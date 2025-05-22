using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QRCodeStorer : MonoBehaviour
{
    public List<string> pastSCOUNs = new List<string>();
    static QRCodeStorer instance;
    void Awake()
    {
        if (instance){
            Destroy(gameObject);
        }else{
            instance = this;
            DontDestroyOnLoad(transform.gameObject);
        }
    }

    public void addSCOUN(string SCOUN){
        if (pastSCOUNs.Count == 5) pastSCOUNs.Remove(pastSCOUNs[0]);
        pastSCOUNs.Add(SCOUN);
    }
}
