﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Yes : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("GameScene");
    }
}
