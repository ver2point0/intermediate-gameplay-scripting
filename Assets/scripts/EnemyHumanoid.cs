using UnityEngine;
using System.Collections;

public class EnemyHumanoid : Humanoid {

	// this hides the humanoid version
	new public void Yell() {
		Debug.Log("Enemy version of the Yell() method.");
	}

}
