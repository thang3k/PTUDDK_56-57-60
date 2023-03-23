namespace _57
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
            this.btnButton = new System.Windows.Forms.Button();
            this.btnFlat = new System.Windows.Forms.Button();
            this.ckbMauChu = new System.Windows.Forms.CheckBox();
            this.chkMauNen = new System.Windows.Forms.CheckBox();
            this.rdFlat = new System.Windows.Forms.RadioButton();
            this.rdPopUp = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnButton
            // 
            this.btnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnButton.ForeColor = System.Drawing.Color.Red;
            this.btnButton.Location = new System.Drawing.Point(31, 43);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(94, 23);
            this.btnButton.TabIndex = 0;
            this.btnButton.Text = "Button";
            this.btnButton.UseVisualStyleBackColor = true;
            // 
            // btnFlat
            // 
            this.btnFlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlat.ForeColor = System.Drawing.Color.Black;
            this.btnFlat.Location = new System.Drawing.Point(31, 124);
            this.btnFlat.Name = "btnFlat";
            this.btnFlat.Size = new System.Drawing.Size(94, 23);
            this.btnFlat.TabIndex = 0;
            this.btnFlat.Text = "Button flat";
            this.btnFlat.UseVisualStyleBackColor = true;
            // 
            // ckbMauChu
            // 
            this.ckbMauChu.AutoSize = true;
            this.ckbMauChu.Checked = true;
            this.ckbMauChu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbMauChu.Location = new System.Drawing.Point(181, 26);
            this.ckbMauChu.Name = "ckbMauChu";
            this.ckbMauChu.Size = new System.Drawing.Size(112, 17);
            this.ckbMauChu.TabIndex = 1;
            this.ckbMauChu.Text = "Thay đổi màu chữ";
            this.ckbMauChu.UseVisualStyleBackColor = true;
            this.ckbMauChu.CheckedChanged += new System.EventHandler(this.ckbMauChu_CheckedChanged);
            // 
            // chkMauNen
            // 
            this.chkMauNen.AutoSize = true;
            this.chkMauNen.Checked = true;
            this.chkMauNen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMauNen.Location = new System.Drawing.Point(181, 49);
            this.chkMauNen.Name = "chkMauNen";
            this.chkMauNen.Size = new System.Drawing.Size(112, 17);
            this.chkMauNen.TabIndex = 1;
            this.chkMauNen.Text = "Thay đổi màu nền";
            this.chkMauNen.UseVisualStyleBackColor = true;
            this.chkMauNen.CheckedChanged += new System.EventHandler(this.chkMauNen_CheckedChanged);
            // 
            // rdFlat
            // 
            this.rdFlat.AutoSize = true;
            this.rdFlat.Location = new System.Drawing.Point(181, 112);
            this.rdFlat.Name = "rdFlat";
            this.rdFlat.Size = new System.Drawing.Size(63, 17);
            this.rdFlat.TabIndex = 2;
            this.rdFlat.Text = "Kiểu flat";
            this.rdFlat.UseVisualStyleBackColor = true;
            this.rdFlat.CheckedChanged += new System.EventHandler(this.rdFlat_CheckedChanged);
            // 
            // rdPopUp
            // 
            this.rdPopUp.AutoSize = true;
            this.rdPopUp.Checked = true;
            this.rdPopUp.Location = new System.Drawing.Point(181, 135);
            this.rdPopUp.Name = "rdPopUp";
            this.rdPopUp.Size = new System.Drawing.Size(80, 17);
            this.rdPopUp.TabIndex = 2;
            this.rdPopUp.TabStop = true;
            this.rdPopUp.Text = "Kiểu Popup";
            this.rdPopUp.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 182);
            this.Controls.Add(this.rdPopUp);
            this.Controls.Add(this.rdFlat);
            this.Controls.Add(this.chkMauNen);
            this.Controls.Add(this.ckbMauChu);
            this.Controls.Add(this.btnFlat);
            this.Controls.Add(this.btnButton);
            this.Name = "Form1";
            this.Text = "Buttons";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnButton;
        private System.Windows.Forms.Button btnFlat;
        private System.Windows.Forms.CheckBox ckbMauChu;
        private System.Windows.Forms.CheckBox chkMauNen;
        private System.Windows.Forms.RadioButton rdFlat;
        private System.Windows.Forms.RadioButton rdPopUp;
    }
}

