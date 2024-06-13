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
            btn_reg = new Button();
            label1 = new Label();
            label2 = new Label();
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
            btn_auth.Location = new Point(219, 183);
            btn_auth.Name = "btn_auth";
            btn_auth.Size = new Size(147, 26);
            btn_auth.TabIndex = 2;
            btn_auth.Text = "Войти";
            btn_auth.UseVisualStyleBackColor = true;
            btn_auth.Click += btn_auth_Click;
            // 
            // btn_reg
            // 
            btn_reg.Location = new Point(219, 215);
            btn_reg.Name = "btn_reg";
            btn_reg.Size = new Size(147, 26);
            btn_reg.TabIndex = 3;
            btn_reg.Text = "Регистрация";
            btn_reg.UseVisualStyleBackColor = true;
            btn_reg.Click += btn_reg_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 128);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 4;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 157);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 5;
            label2.Text = "Пароль";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 343);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_reg);
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
        private Button btn_reg;
        private Label label1;
        private Label label2;
    }
}
