/*

1 boyutlu Random Walk algoritması

Noktaların yerlerinin net görülebilmesi için her nokta 1 birim alta çizilerek devam eder

Normal dağılım'ı (çan şeklinde olasılığı görmek için yazıldı)

*/

private void button1_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(new ThreadStart(ParallelWorker));
            t1.Start();
        }

        public static void ParallelWorker()
        {
            Graphics g;

            using (g = Graphics.FromHwnd(IntPtr.Zero))
            {

                Console.WriteLine("Başladı.");
                int lastPosition = 0;

                Random rand = new Random();
                int testCount = 1000000;
                for (int i = 0; i < testCount; i++)
                {
                    int randomnum = rand.Next(2);

                    if (randomnum > 0)
                    {
                        lastPosition += 1;
                    }
                    else
                    {
                        lastPosition -= 1;
                    }

                    g.DrawEllipse(Pens.Red, 1000 + lastPosition, i, 10, 10);
                    Console.WriteLine("gelen değer: " + randomnum + ": son durum: " + lastPosition);

                }

                Console.WriteLine("Bitti.");
            }
        }
