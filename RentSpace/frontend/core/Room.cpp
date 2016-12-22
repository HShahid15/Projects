/*
* RoomData.cpp
*
*  Created on: Oct 20, 2016
*      Author: Daniel
*/

// Class Data for a single room. Used to store data to be used for Table Display.
#include "Stdafx.h"

core::Room::Room() {
	floor = 0;
	roomNum = 0;
	capacity = 0;
	facility = "";
}

core::Room::Room(Room^ copy) {
	floor = copy->getFloor();
	roomNum = copy->getRoomNum();
	capacity = copy->getCapacity();
	description = copy->getDescription();
	facility = copy->getFacility();
}

// Provide parsed values from JSON
core::Room::Room(int fl, int rn, int c, String^ d, String^ fa) {
	floor = fl;
	roomNum = rn;
	capacity = c;
	description = d;
	facility = fa;
}

void core::Room::debugPrint() {
	System::Console::WriteLine("getFloor = " + getFloor());
	System::Console::WriteLine("getRoomNum = " + getRoomNum());
	System::Console::WriteLine("getCapacity = " + getCapacity());
	System::Console::WriteLine("getDescription = " + getDescription());
	System::Console::WriteLine("getFacility = " + getFacility());
}

// End of File