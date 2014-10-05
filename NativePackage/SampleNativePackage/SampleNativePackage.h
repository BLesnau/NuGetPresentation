// SampleNativePackage.h : main header file for the SampleNativePackage DLL
//

#pragma once

#ifndef __AFXWIN_H__
	#error "include 'stdafx.h' before including this file for PCH"
#endif

#include "resource.h"		// main symbols


// CSampleNativePackageApp
// See SampleNativePackage.cpp for the implementation of this class
//

class _declspec(dllexport) SampleNativePackageApp
{
public:
   void ShowMessage() { AfxMessageBox( L"SampleNativePackage Version 2" ); }
};
