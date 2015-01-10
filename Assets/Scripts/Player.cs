using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public Texture2D target;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI() {
		Vector2 targetSize = new Vector2(20, 20);
		GUI.DrawTexture(new Rect(Input.mousePosition.x + targetSize.y / 2, Input.mousePosition.y - targetSize.y / 2, targetSize.x, targetSize.y), this.target);
	}
}
