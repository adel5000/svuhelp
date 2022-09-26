using System;

namespace LogicalOperators
{
	class LogicalOperators
	{
		static void Main(string[] args)
		{
			// testing the conditional AND operator (&&)
			Console.WriteLine("Conditional AND (&&)" + "\nfalse && false: " + (false && false) + "\nfalse && true: " + (false && true) + "\ntrue && false: " + (true && false) + "\ntrue && true: " + (true && true));
			// testing the conditional OR operator (||)
			Console.WriteLine("\n\nConditional OR (||)" + "\nfalse || false: " + (false || false) + "\nfalse || true: " + (false || true) + "\ntrue || false: " + (true || false) + "\ntrue || true: " + (true || true));
			// testing the logical AND operator (&)
			Console.WriteLine("\n\nLogical AND (&)" + "\nfalse & false: " + (false & false) + "\nfalse & true: " + (false & true) + "\ntrue & false: " + (true & false) + "\ntrue & true: " + (true & true));
			// testing the logical OR operator (|)
			Console.WriteLine("\n\nLogical OR (|)" + "\nfalse | false: " + (false | false) + "\nfalse | true: " + (false | true) + "\ntrue | false: " + (true | false) + "\ntrue | true: " + (true | true));
			// testing the logical exclusive OR operator (^)
			Console.WriteLine("\n\nLogical exclusive OR (^)" + "\nfalse ^ false: " + (false ^ false) + "\nfalse ^ true: " + (false ^ true) + "\ntrue ^ false: " + (true ^ false) + "\ntrue ^ true: " + (true ^ true));
			// testing the logical NOT operator (!)
			Console.WriteLine("\n\nLogical NOT (!)" + "\n!false: " + (!false) + "\n!true: " + (!true));
		}
	}
}
