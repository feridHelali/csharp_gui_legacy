using Core.Models;
using Core.Services;
using DataAccess;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LegacySystem;

public partial class UpdateCarForm : Form
{
    private readonly CarServices _carServices;
    private readonly SqlDataAccess _sqlDataAccess;
    public UpdateCarForm(IServiceProvider serviceProvider)
    {
        _sqlDataAccess = serviceProvider.GetRequiredService<SqlDataAccess>();
        _carServices = serviceProvider.GetRequiredService<CarServices>();
        InitializeComponent();
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        Car car = _carServices.GetCarById(int.Parse(IdtextBox.Text));
        if (car is null)
        {
            MessageBox.Show($"Car with Id {IdtextBox.Text} not found");
        }
        else
        {
            carNameTextBox.Text = car.Name;
            descriptionTextBox.Text = car.Description;
            priceTextBox.Text = car.Price.ToString();
        }
    }

    private void btnSaveCar_Click(object sender, EventArgs e)
    {

        Car car = new Car
        {
            Id = int.Parse(IdtextBox.Text),
            Name = carNameTextBox.Text,
            Description = descriptionTextBox.Text,
            Price = double.Parse(priceTextBox.Text),
        };

        var result = _carServices.UpdateCar(car);
        if (!result)
        {
            MessageBox.Show("Error Occured While Updating TheCar");
            Close();
        }
        else
        {
            MessageBox.Show("Successfully Updated TheCar");
            Close();
        }
    }
}

