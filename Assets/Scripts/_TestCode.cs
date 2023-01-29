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
        input.OnMenu.MoveDown.performed += value => OnMoveDown();
        input.OnMenu.Test.performed += value => OnTest();
        input.OnMenu.Test1.performed += value => OnTest1();
    }
    private void OnMoveDown()
    {
        print("A");
    }
    private void OnTest()
    {
        print("A");
    }
    private void OnTest1()
    {
        print("A");
    }
}
 