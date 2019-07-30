//----------------------------------------------------------------------------
// (C) Copyright 2005, Avantes B.V.
// Any reproduction without written permission is prohibited by law.
//----------------------------------------------------------------------------
//
// Project      : AVS606
// Subject      : AS5216 DLL
// File type    : C++ source
// Description  : Device class
//
//----------------------------------------------------------------------------
//
// File : $Workfile:   convert.cpp  $
// Revision : $Revision:   1.0  $
// Date : $Date:   Jul 22 2005 08:07:04  $
//
//----------------------------------------------------------------------------

//----------------------------------------------------------------------------
// Import overview
//----------------------------------------------------------------------------
// General environment (Builder)
#include <vcl.h>
#pragma hdrstop

#include "convert.h"

//----------------------------------------------------------------------------
// General definitions
//----------------------------------------------------------------------------
AnsiString CharToString(char* a_pChar)
{
    return AnsiString(reinterpret_cast<char const *>(a_pChar));
}
