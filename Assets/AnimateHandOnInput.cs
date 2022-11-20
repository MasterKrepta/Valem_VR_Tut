using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class AnimateHandOnInput : MonoBehaviour
{
    public InputActionProperty pinceAnimAction;
    public InputActionProperty gripAnim;
    Animator animHand;
    // Start is called before the first frame update
    void Start()
    {
        animHand = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var triggerVal = pinceAnimAction.action.ReadValue<float>();
        var gripVal = gripAnim.action.ReadValue<float>();

        animHand.SetFloat("Trigger", triggerVal);
        animHand.SetFloat("Grip", gripVal);
    }
}
