using UnityEngine;
using System.Collections;

public class button302 : MonoBehaviour {
	GameObject obj301;
	GameObject obj302;
	// Use this for initialization
	void Start () {
		obj301=  GameObject.Find ("301");
		obj302 = GameObject.Find ("302");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick ()
	{	if (shuzi.num == 1) {
						obj301.SetActive (false);
						GameObject.Find ("GameObject").GetComponent<youban> ().enabled = true;
						obj302.GetComponent<Animator> ().enabled = true;
			zidongcamera.w=6;
			zidongcamera.x=0.25f;
						Destroy (this.transform.gameObject);
			shuzi.num++;		
		}
		}
}
