using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;


namespace Kanban
{
    public partial class KanbanEditControl : EditFormUserControl
    {
        public KanbanEditControl()
        {
            InitializeComponent();
            cmbCategory.Properties.Items.AddRange(new String[]{ "M", "C", "D", "S", "X"});
        }
        public string Headline { get{ return txtHeadline.Text; } }
        public string Milestone  { get { return txtMilestone.Text; } }
        public string Customer { get { return txtCustomer.Text; } }
        public string Technican { get { return txtTechnican.Text; } }
        public DateTime DueDate { get { return dateDue.DateTime; } }
        public DateTime EndDate { get { return dateEnd.DateTime; } }
        public int ID { get { return int.Parse(spinID.Text); } }
        public string Category { get { return cmbCategory.Text;} }
        
    }
}
