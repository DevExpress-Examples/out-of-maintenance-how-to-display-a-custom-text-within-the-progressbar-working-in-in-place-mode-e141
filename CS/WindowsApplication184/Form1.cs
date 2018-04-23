using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;

namespace FormatProgressBarText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateNodes(treeList1);
            repositoryItemProgressBar1.ShowTitle = true;
            repositoryItemProgressBar1.Appearance.Options.UseFont = true;
            repositoryItemProgressBar1.Appearance.Font = new Font(repositoryItemProgressBar1.Appearance.Font, FontStyle.Bold);
            repositoryItemProgressBar1.Appearance.Options.UseTextOptions = true;
            repositoryItemProgressBar1.Appearance.TextOptions.HAlignment = HorzAlignment.Near;
        }

        private void treeList1_CustomDrawNodeCell(object sender, DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs e)
        {
            if (e.Column.ColumnEdit != null && e.Column.ColumnEdit.GetType() == typeof(RepositoryItemProgressBar))
            {
                string val = e.Node[e.Column].ToString();
                e.CellText = "The progress is: " + val + "%";
                e.Appearance.Options.UseFont = true;
                e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                e.Appearance.Options.UseTextOptions = true;
                e.Appearance.TextOptions.HAlignment = HorzAlignment.Near;
                ((DevExpress.XtraEditors.ViewInfo.ProgressBarViewInfo)(e.EditViewInfo)).CalcViewInfo(e.Graphics);
            }

        }

        private void CreateNodes(DevExpress.XtraTreeList.TreeList tl)
        {
            tl.BeginUnboundLoad();
            for (int i = 0; i < 10; i++)
            {
                tl.AppendNode(new object[] { "Item" + i, i * 10 }, -1, 0, 0, -1);
                tl.EndUnboundLoad();
            }
        }

        private void repositoryItemProgressBar1_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            string val = e.Value.ToString();
            e.DisplayText = "The progress is: " + val;
        }
    }
}