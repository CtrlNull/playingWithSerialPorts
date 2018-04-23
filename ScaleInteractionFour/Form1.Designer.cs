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
            this.lblError = new System.Windows.Forms.Label();
            this.lblFour = new System.Windows.Forms.Label();
            this.lblThree = new System.Windows.Forms.Label();
            this.lblTwo = new System.Windows.Forms.Label();
            this.lblOne = new System.Windows.Forms.Label();
            this.rdoOne = new System.Windows.Forms.RadioButton();
            this.rdoFour = new System.Windows.Forms.RadioButton();
            this.rdoTwo = new System.Windows.Forms.RadioButton();
            this.rdoThree = new System.Windows.Forms.RadioButton();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txtRand = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblError);
            this.groupBox1.Controls.Add(this.lblFour);
            this.groupBox1.Controls.Add(this.lblThree);
            this.groupBox1.Controls.Add(this.lblTwo);
            this.groupBox1.Controls.Add(this.lblOne);
            this.groupBox1.Controls.Add(this.rdoOne);
            this.groupBox1.Controls.Add(this.rdoFour);
            this.groupBox1.Controls.Add(this.rdoTwo);
            this.groupBox1.Controls.Add(this.rdoThree);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port Selection";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(85, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(46, 13);
            this.lblError.TabIndex = 10;
            this.lblError.Text = "ERROR";
            // 
            // lblFour
            // 
            this.lblFour.AutoSize = true;
            this.lblFour.Location = new System.Drawing.Point(25, 146);
            this.lblFour.Name = "lblFour";
            this.lblFour.Size = new System.Drawing.Size(35, 13);
            this.lblFour.TabIndex = 9;
            this.lblFour.Text = "label4";
            // 
            // lblThree
            // 
            this.lblThree.AutoSize = true;
            this.lblThree.Location = new System.Drawing.Point(25, 110);
            this.lblThree.Name = "lblThree";
            this.lblThree.Size = new System.Drawing.Size(35, 13);
            this.lblThree.TabIndex = 8;
            this.lblThree.Text = "label3";
            // 
            // lblTwo
            // 
            this.lblTwo.AutoSize = true;
            this.lblTwo.Location = new System.Drawing.Point(25, 75);
            this.lblTwo.Name = "lblTwo";
            this.lblTwo.Size = new System.Drawing.Size(35, 13);
            this.lblTwo.TabIndex = 7;
            this.lblTwo.Text = "label2";
            // 
            // lblOne
            // 
            this.lblOne.AutoSize = true;
            this.lblOne.Location = new System.Drawing.Point(25, 39);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(35, 13);
            this.lblOne.TabIndex = 6;
            this.lblOne.Text = "label1";
            // 
            // rdoOne
            // 
            this.rdoOne.AutoSize = true;
            this.rdoOne.Location = new System.Drawing.Point(28, 19);
            this.rdoOne.Name = "rdoOne";
            this.rdoOne.Size = new System.Drawing.Size(85, 17);
            this.rdoOne.TabIndex = 2;
            this.rdoOne.TabStop = true;
            this.rdoOne.Text = "radioButton1";
            this.rdoOne.UseVisualStyleBackColor = true;
            // 
            // rdoFour
            // 
            this.rdoFour.AutoSize = true;
            this.rdoFour.Location = new System.Drawing.Point(28, 126);
            this.rdoFour.Name = "rdoFour";
            this.rdoFour.Size = new System.Drawing.Size(85, 17);
            this.rdoFour.TabIndex = 5;
            this.rdoFour.TabStop = true;
            this.rdoFour.Text = "radioButton4";
            this.rdoFour.UseVisualStyleBackColor = true;
            // 
            // rdoTwo
            // 
            this.rdoTwo.AutoSize = true;
            this.rdoTwo.Location = new System.Drawing.Point(28, 55);
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
            this.rdoThree.Location = new System.Drawing.Point(28, 91);
            this.rdoThree.Name = "rdoThree";
            this.rdoThree.Size = new System.Drawing.Size(85, 17);
            this.rdoThree.TabIndex = 4;
            this.rdoThree.TabStop = true;
            this.rdoThree.Text = "radioButton3";
            this.rdoThree.UseVisualStyleBackColor = true;
            // 
            // txtRand
            // 
            this.txtRand.Location = new System.Drawing.Point(301, 13);
            this.txtRand.Multiline = true;
            this.txtRand.Name = "txtRand";
            this.txtRand.Size = new System.Drawing.Size(156, 113);
            this.txtRand.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Port Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(382, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "PortName";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 192);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRand);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoOne;
        private System.Windows.Forms.RadioButton rdoTwo;
        private System.Windows.Forms.RadioButton rdoThree;
        private System.Windows.Forms.RadioButton rdoFour;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox txtRand;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblFour;
        private System.Windows.Forms.Label lblThree;
        private System.Windows.Forms.Label lblTwo;
        private System.Windows.Forms.Label lblOne;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button button2;
    }
}

