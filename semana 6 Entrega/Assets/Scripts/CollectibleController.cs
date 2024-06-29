using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleController : MonoBehaviour
{
    [SerializeField]
    CollectibleType collecttibleType;

    [SerializeField]
    float value;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            CollectorController controller =other.GetComponent<CollectorController>();
            controller.Increase(collecttibleType, value);
            Destroy(gameObject);
        }
    }
}
