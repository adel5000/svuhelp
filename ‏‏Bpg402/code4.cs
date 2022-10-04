class StudentRecord {

 int id;
 string name;
 Date birth ;
 double eng, math, prog;
 double average;

 public StudentRecord(int idV,string nameV,
 double engV, double mathV, double progV, Date
birthV) {
 id = idV; name= nameV; birth = birthV;
 eng = engV; math=mathV; prog =progV;
 average = averageGrade();
 }
 public double averageGrade() {
 return (eng+math+prog)/3;
 }
 public double maxGrade() {
 return Math.Max( Math.Max(eng,math) , prog );
 }
public void display() {

 string toString = string.Format( " {0}{1} {2} {3} {4} {5}
",
 id, name, eng, math, prog,
average);
 string stBirh =birth.ToDateString();
 toString = toString + ""+stBirh;
 Console.WriteLine( toString);
}
}//class StudentRecord







using System;
public class StudentRecordTest {
// Use of defined class StudentRecord
public static void Main(string[] args) {
 string line;
 string[] items;
 int id;
 double eng, math, prog;
 string name;
 Date birth ;
 Console.Write(" Enter data as (20510 85 60 80 Sami) : ");
line = Console.ReadLine();
// input line data example : 20510 85 60 80 Sami
 items = line.Split();
 id = int.Parse(items[0]);
 eng = double.Parse(items[1]);
 math =double.Parse( items[2]);
 prog = double.Parse(items[3]);
 name = items[4];
 Console.Write(" Birthday as ( 1/10/2000) : ");
 line = Console.ReadLine();
 items = line.Split('/');
 int d= int.Parse(items[0]);
 int m= int.Parse(items[1]);
 int y= int.Parse(items[2]);
 birth = new Date(d,m,y);
// create object (std) of class (StudentRecord)
 birth = new Date(1,10,2000);
 StudentRecord std =new StudentRecord( id, name,
 eng, math, prog,
birth);
 Console.WriteLine("id name eng math prog Avg Birthday ");

Console.WriteLine("=======================================================
=====");
 // show objet (std)
 std.display();

} //Main
}//class
