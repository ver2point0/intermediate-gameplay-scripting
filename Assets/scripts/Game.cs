﻿using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {

	void Start() {
		Player myPlayer = new Player();

		//properties can be used just like variables
		myPlayer.Experience = 5;
		int x = myPlayer.Experience;
	}
}
