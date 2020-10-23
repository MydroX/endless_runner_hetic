using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

  private float score = 0.0f;
  public Text scoreText;

  // Update score on every frame
  void Update()
  {
    score += Time.deltaTime;
    scoreText.text = "SCORE : " + ((int)score).ToString();
  }
}
