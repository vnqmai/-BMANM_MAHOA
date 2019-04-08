using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMANM_MAHOA
{
    class Ceasar
    {
        #region property
        public int k { get; set; }
        public string plainText { get; set; }
        public string cipherText { get; set; }
        #endregion
        public Ceasar(int dodoi, string pt,string ci)
        {
            k = dodoi;
            plainText = pt;
            cipherText = ci;
        }
        public string mahoa()
        {
            plainText = plainText.ToUpper();
            for (int i = 0; i < plainText.Length; i++)
                cipherText += (char)('A' +
               ((plainText[i] - 'A' + k) % 26));
            return cipherText;
        }
        public string giaima()
        {
            string kq = string.Empty;
            for (int i = 0; i < cipherText.Length; i++)
                kq += (char)('A' + (cipherText[i] - 'A' +
               (26 - k)) % 26);
            plainText = kq;
            return kq;
        }
    }
}
