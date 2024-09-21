using UnityEngine;
using System.Collections;

public class ExampleBehaviourScript : MonoBehaviour
{
  void Update()
  {
      if (Input.GetKeyDown(KeyCode.R))
      {
          GetComponent<Renderer> ().material.color = Color.red;
      }
  }
}
