using UnityEngine;
using System.Collections;
using System.Collections.Generic; 

public class BadGuyDictionary : MonoBehaviour {

	void Start() {
		Dictionary<string, BadGuy> badGuys = new Dictionary<string, BadGuy>();

		BadGuy b1 = new BadGuy("X", 25);
		BadGuy b2 = new BadGuy("Y", 75);

		badGuys.Add("gangster", b1);
		badGuys.Add("mutant", b2);

		BadGuy x = badGuys["gangster"];
		BadGuy y = badGuys["mutant"];

		BadGuy temp = null;

		if(badGuys.TryGetValue("birds", out temp)) {
			print("Success!");
		} else {
			print("Failure!");
		}
	}
}
