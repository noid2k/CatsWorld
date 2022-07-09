
namespace GameDataBase
{
    partial class Form_menu
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
            this.Lbl_GameTitle = new System.Windows.Forms.Label();
            this.Btn_createAcc = new System.Windows.Forms.Button();
            this.Btn_login = new System.Windows.Forms.Button();
            this.Btn_exit = new System.Windows.Forms.Button();
            this.Lbl_AccName = new System.Windows.Forms.Label();
            this.Lbl_AccPsw = new System.Windows.Forms.Label();
            this.Txt_accNameLogin = new System.Windows.Forms.TextBox();
            this.Txt_accPswLogin = new System.Windows.Forms.TextBox();
            this.Btn_continueLogin = new System.Windows.Forms.Button();
            this.Lbl_Error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_GameTitle
            // 
            this.Lbl_GameTitle.AutoSize = true;
            this.Lbl_GameTitle.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_GameTitle.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_GameTitle.Location = new System.Drawing.Point(194, 9);
            this.Lbl_GameTitle.Name = "Lbl_GameTitle";
            this.Lbl_GameTitle.Size = new System.Drawing.Size(274, 55);
            this.Lbl_GameTitle.TabIndex = 0;
            this.Lbl_GameTitle.Text = "Cat World";
            this.Lbl_GameTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // Btn_createAcc
            // 
            this.Btn_createAcc.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_createAcc.Location = new System.Drawing.Point(12, 406);
            this.Btn_createAcc.Name = "Btn_createAcc";
            this.Btn_createAcc.Size = new System.Drawing.Size(120, 23);
            this.Btn_createAcc.TabIndex = 1;
            this.Btn_createAcc.Text = "Create Account";
            this.Btn_createAcc.UseVisualStyleBackColor = true;
            this.Btn_createAcc.Click += new System.EventHandler(this.Btn_createAcc_Click);
            // 
            // Btn_login
            // 
            this.Btn_login.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_login.Location = new System.Drawing.Point(260, 406);
            this.Btn_login.Name = "Btn_login";
            this.Btn_login.Size = new System.Drawing.Size(120, 23);
            this.Btn_login.TabIndex = 2;
            this.Btn_login.Text = "Login";
            this.Btn_login.UseVisualStyleBackColor = true;
            this.Btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // Btn_exit
            // 
            this.Btn_exit.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_exit.Location = new System.Drawing.Point(492, 406);
            this.Btn_exit.Name = "Btn_exit";
            this.Btn_exit.Size = new System.Drawing.Size(120, 23);
            this.Btn_exit.TabIndex = 3;
            this.Btn_exit.Text = "Exit";
            this.Btn_exit.UseVisualStyleBackColor = true;
            this.Btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // Lbl_AccName
            // 
            this.Lbl_AccName.AutoSize = true;
            this.Lbl_AccName.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_AccName.Location = new System.Drawing.Point(240, 124);
            this.Lbl_AccName.Name = "Lbl_AccName";
            this.Lbl_AccName.Size = new System.Drawing.Size(126, 19);
            this.Lbl_AccName.TabIndex = 4;
            this.Lbl_AccName.Text = "Account Name";
            this.Lbl_AccName.Visible = false;
            // 
            // Lbl_AccPsw
            // 
            this.Lbl_AccPsw.AutoSize = true;
            this.Lbl_AccPsw.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_AccPsw.Location = new System.Drawing.Point(240, 186);
            this.Lbl_AccPsw.Name = "Lbl_AccPsw";
            this.Lbl_AccPsw.Size = new System.Drawing.Size(90, 19);
            this.Lbl_AccPsw.TabIndex = 5;
            this.Lbl_AccPsw.Text = "Password";
            this.Lbl_AccPsw.Visible = false;
            // 
            // Txt_accNameLogin
            // 
            this.Txt_accNameLogin.Location = new System.Drawing.Point(240, 147);
            this.Txt_accNameLogin.Name = "Txt_accNameLogin";
            this.Txt_accNameLogin.Size = new System.Drawing.Size(160, 23);
            this.Txt_accNameLogin.TabIndex = 6;
            this.Txt_accNameLogin.Visible = false;
            // 
            // Txt_accPswLogin
            // 
            this.Txt_accPswLogin.Location = new System.Drawing.Point(240, 204);
            this.Txt_accPswLogin.Name = "Txt_accPswLogin";
            this.Txt_accPswLogin.Size = new System.Drawing.Size(160, 23);
            this.Txt_accPswLogin.TabIndex = 7;
            this.Txt_accPswLogin.Visible = false;
            // 
            // Btn_continueLogin
            // 
            this.Btn_continueLogin.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_continueLogin.Location = new System.Drawing.Point(260, 254);
            this.Btn_continueLogin.Name = "Btn_continueLogin";
            this.Btn_continueLogin.Size = new System.Drawing.Size(120, 23);
            this.Btn_continueLogin.TabIndex = 8;
            this.Btn_continueLogin.Text = "Continue";
            this.Btn_continueLogin.UseVisualStyleBackColor = true;
            this.Btn_continueLogin.Visible = false;
            this.Btn_continueLogin.Click += new System.EventHandler(this.Btn_continueLogin_Click);
            // 
            // Lbl_Error
            // 
            this.Lbl_Error.AutoSize = true;
            this.Lbl_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Error.ForeColor = System.Drawing.Color.Firebrick;
            this.Lbl_Error.Location = new System.Drawing.Point(231, 230);
            this.Lbl_Error.Name = "Lbl_Error";
            this.Lbl_Error.Size = new System.Drawing.Size(179, 16);
            this.Lbl_Error.TabIndex = 9;
            this.Lbl_Error.Text = "Provide name and password";
            this.Lbl_Error.Visible = false;
            // 
            // Form_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.Lbl_Error);
            this.Controls.Add(this.Btn_continueLogin);
            this.Controls.Add(this.Txt_accPswLogin);
            this.Controls.Add(this.Txt_accNameLogin);
            this.Controls.Add(this.Lbl_AccPsw);
            this.Controls.Add(this.Lbl_AccName);
            this.Controls.Add(this.Btn_exit);
            this.Controls.Add(this.Btn_login);
            this.Controls.Add(this.Btn_createAcc);
            this.Controls.Add(this.Lbl_GameTitle);
            this.Name = "Form_menu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form_menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_GameTitle;
        private System.Windows.Forms.Button Btn_createAcc;
        private System.Windows.Forms.Button Btn_login;
        private System.Windows.Forms.Button Btn_exit;
        private System.Windows.Forms.Label Lbl_AccName;
        private System.Windows.Forms.Label Lbl_AccPsw;
        private System.Windows.Forms.TextBox Txt_accNameLogin;
        private System.Windows.Forms.TextBox Txt_accPswLogin;
        private System.Windows.Forms.Button Btn_continueLogin;
        private System.Windows.Forms.Label Lbl_Error;
    }
}

