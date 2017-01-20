using UnityEngine;
using System.Collections;

public class SomeOtherGenericClass : MonoBehaviour {

	void Start() {
		SomeGenericClass myClass = new SomeGenericClass();
		myClass.GenericMethod<int>(5);
	}
}
