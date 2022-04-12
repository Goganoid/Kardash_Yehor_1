namespace Lab1;

using Newtonsoft.Json;

public class Vector3
{
    private double _x;
    private double _y;
    private double _z;
    
    public double X => _x;
    public double Y => _y;
    public double Z => _z;

    public Vector3(double x, double y, double z)
    {
        _x = x;
        _y = y;
        _z = z;
    }

    public static Vector3 operator +(Vector3 a, Vector3 b)
    {
        return new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
    }
    public static Vector3 operator -(Vector3 a, Vector3 b)
    {
        return new Vector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
    }
    public static double Scalar(Vector3 a, Vector3 b)
    {
        return a.X * b.X + a.Y * b.Y + a.Z + b.Z;
    }

    public static double Length(Vector3 a)
    {
        return Math.Sqrt(a.X * a.X + a.Y * a.Y + a.Z * a.Z);
    }

    public static double Cos(Vector3 a, Vector3 b)
    {
        return Scalar(a, b) / (Length(a) * Length(b));
    }
    
    public double Scalar(Vector3 b)
    {
        return Scalar(this, b);
    }

    public double Length()
    {
        return Length(this);
    }

    public double Cos(Vector3 b)
    {
        return Cos(this, b);
    }

    public string ToJson()
    {
        return JsonConvert.SerializeObject(this);
    }

    public void SaveJson(string filePath)
    {
        File.WriteAllText(filePath,ToJson());
    }
    public static Vector3? FromFile(string filePath)
    {
        return JsonConvert.DeserializeObject<Vector3>(File.ReadAllText(filePath));
    }
    public static Vector3? FromJson(string json)
    {
        return JsonConvert.DeserializeObject<Vector3>(json);
    }
    public override string ToString()
    {
        return $"{X},{Y},{Z}";
    }
}