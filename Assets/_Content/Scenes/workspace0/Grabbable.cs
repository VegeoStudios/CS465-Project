using UnityEngine;

public class Grabbable : MonoBehaviour
{
    private Collider _trigger;

    private void Awake()
    {
        _trigger = transform.Find("GrabTrigger").GetComponent<Collider>();
    }

    public void OnGrab()
    {

    }
}
