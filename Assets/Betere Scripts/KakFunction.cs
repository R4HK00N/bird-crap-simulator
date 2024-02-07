using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KakFunction : MonoBehaviour
{
    public GameObject winScreen;
    public GameObject questScreen;
    public int prullenbakHits;
    public int streetlightHits;
    public int benchHits;
    public TMP_Text questText;
    public TMP_Text counter;

    public void CheckForKak(Transform other)
    {
        if(other.tag == "Prullenbak")
        {
            prullenbakHits++;
            counter.text = prullenbakHits.ToString();
            if(prullenbakHits >= 100)
            {
                counter.text = "0";
                questText.text = "Now hit 100 street lights";
            }
        }
        if (other.tag == "Streetlight" && prullenbakHits >= 100)
        {
            streetlightHits++;
            counter.text = streetlightHits.ToString();
            if (streetlightHits >= 100)
            {
                counter.text = "0";
                questText.text = "100 Benches, too ez";
            }
        }
        if (other.tag == "Bench" && streetlightHits >= 100)
        {
            benchHits++;
            counter.text = benchHits.ToString();
            if (benchHits >= 100)
            {
                Time.timeScale = 0;
                winScreen.SetActive(true);
                questScreen.SetActive(false);
                Cursor.lockState= CursorLockMode.None;
            }
        }
    }
}
