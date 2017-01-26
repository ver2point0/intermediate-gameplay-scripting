using UnityEngine;
using System.Collections;

public class MixedVegetable : MonoBehaviour {

	void Start() {
		Broccoli broc = new Broccoli();

		broc.SayHello();
		broc.Chop();

		Vegetable veggie = new Broccoli();
		veggie.SayHello();
		veggie.Chop();
	}
}
