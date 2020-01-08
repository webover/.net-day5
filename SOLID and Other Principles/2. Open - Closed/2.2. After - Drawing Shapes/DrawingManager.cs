using OpenClosedDrawingShapesAfter.Contracts;

namespace OpenClosedDrawingShapesAfter
{
    public class DrawingManager : IDrawingManager
    {
        public void Draw(IShape shape)
        {
            shape.Draw();
        }
    }
}
