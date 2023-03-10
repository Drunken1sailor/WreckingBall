using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCreator : MonoBehaviour
{
	public GameObject bullet;
	public float bulletSpeed = 20f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
			GameObject newBullet = Instantiate (bullet, transform.position, transform.rotation);
			newBullet.GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed;
		} 
    }
	
}
