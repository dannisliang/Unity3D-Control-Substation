using UnityEngine;
using System.Collections;

public class button309 : MonoBehaviour {

	GameObject obj308;
	GameObject obj309;
	// Use this for initialization
	void Start () {
		
		obj308=  GameObject.Find ("308");
		obj309 = GameObject.Find ("309");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick ()
	{	if (shuzi.num==8) {
			obj308.SetActive (false);
			GameObject.Find("GameObject").GetComponent<daomovec>().enabled=false;
			obj309.GetComponent<Animator> ().enabled = true;
			Destroy (this.transform.gameObject);
			shuzi.num++;		
		}
	}
}
