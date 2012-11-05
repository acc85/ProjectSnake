using UnityEngine;
using System.Collections;

public class randomDrop : MonoBehaviour {
	
	public GameObject Sphere;
	// Use this for initialization
	void Start () {
		GameObject Sphere = GameObject.CreatePrimitive(PrimitiveType.Cube);
		float x = Random.value;
		float z = Random.value;
		Sphere.transform.position = new Vector3(2, 2, 0);
		
	}
	
	// Update is called once per frame
	void Update () {

	}
}
