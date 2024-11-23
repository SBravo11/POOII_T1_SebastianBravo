using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using POOII_T1_SebastianBravo.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Globalization;
using System.Web.Services.Description;

namespace POOII_T1_SebastianBravo.Controllers
{
    public class AlumnoController : Controller
    {

        IEnumerable<Alumno> alumnos()
        {
            List<Alumno> temp = new List<Alumno>();
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbSql"].ConnectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("exec usp_getallstudents", cn);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    temp.Add(new Alumno()
                    {
                        Id = dr.GetInt32(0),
                        Name = dr.GetString(1),
                        LastName = dr.GetString(2),
                        DNI = dr.GetString(3),
                        RegisterDate = dr.GetDateTime(4),
                        Birthday = dr.GetDateTime(5),
                        Cellphone = dr.GetString(6),
                        Address = dr.GetString(7)
                    });
                }
                cn.Close();
            }
            return temp;
        }
        public ActionResult Create()
        {
            return View(new Alumno());
        }
        [HttpPost]
        public ActionResult Create(Alumno reg)
        {
            if (!ModelState.IsValid)
            {
                return View(reg);
            }
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbSql"].ConnectionString))
            {
                ViewBag.mensaje = "";
                cn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("exec usp_savestudent @Name, @LastName, @DNI, @RegisterDate, @Birthday, @Cellphone, @Address", cn);
                    cmd.Parameters.AddWithValue("@Name", reg.Name);
                    cmd.Parameters.AddWithValue("@LastName", reg.LastName);
                    cmd.Parameters.AddWithValue("@DNI", reg.DNI);
                    cmd.Parameters.AddWithValue("@RegisterDate", reg.RegisterDate);
                    cmd.Parameters.AddWithValue("@Birthday", reg.Birthday);
                    cmd.Parameters.AddWithValue("@Cellphone", reg.Cellphone);
                    cmd.Parameters.AddWithValue("@Address", reg.Address);

                    int cont = cmd.ExecuteNonQuery();
                    ViewBag.mensaje = "Se ha registrado el alumno con exito!";
                }
                catch (Exception ex)
                {
                    ViewBag.mensaje = ex.Message;
                }
                finally
                {
                    cn.Close();
                }
            }
            return View(reg);
        }
        // GET: Alumno
        public ActionResult ListaAlumnos()
        {
            return View(alumnos());
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}