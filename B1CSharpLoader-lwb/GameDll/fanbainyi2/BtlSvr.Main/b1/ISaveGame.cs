using System.Collections.Generic;

namespace b1;

public interface ISaveGame
{
	void OnInit();

	bool SaveDataToSlot(List<byte> InSaveData, string SlotName, string UserId);

	bool LoadDataFromSlot(out List<byte> OutSaveData, string SlotName, string UserId);

	bool DoesSaveGameExist(string SlotName, string UserId);

	bool DeleteGameInSlot(string SlotName, string UserId);
}
