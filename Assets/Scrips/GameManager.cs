using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int[] puntuacion;
    public static GameManager instance;

    // Start is called before the first frame update
    void Awake()
    {
        if (!instance)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        puntuacion = new int[2];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int GetIndexPuntuacion(int index)
    { 
        return puntuacion[index]; 
    }

    public void SetIndexPuntuacion(int index, int nValue)
    {
        puntuacion[index] = nValue;    
    }
    public void ChangeScene( string sceneName )
    {
        SceneManager.LoadScene( sceneName );   
    }
}
