namespace WindowsFormsMiniProject
{
    partial class PersonInfo
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
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.adressesList = new System.Windows.Forms.ListBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.isActive = new System.Windows.Forms.CheckBox();
            this.isActiveLabel = new System.Windows.Forms.Label();
            this.adressesListLabel = new System.Windows.Forms.Label();
            this.addNewAdress = new System.Windows.Forms.Button();
            this.saveRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(195, 32);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(347, 38);
            this.firstNameText.TabIndex = 1;
            // 
            // adressesList
            // 
            this.adressesList.FormattingEnabled = true;
            this.adressesList.ItemHeight = 31;
            this.adressesList.Location = new System.Drawing.Point(44, 294);
            this.adressesList.Name = "adressesList";
            this.adressesList.Size = new System.Drawing.Size(498, 314);
            this.adressesList.TabIndex = 2;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(38, 38);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(151, 32);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(38, 110);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(150, 32);
            this.lastNameLabel.TabIndex = 6;
            this.lastNameLabel.Text = "Last Name";
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(195, 104);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(347, 38);
            this.lastNameText.TabIndex = 5;
            // 
            // isActive
            // 
            this.isActive.AutoSize = true;
            this.isActive.Location = new System.Drawing.Point(195, 185);
            this.isActive.Name = "isActive";
            this.isActive.Size = new System.Drawing.Size(178, 45);
            this.isActive.TabIndex = 7;
            this.isActive.Text = "Is Active";
            this.isActive.UseVisualStyleBackColor = true;
            // 
            // isActiveLabel
            // 
            this.isActiveLabel.AutoSize = true;
            this.isActiveLabel.Location = new System.Drawing.Point(38, 189);
            this.isActiveLabel.Name = "isActiveLabel";
            this.isActiveLabel.Size = new System.Drawing.Size(92, 32);
            this.isActiveLabel.TabIndex = 8;
            this.isActiveLabel.Text = "Active";
            // 
            // adressesListLabel
            // 
            this.adressesListLabel.AutoSize = true;
            this.adressesListLabel.Location = new System.Drawing.Point(38, 259);
            this.adressesListLabel.Name = "adressesListLabel";
            this.adressesListLabel.Size = new System.Drawing.Size(132, 32);
            this.adressesListLabel.TabIndex = 8;
            this.adressesListLabel.Text = "Adresses";
            // 
            // addNewAdress
            // 
            this.addNewAdress.Location = new System.Drawing.Point(407, 246);
            this.addNewAdress.Name = "addNewAdress";
            this.addNewAdress.Size = new System.Drawing.Size(135, 45);
            this.addNewAdress.TabIndex = 9;
            this.addNewAdress.Text = "Add";
            this.addNewAdress.UseVisualStyleBackColor = true;
            this.addNewAdress.Click += new System.EventHandler(this.addNewAdress_Click);
            // 
            // saveRecord
            // 
            this.saveRecord.Location = new System.Drawing.Point(209, 635);
            this.saveRecord.Name = "saveRecord";
            this.saveRecord.Size = new System.Drawing.Size(176, 66);
            this.saveRecord.TabIndex = 10;
            this.saveRecord.Text = "Save";
            this.saveRecord.UseVisualStyleBackColor = true;
            this.saveRecord.Click += new System.EventHandler(this.saveRecord_Click);
            // 
            // PersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 725);
            this.Controls.Add(this.saveRecord);
            this.Controls.Add(this.addNewAdress);
            this.Controls.Add(this.adressesListLabel);
            this.Controls.Add(this.isActiveLabel);
            this.Controls.Add(this.isActive);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.adressesList);
            this.Controls.Add(this.firstNameText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PersonInfo";
            this.Text = "Person Info Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.ListBox adressesList;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.CheckBox isActive;
        private System.Windows.Forms.Label isActiveLabel;
        private System.Windows.Forms.Label adressesListLabel;
        private System.Windows.Forms.Button addNewAdress;
        private System.Windows.Forms.Button saveRecord;
    }
}

