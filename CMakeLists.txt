cmake_minimum_required(VERSION 3.8)

set(PROJECT_VERSION    "0.1.0")
set(SO_VERSION         "0.1")
set(CMAKE_CXX_STANDARD 11)

message("writing library to ${CMAKE_BINARY_DIR}")
set(CMAKE_RUNTIME_OUTPUT_DIRECTORY "${CMAKE_BINARY_DIR}")
set(CMAKE_LIBRARY_OUTPUT_DIRECTORY "${CMAKE_BINARY_DIR}")

if (NOT "$ENV{BUILD_CONFIG}" STREQUAL "")
    set(BUILD_CONFIG "$ENV{BUILD_CONFIG}" CACHE INTERNAL "copied from env")
else()
    set(BUILD_CONFIG "Debug" CACHE INTERNAL "set default")
endif()
message("CMAKE: Building with config ${BUILD_CONFIG}")

project(NativeLib VERSION ${PROJECT_VERSION})
add_subdirectory(source/Native)
