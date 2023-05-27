using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Model.Classes
{
    /// <summary>
    /// Хранит данные о текущей песне.
    /// </summary>
    public class Data
    {
        /// <summary>
        /// Возвращает и задает объект класса <see cref="Song"/>. 
        /// </summary>
        public static Song Value { get; set; }

        /// <summary>
        /// Возвращает и задает флаг.
        /// </summary>
        public static bool Flag { get; set; }
    }
}
