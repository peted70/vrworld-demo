using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class RabbitDance : MonoBehaviour, IFocusable
{
    public void OnFocusEnter()
    {
        gameObject.GetComponent<AudioSource>().Play();
    }
}
