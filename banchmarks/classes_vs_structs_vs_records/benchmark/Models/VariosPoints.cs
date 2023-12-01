
public struct MyStructPoint : IPoint
{
    public int Property1 { get; }
    public double Property2 { get; }
    public char Property3 { get; }
    public long Property4 { get; }
    public float Property5 { get; }
    public short Property6 { get; }
    public uint Property7 { get; }
    public bool Property8 { get; }
    public byte Property9 { get; }
    public decimal Property10 { get; }

    public int X { init; get; }
    public int Y { init; get; }

    public MyStructPoint(int x1, int y1)
    {
        X = x1;
        Y = y1;
    }
}

public class MyClassPoint : IPoint
{
    public int Property1 { get; }
    public double Property2 { get; }
    public char Property3 { get; }
    public long Property4 { get; }
    public float Property5 { get; }
    public short Property6 { get; }
    public uint Property7 { get; }
    public bool Property8 { get; }
    public byte Property9 { get; }
    public decimal Property10 { get; }

    public int X { init; get; }
    public int Y { init; get; }

}

public record class MyRecordClassPoint : IPoint
{
    public int Property1 { get; }
    public double Property2 { get; }
    public char Property3 { get; }
    public long Property4 { get; }
    public float Property5 { get; }
    public short Property6 { get; }
    public uint Property7 { get; }
    public bool Property8 { get; }
    public byte Property9 { get; }
    public decimal Property10 { get; }

    public int X { init; get; }
    public int Y { init; get; }
}

public record struct MyRecordStructPoint : IPoint
{
    public int Property1 { get; }
    public double Property2 { get; }
    public char Property3 { get; }
    public long Property4 { get; }
    public float Property5 { get; }
    public short Property6 { get; }
    public uint Property7 { get; }
    public bool Property8 { get; }
    public byte Property9 { get; }
    public decimal Property10 { get; }

    public int X { init; get; }
    public int Y { init; get; }
}