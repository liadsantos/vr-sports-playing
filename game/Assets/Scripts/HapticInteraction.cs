using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

/*[System.Serializable]
public class Haptic 
{
    [Range(0,1)]
    public float intensity;
    public float duration;

    public void TriggerHaptic(BaseInteractionEventArgs eventArgs)
    {
        if (eventArgs.interactorObject is XRBaseControllerInteractor controllerInteractor) {
            TriggerHaptic(controllerInteractor.xrController);
        }
    }

    public void TriggerHaptic(XRBaseController controller) 
    {
        if (intensity > 0) {
            controller.SendHapticImpulse(intensity, duration);
        }
    }
}*/

public class HapticInteraction : MonoBehaviour
{
    //public Haptic hapticSelectedEntered;

    public float intensity;
    public float duration;

    public XRBaseController controller;

    // Start is called before the first frame update
    void Start()
    {
        //XRBaseInteractable interactable = GetComponent<XRBaseInteractable>();
        //interactable.selectEntered.AddListener(hapticSelectedEntered.TriggerHaptic);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("ball_tag")) {
            controller.SendHapticImpulse(intensity, duration);
        }
    }
}
