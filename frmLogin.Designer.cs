namespace WebClientWebSocket
{
    partial class frmLogin
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
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            lbSenha = new Label();
            lbUsuario = new Label();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(116, 81);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(190, 23);
            txtSenha.TabIndex = 11;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(116, 38);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(330, 23);
            txtUsuario.TabIndex = 10;
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            lbSenha.ForeColor = SystemColors.Window;
            lbSenha.ImeMode = ImeMode.NoControl;
            lbSenha.Location = new Point(44, 84);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(48, 20);
            lbSenha.TabIndex = 9;
            lbSenha.Text = "Senha";
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.FlatStyle = FlatStyle.Flat;
            lbUsuario.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            lbUsuario.ForeColor = SystemColors.Window;
            lbUsuario.ImeMode = ImeMode.NoControl;
            lbUsuario.Location = new Point(44, 46);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(57, 20);
            lbUsuario.TabIndex = 8;
            lbUsuario.Text = "Usuário";
            // 
            // button2
            // 
            button2.BackColor = Color.Brown;
            button2.Font = new Font("Arial", 12F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.ImeMode = ImeMode.NoControl;
            button2.Location = new Point(289, 140);
            button2.Name = "button2";
            button2.Size = new Size(157, 39);
            button2.TabIndex = 7;
            button2.Text = "Sair";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.ImeMode = ImeMode.NoControl;
            button1.Location = new Point(116, 138);
            button1.Name = "button1";
            button1.Size = new Size(148, 41);
            button1.TabIndex = 6;
            button1.Text = "Logar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(541, 213);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(lbSenha);
            Controls.Add(lbUsuario);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Autentição";
            FormClosing += frmLogin_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSenha;
        private TextBox txtUsuario;
        private Label lbSenha;
        private Label lbUsuario;
        private Button button2;
        private Button button1;
    }
}