using UnityEngine;
using UnityEngine.UI;

public class BodyPartList : MonoBehaviour
{
	public void OnBodyPartClicked(Image bodyPart)
	{
		bodyPart.color = Color.white;
	}
}
