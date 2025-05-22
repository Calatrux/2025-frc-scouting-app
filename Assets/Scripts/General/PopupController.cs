using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PopupController : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text text;
    public void Activate(string popupText)
    {
        text.text = popupText;
        StartCoroutine(PopupLifetime());
    }

    IEnumerator PopupLifetime(){
        yield return new WaitForSeconds(1f);
        gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
