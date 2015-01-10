using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public int health;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Damage(int damage) {
		this.health -= damage;
		if (this.health <= 0) {
			this.Die();
		}
	}

	void Die() {

	}
}
