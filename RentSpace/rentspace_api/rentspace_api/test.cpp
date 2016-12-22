#pragma once

#include "rentspace_api.h"
#include "json.hpp"
#include <regex>
using namespace std;
using json = nlohmann::json;
using namespace nlohmann;

void parseJson(string json) {
	//regex regex("(facility)\":\"((\\\" | [^\"])*)");
	//smatch match;


	//if (regex_search(json, match, regex))
	//	string test = match[1];


	std::size_t idPos = json.find("id");
	std::size_t rolePos = json.find("role");
	std::size_t facilityPos = json.find("facility");
	std::size_t timeMaxPos = json.find("time_global_max");
	std::size_t timeCurrPos = json.find("time_global_current");
	std::size_t bookingMaxPos = json.find("bookings_max");
	std::size_t bookingCurrPos = json.find("bookings_current");


	std::string id = json.substr((idPos+5), (6));
	std::string role = json.substr((rolePos + 7), facilityPos-rolePos-idPos-7);
	std::string facility = json.substr((rolePos + 7), facilityPos - rolePos - idPos - 7);

	cout << "help" << endl;
}



int main() {

	string test1 = ApiRequest::getAllUsers();
	cout << test1 << "\n" << endl;

	string test2 = ApiRequest::getUser("13too1");
	cout << test2 << "\n" << endl;

	string test3 = ApiRequest::getFacilityRooms("Stauffer");
	cout << test3 << "\n" << endl;

	string test4 = ApiRequest::getRoom("Stauffer", "120");
	cout << test4 << "\n" << endl;

	string test5 = ApiRequest::getFacilityBookings("Stuaffer", "2016-12-02");
	cout << test5 << "\n" << endl;

	bool test6 = ApiRequest::updateTimeInfo("13too1", "25", "27", "3" );
	cout << test6 << "\n" << endl;

	string test7 = ApiRequest::postUser("13too2", "Stuaffer");
	cout << test7 << "\n" << endl;

	string test8 = ApiRequest::postUser("67oko9", "Stuaffer");
	cout << test8 << "\n" << endl;

	string test9 = ApiRequest::addBooking( "13too1", "Stuaffer","2016-12-20", "16:30:00", "17:30:00", "213" );
	cout << test9 << "\n" << endl;

	
	//Parser parser;
	//Var result = parser.parse(test2);
	//Object::Ptr object = result.extract<Object::Ptr>();
	//Var test = object->get("id");
	//object = test.extract<Object::Ptr>();
	//test = object->get("property");
	////std::string value = test.convert<std::string>();
	//auto j3 = nlohmann::json::parse("{ \"happy\": true, \"pi\": 3.141 }");
	//string emotion = to_string(j3->get("happy"));
	//parseJson(test8);
	return 0;
}

