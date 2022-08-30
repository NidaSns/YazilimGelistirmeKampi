using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class TasitKrediManager : IKrediManager
    {
        public void BirseyYap()
        {
            Console.WriteLine("Tasit kredi hesaplandı");
        }

        public void Hesapla()
        {
            throw new NotImplementedException();
        }
    }
}
