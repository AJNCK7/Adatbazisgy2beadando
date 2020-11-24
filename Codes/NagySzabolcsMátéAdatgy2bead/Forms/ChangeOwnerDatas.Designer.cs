
namespace NagySzabolcsMátéAdatgy2bead
{
    partial class ChangeOwnerDatas
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
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Set = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_NewSet = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(22, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Choose which data to change";
            // 
            // cb_Set
            // 
            this.cb_Set.FormattingEnabled = true;
            this.cb_Set.Location = new System.Drawing.Point(26, 36);
            this.cb_Set.Name = "cb_Set";
            this.cb_Set.Size = new System.Drawing.Size(247, 21);
            this.cb_Set.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(302, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "New data";
            // 
            // tb_NewSet
            // 
            this.tb_NewSet.Location = new System.Drawing.Point(306, 37);
            this.tb_NewSet.Name = "tb_NewSet";
            this.tb_NewSet.Size = new System.Drawing.Size(244, 20);
            this.tb_NewSet.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChangeOwnerDatas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 83);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_Set);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_NewSet);
            this.Name = "ChangeOwnerDatas";
            this.Text = "ChangeOwnerDatas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Set;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_NewSet;
        private System.Windows.Forms.Button button1;
    }
}