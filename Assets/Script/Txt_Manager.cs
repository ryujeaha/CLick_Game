using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Numerics;

public class Txt_Manager : MonoBehaviour
{
   BigInteger money = 1;
   [SerializeField] Text money_txt;

    private void Start()
    {
        money = 1;
        money_txt.text = MoneyUp(money);
    }

    public void BtnClick()
    {
        money =  money * 11;
        money_txt.text = MoneyUp(money);
    }

   public string  MoneyUp(BigInteger _money)
    {
        string value = _money.ToString();
        if(value.Trim().Length <=3 )
        {
            value = _money + "¿ø";
        }
       else if(value.Trim().Length > 3&&value.Trim().Length <=6)
        {
            value = (money / 1000) + "K";  
        }
        else if (value.Trim().Length > 6 && value.Trim().Length <= 9)
        {
            value = (money / 1000000) + "M";
        }
        else if (value.Trim().Length > 9 && value.Trim().Length <= 12)
        {
            value = (money / 1000000000) + "B";
        }
        else if (value.Trim().Length > 12 && value.Trim().Length <= 15)
        {
            value = (money / 1000000000000) + "T";
        }
        else if(value.Trim().Length > 15)
        {
            value = value.Substring(0, 1)+"."+value.Substring(1,2) + "E" + (value.Length-1);
        }
        return value;
    }
}
