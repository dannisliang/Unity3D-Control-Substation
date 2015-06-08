using UnityEngine;
using System.Collections;

public class button315 : MonoBehaviour {
	GameObject obj314;
	GameObject obj315;
	// Use this for initialization
	void Start () {
		
		obj314=  GameObject.Find ("314");
		obj315 = GameObject.Find ("315");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick ()
	{	if (shuzi.num==14) {
			obj314.SetActive (false);
			obj315.GetComponent<Animator> ().enabled = true;
			Destroy (this.transform.gameObject);
			shuzi.num++;		
		}
	}
}
