using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using LAB0_0.Helpers;
using LAB0_0.Models;


namespace LAB0_0.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {           
            return View(Storage.Instance.personList);
        }

        public ActionResult SortByName()
        {
            try
            {
                //ORDER BY NAME
                int CountElement = Storage.Instance.personList.Count;
                PersonModel[] ArrayList = new PersonModel[CountElement];
                ArrayList = Storage.Instance.personList.ToArray();

                string tmpName, tmpLName,tmpDesc;
                int tmpPhone;
                for (int i = 0; i < CountElement - 1; i++)
                {
                    for (int j = i + 1; j < CountElement; j++)
                    {
                        if (string.Compare(ArrayList[i].Name, ArrayList[j].Name) == 1)
                        {
                            tmpName = ArrayList[i].Name;
                            tmpLName = ArrayList[i].LastName;
                            tmpPhone = ArrayList[i].Phone;
                            tmpDesc = ArrayList[i].Description;

                            ArrayList[i].Name = ArrayList[j].Name;
                            ArrayList[i].LastName = ArrayList[j].LastName;
                            ArrayList[i].Phone = ArrayList[j].Phone;
                            ArrayList[i].Description = ArrayList[j].Description;

                            ArrayList[j].Name = tmpName;
                            ArrayList[j].LastName = tmpLName;
                            ArrayList[j].Phone = tmpPhone;
                            ArrayList[j].Description = tmpDesc;
                        }
                    }
                }

                return View(Storage.Instance.personList);
            }
            catch 
            {
                return View();
            }
        }

        public ActionResult SortByLastName()
        {
            try
            {
                //ORDER BY LAST NAME
                int CountElement = Storage.Instance.personList.Count;
                PersonModel[] ArrayList = new PersonModel[CountElement];
                ArrayList = Storage.Instance.personList.ToArray();

                string tmpName, tmpLName, tmpDesc;
                int tmpPhone;
                for (int i = 0; i < CountElement - 1; i++)
                {
                    for (int j = i + 1; j < CountElement; j++)
                    {
                        if (string.Compare(ArrayList[i].LastName, ArrayList[j].LastName) == 1)
                        {
                            tmpName = ArrayList[i].Name;
                            tmpLName = ArrayList[i].LastName;
                            tmpPhone = ArrayList[i].Phone;
                            tmpDesc = ArrayList[i].Description;

                            ArrayList[i].Name = ArrayList[j].Name;
                            ArrayList[i].LastName = ArrayList[j].LastName;
                            ArrayList[i].Phone = ArrayList[j].Phone;
                            ArrayList[i].Description = ArrayList[j].Description;

                            ArrayList[j].Name = tmpName;
                            ArrayList[j].LastName = tmpLName;
                            ArrayList[j].Phone = tmpPhone;
                            ArrayList[j].Description = tmpDesc;
                        }
                    }
                }

                return View(Storage.Instance.personList);
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                var person = new PersonModel
                {
                    Name = collection["Name"],
                    LastName = collection["LastName"],
                    Phone = int.Parse(collection["Phone"]),
                    Description = collection["Description"],                
                 };

                if (person.Save())
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(person);
                }
       
            }
            catch
            {
                return View();
            }
        }

            // GET: Person/Edit/5
            public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Person/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Person/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
