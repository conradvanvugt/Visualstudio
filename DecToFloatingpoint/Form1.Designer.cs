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
            this.btnOmzetten = new System.Windows.Forms.Button();
            this.lblFloating = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(207, 13);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(120, 20);
            this.txtInput.TabIndex = 0;
            // 
            // btnOmzetten
            // 
            this.btnOmzetten.Location = new System.Drawing.Point(68, 39);
            this.btnOmzetten.Name = "btnOmzetten";
            this.btnOmzetten.Size = new System.Drawing.Size(259, 23);
            this.btnOmzetten.TabIndex = 1;
            this.btnOmzetten.Text = "Omzetten naar 32 bits notatie";
            this.btnOmzetten.UseVisualStyleBackColor = true;
            this.btnOmzetten.Click += new System.EventHandler(this.btnOmzetten_Click);
            // 
            // lblFloating
            // 
            this.lblFloating.AutoSize = true;
            this.lblFloating.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFloating.Location = new System.Drawing.Point(12, 64);
            this.lblFloating.Name = "lblFloating";
            this.lblFloating.Size = new System.Drawing.Size(0, 24);
            this.lblFloating.TabIndex = 2;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFloating);
            this.Controls.Add(this.btnOmzetten);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnOmzetten;
        private System.Windows.Forms.Label lblFloating;
        private System.Windows.Forms.Label label2;
    }
}

