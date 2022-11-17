namespace CRUD_BASICO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_modelo = new System.Windows.Forms.Label();
            this.textBox_modelo = new System.Windows.Forms.TextBox();
            this.label_nombre = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.label_year = new System.Windows.Forms.Label();
            this.textBox_year = new System.Windows.Forms.TextBox();
            this.label_dueno = new System.Windows.Forms.Label();
            this.textBox_dueno = new System.Windows.Forms.TextBox();
            this.label_estado = new System.Windows.Forms.Label();
            this.textBox_estado = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.button_guardar = new System.Windows.Forms.Button();
            this.button1_modificar = new System.Windows.Forms.Button();
            this.button2_eliminar = new System.Windows.Forms.Button();
            this.button3_buscar = new System.Windows.Forms.Button();
            this.btn_guardar_archivo = new System.Windows.Forms.Button();
            this.lbl_placa = new System.Windows.Forms.Label();
            this.txt_placa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORMULARIO DE REGISTRO DE VEHICULOS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1186, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 2;
            // 
            // label_modelo
            // 
            this.label_modelo.AutoSize = true;
            this.label_modelo.Location = new System.Drawing.Point(2, 147);
            this.label_modelo.Name = "label_modelo";
            this.label_modelo.Size = new System.Drawing.Size(66, 20);
            this.label_modelo.TabIndex = 3;
            this.label_modelo.Text = "Modelo:";
            // 
            // textBox_modelo
            // 
            this.textBox_modelo.Location = new System.Drawing.Point(93, 144);
            this.textBox_modelo.Name = "textBox_modelo";
            this.textBox_modelo.Size = new System.Drawing.Size(247, 27);
            this.textBox_modelo.TabIndex = 4;
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(2, 198);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(71, 20);
            this.label_nombre.TabIndex = 5;
            this.label_nombre.Text = "Nombre:";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(93, 198);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(247, 27);
            this.textBox_nombre.TabIndex = 7;
            // 
            // label_year
            // 
            this.label_year.AutoSize = true;
            this.label_year.Location = new System.Drawing.Point(2, 264);
            this.label_year.Name = "label_year";
            this.label_year.Size = new System.Drawing.Size(42, 20);
            this.label_year.TabIndex = 8;
            this.label_year.Text = "Año:";
            // 
            // textBox_year
            // 
            this.textBox_year.Location = new System.Drawing.Point(93, 261);
            this.textBox_year.Name = "textBox_year";
            this.textBox_year.Size = new System.Drawing.Size(247, 27);
            this.textBox_year.TabIndex = 9;
            // 
            // label_dueno
            // 
            this.label_dueno.AutoSize = true;
            this.label_dueno.Location = new System.Drawing.Point(2, 320);
            this.label_dueno.Name = "label_dueno";
            this.label_dueno.Size = new System.Drawing.Size(59, 20);
            this.label_dueno.TabIndex = 10;
            this.label_dueno.Text = "Dueño:";
            // 
            // textBox_dueno
            // 
            this.textBox_dueno.Location = new System.Drawing.Point(93, 320);
            this.textBox_dueno.Name = "textBox_dueno";
            this.textBox_dueno.Size = new System.Drawing.Size(247, 27);
            this.textBox_dueno.TabIndex = 11;
            // 
            // label_estado
            // 
            this.label_estado.AutoSize = true;
            this.label_estado.Location = new System.Drawing.Point(6, 390);
            this.label_estado.Name = "label_estado";
            this.label_estado.Size = new System.Drawing.Size(60, 20);
            this.label_estado.TabIndex = 12;
            this.label_estado.Text = "Estado:";
            // 
            // textBox_estado
            // 
            this.textBox_estado.Location = new System.Drawing.Point(93, 387);
            this.textBox_estado.Name = "textBox_estado";
            this.textBox_estado.Size = new System.Drawing.Size(247, 27);
            this.textBox_estado.TabIndex = 13;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(371, 104);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(791, 310);
            this.dataGridView.TabIndex = 14;
            this.dataGridView.DoubleClick += new System.EventHandler(this.dataGridView_DoubleClick);
            // 
            // button_guardar
            // 
            this.button_guardar.Location = new System.Drawing.Point(146, 450);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(94, 29);
            this.button_guardar.TabIndex = 15;
            this.button_guardar.Text = "GUARDAR";
            this.button_guardar.UseVisualStyleBackColor = true;
            this.button_guardar.Click += new System.EventHandler(this.button_guardar_Click);
            // 
            // button1_modificar
            // 
            this.button1_modificar.Location = new System.Drawing.Point(1186, 142);
            this.button1_modificar.Name = "button1_modificar";
            this.button1_modificar.Size = new System.Drawing.Size(94, 29);
            this.button1_modificar.TabIndex = 16;
            this.button1_modificar.Text = "MODIFICAR";
            this.button1_modificar.UseVisualStyleBackColor = true;
            this.button1_modificar.Click += new System.EventHandler(this.button1_modificar_Click);
            // 
            // button2_eliminar
            // 
            this.button2_eliminar.Location = new System.Drawing.Point(1186, 212);
            this.button2_eliminar.Name = "button2_eliminar";
            this.button2_eliminar.Size = new System.Drawing.Size(94, 29);
            this.button2_eliminar.TabIndex = 17;
            this.button2_eliminar.Text = "ELIMINAR";
            this.button2_eliminar.UseVisualStyleBackColor = true;
            this.button2_eliminar.Click += new System.EventHandler(this.button2_eliminar_Click);
            // 
            // button3_buscar
            // 
            this.button3_buscar.Location = new System.Drawing.Point(1186, 381);
            this.button3_buscar.Name = "button3_buscar";
            this.button3_buscar.Size = new System.Drawing.Size(94, 29);
            this.button3_buscar.TabIndex = 18;
            this.button3_buscar.Text = "BUSCAR";
            this.button3_buscar.UseVisualStyleBackColor = true;
            this.button3_buscar.Click += new System.EventHandler(this.button3_buscar_Click);
            // 
            // btn_guardar_archivo
            // 
            this.btn_guardar_archivo.Location = new System.Drawing.Point(1186, 282);
            this.btn_guardar_archivo.Name = "btn_guardar_archivo";
            this.btn_guardar_archivo.Size = new System.Drawing.Size(94, 58);
            this.btn_guardar_archivo.TabIndex = 19;
            this.btn_guardar_archivo.Text = "GUARDAR DATOS";
            this.btn_guardar_archivo.UseVisualStyleBackColor = true;
            this.btn_guardar_archivo.Click += new System.EventHandler(this.btn_guardar_archivo_Click);
            // 
            // lbl_placa
            // 
            this.lbl_placa.AutoSize = true;
            this.lbl_placa.Location = new System.Drawing.Point(2, 95);
            this.lbl_placa.Name = "lbl_placa";
            this.lbl_placa.Size = new System.Drawing.Size(45, 20);
            this.lbl_placa.TabIndex = 20;
            this.lbl_placa.Text = "Placa";
            // 
            // txt_placa
            // 
            this.txt_placa.Location = new System.Drawing.Point(93, 95);
            this.txt_placa.Name = "txt_placa";
            this.txt_placa.Size = new System.Drawing.Size(247, 27);
            this.txt_placa.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 511);
            this.Controls.Add(this.txt_placa);
            this.Controls.Add(this.lbl_placa);
            this.Controls.Add(this.btn_guardar_archivo);
            this.Controls.Add(this.button3_buscar);
            this.Controls.Add(this.button2_eliminar);
            this.Controls.Add(this.button1_modificar);
            this.Controls.Add(this.button_guardar);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.textBox_estado);
            this.Controls.Add(this.label_estado);
            this.Controls.Add(this.textBox_dueno);
            this.Controls.Add(this.label_dueno);
            this.Controls.Add(this.textBox_year);
            this.Controls.Add(this.label_year);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.textBox_modelo);
            this.Controls.Add(this.label_modelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Registro de vehículos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private DataGridView dataGridView;
        private Label label_modelo;
        private TextBox textBox_modelo;
        private Label label_nombre;
        private TextBox textBox_nombre;
        private Label label_year;
        private TextBox textBox_year;
        private Label label_dueno;
        private TextBox textBox_dueno;
        private Label label_estado;
        private TextBox textBox_estado;
        private Button button_guardar;
        private Button button1_modificar;
        private Button button2_eliminar;
        private Button button3_buscar;
        private Button btn_guardar_archivo;
        private Label lbl_placa;
        private TextBox txt_placa;
    }
}