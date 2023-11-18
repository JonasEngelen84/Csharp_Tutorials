using System.Windows;

namespace Dependency_Properties
{
    public partial class MainWindow : Window
    {
        public int MyProperty
        {
            // Für die Beziehung zur Dependency Property muss diese hier einbezogen werden.
            get { return (int)GetValue(myDependencyProperty); }
            set { SetValue(myDependencyProperty, value); }
        }

        // Die Dependency Property muss registriert werden.
        // Hierbei muss der Name der Property und ihr Datentyp,
        // sowie die Klasse angegeben werden.
        // wenn Metadaten mit zu übergeben sind, werden die als
        // "new PropertyMetadat(Anzahl der Daten)" übergeben.
        public static readonly DependencyProperty myDependencyProperty =
            DependencyProperty.Register("MyProperty", typeof(int), typeof(MainWindow));


        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
