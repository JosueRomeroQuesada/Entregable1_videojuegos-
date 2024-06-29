using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageController : MonoBehaviour
{
    [SerializeField]
    string target;

    [SerializeField]
    float damege;

    [SerializeField]
    bool selfDestruct;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag(target)) 
        {
            if (selfDestruct) 
            {
                Destroy(gameObject);
            }
        }
    }
}
