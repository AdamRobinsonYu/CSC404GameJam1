using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public Texture2D crosshair;
    public GameObject impact;
    static int score = 0;
    public UILabel scoreUI;
	void Start () {
        scoreUI.text = score.ToString();
	}
	
	// Update is called once per frame
    void Update()
    {
        scoreUI.text = score.ToString();
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {

              
                if (hit.collider.GetComponent<Enemy>())
                {
                    GameObject go = hit.collider.gameObject;

                    GameObject newEffect = (GameObject)Instantiate(impact);
                    newEffect.transform.position = go.transform.position + Vector3.up * 0.2f;

                    GameObject.Destroy(hit.collider.gameObject, 0.1f);

                    if (hit.collider.GetComponent<Enemy>())
                    {
                        hit.collider.GetComponent<Enemy>().Damage(1);
                        score++;

                    }
                }
            }
        }
    }
       
	void OnGUI() {
		Vector2 targetSize = new Vector2(20, 20);
		GUI.DrawTexture(new Rect(Input.mousePosition.x - targetSize.x / 2, Screen.height - Input.mousePosition.y - targetSize.y / 2, targetSize.x, targetSize.y), this.crosshair);
	}
}
