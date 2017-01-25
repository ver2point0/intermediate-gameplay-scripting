using UnityEngine;
using System.Collections;

public class OrcHumanoid : Humanoid {

	//this hides the enemy version
	new public void Yell() {
		Debug.Log("Orc version of the Yell() method.");
	}
}
