namespace bald_mans_iron_butterfly
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.envanterHareket_btn = new System.Windows.Forms.Button();
            this.girisCikis_btn = new System.Windows.Forms.Button();
            this.girisCikis_groupBox = new System.Windows.Forms.GroupBox();
            this.stok_dataGridView = new System.Windows.Forms.DataGridView();
            this.stokYazdir_btn = new System.Windows.Forms.Button();
            this.stokIsle_btn = new System.Windows.Forms.Button();
            this.cikis_radioBtn = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.giris_radioBtn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.not_txtBox = new System.Windows.Forms.TextBox();
            this.demirCap_comboBox = new System.Windows.Forms.ComboBox();
            this.miktar_txtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hareket_groupBox = new System.Windows.Forms.GroupBox();
            this.hareket_dataGridView = new System.Windows.Forms.DataGridView();
            this.hareketYazdir_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.linkedin_btn = new System.Windows.Forms.Button();
            this.github_btn = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notlokasyonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanıcıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.envanterhareketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iron_butterfly_dbDataSet = new bald_mans_iron_butterfly.iron_butterfly_dbDataSet();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demirstokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demir_stokTableAdapter = new bald_mans_iron_butterfly.iron_butterfly_dbDataSetTableAdapters.demir_stokTableAdapter();
            this.envanter_hareketTableAdapter = new bald_mans_iron_butterfly.iron_butterfly_dbDataSetTableAdapters.envanter_hareketTableAdapter();
            this.groupBox1.SuspendLayout();
            this.girisCikis_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stok_dataGridView)).BeginInit();
            this.hareket_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hareket_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.envanterhareketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iron_butterfly_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirstokBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.github_btn);
            this.groupBox1.Controls.Add(this.linkedin_btn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.envanterHareket_btn);
            this.groupBox1.Controls.Add(this.girisCikis_btn);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 656);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NERVÜRLÜ DEMİR";
            // 
            // envanterHareket_btn
            // 
            this.envanterHareket_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.envanterHareket_btn.Location = new System.Drawing.Point(7, 73);
            this.envanterHareket_btn.Name = "envanterHareket_btn";
            this.envanterHareket_btn.Size = new System.Drawing.Size(187, 45);
            this.envanterHareket_btn.TabIndex = 0;
            this.envanterHareket_btn.TabStop = false;
            this.envanterHareket_btn.Text = "ENVANTER HAREKETLERİ";
            this.envanterHareket_btn.UseVisualStyleBackColor = true;
            this.envanterHareket_btn.Click += new System.EventHandler(this.envanterHareket_btn_Click);
            // 
            // girisCikis_btn
            // 
            this.girisCikis_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.girisCikis_btn.Location = new System.Drawing.Point(7, 22);
            this.girisCikis_btn.Name = "girisCikis_btn";
            this.girisCikis_btn.Size = new System.Drawing.Size(187, 45);
            this.girisCikis_btn.TabIndex = 0;
            this.girisCikis_btn.TabStop = false;
            this.girisCikis_btn.Text = "GİRİŞ / ÇIKIŞ";
            this.girisCikis_btn.UseVisualStyleBackColor = true;
            this.girisCikis_btn.Click += new System.EventHandler(this.girisCikis_btn_Click);
            // 
            // girisCikis_groupBox
            // 
            this.girisCikis_groupBox.Controls.Add(this.stok_dataGridView);
            this.girisCikis_groupBox.Controls.Add(this.stokYazdir_btn);
            this.girisCikis_groupBox.Controls.Add(this.stokIsle_btn);
            this.girisCikis_groupBox.Controls.Add(this.cikis_radioBtn);
            this.girisCikis_groupBox.Controls.Add(this.label4);
            this.girisCikis_groupBox.Controls.Add(this.giris_radioBtn);
            this.girisCikis_groupBox.Controls.Add(this.label3);
            this.girisCikis_groupBox.Controls.Add(this.not_txtBox);
            this.girisCikis_groupBox.Controls.Add(this.demirCap_comboBox);
            this.girisCikis_groupBox.Controls.Add(this.miktar_txtBox);
            this.girisCikis_groupBox.Controls.Add(this.label2);
            this.girisCikis_groupBox.Controls.Add(this.label1);
            this.girisCikis_groupBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisCikis_groupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.girisCikis_groupBox.Location = new System.Drawing.Point(220, 13);
            this.girisCikis_groupBox.Name = "girisCikis_groupBox";
            this.girisCikis_groupBox.Size = new System.Drawing.Size(1032, 656);
            this.girisCikis_groupBox.TabIndex = 1;
            this.girisCikis_groupBox.TabStop = false;
            this.girisCikis_groupBox.Text = "GİRİŞ/ÇIKIŞ";
            // 
            // stok_dataGridView
            // 
            this.stok_dataGridView.AllowUserToAddRows = false;
            this.stok_dataGridView.AllowUserToDeleteRows = false;
            this.stok_dataGridView.AllowUserToResizeRows = false;
            this.stok_dataGridView.AutoGenerateColumns = false;
            this.stok_dataGridView.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.stok_dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stok_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.stok_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.stok_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.stok_dataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stok_dataGridView.DataSource = this.demirstokBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stok_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.stok_dataGridView.EnableHeadersVisualStyles = false;
            this.stok_dataGridView.GridColor = System.Drawing.Color.Black;
            this.stok_dataGridView.Location = new System.Drawing.Point(11, 99);
            this.stok_dataGridView.MultiSelect = false;
            this.stok_dataGridView.Name = "stok_dataGridView";
            this.stok_dataGridView.ReadOnly = true;
            this.stok_dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.stok_dataGridView.RowHeadersVisible = false;
            this.stok_dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.stok_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stok_dataGridView.ShowCellErrors = false;
            this.stok_dataGridView.ShowCellToolTips = false;
            this.stok_dataGridView.ShowEditingIcon = false;
            this.stok_dataGridView.ShowRowErrors = false;
            this.stok_dataGridView.Size = new System.Drawing.Size(1012, 551);
            this.stok_dataGridView.TabIndex = 7;
            // 
            // stokYazdir_btn
            // 
            this.stokYazdir_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stokYazdir_btn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokYazdir_btn.Location = new System.Drawing.Point(773, 66);
            this.stokYazdir_btn.Name = "stokYazdir_btn";
            this.stokYazdir_btn.Size = new System.Drawing.Size(250, 27);
            this.stokYazdir_btn.TabIndex = 6;
            this.stokYazdir_btn.Text = "STOĞU EXCEL\'E YAZDIR";
            this.stokYazdir_btn.UseVisualStyleBackColor = true;
            this.stokYazdir_btn.Click += new System.EventHandler(this.stokYazdir_btn_Click);
            // 
            // stokIsle_btn
            // 
            this.stokIsle_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stokIsle_btn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokIsle_btn.Location = new System.Drawing.Point(773, 39);
            this.stokIsle_btn.Name = "stokIsle_btn";
            this.stokIsle_btn.Size = new System.Drawing.Size(250, 27);
            this.stokIsle_btn.TabIndex = 5;
            this.stokIsle_btn.Text = "STOĞA İŞLE";
            this.stokIsle_btn.UseVisualStyleBackColor = true;
            this.stokIsle_btn.Click += new System.EventHandler(this.stokIsle_btn_Click);
            // 
            // cikis_radioBtn
            // 
            this.cikis_radioBtn.AutoSize = true;
            this.cikis_radioBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikis_radioBtn.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cikis_radioBtn.Location = new System.Drawing.Point(693, 42);
            this.cikis_radioBtn.Name = "cikis_radioBtn";
            this.cikis_radioBtn.Size = new System.Drawing.Size(54, 18);
            this.cikis_radioBtn.TabIndex = 3;
            this.cikis_radioBtn.TabStop = true;
            this.cikis_radioBtn.Text = "ÇIKIŞ";
            this.cikis_radioBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(691, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Yön seçiniz.";
            // 
            // giris_radioBtn
            // 
            this.giris_radioBtn.AutoSize = true;
            this.giris_radioBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.giris_radioBtn.Font = new System.Drawing.Font("Tahoma", 9F);
            this.giris_radioBtn.Location = new System.Drawing.Point(693, 64);
            this.giris_radioBtn.Name = "giris_radioBtn";
            this.giris_radioBtn.Size = new System.Drawing.Size(55, 18);
            this.giris_radioBtn.TabIndex = 4;
            this.giris_radioBtn.TabStop = true;
            this.giris_radioBtn.Text = "GİRİŞ";
            this.giris_radioBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(304, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Not (Lokasyon)";
            // 
            // not_txtBox
            // 
            this.not_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.not_txtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.not_txtBox.Font = new System.Drawing.Font("Tahoma", 9F);
            this.not_txtBox.Location = new System.Drawing.Point(304, 50);
            this.not_txtBox.Name = "not_txtBox";
            this.not_txtBox.Size = new System.Drawing.Size(365, 22);
            this.not_txtBox.TabIndex = 2;
            // 
            // demirCap_comboBox
            // 
            this.demirCap_comboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.demirCap_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.demirCap_comboBox.Font = new System.Drawing.Font("Tahoma", 9F);
            this.demirCap_comboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.demirCap_comboBox.FormattingEnabled = true;
            this.demirCap_comboBox.Items.AddRange(new object[] {
            "Ø8",
            "Ø10",
            "Ø12",
            "Ø14",
            "Ø16",
            "Ø18",
            "Ø20"});
            this.demirCap_comboBox.Location = new System.Drawing.Point(11, 51);
            this.demirCap_comboBox.Name = "demirCap_comboBox";
            this.demirCap_comboBox.Size = new System.Drawing.Size(121, 22);
            this.demirCap_comboBox.TabIndex = 0;
            // 
            // miktar_txtBox
            // 
            this.miktar_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.miktar_txtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.miktar_txtBox.Font = new System.Drawing.Font("Tahoma", 9F);
            this.miktar_txtBox.Location = new System.Drawing.Point(156, 51);
            this.miktar_txtBox.Name = "miktar_txtBox";
            this.miktar_txtBox.Size = new System.Drawing.Size(122, 22);
            this.miktar_txtBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(154, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Miktar yazınız. (Bağ)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Demir Çapı seçiniz.";
            // 
            // hareket_groupBox
            // 
            this.hareket_groupBox.Controls.Add(this.hareket_dataGridView);
            this.hareket_groupBox.Controls.Add(this.hareketYazdir_btn);
            this.hareket_groupBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hareket_groupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hareket_groupBox.Location = new System.Drawing.Point(220, 13);
            this.hareket_groupBox.Name = "hareket_groupBox";
            this.hareket_groupBox.Size = new System.Drawing.Size(1032, 656);
            this.hareket_groupBox.TabIndex = 9;
            this.hareket_groupBox.TabStop = false;
            this.hareket_groupBox.Text = "ENVANTER HAREKETLERİ";
            this.hareket_groupBox.Visible = false;
            // 
            // hareket_dataGridView
            // 
            this.hareket_dataGridView.AllowUserToAddRows = false;
            this.hareket_dataGridView.AllowUserToDeleteRows = false;
            this.hareket_dataGridView.AllowUserToResizeRows = false;
            this.hareket_dataGridView.AutoGenerateColumns = false;
            this.hareket_dataGridView.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.hareket_dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.hareket_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.hareket_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.hareket_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.yonDataGridViewTextBoxColumn,
            this.notlokasyonDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn9,
            this.kullanıcıDataGridViewTextBoxColumn});
            this.hareket_dataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hareket_dataGridView.DataSource = this.envanterhareketBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.hareket_dataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.hareket_dataGridView.EnableHeadersVisualStyles = false;
            this.hareket_dataGridView.GridColor = System.Drawing.Color.Black;
            this.hareket_dataGridView.Location = new System.Drawing.Point(11, 64);
            this.hareket_dataGridView.MultiSelect = false;
            this.hareket_dataGridView.Name = "hareket_dataGridView";
            this.hareket_dataGridView.ReadOnly = true;
            this.hareket_dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.hareket_dataGridView.RowHeadersVisible = false;
            this.hareket_dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.hareket_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.hareket_dataGridView.ShowCellErrors = false;
            this.hareket_dataGridView.ShowCellToolTips = false;
            this.hareket_dataGridView.ShowEditingIcon = false;
            this.hareket_dataGridView.ShowRowErrors = false;
            this.hareket_dataGridView.Size = new System.Drawing.Size(1012, 586);
            this.hareket_dataGridView.TabIndex = 7;
            // 
            // hareketYazdir_btn
            // 
            this.hareketYazdir_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hareketYazdir_btn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hareketYazdir_btn.Location = new System.Drawing.Point(823, 21);
            this.hareketYazdir_btn.Name = "hareketYazdir_btn";
            this.hareketYazdir_btn.Size = new System.Drawing.Size(200, 39);
            this.hareketYazdir_btn.TabIndex = 6;
            this.hareketYazdir_btn.Text = "ENVANTER HAREKETLERİNİ EXCEL\'E YAZDIR";
            this.hareketYazdir_btn.UseVisualStyleBackColor = true;
            this.hareketYazdir_btn.Click += new System.EventHandler(this.hareketYazdir_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(52, 605);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 39);
            this.label5.TabIndex = 1;
            this.label5.Text = "BUĞRA DÖNMEZ\r\n\r\n2024";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkedin_btn
            // 
            this.linkedin_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("linkedin_btn.BackgroundImage")));
            this.linkedin_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.linkedin_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkedin_btn.Location = new System.Drawing.Point(8, 544);
            this.linkedin_btn.Name = "linkedin_btn";
            this.linkedin_btn.Size = new System.Drawing.Size(84, 51);
            this.linkedin_btn.TabIndex = 3;
            this.linkedin_btn.TabStop = false;
            this.linkedin_btn.UseVisualStyleBackColor = true;
            this.linkedin_btn.Click += new System.EventHandler(this.linkedin_btn_Click);
            // 
            // github_btn
            // 
            this.github_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("github_btn.BackgroundImage")));
            this.github_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.github_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.github_btn.Location = new System.Drawing.Point(109, 544);
            this.github_btn.Name = "github_btn";
            this.github_btn.Size = new System.Drawing.Size(84, 51);
            this.github_btn.TabIndex = 4;
            this.github_btn.TabStop = false;
            this.github_btn.UseVisualStyleBackColor = true;
            this.github_btn.Click += new System.EventHandler(this.github_btn_Click);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 60;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "stok_kodu";
            this.dataGridViewTextBoxColumn6.HeaderText = "STOK KODU";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "malzeme_adi";
            this.dataGridViewTextBoxColumn7.HeaderText = "MALZEME ADI";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "miktar";
            this.dataGridViewTextBoxColumn8.HeaderText = "MİKTAR (BAĞ)";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // yonDataGridViewTextBoxColumn
            // 
            this.yonDataGridViewTextBoxColumn.DataPropertyName = "yon";
            this.yonDataGridViewTextBoxColumn.HeaderText = "YON";
            this.yonDataGridViewTextBoxColumn.Name = "yonDataGridViewTextBoxColumn";
            this.yonDataGridViewTextBoxColumn.ReadOnly = true;
            this.yonDataGridViewTextBoxColumn.Width = 80;
            // 
            // notlokasyonDataGridViewTextBoxColumn
            // 
            this.notlokasyonDataGridViewTextBoxColumn.DataPropertyName = "not_lokasyon";
            this.notlokasyonDataGridViewTextBoxColumn.HeaderText = "NOT (LOKASYON)";
            this.notlokasyonDataGridViewTextBoxColumn.Name = "notlokasyonDataGridViewTextBoxColumn";
            this.notlokasyonDataGridViewTextBoxColumn.ReadOnly = true;
            this.notlokasyonDataGridViewTextBoxColumn.Width = 250;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "tarih";
            this.dataGridViewTextBoxColumn9.HeaderText = "TARİH";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // kullanıcıDataGridViewTextBoxColumn
            // 
            this.kullanıcıDataGridViewTextBoxColumn.DataPropertyName = "kullanıcı";
            this.kullanıcıDataGridViewTextBoxColumn.HeaderText = "KULLANICI";
            this.kullanıcıDataGridViewTextBoxColumn.Name = "kullanıcıDataGridViewTextBoxColumn";
            this.kullanıcıDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // envanterhareketBindingSource
            // 
            this.envanterhareketBindingSource.DataMember = "envanter_hareket";
            this.envanterhareketBindingSource.DataSource = this.iron_butterfly_dbDataSet;
            // 
            // iron_butterfly_dbDataSet
            // 
            this.iron_butterfly_dbDataSet.DataSetName = "iron_butterfly_dbDataSet";
            this.iron_butterfly_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "stok_kodu";
            this.dataGridViewTextBoxColumn2.HeaderText = "STOK KODU";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "malzeme_adi";
            this.dataGridViewTextBoxColumn3.HeaderText = "MALZEME ADI";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "miktar";
            this.dataGridViewTextBoxColumn4.HeaderText = "MİKTAR (BAĞ)";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // demirstokBindingSource
            // 
            this.demirstokBindingSource.DataMember = "demir_stok";
            this.demirstokBindingSource.DataSource = this.iron_butterfly_dbDataSet;
            // 
            // demir_stokTableAdapter
            // 
            this.demir_stokTableAdapter.ClearBeforeFill = true;
            // 
            // envanter_hareketTableAdapter
            // 
            this.envanter_hareketTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.hareket_groupBox);
            this.Controls.Add(this.girisCikis_groupBox);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bald Man\'s Iron Butterfly";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.girisCikis_groupBox.ResumeLayout(false);
            this.girisCikis_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stok_dataGridView)).EndInit();
            this.hareket_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hareket_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.envanterhareketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iron_butterfly_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirstokBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox girisCikis_groupBox;
        private System.Windows.Forms.Button envanterHareket_btn;
        private System.Windows.Forms.Button girisCikis_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox miktar_txtBox;
        private System.Windows.Forms.ComboBox demirCap_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox not_txtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton giris_radioBtn;
        private System.Windows.Forms.RadioButton cikis_radioBtn;
        private System.Windows.Forms.Button stokIsle_btn;
        private System.Windows.Forms.Button stokYazdir_btn;
        private System.Windows.Forms.DataGridView stok_dataGridView;
        private System.Windows.Forms.GroupBox hareket_groupBox;
        private System.Windows.Forms.DataGridView hareket_dataGridView;
        private System.Windows.Forms.Button hareketYazdir_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokkoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yönDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokkoduDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeadiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktarDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn notDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private iron_butterfly_dbDataSet iron_butterfly_dbDataSet;
        private System.Windows.Forms.BindingSource demirstokBindingSource;
        private iron_butterfly_dbDataSetTableAdapters.demir_stokTableAdapter demir_stokTableAdapter;
        private System.Windows.Forms.BindingSource envanterhareketBindingSource;
        private iron_butterfly_dbDataSetTableAdapters.envanter_hareketTableAdapter envanter_hareketTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn yonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notlokasyonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanıcıDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button github_btn;
        private System.Windows.Forms.Button linkedin_btn;
    }
}

