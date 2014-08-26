using UnityEngine;
using System.Collections;

public class Backgroundoffset : MonoBehaviour {
	public float speed = 0;
	public static Backgroundoffset current;
	
	float pos = 0;
	
	/*void Start () 
	{
		current = this;
	}*/
	
	void Update () 
	{
		pos += speed * Time.deltaTime;
		if(pos > 1.0f)
			pos = 0f;

		renderer.material.mainTextureOffset = new Vector2 (pos, 0);
	}
}
