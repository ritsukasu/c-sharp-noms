namespace Valencia_RyanLabStream_1
{
    partial class FrmOpenTextFile
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lvShowText = new System.Windows.Forms.ListView();
            colText = new System.Windows.Forms.ColumnHeader();
            btnOpen = new System.Windows.Forms.Button();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            SuspendLayout();
            // 
            // lvShowText
            // 
            lvShowText.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { colText });
            lvShowText.FullRowSelect = true;
            lvShowText.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            lvShowText.Location = new System.Drawing.Point(12, 12);
            lvShowText.Name = "lvShowText";
            lvShowText.Size = new System.Drawing.Size(406, 230);
            lvShowText.TabIndex = 0;
            lvShowText.UseCompatibleStateImageBehavior = false;
            lvShowText.View = System.Windows.Forms.View.Details;
            // 
            // colText
            // 
            colText.Text = "Text";
            colText.Width = 381;
            // 
            // btnOpen
            // 
            btnOpen.Location = new System.Drawing.Point(160, 255);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new System.Drawing.Size(110, 32);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmOpenTextFile
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(430, 305);
            Controls.Add(btnOpen);
            Controls.Add(lvShowText);
            Name = "FrmOpenTextFile";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FrmOpenTextFile";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ListView lvShowText;
        private System.Windows.Forms.ColumnHeader colText;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
