using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using ZXing.QrCode;

public class PastQRCodeManager : MonoBehaviour
{
    public GameObject pastQRCodeHolder;
    public TMP_Dropdown pastMatchDropdown;
    public QRCodeGenerator qRCodeGenerator;
    public TMP_Text title;
    void repopulatePastMatchDropdown(){
        List<string> pastMatches = GameObject.Find("QRCodeStorer").GetComponent<QRCodeStorer>().pastSCOUNs;
        print(pastMatches.Count);
        pastMatchDropdown.ClearOptions();
        List<string> options = new List<string>
        {
            "Select Match"
        };

        for (int i = 0; i < pastMatches.Count; i++){
            string match = getMatchFromSCOUN(pastMatches[i]);
            options.Add(match);
        }
        options.Add("-----------");
        pastMatchDropdown.AddOptions(options);
    }

    string getMatchFromSCOUN(string SCOUN){
        string[] SCOUNSplit = SCOUN.Split(new string[] { "$", "&" }, StringSplitOptions.None);
        return SCOUNSplit[2];
    }

    void enablePastQRCodeHolder(){
        pastQRCodeHolder.SetActive(true);
    }

    void disablePastQRCodeHolder(){
        pastQRCodeHolder.SetActive(false);
    }

    public void setMatchFinderReady(){
        enablePastQRCodeHolder();
        repopulatePastMatchDropdown();
    }

    public void generatePastQR(){
        List<string> pastMatches = GameObject.Find("QRCodeStorer").GetComponent<QRCodeStorer>().pastSCOUNs;
        print((pastMatchDropdown.value, pastMatches.Count));
        if (pastMatchDropdown.value > 0 && pastMatchDropdown.value <= pastMatches.Count){
            string oldSCOUN = pastMatches[pastMatchDropdown.value - 1];
            qRCodeGenerator.qrCodeString = oldSCOUN;
            disablePastQRCodeHolder();
            qRCodeGenerator.GenerateQRCode();
        }
    }
}
