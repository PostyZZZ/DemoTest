namespace DemoTest
{
    partial class UserForm
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
            add_btn = new Button();
            txtName = new TextBox();
            txtDoc = new TextBox();
            txtPlace = new TextBox();
            txtNum = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbType = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            cmbStatus = new ComboBox();
            label8 = new Label();
            NumClient = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)NumClient).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(186, 9);
            label1.Name = "label1";
            label1.Size = new Size(193, 28);
            label1.TabIndex = 0;
            label1.Text = "Добавление заявки";
            // 
            // add_btn
            // 
            add_btn.Location = new Point(186, 286);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(193, 42);
            add_btn.TabIndex = 1;
            add_btn.Text = "Добавить";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += add_btn_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(133, 129);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 2;
            // 
            // txtDoc
            // 
            txtDoc.Location = new Point(133, 215);
            txtDoc.Name = "txtDoc";
            txtDoc.Size = new Size(100, 23);
            txtDoc.TabIndex = 3;
            // 
            // txtPlace
            // 
            txtPlace.Location = new Point(133, 171);
            txtPlace.Name = "txtPlace";
            txtPlace.Size = new Size(100, 23);
            txtPlace.TabIndex = 5;
            // 
            // txtNum
            // 
            txtNum.Location = new Point(133, 89);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(100, 23);
            txtNum.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 92);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 8;
            label2.Text = "Номер заявки";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 174);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 9;
            label3.Text = "Место";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 137);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 10;
            label4.Text = "Имя ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 218);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 11;
            label5.Text = "Документы";
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "эконом", "средний", "люкс" });
            cmbType.Location = new Point(403, 92);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(121, 23);
            cmbType.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(343, 95);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 13;
            label6.Text = "Тип тура";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(297, 137);
            label7.Name = "label7";
            label7.Size = new Size(100, 15);
            label7.TabIndex = 15;
            label7.Text = "Кол-во клиентов";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "В ожидании" });
            cmbStatus.Location = new Point(403, 174);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 23);
            cmbStatus.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(354, 179);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 17;
            label8.Text = "Статус";
            // 
            // NumClient
            // 
            NumClient.Location = new Point(403, 135);
            NumClient.Name = "NumClient";
            NumClient.Size = new Size(121, 23);
            NumClient.TabIndex = 18;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 340);
            Controls.Add(NumClient);
            Controls.Add(label8);
            Controls.Add(cmbStatus);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cmbType);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNum);
            Controls.Add(txtPlace);
            Controls.Add(txtDoc);
            Controls.Add(txtName);
            Controls.Add(add_btn);
            Controls.Add(label1);
            Name = "UserForm";
            Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)NumClient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button add_btn;
        private TextBox txtName;
        private TextBox txtDoc;
        private TextBox txtPlace;
        private TextBox txtNum;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbType;
        private Label label6;
        private Label label7;
        private ComboBox cmbStatus;
        private Label label8;
        private NumericUpDown NumClient;
    }
}