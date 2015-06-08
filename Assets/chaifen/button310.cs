using UnityEngine;
using System.Collections;

public class button310 : MonoBehaviour {

	GameObject obj309;
	GameObject obj310;
	// Use this for initialization
	void Start () {
		
		obj309=  GameObject.Find ("309");
		obj310 = GameObject.Find ("310");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick ()
	{	if (shuzi.num==9) {
			obj309.SetActive (false);
			obj310.GetComponent<Animator> ().enabled = true;
			Destroy (this.transform.gameObject);
			shuzi.num++;		
		}
	}
}
