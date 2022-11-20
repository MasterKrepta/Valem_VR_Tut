using System.Xml;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class ActivateTeleportRay : MonoBehaviour
{
    public XRRayInteractor rayInteractor;

    public InputActionProperty rightActivate;


    // Update is called once per frame
    void Update()
    {
        if ((rightActivate.action.ReadValue<float>() > 0.1f))
        {
            rayInteractor.enabled = true;
        }
        else
            rayInteractor.enabled = false;

    }
}
