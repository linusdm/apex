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
 
#ifndef WAVDATABLOCK_H
#define WAVDATABLOCK_H

#include "wavcompatibledatablock.h"

namespace streamapp
{
  class PositionableAudioFormatReaderStream;
}
using namespace streamapp;

namespace apex
{

class ExperimentRunDelegate;

namespace data
{
class DatablockData;
}

namespace stimulus
{

class WavDataBlock : public WavCompatibleDataBlock
{
public:
    /**
     * Constructor.
     */
    WavDataBlock(const data::DatablockData& data, const QUrl& filename,
                 const ExperimentRunDelegate* experiment);

    /**
     * Destructor.
     */
    virtual ~WavDataBlock();

    /**
        * Implementation of the WavCompatibleDataBlock method.
        */
    PositionableAudioFormatReaderStream* GetWavStream( const unsigned ac_nBufferSize, const unsigned long ac_lFs ) const;

    /**
        * Implementation of the DataBlock method.
        */
    virtual const QString& GetModule() const
    { return sc_sWavDevice; }

    virtual DataBlock* GetCopy(QString id);

private:
    double m_dSilenceLength;    //!< if !=0 datablock is a silence datablock of length m_silenceLen ms
};

}
}

#endif //WAVDATABLOCK_H