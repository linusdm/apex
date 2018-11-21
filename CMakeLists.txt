cmake_minimum_required(VERSION 3.12)
include(GNUInstallDirs)
enable_testing()

# make sure everything can be linked for all shared libraries
set(CMAKE_SHARED_LINKER_FLAGS "${CMAKE_SHARED_LINKER_FLAGS} -Wl,-z,defs")

set(CMAKE_LIBRARY_OUTPUT_DIRECTORY ${CMAKE_HOME_DIRECTORY}/bin-cmake/debug)
set(CMAKE_RUNTIME_OUTPUT_DIRECTORY ${CMAKE_HOME_DIRECTORY}/bin-cmake/debug)
set(CMAKE_MODULE_PATH ${CMAKE_CURRENT_SOURCE_DIR}/cmake-modules
                      ${CMAKE_MODULE_PATH})

project(apex-project)

find_package(FFTW3 REQUIRED)
find_package(FFTW3f REQUIRED)
find_package(Jack REQUIRED)
find_package(Libgit2 REQUIRED)
find_package(LibXml2 REQUIRED)
find_package(OpenSSL REQUIRED)
find_package(Portaudio REQUIRED)
find_package(Protobuf REQUIRED)
find_package(Sndfile REQUIRED)
find_package(Qt5 COMPONENTS
    Core
    Multimedia
    Network
    PrintSupport
    Script
    ScriptTools
    Svg
    Test
    WebKitWidgets
    WebSockets
    Widgets
    Xml
    XmlPatterns
    REQUIRED)

add_subdirectory(bertha-lib)
add_subdirectory(coh)
add_subdirectory(common)
add_subdirectory(src)

