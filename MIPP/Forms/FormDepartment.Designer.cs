﻿namespace MIPP.Forms
{
    partial class FormDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDepartment));
            this.gbDepart = new System.Windows.Forms.GroupBox();
            this.dgvImage = new System.Windows.Forms.DataGridView();
            this.cbActivated = new System.Windows.Forms.CheckBox();
            this.btnPhoto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbID = new System.Windows.Forms.MaskedTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvDepart = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.gbDepart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepart)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDepart
            // 
            this.gbDepart.Controls.Add(this.dgvImage);
            this.gbDepart.Controls.Add(this.cbActivated);
            this.gbDepart.Controls.Add(this.btnPhoto);
            this.gbDepart.Controls.Add(this.label2);
            this.gbDepart.Controls.Add(this.label1);
            this.gbDepart.Controls.Add(this.mtbID);
            this.gbDepart.Controls.Add(this.txtName);
            this.gbDepart.Controls.Add(this.btnUpdate);
            this.gbDepart.Controls.Add(this.dgvDepart);
            this.gbDepart.Controls.Add(this.btnDelete);
            this.gbDepart.Controls.Add(this.btnSave);
            this.gbDepart.Location = new System.Drawing.Point(16, 9);
            this.gbDepart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDepart.Name = "gbDepart";
            this.gbDepart.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDepart.Size = new System.Drawing.Size(381, 500);
            this.gbDepart.TabIndex = 1022;
            this.gbDepart.TabStop = false;
            this.gbDepart.Text = "Departamentos";
            // 
            // dgvImage
            // 
            this.dgvImage.AllowUserToAddRows = false;
            this.dgvImage.AllowUserToDeleteRows = false;
            this.dgvImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImage.Location = new System.Drawing.Point(83, 21);
            this.dgvImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvImage.Name = "dgvImage";
            this.dgvImage.ReadOnly = true;
            this.dgvImage.Size = new System.Drawing.Size(357, 469);
            this.dgvImage.TabIndex = 1023;
            this.dgvImage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImage_CellClick);
            this.dgvImage.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImage_CellDoubleClick);
            this.dgvImage.DoubleClick += new System.EventHandler(this.dgvImage_DoubleClick);
            // 
            // cbActivated
            // 
            this.cbActivated.AutoSize = true;
            this.cbActivated.Location = new System.Drawing.Point(301, 22);
            this.cbActivated.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbActivated.Name = "cbActivated";
            this.cbActivated.Size = new System.Drawing.Size(61, 21);
            this.cbActivated.TabIndex = 1029;
            this.cbActivated.Text = "Ativo";
            this.cbActivated.UseVisualStyleBackColor = true;
            this.cbActivated.CheckedChanged += new System.EventHandler(this.cbActivated_CheckedChanged);
            // 
            // btnPhoto
            // 
            this.btnPhoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPhoto.BackgroundImage")));
            this.btnPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPhoto.Location = new System.Drawing.Point(193, 442);
            this.btnPhoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(53, 49);
            this.btnPhoto.TabIndex = 1019;
            this.btnPhoto.UseVisualStyleBackColor = true;
            this.btnPhoto.Click += new System.EventHandler(this.btnPhoto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1028;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 1027;
            this.label1.Text = "ID";
            // 
            // mtbID
            // 
            this.mtbID.Location = new System.Drawing.Point(61, 22);
            this.mtbID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtbID.Mask = "0000";
            this.mtbID.Name = "mtbID";
            this.mtbID.Size = new System.Drawing.Size(44, 22);
            this.mtbID.TabIndex = 1026;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(61, 54);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(305, 22);
            this.txtName.TabIndex = 1025;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdate.Location = new System.Drawing.Point(71, 442);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(53, 49);
            this.btnUpdate.TabIndex = 1022;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvDepart
            // 
            this.dgvDepart.AllowUserToAddRows = false;
            this.dgvDepart.AllowUserToDeleteRows = false;
            this.dgvDepart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepart.Location = new System.Drawing.Point(11, 91);
            this.dgvDepart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDepart.Name = "dgvDepart";
            this.dgvDepart.ReadOnly = true;
            this.dgvDepart.Size = new System.Drawing.Size(357, 343);
            this.dgvDepart.TabIndex = 0;
            this.dgvDepart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProd_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.Location = new System.Drawing.Point(132, 442);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(53, 49);
            this.btnDelete.TabIndex = 1023;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Location = new System.Drawing.Point(9, 442);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(53, 49);
            this.btnSave.TabIndex = 1024;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbBackground);
            this.groupBox1.Location = new System.Drawing.Point(405, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(976, 500);
            this.groupBox1.TabIndex = 1021;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plano de fundo";
            // 
            // pbBackground
            // 
            this.pbBackground.Location = new System.Drawing.Point(8, 21);
            this.pbBackground.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(960, 468);
            this.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackground.TabIndex = 1017;
            this.pbBackground.TabStop = false;
            this.pbBackground.Click += new System.EventHandler(this.pbBackground_Click);
            // 
            // FormDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 521);
            this.Controls.Add(this.gbDepart);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FormDepartment";
            this.Text = "Departamento";
            this.Load += new System.EventHandler(this.FormDepartment_Load);
            this.gbDepart.ResumeLayout(false);
            this.gbDepart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDepart;
        private System.Windows.Forms.DataGridView dgvDepart;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Button btnPhoto;
        private System.Windows.Forms.PictureBox pbBackground;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbActivated;
        private System.Windows.Forms.DataGridView dgvImage;
    }
}