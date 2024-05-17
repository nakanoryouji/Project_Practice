using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GlobalValue
{
    //クッキーの数
    public static int cookie = 0;
    public static int hundredMillionCookies = 0; //100000000(1億)

    //クッキー必要数 2の累乗
    public static int cookieRequired = 16;
    
    //レベル
    public static int level = 1;

    //フィーバーまでのカウント
    public static int feverCount = 0;
    public static bool feverFlag = false;
}
