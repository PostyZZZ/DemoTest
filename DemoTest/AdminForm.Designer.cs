namespace DemoTest
{
    partial class AdminForm
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
            dataGridViewRequests = new DataGridView();
            btn_succ = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequests).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(482, 9);
            label1.Name = "label1";
            label1.Size = new Size(159, 28);
            label1.TabIndex = 0;
            label1.Text = "Администрация";
            // 
            // dataGridViewRequests
            // 
            dataGridViewRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRequests.Location = new Point(12, 48);
            dataGridViewRequests.Name = "dataGridViewRequests";
            dataGridViewRequests.Size = new Size(1078, 390);
            dataGridViewRequests.TabIndex = 1;
            // 
            // btn_succ
            // 
            btn_succ.Location = new Point(953, 8);
            btn_succ.Name = "btn_succ";
            btn_succ.Size = new Size(137, 34);
            btn_succ.TabIndex = 2;
            btn_succ.Text = "Принять изменения";
            btn_succ.UseVisualStyleBackColor = true;
            btn_succ.Click += btn_succ_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 450);
            Controls.Add(btn_succ);
            Controls.Add(dataGridViewRequests);
            Controls.Add(label1);
            Name = "AdminForm";
            Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewRequests;
        private Button btn_succ;
    }
}