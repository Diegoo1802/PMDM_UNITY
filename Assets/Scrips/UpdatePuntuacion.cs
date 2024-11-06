using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdatePuntuacion : MonoBehaviour
{
    // Start is called before the first frame update

    private TMP_Text textComponent;
    public uint playerIndex;
    void Start()
    {
        textComponent = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textComponent.text = "Jugador " + playerIndex + ": " + GameManager.instance.GetIndexPuntuacion((int)playerIndex);
    }
}
