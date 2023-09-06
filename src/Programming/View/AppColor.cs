using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Programming.View
{
    /// <summary>
    /// Хранит данные об используемых цветах.
    /// </summary>
    public static class AppColor
    {
        /// <summary>
        /// Белый цвет.
        /// </summary>
        public static Color White = Color.White;

        /// <summary>
        /// Зеленый цвет.
        /// </summary>
        public static Color SpringGreen = ColorTranslator.FromHtml("#559c45");

        /// <summary>
        /// Оранжевый цвет.
        /// </summary>
        public static Color AutumnOrange = ColorTranslator.FromHtml("#e29c45");

        /// <summary>
        /// Светло-красный цвет.
        /// </summary>
        public static Color LightPink = Color.LightPink;

        /// <summary>
        /// Светло-зеленый цвет.
        /// </summary>
        public static Color LightGreen = Color.FromArgb(127, 127, 255, 127);

        /// <summary>
        /// Красный цвет.
        /// </summary>
        public static Color Red = Color.FromArgb(127, 255, 127, 127);
    }
}
