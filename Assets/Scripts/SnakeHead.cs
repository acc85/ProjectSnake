using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SnakeHead : MonoBehaviour {
	
	List<Vector3> targets;
	Vector3 currentTarget;
	int currentIndex;
	Vector3 currentPosition;
	float speed = 3.0f;
	GameObject currentObject;
	
	// Use this for initialization
	void Start () {
			
		currentPosition = transform.position;
		currentObject = new GameObject();
		targets = new List<Vector3>();
		targets.Add(new Vector3(currentPosition.x + 8.0f, currentPosition.y, currentPosition.z+ 8.0f));
		targets.Add(new Vector3(currentPosition.x - 8.0f, currentPosition.y, currentPosition.z+ 8.0f));
		targets.Add(new Vector3(currentPosition.x + 8.0f, currentPosition.y, currentPosition.z- 8.0f));
		targets.Add(new Vector3(currentPosition.x - 8.0f, currentPosition.y, currentPosition.z- 8.0f));
		
		currentIndex = 0;
		currentTarget = targets[currentIndex];
	
	}
	
	
	// Update is called once per frame
	void Update () {
		currentPosition = transform.position;

		if(randomDrop.cubeObjects.Count > 0)
		{ 
			foreach(GameObject a in randomDrop.cubeObjects)
			{
				currentTarget = a.transform.position;
				currentObject = a;
			}
			
		}

		if (Vector3.Distance(currentPosition, currentTarget) > 1) {
		
			Vector2 directionVector = new Vector2(currentTarget.x - currentPosition.x, currentTarget.z - currentPosition.z);
			
			float x = currentPosition.x + (directionVector.x * speed * Time.deltaTime);
			float z = currentPosition.z + (directionVector.y * speed * Time.deltaTime);
			
			Vector3 newPosition = new Vector3(x, currentPosition.y, z);
			
			transform.position = newPosition;
			

	
		}
		
		else 
		{
			DestroyObject(currentObject);
			if (currentIndex == (targets.Count - 1)) 
			{
				currentIndex = 0;
			} 
			else 
			{
				currentIndex++;
			}
			currentTarget = targets[currentIndex];	
		}
		
	}
}
