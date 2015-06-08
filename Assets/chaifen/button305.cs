using UnityEngine;
using System.Collections;

public class button305 : MonoBehaviour {
	GameObject obj304;

	GameObject obj305;
	// Use this for initialization
	void Start () {

		obj304=  GameObject.Find ("304");
		obj305 = GameObject.Find ("305");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick ()
	{	if (shuzi.num==4) {
						GameObject.Find ("gameobject").GetComponent<daomoveg> ().enabled = false;
						obj304.SetActive (false);
						obj305.GetComponent<Animator> ().enabled = true;
		
						Destroy (this.transform.gameObject);
			shuzi.num++;		
		}
	}
}
