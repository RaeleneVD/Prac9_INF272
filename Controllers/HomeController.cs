using System;
using System.Collections.Generic;
using System.Data.SqlClient; 
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prac9_INF272_u20467207.Controllers
{
    public class HomeController : Controller
    {
        private SqlConnection myConnection = new SqlConnection(Globals.ConnectionString); //connection instance

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //load pages
        public ActionResult DoInsert()
        {
            return View();
        }
        public ActionResult DoUpdate()
        {
            return View();
        }
        public ActionResult DoDelete()
        {
            return View();
        }

        //action insert, update, delete

        public ActionResult Insert (string name, string clubName, int age, int fee)
        {
            //try and tab twice
            try
            {
                SqlCommand myCommand = new SqlCommand("Insert into MembershipTable1 VALUES('"+name+"', '"+clubName+"', "+age+", "+fee+")", myConnection);
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            { 
                ViewBag.Message = err.Message;
            }
            finally //will always execute at the end
            {
                myConnection.Close();
            }
            return View("Index");
        }

        public ActionResult Update(int id, string name)
        {
            //try and tab twice
            try
            {
                SqlCommand myCommand = new SqlCommand("Update MembershipTable1 SET MembershipTable1_Name = '"+name+"' where MembershipTable1_ID = "+id, myConnection);
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                ViewBag.Message = err.Message;
            }
            finally //will always execute at the end
            {
                myConnection.Close();
            }
            return View("Index");
        }

        public ActionResult Delete(int id)
        {
            //try and tab twice
            try
            {
                SqlCommand myCommand = new SqlCommand("Delete FROM MembershipTable1 WHERE MembershipTable1_ID = "+id, myConnection);
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                ViewBag.Message = err.Message;
            }
            finally //will always execute at the end
            {
                myConnection.Close();
            }
            return View("Index");
        }


    }
}