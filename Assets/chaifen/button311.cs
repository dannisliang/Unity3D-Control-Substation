using UnityEngine;
using System.Collections;

public class button311 : MonoBehaviour {

	GameObject obj310;
	GameObject obj311;
	// Use this for initialization
	void Start () {
		
		obj310=  GameObject.Find ("310");
		obj311 = GameObject.Find ("311");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick ()
	{	if (shuzi.num==10) {
			obj310.SetActive (false);
			obj311.GetComponent<Animator> ().enabled = true;
			Destroy (this.transform.gameObject);
			shuzi.num++;		
		}
	}
}
