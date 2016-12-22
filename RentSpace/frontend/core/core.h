// core.h

#pragma once

#include <iostream>
#include <fstream>
#include <sstream>
#include <vector>
#include <regex>
#include <string>

using namespace System;
using namespace System::Text::RegularExpressions;
using namespace System::Collections::Generic;

namespace core {

	// Data structure used to represent one booking.
	public ref class BookingData {
	public:
		BookingData();
		BookingData(int, int, int, int, String^, int);
		// Methods
		int getOwner() { return owner; }
		int getDate() { return date; }
		int getStartTime() { return startTime; }
		int getEndTime() { return endTime; }
		String^ getFacility() { return facility; }
		int getRoomNum() { return roomNum; }
		bool booked() { return owner >= 0; }
		// Debug Print
		void debugPrint();
	private:
		// Attributes
		int owner;
		int date;
		int startTime;
		int endTime;
		String^ facility;
		int roomNum;
	};

	// Preliminary Data for each individual room. Each of these will need to be 'saved' to the webpage in either this form
	// or to dump the contents into another format.
	public ref class Room {
	public:
		Room();
		Room(Room^);
		Room(int, int, int, String^, String^);
		// Accessors (add more for each necessary property)
		int getRoomNum() { return roomNum; }
		int getFloor() { return floor; }
		int getCapacity() { return capacity; }
		String^ getDescription() { return description; }
		String^ getFacility() { return facility; }
		// Methods
		// Debug Print
		void debugPrint();
	private:
		// Properties
		int floor;
		int roomNum;
		int capacity;
		String^ description;
		String^ facility;
	};

	// Object to be used by calendar to filter out rooms by their features. These are based on U.I features, so
	// revise if needed according to U.I. This should be stored locally by the U.I, and updated by its features.
	public ref class Filter {
	public:
		Filter();
		// Update functions for each feature, use data provided by U.I states
		void updatePeriod(int, int);
		void updateDate(int, int, int);
		void updateLibrary(int);
		void updateFloor(int);
		bool matchFilter(Room^);
		// Accessors
		int getPeriodStart() { return periodStart; }
		int getPeriodEnd() { return periodEnd; }
		int getLibrary() { return library; }
		int getFloor() { return floor; }
		// Debug Print
		void debugPrint();
	private:
		// Attributes
		// Each increment of 1 represents 30 minutes
		int periodStart;
		int periodEnd;
		// 0 - Stauffer, 1 - Douglas, 2 - ILC
		int library;
		int floor;
		// date[0] - day, date[1] - month, date[2] - year
		array<int>^ date;
	};

	// Should also be stored locally by the U.I, and used to retrieve information.
	public ref class Calendar {
	public:
		Calendar();
		Calendar(int, int, int);
		// Application of Filter (the Calander object should be a local variable, along with Filter itself).
		// Uses filter to load the appropriate data from the back end;
		// Accessors
		Room^ getRoom(int x) { return roomList[x]; }
		int getSlots();
		// Methods
		void clear();
		void addRoom(Filter^, int, int, int, String^, String^);
		void updateDate(int, int, int);
		// Debug Print
		void debugPrint();
	private:
		// Attributes
		List<Room^>^ roomList;
		int day;
		int month;
		int year;
	};

	// Preliminary Data for each user. Each of these will need to be 'saved' to the webpage in either this form
	// or to dump the contents into another format. This class is the virtual basis for Student, TA, Prof, and Faculty.
	// Should be stored locally by the U.I framework.
	public ref class User {
	public:
		User();
		User(int, String^, String^, int, int, int, int, int, int);
		// Accessors OLD
		String^ getUsername() { return username; }
		String^ getPassword() { return password; }
		int getHours() { return hours; }
		// Accessors New
		int getId() { return id; }
		String^ getRole() { return role; }
		String^ getFacility() { return facility; }
		int getTimeGlobalMax() { return timeGlobalMax; }
		int getTimeGlobalCurrent() { return timeGlobalCurrent; }
		int getTimeDailyMax() { return timeDailyMax; }
		int getTimeDailyCurrent() { return timeDailyCurrent; }
		int getBookingsMax() { return bookingsMax; }
		int getBookingsCurrent() { return bookingsCurrent; }
		// Methods
		void changeDailyHours(int);
		void changeGlobalHours(int);
		bool canBookNewRoom();
		bool canBookNewRoom(int);
		// Permissions Methods OLD
		bool isStudent() { return permissions == 0 || permissions < 0 || permissions > 3; }
		bool isTA() { return permissions == 1; }
		bool isProf() { return permissions == 2; }
		bool isFaculty() { return permissions == 3; }
		// Debug Print
		void debugPrint();
	private:
		// Values:
		// 1 - id
		// 2 - role
		// 3 - facility
		// 4 - time_global_max
		// 5 - time_global_current
		// 6 - time_daily_max
		// 7 - time_daily_current
		// 8 - bookings_max
		// 9 - bookings_current
		// Not in Use
		String^ username;
		String^ password;
		String^ fName;
		String^ lName;
		int permissions; 
		int faculty;
		int hours;
		int bookings;
		// New Material
		int id;
		String^ role;
		String^ facility;
		int timeGlobalMax;
		int timeGlobalCurrent;
		int timeDailyMax;
		int timeDailyCurrent;
		int bookingsMax;
		int bookingsCurrent;
	};
}

// End of File
