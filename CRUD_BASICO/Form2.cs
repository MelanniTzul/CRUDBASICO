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

namespace CRUD_BASICO
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        DataTable datos = new DataTable();//Cree mi tabla de datos 
        private void text_buscador_TextChanged(object sender, EventArgs e)
        {



        }

        private void Form2_Load(object sender, EventArgs e)
        {
            datos.Columns.Add("MODELO");
            datos.Columns.Add("NOMBRE");
            datos.Columns.Add("AÑO");
            datos.Columns.Add("DUEÑO");
            datos.Columns.Add("Estado");

            dataGridView_busqueda.DataSource = datos;//Asignando datos al dataGridView
            btn_cargarArchivo.PerformClick();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cargarArchivo_Click(object sender, EventArgs e)
        {
            //PARA LEER EL ARCHIVO           
            String ruta = "C:\\Users\\Melanni Tzul\\Desktop\\Curso .NET\\.Net c#\\CRUD_BASICO\\Nombres.txt";
            StreamReader sr = new StreamReader(ruta); //permite leer y encontrar el archivo

            while (!sr.EndOfStream)//mientras no sea el final de linea entra
            {
                string linea = sr.ReadLine();//Lee la linea
                string[] aux = linea.Split(',');//separa la cadena por coma crea un vector y los almacena en posiciones

                //Llenar dataGridView
                datos.Rows.Add(aux[0], aux[1], aux[2], aux[3], aux[4]);


            }
            dataGridView_busqueda.DataSource = datos;
            sr.Close();

        }
    }
}
