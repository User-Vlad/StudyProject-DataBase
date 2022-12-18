namespace ISHospital
{
    partial class MenuForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.bAddInfo = new System.Windows.Forms.Button();
            this.bSearchInfo = new System.Windows.Forms.Button();
            this.bQueryBD = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(47, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Меню ИС \"Больница+\"";
            // 
            // bAddInfo
            // 
            this.bAddInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bAddInfo.Location = new System.Drawing.Point(47, 81);
            this.bAddInfo.Name = "bAddInfo";
            this.bAddInfo.Size = new System.Drawing.Size(328, 43);
            this.bAddInfo.TabIndex = 1;
            this.bAddInfo.Text = "Добавить данные";
            this.bAddInfo.UseVisualStyleBackColor = true;
            this.bAddInfo.Click += new System.EventHandler(this.bAddInfo_Click);
            // 
            // bSearchInfo
            // 
            this.bSearchInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bSearchInfo.Location = new System.Drawing.Point(47, 148);
            this.bSearchInfo.Name = "bSearchInfo";
            this.bSearchInfo.Size = new System.Drawing.Size(328, 43);
            this.bSearchInfo.TabIndex = 2;
            this.bSearchInfo.Text = "Поиск данных";
            this.bSearchInfo.UseVisualStyleBackColor = true;
            // 
            // bQueryBD
            // 
            this.bQueryBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bQueryBD.Location = new System.Drawing.Point(47, 222);
            this.bQueryBD.Name = "bQueryBD";
            this.bQueryBD.Size = new System.Drawing.Size(328, 43);
            this.bQueryBD.TabIndex = 3;
            this.bQueryBD.Text = "Выполнение запросов";
            this.bQueryBD.UseVisualStyleBackColor = true;
            // 
            // bExit
            // 
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bExit.Location = new System.Drawing.Point(47, 322);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(328, 43);
            this.bExit.TabIndex = 4;
            this.bExit.Text = "Выход из программы";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 384);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bQueryBD);
            this.Controls.Add(this.bSearchInfo);
            this.Controls.Add(this.bAddInfo);
            this.Controls.Add(this.label1);
            this.Name = "MenuForm";
            this.Text = "Меню ИС \"Больница+\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button bAddInfo;
        private Button bSearchInfo;
        private Button bQueryBD;
        private Button bExit;
    }
}