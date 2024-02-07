using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VogelKak : MonoBehaviour
{
    KakFunction kakFunction;

    private void Start()
    {
        kakFunction = FindObjectOfType<KakFunction>();
    }
    private void OnCollisionEnter(Collision other)
    {
        kakFunction.CheckForKak(other.transform);
    }
}
