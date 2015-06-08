using UnityEngine;
using System.Collections;

public class button2 : MonoBehaviour {
	GameObject obj101;
	GameObject obj102;
	// Use this for initialization
	void Start () {
		obj102=  GameObject.Find ("102");
		obj102.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	

		}

	void OnClick () {
	
				obj101 = GameObject.Find ("101");
				if (obj101) {
						if (!obj101.animation.isPlaying) {

				GameObject.Find("GameObject").GetComponent<rotashang>().enabled = false;
				rotashang.w=45;
					obj102.SetActive (true);
								obj102.GetComponent<Animation> ().enabled = true;
				obj102.GetComponent<AudioSource> ().enabled = true;
				yincang.fun();
				yincang.funny();

								Destroy (this.transform.gameObject);
						} else {
				yincang.funny2();
						}
				}
				else {
			yincang.fun2();
			yincang.Add();
				}

	}
}
