using UnityEngine;
using System.Collections;

public class button304 : MonoBehaviour {

	GameObject obj303;
	GameObject obj304;
	// Use this for initialization
	void Start () {

		obj303=  GameObject.Find ("303");
		obj304 = GameObject.Find ("304");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick ()
	{	if (shuzi.num==3) {
						obj303.SetActive (false);
						obj304.GetComponent<Animator> ().enabled = true;
		
						Destroy (this.transform.gameObject);
			shuzi.num++;		
		
		}
	}
}
