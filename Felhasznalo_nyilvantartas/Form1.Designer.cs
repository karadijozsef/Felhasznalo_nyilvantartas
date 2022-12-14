namespace Felhasznalo_nyilvantartas
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.listBox_felhasznalok = new System.Windows.Forms.ListBox();
            this.dateTimePicker_szuletes = new System.Windows.Forms.DateTimePicker();
            this.textBox_profilnev = new System.Windows.Forms.TextBox();
            this.insert = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.pictureBox_profilkep = new System.Windows.Forms.PictureBox();
            this.upload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_profilkep)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(283, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Felhasználó nyilvántartás";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Név:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Születési dátum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Profilkép neve:";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(363, 89);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(62, 20);
            this.textBox_id.TabIndex = 5;
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(363, 148);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(148, 20);
            this.textBox_nev.TabIndex = 6;
            // 
            // listBox_felhasznalok
            // 
            this.listBox_felhasznalok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_felhasznalok.FormattingEnabled = true;
            this.listBox_felhasznalok.Location = new System.Drawing.Point(0, 0);
            this.listBox_felhasznalok.Name = "listBox_felhasznalok";
            this.listBox_felhasznalok.Size = new System.Drawing.Size(177, 512);
            this.listBox_felhasznalok.TabIndex = 7;
            // 
            // dateTimePicker_szuletes
            // 
            this.dateTimePicker_szuletes.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_szuletes.Location = new System.Drawing.Point(363, 210);
            this.dateTimePicker_szuletes.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_szuletes.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_szuletes.Name = "dateTimePicker_szuletes";
            this.dateTimePicker_szuletes.Size = new System.Drawing.Size(101, 20);
            this.dateTimePicker_szuletes.TabIndex = 8;
            // 
            // textBox_profilnev
            // 
            this.textBox_profilnev.Location = new System.Drawing.Point(363, 278);
            this.textBox_profilnev.Name = "textBox_profilnev";
            this.textBox_profilnev.Size = new System.Drawing.Size(148, 20);
            this.textBox_profilnev.TabIndex = 9;
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(465, 324);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(137, 43);
            this.insert.TabIndex = 10;
            this.insert.Text = "Új felhasználó hozzáadása";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(465, 384);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(137, 43);
            this.update.TabIndex = 11;
            this.update.Text = "Felhasználó módosítása";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(465, 444);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(137, 43);
            this.delete.TabIndex = 12;
            this.delete.Text = "Felhasználó törlése";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // pictureBox_profilkep
            // 
            this.pictureBox_profilkep.Location = new System.Drawing.Point(227, 324);
            this.pictureBox_profilkep.Name = "pictureBox_profilkep";
            this.pictureBox_profilkep.Size = new System.Drawing.Size(210, 141);
            this.pictureBox_profilkep.TabIndex = 13;
            this.pictureBox_profilkep.TabStop = false;
            // 
            // upload
            // 
            this.upload.Location = new System.Drawing.Point(227, 477);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(120, 23);
            this.upload.TabIndex = 14;
            this.upload.Text = "Profilkép feltöltés";
            this.upload.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 512);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.pictureBox_profilkep);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.textBox_profilnev);
            this.Controls.Add(this.dateTimePicker_szuletes);
            this.Controls.Add(this.listBox_felhasznalok);
            this.Controls.Add(this.textBox_nev);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_profilkep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.ListBox listBox_felhasznalok;
        private System.Windows.Forms.DateTimePicker dateTimePicker_szuletes;
        private System.Windows.Forms.TextBox textBox_profilnev;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.PictureBox pictureBox_profilkep;
        private System.Windows.Forms.Button upload;
    }
}

