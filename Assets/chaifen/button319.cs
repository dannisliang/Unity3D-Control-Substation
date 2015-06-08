using UnityEngine;
using System.Collections;

public class button319 : MonoBehaviour {

	GameObject obj318;
	GameObject obj319;
	// Use this for initialization
	void Start () {
		
		obj318=  GameObject.Find ("318");
		obj319 = GameObject.Find ("319");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick ()
	{	if (shuzi.num==18) {
			obj318.SetActive (false);
			obj319.GetComponent<Animator> ().enabled = true;
			Destroy (this.transform.gameObject);
			shuzi.num++;		
		}
	}
}
