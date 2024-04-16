using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Service.Backend.Repository;

namespace Service
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var context = new ApplicationDbContext();
            _statsRepository = new StatsRepository(context);
            _songRepository = new SongRepository(context);
            _statsService = new StatsService(_statsRepository);
            _songService = new SongService(_songRepository);
            
        }

    }
}
