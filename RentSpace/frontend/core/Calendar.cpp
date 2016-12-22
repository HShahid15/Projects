/*
* Calendar.cpp
*
*  Created on: Nov 10, 2016
*      Author: Daniel
*/

#include "Stdafx.h"

core::Calendar::Calendar() {
	roomList = gcnew List<Room^>();
	day = 0;
	month = 0;
	year = 0;
}

core::Calendar::Calendar(int d, int m, int y) {
	roomList = gcnew List<Room^>();
	updateDate(d, m, y);
}

// Call in a loop on main program after clearing table, providing parsed values from JSON.
void core::Calendar::addRoom(Filter^ filter, int fl, int rn, int c, String^ d, String^ fa) {
	Room^ tempRoom = gcnew Room(fl, rn, c, d, fa);
	if (filter->matchFilter(tempRoom) == true) {
		roomList->Add(gcnew Room(tempRoom));
	}
	delete tempRoom;
}

// Should be called on Refreshing Table
void core::Calendar::clear() {
	roomList->Clear();
}

int core::Calendar::getSlots() {
	return roomList->ToArray()->Length;
}

void core::Calendar::updateDate(int d, int m, int y) {
	day = d;
	month = m;
	year = y;
}

void core::Calendar::debugPrint() {
	array<Room^>^ array = roomList->ToArray();
	for (int i = 0; i < array->Length; i++) {
		System::Console::WriteLine("---Room " + i + "---");
		array[i]->debugPrint();
	}
	System::Console::WriteLine("---------------");
}

// End of File