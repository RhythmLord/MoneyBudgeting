namespace WinFormsApp1.Forms
{
    partial class FormCreateWallet
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
            label_walletName = new Label();
            label_SoDuBanDau = new Label();
            label_description = new Label();
            input_walletName = new TextBox();
            input_soDuBanDau = new TextBox();
            input_mieuTa = new TextBox();
            button_confirmCreate = new Button();
            SuspendLayout();
            // 
            // label_walletName
            // 
            label_walletName.AutoSize = true;
            label_walletName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_walletName.Location = new Point(72, 35);
            label_walletName.Name = "label_walletName";
            label_walletName.Size = new Size(62, 25);
            label_walletName.TabIndex = 0;
            label_walletName.Text = "Tên Ví:";
            // 
            // label_SoDuBanDau
            // 
            label_SoDuBanDau.AutoSize = true;
            label_SoDuBanDau.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_SoDuBanDau.Location = new Point(0, 87);
            label_SoDuBanDau.Name = "label_SoDuBanDau";
            label_SoDuBanDau.Size = new Size(134, 25);
            label_SoDuBanDau.TabIndex = 1;
            label_SoDuBanDau.Text = "Số dư ban đầu:";
            // 
            // label_description
            // 
            label_description.AutoSize = true;
            label_description.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_description.Location = new Point(59, 142);
            label_description.Name = "label_description";
            label_description.Size = new Size(75, 25);
            label_description.TabIndex = 2;
            label_description.Text = "Miêu tả:";
            // 
            // input_walletName
            // 
            input_walletName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            input_walletName.Location = new Point(140, 32);
            input_walletName.Name = "input_walletName";
            input_walletName.Size = new Size(248, 31);
            input_walletName.TabIndex = 3;
            // 
            // input_soDuBanDau
            // 
            input_soDuBanDau.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            input_soDuBanDau.Location = new Point(140, 87);
            input_soDuBanDau.Name = "input_soDuBanDau";
            input_soDuBanDau.Size = new Size(248, 31);
            input_soDuBanDau.TabIndex = 4;
            // 
            // input_mieuTa
            // 
            input_mieuTa.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            input_mieuTa.Location = new Point(140, 142);
            input_mieuTa.Multiline = true;
            input_mieuTa.Name = "input_mieuTa";
            input_mieuTa.Size = new Size(373, 206);
            input_mieuTa.TabIndex = 5;
            // 
            // button_confirmCreate
            // 
            button_confirmCreate.BackColor = Color.FromArgb(192, 255, 192);
            button_confirmCreate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_confirmCreate.ForeColor = Color.Green;
            button_confirmCreate.Location = new Point(198, 375);
            button_confirmCreate.Name = "button_confirmCreate";
            button_confirmCreate.Size = new Size(119, 37);
            button_confirmCreate.TabIndex = 6;
            button_confirmCreate.Text = "Xác Nhận";
            button_confirmCreate.UseVisualStyleBackColor = false;
            button_confirmCreate.Click += button_confirmCreate_Click;
            // 
            // FormCreateWallet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(525, 424);
            Controls.Add(button_confirmCreate);
            Controls.Add(input_mieuTa);
            Controls.Add(input_soDuBanDau);
            Controls.Add(input_walletName);
            Controls.Add(label_description);
            Controls.Add(label_SoDuBanDau);
            Controls.Add(label_walletName);
            Name = "FormCreateWallet";
            Text = "FormCreateWallet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_walletName;
        private Label label_SoDuBanDau;
        private Label label_description;
        private TextBox input_walletName;
        private TextBox input_soDuBanDau;
        private TextBox input_mieuTa;
        private Button button_confirmCreate;
    }
}