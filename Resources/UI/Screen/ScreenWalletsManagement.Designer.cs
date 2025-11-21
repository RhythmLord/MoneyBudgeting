namespace WinFormsApp1.Screen
{
    partial class ScreenWalletsManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_tenvi = new Label();
            lable_soDu = new Label();
            label_createDate = new Label();
            label_description = new Label();
            comboBox_WalletSelect = new ComboBox();
            label_walletChoose = new Label();
            text_TenVi = new TextBox();
            text_SoDu = new TextBox();
            text_MieuTa = new TextBox();
            button_confirmEdit = new Button();
            linkLabel_Xoa = new LinkLabel();
            button_CreateWallet = new Button();
            CreatedDate = new DateTimePicker();
            isEditing = new CheckBox();
            SuspendLayout();
            // 
            // label_tenvi
            // 
            label_tenvi.AutoSize = true;
            label_tenvi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_tenvi.Location = new Point(123, 146);
            label_tenvi.Name = "label_tenvi";
            label_tenvi.Size = new Size(75, 28);
            label_tenvi.TabIndex = 0;
            label_tenvi.Text = "Tên Ví:";
            // 
            // lable_soDu
            // 
            lable_soDu.AutoSize = true;
            lable_soDu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lable_soDu.Location = new Point(124, 200);
            lable_soDu.Name = "lable_soDu";
            lable_soDu.Size = new Size(74, 28);
            lable_soDu.TabIndex = 1;
            lable_soDu.Text = "Số Dư:";
            // 
            // label_createDate
            // 
            label_createDate.AutoSize = true;
            label_createDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_createDate.Location = new Point(41, 257);
            label_createDate.Name = "label_createDate";
            label_createDate.Size = new Size(157, 28);
            label_createDate.TabIndex = 2;
            label_createDate.Text = "Thời Điểm Tạo:";
            // 
            // label_description
            // 
            label_description.AutoSize = true;
            label_description.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_description.Location = new Point(104, 321);
            label_description.Name = "label_description";
            label_description.Size = new Size(94, 28);
            label_description.TabIndex = 3;
            label_description.Text = "Miêu Tả:";
            // 
            // comboBox_WalletSelect
            // 
            comboBox_WalletSelect.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox_WalletSelect.FormattingEnabled = true;
            comboBox_WalletSelect.Location = new Point(353, 57);
            comboBox_WalletSelect.Name = "comboBox_WalletSelect";
            comboBox_WalletSelect.Size = new Size(249, 33);
            comboBox_WalletSelect.TabIndex = 4;
            comboBox_WalletSelect.SelectedIndexChanged += comboBox_WalletSelect_SelectedIndexChanged;
            // 
            // label_walletChoose
            // 
            label_walletChoose.AutoSize = true;
            label_walletChoose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_walletChoose.Location = new Point(424, 26);
            label_walletChoose.Name = "label_walletChoose";
            label_walletChoose.Size = new Size(85, 28);
            label_walletChoose.TabIndex = 5;
            label_walletChoose.Text = "Chọn Ví";
            // 
            // text_TenVi
            // 
            text_TenVi.Enabled = false;
            text_TenVi.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text_TenVi.Location = new Point(218, 146);
            text_TenVi.Name = "text_TenVi";
            text_TenVi.Size = new Size(686, 31);
            text_TenVi.TabIndex = 6;
            text_TenVi.TextChanged += text_TenVi_TextChanged;
            // 
            // text_SoDu
            // 
            text_SoDu.Enabled = false;
            text_SoDu.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text_SoDu.Location = new Point(218, 200);
            text_SoDu.Name = "text_SoDu";
            text_SoDu.Size = new Size(686, 31);
            text_SoDu.TabIndex = 7;
            // 
            // text_MieuTa
            // 
            text_MieuTa.Enabled = false;
            text_MieuTa.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text_MieuTa.Location = new Point(218, 321);
            text_MieuTa.Multiline = true;
            text_MieuTa.Name = "text_MieuTa";
            text_MieuTa.Size = new Size(686, 138);
            text_MieuTa.TabIndex = 9;
            // 
            // button_confirmEdit
            // 
            button_confirmEdit.BackColor = Color.FromArgb(192, 255, 192);
            button_confirmEdit.Enabled = false;
            button_confirmEdit.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_confirmEdit.ForeColor = Color.Green;
            button_confirmEdit.Location = new Point(392, 474);
            button_confirmEdit.Name = "button_confirmEdit";
            button_confirmEdit.Size = new Size(174, 38);
            button_confirmEdit.TabIndex = 10;
            button_confirmEdit.Text = "Xác Nhận";
            button_confirmEdit.UseVisualStyleBackColor = false;
            button_confirmEdit.Click += button_confirmEdit_Click;
            // 
            // linkLabel_Xoa
            // 
            linkLabel_Xoa.ActiveLinkColor = Color.Maroon;
            linkLabel_Xoa.AutoSize = true;
            linkLabel_Xoa.LinkColor = Color.Red;
            linkLabel_Xoa.Location = new Point(869, 107);
            linkLabel_Xoa.Name = "linkLabel_Xoa";
            linkLabel_Xoa.Size = new Size(35, 20);
            linkLabel_Xoa.TabIndex = 12;
            linkLabel_Xoa.TabStop = true;
            linkLabel_Xoa.Text = "Xóa";
            linkLabel_Xoa.LinkClicked += linkLabel_Xoa_LinkClicked;
            // 
            // button_CreateWallet
            // 
            button_CreateWallet.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_CreateWallet.Location = new Point(620, 57);
            button_CreateWallet.Name = "button_CreateWallet";
            button_CreateWallet.Size = new Size(123, 33);
            button_CreateWallet.TabIndex = 13;
            button_CreateWallet.Text = "Tạo Ví Mới";
            button_CreateWallet.UseVisualStyleBackColor = true;
            button_CreateWallet.Click += button_CreateWallet_Click;
            // 
            // CreatedDate
            // 
            CreatedDate.Enabled = false;
            CreatedDate.Location = new Point(218, 259);
            CreatedDate.Name = "CreatedDate";
            CreatedDate.Size = new Size(250, 27);
            CreatedDate.TabIndex = 14;
            // 
            // isEditing
            // 
            isEditing.AutoSize = true;
            isEditing.ForeColor = Color.Blue;
            isEditing.Location = new Point(752, 107);
            isEditing.Name = "isEditing";
            isEditing.Size = new Size(97, 24);
            isEditing.TabIndex = 15;
            isEditing.Text = "Chỉnh Sửa";
            isEditing.UseVisualStyleBackColor = true;
            isEditing.CheckedChanged += isEditing_CheckedChanged;
            // 
            // UserControlWalletManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(isEditing);
            Controls.Add(CreatedDate);
            Controls.Add(button_CreateWallet);
            Controls.Add(linkLabel_Xoa);
            Controls.Add(button_confirmEdit);
            Controls.Add(text_MieuTa);
            Controls.Add(text_SoDu);
            Controls.Add(text_TenVi);
            Controls.Add(label_walletChoose);
            Controls.Add(comboBox_WalletSelect);
            Controls.Add(label_description);
            Controls.Add(label_createDate);
            Controls.Add(lable_soDu);
            Controls.Add(label_tenvi);
            Name = "UserControlWalletManagement";
            Size = new Size(973, 533);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_tenvi;
        private Label lable_soDu;
        private Label label_createDate;
        private Label label_description;
        private ComboBox comboBox_WalletSelect;
        private Label label_walletChoose;
        private TextBox text_TenVi;
        private TextBox text_SoDu;
        private TextBox text_MieuTa;
        private Button button_confirmEdit;
        private LinkLabel linkLabel_Xoa;
        private Button button_CreateWallet;
        private DateTimePicker CreatedDate;
        private CheckBox isEditing;
    }
}
