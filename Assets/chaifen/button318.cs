using UnityEngine;
using System.Collections;

public class button318 : MonoBehaviour {

	
	GameObject obj317;
	GameObject obj318;
	// Use this for initialization
	void Start () {
		
		obj317=  GameObject.Find ("317");
		obj318 = GameObject.Find ("318");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick ()
	{	if (shuzi.num==17&&youban.w==0) {
			obj317.SetActive (false);
			GameObject.Find("GameObject").GetComponent<youban>().enabled=false;
			youban.w=180;
			rotashang.w=70;
			GameObject.Find("GameObject").GetComponent<rotashang>().enabled=true;
			obj318.GetComponent<Animator> ().enabled = true;
			Destroy (this.transform.gameObject);
			shuzi.num++;		
		}
	}
}
