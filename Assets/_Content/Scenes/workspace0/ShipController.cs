using UnityEngine;

public class ShipController : MonoBehaviour
{
    // Ship-Specs
    public float ForwardThrust = 1000f;
    public float BackwardThrust = 500f;
    public float PitchManeuverability = 100f;
    public float RollManeuverability = 100f;
    public float YawManeuverability = 50f;

    // Ship-programmed Limits
    public float TopSpeed = 221f;
    public float AltThrustSpeedMultiplier = 0.5f;
    public float BoostMultiplier = 1.5f;

    // References
    private Rigidbody _rb;
    private ShipInputHandler _inputHandler;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _inputHandler = GetComponent<ShipInputHandler>();
    }
}
