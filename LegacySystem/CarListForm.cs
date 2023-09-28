
using Core.Models;
using Core.Services;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using Core;
using Microsoft.Extensions.DependencyInjection;

namespace LegacySystem;

public partial class CarListForm : Form
{
    private List<Car> cars = new List<Car>();
    private BindingSource bindingSource = new BindingSource();
    private readonly CarServices _carServices;
    private readonly SqlDataAccess _sqlDataAccess;
    public CarListForm(IServiceProvider serviceProvider)
    {
        _sqlDataAccess = serviceProvider.GetRequiredService<SqlDataAccess>();
        _carServices = serviceProvider.GetRequiredService<CarServices>();

        LoadCars();
        InitializeComponent();
        bindingSource.DataSource = cars;
        CarGridView.DataSource = cars;
    }

    public void LoadCars()
    {
        var _tmpCars = _carServices.GetAllCars();
        foreach (var _tc in _tmpCars)
        {
            cars.Add(_tc);
        }
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        var selected = CarGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
        if (selected == 1)
        {
            var carId = CarGridView.SelectedRows[selected];

            MessageBox.Show(carId.ToString());
        }
    }
}
