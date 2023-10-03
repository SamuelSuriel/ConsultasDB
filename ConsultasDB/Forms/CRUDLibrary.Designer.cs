namespace ConsultasDB.Forms
{
    partial class CRUDLibrary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDLibrary));
            btnAgregar = new Button();
            btnEditar = new Button();
            btnBorrar = new Button();
            cbMaterias = new ComboBox();
            txtCantidadPaginasIn = new TextBox();
            txtTituloIn = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            picbtnAtras = new PictureBox();
            label1 = new Label();
            dgvBiblioteca = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picbtnAtras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBiblioteca).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Gold;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Location = new Point(820, 615);
            btnAgregar.Margin = new Padding(4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(668, 67);
            btnAgregar.TabIndex = 24;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.ForeColor = Color.Black;
            btnEditar.Location = new Point(820, 732);
            btnEditar.Margin = new Padding(4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(330, 66);
            btnEditar.TabIndex = 23;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Cursor = Cursors.Hand;
            btnBorrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBorrar.ForeColor = Color.Black;
            btnBorrar.Location = new Point(1158, 732);
            btnBorrar.Margin = new Padding(4);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(330, 66);
            btnBorrar.TabIndex = 22;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // cbMaterias
            // 
            cbMaterias.BackColor = Color.White;
            cbMaterias.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cbMaterias.FormattingEnabled = true;
            cbMaterias.Location = new Point(1139, 499);
            cbMaterias.Margin = new Padding(4);
            cbMaterias.Name = "cbMaterias";
            cbMaterias.Size = new Size(349, 36);
            cbMaterias.TabIndex = 21;
            // 
            // txtCantidadPaginasIn
            // 
            txtCantidadPaginasIn.BackColor = Color.White;
            txtCantidadPaginasIn.BorderStyle = BorderStyle.FixedSingle;
            txtCantidadPaginasIn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCantidadPaginasIn.Location = new Point(820, 499);
            txtCantidadPaginasIn.Margin = new Padding(4);
            txtCantidadPaginasIn.Name = "txtCantidadPaginasIn";
            txtCantidadPaginasIn.Size = new Size(276, 34);
            txtCantidadPaginasIn.TabIndex = 16;
            // 
            // txtTituloIn
            // 
            txtTituloIn.BackColor = Color.White;
            txtTituloIn.BorderStyle = BorderStyle.FixedSingle;
            txtTituloIn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTituloIn.Location = new Point(820, 319);
            txtTituloIn.Margin = new Padding(4);
            txtTituloIn.Name = "txtTituloIn";
            txtTituloIn.Size = new Size(668, 34);
            txtTituloIn.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(1148, 425);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(94, 31);
            label6.TabIndex = 19;
            label6.Text = "Materia";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(820, 255);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(80, 31);
            label5.TabIndex = 20;
            label5.Text = "Título ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(820, 425);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(137, 31);
            label7.TabIndex = 18;
            label7.Text = "No. Páginas";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(picbtnAtras);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1504, 125);
            panel2.TabIndex = 25;
            // 
            // picbtnAtras
            // 
            picbtnAtras.BackColor = Color.Transparent;
            picbtnAtras.Image = (Image)resources.GetObject("picbtnAtras.Image");
            picbtnAtras.Location = new Point(30, 33);
            picbtnAtras.Name = "picbtnAtras";
            picbtnAtras.Size = new Size(41, 41);
            picbtnAtras.SizeMode = PictureBoxSizeMode.StretchImage;
            picbtnAtras.TabIndex = 28;
            picbtnAtras.TabStop = false;
            picbtnAtras.Click += picbtnAtras_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(605, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(320, 54);
            label1.TabIndex = 27;
            label1.Text = "CRUD LIBRARY";
            // 
            // dgvBiblioteca
            // 
            dgvBiblioteca.BackgroundColor = Color.White;
            dgvBiblioteca.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBiblioteca.Location = new Point(16, 133);
            dgvBiblioteca.Margin = new Padding(4);
            dgvBiblioteca.Name = "dgvBiblioteca";
            dgvBiblioteca.RowHeadersWidth = 51;
            dgvBiblioteca.RowTemplate.Height = 29;
            dgvBiblioteca.Size = new Size(773, 665);
            dgvBiblioteca.TabIndex = 26;
            // 
            // CRUDLibrary
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1504, 830);
            Controls.Add(dgvBiblioteca);
            Controls.Add(panel2);
            Controls.Add(btnAgregar);
            Controls.Add(btnEditar);
            Controls.Add(btnBorrar);
            Controls.Add(cbMaterias);
            Controls.Add(txtCantidadPaginasIn);
            Controls.Add(txtTituloIn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label7);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "CRUDLibrary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUDLibrary";
            Load += CRUDLibrary_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picbtnAtras).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBiblioteca).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button btnEditar;
        private Button btnBorrar;
        private ComboBox cbMaterias;
        private Label label6;
        private Label label5;
        private Label label7;
        private Panel panel2;
        private DataGridView dgvBiblioteca;
        private Label label1;
        private PictureBox picbtnAtras;
        public TextBox txtCantidadPaginasIn;
        public TextBox txtTituloIn;
    }
}