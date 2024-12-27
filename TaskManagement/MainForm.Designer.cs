using TaskManagement;

namespace TaskManagementApp
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserRole = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.txtProjectDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.txtProjectId = new System.Windows.Forms.TextBox();
            this.txtTaskDescription = new System.Windows.Forms.TextBox();
            this.txtAssigneeId = new System.Windows.Forms.TextBox();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.taskManagementDBDataSet = new TaskManagement.DBDataSet();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnUpdateTask = new System.Windows.Forms.Button();
            this.btnSearchTask = new System.Windows.Forms.Button();
            this.txtSearchTerm = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dataGridViewTasks = new System.Windows.Forms.DataGridView();
            this.taskIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assigneeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskManagementDBDataSet1 = new TaskManagement.TaskManagementDBDataSet1();
            this.taskManagementDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tasksTableAdapter = new TaskManagement.TaskManagementDBDataSet1TableAdapters.TasksTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.taskManagementDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskManagementDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskManagementDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("STKaiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавить пользователя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("STKaiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя пользователя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("STKaiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Роль пользователя";
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddUser.Font = new System.Drawing.Font("STKaiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddUser.Location = new System.Drawing.Point(346, 50);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(160, 66);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "Добавить пользователя";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(191, 50);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(134, 22);
            this.txtUserName.TabIndex = 4;
            // 
            // txtUserRole
            // 
            this.txtUserRole.Location = new System.Drawing.Point(191, 95);
            this.txtUserRole.Name = "txtUserRole";
            this.txtUserRole.Size = new System.Drawing.Size(134, 22);
            this.txtUserRole.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("STKaiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(635, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Добавить проект";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("STKaiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(595, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Название проекта";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("STKaiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(595, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Описание";
            // 
            // btnAddProject
            // 
            this.btnAddProject.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddProject.Font = new System.Drawing.Font("STKaiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddProject.Location = new System.Drawing.Point(948, 49);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(160, 66);
            this.btnAddProject.TabIndex = 9;
            this.btnAddProject.Text = "Добавить проект";
            this.btnAddProject.UseVisualStyleBackColor = false;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(771, 49);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(134, 22);
            this.txtProjectName.TabIndex = 10;
            // 
            // txtProjectDescription
            // 
            this.txtProjectDescription.Location = new System.Drawing.Point(771, 97);
            this.txtProjectDescription.Name = "txtProjectDescription";
            this.txtProjectDescription.Size = new System.Drawing.Size(134, 22);
            this.txtProjectDescription.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("STKaiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(-7, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1428, 31);
            this.label7.TabIndex = 12;
            this.label7.Text = "_________________________________________________________________________________" +
    "____________________";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("STKaiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(8, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 22);
            this.label9.TabIndex = 14;
            this.label9.Text = "Название задачи";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("STKaiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(8, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 22);
            this.label10.TabIndex = 15;
            this.label10.Text = "ID проекта";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("STKaiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(8, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 22);
            this.label11.TabIndex = 16;
            this.label11.Text = "Описание задачи";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("STKaiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(8, 321);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 22);
            this.label12.TabIndex = 17;
            this.label12.Text = "Приоритет";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("STKaiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(10, 347);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 22);
            this.label13.TabIndex = 18;
            this.label13.Text = "ID исполнителя";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("STKaiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(8, 383);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 22);
            this.label14.TabIndex = 19;
            this.label14.Text = "Статус задачи";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(189, 223);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(217, 22);
            this.txtTaskName.TabIndex = 20;
            // 
            // txtProjectId
            // 
            this.txtProjectId.Location = new System.Drawing.Point(189, 257);
            this.txtProjectId.Name = "txtProjectId";
            this.txtProjectId.Size = new System.Drawing.Size(217, 22);
            this.txtProjectId.TabIndex = 21;
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.Location = new System.Drawing.Point(189, 286);
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(217, 22);
            this.txtTaskDescription.TabIndex = 22;
            // 
            // txtAssigneeId
            // 
            this.txtAssigneeId.Location = new System.Drawing.Point(189, 352);
            this.txtAssigneeId.Name = "txtAssigneeId";
            this.txtAssigneeId.Size = new System.Drawing.Size(217, 22);
            this.txtAssigneeId.TabIndex = 23;
            // 
            // cmbPriority
            // 
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Location = new System.Drawing.Point(189, 322);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(217, 24);
            this.cmbPriority.TabIndex = 24;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(189, 384);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(217, 24);
            this.cmbStatus.TabIndex = 25;
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddTask.Font = new System.Drawing.Font("STKaiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddTask.Location = new System.Drawing.Point(428, 194);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(153, 41);
            this.btnAddTask.TabIndex = 28;
            this.btnAddTask.Text = "Добавить задачу";
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // taskManagementDBDataSet
            // 
            this.taskManagementDBDataSet.DataSetName = "NewDataSet";
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDeleteTask.Font = new System.Drawing.Font("STKaiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteTask.Location = new System.Drawing.Point(428, 238);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(153, 41);
            this.btnDeleteTask.TabIndex = 31;
            this.btnDeleteTask.Text = "Удалить задачу";
            this.btnDeleteTask.UseVisualStyleBackColor = false;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnUpdateTask
            // 
            this.btnUpdateTask.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnUpdateTask.Font = new System.Drawing.Font("STKaiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdateTask.Location = new System.Drawing.Point(428, 285);
            this.btnUpdateTask.Name = "btnUpdateTask";
            this.btnUpdateTask.Size = new System.Drawing.Size(153, 38);
            this.btnUpdateTask.TabIndex = 32;
            this.btnUpdateTask.Text = "Изменить";
            this.btnUpdateTask.UseVisualStyleBackColor = false;
            this.btnUpdateTask.Click += new System.EventHandler(this.btnUpdateTask_Click);
            // 
            // btnSearchTask
            // 
            this.btnSearchTask.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSearchTask.Font = new System.Drawing.Font("STKaiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchTask.Location = new System.Drawing.Point(428, 333);
            this.btnSearchTask.Name = "btnSearchTask";
            this.btnSearchTask.Size = new System.Drawing.Size(153, 36);
            this.btnSearchTask.TabIndex = 33;
            this.btnSearchTask.Text = "Найти задачу";
            this.btnSearchTask.UseVisualStyleBackColor = false;
            this.btnSearchTask.Click += new System.EventHandler(this.btnSearchTask_Click);
            // 
            // txtSearchTerm
            // 
            this.txtSearchTerm.Location = new System.Drawing.Point(189, 194);
            this.txtSearchTerm.Name = "txtSearchTerm";
            this.txtSearchTerm.Size = new System.Drawing.Size(217, 22);
            this.txtSearchTerm.TabIndex = 34;
            this.txtSearchTerm.TextChanged += new System.EventHandler(this.txtSearchTerm_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("STKaiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(10, 194);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(122, 22);
            this.label17.TabIndex = 35;
            this.label17.Text = "Поиск задачи";
            // 
            // dataGridViewTasks
            // 
            this.dataGridViewTasks.AutoGenerateColumns = false;
            this.dataGridViewTasks.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridViewTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taskIDDataGridViewTextBoxColumn1,
            this.taskNumberDataGridViewTextBoxColumn,
            this.createdAtDataGridViewTextBoxColumn,
            this.projectIDDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priorityDataGridViewTextBoxColumn,
            this.assigneeIDDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridViewTasks.DataSource = this.tasksBindingSource;
            this.dataGridViewTasks.Location = new System.Drawing.Point(-1, 430);
            this.dataGridViewTasks.Name = "dataGridViewTasks";
            this.dataGridViewTasks.RowHeadersWidth = 51;
            this.dataGridViewTasks.RowTemplate.Height = 24;
            this.dataGridViewTasks.Size = new System.Drawing.Size(1071, 162);
            this.dataGridViewTasks.TabIndex = 36;
            // 
            // taskIDDataGridViewTextBoxColumn1
            // 
            this.taskIDDataGridViewTextBoxColumn1.DataPropertyName = "TaskID";
            this.taskIDDataGridViewTextBoxColumn1.HeaderText = "TaskID";
            this.taskIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.taskIDDataGridViewTextBoxColumn1.Name = "taskIDDataGridViewTextBoxColumn1";
            this.taskIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.taskIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // taskNumberDataGridViewTextBoxColumn
            // 
            this.taskNumberDataGridViewTextBoxColumn.DataPropertyName = "TaskNumber";
            this.taskNumberDataGridViewTextBoxColumn.HeaderText = "TaskNumber";
            this.taskNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.taskNumberDataGridViewTextBoxColumn.Name = "taskNumberDataGridViewTextBoxColumn";
            this.taskNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            this.createdAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.HeaderText = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            this.createdAtDataGridViewTextBoxColumn.Width = 125;
            // 
            // projectIDDataGridViewTextBoxColumn
            // 
            this.projectIDDataGridViewTextBoxColumn.DataPropertyName = "ProjectID";
            this.projectIDDataGridViewTextBoxColumn.HeaderText = "ProjectID";
            this.projectIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.projectIDDataGridViewTextBoxColumn.Name = "projectIDDataGridViewTextBoxColumn";
            this.projectIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // priorityDataGridViewTextBoxColumn
            // 
            this.priorityDataGridViewTextBoxColumn.DataPropertyName = "Priority";
            this.priorityDataGridViewTextBoxColumn.HeaderText = "Priority";
            this.priorityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priorityDataGridViewTextBoxColumn.Name = "priorityDataGridViewTextBoxColumn";
            this.priorityDataGridViewTextBoxColumn.Width = 125;
            // 
            // assigneeIDDataGridViewTextBoxColumn
            // 
            this.assigneeIDDataGridViewTextBoxColumn.DataPropertyName = "AssigneeID";
            this.assigneeIDDataGridViewTextBoxColumn.HeaderText = "AssigneeID";
            this.assigneeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.assigneeIDDataGridViewTextBoxColumn.Name = "assigneeIDDataGridViewTextBoxColumn";
            this.assigneeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // tasksBindingSource
            // 
            this.tasksBindingSource.DataMember = "Tasks";
            this.tasksBindingSource.DataSource = this.taskManagementDBDataSet1;
            // 
            // taskManagementDBDataSet1
            // 
            this.taskManagementDBDataSet1.DataSetName = "TaskManagementDBDataSet1";
            this.taskManagementDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taskManagementDBDataSetBindingSource
            // 
            this.taskManagementDBDataSetBindingSource.DataSource = this.taskManagementDBDataSet;
            this.taskManagementDBDataSetBindingSource.Position = 0;
            // 
            // tasksTableAdapter
            // 
            this.tasksTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("STKaiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 31);
            this.label8.TabIndex = 37;
            this.label8.Text = "Задачи";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1125, 606);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridViewTasks);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtSearchTerm);
            this.Controls.Add(this.btnSearchTask);
            this.Controls.Add(this.btnUpdateTask);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.txtAssigneeId);
            this.Controls.Add(this.txtTaskDescription);
            this.Controls.Add(this.txtProjectId);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtProjectDescription);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.btnAddProject);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUserRole);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taskManagementDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskManagementDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskManagementDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserRole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.TextBox txtProjectDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.TextBox txtProjectId;
        private System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.TextBox txtAssigneeId;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnAddTask;
        private DBDataSet taskManagementDBDataSet;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnUpdateTask;
        private System.Windows.Forms.Button btnSearchTask;
        private System.Windows.Forms.TextBox txtSearchTerm;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dataGridViewTasks;
        private System.Windows.Forms.BindingSource taskManagementDBDataSetBindingSource;
        private TaskManagementDBDataSet1 taskManagementDBDataSet1;
        private System.Windows.Forms.BindingSource tasksBindingSource;
        private TaskManagement.TaskManagementDBDataSet1TableAdapters.TasksTableAdapter tasksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assigneeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
    }
}