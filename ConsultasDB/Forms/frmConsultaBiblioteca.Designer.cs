namespace ConsultasDB.Forms
{
    partial class frmConsultaBiblioteca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaBiblioteca));
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtCodigoMateria = new TextBox();
            txtCantidadPaginas = new TextBox();
            txtTitulo = new TextBox();
            txtCodigoLibro = new TextBox();
            txtCodigo = new TextBox();
            btnConsultar = new Button();
            btnClean = new Button();
            picbtnAbrirCrud = new PictureBox();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picbtnAbrirCrud).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.NavajoWhite;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtCodigoMateria);
            panel1.Controls.Add(txtCantidadPaginas);
            panel1.Controls.Add(txtTitulo);
            panel1.Controls.Add(txtCodigoLibro);
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.ForeColor = SystemColors.Highlight;
            panel1.Location = new Point(55, 156);
            panel1.Name = "panel1";
            panel1.Size = new Size(757, 287);
            panel1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Papyrus", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(26, 26);
            label4.Name = "label4";
            label4.Size = new Size(168, 37);
            label4.TabIndex = 9;
            label4.Text = "Código Libro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Papyrus", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(26, 200);
            label3.Name = "label3";
            label3.Size = new Size(105, 37);
            label3.TabIndex = 8;
            label3.Text = "Materia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Papyrus", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(26, 137);
            label2.Name = "label2";
            label2.Size = new Size(152, 37);
            label2.TabIndex = 7;
            label2.Text = "No. Páginas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Papyrus", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 82);
            label1.Name = "label1";
            label1.Size = new Size(88, 37);
            label1.TabIndex = 6;
            label1.Text = "Título";
            // 
            // txtCodigoMateria
            // 
            txtCodigoMateria.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigoMateria.Location = new Point(235, 200);
            txtCodigoMateria.Name = "txtCodigoMateria";
            txtCodigoMateria.ReadOnly = true;
            txtCodigoMateria.Size = new Size(263, 39);
            txtCodigoMateria.TabIndex = 5;
            // 
            // txtCantidadPaginas
            // 
            txtCantidadPaginas.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCantidadPaginas.Location = new Point(235, 145);
            txtCantidadPaginas.Name = "txtCantidadPaginas";
            txtCantidadPaginas.ReadOnly = true;
            txtCantidadPaginas.Size = new Size(263, 39);
            txtCantidadPaginas.TabIndex = 4;
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitulo.Location = new Point(235, 82);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.ReadOnly = true;
            txtTitulo.Size = new Size(502, 39);
            txtTitulo.TabIndex = 3;
            // 
            // txtCodigoLibro
            // 
            txtCodigoLibro.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigoLibro.Location = new Point(235, 26);
            txtCodigoLibro.Name = "txtCodigoLibro";
            txtCodigoLibro.ReadOnly = true;
            txtCodigoLibro.Size = new Size(263, 39);
            txtCodigoLibro.TabIndex = 2;
            // 
            // txtCodigo
            // 
            txtCodigo.Cursor = Cursors.IBeam;
            txtCodigo.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigo.Location = new Point(290, 101);
            txtCodigo.MaxLength = 100;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(205, 39);
            txtCodigo.TabIndex = 8;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = SystemColors.Highlight;
            btnConsultar.Cursor = Cursors.Hand;
            btnConsultar.Font = new Font("Papyrus", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultar.ForeColor = SystemColors.ButtonHighlight;
            btnConsultar.Location = new Point(520, 95);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(125, 48);
            btnConsultar.TabIndex = 7;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnClean
            // 
            btnClean.Cursor = Cursors.Hand;
            btnClean.Font = new Font("Papyrus", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClean.ForeColor = SystemColors.Highlight;
            btnClean.Location = new Point(689, 96);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(123, 47);
            btnClean.TabIndex = 10;
            btnClean.Text = "Limpiar";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // picbtnAbrirCrud
            // 
            picbtnAbrirCrud.BackColor = Color.Transparent;
            picbtnAbrirCrud.Cursor = Cursors.Hand;
            picbtnAbrirCrud.Image = (Image)resources.GetObject("picbtnAbrirCrud.Image");
            picbtnAbrirCrud.Location = new Point(55, 30);
            picbtnAbrirCrud.Name = "picbtnAbrirCrud";
            picbtnAbrirCrud.Size = new Size(100, 83);
            picbtnAbrirCrud.SizeMode = PictureBoxSizeMode.CenterImage;
            picbtnAbrirCrud.TabIndex = 11;
            picbtnAbrirCrud.TabStop = false;
            picbtnAbrirCrud.Click += picbtnAbrirCrud_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Papyrus", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(65, 116);
            label5.Name = "label5";
            label5.Size = new Size(79, 27);
            label5.TabIndex = 10;
            label5.Text = "CRUD";
            // 
            // frmConsultaBiblioteca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(863, 486);
            Controls.Add(label5);
            Controls.Add(picbtnAbrirCrud);
            Controls.Add(btnClean);
            Controls.Add(panel1);
            Controls.Add(txtCodigo);
            Controls.Add(btnConsultar);
            ForeColor = SystemColors.Highlight;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmConsultaBiblioteca";
            Text = "Consulta Biblioteca";
            Load += frmConsultaBiblioteca_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picbtnAbrirCrud).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtCodigoMateria;
        private TextBox txtCantidadPaginas;
        private TextBox txtTitulo;
        private TextBox txtCodigoLibro;
        private TextBox txtCodigo;
        private Button btnConsultar;
        private Button btnClean;
        private PictureBox picbtnAbrirCrud;
        private Label label5;
    }
}