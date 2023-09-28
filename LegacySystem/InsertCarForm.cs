using Core;
using Core.Models;
using Core.Services;
using DataAccess;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LegacySystem
{
    public partial class InsertCarForm : Form
    {
        private readonly CarServices _carServices;
        private readonly SqlDataAccess _sqlDataAccess;
        public InsertCarForm(IServiceProvider serviceProvider)
        {
            _sqlDataAccess = serviceProvider.GetRequiredService<SqlDataAccess>();
            _carServices = serviceProvider.GetRequiredService<CarServices>();

            InitializeComponent();
        }

        private void btnSaveCar_Click(object sender, EventArgs e)
        {
            var _price = double.Parse(priceTextBox.Text);
            var newCar = new Car
            {
                Name = carNameTextBox.Text,
                Description = descriptionTextBox.Text,
                Price = _price
            };

            try
            {
                var result = _carServices.InsertCar(newCar);
                if (result > 0)
                {
                    MessageBox.Show("New Car Added Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
