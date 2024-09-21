using ShapeArea.Entities.Enum;
using ShapeArea.Entities;

namespace ShapeArea.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius,Color color)
            : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
           return (Radius*Radius) * Math.PI  ;
        }
    }
}
