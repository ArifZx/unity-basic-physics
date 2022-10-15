using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physicsbehavooud : MonoBehaviour
{
  void OnCollisionEnter(Collision other)
  {
    // enter -> stay -> exit
    Debug.Log($"Physics enter {other.gameObject.tag}");
  }

  void OnCollisionStay(Collision collisionInfo)
  {
    // enter -> stay -> exit
    Debug.Log("Physics stay");
  }

  void OnCollisionExit(Collision collisionInfo)
  {
    // enter -> stay -> exit
    Debug.Log("Physics exit");
  }



  void OnTriggerEnter(Collider other)
  {
    Debug.Log("Trigger enter");
  }

  void OnTriggerStay(Collider other)
  {
    Debug.Log("Trigger stay");
  }

  void OnTriggerExit(Collider other)
  {
    Debug.Log("Trigger exit");
  }
}
