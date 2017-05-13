using HoloToolkit.Unity;
using HoloToolkit.Unity.InputModule;
using HoloToolkit.Unity.SpatialMapping;
using UnityEngine;

public class RabbitScript : MonoBehaviour, IFocusable
{
    private bool _dropped;

    public void OnFocusEnter()
    {
        if (!_dropped)
            return;
        gameObject.GetComponent<Animation>().Play();
    }

    public void OnFocusExit()
    {
        if (!_dropped)
            return;
        gameObject.GetComponent<Animation>().Stop();
    }
    public void OnDrop()
    {
        // Remove the RigidBody component from the rabbit
        var rabbit = GameObject.Find("Rabbit");

        Destroy(rabbit.GetComponent<FixedAngularSize>());
        Destroy(rabbit.GetComponent<BoxCollider>());
        Destroy(rabbit.GetComponent<Tagalong>());

        rabbit.AddComponent<Rigidbody>().freezeRotation = true;
        rabbit.GetComponent<AudioSource>().Play();

        SpatialMappingManager.Instance.DrawVisualMeshes = false;
        _dropped = true;
    }
}
