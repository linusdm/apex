project(apex LANGUAGES CXX)

set(CMAKE_AUTOMOC ON)
set(CMAKE_AUTOUIC ON)

# berthaplugins
add_library(apex-berthaplugins-compatibledatablock SHARED
	berthaplugins/apexcompatibledatablockplugin/apexcompatibledatablockplugin.cpp)
add_library(apex-berthaplugins-soundcard SHARED
	berthaplugins/apexsoundcardplugin/apexsoundcardplugin.cpp)
add_library(apex-berthaplugins-adapter SHARED
	berthaplugins/apexadapterplugin/apexadapterplugin.cpp)

set(BERTHAPLUGIN_LIBS
    apex-common
    apex-tools
    bertha-lib
    Qt5::Core
    ${SNDFILE_LIBRARIES})

target_link_libraries(apex-berthaplugins-compatibledatablock    PRIVATE ${BERTHAPLUGIN_LIBS})
target_link_libraries(apex-berthaplugins-soundcard              PRIVATE ${BERTHAPLUGIN_LIBS})
target_link_libraries(apex-berthaplugins-adapter                PRIVATE ${BERTHAPLUGIN_LIBS})

# apex-data
file(GLOB_RECURSE APEX_DATA_SOURCES RELATIVE ${CMAKE_CURRENT_SOURCE_DIR} "lib/apexdata/*.cpp")

add_library(apex-data SHARED ${APEX_DATA_SOURCES})

target_include_directories(apex-data
    PUBLIC  ${CMAKE_CURRENT_SOURCE_DIR}/lib
    PRIVATE ${CMAKE_CURRENT_SOURCE_DIR}/lib/apexdata)

target_link_libraries(apex-data PRIVATE
	apex-common
	apex-tools
	coh-lib
    Qt5::Core
    Qt5::Xml)

# apex-main
set(CMAKE_AUTOUIC_SEARCH_PATHS lib/apexmain/gui)

file(GLOB_RECURSE APEX_MAIN_SOURCES RELATIVE ${CMAKE_CURRENT_SOURCE_DIR} "lib/apexmain/*.cpp")

list(REMOVE_ITEM APEX_MAIN_SOURCES
    lib/apexmain/apexandroidnative.cpp
    lib/apexmain/corrector/corrector.cpp
    lib/apexmain/gui/flashwidget.cpp
    lib/apexmain/screen/flashplayerrundelegate.cpp)

add_library(apex-main SHARED
    ${APEX_MAIN_SOURCES}
    lib/apexmain/wavstimulus/soundcarddialog.h # added to force UIC of soundcarddialog.ui (is soundcarddialog.h needed anyway?)
    lib/apexmain/stimulus/outputdevice.h)      # added to force MOC

target_include_directories(apex-main
    PUBLIC ${CMAKE_CURRENT_SOURCE_DIR}/lib
    PRIVATE ${CMAKE_CURRENT_SOURCE_DIR}/lib/apexmain)

target_link_libraries(apex-main
    PUBLIC
        Qt5::Xml
    PRIVATE
        apex-common
        apex-commongui
        apex-tools
        apex-data
        apex-writers
        bertha-lib
        coh-lib
        psignifit
        streamapp
        Qt5::Core
        Qt5::XmlPatterns
        Qt5::Network
        Qt5::Widgets
        Qt5::WebKitWidgets
        Qt5::Svg
        Qt5::Script
        Qt5::ScriptTools
        Qt5::PrintSupport
        LibXml2::LibXml2
        ${LIBGIT2_LIBRARIES}
        ${PORTAUDIO_LIBRARIES})

# apex-tools
file(GLOB_RECURSE APEX_TOOLS_SOURCES RELATIVE ${CMAKE_CURRENT_SOURCE_DIR} "lib/apextools/*.cpp")

add_library(apex-tools SHARED ${APEX_TOOLS_SOURCES})

target_include_directories(apex-tools
    PUBLIC ${CMAKE_CURRENT_SOURCE_DIR}/lib
    PRIVATE ${CMAKE_CURRENT_SOURCE_DIR}/lib/apextools)

target_link_libraries(apex-tools
    PRIVATE
        apex-common
        Qt5::Widgets
        Qt5::Xml
        Qt5::XmlPatterns
        Qt5::Script
        OpenSSL::SSL
        OpenSSL::Crypto
        LibXml2::LibXml2)

# apex-writers
file(GLOB_RECURSE APEX_WRITERS_SOURCES RELATIVE ${CMAKE_CURRENT_SOURCE_DIR} "lib/apexwriters/*.cpp")

add_library(apex-writers SHARED ${APEX_WRITERS_SOURCES})

target_link_libraries(apex-writers PRIVATE
        apex-data
        apex-common
        apex-tools
        Qt5::Core
        Qt5::Xml
        Qt5::Widgets)

# psignifit
file(GLOB_RECURSE PSIGNIFIT_SOURCES "${CMAKE_HOME_DIRECTORY}/contrib/psignifit/*.c")

list(REMOVE_ITEM PSIGNIFIT_SOURCES
    ${CMAKE_HOME_DIRECTORY}/contrib/psignifit/main.c)

add_library(psignifit SHARED
    lib/psignifit/psignifitwrapper.cpp
    ${PSIGNIFIT_SOURCES})

target_include_directories(psignifit
    PUBLIC ${CMAKE_CURRENT_SOURCE_DIR}/lib
    PRIVATE ${CMAKE_HOME_DIRECTORY}/contrib/psignifit)

target_link_libraries(psignifit PRIVATE
    apex-common
    Qt5::Core)

# streamapp
file(GLOB_RECURSE STREAMAPP_SOURCES RELATIVE ${CMAKE_CURRENT_SOURCE_DIR} "lib/streamapp/*.cpp")

list(REMOVE_ITEM STREAMAPP_SOURCES
    lib/streamapp/_archs/osx/osx_coreaudiowrapper.cpp
    lib/streamapp/_archs/win32/win32_asiowrapper.cpp
    lib/streamapp/_archs/win32/win32_cputicker.cpp
    lib/streamapp/_archs/win32/win32_ctimer1.cpp
    lib/streamapp/_archs/win32/win32_misc.cpp
    lib/streamapp/_archs/win32/win32_threads.cpp
    lib/streamapp/_fromv3/_archs/win32/automation/clsid.cpp
    lib/streamapp/_fromv3/core/text/wchars.cpp)

add_library(streamapp SHARED ${STREAMAPP_SOURCES})

target_include_directories(streamapp
    PRIVATE ${CMAKE_CURRENT_SOURCE_DIR}/lib/streamapp)

target_link_libraries(streamapp PRIVATE
	apex-common
	apex-tools
	Qt5::Core
	${PORTAUDIO_LIBRARIES}
    ${JACK_LIBRARIES})

# apex-caladmin
file(GLOB_RECURSE APEX_CALADMIN_SOURCES RELATIVE ${CMAKE_CURRENT_SOURCE_DIR} "lib/apexcaladmin/*.cpp")

add_library(apex-caladmin SHARED ${APEX_CALADMIN_SOURCES})

target_include_directories(apex-caladmin
    PUBLIC ${CMAKE_CURRENT_SOURCE_DIR}/lib)

target_link_libraries(apex-caladmin PRIVATE
    apex-common
    apex-tools
    Qt5::Core)

# apex-spin
file(GLOB_RECURSE APEX_SPIN_SOURCES RELATIVE ${CMAKE_CURRENT_SOURCE_DIR} "lib/apexspin/*.cpp")

add_library(apex-spin SHARED ${APEX_SPIN_SOURCES})

target_link_libraries(apex-spin PRIVATE
    apex-common
    apex-tools
    apex-main
    apex-data
    apex-writers
    Qt5::Widgets
    Qt5::Xml)

target_include_directories(apex-spin
    PRIVATE ${CMAKE_CURRENT_SOURCE_DIR}/lib/apexspin)

# plugins
add_subdirectory(plugins)

# apex
add_executable(apex programs/apex/apex.cpp)

target_link_libraries(apex PRIVATE
    apex-main
    apex-common
    apex-data
    apex-tools
    apex-writers
    apex-commongui
    bertha-lib
    coh-lib
    streamapp
    psignifit
    Qt5::Core
    Qt5::Widgets)

# activeqt-flash
# TODO
message("TODO: activeqt-flash")

# apexupgrader
add_executable(apexupgrader programs/apexupgrader/main.cpp)

target_link_libraries(apexupgrader PRIVATE
    apex-common
    apex-main
    apex-tools
    apex-spin)

# arclayout
add_executable(arclayout programs/arclayout/testarclayout.cpp)

target_link_libraries(arclayout PRIVATE
    apex-common
    apex-tools
    Qt5::Widgets)

# bkslmslave
# TODO
message("TODO: bkslmslave")

# calibrationadmin
add_executable(calibrationadmin
    programs/calibrationadmin/main.cpp
    programs/calibrationadmin/mainwindow.cpp)

target_link_libraries(calibrationadmin PRIVATE
    apex-common
    apex-tools
    apex-caladmin
    Qt5::Core
    Qt5::Widgets)

# dummyslmslave
# TODO
message("TODO: dummyslmslave")

# experimentupgrader
# TODO
message("TODO: experimentupgrader")

# largeslm
add_executable(largeslm programs/largeslm/largeslm.cpp)

target_link_libraries(largeslm PRIVATE
    apex-main
    apex-common
    apex-tools
    Qt5::Core
    Qt5::Widgets)

# ledcontrollertest
# TODO
message("TODO: ledcontrollertest")

# picturebutton
add_executable(picturebutton programs/picturebutton/picturebutton.cpp)

target_link_libraries(picturebutton PRIVATE
    apex-main
    apex-common
    Qt5::Widgets)

# qtaudio
add_executable(qtaudio
    programs/qtaudio/main.cpp
    programs/qtaudio/callbackbuffer.cpp)

target_link_libraries(qtaudio PRIVATE
    apex-tools
    apex-common
    Qt5::Core
    Qt5::Multimedia)

# resultschecker
add_executable(resultschecker
    programs/resultschecker/resultschecker.cpp)

target_link_libraries(resultschecker PRIVATE
    apex-tools
    apex-common
    Qt5::Xml)

# screeneditor
file(GLOB_RECURSE SCREENEDITOR_SOURCES RELATIVE ${CMAKE_CURRENT_SOURCE_DIR} "programs/screeneditor/*.cpp")

add_executable(screeneditor ${SCREENEDITOR_SOURCES})

target_link_libraries(screeneditor PRIVATE
    apex-data
    apex-common
    apex-tools
    apex-main
    apex-writers
    Qt5::Core
    Qt5::Widgets
    Qt5::Xml)

# statemachinevisualizer
add_executable(statemachinevisualizer
    programs/statemachinevisualizer/main.cpp
    programs/statemachinevisualizer/statemachinevisualizer.cpp)

target_link_libraries(statemachinevisualizer PRIVATE
    apex-main
    apex-common)

# apex-data-tests
add_executable(apex-data-tests tests/apexdata/apexdatatest.cpp)

target_link_libraries(apex-data-tests PRIVATE
    apex-common
    apex-tools
    apex-data
    Qt5::Test
    Qt5::Core)

add_test(NAME apex-data-tests COMMAND $<TARGET_FILE:apex-data-tests>)

# apex-main-tests
file(GLOB_RECURSE APEX_MAIN_TESTS_SOURCES RELATIVE ${CMAKE_CURRENT_SOURCE_DIR} "tests/apexmain/*.cpp")

add_executable(apex-main-tests ${APEX_MAIN_TESTS_SOURCES})

target_link_libraries(apex-main-tests PRIVATE
    apex-main
    apex-common
    apex-commongui
    apex-tools
    apex-data
    apex-writers
    bertha-lib
    coh-lib
    psignifit
    streamapp
    Qt5::Test
    Qt5::Core
    Qt5::XmlPatterns
    Qt5::Network
    Qt5::Widgets
    Qt5::WebKitWidgets
    Qt5::Svg
    Qt5::Script
    Qt5::ScriptTools
    Qt5::PrintSupport
    ${SNDFILE_LIBRARIES})

add_test(NAME apex-main-tests COMMAND $<TARGET_FILE:apex-main-tests>)

# apex-tools-tests
add_executable(apex-tools-tests
    tests/apextools/apextoolstest.cpp)

target_link_libraries(apex-tools-tests PRIVATE
    apex-tools
    apex-common
    Qt5::Test
    Qt5::Core
    Qt5::Xml
    OpenSSL::SSL
)

add_test(NAME apex-tools-tests COMMAND $<TARGET_FILE:apex-tools-tests>)

# apex-writers-tests
add_executable(apex-writers-tests
    tests/apexwriters/apexwriterstest.cpp)

target_link_libraries(apex-writers-tests PRIVATE
    apex-data
    apex-common
    apex-writers
    apex-main
    Qt5::Xml
    Qt5::Test)

add_test(NAME apex-writers-tests COMMAND $<TARGET_FILE:apex-writers-tests>)

# berthaplugins-tests
add_executable(berthaplugins-tests
    tests/berthaplugins/berthapluginstest.cpp)

target_link_libraries(berthaplugins-tests PRIVATE
    bertha-lib
    apex-common    
    Qt5::Test
    ${SNDFILE_LIBRARIES}
)

add_test(NAME berthaplugins-tests COMMAND $<TARGET_FILE:berthaplugins-tests>)

# calibrationadmin-tests
add_executable(calibrationadmin-tests
    tests/calibrationadmin/calibrationadmintest.cpp)

target_link_libraries(calibrationadmin-tests PRIVATE
    apex-caladmin
    apex-common
    apex-tools
    Qt5::Gui
    Qt5::Widgets
    Qt5::Test)

add_test(NAME calibrationadmin-tests COMMAND $<TARGET_FILE:calibrationadmin-tests>)

# osccontroller-tests
add_executable(osccontroller-tests
    tests/osccontroller/osccontrollertest.cpp)

target_link_libraries(osccontroller-tests PRIVATE
    apex-main
    apex-common    
    Qt5::Test)

add_test(NAME osccontroller-tests COMMAND $<TARGET_FILE:osccontroller-tests>)

# plugin-tests
# TODO
message("TODO: plugin-tests")

# procedures-tests
add_executable(procedures-tests
    tests/procedures/procedurestest.cpp)

target_link_libraries(procedures-tests PRIVATE
    apex-data
    apex-common
    apex-tools
    apex-main
    Qt5::Xml
    Qt5::Test)

add_test(NAME procedures-tests COMMAND $<TARGET_FILE:procedures-tests>)

# psignifit-tests
add_executable(psignifit-tests
    tests/psignifit/psignifittest.cpp)

target_link_libraries(psignifit-tests PRIVATE
    psignifit
    apex-common
    apex-tools
    Qt5::Test)

add_test(NAME psignifit-tests COMMAND $<TARGET_FILE:psignifit-tests>)

# spin-tests
add_executable(spin-tests
    tests/spin/spintest.cpp)

target_link_libraries(spin-tests PRIVATE
    apex-data
    apex-common
    apex-tools
    apex-main
    apex-spin
    psignifit
    Qt5::Xml
    Qt5::Test)

add_test(NAME spin-tests COMMAND $<TARGET_FILE:spin-tests>)

