using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHouse : MonoBehaviour
{
	
	public GameObject[] objects;
	public float Speed = 5f;
	//public float timer = 20f;
    //private Rigidbody _rb;
	bool isDead = false;
	
	
    // Start is called before the first frame update
    void Start()
    {
		//GetComponent<Rigidbody>().isKinematic = true;//включаем у риджидбоди синематик дабы наш объект не разрушался раньше времени
			//_rb = GetComponent<Rigidbody>();
			
    }

	void OnCollisionEnter(Collision collision)//проверяем на объект на коллизию
	{
		    isDead = true;//делаем переменную положительной, чтобы скрипт смог понять что обьект уже "отработан", и его можно удалить
	}

	void FixedUpdate()
	{
		if(isDead == false) MovementLogic();
	}
	
	
	
	void MovementLogic()
	{

        Vector3 movement = new Vector3(-3f, 0.0f, 0.0f);

        // что бы скорость была стабильной в любом случае
        // и учитывая что мы вызываем из FixedUpdate мы умножаем на fixedDeltaTimе
        transform.Translate(movement * Speed * Time.fixedDeltaTime);
	}
	
	
    
}

