using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{
    public InputActionProperty pinchAnimationAction;
    public InputActionProperty gripAnimationAction;
    public Animator handAnimator;

    // Start is called before the first frame update
    void Start()
    {
        bool var = true;
    }

    // Update is called once per frame
    void Update()
    {
        float triggerValue = pinchAnimationAction.action.ReadValue<float>();     // know the input of the trigger Activate Value
        handAnimator.SetFloat("Trigger", triggerValue);                          // animate the pinch

        float gripValue = gripAnimationAction.action.ReadValue<float>();     
        handAnimator.SetFloat("Grip", gripValue);                                // animate the grip
    }
}
