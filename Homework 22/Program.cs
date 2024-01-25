using Homework_22;


static double GetCircleCount(Shape[] shapes)
{
    int count=0;

    for (int i = 0; i < shapes.Length; i++)
    {
        if (shapes[i] is Circle)
            count++;
    }
}

static double GetCircles(Shape[] shapes, Shape[] circles)
{
    for (int i = 0;i < shapes.Length;i++)
    {
        if ((shapes[i] is Circle))
            shapes[i] = circles[i];
    }
}

static int GetSquareCount(Shape[] shapes)
{
    for(int i = 0;i<shapes.Length ; i++)
    {
        if (shapes[i] is Rectangle) 
            Rectangle.FindSquare();
    }
}

static int AddShape(Shape[] shapes, Shape shape)
{
    Array.Resize(ref shapes, shapes.Length+1);
    shapes [shapes.Length-1] = shape;
}