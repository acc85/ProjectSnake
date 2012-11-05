using UnityEngine;
using System.Collections;

public class randomDrop : MonoBehaviour {
		int time;
	// Use this for initialization
	void Start () {
		time = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		time ++;
		if(time == 100)
		{
			GameObject Sphere = GameObject.CreatePrimitive(PrimitiveType.Cube);
	//		float x = (float)-9.776898;
	//		float z = (float)7.720881;
			float y = (float)44.01806;
			float randomX = Random.Range((float)0.0, (float)8.0);
			float randomZ = Random.Range((float)0.0, (float)7.0);
			Sphere.transform.position = new Vector3(randomX, randomZ, y);
			time = 0;
		}
	}
}
