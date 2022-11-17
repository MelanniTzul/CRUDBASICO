using System;
using System.Data;
using System.IO;
namespace CRUD_BASICO
{
    public partial class Form1 : Form
    {
        //DataTable representa una tabla de datos relacionales de la memoria
        //DataTable datos = new DataTable();//Cree mi tabla de datos 
        DataTable datos = Clases.variablesGlobales.baseDatosGlobal;//tabla creada por medio de una clase

        public Form1()
        {
            InitializeComponent();
        }

        //Funcion que lee el archivo
        public void mostrarDatosEnTabla()
        {
            //PARA LEER EL ARCHIVO           
            String ruta = "C:\\Users\\Melanni Tzul\\Desktop\\Curso .NET\\Net c#\\CRUD_BASICO\\Nombres.txt";
            StreamReader sr = new StreamReader(ruta); //permite leer y encontrar el archivo

            while (!sr.EndOfStream)//mientras no sea el final de linea entra
            {
                string linea = sr.ReadLine();//Lee la linea
                string[] aux = linea.Split(',');//separa la cadena por coma crea un vector y los almacena en posiciones

                //Llenar dataGridView
                datos.Rows.Add(aux[0], aux[1], aux[2], aux[3], aux[4]);


            }
            dataGridView.DataSource = datos;
            sr.Close();
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
            mostrarDatosEnTabla();//leemos el archivo al ejecutarse
        }

        //Darle click a la imagen 
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Llene el formulario!");
        }

        //Funcion limpiar
        public void limpiartxt()
        {
            foreach (Control crt in this.Controls) //Corre todo lo que sea text, btn etc
            {
                if (crt is TextBox)
                {
                    crt.Text = string.Empty;//vaciar
                }
            }
            textBox_modelo.Focus();//Regresa el cursor a mi text principal
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



        int index = -1;//variable que permite hubicarme inicializa el indice

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

        //Boton que nos dirige al otro form
        private void button3_buscar_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2();//creamos una variable y llamamos alformualrio que queremos mostrar
            formulario.Show();//llamamos al Form2

            //Mi variableglobal le asigno los datos que de mi tabla que ya tengo aqui                  
            Clases.variablesGlobales.baseDatosGlobal=datos;//le paso mis datos de mi tabla a la variable global 

        }

        private void btn_guardar_archivo_Click(object sender, EventArgs e)
        {
            //PARA ESCRIBIR O CREAR ARCHIVOS DE TEXTO 

            string ruta = "C:\\Users\\Melanni Tzul\\Desktop\\Curso .NET\\Net c#\\CRUD_BASICO\\Nombres.txt";
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