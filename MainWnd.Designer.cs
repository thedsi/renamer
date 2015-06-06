namespace kurs
{
    partial class MainWnd
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
            this.btnAddFiles = new System.Windows.Forms.Button();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbIndex = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbLabel = new System.Windows.Forms.TextBox();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpRename = new System.Windows.Forms.GroupBox();
            this.tbActionValue = new System.Windows.Forms.TextBox();
            this.cmbActionType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnDoRename = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblFileCount = new System.Windows.Forms.Label();
            this.lstVars = new kurs.RenameVarListBox();
            this.lstFiles = new kurs.MediaFileListBox();
            this.grpDetails.SuspendLayout();
            this.grpRename.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddFiles
            // 
            this.btnAddFiles.Location = new System.Drawing.Point(18, 12);
            this.btnAddFiles.Name = "btnAddFiles";
            this.btnAddFiles.Size = new System.Drawing.Size(208, 23);
            this.btnAddFiles.TabIndex = 0;
            this.btnAddFiles.Text = "Добавить файлы...";
            this.btnAddFiles.UseVisualStyleBackColor = true;
            this.btnAddFiles.Click += new System.EventHandler(this.btnAddFiles_Click);
            // 
            // grpDetails
            // 
            this.grpDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDetails.Controls.Add(this.label7);
            this.grpDetails.Controls.Add(this.tbIndex);
            this.grpDetails.Controls.Add(this.label5);
            this.grpDetails.Controls.Add(this.tbDesc);
            this.grpDetails.Controls.Add(this.tbTime);
            this.grpDetails.Controls.Add(this.tbDate);
            this.grpDetails.Controls.Add(this.tbLabel);
            this.grpDetails.Controls.Add(this.tbFullName);
            this.grpDetails.Controls.Add(this.label4);
            this.grpDetails.Controls.Add(this.label3);
            this.grpDetails.Controls.Add(this.label2);
            this.grpDetails.Controls.Add(this.label1);
            this.grpDetails.Location = new System.Drawing.Point(244, 12);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(512, 190);
            this.grpDetails.TabIndex = 6;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Сведения о выбранном файле";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Индекс:";
            // 
            // tbIndex
            // 
            this.tbIndex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIndex.BackColor = System.Drawing.SystemColors.Control;
            this.tbIndex.Location = new System.Drawing.Point(104, 154);
            this.tbIndex.Name = "tbIndex";
            this.tbIndex.ReadOnly = true;
            this.tbIndex.Size = new System.Drawing.Size(388, 20);
            this.tbIndex.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Описание:";
            // 
            // tbDesc
            // 
            this.tbDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDesc.BackColor = System.Drawing.SystemColors.Control;
            this.tbDesc.Location = new System.Drawing.Point(104, 128);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.ReadOnly = true;
            this.tbDesc.Size = new System.Drawing.Size(388, 20);
            this.tbDesc.TabIndex = 8;
            // 
            // tbTime
            // 
            this.tbTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTime.BackColor = System.Drawing.SystemColors.Control;
            this.tbTime.Location = new System.Drawing.Point(104, 102);
            this.tbTime.Name = "tbTime";
            this.tbTime.ReadOnly = true;
            this.tbTime.Size = new System.Drawing.Size(388, 20);
            this.tbTime.TabIndex = 7;
            // 
            // tbDate
            // 
            this.tbDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDate.BackColor = System.Drawing.SystemColors.Control;
            this.tbDate.Location = new System.Drawing.Point(104, 76);
            this.tbDate.Name = "tbDate";
            this.tbDate.ReadOnly = true;
            this.tbDate.Size = new System.Drawing.Size(388, 20);
            this.tbDate.TabIndex = 6;
            // 
            // tbLabel
            // 
            this.tbLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLabel.BackColor = System.Drawing.SystemColors.Control;
            this.tbLabel.Location = new System.Drawing.Point(104, 50);
            this.tbLabel.Name = "tbLabel";
            this.tbLabel.ReadOnly = true;
            this.tbLabel.Size = new System.Drawing.Size(388, 20);
            this.tbLabel.TabIndex = 5;
            // 
            // tbFullName
            // 
            this.tbFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFullName.BackColor = System.Drawing.SystemColors.Control;
            this.tbFullName.Location = new System.Drawing.Point(104, 26);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.ReadOnly = true;
            this.tbFullName.Size = new System.Drawing.Size(388, 20);
            this.tbFullName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Время:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Метка:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Полный путь:";
            // 
            // grpRename
            // 
            this.grpRename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRename.Controls.Add(this.tbActionValue);
            this.grpRename.Controls.Add(this.cmbActionType);
            this.grpRename.Controls.Add(this.label6);
            this.grpRename.Controls.Add(this.lstVars);
            this.grpRename.Location = new System.Drawing.Point(244, 208);
            this.grpRename.Name = "grpRename";
            this.grpRename.Size = new System.Drawing.Size(512, 204);
            this.grpRename.TabIndex = 7;
            this.grpRename.TabStop = false;
            // 
            // tbActionValue
            // 
            this.tbActionValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbActionValue.Enabled = false;
            this.tbActionValue.Location = new System.Drawing.Point(158, 99);
            this.tbActionValue.Name = "tbActionValue";
            this.tbActionValue.Size = new System.Drawing.Size(334, 20);
            this.tbActionValue.TabIndex = 3;
            this.tbActionValue.TextChanged += new System.EventHandler(this.tbActionValue_TextChanged);
            // 
            // cmbActionType
            // 
            this.cmbActionType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbActionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActionType.FormattingEnabled = true;
            this.cmbActionType.Location = new System.Drawing.Point(158, 72);
            this.cmbActionType.Name = "cmbActionType";
            this.cmbActionType.Size = new System.Drawing.Size(334, 21);
            this.cmbActionType.TabIndex = 2;
            this.cmbActionType.SelectedIndexChanged += new System.EventHandler(this.cmbActionType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Исправить следующие значения:";
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelectAll.Location = new System.Drawing.Point(18, 461);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(101, 23);
            this.btnSelectAll.TabIndex = 3;
            this.btnSelectAll.Text = "Выбрать все";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearAll.Location = new System.Drawing.Point(125, 461);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(101, 23);
            this.btnClearAll.TabIndex = 4;
            this.btnClearAll.Text = "Снять выбор";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.Location = new System.Drawing.Point(18, 490);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(208, 23);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Убрать отмеченные";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnDoRename
            // 
            this.btnDoRename.Location = new System.Drawing.Point(387, 463);
            this.btnDoRename.Name = "btnDoRename";
            this.btnDoRename.Size = new System.Drawing.Size(200, 50);
            this.btnDoRename.TabIndex = 9;
            this.btnDoRename.Text = "Переименовать файлы";
            this.btnDoRename.UseVisualStyleBackColor = true;
            this.btnDoRename.Click += new System.EventHandler(this.btnDoRename_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(348, 436);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Выбрано файлов:";
            // 
            // lblFileCount
            // 
            this.lblFileCount.AutoSize = true;
            this.lblFileCount.Location = new System.Drawing.Point(450, 436);
            this.lblFileCount.Name = "lblFileCount";
            this.lblFileCount.Size = new System.Drawing.Size(14, 13);
            this.lblFileCount.TabIndex = 11;
            this.lblFileCount.Text = "#";
            // 
            // lstVars
            // 
            this.lstVars.DisplayMember = "Name";
            this.lstVars.FormattingEnabled = true;
            this.lstVars.Location = new System.Drawing.Point(30, 44);
            this.lstVars.Name = "lstVars";
            this.lstVars.Size = new System.Drawing.Size(122, 139);
            this.lstVars.TabIndex = 0;
            this.lstVars.SelectedIndexChanged += new System.EventHandler(this.lstVars_SelectedIndexChanged);
            // 
            // lstFiles
            // 
            this.lstFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstFiles.CheckOnClick = true;
            this.lstFiles.DisplayMember = "Name";
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.Location = new System.Drawing.Point(18, 41);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(208, 409);
            this.lstFiles.TabIndex = 2;
            this.lstFiles.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstFiles_ItemCheck);
            this.lstFiles.SelectedIndexChanged += new System.EventHandler(this.lstFiles_SelectedIndexChanged);
            // 
            // MainWnd
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 546);
            this.Controls.Add(this.lblFileCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDoRename);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddFiles);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.grpRename);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.lstFiles);
            this.Name = "MainWnd";
            this.Text = "Фиксер имён";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainWnd_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainWnd_DragEnter);
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.grpRename.ResumeLayout(false);
            this.grpRename.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MediaFileListBox lstFiles;
        private System.Windows.Forms.Button btnAddFiles;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpRename;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox tbLabel;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnRemove;
        private RenameVarListBox lstVars;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbActionValue;
        private System.Windows.Forms.ComboBox cmbActionType;
        private System.Windows.Forms.Button btnDoRename;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbIndex;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblFileCount;
    }
}

