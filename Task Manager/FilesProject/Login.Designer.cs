namespace FilesProject
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.unLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.unText = new System.Windows.Forms.TextBox();
            this.passText = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.loginB = new System.Windows.Forms.Button();
            this.utComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // unLabel
            // 
            this.unLabel.AutoSize = true;
            this.unLabel.BackColor = System.Drawing.Color.Transparent;
            this.unLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unLabel.ForeColor = System.Drawing.Color.White;
            this.unLabel.Location = new System.Drawing.Point(16, 79);
            this.unLabel.Name = "unLabel";
            this.unLabel.Size = new System.Drawing.Size(63, 14);
            this.unLabel.TabIndex = 0;
            this.unLabel.Text = "Username";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.BackColor = System.Drawing.Color.Transparent;
            this.passLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.ForeColor = System.Drawing.Color.White;
            this.passLabel.Location = new System.Drawing.Point(16, 121);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(63, 14);
            this.passLabel.TabIndex = 1;
            this.passLabel.Text = "Password";
            // 
            // unText
            // 
            this.unText.Location = new System.Drawing.Point(124, 75);
            this.unText.Name = "unText";
            this.unText.Size = new System.Drawing.Size(135, 20);
            this.unText.TabIndex = 2;
            this.unText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(124, 117);
            this.passText.Name = "passText";
            this.passText.PasswordChar = '*';
            this.passText.Size = new System.Drawing.Size(135, 20);
            this.passText.TabIndex = 3;
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(184, 211);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 45);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "E&XIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // loginB
            // 
            this.loginB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginB.BackgroundImage")));
            this.loginB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginB.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginB.ForeColor = System.Drawing.Color.White;
            this.loginB.Location = new System.Drawing.Point(20, 211);
            this.loginB.Name = "loginB";
            this.loginB.Size = new System.Drawing.Size(75, 45);
            this.loginB.TabIndex = 5;
            this.loginB.Text = "LOGIN";
            this.loginB.UseVisualStyleBackColor = true;
            this.loginB.Click += new System.EventHandler(this.button2_Click);
            // 
            // utComboBox
            // 
            this.utComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.utComboBox.FormattingEnabled = true;
            this.utComboBox.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.utComboBox.Location = new System.Drawing.Point(124, 160);
            this.utComboBox.Name = "utComboBox";
            this.utComboBox.Size = new System.Drawing.Size(135, 21);
            this.utComboBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "User Type";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(291, 285);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.utComboBox);
            this.Controls.Add(this.loginB);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.unText);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.unLabel);
            this.DoubleBuffered = true;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label unLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox unText;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button loginB;
        private System.Windows.Forms.ComboBox utComboBox;
        private System.Windows.Forms.Label label1;
    }
}

