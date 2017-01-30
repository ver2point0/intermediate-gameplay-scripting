using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BadGuyList : MonoBehaviour {

	void Start() {
		List<BadGuy> badGuys = new List<BadGuy>();

		badGuys.Add(new BadGuy("A", 10));
		badGuys.Add(new BadGuy("C", 50));
		badGuys.Add(new BadGuy("B", 100));

		badGuys.Sort();

		foreach(BadGuy guy in badGuys) {
			print(guy.name + " " + guy.power);
		}

		badGuys.Clear();
	}
}
