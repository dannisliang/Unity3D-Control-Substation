using UnityEngine;
using System.Collections;

public class movecyou : MonoBehaviour {
	public static float  w=90;//期望角度
	float v = 80;
	public static float y=60;
	public Transform goTransfom;
	private float vel=0.1f;
	// Use this for initialization
	void Start () {
		
		goTransfom = this.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {



		if(y != 0){
			y -= Time.deltaTime * v;
			if(y > 0){
				this.gameObject.transform.Rotate(Vector3.down, Time.deltaTime * v, Space.World);//旋转吧少年！
			}else{
				this.gameObject.transform.Rotate(Vector3.down, y + Time.deltaTime * v, Space.World);//找回误差量
				y = 0;
				
			}
		}
		if(y==0&&goTransfom.transform.position.z>1)
			goTransfom.Translate (Vector3.back * vel);



		if(w != 0&&y==0&&goTransfom.transform.position.z<1){
			w -= Time.deltaTime * v;
			if(w > 0){
				this.gameObject.transform.Rotate(Vector3.right, Time.deltaTime * v, Space.World);//旋转吧少年！
			}else{
				this.gameObject.transform.Rotate(Vector3.right, w + Time.deltaTime * v, Space.World);//找回误差量
				w = 0;
				
			}
		}
		
	}
}
