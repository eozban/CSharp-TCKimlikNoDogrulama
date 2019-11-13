using System;
using System.Collections.Generic;
using System.Text;

namespace ESinTiBiLiSiM
{
    class MyTCKontrol
    {
        public static bool IsNumeric(string tcKimlikNo)
        {
            bool sonuc = true;
            for (int i = 0; i < tcKimlikNo.Length; i++)
            {
                if (!char.IsNumber(tcKimlikNo[i]))
                    sonuc = false;
            }
            return sonuc;
        }

        public static string TcDogrula(string tcKimlikNo)
        {
            int i = 0;
            int tekler = 0;
            int ciftler = 0;
            string k10, k11;

            try
            {
                if (tcKimlikNo.Length == 11)
                {
                    if (IsNumeric(tcKimlikNo))
                    {
                        if (tcKimlikNo.Substring(0, 1) != "0")
                        {

                            for (i = 0; i < 9; i += 2)
                            {
                                tekler += int.Parse(tcKimlikNo[i].ToString());
                                //MessageBox.Show("t" + i.ToString() + "=" + tcKimlikNo[i].ToString());
                            }

                            for (i = 1; i < 8; i += 2)
                            {
                                ciftler += int.Parse(tcKimlikNo[i].ToString());
                                //MessageBox.Show("c" + i.ToString() + "=" + tcKimlikNo[i].ToString());
                            }


                            k10 = (((tekler * 7) - ciftler) % 10).ToString();
                            k11 = (((tekler + ciftler) + int.Parse(tcKimlikNo[9].ToString())) % 10).ToString();

                            //MessageBox.Show(tekler.ToString());
                            //MessageBox.Show(ciftler.ToString());
                            //MessageBox.Show(k10);
                            //MessageBox.Show(k11);

                            if ((k10 == tcKimlikNo[9].ToString()) && (k11 == tcKimlikNo[10].ToString()))
                                return "TC Kimlik Numarası DOĞRU";
                            else
                                return "TC Kimlik Numarası YANLIŞ";
                        }
                        else
                            return "Tc Kimlik Numarasının ilk hanesi 0 olamaz";
                    }
                    else
                        return "Tc Kimlik Numarası sadece rakamlardan oluşabilir";
                }
                else
                    return "Tc Kimlik No 11 Hane Olmalıdır";
            }
            catch (Exception hata)
            {
                return "Hata :" + hata.Message;
            }
        }

        public static string TcTamamla(string tcKimlikNo)
        {
            int i = 0;
            int tekler = 0;
            int ciftler = 0;
            string k10, k11;

            for (i = 0; i < 9; i += 2)
            {
                tekler += int.Parse(tcKimlikNo[i].ToString());
                //MessageBox.Show("t" + i.ToString() + "=" + tcKimlikNo[i].ToString());
            }

            for (i = 1; i < 8; i += 2)
            {
                ciftler += int.Parse(tcKimlikNo[i].ToString());
                //MessageBox.Show("c" + i.ToString() + "=" + tcKimlikNo[i].ToString());
            }


            k10 = (((tekler * 7) - ciftler) % 10).ToString();
            k11 = (((tekler + ciftler) + int.Parse(k10)) % 10).ToString();

            return (tcKimlikNo + k10 + k11);
        }
    }
}
