﻿using UnityEngine;
using System.Collections;

public class zuoshzuo : MonoBehaviour {
	public static float  w=90;//期望角度
	float v = 80;
	public static float  y=90;
	public static float  z=90;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(y!= 0){
			y -= Time.deltaTime * v;
			if(y > 0){
				this.gameObject.transform.Rotate(Vector3.up, Time.deltaTime * v, Space.World);//旋转吧少年！
			}else{
				this.gameObject.transform.Rotate(Vector3.up, y + Time.deltaTime * v, Space.World);//找回误差量
				y = 0;
				
			}
		}
		
		if(w != 0&&y==0){
			w -= Time.deltaTime * v;
			if(w > 0){
				this.gameObject.transform.Rotate(Vector3.left, Time.deltaTime * v, Space.World);//旋转吧少年！
			}else{
				this.gameObject.transform.Rotate(Vector3.left, w + Time.deltaTime * v, Space.World);//找回误差量
				w = 0;
				
			}
		}

		if(z != 0&&y==0&&w==0){
			z -= Time.deltaTime * v;
			if(z > 0){
				this.gameObject.transform.Rotate(Vector3.up, Time.deltaTime * v, Space.World);//旋转吧少年！
			}else{
				this.gameObject.transform.Rotate(Vector3.up, z + Time.deltaTime * v, Space.World);//找回误差量
				z = 0;
				
			}
		}

		
		
		
	}
}
