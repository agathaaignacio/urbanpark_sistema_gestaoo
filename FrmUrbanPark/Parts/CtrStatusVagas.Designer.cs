namespace FrmUrbanPark.Parts
{
    partial class CtrStatusVagas
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrStatusVagas));
            pictureBox1 = new PictureBox();
            lblStatusVaga = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(44, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblStatusVaga
            // 
            lblStatusVaga.AutoSize = true;
            lblStatusVaga.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatusVaga.Location = new Point(49, 25);
            lblStatusVaga.Name = "lblStatusVaga";
            lblStatusVaga.Size = new Size(49, 23);
            lblStatusVaga.TabIndex = 1;
            lblStatusVaga.Text = "LIVRE";
            lblStatusVaga.Click += label1_Click;
            // 
            // CtrStatusVagas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 247, 231);
            Controls.Add(lblStatusVaga);
            Controls.Add(pictureBox1);
            Name = "CtrStatusVagas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblStatusVaga;
    }
}
