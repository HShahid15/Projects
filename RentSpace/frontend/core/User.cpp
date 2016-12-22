/*
* User.cpp
*
*  Created on: Nov 10, 2016
*      Author: Daniel
*/
// Class Data for a single user. Implementation.

#include "Stdafx.h"

core::User::User() {
	int id = 0;
	String^ role = "";
	String^ faculty = "";
	int timeGlobalMax = 0;
	int timeGlobalCurrent = 0;
	int timeDailyMax = 0;
	int timeDailyCurrent = 0;
	int bookingsMax = 0;
	int bookingsCurrent = 0;
}

core::User::User(int i, String^ r, String^ f, int tgm, int tgc, int tdm, int tdc, int bm, int bc) {
	id = i;
	role = r;
	facility = f;
	timeGlobalMax = tgm;
	timeGlobalCurrent = tgc;
	timeDailyMax = tdm;
	timeDailyCurrent = tdc;
	bookingsMax = bm;
	bookingsCurrent = bc;
}

void core::User::changeGlobalHours(int number) {
	timeGlobalCurrent += number;
}

void core::User::changeDailyHours(int number) {
	timeDailyCurrent += number;
}

bool core::User::canBookNewRoom() {
	return bookingsCurrent < bookingsMax;
}

bool core::User::canBookNewRoom(int hours) {
	bool a = bookingsCurrent < bookingsMax;
	bool b = (timeGlobalCurrent + hours) < timeGlobalMax;
	bool c = (timeDailyCurrent + hours) < timeDailyMax;
	return a && b && c;
}

void core::User::debugPrint() {
	System::Console::WriteLine("id = " + id);
	System::Console::WriteLine("role = " + role);
	System::Console::WriteLine("facility = " + facility);
	System::Console::WriteLine("timeGlobalMax = " + timeGlobalMax);
	System::Console::WriteLine("timeGlobalCurrent = " + timeGlobalCurrent);
	System::Console::WriteLine("timeDailyMax = " + timeDailyMax);
	System::Console::WriteLine("timeDailyCurrent = " + timeDailyCurrent);
	System::Console::WriteLine("bookingsMax = " + bookingsMax);
	System::Console::WriteLine("bookingsCurrent = " + bookingsCurrent);
}

// End of File