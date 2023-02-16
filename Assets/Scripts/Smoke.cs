using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smoke : MonoBehaviour
{
    public ParticleSystem SmokeEffect;

    private void Start()
    {
        SmokeEffect.startSize = 0;
    }
    private void OnCollisionEnter(Collision collision)
    {
            SmokeEffect.startSize = 10;
    }
}
