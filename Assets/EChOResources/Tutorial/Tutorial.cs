﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
public class Tutorial : MonoBehaviour
{

    public RawImage image;

    void Start()
    {
        // Turns the image off.
        image.enabled = false;
        //image.SetActive(false);
    }
    public void btnInfo()
    {
        //image.active = !image.active;
        image.enabled = !image.enabled;
    }

}