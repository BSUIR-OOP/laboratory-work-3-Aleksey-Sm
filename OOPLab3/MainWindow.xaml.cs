using OOPLab3.Classes;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using System.Windows;

namespace OOPLab3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VehicleList l;
        public MainWindow()
        {
            InitializeComponent();
            CBChooseVehicle.Items.Add(new Truck());
            CBChooseVehicle.Items.Add(new Sportcar());
            CBChooseVehicle.Items.Add(new Minivan());
            CBChooseVehicle.Items.Add(new Autobus());
            CBChooseVehicle.Items.Add(new Sportbyke());
            CBChooseVehicle.Items.Add(new Chopper());
            l = new VehicleList();
           /* l.Add(new Truck(300, "VAZ"));
            l.Add(new Minivan(100, "Minivan"));
            l.ElementAt(0).SpeedUp(50);
            l.ElementAt(0).GetInfo();
            using (var stream = File.Open("vehicles.json", FileMode.Create))
            {
                using (var writer = JsonReaderWriterFactory.CreateJsonWriter(stream, Encoding.UTF8, true, true, "  "))
                {
                    var serializer = new DataContractJsonSerializer(typeof(List<Vehicle>));
                    serializer.WriteObject(writer, l.GetMembers());
                    writer.Flush();
                }
            }

            using (var stream = File.OpenRead("vehicles.json"))
            {
                var serializer = new DataContractJsonSerializer(typeof(List<Vehicle>));
                List<Vehicle> l2 = new List<Vehicle>();
                l2 = (List<Vehicle>)serializer.ReadObject(stream);
                foreach (Vehicle v in l2)
                    v.GetInfo();
            } */
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Vehicle vehicle = CBChooseVehicle.SelectedItem as Vehicle;
            vehicle.maxSpeed = 300;
            vehicle.Name = "Vaz";
            MessageBox.Show(vehicle.GetInfo());
        }
    }
}
