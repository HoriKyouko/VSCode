// Everything in C# inherits from object Complaint: too slow, Java reasoning: no need to waste space
// integer types: signed: sbyte, int, short, long. unsigned: byte, uint, ushort, ulong
// floating point: float, double

// string type: string can index like char array, has method Split
// Example
/*string s = "hello";
char third = s[2];
string[] split = s.Split(third);

// Default values only for instance variables...

// Normal objects (as in java), inherit from object, refer to a memory location, can be set to null, very much like pointers in other languages
public void foo(){
	A a = new A();
	A b = a;
}

// Contain the actual value, not the location
// Inherit from System.valueType, treated specially by the runtime: no subclassing, not objects in normal case, but cna become objects on demand.
public void Bar(){
	int a = 137
	int b = a;
}

// Value types not objects, performance gain in common case, sometimes need to become objects, called "boxing". Revers is "unboxing"
public void foo2(){
	int a = 137;
	object o1 = a;
	object o2 = o1;
	int b = (int)o2;
}

// All integer adn floating point types, Strings, Anything that wouldn't be an object in Java, Structs: user-defined value types, can contain
// arbitray data, Examples: Point, TwoDPoint, inheritance
// All classes ar subtypes of Object single inheritance in class hierarchy, implement arbitrarily many interfaces: same idea for interfaces
// as in Java: access paterns, note interface naming: IAmAnInterface.

// Can have standard C arrays: int [] array = nw int[30];
// int[,] array = new int[2,10];
// int[][] array = new int [2][];
//	array[0] = new int[100];
//	array[1] - new int[1];
// Called  "jagged" arrays, stored in random parts of the heap, stored in row major order
// Can have arbitrary dimensions
// Recall that an array is an object.

// Multidimensional arrays stored equally, not specified what order, JIT copmutes the offset code...

// Can implement arbitrary storage order with a neat property trick: indexers
public int this(int a, int b){
	get{
		//do calculation to find the true location of (a,b)
		return mat[f(a,b)]
	}
}

// recall normal access patterns
protected int x;
public int setX();
public void setX(int newVal);
// evaluated into the language:
protected int x;
public int X{
	get{
		return x
	}
	set{
		x = value;
	}
}
A a = new A();
a.X = 15;

// Can have three types of properties: read-write, read-only, write-only.
// Why properties? Can be interface members...

// Allow bracket notation on any object
public string this[int a, double b]{...}
// Used, eg in hashtables: val = h[key], simplifies notation
// Related to C++ operator[] overloading
// Special property

// ref parameters: reference to a variable, can change the variable passed in
// Out parameters: value provided by callee.
// Note: reference types are passed by value: so can change underlying object, where might we have been able to use this?
// For variables number of parameters: public void f(int x, params char[] ar); call f(1), f(1,'s'),
// f(1, 's', 'f')...

// Iterators: Common code pattern: walk a data structure. want to abstract to a GetNext() walk
// iterator returns next element in walk can be done explicitly.

// C# way:
foreach(object key in h.Keys){
	object val = h[key];
	// do something with the key/value pair
}

// Can implement own iterable class: must implement IEnumerable.

// C# 2.0 Iterators: major change: yield return: compiler builds the inner class.
public IEnumerator getEnumerator(){
	for(int i = 0;)
}

List<int> lst = new List<int>();
static void populateList(){
	lst.add(1);
	lst.add(2);
	lst.add(3);
	lst.add(4);
	lst.add(5);
}
static void main(string[] args){
	populateList();
	foreach(int i in filter()){
		Console.WriteLine(i);
	}
}
static IEnumerator<int> filter(){
	foreach(int i in lst){
		if(i > 3){
			yield return i;
		}
	}
}
*/
// Sort method on many containers: provides efficient sorting, needs to be able to compare to objects.

// Enum like in C: give names to a family of values. eg. Color c = Red, can define enum Color{Red, Orange, Blue};
// As in C can give values to each...

// Old software engineering problem: what is the default value...

// Another software concern : how to separate generated...

// Generics Motivation: in summary four main goals: 1. Increase type safety(statically), 2. Elminate type casts. 3. Elminate...
// Write public class Stack<T>{...}
// T is the type variable
// Stack <int> myStack = new Stack<int>();

// Generics can be used with: Types: Structs, Interface, calss, Delegate, Method
// Can be used to easily create non-generic derived types:

// Can be used in internal fields, properties adn methods of a class: 

// Using the type is like using any other non-generic type.

// A new keyword where provides constraints on a type parameter.
// A base class or interface can be used as a constraint.
// For instance public interface IDrawable{public voidDraw();}

// Can also specify a class constraint. That is, require a reference type

// Alternateively, require a value (struct) type. Fixes the new problem (but is limited):