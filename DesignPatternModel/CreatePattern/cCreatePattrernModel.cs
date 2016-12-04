using DesignPatternModel.CreatePattern.FactoryMethod.Generic;
using DesignPatternModel.CreatePattern.FactoryMethod.Generic.Abstruct;
using DesignPatternModel.CreatePattern.FactoryMethod.Stantard;
using DesignPatternModel.CreatePattern.Singlton.Default;
using DesignPatternModel.CreatePattern.Singlton.Holder;
using DesignPatternModel.CreatePattern.Singlton.Multi;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternModel.CreatePattern
{
    public class cCreatePattrernModel
    {
        public void SingltonSample()
        {
            int count = (int)Math.Pow(10, 6);
            List<cSingltonSample> O0 = new List<cSingltonSample>();
            List<cSingltonSample> O1 = new List<cSingltonSample>();
            List<cSingltonSample> O2 = new List<cSingltonSample>();

            ParallelOptions options = new ParallelOptions() { MaxDegreeOfParallelism = 3 };


            for (int i = 0; i < count; i++)
            {
                Action a0 = () => O0.Add(cSingltonSample.GetInstance());
                Action a1 = () => O1.Add(cSingltonSample.GetInstance());
                Action a2 = () => O2.Add(cSingltonSample.GetInstance());

                Parallel.Invoke(options,
                a0,
                a1,
               a2
                );
            }

            var t = O0[0];

            for (int i = 0; i < count; i++)
            {
                if (t != O0[i])
                {
                    throw new Exception();
                }
                if (t != O1[i])
                {
                    throw new Exception();
                }
                if (t != O2[i])
                {
                    throw new Exception();
                }
            }
        }

        public void SingltonHolderSample()
        {
            int count = (int)Math.Pow(10, 6);
            List<cSingltonHolderSample> O0 = new List<cSingltonHolderSample>();
            List<cSingltonHolderSample> O1 = new List<cSingltonHolderSample>();
            List<cSingltonHolderSample> O2 = new List<cSingltonHolderSample>();

            ParallelOptions options = new ParallelOptions() { MaxDegreeOfParallelism = 3 };


            for (int i = 0; i < count; i++)
            {
                Action a0 = () => O0.Add(cSingltonHolderSample.GetInstance());
                Action a1 = () => O1.Add(cSingltonHolderSample.GetInstance());
                Action a2 = () => O2.Add(cSingltonHolderSample.GetInstance());

                Parallel.Invoke(options,
                a0,
                a1,
               a2
                );
            }

            var t = O0[0];

            for (int i = 0; i < count; i++)
            {
                if (t != O0[i])
                {
                    throw new Exception();
                }
                if (t != O1[i])
                {
                    throw new Exception();
                }
                if (t != O2[i])
                {
                    throw new Exception();
                }
            }
        }

        public void MultitonSample()
        {
            int count = (int)Math.Pow(10, 6);
            List<string> k0 = new List<string>();
            List<string> k1 = new List<string>();
            List<string> k2 = new List<string>();
            for (int i = 0; i < count; i++)
            {
                k0.Add(i.ToString());
            }
            k1.AddRange(k0);
            k2.AddRange(k0);

            List<cMultitonSample> O0 = new List<cMultitonSample>();
            List<cMultitonSample> O1 = new List<cMultitonSample>();
            List<cMultitonSample> O2 = new List<cMultitonSample>();

            var options = new ParallelOptions() { MaxDegreeOfParallelism = 3 };

            //Parallel.For(0, count,
            //       i => {
            //           Action a0 = () => O0.Add(cMultitonSample.GetInstance(k0[i]));
            //           Action a1 = () => O0.Add(cMultitonSample.GetInstance(k1[i]));
            //           Action a2 = () => O0.Add(cMultitonSample.GetInstance(k2[i]));

            //           Parallel.Invoke(options,
            //           a0,
            //           a1,
            //          a2
            //           );
            //       });

            for (int i = 0; i < count; i++)
            {
                Action a0 = () => O0.Add(cMultitonSample.GetInstance(k0[i]));
                Action a1 = () => O0.Add(cMultitonSample.GetInstance(k1[i]));
                Action a2 = () => O0.Add(cMultitonSample.GetInstance(k2[i]));

                Parallel.Invoke(options,
                a0,
                a1,
               a2
                );
            }

            for (int i = 0; i < count; i++)
            {
                if (k0[i] != k1[i])
                {
                    throw new Exception();
                }
                if (k0[i] != k2[i])
                {
                    throw new Exception();
                }
            }
        }

        public void FactoryMethod()
        {
            List<string> list = new List<string>() { "いちご", "もも", "いちじく" };

            Console.WriteLine("五十音順で表示:");
            string dic = new cDictionaryOrderCreator().anOperation(list);
            Console.WriteLine(dic);

            Console.WriteLine("長さ順で表示:");
            string len = new cLengthOrderCreator().anOperation(list);
            Console.WriteLine(len);
        }

        public void FactoryMethodGeneric()
        {
            List<string> list = new List<string>() { "いちご", "もも", "いちじく" };

            Console.WriteLine("五十音順で表示:");
            string dic = new genericCreator<cDictionaryOrderProduct>().anOperation(list);
            Console.WriteLine(dic);

            Console.WriteLine("長さ順で表示:");
            string len = new genericCreator<cDictionaryOrderProduct>().anOperation(list);
            Console.WriteLine(len);
        }
    }
}
