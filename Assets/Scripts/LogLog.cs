using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogLog : MonoBehaviour
{
    public void ShowLog()
    {
        if (this.gameObject.name == "Basic")
        {
            Debug.Log("Basic 버튼 누름");
        }
        else if (this.gameObject.name == "Variant")
        {
            Debug.Log( "Variant 버튼 누름");
        }
        else if (this.gameObject.name == "Nested")
        {
            Debug.Log("Nested 버튼 누름");
        }
        
    }
}
