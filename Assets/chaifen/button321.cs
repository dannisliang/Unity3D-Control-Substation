using UnityEngine;
using System.Collections;

public class button321 : MonoBehaviour {

	
	GameObject obj320;
	GameObject obj321;
	// Use this for initialization
	void Start () {
		
		obj320=  GameObject.Find ("320");
		obj321 = GameObject.Find ("321");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick ()
	{	if (shuzi.num==20) {
			obj320.SetActive (false);
			obj321.GetComponent<Animator> ().enabled = true;
			Destroy (this.transform.gameObject);
			shuzi.num++;		
		}
	}
}
