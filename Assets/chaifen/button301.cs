using UnityEngine;
using System.Collections;

public class button301 : MonoBehaviour {
	GameObject obj301;
	// Use this for initialization
	void Start () {
		shuzi.num = 0;
		obj301=  GameObject.Find ("301");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnClick ()
	{	if (shuzi.num == 0) {
						youban.w = 180;
						rotayou.w = 90;
						rotazuo.w = 90;
						rotashang.w = 90;
						zuo180.w = 180;
						rotadown.w = 90;
			zidongcamera.w=0;
						obj301.GetComponent<Animator> ().enabled = true;	
						Destroy (this.transform.gameObject);
			shuzi.num++;
		}
	}
}
