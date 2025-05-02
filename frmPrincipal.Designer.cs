namespace WebClientWebSocket
{
    partial class frmPrincipal
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
            btnRealizarLeitura = new Button();
            txtLinhas = new TextBox();
            btnPararLeitura = new Button();
            Rodape = new StatusStrip();
            label1 = new Label();
            NumeroLimite = new NumericUpDown();
            lblUltimoTipo = new Label();
            lbQtdeRegistro = new Label();
            RodapeTexto1 = new ToolStripStatusLabel();
            Rodape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumeroLimite).BeginInit();
            SuspendLayout();
            // 
            // btnRealizarLeitura
            // 
            btnRealizarLeitura.BackColor = Color.LightSteelBlue;
            btnRealizarLeitura.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRealizarLeitura.ForeColor = Color.WhiteSmoke;
            btnRealizarLeitura.Location = new Point(12, 13);
            btnRealizarLeitura.Name = "btnRealizarLeitura";
            btnRealizarLeitura.Size = new Size(325, 57);
            btnRealizarLeitura.TabIndex = 0;
            btnRealizarLeitura.Text = "Realizar a leitura";
            btnRealizarLeitura.UseVisualStyleBackColor = false;
            btnRealizarLeitura.Click += btnRealizarLeitura_Click;
            // 
            // txtLinhas
            // 
            txtLinhas.AcceptsReturn = true;
            txtLinhas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLinhas.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLinhas.Location = new Point(12, 171);
            txtLinhas.Multiline = true;
            txtLinhas.Name = "txtLinhas";
            txtLinhas.ScrollBars = ScrollBars.Vertical;
            txtLinhas.Size = new Size(1436, 511);
            txtLinhas.TabIndex = 1;
            txtLinhas.WordWrap = false;
            // 
            // btnPararLeitura
            // 
            btnPararLeitura.BackColor = Color.Crimson;
            btnPararLeitura.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPararLeitura.ForeColor = Color.Transparent;
            btnPararLeitura.Location = new Point(12, 12);
            btnPararLeitura.Name = "btnPararLeitura";
            btnPararLeitura.Size = new Size(325, 61);
            btnPararLeitura.TabIndex = 2;
            btnPararLeitura.Text = "Parar a leitura";
            btnPararLeitura.UseVisualStyleBackColor = false;
            btnPararLeitura.Visible = false;
            btnPararLeitura.Click += btnPararLeitura_Click;
            // 
            // Rodape
            // 
            Rodape.BackColor = SystemColors.ButtonFace;
            Rodape.Items.AddRange(new ToolStripItem[] { RodapeTexto1 });
            Rodape.Location = new Point(0, 696);
            Rodape.Name = "Rodape";
            Rodape.Size = new Size(1460, 22);
            Rodape.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 123);
            label1.Name = "label1";
            label1.Size = new Size(199, 25);
            label1.TabIndex = 4;
            label1.Text = "Limite de Resultados:";
            // 
            // NumeroLimite
            // 
            NumeroLimite.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NumeroLimite.Location = new Point(217, 119);
            NumeroLimite.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            NumeroLimite.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            NumeroLimite.Name = "NumeroLimite";
            NumeroLimite.Size = new Size(120, 29);
            NumeroLimite.TabIndex = 5;
            NumeroLimite.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // lblUltimoTipo
            // 
            lblUltimoTipo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblUltimoTipo.AutoSize = true;
            lblUltimoTipo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUltimoTipo.ForeColor = SystemColors.ButtonHighlight;
            lblUltimoTipo.Location = new Point(366, 32);
            lblUltimoTipo.Name = "lblUltimoTipo";
            lblUltimoTipo.Size = new Size(27, 25);
            lblUltimoTipo.TabIndex = 6;
            lblUltimoTipo.Text = ":::";
            lblUltimoTipo.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lbQtdeRegistro
            // 
            lbQtdeRegistro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbQtdeRegistro.AutoSize = true;
            lbQtdeRegistro.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbQtdeRegistro.ForeColor = SystemColors.ButtonHighlight;
            lbQtdeRegistro.Location = new Point(366, 123);
            lbQtdeRegistro.Name = "lbQtdeRegistro";
            lbQtdeRegistro.Size = new Size(27, 25);
            lbQtdeRegistro.TabIndex = 7;
            lbQtdeRegistro.Text = ":::";
            // 
            // RodapeTexto1
            // 
            RodapeTexto1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RodapeTexto1.ForeColor = Color.Black;
            RodapeTexto1.Name = "RodapeTexto1";
            RodapeTexto1.Size = new Size(110, 17);
            RodapeTexto1.Text = "Não autenticado";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1460, 718);
            Controls.Add(lbQtdeRegistro);
            Controls.Add(lblUltimoTipo);
            Controls.Add(btnRealizarLeitura);
            Controls.Add(NumeroLimite);
            Controls.Add(label1);
            Controls.Add(Rodape);
            Controls.Add(btnPararLeitura);
            Controls.Add(txtLinhas);
            ForeColor = Color.White;
            Name = "frmPrincipal";
            Text = "WebSocket finance";
            WindowState = FormWindowState.Maximized;
            Shown += frmPrincipal_Shown;
            Rodape.ResumeLayout(false);
            Rodape.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumeroLimite).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRealizarLeitura;
        private TextBox txtLinhas;
        private Button btnPararLeitura;
        private StatusStrip Rodape;
        private Label label1;
        private NumericUpDown NumeroLimite;
        private Label lblUltimoTipo;
        private Label lbQtdeRegistro;
        private ToolStripStatusLabel RodapeTexto1;
    }
}
