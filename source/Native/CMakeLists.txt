cmake_minimum_required(VERSION 3.8)

# Would export all symbols, see  https://blog.kitware.com/create-dlls-on-windows-without-declspec-using-new-cmake-export-all-feature/
# extern "C" still needs to be defined (same on non-windows too)
#set(CMAKE_WINDOWS_EXPORT_ALL_SYMBOLS ON)

configure_file(version.cpp.in version.cpp)

add_library(Native SHARED
    "math.cpp"
    "${CMAKE_CURRENT_BINARY_DIR}/version.cpp"
)

target_include_directories(Native PRIVATE ${CMAKE_CURRENT_SOURCE_DIR})

# This will name your output .so files "libsomething.1.0" which is pretty useful
set_target_properties(Native
    PROPERTIES
        VERSION   ${PROJECT_VERSION}
        SOVERSION ${SO_VERSION}
)
