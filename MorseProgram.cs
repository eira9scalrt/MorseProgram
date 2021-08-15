using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

class Program{
	private static string msg = ""; 
	private static string old = "";

	public static void Main(){	
		var task1 = Task.Run( () => Thread1("task1") );
		var task2 = Task.Run( () => ReadLine() );		
		task2.Wait();	
	}

	private static void Thread1(string str){
		Basis basis = new Basis();
		while(true){
			if(old != msg){	
				foreach(char c in msg){        // "ABC" => 'A' 'B' 'C' 
					basis.Show(c.ToString());  // 'A'.ToString => "A"
				}
			}

		}
	}
	private static void ReadLine(){
		while(true){
			old = msg;
			msg = Console.ReadLine();
			if(msg == "exit"){
				break;
			}
		}
	}
}



class Basis{
	private Dictionary<string,string> m_data;
	
	public Basis(){
		m_data = new Dictionary<string,string>();
		m_data.Add("A","・ー");	
		m_data.Add("B","ー・・・");
		m_data.Add("C","ー・ー・");
		m_data.Add("D","ー・・");
		m_data.Add("E","・");
		m_data.Add("F","・・ー・");
		m_data.Add("G","ーー・");
		m_data.Add("H","・・・・");	
		m_data.Add("I","・・");
		m_data.Add("J","・ーーー");
		m_data.Add("K","ー・ー");
		m_data.Add("L","・ー・・");
		m_data.Add("M","ーー");
		m_data.Add("N","ー・");
		m_data.Add("O","ーーー");
		m_data.Add("P","・ーー・");	
		m_data.Add("Q","ーー・ー");
		m_data.Add("R","・ー・");
		m_data.Add("S","・・・");
		m_data.Add("T","ー");
		m_data.Add("U","・・ー");
		m_data.Add("V","・・・ー");
		m_data.Add("W","・ーー");
		m_data.Add("X","ー・・ー");
		m_data.Add("Y","ー・ーー");
		m_data.Add("Z","ーー・・");		
	}

	public void Show(string kv){ 
		if(m_data.ContainsKey(kv)){
			Console.WriteLine(m_data[kv]);
		}
		else if(m_data.ContainsValue(kv){
			Console.WriteLine(m_data[kv]);
		}
		else{
			Console.WriteLine("エラー：存在しないKeyです");
		}
	}
}