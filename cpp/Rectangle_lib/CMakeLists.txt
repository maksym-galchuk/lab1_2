add_library(Rectangle_lib STATIC Rectangle.cpp Rectangle.h)
target_include_directories(Rectangle_lib PUBLIC ${CMAKE_CURRENT_SOURCE_DIR})