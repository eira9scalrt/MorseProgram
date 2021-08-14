using System;
using System.Collections.Generic;

class Program{
	public static void Main(){
		Basis basis = new Basis();

		while(true){
			var str = Console.ReadLine();

			if( string.Compare(str ,"exit") == 0 ){
				break;
			}
			
			foreach(char c in str){        // "ABC" => 'A' 'B' 'C' 
				basis.Show(c.ToString());  // 'A'.ToString => "A"
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

	public void Show(string key){
		if(m_data.ContainsKey(key)){
			Console.WriteLine(m_data[key]);
		}
		else{
			Console.WriteLine("エラー：存在しないKeyです");
		}
	}
}