using System;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharAnimScript : MonoBehaviour
{
    public InputActionReference move;
    private Animator _animator;
    public float counter = 0;
    public float fCounter;
    public float animCount;
    public float rndmNmbr;
    public bool playing = false;
    public RandomListScript listScript;
    public string chosenIdle;
    
    void Awake()
    {
        listScript = GetComponent<RandomListScript>();
        _animator = GetComponent<Animator>();
        rndmNmbr = UnityEngine.Random.Range(3, 10);
        animCount = UnityEngine.Random.Range(2, 6);
        
        // Source - https://stackoverflow.com/a/723219
        // Posted by Neil Williams
        // Retrieved 2026-11-16, License - CC BY-SA 2.5
        // Was modified to fit our project

        var idleList = new List<string> { "idle1", "idle2", "idle3" };
        chosenIdle = listScript.GetRandomElements(idleList, 1).ToString();
        Debug.Log(listScript.GetRandomElements(idleList, 1));
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Gamepad.current == null)
        {
            if (move.action.ReadValue<Vector2>() == new Vector2(0, 0))
            {
                if (counter < rndmNmbr && !playing)
                {
                    counter += Time.deltaTime;
                }
                if (counter >= rndmNmbr && !playing)
                {
                    _animator.Play(chosenIdle);
                    playing = true;
                }
                if (playing)
                {
                    if (fCounter < animCount)
                    {
                        fCounter += Time.deltaTime;
                    }
                    if (fCounter >= animCount)
                    {
                        _animator.Play("Base");
                        rndmNmbr = UnityEngine.Random.Range(3, 10);
                        animCount = UnityEngine.Random.Range(2,6);
                        counter = 0;
                        fCounter = 0;
                        playing = false;
                    }
                }
            }
            if (move.action.ReadValue<Vector2>() != new Vector2(0,0))
            {
                Debug.Log("Stopped!");
                counter = 0;
            }
        }
        else
        {
            if (Gamepad.current.dpad.ReadValue() == new Vector2(x: 0, y: 0) && Gamepad.current.leftStick.ReadValue() == new Vector2(x:0, y:0))
            {
                if (counter < rndmNmbr && !playing)
                {
                    counter += Time.deltaTime;
                }
                if (counter >= rndmNmbr && !playing)
                {
                    _animator.Play(chosenIdle);
                    playing = true;
                }
                if (playing)
                {
                    if (fCounter < animCount)
                    {
                        fCounter += Time.deltaTime;
                    }
                    if (fCounter >= animCount)
                    {
                        _animator.Play("Base");
                        rndmNmbr = UnityEngine.Random.Range(3, 10);
                        animCount = UnityEngine.Random.Range(2,6);
                        counter = 0;
                        fCounter = 0;
                        playing = false;
                    }
                }
            }
            if (Gamepad.current.dpad.ReadValue() != new Vector2(x: 0, y: 0) || Gamepad.current.leftStick.ReadValue() != new Vector2(x:0, y:0))
            {
                Debug.Log("Stopped!");
                counter = 0;
            }
        }
    }
}
