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
            this.txt_buscador = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Buscar = new System.Windows.Forms.Button();
            this.dataGridView_busqueda = new System.Windows.Forms.DataGridView();
            this.lbl_carroSeleccionado = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.checkBox_nombre = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_busqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Buscador
            // 
            this.label_Buscador.AutoSize = true;
            this.label_Buscador.Location = new System.Drawing.Point(38, 90);
            this.label_Buscador.Name = "label_Buscador";
            this.label_Buscador.Size = new System.Drawing.Size(90, 20);
            this.label_Buscador.TabIndex = 0;
            this.label_Buscador.Text = "BUSCADOR";
            // 
            // txt_buscador
            // 
            this.txt_buscador.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_buscador.Location = new System.Drawing.Point(168, 83);
            this.txt_buscador.Name = "txt_buscador";
            this.txt_buscador.Size = new System.Drawing.Size(353, 27);
            this.txt_buscador.TabIndex = 1;
            this.txt_buscador.TextChanged += new System.EventHandler(this.text_buscador_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1035, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button_Buscar
            // 
            this.button_Buscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Buscar.Location = new System.Drawing.Point(812, 80);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(175, 27);
            this.button_Buscar.TabIndex = 3;
            this.button_Buscar.Text = "BUSCAR ";
            this.button_Buscar.UseVisualStyleBackColor = true;
            this.button_Buscar.Click += new System.EventHandler(this.button_Buscar_Click);
            // 
            // dataGridView_busqueda
            // 
            this.dataGridView_busqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_busqueda.Location = new System.Drawing.Point(38, 178);
            this.dataGridView_busqueda.Name = "dataGridView_busqueda";
            this.dataGridView_busqueda.RowHeadersWidth = 51;
            this.dataGridView_busqueda.RowTemplate.Height = 29;
            this.dataGridView_busqueda.Size = new System.Drawing.Size(802, 292);
            this.dataGridView_busqueda.TabIndex = 4;
            // 
            // lbl_carroSeleccionado
            // 
            this.lbl_carroSeleccionado.AutoSize = true;
            this.lbl_carroSeleccionado.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_carroSeleccionado.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_carroSeleccionado.Location = new System.Drawing.Point(879, 255);
            this.lbl_carroSeleccionado.Name = "lbl_carroSeleccionado";
            this.lbl_carroSeleccionado.Size = new System.Drawing.Size(0, 23);
            this.lbl_carroSeleccionado.TabIndex = 5;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(879, 441);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(94, 29);
            this.btn_cerrar.TabIndex = 6;
            this.btn_cerrar.Text = "CERRAR";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // checkBox_nombre
            // 
            this.checkBox_nombre.AutoSize = true;
            this.checkBox_nombre.Checked = true;
            this.checkBox_nombre.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_nombre.Location = new System.Drawing.Point(564, 83);
            this.checkBox_nombre.Name = "checkBox_nombre";
            this.checkBox_nombre.Size = new System.Drawing.Size(215, 24);
            this.checkBox_nombre.TabIndex = 8;
            this.checkBox_nombre.Text = "BUSQUEDA POR NOMBRE";
            this.checkBox_nombre.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 552);
            this.Controls.Add(this.checkBox_nombre);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.lbl_carroSeleccionado);
            this.Controls.Add(this.dataGridView_busqueda);
            this.Controls.Add(this.button_Buscar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_buscador);
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
        private TextBox txt_buscador;
        private PictureBox pictureBox1;
        private Button button_Buscar;
        private DataGridView dataGridView_busqueda;
        private Label lbl_carroSeleccionado;
        private Button btn_cerrar;
        private CheckBox checkBox_nombre;
    }
}