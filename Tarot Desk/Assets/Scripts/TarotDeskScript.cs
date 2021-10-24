using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class TarotDeskScript : MonoBehaviour 
{
	
	private int[] random_Number = new int[9];
	private int[] random_Nunber_Looking = new int[9];
	private string CardName;
	private int HowMuchCardYouWant;
	public bool WouldYouWant = true;
	private string Looking;
	private int HowManyTurnCounter = 0;
	// Start is called before the first frame update

	bool TarotDeskController( int Turn,int HowMuchCardYouWant)
    {
        for (int i = 0; i < HowMuchCardYouWant; i++)
        {
            if (Turn != i)
            {
                if (random_Number[i] == random_Number[Turn])
                {
                    return true;
                }
            }
        }
        return false;
    }

	void Update()
    {
		TextMeshProUGUI Card = GameObject.Find("Canvas/Card").GetComponent<TextMeshProUGUI>();
		TextMeshProUGUI myTextTurn = GameObject.Find("Canvas/Turn").GetComponent<TextMeshProUGUI>();

		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}
		if (WouldYouWant)
		{
			for (int Card_Number = 0; Card_Number < HowMuchCardYouWant; Card_Number++)
			{
				do
				{
					random_Number[Card_Number] = Random.Range(0, 78);
					random_Nunber_Looking[Card_Number] = Random.Range(0, 2);
				} while (TarotDeskController( Card_Number, HowMuchCardYouWant));
			}
			for (int WritingTurn = 0; WritingTurn < HowMuchCardYouWant; WritingTurn++)
			{
				Looking = ForLookingArray(WritingTurn);
				WritingTurn++;
				CardName += WritingTurn +". Kart ";
				WritingTurn--;
				CardName += Looking;
				CardName += Writing_to_Log (WritingTurn);
				Card.text = CardName;
				CardName += "\n";			}
			CardName = "";
			WouldYouWant = false;
			myTextTurn.text = HowManyTurnCounter +" Kez kart çektin. ";
			HowManyTurnCounter++;
		}
		else
        {
			HowMuchCardYouWant = 0;
			WouldYouWant = NumericControl();
		}
	}
	string ForLookingArray (int turn)
    {
		if (random_Nunber_Looking[turn] == 0)
        {
			return "";
		}
		else if (random_Nunber_Looking[turn] == 1)
        {
			return "[Ters] ";
        }
		else
        {
			return "error ";
        }
			

	} 
	bool NumericControl()
	{
		if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1))
		{
			HowMuchCardYouWant = 1;
			return true;
		}
		else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2))
		{
			HowMuchCardYouWant = 2;
			return true;
		}
		else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3))
        {
			HowMuchCardYouWant = 3;
			return true;
		}
		else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4))
        {
			HowMuchCardYouWant = 4;
			return true;
		}
		else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5))
        {
			HowMuchCardYouWant = 5;
			return true;
		}
		else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6))
        {
			HowMuchCardYouWant = 6;
			return true;
		}
		else if (Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7))
        {
            HowMuchCardYouWant = 7;
            return true;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad8) || Input.GetKeyDown(KeyCode.Alpha8))
        {
            HowMuchCardYouWant = 8;
            return true;
        }
		else if (Input.GetKeyDown(KeyCode.Keypad9) || Input.GetKeyDown(KeyCode.Alpha9))
		{
			HowMuchCardYouWant = 9;
			return true;
		}
		else
        {
            return false;
        }
	}
	

	string Writing_to_Log(int writing_turn)
	{
		string Turner;
		if (random_Number[writing_turn] == 0)
			Turner = "Joker, The Fool";
		else if (random_Number[writing_turn] == 1)
			Turner = "Sihirbaz, The Magican";
		else if (random_Number[writing_turn] == 2)
			Turner = "Azize, The High Priestess";
		else if (random_Number[writing_turn] == 3)
			Turner = "Ýmparatoriçe, The Empress";
		else if (random_Number[writing_turn] == 4)
			Turner = "Ýmparator, The Emperor";
		else if (random_Number[writing_turn] == 5)
			Turner = "Aziz, The Hierophant";
		else if (random_Number[writing_turn] == 6)
			Turner = "Aþýklar, The Lovers";
		else if (random_Number[writing_turn] == 7)
			Turner = "Savaþ Arabasý, The Chariot";
		else if (random_Number[writing_turn] == 8)
			Turner = "Güç, Strength";
		else if (random_Number[writing_turn] == 9)
			Turner = "Ermiþ, Rhe Hermit";
		else if (random_Number[writing_turn] == 10)
			Turner = "Kader Çarký, Wheel of Fortune";
		else if (random_Number[writing_turn] == 11)
			Turner = "Adalet, Justice";
		else if (random_Number[writing_turn] == 12)
			Turner = "Asýlan Adam, The Hanged Man";
		else if (random_Number[writing_turn] == 13)
			Turner = "Ölüm, Death";
		else if (random_Number[writing_turn] == 14)
			Turner = "Denge, Temperance";
		else if (random_Number[writing_turn] == 15)
			Turner = "Þeytan, The Devil";
		else if (random_Number[writing_turn] == 16)
			Turner = "Yýkýlan Kule, The Tower";
		else if (random_Number[writing_turn] == 17)
			Turner = "Yýldýz, The Star";
		else if (random_Number[writing_turn] == 18)
			Turner = "Ay, The Moon";
		else if (random_Number[writing_turn] == 19)
			Turner = "Güneþ, The Sun";
		else if (random_Number[writing_turn] == 20)
			Turner = "Mahkeme, The Last Judgement";
		else if (random_Number[writing_turn] == 21)
			Turner = "Dünya, The World";
		else if (random_Number[writing_turn] == 22)
			Turner = "Deðnek Asý";
		else if (random_Number[writing_turn] == 23)
			Turner = "Deðnek Ýkilisi";
		else if (random_Number[writing_turn] == 24)
			Turner = "Deðnek Üçlüsü";
		else if (random_Number[writing_turn] == 25)
			Turner = "Deðnek Dörtlüsü";
		else if (random_Number[writing_turn] == 26)
			Turner = "Deðnek Beþlisi";
		else if (random_Number[writing_turn] == 27)
			Turner = "Deðnek Altýlýsý";
		else if (random_Number[writing_turn] == 28)
			Turner = "Deðnek Yedilisi";
		else if (random_Number[writing_turn] == 29)
			Turner = "Deðnek Sekizlisi";
		else if (random_Number[writing_turn] == 30)
			Turner = "Deðnek Dokuzlusu ";
		else if (random_Number[writing_turn] == 31)
			Turner = "Deðnek Onlusu ";
		else if (random_Number[writing_turn] == 32)
			Turner = "Deðnek Prensi ";
		else if (random_Number[writing_turn] == 33)
			Turner = "Deðnek Þövalyesi";
		else if (random_Number[writing_turn] == 34)
			Turner = "Deðnek Kraliçesi";
		else if (random_Number[writing_turn] == 35)
			Turner = "Deðnek Kralý";
		else if (random_Number[writing_turn] == 36)
			Turner = "Kupa Asý";
		else if (random_Number[writing_turn] == 37)
			Turner = "Kupa Ýkilisi";
		else if (random_Number[writing_turn] == 38)
			Turner = "Kupa Üçlüsü";
		else if (random_Number[writing_turn] == 39)
			Turner = "Kupa Dörtlüsü";
		else if (random_Number[writing_turn] == 40)
			Turner = "Kupa Beþlisi";
		else if (random_Number[writing_turn] == 41)
			Turner = "Kupa Altýlýsý";
		else if (random_Number[writing_turn] == 42)
			Turner = "Kupa Yedilisi";
		else if (random_Number[writing_turn] == 43)
			Turner = "Kupa Sekizlisi";
		else if (random_Number[writing_turn] == 44)
			Turner = "Kupa Dokuzlusu";
		else if (random_Number[writing_turn] == 45)
			Turner = "Kupa Onlusu";
		else if (random_Number[writing_turn] == 46)
			Turner = "Kupa Prensi";
		else if (random_Number[writing_turn] == 47)
			Turner = "Kupa Þövalyesi";
		else if (random_Number[writing_turn] == 48)
			Turner = "Kupa Kraliçesi";
		else if (random_Number[writing_turn] == 49)
			Turner = "Kupa Kralý";
		else if (random_Number[writing_turn] == 50)
			Turner = "Kýlýç Asý";
		else if (random_Number[writing_turn] == 51)
			Turner = "Kýlýç Ýkilisi";
		else if (random_Number[writing_turn] == 52)
			Turner = "Kýlýç Üçlüsü";
		else if (random_Number[writing_turn] == 53)
			Turner = "Kýlýç Dörtlüsü";
		else if (random_Number[writing_turn] == 54)
			Turner = "Kýlýç Beþlisi";
		else if (random_Number[writing_turn] == 55)
			Turner = "Kýlýç Altýlýsý";
		else if (random_Number[writing_turn] == 56)
			Turner = "Kýlýç Yedilisi";
		else if (random_Number[writing_turn] == 57)
			Turner = "Kýlýç Sekizlisi";
		else if (random_Number[writing_turn] == 58)
			Turner = "Kýlýç Dokuzlusu";
		else if (random_Number[writing_turn] == 59)
			Turner = "Kýlýç Onlusu";
		else if (random_Number[writing_turn] == 60)
			Turner = "Kýlýç Prensi";
		else if (random_Number[writing_turn] == 61)
			Turner = "Kýlýç Þövalyesi";
		else if (random_Number[writing_turn] == 62)
			Turner = "Kýlýç Kraliçesi";
		else if (random_Number[writing_turn] == 63)
			Turner = "Kýlýç Kralý";
		else if (random_Number[writing_turn] == 64)
			Turner = "Týlsým Asý";
		else if (random_Number[writing_turn] == 65)
			Turner = "Týlsým Ýkilisi";
		else if (random_Number[writing_turn] == 66)
			Turner = "Týlsým Üçlüsü";
		else if (random_Number[writing_turn] == 67)
			Turner = "Týlsým Dörtlüsü";
		else if (random_Number[writing_turn] == 68)
			Turner = "Týlsým Beþlisi";
		else if (random_Number[writing_turn] == 69)
			Turner = "Týlsým Altýlýsý";
		else if (random_Number[writing_turn] == 70)
			Turner = "Týlsým Yedilisi";
		else if (random_Number[writing_turn] == 71)
			Turner = "Týlsým Sekizlisi";
		else if (random_Number[writing_turn] == 72)
			Turner = "Týlsým Dokuzlusu";
		else if (random_Number[writing_turn] == 73)
			Turner = "Týlsým Onlusu";
		else if (random_Number[writing_turn] == 74)
			Turner = "Týlsým Prensi";
		else if (random_Number[writing_turn] == 75)
			Turner = "Týlsým Þövalyesi";
		else if (random_Number[writing_turn] == 76)
			Turner = "Týlsým Kraliçesi";
		else if (random_Number[writing_turn] == 77)
			Turner = "Týlsým Kralý";
		else
			Turner = "Error";
		return Turner;
	}

	public void OneCardFunc()
	{
		WouldYouWant = true;
		HowMuchCardYouWant = 1;
	}
	public void TwoCardFunc()
	{
		WouldYouWant = true;
		HowMuchCardYouWant = 2;
	}
	public void ThreeCardFunc()
	{
		WouldYouWant = true;
		HowMuchCardYouWant = 3;
	}
	public void FourCardFunc()
	{
		WouldYouWant = true;
		HowMuchCardYouWant = 4;
	}
	public void FiveCardFunc()
	{
		WouldYouWant = true;
		HowMuchCardYouWant = 5;
	}
	public void SixCardFunc()
	{
		WouldYouWant = true;
		HowMuchCardYouWant = 6;
	}
	public void SevenCardFunc()
	{
		WouldYouWant = true;
		HowMuchCardYouWant = 7;
	}
	public void EightCardFunc()
	{
		WouldYouWant = true;
		HowMuchCardYouWant = 8;
	}
}
