using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using PvTerrenos.WSpvt;

namespace PvTerrenos
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void cmdIncioSecion_Click(object sender, EventArgs e)
        {
            string mail = Convert.ToString(txtUsuario.Text);
            string contraseña = Convert.ToString(txtContraseña.Text);

            //XDocument usuarioXML = new XDocument(
              //  new XDeclaration("1.0", "utf-8", "yes"),
                //new XComment("Inicio Sesion"),
                //new XElement("Sesion",
                  //                    new XElement("Sesion",
                    //                      new XAttribute(mail, contraseña))
                      //                    )
                        //                  );
            //usuarioXML.Save(@"c:\usuario.xml");
            //WSpvt.loginCompletedEventArgs iniciarSesion = new WSpvt.loginCompletedEventArgs();
           // loginCompletedEventHandler iniciarSesion = new loginCompletedEventHandler();
     

            WSpvt.PVT ws = new WSpvt.PVT();
            String resp = ws.login(mail, contraseña);
            MessageBox.Show(resp);
        }
    }
}
