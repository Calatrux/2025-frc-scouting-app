using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class SCOUNManager : MonoBehaviour
{
    public ActionManager actionManager;
    public GameObject qrCode;
    public TMP_Text qrCodeTitle;
    public QRCodeGenerator qrCodeGenerator;
    public ConfirmMenu confirmMenu;
    public General general;

    public string GenerateSCOUN()
    {
        string scoun = "";
        foreach (KeyValuePair<int, IAction> action in actionManager.actions)
        {
            scoun += action.Value.GetTimePerformed() + action.Value.GetID().ToString() + ".";
        }

        return scoun;
    }

    public void generateQR()
    {
        string scoun = confirmMenu.GetInfoSCOUN() + GenerateSCOUN() + general.GetFlag();
        qrCode.SetActive(true);
        qrCodeGenerator.qrCodeString = scoun;
        qrCodeGenerator.GenerateQRCode();
        qrCodeTitle.text = confirmMenu.getFormattedSCOUN();
    }
}
