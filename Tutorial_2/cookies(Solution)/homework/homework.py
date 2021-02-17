#!/usr/bin/env python

import sys, socket

def create_error_page(conn, err_string):
    conn.send('HTTP/1.1 200 OK\r\n')
    conn.send('Connection: close\r\n')
    conn.send('Content-Type: text/html\r\n\r\n')
    conn.send('<html><head><title>ERROR</title></head>\r\n')
    conn.send('<body><h1>Error</h1><hr/><p>%s</p></body></html>'%(err_string))
    conn.close()

def getCookieData(data,cookie): 
    clines = data.split('; ')
    for cline in clines[0:]:
        ckey, cvalue = cline.split('=')
        cookie[ckey] = cvalue

def handleRequest(conn):
    data = conn.recv(1024)
    dataStr = repr(data) 
    datas = dataStr[2:-1]
    head,body = datas.split('\\r\\n\\r\\n')
    header = {}
    values = {}
    cookie = {}
    lines = head.split('\\r\\n')
    for line in lines[1:]:
        key, value = line.split(': ')
        header[key] = value

    #TODO: get cookie information
    
    if body:
        pairs = body.split('&')
        for pair in pairs:
            key, value = pair.split('=')
            values[key] = value

    try:
        getCookieData(header['Cookie'],cookie)
        kontostand = float(cookie['kontostand'])
    except:
        kontostand = 100
    
    if 'amount' in values:
        try:
            amount = float(values['amount'])
        except:
            create_error_page(conn, "%s ist kein Fliesskommawert"%(values['amount']))
            return
        kontostand -= amount

    print(kontostand)

    conn.send('HTTP/1.1 200 OK\r\n'.encode('ascii'))
    conn.send('Connection: close\r\n'.encode('ascii'))
    conn.send('Set-Cookie: kontostand= %5.2f\r\n'.encode('ascii') %(kontostand))
    conn.send('Content-Type: text/html\r\n\r\n'.encode('ascii'))
    conn.send('<html><head><title>Konto</title></head>\r\n'.encode('ascii'))
    conn.send('<body><h1>Konto</h1><hr/>\r\n'.encode('ascii'))
    if 'amount' in values:
        conn.send('<p>berwiesen = %5.2f</p>\r\n'.encode() %(amount))
    conn.send('<p>Neuer Kontostand = %5.2f</p>\r\n'.encode('ascii') %(kontostand))
    conn.send('<form method="POST">\r\n'.encode('ascii'))
    conn.send('<p>Betrag zum berweisen: <input type="text" name="amount"/></p>\r\n'.encode())
    conn.send('<p><input type="submit" value="Abschicken"/></p>\r\n'.encode('ascii'))
    conn.send('</form>\r\n'.encode('ascii'))
    conn.send('</body></html>\r\n'.encode('ascii'))
    conn.close()
    return

KONTOSTANDFILE = 'account.txt'

TCP_IP = ''
TCP_PORT = 5000

s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
s.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
s.bind((TCP_IP, TCP_PORT))
s.listen(1)

while 1:
    conn, addr = s.accept()
    handleRequest(conn)
