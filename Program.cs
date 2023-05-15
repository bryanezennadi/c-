using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero = "";
            do
            {
                Console.WriteLine("inserisci un numero di 8 cifre, se sono meno, inserisci degli 0 alla fine per raggiungere 8 ");
                numero = Console.ReadLine();
                Console.Clear();
            } while(numero.Length!=8);
           

            long[] dataFinale2 = new long[8];
           
            string mese2 = "";
            string giorno2 = "";

            long numerone = Convert.ToInt64(numero);

            datonafinale(numerone, ref dataFinale2, ref mese2, ref giorno2);
            if (primoConfronto(mese2) && Controllogiorno(mese2, giorno2))
            {
                for (int i = 0; i < dataFinale2.Length; i++)
                {

                    Console.Write(dataFinale2[i]);
                    if (i == 1 || i == 3)
                    {
                        Console.Write('/');
                    }
                }
            }
            else
            {
                Console.WriteLine("data non valida");
            }

        //    Console.WriteLine("\n***********************************");
        //    string giorno = "";
        //    string mese = "";
        //    string anno = "";
        //    string dataFinale = "";

        //    giorno = Giorno(numero);
        //    mese = Mese(numero);
        //    anno = Anno(numero);
        //    dataFinale = DataFinale(giorno, mese, anno);
        //    Console.WriteLine(dataFinale);
            Console.ReadLine();
        }
        static bool Controllogiorno(string mese, string giorno)
        {
            bool confronto=false;
            switch (mese)
            {
                case "01":
                    mese = "gennaio";
                    if (Convert.ToInt32(giorno) > 0 && Convert.ToInt32(giorno) < 32)
                    {
                        confronto = true;
                    }
                    break;
                case "02":
                    mese = "febbraio";
                    if (Convert.ToInt32(giorno) > 0 && Convert.ToInt32(giorno) < 29)
                    {
                        confronto = true;
                    }
                    break;
                case "03":
                    mese = "marzo";
                    if (Convert.ToInt32(giorno) > 0 && Convert.ToInt32(giorno) < 32)
                    {
                        confronto = true;
                    }
                    break;
                case "04":
                    mese = "aprile";
                    if (Convert.ToInt32(giorno) > 0 && Convert.ToInt32(giorno) < 31)
                    {
                        confronto = true;
                    }
                    break;
                case "05":
                    mese = "maggio";
                    if (Convert.ToInt32(giorno) > 0 && Convert.ToInt32(giorno) < 32)
                    {
                        confronto = true;
                    }
                    break;
                case "06":
                    mese = "giugno";
                    if (Convert.ToInt32(giorno) > 0 && Convert.ToInt32(giorno) < 31)
                    {
                        confronto = true;
                    }
                    break;
                case "07":
                    mese = "luglio";
                    if (Convert.ToInt32(giorno) > 0 && Convert.ToInt32(giorno) < 32)
                    {
                        confronto = true;
                    }
                    break;
                case "08":
                    mese = "agosto";
                    if (Convert.ToInt32(giorno) > 0 && Convert.ToInt32(giorno) < 32)
                    {
                        confronto = true;
                    }
                    break;
                case "09":
                    mese = "settembre";
                    if (Convert.ToInt32(giorno) > 0 && Convert.ToInt32(giorno) < 31)
                    {
                        confronto = true;
                    }
                    break;
                case "10":
                    mese = "ottobre";
                    if (Convert.ToInt32(giorno) > 0 && Convert.ToInt32(giorno) < 32)
                    {
                        confronto = true;
                    }
                    break;
                case "11":
                    mese = "novembre";
                    if (Convert.ToInt32(giorno) > 0 && Convert.ToInt32(giorno) < 31)
                    {
                        confronto = true;
                    }
                    break;
                case "12":
                    mese = "dicembre"; if (Convert.ToInt32(giorno) > 0 && Convert.ToInt32(giorno) < 32)
                    {
                        confronto = true;
                    }
                    break;


            }
            return confronto;
        }
        
        //static string Giorno(string frase)
        //{
        //    string giorno = "";
        //    for (int i = 0; i < 2; i++)
        //    {
        //        giorno = giorno + frase[i];
        //    }
        //    return giorno;
        //}
        //static string Mese(string frase)
        //{
        //    string mese = "";
        //    for (int i = 2; i < 4; i++)
        //    {
        //        mese = mese + frase[i];
        //    }
        //    switch (mese)
        //    {
        //        case "01":
        //            mese = "gennaio";
        //            break;
        //        case "02":
        //            mese = "febbraio";
        //            break;
        //        case "03":
        //            mese = "marzo";
        //            break;
        //        case "04":
        //            mese = "aprile";
        //            break;
        //        case "05":
        //            mese = "maggio";
        //            break;
        //        case "06":
        //            mese = "giugno";
        //            break;
        //        case "07":
        //            mese = "luglio";
        //            break;
        //        case "08":
        //            mese = "agosto";
        //            break;
        //        case "09":
        //            mese = "settembre";
        //            break;
        //        case "10":
        //            mese = "ottobre";
        //            break;
        //        case "11":
        //            mese = "novembre";
        //            break;
        //        case "12":
        //            mese = "dicembre";
        //            break;


        //    }

        //    return mese;
        //}

        //static string Anno(string frase)
        //{
        //    string anno = "";
        //    for (int i = 4; i < 8; i++)
        //    {
        //        anno = anno + frase[i];
        //    }
        //    return anno;
        //}
        static bool primoConfronto(string mese2)
        {
            bool confronto = false;
            if (Convert.ToInt32(mese2) > 0 && Convert.ToInt32(mese2) < 13)
            {
                confronto = true;
            }
            return confronto;
        }
        //static string DataFinale(string giorno, string mese, string anno)
        //{
        //    string dataFinale = "";
        //    dataFinale = giorno + '/' + mese + '/' + anno;
        //    return dataFinale;
        //}
        static void datonafinale(long numerone, ref long[] dataFinale2, ref string mese2, ref string giorno2)
        {
            int m = 7;
            long cifra = 0;
            do
            {
                cifra = numerone % 10;
                numerone = numerone / 10;
                if (m == 3 || m == 2)
                {
                    mese2=mese2+ cifra;
                }
                else if (m == 1 || m == 0)
                {
                    giorno2 = giorno2 + cifra;
                }
                dataFinale2[m] = cifra;
                m--;


            } while (numerone != 0);


        }

    }
}
