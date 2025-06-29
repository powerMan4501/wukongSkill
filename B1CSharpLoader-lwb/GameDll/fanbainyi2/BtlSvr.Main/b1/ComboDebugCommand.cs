using System.Collections.Generic;
using System.IO;
using LitJson;
using UnrealEngine.Runtime;

namespace b1;

public class ComboDebugCommand
{
	public string CasterID;

	public bool DisableCBG;

	public List<ComboDebugConfig> Combo;

	private string PERSISTENT_DATA_PATH = FPaths.Combine(FPaths.ConvertRelativePathToFull(FPaths.ProjectDir), "Saved/Config/WindowsEditor/ComboDebugger.json");

	public void LoadFromDisk()
	{
		if (File.Exists(PERSISTENT_DATA_PATH))
		{
			ComboDebugCommand comboDebugCommand = JsonMapper.ToObject<ComboDebugCommand>(File.ReadAllText(PERSISTENT_DATA_PATH));
			if (comboDebugCommand != null)
			{
				CasterID = comboDebugCommand.CasterID;
				DisableCBG = comboDebugCommand.DisableCBG;
				Combo = comboDebugCommand.Combo;
			}
		}
	}

	public void LoadFromString(string JsonStr)
	{
		ComboDebugCommand comboDebugCommand = JsonMapper.ToObject<ComboDebugCommand>(JsonStr);
		if (comboDebugCommand != null)
		{
			CasterID = comboDebugCommand.CasterID;
			DisableCBG = comboDebugCommand.DisableCBG;
			Combo = comboDebugCommand.Combo;
		}
	}

	public void SaveToDisk()
	{
		if (!File.Exists(PERSISTENT_DATA_PATH))
		{
			File.Create(PERSISTENT_DATA_PATH).Close();
		}
		File.WriteAllText(PERSISTENT_DATA_PATH, ToJson());
	}

	public string ToJson()
	{
		return JsonMapper.ToJson(this);
	}
}
