using System;

// Class Time maintains time in 24-h format.
// Time class definition
public class Time {
public int h; // 0-23
public int m; // 0-59
public int s; // 0-59
// Time constructor initializes instance variables to
// zero to set default time to midnight
public Time(){
SetTime( 0, 0, 0 );
}
public Time(int hv){
SetTime( hv, 0, 0 );
}
public Time(int hv, int mv){
SetTime( hv, mv, 0 );
}
public Time(int hv, int mv, int sv){
SetTime( hv, mv, 0 );
}
// Set new time value in 24-h format. Perform validity
// checks on the data. Set invalid values to zero.
public void SetTime(int hv, int mv, int sv ) {
 h = ( hv >= 0 && hv < 24 ) ? hv : 0;
 m = ( mv >= 0 && mv < 60 ) ? mv : 0;
 s = ( sv >= 0 && sv < 60 ) ? sv : 0;
} // end method SetTime
// convert time to universal-time (24 h) format string
public string ToUniversalString() {
 return String.Format("{0:D2}:{1:D2}:{2:D2}", h, m, s );
}
// convert time to standard-time (12 h) format string
public string ToStandardString() {
int hh = ( ( h == 12 || h == 0 ) ? 12 : h % 12 );
string AmPm = ( h < 12 ? "AM" : "PM" );
 return String.Format( "{0}:{1:D2}:{2:D2} {3}",
 hh ,m, s, AmPm );
}
}// end class Time


// TimeTest.cs
// Demonstrating class Time.
using System;
using System.Windows.Forms;
// TimeTest uses creates and uses a Time object
class TimeTest {
// main entry point for application
static void Main( string[] args ) {
Time time = new Time(); // calls Time constructor
string output;
// assign string representation of time to output
output = "Initial universal time is: "
 + time.ToUniversalString()
 + "standard time is: "
 + time.ToStandardString();
// attempt valid time settings
time.SetTime( 15, 45, 30 );
// append new string representations of time to output
output += "time after SetTime is: "
 + time.ToUniversalString()
 + "time after SetTime is: "
 + time.ToStandardString();

// attempt invalid time settings
time.SetTime( 60, 70, 80 );
output += "attempting invalid settings: "
 +"time: " + time.ToUniversalString()
 +"time: " + time.ToStandardString();

MessageBox.Show( output, "Testing Class Time" );
} // end method Main
}// end class TimeTest

