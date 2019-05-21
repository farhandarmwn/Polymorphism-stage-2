using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Latihan_Interface
{
    public interface IConvertObject
    {
        // method abstract
        void Convert(Mahasiswa mhs); 
    }
}
