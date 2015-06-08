using UnityEngine;
using System.Collections;

public class button308 : MonoBehaviour {

	
	GameObject obj307;
	GameObject obj308;
	// Use this for initialization
	void Start () {
		
		obj307=  GameObject.Find ("307");
		obj308 = GameObject.Find ("308");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick ()
	{	if (shuzi.num==7) {
			obj307.SetActive (false);
	
			obj308.GetComponent<Animator> ().enabled = true;
			Destroy (this.transform.gameObject);
			shuzi.num++;		
		}
	}
}
