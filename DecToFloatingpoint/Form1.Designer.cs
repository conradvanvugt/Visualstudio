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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSignOut = new System.Windows.Forms.TextBox();
            this.txtExpOut = new System.Windows.Forms.TextBox();
            this.txtfractieOut = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.txtSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignOut.Location = new System.Drawing.Point(12, 84);
            this.txtSignOut.Name = "txtSignOut";
            this.txtSignOut.Size = new System.Drawing.Size(20, 29);
            this.txtSignOut.TabIndex = 4;
            // 
            // txtExpOut
            // 
            this.txtExpOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpOut.Location = new System.Drawing.Point(38, 84);
            this.txtExpOut.Name = "txtExpOut";
            this.txtExpOut.Size = new System.Drawing.Size(100, 29);
            this.txtExpOut.TabIndex = 5;
            // 
            // txtfractieOut
            // 
            this.txtfractieOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfractieOut.Location = new System.Drawing.Point(144, 84);
            this.txtfractieOut.Name = "txtfractieOut";
            this.txtfractieOut.Size = new System.Drawing.Size(269, 29);
            this.txtfractieOut.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtfractieOut);
            this.Controls.Add(this.txtExpOut);
            this.Controls.Add(this.txtSignOut);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSignOut;
        private System.Windows.Forms.TextBox txtExpOut;
        private System.Windows.Forms.TextBox txtfractieOut;
        private System.Windows.Forms.Button button1;
    }
}

