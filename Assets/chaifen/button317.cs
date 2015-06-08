using UnityEngine;
using System.Collections;

public class button317 : MonoBehaviour {

	GameObject obj316;
	GameObject obj317;
	// Use this for initialization
	void Start () {
		
		obj316=  GameObject.Find ("316");
		obj317 = GameObject.Find ("317");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick ()
	{	if (shuzi.num==16) {
			obj316.SetActive (false);
			GameObject.Find("GameObject").GetComponent<youban>().enabled=true;
			obj317.GetComponent<Animator> ().enabled = true;
			Destroy (this.transform.gameObject);
			shuzi.num++;		
		}
	}
}
