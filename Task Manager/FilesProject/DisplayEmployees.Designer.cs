namespace FilesProject
{
    partial class DisplayEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayEmployees));
            this.DGV = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dep = new System.Windows.Forms.ComboBox();
            this.gen = new System.Windows.Forms.ComboBox();
            this.name = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.un = new System.Windows.Forms.TextBox();
            this.dLabel = new System.Windows.Forms.Label();
            this.gLabel = new System.Windows.Forms.Label();
            this.nLabel = new System.Windows.Forms.Label();
            this.pLabel = new System.Windows.Forms.Label();
            this.unLabel = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Username,
            this.Password,
            this.EmpName,
            this.Gender,
            this.Department});
            this.DGV.Location = new System.Drawing.Point(13, 12);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.Size = new System.Drawing.Size(648, 223);
            this.DGV.TabIndex = 2;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick_1);
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // EmpName
            // 
            this.EmpName.HeaderText = "Name";
            this.EmpName.Name = "EmpName";
            this.EmpName.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Department
            // 
            this.Department.HeaderText = "Department";
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            // 
            // dep
            // 
            this.dep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dep.FormattingEnabled = true;
            this.dep.Items.AddRange(new object[] {
            "Sales",
            "Accouting",
            "HR",
            "Customer Service",
            "Management"});
            this.dep.Location = new System.Drawing.Point(157, 438);
            this.dep.Name = "dep";
            this.dep.Size = new System.Drawing.Size(121, 21);
            this.dep.TabIndex = 22;
            // 
            // gen
            // 
            this.gen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gen.FormattingEnabled = true;
            this.gen.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gen.Location = new System.Drawing.Point(157, 401);
            this.gen.Name = "gen";
            this.gen.Size = new System.Drawing.Size(121, 21);
            this.gen.TabIndex = 21;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(157, 361);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 20;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(157, 315);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(100, 20);
            this.pass.TabIndex = 19;
            // 
            // un
            // 
            this.un.Location = new System.Drawing.Point(157, 268);
            this.un.Name = "un";
            this.un.Size = new System.Drawing.Size(100, 20);
            this.un.TabIndex = 18;
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.BackColor = System.Drawing.Color.Transparent;
            this.dLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dLabel.ForeColor = System.Drawing.Color.White;
            this.dLabel.Location = new System.Drawing.Point(32, 438);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(77, 14);
            this.dLabel.TabIndex = 17;
            this.dLabel.Text = "Department";
            // 
            // gLabel
            // 
            this.gLabel.AutoSize = true;
            this.gLabel.BackColor = System.Drawing.Color.Transparent;
            this.gLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gLabel.ForeColor = System.Drawing.Color.White;
            this.gLabel.Location = new System.Drawing.Point(32, 401);
            this.gLabel.Name = "gLabel";
            this.gLabel.Size = new System.Drawing.Size(49, 14);
            this.gLabel.TabIndex = 16;
            this.gLabel.Text = "Gender";
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.BackColor = System.Drawing.Color.Transparent;
            this.nLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nLabel.ForeColor = System.Drawing.Color.White;
            this.nLabel.Location = new System.Drawing.Point(32, 361);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(35, 14);
            this.nLabel.TabIndex = 15;
            this.nLabel.Text = "Name";
            // 
            // pLabel
            // 
            this.pLabel.AutoSize = true;
            this.pLabel.BackColor = System.Drawing.Color.Transparent;
            this.pLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pLabel.ForeColor = System.Drawing.Color.White;
            this.pLabel.Location = new System.Drawing.Point(32, 315);
            this.pLabel.Name = "pLabel";
            this.pLabel.Size = new System.Drawing.Size(91, 14);
            this.pLabel.TabIndex = 14;
            this.pLabel.Text = "New Password";
            // 
            // unLabel
            // 
            this.unLabel.AutoSize = true;
            this.unLabel.BackColor = System.Drawing.Color.Transparent;
            this.unLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unLabel.ForeColor = System.Drawing.Color.White;
            this.unLabel.Location = new System.Drawing.Point(32, 273);
            this.unLabel.Name = "unLabel";
            this.unLabel.Size = new System.Drawing.Size(91, 14);
            this.unLabel.TabIndex = 13;
            this.unLabel.Text = "New Username";
            // 
            // Back
            // 
            this.Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back.BackgroundImage")));
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(334, 361);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(101, 44);
            this.Back.TabIndex = 24;
            this.Back.Text = "BACK";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Save
            // 
            this.Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Save.BackgroundImage")));
            this.Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Save.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.Location = new System.Drawing.Point(334, 273);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(101, 44);
            this.Save.TabIndex = 23;
            this.Save.Text = "SAVE";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // DisplayEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(673, 482);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.dep);
            this.Controls.Add(this.gen);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.un);
            this.Controls.Add(this.dLabel);
            this.Controls.Add(this.gLabel);
            this.Controls.Add(this.nLabel);
            this.Controls.Add(this.pLabel);
            this.Controls.Add(this.unLabel);
            this.Controls.Add(this.DGV);
            this.Name = "DisplayEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayEmployees";
            this.Load += new System.EventHandler(this.DisplayEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.ComboBox dep;
        private System.Windows.Forms.ComboBox gen;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox un;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.Label gLabel;
        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.Label pLabel;
        private System.Windows.Forms.Label unLabel;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Save;
    }
}