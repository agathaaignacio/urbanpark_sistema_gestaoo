namespace FrmUrbanPark
{
    partial class frmRegistrarSaida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarSaida));
            pnlCabecalho = new Panel();
            pictureBox1 = new PictureBox();
            grpBuscarVeiculo = new GroupBox();
            btnBuscarPorPlaca = new Button();
            mskPlacaveiculo = new MaskedTextBox();
            lblPlacaVeiculo = new Label();
            grpDadosVeiculo = new GroupBox();
            txtNumeroVaga = new TextBox();
            txtPlaca = new TextBox();
            txtNomeCliente = new TextBox();
            lblVaga = new Label();
            txtCorModelo = new TextBox();
            lblPlaca = new Label();
            lblCorModelo = new Label();
            lblCliente = new Label();
            grpMovimentacao = new GroupBox();
            dtInfoHrSaida = new DateTimePicker();
            lblHoraSaida = new Label();
            dtInfoDtSaida = new DateTimePicker();
            lblDataSaida = new Label();
            lblDataHoraEntrada = new Label();
            grpCalculo = new GroupBox();
            pnlValorPagar = new Panel();
            lblValorPagar = new Label();
            lblValorAPagar = new Label();
            txtInfoTarifa = new TextBox();
            txtInfoTempoPermanencia = new TextBox();
            lblTempoPermanencia = new Label();
            lblTarifaVigente = new Label();
            btnRegistrarSaida = new Button();
            btnCancelar = new Button();
            txtDataHoraEntrada = new TextBox();
            pnlCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpBuscarVeiculo.SuspendLayout();
            grpDadosVeiculo.SuspendLayout();
            grpMovimentacao.SuspendLayout();
            grpCalculo.SuspendLayout();
            pnlValorPagar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCabecalho
            // 
            pnlCabecalho.Controls.Add(pictureBox1);
            pnlCabecalho.Dock = DockStyle.Top;
            pnlCabecalho.Location = new Point(0, 0);
            pnlCabecalho.Name = "pnlCabecalho";
            pnlCabecalho.Size = new Size(935, 78);
            pnlCabecalho.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(935, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // grpBuscarVeiculo
            // 
            grpBuscarVeiculo.Controls.Add(btnBuscarPorPlaca);
            grpBuscarVeiculo.Controls.Add(mskPlacaveiculo);
            grpBuscarVeiculo.Controls.Add(lblPlacaVeiculo);
            grpBuscarVeiculo.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            grpBuscarVeiculo.ForeColor = Color.FromArgb(255, 128, 0);
            grpBuscarVeiculo.Location = new Point(12, 93);
            grpBuscarVeiculo.Name = "grpBuscarVeiculo";
            grpBuscarVeiculo.Size = new Size(776, 85);
            grpBuscarVeiculo.TabIndex = 1;
            grpBuscarVeiculo.TabStop = false;
            grpBuscarVeiculo.Text = "Buscar Veículo";
            // 
            // btnBuscarPorPlaca
            // 
            btnBuscarPorPlaca.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            btnBuscarPorPlaca.Image = (Image)resources.GetObject("btnBuscarPorPlaca.Image");
            btnBuscarPorPlaca.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarPorPlaca.Location = new Point(384, 26);
            btnBuscarPorPlaca.Name = "btnBuscarPorPlaca";
            btnBuscarPorPlaca.Size = new Size(151, 29);
            btnBuscarPorPlaca.TabIndex = 2;
            btnBuscarPorPlaca.Text = "Buscar por Placa";
            btnBuscarPorPlaca.TextAlign = ContentAlignment.MiddleRight;
            btnBuscarPorPlaca.UseVisualStyleBackColor = true;
            // 
            // mskPlacaveiculo
            // 
            mskPlacaveiculo.Location = new Point(123, 30);
            mskPlacaveiculo.Name = "mskPlacaveiculo";
            mskPlacaveiculo.Size = new Size(132, 27);
            mskPlacaveiculo.TabIndex = 1;
            // 
            // lblPlacaVeiculo
            // 
            lblPlacaVeiculo.AutoSize = true;
            lblPlacaVeiculo.Font = new Font("Segoe UI", 9.75F);
            lblPlacaVeiculo.ForeColor = Color.Black;
            lblPlacaVeiculo.Location = new Point(6, 36);
            lblPlacaVeiculo.Name = "lblPlacaVeiculo";
            lblPlacaVeiculo.Size = new Size(106, 17);
            lblPlacaVeiculo.TabIndex = 0;
            lblPlacaVeiculo.Text = "Placa do Veículo:";
            // 
            // grpDadosVeiculo
            // 
            grpDadosVeiculo.Controls.Add(txtNumeroVaga);
            grpDadosVeiculo.Controls.Add(txtPlaca);
            grpDadosVeiculo.Controls.Add(txtNomeCliente);
            grpDadosVeiculo.Controls.Add(lblVaga);
            grpDadosVeiculo.Controls.Add(txtCorModelo);
            grpDadosVeiculo.Controls.Add(lblPlaca);
            grpDadosVeiculo.Controls.Add(lblCorModelo);
            grpDadosVeiculo.Controls.Add(lblCliente);
            grpDadosVeiculo.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            grpDadosVeiculo.ForeColor = Color.FromArgb(255, 128, 0);
            grpDadosVeiculo.Location = new Point(12, 198);
            grpDadosVeiculo.Name = "grpDadosVeiculo";
            grpDadosVeiculo.Size = new Size(387, 296);
            grpDadosVeiculo.TabIndex = 2;
            grpDadosVeiculo.TabStop = false;
            grpDadosVeiculo.Text = "Dados do Veículo";
            // 
            // txtNumeroVaga
            // 
            txtNumeroVaga.Location = new Point(62, 178);
            txtNumeroVaga.Name = "txtNumeroVaga";
            txtNumeroVaga.Size = new Size(124, 27);
            txtNumeroVaga.TabIndex = 9;
            txtNumeroVaga.TextChanged += txtNumeroVaga_TextChanged;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(62, 77);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(124, 27);
            txtPlaca.TabIndex = 6;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(62, 27);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(281, 27);
            txtNomeCliente.TabIndex = 5;
            // 
            // lblVaga
            // 
            lblVaga.AutoSize = true;
            lblVaga.Font = new Font("Segoe UI", 9.75F);
            lblVaga.ForeColor = Color.Black;
            lblVaga.Location = new Point(10, 181);
            lblVaga.Name = "lblVaga";
            lblVaga.Size = new Size(40, 17);
            lblVaga.TabIndex = 3;
            lblVaga.Text = "Vaga:";
            // 
            // txtCorModelo
            // 
            txtCorModelo.Location = new Point(106, 133);
            txtCorModelo.Name = "txtCorModelo";
            txtCorModelo.Size = new Size(170, 27);
            txtCorModelo.TabIndex = 4;
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Font = new Font("Segoe UI", 9.75F);
            lblPlaca.ForeColor = Color.Black;
            lblPlaca.Location = new Point(15, 82);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(41, 17);
            lblPlaca.TabIndex = 3;
            lblPlaca.Text = "Placa:";
            // 
            // lblCorModelo
            // 
            lblCorModelo.AutoSize = true;
            lblCorModelo.Font = new Font("Segoe UI", 9.75F);
            lblCorModelo.ForeColor = Color.Black;
            lblCorModelo.Location = new Point(9, 138);
            lblCorModelo.Name = "lblCorModelo";
            lblCorModelo.Size = new Size(91, 17);
            lblCorModelo.TabIndex = 3;
            lblCorModelo.Text = "Cor / Modelo:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 9.75F);
            lblCliente.ForeColor = Color.Black;
            lblCliente.Location = new Point(6, 32);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(50, 17);
            lblCliente.TabIndex = 3;
            lblCliente.Text = "Cliente:";
            // 
            // grpMovimentacao
            // 
            grpMovimentacao.Controls.Add(txtDataHoraEntrada);
            grpMovimentacao.Controls.Add(dtInfoHrSaida);
            grpMovimentacao.Controls.Add(lblHoraSaida);
            grpMovimentacao.Controls.Add(dtInfoDtSaida);
            grpMovimentacao.Controls.Add(lblDataSaida);
            grpMovimentacao.Controls.Add(lblDataHoraEntrada);
            grpMovimentacao.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            grpMovimentacao.ForeColor = Color.FromArgb(255, 128, 0);
            grpMovimentacao.Location = new Point(405, 198);
            grpMovimentacao.Name = "grpMovimentacao";
            grpMovimentacao.Size = new Size(486, 124);
            grpMovimentacao.TabIndex = 3;
            grpMovimentacao.TabStop = false;
            grpMovimentacao.Text = "Movimentação";
            // 
            // dtInfoHrSaida
            // 
            dtInfoHrSaida.CustomFormat = "HH:mm";
            dtInfoHrSaida.Format = DateTimePickerFormat.Custom;
            dtInfoHrSaida.Location = new Point(343, 72);
            dtInfoHrSaida.Name = "dtInfoHrSaida";
            dtInfoHrSaida.Size = new Size(72, 27);
            dtInfoHrSaida.TabIndex = 4;
            // 
            // lblHoraSaida
            // 
            lblHoraSaida.AutoSize = true;
            lblHoraSaida.Font = new Font("Segoe UI", 9.75F);
            lblHoraSaida.ForeColor = Color.Black;
            lblHoraSaida.Location = new Point(242, 78);
            lblHoraSaida.Name = "lblHoraSaida";
            lblHoraSaida.Size = new Size(95, 17);
            lblHoraSaida.TabIndex = 4;
            lblHoraSaida.Text = "Hora de Saída:";
            // 
            // dtInfoDtSaida
            // 
            dtInfoDtSaida.Format = DateTimePickerFormat.Custom;
            dtInfoDtSaida.Location = new Point(104, 72);
            dtInfoDtSaida.Name = "dtInfoDtSaida";
            dtInfoDtSaida.Size = new Size(120, 27);
            dtInfoDtSaida.TabIndex = 4;
            dtInfoDtSaida.Value = new DateTime(2026, 11, 26, 18, 10, 28, 0);
            // 
            // lblDataSaida
            // 
            lblDataSaida.AutoSize = true;
            lblDataSaida.Font = new Font("Segoe UI", 9.75F);
            lblDataSaida.ForeColor = Color.Black;
            lblDataSaida.Location = new Point(10, 78);
            lblDataSaida.Name = "lblDataSaida";
            lblDataSaida.Size = new Size(93, 17);
            lblDataSaida.TabIndex = 4;
            lblDataSaida.Text = "Data de Saída:";
            // 
            // lblDataHoraEntrada
            // 
            lblDataHoraEntrada.AutoSize = true;
            lblDataHoraEntrada.Font = new Font("Segoe UI", 9.75F);
            lblDataHoraEntrada.ForeColor = Color.Black;
            lblDataHoraEntrada.Location = new Point(10, 28);
            lblDataHoraEntrada.Name = "lblDataHoraEntrada";
            lblDataHoraEntrada.Size = new Size(148, 17);
            lblDataHoraEntrada.TabIndex = 4;
            lblDataHoraEntrada.Text = "Data / Hora de Entrada:";
            // 
            // grpCalculo
            // 
            grpCalculo.Controls.Add(pnlValorPagar);
            grpCalculo.Controls.Add(txtInfoTarifa);
            grpCalculo.Controls.Add(txtInfoTempoPermanencia);
            grpCalculo.Controls.Add(lblTempoPermanencia);
            grpCalculo.Controls.Add(lblTarifaVigente);
            grpCalculo.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            grpCalculo.ForeColor = Color.FromArgb(255, 128, 0);
            grpCalculo.Location = new Point(405, 328);
            grpCalculo.Name = "grpCalculo";
            grpCalculo.Size = new Size(486, 166);
            grpCalculo.TabIndex = 4;
            grpCalculo.TabStop = false;
            grpCalculo.Text = "Cálculo do Estacionamento";
            // 
            // pnlValorPagar
            // 
            pnlValorPagar.BackColor = Color.FromArgb(215, 240, 215);
            pnlValorPagar.BorderStyle = BorderStyle.FixedSingle;
            pnlValorPagar.Controls.Add(lblValorPagar);
            pnlValorPagar.Controls.Add(lblValorAPagar);
            pnlValorPagar.Location = new Point(21, 108);
            pnlValorPagar.Name = "pnlValorPagar";
            pnlValorPagar.Size = new Size(441, 42);
            pnlValorPagar.TabIndex = 8;
            // 
            // lblValorPagar
            // 
            lblValorPagar.BackColor = Color.Transparent;
            lblValorPagar.Dock = DockStyle.Left;
            lblValorPagar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValorPagar.ForeColor = Color.FromArgb(20, 30, 20);
            lblValorPagar.Location = new Point(0, 0);
            lblValorPagar.Name = "lblValorPagar";
            lblValorPagar.Padding = new Padding(10, 0, 0, 0);
            lblValorPagar.Size = new Size(130, 40);
            lblValorPagar.TabIndex = 5;
            lblValorPagar.Text = "Valor a Pagar:";
            lblValorPagar.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblValorAPagar
            // 
            lblValorAPagar.BackColor = Color.Transparent;
            lblValorAPagar.Dock = DockStyle.Right;
            lblValorAPagar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValorAPagar.ForeColor = Color.FromArgb(10, 55, 15);
            lblValorAPagar.Location = new Point(327, 0);
            lblValorAPagar.Name = "lblValorAPagar";
            lblValorAPagar.Padding = new Padding(0, 0, 12, 0);
            lblValorAPagar.Size = new Size(112, 40);
            lblValorAPagar.TabIndex = 5;
            lblValorAPagar.Text = "R$ 26,50";
            lblValorAPagar.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtInfoTarifa
            // 
            txtInfoTarifa.Location = new Point(104, 69);
            txtInfoTarifa.Name = "txtInfoTarifa";
            txtInfoTarifa.Size = new Size(141, 27);
            txtInfoTarifa.TabIndex = 8;
            // 
            // txtInfoTempoPermanencia
            // 
            txtInfoTempoPermanencia.Location = new Point(162, 25);
            txtInfoTempoPermanencia.Name = "txtInfoTempoPermanencia";
            txtInfoTempoPermanencia.Size = new Size(152, 27);
            txtInfoTempoPermanencia.TabIndex = 8;
            txtInfoTempoPermanencia.TextChanged += textBox1_TextChanged;
            // 
            // lblTempoPermanencia
            // 
            lblTempoPermanencia.AutoSize = true;
            lblTempoPermanencia.Font = new Font("Segoe UI", 9.75F);
            lblTempoPermanencia.ForeColor = Color.Black;
            lblTempoPermanencia.Location = new Point(8, 29);
            lblTempoPermanencia.Name = "lblTempoPermanencia";
            lblTempoPermanencia.Size = new Size(148, 17);
            lblTempoPermanencia.TabIndex = 5;
            lblTempoPermanencia.Text = "Tempo de Permanência:";
            // 
            // lblTarifaVigente
            // 
            lblTarifaVigente.AutoSize = true;
            lblTarifaVigente.Font = new Font("Segoe UI", 9.75F);
            lblTarifaVigente.ForeColor = Color.Black;
            lblTarifaVigente.Location = new Point(8, 72);
            lblTarifaVigente.Name = "lblTarifaVigente";
            lblTarifaVigente.Size = new Size(91, 17);
            lblTarifaVigente.TabIndex = 5;
            lblTarifaVigente.Text = "Tarifa Vigente:";
            // 
            // btnRegistrarSaida
            // 
            btnRegistrarSaida.BackColor = Color.OliveDrab;
            btnRegistrarSaida.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnRegistrarSaida.ForeColor = Color.White;
            btnRegistrarSaida.Image = (Image)resources.GetObject("btnRegistrarSaida.Image");
            btnRegistrarSaida.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarSaida.Location = new Point(567, 504);
            btnRegistrarSaida.Name = "btnRegistrarSaida";
            btnRegistrarSaida.Size = new Size(146, 36);
            btnRegistrarSaida.TabIndex = 6;
            btnRegistrarSaida.Text = "Registrar Saída";
            btnRegistrarSaida.TextAlign = ContentAlignment.MiddleRight;
            btnRegistrarSaida.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(734, 504);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(133, 36);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // txtDataHoraEntrada
            // 
            txtDataHoraEntrada.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            txtDataHoraEntrada.Location = new Point(164, 27);
            txtDataHoraEntrada.Name = "txtDataHoraEntrada";
            txtDataHoraEntrada.ReadOnly = true;
            txtDataHoraEntrada.Size = new Size(173, 27);
            txtDataHoraEntrada.TabIndex = 10;
            txtDataHoraEntrada.Text = "22/01/2026 08:15";
            // 
            // picLogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 552);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrarSaida);
            Controls.Add(grpCalculo);
            Controls.Add(grpMovimentacao);
            Controls.Add(grpDadosVeiculo);
            Controls.Add(grpBuscarVeiculo);
            Controls.Add(pnlCabecalho);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "picLogo";
            Text = "Registrar Saída";
            pnlCabecalho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpBuscarVeiculo.ResumeLayout(false);
            grpBuscarVeiculo.PerformLayout();
            grpDadosVeiculo.ResumeLayout(false);
            grpDadosVeiculo.PerformLayout();
            grpMovimentacao.ResumeLayout(false);
            grpMovimentacao.PerformLayout();
            grpCalculo.ResumeLayout(false);
            grpCalculo.PerformLayout();
            pnlValorPagar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCabecalho;
        private PictureBox pictureBox1;
        private GroupBox grpBuscarVeiculo;
        private Label lblPlacaVeiculo;
        private Button btnBuscarPorPlaca;
        private MaskedTextBox mskPlacaveiculo;
        private GroupBox grpDadosVeiculo;
        private Label lblPlaca;
        private Label lblCliente;
        private Label lblCorModelo;
        private TextBox txtCorModelo;
        private Label lblVaga;
        private GroupBox grpMovimentacao;
        private Label lblDataHoraEntrada;
        private DateTimePicker dtInfoHrSaida;
        private Label lblHoraSaida;
        private DateTimePicker dtInfoDtSaida;
        private Label lblDataSaida;
        private GroupBox grpCalculo;
        private Label lblTempoPermanencia;
        private Label lblValorPagar;
        private Label lblTarifaVigente;
        private Label lblValorAPagar;
        private Button btnRegistrarSaida;
        private TextBox txtPlaca;
        private TextBox txtNomeCliente;
        private TextBox txtNumeroVaga;
        private TextBox txtInfoTempoPermanencia;
        private TextBox txtInfoTarifa;
        private Panel pnlValorPagar;
        private Button btnCancelar;
        private TextBox txtDataHoraEntrada;
    }
}