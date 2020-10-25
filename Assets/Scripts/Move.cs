﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
  public Vector3 Direction;

  private Global GlobalRef;

  // Start is called before the first frame update
  void Start()
  {
    GlobalRef = GameObject.FindObjectOfType<Global>();
    InvokeRepeating("SpeedUp", 0f, 2f);
  }

  // Update is called once per frame
  void Update()
  {
    transform.Translate(GlobalRef.Speed * Direction * Time.deltaTime);
  }

  void SpeedUp()
  {
    GlobalRef.Speed += (Time.deltaTime / 2);
  }
}
