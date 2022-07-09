
namespace GameDataBase
{
    partial class FormCreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateAccount));
            this.Lbl_accName = new System.Windows.Forms.Label();
            this.Txt_accName = new System.Windows.Forms.TextBox();
            this.Txt_accPsw = new System.Windows.Forms.TextBox();
            this.Lbl_accPsw = new System.Windows.Forms.Label();
            this.Btn_mainMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Box_charDisplay = new System.Windows.Forms.PictureBox();
            this.Btn_charSelectPrev = new System.Windows.Forms.PictureBox();
            this.Btn_charSelectNext = new System.Windows.Forms.PictureBox();
            this.Btn_createAcc = new System.Windows.Forms.PictureBox();
            this.Lbl_Error = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Box_charDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_charSelectPrev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_charSelectNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_createAcc)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_accName
            // 
            this.Lbl_accName.AutoSize = true;
            this.Lbl_accName.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_accName.Location = new System.Drawing.Point(12, 18);
            this.Lbl_accName.Name = "Lbl_accName";
            this.Lbl_accName.Size = new System.Drawing.Size(51, 17);
            this.Lbl_accName.TabIndex = 0;
            this.Lbl_accName.Text = "Name";
            this.Lbl_accName.Click += new System.EventHandler(this.label1_Click);
            // 
            // Txt_accName
            // 
            this.Txt_accName.Location = new System.Drawing.Point(12, 36);
            this.Txt_accName.Name = "Txt_accName";
            this.Txt_accName.Size = new System.Drawing.Size(100, 23);
            this.Txt_accName.TabIndex = 1;
            this.Txt_accName.TextChanged += new System.EventHandler(this.Txt_accName_TextChanged);
            // 
            // Txt_accPsw
            // 
            this.Txt_accPsw.Location = new System.Drawing.Point(12, 89);
            this.Txt_accPsw.Name = "Txt_accPsw";
            this.Txt_accPsw.Size = new System.Drawing.Size(100, 23);
            this.Txt_accPsw.TabIndex = 2;
            // 
            // Lbl_accPsw
            // 
            this.Lbl_accPsw.AutoSize = true;
            this.Lbl_accPsw.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_accPsw.Location = new System.Drawing.Point(12, 71);
            this.Lbl_accPsw.Name = "Lbl_accPsw";
            this.Lbl_accPsw.Size = new System.Drawing.Size(83, 17);
            this.Lbl_accPsw.TabIndex = 3;
            this.Lbl_accPsw.Text = "Password";
            this.Lbl_accPsw.Click += new System.EventHandler(this.Lbl_accPsw_Click);
            // 
            // Btn_mainMenu
            // 
            this.Btn_mainMenu.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_mainMenu.Location = new System.Drawing.Point(537, 405);
            this.Btn_mainMenu.Name = "Btn_mainMenu";
            this.Btn_mainMenu.Size = new System.Drawing.Size(75, 23);
            this.Btn_mainMenu.TabIndex = 4;
            this.Btn_mainMenu.Text = "Return";
            this.Btn_mainMenu.UseVisualStyleBackColor = true;
            this.Btn_mainMenu.Click += new System.EventHandler(this.Btn_mainMenu_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::GameDataBase.Properties.Resources.Asset_3;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Box_charDisplay);
            this.panel1.Location = new System.Drawing.Point(210, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 351);
            this.panel1.TabIndex = 5;
            // 
            // Box_charDisplay
            // 
            this.Box_charDisplay.BackColor = System.Drawing.Color.Transparent;
            this.Box_charDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Box_charDisplay.Image = global::GameDataBase.Properties.Resources.HeadBeige;
            this.Box_charDisplay.Location = new System.Drawing.Point(31, 107);
            this.Box_charDisplay.Name = "Box_charDisplay";
            this.Box_charDisplay.Size = new System.Drawing.Size(163, 166);
            this.Box_charDisplay.TabIndex = 0;
            this.Box_charDisplay.TabStop = false;
            this.Box_charDisplay.Click += new System.EventHandler(this.Box_charDisplay_Click);
            // 
            // Btn_charSelectPrev
            // 
            this.Btn_charSelectPrev.BackColor = System.Drawing.Color.Transparent;
            this.Btn_charSelectPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_charSelectPrev.Image = global::GameDataBase.Properties.Resources.Asset_1;
            this.Btn_charSelectPrev.Location = new System.Drawing.Point(122, 314);
            this.Btn_charSelectPrev.Name = "Btn_charSelectPrev";
            this.Btn_charSelectPrev.Size = new System.Drawing.Size(82, 55);
            this.Btn_charSelectPrev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_charSelectPrev.TabIndex = 0;
            this.Btn_charSelectPrev.TabStop = false;
            this.Btn_charSelectPrev.Click += new System.EventHandler(this.Btn_charSelectPrev_Click);
            // 
            // Btn_charSelectNext
            // 
            this.Btn_charSelectNext.BackColor = System.Drawing.Color.Transparent;
            this.Btn_charSelectNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_charSelectNext.Image = ((System.Drawing.Image)(resources.GetObject("Btn_charSelectNext.Image")));
            this.Btn_charSelectNext.Location = new System.Drawing.Point(436, 314);
            this.Btn_charSelectNext.Name = "Btn_charSelectNext";
            this.Btn_charSelectNext.Size = new System.Drawing.Size(82, 55);
            this.Btn_charSelectNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_charSelectNext.TabIndex = 6;
            this.Btn_charSelectNext.TabStop = false;
            this.Btn_charSelectNext.Click += new System.EventHandler(this.Btn_charSelectNext_Click);
            // 
            // Btn_createAcc
            // 
            this.Btn_createAcc.Image = global::GameDataBase.Properties.Resources.Asset_4;
            this.Btn_createAcc.Location = new System.Drawing.Point(200, 375);
            this.Btn_createAcc.Name = "Btn_createAcc";
            this.Btn_createAcc.Size = new System.Drawing.Size(240, 53);
            this.Btn_createAcc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_createAcc.TabIndex = 7;
            this.Btn_createAcc.TabStop = false;
            this.Btn_createAcc.Click += new System.EventHandler(this.Btn_createAcc_Click);
            this.Btn_createAcc.MouseLeave += new System.EventHandler(this.Btn_createAcc_MouseLeave);
            this.Btn_createAcc.MouseHover += new System.EventHandler(this.Btn_createAcc_MouseHover);
            // 
            // Lbl_Error
            // 
            this.Lbl_Error.AutoSize = true;
            this.Lbl_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Error.ForeColor = System.Drawing.Color.Firebrick;
            this.Lbl_Error.Location = new System.Drawing.Point(12, 125);
            this.Lbl_Error.Name = "Lbl_Error";
            this.Lbl_Error.Size = new System.Drawing.Size(179, 16);
            this.Lbl_Error.TabIndex = 8;
            this.Lbl_Error.Text = "Provide name and password";
            this.Lbl_Error.Visible = false;
            this.Lbl_Error.Click += new System.EventHandler(this.Lbl_Error_Click);
            // 
            // FormCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.Lbl_Error);
            this.Controls.Add(this.Btn_createAcc);
            this.Controls.Add(this.Btn_charSelectNext);
            this.Controls.Add(this.Btn_charSelectPrev);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_mainMenu);
            this.Controls.Add(this.Lbl_accPsw);
            this.Controls.Add(this.Txt_accPsw);
            this.Controls.Add(this.Txt_accName);
            this.Controls.Add(this.Lbl_accName);
            this.Name = "FormCreateAccount";
            this.Text = "Create Account";
            this.Load += new System.EventHandler(this.FormCreateAccount_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Box_charDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_charSelectPrev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_charSelectNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_createAcc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_accName;
        private System.Windows.Forms.TextBox Txt_accName;
        private System.Windows.Forms.TextBox Txt_accPsw;
        private System.Windows.Forms.Label Lbl_accPsw;
        private System.Windows.Forms.Button Btn_mainMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Btn_charSelectPrev;
        private System.Windows.Forms.PictureBox Btn_charSelectNext;
        private System.Windows.Forms.PictureBox Btn_createAcc;
        private System.Windows.Forms.Label Lbl_Error;
        private System.Windows.Forms.PictureBox Box_charDisplay;
    }
}