using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public GameObject objectToClone;
    int cloneAmount;
    public Text txtUserCloneAmount;


    public void multiInstantiate()
    {

        if(txtUserCloneAmount.text != "")
        {
            cloneAmount = int.Parse(txtUserCloneAmount.text);
        }
        else
        {
            Debug.Log("Error");
        }

        int counter = 0;

        while (counter < cloneAmount)
        {
            Instantiate(objectToClone);
            counter++;
        }
    }
}
