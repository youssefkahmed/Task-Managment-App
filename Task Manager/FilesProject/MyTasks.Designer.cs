namespace FilesProject
{
    partial class MyTasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyTasks));
            this.tDGV = new System.Windows.Forms.DataGridView();
            this.eDGV = new System.Windows.Forms.DataGridView();
            this.unLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.Forward = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Update = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tDGV
            // 
            this.tDGV.AllowUserToAddRows = false;
            this.tDGV.AllowUserToDeleteRows = false;
            this.tDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tDGV.Location = new System.Drawing.Point(12, 36);
            this.tDGV.Name = "tDGV";
            this.tDGV.ReadOnly = true;
            this.tDGV.RowHeadersWidth = 51;
            this.tDGV.Size = new System.Drawing.Size(440, 150);
            this.tDGV.TabIndex = 0;
            this.tDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tDGV_CellClick);
            // 
            // eDGV
            // 
            this.eDGV.AllowUserToAddRows = false;
            this.eDGV.AllowUserToDeleteRows = false;
            this.eDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eDGV.Location = new System.Drawing.Point(458, 36);
            this.eDGV.Name = "eDGV";
            this.eDGV.ReadOnly = true;
            this.eDGV.RowHeadersWidth = 51;
            this.eDGV.Size = new System.Drawing.Size(331, 150);
            this.eDGV.TabIndex = 1;
            this.eDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eDGV_CellClick);
            // 
            // unLabel
            // 
            this.unLabel.AutoSize = true;
            this.unLabel.BackColor = System.Drawing.Color.Transparent;
            this.unLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unLabel.ForeColor = System.Drawing.Color.White;
            this.unLabel.Location = new System.Drawing.Point(9, 19);
            this.unLabel.Name = "unLabel";
            this.unLabel.Size = new System.Drawing.Size(84, 14);
            this.unLabel.TabIndex = 2;
            this.unLabel.Text = "Your Tasks:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(455, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employees With Common Projects:";
            // 
            // Back
            // 
            this.Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back.BackgroundImage")));
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(515, 320);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(101, 44);
            this.Back.TabIndex = 25;
            this.Back.Text = "BACK";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 14);
            this.label2.TabIndex = 26;
            this.label2.Text = "Forward Task:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(268, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 14);
            this.label3.TabIndex = 27;
            this.label3.Text = "To Employee:";
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(122, 212);
            this.TB1.Name = "TB1";
            this.TB1.ReadOnly = true;
            this.TB1.Size = new System.Drawing.Size(125, 20);
            this.TB1.TabIndex = 28;
            // 
            // TB2
            // 
            this.TB2.Location = new System.Drawing.Point(365, 212);
            this.TB2.Name = "TB2";
            this.TB2.ReadOnly = true;
            this.TB2.Size = new System.Drawing.Size(125, 20);
            this.TB2.TabIndex = 29;
            this.TB2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Forward
            // 
            this.Forward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Forward.BackgroundImage")));
            this.Forward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Forward.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forward.ForeColor = System.Drawing.Color.White;
            this.Forward.Location = new System.Drawing.Point(515, 193);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(101, 44);
            this.Forward.TabIndex = 30;
            this.Forward.Text = "FORWARD";
            this.Forward.UseVisualStyleBackColor = true;
            this.Forward.Click += new System.EventHandler(this.Forward_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 14);
            this.label4.TabIndex = 31;
            this.label4.Text = "Comment:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(122, 260);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(368, 96);
            this.richTextBox1.TabIndex = 32;
            this.richTextBox1.Text = "";
            // 
            // Update
            // 
            this.Update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Update.BackgroundImage")));
            this.Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Update.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.Color.White;
            this.Update.Location = new System.Drawing.Point(515, 260);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(101, 44);
            this.Update.TabIndex = 33;
            this.Update.Text = "UPDATE COMMENT";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(633, 261);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 36);
            this.button1.TabIndex = 34;
            this.button1.Text = "Download";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(633, 232);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(630, 216);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 14);
            this.label5.TabIndex = 36;
            this.label5.Text = "Specified File";
            // 
            // MyTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 376);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Forward);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unLabel);
            this.Controls.Add(this.eDGV);
            this.Controls.Add(this.tDGV);
            this.Name = "MyTasks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyTasks";
            this.Load += new System.EventHandler(this.MyTasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tDGV;
        private System.Windows.Forms.DataGridView eDGV;
        private System.Windows.Forms.Label unLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.TextBox TB2;
        private System.Windows.Forms.Button Forward;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
    }
}