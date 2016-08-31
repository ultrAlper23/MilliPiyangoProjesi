using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MilliPiyango
{
    class Bilet
    {
        string biletNo;
        //BiletNo property si biletNo alanını dış etkilerden korur. biletNo sadece bilet çekildiği zaman bilete ait numarayı verir. ve kullanıcı ya da sınıfı kullanan diğer yazılımcılar bu alana veri girişi yapamazlar.
        public string BiletNo
        {
            get { return biletNo; }
           // set { biletNo = value; }
        }

        //form açıldığında (ve her yeni bilet nesnesi için) biletimizin bir numarası olsun ve çekiliş sonrası karşılaştırmada da bu numarayı (değiştiremeden) kullanabilelim.

        public Bilet()
        {
            Random gen = new Random();
            for (int i = 0; i < 6; i++)
            {
                biletNo += gen.Next(10);
            }
            Thread.Sleep(10);
        }
    }
}
