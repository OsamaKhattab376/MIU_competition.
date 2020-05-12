using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loadscene : MonoBehaviour
{
	public void next(string scenename )
	{
		Application.LoadLevel(scenename);

	}

}
