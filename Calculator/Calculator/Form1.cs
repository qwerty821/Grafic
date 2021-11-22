using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace Calculator {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
        
        }

        ArrayList list = new ArrayList();
        long[] nr = new long[10];
        char[] semn = new char[10];
        int nr_index = 0;
        int semn_index = 0;
        String sir;
        int get_int(object sender) {
            String s = sender.ToString();
            char x = s[s.Length - 1];
            int nr = x - '0';
            return nr;
        }
       
        void afisare() {
           if (sir.Length == 0) {
                ecran.Text = "0";
           } else {
                ecran.Text = sir;
            }
        }
        private void cifra(object sender, MouseEventArgs e) {
            int n = get_int(sender);
            if (n == 0) {
                return;
            } 
            if (nr_index == 0) {
                nr[nr_index++] = n;
            } else {
                nr[nr_index - 1] *= 10;
                nr[nr_index - 1] += n;

            }
            sir += Convert.ToString(n);
            afisare();
        }

        private void button_c_Click(object sender, EventArgs e) {
           
        }

        private void rezultat(object sender, EventArgs e) {
            nr_index++;
            char s  = sir[sir.Length - 1];
            if(s == '/' || s == '+' || s == '-' || s == '*') {
                MessageBox.Show("Incorect Format", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                for(int i = 0; i < semn_index; i++) {
                    Console.Write(semn[i] + " ");
                }
                Console.WriteLine();
                for (int i = 0; i < nr_index;i++) {
                    Console.Write(nr[i] + " ");
                }
            }
        }

        private void semn_click(object sender, EventArgs e) {
            String s = sender.ToString();
            char x = s[s.Length - 1];
            char ss = Convert.ToChar(sir[sir.Length - 1]);
            Console.WriteLine(x);
            Console.WriteLine(sir);
            Console.WriteLine(ss);
            Console.WriteLine("----");

            if (ss == '/' || ss == '*' || ss == '+' || ss == '-') {
                sir = sir.Remove(sir.Length - 1, 1) + x;
                afisare();
                return;
            } else {
                sir += x;
            }
            if(semn_index == 0) {
                semn[semn_index++] = x;
            } else {
                semn[semn_index++] = x;
            }
            
            afisare();
        }

         
    }
}
