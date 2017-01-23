using UnityEngine;
using System.Collections;

public class VehicleFactory : MonoBehaviour {

	void Start() {
		Vehicle myVehicle = new Honda();

		myVehicle.SoundHorn();
		myVehicle.Drive();

		Honda myHonda = (Honda)myVehicle;
		myHonda.SoundHorn();
		myHonda.Drive();
	}
}
