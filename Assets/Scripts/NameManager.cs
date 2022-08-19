using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameManager : MonoBehaviour
{
    public static NameManager Instance;

    public string playerName;

    private void Awake()
    {
        
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        
    Instance = this;
    DontDestroyOnLoad(gameObject);
    }
    public void SetName(Text name){
        NameManager.Instance.playerName = name.text;
    }
}
