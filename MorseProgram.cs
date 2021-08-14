using System;
using System.Collections.Generic;

class Program{
	public static void Main(){
		Basis basis = new Basis();
		basis.Show("A");
	}
}

class Basis{
	private Dictionary<string,string> m_data;
	public Basis(){
		m_data = new Dictionary<string,string>();
		m_data.Add("A","・ー");	
		m_data.Add("B","ー・・・");
		m_data.Add("C","ー・ー・");
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