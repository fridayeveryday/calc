using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calc : MonoBehaviour
{
    public Text textOfResult;
    public Button button;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void clickOnButton(string val)
    {

        button.GetComponent<Text>().text = "";
    }


    public void clickOnDigit(double val)
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
