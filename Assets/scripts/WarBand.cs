using UnityEngine;
using System.Collections;

public class WarBand : MonoBehaviour {

	void Start() {
		Humanoid human = new Humanoid();
		Humanoid enemy = new EnemyHumanoid();
		Humanoid orc = new OrcHumanoid();

		human.Yell();
		enemy.Yell();
		orc.Yell();
	}
}
