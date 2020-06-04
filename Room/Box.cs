using System.Drawing;

namespace Room
{
    public class Box : IPaintable
    {
        private int _height;
        public int Height
        {
            get
            {
                return _height;
            }
        }
        private int _width;
        public int Width
        {
            get
            {
                return _width;
            }
        }
        private int _depth;
        public int Depth {
            get
            {
                return _depth;
            }
        }

        private Color color;
        public Color Color {
            get
            {
                return color;
            }
        }
         
        public Box(int height, int width, int depth, Material material)
        {
            this._height = height;
            this._width = width;
            this._depth = depth;
            
        }

        public void Paint(Color c)
        {
            color = c;
            System.Console.WriteLine(this.Color);
        }
    }
}
