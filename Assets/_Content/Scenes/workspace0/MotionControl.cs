using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics;

public class MotionControl : MonoBehaviour
{
    public Hand ControllerHand;

    public HapticImpulsePlayer HapticImpulsePlayer { get; private set; }
    public TrackedPoseDriver TrackedPoseDriver { get; private set; }

    private void Awake()
    {
        HapticImpulsePlayer = GetComponent<HapticImpulsePlayer>();
        TrackedPoseDriver = GetComponent<TrackedPoseDriver>();
    }

    public enum Hand
    {
        Left, Right
    }
}
