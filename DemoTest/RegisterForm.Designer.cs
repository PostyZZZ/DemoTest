namespace DemoTest
{
    partial class RegisterForm
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
            label1 = new Label();
            lbl_role = new Label();
            lbl_pass = new Label();
            lbl_name = new Label();
            btn_back = new Button();
            btn_register = new Button();
            txt_regpass = new TextBox();
            txt_reglog = new TextBox();
            cmb_roles = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(171, 9);
            label1.Name = "label1";
            label1.Size = new Size(126, 28);
            label1.TabIndex = 23;
            label1.Text = "Регистрация";
            // 
            // lbl_role
            // 
            lbl_role.AutoSize = true;
            lbl_role.Location = new Point(131, 191);
            lbl_role.Name = "lbl_role";
            lbl_role.Size = new Size(34, 15);
            lbl_role.TabIndex = 22;
            lbl_role.Text = "Роль";
            // 
            // lbl_pass
            // 
            lbl_pass.AutoSize = true;
            lbl_pass.Location = new Point(116, 162);
            lbl_pass.Name = "lbl_pass";
            lbl_pass.Size = new Size(49, 15);
            lbl_pass.TabIndex = 20;
            lbl_pass.Text = "Пароль";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(124, 133);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(41, 15);
            lbl_name.TabIndex = 19;
            lbl_name.Text = "Логин";
            // 
            // btn_back
            // 
            btn_back.Location = new Point(171, 250);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(147, 26);
            btn_back.TabIndex = 18;
            btn_back.Text = "Назад";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // btn_register
            // 
            btn_register.Location = new Point(171, 218);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(147, 26);
            btn_register.TabIndex = 17;
            btn_register.Text = "Создать";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // txt_regpass
            // 
            txt_regpass.Location = new Point(171, 159);
            txt_regpass.Name = "txt_regpass";
            txt_regpass.Size = new Size(147, 23);
            txt_regpass.TabIndex = 16;
            // 
            // txt_reglog
            // 
            txt_reglog.Location = new Point(171, 130);
            txt_reglog.Name = "txt_reglog";
            txt_reglog.Size = new Size(147, 23);
            txt_reglog.TabIndex = 15;
            // 
            // cmb_roles
            // 
            cmb_roles.FormattingEnabled = true;
            cmb_roles.Items.AddRange(new object[] { "user" });
            cmb_roles.Location = new Point(171, 188);
            cmb_roles.Name = "cmb_roles";
            cmb_roles.Size = new Size(147, 23);
            cmb_roles.TabIndex = 24;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 337);
            Controls.Add(cmb_roles);
            Controls.Add(label1);
            Controls.Add(lbl_role);
            Controls.Add(lbl_pass);
            Controls.Add(lbl_name);
            Controls.Add(btn_back);
            Controls.Add(btn_register);
            Controls.Add(txt_regpass);
            Controls.Add(txt_reglog);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl_role;
        private Label lbl_pass;
        private Label lbl_name;
        private Button btn_back;
        private Button btn_register;
        private TextBox txt_regpass;
        private TextBox txt_reglog;
        private ComboBox cmb_roles;
    }
}