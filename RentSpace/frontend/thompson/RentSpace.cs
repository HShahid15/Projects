using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thompson
{
    public partial class RentSpace : Form
    {
        // Global values passed from login popup, for username and organization
        private String organization;
        private String username;
        // User's remaining room booking hours for the semester
        private int remainingHours;
        private int tempHours;
        // Integer count representing the current number of temporary rooms
        private int tempRoom;
        // Integer value representing Month/Date (MMdd)
        private int dateValue;

        private string floorValue;
        // Array for row-to-room name values
        private readonly string[] roomTitle = { "120", "121", "141", "211", "212", "239", "242", "301", "302", "315", "316", "401", "404", "405", "407", "408", "411", "412", "413" };
        // Array for column-to-time values
        private readonly string[] timeColumn = { "8:30 AM", "9:30 AM", "10:30 AM", "11:30 AM", "12:30 PM", "1:30 PM", "2:30 PM", "3:30 PM", "4:30 PM", "5:30 PM", "6:30 PM", "7:30 PM", "8:30 PM", "9:30 PM", "10:30 PM", "11:30 PM" };
        // Array for temporary room booking cart
        private string[] tempCart;
        // 2-D Array for selected day
        int[,] activeDay;
        // 2-D Arrays for demo data
        private int[,] day1;
        private int[,] day2;
        private int[,] day3;
        private int[,] day4;
        private int[,] day5;
        private int[,] day6;
        private int[,] day7;
        private int[,] day0;
        // Arrays for permanent room booking cart
        private string[] day1cart;
        private string[] day2cart;
        private string[] day3cart;
        private string[] day4cart;
        private string[] day5cart;
        private string[] day6cart;
        private string[] day7cart;
        private string[] day0cart;

        private int[,] tempDay1CartCoord;
        private int[,] tempDay2CartCoord;
        private int[,] tempDay3CartCoord;
        private int[,] tempDay4CartCoord;
        private int[,] tempDay5CartCoord;
        private int[,] tempDay6CartCoord;
        private int[,] tempDay7CartCoord;
        private int[,] tempDay0CartCoord;

        private int[,] day1CartCoord;
        private int[,] day2CartCoord;
        private int[,] day3CartCoord;
        private int[,] day4CartCoord;
        private int[,] day5CartCoord;
        private int[,] day6CartCoord;
        private int[,] day7CartCoord;
        private int[,] day0CartCoord;

        private int[] finalRoom;

        private int day1cartSize;
        private int day2cartSize;
        private int day3cartSize;
        private int day4cartSize;
        private int day5cartSize;
        private int day6cartSize;
        private int day7cartSize;
        private int day0cartSize;

        public RentSpace(String inputOrg, String inputUser)
        {
            InitializeComponent();
            // Initialize data
            organization = inputOrg;
            username = inputUser;
            remainingHours = 50;
            tempHours = remainingHours;
            tempRoom = 0;
            tempCart = new string[5];
            // Initialize demo day data
            //string[] timeColumn = 
            day1 = new int[19, 15] { { -1, 0, 0, 0, 0, -1, 0, -1, -1, 0, -1, -1, -1, -1, -1 }, { -1, 0, 0, 0, -1, 0, -1, -1, -1, 0, -1, -1, -1, -1, 0 }, { 0, -1, -1, 0, -1, 0, -1, 0, 0, 0, 0, -1, -1, -1, 0 }, { 0, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, -1, -1, -1, 0 }, { 0, -1, 0, 0, -1, 0, -1, -1, 0, -1, 0, 0, 0, 0, -1 }, { 0, -1, 0, -1, 0, 0, 0, -1, -1, -1, -1, -1, 0, -1, 0 }, { -1, -1, -1, 0, 0, 0, 0, -1, 0, -1, -1, 0, -1, 0, -1 }, { 0, -1, 0, 0, 0, -1, 0, -1, -1, 0, 0, 0, -1, 0, 0 }, { -1, -1, -1, 0, 0, 0, -1, 0, 0, -1, 0, 0, 0, -1, -1 }, { -1, 0, 0, 0, 0, 0, -1, 0, -1, -1, 0, -1, 0, 0, -1 }, { 0, -1, -1, -1, 0, -1, 0, -1, -1, 0, 0, -1, -1, -1, 0 }, { -1, -1, -1, 0, -1, 0, -1, -1, 0, 0, -1, -1, 0, 0, 0 }, { -1, -1, -1, 0, -1, 0, 0, 0, -1, -1, -1, -1, 0, 0, -1 }, { -1, -1, 0, -1, -1, 0, 0, -1, -1, 0, 0, 0, -1, 0, 0 }, { -1, -1, -1, -1, 0, 0, -1, -1, 0, -1, -1, 0, -1, 0, 0 }, { 0, -1, 0, -1, 0, 0, 0, -1, -1, 0, 0, 0, 0, -1, 0 }, { -1, -1, -1, -1, 0, 0, -1, -1, 0, -1, 0, -1, -1, 0, -1 }, { -1, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1, 0, 0, 0, 0 }, { -1, -1, 0, 0, -1, 0, 0, -1, -1, -1, 0, -1, -1, 0, 0 } };
            day2 = new int[19, 15] { { -1, 0, -1, 0, -1, -1, 0, 0, 0, 0, -1, 0, -1, -1, 0 }, { 0, -1, -1, 0, -1, 0, -1, 0, 0, 0, -1, -1, 0, 0, 0 }, { -1, -1, -1, -1, -1, 0, -1, -1, 0, -1, 0, -1, -1, 0, -1 }, { 0, -1, 0, -1, -1, 0, 0, -1, -1, -1, 0, -1, -1, 0, 0 }, { -1, 0, -1, -1, 0, -1, -1, -1, 0, 0, -1, -1, -1, 0, 0 }, { 0, 0, -1, 0, -1, 0, 0, 0, -1, -1, -1, 0, 0, -1, 0 }, { -1, 0, -1, -1, 0, 0, 0, 0, -1, -1, 0, 0, 0, -1, -1 }, { 0, 0, -1, -1, 0, 0, 0, 0, 0, 0, -1, 0, -1, 0, -1 }, { -1, 0, 0, 0, 0, 0, -1, -1, 0, 0, -1, -1, 0, -1, -1 }, { 0, -1, -1, 0, 0, -1, 0, 0, 0, 0, -1, 0, -1, 0, -1 }, { 0, 0, -1, 0, 0, 0, -1, -1, 0, 0, -1, 0, -1, -1, -1 }, { -1, 0, -1, 0, 0, 0, 0, 0, -1, 0, -1, 0, -1, 0, 0 }, { 0, 0, -1, 0, -1, 0, 0, 0, 0, 0, 0, -1, -1, 0, 0 }, { 0, -1, -1, -1, -1, 0, -1, -1, -1, -1, 0, -1, -1, 0, 0 }, { -1, -1, -1, -1, 0, -1, -1, 0, 0, 0, -1, -1, 0, 0, 0 }, { -1, -1, 0, 0, 0, 0, -1, -1, -1, -1, 0, 0, 0, 0, -1 }, { -1, -1, -1, 0, -1, 0, -1, 0, 0, 0, 0, -1, -1, 0, 0 }, { 0, 0, 0, -1, 0, 0, -1, 0, -1, -1, 0, -1, 0, -1, 0 }, { -1, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, 0, -1, -1, -1 } };
            day3 = new int[19, 15] { { 0, 0, 0, 0, -1, -1, 0, -1, -1, 0, -1, -1, 0, -1, -1 }, { 0, 0, -1, -1, -1, -1, 0, -1, 0, -1, -1, -1, 0, -1, -1 }, { -1, -1, 0, -1, -1, 0, 0, 0, -1, -1, -1, 0, -1, -1, -1 }, { 0, 0, 0, -1, -1, -1, -1, 0, -1, -1, 0, -1, 0, -1, 0 }, { 0, 0, 0, -1, 0, -1, -1, 0, 0, -1, -1, -1, -1, -1, -1 }, { -1, -1, 0, 0, 0, 0, -1, -1, 0, -1, 0, 0, -1, -1, -1 }, { 0, 0, -1, 0, -1, -1, 0, -1, 0, -1, -1, 0, -1, 0, 0 }, { 0, -1, -1, -1, -1, -1, 0, -1, 0, -1, -1, -1, -1, -1, 0 }, { 0, 0, -1, -1, 0, 0, 0, -1, 0, -1, -1, -1, 0, -1, -1 }, { 0, -1, 0, 0, -1, 0, -1, -1, 0, 0, -1, 0, 0, -1, -1 }, { 0, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, 0, -1 }, { -1, -1, -1, -1, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, 0 }, { 0, -1, -1, 0, 0, 0, -1, 0, -1, -1, -1, 0, -1, 0, -1 }, { 0, -1, 0, -1, -1, 0, 0, 0, -1, 0, -1, 0, 0, -1, 0 }, { -1, 0, 0, -1, -1, 0, 0, 0, -1, 0, 0, -1, 0, -1, 0 }, { 0, 0, 0, -1, -1, -1, -1, 0, -1, 0, 0, -1, 0, -1, 0 }, { 0, 0, 0, 0, -1, 0, -1, 0, 0, -1, 0, 0, -1, -1, -1 }, { 0, 0, -1, -1, 0, -1, 0, -1, 0, -1, -1, -1, 0, 0, -1 }, { 0, -1, 0, -1, -1, -1, -1, -1, 0, -1, 0, 0, -1, 0, 0 } };
            day4 = new int[19, 15] { { 0, -1, 0, -1, -1, -1, 0, -1, -1, 0, -1, 0, 0, -1, 0 }, { -1, -1, 0, -1, -1, 0, -1, -1, 0, 0, 0, -1, -1, -1, 0 }, { 0, -1, -1, 0, 0, 0, -1, 0, -1, -1, 0, 0, -1, 0, 0 }, { 0, -1, -1, 0, 0, 0, 0, 0, 0, 0, 0, 0, -1, 0, -1 }, { -1, -1, -1, 0, 0, 0, 0, 0, 0, 0, -1, 0, 0, 0, -1 }, { -1, -1, 0, 0, 0, -1, 0, 0, -1, 0, -1, -1, 0, -1, 0 }, { 0, -1, -1, -1, 0, 0, -1, 0, -1, 0, 0, -1, -1, -1, -1 }, { -1, 0, 0, -1, -1, 0, 0, -1, -1, -1, -1, -1, -1, -1, 0 }, { 0, 0, 0, 0, -1, -1, -1, 0, -1, -1, 0, -1, 0, -1, -1 }, { 0, 0, 0, -1, 0, 0, -1, -1, 0, -1, 0, 0, -1, 0, 0 }, { -1, -1, -1, -1, -1, 0, 0, -1, -1, 0, -1, -1, 0, 0, -1 }, { 0, -1, 0, 0, 0, -1, 0, -1, 0, -1, -1, -1, -1, 0, 0 }, { -1, -1, 0, -1, 0, 0, 0, 0, -1, 0, 0, 0, -1, -1, -1 }, { 0, 0, 0, 0, -1, -1, 0, 0, -1, -1, 0, -1, 0, 0, 0 }, { 0, 0, 0, 0, -1, 0, -1, -1, 0, -1, 0, 0, -1, 0, 0 }, { 0, -1, -1, 0, -1, -1, 0, 0, -1, 0, -1, 0, 0, 0, 0 }, { 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 0, -1, -1 }, { -1, -1, 0, 0, -1, 0, 0, -1, 0, -1, 0, 0, -1, -1, 0 }, { 0, -1, 0, 0, 0, -1, 0, 0, 0, 0, -1, -1, 0, 0, -1 } };
            day5 = new int[19, 15] { { 0, -1, -1, 0, -1, -1, -1, -1, -1, 0, 0, -1, -1, -1, 0 }, { -1, 0, -1, -1, 0, 0, 0, 0, -1, 0, 0, -1, 0, -1, 0 }, { -1, -1, -1, 0, 0, 0, 0, -1, 0, 0, -1, 0, 0, -1, -1 }, { 0, 0, -1, -1, 0, -1, -1, 0, -1, -1, 0, 0, 0, 0, -1 }, { 0, 0, 0, 0, -1, 0, -1, -1, 0, -1, -1, 0, 0, 0, -1 }, { 0, -1, -1, 0, 0, 0, 0, -1, 0, 0, -1, -1, -1, -1, 0 }, { -1, -1, -1, -1, 0, -1, -1, 0, 0, 0, 0, -1, 0, -1, -1 }, { 0, 0, -1, 0, 0, 0, 0, -1, 0, 0, 0, -1, 0, 0, -1 }, { 0, -1, 0, 0, -1, -1, -1, 0, -1, 0, 0, -1, 0, -1, -1 }, { -1, -1, -1, 0, -1, 0, 0, 0, -1, 0, 0, 0, 0, -1, 0 }, { 0, -1, -1, 0, -1, 0, 0, 0, -1, -1, 0, -1, 0, -1, -1 }, { -1, -1, 0, 0, -1, -1, 0, 0, 0, 0, -1, 0, 0, 0, 0 }, { 0, 0, -1, -1, -1, -1, 0, 0, 0, 0, -1, -1, 0, 0, 0 }, { -1, -1, -1, 0, 0, 0, -1, -1, 0, 0, 0, 0, -1, 0, 0 }, { 0, 0, -1, 0, 0, -1, 0, 0, -1, -1, 0, -1, -1, 0, -1 }, { 0, 0, -1, -1, -1, 0, 0, 0, 0, 0, 0, 0, -1, -1, -1 }, { -1, 0, -1, 0, 0, 0, 0, 0, 0, 0, 0, 0, -1, -1, 0 }, { -1, 0, 0, 0, -1, -1, -1, 0, 0, -1, 0, 0, 0, 0, 0 }, { 0, 0, 0, -1, -1, 0, -1, -1, 0, -1, 0, 0, -1, 0, -1 } };
            day6 = new int[19, 15] { { -1, -1, -1, -1, 0, -1, 0, -1, 0, 0, -1, 0, -1, -1, 0 }, { 0, -1, -1, 0, 0, 0, 0, -1, -1, -1, -1, -1, 0, 0, -1 }, { -1, -1, -1, -1, -1, 0, -1, 0, 0, 0, 0, -1, -1, -1, 0 }, { -1, 0, -1, -1, 0, 0, 0, 0, -1, -1, 0, -1, -1, 0, -1 }, { -1, -1, 0, -1, 0, -1, 0, 0, -1, 0, 0, 0, 0, -1, -1 }, { -1, -1, -1, 0, 0, -1, -1, 0, 0, 0, -1, 0, -1, -1, -1 }, { 0, 0, 0, -1, 0, -1, -1, -1, 0, -1, -1, -1, -1, 0, 0 }, { -1, -1, -1, 0, -1, -1, 0, -1, 0, -1, -1, -1, -1, -1, 0 }, { -1, 0, -1, 0, -1, 0, 0, 0, 0, -1, -1, -1, 0, -1, -1 }, { -1, -1, -1, 0, -1, 0, 0, -1, 0, -1, 0, 0, -1, 0, -1 }, { -1, 0, -1, -1, 0, 0, 0, -1, -1, 0, 0, -1, 0, 0, 0 }, { 0, 0, -1, -1, -1, -1, 0, -1, -1, -1, -1, -1, 0, -1, 0 }, { -1, 0, -1, 0, -1, -1, 0, -1, 0, 0, 0, -1, -1, -1, -1 }, { 0, 0, -1, -1, 0, 0, 0, -1, -1, -1, -1, -1, 0, -1, 0 }, { -1, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, 0, 0, -1, -1 }, { -1, 0, -1, 0, -1, 0, 0, 0, 0, -1, -1, -1, 0, 0, 0 }, { 0, 0, 0, -1, -1, 0, -1, -1, -1, 0, -1, 0, 0, -1, 0 }, { -1, -1, 0, 0, 0, -1, 0, 0, 0, 0, 0, 0, 0, -1, 0 }, { 0, 0, -1, -1, -1, -1, 0, -1, 0, 0, 0, -1, -1, -1, -1 } };
            day7 = new int[19, 15] { { -1, -1, 0, 0, -1, -1, -1, 0, -1, 0, 0, -1, 0, 0, 0 }, { -1, 0, -1, 0, -1, -1, -1, 0, 0, -1, -1, 0, -1, 0, 0 }, { 0, -1, -1, 0, -1, 0, 0, 0, -1, -1, -1, 0, 0, 0, 0 }, { -1, 0, 0, 0, 0, -1, -1, -1, -1, -1, 0, 0, 0, -1, -1 }, { -1, 0, -1, -1, 0, 0, 0, -1, 0, 0, -1, -1, 0, 0, 0 }, { 0, -1, -1, 0, -1, -1, 0, -1, -1, -1, -1, -1, -1, 0, -1 }, { -1, 0, -1, 0, 0, 0, 0, -1, -1, 0, 0, -1, 0, 0, 0 }, { -1, 0, 0, 0, -1, -1, -1, -1, 0, 0, 0, 0, -1, 0, 0 }, { -1, 0, -1, -1, -1, 0, -1, 0, 0, 0, -1, 0, -1, 0, 0 }, { -1, -1, -1, -1, -1, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1 }, { -1, -1, -1, 0, -1, -1, -1, 0, -1, 0, -1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, -1, -1, 0, -1, -1, -1, -1, -1, 0 }, { -1, 0, 0, -1, -1, 0, 0, -1, 0, 0, -1, -1, -1, 0, -1 }, { 0, 0, -1, -1, 0, -1, 0, 0, -1, -1, -1, -1, -1, 0, 0 }, { -1, 0, -1, 0, -1, 0, -1, 0, 0, -1, -1, -1, -1, -1, 0 }, { -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, -1, -1, -1, -1, 0 }, { 0, 0, -1, -1, -1, -1, -1, 0, 0, -1, -1, 0, 0, 0, 0 }, { -1, -1, -1, 0, 0, 0, 0, -1, -1, -1, 0, -1, 0, -1, 0 }, { -1, 0, -1, -1, -1, 0, -1, 0, -1, 0, 0, -1, 0, 0, -1 } };
            day0 = new int[19, 15] { { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } };
            // Initialize demo day carts
            day1cart = new string[5];
            day2cart = new string[5];
            day3cart = new string[5];
            day4cart = new string[5];
            day5cart = new string[5];
            day6cart = new string[5];
            day7cart = new string[5];
            day0cart = new string[5];

            
            tempDay1CartCoord = new int[2, 5];
            tempDay2CartCoord = new int[2, 5];
            tempDay3CartCoord = new int[2, 5];
            tempDay4CartCoord = new int[2, 5];
            tempDay5CartCoord = new int[2, 5];
            tempDay6CartCoord = new int[2, 5];
            tempDay7CartCoord = new int[2, 5];
            tempDay0CartCoord = new int[2, 5];

            day1CartCoord = new int[2, 5];
            day2CartCoord = new int[2, 5];
            day3CartCoord = new int[2, 5];
            day4CartCoord = new int[2, 5];
            day5CartCoord = new int[2, 5];
            day6CartCoord = new int[2, 5];
            day7CartCoord = new int[2, 5];
            day0CartCoord = new int[2, 5];

            finalRoom = new int[8];

            day1cartSize = 0;
            day2cartSize = 0;
            day3cartSize = 0;
            day4cartSize = 0;
            day5cartSize = 0;
            day6cartSize = 0;
            day7cartSize = 0;
            day0cartSize = 0;

            libPick.SelectedIndex = 0;
            floor.SelectedIndex = 0;
            floorValue = "Floor 1";
            // Initialize dateTimePicker custom formatter
            dateValue = Int32.Parse(dateChooser.Value.Date.ToString("MMdd"));
            // Debug, display date value
            // Initialize DataTable for DataGridView
            DataTable dt = new DataTable();
            for(int i = 0; i < roomTitle.Length; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.HeaderCell.Value = "Room " + roomTitle[i];
                bookingGridView.Rows.Add(row);
            }
            bookingGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            bookingGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            bookingGridView.AutoResizeRowHeadersWidth(0, DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            bookingGridView.AllowUserToResizeRows = false;
            bookingGridView.AllowUserToResizeColumns = false;
            bookingGridView.AllowUserToOrderColumns = false;
            bookingGridView.AllowUserToDeleteRows = false;
            bookingGridView.AllowUserToAddRows = false;
            bookingGridView.ReadOnly = true;
            bookingGridView.Refresh();
            ReloadLocalData();
        }

        private void ReloadLocalData()
        {
            tempHours = remainingHours;
            remainingHoursLabel.Text = "" + remainingHours;
            userLabel.Text = "" + username;
            // Set default "day" array for usage
            activeDay = day0;
            floorValue = floor.Text;
            if (floorValue == "Floor 1")
            {
                pictureBox1.Image = thompson.Properties.Resources._1st_Floor;
            }
            else if (floorValue == "Floor 2")
            {
                pictureBox1.Image = thompson.Properties.Resources._2nd_Floor;
            }
            else if (floorValue == "Floor 3")
            {
                pictureBox1.Image = thompson.Properties.Resources._3rd_Floor;
            }
            else
            {
                pictureBox1.Image = thompson.Properties.Resources._4th_Floor;
            }
            dateValue = Int32.Parse(dateChooser.Value.Date.ToString("MMdd"));
            cartLabel1.Text = "";
            cartLabel2.Text = "";
            cartLabel3.Text = "";
            cartLabel4.Text = "";
            cartLabel5.Text = "";
            if (dateValue <= 1130)
            {
                activeDay = day1;
                tempRoom = finalRoom[1];
                tempCart = day1cart;
                tempDay1CartCoord = day1CartCoord;
            }
            else if(dateValue == 1201)
            {
                activeDay = day2;
                tempRoom = finalRoom[2];
                tempCart = day2cart;
                tempDay2CartCoord = day2CartCoord;
            }
            else if (dateValue == 1202)
            {
                activeDay = day3;
                tempRoom = finalRoom[3];
                tempCart = day3cart;
                tempDay3CartCoord = day3CartCoord;
            }
            else if (dateValue == 1203)
            {
                activeDay = day4;
                tempRoom = finalRoom[4];
                tempCart = day4cart;
                tempDay4CartCoord = day4CartCoord;
            }
            else if (dateValue == 1204)
            {
                activeDay = day5;
                tempRoom = finalRoom[5];
                tempCart = day5cart;
                tempDay5CartCoord = day5CartCoord;
            }
            else if (dateValue == 1205)
            {
                activeDay = day6;
                tempRoom = finalRoom[6];
                tempCart = day6cart;
                tempDay6CartCoord = day6CartCoord;
            }
            else if (dateValue == 1206)
            {
                activeDay = day7;
                tempRoom = finalRoom[7];
                tempCart = day7cart;
                tempDay7CartCoord = day7CartCoord;
            }
            else
            {
                activeDay = day0;
                tempRoom = finalRoom[0];
                tempCart = day0cart;
                tempDay0CartCoord = day0CartCoord;
            }

            cartLabel1.Text = tempCart[0];
            cartLabel2.Text = tempCart[1];
            cartLabel3.Text = tempCart[2];
            cartLabel4.Text = tempCart[3];
            cartLabel5.Text = tempCart[4];

            // Refresh data grid arrays (Loop through each room, loop through each hour bracket)
            for (int i = 0; i < 19; i++)
            {
                // Loop through individual columns
                for(int j = 0; j < 15; j++)
                {
                    DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)bookingGridView.Rows[i].Cells[j];
                    buttonCell.FlatStyle = FlatStyle.Popup;
                    if(activeDay[i,j] == 0)
                    {
                        buttonCell.Style.BackColor = System.Drawing.Color.LightGreen;
                    }
                    else if( activeDay[i, j] == 1)
                    {
                        buttonCell.Style.BackColor = System.Drawing.Color.Yellow;
                    }
                    else
                    {
                        buttonCell.Style.BackColor = System.Drawing.Color.IndianRed;
                    }
                }
            }
            // Update data grid visuals
            bookingGridView.Refresh();
        }

        private void SubmitLocalData()
        {
            remainingHours = tempHours;
            remainingHoursLabel.Text = "" + remainingHours;
            if (activeDay == day1)
            {
                day1cart = tempCart;
                day1CartCoord = tempDay1CartCoord;
                finalRoom[1] = tempRoom;
                for (int i = 0; i < 5; i++)
                {
                    //Debug.Write(day2CartCoord[0, i] + ", " + day2CartCoord[1, i] + "/n");
                    if (day1CartCoord[0, i] != 0 || day1CartCoord[1, i] != 0)
                    {
                        day1[day1CartCoord[0, i], day1CartCoord[1, i]] = 1;
                    }

                }
            }
            else if (activeDay == day2)
            {
                day2cart = tempCart;
                day2CartCoord = tempDay2CartCoord;
                finalRoom[2] = tempRoom;
                for (int i = 0; i < 5; i++)
                {
                    //Debug.Write(day2CartCoord[0, i] + ", " + day2CartCoord[1, i] + "/n");
                    if (day2CartCoord[0, i] != 0 || day2CartCoord[1, i] != 0)
                    {
                        day2[day2CartCoord[0, i], day2CartCoord[1, i]] = 1;
                    }

                }
            }
            else if (activeDay == day3)
            {
                day3cart = tempCart;
                day3CartCoord = tempDay3CartCoord;
                finalRoom[3] = tempRoom;
                for (int i = 0; i < 5; i++)
                {
                    //Debug.Write(day3CartCoord[0, i] + ", " + day3CartCoord[1, i] + "/n");
                    if (day3CartCoord[0, i] != 0 || day3CartCoord[1, i] != 0)
                    {
                        day3[day3CartCoord[0, i], day3CartCoord[1, i]] = 1;
                    }

                }
            }
            else if (activeDay == day4)
            {
                day4cart = tempCart;
                day4CartCoord = tempDay4CartCoord;
                finalRoom[4] = tempRoom;
                for (int i = 0; i < 5; i++)
                {
                    //Debug.Write(day2CartCoord[0, i] + ", " + day2CartCoord[1, i] + "/n");
                    if (day4CartCoord[0, i] != 0 || day4CartCoord[1, i] != 0)
                    {
                        day4[day4CartCoord[0, i], day4CartCoord[1, i]] = 1;
                    }

                }
            }
            else if (activeDay == day5)
            {
                day5cart = tempCart;
                day5CartCoord = tempDay5CartCoord;
                finalRoom[5] = tempRoom;
                for (int i = 0; i < 5; i++)
                {
                    //Debug.Write(day2CartCoord[0, i] + ", " + day2CartCoord[1, i] + "/n");
                    if (day5CartCoord[0, i] != 0 || day5CartCoord[1, i] != 0)
                    {
                        day5[day5CartCoord[0, i], day5CartCoord[1, i]] = 1;
                    }

                }
            }
            else if (activeDay == day6)
            {
                day6cart = tempCart;
                day6CartCoord = tempDay6CartCoord;
                finalRoom[6] = tempRoom;
                for (int i = 0; i < 5; i++)
                {
                    //Debug.Write(day2CartCoord[0, i] + ", " + day2CartCoord[1, i] + "/n");
                    if (day6CartCoord[0, i] != 0 || day6CartCoord[1, i] != 0)
                    {
                        day6[day6CartCoord[0, i], day6CartCoord[1, i]] = 1;
                    }

                }
            }
            else if (activeDay == day7)
            {
                day7cart = tempCart;
                day7CartCoord = tempDay7CartCoord;
                finalRoom[7] = tempRoom;
                for (int i = 0; i < 5; i++)
                {
                    //Debug.Write(day2CartCoord[0, i] + ", " + day2CartCoord[1, i] + "/n");
                    if (day7CartCoord[0, i] != 0 || day7CartCoord[1, i] != 0)
                    {
                        day7[day7CartCoord[0, i], day7CartCoord[1, i]] = 1;
                    }

                }
            }
            else
            {
                day0cart = tempCart;
                day0CartCoord = tempDay0CartCoord;
                finalRoom[0] = tempRoom;
                for (int i = 0; i < 5; i++)
                {
                    //Debug.Write(day2CartCoord[0, i] + ", " + day2CartCoord[1, i] + "/n");
                    if (day0CartCoord[0, i] != 0 || day0CartCoord[1, i] != 0)
                    {
                        day0[day0CartCoord[0, i], day0CartCoord[1, i]] = 1;
                    }

                }
            }
        }

        private void RentSpace_Load(object sender, EventArgs e)
        {
            //loginScreen.Visible = true;
        }

        //date chooser  - needs database
        private void dateChooser_ValueChanged(object sender, EventArgs e)
        {
            //change the availability of the different slots in the table
            ReloadLocalData();
        }

        //Floor chooser
        private void floor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //changes the map
        }

        //rooms table  - needs database
        private void rooms_ControlAdded(object sender, ControlEventArgs e)
        {
            //populated with text boxes displaying the room info
        }

        //time picker - needs database
        private void timePicker_ControlAdded(object sender, ControlEventArgs e)
        {
            //populated with buttons for the available rooms
        }

        //library drop-down - needs database
        private void libPick_SelectedIndexChanged(object sender, EventArgs e)
        {
            //change the layout of the two tables
        }

        //Submit button - needs database
        private void submitBtn_Click(object sender, EventArgs e)
        {
            SubmitLocalData();   
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void bookingGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if(senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                // Button clicked
                DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)bookingGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                // Remove button focus
                    // Code
                if(buttonCell.Style.BackColor == System.Drawing.Color.LightGreen)
                {
                    if (tempRoom < 5 && tempHours >= 1)
                    {
                        string activeRoom = "Room " + roomTitle[e.RowIndex] + ", " + timeColumn[e.ColumnIndex] + " - " + timeColumn[e.ColumnIndex + 1];
                        if (Array.IndexOf(tempCart, activeRoom) == -1)
                        {
                            tempCart[tempRoom] = activeRoom;
                            // Increment temporary room count
                        }
                        if (activeDay == day1)
                        {
                            tempDay1CartCoord[0, tempRoom] = e.RowIndex;
                            tempDay1CartCoord[1, tempRoom] = e.ColumnIndex;
                        }
                        else if (activeDay == day2)
                        {
                            tempDay2CartCoord[0, tempRoom] = e.RowIndex;
                            tempDay2CartCoord[1, tempRoom] = e.ColumnIndex;

                        }
                        else if (activeDay == day3)
                        {
                            tempDay3CartCoord[0, tempRoom] = e.RowIndex;
                            tempDay3CartCoord[1, tempRoom] = e.ColumnIndex;
                        }
                        else if (activeDay == day4)
                        {
                            tempDay4CartCoord[0, tempRoom] = e.RowIndex;
                            tempDay4CartCoord[1, tempRoom] = e.ColumnIndex;
                        }
                        else if (activeDay == day5)
                        {
                            tempDay5CartCoord[0, tempRoom] = e.RowIndex;
                            tempDay5CartCoord[1, tempRoom] = e.ColumnIndex;
                        }
                        else if (activeDay == day6)
                        {
                            tempDay6CartCoord[0, tempRoom] = e.RowIndex;
                            tempDay6CartCoord[1, tempRoom] = e.ColumnIndex;
                        }
                        else if (activeDay == day7)
                        {
                            tempDay7CartCoord[0, tempRoom] = e.RowIndex;
                            tempDay7CartCoord[1, tempRoom] = e.ColumnIndex;
                        }
                        else
                        {
                            tempDay0CartCoord[0, tempRoom] = e.RowIndex;
                            tempDay0CartCoord[1, tempRoom] = e.ColumnIndex;
                        }
                        buttonCell.Style.BackColor = System.Drawing.Color.Yellow;
                        tempHours--;
                        tempRoom++;
                    }
                    cartLabel1.Text = tempCart[0];
                    cartLabel2.Text = tempCart[1];
                    cartLabel3.Text = tempCart[2];
                    cartLabel4.Text = tempCart[3];
                    cartLabel5.Text = tempCart[4];
                }
                
            }

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            SubmitLocalData();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            ReloadLocalData();
        }

        private void cartTableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox16_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



    }
}
