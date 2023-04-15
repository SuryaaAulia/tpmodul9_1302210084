using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace tpmodul9_1302210084
{
    public class MahasiswaC
    {
        public string Nama { get; private set; }
        public string Nim { get; private set; }

        public MahasiswaC(string nama, string nim) { this.Nama = nama; this.Nim = nim; }
    }

}
