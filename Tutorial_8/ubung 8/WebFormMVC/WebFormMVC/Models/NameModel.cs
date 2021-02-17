using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace WebFormMVC.Models
{
    public class NameModel
    {
        protected string myName;
        protected string[] nameList;
        protected string filePath;

        public NameModel()
        {
            myName = "Firstname Secondname";
            nameList = new string[] { "Paul", "Peter" };
            filePath = HostingEnvironment.MapPath("~/names.txt");
            
            if(File.Exists(filePath))
            {
                nameList = File.ReadAllLines(filePath);
            }
        }

        public void StoreNewName(string newName)
        {
            File.AppendAllText(filePath, myName + Environment.NewLine);
        }

       
    }
}