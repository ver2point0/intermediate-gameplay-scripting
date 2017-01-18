using UnityEngine;
using System.Collections;

public class PlayerStatic : MonoBehaviour {

	public static int playerCount = 0;
	void Start() {
		playerCount++;
	}
}
