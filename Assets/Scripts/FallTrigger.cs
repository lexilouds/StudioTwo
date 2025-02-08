using UnityEngine;
using System;
using UnityEngine.Events;

public class FallTrigger : MonoBehaviour
{
    public UnityEvent OnPillFall = new();
    public bool isPinFallen = false;

    private void OnTriggerEnter(Collider triggeredBody) {
        isPinFallen = true;
        OnPillFall?.Invoke();
        Debug.Log($"{gameObject.name} is fallen");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
