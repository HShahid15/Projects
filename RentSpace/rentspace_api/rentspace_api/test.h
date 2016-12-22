#pragma once

#include "rentspace_api.cpp"


int main() {
	std::string s= ApiRequest::getAllUsers();
	cout << s << endl;
	return 0;
}