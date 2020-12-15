namespace FilesProject
{
    partial class AddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
            this.unLabel = new System.Windows.Forms.Label();
            this.pLabel = new System.Windows.Forms.Label();
            this.nLabel = new System.Windows.Forms.Label();
            this.gLabel = new System.Windows.Forms.Label();
            this.dLabel = new System.Windows.Forms.Label();
            this.iLabel = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.un = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.ComboBox();
            this.dep = new System.Windows.Forms.ComboBox();
            this.Save = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // unLabel
            // 
            this.unLabel.AutoSize = true;
            this.unLabel.BackColor = System.Drawing.Color.Transparent;
            this.unLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unLabel.ForeColor = System.Drawing.Color.White;
            this.unLabel.Location = new System.Drawing.Point(12, 55);
            this.unLabel.Name = "unLabel";
            this.unLabel.Size = new System.Drawing.Size(74, 16);
            this.unLabel.TabIndex = 1;
            this.unLabel.Text = "Username";
            this.unLabel.Click += new System.EventHandler(this.unLabel_Click);
            // 
            // pLabel
            // 
            this.pLabel.AutoSize = true;
            this.pLabel.BackColor = System.Drawing.Color.Transparent;
            this.pLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pLabel.ForeColor = System.Drawing.Color.White;
            this.pLabel.Location = new System.Drawing.Point(12, 97);
            this.pLabel.Name = "pLabel";
            this.pLabel.Size = new System.Drawing.Size(71, 16);
            this.pLabel.TabIndex = 2;
            this.pLabel.Text = "Password";
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.BackColor = System.Drawing.Color.Transparent;
            this.nLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nLabel.ForeColor = System.Drawing.Color.White;
            this.nLabel.Location = new System.Drawing.Point(12, 143);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(46, 16);
            this.nLabel.TabIndex = 3;
            this.nLabel.Text = "Name";
            // 
            // gLabel
            // 
            this.gLabel.AutoSize = true;
            this.gLabel.BackColor = System.Drawing.Color.Transparent;
            this.gLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gLabel.ForeColor = System.Drawing.Color.White;
            this.gLabel.Location = new System.Drawing.Point(12, 183);
            this.gLabel.Name = "gLabel";
            this.gLabel.Size = new System.Drawing.Size(57, 16);
            this.gLabel.TabIndex = 4;
            this.gLabel.Text = "Gender";
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.BackColor = System.Drawing.Color.Transparent;
            this.dLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dLabel.ForeColor = System.Drawing.Color.White;
            this.dLabel.Location = new System.Drawing.Point(12, 220);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(87, 16);
            this.dLabel.TabIndex = 5;
            this.dLabel.Text = "Department";
            // 
            // iLabel
            // 
            this.iLabel.AutoSize = true;
            this.iLabel.BackColor = System.Drawing.Color.Transparent;
            this.iLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iLabel.ForeColor = System.Drawing.Color.White;
            this.iLabel.Location = new System.Drawing.Point(12, 13);
            this.iLabel.Name = "iLabel";
            this.iLabel.Size = new System.Drawing.Size(22, 16);
            this.iLabel.TabIndex = 6;
            this.iLabel.Text = "ID";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(137, 13);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 7;
            // 
            // un
            // 
            this.un.Location = new System.Drawing.Point(137, 50);
            this.un.Name = "un";
            this.un.Size = new System.Drawing.Size(100, 20);
            this.un.TabIndex = 8;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(137, 97);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(100, 20);
            this.pass.TabIndex = 9;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(137, 143);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 10;
            // 
            // gender
            // 
            this.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender.Location = new System.Drawing.Point(137, 183);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(121, 21);
            this.gender.TabIndex = 11;
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
            this.dep.Location = new System.Drawing.Point(137, 220);
            this.dep.Name = "dep";
            this.dep.Size = new System.Drawing.Size(121, 21);
            this.dep.TabIndex = 12;
            // 
            // Save
            // 
            this.Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Save.BackgroundImage")));
            this.Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Save.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.Location = new System.Drawing.Point(10, 309);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(101, 44);
            this.Save.TabIndex = 13;
            this.Save.Text = "SAVE";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Back
            // 
            this.Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back.BackgroundImage")));
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(157, 309);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(101, 44);
            this.Back.TabIndex = 14;
            this.Back.Text = "BACK";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // typeBox
            // 
            this.typeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.typeBox.Location = new System.Drawing.Point(137, 268);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(121, 21);
            this.typeBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "User Type";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 374);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.dep);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.un);
            this.Controls.Add(this.id);
            this.Controls.Add(this.iLabel);
            this.Controls.Add(this.dLabel);
            this.Controls.Add(this.gLabel);
            this.Controls.Add(this.nLabel);
            this.Controls.Add(this.pLabel);
            this.Controls.Add(this.unLabel);
            this.Name = "AddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label unLabel;
        private System.Windows.Forms.Label pLabel;
        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.Label gLabel;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.Label iLabel;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox un;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.ComboBox dep;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.Label label1;

    }
}