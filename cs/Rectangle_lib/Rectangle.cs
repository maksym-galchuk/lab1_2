namespace Rectangle_lib;

public class Rectangle {
    private double x1, y1, x2, y2;
    
    public Rectangle(Rectangle r) {
        this.x1 = r.x1;
        this.y1 = r.y1;
        this.x2 = r.x2;
        this.y2 = r.y2;
    }
    public Rectangle(double x1, double y1, double x2, double y2) {
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
    }
    
    public double X1 {
        get => x1;
        set => x1 = value;
    }
    public double Y1 {
        get => y1;
        set => y1 = value;
    }
    public double X2 {
        get => x2;
        set => x2 = value;
    }
    public double Y2 {
        get => y2;
        set => y2 = value;
    }
    
    public double Width => Math.Abs(x2 - x1);
    public double Height => Math.Abs(y2 - y1);

    public bool IsRectangle() {
        return Width != 0 && Height != 0;
    }
    public double Area() {
        return Width * Height;
    }
    public double Perimeter() {
        return 2 * (Width + Height);
    }
    
    public override string ToString() {
        return $"({X1}; {Y1}), ({X1}; {Y2}), ({X2}; {Y2}), ({X2}; {Y1})";
    }
}