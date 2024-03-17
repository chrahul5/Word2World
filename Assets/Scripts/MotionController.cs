/*
 * The file controls custom aspects of the Player.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class MotionController : MonoBehaviour
{
    public InputActionProperty rightGripAction;
    public InputActionProperty leftGripAction;

    // Reference to the continous move provider.
    public ActionBasedContinuousMoveProvider continuousMoveProvider;

    // Start is called before the first frame update
    void Start()
    {
        continuousMoveProvider = GetComponent<ActionBasedContinuousMoveProvider>();
    }

    void UpdateMoveSpeed()
    {
        // Get grip float values.
        float leftGripValue = leftGripAction.action.ReadValue<float>();
        float rightGripValue = rightGripAction.action.ReadValue<float>();


        if (leftGripValue > 0.5f && rightGripValue > 0.5f)
        {
            continuousMoveProvider.moveSpeed = 5;
        }
        else
        {
            continuousMoveProvider.moveSpeed = 1;
        }

    }

    // Update is called once per frame
    void Update()
    {
        UpdateMoveSpeed();
    }
}

