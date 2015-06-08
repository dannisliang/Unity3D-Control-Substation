using UnityEngine;
using System.Collections;

public class button307 : MonoBehaviour {

	GameObject obj306;
	GameObject obj307;
	// Use this for initialization
	void Start () {
		
		obj306=  GameObject.Find ("306");
		obj307 = GameObject.Find ("307");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick ()
	{	if (shuzi.num==6) {
			obj306.SetActive (false);
			zidongcamera.w=-10;
			zidongcamera.x=0.5f;
			GameObject.Find ("gameobject").GetComponent<daomoveG1> ().enabled = false;
			GameObject.Find("GameObject").GetComponent<daomovec>().enabled=true;
			obj306.GetComponent<Animator> ().enabled = true;
			Destroy (this.transform.gameObject);
			shuzi.num++;		
		}
	}
}
