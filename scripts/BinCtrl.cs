using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Binctrl : MonoBehaviour {

	public float speed = 7;
	public event System.Action OnPlayerDeath;
	public Text countText;
	//private int count;
	float screenHalfWidthInWorldUnits;

	
	void Start () {
		//count = 0;
		//SetCountText();
		float halfPlayerWidth = transform.localScale.x / 2f;
		screenHalfWidthInWorldUnits = Camera.main.aspect * Camera.main.orthographicSize + halfPlayerWidth;
	
	}
	

	void Update () {

		float inputX = Input.GetAxisRaw ("Horizontal");
		float velocity = inputX * speed;
		transform.Translate (Vector2.right * velocity * Time.deltaTime);

		if (transform.position.x < -screenHalfWidthInWorldUnits) {
			transform.position = new Vector2 (screenHalfWidthInWorldUnits, transform.position.y);
		}

		if (transform.position.x > screenHalfWidthInWorldUnits) {
			transform.position = new Vector2 (-screenHalfWidthInWorldUnits, transform.position.y);
		}

	}

	void OnTriggerEnter2D(Collider2D triggerCollider) {
		if (triggerCollider.tag == "banana") {
			if ( OnPlayerDeath != null) {
				OnPlayerDeath ();
			}
			Destroy (gameObject);
		}

		// if (triggerCollider.tag == "plasticbottle") {
		//	count = count + 1;
		//	SetCountText();
		//}
	}
	//void SetCountText() {
	//	countText.text = "Count: " + count.ToString ();
	//}
}
