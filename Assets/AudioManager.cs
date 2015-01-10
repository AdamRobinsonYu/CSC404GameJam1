using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {


    public AudioSource[] music;
	// Use this for initialization
	void Start () {
        music[0].Play();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
