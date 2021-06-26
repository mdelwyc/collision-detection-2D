namespace CollisionDetection2D
{
    public interface ICollision
    {
        bool CollisionDetection(ICollision collision);
        bool CollisionDetectionPoint(Point point);
        bool CollisionDetectionCircle(Circle circle);
        bool CollisionDetectionRectangle(Rectangle rect);
        bool CollisionDetectionLine(Line line);
        bool CollisionDetectionPolygon(Polygon polygon);
        bool CollisionDetectionTriangle(Triangle triangle);
    }
}
