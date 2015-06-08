using UnityEngine;
using System.Collections;

public class button320 : MonoBehaviour {

	
	GameObject obj319;
	GameObject obj320;
	// Use this for initialization
	void Start () {
		
		obj319=  GameObject.Find ("319");
		obj320 = GameObject.Find ("320");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick ()
	{	if (shuzi.num==19) {
			obj319.SetActive (false);
			obj320.GetComponent<Animator> ().enabled = true;
			Destroy (this.transform.gameObject);
			shuzi.num++;		
		}
	}
}
