
public struct MyStructPoint : IPoint
{
    public int X { init; get; }
    public int Y { init; get; }
    public int Y2 { init; get; }

    public MyStructPoint(int x1, int y1)
    {
        X = x1;
        Y = y1;
    }
}

public class MyClassPoint : IPoint
{
    public int X { init; get; }
    public int Y { init; get; }
    public int Y2 { init; get; }

}

public record class MyRecordClassPoint : IPoint
{
    public int X { init; get; }
    public int Y { init; get; }
    public int Y2 { init; get; }
}

public record struct MyRecordStructPoint : IPoint
{
    public int X { init; get; }
    public int Y { init; get; }
    public int Y2 { init; get; }
}