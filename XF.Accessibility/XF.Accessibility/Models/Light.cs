using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XF.Accessibility.Models
{
    public class Light
    {
        public string Name { get; set; }
        public Color Color { get; set; }

        public static Light Red => new Light() { Name = "Red", Color = Color.Red };
        public static Light Yellow => new Light() { Name = "Yellow", Color = Color.Yellow };
        public static Light Green => new Light() { Name = "Green", Color = Color.Green};
    }
}
