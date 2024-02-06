using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KakFunction : MonoBehaviour
{
    public GameObject kak;
    public Transform kakSpawn;
    public Vector3 kakPosition;

    public void Start()
    {
        kakPosition = kakSpawn.position;
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(kak, kakPosition, Quaternion.identity);
        }
    }
}
