using UnityEngine;
using System.Collections;

public class button13 : MonoBehaviour {

	GameObject obj101;
	GameObject obj102;
	GameObject obj103;
	GameObject obj104;
	GameObject obj105;
	GameObject obj106;
	GameObject obj107;
	GameObject obj108;
	GameObject obj109;
	GameObject obj110;
	GameObject obj111;
	GameObject obj112;
	GameObject obj113;
	// Use this for initialization
	void Start () {
		obj113=  GameObject.Find ("113");
		obj113.SetActive (false);


	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick () {
		obj101=GameObject.Find("101");
		obj102=GameObject.Find("102");
		obj103=GameObject.Find("103");
		obj104=GameObject.Find("104");
		obj105=GameObject.Find("105");
		obj106=GameObject.Find("106");
		obj107=GameObject.Find("107");
		obj108=GameObject.Find("108");
		obj109=GameObject.Find("109");
		obj110=GameObject.Find("110");
		obj111=GameObject.Find("111");
		obj112=GameObject.Find("112");
		if (obj112) {
			if (!obj112.animation.isPlaying) {
				obj101.SetActive (false);
				obj102.SetActive (false);
				obj103.SetActive (false);
				obj104.SetActive (false);
				obj105.SetActive (false);
				obj106.SetActive (false);
				obj107.SetActive (false);
				obj108.SetActive (false);
				obj109.SetActive (false);
				obj110.SetActive (false);
				obj111.SetActive (false);
				obj112.SetActive (false);

				GameObject.Find("GameObject").GetComponent<zuo180>().enabled = true;
				obj113.SetActive (true);
				obj113.GetComponent<Animation> ().enabled = true;
				obj113.GetComponent<AudioSource> ().enabled = true;
				GameObject.Find("GameObject").GetComponent<rotayou>().enabled=false;
				yincang.fun();
				yincang.funny();
				Destroy (this.transform.gameObject);
			} else {
				yincang.funny2();
			}
		}
		else {
			yincang.fun2();
			yincang.Add();
		}
		
	}
}
