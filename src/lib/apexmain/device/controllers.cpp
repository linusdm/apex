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
 
#include "controllers.h"
#include "apexcontrol.h"
#include "services/errorhandler.h"
#include "iapexdevice.h"
#include "stimulus/stimulusparameters.h"
#include "device/controldevice.h"
#include <iostream>

#include "runner/experimentrundelegate.h"

using namespace apex;
using namespace apex::device;

Controllers::Controllers(ExperimentRunDelegate& p_rd) :
        ApexModule(p_rd),
  m_Devices(p_rd.GetControllers() )
{
}

Controllers::~Controllers()
{
}


QString apex::device::Controllers::GetResultXML( ) const
{
    QString result;
    for (tControllerMap::const_iterator it=m_Devices.begin(); it!=m_Devices.end(); ++it) {
        result += it.value()->GetResultXML();
    }

  return result;
}
