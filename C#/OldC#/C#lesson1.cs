// The first component oriented language in the C/C++ family
// Everything really is an object
// Next generation robust adn durable software
// Preservation of investment

// C# is the first "component oriented" language in the C/C++ family
// Component concepts are first class: Properites, methods, events, Design time adn run-time attributes
// Integrated documentation using XML
// Enables one-stop programming No header files, IDL, etc. can be embedded in web pages.

// C++, Java: primitive types are "magic" and do not interoperate with objects
// Smalltalk, Lisp: Primitive types are objects, but at great performacne cost

// Garbage Collection: No memory leaks adn stray pointers
// Exceptions: Error handling is not an afterthought
// Type Safety: No uninitialized variables, unsafe casts
// Versioning: Pervasive versioning considerations in all aspects of language design

// C++ heritage: Namespaces, enums, unsigned types, pointers (in unsafe code), etc. No unnecessary sacrifices
// Interoperability...

/*using System;

class Hello{
	static void Main(){
		Console.WriteLine("Hello World");
	}
}

// Namespaces: Contain types adn other namespaces
// Type Declarations: Classes structs, interfaces, enums, and delegates
// Members: Constants, fields, methods, properties, indexers, events, operators, constructors, destructors
// Organization...

Using System;
namespace System.Collections{
	public class Stack{
		Entry top;
		public void Push(object data){
			top = new Entry(top, data);
		}
		public object Pop(){
			if( top == null) throw new InvalidOperationException();
			object result = top.data;
			top = top.next;
			return result;
		}
	}
}*/

// Primitives: int i;
// Enums: enum State {off, on}
// Structs: struct Point{int x, y;}
// classes: class Foo: Bar, IFoo{...}
// interfaces: interface IFoo: IBar{...}
// arrays: string[] a = new string[10];
// Delegates: delegate void Empty();

// Classes
// Single inheritance
// Multiple interface implementation
// Class Members: constants fields, methods, properties, indexers, events, 
// 

// Structs
// Liek classes, except: Stored in line, not heap allocated, assignment copies data, not reference, not inheritance
// Benefits: no heap allocation, less GC pressure, more efficient use of memory.

// Interfaces
// Multiple inheritance
// Can contain methods, properties, indexers, and events
// private interface implementation

// Delegates
// Object oriented function pointers
// Multiple receivers: each delegate has an invocation list, Thread safe + and - operations
// Foundation of events

// Everyhing is an object, All types ultimately inherit from object, any piece of datat can be stored, transported, and manipulated

// Boxing: Allocates box, copies value into it
// Unboxing: Checks type of box, copies value out

// Attributes
// How do you associate informatin with types and members?...
// Attributes can be attached to types and members.

// Statements and Expressions
// High C++ fidelity
// If, while, do require bool condition
// goto can't jump into blocks
// switch statement: no fall-though, "goto case" or "goto default"
// foreach statement
// checked and unchecked statements
// Expression statements must do work

// void Foo(){
	// i == 1; // error
// }