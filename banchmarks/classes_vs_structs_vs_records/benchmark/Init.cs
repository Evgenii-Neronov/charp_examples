
public partial class BenchmarkExample<T> where T : IPoint, new()
{ 
    public static void Init()
    {
        var rnd = new Random();

        for (int i = 0; i < Length; i++)
        {
            Array[i] = new T()
            {
                
                X = rnd.Next(1000),
                Y = rnd.Next(1000),
            };
        }
    }
}