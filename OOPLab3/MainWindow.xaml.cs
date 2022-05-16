using OOPLab3.Classes;
using System;
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
        TransportList transportList = new TransportList();
        public MainWindow()
        {
            InitializeComponent();
            ChooseTransport.Items.Add(new Car());
            ChooseTransport.Items.Add(new Motorcycle());
            ChooseTransport.Items.Add(new Bicycle());
            ChooseTransport.Items.Add(new Plane());
            ChooseTransport.Items.Add(new Ship());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Type type = ChooseTransport.SelectedItem.GetType();
            Transport t = (Transport)Activator.CreateInstance(type);
            if (t != null)
            {
                t.CurrentSpeed = Convert.ToInt32(AddCurrentSpeed.Text);
                t.CurrentCountOfPassengers = Convert.ToInt32(AddCurrentPassengers.Text);
                t.Power = Convert.ToInt32(AddPower.Text);
                t.PetName = AddName.Text;
            }
            transportList.Add(t);
            ShowTransports.Items.Clear();
            foreach (Transport tr in transportList)
                ShowTransports.Items.Add(tr.ShowInfo());
        }

        private void Serialize_Click(object sender, RoutedEventArgs e)
        {
            JsonSerializator s = new JsonSerializator();
            File.WriteAllText(FileToSerialize.Text, s.Serialize(transportList));
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            transportList.Remove(transportList.Get(ShowTransports.SelectedIndex));
            ShowTransports.Items.Clear();
            foreach (Transport tr in transportList)
                ShowTransports.Items.Add(tr.ShowInfo());
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            Transport t = transportList.Get(ShowTransports.SelectedIndex);
            t.CurrentCountOfPassengers = Convert.ToInt32(EditCurrentPassengers.Text);
            t.CurrentSpeed = Convert.ToInt32(EditCurrentSpeed.Text);
            t.Power = Convert.ToInt32(EditPower.Text);
            t.PetName = EditName.Text;
            ShowTransports.Items.Clear();
            foreach (Transport tr in transportList)
                ShowTransports.Items.Add(tr.ShowInfo());
        }

        private void Deserialize_Click(object sender, RoutedEventArgs e)
        {
            JsonSerializator s = new JsonSerializator();
            TransportList tmp = s.Deserialize(File.ReadAllText(FileToDeserialize.Text));
            foreach (Transport tr in tmp)
                transportList.Add(tr);
            ShowTransports.Items.Clear();
            foreach (Transport tr in transportList)
                ShowTransports.Items.Add(tr.ShowInfo());
        }
    }
}
