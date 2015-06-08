using UnityEngine;
using System.Collections;

public class button316 : MonoBehaviour {
	GameObject obj315;
	GameObject obj316;
	// Use this for initialization
	void Start () {
		
		obj315=  GameObject.Find ("315");
		obj316 = GameObject.Find ("316");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick ()
	{	if (shuzi.num==15) {
			obj315.SetActive (false);
			obj316.GetComponent<Animator> ().enabled = true;
			Destroy (this.transform.gameObject);
			shuzi.num++;		
		}
	}
}
