using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1;

public class ConsolePlatformSDKSaveGame : ISaveGame
{
	public bool LoadDataFromSlot(out List<byte> OutSaveData, string SlotName, string UserId)
	{
		if (UGSE_SaveGameFuncLib.LoadDataFromSlot(out OutSaveData, SlotName, 0))
		{
			return true;
		}
		return false;
	}

	public bool SaveDataToSlot(List<byte> InSaveData, string SlotName, string UserId)
	{
		return UGSE_SaveGameFuncLib.SaveDataToSlot(InSaveData, SlotName, 0);
	}

	public bool DeleteGameInSlot(string SlotName, string UserId)
	{
		return UGameplayStatics.DeleteGameInSlot(SlotName, 0);
	}

	public bool DoesSaveGameExist(string SlotName, string UserId)
	{
		return UGameplayStatics.DoesSaveGameExist(SlotName, 0);
	}

	public void OnInit()
	{
	}
}
