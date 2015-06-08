using UnityEngine;
using System.Collections;

public class button314 : MonoBehaviour {
	GameObject obj313;
	GameObject obj314;
	// Use this for initialization
	void Start () {
		
		obj313=  GameObject.Find ("313");
		obj314 = GameObject.Find ("314");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick ()
	{	if (shuzi.num==13&&zuo180.w==0) {
			obj313.SetActive (false);
			zidongcamera.w=-8;
			zidongcamera.x=0.25f;
			GameObject.Find("GameObject").GetComponent<zuo180>().enabled=false;
			zuo180.w=180;
			obj314.GetComponent<Animator> ().enabled = true;
			Destroy (this.transform.gameObject);
			shuzi.num++;		
		}
	}
}
