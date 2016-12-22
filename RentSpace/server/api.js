var db = require('./db');
var express = require('express');
var app = express();




//creation of express router object for Users
var usersRouter = express.Router();

app.get('/users/:facility/:id', function(req, res){
var facility = req.params.facility;
var id = req.params.id;

var sql = "SELECT * FROM users WHERE id ='" + id + "' AND facility ='" + facility +"'";

db.query(sql, function(err, results) {
	if(err){
		console.error(err);
		res.statusCode = 500;
		return res.json({error: ['Could not retrieve users']});
	}

	if(results.length === 0) {
	
	var add = "INSERT INTO users ( id, facility) VALUES ( '"+ id + "', '"+ facility + "')"; 
	db.query(add, function(err, results2){
	if(err){
		console.error(err);
		res.statusCode = 500;
		return res.json({error: ['Could not add user']});	
	}
	
 	
	var sql = "SELECT * FROM users WHERE id ='" + id + "' AND facility ='" + facility +"'";

	db.query(sql, function(err, results) {
		if(err){
			console.error(err);
			res.statusCode = 500;
			return res.json({error: ['Could not retrieve users']});
		}
	var json = JSON.stringify(results);
	res.send(json);
	
	});
	});
}
else{
var json = JSON.stringify(results);
res.send(json);
}

});
});






//get all users
app.get('/users', function(req, res){
var sql = 'SELECT * FROM users';
db.query(sql, function(err, results) {
  if(err){
    console.error(err);
    res.statusCode = 500;
    return res.json({error: ['Could not retrieve users']});
    }

   if(results.length === 0){
   res.statusCode = 404;
   return res.json({errors: ['No users found'] });
   }
   var json = JSON.stringify(results);
   res.send(json);
});
});

app.get('/users/:id', function(req, res){
var id = req.params.id;
var sql = 'SELECT * FROM users WHERE id = ?';
db.query(sql,[id], function(err, results) {
  if(err){
    console.error(err);
    res.statusCode = 500;
    return res.json({error: ['Could not retrieve users']});
    }

   if(results.length === 0){
   res.statusCode = 404;
   return res.json({errors: ['No users found'] });
   }
   var json = JSON.stringify(results);
   res.send(json);
});
});




//returns all rooms in a facility
app.get('/rooms/:facility', function(req, res){
var facility = req.params.facility; 


var sql = "SELECT * FROM rooms WHERE facility = '" + facility + "'";
db.query(sql, function(err, results) {
	if(err){
	console.error(err);
	res.statusCode = 500;
	return res.json({error: ['Could not retrieve specified room']});
	} 

	if(results.length === 0) {
	res.statusCode = 404;
	return res.json({errors: ['No room matching those parameters found'] } );
	}
	var json = JSON.stringify(results);
	res.send(json);
});
});


//returns specified room
app.get('/rooms/:roomnum/:facility', function(req, res){
var roomnum = req.params.roomnum;
var facility = req.params.facility; 

var sql = "SELECT * FROM rooms WHERE facility = '" + facility + "' and room_number = " + roomnum;
db.query(sql, function(err, results) {
	if(err){
	console.error(err);
	res.statusCode = 500;
	return res.json({error: ['Could not retrieve specified room']});
	} 

	if(results.length === 0) {
	res.statusCode = 404;
	return res.json({errors: ['No room matching those parameters found'] } );
	}
	var json = JSON.stringify(results);
	res.send(json);
});
});
	

app.get('/bookings', function(req, res){
var QueryGenerator = require('mysql-query-generator');
var handler = new QueryGenerator(100);
var queryAddition = handler.generateQueryAddition(req.url);

var sql = 'SELECT * FROM bookings' + queryAddition;

db.query(sql, function(err, results) {
	if(err){
	console.error(err);
	res.statusCode = 500;
	return res.json({error: ['Could not retrieve rooms']});
	} 

	if(results.length === 0) {
	res.statusCode = 404;
	return res.json({errors: ['No booked rooms'] } );
	}
	var json = JSON.stringify(results);
	res.send(json);
});
});

//Updates daily and global time limits	
app.patch('/users/:id', function(req, res) {
var dailyTime = req.query.dailyTime;
var globalTime = req.query.globalTime;
var bookingsLeft = req.query.bookingsLeft;
var id = req.params.id;

var sql = 'UPDATE users SET time_daily_current=' +dailyTime +', time_global_max=' + globalTime + ', bookings_current=' + bookingsLeft + ' WHERE id=' + id;

db.query(sql, function(err, results){
	if(err) {
		console.error(err);
	  	res.statusCode = 500;
		return res.json({error: ['Could not update user'] });
	}
var sql2 = 'SELECT * from user WHERE id =' + id;
db.query(sql, function(err, results){
	if(err){
		console.error(err);
		res.statusCode = 500;
		return res.json({error: ['Could not retrieve user']});
		}
	
	if(results.length === 0) {
	res.statusCode = 404;
	return res.json({errors: ['No users found']});
	}
	var json = JSON.stringify(results);
	res.send(json);

});
}); 
});




//update room bookinapp.post('/booking', function(req,res)
app.get('/booking', function(req,res){
var Owner = req.query.owner;
var date = req.query.date;
var startTime = req.query.startTime;
var endTime = req.query.endTime;
var facility = req.query.facility;
var roomNum = req.query.roomNum;
var id;

var sql = "INSERT INTO bookings (owner, date, start_time, end_time, facility, room_number) values ('" + Owner + "', '" + date + "', '" + startTime + "', '" + endTime + "', '"+ facility + "', " + roomNum + ')';



db.query(sql, function(err, results){
	if(err){
		console.error(err);
		res.statusCode = 500;
		return res.json({error: ['Could not add room booking']});
		}
});

 
db.query('SELECT LAST_INSERT_ID()', function(err, results1){


id = results1[0]['LAST_INSERT_ID()'];

var sql2 = "SELECT * FROM bookings WHERE id = ?";

db.query(sql2,[id], function(err, results) {
	if(err){
	console.error(err);
	res.statusCode =500;
	return res.json({error: ['Unable to retrieve recently added booking']});
	}
	var json = JSON.stringify(results);
	res.send(json);

});

//res.send(json);

});
});
 



app.on('error', function (err) {
	console.log(err);
});

console.log("Registering endpoints: /");
app.get('/', function(req, res){
     res.send('hello ROOT world');
 });
 
 

console.log("Registering endpoints: /test");
app.get('/test', function(req, res){
     res.json({
          "mykey": "myvalue",
	  "testy" : "something",
	  "exnum" : 123,
	  "test" : "Hello tester!!!"
	  });
});

app.listen(8080);
