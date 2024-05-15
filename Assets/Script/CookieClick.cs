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

    //�N�b�L�[�{�^�����N���b�N�����Ƃ��Ɏ��s
    public void CookieClickOnButton()
    {
        //���x���ɉ����đ�����N�b�L�[�̐����㏸
        for (int i = 0; i < GlobalValue.level;i++)
        {
            GlobalValue.cookie++;
        }
        
        //�����\�L��ς���
        cookieQuantity.Abbreviation();

        //���x���A�b�v�ł��邩����
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
            //���x���A�b�v�ł��邩����
            levelUp.LevelButtonInteractable();
        }
    }
}
