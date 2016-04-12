namespace DecToFloatingpoint
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnFloat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSignOut = new System.Windows.Forms.TextBox();
            this.txtExpOut = new System.Windows.Forms.TextBox();
            this.txtFractieOut = new System.Windows.Forms.TextBox();
            this.btnbinair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFractieIn = new System.Windows.Forms.TextBox();
            this.txtExpIn = new System.Windows.Forms.TextBox();
            this.txtSignIn = new System.Windows.Forms.TextBox();
            this.txtGetalOut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(207, 13);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(120, 20);
            this.txtInput.TabIndex = 0;
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // btnFloat
            // 
            this.btnFloat.Location = new System.Drawing.Point(68, 39);
            this.btnFloat.Name = "btnFloat";
            this.btnFloat.Size = new System.Drawing.Size(259, 23);
            this.btnFloat.TabIndex = 1;
            this.btnFloat.Text = "Omzetten naar 32 bits notatie";
            this.btnFloat.UseVisualStyleBackColor = true;
            this.btnFloat.Click += new System.EventHandler(this.btnFloat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Om te zetten getal:";
            // 
            // txtSignOut
            // 
            this.txtSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignOut.Location = new System.Drawing.Point(12, 84);
            this.txtSignOut.Name = "txtSignOut";
            this.txtSignOut.Size = new System.Drawing.Size(20, 26);
            this.txtSignOut.TabIndex = 4;
            // 
            // txtExpOut
            // 
            this.txtExpOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpOut.Location = new System.Drawing.Point(38, 84);
            this.txtExpOut.Name = "txtExpOut";
            this.txtExpOut.Size = new System.Drawing.Size(89, 26);
            this.txtExpOut.TabIndex = 5;
            // 
            // txtFractieOut
            // 
            this.txtFractieOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFractieOut.Location = new System.Drawing.Point(133, 84);
            this.txtFractieOut.Name = "txtFractieOut";
            this.txtFractieOut.Size = new System.Drawing.Size(280, 26);
            this.txtFractieOut.TabIndex = 6;
            // 
            // btnbinair
            // 
            this.btnbinair.Location = new System.Drawing.Point(68, 183);
            this.btnbinair.Name = "btnbinair";
            this.btnbinair.Size = new System.Drawing.Size(259, 23);
            this.btnbinair.TabIndex = 7;
            this.btnbinair.Text = "Omzetten naar binair";
            this.btnbinair.UseVisualStyleBackColor = true;
            this.btnbinair.Click += new System.EventHandler(this.btnbinair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Om te zetten float:";
            // 
            // txtFractieIn
            // 
            this.txtFractieIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFractieIn.Location = new System.Drawing.Point(133, 148);
            this.txtFractieIn.Name = "txtFractieIn";
            this.txtFractieIn.Size = new System.Drawing.Size(280, 26);
            this.txtFractieIn.TabIndex = 11;
            this.txtFractieIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFractieIn_KeyPress);
            // 
            // txtExpIn
            // 
            this.txtExpIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpIn.Location = new System.Drawing.Point(38, 148);
            this.txtExpIn.Name = "txtExpIn";
            this.txtExpIn.Size = new System.Drawing.Size(89, 26);
            this.txtExpIn.TabIndex = 10;
            this.txtExpIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExpIn_KeyPress);
            // 
            // txtSignIn
            // 
            this.txtSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignIn.Location = new System.Drawing.Point(12, 148);
            this.txtSignIn.Name = "txtSignIn";
            this.txtSignIn.Size = new System.Drawing.Size(20, 26);
            this.txtSignIn.TabIndex = 9;
            this.txtSignIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSignIn_KeyPress);
            // 
            // txtGetalOut
            // 
            this.txtGetalOut.Location = new System.Drawing.Point(68, 212);
            this.txtGetalOut.Name = "txtGetalOut";
            this.txtGetalOut.Size = new System.Drawing.Size(259, 20);
            this.txtGetalOut.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 261);
            this.Controls.Add(this.txtGetalOut);
            this.Controls.Add(this.txtFractieIn);
            this.Controls.Add(this.txtExpIn);
            this.Controls.Add(this.txtSignIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnbinair);
            this.Controls.Add(this.txtFractieOut);
            this.Controls.Add(this.txtExpOut);
            this.Controls.Add(this.txtSignOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFloat);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnFloat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSignOut;
        private System.Windows.Forms.TextBox txtExpOut;
        private System.Windows.Forms.TextBox txtFractieOut;
        private System.Windows.Forms.Button btnbinair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFractieIn;
        private System.Windows.Forms.TextBox txtExpIn;
        private System.Windows.Forms.TextBox txtSignIn;
        private System.Windows.Forms.TextBox txtGetalOut;
    }
}

