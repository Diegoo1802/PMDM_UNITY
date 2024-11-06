using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFuncion : MonoBehaviour
{
    // Start is called before the first frame update
   public void ChangeScene(string sceneName)
    {
           GameManager.instance.ChangeScene(sceneName);
    }
}
