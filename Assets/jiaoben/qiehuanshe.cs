using UnityEngine;
using System.Collections;

public class qiehuanshe : MonoBehaviour {
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
	GameObject obj114;
	GameObject obj115;
	GameObject obj116;
	GameObject obj117;
	GameObject obj118;
	GameObject obj119;
	GameObject obj120;
	GameObject obj121;
	GameObject obj122;
	GameObject obj123;
    GameObject ca1;
	GameObject ca2;
	GameObject p1;
	GameObject p2;
	GameObject p3;
	// Use this for initialization

	void Awake(){
	
		p1 = GameObject.Find ("gameobject");
		p2=GameObject.Find("object");
		p3=GameObject.Find("objr");


		obj101=  GameObject.Find ("101");
	obj102=  GameObject.Find ("102");
	obj103=  GameObject.Find ("103");
	obj104=  GameObject.Find ("104");
	obj105=  GameObject.Find ("105");
	obj106=  GameObject.Find ("106");
	obj107=  GameObject.Find ("107");
	obj108=  GameObject.Find ("108");
	obj109=  GameObject.Find ("109");
	obj110=  GameObject.Find ("110");
	obj111=  GameObject.Find ("111");
	obj112=  GameObject.Find ("112");
	obj113=  GameObject.Find ("113");
	obj114=  GameObject.Find ("114");
	obj115=  GameObject.Find ("115");
	obj116=  GameObject.Find ("116");
	obj117=  GameObject.Find ("117");
	obj118=  GameObject.Find ("118");
	obj119=  GameObject.Find ("119");
	obj120=  GameObject.Find ("120");
	obj121=  GameObject.Find ("121");
	obj122=  GameObject.Find ("122");
	obj123=  GameObject.Find ("123");
	
}

	void Start () {
	
		ca1 = GameObject.Find ("Camera");
		ca2 = GameObject.Find ("Camera1");

	}
	
	// Update is called once per frame
	void Update () {
		if (obj101.animation.isPlaying||obj102.animation.isPlaying||obj103.animation.isPlaying||obj104.animation.isPlaying||obj105.animation.isPlaying||obj106.animation.isPlaying||obj107.animation.isPlaying||obj108.animation.isPlaying||obj109.animation.isPlaying||obj110.animation.isPlaying||obj111.animation.isPlaying||obj112.animation.isPlaying||obj113.animation.isPlaying||obj114.animation.isPlaying||obj115.animation.isPlaying||obj116.animation.isPlaying||obj117.animation.isPlaying||obj118.animation.isPlaying||obj119.animation.isPlaying||obj120.animation.isPlaying||obj121.animation.isPlaying||obj122.animation.isPlaying||obj123.animation.isPlaying)
		{	//ca2.transform.position.Set(ca1.transform.position.x,ca1.transform.position.y,ca1.transform.position.z);
		//ca2.transform.
		//	ca2.transform.localPosition.Set(ca1.transform.localPosition.x,ca1.transform.localPosition.y,ca1.transform.localPosition.z);
			//ca2.transform.rotation.(ca1.transform.localPosition.x+p1.transform.localPosition
			//ca2.transform.rotation.Set(p1.transform.rotation.x+p2.transform.rotation.x+ca1.transform.rotation.x,p1.transform.rotation.y+p2.transform.rotation.y+ca1.transform.rotation.y,p1.transform.rotation.z+p2.transform.rotation.z+ca1.transform.rotation.z,p1.transform.rotation.w+p2.transform.rotation.w+ca1.transform.rotation.w);
			p3.transform.position=p1.transform.position;
			p2.transform.localRotation=p1.transform.rotation;
			ca2.camera.fieldOfView=ca1.camera.fieldOfView;
			ca1.SetActive(true);
			ca2.SetActive (false);

			//ca2.transform.rotation=ca2.transform.rotation;

		} else {
			ca1.SetActive (false);
			ca2.SetActive (true);
				}

	}
}
