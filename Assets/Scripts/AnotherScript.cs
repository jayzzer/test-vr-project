using System;
using UnityEngine;

public class AnotherScript : MonoBehaviour
{
    [SerializeField] private HelloWorld helloWorldScript;

    private void OnEnable()
    {
        helloWorldScript.testEvent.AddListener(OnTestEventInvoke);
    }
    
    private void OnDisable()
    {
        helloWorldScript.testEvent.RemoveListener(OnTestEventInvoke);
    }

    private void OnTestEventInvoke()
    {
        Debug.LogWarning("Сработал testEvent");
    }
}