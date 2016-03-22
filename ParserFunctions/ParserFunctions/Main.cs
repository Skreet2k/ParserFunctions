using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParserFunctions
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
            Graph graph = new Graph(GraphicsPb);
            graph.DrawGrid();
        }

        private void YB_Click(object sender, EventArgs e)
        {
            try
            {
                string func = YTb.Text;
                Function fnc = new Function(func);
                Graph graph = new Graph(GraphicsPb);
                graph.DrawGrid();
                graph.DrawArray(fnc.FunctionToArray(1, 0, GraphicsPb.Width));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void XB_Click(object sender, EventArgs e)
        {
            try
            {
                float y = 0;
                if (XTb.Text == string.Empty)
                {
                    XTb.Text = "1";
                }
                Function fnc = new Function(YTb.Text);
                y = fnc.Parse(YTb.Text, decimal.Parse((XTb.Text)));
                MessageBox.Show("y(x) = " + YTb.Text + ";\n" + "y(" + XTb.Text + ") = " + y + ".");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void сброситьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graph graph = new Graph(GraphicsPb);
            graph.DrawGrid();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
