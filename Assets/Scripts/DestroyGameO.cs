using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameO : MonoBehaviour
{
	public GameObject objectNew;
	public GameObject objectOld;
	public int health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if(health <= 0){
			Score.incScore();
		}*/
		
    }
	
	void OnCollisionEnter (Collision col){
		
	}
	void OnTriggerEnter(Collider col){
		Score.scoreCounter += 1;
		if (col.CompareTag ("Destroy")) {
			health -= 1;
			objectNew.SetActive(true);
			objectOld.SetActive(false);
			}
	}
}
