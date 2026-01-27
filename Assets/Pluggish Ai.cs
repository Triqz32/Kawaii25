using TMPro;
using UnityEngine;

public class PluggishAi : MonoBehaviour
{
    [SerializeField] TMP_Text chatlog;
    [SerializeField] TMP_InputField input;

    string content = "Pluggish Ai";// le text som kommer upp via yk
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        chatlog.text = content;// det som gör string content funka
    }

    public void Send()
    {
        content += "\nDu: " + input.text;
        Responce(input.text);
        input.text = "";
    }
    
    void Responce(string msg)
    {
        msg= msg.ToLower();
        string svar = "";


        content += "\nPluggish AI: " + svar;
    }
    
    
}

