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
            pnlCabecalho.Size = new Size(767, 84);
            pnlCabecalho.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(0, 0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(767, 84);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // grpBuscarVeiculo
            // 
            grpBuscarVeiculo.Controls.Add(btnBuscarPorPlaca);
            grpBuscarVeiculo.Controls.Add(mskPlacaveiculo);
            grpBuscarVeiculo.Controls.Add(lblPlacaVeiculo);
            grpBuscarVeiculo.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBuscarVeiculo.ForeColor = Color.Purple;
            grpBuscarVeiculo.Location = new Point(25, 101);
            grpBuscarVeiculo.Name = "grpBuscarVeiculo";
            grpBuscarVeiculo.Size = new Size(721, 85);
            grpBuscarVeiculo.TabIndex = 1;
            grpBuscarVeiculo.TabStop = false;
            grpBuscarVeiculo.Text = "Buscar Veículo";
            // 
            // btnBuscarPorPlaca
            // 
            btnBuscarPorPlaca.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarPorPlaca.Image = (Image)resources.GetObject("btnBuscarPorPlaca.Image");
            btnBuscarPorPlaca.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarPorPlaca.Location = new Point(313, 31);
            btnBuscarPorPlaca.Name = "btnBuscarPorPlaca";
            btnBuscarPorPlaca.Size = new Size(169, 30);
            btnBuscarPorPlaca.TabIndex = 2;
            btnBuscarPorPlaca.Text = "Buscar por Placa";
            btnBuscarPorPlaca.UseVisualStyleBackColor = true;
            btnBuscarPorPlaca.Click += btnBuscarPorPlaca_Click;
            // 
            // mskPlacaveiculo
            // 
            mskPlacaveiculo.Location = new Point(124, 33);
            mskPlacaveiculo.Name = "mskPlacaveiculo";
            mskPlacaveiculo.Size = new Size(170, 27);
            mskPlacaveiculo.TabIndex = 1;
            // 
            // lblPlacaVeiculo
            // 
            lblPlacaVeiculo.AutoSize = true;
            lblPlacaVeiculo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlacaVeiculo.ForeColor = Color.Black;
            lblPlacaVeiculo.Location = new Point(12, 23);
            lblPlacaVeiculo.Name = "lblPlacaVeiculo";
            lblPlacaVeiculo.Size = new Size(106, 34);
            lblPlacaVeiculo.TabIndex = 0;
            lblPlacaVeiculo.Text = "\t\nPlaca do Veículo:";
            // 
            // grpDadosVeiculo
            // 
            grpDadosVeiculo.Controls.Add(txtCorModelo);
            grpDadosVeiculo.Controls.Add(lblCorModelo);
            grpDadosVeiculo.Controls.Add(txtNomeCliente);
            grpDadosVeiculo.Controls.Add(lblCliente);
            grpDadosVeiculo.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            grpDadosVeiculo.ForeColor = Color.Purple;
            grpDadosVeiculo.Location = new Point(25, 197);
            grpDadosVeiculo.Name = "grpDadosVeiculo";
            grpDadosVeiculo.Size = new Size(301, 132);
            grpDadosVeiculo.TabIndex = 2;
            grpDadosVeiculo.TabStop = false;
            grpDadosVeiculo.Text = "Dados do Veículo";
            // 
            // txtCorModelo
            // 
            txtCorModelo.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCorModelo.Location = new Point(104, 63);
            txtCorModelo.Name = "txtCorModelo";
            txtCorModelo.Size = new Size(190, 26);
            txtCorModelo.TabIndex = 4;
            // 
            // lblCorModelo
            // 
            lblCorModelo.AutoSize = true;
            lblCorModelo.Font = new Font("Segoe UI", 9.75F);
            lblCorModelo.ForeColor = Color.Black;
            lblCorModelo.Location = new Point(7, 70);
            lblCorModelo.Name = "lblCorModelo";
            lblCorModelo.Size = new Size(91, 17);
            lblCorModelo.TabIndex = 3;
            lblCorModelo.Text = "Cor / Modelo:";
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Font = new Font("Tahoma", 11F, FontStyle.Bold);
            txtNomeCliente.Location = new Point(75, 22);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(182, 25);
            txtNomeCliente.TabIndex = 1;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 9.75F);
            lblCliente.ForeColor = Color.Black;
            lblCliente.Location = new Point(6, 30);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(50, 17);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            // 
            // grpMovimentacao
            // 
            grpMovimentacao.Controls.Add(dateTimePicker1);
            grpMovimentacao.Controls.Add(lblHoraEntrada);
            grpMovimentacao.Controls.Add(dtInfoDtEntrada);
            grpMovimentacao.Controls.Add(lblDataEntrada);
            grpMovimentacao.Controls.Add(txtVagaSelecionada);
            grpMovimentacao.Controls.Add(lblVagaSelecionada);
            grpMovimentacao.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            grpMovimentacao.ForeColor = Color.Purple;
            grpMovimentacao.Location = new Point(332, 197);
            grpMovimentacao.Name = "grpMovimentacao";
            grpMovimentacao.Size = new Size(414, 132);
            grpMovimentacao.TabIndex = 5;
            grpMovimentacao.TabStop = false;
            grpMovimentacao.Text = "Movimentação";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "HH:mm";
            dateTimePicker1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(128, 61);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(82, 26);
            dateTimePicker1.TabIndex = 6;
            // 
            // lblHoraEntrada
            // 
            lblHoraEntrada.AutoSize = true;
            lblHoraEntrada.Font = new Font("Segoe UI", 9.75F);
            lblHoraEntrada.ForeColor = Color.Black;
            lblHoraEntrada.Location = new Point(8, 66);
            lblHoraEntrada.Name = "lblHoraEntrada";
            lblHoraEntrada.Size = new Size(108, 17);
            lblHoraEntrada.TabIndex = 5;
            lblHoraEntrada.Text = "Hora de Entrada:";
            // 
            // dtInfoDtEntrada
            // 
            dtInfoDtEntrada.CalendarFont = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtInfoDtEntrada.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtInfoDtEntrada.Format = DateTimePickerFormat.Custom;
            dtInfoDtEntrada.Location = new Point(128, 29);
            dtInfoDtEntrada.Name = "dtInfoDtEntrada";
            dtInfoDtEntrada.Size = new Size(128, 26);
            dtInfoDtEntrada.TabIndex = 4;
            dtInfoDtEntrada.Value = new DateTime(2026, 11, 26, 11, 7, 11, 0);
            // 
            // lblDataEntrada
            // 
            lblDataEntrada.AutoSize = true;
            lblDataEntrada.Font = new Font("Segoe UI", 9.75F);
            lblDataEntrada.ForeColor = Color.Black;
            lblDataEntrada.Location = new Point(8, 30);
            lblDataEntrada.Name = "lblDataEntrada";
            lblDataEntrada.Size = new Size(106, 17);
            lblDataEntrada.TabIndex = 3;
            lblDataEntrada.Text = "Data de Entrada:";
            // 
            // txtVagaSelecionada
            // 
            txtVagaSelecionada.Location = new Point(128, 93);
            txtVagaSelecionada.Name = "txtVagaSelecionada";
            txtVagaSelecionada.Size = new Size(122, 27);
            txtVagaSelecionada.TabIndex = 1;
            // 
            // lblVagaSelecionada
            // 
            lblVagaSelecionada.AutoSize = true;
            lblVagaSelecionada.Font = new Font("Segoe UI", 9.75F);
            lblVagaSelecionada.ForeColor = Color.Black;
            lblVagaSelecionada.Location = new Point(8, 98);
            lblVagaSelecionada.Name = "lblVagaSelecionada";
            lblVagaSelecionada.Size = new Size(114, 17);
            lblVagaSelecionada.TabIndex = 0;
            lblVagaSelecionada.Text = "Vaga Selecionada:";
            // 
            // btnRegistrarEntrada
            // 
            btnRegistrarEntrada.BackColor = Color.FromArgb(234, 250, 234);
            btnRegistrarEntrada.FlatAppearance.BorderColor = Color.Lime;
            btnRegistrarEntrada.FlatAppearance.BorderSize = 15;
            btnRegistrarEntrada.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarEntrada.Image = (Image)resources.GetObject("btnRegistrarEntrada.Image");
            btnRegistrarEntrada.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarEntrada.Location = new Point(469, 378);
            btnRegistrarEntrada.Name = "btnRegistrarEntrada";
            btnRegistrarEntrada.Size = new Size(148, 40);
            btnRegistrarEntrada.TabIndex = 6;
            btnRegistrarEntrada.Text = "Registrar Entrada";
            btnRegistrarEntrada.TextAlign = ContentAlignment.MiddleRight;
            btnRegistrarEntrada.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(242, 242, 242);
            btnCancelar.Font = new Font("Segoe UI", 9.75F);
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(652, 378);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 40);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // frmRegistrarEntrada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(767, 448);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrarEntrada);
            Controls.Add(grpMovimentacao);
            Controls.Add(grpDadosVeiculo);
            Controls.Add(grpBuscarVeiculo);
            Controls.Add(pnlCabecalho);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmRegistrarEntrada";
            Text = "Registrar Entrada";
            Load += frmRegistrarEntrada_Load;
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