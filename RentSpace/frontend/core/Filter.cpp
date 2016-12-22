/*
* Filter.cpp
*
*  Created on: Nov 10, 2016
*      Author: Daniel
*/

#include "Stdafx.h"

core::Filter::Filter() {
	periodStart = 0;
	periodEnd = 0;
	library = 0;
	floor = 0;
	date = gcnew array<int>(3);
}

// Update methods

void core::Filter::updatePeriod(int start, int end) {
	periodStart = start;
	periodEnd = end;
}

void core::Filter::updateLibrary(int lib) {
	library = lib;
}

void core::Filter::updateFloor(int f) {
	floor = f;
}

void core::Filter::updateDate(int day, int month, int year) {
	date[0] = day;
	date[1] = month;
	date[2] = year;
}

bool core::Filter::matchFilter(Room^ room) {
	// Match room data with the filter. Edit to add other conditions for any additional conditions for narrowing down room seleciton.
	bool a = floor == room->getFloor();
	return a;
}

// Accessors

void core::Filter::debugPrint() {
	System::Console::WriteLine("getPeriodStart = " + getPeriodStart());
	System::Console::WriteLine("getPeriodEnd = " + getPeriodEnd());
	System::Console::WriteLine("getLibrary = " + getLibrary());
	System::Console::WriteLine("getFloor = " + getFloor());
}

// End of File