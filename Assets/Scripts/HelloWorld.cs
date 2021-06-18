using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HelloWorld : MonoBehaviour
{
    [SerializeField] private string message = "Hello World";
    [Range(0, 100)] [SerializeField] private int count;

    public UnityEvent testEvent;
    
    private void Awake()
    {
        Debug.Log("Вызвался Awake");
    }

    // Start is called before the first frame update
    private void Start()
    {
        testEvent.Invoke();
        Debug.Log("Вызвался Start");
    }

    // Update is called once per frame
    private void Update()
    {
        Debug.Log(message);
    }

    private void OnEnable()
    {
        Debug.Log("Вызвался OnEnable");
    }

    private void OnDisable()
    {
        Debug.Log("Вызвался OnDisable");
    }

    private void OnDestroy()
    {
        Debug.Log("Вызвался OnDestroy");
    }
}
