namespace ValidateData
{
    partial class Form1
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
            this.buttonValidate = new System.Windows.Forms.Button();
            this.textBoxLS = new System.Windows.Forms.TextBox();
            this.textBoxFN = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IDnumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonValidate
            // 
            this.buttonValidate.Location = new System.Drawing.Point(515, 168);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(132, 53);
            this.buttonValidate.TabIndex = 10;
            this.buttonValidate.Text = "VALIDATE";
            this.buttonValidate.UseVisualStyleBackColor = true;
            // 
            // textBoxLS
            // 
            this.textBoxLS.Location = new System.Drawing.Point(214, 309);
            this.textBoxLS.Name = "textBoxLS";
            this.textBoxLS.Size = new System.Drawing.Size(151, 22);
            this.textBoxLS.TabIndex = 7;
            // 
            // textBoxFN
            // 
            this.textBoxFN.Location = new System.Drawing.Point(215, 224);
            this.textBoxFN.Name = "textBoxFN";
            this.textBoxFN.Size = new System.Drawing.Size(150, 22);
            this.textBoxFN.TabIndex = 8;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(214, 140);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(151, 22);
            this.textBoxID.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Must be 7 Digit number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Name";
            // 
            // IDnumber
            // 
            this.IDnumber.AutoSize = true;
            this.IDnumber.Location = new System.Drawing.Point(211, 120);
            this.IDnumber.Name = "IDnumber";
            this.IDnumber.Size = new System.Drawing.Size(75, 17);
            this.IDnumber.TabIndex = 6;
            this.IDnumber.Text = "ID Number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonValidate);
            this.Controls.Add(this.textBoxLS);
            this.Controls.Add(this.textBoxFN);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDnumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonValidate;
        private System.Windows.Forms.TextBox textBoxLS;
        private System.Windows.Forms.TextBox textBoxFN;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IDnumber;
    }
}

