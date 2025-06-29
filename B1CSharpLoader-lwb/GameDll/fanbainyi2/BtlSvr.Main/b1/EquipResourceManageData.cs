using System.Collections.Generic;

namespace b1;

public class EquipResourceManageData
{
	public Dictionary<string, bool> Resources;

	public bool bStartTickingForUnload;

	public float RemainingTime;

	public bool bForceUnload;

	public EquipResourceManageData(string Path)
	{
		Resources = new Dictionary<string, bool> { { Path, false } };
	}

	public void AddPath(string Path)
	{
		if (!Resources.ContainsKey(Path))
		{
			Resources.Add(Path, value: false);
		}
	}

	public void OnResourceLoaded(string Path)
	{
		if (Resources.ContainsKey(Path))
		{
			Resources[Path] = true;
		}
	}
}
