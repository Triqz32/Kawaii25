using System.Collections.Generic;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;

public class PluggishAi : MonoBehaviour
{
    [SerializeField] TMP_Text chatlog;
    [SerializeField] TMP_InputField input;
    [SerializeField] TMP_InputField inputName;
    [SerializeField] TMP_InputField Inputlist;
    public int Currentlist = 0;// Fuad: Det här är det nya listan som blir gjort
    //public string Question;
    public List<Question> Questions;
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

    public void Makenewlist()
    {
        Question newQuestion = new Question();//Fuad: Coden gör en lista
        newQuestion.personName = inputName.text;//Fuad: När man skriver sitt namn står det.
        newQuestion.newList= new List<string>();//Fuad: Man kan göra nya frågor
        Questions.Add(newQuestion);
    }

    public void showlist()
    {

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
        Match match = Regex.Match(msg, "yo|hallå|hej|ursäkta|hjälp|halloj");
        if (match.Success)
        {
            svar = "Hej, vilket ämne vill du ha hjälp med vi har matte och Samhällskunskap";
        }
        match = Regex.Match(msg,"");
        /*if (msg == "yo" || msg == "hej" || msg == "hallå" )// || detta kan säga som ELLER så det är yo ELLER hej ELELR osv
        {
            svar = "Hej, vilket ämne vill du ha hjälp med vi har Matte och Samhällskunskap.";
        }*/





        content += "\nPluggish AI: " + svar;// vi måste lägga till mer code för att göra den unique
    }
    

    
    
}

