namespace FilesProject
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.MyTasks = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MyTasks
            // 
            this.MyTasks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MyTasks.BackgroundImage")));
            this.MyTasks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MyTasks.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyTasks.ForeColor = System.Drawing.Color.White;
            this.MyTasks.Location = new System.Drawing.Point(36, 48);
            this.MyTasks.Name = "MyTasks";
            this.MyTasks.Size = new System.Drawing.Size(101, 45);
            this.MyTasks.TabIndex = 7;
            this.MyTasks.Text = "My Tasks";
            this.MyTasks.UseVisualStyleBackColor = true;
            this.MyTasks.Click += new System.EventHandler(this.MyTasks_Click);
            // 
            // Back
            // 
            this.Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back.BackgroundImage")));
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(36, 110);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(101, 45);
            this.Back.TabIndex = 6;
            this.Back.Text = "BACK";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(168, 201);
            this.Controls.Add(this.MyTasks);
            this.Controls.Add(this.Back);
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MyTasks;
        private System.Windows.Forms.Button Back;
    }
}