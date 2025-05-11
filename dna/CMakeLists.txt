cmake_minimum_required(VERSION 4.0)

project(DotNetAnywhere LANGUAGES C)

set(DNA_PUBLIC_HEADERS
  CLIFile.h
  Compat.h
  Config.h
  Delegate.h
  EvalStack.h
  Finalizer.h
  Generics.h
  Heap.h
  InternalCall.h
  JIT.h
  JIT_OpCodes.h
  MetaData.h
  MetaDataTables.h
  MethodState.h
  PInvoke_CaseCode.h
  PInvoke.h
  PInvoke_TypeDef.h
  Reflection.h
  RVA.h
  Sys.h
  System.Array.h
  System.Attribute.h
  System.Char.CaseConversion.h
  System.Char.h
  System.Char.UC_IndexRuns.h
  System.Console.h
  System.DateTime.h
  System.Diagnostics.Debugger.h
  System.Enum.h
  System.Environment.h
  System.GC.h
  System.IO.FileInternal.h
  System.Math.h
  System.Net.Dns.h
  System.Net.Sockets.Socket.h
  System.Object.h
  System.Reflection.MemberInfo.h
  System.Reflection.MethodBase.h
  System.Reflection.MethodInfo.h
  System.Reflection.PropertyInfo.h
  System.Runtime.CompilerServices.RuntimeHelpers.h
  System.RuntimeType.h
  System.String.h
  System.Threading.Interlocked.h
  System.Threading.Monitor.h
  System.Threading.Thread.h
  System.Type.h
  System.ValueType.h
  System.WeakReference.h
  Thread.h
  Type.h
  Types.h
)

add_library(${PROJECT_NAME}
  CLIFile.c
  Delegate.c
  dna.c
  Finalizer.c
  Generics.c
  Heap.c
  InternalCall.c
  JIT.c
  JIT_Execute.c
  MetaData.c
  MetaData_Fill.c
  MetaData_Search.c
  MethodState.c
  PInvoke.c
  Reflection.c
  RVA.c
  Sys.c
  System.Array.c
  System.Char.c
  System.Console.c
  System.DateTime.c
  System.Diagnostics.Debugger.c
  System.Enum.c
  System.Environment.c
  System.GC.c
  System.IO.FileInternal.c
  System.Math.c
  System.Net.Dns.c
  System.Net.Sockets.Socket.c
  System.Object.c
  System.Runtime.CompilerServices.RuntimeHelpers.c
  System.RuntimeType.c
  System.String.c
  System.Threading.Interlocked.c
  System.Threading.Monitor.c
  System.Threading.Thread.c
  System.Type.c
  System.ValueType.c
  System.WeakReference.c
  Thread.c
  Type.c
)
target_include_directories(${PROJECT_NAME} PUBLIC ${CMAKE_CURRENT_SOURCE_DIR})
if (CMAKE_C_COMPILER_ID MATCHES "Clang|GNU")
  target_compile_options(${PROJECT_NAME} PRIVATE -Wno-int-to-pointer-cast)
endif()
if (UNIX)
  target_link_libraries(${PROJECT_NAME} PUBLIC dl m)
endif()
set_target_properties(${PROJECT_NAME} PROPERTIES
  PUBLIC_HEADER "${DNA_PUBLIC_HEADERS}"
)
include(GNUInstallDirs)
install(TARGETS ${PROJECT_NAME}
  EXPORT ${PROJECT_NAME}
  PUBLIC_HEADER
    DESTINATION ${CMAKE_INSTALL_INCLUDEDIR}/DNA
)

add_executable(dna
  dna.c
)
target_link_libraries(dna PRIVATE DotNetAnywhere)
install(TARGETS dna)
