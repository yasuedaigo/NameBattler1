﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace BattleStart
{
    public class SceneManagerScript : MonoBehaviour
    {
        public void clickBackButton()
        {
            SceneManager.LoadScene("MakeParty");
        }
    }
}
