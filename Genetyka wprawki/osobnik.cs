using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetyka_wprawki
{
    class osobnik
    {
        public static Random random = new Random();

        public bool mutant { get; set; }
        public int[] parametry { get; set; }

        public double ocena { get; set; }

        public osobnik()
        {
                        
           this.parametry = new int[5];
            this.generate();
            mutant = false;
           
        }

        public void generate()
        {
            for (int i = 0; i < 5; i++)
            {

                parametry[i] = random.Next(2);
            }
            ocena = parametry.Average();
        }

        public osobnik(osobnik tata, osobnik mama)
        {
            this.parametry = new int[5];
            this.parametry[0] = tata.parametry[0];
            this.parametry[1] = tata.parametry[1];
            this.parametry[2] = tata.parametry[2];
            this.parametry[3] = mama.parametry[3];
            this.parametry[4] = mama.parametry[4];
        }

        public void mutacja()
        {
            Random random = new Random();
            int test = random.Next(0, 100);
            if (test == 0)
            {
                mutant = true;
                int indeks = random.Next(0, 5);
                if (this.parametry.ElementAt(indeks) == 0)
                {
                    this.parametry[indeks] = 1;
                }
                else {
                    this.parametry[indeks] = 0;
                }
            }
        }
        }
    }
