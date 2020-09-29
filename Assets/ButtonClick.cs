using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Data;

public class ButtonClick : MonoBehaviour
{

    public Button butt;
    public Text text;
/*    public string calc1;
    public string x1;*/
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void click()
    {
        /* Debug.Log(butt.GetComponent<Text>().text)*/
        string st = butt.GetComponentInChildren<Text>().text;
/*        string str = butt.transform.FindChild("Text").GetComponent<Text>.text;
*/        text.text += st;
    }

    public void clickOnEquals()
    {
        
        DataTable dt = new DataTable();
        string res = (dt.Compute(text.text, "")).ToString();
        click();
        text.text = res;

    }


    public void clickOnClear()
    {
        text.text = text.text.Substring(0, text.text.Length - 1);
    }

    public void clickOnClearAll()
    {
        text.text = "";
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
