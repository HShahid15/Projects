#include "rentspace_api.h"
using namespace std;



//Returns all users currently in the database
string ApiRequest::getAllUsers()
{
	HTTPClientSession s("thompson.caslab.queensu.ca", 8080);
	HTTPRequest request(HTTPRequest::HTTP_GET, "/users/");
	s.sendRequest(request);

	HTTPResponse response;
	std::istream& rs = s.receiveResponse(response);

	string responseStr;
	StreamCopier::copyToString(rs, responseStr);
	return responseStr;
}

//gets current users
string ApiRequest::getUser(string UID)
{
	string uri = "/users/" + UID;
	HTTPClientSession s("thompson.caslab.queensu.ca", 8080);
	HTTPRequest request(HTTPRequest::HTTP_GET, uri);
	s.sendRequest(request);

	HTTPResponse response;
	std::istream& rs = s.receiveResponse(response);



	string responseStr;
	StreamCopier::copyToString(rs, responseStr);
	return responseStr;
}

//returns all the rooms in a specifed facility
std::string ApiRequest::getFacilityRooms(string facility)
{
	string uri = "/rooms/" + facility;
	HTTPClientSession s("thompson.caslab.queensu.ca", 8080);
	HTTPRequest request(HTTPRequest::HTTP_GET, uri);
	s.sendRequest(request);

	HTTPResponse response;
	std::istream& rs = s.receiveResponse(response);

	string responseStr;
	StreamCopier::copyToString(rs, responseStr);
	return responseStr;
}


//get a specific room in a facility
std::string ApiRequest::getRoom(string facility, string roomNum)
{
	string uri = "/rooms/" + roomNum+ "/"+ facility;
	HTTPClientSession s("thompson.caslab.queensu.ca", 8080);
	HTTPRequest request(HTTPRequest::HTTP_GET, uri);
	s.sendRequest(request);

	HTTPResponse response;
	std::istream& rs = s.receiveResponse(response);

	string responseStr;
	StreamCopier::copyToString(rs, responseStr);
	return responseStr;
}

std::string ApiRequest::getFacilityBookings(string facility, string date)
{
	string uri = "/bookings/?facility.is=" + facility + "&date.is=" + date;


	HTTPClientSession s("thompson.caslab.queensu.ca", 8080);
	HTTPRequest request(HTTPRequest::HTTP_GET, uri);
	s.sendRequest(request);

	HTTPResponse response;
	std::istream& rs = s.receiveResponse(response);

	string responseStr;
	StreamCopier::copyToString(rs, responseStr);
	return responseStr;
}

bool ApiRequest::updateTimeInfo(string UID, string dailyTime, string globalTime, string bookingsLeft)
{
	string uri = "/users/" + UID+"?dailyTime=" + dailyTime + "&globalTime=" + globalTime+ "&bookingsLeft=" + bookingsLeft;

	HTTPClientSession s("thompson.caslab.queensu.ca", 8080);
	HTTPRequest request(HTTPRequest::HTTP_PATCH, uri);
	s.sendRequest(request);

	HTTPResponse response;
	
	int i = response.getStatus();
	if (i == 200) {
		return true;
	}
	else {
		return false;
	}

}

string ApiRequest::postUser(string UID, string facility)
{
	string uri = "/users/" + facility + "/" + UID;
	HTTPClientSession s("thompson.caslab.queensu.ca", 8080);
	HTTPRequest request(HTTPRequest::HTTP_GET, uri);
	s.sendRequest(request);

	HTTPResponse response;
	std::istream& rs = s.receiveResponse(response);

	string responseStr;
	StreamCopier::copyToString(rs, responseStr);
	return responseStr;
}

string ApiRequest::addBooking(string owner, string facility, string date, string startTime, string endTime,  string roomNum)
{
	string uri = "/booking/?roomNum=" + roomNum + "&owner="+ owner+ "&facility=" + facility + "&startTime=" + startTime + "&endTime="+endTime+ "&date=" +date;


	HTTPClientSession s("thompson.caslab.queensu.ca", 8080);
	HTTPRequest request(HTTPRequest::HTTP_GET, uri);
	s.sendRequest(request);

	HTTPResponse response;
	std::istream& rs = s.receiveResponse(response);

	string responseStr;
	StreamCopier::copyToString(rs, responseStr);
	return responseStr;
}
