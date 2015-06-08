using UnityEngine;
using System.Collections;

public class button322 : MonoBehaviour {

	
	GameObject obj321;
	GameObject obj322;
	// Use this for initialization
	void Start () {
		
		obj321=  GameObject.Find ("321");
		obj322 = GameObject.Find ("322");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick ()
	{	if (shuzi.num==21) {
			obj321.SetActive (false);
			rotadown.w=40;
			GameObject.Find("GameObject").GetComponent<rotadown>().enabled=true;

			obj322.GetComponent<Animator> ().enabled = true;
			Destroy (this.transform.gameObject);
			shuzi.num++;		
		}
	}
}
