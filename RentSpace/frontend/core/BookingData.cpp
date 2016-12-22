/*
* BookingData.cpp
*
*  Created on: Nov 17, 2016
*      Author: Daniel
*/

#include "Stdafx.h"

// This class represents the one instant of a booking.

core::BookingData::BookingData() {
	int owner = 0;
	int date = 0;
	int startTime = 0;
	int endTime = 0;
	String^ facility = "";
	int roomNum = 0;
}

core::BookingData::BookingData(int o, int d, int st, int et, String^ f, int rn) {
	int owner = 0;
	int date = 0;
	int startTime = 0;
	int endTime = 0;
	String^ facility = "";
	int roomNum = 0;
}

void core::BookingData::debugPrint() {
	System::Console::WriteLine("owner = " + owner);
	System::Console::WriteLine("date = " + date);
	System::Console::WriteLine("startTime = " + startTime);
	System::Console::WriteLine("endTime = " + endTime);
	System::Console::WriteLine("facility = " + facility);
	System::Console::WriteLine("roomNum = " + roomNum);
}

// End of File