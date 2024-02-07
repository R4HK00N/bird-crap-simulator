using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KakFunction : MonoBehaviour
{
    public GameObject kak;
    public Transform kakSpawn;
    public Vector3 kakPosition;
    public int prullenbakHits;
    public TMP_Text questText;

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
    public void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Prullenbak")
        {
            prullenbakHits++;
            if(prullenbakHits >= 10)
            {
                questText.text = "Now get some street lights";
                if(other.transform.tag == "Streetlight")
                {
                    questText.text = "?";
                }
            }
        }
    }
}
