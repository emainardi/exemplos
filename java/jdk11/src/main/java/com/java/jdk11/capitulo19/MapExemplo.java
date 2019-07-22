package com.java.jdk11.capitulo19;

import java.util.HashMap;
import java.util.Map;
import java.util.TreeMap;

public class MapExemplo {

	public static void main(String args[]) {
		treeMapExemplo();
	}
	
	public static void hashMapExemplo() {
		var map = new HashMap<Integer, String>();
		
		map.put(0, "Eduardo");
		map.put(1, "Maria");
		map.put(1, "Chave Duplicada"); // substitui quando encontra uma chave igual
		map.put(-1, "Carlos");
		
		map.entrySet().forEach( m -> System.out.println(String.format(" %d - %s", m.getKey(), m.getValue())));		
		
		System.out.println("------------------------------------");
		
		for(Map.Entry<Integer, String> item : map.entrySet()) {
			System.out.println(item.getKey());
			System.out.println(item.getValue());
		}
		
		System.out.println("------------------------------------");
	}
	
	/**
	 * Armazena os valores de forma ordenada (Comparetor)
	 */
	public static void treeMapExemplo() {		
		var treeMap = new TreeMap<String, String>();
		
		treeMap.put("1", "Eduardo");
		treeMap.put("10", "Eduardo");
		treeMap.put("0", "Eduardo");
		
		treeMap.entrySet().forEach(t -> System.out.println(String.format("%s - %s", t.getKey(), t.getValue())));
	}
	
}
