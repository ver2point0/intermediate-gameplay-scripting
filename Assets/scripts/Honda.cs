using UnityEngine;
using System.Collections;

public class Honda : Vehicle {

	public Honda() {
		Debug.Log("1st Honda constructor called.");
	}
	
	public new void Drive() {
		Debug.Log("The Honda has been driven.");
	}
	
	public new void SoundHorn() {
		Debug.Log("BEEPITY! BEEPITY!");
	}
}
