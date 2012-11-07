using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class randomDrop : MonoBehaviour {
	float timer;
	float randomOccurance;
	
	public static List<GameObject> cubeObjects;
	// Use this for initialization
	void Start () {
		cubeObjects =  new List<GameObject>();
		randomOccurance = Random.Range (1,10);
	}
	
	// Update is called once per frame
	void Update () {
		timer +=  Time.deltaTime * 1;
		if(timer > randomOccurance)
		{
			GameObject Cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
			Cube.transform.renderer.material.color = Color.blue;
			float z = (float)0;
			float randomX = Random.Range((float)-10.0, (float)10.0);
			float randomY = Random.Range((float)-10.0, (float)10.0);
			Cube.transform.position = new Vector3(randomX, randomY, z);
			timer = 0;
			randomOccurance = Random.Range (1,10);
			cubeObjects.Add(Cube);
			//globalCubeObjects = cubeObjects;
			
//			Debug.Log (cubeObjects.Count);
		}
	}
	
	
}
