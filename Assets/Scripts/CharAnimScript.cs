using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
    private ArrayList idleList = new ArrayList();
    public int idleRndm;
    
    void Awake()
    {
        listScript = GetComponent<RandomListScript>();
        _animator = GetComponent<Animator>();
        rndmNmbr = UnityEngine.Random.Range(6, 15);
        animCount = UnityEngine.Random.Range(1, 3);
        idleList.Add("idle1");
        idleList.Add("idle2");
        idleList.Add("idle3");
        chosenIdle = GetString();
    }
    
    // Update is called once per frame
    void Update()
    {
        Animation();
    }
    
    public string GetString()
    {
        idleRndm = UnityEngine.Random.Range(0,idleList.Count);
        string rndmStrng = idleList[idleRndm].ToString();
        return rndmStrng;
    }

    public void Animation()
    {
        if (Gamepad.current == null)
        {
            if (move.action.ReadValue<Vector2>() == new Vector2(0, 0))
            {
                if (counter < rndmNmbr && !playing)
                {
                    _animator.Play("Base");
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
                        rndmNmbr = UnityEngine.Random.Range(6, 15);
                        animCount = UnityEngine.Random.Range(1,3);
                        counter = 0;
                        fCounter = 0;
                        chosenIdle = GetString();
                        playing = false;
                    }
                }
            }
            if (move.action.ReadValue<Vector2>() != new Vector2(0,0))
            {
                Debug.Log("Stopped!");
                _animator.Play("walk");
                counter = 0;
            }
        }
        else
        {
            if (Gamepad.current.dpad.ReadValue() == new Vector2(x: 0, y: 0) && Gamepad.current.leftStick.ReadValue() == new Vector2(x:0, y:0))
            {
                if (counter < rndmNmbr && !playing)
                {
                    _animator.Play("Base");
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
                        rndmNmbr = UnityEngine.Random.Range(6, 15);
                        animCount = UnityEngine.Random.Range(1,3);
                        counter = 0;
                        fCounter = 0;
                        chosenIdle = GetString();
                        playing = false;
                    }
                }
            }
            if (Gamepad.current.dpad.ReadValue() != new Vector2(x: 0, y: 0) || Gamepad.current.leftStick.ReadValue() != new Vector2(x:0, y:0))
            {
                Debug.Log("Stopped!");
                _animator.Play("walk");
                counter = 0;
            }
        }
    }
}
