namespace RentACarForm
{
    partial class Main_Form
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
            this.btn_LoginInto = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_LoginInto
            // 
            this.btn_LoginInto.Location = new System.Drawing.Point(61, 142);
            this.btn_LoginInto.Name = "btn_LoginInto";
            this.btn_LoginInto.Size = new System.Drawing.Size(194, 123);
            this.btn_LoginInto.TabIndex = 0;
            this.btn_LoginInto.Text = "Login Bilgisi";
            this.btn_LoginInto.UseVisualStyleBackColor = true;
            this.btn_LoginInto.Click += new System.EventHandler(this.btn_LoginInto_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(300, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 123);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(531, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 123);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_LoginInto);
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_LoginInto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}