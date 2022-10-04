// Time2.cs
// Class Time2 provides overloaded constructors.
// Class Time2 uses set and get accessors.
// Time2 class definition
public class Time2 {
private int hour; // 0-23
private int minute; // 0-59
private int second; // 0-59
// property Hour
public int Hour{
get { return hour;}
set {
hour = ( ( value >= 0 && value < 24 ) ? value : 0 );}
} // end property Hour
// property Minute
public int Minute {
get { return minute;}
set { minute = ( ( value >= 0 && value < 60 ) ? value : 0 );}
} // end property Minute
// property Second
public int Second {
get { return second; }
set { second = ( ( value >= 0 && value < 60 ) ? value : 0 );}
} // end property Second
// Time2 constructor initializes instance variables to
// zero to set default time to midnight
public Time2() {
SetTime( 0, 0, 0 );
}
// Time2 constructor: hour supplied, minute and second
// defaulted to 0
public Time2( int h ) {
SetTime( h, 0, 0 );
}
// Time2 constructor: hour and minute supplied, second
// defaulted to 0
public Time2( int h, int m ) {
SetTime( h, m, 0 );
}
// Time2 constructor: hour, minute and second supplied
public Time2( int h, int m, int s ){
SetTime( h, m, s );
}
// Time2 constructor: initialize using another Time3 object
public Time2( Time2 time ) {
SetTime( time.Hour, time.Minute, time.Second );
}
// Set new time value in 24-hour format. Perform validity
// checks on the data. Set invalid values to zero.
public void SetTime(int h, int m, int s ){
Hour = hour;
Minute = minute;
Second = second;
}
// convert time to universal-time (24 hour) format string
public string ToUniversalString(){
return String.Format("{0:D2}:{1:D2}:{2:D2}", Hour, Minute,
Second );
}
// convert time to standard-time (12 hour) format string
public string ToStandardString(){
 return String.Format( "{0}:{1:D2}:{2:D2} {3}",
 ( ( Hour == 12 || Hour == 0 ) ? 12 : Hour % 12 ),
 Minute, Second, ( Hour < 12 ? "AM" : "PM" ) );
}
} // end class Time2





// Time2Test.cs
// Demonstrating class Time2 using set, get.
using System;
using System.Windows.Forms;
// Time2Test creates and uses a Time2 object
class Time2Test {
// main entry point for application
static void Main( string[] args ) {
Time2 time = new Time2(); // calls Time2 constructor
string output;
// assign string representation of time to output
output = "Initial universal time is: "
 + time.ToUniversalString()
 + "standard time is: "
 + time.ToStandardString();
// attempt valid time settings
time.SetTime( 18, 40, 20 );
// append new string representations of time to output
output += "time after SetTime is: "
 + time.ToUniversalString()
 + "time after SetTime is: "
 + time.ToStandardString();

// attempt invalid time settings
time.SetTime( 30, 65, 70 );
output += "attempting invalid settings: "
 +"time: " + time.ToUniversalString()
 +"time: " + time.ToStandardString();

MessageBox.Show( output, "Testing Class Time" );
} // end method Main
}// end class TimeTest
