using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour {

	public float speed;
    public MovementState state = MovementState.Straight;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position += Vector3.up * Time.deltaTime * this.speed;
	}
}
