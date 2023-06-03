namespace DotNetWinFormApp.UI
{
    partial class frmEmployDetail
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
            groupBox1 = new GroupBox();
            idLable = new Label();
            updateButton = new Button();
            phoneTextBox = new TextBox();
            emailTextBox = new TextBox();
            nameTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(idLable);
            groupBox1.Controls.Add(updateButton);
            groupBox1.Controls.Add(phoneTextBox);
            groupBox1.Controls.Add(emailTextBox);
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(1, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(389, 219);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Employee Information";
            // 
            // idLable
            // 
            idLable.AutoSize = true;
            idLable.Location = new Point(303, 22);
            idLable.Name = "idLable";
            idLable.Size = new Size(0, 21);
            idLable.TabIndex = 14;
            idLable.Visible = false;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(244, 167);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(75, 29);
            updateButton.TabIndex = 13;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(111, 123);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(208, 29);
            phoneTextBox.TabIndex = 12;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(111, 84);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(208, 29);
            emailTextBox.TabIndex = 11;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(111, 46);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(208, 29);
            nameTextBox.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 123);
            label3.Name = "label3";
            label3.Size = new Size(54, 21);
            label3.TabIndex = 9;
            label3.Text = "Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 84);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 8;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 46);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 7;
            label1.Text = "Name";
            // 
            // frmEmployDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 226);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEmployDetail";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmEmployDetail";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button updateButton;
        private Label label3;
        private Label label2;
        private Label label1;
        public TextBox phoneTextBox;
        public TextBox emailTextBox;
        public TextBox nameTextBox;
        public Label idLable;
    }
}