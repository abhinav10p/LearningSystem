namespace LearningSystem
{
    partial class Register
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tTadioButton = new System.Windows.Forms.RadioButton();
            this.stRadioButton = new System.Windows.Forms.RadioButton();
            this.contactBox = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sumitButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.retypePassword = new System.Windows.Forms.MaskedTextBox();
            this.paswordBox = new System.Windows.Forms.MaskedTextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::LearningSystem.Properties.Resources.wp2249188_grey_color_wallpapers;
            this.panel1.Controls.Add(this.tTadioButton);
            this.panel1.Controls.Add(this.stRadioButton);
            this.panel1.Controls.Add(this.contactBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.sumitButton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.retypePassword);
            this.panel1.Controls.Add(this.paswordBox);
            this.panel1.Controls.Add(this.lastNameBox);
            this.panel1.Controls.Add(this.firstNameBox);
            this.panel1.Controls.Add(this.emailBox);
            this.panel1.Location = new System.Drawing.Point(27, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 401);
            this.panel1.TabIndex = 0;
            // 
            // tTadioButton
            // 
            this.tTadioButton.AutoSize = true;
            this.tTadioButton.BackColor = System.Drawing.Color.Transparent;
            this.tTadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tTadioButton.Location = new System.Drawing.Point(332, 217);
            this.tTadioButton.Name = "tTadioButton";
            this.tTadioButton.Size = new System.Drawing.Size(70, 19);
            this.tTadioButton.TabIndex = 5;
            this.tTadioButton.TabStop = true;
            this.tTadioButton.Text = "Teacher";
            this.tTadioButton.UseVisualStyleBackColor = false;
            // 
            // stRadioButton
            // 
            this.stRadioButton.AutoSize = true;
            this.stRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.stRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stRadioButton.Location = new System.Drawing.Point(259, 217);
            this.stRadioButton.Name = "stRadioButton";
            this.stRadioButton.Size = new System.Drawing.Size(67, 19);
            this.stRadioButton.TabIndex = 4;
            this.stRadioButton.TabStop = true;
            this.stRadioButton.Text = "Student";
            this.stRadioButton.UseVisualStyleBackColor = false;
            // 
            // contactBox
            // 
            this.contactBox.Location = new System.Drawing.Point(259, 191);
            this.contactBox.Name = "contactBox";
            this.contactBox.Size = new System.Drawing.Size(201, 20);
            this.contactBox.TabIndex = 3;
            this.contactBox.Tag = "c";
            this.contactBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.contactBox_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(258, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 40;
            this.label6.Text = "Contact No";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sumitButton
            // 
            this.sumitButton.Location = new System.Drawing.Point(259, 361);
            this.sumitButton.Name = "sumitButton";
            this.sumitButton.Size = new System.Drawing.Size(88, 23);
            this.sumitButton.TabIndex = 8;
            this.sumitButton.Text = "Submit";
            this.sumitButton.UseVisualStyleBackColor = true;
            this.sumitButton.Click += new System.EventHandler(this.sumitButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(259, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 15);
            this.label5.TabIndex = 40;
            this.label5.Text = "Retype Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(259, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 40;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(259, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 40;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(259, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 40;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(259, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 40;
            this.label1.Text = "Email";
            // 
            // retypePassword
            // 
            this.retypePassword.Location = new System.Drawing.Point(259, 324);
            this.retypePassword.Name = "retypePassword";
            this.retypePassword.PasswordChar = '*';
            this.retypePassword.Size = new System.Drawing.Size(201, 20);
            this.retypePassword.TabIndex = 7;
            this.retypePassword.Tag = "p";
            this.retypePassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.contactBox_KeyDown);
            // 
            // paswordBox
            // 
            this.paswordBox.Location = new System.Drawing.Point(259, 274);
            this.paswordBox.Name = "paswordBox";
            this.paswordBox.PasswordChar = '*';
            this.paswordBox.Size = new System.Drawing.Size(201, 20);
            this.paswordBox.TabIndex = 6;
            this.paswordBox.Tag = "p";
            this.paswordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.contactBox_KeyDown);
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(259, 138);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(201, 20);
            this.lastNameBox.TabIndex = 2;
            this.lastNameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.contactBox_KeyDown);
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(259, 86);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(201, 20);
            this.firstNameBox.TabIndex = 1;
            this.firstNameBox.Tag = "x";
            this.firstNameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.contactBox_KeyDown);
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(259, 38);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(201, 20);
            this.emailBox.TabIndex = 0;
            this.emailBox.Tag = "x";
            this.emailBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.contactBox_KeyDown);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(765, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(21, 20);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "X";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(788, 457);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.VisibleChanged += new System.EventHandler(this.Register_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox retypePassword;
        private System.Windows.Forms.MaskedTextBox paswordBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button sumitButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.MaskedTextBox contactBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RadioButton tTadioButton;
        private System.Windows.Forms.RadioButton stRadioButton;
    }
}