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
        //DataTable datos = new DataTable();//Cree mi tabla de datos 
        DataTable datos = Clases.variablesGlobales.baseDatosGlobal;//Creamos tabla por medio de una clase
        private void text_buscador_TextChanged(object sender, EventArgs e)
        {
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


        private void btn_cargarArchivo_Click(object sender, EventArgs e)
        {
            
            //PARA LEER EL ARCHIVO           
            String ruta = "C:\\Users\\Melanni Tzul\\Desktop\\Curso .NET\\Net c#\\CRUD_BASICO\\Nombres.txt";
            StreamReader sr = new StreamReader(ruta); //permite leer y encontrar el archivo

            while (!sr.EndOfStream)//mientras no sea el final de linea entra
            {
                string linea = sr.ReadLine();//Lee la linea
                string[] aux = linea.Split(',');//separa la cadena por coma crea un vector y los almacena en posiciones

                //Llenar dataGridView
                datos.Rows.Add(aux[0], aux[1], aux[2], aux[3], aux[4], aux[5]);


            }
            dataGridView_busqueda.DataSource = datos;
            sr.Close();

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
                           // lbl_carroSeleccionado.Text = txt_buscador.Text;
                             //lbl_carroSeleccionado.Text = datos.Rows[i][0].ToString();
                            lbl_carroSeleccionado.Text = datos.Rows[i][0].ToString() + "-" + datos.Rows[i][1].ToString() + "-" + datos.Rows[i][2].ToString() + "-" + datos.Rows[i][3].ToString() + "-" + datos.Rows[i][4].ToString() + "-" + datos.Rows[i][5].ToString();
                        }
                    }
                }

            }

           
        }
       
    }
}
