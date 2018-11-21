project(apex-plugins LANGUAGES CXX)

set(CMAKE_AUTOMOC ON)

add_library(apex-plugins-dataloopgenerator          SHARED dataloopgenerator/dataloopgenerator.cpp)
add_library(apex-plugins-vocoderfilter              SHARED vocoderfilter/vocoderfilter.cpp)
add_library(apex-plugins-spinplugin                 SHARED spinplugin/spin.cpp)
add_library(apex-plugins-threadedhrtffilter         SHARED threadedhrtffilter/threadedhrtffilter.cpp)
add_library(apex-plugins-hrtffilter                 SHARED hrtffilter/hrtffilter.cpp)
add_library(apex-plugins-networkdevicecontroller    SHARED networkdevicecontroller/networkdevicecontroller.cpp)
add_library(apex-plugins-protoslmplugin             SHARED protoslmplugin/protoslmplugin.cpp)
add_library(apex-plugins-delayfilter                SHARED delayfilter/delayfilter.cpp)
add_library(apex-plugins-dummyfeedbackplugin        SHARED dummyfeedbackplugin/dummyfeedbackplugin.cpp)
add_library(apex-plugins-sinkfilter                 SHARED sinkfilter/sinkfilter.cpp)
add_library(apex-plugins-beamformerfilter           SHARED beamformerfilter/beamformerfilter.cpp)
add_library(apex-plugins-adaptivewienerfilter       SHARED adaptivewienerfilter/adaptivewienerfilter.cpp)
add_library(apex-plugins-scramblespectrumfilter     SHARED scramblespectrumfilter/scramblespectrumfilter.cpp)
add_library(apex-plugins-democontroller             SHARED democontroller/democontroller.cpp)
add_library(apex-plugins-vadfilter                  SHARED vadfilter/vadfilter.cpp)
add_library(apex-plugins-noisegenerator             SHARED noisegenerator/noisegenerator.cpp)
add_library(apex-plugins-singlepulsegenerator       SHARED singlepulsegenerator/singlepulsegenerator.cpp)
add_library(apex-plugins-fadefilter                 SHARED fadefilter/fadefilter.cpp)
add_library(apex-plugins-emphasisfilter             SHARED emphasisfilter/emphasisfilter.cpp)
add_library(apex-plugins-sinegenerator              SHARED sinegenerator/sinegenerator.cpp)
add_library(apex-plugins-wienerfilter               SHARED wienerfilter/wienerfilter.cpp)
add_library(apex-plugins-dummyprocedure             SHARED dummyprocedure/dummyprocedure.cpp)
add_library(apex-plugins-amplifierfilter            SHARED amplifierfilter/amplifierfilter.cpp)
add_library(apex-plugins-studyplugin                SHARED studyplugin/studyrunner.cpp)
message("TODO: apex-plugins-matlabfilter")
#add_library(apex-plugins-matlabfilter              SHARED matlabfilter/matlabfilter.cpp)
message("TODO: apex-plugins-iirfilter")
#add_library(apex-plugins-iirfilter                 SHARED iirfilter/iirfilter.cpp)
message("TODO: apex-plugins-pa5controller")
#add_library(apex-plugins-pa5controller             SHARED
#    pa5controller/pa5_actx.cpp
#    pa5controller/pa5device.cpp)
message("TODO: apex-plugins-ledfeedbackplugin")
#add_library(apex-plugins-ledfeedbackplugin         SHARED
#    ledfeedbackplugin/ledcontroller.cpp
#    ledfeedbackplugin/ledfeedback.cpp)
message("TODO: apex-plugins-slm_2250plugin")
#add_library(apex-plugins-slm_2250plugin            SHARED slm_2250plugin/slm_2250.cpp)
message("TODO: apex-plugins-osccontroller")
#add_library(apex-plugins-osccontroller             SHARED osccontroller/osccontroller.cpp)

set(PLUGIN_LIBS
    apex-main
    apex-common
    apex-commongui
    apex-tools
    apex-data
    apex-spin
    bertha-lib-syllib
    Qt5::Network
    Qt5::Widgets
    Qt5::Script
    Qt5::ScriptTools
    ${SNDFILE_LIBRARIES}) 

target_link_libraries(apex-plugins-dataloopgenerator        PRIVATE ${PLUGIN_LIBS})
target_link_libraries(apex-plugins-vocoderfilter            PRIVATE ${PLUGIN_LIBS})
target_link_libraries(apex-plugins-spinplugin               PRIVATE ${PLUGIN_LIBS})
target_link_libraries(apex-plugins-threadedhrtffilter       PRIVATE ${PLUGIN_LIBS})
target_link_libraries(apex-plugins-hrtffilter               PRIVATE ${PLUGIN_LIBS})
target_link_libraries(apex-plugins-networkdevicecontroller  PRIVATE ${PLUGIN_LIBS})
target_link_libraries(apex-plugins-protoslmplugin           PRIVATE ${PLUGIN_LIBS})
target_link_libraries(apex-plugins-delayfilter              PRIVATE ${PLUGIN_LIBS})
target_link_libraries(apex-plugins-dummyfeedbackplugin      PRIVATE ${PLUGIN_LIBS})
target_link_libraries(apex-plugins-sinkfilter               PRIVATE ${PLUGIN_LIBS})
target_link_libraries(apex-plugins-beamformerfilter         PRIVATE ${PLUGIN_LIBS})
target_link_libraries(apex-plugins-adaptivewienerfilter     PRIVATE ${PLUGIN_LIBS})
target_link_libraries(apex-plugins-scramblespectrumfilter   PRIVATE ${PLUGIN_LIBS})
target_link_libraries(apex-plugins-democontroller           PRIVATE ${PLUGIN_LIBS})
target_link_libraries(apex-plugins-vadfilter                PRIVATE ${PLUGIN_LIBS})
target_link_libraries(apex-plugins-noisegenerator           PRIVATE ${PLUGIN_LIBS})
target_link_libraries(apex-plugins-singlepulsegenerator     PRIVATE ${PLUGIN_LIBS})
target_link_libraries(apex-plugins-fadefilter               PRIVATE ${PLUGIN_LIBS})
target_link_libraries(apex-plugins-emphasisfilter           PRIVATE ${PLUGIN_LIBS})
target_link_libraries(apex-plugins-sinegenerator            PRIVATE ${PLUGIN_LIBS})
target_link_libraries(apex-plugins-wienerfilter             PRIVATE ${PLUGIN_LIBS})
target_link_libraries(apex-plugins-dummyprocedure           PRIVATE ${PLUGIN_LIBS})
target_link_libraries(apex-plugins-amplifierfilter          PRIVATE ${PLUGIN_LIBS})
target_link_libraries(apex-plugins-studyplugin              PRIVATE ${PLUGIN_LIBS})
#target_link_libraries(apex-plugins-matlabfilter            PRIVATE ${PLUGIN_LIBS})
#target_link_libraries(apex-plugins-iirfilter               PRIVATE ${PLUGIN_LIBS})
#target_link_libraries(apex-plugins-pa5controller           PRIVATE ${PLUGIN_LIBS})
#target_link_libraries(apex-plugins-ledfeedbackplugin       PRIVATE ${PLUGIN_LIBS})
#target_link_libraries(apex-plugins-slm_2250plugin          PRIVATE ${PLUGIN_LIBS})
#target_link_libraries(apex-plugins-osccontroller           PRIVATE ${PLUGIN_LIBS})

file(GLOB_RECURSE APEX_PROCEDURES_SOURCES
    RELATIVE ${CMAKE_CURRENT_SOURCE_DIR} "apexprocedures/*.cpp")

add_library(apex-plugins-apexprocedures SHARED ${APEX_PROCEDURES_SOURCES}
    apexprocedures/scriptresulthighlight.h)

target_link_libraries(apex-plugins-apexprocedures PRIVATE ${PLUGIN_LIBS})

