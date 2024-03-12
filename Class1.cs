using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmod4_1302223054
{
    internal class Class1
    {
        public class KodePos
        {
            public string GetKodePos(string kelurahan)
            {
                // Buat dictionary untuk menyimpan data tabel
                Dictionary<string, string> kodePosTable = new Dictionary<string, string>()
            {
                { "Batununggal", "40266" },
                { "Kujangsari", "40287" },
                { "Mengger", "40267" },
                { "Wates", "40256" },
                { "Cijaura", "40287" },
                { "Jatisari", "40286" },
                { "Margasari", "40286" },
                { "Sekejati", "40286" },
                { "Kebonwaru", "40272" },
                { "Maleer", "40274" },
                { "Samoja", "40273" }
            };

                // Cek apakah kelurahan ada di dalam tabel
                if (kodePosTable.ContainsKey(kelurahan))
                {
                    // Kembalikan kode pos
                    return kodePosTable[kelurahan];
                }
                else
                {
                    // Kembalikan string kosong jika kelurahan tidak ditemukan
                    return "";
                }
            }
        }

    }
}
