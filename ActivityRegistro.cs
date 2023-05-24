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
using Android.Widget;

namespace AgendaOnline
{
    [Activity(Label = "ActivityRegistro")]
    public class ActivityRegistro : Activity
    {
        EditText Nombre, Apellido, Telf, Email, Pass, RePass;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.registro);
            //Validamos las contraseñas
            Pass = FindViewById<EditText>(Resource.Id.editText4);
            RePass = FindViewById<EditText>(Resource.Id.editText6);

            if(Pass.Text==RePass.Text)
            {
                //Vinculamos las instancias de variables con los controles
                Nombre= FindViewById<EditText>(Resource.Id.editText1);
                Apellido = FindViewById<EditText>(Resource.Id.editText2);
                Email = FindViewById<EditText>(Resource.Id.editText3);
                Telf = FindViewById<EditText>(Resource.Id.editText5);

                //Invocamos el metodo para registrar
               // ClienteWS C = new ClienteWS();//Con instanciamiento de la clase
                
               if(ClienteWS.CrearUsuario(Nombre.Text, Apellido.Text,Telf.Text,Email.Text,Pass.Text))
                {
                    Toast.MakeText(this, "Se ha registrado con Exito", ToastLength.Long).Show();
                    ClienteWS.Email = Email.Text;
                    ClienteWS.Pass = Pass.Text;
                }
               else
                {
                    Toast.MakeText(this, "No se realizo el registro", ToastLength.Long).Show();
                }

            }
            else
            {
                Toast.MakeText(this, "Contraseñas no coinciden, vuela a intentar ", ToastLength.Long).Show();
            }
        }
    }
}