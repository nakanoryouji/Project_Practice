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

    //int ���I�[�o�[���邱�Ƃ��Ȃ��悤�ɂ��邽�߂P���ȏ�ɂȂ����ꍇ�ʂ̕ϐ���+1
    public void Abbreviation()
    {
        //cookie ���}�C�i�X�ɂȂ����Ƃ� hundredMillionCookies ��������� cookie �� hundredMillion �𑫂�
        if (GlobalValue.cookie < 0)
        {
            GlobalValue.hundredMillionCookies -= GlobalValue.cookie / hundredMillion;
            GlobalValue.cookie = (GlobalValue.cookie % hundredMillion) + hundredMillion;

        }

        //cookie �� hundredMillion ��荂���Ȃ����ꍇ���̕� hundredMillionCookies �� +1 ����
        if (GlobalValue.cookie >= hundredMillion)
        {
            GlobalValue.hundredMillionCookies += GlobalValue.cookie / hundredMillion;
            GlobalValue.cookie = GlobalValue.cookie % hundredMillion;
        }

        //�e�L�X�g�\��
        if (GlobalValue.hundredMillionCookies == 0)
        {
            text.text = "Cookie�F" + GlobalValue.cookie.ToString();
        }
        else
        {
            int cookies = GlobalValue.cookie / (hundredMillion / 100);
            text.text = "Cookie�F" + GlobalValue.hundredMillionCookies.ToString() + "." + cookies.ToString() + "��";
        }
    }
}
