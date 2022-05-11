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
        public MainWindow()
        {
            InitializeComponent();
            TransportList l = new TransportList();
            Car c = new Car();
            Ship s = new Ship();
            Plane p = new Plane();

            c.PetName = "BMW";
            c.CurrentSpeed = 50;
            c.CurrentCountOfPassengers = 1;
            c.Power = 5;

            s.PetName = "ZAluPa";
            s.CurrentSpeed = 21;
            s.CurrentCountOfPassengers = 9;
            s.Power = 10;

            p.PetName = "Boing";
            p.CurrentSpeed = 370;
            p.CurrentCountOfPassengers = 20;
            p.Power = 15;

            l.Add(c);
            l.Add(s);
            l.Add(p);

            JsonSerializator serializator = new JsonSerializator();
            string json = serializator.Serialize(l);
            MessageBox.Show(serializator.Serialize(l));
            TransportList l2 = serializator.Deserialize(json);
            foreach (Transport t in l2)
                MessageBox.Show(t.Move());
        }
    }
}
