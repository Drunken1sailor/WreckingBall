using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wholenessOfComponents : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().isKinematic = true;
    }

    void OnCollisionEnter(Collision collision)//проверяем на объект на коллизию
	{
		if(collision.collider.CompareTag ("Destroy")){
		    GetComponent<Rigidbody>().isKinematic = false;
		}
	}
}
