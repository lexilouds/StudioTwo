using UnityEngine;
using System;
using UnityEngine.Events;

public class FallTrigger : MonoBehaviour
{
    public UnityEvent OnPillFall = new();
    public bool isPinFallen = false;

    private void OnTriggerEnter(Collider triggeredObject) {
        if (triggeredObject.CompareTag("Ground") && !isPinFallen) {
            isPinFallen = true;
            OnPillFall?.Invoke();
            Debug.Log($"{gameObject.name} is fallen");
        }
    }
}
