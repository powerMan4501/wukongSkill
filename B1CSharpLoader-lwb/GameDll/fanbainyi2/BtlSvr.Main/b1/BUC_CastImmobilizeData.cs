using System;
using System.Collections.Generic;
using BtlB1;

namespace b1;

public class BUC_CastImmobilizeData
{
	public Dictionary<int, FUStImmobilizeSkillConfigDesc> ImmobilizeConfigCache { get; } = new Dictionary<int, FUStImmobilizeSkillConfigDesc>();

	public int ResId { get; set; }

	public FUStImmobilizeSkillConfigDesc GetCachedImmobilizeConfigDesc(int ConfigID)
	{
		if (ImmobilizeConfigCache.TryGetValue(ConfigID, out var value))
		{
			return value;
		}
		FUStImmobilizeSkillConfigDesc immobilizeSkillConfigDesc = BGW_GameDB.GetImmobilizeSkillConfigDesc(ConfigID);
		if (immobilizeSkillConfigDesc != null)
		{
			FUStImmobilizeSkillConfigDesc fUStImmobilizeSkillConfigDesc = BGU_DeepCopyUtil.Copy(immobilizeSkillConfigDesc);
			ImmobilizeConfigCache[ConfigID] = fUStImmobilizeSkillConfigDesc;
			return fUStImmobilizeSkillConfigDesc;
		}
		return null;
	}
}
