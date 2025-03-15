using UnityEngine;

public class ShipInputHandler : MonoBehaviour
{
    public float Throttle { get; private set; }
    public float Pitch { get; private set; }
    public float Roll { get; private set; }
    public float Yaw { get; private set; }
    public float VerticalThrust { get; private set; }
    public float HorizontalThrust { get; private set; }
    public bool Boost { get; private set; }
}
