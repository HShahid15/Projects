#pragma once
#include <iostream>
#include <string>
//#include "multiplication.h"
#include <vector>
#include "Poco/Net/HTTPRequest.h"
#include "Poco/Net/HTTPClientSession.h"
#include "Poco/Net/HTTPRequest.h"
#include "Poco/Net/HTTPResponse.h"
#include <Poco/Net/HTTPCredentials.h>
#include "Poco/StreamCopier.h"
#include "Poco/URI.h"
#include <iostream>
#include <fstream>
#include "Poco/StreamCopier.h"
#include <Poco/JSON/JSON.h>
#include <Poco/JSON/Parser.h>
#include <Poco/Dynamic/Var.h>
using namespace Poco::JSON;

//#include "json.hpp"
//using json = nlohmann::json;
//using namespace nlohmann;

using std::cout;
using std::cin;
using std::getline;
using namespace Poco;
using namespace Net;
using Poco::Net::HTTPClientSession;
using Poco::Net::HTTPRequest;
using Poco::Net::HTTPResponse;
using Poco::Net::HTTPMessage;
using namespace std;
using namespace Poco::Dynamic;


class ApiRequest {
public:
	static string getAllUsers();
	static string getUser(string UID);
	static std::string getFacilityRooms(string facility);
	static std::string getRoom(string facility, string roomNum);
	static std::string getFacilityBookings(string facility, string date);
	static bool updateTimeInfo(string UID, string dailyTime, string globalTime, string bookingsleft);
	static string postUser(string UID, string facility);
	static string addBooking(string owner, string facility, string date, string startTime, string endTime,  string roomNum);


};
