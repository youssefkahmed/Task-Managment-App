namespace FilesProject
{
    partial class EmployeesMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesMenu));
            this.Back = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back.BackgroundImage")));
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(82, 159);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 34);
            this.Back.TabIndex = 2;
            this.Back.Text = "BACK";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Add
            // 
            this.Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Add.BackgroundImage")));
            this.Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Add.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(47, 28);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(143, 42);
            this.Add.TabIndex = 3;
            this.Add.Text = "ADD EMPLOYEE";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Save_Click);
            // 
            // Display
            // 
            this.Display.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Display.BackgroundImage")));
            this.Display.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Display.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.ForeColor = System.Drawing.Color.White;
            this.Display.Location = new System.Drawing.Point(35, 76);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(166, 37);
            this.Display.TabIndex = 4;
            this.Display.Text = "DISPLAY AND EDIT EMPLOYEES";
            this.Display.UseVisualStyleBackColor = true;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // Delete
            // 
            this.Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Delete.BackgroundImage")));
            this.Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Delete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(35, 119);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(166, 34);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "DELETE EMPLOYEES";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // EmployeesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(229, 216);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Back);
            this.Name = "EmployeesMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeesMenu";
            this.Load += new System.EventHandler(this.EmployeesMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Display;
        private System.Windows.Forms.Button Delete;
    }
}