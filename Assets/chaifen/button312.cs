using UnityEngine;
using System.Collections;

public class button312 : MonoBehaviour {
	GameObject obj311;
	GameObject obj312;
	// Use this for initialization
	void Start () {
		
		obj311=  GameObject.Find ("311");
		obj312 = GameObject.Find ("312");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick ()
	{	if (shuzi.num==11) {
			obj311.SetActive (false);
			obj312.GetComponent<Animator> ().enabled = true;
			Destroy (this.transform.gameObject);
			shuzi.num++;		
		}
	}
}
