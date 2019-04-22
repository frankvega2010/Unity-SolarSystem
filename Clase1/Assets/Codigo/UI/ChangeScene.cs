﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string nombreDeEscena;

    public void SwitchScene()
    {
        SceneManager.LoadScene(nombreDeEscena);
    }
}