using System;
using System.Collections.Generic;
using System.Text;

namespace IsTakip.Business.Interfaces
{
    public interface IDosyaService
    {
        /// <summary>
        /// Geriye üretmiş ve update etmiş olduğu pdf dosyasının virtual pathini döner
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        string AktarPdf<T>(List<T> list) where T : class, new();

        /// <summary>
        /// Geriye Excel verisini byte dizisi olarak döner.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        byte[] AktarExcel<T>(List<T> list) where T : class, new();
    }
}
