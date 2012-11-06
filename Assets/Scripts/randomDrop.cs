using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class randomDrop : MonoBehaviour {
	float timer;
	
	public static List<GameObject> cubeObjects;
	public static List<GameObject> globalCubeObjects;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		timer +=  Time.deltaTime * 1;
		cubeObjects =  new List<GameObject>();
		if(timer > 5)
		{
			GameObject Cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
			Cube.transform.renderer.material.color = Color.blue;
			float y = (float)8.532489;
			float randomX = Random.Range((float)-44.0, (float)-15.0);
			float randomZ = Random.Range((float)20.0, (float)40.0);
			Cube.transform.position = new Vector3(randomX, y, randomZ);
			timer = 0;
			cubeObjects.Add(Cube);
			//globalCubeObjects = cubeObjects;
			
//			Debug.Log (cubeObjects.Count);
		}
	}
	
	
}
