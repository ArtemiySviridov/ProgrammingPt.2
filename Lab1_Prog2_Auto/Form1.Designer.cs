namespace Lab1_Prog2_Auto
{
    partial class Lab1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.addData = new System.Windows.Forms.Label();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.textBoxDiagnosticYear = new System.Windows.Forms.TextBox();
            this.textBoxReleaseYear = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.brand = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.Label();
            this.releaseYear = new System.Windows.Forms.Label();
            this.diagnosticYear = new System.Windows.Forms.Label();
            this.owner = new System.Windows.Forms.Label();
            this.textBoxOwner = new System.Windows.Forms.TextBox();
            this.dataGridViewCars = new System.Windows.Forms.DataGridView();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.automobileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewFines = new System.Windows.Forms.DataGridView();
            this.FineSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Intruder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fineSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.intruderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonIssueFine = new System.Windows.Forms.Button();
            this.buttonPayFine = new System.Windows.Forms.Button();
            this.buttonSell = new System.Windows.Forms.Button();
            this.textBoxFineSum = new System.Windows.Forms.TextBox();
            this.buttonReg = new System.Windows.Forms.Button();
            this.labelNewOwner = new System.Windows.Forms.Label();
            this.textBoxNewOwner = new System.Windows.Forms.TextBox();
            this.buttonDiagnostic = new System.Windows.Forms.Button();
            this.labelFineSum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addData
            // 
            this.addData.AutoSize = true;
            this.addData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addData.Location = new System.Drawing.Point(110, 30);
            this.addData.Name = "addData";
            this.addData.Size = new System.Drawing.Size(188, 25);
            this.addData.TabIndex = 0;
            this.addData.Text = "Заполните данные";
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(161, 67);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(223, 22);
            this.textBoxBrand.TabIndex = 1;
            // 
            // textBoxDiagnosticYear
            // 
            this.textBoxDiagnosticYear.Location = new System.Drawing.Point(161, 188);
            this.textBoxDiagnosticYear.Name = "textBoxDiagnosticYear";
            this.textBoxDiagnosticYear.Size = new System.Drawing.Size(223, 22);
            this.textBoxDiagnosticYear.TabIndex = 2;
            // 
            // textBoxReleaseYear
            // 
            this.textBoxReleaseYear.Location = new System.Drawing.Point(161, 142);
            this.textBoxReleaseYear.Name = "textBoxReleaseYear";
            this.textBoxReleaseYear.Size = new System.Drawing.Size(223, 22);
            this.textBoxReleaseYear.TabIndex = 3;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(161, 105);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(223, 22);
            this.textBoxModel.TabIndex = 4;
            // 
            // brand
            // 
            this.brand.AutoSize = true;
            this.brand.Location = new System.Drawing.Point(20, 67);
            this.brand.Name = "brand";
            this.brand.Size = new System.Drawing.Size(49, 16);
            this.brand.TabIndex = 5;
            this.brand.Text = "Марка";
            // 
            // model
            // 
            this.model.AutoSize = true;
            this.model.Location = new System.Drawing.Point(20, 105);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(57, 16);
            this.model.TabIndex = 6;
            this.model.Text = "Модель";
            // 
            // releaseYear
            // 
            this.releaseYear.AutoSize = true;
            this.releaseYear.Location = new System.Drawing.Point(20, 142);
            this.releaseYear.Name = "releaseYear";
            this.releaseYear.Size = new System.Drawing.Size(88, 16);
            this.releaseYear.TabIndex = 7;
            this.releaseYear.Text = "Год выпуска";
            // 
            // diagnosticYear
            // 
            this.diagnosticYear.AutoSize = true;
            this.diagnosticYear.Location = new System.Drawing.Point(20, 188);
            this.diagnosticYear.Name = "diagnosticYear";
            this.diagnosticYear.Size = new System.Drawing.Size(119, 32);
            this.diagnosticYear.TabIndex = 8;
            this.diagnosticYear.Text = "Год прохождения\r\nтехосмотра";
            // 
            // owner
            // 
            this.owner.AutoSize = true;
            this.owner.Location = new System.Drawing.Point(20, 238);
            this.owner.Name = "owner";
            this.owner.Size = new System.Drawing.Size(112, 16);
            this.owner.TabIndex = 9;
            this.owner.Text = "ФИО владельца";
            // 
            // textBoxOwner
            // 
            this.textBoxOwner.Location = new System.Drawing.Point(161, 238);
            this.textBoxOwner.Name = "textBoxOwner";
            this.textBoxOwner.Size = new System.Drawing.Size(223, 22);
            this.textBoxOwner.TabIndex = 14;
            // 
            // dataGridViewCars
            // 
            this.dataGridViewCars.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCars.AutoGenerateColumns = false;
            this.dataGridViewCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brandDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewCars.DataSource = this.automobileBindingSource;
            this.dataGridViewCars.Location = new System.Drawing.Point(420, 13);
            this.dataGridViewCars.Name = "dataGridViewCars";
            this.dataGridViewCars.RowHeadersWidth = 51;
            this.dataGridViewCars.RowTemplate.Height = 24;
            this.dataGridViewCars.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewCars.Size = new System.Drawing.Size(876, 159);
            this.dataGridViewCars.TabIndex = 15;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Марка";
            this.brandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.ReadOnly = true;
            this.brandDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn1.HeaderText = "Модель";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ReleaseYear";
            this.dataGridViewTextBoxColumn2.HeaderText = "Год выпуска";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DiagnosticYear";
            this.dataGridViewTextBoxColumn3.HeaderText = "Год прохождения ТО";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Owner";
            this.dataGridViewTextBoxColumn4.HeaderText = "ФИО Владельца";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // automobileBindingSource
            // 
            this.automobileBindingSource.DataSource = typeof(Automobile_Class.Automobile);
            // 
            // dataGridViewFines
            // 
            this.dataGridViewFines.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFines.AutoGenerateColumns = false;
            this.dataGridViewFines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FineSum,
            this.Status,
            this.Intruder,
            this.fineSumDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn,
            this.intruderDataGridViewTextBoxColumn});
            this.dataGridViewFines.DataSource = this.fineBindingSource;
            this.dataGridViewFines.Location = new System.Drawing.Point(750, 188);
            this.dataGridViewFines.Name = "dataGridViewFines";
            this.dataGridViewFines.RowHeadersWidth = 51;
            this.dataGridViewFines.RowTemplate.Height = 24;
            this.dataGridViewFines.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewFines.Size = new System.Drawing.Size(546, 135);
            this.dataGridViewFines.TabIndex = 16;
            // 
            // FineSum
            // 
            this.FineSum.DataPropertyName = "FineSum";
            this.FineSum.HeaderText = "Сумма штрафа";
            this.FineSum.MinimumWidth = 6;
            this.FineSum.Name = "FineSum";
            this.FineSum.ReadOnly = true;
            this.FineSum.Width = 125;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Статус оплаты";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 125;
            // 
            // Intruder
            // 
            this.Intruder.DataPropertyName = "Intruder";
            this.Intruder.HeaderText = "ФИО нарушителя";
            this.Intruder.MinimumWidth = 6;
            this.Intruder.Name = "Intruder";
            this.Intruder.ReadOnly = true;
            this.Intruder.Width = 125;
            // 
            // fineSumDataGridViewTextBoxColumn
            // 
            this.fineSumDataGridViewTextBoxColumn.DataPropertyName = "FineSum";
            this.fineSumDataGridViewTextBoxColumn.HeaderText = "";
            this.fineSumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fineSumDataGridViewTextBoxColumn.Name = "fineSumDataGridViewTextBoxColumn";
            this.fineSumDataGridViewTextBoxColumn.ReadOnly = true;
            this.fineSumDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Status";
            this.statusDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.ReadOnly = true;
            this.statusDataGridViewCheckBoxColumn.Width = 125;
            // 
            // intruderDataGridViewTextBoxColumn
            // 
            this.intruderDataGridViewTextBoxColumn.DataPropertyName = "Intruder";
            this.intruderDataGridViewTextBoxColumn.HeaderText = "Intruder";
            this.intruderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.intruderDataGridViewTextBoxColumn.Name = "intruderDataGridViewTextBoxColumn";
            this.intruderDataGridViewTextBoxColumn.ReadOnly = true;
            this.intruderDataGridViewTextBoxColumn.Width = 125;
            // 
            // fineBindingSource
            // 
            this.fineBindingSource.DataSource = typeof(Fine_Class.Fine);
            // 
            // buttonIssueFine
            // 
            this.buttonIssueFine.Location = new System.Drawing.Point(420, 188);
            this.buttonIssueFine.Name = "buttonIssueFine";
            this.buttonIssueFine.Size = new System.Drawing.Size(94, 52);
            this.buttonIssueFine.TabIndex = 17;
            this.buttonIssueFine.Text = "Выписать штраф";
            this.buttonIssueFine.UseVisualStyleBackColor = true;
            this.buttonIssueFine.Click += new System.EventHandler(this.buttonIssueFine_Click);
            // 
            // buttonPayFine
            // 
            this.buttonPayFine.Location = new System.Drawing.Point(750, 327);
            this.buttonPayFine.Name = "buttonPayFine";
            this.buttonPayFine.Size = new System.Drawing.Size(552, 85);
            this.buttonPayFine.TabIndex = 18;
            this.buttonPayFine.Text = "Оплатить штраф";
            this.buttonPayFine.UseVisualStyleBackColor = true;
            this.buttonPayFine.Click += new System.EventHandler(this.buttonPayFine_Click);
            // 
            // buttonSell
            // 
            this.buttonSell.Location = new System.Drawing.Point(420, 248);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(94, 52);
            this.buttonSell.TabIndex = 19;
            this.buttonSell.Text = "Продать авто";
            this.buttonSell.UseVisualStyleBackColor = true;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // textBoxFineSum
            // 
            this.textBoxFineSum.Location = new System.Drawing.Point(520, 208);
            this.textBoxFineSum.Name = "textBoxFineSum";
            this.textBoxFineSum.Size = new System.Drawing.Size(217, 22);
            this.textBoxFineSum.TabIndex = 21;
            // 
            // buttonReg
            // 
            this.buttonReg.Location = new System.Drawing.Point(76, 274);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(238, 55);
            this.buttonReg.TabIndex = 23;
            this.buttonReg.Text = "Зарегистрировать автомобиль";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // labelNewOwner
            // 
            this.labelNewOwner.AutoSize = true;
            this.labelNewOwner.Location = new System.Drawing.Point(517, 248);
            this.labelNewOwner.Name = "labelNewOwner";
            this.labelNewOwner.Size = new System.Drawing.Size(220, 16);
            this.labelNewOwner.TabIndex = 24;
            this.labelNewOwner.Text = "Введите ФИО нового владельца";
            // 
            // textBoxNewOwner
            // 
            this.textBoxNewOwner.Location = new System.Drawing.Point(520, 267);
            this.textBoxNewOwner.Name = "textBoxNewOwner";
            this.textBoxNewOwner.Size = new System.Drawing.Size(217, 22);
            this.textBoxNewOwner.TabIndex = 25;
            // 
            // buttonDiagnostic
            // 
            this.buttonDiagnostic.Location = new System.Drawing.Point(420, 306);
            this.buttonDiagnostic.Name = "buttonDiagnostic";
            this.buttonDiagnostic.Size = new System.Drawing.Size(317, 106);
            this.buttonDiagnostic.TabIndex = 26;
            this.buttonDiagnostic.Text = "Пройти техосмотр";
            this.buttonDiagnostic.UseVisualStyleBackColor = true;
            this.buttonDiagnostic.Click += new System.EventHandler(this.buttonDiagnostic_Click);
            // 
            // labelFineSum
            // 
            this.labelFineSum.AutoSize = true;
            this.labelFineSum.Location = new System.Drawing.Point(517, 188);
            this.labelFineSum.Name = "labelFineSum";
            this.labelFineSum.Size = new System.Drawing.Size(161, 16);
            this.labelFineSum.TabIndex = 29;
            this.labelFineSum.Text = "Введите сумму штрафа";
            // 
            // Lab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1308, 422);
            this.Controls.Add(this.labelFineSum);
            this.Controls.Add(this.buttonDiagnostic);
            this.Controls.Add(this.textBoxNewOwner);
            this.Controls.Add(this.labelNewOwner);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.textBoxFineSum);
            this.Controls.Add(this.buttonSell);
            this.Controls.Add(this.buttonPayFine);
            this.Controls.Add(this.buttonIssueFine);
            this.Controls.Add(this.dataGridViewFines);
            this.Controls.Add(this.dataGridViewCars);
            this.Controls.Add(this.textBoxOwner);
            this.Controls.Add(this.owner);
            this.Controls.Add(this.diagnosticYear);
            this.Controls.Add(this.releaseYear);
            this.Controls.Add(this.model);
            this.Controls.Add(this.brand);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxReleaseYear);
            this.Controls.Add(this.textBoxDiagnosticYear);
            this.Controls.Add(this.textBoxBrand);
            this.Controls.Add(this.addData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Lab1";
            this.Text = "Автомобильный менеджер";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fineBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addData;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.TextBox textBoxDiagnosticYear;
        private System.Windows.Forms.TextBox textBoxReleaseYear;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label brand;
        private System.Windows.Forms.Label model;
        private System.Windows.Forms.Label releaseYear;
        private System.Windows.Forms.Label diagnosticYear;
        private System.Windows.Forms.Label owner;
        private System.Windows.Forms.TextBox textBoxOwner;
        private System.Windows.Forms.DataGridView dataGridViewCars;
        private System.Windows.Forms.DataGridView dataGridViewFines;
        private System.Windows.Forms.Button buttonIssueFine;
        private System.Windows.Forms.Button buttonPayFine;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.TextBox textBoxFineSum;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.Label labelNewOwner;
        private System.Windows.Forms.TextBox textBoxNewOwner;
        private System.Windows.Forms.BindingSource automobileBindingSource;
        private System.Windows.Forms.BindingSource fineBindingSource;
        private System.Windows.Forms.Button buttonDiagnostic;
        private System.Windows.Forms.Label labelFineSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn FineSum;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Intruder;
        private System.Windows.Forms.DataGridViewTextBoxColumn fineSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intruderDataGridViewTextBoxColumn;
    }
}

