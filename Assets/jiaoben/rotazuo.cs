using UnityEngine;
using System.Collections;

public class rotazuo : MonoBehaviour {
	public static float  w=90;//期望角度
	public static float v = 50;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
				if(w != 0){
					w -= Time.deltaTime * v;
					if(w > 0){
						this.gameObject.transform.Rotate(Vector3.up, Time.deltaTime * v, Space.World);//旋转吧少年！
					}else{
						this.gameObject.transform.Rotate(Vector3.up, w + Time.deltaTime * v, Space.World);//找回误差量
						w = 0;

	}
}
	}
}