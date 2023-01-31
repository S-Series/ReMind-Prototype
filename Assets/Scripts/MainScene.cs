using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScene : MonoBehaviour
{
    private static MainScene main;

    private PlayerInputSystem playerInput;

    [SerializeField] private SpriteRenderer SelectFrameRenderer;
    private float[] rendererPosY = { 0.0f, 0.0f, 0.0f };

    private void Awake()
    {
        main = this;
        playerInput = new PlayerInputSystem();

        playerInput.OnMenu.MoveUp.performed += value => OnMoveUp();
        playerInput.OnMenu.MoveDown.performed += value => OnMoveDown();
        playerInput.OnMenu.MoveLeft.performed += value => OnMoveLeft();
        playerInput.OnMenu.MoveRight.performed += value => OnMoveRight();

        playerInput.OnMenu.Select.performed += value => OnSelect();
        playerInput.OnMenu.Cancel.performed += value => OnCancel();
    }
    public static void LoadScene()
    {
        SetItem(0);
    }
    public static void SetItem(int index)
    {
        Transform transform;
        transform = main.SelectFrameRenderer.transform;
        transform.localPosition = new Vector3(0, main.rendererPosY[index], 0);
        transform.GetComponent<Animator>().SetTrigger("Play");
        transform.GetComponent<AudioSource>().Play();
    }

    //$ InputSystem Actions
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

    private void OnSelect()
    {

    }
    private void OnCancel()
    {

    }
}