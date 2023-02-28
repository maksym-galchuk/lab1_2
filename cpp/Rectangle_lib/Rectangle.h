#pragma once
#include <string>

class Rectangle{
private:
    double x1, y1, x2, y2;
public:
    Rectangle(const Rectangle& r);
    Rectangle(double x1, double y1, double x2, double y2);

    double getX1();
    double getY1();
    double getX2();
    double getY2();

    void setX1(double x1);
    void setY1(double y1);
    void setX2(double x2);
    void setY2(double y2);

    double width();
    double height();
    double area();
    double perimeter();
    bool isRectangle();

    std::String toString();
};