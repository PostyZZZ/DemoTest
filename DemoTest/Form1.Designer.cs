namespace DemoTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox_lgn = new TextBox();
            textBox_pass = new TextBox();
            btn_auth = new Button();
            SuspendLayout();
            // 
            // textBox_lgn
            // 
            textBox_lgn.Location = new Point(219, 125);
            textBox_lgn.Name = "textBox_lgn";
            textBox_lgn.Size = new Size(147, 23);
            textBox_lgn.TabIndex = 0;
            // 
            // textBox_pass
            // 
            textBox_pass.Location = new Point(219, 154);
            textBox_pass.Name = "textBox_pass";
            textBox_pass.Size = new Size(147, 23);
            textBox_pass.TabIndex = 1;
            // 
            // btn_auth
            // 
            btn_auth.Location = new Point(255, 183);
            btn_auth.Name = "btn_auth";
            btn_auth.Size = new Size(75, 23);
            btn_auth.TabIndex = 2;
            btn_auth.Text = "Войти";
            btn_auth.UseVisualStyleBackColor = true;
            btn_auth.Click += btn_auth_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 343);
            Controls.Add(btn_auth);
            Controls.Add(textBox_pass);
            Controls.Add(textBox_lgn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_lgn;
        private TextBox textBox_pass;
        private Button btn_auth;
    }
}
