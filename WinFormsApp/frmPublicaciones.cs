namespace WinFormsApp
{
    public partial class FrmPublicaciones : Form
    {
        public FrmPublicaciones()
        {
            InitializeComponent();
        }

        private GroupBox groupBox1;

        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            rbLibro = new RadioButton();
            rbAudioLibro = new RadioButton();
            btnCapturar = new Button();
            btnMostrar = new Button();
            btnSalir = new Button();
            GroupBox2 = new GroupBox();
            lblTitulo = new Label();
            lblPrecio = new Label();
            lblNumPaginas = new Label();
            lblTiempo = new Label();
            txtTitulo = new TextBox();
            txtPrecio = new TextBox();
            txtNumPaginas = new TextBox();
            txtTiempo = new TextBox();
            groupBox1.SuspendLayout();
            GroupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbAudioLibro);
            groupBox1.Controls.Add(rbLibro);
            groupBox1.Location = new Point(209, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "TipoDePublicacion";
            // 
            // rbLibro
            // 
            rbLibro.AutoSize = true;
            rbLibro.Location = new Point(20, 19);
            rbLibro.Name = "rbLibro";
            rbLibro.Size = new Size(95, 19);
            rbLibro.TabIndex = 0;
            rbLibro.Text = "LibroImpreso";
            rbLibro.UseVisualStyleBackColor = true;
            rbLibro.CheckedChanged += rbLibro_CheckedChanged;
            // 
            // rbAudioLibro
            // 
            rbAudioLibro.AutoSize = true;
            rbAudioLibro.Checked = true;
            rbAudioLibro.Location = new Point(20, 46);
            rbAudioLibro.Name = "rbAudioLibro";
            rbAudioLibro.Size = new Size(84, 19);
            rbAudioLibro.TabIndex = 1;
            rbAudioLibro.TabStop = true;
            rbAudioLibro.Text = "AudioLibro";
            rbAudioLibro.UseVisualStyleBackColor = true;
            rbAudioLibro.CheckedChanged += rbAudioLibro_CheckedChanged;
            // 
            // btnCapturar
            // 
            btnCapturar.Location = new Point(101, 210);
            btnCapturar.Name = "btnCapturar";
            btnCapturar.Size = new Size(75, 23);
            btnCapturar.TabIndex = 1;
            btnCapturar.Text = "Capturar datos";
            btnCapturar.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(229, 210);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 2;
            btnMostrar.Text = "MostrarDatos";
            btnMostrar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(364, 210);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // GroupBox2
            // 
            GroupBox2.Controls.Add(txtTiempo);
            GroupBox2.Controls.Add(txtNumPaginas);
            GroupBox2.Controls.Add(txtPrecio);
            GroupBox2.Controls.Add(txtTitulo);
            GroupBox2.Controls.Add(lblTiempo);
            GroupBox2.Controls.Add(lblNumPaginas);
            GroupBox2.Controls.Add(lblPrecio);
            GroupBox2.Controls.Add(lblTitulo);
            GroupBox2.Location = new Point(211, 282);
            GroupBox2.Name = "GroupBox2";
            GroupBox2.Size = new Size(198, 155);
            GroupBox2.TabIndex = 4;
            GroupBox2.TabStop = false;
            GroupBox2.Text = "TiempoDePublicacion";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(21, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(37, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(18, 51);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 1;
            lblPrecio.Text = "Precio";
            lblPrecio.Click += this.label2_Click;
            // 
            // lblNumPaginas
            // 
            lblNumPaginas.AutoSize = true;
            lblNumPaginas.Location = new Point(10, 85);
            lblNumPaginas.Name = "lblNumPaginas";
            lblNumPaginas.Size = new Size(78, 15);
            lblNumPaginas.TabIndex = 2;
            lblNumPaginas.Text = "Num Paginas";
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(6, 124);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(76, 15);
            lblTiempo.TabIndex = 3;
            lblTiempo.Text = "Tiempo(Min)";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(94, 19);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(100, 23);
            txtTitulo.TabIndex = 4;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(94, 48);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 5;
            // 
            // txtNumPaginas
            // 
            txtNumPaginas.Location = new Point(94, 77);
            txtNumPaginas.Name = "txtNumPaginas";
            txtNumPaginas.Size = new Size(100, 23);
            txtNumPaginas.TabIndex = 6;
            // 
            // txtTiempo
            // 
            txtTiempo.Location = new Point(94, 116);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(100, 23);
            txtTiempo.TabIndex = 7;
            // 
            // Form1
            // 
            ClientSize = new Size(752, 539);
            Controls.Add(GroupBox2);
            Controls.Add(btnSalir);
            Controls.Add(btnMostrar);
            Controls.Add(btnCapturar);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Publicaciones";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            GroupBox2.ResumeLayout(false);
            GroupBox2.PerformLayout();
            ResumeLayout(false);
        }

        private RadioButton rbAudioLibro;
        private RadioButton rbLibro;
        private Button btnCapturar;
        private Button btnMostrar;
        private Button btnSalir;
        private GroupBox GroupBox2;
        private Label lblTiempo;
        private Label lblNumPaginas;
        private Label lblPrecio;
        private Label lblTitulo;
        private TextBox txtNumPaginas;
        private TextBox txtPrecio;
        private TextBox txtTitulo;
        private TextBox txtTiempo;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rbAudioLibro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbLibro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLibro.Checked)
            {
                txtPagina.Enabled = true;
                txtTiempo.Enabled = false;
                txtTiempo.Text = string.Empty;
            }
            else
            {
                txtPaginas.Enabled = false;
                txtTiempo.Enabled = true;
                txtPaginas.Text = string.Empty;
            }
        }
    }
}
