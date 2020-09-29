using UnityEngine;
using UnityEngine.UI;
using System.Data;
using System.Linq.Expressions;

public class ButtonClick : MonoBehaviour
{

    public Button butt;
    public Text totalRes;

    public void click()
    {
        totalRes.text += butt.GetComponentInChildren<Text>().text;
    }

    public void clickOnEquals()
    {
        DataTable dt = new DataTable();
        string st = totalRes.text.Replace(',', '.');
        string res = dt.Compute(st, null).ToString();
        totalRes.text = res;
    }

    public void clickOnClear()
    {
        totalRes.text = totalRes.text.Substring(0, totalRes.text.Length - 1);
    }

    public void clickOnClearAll()
    {
        totalRes.text = "";
    }
}
