using UnityEngine;
using System.Collections;

public class Player {

	//member variables can be referred to as fields
	private int experience;

	//experience is a basic property
	public int Experience {
		get {
			//some other code
			return experience;
		}
		set {
			//some other code
			experience = value;
		}
	}

	//level is a property that converts experience
	//points into the level of a player automatically
	public int Level {
		get {
			return experience / 1000;
		}
		set {
			experience = value * 1000;
		}
	}

	//this is an example of an auto-implemented
	//property
	public int Health {
		get;
		set;
	}
}
