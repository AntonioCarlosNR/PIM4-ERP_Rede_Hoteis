
namespace PIM4
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn1sair = new System.Windows.Forms.Button();
            this.btn2entrar = new System.Windows.Forms.Button();
            this.lbl1login = new System.Windows.Forms.Label();
            this.lbl2senha = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(447, 404);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn1sair
            // 
            this.btn1sair.Location = new System.Drawing.Point(678, 226);
            this.btn1sair.Name = "btn1sair";
            this.btn1sair.Size = new System.Drawing.Size(93, 40);
            this.btn1sair.TabIndex = 1;
            this.btn1sair.Text = "Sair";
            this.btn1sair.UseVisualStyleBackColor = false;
            this.btn1sair.Click += new System.EventHandler(this.btn1sair_Click);
            // 
            // btn2entrar
            // 
            this.btn2entrar.Location = new System.Drawing.Point(561, 226);
            this.btn2entrar.Name = "btn2entrar";
            this.btn2entrar.Size = new System.Drawing.Size(93, 40);
            this.btn2entrar.TabIndex = 2;
            this.btn2entrar.Text = "Entrar";
            this.btn2entrar.UseVisualStyleBackColor = false;
            this.btn2entrar.Click += new System.EventHandler(this.btn2entrar_Click);
            // 
            // lbl1login
            // 
            this.lbl1login.AutoSize = true;
            this.lbl1login.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl1login.Location = new System.Drawing.Point(482, 103);
            this.lbl1login.Name = "lbl1login";
            this.lbl1login.Size = new System.Drawing.Size(73, 21);
            this.lbl1login.TabIndex = 3;
            this.lbl1login.Text = "LOGIN";
            // 
            // lbl2senha
            // 
            this.lbl2senha.AutoSize = true;
            this.lbl2senha.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl2senha.Location = new System.Drawing.Point(480, 163);
            this.lbl2senha.Name = "lbl2senha";
            this.lbl2senha.Size = new System.Drawing.Size(75, 21);
            this.lbl2senha.TabIndex = 4;
            this.lbl2senha.Text = "SENHA";
            this.lbl2senha.Click += new System.EventHandler(this.lbl2senha_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(561, 101);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(210, 27);
            this.txtLogin.TabIndex = 5;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(561, 163);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(210, 27);
            this.txtSenha.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lbl2senha);
            this.Controls.Add(this.lbl1login);
            this.Controls.Add(this.btn2entrar);
            this.Controls.Add(this.btn1sair);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "z\\";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn1sair;
        private System.Windows.Forms.Button btn2entrar;
        private System.Windows.Forms.Label lbl1login;
        private System.Windows.Forms.Label lbl2senha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
    }
}

