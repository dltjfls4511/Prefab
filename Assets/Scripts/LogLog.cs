using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogLog : MonoBehaviour
{
    public void ShowLog()
    {
        if (this.gameObject.name == "Basic")
        {
            Debug.Log("Basic ��ư ����");
        }
        else if (this.gameObject.name == "Variant")
        {
            Debug.Log( "Variant ��ư ����");
        }
        else if (this.gameObject.name == "Nested")
        {
            Debug.Log("Nested ��ư ����");
        }
        
    }
}
