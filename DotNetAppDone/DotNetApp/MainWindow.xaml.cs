using System.Globalization;
using System.Linq;
using System.Windows;
using Allan.Language.Detection;

namespace DotNetApp
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      public MainWindow()
      {
         InitializeComponent();
      }

      private void Button_Click( object sender, RoutedEventArgs e )
      {
         var languages = Detector.DetectLanguage( inputTextBox.Text );
         var topLanguage = languages.OrderBy( l => l.Distance ).First();
         var langString = new CultureInfo( topLanguage.Language.Code ).DisplayName;

         languageTextBox.Content = langString;
      }
   }
}
