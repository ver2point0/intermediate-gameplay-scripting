using UnityEngine;
using System.Collections;

public class Vegetable {
	
	public Vegetable() {
		Debug.Log("1st veggie constructor called");
	}

	// these methods are virtual and thus can be overriden
	// in child classes
	public virtual void Chop() {
		Debug.Log("the veggie has been chopped.");
	}

	public virtual void SayHello() {
		Debug.Log("Hello, I am a veggie.");
	}
}
