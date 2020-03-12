namespace Kanban
{
    partial class frmMain
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
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition3 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition4 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition5 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition3 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition4 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan1 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement4 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement5 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement6 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement7 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement8 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.colHeadline = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colMilestone = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colDueDate = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colEndDate = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colCategory = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colCustomer = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colTechnican = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colID = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.datePicker = new DevExpress.XtraEditors.DateEdit();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.viewTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new Kanban.DataSet();
            this.tileView = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.colDayofWeek = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colGroupTitle = new DevExpress.XtraGrid.Columns.TileViewColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datePicker.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePicker.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView)).BeginInit();
            this.SuspendLayout();
            // 
            // colHeadline
            // 
            this.colHeadline.FieldName = "Headline";
            this.colHeadline.Name = "colHeadline";
            this.colHeadline.Visible = true;
            this.colHeadline.VisibleIndex = 2;
            // 
            // colMilestone
            // 
            this.colMilestone.FieldName = "Milestone";
            this.colMilestone.Name = "colMilestone";
            this.colMilestone.Visible = true;
            this.colMilestone.VisibleIndex = 3;
            // 
            // colDueDate
            // 
            this.colDueDate.FieldName = "DueDate";
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.Visible = true;
            this.colDueDate.VisibleIndex = 4;
            // 
            // colEndDate
            // 
            this.colEndDate.FieldName = "EndDate";
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.Visible = true;
            this.colEndDate.VisibleIndex = 5;
            // 
            // colCategory
            // 
            this.colCategory.FieldName = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.Visible = true;
            this.colCategory.VisibleIndex = 6;
            // 
            // colCustomer
            // 
            this.colCustomer.FieldName = "Customer";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.Visible = true;
            this.colCustomer.VisibleIndex = 8;
            // 
            // colTechnican
            // 
            this.colTechnican.FieldName = "Technican";
            this.colTechnican.Name = "colTechnican";
            this.colTechnican.Visible = true;
            this.colTechnican.VisibleIndex = 9;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 7;
            // 
            // datePicker
            // 
            this.datePicker.EditValue = null;
            this.datePicker.Location = new System.Drawing.Point(39, 37);
            this.datePicker.Name = "datePicker";
            this.datePicker.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datePicker.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datePicker.Size = new System.Drawing.Size(100, 20);
            this.datePicker.TabIndex = 0;
            this.datePicker.DateTimeChanged += new System.EventHandler(this.datePicker_DateTimeChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(145, 35);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // gridControl
            // 
            this.gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl.DataSource = this.viewTableBindingSource;
            this.gridControl.Location = new System.Drawing.Point(12, 64);
            this.gridControl.MainView = this.tileView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(1103, 479);
            this.gridControl.TabIndex = 2;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView});
            // 
            // viewTableBindingSource
            // 
            this.viewTableBindingSource.DataMember = "ViewTable";
            this.viewTableBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tileView
            // 
            this.tileView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDayofWeek,
            this.colGroupTitle,
            this.colHeadline,
            this.colMilestone,
            this.colDueDate,
            this.colEndDate,
            this.colCategory,
            this.colID,
            this.colCustomer,
            this.colTechnican});
            this.tileView.ColumnSet.GroupColumn = this.colGroupTitle;
            this.tileView.GridControl = this.gridControl;
            this.tileView.Name = "tileView";
            this.tileView.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.Kanban;
            this.tileView.OptionsTiles.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top;
            this.tileView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colGroupTitle, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDayofWeek, DevExpress.Data.ColumnSortOrder.Ascending)});
            tableColumnDefinition1.Length.Value = 8D;
            tableColumnDefinition2.Length.Value = 76D;
            tableColumnDefinition3.Length.Value = 64D;
            tableColumnDefinition4.Length.Value = 40D;
            tableColumnDefinition5.Length.Value = 36D;
            this.tileView.TileColumns.Add(tableColumnDefinition1);
            this.tileView.TileColumns.Add(tableColumnDefinition2);
            this.tileView.TileColumns.Add(tableColumnDefinition3);
            this.tileView.TileColumns.Add(tableColumnDefinition4);
            this.tileView.TileColumns.Add(tableColumnDefinition5);
            this.tileView.TileRows.Add(tableRowDefinition1);
            this.tileView.TileRows.Add(tableRowDefinition2);
            this.tileView.TileRows.Add(tableRowDefinition3);
            this.tileView.TileRows.Add(tableRowDefinition4);
            tableSpan1.RowSpan = 4;
            this.tileView.TileSpans.Add(tableSpan1);
            tileViewItemElement1.Column = this.colHeadline;
            tileViewItemElement1.ColumnIndex = 1;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement1.Text = "colHeadline";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.Column = this.colMilestone;
            tileViewItemElement2.ColumnIndex = 1;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement2.RowIndex = 1;
            tileViewItemElement2.Text = "colMilestone";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.Column = this.colDueDate;
            tileViewItemElement3.ColumnIndex = 1;
            tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement3.RowIndex = 3;
            tileViewItemElement3.Text = "colDueDate";
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.Column = this.colEndDate;
            tileViewItemElement4.ColumnIndex = 2;
            tileViewItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement4.RowIndex = 3;
            tileViewItemElement4.Text = "colEndDate";
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement5.Appearance.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            tileViewItemElement5.Appearance.Normal.Options.UseBackColor = true;
            tileViewItemElement5.Column = this.colCategory;
            tileViewItemElement5.StretchVertical = true;
            tileViewItemElement5.Text = "colCategory";
            tileViewItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement5.TextLocation = new System.Drawing.Point(-15, 0);
            tileViewItemElement5.TextVisible = false;
            tileViewItemElement5.Width = 8;
            tileViewItemElement6.Column = this.colCustomer;
            tileViewItemElement6.ColumnIndex = 1;
            tileViewItemElement6.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement6.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement6.RowIndex = 2;
            tileViewItemElement6.Text = "colCustomer";
            tileViewItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement7.Column = this.colTechnican;
            tileViewItemElement7.ColumnIndex = 2;
            tileViewItemElement7.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement7.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement7.RowIndex = 2;
            tileViewItemElement7.Text = "colTechnican";
            tileViewItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement8.Column = this.colID;
            tileViewItemElement8.ColumnIndex = 4;
            tileViewItemElement8.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement8.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement8.RowIndex = 3;
            tileViewItemElement8.Text = "colID";
            tileViewItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileView.TileTemplate.Add(tileViewItemElement1);
            this.tileView.TileTemplate.Add(tileViewItemElement2);
            this.tileView.TileTemplate.Add(tileViewItemElement3);
            this.tileView.TileTemplate.Add(tileViewItemElement4);
            this.tileView.TileTemplate.Add(tileViewItemElement5);
            this.tileView.TileTemplate.Add(tileViewItemElement6);
            this.tileView.TileTemplate.Add(tileViewItemElement7);
            this.tileView.TileTemplate.Add(tileViewItemElement8);
            this.tileView.ItemDrop += new DevExpress.XtraGrid.Views.Tile.TileViewItemDropEventHandler(this.tileView_ItemDrop);
            this.tileView.ItemCustomize += new DevExpress.XtraGrid.Views.Tile.TileViewItemCustomizeEventHandler(this.tileView_ItemCustomize);
            // 
            // colDayofWeek
            // 
            this.colDayofWeek.FieldName = "DayofWeek";
            this.colDayofWeek.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDayofWeek.Name = "colDayofWeek";
            this.colDayofWeek.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colDayofWeek.Visible = true;
            this.colDayofWeek.VisibleIndex = 0;
            // 
            // colGroupTitle
            // 
            this.colGroupTitle.FieldName = "GroupTitle";
            this.colGroupTitle.FieldNameSortGroup = "DayofWeek";
            this.colGroupTitle.Name = "colGroupTitle";
            this.colGroupTitle.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colGroupTitle.Visible = true;
            this.colGroupTitle.VisibleIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 555);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.datePicker);
            this.Name = "frmMain";
            this.Text = "Kanban board";
            ((System.ComponentModel.ISupportInitialize)(this.datePicker.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePicker.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit datePicker;
        private DevExpress.XtraEditors.SimpleButton btnCreate;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView;
        private System.Windows.Forms.BindingSource viewTableBindingSource;
        private DataSet dataSet;
        private DevExpress.XtraGrid.Columns.TileViewColumn colDayofWeek;
        private DevExpress.XtraGrid.Columns.TileViewColumn colGroupTitle;
        private DevExpress.XtraGrid.Columns.TileViewColumn colHeadline;
        private DevExpress.XtraGrid.Columns.TileViewColumn colMilestone;
        private DevExpress.XtraGrid.Columns.TileViewColumn colDueDate;
        private DevExpress.XtraGrid.Columns.TileViewColumn colEndDate;
        private DevExpress.XtraGrid.Columns.TileViewColumn colCategory;
        private DevExpress.XtraGrid.Columns.TileViewColumn colID;
        private DevExpress.XtraGrid.Columns.TileViewColumn colCustomer;
        private DevExpress.XtraGrid.Columns.TileViewColumn colTechnican;
    }
}

