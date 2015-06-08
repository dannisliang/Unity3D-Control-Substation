using UnityEngine;
using System.Collections;

public class button303 : MonoBehaviour {

	GameObject obj302;
	GameObject obj303;

	// Use this for initialization
	void Start () {
		obj302=  GameObject.Find ("302");
		obj303 = GameObject.Find ("303");
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick ()
	{	if (shuzi.num==2&&youban.w==0) {
						obj302.SetActive (false);

			zidongcamera.w=15;
			zidongcamera.x=0.5f;
						GameObject.Find ("GameObject").GetComponent<youban> ().enabled = false;
						youban.w = 180;
						GameObject.Find ("gameobject").GetComponent<daomoveg> ().enabled = true;
						obj303.GetComponent<Animator> ().enabled = true;
						Destroy (this.transform.gameObject);
				
			shuzi.num++;
		}
	}
}
