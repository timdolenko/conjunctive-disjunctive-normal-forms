using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDM_Lab_3
{
    public partial class ResultsScreen : Form
    {
        Formula formula;
        public ResultsScreen(Formula formula)
        {
            InitializeComponent();
            this.formula = formula;
            fillGrid();
            this.pdnfLbl.Text = "PDNF: " + formula.principalDisjunctiveNormalForm;
            this.pcnfLbl.Text = "PCNF: " + formula.principalConjunctiveNormalForm;
        }

        void fillGrid()
        {
            dataGridView.ColumnCount = formula.truthTable.Count;
            dataGridView.RowHeadersVisible = false;
            dataGridView.ScrollBars = ScrollBars.None;
            int dataGridViewWidth = 3;

            for (int i = 0; i < formula.truthTable.Count; i++)
            {
                int columnWith = formula.truthTable[i].stringDesc.Length > 2 ? formula.truthTable[i].stringDesc.Length * 10 : 20;
                dataGridViewWidth += columnWith;
                dataGridView.Columns[i].Width = columnWith;
                dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView.Columns[i].Name = formula.truthTable[i].stringDesc;
                dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dataGridView.Width = dataGridViewWidth;
            this.Width = dataGridView.Width + 60;
            dataGridView.Height = formula.truthTable.First().truthArray.Length * 20;
            this.Height = dataGridView.Height + 180;

            for (int i = 0; i < formula.truthTable.First().truthArray.Length; i++)
            {
                string[] row = new string[formula.truthTable.Count - 1];
                dataGridView.Rows.Add(row);
                for (int j = 0; j < formula.truthTable.Count; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = formula.truthTable[j].truthArray[i] ? 1 : 0;
                }
                dataGridView.Rows[i].Height = 20;
            }
        }
    }
}
