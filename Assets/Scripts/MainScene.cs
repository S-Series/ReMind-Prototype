using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScene : MonoBehaviour
{
    PlayerInputSystem playerInput;
    private void Awake()
    {
        playerInput = new PlayerInputSystem();
        playerInput.OnMenu.MoveUp.performed += value => OnMoveUp();
        playerInput.OnMenu.MoveDown.performed += value => OnMoveDown();
        playerInput.OnMenu.MoveLeft.performed += value => OnMoveLeft();
        playerInput.OnMenu.MoveRight.performed += value => OnMoveRight();
    }
    public static void LoadScene()
    {
        
    }
    public void SetItem(int index)
    {

    }

    private void OnMoveUp()
    {
        
    }
    private void OnMoveDown()
    {
        
    }
    private void OnMoveLeft()
    {
        
    }
    private void OnMoveRight()
    {

    }
}