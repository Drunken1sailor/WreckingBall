using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanBeDestroyed : MonoBehaviour
{
    public Transform _destroyed;

    public void Dead()
    {
        Instantiate(_destroyed, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
