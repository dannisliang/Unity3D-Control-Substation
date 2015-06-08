using UnityEngine;
using System.Collections;

public class button1 : MonoBehaviour {
	GameObject obj101;
	// Use this for initialization
	void Start () {
		obj101=  GameObject.Find ("101");
		obj101.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnClick () {


		GameObject.Find("GameObject").GetComponent<youban>().enabled = false;
		youban.w = 180;
		rotayou.w = 90;
		rotazuo.w = 90;
		rotashang.w = 45;
		zuo180.w = 180;
		rotadown.w = 70;
		zidongcamera.w = 0;
		rotazuo.v=50;
		obj101.SetActive(true);
		GameObject.Find("GameObject").GetComponent<rotashang>().enabled = true;
		obj101.GetComponent<Animation> ().enabled = true;	
		obj101.GetComponent<AudioSource> ().enabled = true;
		yincang.fun ();
		kongzhijiao.kongnum++;
		Destroy(this.transform.gameObject);
	}
}
