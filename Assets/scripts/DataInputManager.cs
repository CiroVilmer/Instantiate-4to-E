using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataInputManager : MonoBehaviour
{

    public Text txtUserName;

    public void showGreetings()
    {
        Debug.Log("Hola " + txtUserName.text);
    }
}
