using UnityEngine;
using System.Collections;

public class DeahtMenuBehaviourScript : MenuBehaviour {

	void Start () {
		// Devemos colocar o nome do jogador perdedor
		TextMesh textMesh = transform.FindChild ("Texts").FindChild ("defeatedPlayerText").GetComponent<TextMesh> ();
		textMesh.text = ApplicationData.defeatedPlayerName + " lost";
	}
	
	public override void TreatClickEvent (string buttonName, Transform button) {
		switch (buttonName) {
		case "retryButton":
			Application.LoadLevel("Match");
			break;
		case "mainMenuButton":
			Application.LoadLevel ("MainMenu");
			break;
		}
	}

}
