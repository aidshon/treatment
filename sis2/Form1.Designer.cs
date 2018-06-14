namespace sis2
{
    partial class Form1
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
            System.Windows.Forms.Label full_nameLabel;
            System.Windows.Forms.Label birth_dateLabel;
            System.Windows.Forms.Label policy_numberLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label social_status_idLabel;
            System.Windows.Forms.Label full_nameLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet = new sis2.hospitalDataSet();
            this.socialstatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.policy_numberTextBox = new System.Windows.Forms.TextBox();
            this.birth_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.full_nameTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.full_nameTextBox1 = new System.Windows.Forms.TextBox();
            this.fKDoctorSpecializationBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.specializationBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet4 = new sis2.hospitalDataSet4();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.fullnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specializationidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator3 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem2 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem2 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.patientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentstateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet2 = new sis2.hospitalDataSet2();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.fKTreatmentPatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.specializationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKDoctorSpecializationBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fKDoctorSpecializationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientTableAdapter = new sis2.hospitalDataSetTableAdapters.PatientTableAdapter();
            this.tableAdapterManager = new sis2.hospitalDataSetTableAdapters.TableAdapterManager();
            this.social_statusTableAdapter = new sis2.hospitalDataSetTableAdapters.Social_statusTableAdapter();
            this.specializationTableAdapter = new sis2.hospitalDataSetTableAdapters.SpecializationTableAdapter();
            this.doctorTableAdapter = new sis2.hospitalDataSetTableAdapters.DoctorTableAdapter();
            this.fKDoctorSpecializationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.treatmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treatmentTableAdapter = new sis2.hospitalDataSetTableAdapters.TreatmentTableAdapter();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet1 = new sis2.hospitalDataSet1();
            this.treatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treatTableAdapter = new sis2.hospitalDataSet1TableAdapters.TreatTableAdapter();
            this.treatBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.treatBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.treatBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.treatTableAdapter1 = new sis2.hospitalDataSet2TableAdapters.TreatTableAdapter();
            this.specializationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKDoctorSpecializationBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet3 = new sis2.hospitalDataSet3();
            this.specializationBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.specializationTableAdapter1 = new sis2.hospitalDataSet3TableAdapters.SpecializationTableAdapter();
            this.fKDoctorSpecializationBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.doctorTableAdapter1 = new sis2.hospitalDataSet3TableAdapters.DoctorTableAdapter();
            this.specializationBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.fKDoctorSpecializationBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.specializationTableAdapter2 = new sis2.hospitalDataSet4TableAdapters.SpecializationTableAdapter();
            this.doctorTableAdapter2 = new sis2.hospitalDataSet4TableAdapters.DoctorTableAdapter();
            this.tableAdapterManager1 = new sis2.hospitalDataSet4TableAdapters.TableAdapterManager();
            full_nameLabel = new System.Windows.Forms.Label();
            birth_dateLabel = new System.Windows.Forms.Label();
            policy_numberLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            social_status_idLabel = new System.Windows.Forms.Label();
            full_nameLabel1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socialstatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKDoctorSpecializationBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializationBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).BeginInit();
            this.bindingNavigator3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKTreatmentPatientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDoctorSpecializationBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDoctorSpecializationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDoctorSpecializationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDoctorSpecializationBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializationBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDoctorSpecializationBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializationBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDoctorSpecializationBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // full_nameLabel
            // 
            full_nameLabel.AutoSize = true;
            full_nameLabel.BackColor = System.Drawing.Color.Linen;
            full_nameLabel.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            full_nameLabel.Location = new System.Drawing.Point(295, 54);
            full_nameLabel.Name = "full_nameLabel";
            full_nameLabel.Size = new System.Drawing.Size(92, 21);
            full_nameLabel.TabIndex = 2;
            full_nameLabel.Text = "Full name:";
            // 
            // birth_dateLabel
            // 
            birth_dateLabel.AutoSize = true;
            birth_dateLabel.BackColor = System.Drawing.Color.Linen;
            birth_dateLabel.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            birth_dateLabel.Location = new System.Drawing.Point(295, 99);
            birth_dateLabel.Name = "birth_dateLabel";
            birth_dateLabel.Size = new System.Drawing.Size(121, 21);
            birth_dateLabel.TabIndex = 4;
            birth_dateLabel.Text = "Date of birth:";
            // 
            // policy_numberLabel
            // 
            policy_numberLabel.AutoSize = true;
            policy_numberLabel.BackColor = System.Drawing.Color.Linen;
            policy_numberLabel.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            policy_numberLabel.Location = new System.Drawing.Point(295, 222);
            policy_numberLabel.Name = "policy_numberLabel";
            policy_numberLabel.Size = new System.Drawing.Size(129, 21);
            policy_numberLabel.TabIndex = 6;
            policy_numberLabel.Text = "Policy number:";
            policy_numberLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.BackColor = System.Drawing.Color.Linen;
            addressLabel.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            addressLabel.Location = new System.Drawing.Point(295, 269);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(82, 21);
            addressLabel.TabIndex = 8;
            addressLabel.Text = "Address:";
            // 
            // social_status_idLabel
            // 
            social_status_idLabel.AutoSize = true;
            social_status_idLabel.BackColor = System.Drawing.Color.Linen;
            social_status_idLabel.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            social_status_idLabel.Location = new System.Drawing.Point(296, 320);
            social_status_idLabel.Name = "social_status_idLabel";
            social_status_idLabel.Size = new System.Drawing.Size(113, 21);
            social_status_idLabel.TabIndex = 10;
            social_status_idLabel.Text = "Social status";
            // 
            // full_nameLabel1
            // 
            full_nameLabel1.AutoSize = true;
            full_nameLabel1.BackColor = System.Drawing.Color.WhiteSmoke;
            full_nameLabel1.ForeColor = System.Drawing.Color.Maroon;
            full_nameLabel1.Location = new System.Drawing.Point(23, 217);
            full_nameLabel1.Name = "full_nameLabel1";
            full_nameLabel1.Size = new System.Drawing.Size(74, 17);
            full_nameLabel1.TabIndex = 11;
            full_nameLabel1.Text = "Full name:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(909, 545);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Lavender;
            this.tabPage1.BackgroundImage = global::sis2.Properties.Resources._1;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.age);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(social_status_idLabel);
            this.tabPage1.Controls.Add(addressLabel);
            this.tabPage1.Controls.Add(this.addressTextBox);
            this.tabPage1.Controls.Add(policy_numberLabel);
            this.tabPage1.Controls.Add(this.policy_numberTextBox);
            this.tabPage1.Controls.Add(birth_dateLabel);
            this.tabPage1.Controls.Add(this.birth_dateDateTimePicker);
            this.tabPage1.Controls.Add(full_nameLabel);
            this.tabPage1.Controls.Add(this.full_nameTextBox);
            this.tabPage1.Controls.Add(this.bindingNavigator1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(901, 515);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Patient";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.ForeColor = System.Drawing.Color.Maroon;
            this.button4.Location = new System.Drawing.Point(433, 172);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 22);
            this.button4.TabIndex = 20;
            this.button4.Text = "Calculate";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(297, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 80);
            this.label2.TabIndex = 17;
            this.label2.Text = "10 - Studying\r\n20 - Employed\r\n30 - Temporarily unemployed\r\n40 - Disabled\r\n50 - Pe" +
    "nsioner";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Linen;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.label1.Location = new System.Drawing.Point(294, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Age:";
            // 
            // age
            // 
            this.age.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.age.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.ForeColor = System.Drawing.Color.MidnightBlue;
            this.age.Location = new System.Drawing.Point(433, 144);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(141, 22);
            this.age.TabIndex = 15;
            this.age.TextChanged += new System.EventHandler(this.age_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "social_status_id", true));
            this.comboBox1.DataSource = this.socialstatusBindingSource;
            this.comboBox1.DisplayMember = "social_status_id";
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(434, 321);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 25);
            this.comboBox1.TabIndex = 14;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.hospitalDataSet;
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "hospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // socialstatusBindingSource
            // 
            this.socialstatusBindingSource.DataMember = "Social_status";
            this.socialstatusBindingSource.DataSource = this.hospitalDataSet;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.NavajoWhite;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.ForestGreen;
            this.button1.Location = new System.Drawing.Point(100, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 27);
            this.button1.TabIndex = 13;
            this.button1.Text = "UPLOAD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.patientBindingSource, "img", true));
            this.pictureBox1.Location = new System.Drawing.Point(34, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // addressTextBox
            // 
            this.addressTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "address", true));
            this.addressTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.addressTextBox.Location = new System.Drawing.Point(434, 270);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(142, 22);
            this.addressTextBox.TabIndex = 9;
            // 
            // policy_numberTextBox
            // 
            this.policy_numberTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.policy_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "policy_number", true));
            this.policy_numberTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.policy_numberTextBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.policy_numberTextBox.Location = new System.Drawing.Point(433, 222);
            this.policy_numberTextBox.Name = "policy_numberTextBox";
            this.policy_numberTextBox.Size = new System.Drawing.Size(142, 22);
            this.policy_numberTextBox.TabIndex = 7;
            // 
            // birth_dateDateTimePicker
            // 
            this.birth_dateDateTimePicker.CalendarForeColor = System.Drawing.Color.MidnightBlue;
            this.birth_dateDateTimePicker.CalendarMonthBackground = System.Drawing.Color.MidnightBlue;
            this.birth_dateDateTimePicker.CalendarTitleBackColor = System.Drawing.Color.MidnightBlue;
            this.birth_dateDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.MidnightBlue;
            this.birth_dateDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.birth_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientBindingSource, "birth_date", true));
            this.birth_dateDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth_dateDateTimePicker.Location = new System.Drawing.Point(433, 99);
            this.birth_dateDateTimePicker.Name = "birth_dateDateTimePicker";
            this.birth_dateDateTimePicker.Size = new System.Drawing.Size(142, 22);
            this.birth_dateDateTimePicker.TabIndex = 5;
            this.birth_dateDateTimePicker.ValueChanged += new System.EventHandler(this.birth_dateDateTimePicker_ValueChanged);
            // 
            // full_nameTextBox
            // 
            this.full_nameTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.full_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "full_name", true));
            this.full_nameTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.full_nameTextBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.full_nameTextBox.Location = new System.Drawing.Point(434, 53);
            this.full_nameTextBox.Name = "full_nameTextBox";
            this.full_nameTextBox.Size = new System.Drawing.Size(142, 22);
            this.full_nameTextBox.TabIndex = 3;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BackColor = System.Drawing.Color.AliceBlue;
            this.bindingNavigator1.BindingSource = this.patientBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton1,
            this.toolStripButton3});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(895, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::sis2.Properties.Resources.diskette;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Insert";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::sis2.Properties.Resources.reload;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Update";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::sis2.Properties.Resources.composicao_moderna_com_coracao_real_e_estetoscopio_23_2147652362;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.radioButton6);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.radioButton5);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(full_nameLabel1);
            this.tabPage2.Controls.Add(this.full_nameTextBox1);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.dataGridView4);
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Controls.Add(this.bindingNavigator3);
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(901, 515);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Doctor";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.radioButton6.ForeColor = System.Drawing.Color.Maroon;
            this.radioButton6.Location = new System.Drawing.Point(304, 381);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(119, 25);
            this.radioButton6.TabIndex = 16;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Experience";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(304, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Sort";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.radioButton5.ForeColor = System.Drawing.Color.Maroon;
            this.radioButton5.Location = new System.Drawing.Point(304, 350);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(110, 25);
            this.radioButton5.TabIndex = 14;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Birth date";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(59, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Age:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // full_nameTextBox1
            // 
            this.full_nameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKDoctorSpecializationBindingSource6, "full_name", true));
            this.full_nameTextBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.full_nameTextBox1.Location = new System.Drawing.Point(122, 217);
            this.full_nameTextBox1.Name = "full_nameTextBox1";
            this.full_nameTextBox1.Size = new System.Drawing.Size(123, 23);
            this.full_nameTextBox1.TabIndex = 12;
            // 
            // fKDoctorSpecializationBindingSource6
            // 
            this.fKDoctorSpecializationBindingSource6.DataMember = "FK_Doctor_Specialization";
            this.fKDoctorSpecializationBindingSource6.DataSource = this.specializationBindingSource4;
            // 
            // specializationBindingSource4
            // 
            this.specializationBindingSource4.DataMember = "Specialization";
            this.specializationBindingSource4.DataSource = this.hospitalDataSet4;
            // 
            // hospitalDataSet4
            // 
            this.hospitalDataSet4.DataSetName = "hospitalDataSet4";
            this.hospitalDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox3
            // 
            this.textBox3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBox3.Location = new System.Drawing.Point(122, 246);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(123, 23);
            this.textBox3.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Tan;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.fKDoctorSpecializationBindingSource6, "img", true));
            this.pictureBox2.Location = new System.Drawing.Point(72, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(152, 141);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn});
            this.dataGridView4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView4.DataSource = this.specializationBindingSource4;
            this.dataGridView4.GridColor = System.Drawing.Color.Maroon;
            this.dataGridView4.Location = new System.Drawing.Point(23, 292);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView4.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSalmon;
            this.dataGridView4.Size = new System.Drawing.Size(260, 206);
            this.dataGridView4.TabIndex = 7;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Specialization";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Width = 200;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullnameDataGridViewTextBoxColumn1,
            this.experienceDataGridViewTextBoxColumn,
            this.specializationidDataGridViewTextBoxColumn1,
            this.birthdateDataGridViewTextBoxColumn1,
            this.address});
            this.dataGridView3.DataSource = this.fKDoctorSpecializationBindingSource6;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView3.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView3.Location = new System.Drawing.Point(296, 48);
            this.dataGridView3.Name = "dataGridView3";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView3.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSalmon;
            this.dataGridView3.Size = new System.Drawing.Size(543, 236);
            this.dataGridView3.TabIndex = 6;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick_1);
            // 
            // fullnameDataGridViewTextBoxColumn1
            // 
            this.fullnameDataGridViewTextBoxColumn1.DataPropertyName = "full_name";
            this.fullnameDataGridViewTextBoxColumn1.HeaderText = "Full name";
            this.fullnameDataGridViewTextBoxColumn1.Name = "fullnameDataGridViewTextBoxColumn1";
            // 
            // experienceDataGridViewTextBoxColumn
            // 
            this.experienceDataGridViewTextBoxColumn.DataPropertyName = "experience";
            this.experienceDataGridViewTextBoxColumn.HeaderText = "Experience";
            this.experienceDataGridViewTextBoxColumn.Name = "experienceDataGridViewTextBoxColumn";
            this.experienceDataGridViewTextBoxColumn.Width = 80;
            // 
            // specializationidDataGridViewTextBoxColumn1
            // 
            this.specializationidDataGridViewTextBoxColumn1.DataPropertyName = "specialization_id";
            this.specializationidDataGridViewTextBoxColumn1.HeaderText = "Specialization";
            this.specializationidDataGridViewTextBoxColumn1.Name = "specializationidDataGridViewTextBoxColumn1";
            // 
            // birthdateDataGridViewTextBoxColumn1
            // 
            this.birthdateDataGridViewTextBoxColumn1.DataPropertyName = "birth_date";
            this.birthdateDataGridViewTextBoxColumn1.HeaderText = "Birth_date";
            this.birthdateDataGridViewTextBoxColumn1.Name = "birthdateDataGridViewTextBoxColumn1";
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.Width = 120;
            // 
            // bindingNavigator3
            // 
            this.bindingNavigator3.AddNewItem = this.bindingNavigatorAddNewItem2;
            this.bindingNavigator3.BindingSource = this.fKDoctorSpecializationBindingSource6;
            this.bindingNavigator3.CountItem = this.bindingNavigatorCountItem2;
            this.bindingNavigator3.DeleteItem = this.bindingNavigatorDeleteItem2;
            this.bindingNavigator3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem2,
            this.bindingNavigatorMovePreviousItem2,
            this.bindingNavigatorSeparator6,
            this.bindingNavigatorPositionItem2,
            this.bindingNavigatorCountItem2,
            this.bindingNavigatorSeparator7,
            this.bindingNavigatorMoveNextItem2,
            this.bindingNavigatorMoveLastItem2,
            this.bindingNavigatorSeparator8,
            this.bindingNavigatorAddNewItem2,
            this.bindingNavigatorDeleteItem2,
            this.toolStripButton4});
            this.bindingNavigator3.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator3.MoveFirstItem = this.bindingNavigatorMoveFirstItem2;
            this.bindingNavigator3.MoveLastItem = this.bindingNavigatorMoveLastItem2;
            this.bindingNavigator3.MoveNextItem = this.bindingNavigatorMoveNextItem2;
            this.bindingNavigator3.MovePreviousItem = this.bindingNavigatorMovePreviousItem2;
            this.bindingNavigator3.Name = "bindingNavigator3";
            this.bindingNavigator3.PositionItem = this.bindingNavigatorPositionItem2;
            this.bindingNavigator3.Size = new System.Drawing.Size(895, 25);
            this.bindingNavigator3.TabIndex = 4;
            this.bindingNavigator3.Text = "bindingNavigator3";
            // 
            // bindingNavigatorAddNewItem2
            // 
            this.bindingNavigatorAddNewItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem2.Image")));
            this.bindingNavigatorAddNewItem2.Name = "bindingNavigatorAddNewItem2";
            this.bindingNavigatorAddNewItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem2.Text = "Добавить";
            this.bindingNavigatorAddNewItem2.Click += new System.EventHandler(this.bindingNavigatorAddNewItem2_Click);
            // 
            // bindingNavigatorCountItem2
            // 
            this.bindingNavigatorCountItem2.Name = "bindingNavigatorCountItem2";
            this.bindingNavigatorCountItem2.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem2.Text = "для {0}";
            this.bindingNavigatorCountItem2.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem2
            // 
            this.bindingNavigatorDeleteItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem2.Image")));
            this.bindingNavigatorDeleteItem2.Name = "bindingNavigatorDeleteItem2";
            this.bindingNavigatorDeleteItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem2.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem2
            // 
            this.bindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem2.Image")));
            this.bindingNavigatorMoveFirstItem2.Name = "bindingNavigatorMoveFirstItem2";
            this.bindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem2.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem2
            // 
            this.bindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem2.Image")));
            this.bindingNavigatorMovePreviousItem2.Name = "bindingNavigatorMovePreviousItem2";
            this.bindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem2.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator6
            // 
            this.bindingNavigatorSeparator6.Name = "bindingNavigatorSeparator6";
            this.bindingNavigatorSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem2
            // 
            this.bindingNavigatorPositionItem2.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem2.AutoSize = false;
            this.bindingNavigatorPositionItem2.Name = "bindingNavigatorPositionItem2";
            this.bindingNavigatorPositionItem2.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem2.Text = "0";
            this.bindingNavigatorPositionItem2.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator7
            // 
            this.bindingNavigatorSeparator7.Name = "bindingNavigatorSeparator7";
            this.bindingNavigatorSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem2
            // 
            this.bindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem2.Image")));
            this.bindingNavigatorMoveNextItem2.Name = "bindingNavigatorMoveNextItem2";
            this.bindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem2.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem2
            // 
            this.bindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem2.Image")));
            this.bindingNavigatorMoveLastItem2.Name = "bindingNavigatorMoveLastItem2";
            this.bindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem2.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator8
            // 
            this.bindingNavigatorSeparator8.Name = "bindingNavigatorSeparator8";
            this.bindingNavigatorSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::sis2.Properties.Resources.rotate;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Reload";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::sis2.Properties.Resources.healthcare;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.radioButton4);
            this.tabPage3.Controls.Add(this.radioButton2);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.comboBox3);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.bindingNavigator2);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(901, 515);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Treatment";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Firebrick;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(726, 450);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 25);
            this.button5.TabIndex = 13;
            this.button5.Text = "Do";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(513, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 32);
            this.button2.TabIndex = 12;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Bold);
            this.radioButton4.ForeColor = System.Drawing.Color.Indigo;
            this.radioButton4.Location = new System.Drawing.Point(708, 74);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(103, 20);
            this.radioButton4.TabIndex = 11;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Descending";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Bold);
            this.radioButton2.ForeColor = System.Drawing.Color.Indigo;
            this.radioButton2.Location = new System.Drawing.Point(708, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(96, 20);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ascending";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBox1.Location = new System.Drawing.Point(328, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 27);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Patient",
            "Doctor"});
            this.comboBox3.Location = new System.Drawing.Point(140, 46);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 25);
            this.comboBox3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.label4.Location = new System.Drawing.Point(57, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Search: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.checkBox6);
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.Peru;
            this.groupBox2.Location = new System.Drawing.Point(708, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(143, 193);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.ForeColor = System.Drawing.Color.Peru;
            this.checkBox6.Location = new System.Drawing.Point(13, 158);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(75, 20);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Critical";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.ForeColor = System.Drawing.Color.Peru;
            this.checkBox5.Location = new System.Drawing.Point(13, 131);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(73, 20);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Serious";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.ForeColor = System.Drawing.Color.Peru;
            this.checkBox4.Location = new System.Drawing.Point(13, 104);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(51, 20);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Fair";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.ForeColor = System.Drawing.Color.Peru;
            this.checkBox3.Location = new System.Drawing.Point(13, 77);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(63, 20);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Good";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.ForeColor = System.Drawing.Color.Peru;
            this.checkBox2.Location = new System.Drawing.Point(13, 50);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(118, 20);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Undetermined";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.Peru;
            this.checkBox1.Location = new System.Drawing.Point(13, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Dead";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Peru;
            this.groupBox1.Location = new System.Drawing.Point(706, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 109);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.Color.Peru;
            this.radioButton3.Location = new System.Drawing.Point(20, 69);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(84, 20);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "End date";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.Peru;
            this.radioButton1.Location = new System.Drawing.Point(20, 31);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(89, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Start date";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientDataGridViewTextBoxColumn,
            this.diagnosisDataGridViewTextBoxColumn,
            this.doctorDataGridViewTextBoxColumn,
            this.startdateDataGridViewTextBoxColumn,
            this.enddateDataGridViewTextBoxColumn,
            this.currentstateDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.treatBindingSource4;
            this.dataGridView2.Location = new System.Drawing.Point(34, 99);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.dataGridView2.Size = new System.Drawing.Size(641, 376);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // patientDataGridViewTextBoxColumn
            // 
            this.patientDataGridViewTextBoxColumn.DataPropertyName = "Patient";
            this.patientDataGridViewTextBoxColumn.HeaderText = "Patient";
            this.patientDataGridViewTextBoxColumn.Name = "patientDataGridViewTextBoxColumn";
            // 
            // diagnosisDataGridViewTextBoxColumn
            // 
            this.diagnosisDataGridViewTextBoxColumn.DataPropertyName = "Diagnosis";
            this.diagnosisDataGridViewTextBoxColumn.HeaderText = "Diagnosis";
            this.diagnosisDataGridViewTextBoxColumn.Name = "diagnosisDataGridViewTextBoxColumn";
            // 
            // doctorDataGridViewTextBoxColumn
            // 
            this.doctorDataGridViewTextBoxColumn.DataPropertyName = "Doctor";
            this.doctorDataGridViewTextBoxColumn.HeaderText = "Doctor";
            this.doctorDataGridViewTextBoxColumn.Name = "doctorDataGridViewTextBoxColumn";
            // 
            // startdateDataGridViewTextBoxColumn
            // 
            this.startdateDataGridViewTextBoxColumn.DataPropertyName = "start_date";
            this.startdateDataGridViewTextBoxColumn.HeaderText = "Start date";
            this.startdateDataGridViewTextBoxColumn.Name = "startdateDataGridViewTextBoxColumn";
            // 
            // enddateDataGridViewTextBoxColumn
            // 
            this.enddateDataGridViewTextBoxColumn.DataPropertyName = "end_date";
            this.enddateDataGridViewTextBoxColumn.HeaderText = "End date";
            this.enddateDataGridViewTextBoxColumn.Name = "enddateDataGridViewTextBoxColumn";
            // 
            // currentstateDataGridViewTextBoxColumn
            // 
            this.currentstateDataGridViewTextBoxColumn.DataPropertyName = "Current_state";
            this.currentstateDataGridViewTextBoxColumn.HeaderText = "Current state";
            this.currentstateDataGridViewTextBoxColumn.Name = "currentstateDataGridViewTextBoxColumn";
            // 
            // treatBindingSource4
            // 
            this.treatBindingSource4.DataMember = "Treat";
            this.treatBindingSource4.DataSource = this.hospitalDataSet2;
            // 
            // hospitalDataSet2
            // 
            this.hospitalDataSet2.DataSetName = "hospitalDataSet2";
            this.hospitalDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigator2.BindingSource = this.fKTreatmentPatientBindingSource;
            this.bindingNavigator2.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator2.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1,
            this.toolStripButton2});
            this.bindingNavigator2.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator2.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator2.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator2.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator2.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator2.Size = new System.Drawing.Size(895, 25);
            this.bindingNavigator2.TabIndex = 3;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem1.Text = "Добавить";
            // 
            // fKTreatmentPatientBindingSource
            // 
            this.fKTreatmentPatientBindingSource.DataMember = "FK_Treatment_Patient";
            this.fKTreatmentPatientBindingSource.DataSource = this.patientBindingSource;
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem1.Text = "для {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::sis2.Properties.Resources.rotate;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Update";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // specializationBindingSource
            // 
            this.specializationBindingSource.DataMember = "Specialization";
            this.specializationBindingSource.DataSource = this.hospitalDataSet;
            // 
            // fKDoctorSpecializationBindingSource2
            // 
            this.fKDoctorSpecializationBindingSource2.DataMember = "FK_Doctor_Specialization";
            this.fKDoctorSpecializationBindingSource2.DataSource = this.specializationBindingSource;
            // 
            // fKDoctorSpecializationBindingSource
            // 
            this.fKDoctorSpecializationBindingSource.DataMember = "FK_Doctor_Specialization";
            this.fKDoctorSpecializationBindingSource.DataSource = this.specializationBindingSource;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Current_stateTableAdapter = null;
            this.tableAdapterManager.DiagnosisTableAdapter = null;
            this.tableAdapterManager.DoctorTableAdapter = null;
            this.tableAdapterManager.PatientTableAdapter = this.patientTableAdapter;
            this.tableAdapterManager.Social_statusTableAdapter = this.social_statusTableAdapter;
            this.tableAdapterManager.SpecializationTableAdapter = null;
            this.tableAdapterManager.TreatmentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = sis2.hospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // social_statusTableAdapter
            // 
            this.social_statusTableAdapter.ClearBeforeFill = true;
            // 
            // specializationTableAdapter
            // 
            this.specializationTableAdapter.ClearBeforeFill = true;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // fKDoctorSpecializationBindingSource1
            // 
            this.fKDoctorSpecializationBindingSource1.DataMember = "FK_Doctor_Specialization";
            this.fKDoctorSpecializationBindingSource1.DataSource = this.specializationBindingSource;
            // 
            // treatmentBindingSource
            // 
            this.treatmentBindingSource.DataMember = "Treatment";
            this.treatmentBindingSource.DataSource = this.hospitalDataSet;
            // 
            // treatmentTableAdapter
            // 
            this.treatmentTableAdapter.ClearBeforeFill = true;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.hospitalDataSet;
            // 
            // hospitalDataSet1
            // 
            this.hospitalDataSet1.DataSetName = "hospitalDataSet1";
            this.hospitalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // treatBindingSource
            // 
            this.treatBindingSource.DataMember = "Treat";
            this.treatBindingSource.DataSource = this.hospitalDataSet1;
            // 
            // treatTableAdapter
            // 
            this.treatTableAdapter.ClearBeforeFill = true;
            // 
            // treatBindingSource1
            // 
            this.treatBindingSource1.DataMember = "Treat";
            this.treatBindingSource1.DataSource = this.hospitalDataSet1;
            // 
            // treatBindingSource2
            // 
            this.treatBindingSource2.DataMember = "Treat";
            this.treatBindingSource2.DataSource = this.hospitalDataSet1;
            // 
            // treatBindingSource3
            // 
            this.treatBindingSource3.DataMember = "Treat";
            this.treatBindingSource3.DataSource = this.hospitalDataSet2;
            // 
            // treatTableAdapter1
            // 
            this.treatTableAdapter1.ClearBeforeFill = true;
            // 
            // specializationBindingSource1
            // 
            this.specializationBindingSource1.DataMember = "Specialization";
            this.specializationBindingSource1.DataSource = this.hospitalDataSet;
            // 
            // fKDoctorSpecializationBindingSource3
            // 
            this.fKDoctorSpecializationBindingSource3.DataMember = "FK_Doctor_Specialization";
            this.fKDoctorSpecializationBindingSource3.DataSource = this.specializationBindingSource1;
            // 
            // hospitalDataSet3
            // 
            this.hospitalDataSet3.DataSetName = "hospitalDataSet3";
            this.hospitalDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specializationBindingSource2
            // 
            this.specializationBindingSource2.DataMember = "Specialization";
            this.specializationBindingSource2.DataSource = this.hospitalDataSet3;
            // 
            // specializationTableAdapter1
            // 
            this.specializationTableAdapter1.ClearBeforeFill = true;
            // 
            // fKDoctorSpecializationBindingSource4
            // 
            this.fKDoctorSpecializationBindingSource4.DataMember = "FK_Doctor_Specialization";
            this.fKDoctorSpecializationBindingSource4.DataSource = this.specializationBindingSource2;
            // 
            // doctorTableAdapter1
            // 
            this.doctorTableAdapter1.ClearBeforeFill = true;
            // 
            // specializationBindingSource3
            // 
            this.specializationBindingSource3.DataMember = "Specialization";
            this.specializationBindingSource3.DataSource = this.hospitalDataSet3;
            // 
            // fKDoctorSpecializationBindingSource5
            // 
            this.fKDoctorSpecializationBindingSource5.DataMember = "FK_Doctor_Specialization";
            this.fKDoctorSpecializationBindingSource5.DataSource = this.specializationBindingSource3;
            // 
            // specializationTableAdapter2
            // 
            this.specializationTableAdapter2.ClearBeforeFill = true;
            // 
            // doctorTableAdapter2
            // 
            this.doctorTableAdapter2.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Current_stateTableAdapter = null;
            this.tableAdapterManager1.DiagnosisTableAdapter = null;
            this.tableAdapterManager1.DoctorTableAdapter = this.doctorTableAdapter2;
            this.tableAdapterManager1.PatientTableAdapter = null;
            this.tableAdapterManager1.Social_statusTableAdapter = null;
            this.tableAdapterManager1.SpecializationTableAdapter = this.specializationTableAdapter2;
            this.tableAdapterManager1.TreatmentTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = sis2.hospitalDataSet4TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(911, 548);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Hospital";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socialstatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKDoctorSpecializationBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializationBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).EndInit();
            this.bindingNavigator3.ResumeLayout(false);
            this.bindingNavigator3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKTreatmentPatientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDoctorSpecializationBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDoctorSpecializationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDoctorSpecializationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDoctorSpecializationBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializationBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDoctorSpecializationBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializationBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDoctorSpecializationBindingSource5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private hospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private hospitalDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox policy_numberTextBox;
        private System.Windows.Forms.DateTimePicker birth_dateDateTimePicker;
        private System.Windows.Forms.TextBox full_nameTextBox;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private hospitalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private hospitalDataSetTableAdapters.Social_statusTableAdapter social_statusTableAdapter;
        private System.Windows.Forms.BindingSource socialstatusBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.BindingSource specializationBindingSource;
        private hospitalDataSetTableAdapters.SpecializationTableAdapter specializationTableAdapter;
        private System.Windows.Forms.BindingSource fKDoctorSpecializationBindingSource;
        private hospitalDataSetTableAdapters.DoctorTableAdapter doctorTableAdapter;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource fKDoctorSpecializationBindingSource2;
        private System.Windows.Forms.BindingSource fKDoctorSpecializationBindingSource1;
        private System.Windows.Forms.BindingSource treatmentBindingSource;
        private hospitalDataSetTableAdapters.TreatmentTableAdapter treatmentTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.BindingSource fKTreatmentPatientBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private hospitalDataSet1 hospitalDataSet1;
        private System.Windows.Forms.BindingSource treatBindingSource;
        private hospitalDataSet1TableAdapters.TreatTableAdapter treatTableAdapter;
        private System.Windows.Forms.BindingSource treatBindingSource1;
        private System.Windows.Forms.BindingSource treatBindingSource2;
        private hospitalDataSet2 hospitalDataSet2;
        private System.Windows.Forms.BindingSource treatBindingSource3;
        private hospitalDataSet2TableAdapters.TreatTableAdapter treatTableAdapter1;
        private System.Windows.Forms.BindingSource treatBindingSource4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentstateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator bindingNavigator3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem2;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator6;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator8;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource specializationBindingSource1;
        private System.Windows.Forms.BindingSource fKDoctorSpecializationBindingSource3;
        private hospitalDataSet3 hospitalDataSet3;
        private System.Windows.Forms.BindingSource specializationBindingSource2;
        private hospitalDataSet3TableAdapters.SpecializationTableAdapter specializationTableAdapter1;
        private System.Windows.Forms.BindingSource fKDoctorSpecializationBindingSource4;
        private hospitalDataSet3TableAdapters.DoctorTableAdapter doctorTableAdapter1;
        private System.Windows.Forms.BindingSource fKDoctorSpecializationBindingSource5;
        private System.Windows.Forms.BindingSource specializationBindingSource3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private hospitalDataSet4 hospitalDataSet4;
        private System.Windows.Forms.BindingSource specializationBindingSource4;
        private hospitalDataSet4TableAdapters.SpecializationTableAdapter specializationTableAdapter2;
        private System.Windows.Forms.BindingSource fKDoctorSpecializationBindingSource6;
        private hospitalDataSet4TableAdapters.DoctorTableAdapter doctorTableAdapter2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private hospitalDataSet4TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox full_nameTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn experienceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specializationidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.Button button5;
    }
}

