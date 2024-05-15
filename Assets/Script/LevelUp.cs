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

    //���x���A�b�v�ł��邩���� (�N�b�L�[���������Ƃ��Ɏ��s)
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

    //���x���A�b�v�{�^�����N���b�N�����Ƃ��Ɏ��s
    public void LevelUpButtonClick()
    {
        //���x���A�b�v
        GlobalValue.level += 1;
        
        //������炷
        GlobalValue.cookie -= GlobalValue.cookieRequired;

        //CookieText�\��
        cookieQuantity.Abbreviation();

        //���x���A�b�v������2�̗ݏ摝�₷
        GlobalValue.cookieRequired *= 2;

        //LevelUpText�\��
        LevelUpText();

        //����Ă���܂����x���A�b�v�ł��邩����
        LevelButtonInteractable();
    }

    //LevelUpText�\��
    public void LevelUpText()
    {
        text.text = "Level�F" + GlobalValue.level.ToString() + "\n" + "Next:" + GlobalValue.cookieRequired;
    }
}
