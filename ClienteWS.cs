using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AgendaOnline.com.somee.pogramaweb2023;

namespace AgendaOnline
{
    /*
     Dentro de esta clase crearemos 
    cada uno de los metodos correspondientes a los respectivos 
    webmethod del servicio web
     */
    class ClienteWS
    {
        //Almacenar las credenciales
        public static string Email = "";
        public static string Pass = "";
        //Instanciar el servicio web
        public static com.somee.pogramaweb2023.AgendaOnlineWS Servicio = new com.somee.pogramaweb2023.AgendaOnlineWS();

        //Definimos los metetodos que funcionaran como interfaces

        public static bool CrearUsuario(string Nombre, string Apellido, string Telf, string Email, string Pass)
        {
            return Servicio.CreateUser(Nombre, Apellido, Email, Telf, Pass);
        }

        public int IniciarSesion(string Email, string Pass)
        {
            return Servicio.Logueo(Email, Pass);
        }

        public bool CrearGrupo(string Email, string Pass, string NombreGrupo, string Color)
        {
            return Servicio.CrearGrupo(Email, Pass, NombreGrupo, Color);
        }

        public bool CrearContacto(string Email, string Pass, int idGrupo, ContactoWS Contacto)
        {
            return Servicio.CrearContacto(Email, Pass, idGrupo, Contacto);
        }

        public List<GrupoWS> ListarGrupos(string Email, string Pass)
        {
            return Servicio.ListarGrupos(Email, Pass).ToList();
        }

        public List<ContactoWS> ListarContactos(string Email, string Pass, int idGrupo)
        {
            return Servicio.ListarContactos(Email, Pass, idGrupo).ToList();
        }
    }
}