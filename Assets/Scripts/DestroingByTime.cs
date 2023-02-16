using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroingByTime : MonoBehaviour
{
	public float LivingTime;
    void Update()
    {
       if (LivingTime < 0){
		   Destroy (gameObject);
	   } 
	   LivingTime -= Time.deltaTime;
    }
}
