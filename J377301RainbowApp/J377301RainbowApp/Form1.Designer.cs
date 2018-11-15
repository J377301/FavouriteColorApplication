namespace J377301RainbowApp
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
            this.btn_Favourite = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.flowLayoutPanelColors = new System.Windows.Forms.FlowLayoutPanel();
            this.favColorList = new System.Windows.Forms.ListBox();
            this.labelJsonString = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Favourite
            // 
            this.btn_Favourite.Location = new System.Drawing.Point(55, 12);
            this.btn_Favourite.Name = "btn_Favourite";
            this.btn_Favourite.Size = new System.Drawing.Size(149, 23);
            this.btn_Favourite.TabIndex = 0;
            this.btn_Favourite.Text = "Favourite Color";
            this.btn_Favourite.UseVisualStyleBackColor = true;
            this.btn_Favourite.Click += new System.EventHandler(this.btn_Favourite_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(266, 12);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(144, 23);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "Save and Write (Serialize)";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // flowLayoutPanelColors
            // 
            this.flowLayoutPanelColors.Location = new System.Drawing.Point(441, 20);
            this.flowLayoutPanelColors.Name = "flowLayoutPanelColors";
            this.flowLayoutPanelColors.Size = new System.Drawing.Size(385, 386);
            this.flowLayoutPanelColors.TabIndex = 3;
            // 
            // favColorList
            // 
            this.favColorList.FormattingEnabled = true;
            this.favColorList.Location = new System.Drawing.Point(55, 79);
            this.favColorList.Name = "favColorList";
            this.favColorList.Size = new System.Drawing.Size(355, 95);
            this.favColorList.TabIndex = 4;
            // 
            // labelJsonString
            // 
            this.labelJsonString.AutoSize = true;
            this.labelJsonString.Location = new System.Drawing.Point(52, 197);
            this.labelJsonString.Name = "labelJsonString";
            this.labelJsonString.Size = new System.Drawing.Size(190, 13);
            this.labelJsonString.TabIndex = 5;
            this.labelJsonString.Text = "JSON formatted string will appear here.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "You can choose more than one color ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 429);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelJsonString);
            this.Controls.Add(this.favColorList);
            this.Controls.Add(this.flowLayoutPanelColors);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Favourite);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Favourite;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelColors;
        private System.Windows.Forms.ListBox favColorList;
        private System.Windows.Forms.Label labelJsonString;
        private System.Windows.Forms.Label label1;
    }
}

