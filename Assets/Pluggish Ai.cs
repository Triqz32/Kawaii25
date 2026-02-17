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
    
    void Responce(string msg)// Elias: behöver en message för att den ska funka ALLT under detta är gjord av Elias
    {
        msg= msg.ToLower();//Elias: gör allt man har skrivit bli till små bokstäver
        string svar = "";
        Match match = Regex.Match(msg, "yo|hallå|hej|ursäkta|hjälp|halloj");// gjord av ELias
        if (match.Success)
        {
            svar = "Hej, vilket ämne vill du ha hjälp med vi har matte och Samhällskunskap";// av Elias
        }
        match = Regex.Match(msg,"matte");// lägg till fårgot och stöd om man säger te.x hjälp mig med denna frågan sen förklarar man vad det står på frågan och vi ger de hints och sist svaren Av Elias
        if (match.Success)
        {
            svar = "Okej säg math start och vilket del av matten du vill för att börja";// av Elias
        }
        match = Regex.Match(msg, "math start algebra");// Av Elias
        int rng = Random.Range(0, 100);// Av Elias
        if (match.Success) {
            if (rng == 0)
            {
                svar = "2x plus 3";
            }
            else if (rng == 1) { }// av Elias
        }
        /*if (msg == "yo" || msg == "hej" || msg == "hallå" )// || detta kan säga som ELLER så det är yo ELLER hej ELELR osv
        {
            svar = "Hej, vilket ämne vill du ha hjälp med vi har Matte och Samhällskunskap.";
        }*/
        // Av Elias




        content += "\nPluggish AI: " + svar;// vi måste lägga till mer code för att göra den unique Av Elias
    }
    

    
    
}

