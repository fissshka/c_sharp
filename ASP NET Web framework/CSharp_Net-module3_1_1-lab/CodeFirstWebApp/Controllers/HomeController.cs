﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFirstDataAccess;
using CodeFirstModel;
using CodeFirstWebApp.Models;

namespace CodeFirstWebApp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            try
            {
                //implementation of IDatabaseInitializer that will delete, recreate,
                //and optionally re-seed the database with data only if the model has changed since the database was created. 
                //This implementation require you to use the type of the Database Context because it’s a generic class. 

                // 5) Use BookEntityContext as type for DropCreateDatabaseIfModelChanges<>
               Database.SetInitializer(new DropCreateDatabaseIfModelChanges<>());
                return View();
            }
            catch (Exception)
            {
                
                throw;
            }
           
        }

        /// <summary>
        /// Get book details
        /// </summary>
        /// <returns></returns>
        public ActionResult GetBookDetails()
        {
            // 6) Declare list of BookModel
            
            try
            {
                // 7) Declare new BookEntityContext in using block
                using ()
                {
                    // 8) Use method ToList() for books from context;
                    // save result to variable value

                    // 9) In foreach loop 'in value' declare new BookModel
                    // and save Name (and other properties) of book (foreach variable) to declared new BookModel
                    foreach (var book in value)
                    {
                       
                       
                        // 10) Invloke method Add() from list of BookModel with parameter object of BookModel
                        
                    }
                }
            }
            catch (Exception)
            {
                
                throw;
            }

            // model - list of BookModel
            return PartialView("_BookDetailView", model);
        }

        /// <summary>
        /// populate some hardcoded value in book table
        /// </summary>
        public ActionResult InsertBookDetail()
        {
            try
            {
                for (int counter = 0; counter < 5; counter++)
                {
                    // 11) Declare new Book with name of property as string value and concatenate it with counter
                   
                   // book - new declared Book
                    using (var context = new BookEntityContext())
                    {
                        context.Books.Add(book);
                        context.SaveChanges();
                    }
                }
               
            }
            catch (Exception)
            {
                throw;
            }
            return Json(true);
        }

    }
}
