namespace WindowsFormsMiniProject
{
    partial class AdressInfo
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
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityText = new System.Windows.Forms.TextBox();
            this.streetAdressLabel = new System.Windows.Forms.Label();
            this.streetAdressText = new System.Windows.Forms.TextBox();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.zipCodeText = new System.Windows.Forms.TextBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.stateText = new System.Windows.Forms.TextBox();
            this.adressEntryLabel = new System.Windows.Forms.Label();
            this.saveRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(184, 178);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(70, 32);
            this.cityLabel.TabIndex = 10;
            this.cityLabel.Text = "City ";
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(260, 172);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(347, 38);
            this.cityText.TabIndex = 9;
            // 
            // streetAdressLabel
            // 
            this.streetAdressLabel.AutoSize = true;
            this.streetAdressLabel.Location = new System.Drawing.Point(69, 106);
            this.streetAdressLabel.Name = "streetAdressLabel";
            this.streetAdressLabel.Size = new System.Drawing.Size(185, 32);
            this.streetAdressLabel.TabIndex = 8;
            this.streetAdressLabel.Text = "Street Adress";
            // 
            // streetAdressText
            // 
            this.streetAdressText.Location = new System.Drawing.Point(260, 100);
            this.streetAdressText.Name = "streetAdressText";
            this.streetAdressText.Size = new System.Drawing.Size(347, 38);
            this.streetAdressText.TabIndex = 7;
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Location = new System.Drawing.Point(125, 315);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(129, 32);
            this.zipCodeLabel.TabIndex = 14;
            this.zipCodeLabel.Text = "Zip Code";
            // 
            // zipCodeText
            // 
            this.zipCodeText.Location = new System.Drawing.Point(260, 309);
            this.zipCodeText.Name = "zipCodeText";
            this.zipCodeText.Size = new System.Drawing.Size(347, 38);
            this.zipCodeText.TabIndex = 13;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(173, 240);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(81, 32);
            this.stateLabel.TabIndex = 12;
            this.stateLabel.Text = "State";
            // 
            // stateText
            // 
            this.stateText.Location = new System.Drawing.Point(260, 237);
            this.stateText.Name = "stateText";
            this.stateText.Size = new System.Drawing.Size(347, 38);
            this.stateText.TabIndex = 11;
            // 
            // adressEntryLabel
            // 
            this.adressEntryLabel.AutoSize = true;
            this.adressEntryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adressEntryLabel.Location = new System.Drawing.Point(230, 9);
            this.adressEntryLabel.Name = "adressEntryLabel";
            this.adressEntryLabel.Size = new System.Drawing.Size(281, 51);
            this.adressEntryLabel.TabIndex = 15;
            this.adressEntryLabel.Text = "Adress Entry";
            // 
            // saveRecord
            // 
            this.saveRecord.Location = new System.Drawing.Point(307, 390);
            this.saveRecord.Name = "saveRecord";
            this.saveRecord.Size = new System.Drawing.Size(176, 66);
            this.saveRecord.TabIndex = 16;
            this.saveRecord.Text = "Save";
            this.saveRecord.UseVisualStyleBackColor = true;
            this.saveRecord.Click += new System.EventHandler(this.saveRecord_Click);
            // 
            // AdressInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 483);
            this.Controls.Add(this.saveRecord);
            this.Controls.Add(this.adressEntryLabel);
            this.Controls.Add(this.zipCodeLabel);
            this.Controls.Add(this.zipCodeText);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.stateText);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.streetAdressLabel);
            this.Controls.Add(this.streetAdressText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AdressInfo";
            this.Text = "Adress Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox cityText;
        private System.Windows.Forms.Label streetAdressLabel;
        private System.Windows.Forms.TextBox streetAdressText;
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.TextBox zipCodeText;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.TextBox stateText;
        private System.Windows.Forms.Label adressEntryLabel;
        private System.Windows.Forms.Button saveRecord;
    }
}