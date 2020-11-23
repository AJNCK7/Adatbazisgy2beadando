namespace NagySzabolcsMátéAdatgy2bead
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_OwnORAni = new System.Windows.Forms.ComboBox();
            this.btn_NewOwner = new System.Windows.Forms.Button();
            this.btn_newanimal = new System.Windows.Forms.Button();
            this.dgv_table = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Animal Clinic";
            // 
            // cb_OwnORAni
            // 
            this.cb_OwnORAni.FormattingEnabled = true;
            this.cb_OwnORAni.Location = new System.Drawing.Point(13, 69);
            this.cb_OwnORAni.Name = "cb_OwnORAni";
            this.cb_OwnORAni.Size = new System.Drawing.Size(148, 21);
            this.cb_OwnORAni.TabIndex = 1;
            this.cb_OwnORAni.Text = "Tulajdonos";
            this.cb_OwnORAni.SelectedIndexChanged += new System.EventHandler(this.cb_OwnORAni_SelectedIndexChanged_1);
            // 
            // btn_NewOwner
            // 
            this.btn_NewOwner.Location = new System.Drawing.Point(167, 69);
            this.btn_NewOwner.Name = "btn_NewOwner";
            this.btn_NewOwner.Size = new System.Drawing.Size(172, 23);
            this.btn_NewOwner.TabIndex = 2;
            this.btn_NewOwner.Text = "New owner";
            this.btn_NewOwner.UseVisualStyleBackColor = true;
            this.btn_NewOwner.Click += new System.EventHandler(this.btn_NewOwner_Click);
            // 
            // btn_newanimal
            // 
            this.btn_newanimal.Location = new System.Drawing.Point(167, 99);
            this.btn_newanimal.Name = "btn_newanimal";
            this.btn_newanimal.Size = new System.Drawing.Size(172, 23);
            this.btn_newanimal.TabIndex = 3;
            this.btn_newanimal.Text = "New animal";
            this.btn_newanimal.UseVisualStyleBackColor = true;
            this.btn_newanimal.Click += new System.EventHandler(this.btn_newanimal_Click);
            // 
            // dgv_table
            // 
            this.dgv_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_table.Location = new System.Drawing.Point(13, 140);
            this.dgv_table.Name = "dgv_table";
            this.dgv_table.Size = new System.Drawing.Size(775, 298);
            this.dgv_table.TabIndex = 4;
            this.dgv_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_table_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_table);
            this.Controls.Add(this.btn_newanimal);
            this.Controls.Add(this.btn_NewOwner);
            this.Controls.Add(this.cb_OwnORAni);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_OwnORAni;
        private System.Windows.Forms.Button btn_NewOwner;
        private System.Windows.Forms.Button btn_newanimal;
        private System.Windows.Forms.DataGridView dgv_table;
    }
}

