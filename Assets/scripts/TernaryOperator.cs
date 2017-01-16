using UnityEngine;
using System.Collections;

public class TernaryOperator : MonoBehaviour {

	void Start() {
		int health = 10;
		string message;

		// this is an example ternary operation that chooses a message based on
		// the variable "health".
		message = health > 0 ? "Player is Alive" : "Player is Dead";
		Debug.Log(message);
	}
}
