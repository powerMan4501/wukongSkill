using System;

namespace b1.UI;

public struct AnimFinishConfig
{
	public string AnimName;

	public float AnimLength;

	public Action Evt_Finish;
}
