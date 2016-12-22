/*Class to connect to the database
*/
var mysql = require('mysql');
var con = mysql.createConnection({
	host : '127.0.0.1',
	user: 'admin',
	password :'admin123',
	database: '320_db',
	debug: false,
});

con.connect(function(err) {
	if(err) throw err;
	
});

module.exports = con;
