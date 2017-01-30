﻿using UnityEngine;
using System.Collections;
using System; // allows IComparable interface

public class BadGuy : IComparable<BadGuy> {

	public string name;
	public int power;

	public BadGuy(string newName, int newPower) {
		name = newName;
		power = newPower;
	}

	public int CompareTo(BadGuy other) {
		if(other == null) {
			return 1;
		} 
		return power - other.power;
	}
}
