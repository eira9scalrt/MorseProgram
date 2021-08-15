using System.Collections.Generic;
using System;

class TestProgram{
	public static void Main(){
		var dic = new Dictionary<int,int>();
		dic.Add(1,1001);
		dic.Add(2,1002);
		dic.Add(3,1003);
		dic.Add(4,1004);
		dic.Add(5,1005);
		
		Console.WriteLine(dic);
	}
}