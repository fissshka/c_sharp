using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CSharp_Net_module3_1_1_lab.Models;

namespace CSharp_Net_module3_1_1_lab.Controllers
{
    public class BookController : Controller
    {
        // 8) Declate public static object of Books
       
        
        // 9) Add view Index.cshtml to action method Index();
        // add new folder 'Book' to 'View';
        // use context menu on Index() -> Add View...;
        // select "List" template and BookModels as model
        
        // Note: Don't use DBContext
        //
        // GET: /Book/
        public ActionResult Index()
        {
            // 10) Add parameter of View(); it must be the list of books
            return View();
        }

        // 11) Change parameters if it is necessary
        public ActionResult AddBook()
        {
            return View();
        }

        // 12) Add HttpPost attribute
    
        // 13) Add parameter - object of BookModels
        public ActionResult AddBook()
        {
            // 14) Invoke AddBook() method of book list
            
            return RedirectToAction("Index");
        
        }
	}
}