cmake_minimum_required(VERSION 3.24)
project(lab1_2)

set(CMAKE_CXX_STANDARD 23)

add_library(Rectangle STATIC ../Rectangle_lib/Rectangle.cpp ../Rectangle_lib/Rectangle.h)
add_executable(lab1_2 main.cpp)
