using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using PlantLib;

namespace PlantApp;

public partial class MainWindow : Window
{
    private readonly ObservableCollection<Plant> plants = new();

    public MainWindow()
    {
        InitializeComponent();
        PlantList.ItemsSource = plants;
    }

    private void KindBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (ExtraLabel == null)
        {
            return;
        }
        ExtraLabel.Text = KindBox.SelectedIndex switch
        {
            0 => "Вік",
            1 => "Колір",
            _ => "Висота"
        };
    }

    private void Add_Click(object sender, RoutedEventArgs e)
    {
        string name = NameBox.Text.Trim();
        string type = TypeBox.Text.Trim();
        string place = PlaceBox.Text.Trim();
        string extra = ExtraBox.Text.Trim();

        if (name == "" || type == "" || place == "" || extra == "")
        {
            MessageBox.Show("Заповніть усі поля");
            return;
        }

        if (KindBox.SelectedIndex == 0)
        {
            if (!int.TryParse(extra, out int age) || age < 0)
            {
                MessageBox.Show("Вік має бути цілим числом не менше 0");
                return;
            }
            plants.Add(new Tree(name, type, place, age));
        }
        else if (KindBox.SelectedIndex == 1)
        {
            plants.Add(new Flower(name, type, place, extra));
        }
        else
        {
            if (!int.TryParse(extra, out int height) || height < 0)
            {
                MessageBox.Show("Висота має бути цілим числом не менше 0");
                return;
            }
            plants.Add(new Shrub(name, type, place, height));
        }

        AverageText.Text = $"Середній вік дерев: {PlantCalculator.GetAverageTreeAge(plants):F1}";
        MaxBloomText.Text = $"Найдовше цвітіння: {PlantCalculator.GetMaxBloomDuration(plants)} дн.";

        NameBox.Clear();
        TypeBox.Clear();
        PlaceBox.Clear();
        ExtraBox.Clear();
    }

    private void Water_Click(object sender, RoutedEventArgs e)
    {
        if (PlantList.SelectedItem is Plant plant)
        {
            MessageBox.Show(plant.Water());
        }
        else
        {
            MessageBox.Show("Оберіть рослину зі списку");
        }
    }

    private void PlantIt_Click(object sender, RoutedEventArgs e)
    {
        if (PlantList.SelectedItem is Plant plant)
        {
            MessageBox.Show(plant.PlantIt());
        }
        else
        {
            MessageBox.Show("Оберіть рослину зі списку");
        }
    }
}
