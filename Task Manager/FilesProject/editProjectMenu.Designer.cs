namespace FilesProject
{
    partial class editProjectMenu
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
            this.ChangeN = new System.Windows.Forms.Button();
            this.ChangeT = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChangeN
            // 
            this.ChangeN.BackgroundImage = global::FilesProject.Properties.Resources.orange_or_whatever;
            this.ChangeN.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeN.ForeColor = System.Drawing.Color.White;
            this.ChangeN.Location = new System.Drawing.Point(31, 33);
            this.ChangeN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChangeN.Name = "ChangeN";
            this.ChangeN.Size = new System.Drawing.Size(94, 54);
            this.ChangeN.TabIndex = 0;
            this.ChangeN.Text = "CHANGE PROJECT NAME";
            this.ChangeN.UseVisualStyleBackColor = true;
            this.ChangeN.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ChangeT
            // 
            this.ChangeT.BackgroundImage = global::FilesProject.Properties.Resources.orange_or_whatever;
            this.ChangeT.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeT.ForeColor = System.Drawing.Color.White;
            this.ChangeT.Location = new System.Drawing.Point(31, 115);
            this.ChangeT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChangeT.Name = "ChangeT";
            this.ChangeT.Size = new System.Drawing.Size(94, 49);
            this.ChangeT.TabIndex = 1;
            this.ChangeT.Text = "CHANGE PROJECT TASKS";
            this.ChangeT.UseVisualStyleBackColor = true;
            this.ChangeT.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Back
            // 
            this.Back.BackgroundImage = global::FilesProject.Properties.Resources.orange_or_whatever;
            this.Back.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(31, 199);
            this.Back.Margin = new System.Windows.Forms.Padding(2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(94, 49);
            this.Back.TabIndex = 2;
            this.Back.Text = "BACK";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // editProjectMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FilesProject.Properties.Resources.img;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(158, 274);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.ChangeT);
            this.Controls.Add(this.ChangeN);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "editProjectMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "editProjectMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ChangeN;
        private System.Windows.Forms.Button ChangeT;
        private System.Windows.Forms.Button Back;
    }
}