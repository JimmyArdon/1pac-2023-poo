using Microsoft.AspNetCore.Mvc;
using MayaMobile.Models;
using System.Security.Cryptography;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Data.SqlClient;


namespace MayaMobile.Controllers
{
    public class LoginController : Controller
    {

        private readonly IHttpContextAccessor _httpContextAccessor;

        public LoginController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        static string cadena = "Server=DESKTOP-L0SSA1J;Database=DB_ACCESO;User Id=sa;Password=volleyball03;TrustServerCertificate=true;";


        [HttpGet]

        public ActionResult Acceso()
        {
            return View();
        }

        public IActionResult Registrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registrar(Usuario usuario)
        {
            bool resgitrado;
            string mensaje;

            if (string.IsNullOrEmpty(usuario.Clave) || string.IsNullOrEmpty(usuario.ConfirmarClave))
            {
                ViewData["Mensaje"] = "Por favor, complete los campos de contraseña.";
                return View();
            }


            if (usuario.Clave == usuario.ConfirmarClave)
            {
                usuario.Clave = ConvertirSha256(usuario.Clave);
                usuario.ConfirmarClave = ConvertirSha256(usuario.ConfirmarClave);

            }
            else
            {
                ViewData["Mensaje"] = "Las contraseñas no coinciden";
                return View();
            }

            using (SqlConnection cn = new SqlConnection(cadena))
            {
                SqlCommand cmd = new SqlCommand("sp_RegistrarUsuario", cn);
                cmd.Parameters.AddWithValue("Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("Usuario", usuario.Usuarios);
                cmd.Parameters.AddWithValue("Correo", usuario.Correo);
                cmd.Parameters.AddWithValue("Telefono", usuario.Telefono);
                cmd.Parameters.AddWithValue("Clave", usuario.Clave);
                cmd.Parameters.AddWithValue("ConfirmarClave", usuario.ConfirmarClave);
                cmd.Parameters.Add("Registrado",SqlDbType.Bit).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("Mensaje",SqlDbType.VarChar,100).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();

                cmd.ExecuteNonQuery();

                resgitrado = Convert.ToBoolean(cmd.Parameters["Registrado"].Value);
                mensaje = cmd.Parameters["Mensaje"].Value.ToString();
            }

            ViewData["Mensaje"] = mensaje;
            if (resgitrado)
            {
                return(RedirectToAction("Login","Acceso"));
            }
            else
            {
                return View();
            }
           
        }

        [HttpPost]
        public IActionResult Acceso(UsuarioLogin usuario)
        {
            if (usuario == null || string.IsNullOrEmpty(usuario.Clave) || string.IsNullOrEmpty(usuario.Correo))
            {
                ViewData["Mensaje"] = "Por favor,complete espacios vacios.";
                return View();
            }

            usuario.Clave = ConvertirSha256(usuario.Clave);

            using (SqlConnection cn = new SqlConnection(cadena))
            {
                SqlCommand cmd = new SqlCommand("sp_ValidarUsuario", cn);
                cmd.Parameters.AddWithValue("Correo", usuario.Correo);
                cmd.Parameters.AddWithValue("Clave", usuario.Clave);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();

                usuario.Id = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            }

            if (usuario.Id != 0)
            {
                var session = _httpContextAccessor.HttpContext.Session;
                session.SetString("usuario", usuario.Correo);
                return RedirectToAction("Index", "Inicio");
            }
            else
            {
                ViewData["Mensaje"] = "Usuario no Encontrado";
                return View();
            }
        }



        public IActionResult Index()
        {
            return View();
        }

        public static string ConvertirSha256 (string texto)
        {
            StringBuilder Sb = new StringBuilder ();
            using (SHA256 hash = SHA256Managed.Create()) { 
            Encoding encoding= Encoding.UTF8;
                byte[] result = hash.ComputeHash(encoding.GetBytes(texto));
                foreach (byte b in result)
                {
                    Sb.Append (b.ToString("x2"));
                }

            }
            return Sb.ToString ();
        }
    }
}
