using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHouse : MonoBehaviour
{
	public GameObject[] objects;
	public int timer = 150;
	
	int spawnTimeRemaining; 
    // Start is called before the first frame update
    void Start()
    {
        /*for (int i =0; i<objects.Length; i++){
			objects[i].GetComponent<Rigidbody>().isKinematic = true;
		}*/
	spawnTimeRemaining = timer;
		
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		
		if (objects.Length == 1){
			if (spawnTimeRemaining == 0)
			{		
					InstantiateHouse();
					spawnTimeRemaining = timer;
			}
		}
		else if (spawnTimeRemaining == 0)
			{		
					InstantiateHouses();
					spawnTimeRemaining = timer;
			}
		spawnTimeRemaining -= 1;
    }
	
	
	
	void InstantiateHouse()
	{
		Instantiate(objects[0], objects[0].transform.position, objects[0].transform.rotation);
	}
	
	void InstantiateHouses()
	{
		int rand = Random.Range(0,objects.Length) ;
		Instantiate(objects[rand], objects[rand].transform.position, objects[rand].transform.rotation);
	}
}
