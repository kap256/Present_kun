namespace Present_kun
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.list_Names = new System.Windows.Forms.ListBox();
            this.label_Result = new System.Windows.Forms.Label();
            this.text_AddName = new System.Windows.Forms.TextBox();
            this.button_AddName = new System.Windows.Forms.Button();
            this.button_Result = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_Names
            // 
            this.list_Names.FormattingEnabled = true;
            this.list_Names.ItemHeight = 21;
            this.list_Names.Location = new System.Drawing.Point(13, 13);
            this.list_Names.Name = "list_Names";
            this.list_Names.Size = new System.Drawing.Size(424, 403);
            this.list_Names.TabIndex = 0;
            this.list_Names.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_Names_MouseDoubleClick);
            // 
            // label_Result
            // 
            this.label_Result.AutoSize = true;
            this.label_Result.Location = new System.Drawing.Point(444, 13);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(0, 21);
            this.label_Result.TabIndex = 1;
            // 
            // text_AddName
            // 
            this.text_AddName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.text_AddName.Location = new System.Drawing.Point(13, 441);
            this.text_AddName.Name = "text_AddName";
            this.text_AddName.Size = new System.Drawing.Size(332, 28);
            this.text_AddName.TabIndex = 2;
            // 
            // button_AddName
            // 
            this.button_AddName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_AddName.Location = new System.Drawing.Point(351, 435);
            this.button_AddName.Name = "button_AddName";
            this.button_AddName.Size = new System.Drawing.Size(92, 38);
            this.button_AddName.TabIndex = 3;
            this.button_AddName.Text = "追加";
            this.button_AddName.UseVisualStyleBackColor = true;
            this.button_AddName.Click += new System.EventHandler(this.button_AddName_Click);
            // 
            // button_Result
            // 
            this.button_Result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Result.Location = new System.Drawing.Point(807, 435);
            this.button_Result.Name = "button_Result";
            this.button_Result.Size = new System.Drawing.Size(92, 38);
            this.button_Result.TabIndex = 4;
            this.button_Result.Text = "抽選";
            this.button_Result.UseVisualStyleBackColor = true;
            this.button_Result.Click += new System.EventHandler(this.button_Result_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button_AddName;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 486);
            this.Controls.Add(this.button_Result);
            this.Controls.Add(this.button_AddName);
            this.Controls.Add(this.text_AddName);
            this.Controls.Add(this.label_Result);
            this.Controls.Add(this.list_Names);
            this.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "プレゼントくん";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_Names;
        private System.Windows.Forms.Label label_Result;
        private System.Windows.Forms.TextBox text_AddName;
        private System.Windows.Forms.Button button_AddName;
        private System.Windows.Forms.Button button_Result;
    }
}

