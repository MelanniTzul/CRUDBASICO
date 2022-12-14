using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.ApplicationServices;

namespace CRUD_BASICO
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
  
        DataTable datos = Clases.variablesGlobales.baseDatosGlobal;//Creamos tabla por medio de una clase
        private void text_buscador_TextChanged(object sender, EventArgs e)
        {
            //Mi variableglobal le asigno los datos que de mi tabla que ya tengo  
            Clases.variablesGlobales.baseDatosGlobal = datos;

        }

        private void Form2_Load(object sender, EventArgs e)
        {         
            dataGridView_busqueda.DataSource = datos;//Asignando datos al dataGridView
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();//cerrar ventana
        }


        
        //Boton buscar en los datos registrados
        private void button_Buscar_Click(object sender, EventArgs e)
        {
            if(checkBox_nombre.Checked)//Si es true
            {
                //Buscar por nombre
                //corremos datos
                for (int i =0; i<datos.Rows.Count; i++)
                {
                    if (datos.Rows[i][1].ToString().Contains(txt_buscador.Text))
                    {
                        lbl_carroSeleccionado.Text = datos.Rows[i][0].ToString() + " " + datos.Rows[i][1].ToString() + " " + datos.Rows[i][2].ToString() + " " + datos.Rows[i][3].ToString() + " " + datos.Rows[i][4].ToString() + " " + datos.Rows[i][5].ToString();
                    }
                    else if (datos.Rows[i][2].ToString().Contains(txt_buscador.Text))
                    {
                        lbl_carroSeleccionado.Text = datos.Rows[i][0].ToString() + " " + datos.Rows[i][1].ToString() + " " + datos.Rows[i][2].ToString() + " " + datos.Rows[i][3].ToString() + " " + datos.Rows[i][4].ToString() + " " + datos.Rows[i][5].ToString();
                    }
                    else if (datos.Rows[i][3].ToString().Contains(txt_buscador.Text))
                    {
                        lbl_carroSeleccionado.Text = datos.Rows[i][0].ToString() + " " + datos.Rows[i][1].ToString() + " " + datos.Rows[i][2].ToString() + "-" + datos.Rows[i][3].ToString() + " " + datos.Rows[i][4].ToString() + " " + datos.Rows[i][5].ToString();
                    }
                    else if (datos.Rows[i][4].ToString().Contains(txt_buscador.Text))
                    {
                        lbl_carroSeleccionado.Text = datos.Rows[i][0].ToString() + " " + datos.Rows[i][1].ToString() + " " + datos.Rows[i][2].ToString() + "-" + datos.Rows[i][3].ToString() + " " + datos.Rows[i][4].ToString() + " " + datos.Rows[i][5].ToString();
                    }
                    else if(datos.Rows[i][5].ToString().Contains(txt_buscador.Text))
                    {
                        lbl_carroSeleccionado.Text = datos.Rows[i][0].ToString() + " " + datos.Rows[i][1].ToString() + " " + datos.Rows[i][2].ToString() + "-" + datos.Rows[i][3].ToString() + " " + datos.Rows[i][4].ToString() + " " + datos.Rows[i][5].ToString();
                    }
                }               
            }
            else 
            {
                //Buscar por placa
                if (txt_buscador.Text != String.Empty)//lo hace si encuentra datos
                {
                    //Recorrer base de datos
                    for (int i = 0; i < datos.Rows.Count; i++)
                    {
                        if (datos.Rows[i][0].ToString() == txt_buscador.Text)
                        {                          
                            lbl_carroSeleccionado.Text = datos.Rows[i][0].ToString() + "-" + datos.Rows[i][1].ToString() + "-" + datos.Rows[i][2].ToString() + "-" + datos.Rows[i][3].ToString() + "-" + datos.Rows[i][4].ToString() + "-" + datos.Rows[i][5].ToString();
                        }
                    }
                }

            }

           
        }
       
    }
}
