namespace book_app1._0
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
            System.Windows.Forms.Label kitapAdiLabel;
            System.Windows.Forms.Label yazarLabel;
            System.Windows.Forms.Label kategoriLabel;
            System.Windows.Forms.Label durumLabel;
            System.Windows.Forms.Label okumaTarihiLabel;
            System.Windows.Forms.Label ozetLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kitaplarBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.kitaplarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitaplar_databaseDataSet = new book_app1._0.kitaplar_databaseDataSet();
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
            this.kitaplarBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kitaplarDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapAdiTextBox = new System.Windows.Forms.TextBox();
            this.yazarTextBox = new System.Windows.Forms.TextBox();
            this.kategoriComboBox = new System.Windows.Forms.ComboBox();
            this.durumComboBox = new System.Windows.Forms.ComboBox();
            this.okumaTarihiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ozetTextBox = new System.Windows.Forms.TextBox();
            this.kitaplarTableAdapter = new book_app1._0.kitaplar_databaseDataSetTableAdapters.kitaplarTableAdapter();
            this.tableAdapterManager = new book_app1._0.kitaplar_databaseDataSetTableAdapters.TableAdapterManager();
            kitapAdiLabel = new System.Windows.Forms.Label();
            yazarLabel = new System.Windows.Forms.Label();
            kategoriLabel = new System.Windows.Forms.Label();
            durumLabel = new System.Windows.Forms.Label();
            okumaTarihiLabel = new System.Windows.Forms.Label();
            ozetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingNavigator)).BeginInit();
            this.kitaplarBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplar_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // kitapAdiLabel
            // 
            kitapAdiLabel.AutoSize = true;
            kitapAdiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            kitapAdiLabel.Location = new System.Drawing.Point(46, 601);
            kitapAdiLabel.Name = "kitapAdiLabel";
            kitapAdiLabel.Size = new System.Drawing.Size(144, 36);
            kitapAdiLabel.TabIndex = 2;
            kitapAdiLabel.Text = "Kitap Adi:";
            // 
            // yazarLabel
            // 
            yazarLabel.AutoSize = true;
            yazarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            yazarLabel.Location = new System.Drawing.Point(46, 654);
            yazarLabel.Name = "yazarLabel";
            yazarLabel.Size = new System.Drawing.Size(100, 36);
            yazarLabel.TabIndex = 4;
            yazarLabel.Text = "Yazar:";
            // 
            // kategoriLabel
            // 
            kategoriLabel.AutoSize = true;
            kategoriLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            kategoriLabel.Location = new System.Drawing.Point(46, 706);
            kategoriLabel.Name = "kategoriLabel";
            kategoriLabel.Size = new System.Drawing.Size(134, 36);
            kategoriLabel.TabIndex = 6;
            kategoriLabel.Text = "Kategori:";
            // 
            // durumLabel
            // 
            durumLabel.AutoSize = true;
            durumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            durumLabel.Location = new System.Drawing.Point(46, 821);
            durumLabel.Name = "durumLabel";
            durumLabel.Size = new System.Drawing.Size(111, 36);
            durumLabel.TabIndex = 8;
            durumLabel.Text = "Durum:";
            // 
            // okumaTarihiLabel
            // 
            okumaTarihiLabel.AutoSize = true;
            okumaTarihiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            okumaTarihiLabel.Location = new System.Drawing.Point(46, 762);
            okumaTarihiLabel.Name = "okumaTarihiLabel";
            okumaTarihiLabel.Size = new System.Drawing.Size(199, 36);
            okumaTarihiLabel.TabIndex = 10;
            okumaTarihiLabel.Text = "Okuma Tarihi:";
            // 
            // ozetLabel
            // 
            ozetLabel.AutoSize = true;
            ozetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            ozetLabel.Location = new System.Drawing.Point(581, 595);
            ozetLabel.Name = "ozetLabel";
            ozetLabel.Size = new System.Drawing.Size(84, 36);
            ozetLabel.TabIndex = 12;
            ozetLabel.Text = "Ozet:";
            // 
            // kitaplarBindingNavigator
            // 
            this.kitaplarBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.kitaplarBindingNavigator.BindingSource = this.kitaplarBindingSource;
            this.kitaplarBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.kitaplarBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.kitaplarBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.kitaplarBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.kitaplarBindingNavigatorSaveItem});
            this.kitaplarBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.kitaplarBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.kitaplarBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.kitaplarBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.kitaplarBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.kitaplarBindingNavigator.Name = "kitaplarBindingNavigator";
            this.kitaplarBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.kitaplarBindingNavigator.Size = new System.Drawing.Size(1443, 27);
            this.kitaplarBindingNavigator.TabIndex = 0;
            this.kitaplarBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Yeni ekle";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // kitaplarBindingSource
            // 
            this.kitaplarBindingSource.DataMember = "kitaplar";
            this.kitaplarBindingSource.DataSource = this.kitaplar_databaseDataSet;
            // 
            // kitaplar_databaseDataSet
            // 
            this.kitaplar_databaseDataSet.DataSetName = "kitaplar_databaseDataSet";
            this.kitaplar_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 24);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Toplam öğe sayısı";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Sil";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Başa taşı";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Öne taşı";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Konum";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Geçerli konum";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Arkaya taşı";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Sona taşı";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // kitaplarBindingNavigatorSaveItem
            // 
            this.kitaplarBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kitaplarBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("kitaplarBindingNavigatorSaveItem.Image")));
            this.kitaplarBindingNavigatorSaveItem.Name = "kitaplarBindingNavigatorSaveItem";
            this.kitaplarBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.kitaplarBindingNavigatorSaveItem.Text = "Veriyi Sakla";
            this.kitaplarBindingNavigatorSaveItem.Click += new System.EventHandler(this.kitaplarBindingNavigatorSaveItem_Click);
            // 
            // kitaplarDataGridView
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitaplarDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.kitaplarDataGridView.AutoGenerateColumns = false;
            this.kitaplarDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kitaplarDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kitaplarDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kitaplarDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.kitaplarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitaplarDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.kitaplarDataGridView.DataSource = this.kitaplarBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.kitaplarDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.kitaplarDataGridView.Location = new System.Drawing.Point(12, 69);
            this.kitaplarDataGridView.Name = "kitaplarDataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kitaplarDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.kitaplarDataGridView.RowHeadersWidth = 51;
            this.kitaplarDataGridView.RowTemplate.Height = 24;
            this.kitaplarDataGridView.Size = new System.Drawing.Size(1344, 483);
            this.kitaplarDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "KitapId";
            this.dataGridViewTextBoxColumn1.HeaderText = "KitapId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "KitapAdi";
            this.dataGridViewTextBoxColumn2.HeaderText = "KitapAdi";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Yazar";
            this.dataGridViewTextBoxColumn3.HeaderText = "Yazar";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Kategori";
            this.dataGridViewTextBoxColumn4.HeaderText = "Kategori";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Durum";
            this.dataGridViewTextBoxColumn5.HeaderText = "Durum";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "OkumaTarihi";
            this.dataGridViewTextBoxColumn6.HeaderText = "OkumaTarihi";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Ozet";
            this.dataGridViewTextBoxColumn7.HeaderText = "Ozet";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // kitapAdiTextBox
            // 
            this.kitapAdiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kitaplarBindingSource, "KitapAdi", true));
            this.kitapAdiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapAdiTextBox.Location = new System.Drawing.Point(299, 607);
            this.kitapAdiTextBox.Name = "kitapAdiTextBox";
            this.kitapAdiTextBox.Size = new System.Drawing.Size(202, 34);
            this.kitapAdiTextBox.TabIndex = 3;
            // 
            // yazarTextBox
            // 
            this.yazarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kitaplarBindingSource, "Yazar", true));
            this.yazarTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yazarTextBox.Location = new System.Drawing.Point(299, 660);
            this.yazarTextBox.Name = "yazarTextBox";
            this.yazarTextBox.Size = new System.Drawing.Size(202, 34);
            this.yazarTextBox.TabIndex = 5;
            // 
            // kategoriComboBox
            // 
            this.kategoriComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kitaplarBindingSource, "Kategori", true));
            this.kategoriComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kategoriComboBox.FormattingEnabled = true;
            this.kategoriComboBox.Location = new System.Drawing.Point(299, 706);
            this.kategoriComboBox.Name = "kategoriComboBox";
            this.kategoriComboBox.Size = new System.Drawing.Size(202, 37);
            this.kategoriComboBox.TabIndex = 7;
            // 
            // durumComboBox
            // 
            this.durumComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kitaplarBindingSource, "Durum", true));
            this.durumComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.durumComboBox.FormattingEnabled = true;
            this.durumComboBox.Location = new System.Drawing.Point(299, 827);
            this.durumComboBox.Name = "durumComboBox";
            this.durumComboBox.Size = new System.Drawing.Size(202, 37);
            this.durumComboBox.TabIndex = 9;
            // 
            // okumaTarihiDateTimePicker
            // 
            this.okumaTarihiDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.kitaplarBindingSource, "OkumaTarihi", true));
            this.okumaTarihiDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.okumaTarihiDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.okumaTarihiDateTimePicker.Location = new System.Drawing.Point(299, 768);
            this.okumaTarihiDateTimePicker.Name = "okumaTarihiDateTimePicker";
            this.okumaTarihiDateTimePicker.Size = new System.Drawing.Size(202, 34);
            this.okumaTarihiDateTimePicker.TabIndex = 11;
            // 
            // ozetTextBox
            // 
            this.ozetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kitaplarBindingSource, "Ozet", true));
            this.ozetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ozetTextBox.Location = new System.Drawing.Point(691, 586);
            this.ozetTextBox.Multiline = true;
            this.ozetTextBox.Name = "ozetTextBox";
            this.ozetTextBox.Size = new System.Drawing.Size(429, 260);
            this.ozetTextBox.TabIndex = 13;
            // 
            // kitaplarTableAdapter
            // 
            this.kitaplarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.kitaplarTableAdapter = this.kitaplarTableAdapter;
            this.tableAdapterManager.UpdateOrder = book_app1._0.kitaplar_databaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1443, 1055);
            this.Controls.Add(ozetLabel);
            this.Controls.Add(this.ozetTextBox);
            this.Controls.Add(okumaTarihiLabel);
            this.Controls.Add(this.okumaTarihiDateTimePicker);
            this.Controls.Add(durumLabel);
            this.Controls.Add(this.durumComboBox);
            this.Controls.Add(kategoriLabel);
            this.Controls.Add(this.kategoriComboBox);
            this.Controls.Add(yazarLabel);
            this.Controls.Add(this.yazarTextBox);
            this.Controls.Add(kitapAdiLabel);
            this.Controls.Add(this.kitapAdiTextBox);
            this.Controls.Add(this.kitaplarDataGridView);
            this.Controls.Add(this.kitaplarBindingNavigator);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingNavigator)).EndInit();
            this.kitaplarBindingNavigator.ResumeLayout(false);
            this.kitaplarBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplar_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private kitaplar_databaseDataSet kitaplar_databaseDataSet;
        private System.Windows.Forms.BindingSource kitaplarBindingSource;
        private kitaplar_databaseDataSetTableAdapters.kitaplarTableAdapter kitaplarTableAdapter;
        private kitaplar_databaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator kitaplarBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton kitaplarBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView kitaplarDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox kitapAdiTextBox;
        private System.Windows.Forms.TextBox yazarTextBox;
        private System.Windows.Forms.ComboBox kategoriComboBox;
        private System.Windows.Forms.ComboBox durumComboBox;
        private System.Windows.Forms.DateTimePicker okumaTarihiDateTimePicker;
        private System.Windows.Forms.TextBox ozetTextBox;
    }
}

