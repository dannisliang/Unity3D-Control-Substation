using UnityEngine;
using System.Collections;

public class yincang : MonoBehaviour {
	static GameObject  objcuo;
	static GameObject objwei;
	 public static int count;
	// Use this for initialization
	 void Start () {
		count = 0;
		objcuo = GameObject.Find ("cuowu_texture");
		objwei =GameObject.Find("weiwancheng_texture");
		objcuo.SetActive (false);
		objwei.SetActive (false);
	}


	public static void Add()
	{count++;
		}
	public static void  fun(){
		objcuo.SetActive (false);
	}
	public static void fun2(){
		objcuo.SetActive (true);
		}
	public static void funny()
	{
		objwei.SetActive (false);
		}

	public static void funny2()
	{objwei.SetActive (true);

		}


	// Update is called once per frame
	void Update () {
	
	}
}
