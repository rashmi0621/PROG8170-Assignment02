using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public class Rectangle
    {
        private int? length, width;
        public Rectangle()
        {
            this.length = 1;
            this.width = 1;
        }
        public Rectangle(int? length, int? width)
        {
            this.length = length;
            this.width = width;
        }

        public int? GetLength()
        {
            return this.length;
        }
        public int? SetLength(int? length)
        {
            this.length = length;
            return this.length;
        }

        public int? GetWidth()
        {
            return this.width;
        }
        public int? SetWidth(int? width)
        {
            this.width = width;
            return this.width;
        }
        public int? GetPerimeter()
        {
            try
            {
                return (this.length + this.width) * 2;
            }
            catch (Exception)
            {

                return null;
            }

        }
        public int? GetArea()
        {
            try
            {
                return this.length * this.width;
            }
            catch (Exception)
            {

                return null;
            }

        }
    }
}
