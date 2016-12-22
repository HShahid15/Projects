package
{
	import flash.display.*
	import flash.events.*
	import flash.ui.*
	import flash.geom.*
	import flash.utils.Timer;
	import flash.net.URLRequest;
	import flash.media.Sound;
	
	public class dodgeDonGame extends MovieClip
	{
		//STARTING PAGE
		public function dodgeDonGame()
		{
			playBtn.addEventListener(MouseEvent.CLICK, goToInstructions)
			tag.play()
			var latch: URLRequest = new URLRequest("LatchInstramental.mp3")
			var music: Sound = new Sound()
			music.load(latch)
			music.play()
			//for(var a = 0; a <= 10; a++)
			//{music.play()}
		}
		
		//INSTRUCTIONS PAGE
		function goToInstructions (evt: MouseEvent)
		{
			playBtn.removeEventListener(MouseEvent.CLICK, goToInstructions)
			gotoAndStop(2)
			arrowBtn.addEventListener(MouseEvent.CLICK, instructionsPg2)
		}
		
		//INSTRUCTIONS PAGE 2
		function instructionsPg2 (evt: MouseEvent)
		{
			arrowBtn.removeEventListener(MouseEvent.CLICK, instructionsPg2)
			gotoAndStop(3)
			beginBtn.addEventListener(MouseEvent.CLICK, westCampus)
		}
		
		//WEST LEVEL
		var timer: Timer
		function westCampus (evt: Event)
		{
			beginBtn.removeEventListener(MouseEvent.CLICK, westCampus)
			//wallyLvl.removeEventListener(MouseEvent.CLICK, wally)
			//westCampusLvl.removeEventListener(MouseEvent.CLICK, westCampus)
			gotoAndStop(4)
			stage.addEventListener(KeyboardEvent.KEY_DOWN, pressedDown)
			stage.addEventListener(KeyboardEvent.KEY_UP, notPressed)
			stage.addEventListener(Event.ENTER_FRAME, moveStudent)
			stage.addEventListener(Event.ENTER_FRAME, powerUpShot)
			stage.addEventListener(Event.ENTER_FRAME, powerUpBeer)
			stage.addEventListener(Event.ENTER_FRAME, powerUpEngyDrink)
			stage.addEventListener(Event.ENTER_FRAME, powerUpBurger)
			stage.addEventListener(Event.ENTER_FRAME, powerUpChase)
			pointHit()
			stage.addEventListener(Event.ENTER_FRAME, aiSharukh)
			sharukhman.addEventListener(Event.ENTER_FRAME, gameOver)
			
			timer = new Timer(2000, time)
			timer.addEventListener(TimerEvent.TIMER, countdown)
			timer.start()
			var time: Number = Number(timeLeft.text)
			function countdown(evt: TimerEvent)
			{
				if(time > 0)
				{timeLeft.text = String(time--)}
				else if (time == 0)
				{timer.stop()}
				
				if(time == 0)
				{
					stage.addEventListener(Event.ENTER_FRAME, timesUp)
					timer.stop()
					timer.removeEventListener(TimerEvent.TIMER, countdown)
				}
			}
			
			score = 0
			playerScore.text = String(score)
		}
		
		//GOES TO THIS PAGE WHEN SHARUKHMAN CATCHES YOU
		function gameOver(evt: Event)
		{
			if (donHitStudent() == true)
			{
				stage.removeEventListener(KeyboardEvent.KEY_DOWN, pressedDown)
				stage.removeEventListener(KeyboardEvent.KEY_UP, notPressed)
				stage.removeEventListener(Event.ENTER_FRAME, moveStudent)
				stage.removeEventListener(Event.ENTER_FRAME, powerUpShot)
				stage.removeEventListener(Event.ENTER_FRAME, powerUpBeer)
				stage.removeEventListener(Event.ENTER_FRAME, powerUpEngyDrink)
				stage.removeEventListener(Event.ENTER_FRAME, powerUpBurger)
				stage.removeEventListener(Event.ENTER_FRAME, powerUpChase)
				sharukhman.removeEventListener(Event.ENTER_FRAME, gameOver)
				stage.removeEventListener(Event.ENTER_FRAME, timesUp)
				stage.removeEventListener(Event.ENTER_FRAME, aiSharukh)
				timer.stop()
				gotoAndStop(5)
				yourScore.text = String(score)
			}
		}
		
		//GOES TO THIS PAGE WHEN TIME RUNS OUT
		function timesUp(evt: Event)
		{
			stage.removeEventListener(KeyboardEvent.KEY_DOWN, pressedDown)
			stage.removeEventListener(KeyboardEvent.KEY_UP, notPressed)
			stage.removeEventListener(Event.ENTER_FRAME, moveStudent)
			stage.removeEventListener(Event.ENTER_FRAME, powerUpShot)
			stage.removeEventListener(Event.ENTER_FRAME, powerUpBeer)
			stage.removeEventListener(Event.ENTER_FRAME, powerUpEngyDrink)
			stage.removeEventListener(Event.ENTER_FRAME, powerUpBurger)
			stage.removeEventListener(Event.ENTER_FRAME, powerUpChase)
			sharukhman.removeEventListener(Event.ENTER_FRAME, gameOver)
			stage.removeEventListener(Event.ENTER_FRAME, timesUp)
			stage.removeEventListener(Event.ENTER_FRAME, aiSharukh)
			timer.stop()
			gotoAndStop(6)
			
			yourScore.text = String(score)
		}
		
		//MOVEMENT FUNCTIONS
		var leftArrow = false
		var rightArrow = false
		var upArrow = false
		
		//CHECK IF PRESSED DOWN
		function pressedDown (evt: KeyboardEvent)
		{
			if (evt.keyCode == Keyboard.LEFT)
			{
				leftArrow = true
			}
			else if (evt.keyCode == Keyboard.RIGHT)
			{
				rightArrow = true
			}
			else if (evt.keyCode == Keyboard.UP)
			{
				upArrow = true
			}			
		}
		
		//CHECK IF NOT PRESSED
		function notPressed (evt: KeyboardEvent)
		{
			if (evt.keyCode == Keyboard.LEFT)
			{
				leftArrow = false
			}
			else if (evt.keyCode == Keyboard.RIGHT)
			{
				rightArrow = false
			}
			else if (evt.keyCode == Keyboard.UP)
			{
				upArrow = false
			}			
		}
		
		//MOVE THE CHARACTER + PLATFORMS
		var velocity: Number
		var xSpeed: Number = 0
		var jumpSpeed: Number
		function moveStudent (evt: Event)
		{
			student.stop()
			velocity = 5
			
			if (leftArrow == true)
			{
				xSpeed= -velocity
				//student.x = student.x - velocity
				student.width = student.width * (-1)
				student.rotation = 0
				student.play()
			}
			if (rightArrow == true)
			{
				xSpeed = velocity
				//student.x = student.x + velocity
				student.rotation = 0
				student.play()
			}
			if (upArrow == true )//|| studentJumping == true)
			{
				jumpSpeed = -10
				//student.y = student.y - 15
				student.y += jumpSpeed
				student. rotation = 0
				student.grav = -5
			}
			if(leftArrow || rightArrow)
			{
				student.x += xSpeed
			}
			else(xSpeed = 0)
			
			
			barriers()
			student.y += jumpSpeed
			var leftBumpPoint: Point = new Point(-10, -22)
			var rightBumpPoint: Point = new Point(10, -22)
			var upBumpPoint: Point = new Point(0, -45)
			var downBumpPoint: Point = new Point(0, 35)
			var rightBumping: Boolean = false
			var leftBumping: Boolean = false
			var downBumping: Boolean = false
			var upBumping: Boolean = false
			
			if(platforms.hitTestPoint(student.x + rightBumpPoint.x, student.y + rightBumpPoint.y, true))
			{rightBumping = true}
			else
			{rightBumping = false}
		
			if(platforms.hitTestPoint(student.x + leftBumpPoint.x, student.y + leftBumpPoint.y, true))
			{leftBumping = true}
			else
			{leftBumping = false}
		
			if(platforms.hitTestPoint(student.x + downBumpPoint.x, student.y + downBumpPoint.y, true))
			{downBumping = true}
			else
			{downBumping = false}
		
			if(platforms.plat.hitTestPoint(student.x + upBumpPoint.x, student.y + upBumpPoint.y, true))
			{upBumping = true}
			else
			{upBumping = true}
			
			if(leftBumping)
			{
				if(xSpeed < 0)
				{xSpeed *= 0}
			}
			
			if(rightBumping)
			{
				if(xSpeed > 0)
				{
					xSpeed *= 0
					
				}
			}
			
			if(downBumping)
			{
				if(grav > 0)
				{grav = 0}
				
				if(upArrow && jumpSpeed == 0)
				{jumpSpeed = -18}
			}
			
			if(upBumping)
			{
				if(jumpSpeed > 0)
				{jumpSpeed = 0}
				else
				{jumpSpeed = -18}
			}
		} 
		
		//BARRIERS + GRAVTIY
		var grav: int = 0
		var ground: int = 485
		function barriers()
		{
			student.y += grav/2
			
			if(student.y + student.height/2 < ground)
			{
				grav++
				jumpSpeed = 0
			}
			else
			{
				grav = 0
				student.y = ground - student.height/2
			}
			if(student.y - student.height/2 > 0)
			{
				jumpSpeed = 0
			}
			if(student.x - student.width/2 < 0)
			{
				student.x = student.width/2
			}
			if(student.x + student.width/2 > 490)
			{
				student.x = 490 - student.width/2
			}
		}
		
		// END MOVEMENT FUCNTIONS
		
		//POWER-UPS FUNCTIONS
		
		var score: Number
		var itemArray: Array = new Array()
		
		//SHOT GLASS
		var k: Number = 0
		var b: int = 0
		var glassOnStage: Boolean
		var shot1: shotGlass = new shotGlass
		
		function powerUpShot (evt: Event)
		{
			if (k == Math.round(Math.random()*100 + 50))
			{
				glassOnStage = true
				shot1.x = Math.round(Math.random()*(stage.stageWidth - 75))
				shot1.y = Math.round(Math.random()*(stage.stageHeight - 75))
				//itemArray.splice(0,0,shot1)
				addChild(shot1)
				b++			
			}
			if (glassOnStage == true && b >= 150 || student.hitTestObject(shot1))
			{
				glassOnStage = false
				//itemArray.shift()
				//itemArray[0].visible = false
				removeChild(shot1)
				b = 0
				k = 0
				score = score + 5
			}
			if (glassOnStage == false)
			{
				k++
				if ( k >= 150)
				{
					k = 0
				}
			}
		}
		
		//BEER 
		var j: Number = 0
		var t: Number = 0
		var beerOnStage: Boolean
		var beer1: beer = new beer
		
		function powerUpBeer (evt: Event)
		{
			if ( j == Math.round(Math.random()*120 + 50))
			{
				beerOnStage = true
				beer1.x = Math.round(Math.random()*(stage.stageWidth - 75))
				beer1.y = Math.round(Math.random()*(stage.stageHeight - 75))
				addChild(beer1)
				t++
			}
			if(beerOnStage == true && t >= 150 || student.hitTestObject(beer1))
			{
				removeChild(beer1)
				beerOnStage = false
				t = 0
				j = 0
				score = score + 2
			}
			if(beerOnStage == false)
			{
				j++
				if (j >= 170)
				{
					j = 0
				}
			}
		}
		
		//ENERGY DRINK
		var q: Number = 0
		var m: Number = 0
		var drinkOnStage: Boolean
		var engyDrink: energyDrink = new energyDrink
		
		function powerUpEngyDrink (evt: Event)
		{
			if (q == Math.round(Math.random()*150 + 80))
			{
				drinkOnStage = true
				engyDrink.x = Math.round(Math.random()*stage.stageWidth - 75)
				engyDrink.y = Math.round(Math.random()*stage.stageHeight - 75)
				addChild(engyDrink)
				m++
			}
			if (drinkOnStage == true && m >= 100 || student.hitTestObject(engyDrink))
			{
				removeChild(engyDrink)
				drinkOnStage = false
				m = 0
				q = 0
				score = score + 3
			}
			if (drinkOnStage == false)
			{
				q++
				if (q >= 230)
				{
					q =0
				}
			}
		}
		
		//BURGER
		var p: Number = 0
		var s: Number = 0
		var burgerOnStage: Boolean
		var burger1: burger = new burger
		
		function powerUpBurger (evt: Event)
		{
			if (p == Math.round(Math.random()*200 + 50))
			{
				burgerOnStage = true
				burger1.x = Math.round(Math.random()*(stage.stageWidth - 75))
				burger1.y = Math.round(Math.random()*(stage.stageHeight - 75))
				addChild(burger1)
				s++
			}
			if(burgerOnStage == true && s >= 50 || student.hitTestObject(burger1))
			{
				removeChild(burger1)
				burgerOnStage = false
				s = 0
				p = 0
				score = score + 7
			}
			if (burgerOnStage == false)
			{
				p++
				if (p >= 250)
				{
					p = 0
				}
			}
		}
		
		//CHASE
		var d: Number = 0
		var f: Number = 0
		var chaseOnStage: Boolean
		var chase1: chase = new chase
		
		function powerUpChase (evt: Event)
		{
			if (d == Math.round(Math.random()*100 + 75))
			{
				chaseOnStage = true
				chase1.x = Math.round(Math.random()*(stage.stageWidth - 75))
				chase1.y = Math.round(Math.random()*(stage.stageHeight - 75))
				addChild(chase1)
				f++
			}
			if (chaseOnStage == true && f >= 75 || student.hitTestObject(chase1))
			{
				removeChild(chase1)
				chaseOnStage = false
				f = 0
				d = 0
				score = score + 1
			}
			if (chaseOnStage == false)
			{
				d++
				if(d >= 175)
				{
					d = 0
				}
			}
		}
		
		//END POWER UPS
		
		//CHECK FUNCTION FOR IF DON HITS STUDENT
		function donHitStudent(): Boolean
		{
			if(sharukhman.hitTestObject(student))
			{return true}
			
			return false
		}
		
		//SHARUKHMAN AI
		var pX: int
		var pY: int
		var donSpeed: int = 7/2
		function aiSharukh(evt: Event)
		{
			if(pX > sharukhman.x)
			{
				sharukhman.x += donSpeed
			}
			if(pX < sharukhman.x)
			{
				sharukhman.x -= donSpeed
			}
			if(sharukhman.x >= pX - donSpeed && sharukhman.x <= pX + donSpeed)
			{
				if(pY > sharukhman.y)
				{
					sharukhman.y += donSpeed
				}
				if(pY < sharukhman.y)
				{
					sharukhman.y -= donSpeed
				}
				if(sharukhman.y >= pY - donSpeed && sharukhman.y <= pY + donSpeed)
				{
					pointHit()
				}
			}
			
		}
		function pointHit()
		{
			pX = Math.random()*(504 - sharukhman.width/2)
			pY = Math.random()*(544 - (sharukhman.height/2 + 25))
		}
	}
}