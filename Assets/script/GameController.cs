using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
	public UnityEngine.UI.Text scoreLabelA;

    public GameObject winnerLabelObject;

    public void Update ()
    {
        int count = GameObject.FindGameObjectsWithTag ("Item").Length;
		scoreLabelA.text = count.ToString ();

        if(count == 0){
            winnerLabelObject.SetActive (true);
        }
    }
}