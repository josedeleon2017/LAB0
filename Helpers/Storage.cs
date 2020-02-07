using System;
using System.Collections.Generic;
using LAB0_0.Models;
using System.Linq;
using System.Web;

namespace LAB0_0.Helpers
{
    public class Storage
    {
        private static Storage _instance = null;

        public static Storage Instance
        {
            get
            {
                if (_instance == null) _instance = new Storage();
                return _instance;
            }
        }

        public List<PersonModel> personList = new List<PersonModel>();
       

    }
}