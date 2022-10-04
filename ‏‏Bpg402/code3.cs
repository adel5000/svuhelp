using System;
// Date.cs
// Date class definition encapsulates month, day and year.
public class Date {
private int month; // 1-12
private int day; // 1-31 based on month
private int year; // any year
// constructor confirms proper value for month;
// call method CheckDay to confirm proper
// value for day
public Date( int theDay, int theMonth, int theYear ){
// validate month
if ( theMonth > 0 && theMonth <= 12 )
 month = theMonth;
else {
 month = 1;
 Console.WriteLine("Month {0} invalid. Set to month 1.",
 theMonth );
}
year = theYear; // could validate year
day = CheckDay( theDay, month, year ); // validate day
} // end Date constructor



// utility method confirms proper day value
// based on month and year
private int CheckDay( int d , int m, int y) {
int[] daysPerMonth =
 { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31
};
// check if day d in range for month
if ( d > 0 && d <= daysPerMonth[ m ] )
 return d;
// check for leap year
if ( m == 2 && d == 29 &&
 ( y % 400 == 0 ||( y % 4 == 0 && y % 100 != 0 ) ) )
 return d;
 Console.WriteLine("Day {0} invalid. Set to day 1.", d );
 return 1; // leave object in consistent state
}
// return date string as month/day/year
public string ToDateString(){
 return day + "/" + month+ "/" + year;
}
} // end class Date



/ DateTest.cs
// Demonstrating class Date.
// DateTest uses creates and uses a Date object
class DateTest {
static void Main( string[] args ) {
Console.WriteLine("new Date(10,12,2019); ");
Date date = new Date(10,12,2019); // calls Date constructor
Console.WriteLine( ""+ date.ToDateString());
Console.WriteLine("new Date(10,20,2019); ");
date = new Date(10,20,2019); // calls Date constructor
Console.WriteLine( ""+date.ToDateString());
Console.WriteLine("new Date(29,2,2020); ");
date = new Date(29,2,2020); // calls Date constructor
Console.WriteLine( ""+date.ToDateString());
}//Main
} // class TestDate
