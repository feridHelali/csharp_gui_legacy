using Core;
using Core.Services;
using DataAccess;
using Microsoft.Extensions.DependencyInjection;

namespace LegacySystem
{
    public partial class Main : Form
    {

        private IServiceProvider _services;
        public Main(IServiceProvider service)
        {
            _services = service;
            InitializeComponent();
        }

        private void carListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarListForm carListForm = new CarListForm(_services);
            carListForm.MdiParent = this;
            carListForm.Show();
        }

        private void addNewCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertCarForm carForm = new InsertCarForm(_services);
            carForm.MdiParent = this;
            carForm.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Quit.", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                Application.Exit();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UpdateCarForm updateCarForm = new UpdateCarForm(_services);
            updateCarForm.MdiParent = this;
            updateCarForm.Show();
        }
    }
}