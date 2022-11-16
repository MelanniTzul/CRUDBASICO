using System;
using System.Data;
using System.IO;
namespace CRUD_BASICO
{
    public partial class Form1 : Form
    {
        //DataTable representa una tabla de datos relacionales de la memoria
        DataTable datos = new DataTable();//Cree mi tabla de datos 

        public Form1()
        {
            InitializeComponent();
        }

        //Creacion de columnas
        private void Form1_Load(object sender, EventArgs e)
        {
            datos.Columns.Add("MODELO");
            datos.Columns.Add("NOMBRE");
            datos.Columns.Add("AÑO");
            datos.Columns.Add("DUEÑO");
            datos.Columns.Add("Estado");

            dataGridView.DataSource = datos;//Asignando datos al dataGridView
        }

        //Darle click a la imagen 
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Llene el formulario!");
        }

       

        //Funcion limpiar
        public void limpiartxt()
        {
            foreach (Control crt in this.Controls)
            {
                if (crt is TextBox)
                {
                    crt.Text = string.Empty;
                }
            }
            textBox_modelo.Focus();
        }



        //Guardar datos
        private void button_guardar_Click(object sender, EventArgs e)
        {
            if (textBox_modelo.Text != String.Empty && textBox_nombre.Text != String.Empty && textBox_year.Text != String.Empty && textBox_dueno.Text != String.Empty && textBox_estado.Text != String.Empty)
            {

                //Ingresar datos a la tabla 
                datos.Rows.Add(textBox_modelo.Text, textBox_nombre.Text, textBox_year.Text, textBox_dueno.Text, textBox_estado.Text);
                limpiartxt();
            }
            else
            {
                MessageBox.Show("por favor ingresa todos los datos");
            }

        }



        int index = -1;

        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            //GUARDO EL INDICE SELECCIONADO.
            index = dataGridView.CurrentRow.Index; //obtento el index de la fila que hago doble click

            textBox_modelo.Text = datos.Rows[dataGridView.CurrentRow.Index][0].ToString();
            textBox_nombre.Text = datos.Rows[dataGridView.CurrentRow.Index][1].ToString();
            textBox_year.Text = datos.Rows[dataGridView.CurrentRow.Index][2].ToString();
            textBox_dueno.Text = datos.Rows[dataGridView.CurrentRow.Index][3].ToString();
            textBox_estado.Text = datos.Rows[dataGridView.CurrentRow.Index][4].ToString();

            button_guardar.Enabled = false;
            button1_modificar.Enabled = true;
            button2_eliminar.Enabled = true;
        }

        //Boton modificar
        private void button1_modificar_Click(object sender, EventArgs e)
        {
            datos.Rows[index][0] = textBox_modelo.Text;
            datos.Rows[index][1] = textBox_nombre.Text;
            datos.Rows[index][2] = textBox_year.Text;
            datos.Rows[index][3] = textBox_dueno.Text;
            datos.Rows[index][4] = textBox_estado.Text;

            button_guardar.Enabled = true;
            button1_modificar.Enabled =false;
            button2_eliminar.Enabled = false;
            limpiartxt();
        }


        ///BOTON ELIMINAR
        private void button2_eliminar_Click(object sender, EventArgs e)
        {        
            datos.Rows.RemoveAt(index);
            button_guardar.Enabled = true;
            button2_eliminar.Enabled = false;
            button1_modificar.Enabled = false;
            limpiartxt();
        }

        private void button3_buscar_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2();//creamos una variable y llamamos alformualrio que queremos mostrar
            formulario.Show();//llamamos al Form2
                              
            Clases.variablesGlobales.baseDatosGlobal=datos;

        }

        private void btn_guardar_archivo_Click(object sender, EventArgs e)
        {
            //PARA ESCRIBIR O CREAR ARCHIVOS DE TEXTO 

            string ruta = "C:\\Users\\Melanni Tzul\\Desktop\\Curso .NET\\.Net c#\\CRUD_BASICO\\Nombres.txt";
            StreamWriter sw = new StreamWriter(ruta);

            //Crecorrer o crear el archivo 

            for (int i = 0; i < datos.Rows.Count; i++)
            {
                string linea = datos.Rows[i][0].ToString() + "," + datos.Rows[i][1].ToString() + "," + datos.Rows[i][2].ToString() + "," + datos.Rows[i][3].ToString() + "," + datos.Rows[i][4].ToString();
                sw.WriteLine(linea);
            }
            sw.Close();
        }
    }

}