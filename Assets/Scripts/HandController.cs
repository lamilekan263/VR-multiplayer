using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Animator))]
public class HandController : MonoBehaviour
{
    public InputActionReference gripInputActionReference;
    public InputActionReference triggerInputActionReference;

    private Animator handAnimator;
    private float _gripValue;
    private float _triggerValue;


    void Update()
    {
        SendGripInputValueToAnimator();
        SendTriggerInputValueToAnimator();
    }
    void SendGripInputValueToAnimator()
    {
        _gripValue = gripInputActionReference.action.ReadValue<float>();
        handAnimator.SetFloat("Grip_Value", _gripValue);
    }

    void SendTriggerInputValueToAnimator()
    {
        _triggerValue = triggerInputActionReference.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger_value", _triggerValue);
    }
    public float GetTriggerValue()
    {
        return _triggerValue;
    }
    public float GetGripValue()
    {
        return _gripValue;
    }
}