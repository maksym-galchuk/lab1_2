#include "Rectangle.h"
#include <cmath>

Rectangle::Rectangle(const Rectangle& r){
    x1 = r.x1;
    y1 = r.y1;
    x2 = r.x2;
    y2 = r.y2;
}

Rectangle::Rectangle(double x1, double y1, double x2, double y2){
    this->x1 = x1;
    this->y1 = y1;
    this->x2 = x2;
    this->y2 = y2;
}

double Rectangle::getX1(){ return x1; }
double Rectangle::getY1(){ return y1; }
double Rectangle::getX2(){ return x2; }
double Rectangle::getY2(){ return y2; }

void Rectangle::setX1(double x1){ this->x1 = x1; }
void Rectangle::setY1(double y1){ this->y1 = y1; }
void Rectangle::setX2(double x2){ this->x2 = x2; }
void Rectangle::setY2(double y2){ this->y2 = y2; }

double Rectangle::width(){ return std::abs(x2 - x1); }
double Rectangle::height(){ return std::abs(y2 - y1); }
double Rectangle::area(){ return width() * height(); }
double Rectangle::perimeter(){ return 2 * (width() + height()); }
bool Rectangle::isRectangle(){ return width() > 0 && height() > 0; }


