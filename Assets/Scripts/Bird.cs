using UnityEngine;
using System.Collections;

public class Bird : Enemy {

	public float speed;
    public bool accelerate;
    public MovementState state = MovementState.Straight;

	// Use this for initialization
	void Start () {	

	}
	
	// Update is called once per frame
	void Update () {
        switch(state)
        {
            case MovementState.Straight: MoveStraight(); break;
            case MovementState.Curve: SinCurve(); break; 
        }
	}


    void MoveStraight()
    {
        this.transform.position += Vector3.right * Time.deltaTime * this.speed; 
    }

    void SinCurve()
    {
        this.transform.position += Vector3.right * Time.deltaTime * this.speed + new Vector3(0, Mathf.Sin(Time.time), 0.0f)*2* Time.deltaTime;
    }
}
