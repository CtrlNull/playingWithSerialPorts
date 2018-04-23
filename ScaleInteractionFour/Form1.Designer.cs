namespace ScaleInteractionFour
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.rdoOne = new System.Windows.Forms.RadioButton();
            this.rdoTwo = new System.Windows.Forms.RadioButton();
            this.rdoThree = new System.Windows.Forms.RadioButton();
            this.rdoFour = new System.Windows.Forms.RadioButton();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txtRand = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboPorts);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port Selection";
            // 
            // cboPorts
            // 
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.Location = new System.Drawing.Point(23, 32);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(90, 21);
            this.cboPorts.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(272, 19);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(142, 139);
            this.checkedListBox1.TabIndex = 1;
            // 
            // rdoOne
            // 
            this.rdoOne.AutoSize = true;
            this.rdoOne.Location = new System.Drawing.Point(36, 182);
            this.rdoOne.Name = "rdoOne";
            this.rdoOne.Size = new System.Drawing.Size(85, 17);
            this.rdoOne.TabIndex = 2;
            this.rdoOne.TabStop = true;
            this.rdoOne.Text = "radioButton1";
            this.rdoOne.UseVisualStyleBackColor = true;
            // 
            // rdoTwo
            // 
            this.rdoTwo.AutoSize = true;
            this.rdoTwo.Location = new System.Drawing.Point(36, 206);
            this.rdoTwo.Name = "rdoTwo";
            this.rdoTwo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdoTwo.Size = new System.Drawing.Size(85, 17);
            this.rdoTwo.TabIndex = 3;
            this.rdoTwo.TabStop = true;
            this.rdoTwo.Text = "radioButton2";
            this.rdoTwo.UseVisualStyleBackColor = true;
            // 
            // rdoThree
            // 
            this.rdoThree.AutoSize = true;
            this.rdoThree.Location = new System.Drawing.Point(36, 230);
            this.rdoThree.Name = "rdoThree";
            this.rdoThree.Size = new System.Drawing.Size(85, 17);
            this.rdoThree.TabIndex = 4;
            this.rdoThree.TabStop = true;
            this.rdoThree.Text = "radioButton3";
            this.rdoThree.UseVisualStyleBackColor = true;
            // 
            // rdoFour
            // 
            this.rdoFour.AutoSize = true;
            this.rdoFour.Location = new System.Drawing.Point(36, 254);
            this.rdoFour.Name = "rdoFour";
            this.rdoFour.Size = new System.Drawing.Size(85, 17);
            this.rdoFour.TabIndex = 5;
            this.rdoFour.TabStop = true;
            this.rdoFour.Text = "radioButton4";
            this.rdoFour.UseVisualStyleBackColor = true;
            // 
            // txtRand
            // 
            this.txtRand.Location = new System.Drawing.Point(272, 182);
            this.txtRand.Multiline = true;
            this.txtRand.Name = "txtRand";
            this.txtRand.Size = new System.Drawing.Size(127, 113);
            this.txtRand.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 401);
            this.Controls.Add(this.txtRand);
            this.Controls.Add(this.rdoFour);
            this.Controls.Add(this.rdoThree);
            this.Controls.Add(this.rdoTwo);
            this.Controls.Add(this.rdoOne);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboPorts;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.RadioButton rdoOne;
        private System.Windows.Forms.RadioButton rdoTwo;
        private System.Windows.Forms.RadioButton rdoThree;
        private System.Windows.Forms.RadioButton rdoFour;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox txtRand;
    }
}

