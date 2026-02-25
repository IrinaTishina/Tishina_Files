using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Управление_проектами
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void управлениеПроектамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            управлениеПроектамиToolStripMenuItem.ForeColor = Color.Black;
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            управлениеПроектамиToolStripMenuItem.ForeColor = Color.White;
            отчетыToolStripMenuItem.ForeColor = Color.White;
            ещеToolStripMenuItem.ForeColor = Color.White;
        }

        private void отчетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            отчетыToolStripMenuItem.ForeColor = Color.Black;
        }

        private void ещеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ещеToolStripMenuItem.ForeColor = Color.Black;
        }

        private void проектыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.l = 1;
            Projeck_Management WorkSpace = new Projeck_Management();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void задачи_по_проектамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.l = 2;
            Projeck_Management WorkSpace = new Projeck_Management();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }
        
        private void задачиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.l = 3;
            Projeck_Management WorkSpace = new Projeck_Management();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void подзадачи_по_задачамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.l = 4;
            Projeck_Management WorkSpace = new Projeck_Management();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void риски_по_проектамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.l = 5;
            Projeck_Management WorkSpace = new Projeck_Management();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void рискиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.l = 6;
            Projeck_Management WorkSpace = new Projeck_Management();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void затраты_по_проектамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.l = 7;
            Projeck_Management WorkSpace = new Projeck_Management();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void затратыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.l = 8;
            Projeck_Management WorkSpace = new Projeck_Management();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void отчеты_по_проектамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.l = 9;
            Projeck_Management WorkSpace = new Projeck_Management();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.l = 10;
            Projeck_Management WorkSpace = new Projeck_Management();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void должностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.l = 11;
            Projeck_Management WorkSpace = new Projeck_Management();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.l = 12;
            Projeck_Management WorkSpace = new Projeck_Management();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void подзадачиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.l = 13;
            Projeck_Management WorkSpace = new Projeck_Management();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void labelClose1_MouseEnter(object sender, EventArgs e)
        {
            labelClose1.ForeColor = Color.DarkSlateBlue;
        }

        private void labelClose1_MouseLeave(object sender, EventArgs e)
        {
            labelClose1.ForeColor = Color.White;
        }
        private void labelClose1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
