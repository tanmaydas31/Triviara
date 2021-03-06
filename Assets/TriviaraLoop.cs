﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class TriviaraLoop : MonoBehaviour {

    public struct Question {
        public string questionText;
        public string[] answers;
        public int correctAnswerIndex;

        public Question(string questionText, string[] answers, int correctAnswerIndex) {
            this.questionText = questionText;
            this.answers = answers;
            this.correctAnswerIndex = correctAnswerIndex;
        }
    }

	public Text questionText;
	public Button[] answerButton;

	public Question currentQuestion = new Question("What is your favourite colour ?", new string[] { "Blue", "Red", "Yellow", "Green", "Black"}, 1);


	// Use this for initialization
	void Start () {
		assignQuestion ();
	}

	// Update is called once per frame
	void Update () {
	
	}

	void assignQuestion() {
		questionText.text = currentQuestion.questionText;
		for (int i = 0; i < answerButton.Length; i++) {
			answerButton [i].GetComponentInChildren<Text> ().text = currentQuestion.answers [i];
		}
	}

	public void checkAnswer(int answerButtonIndex){
		if (answerButtonIndex == currentQuestion.correctAnswerIndex)
			print ("CORRECT !");
		else
			print ("INCORRECT !");
	}
}
