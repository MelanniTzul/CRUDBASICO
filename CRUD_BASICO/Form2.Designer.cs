namespace CRUD_BASICO
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label_Buscador = new System.Windows.Forms.Label();
            this.text_buscador = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Buscar = new System.Windows.Forms.Button();
            this.dataGridView_busqueda = new System.Windows.Forms.DataGridView();
            this.lbl_carroSeleccionado = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_cargarArchivo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_busqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Buscador
            // 
            this.label_Buscador.AutoSize = true;
            this.label_Buscador.Location = new System.Drawing.Point(278, 101);
            this.label_Buscador.Name = "label_Buscador";
            this.label_Buscador.Size = new System.Drawing.Size(90, 20);
            this.label_Buscador.TabIndex = 0;
            this.label_Buscador.Text = "BUSCADOR";
            // 
            // text_buscador
            // 
            this.text_buscador.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.text_buscador.Location = new System.Drawing.Point(422, 84);
            this.text_buscador.Name = "text_buscador";
            this.text_buscador.Size = new System.Drawing.Size(353, 38);
            this.text_buscador.TabIndex = 1;
            this.text_buscador.TextChanged += new System.EventHandler(this.text_buscador_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button_Buscar
            // 
            this.button_Buscar.Location = new System.Drawing.Point(804, 84);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(112, 38);
            this.button_Buscar.TabIndex = 3;
            this.button_Buscar.Text = "BUSCAR";
            this.button_Buscar.UseVisualStyleBackColor = true;
            // 
            // dataGridView_busqueda
            // 
            this.dataGridView_busqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_busqueda.Location = new System.Drawing.Point(-2, 187);
            this.dataGridView_busqueda.Name = "dataGridView_busqueda";
            this.dataGridView_busqueda.RowHeadersWidth = 51;
            this.dataGridView_busqueda.RowTemplate.Height = 29;
            this.dataGridView_busqueda.Size = new System.Drawing.Size(677, 273);
            this.dataGridView_busqueda.TabIndex = 4;
            // 
            // lbl_carroSeleccionado
            // 
            this.lbl_carroSeleccionado.AutoSize = true;
            this.lbl_carroSeleccionado.Location = new System.Drawing.Point(792, 294);
            this.lbl_carroSeleccionado.Name = "lbl_carroSeleccionado";
            this.lbl_carroSeleccionado.Size = new System.Drawing.Size(0, 20);
            this.lbl_carroSeleccionado.TabIndex = 5;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(792, 431);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(94, 29);
            this.btn_cerrar.TabIndex = 6;
            this.btn_cerrar.Text = "CERRAR";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_cargarArchivo
            // 
            this.btn_cargarArchivo.Location = new System.Drawing.Point(792, 187);
            this.btn_cargarArchivo.Name = "btn_cargarArchivo";
            this.btn_cargarArchivo.Size = new System.Drawing.Size(155, 29);
            this.btn_cargarArchivo.TabIndex = 7;
            this.btn_cargarArchivo.Text = "CARGAR ARCHIVO";
            this.btn_cargarArchivo.UseVisualStyleBackColor = true;
            this.btn_cargarArchivo.Click += new System.EventHandler(this.btn_cargarArchivo_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 608);
            this.Controls.Add(this.btn_cargarArchivo);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.lbl_carroSeleccionado);
            this.Controls.Add(this.dataGridView_busqueda);
            this.Controls.Add(this.button_Buscar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.text_buscador);
            this.Controls.Add(this.label_Buscador);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form2";
            this.Text = "Busqueda";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_busqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_Buscador;
        private TextBox text_buscador;
        private PictureBox pictureBox1;
        private Button button_Buscar;
        private DataGridView dataGridView_busqueda;
        private Label lbl_carroSeleccionado;
        private Button btn_cerrar;
        private Button btn_cargarArchivo;
    }
}