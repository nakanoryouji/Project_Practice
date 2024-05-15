using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CookieClick : MonoBehaviour
{
    public CookieQuantity cookieQuantity;
    public LevelUp levelUp;

    double delay;

    // Update is called once per frame
    void Update()
    {
        if (GlobalValue.level > 5)
        {
            CookieAutClick();
        }
    }

    //クッキーボタンをクリックしたときに実行
    public void CookieClickOnButton()
    {
        //レベルに応じて増えるクッキーの数を上昇
        for (int i = 0; i < GlobalValue.level;i++)
        {
            GlobalValue.cookie++;
        }
        
        //文字表記を変える
        cookieQuantity.Abbreviation();

        //レベルアップできるか判定
        levelUp.LevelButtonInteractable();

    }

    public void CookieAutClick()
    {
        delay += Time.deltaTime;

        if (delay > 0.5)
        {
            delay = 0.0f;
            GlobalValue.cookie += GlobalValue.level - 5;
            cookieQuantity.Abbreviation();
            //レベルアップできるか判定
            levelUp.LevelButtonInteractable();
        }
    }
}
