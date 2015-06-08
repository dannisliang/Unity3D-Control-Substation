using UnityEngine;
using System.Collections;

public class button323 : MonoBehaviour {

	GameObject obj322;
	GameObject obj323;
	// Use this for initialization
	void Start () {
		
		obj322=  GameObject.Find ("322");
		obj323 = GameObject.Find ("323");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick ()
	{	if (shuzi.num==22&&rotadown.w==0) {
			obj322.SetActive (false);
			GameObject.Find("GameObject").GetComponent<rotadown>().enabled=false;
			obj323.GetComponent<Animator> ().enabled = true;
			Destroy (this.transform.gameObject);
			shuzi.num++;		
		}
	}
}
