using UnityEngine;
using System.Collections;

public class button306 : MonoBehaviour {
	GameObject obj305;
	GameObject obj306;
	// Use this for initialization
	void Start () {

		obj305=  GameObject.Find ("305");
		obj306 = GameObject.Find ("306");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick ()
	{	if (shuzi.num==5) {
						obj305.SetActive (false);
						GameObject.Find ("gameobject").GetComponent<daomoveG1> ().enabled = true;
						obj306.GetComponent<Animator> ().enabled = true;
						Destroy (this.transform.gameObject);
			shuzi.num++;		
		}
	}
}
