using UnityEngine;
using System.Collections;

public class Vehicle {

	public Vehicle() {
		Debug.Log("1st Vehicle constructor called.");
	}

	public void Drive() {
		Debug.Log("The vehicle has been driven.");
	}

	public void SoundHorn() {
		Debug.Log("BEEP! BEEP!");
	}
}
