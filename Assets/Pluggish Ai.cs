using TMPro;
using UnityEngine;

public class PluggishAi : MonoBehaviour
{
    [SerializeField] TMP_Text chatlog;
    [SerializeField] TMP_InputField input;

    string content = "Pluggish Ai";// Elias: le text som kommer upp via chat arean
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        chatlog.text = content;//Elias: det som gör string content funka
    }

    public void Send()
    {
        content += "\nDu: " + input.text;// Elias: gör en ny rad och lägger till Du: och sedan vad du har skrivit i input fielden.
        Responce(input.text);// Elias: gör så att messagen går till coden nedan som behöver en message för att den ska funka.
        input.text = "";//Elias: Tar bord vad du har skrivit i unput Fielden.
    }
    
    void Responce(string msg)// Elias: behöver en message för att den ska funka
    {
        msg= msg.ToLower();//Elias: gör allt man har skrivit bli till små bokstäver
        string svar = "";


        content += "\nPluggish AI: " + svar;
    }
    
    
}

