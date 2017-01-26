using UnityEngine;
using System.Collections;

public class Broccoli : Vegetable {

	public Broccoli() {
		Debug.Log("1st broccoli constructor called.");
	}

	// these methods are overrides and therefore
	// can override any virtual mehods in the parent class
	public override void Chop() {
		base.Chop();
		Debug.Log("The broccoli has been chopped.");
	}

	public override void SayHello() {
		base.SayHello();
		Debug.Log("Hello, I am broccoli.");
	}
}
