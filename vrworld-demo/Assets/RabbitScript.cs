using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitScript : MonoBehaviour
{
    public void OnDrop()
    {
        // Remove the RigidBody component from the rabbit
        var rabbit = GameObject.Find("Rabbit");
        var rb = rabbit.GetComponent<Rigidbody>();
        if (rb != null)
            Destroy(rb);

        rabbit.GetComponent<AudioSource>().Play();
        rabbit.AddComponent<RabbitDance>();
    }

    public void OnMove()
    {
        var rabbit = GameObject.Find("Rabbit");
        
        var randomAngle = Random.Range(-45, 45);
        gameObject.transform.localRotation =
            Quaternion.Euler(0, randomAngle, 0);
    }
}
