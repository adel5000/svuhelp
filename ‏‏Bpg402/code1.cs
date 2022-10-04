using System;

class Strings
{
	static void Main(string[] args)
	{
		string s1 = "One Two Three Four";
		int ix;
		// get the index of the last space
		ix = s1.LastIndexOf(" ");
		// get the last word.
		string s2 = s1.Substring(ix + 1);
		// set s1 to the substring starting at 0
		// and ending at ix (the start of the last word
		// thus s1 has one two three
		s1 = s1.Substring(0, ix);
		// find the last space in s1 (after two)
		ix = s1.LastIndexOf(" ");
		// set s3 to the substring starting at
		// ix, the space after "two" plus one more
		// thus s3 = "three"
		string s3 = s1.Substring(ix + 1);
		Console.WriteLine("s2: {0}\ns3: {1}", s2, s3);
		// reset s1 to the substring starting at 0
		// and ending at ix, thus the string "one two"
		s1 = s1.Substring(0, ix);
		// reset ix to the space between "one" and "two"
		ix = s1.LastIndexOf(" ");
		// set s4 to the substring starting one space after ix,
		// thus the substring "two"
		string s4 = s1.Substring(ix + 1);
		// reset s1 to the substring starting at 0 and ending at ix,
		// thus "one"
		s1 = s1.Substring(0, ix);
		// set ix to the last space, but there is none so ix now = -1
		ix = s1.LastIndexOf(" ");
		// set s5 to the substring at one past the last space.
		// there was no last space
		// so this sets s5 to the substring starting at zero
		string s5 = s1.Substring(ix + 1);
		Console.WriteLine("s4: {0}\ns5: {1}\n", s4, s5);
		Console.WriteLine("s1: {0}\n", s1);
	}
}
