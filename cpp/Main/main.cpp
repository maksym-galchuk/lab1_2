#include <iostream>
#include <cstdio>
#include "Rectangle.h"

void split(std::string str, double arr[], char delimiter);
int main(){
    while (true){
        printf("Enter the coordinates in the following format: x1, y1, x2, y2. To end the program, enter 'Stop'.\n");
        std::string input;
        std::cin >> input;
        if (input == "Stop"){
            printf("Program ended.\n");
            break;
        }
        double coordinates[4];
        try{
            split(input, coordinates, ',');
        } catch (std::invalid_argument e) {
            printf("Invalid input. Try again.\n\n");
            continue;
        }

        Rectangle r(coordinates[0], coordinates[1], coordinates[2], coordinates[3]);
        if (r.isRectangle()){
            printf("Coordinates: (%.1f; %.1f), (%.1f; %.1f), (%.1f; %.1f), (%.1f; %.1f) \n",
                   r.getX1(), r.getY1(), r.getX1(), r.getY2(), r.getX2(), r.getY2(), r.getX2(), r.getY1());
            printf("Width: %.1f\n", r.width());
            printf("Height: %.1f\n", r.height());
            printf("Area: %.1f\n", r.area());
            printf("Perimeter: %.1f\n\n", r.perimeter());
        } else {
            printf("The coordinates do not form a rectangle. Try again.\n\n");
        }
    }
    return 0;
};

void split(std::string str, double arr[], char delimiter){
    int i = 0;
    std::string temp;
    for (char j : str){
        if (j == delimiter) {
            arr[i] = std::stod(temp);
            temp = "";
            i++;
        } else {
            temp += j;
        }
    }
    arr[i] = std::stod(temp);
}

