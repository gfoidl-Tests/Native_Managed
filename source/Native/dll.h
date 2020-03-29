// Alternative: https://blog.kitware.com/create-dlls-on-windows-without-declspec-using-new-cmake-export-all-feature/
//-----------------------------------------------------------------------------
#pragma once
//-----------------------------------------------------------------------------
#if defined (_MSC_VER)
    #define MATH_API __declspec(dllexport)
#elif defined (__GNUC__)
    #define MATH_API __attribute__((visibility("default")))
#else
    #define MATH_API 
#endif
//-----------------------------------------------------------------------------
#ifdef __cplusplus
    #define BEGIN_EXTERN_C extern "C" {
    #define END_EXTERN_C   }
#else
    #define BEGIN_EXTERN_C
    #define END_EXTERN_C
#endif
