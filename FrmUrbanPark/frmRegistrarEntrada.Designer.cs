namespace FrmUrbanPark
{
    partial class frmRegistrarEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarEntrada));
            pnlCabecalho = new Panel();
            picLogo = new PictureBox();
            grpBuscarVeiculo = new GroupBox();
            btnBuscarPorPlaca = new Button();
            mskPlacaveiculo = new MaskedTextBox();
            lblPlacaVeiculo = new Label();
            grpDadosVeiculo = new GroupBox();
            txtCorModelo = new TextBox();
            lblCorModelo = new Label();
            txtNomeCliente = new TextBox();
            lblCliente = new Label();
            grpMovimentacao = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            lblHoraEntrada = new Label();
            dtInfoDtEntrada = new DateTimePicker();
            lblDataEntrada = new Label();
            txtVagaSelecionada = new TextBox();
            lblVagaSelecionada = new Label();
            btnRegistrarEntrada = new Button();
            btnCancelar = new Button();
            pnlCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            grpBuscarVeiculo.SuspendLayout();
            grpDadosVeiculo.SuspendLayout();
            grpMovimentacao.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCabecalho
            // 
            pnlCabecalho.Controls.Add(picLogo);
            pnlCabecalho.Dock = DockStyle.Top;
            pnlCabecalho.Location = new Point(0, 0);
            pnlCabecalho.Name = "pnlCabecalho";
            pnlCabecalho.Size = new Size(758, 84);
            pnlCabecalho.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(0, 0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(758, 84);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            picLogo.Click += pictureBox1_Click;
            // 
            // grpBuscarVeiculo
            // 
            grpBuscarVeiculo.Controls.Add(btnBuscarPorPlaca);
            grpBuscarVeiculo.Controls.Add(mskPlacaveiculo);
            grpBuscarVeiculo.Controls.Add(lblPlacaVeiculo);
            grpBuscarVeiculo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBuscarVeiculo.ForeColor = Color.DarkCyan;
            grpBuscarVeiculo.Location = new Point(25, 115);
            grpBuscarVeiculo.Name = "grpBuscarVeiculo";
            grpBuscarVeiculo.Size = new Size(712, 74);
            grpBuscarVeiculo.TabIndex = 1;
            grpBuscarVeiculo.TabStop = false;
            grpBuscarVeiculo.Text = "Buscar Veículo";
            // 
            // btnBuscarPorPlaca
            // 
            btnBuscarPorPlaca.Image = (Image)resources.GetObject("btnBuscarPorPlaca.Image");
            btnBuscarPorPlaca.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarPorPlaca.Location = new Point(307, 20);
            btnBuscarPorPlaca.Name = "btnBuscarPorPlaca";
            btnBuscarPorPlaca.Size = new Size(156, 33);
            btnBuscarPorPlaca.TabIndex = 2;
            btnBuscarPorPlaca.Text = "Buscar por Placa";
            btnBuscarPorPlaca.UseVisualStyleBackColor = true;
            btnBuscarPorPlaca.Click += btnBuscarPorPlaca_Click;
            // 
            // mskPlacaveiculo
            // 
            mskPlacaveiculo.Location = new Point(106, 26);
            mskPlacaveiculo.Name = "mskPlacaveiculo";
            mskPlacaveiculo.Size = new Size(170, 23);
            mskPlacaveiculo.TabIndex = 1;
            // 
            // lblPlacaVeiculo
            // 
            lblPlacaVeiculo.AutoSize = true;
            lblPlacaVeiculo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlacaVeiculo.ForeColor = Color.Black;
            lblPlacaVeiculo.Location = new Point(3, 19);
            lblPlacaVeiculo.Name = "lblPlacaVeiculo";
            lblPlacaVeiculo.Size = new Size(96, 30);
            lblPlacaVeiculo.TabIndex = 0;
            lblPlacaVeiculo.Text = "\t\nPlaca do Veículo:";
            // 
            // grpDadosVeiculo
            // 
            grpDadosVeiculo.Controls.Add(txtCorModelo);
            grpDadosVeiculo.Controls.Add(lblCorModelo);
            grpDadosVeiculo.Controls.Add(txtNomeCliente);
            grpDadosVeiculo.Controls.Add(lblCliente);
            grpDadosVeiculo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDadosVeiculo.ForeColor = Color.DarkCyan;
            grpDadosVeiculo.Location = new Point(25, 211);
            grpDadosVeiculo.Name = "grpDadosVeiculo";
            grpDadosVeiculo.Size = new Size(267, 132);
            grpDadosVeiculo.TabIndex = 2;
            grpDadosVeiculo.TabStop = false;
            grpDadosVeiculo.Text = "Dados do Veículo";
            // 
            // txtCorModelo
            // 
            txtCorModelo.Location = new Point(93, 55);
            txtCorModelo.Name = "txtCorModelo";
            txtCorModelo.Size = new Size(132, 23);
            txtCorModelo.TabIndex = 4;
            // 
            // lblCorModelo
            // 
            lblCorModelo.AutoSize = true;
            lblCorModelo.Font = new Font("Segoe UI", 9F);
            lblCorModelo.ForeColor = Color.Black;
            lblCorModelo.Location = new Point(6, 62);
            lblCorModelo.Name = "lblCorModelo";
            lblCorModelo.Size = new Size(81, 15);
            lblCorModelo.TabIndex = 3;
            lblCorModelo.Text = "Cor / Modelo:";
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(61, 23);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(150, 23);
            txtNomeCliente.TabIndex = 1;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliente.ForeColor = Color.Black;
            lblCliente.Location = new Point(6, 30);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(47, 15);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            lblCliente.Click += lblCliente_Click;
            // 
            // grpMovimentacao
            // 
            grpMovimentacao.Controls.Add(dateTimePicker1);
            grpMovimentacao.Controls.Add(lblHoraEntrada);
            grpMovimentacao.Controls.Add(dtInfoDtEntrada);
            grpMovimentacao.Controls.Add(lblDataEntrada);
            grpMovimentacao.Controls.Add(txtVagaSelecionada);
            grpMovimentacao.Controls.Add(lblVagaSelecionada);
            grpMovimentacao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpMovimentacao.ForeColor = Color.DarkCyan;
            grpMovimentacao.Location = new Point(332, 209);
            grpMovimentacao.Name = "grpMovimentacao";
            grpMovimentacao.Size = new Size(347, 132);
            grpMovimentacao.TabIndex = 5;
            grpMovimentacao.TabStop = false;
            grpMovimentacao.Text = "Movimentação";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "HH:mm";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(126, 97);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(82, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // lblHoraEntrada
            // 
            lblHoraEntrada.AutoSize = true;
            lblHoraEntrada.Font = new Font("Segoe UI", 9F);
            lblHoraEntrada.ForeColor = Color.Black;
            lblHoraEntrada.Location = new Point(6, 92);
            lblHoraEntrada.Name = "lblHoraEntrada";
            lblHoraEntrada.Size = new Size(95, 15);
            lblHoraEntrada.TabIndex = 5;
            lblHoraEntrada.Text = "Hora de Entrada:";
            // 
            // dtInfoDtEntrada
            // 
            dtInfoDtEntrada.CalendarFont = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtInfoDtEntrada.Format = DateTimePickerFormat.Custom;
            dtInfoDtEntrada.Location = new Point(117, 55);
            dtInfoDtEntrada.Name = "dtInfoDtEntrada";
            dtInfoDtEntrada.Size = new Size(128, 23);
            dtInfoDtEntrada.TabIndex = 4;
            dtInfoDtEntrada.Value = new DateTime(2026, 11, 26, 11, 7, 11, 0);
            // 
            // lblDataEntrada
            // 
            lblDataEntrada.AutoSize = true;
            lblDataEntrada.Font = new Font("Segoe UI", 9F);
            lblDataEntrada.ForeColor = Color.Black;
            lblDataEntrada.Location = new Point(6, 62);
            lblDataEntrada.Name = "lblDataEntrada";
            lblDataEntrada.Size = new Size(93, 15);
            lblDataEntrada.TabIndex = 3;
            lblDataEntrada.Text = "Data de Entrada:";
            // 
            // txtVagaSelecionada
            // 
            txtVagaSelecionada.Location = new Point(123, 22);
            txtVagaSelecionada.Name = "txtVagaSelecionada";
            txtVagaSelecionada.Size = new Size(122, 23);
            txtVagaSelecionada.TabIndex = 1;
            // 
            // lblVagaSelecionada
            // 
            lblVagaSelecionada.AutoSize = true;
            lblVagaSelecionada.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVagaSelecionada.ForeColor = Color.Black;
            lblVagaSelecionada.Location = new Point(6, 30);
            lblVagaSelecionada.Name = "lblVagaSelecionada";
            lblVagaSelecionada.Size = new Size(101, 15);
            lblVagaSelecionada.TabIndex = 0;
            lblVagaSelecionada.Text = "Vaga Selecionada:";
            // 
            // btnRegistrarEntrada
            // 
            btnRegistrarEntrada.BackColor = Color.FromArgb(234, 250, 234);
            btnRegistrarEntrada.FlatStyle = FlatStyle.Popup;
            btnRegistrarEntrada.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarEntrada.Image = (Image)resources.GetObject("btnRegistrarEntrada.Image");
            btnRegistrarEntrada.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarEntrada.Location = new Point(412, 373);
            btnRegistrarEntrada.Name = "btnRegistrarEntrada";
            btnRegistrarEntrada.Size = new Size(165, 40);
            btnRegistrarEntrada.TabIndex = 6;
            btnRegistrarEntrada.Text = "Registrar Entrada";
            btnRegistrarEntrada.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(242, 242, 242);
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(595, 373);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(116, 40);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // frmRegistrarEntrada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(758, 437);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrarEntrada);
            Controls.Add(grpMovimentacao);
            Controls.Add(grpDadosVeiculo);
            Controls.Add(grpBuscarVeiculo);
            Controls.Add(pnlCabecalho);
            Name = "frmRegistrarEntrada";
            Text = "Registrar Entrada";
            pnlCabecalho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            grpBuscarVeiculo.ResumeLayout(false);
            grpBuscarVeiculo.PerformLayout();
            grpDadosVeiculo.ResumeLayout(false);
            grpDadosVeiculo.PerformLayout();
            grpMovimentacao.ResumeLayout(false);
            grpMovimentacao.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCabecalho;
        private PictureBox picLogo;
        private GroupBox grpBuscarVeiculo;
        private Button btnBuscarPorPlaca;
        private MaskedTextBox mskPlacaveiculo;
        private Label lblPlacaVeiculo;
        private GroupBox grpDadosVeiculo;
        private Label lblCliente;
        private TextBox txtCorModelo;
        private Label lblCorModelo;
        private TextBox txtNomeCliente;
        private GroupBox grpMovimentacao;
        private Label lblDataEntrada;
        private TextBox txtVagaSelecionada;
        private Label lblVagaSelecionada;
        private Label lblHoraEntrada;
        private DateTimePicker dtInfoDtEntrada;
        private DateTimePicker dtInfoHrEntrada;
        private Button btnRegistrarEntrada;
        private Button btnCancelar;
        private DateTimePicker dateTimePicker1;
    }
}