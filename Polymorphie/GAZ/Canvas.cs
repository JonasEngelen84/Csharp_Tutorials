using System.Collections.Generic;

namespace Polymorphie.GAZ
{
    class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (Shape shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
