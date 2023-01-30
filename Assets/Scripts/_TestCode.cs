using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class _TestCode : MonoBehaviour
{
    PlayerInputSystem input;

    private void Awake()
    {
        input = new PlayerInputSystem();
        //input.OnMenu.MoveDown.performed += value => OnMoveDown();
    }
}
 