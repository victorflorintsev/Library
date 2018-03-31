using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Controllers
{
    public class DefaultController : Controller
    {
        static void Main(string[] args)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                // Create the connectionString
                // Trusted_Connection is used to denote the connection uses Windows Authentication
                Console.WriteLine("Server");
                conn.ConnectionString = "Server=den1.mssql4.gear.host;Database=cosc3380;Uid=cosc3380;Pwd=vfegaf$;";
                conn.Open();
                // Create the command
                SqlCommand command = new SqlCommand("SELECT TOP (1000) [Username_ID],[Hashed_Password],[Failed_Attempts],[Username_String],[Last_Login_Attempt]FROM[cosc3380].[LIBDB].[USERS]", conn);
                // Add the parameters.
                command.Parameters.Add(new SqlParameter("0", 1));

                /* Get the rows and display on the screen! 
                * This section of the code has the basic code
                * that will display the content from the Database Table
                * on the screen using an SqlDataReader. */
            }
        }
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        // GET: Default/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Default/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Default/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Default/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Default/Edit/5
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

        // GET: Default/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Default/Delete/5
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
