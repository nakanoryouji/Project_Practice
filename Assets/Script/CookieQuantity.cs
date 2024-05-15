using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CookieQuantity : MonoBehaviour
{
    public Text text;

    const int hundredMillion = 100000000;

    // Start is called before the first frame update
    void Start()
    {
        Abbreviation();
    }

    //int がオーバーすることがないようにするため１億以上になった場合別の変数に+1
    public void Abbreviation()
    {
        //cookie がマイナスになったとき hundredMillionCookies から引いて cookie に hundredMillion を足す
        if (GlobalValue.cookie < 0)
        {
            GlobalValue.hundredMillionCookies -= GlobalValue.cookie / hundredMillion;
            GlobalValue.cookie = (GlobalValue.cookie % hundredMillion) + hundredMillion;

        }

        //cookie が hundredMillion より高くなった場合その分 hundredMillionCookies に +1 する
        if (GlobalValue.cookie >= hundredMillion)
        {
            GlobalValue.hundredMillionCookies += GlobalValue.cookie / hundredMillion;
            GlobalValue.cookie = GlobalValue.cookie % hundredMillion;
        }

        //テキスト表示
        if (GlobalValue.hundredMillionCookies == 0)
        {
            text.text = "Cookie：" + GlobalValue.cookie.ToString();
        }
        else
        {
            int cookies = GlobalValue.cookie / (hundredMillion / 100);
            text.text = "Cookie：" + GlobalValue.hundredMillionCookies.ToString() + "." + cookies.ToString() + "億";
        }
    }
}
