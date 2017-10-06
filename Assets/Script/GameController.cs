using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
g
public class GameController : MonoBehaviour {

	public InputField guessingNumber;
	public Text guessedNumber;
	private int guessnumber;
	private int userNumber;

	// Use this for initialization
	void Start () {
		guessnumber = Random.Range (1, 100);

	}

	public void checkGuess(){
		userNumber = int.Parse(guessingNumber.text);
		if(userNumber == guessnumber){
			guessedNumber.text = "Keren! Tebakan mu benar..";
		}else if(userNumber > guessnumber){
			guessedNumber.text = "Kegedean tabakannya";
		}else if(userNumber < guessnumber){
			guessedNumber.text = "Kekecilan tebakannya";
		}

		guessingNumber.text = "";
	}
}
