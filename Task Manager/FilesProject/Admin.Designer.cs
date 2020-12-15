namespace FilesProject
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.pMenu = new System.Windows.Forms.Button();
            this.tMenu = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.eMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pMenu.BackgroundImage")));
            this.pMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pMenu.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pMenu.ForeColor = System.Drawing.Color.White;
            this.pMenu.Location = new System.Drawing.Point(12, 51);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(101, 56);
            this.pMenu.TabIndex = 0;
            this.pMenu.Text = "PROJECTS MENU";
            this.pMenu.UseVisualStyleBackColor = true;
            this.pMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // tMenu
            // 
            this.tMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tMenu.BackgroundImage")));
            this.tMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tMenu.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMenu.ForeColor = System.Drawing.Color.White;
            this.tMenu.Location = new System.Drawing.Point(148, 51);
            this.tMenu.Name = "tMenu";
            this.tMenu.Size = new System.Drawing.Size(101, 56);
            this.tMenu.TabIndex = 1;
            this.tMenu.Text = "TASKS MENU";
            this.tMenu.UseVisualStyleBackColor = true;
            this.tMenu.Click += new System.EventHandler(this.button2_Click);
            // 
            // Back
            // 
            this.Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back.BackgroundImage")));
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(148, 164);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(101, 56);
            this.Back.TabIndex = 2;
            this.Back.Text = "BACK";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.button3_Click);
            // 
            // eMenu
            // 
            this.eMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eMenu.BackgroundImage")));
            this.eMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eMenu.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eMenu.ForeColor = System.Drawing.Color.White;
            this.eMenu.Location = new System.Drawing.Point(12, 164);
            this.eMenu.Name = "eMenu";
            this.eMenu.Size = new System.Drawing.Size(101, 56);
            this.eMenu.TabIndex = 3;
            this.eMenu.Text = "EMPLOYEES MENU";
            this.eMenu.UseVisualStyleBackColor = true;
            this.eMenu.Click += new System.EventHandler(this.button4_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(261, 243);
            this.Controls.Add(this.eMenu);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.tMenu);
            this.Controls.Add(this.pMenu);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pMenu;
        private System.Windows.Forms.Button tMenu;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button eMenu;
    }
}