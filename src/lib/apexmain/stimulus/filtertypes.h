/******************************************************************************
 * Copyright (C) 2008  Tom Francart <tom.francart@med.kuleuven.be>            *
 *                                                                            *
 * This file is part of APEX 3.                                               *
 *                                                                            *
 * APEX 3 is free software: you can redistribute it and/or modify             *
 * it under the terms of the GNU General Public License as published by       *
 * the Free Software Foundation, either version 2 of the License, or          *
 * (at your option) any later version.                                        *
 *                                                                            *
 * APEX 3 is distributed in the hope that it will be useful,                  *
 * but WITHOUT ANY WARRANTY; without even the implied warranty of             *
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the              *
 * GNU General Public License for more details.                               *
 *                                                                            *
 * You should have received a copy of the GNU General Public License          *
 * along with APEX 3.  If not, see <http://www.gnu.org/licenses/>.            *
 *****************************************************************************/
 
#ifndef FILTERTYPES_H
#define FILTERTYPES_H

#include <QString>

namespace apex{
  namespace stimulus{

      //filter types
    static const QString sc_sFilterAmplifierType        ( "apex:amplifier"      );
    static const QString sc_sFilterFaderType            ( "apex:fader"          );
    static const QString sc_sFilterGeneratorType        ( "apex:generator"      );
    static const QString sc_sFilterDataLoopType         ( "apex:dataloop"       );
    static const QString sc_sFilterHrtffiltersumType    ( "apex:hrtffiltersum"  );
    static const QString sc_sFilterPluginFilterType     ( "apex:pluginfilter"   );
    static const QString sc_sFilterNoiseGeneratorType   ( "noise"               );
    static const QString sc_sFilterSinglePulseGenType   ( "singlepulse"         );
    static const QString sc_sFilterSineGenType          ( "sinus"               );


  }
}

#endif