using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Threading;
using System.Diagnostics;
using System.Windows.Controls.DataVisualization.Charting;
using LiveCharts;
using LiveCharts.Helpers;
using LiveCharts.Wpf;
using LineSeries = LiveCharts.Wpf.LineSeries;
using Arction.Wpf.Charting;             // LightningChartUltimate and general types.
using Arction.Wpf.Charting.SeriesXY;

namespace Sortowanie_Projekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        #region generowanie liczb


        public int[] Losuj()
        {
            int[] numbers = new int[20000];
            for (int i = 0; i < 20000; i++)
            {
                Random random = new Random();
                numbers[i] = random.Next();
            }

            return numbers;
        }

        public short[] shortLosuj()
        {
            short[] numbers = new short[20000];
            for (int i = 0; i < 20000; i++)
            {
                Random random = new Random();
                numbers[i] = (short)random.Next(-32000,32000);
            }

            return numbers;
        }

        public float[] floatLosuj()
        {
            float[] numbers = new float[20000];
            for (int i = 0; i < 20000; i++)
            {
                Random random = new Random();
                numbers[i] = random.Next();
            }

            return numbers;
        }

                          
        public int[] Rosnace()
        {
            int[] numbers = new int[20000];
            for (int i = 0; i < 20000; i++)
            {
                numbers[i] = i;
            }

            return numbers;
        }

        public short[] shortRosnace()
        {
            short[] numbers = new short[20000];
            for (int i = 0; i < 20000; i++)
            {
                numbers[i] = (short)i;
            }

            return numbers;
        }

        public float[] floatRosnace()
        {
            float[] numbers = new float[20000];
            for (int i = 0; i < 20000; i++)
            {
                numbers[i] = i;
            }

            return numbers;
        }
                   

        public int[] Malejace()
        {
            int[] numbers = new int[20000];
            for (int i = 0; i < 20000; i++)
            {
                numbers[i] = 20000-i;
            }

            return numbers;
        }

        public short[] shortMalejace()
        {
            short[] numbers = new short[20000];
            for (int i = 0; i < 20000; i++)
            {
                int a = 20000 - i;
                numbers[i] = (short)a;
            }

            return numbers;
        }

        public float[] floatMalejace()
        {
            float[] numbers = new float[20000];
            for (int i = 0; i < 20000; i++)
            {
                numbers[i] = 20000 - i;
            }

            return numbers;
        }

          
        public int[] Stale()
        {
            int[] numbers = new int[20000];
            for (int i = 0; i < 20000; i++)
            {
                numbers[i] = 10000;
            }

            return numbers;
        }

        public short[] shortStale()
        {
            short[] numbers = new short[20000];
            for (int i = 0; i < 20000; i++)
            {
                numbers[i] = 10000;
            }

            return numbers;
        }

        public float[] floatStale()
        {
            float[] numbers = new float[20000];
            for (int i = 0; i < 20000; i++)
            {
                numbers[i] = 10000;
            }

            return numbers;
        }
                              
        public int[] Vksztaltne()
        {
            int[] numbers = new int[20000];
            for (int i = 0; i < 10000; i++)
            {
                numbers[i] = 10000-i;
            }
            for (int i = 10000; i < 20000; i++)
            {
                numbers[i] = i;
            }
            return numbers;
        }

        public short[] shortVksztaltne()
        {
            short[] numbers = new short[20000];
            for (int i = 0; i < 10000; i++)
            {
                int b = 10000 - i;
                numbers[i] = (short)b;
            }
            for (int i = 10000; i < 20000; i++)
            {

                numbers[i] = (short)i;
            }
            return numbers;
        }

        public float[] floatVksztaltne()
        {
            float[] numbers = new float[20000];
            for (int i = 0; i < 10000; i++)
            {
                numbers[i] = 10000 - i;
            }
            for (int i = 10000; i < 20000; i++)
            {
                numbers[i] = i;
            }
            return numbers;
        }            

        public float InserSort(int[] numbers, int a)
        {                                      
            InsertionSort.InsertionSortALG(numbers);
            return new float();
        }

        public float floatInserSort(float[] numbers, int a)
        {
            InsertionSort.floatInsertionSortALG(numbers);
            return new float();
        }

        public float shortInserSort(short[] numbers, int a)
        {
            InsertionSort.shortInsertionSortALG(numbers);
            return new float();
        }

                             
        public float SelectSort(int[] numbers, int a)
        {           
            SelectionSort.Count(numbers,a);   
            return new float();    
        }

        public float shortSelectSort(short[] numbers, int a)
        {
            SelectionSort.shortCount(numbers, a);
            return new float();
        }

        public float floatSelectSort(float[] numbers, int a)
        {
            SelectionSort.floatCount(numbers, a);
            return new float();
        }
                                                      
        public float HeapSort(int[] numbers, int a)
        {
            Sortowanie_Projekt.HeapSort.heapSorting(numbers,a);
         
            return new float();
        }

        public float shortHeapSort(short[] numbers, int a)
        {
            Sortowanie_Projekt.HeapSort.shortheapSorting(numbers, a);

            return new float();
        }

        public float floatHeapSort(float[] numbers, int a)
        {
            Sortowanie_Projekt.HeapSort.floatheapSorting(numbers, a);

            return new float();
        }
                   
        public float CoctailSort(int[] numbers, int a)
        {
           Sortowanie_Projekt.CoctailSort.cocktailSort(numbers);
            return new float();
        }

        public float shortCoctailSort(short[] numbers, int a)
        {
            Sortowanie_Projekt.CoctailSort.shortcocktailSort(numbers);
            return new float();
        }


        public float floatCoctailSort(float[] numbers, int a)
        {
            Sortowanie_Projekt.CoctailSort.floatcocktailSort(numbers);
            return new float();
        }

        #endregion generowanie liczb

        ObservableCollection<KeyValuePair<double, double>> Power = new ObservableCollection<KeyValuePair<double, double>>();

        public void Recursive(int[] ciag)
        {
                RecursiveQuickSork.Example.QuickSortRecursive(ciag, 0, ciag.Length-1);
        }

        public void Iterative(int[] ciag)
        {
            IterativeQuickSork.QuickSortIterative(ciag);
            //RecursiveQuickSork.Example.quickSort(ciag, 0, ciag.Length);
       
        }
        WykresOkno noweokno = new WykresOkno();
        public MainWindow()
        {
            InitializeComponent(); 
            noweokno.Show();   
                       
        }
             
        public void ChartyMaker(float[] times)
        {
            noweokno.RysujWykres(times);
          //  Power.Clear();
           // waitingtasks.DataContext = Power;
            /*Power.Add(new KeyValuePair<double, double>(1, (int)times[0]));
            Power.Add(new KeyValuePair<double, double>(2, (int)times[1]));
            Power.Add(new KeyValuePair<double, double>(3, (int)times[2]));
            Power.Add(new KeyValuePair<double, double>(4, (int)times[3]));
            Power.Add(new KeyValuePair<double, double>(5, (int)times[4]));
            Power.Add(new KeyValuePair<double, double>(6, (int)times[5]));
            Power.Add(new KeyValuePair<double, double>(7, (int)times[6]));
            Power.Add(new KeyValuePair<double, double>(8, (int)times[7]));
            Power.Add(new KeyValuePair<double, double>(9, (int)times[8]));
            Power.Add(new KeyValuePair<double, double>(10, (int)times[9]));
            Power.Add(new KeyValuePair<double, double>(11, (int)times[10]));
            Power.Add(new KeyValuePair<double, double>(12, (int)times[11]));
            Power.Add(new KeyValuePair<double, double>(13, (int)times[12]));
            Power.Add(new KeyValuePair<double, double>(14, (int)times[13]));
            Power.Add(new KeyValuePair<double, double>(15, (int)times[14]));
            Power.Add(new KeyValuePair<double, double>(16, (int)times[15]));*/
            //waitingtasks.DataContext = Power;
        }

   
        public SeriesCollection Series { get; set; }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            int[] longArr = Losuj();
                                    
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                int[] shortArray = new int[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);

                Stopwatch sw = new Stopwatch();
                sw.Start();

                InserSort(shortArray, y * 1000 + 5000);

                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;
             
            }
            ChartyMaker(times);
         

            /*List<Bar> _bar = new List<Bar>();
            _bar.Add(new Bar() { BarName = "50k", Value = (int)times[0] });
            _bar.Add(new Bar() { BarName = "60k", Value = (int)times[1] });
            _bar.Add(new Bar() { BarName = "70k", Value = (int)times[2] });
            _bar.Add(new Bar() { BarName = "80k", Value = (int)times[3] });
            _bar.Add(new Bar() { BarName = "90k", Value = (int)times[4] });
            _bar.Add(new Bar() { BarName = "100k", Value = (int)times[5] });
            _bar.Add(new Bar() { BarName = "110k", Value = (int)times[6] });
            _bar.Add(new Bar() { BarName = "120k", Value = (int)times[7] });
            _bar.Add(new Bar() { BarName = "130k", Value = (int)times[8] });
            _bar.Add(new Bar() { BarName = "140k", Value = (int)times[9] });
            _bar.Add(new Bar() { BarName = "150k", Value = (int)times[10] });
            _bar.Add(new Bar() { BarName = "160k", Value = (int)times[11] });
            _bar.Add(new Bar() { BarName = "170k", Value = (int)times[12] });
            _bar.Add(new Bar() { BarName = "180k", Value = (int)times[13] });
            _bar.Add(new Bar() { BarName = "190k", Value = (int)times[14] });
            _bar.Add(new Bar() { BarName = "200k", Value = (int)times[15] });
            this.DataContext = new RecordCollection(_bar);*/
        }
  
        private void ButtonBase_OnClicka(object sender, RoutedEventArgs e)
        {
       
            short[] longArr = shortLosuj();      
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                short[] shortArray = new short[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);   
                Stopwatch sw = new Stopwatch();
                sw.Start();                        
                shortInserSort(shortArray, y * 1000 + 5000);    
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10; 
            }

         
            ChartyMaker(times);
        }

        private void ButtonBase_OnClickb(object sender, RoutedEventArgs e)
        {
            float[] longArr = floatLosuj();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                float[] shortArray = new float[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                floatInserSort(shortArray, y * 1000 + 5000);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;
            }
            ChartyMaker(times);
        }
        private void ButtonBase_OnClick2(object sender, RoutedEventArgs e)
        {
            int[] longArr = Rosnace();           
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                int[] shortArray = new int[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);    
                Stopwatch sw = new Stopwatch();
                sw.Start();   
                InserSort(shortArray, y * 1000 + 5000); 
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;
            }
            ChartyMaker(times);
        }

        private void ButtonBase_OnClick2a(object sender, RoutedEventArgs e)
        {
            short[] longArr = shortRosnace();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                short[] shortArray = new short[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                shortInserSort(shortArray, y * 1000 + 5000);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;
            }
            ChartyMaker(times);
        }
        private void ButtonBase_OnClick2b(object sender, RoutedEventArgs e)
        {
            float[] longArr = floatRosnace();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                float[] shortArray = new float[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                floatInserSort(shortArray, y * 1000 + 5000);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;
            }
            ChartyMaker(times);
        }

        private void ButtonBase_OnClick3(object sender, RoutedEventArgs e)
        {
            int[] longArr = Malejace();

            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                int[] shortArray = new int[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);

                Stopwatch sw = new Stopwatch();
                sw.Start();

                InserSort(shortArray, y * 1000 + 5000);

                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;

            }


            ChartyMaker(times);
        }

        private void ButtonBase_OnClick3a(object sender, RoutedEventArgs e)
        {                                          
            short[] longArr = shortMalejace();   
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                short[] shortArray = new short[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);  
                Stopwatch sw = new Stopwatch();
                sw.Start();               
                shortInserSort(shortArray, y * 1000 + 5000); 
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;
            }                   
            ChartyMaker(times);
        }

        private void ButtonBase_OnClick3b(object sender, RoutedEventArgs e)
        {
            float[] longArr = floatMalejace();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                float[] shortArray = new float[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                floatInserSort(shortArray, y * 1000 + 5000);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;
            }
            ChartyMaker(times);
        }
        private void ButtonBase_OnClick4(object sender, RoutedEventArgs e)
        {
            int[] longArr = Stale();

            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                int[] shortArray = new int[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);

                Stopwatch sw = new Stopwatch();
                sw.Start();

                InserSort(shortArray, y * 1000 + 5000);

                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;

            }


           ChartyMaker(times);
        }


        private void ButtonBase_OnClick4a(object sender, RoutedEventArgs e)
        {
            
            short[] longArr = shortStale();

            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                short[] shortArray = new short[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);

                Stopwatch sw = new Stopwatch();
                sw.Start();

                shortInserSort(shortArray, y * 1000 + 5000);

                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;

            }
                 
            ChartyMaker(times);
        }
        private void ButtonBase_OnClick4b(object sender, RoutedEventArgs e)
        {

            float[] longArr = floatStale();

            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                float[] shortArray = new float[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);

                Stopwatch sw = new Stopwatch();
                sw.Start();

                floatInserSort(shortArray, y * 1000 + 5000);

                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;

            }

            ChartyMaker(times);
        }

        private void ButtonBase_OnClick5(object sender, RoutedEventArgs e)
        {
            int[] longArr = Vksztaltne();

            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                int[] shortArray = new int[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);

                Stopwatch sw = new Stopwatch();
                sw.Start();

                InserSort(shortArray, y * 1000 + 5000);

                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;

            }

            ChartyMaker(times);
        }


        private void ButtonBase_OnClick5a(object sender, RoutedEventArgs e)
        {
            short[] longArr = shortVksztaltne();       
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                short[] shortArray = new short[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000); 
                Stopwatch sw = new Stopwatch();
                sw.Start();                                     
                shortInserSort(shortArray, y * 1000 + 5000);     
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10; 
            }    
           ChartyMaker(times);
        }

        private void ButtonBase_OnClick5b(object sender, RoutedEventArgs e)
        {
            float[] longArr = floatVksztaltne();  
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                float[] shortArray = new float[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);  
                Stopwatch sw = new Stopwatch();
                sw.Start();                          
                floatInserSort(shortArray, y * 1000 + 5000);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;
            }                     
            ChartyMaker(times);
        }






        private void ButtonBase_OnClick6(object sender, RoutedEventArgs e)
        {
            int[] longArr = Losuj();    
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                int[] shortArray = new int[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);  
                Stopwatch sw = new Stopwatch();
                sw.Start();                    
                SelectSort(shortArray, y * 1000 + 5000);   
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10; 
            }             
            ChartyMaker(times);
        }
        private void ButtonBase_OnClick6a(object sender, RoutedEventArgs e)
        {
            short[] longArr = shortLosuj();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                short[] shortArray = new short[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                shortSelectSort(shortArray, y * 1000 + 5000);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;
            }
            ChartyMaker(times);
        }

        private void ButtonBase_OnClick6b(object sender, RoutedEventArgs e)
        {
            float[] longArr = floatLosuj();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                float[] shortArray = new float[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                floatSelectSort(shortArray, y * 1000 + 5000);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;
            }
            ChartyMaker(times);
        }

        private void ButtonBase_OnClick7(object sender, RoutedEventArgs e)
        {
            int[] longArr = Rosnace();  
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                int[] shortArray = new int[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);  
                Stopwatch sw = new Stopwatch();
                sw.Start();                   
                SelectSort(shortArray, y * 1000 + 5000);   
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;     
            }
            ChartyMaker(times);
        }
        private void ButtonBase_OnClick7a(object sender, RoutedEventArgs e)
        {
            short[] longArr = shortRosnace();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                short[] shortArray = new short[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                shortSelectSort(shortArray, y * 1000 + 5000);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;
            }
            ChartyMaker(times);
        }     
        private void ButtonBase_OnClick7b(object sender, RoutedEventArgs e)
        {
            float[] longArr = floatRosnace();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                float[] shortArray = new float[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                floatSelectSort(shortArray, y * 1000 + 5000);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;
            }
            ChartyMaker(times);
        }


        private void ButtonBase_OnClick8(object sender, RoutedEventArgs e)
        {
            int[] longArr = Malejace();    
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                int[] shortArray = new int[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);  
                Stopwatch sw = new Stopwatch();
                sw.Start();        
                SelectSort(shortArray, y * 1000 + 5000); 
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;   
            }
            ChartyMaker(times);
        }
        private void ButtonBase_OnClick8a(object sender, RoutedEventArgs e)
        {
            short[] longArr = shortMalejace();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                short[] shortArray = new short[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                shortSelectSort(shortArray, y * 1000 + 5000);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;
            }
            ChartyMaker(times);
        }
        private void ButtonBase_OnClick8b(object sender, RoutedEventArgs e)
        {
            float[] longArr = floatMalejace();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                float[] shortArray = new float[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                floatSelectSort(shortArray, y * 1000 + 5000);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;
            }
            ChartyMaker(times);
        }

        private void ButtonBase_OnClick9(object sender, RoutedEventArgs e)
        {
            int[] longArr = Stale();  
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                int[] shortArray = new int[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);   
                Stopwatch sw = new Stopwatch();
                sw.Start();              
                SelectSort(shortArray, y * 1000 + 5000);   
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;  
            }
            ChartyMaker(times);
        }

        private void ButtonBase_OnClick9a(object sender, RoutedEventArgs e)
        {
            short[] longArr = shortStale();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                short[] shortArray = new short[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                shortSelectSort(shortArray, y * 1000 + 5000);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;
            }
            ChartyMaker(times);
        }

        private void ButtonBase_OnClick9b(object sender, RoutedEventArgs e)
        {
            float[] longArr = floatStale();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                float[] shortArray = new float[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                floatSelectSort(shortArray, y * 1000 + 5000);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;
            }
            ChartyMaker(times);
        }

        private void ButtonBase_OnClick10(object sender, RoutedEventArgs e)
        {
            int[] longArr = Vksztaltne();  
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                int[] shortArray = new int[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);  
                Stopwatch sw = new Stopwatch();
                sw.Start();         
                SelectSort(shortArray, y * 1000 + 5000); 
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;   
            }
            ChartyMaker(times);
        }
        private void ButtonBase_OnClick10a(object sender, RoutedEventArgs e)
        {
            short[] longArr = shortVksztaltne();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                short[] shortArray = new short[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                shortSelectSort(shortArray, y * 1000 + 5000);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;
            }
            ChartyMaker(times);
        }
        private void ButtonBase_OnClick10b(object sender, RoutedEventArgs e)
        {
            float[] longArr = floatVksztaltne();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                float[] shortArray = new float[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                floatSelectSort(shortArray, y * 1000 + 5000);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;
            }
            ChartyMaker(times);
        }



        private void ButtonBase_OnClick11(object sender, RoutedEventArgs e)
        {
            int[] longArr = Losuj();   
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                int[] shortArray = new int[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);  
                Stopwatch sw = new Stopwatch();
                sw.Start();     
                HeapSort(shortArray, y * 1000 + 5000);  
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds ;     
            }
            ChartyMaker(times);
        }

        private void ButtonBase_OnClick11a(object sender, RoutedEventArgs e)
        {
            short[] longArr = shortLosuj();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                short[] shortArray = new short[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                shortHeapSort(shortArray, y * 1000 + 5000);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds ;
            }
            ChartyMaker(times);
        }                                                                     
        private void ButtonBase_OnClick11b(object sender, RoutedEventArgs e)
        {
            float[] longArr = floatLosuj();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                float[] shortArray = new float[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                floatHeapSort(shortArray, y * 1000 + 5000);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds;
            }
            ChartyMaker(times);
        }

        private void ButtonBase_OnClick12(object sender, RoutedEventArgs e)
        {
            int[] longArr = Rosnace();      
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                int[] shortArray = new int[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);  
                Stopwatch sw = new Stopwatch();
                sw.Start();    
                HeapSort(shortArray, y * 1000 + 5000);  
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds; 
            }
            ChartyMaker(times);
        }
        private void ButtonBase_OnClick12a(object sender, RoutedEventArgs e)
        {
            short[] longArr = shortRosnace();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                short[] shortArray = new short[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                shortHeapSort(shortArray, y * 1000 + 5000);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds;
            }
            ChartyMaker(times);
        }

        private void ButtonBase_OnClick12b(object sender, RoutedEventArgs e)
        {
            float[] longArr = floatRosnace();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                float[] shortArray = new float[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                floatHeapSort(shortArray, y * 1000 + 5000);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds;
            }
            ChartyMaker(times);
        }
        private void ButtonBase_OnClick13(object sender, RoutedEventArgs e)
        {
            int[] longArr = Malejace();     
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                int[] shortArray = new int[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();      
                HeapSort(shortArray, y * 1000 + 5000); 
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds; 
            }
            ChartyMaker(times);
        }
        private void ButtonBase_OnClick13a(object sender, RoutedEventArgs e)
        {
            short[] longArr = shortMalejace();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                short[] shortArray = new short[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                shortHeapSort(shortArray, y * 1000 + 5000);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds ;
            }
            ChartyMaker(times);
        }

        private void ButtonBase_OnClick13b(object sender, RoutedEventArgs e)
        {
            float[] longArr = floatMalejace();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                short[] shortArray = new short[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                shortHeapSort(shortArray, y * 1000 + 5000);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds;
            }
            ChartyMaker(times);
        }

        private void ButtonBase_OnClick14(object sender, RoutedEventArgs e)
        {
            int[] longArr = Stale();   
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                int[] shortArray = new int[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);  
                Stopwatch sw = new Stopwatch();
                sw.Start();                     
                HeapSort(shortArray, y * 1000 + 5000);    
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds ; 
            }
            ChartyMaker(times);
        }

        private void ButtonBase_OnClick14a(object sender, RoutedEventArgs e)
        {
            short[] longArr = shortStale();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                short[] shortArray = new short[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                shortHeapSort(shortArray, y * 1000 + 5000);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds;
            }
            ChartyMaker(times);
        }

        private void ButtonBase_OnClick14b(object sender, RoutedEventArgs e)
        {
            float[] longArr = floatStale();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                float[] shortArray = new float[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                floatHeapSort(shortArray, y * 1000 + 5000);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds;
            }
            ChartyMaker(times);
        }

        private void ButtonBase_OnClick15(object sender, RoutedEventArgs e)
        {
            int[] longArr = Vksztaltne();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                int[] shortArray = new int[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);     
                Stopwatch sw = new Stopwatch();
                sw.Start();                          
                HeapSort(shortArray, y * 1000 + 5000);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds;  
            }
            ChartyMaker(times);
        }
        private void ButtonBase_OnClick15a(object sender, RoutedEventArgs e)
        {
            short[] longArr = shortVksztaltne();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                short[] shortArray = new short[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                shortHeapSort(shortArray, y * 1000 + 5000);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds ;
            }
            ChartyMaker(times);
        }

        private void ButtonBase_OnClick15b(object sender, RoutedEventArgs e)
        {
            float[] longArr = floatVksztaltne();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                float[] shortArray = new float[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                floatHeapSort(shortArray, y * 1000 + 5000);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds;
            }
            ChartyMaker(times);
        }

        private void ButtonBase_OnClick16(object sender, RoutedEventArgs e)
        {
            int[] longArr = Losuj();     
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                int[] shortArray = new int[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);   
                Stopwatch sw = new Stopwatch();
                sw.Start();     
                CoctailSort(shortArray, y * 1000 + 5000);  
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10; 
            }
            ChartyMaker(times);
        }

        private void ButtonBase_OnClick16a(object sender, RoutedEventArgs e)
        {
            short[] longArr = shortLosuj();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                short[] shortArray = new short[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                shortCoctailSort(shortArray, y * 1000 + 5000);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;
            }
            ChartyMaker(times);
        }
        private void ButtonBase_OnClick16b(object sender, RoutedEventArgs e)
        {
            float[] longArr = floatLosuj();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                float[] shortArray = new float[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                floatCoctailSort(shortArray, y * 1000 + 5000);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;
            }
            ChartyMaker(times);
        }

        private void ButtonBase_OnClick17(object sender, RoutedEventArgs e)
        {
            int[] longArr = Rosnace();   
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                int[] shortArray = new int[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);   
                Stopwatch sw = new Stopwatch();
                sw.Start();                  
                CoctailSort(shortArray, y * 1000 + 5000);  
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;    
            }
            ChartyMaker(times);
        }

        private void ButtonBase_OnClick17a(object sender, RoutedEventArgs e)
        {
            short[] longArr = shortRosnace();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                short[] shortArray = new short[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                shortCoctailSort(shortArray, y * 1000 + 5000);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;
            }
            ChartyMaker(times);
        }

        private void ButtonBase_OnClick17b(object sender, RoutedEventArgs e)
        {
            float[] longArr = floatRosnace();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                float[] shortArray = new float[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                floatCoctailSort(shortArray, y * 1000 + 5000);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;
            }
            ChartyMaker(times);
        }

        private void ButtonBase_OnClick18(object sender, RoutedEventArgs e)
        {
            int[] longArr = Malejace();   
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                int[] shortArray = new int[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);   
                Stopwatch sw = new Stopwatch();
                sw.Start();        
                CoctailSort(shortArray, y * 1000 + 5000);  
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10; 
            }
            ChartyMaker(times);
        }

        private void ButtonBase_OnClick18a(object sender, RoutedEventArgs e)
        {
            short[] longArr = shortMalejace();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                short[] shortArray = new short[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                shortCoctailSort(shortArray, y * 1000 + 5000);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;
            }
            ChartyMaker(times);
        }

        private void ButtonBase_OnClick18b(object sender, RoutedEventArgs e)
        {
            float[] longArr = floatMalejace();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                float[] shortArray = new float[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                floatCoctailSort(shortArray, y * 1000 + 5000);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;
            }
            ChartyMaker(times);
        }

        private void ButtonBase_OnClick19(object sender, RoutedEventArgs e)
        {
            int[] longArr = Stale();    
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                int[] shortArray = new int[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000); 
                Stopwatch sw = new Stopwatch();
                sw.Start();                  
                CoctailSort(shortArray, y * 1000 + 5000);  
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;  
            }
            ChartyMaker(times);
        }
        private void ButtonBase_OnClick19a(object sender, RoutedEventArgs e)
        {
            short[] longArr = shortStale();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                short[] shortArray = new short[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                shortCoctailSort(shortArray, y * 1000 + 5000);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;
            }
            ChartyMaker(times);
        }

        private void ButtonBase_OnClick19b(object sender, RoutedEventArgs e)
        {
            float[] longArr = floatStale();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                float[] shortArray = new float[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                floatCoctailSort(shortArray, y * 1000 + 5000);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;
            }
            ChartyMaker(times);
        }

        private void ButtonBase_OnClick20(object sender, RoutedEventArgs e)
        {
            int[] longArr = Vksztaltne();  
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                int[] shortArray = new int[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);  
                Stopwatch sw = new Stopwatch();
                sw.Start();                             
                CoctailSort(shortArray, y * 1000 + 5000);  
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;   
            }
            ChartyMaker(times);
        }
        private void ButtonBase_OnClick20a(object sender, RoutedEventArgs e)
        {
            short[] longArr = shortVksztaltne();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                short[] shortArray = new short[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                shortCoctailSort(shortArray, y * 1000 + 5000);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;
            }
            ChartyMaker(times);
        }

        private void ButtonBase_OnClick20b(object sender, RoutedEventArgs e)
        {
            float[] longArr = floatVksztaltne();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                float[] shortArray = new float[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                floatCoctailSort(shortArray, y * 1000 + 5000);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;
            }
            ChartyMaker(times);
        }

        private void ButtonBase_OnClick21(object sender, RoutedEventArgs e)
        {
            int[] longArr = Losuj();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                int[] shortArray = new int[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                Recursive(shortArray);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;
            }
            ChartyMaker(times);
        }
        private void ButtonBase_OnClick22(object sender, RoutedEventArgs e)
        {
            int[] longArr = Rosnace();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                int[] shortArray = new int[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                Recursive(shortArray);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;
            }
            ChartyMaker(times);
        }


        private void ButtonBase_OnClick23(object sender, RoutedEventArgs e)
        {
            int[] longArr = Malejace();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                int[] shortArray = new int[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                Recursive(shortArray);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;
            }
            ChartyMaker(times);
        }

        private void ButtonBase_OnClick24(object sender, RoutedEventArgs e)
        {
            int[] longArr = Stale();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                int[] shortArray = new int[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                Recursive(shortArray);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;
            }
            ChartyMaker(times);
        }

        private void ButtonBase_OnClick25(object sender, RoutedEventArgs e)
        {
            int[] longArr = Vksztaltne();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                int[] shortArray = new int[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                Recursive(shortArray);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;
            }
            ChartyMaker(times);
        }

        private void ButtonBase_OnClick26(object sender, RoutedEventArgs e)
        {
            int[] longArr = Losuj();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                int[] shortArray = new int[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                Iterative(shortArray);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;
            }
            ChartyMaker(times);
        }

        private void ButtonBase_OnClick27(object sender, RoutedEventArgs e)
        {
            int[] longArr = Rosnace();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                int[] shortArray = new int[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                Iterative(shortArray);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;
            }
            ChartyMaker(times);
        }


        private void ButtonBase_OnClick28(object sender, RoutedEventArgs e)
        {
            int[] longArr = Malejace();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                int[] shortArray = new int[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                Iterative(shortArray);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;
            }
            ChartyMaker(times);
        }

        private void ButtonBase_OnClick29(object sender, RoutedEventArgs e)
        {
            int[] longArr = Stale();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                int[] shortArray = new int[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                Iterative(shortArray);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;
            }
            ChartyMaker(times);
        }

        private void ButtonBase_OnClick30(object sender, RoutedEventArgs e)
        {
            int[] longArr = Vksztaltne();
            float[] times = new float[16];
            for (int y = 0; y <= 15; y++)
            {
                int[] shortArray = new int[y * 1000 + 5000];
                Array.Copy(longArr, 0, shortArray, 0, y * 1000 + 5000);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                Iterative(shortArray);
                sw.Stop();
                times[y] = sw.ElapsedMilliseconds / 10;
            }
            ChartyMaker(times);
        }

    }
}

    

    class RecordCollection : ObservableCollection<Record>
    {

        public RecordCollection(List<Bar> barvalues)
        {
            Random rand = new Random();
            BrushCollection brushcoll = new BrushCollection();

            foreach (Bar barval in barvalues)
            {
                int num = rand.Next(brushcoll.Count / 3);
                Add(new Record(barval.Value, brushcoll[num], barval.BarName));
            }
        }

    }

    class BrushCollection : ObservableCollection<Brush>
    {
        public BrushCollection()
        {
            Type _brush = typeof(Brushes);
            PropertyInfo[] props = _brush.GetProperties();
            foreach (PropertyInfo prop in props)
            {
                Brush _color = (Brush)prop.GetValue(null, null);
                if (_color != Brushes.LightSteelBlue && _color != Brushes.White &&
                     _color != Brushes.WhiteSmoke && _color != Brushes.LightCyan &&
                     _color != Brushes.LightYellow && _color != Brushes.Linen)
                    Add(_color);
            }
        }
    }

    class Bar
    {

        public string BarName { set; get; }

        public int Value { set; get; }

    }

    class Record : INotifyPropertyChanged
    {
        public Brush Color { set; get; }

        public string Name { set; get; }

        private int _data;
        public int Data
        {
            set
            {
                if (_data != value)
                {
                    _data = value;

                }
            }
            get
            {
                return _data;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Record(int value, Brush color, string name)
        {
            Data = value;
            Color = color;
            Name = name;
        }

        protected void PropertyOnChange(string propname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propname));
            }
        }
    }




