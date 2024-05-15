using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUp : MonoBehaviour
{
    public CookieQuantity cookieQuantity;
    public Button levelButton;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        LevelUpText();
        LevelButtonInteractable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //レベルアップできるか判定 (クッキーが増えたときに実行)
    public void LevelButtonInteractable()
    {
        if (GlobalValue.cookieRequired < GlobalValue.cookie)
        {
            levelButton.interactable = true;
        }
        else
        {
            levelButton.interactable = false;
        }
    }

    //レベルアップボタンをクリックしたときに実行
    public void LevelUpButtonClick()
    {
        //レベルアップ
        GlobalValue.level += 1;
        
        //消費分減らす
        GlobalValue.cookie -= GlobalValue.cookieRequired;

        //CookieText表示
        cookieQuantity.Abbreviation();

        //レベルアップしたら2の累乗増やす
        GlobalValue.cookieRequired *= 2;

        //LevelUpText表示
        LevelUpText();

        //消費してからまだレベルアップできるか判定
        LevelButtonInteractable();
    }

    //LevelUpText表示
    public void LevelUpText()
    {
        text.text = "Level：" + GlobalValue.level.ToString() + "\n" + "Next:" + GlobalValue.cookieRequired;
    }
}
