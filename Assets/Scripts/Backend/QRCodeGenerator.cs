using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZXing;
using ZXing.QrCode;
using UnityEngine.UI;
using TMPro;
using System;

public class QRCodeGenerator : MonoBehaviour
{
    public RawImage imageReciever;
    public string qrCodeString;

    private Texture2D qrCodeTexture;
    public TMP_Text title;

    void Start()
    {
        qrCodeTexture = new Texture2D(512, 512);
        GenerateQRCode();
    }

    // Update is called once per frame
    private Color32[] Encode(string textForEncoding, int width, int height)
    {
        BarcodeWriter writer = new BarcodeWriter
        {
            Format = BarcodeFormat.QR_CODE,
            Options = new QrCodeEncodingOptions
            {
                Height = height,
                Width = width
            }
        };
        return writer.Write(textForEncoding);
    }

    public void GenerateQRCode()
    {
        qrCodeTexture = new Texture2D(256, 256);
        Color32[] texture = Encode(qrCodeString, qrCodeTexture.width, qrCodeTexture.height);
        qrCodeTexture.SetPixels32(texture);
        qrCodeTexture.Apply();
        imageReciever.texture = qrCodeTexture;
        //setTitle();
    }

    string getMatchFromSCOUN(string SCOUN){
        string[] SCOUNSplit = SCOUN.Split(new string[] { "$", "&" }, StringSplitOptions.None);
        return SCOUNSplit[2];
    }

    public void setTitle(){
        title.text = getMatchFromSCOUN(qrCodeString);
    }


}

