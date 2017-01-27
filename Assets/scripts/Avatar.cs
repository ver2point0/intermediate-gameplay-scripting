using UnityEngine;
using System.Collections;

public class Avatar : MonoBehaviour, IKillable, IDamageable<float> {

	// the required method of the IKillable interface
	public void Kill() {
		Debug.Log("You're killing the enemy!");
	}

	//the required method of the IDamageable interface
	public void Damage(float damageTaken) {
		damageTaken = 25.0f;
		Debug.Log("The enemy took " + damageTaken + " damage.");
	}

}
