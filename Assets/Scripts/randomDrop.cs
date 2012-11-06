using UnityEngine;
using System.Collections;

public class randomDrop : MonoBehaviour {
	float timer;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		timer +=  Time.deltaTime * 1;
		Debug.Log (timer);
		if(timer > 10)
		{
			GameObject Sphere = GameObject.CreatePrimitive(PrimitiveType.Cube);
			float y = (float)44.01806;
			float randomX = Random.Range((float)0.0, (float)8.0);
			float randomZ = Random.Range((float)0.0, (float)7.0);
			Sphere.transform.position = new Vector3(randomX, randomZ, y);
			timer = 0;
		}
	}
	
	
}
