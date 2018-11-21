project(apex-common LANGUAGES CXX)

set(CMAKE_AUTOUIC ON)
set(CMAKE_AUTOMOC ON)
protobuf_generate_cpp(PROTO_SRCS PROTO_HDRS data/protoslave.proto)

# apex-common
file(GLOB_RECURSE APEX_COMMON_SOURCES RELATIVE ${CMAKE_CURRENT_SOURCE_DIR} "lib/common/*.cpp")

add_library(apex-common SHARED
    ${APEX_COMMON_SOURCES}
    ${PROTO_HDRS}
    ${PROTO_SRCS})

target_include_directories(apex-common
    PRIVATE
        ${CMAKE_CURRENT_BINARY_DIR} # protobuf headers and soures are generated here
    PUBLIC
        ${CMAKE_CURRENT_SOURCE_DIR}/lib)

target_link_libraries(apex-common PRIVATE
	Qt5::Core
	Qt5::Xml
	Qt5::Network
	Qt5::WebSockets
	${SNDFILE_LIBRARIES}
    protobuf::libprotobuf)

# apex-commongui
file(GLOB_RECURSE APEX_COMMONGUI_SOURCES RELATIVE ${CMAKE_CURRENT_SOURCE_DIR} "lib/commongui/*.cpp")

add_library(apex-commongui SHARED ${APEX_COMMONGUI_SOURCES})

target_link_libraries(apex-commongui PRIVATE
    apex-common
    Qt5::Core
    Qt5::Widgets
    Qt5::WebKitWidgets
    Qt5::Network)

# testcolorizer
add_executable(apex-common-programs-testcolorizer
    programs/testcolorizer/testcolorizer.cpp)

target_link_libraries(apex-common-programs-testcolorizer PRIVATE
    Qt5::Core
)

# apex-common-tests
file(GLOB_RECURSE APEX_COMMON_TESTS_SOURCES RELATIVE ${CMAKE_CURRENT_SOURCE_DIR} "tests/common/*.cpp")

add_executable(apex-common-tests ${APEX_COMMON_TESTS_SOURCES})

target_link_libraries(apex-common-tests PRIVATE
    apex-common
    Qt5::Core
    Qt5::Network
    Qt5::WebSockets
    Qt5::Test
    ${SNDFILE_LIBRARIES})

add_test(NAME apex-common-tests COMMAND $<TARGET_FILE:apex-common-tests>)

# apex-commongui-tests
file(GLOB_RECURSE APEX_COMMONGUI_TESTS_SOURCES RELATIVE ${CMAKE_CURRENT_SOURCE_DIR} "tests/commongui/*.cpp")

add_executable(apex-commongui-tests
    ${APEX_COMMONGUI_TESTS_SOURCES}
    tests/commongui/commonguitest.h)

target_link_libraries(apex-commongui-tests PRIVATE
    apex-common
    apex-commongui
    Qt5::Core
    Qt5::Widgets
    Qt5::WebKitWidgets
    Qt5::Network
    Qt5::Test)

add_test(NAME apex-commongui-tests COMMAND $<TARGET_FILE:apex-commongui-tests>)

