using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using CSF.ModelValidator;

namespace Demo_ModelValidator
{
    class Program
    {
        static ModelState modelstatus = new ModelState();
        static void Main(string[] args)
        {

            var reco = new Person { ID = "F123456789", Age = -9, CName = "康文龍", Mobile = "0922626523", EMail = "reco@mail.csf.org.tw" };
            if (modelstatus.IsVaild<Person>(reco) == true)
            {
                Console.WriteLine("OK");
            }
            else
            {
                foreach (var item in modelstatus.MemberNames)
                {
                    Console.WriteLine(item);
                }
            }
            //modelstatus.AddModelError("test0000");
            Console.WriteLine(modelstatus["Age"]);
            Console.WriteLine(modelstatus.ModelErrorMessage);
            Console.ReadLine();
        }
    }

    public class Person
    {
        public string ID { get; set; }
        [Chinese]
        public string CName { get; set; }
        [Age]
        public int Age { get; set; }
        [Mobile]
        public string Mobile { get; set; }
        [Email]
        public string EMail { get; set; }
    }
}
