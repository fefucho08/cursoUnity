// Teste3.cpp: define o ponto de entrada para o aplicativo.
//

#include "Teste3.h"
#include <iostream>
#include <mariadb/conncpp.hpp>

using namespace std;

int main()
{
	try
	{
		string serverPort = "3306";

		string serverIP = "143.106.243.64";
		string serverDatabase = "Si300A2024_05";
		string serverUser = "Si300A2024_05";
		string serverPassword = "t7SUQ25B9I";

		sql::Driver* driver = NULL;
		sql::Connection* connection;

		driver = sql::mariadb::get_driver_instance();
		string connString = "jdbc:mariadb://" + serverIP + ":" + serverPort + "/" + serverDatabase;
		sql::SQLString url(connString);
		sql::Properties properties(
			{
				{ "user", serverUser },
				{ "password", serverPassword } });

		connection = driver->connect(url, properties);
	}
	catch (sql::SQLException& myException)
	{
		std::cerr << "Error Connecting to MariaDB Platform: \n" << myException.what() << std::endl;
		exit(1);
	}
	catch (const bad_alloc& e) {
		cerr << e.what() << endl;
		exit(1);
	}
		
	return 0;
}
