using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

  public Text countText;
  public Text winText;
  private int count;

  void Start ()
  {
      count = 0;
      SetCountText();
      winText.text = "";
  }

  void OnTriggerEnter(Collider other)
  {
      if (other.gameObject.CompareTag ( "Pick Up"))
      {
          count = count + 1;
          SetCountText ();
      }
  }

  void SetCountText ()
  {
      countText.text = "Count: " + count.ToString ();
      if (count >= 12)
      {
          winText.text = "You Win!";
      }
  }
}
