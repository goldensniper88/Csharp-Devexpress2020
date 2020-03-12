using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Tile;


namespace Kanban
{
    public partial class frmMain : XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
            InitializeKanbanView();
            datePicker.DateTime = DateTime.Today;
        }

        private void InitializeKanbanView()
        {
            tileView.OptionsTiles.IndentBetweenGroups = 20;
            tileView.OptionsBehavior.AllowSmoothScrolling = true;
            tileView.OptionsBehavior.EditingMode = TileViewEditingMode.EditForm;
            tileView.OptionsDragDrop.AllowDrag = true;
            tileView.OptionsEditForm.CustomEditFormLayout = new KanbanEditControl();
        }

        private void DataTableUpdate()
        {
            dataSet.ViewTable.Clear();
            DateTime startDay = datePicker.DateTime.AddDays(-(int)datePicker.DateTime.DayOfWeek);

            for (int i = 0; i < 7; i ++)
            {
                DateTime current = startDay.AddDays(i);
                String stringDate = current.ToString("ddd(dd.MM)", CultureInfo.CreateSpecificCulture("de-DE"));
                dataSet.ViewTable.AddViewTableRow(i, stringDate, "", "", current, current, "category", 0, "", "");
            }
            DataSet.ViewTableRow row = dataSet.ViewTable.NewViewTableRow();

            row.DayofWeek = 7;
            row.Category = "";
            row.GroupTitle = "To Do";
            dataSet.ViewTable.AddViewTableRow(row);
            

        }

        private void tileView_ItemCustomize(object sender, TileViewItemCustomizeEventArgs e)
        {
            DataRowView obj = tileView.GetRow(e.RowHandle) as DataRowView;
            if (obj == null) return;
            DataSet.ViewTableRow row = obj.Row as DataSet.ViewTableRow;
            if (row == null) return;
            
            e.Item["Category"].Appearance.Normal.BackColor = GetCategoryColor(row.Category);
        }

        private void datePicker_DateTimeChanged(object sender, EventArgs e)
        {
            DataTableUpdate();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //tileView.ShowEditor();
            DateTime startDay = datePicker.DateTime;
            int weekday = (int)datePicker.DateTime.DayOfWeek;
            String stringDate = startDay.ToString("ddd(dd.MM)", CultureInfo.CreateSpecificCulture("de-DE"));
            
            XtraForm1 editform = new XtraForm1();
            if (editform.ShowDialog() == DialogResult.OK)
            {

                String strHeadline = editform.Headline;
                String strMilestone = editform.Milestone;
                String strCustomer = editform.Customer;
                String strTechnican = editform.Technican;
                DateTime dtEndDate = editform.EndDate;
                DateTime dtDueDate = editform.DueDate;
                int numID = editform.ID;
                String strCategory = editform.Category;
                dataSet.ViewTable.AddViewTableRow(weekday, stringDate, strHeadline, strMilestone, dtDueDate, dtEndDate, strCategory, numID, strCustomer, strTechnican);
            }
        }

        public Color GetCategoryColor(String category)
        {
            switch (category)
            {
                case "M": return Color.Green;
                case "C": return Color.Red;
                case "D": return Color.Yellow;
                case "S": return Color.Blue;
                case "X": return Color.Black;
                default: return Color.Empty;
            }
        }

        private void tileView_ItemDrop(object sender, ItemDropEventArgs e)
        {
            var newStatus = e.GroupColumnValue;
            var prevStatus = e.PrevGroupColumnValue;
            if (!prevStatus.Equals(newStatus))
            {
                tileView.BeginDataUpdate();
                var rowtest = dataSet.ViewTable.FirstOrDefault(x => x.GroupTitle == prevStatus.ToString());
                if (rowtest == null)
                {
                    DataRowView objprev = tileView.GetRow(e.RowHandle) as DataRowView;
                    if (objprev == null) return;
                    DataSet.ViewTableRow rowprev = objprev.Row as DataSet.ViewTableRow;
                    if (rowprev == null) return;
                    string prevtitle = prevStatus as string;
                    DateTime dateprev = DateTime.ParseExact(prevtitle, "ddd(dd.MM)", new CultureInfo("de-DE"));
                    rowprev.GroupTitle = prevtitle;
                    dataSet.ViewTable.AddViewTableRow(rowprev.DayofWeek , rowprev.GroupTitle, "", "", rowprev.DueDate, rowprev.EndDate, "category", 0, "", "");
                }

                DataRowView obj = tileView.GetRow(e.RowHandle) as DataRowView;
                if (obj == null) return;
                DataSet.ViewTableRow row = obj.Row as DataSet.ViewTableRow;
                if (row == null) return;

                string title = newStatus as string;
                DateTime date = DateTime.ParseExact(title, "ddd(dd.MM)", new CultureInfo("de-DE"));
                row.DueDate = date;
                row.DayofWeek = (int)date.DayOfWeek;
                row.GroupTitle = title;

                tileView.EndDataUpdate();
            }
        }

        
    }
}
