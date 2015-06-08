using UnityEngine;
using System.Collections;

public class button313 : MonoBehaviour {
	GameObject obj312;
	GameObject obj313;
	// Use this for initialization
	void Start () {
		
		obj312=  GameObject.Find ("312");
		obj313 = GameObject.Find ("313");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick ()
	{	if (shuzi.num==12) {
			obj312.SetActive (false);
			GameObject.Find("GameObject").GetComponent<zuo180>().enabled=true;

			obj313.GetComponent<Animator> ().enabled = true;
			Destroy (this.transform.gameObject);
			shuzi.num++;		
		}
	}
}
