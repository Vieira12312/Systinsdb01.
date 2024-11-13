namespace SysTINSApp
{
    partial class FrmLogin
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
            txtEmail = new TextBox();
            btnCancelar = new Button();
            btnEntrar = new Button();
            label2 = new Label();
            label1 = new Label();
            lblMensagem = new Label();
            SuspendLayout();
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(371, 245);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(254, 23);
            txtSenha.TabIndex = 20;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(371, 196);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(254, 23);
            txtEmail.TabIndex = 21;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(452, 295);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "&Cencelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(371, 295);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 23;
            btnEntrar.Text = "&Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label2.Location = new Point(371, 171);
            label2.Name = "label2";
            label2.Size = new Size(51, 22);
            label2.TabIndex = 24;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label1.Location = new Point(371, 222);
            label1.Name = "label1";
            label1.Size = new Size(54, 22);
            label1.TabIndex = 25;
            label1.Text = "Senha";
            label1.Click += label1_Click;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensagem.ForeColor = Color.Tomato;
            lblMensagem.Location = new Point(374, 270);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(0, 22);
            lblMensagem.TabIndex = 26;
            // 
            // FrmLogin
            // 
            AcceptButton = btnEntrar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            CancelButton = btnCancelar;
            ClientSize = new Size(954, 527);
            ControlBox = false;
            Controls.Add(lblMensagem);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btnEntrar);
            Controls.Add(btnCancelar);
            Controls.Add(txtEmail);
            Controls.Add(txtSenha);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSenha;
        private TextBox txtEmail;
        private Button btnCancelar;
        private Button btnEntrar;
        private Label label2;
        private Label label1;
        private Label lblMensagem;
    }
}