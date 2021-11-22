using System;
using System.Collections.Generic;
using System.Numerics;


class data {

    private Tuple<double, double>[] tuples;
    private int nr;
    private double maxx = 0;
    private double maxy = 0;
    private double minx = 1e5;
    private double miny = 1e5;
    private int[] linie = new int[1000];
    data() {}
    
    public data(int n) {
        nr = n;
        tuples = new Tuple<double, double>[n];
        for (int j = 0; j < 1000; j++) {
            linie[j] = 0;
        }
    }
    public void citire() {
        Console.WriteLine("cordonatele reale se scriu cu virgula");
        for (int i = 0; i < nr; i++) {
            double x, y;
            Console.WriteLine(i + 1);
            
            Console.Write("x = ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("y = ");
            y = Convert.ToDouble(Console.ReadLine());

            tuples[i] = new Tuple<double, double>(x, y);
        }
        rotungire();
    }

     
    /*
     *  23,6556 * 10 = 236
     *  236 => 23,5
     *  
     *
     */


    private double vir(double x) {
        double rez  = 0;
        int c = (int)(x * 10);
        if (c % 10 > 7) {
            c = c / 10 + 1;
            rez = (double)c;
        } else if (c % 10 > 5 || c % 10 > 2){
            c = c - c % 10 + 5;
            rez = (double)c / 10;
        } else if (c % 10 >= 0) {
            c = c / 10;
            rez = (double)c;
        }
        return rez;
    } 

    private void rotungire() {
        for (int i = 0; i < nr; i++) {
            tuples[i] = new Tuple<double, double>(vir(tuples[i].Item1), vir(tuples[i].Item2));
            maxx = Math.Max(maxx, tuples[i].Item1);
            maxy = Math.Max(maxy, tuples[i].Item2);
            minx = Math.Min(minx, tuples[i].Item1);
            miny = Math.Min(miny, tuples[i].Item2);

        }
    }

    public void afisare() {
        Console.WriteLine("##### dupa rotungire #####");
        for(int i = 0; i < nr; i++) {
            Console.WriteLine($"P{i + 1}({tuples[i].Item1};{tuples[i].Item2})");
        }
        Console.WriteLine("##########################");
    }

    private List<double> caut(double x) {
        List<double> vs = new List<double>();

        for (int i = 0; i < nr; i++) {
            if (tuples[i].Item2 == x) {
                if(vs.Count == 0) {
                    vs.Add(tuples[i].Item1);
                } else if (vs.Count > 0 && vs[vs.Count - 1] != x)
                     vs.Add(tuples[i].Item1);
            }
        }
        return vs;
    }

    private int numar(double x) {
        return (int)(x * 2);
    }

    private bool este_x(double x) {
        for (int i = 0; i < nr; i++) {
            if (tuples[i].Item2 == x)
                return true;
        }
        return false;
    }

    public void grafic() {
      
        for (double i = maxy + 5; i >= 0; i -= 0.5) {
            Console.Write(i + "\t|");
            List<double> num = caut(i);
           
          
            //for (int j = 0; j < num.Count; j++) {
            //    Console.Write("%" + num[j]);
            //}
            //Console.Write("\n");
            num.Sort();
            int n = 0;
            if (num.Count > 0) {
                int k = 0;
                for (double j = 0; j <= maxx + 5; j+= 0.5, n++) {
                    if(k < num.Count && num[k] == j) {
                        Console.Write((char)4 + " ");
                        linie[numar(j)] = 1;
                        k++;
                       
                    }  else if (k < num.Count){
                        Console.ForegroundColor = ConsoleColor.Red;
                        if (linie[numar(j)] == 1) {
                            Console.Write("+ ");
                        } else {
                            Console.Write("--");
                        }
                        Console.ResetColor();
                    } else if (linie[numar(j)] == 1) {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("| ");
                        Console.ResetColor();
                    } else {  
                        Console.Write(". ");
                    }
                    
                }
                Console.Write("\n");
            } else {
                for (double j = 0; j <= maxx + 5; j += 0.5) {
                    if (linie[numar(j)] == 1) {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("| ");
                        Console.ResetColor();
                    } else {
                        Console.Write(". ");
                    }
                }
                Console.Write("\n");
            }
        }
        Console.Write("\t");
        for (int i = 0; i <= (int)(maxx + 5); i++) {
            Console.Write("--");
        }
        Console.Write("\n\t ");
        for (int i = 0; i <= (int)(maxx + 5); i++) {
            Console.Write(i + "   ");
        }
        Console.Write("\n\t  ");
        for (int i = 0; i <= (int)(maxx + 5); i++) {
            Console.Write(i + ",5 ");
        }
        //for (int i = 0; i < 10; i++) {
        //    Console.Write(linie[i] + " ");
        //}
    }
} 

namespace ConsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nr = ");
            int n = Convert.ToInt32(Console.ReadLine());
            data d = new data(n);
            d.citire();
            Console.Clear();
            d.afisare();
            d.grafic();
            Console.WriteLine("\n");
            //for (int i = 0; i < Char.MaxValue;i++) {
            //    Console.WriteLine($"{i} = {(char)i}");
            //}
        }

    }
}
