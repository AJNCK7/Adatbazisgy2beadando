namespace NagySzabolcsMátéAdatgy2bead
{
    partial class NewAnimal
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_owner = new System.Windows.Forms.ComboBox();
            this.cb_animalgender = new System.Windows.Forms.ComboBox();
            this.cb_isivartalanitott = new System.Windows.Forms.ComboBox();
            this.dtp_birthdate = new System.Windows.Forms.DateTimePicker();
            this.tb_animalname = new System.Windows.Forms.TextBox();
            this.btn_newanimalsave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(40, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Owner";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(40, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Animal name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(40, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birth Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(38, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Animal gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(40, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "IsIvartalanitot";
            // 
            // cb_owner
            // 
            this.cb_owner.FormattingEnabled = true;
            this.cb_owner.Location = new System.Drawing.Point(158, 12);
            this.cb_owner.Name = "cb_owner";
            this.cb_owner.Size = new System.Drawing.Size(200, 21);
            this.cb_owner.TabIndex = 5;
            // 
            // cb_animalgender
            // 
            this.cb_animalgender.FormattingEnabled = true;
            this.cb_animalgender.Location = new System.Drawing.Point(158, 90);
            this.cb_animalgender.Name = "cb_animalgender";
            this.cb_animalgender.Size = new System.Drawing.Size(200, 21);
            this.cb_animalgender.TabIndex = 6;
            // 
            // cb_isivartalanitott
            // 
            this.cb_isivartalanitott.FormattingEnabled = true;
            this.cb_isivartalanitott.Location = new System.Drawing.Point(158, 117);
            this.cb_isivartalanitott.Name = "cb_isivartalanitott";
            this.cb_isivartalanitott.Size = new System.Drawing.Size(200, 21);
            this.cb_isivartalanitott.TabIndex = 7;
            // 
            // dtp_birthdate
            // 
            this.dtp_birthdate.Location = new System.Drawing.Point(158, 64);
            this.dtp_birthdate.Name = "dtp_birthdate";
            this.dtp_birthdate.Size = new System.Drawing.Size(200, 20);
            this.dtp_birthdate.TabIndex = 8;
            // 
            // tb_animalname
            // 
            this.tb_animalname.Location = new System.Drawing.Point(158, 40);
            this.tb_animalname.Name = "tb_animalname";
            this.tb_animalname.Size = new System.Drawing.Size(200, 20);
            this.tb_animalname.TabIndex = 9;
            // 
            // btn_newanimalsave
            // 
            this.btn_newanimalsave.Location = new System.Drawing.Point(44, 146);
            this.btn_newanimalsave.Name = "btn_newanimalsave";
            this.btn_newanimalsave.Size = new System.Drawing.Size(314, 23);
            this.btn_newanimalsave.TabIndex = 10;
            this.btn_newanimalsave.Text = "Add";
            this.btn_newanimalsave.UseVisualStyleBackColor = true;
            // 
            // NewAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 181);
            this.Controls.Add(this.btn_newanimalsave);
            this.Controls.Add(this.tb_animalname);
            this.Controls.Add(this.dtp_birthdate);
            this.Controls.Add(this.cb_isivartalanitott);
            this.Controls.Add(this.cb_animalgender);
            this.Controls.Add(this.cb_owner);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewAnimal";
            this.Text = "NewAnimal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_owner;
        private System.Windows.Forms.ComboBox cb_animalgender;
        private System.Windows.Forms.ComboBox cb_isivartalanitott;
        private System.Windows.Forms.DateTimePicker dtp_birthdate;
        private System.Windows.Forms.TextBox tb_animalname;
        private System.Windows.Forms.Button btn_newanimalsave;
    }
}