// See https://aka.ms/new-console-template for more information
var rectangle = Factory.GetRectangle(5);
Console.WriteLine(rectangle);


Console.WriteLine(rectangle.GetArea());

//Bir sınıf, kendisinden miras alan bir başka sınıfın yerine birebir kullanılabilir olmalıdır. Başka değişle miras alan sınıf, base'in metodlarına müdahale edemez.

public interface IAreaCalcutable
{
    int GetArea();
}
public class Rectangle : IAreaCalcutable
{
    protected int width;
    public virtual int Width { get => width; set => width = value; }
    public virtual int Height { get => height; set => height = value; }
    protected int height;

    public int GetArea() => Width * Height;
}


public class Square : IAreaCalcutable //: Rectangle
{
    public int Width { get; set; }

    public int GetArea()
    {
        return Width * Width;
    }
    //public int Height { get => base.Height; set { base.Height = value; base.width = value; } }


}

public class Factory
{
    public static IAreaCalcutable GetRectangle(int width, int? height = null)
    {
        //bir biçimde....
        return height != null ? new Rectangle { Width = width, Height = height.Value }
                              :
                                new Square { Width = width };
    }
}