namespace TestTask_Kosta
{
    partial class FormStructEnterprises
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dB_Kosta = new TestTask_Kosta.DB_Kosta();
            this.treeStructEnterprises = new System.Windows.Forms.TreeView();
            this.lbl_structEnterpises = new System.Windows.Forms.Label();
            this.dataGrid_workers = new System.Windows.Forms.DataGridView();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_InfoEmpoyee = new System.Windows.Forms.Label();
            this.lbl_FirstNameEmpoyee = new System.Windows.Forms.Label();
            this.lbl_SurNameEmpoyee = new System.Windows.Forms.Label();
            this.lbl_PatronymicEmpoyee = new System.Windows.Forms.Label();
            this.lbl_DateOfBirthEmpoyee = new System.Windows.Forms.Label();
            this.lbl_DocEmpoyee = new System.Windows.Forms.Label();
            this.lbl_Position = new System.Windows.Forms.Label();
            this.lbl_CodeDepartment = new System.Windows.Forms.Label();
            this.lbl_FirstNameEmpoyeeValue = new System.Windows.Forms.Label();
            this.lbl_SurNameEmpoyeeValue = new System.Windows.Forms.Label();
            this.lbl_PatronymicEmpoyeeValue = new System.Windows.Forms.Label();
            this.lbl_DateOfBirthEmpoyeeValue = new System.Windows.Forms.Label();
            this.lbl_DocEmpoyeeValue = new System.Windows.Forms.Label();
            this.lbl_PositionValue = new System.Windows.Forms.Label();
            this.lbl_CodeDepartmentValue = new System.Windows.Forms.Label();
            this.lbl_ListEmpoyee = new System.Windows.Forms.Label();
            this.pnl_DataInfoEmpoyee = new System.Windows.Forms.Panel();
            this.btn_EditEmployee = new System.Windows.Forms.Button();
            this.btn_DeleteEmpolye = new System.Windows.Forms.Button();
            this.btn_ShowPanelEmpoyee = new System.Windows.Forms.Button();
            this.lbl_titleForm = new System.Windows.Forms.Label();
            this.btn_AddEmployee = new System.Windows.Forms.Button();
            this.cbx_ShowMessage = new System.Windows.Forms.CheckBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Kosta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_workers)).BeginInit();
            this.pnl_DataInfoEmpoyee.SuspendLayout();
            this.SuspendLayout();
            // 
            // dB_Kosta
            // 
            this.dB_Kosta.DataSetName = "DB_Kosta";
            this.dB_Kosta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // treeStructEnterprises
            // 
            this.treeStructEnterprises.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeStructEnterprises.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.treeStructEnterprises.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeStructEnterprises.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.treeStructEnterprises.Location = new System.Drawing.Point(12, 120);
            this.treeStructEnterprises.Name = "treeStructEnterprises";
            this.treeStructEnterprises.Size = new System.Drawing.Size(290, 375);
            this.treeStructEnterprises.TabIndex = 1;
            this.treeStructEnterprises.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeStructEnterprises_AfterSelect);
            // 
            // lbl_structEnterpises
            // 
            this.lbl_structEnterpises.AutoSize = true;
            this.lbl_structEnterpises.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_structEnterpises.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_structEnterpises.Location = new System.Drawing.Point(15, 85);
            this.lbl_structEnterpises.Name = "lbl_structEnterpises";
            this.lbl_structEnterpises.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lbl_structEnterpises.Size = new System.Drawing.Size(84, 35);
            this.lbl_structEnterpises.TabIndex = 3;
            this.lbl_structEnterpises.Text = "ОТДЕЛЫ:";
            // 
            // dataGrid_workers
            // 
            this.dataGrid_workers.AllowUserToAddRows = false;
            this.dataGrid_workers.AllowUserToDeleteRows = false;
            this.dataGrid_workers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGrid_workers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_workers.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_workers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_workers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_workers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Position,
            this.ID,
            this.FullName});
            this.dataGrid_workers.Location = new System.Drawing.Point(360, 120);
            this.dataGrid_workers.Name = "dataGrid_workers";
            this.dataGrid_workers.ReadOnly = true;
            this.dataGrid_workers.RowHeadersVisible = false;
            this.dataGrid_workers.Size = new System.Drawing.Size(390, 329);
            this.dataGrid_workers.TabIndex = 2;
            this.dataGrid_workers.Click += new System.EventHandler(this.dataGrid_workers_Click);
            // 
            // Position
            // 
            this.Position.HeaderText = "Должность";
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "ФИО";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // lbl_InfoEmpoyee
            // 
            this.lbl_InfoEmpoyee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_InfoEmpoyee.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_InfoEmpoyee.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_InfoEmpoyee.Location = new System.Drawing.Point(3, 2);
            this.lbl_InfoEmpoyee.Name = "lbl_InfoEmpoyee";
            this.lbl_InfoEmpoyee.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lbl_InfoEmpoyee.Size = new System.Drawing.Size(334, 45);
            this.lbl_InfoEmpoyee.TabIndex = 5;
            this.lbl_InfoEmpoyee.Text = "ИНФОРМАЦИЯ О СОТРУДНИКЕ:";
            this.lbl_InfoEmpoyee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_FirstNameEmpoyee
            // 
            this.lbl_FirstNameEmpoyee.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_FirstNameEmpoyee.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_FirstNameEmpoyee.Location = new System.Drawing.Point(19, 61);
            this.lbl_FirstNameEmpoyee.Name = "lbl_FirstNameEmpoyee";
            this.lbl_FirstNameEmpoyee.Size = new System.Drawing.Size(126, 20);
            this.lbl_FirstNameEmpoyee.TabIndex = 5;
            this.lbl_FirstNameEmpoyee.Text = "Имя:";
            this.lbl_FirstNameEmpoyee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_SurNameEmpoyee
            // 
            this.lbl_SurNameEmpoyee.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_SurNameEmpoyee.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_SurNameEmpoyee.Location = new System.Drawing.Point(19, 117);
            this.lbl_SurNameEmpoyee.Name = "lbl_SurNameEmpoyee";
            this.lbl_SurNameEmpoyee.Size = new System.Drawing.Size(126, 20);
            this.lbl_SurNameEmpoyee.TabIndex = 5;
            this.lbl_SurNameEmpoyee.Text = "Фамилия:";
            this.lbl_SurNameEmpoyee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_PatronymicEmpoyee
            // 
            this.lbl_PatronymicEmpoyee.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_PatronymicEmpoyee.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_PatronymicEmpoyee.Location = new System.Drawing.Point(19, 86);
            this.lbl_PatronymicEmpoyee.Name = "lbl_PatronymicEmpoyee";
            this.lbl_PatronymicEmpoyee.Size = new System.Drawing.Size(126, 20);
            this.lbl_PatronymicEmpoyee.TabIndex = 5;
            this.lbl_PatronymicEmpoyee.Text = "Отчество:";
            this.lbl_PatronymicEmpoyee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_DateOfBirthEmpoyee
            // 
            this.lbl_DateOfBirthEmpoyee.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_DateOfBirthEmpoyee.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_DateOfBirthEmpoyee.Location = new System.Drawing.Point(19, 146);
            this.lbl_DateOfBirthEmpoyee.Name = "lbl_DateOfBirthEmpoyee";
            this.lbl_DateOfBirthEmpoyee.Size = new System.Drawing.Size(126, 20);
            this.lbl_DateOfBirthEmpoyee.TabIndex = 5;
            this.lbl_DateOfBirthEmpoyee.Text = "Дата рождения:";
            this.lbl_DateOfBirthEmpoyee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_DocEmpoyee
            // 
            this.lbl_DocEmpoyee.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_DocEmpoyee.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_DocEmpoyee.Location = new System.Drawing.Point(19, 177);
            this.lbl_DocEmpoyee.Name = "lbl_DocEmpoyee";
            this.lbl_DocEmpoyee.Size = new System.Drawing.Size(126, 20);
            this.lbl_DocEmpoyee.TabIndex = 5;
            this.lbl_DocEmpoyee.Text = "Серия и номер:";
            this.lbl_DocEmpoyee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Position
            // 
            this.lbl_Position.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Position.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Position.Location = new System.Drawing.Point(19, 206);
            this.lbl_Position.Name = "lbl_Position";
            this.lbl_Position.Size = new System.Drawing.Size(126, 20);
            this.lbl_Position.TabIndex = 5;
            this.lbl_Position.Text = "Должность:";
            this.lbl_Position.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_CodeDepartment
            // 
            this.lbl_CodeDepartment.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_CodeDepartment.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_CodeDepartment.Location = new System.Drawing.Point(19, 249);
            this.lbl_CodeDepartment.Name = "lbl_CodeDepartment";
            this.lbl_CodeDepartment.Size = new System.Drawing.Size(126, 20);
            this.lbl_CodeDepartment.TabIndex = 5;
            this.lbl_CodeDepartment.Text = "Код отдела:";
            this.lbl_CodeDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_FirstNameEmpoyeeValue
            // 
            this.lbl_FirstNameEmpoyeeValue.AutoSize = true;
            this.lbl_FirstNameEmpoyeeValue.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_FirstNameEmpoyeeValue.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_FirstNameEmpoyeeValue.Location = new System.Drawing.Point(158, 64);
            this.lbl_FirstNameEmpoyeeValue.Name = "lbl_FirstNameEmpoyeeValue";
            this.lbl_FirstNameEmpoyeeValue.Size = new System.Drawing.Size(43, 17);
            this.lbl_FirstNameEmpoyeeValue.TabIndex = 5;
            this.lbl_FirstNameEmpoyeeValue.Text = "текст";
            // 
            // lbl_SurNameEmpoyeeValue
            // 
            this.lbl_SurNameEmpoyeeValue.AutoSize = true;
            this.lbl_SurNameEmpoyeeValue.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_SurNameEmpoyeeValue.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_SurNameEmpoyeeValue.Location = new System.Drawing.Point(158, 120);
            this.lbl_SurNameEmpoyeeValue.Name = "lbl_SurNameEmpoyeeValue";
            this.lbl_SurNameEmpoyeeValue.Size = new System.Drawing.Size(43, 17);
            this.lbl_SurNameEmpoyeeValue.TabIndex = 5;
            this.lbl_SurNameEmpoyeeValue.Text = "текст";
            // 
            // lbl_PatronymicEmpoyeeValue
            // 
            this.lbl_PatronymicEmpoyeeValue.AutoSize = true;
            this.lbl_PatronymicEmpoyeeValue.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_PatronymicEmpoyeeValue.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_PatronymicEmpoyeeValue.Location = new System.Drawing.Point(158, 89);
            this.lbl_PatronymicEmpoyeeValue.Name = "lbl_PatronymicEmpoyeeValue";
            this.lbl_PatronymicEmpoyeeValue.Size = new System.Drawing.Size(43, 17);
            this.lbl_PatronymicEmpoyeeValue.TabIndex = 5;
            this.lbl_PatronymicEmpoyeeValue.Text = "текст";
            // 
            // lbl_DateOfBirthEmpoyeeValue
            // 
            this.lbl_DateOfBirthEmpoyeeValue.AutoSize = true;
            this.lbl_DateOfBirthEmpoyeeValue.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_DateOfBirthEmpoyeeValue.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_DateOfBirthEmpoyeeValue.Location = new System.Drawing.Point(158, 149);
            this.lbl_DateOfBirthEmpoyeeValue.Name = "lbl_DateOfBirthEmpoyeeValue";
            this.lbl_DateOfBirthEmpoyeeValue.Size = new System.Drawing.Size(43, 17);
            this.lbl_DateOfBirthEmpoyeeValue.TabIndex = 5;
            this.lbl_DateOfBirthEmpoyeeValue.Text = "текст";
            // 
            // lbl_DocEmpoyeeValue
            // 
            this.lbl_DocEmpoyeeValue.AutoSize = true;
            this.lbl_DocEmpoyeeValue.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_DocEmpoyeeValue.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_DocEmpoyeeValue.Location = new System.Drawing.Point(158, 180);
            this.lbl_DocEmpoyeeValue.Name = "lbl_DocEmpoyeeValue";
            this.lbl_DocEmpoyeeValue.Size = new System.Drawing.Size(43, 17);
            this.lbl_DocEmpoyeeValue.TabIndex = 5;
            this.lbl_DocEmpoyeeValue.Text = "текст";
            // 
            // lbl_PositionValue
            // 
            this.lbl_PositionValue.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_PositionValue.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_PositionValue.Location = new System.Drawing.Point(33, 228);
            this.lbl_PositionValue.Name = "lbl_PositionValue";
            this.lbl_PositionValue.Size = new System.Drawing.Size(284, 32);
            this.lbl_PositionValue.TabIndex = 5;
            this.lbl_PositionValue.Text = "текст";
            // 
            // lbl_CodeDepartmentValue
            // 
            this.lbl_CodeDepartmentValue.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_CodeDepartmentValue.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_CodeDepartmentValue.Location = new System.Drawing.Point(33, 273);
            this.lbl_CodeDepartmentValue.Name = "lbl_CodeDepartmentValue";
            this.lbl_CodeDepartmentValue.Size = new System.Drawing.Size(284, 38);
            this.lbl_CodeDepartmentValue.TabIndex = 5;
            this.lbl_CodeDepartmentValue.Text = "текст";
            // 
            // lbl_ListEmpoyee
            // 
            this.lbl_ListEmpoyee.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ListEmpoyee.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_ListEmpoyee.Location = new System.Drawing.Point(362, 84);
            this.lbl_ListEmpoyee.Name = "lbl_ListEmpoyee";
            this.lbl_ListEmpoyee.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lbl_ListEmpoyee.Size = new System.Drawing.Size(390, 41);
            this.lbl_ListEmpoyee.TabIndex = 3;
            this.lbl_ListEmpoyee.Text = "СПИСОК СОТРУДНИКОВ ОТДЕЛА:";
            this.lbl_ListEmpoyee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_DataInfoEmpoyee
            // 
            this.pnl_DataInfoEmpoyee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnl_DataInfoEmpoyee.Controls.Add(this.lbl_InfoEmpoyee);
            this.pnl_DataInfoEmpoyee.Controls.Add(this.lbl_CodeDepartmentValue);
            this.pnl_DataInfoEmpoyee.Controls.Add(this.btn_EditEmployee);
            this.pnl_DataInfoEmpoyee.Controls.Add(this.btn_DeleteEmpolye);
            this.pnl_DataInfoEmpoyee.Controls.Add(this.lbl_FirstNameEmpoyee);
            this.pnl_DataInfoEmpoyee.Controls.Add(this.lbl_CodeDepartment);
            this.pnl_DataInfoEmpoyee.Controls.Add(this.lbl_FirstNameEmpoyeeValue);
            this.pnl_DataInfoEmpoyee.Controls.Add(this.lbl_PositionValue);
            this.pnl_DataInfoEmpoyee.Controls.Add(this.lbl_SurNameEmpoyee);
            this.pnl_DataInfoEmpoyee.Controls.Add(this.lbl_Position);
            this.pnl_DataInfoEmpoyee.Controls.Add(this.lbl_SurNameEmpoyeeValue);
            this.pnl_DataInfoEmpoyee.Controls.Add(this.lbl_DocEmpoyeeValue);
            this.pnl_DataInfoEmpoyee.Controls.Add(this.lbl_PatronymicEmpoyee);
            this.pnl_DataInfoEmpoyee.Controls.Add(this.lbl_DocEmpoyee);
            this.pnl_DataInfoEmpoyee.Controls.Add(this.lbl_PatronymicEmpoyeeValue);
            this.pnl_DataInfoEmpoyee.Controls.Add(this.lbl_DateOfBirthEmpoyeeValue);
            this.pnl_DataInfoEmpoyee.Controls.Add(this.lbl_DateOfBirthEmpoyee);
            this.pnl_DataInfoEmpoyee.Location = new System.Drawing.Point(780, 120);
            this.pnl_DataInfoEmpoyee.Name = "pnl_DataInfoEmpoyee";
            this.pnl_DataInfoEmpoyee.Size = new System.Drawing.Size(340, 383);
            this.pnl_DataInfoEmpoyee.TabIndex = 6;
            this.pnl_DataInfoEmpoyee.Visible = false;
            // 
            // btn_EditEmployee
            // 
            this.btn_EditEmployee.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_EditEmployee.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_EditEmployee.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_EditEmployee.Location = new System.Drawing.Point(174, 328);
            this.btn_EditEmployee.Name = "btn_EditEmployee";
            this.btn_EditEmployee.Size = new System.Drawing.Size(143, 47);
            this.btn_EditEmployee.TabIndex = 6;
            this.btn_EditEmployee.Text = "Редактировать данные";
            this.btn_EditEmployee.UseVisualStyleBackColor = false;
            this.btn_EditEmployee.Click += new System.EventHandler(this.btn_EditEmployee_Click);
            // 
            // btn_DeleteEmpolye
            // 
            this.btn_DeleteEmpolye.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_DeleteEmpolye.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_DeleteEmpolye.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_DeleteEmpolye.Location = new System.Drawing.Point(22, 328);
            this.btn_DeleteEmpolye.Name = "btn_DeleteEmpolye";
            this.btn_DeleteEmpolye.Size = new System.Drawing.Size(136, 47);
            this.btn_DeleteEmpolye.TabIndex = 5;
            this.btn_DeleteEmpolye.Text = "Удалить сотрудника";
            this.btn_DeleteEmpolye.UseVisualStyleBackColor = false;
            this.btn_DeleteEmpolye.Click += new System.EventHandler(this.btn_DeleteEmpolye_Click);
            // 
            // btn_ShowPanelEmpoyee
            // 
            this.btn_ShowPanelEmpoyee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ShowPanelEmpoyee.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ShowPanelEmpoyee.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ShowPanelEmpoyee.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_ShowPanelEmpoyee.Location = new System.Drawing.Point(537, 455);
            this.btn_ShowPanelEmpoyee.Name = "btn_ShowPanelEmpoyee";
            this.btn_ShowPanelEmpoyee.Size = new System.Drawing.Size(213, 47);
            this.btn_ShowPanelEmpoyee.TabIndex = 4;
            this.btn_ShowPanelEmpoyee.Text = "Показать подробные данные\r\nо выбранном сотруднике >>";
            this.btn_ShowPanelEmpoyee.UseVisualStyleBackColor = false;
            this.btn_ShowPanelEmpoyee.Click += new System.EventHandler(this.btn_ShowPanelEmpoyee_Click);
            // 
            // lbl_titleForm
            // 
            this.lbl_titleForm.AutoSize = true;
            this.lbl_titleForm.Font = new System.Drawing.Font("Gabriola", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_titleForm.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_titleForm.Location = new System.Drawing.Point(12, -20);
            this.lbl_titleForm.Name = "lbl_titleForm";
            this.lbl_titleForm.Size = new System.Drawing.Size(600, 118);
            this.lbl_titleForm.TabIndex = 3;
            this.lbl_titleForm.Text = "Структура предприятия";
            // 
            // btn_AddEmployee
            // 
            this.btn_AddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_AddEmployee.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_AddEmployee.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddEmployee.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_AddEmployee.Location = new System.Drawing.Point(360, 456);
            this.btn_AddEmployee.Name = "btn_AddEmployee";
            this.btn_AddEmployee.Size = new System.Drawing.Size(163, 47);
            this.btn_AddEmployee.TabIndex = 3;
            this.btn_AddEmployee.Text = "Добавит сотрудника";
            this.btn_AddEmployee.UseVisualStyleBackColor = false;
            this.btn_AddEmployee.Click += new System.EventHandler(this.btn_AddEmployee_Click);
            // 
            // cbx_ShowMessage
            // 
            this.cbx_ShowMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_ShowMessage.AutoSize = true;
            this.cbx_ShowMessage.Checked = true;
            this.cbx_ShowMessage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_ShowMessage.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cbx_ShowMessage.Location = new System.Drawing.Point(608, 12);
            this.cbx_ShowMessage.Name = "cbx_ShowMessage";
            this.cbx_ShowMessage.Size = new System.Drawing.Size(148, 17);
            this.cbx_ShowMessage.TabIndex = 7;
            this.cbx_ShowMessage.Text = "Отображать сообщения";
            this.cbx_ShowMessage.UseVisualStyleBackColor = true;
            this.cbx_ShowMessage.CheckedChanged += new System.EventHandler(this.cbx_ShowMessage_CheckedChanged);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Exit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Exit.Location = new System.Drawing.Point(658, 30);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(95, 35);
            this.btn_Exit.TabIndex = 8;
            this.btn_Exit.Text = "Выход";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // FormStructEnterprises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(768, 521);
            this.Controls.Add(this.cbx_ShowMessage);
            this.Controls.Add(this.treeStructEnterprises);
            this.Controls.Add(this.dataGrid_workers);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_AddEmployee);
            this.Controls.Add(this.btn_ShowPanelEmpoyee);
            this.Controls.Add(this.pnl_DataInfoEmpoyee);
            this.Controls.Add(this.lbl_structEnterpises);
            this.Controls.Add(this.lbl_ListEmpoyee);
            this.Controls.Add(this.lbl_titleForm);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MinimumSize = new System.Drawing.Size(784, 560);
            this.Name = "FormStructEnterprises";
            this.Text = "Структура предприятия";
            this.Load += new System.EventHandler(this.FormStructEnterprises_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_Kosta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_workers)).EndInit();
            this.pnl_DataInfoEmpoyee.ResumeLayout(false);
            this.pnl_DataInfoEmpoyee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_Kosta dB_Kosta;
        private System.Windows.Forms.TreeView treeStructEnterprises;
        private System.Windows.Forms.Label lbl_structEnterpises;
        private System.Windows.Forms.DataGridView dataGrid_workers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.Label lbl_InfoEmpoyee;
        private System.Windows.Forms.Label lbl_FirstNameEmpoyee;
        private System.Windows.Forms.Label lbl_SurNameEmpoyee;
        private System.Windows.Forms.Label lbl_PatronymicEmpoyee;
        private System.Windows.Forms.Label lbl_DateOfBirthEmpoyee;
        private System.Windows.Forms.Label lbl_DocEmpoyee;
        private System.Windows.Forms.Label lbl_Position;
        private System.Windows.Forms.Label lbl_CodeDepartment;
        private System.Windows.Forms.Label lbl_FirstNameEmpoyeeValue;
        private System.Windows.Forms.Label lbl_SurNameEmpoyeeValue;
        private System.Windows.Forms.Label lbl_PatronymicEmpoyeeValue;
        private System.Windows.Forms.Label lbl_DateOfBirthEmpoyeeValue;
        private System.Windows.Forms.Label lbl_DocEmpoyeeValue;
        private System.Windows.Forms.Label lbl_CodeDepartmentValue;
        private System.Windows.Forms.Label lbl_ListEmpoyee;
        private System.Windows.Forms.Panel pnl_DataInfoEmpoyee;
        private System.Windows.Forms.Button btn_ShowPanelEmpoyee;
        private System.Windows.Forms.Label lbl_titleForm;
        private System.Windows.Forms.Label lbl_PositionValue;
        private System.Windows.Forms.Button btn_EditEmployee;
        private System.Windows.Forms.Button btn_DeleteEmpolye;
        private System.Windows.Forms.Button btn_AddEmployee;
        private System.Windows.Forms.CheckBox cbx_ShowMessage;
        private System.Windows.Forms.Button btn_Exit;
    }
}

