using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class UniteToMessage : MonoBehaviour {

    public Text m_InputField;
    public Text LogText;
    public Text TimeText;
    public Text LanguageText;
    public Text EndGameText;
    public Text MusicTrackText;
    public Text SatellitesText;
    public Text SnakeText;
    public Text CodeFixText;
    //public Button SynchroniseServerButton;
    //public Button SynchroniseClientButton;

    public string UnitedTextString;
    public string LogTextString;
    public string TimeTextString;
    public string LanguageTextString;
    public string EndGameTextString;
    public string MusicTrackTextString;
    public string SatellitesTextString;
    public string SnakeTextString;
    public string CodeFixTextString;
    public bool IsAdminSender = false;
    public bool IsUserSender = false;
   

    // Use this for initialization
    void Start () {
        InvokeRepeating("CollectToMessage", 0, 3.0f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CollectToMessage()
    {
        if (IsUserSender)
        {
           
            //TimeTextString = TimeText.text;
            //LanguageTextString = LanguageText.text;
            //EndGameTextString = EndGameText.text;
            //MusicTrackTextString = MusicTrackText.text;
            //SatellitesTextString = SatellitesText.text;
            //SnakeTextString = SnakeText.text;
            CodeFixTextString = CodeFixText.text;
            

            UnitedTextString = CodeFixTextString + "|" ;
            m_InputField.text = UnitedTextString;
        }
        if (IsAdminSender)
        {
            
            TimeTextString = TimeText.text;
            LanguageTextString = LanguageText.text;
            EndGameTextString = EndGameText.text;
            MusicTrackTextString = MusicTrackText.text;
            SatellitesTextString = SatellitesText.text;
            SnakeTextString = SnakeText.text;
            CodeFixTextString = CodeFixText.text;
           

            UnitedTextString = TimeTextString + "|" + LanguageTextString + "|" + EndGameTextString + "|" + MusicTrackTextString + "|" + SatellitesTextString + "|" + SnakeTextString + "|";
            m_InputField.text = UnitedTextString;
        }
    }
}
