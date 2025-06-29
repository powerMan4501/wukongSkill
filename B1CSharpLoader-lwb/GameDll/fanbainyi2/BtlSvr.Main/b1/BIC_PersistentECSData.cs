using Google.Protobuf.Collections;
using GurGsPersistent;

namespace b1;

public class BIC_PersistentECSData : IBIC_PersistentECSData
{
	public PersistentECSData PersistentECSData = BGU_DataUtil.GenNewPersistentECSData();

	public PersistentBUCDataCollection PersistentBUCData;

	public bool FindOrAllocBUCDataByGuid(string Guid, out PersistentBUCData Ret)
	{
		if (!GSEUtil.Ensure(!string.IsNullOrEmpty(Guid), "FindOrAllocBUCDataByGuid IsNullOrEmpty(Guid)"))
		{
			Ret = null;
			return false;
		}
		if (PersistentBUCData == null)
		{
			PersistentBUCData = new PersistentBUCDataCollection();
			PersistentBUCData.PersistentBUCDataWithLevel = new PersistentBUCDataWithLevel();
			PersistentECSData.BUCData.Add(PersistentBUCData.PersistentBUCDataWithLevel);
		}
		if (PersistentBUCData.BUCDatasMap.TryGetValue(Guid, out Ret))
		{
			return true;
		}
		Ret = new PersistentBUCData();
		Ret.Guid = Guid;
		PersistentBUCData.BUCDatasMap.Add(Guid, Ret);
		PersistentBUCData.PersistentBUCDataWithLevel.BUCData.Add(Ret);
		return false;
	}

	public bool FindBUCDataByGuid(string Guid, int LevelID, out PersistentBUCData Ret)
	{
		if (!GSEUtil.Ensure(!string.IsNullOrEmpty(Guid), "FindBUCDataByGuid IsNullOrEmpty(Guid)"))
		{
			Ret = null;
			return false;
		}
		if (PersistentBUCData != null && PersistentBUCData.BUCDatasMap.TryGetValue(Guid, out Ret))
		{
			return true;
		}
		Ret = null;
		return false;
	}

	public PersistentBGCData GetPersistentBGCData()
	{
		return PersistentECSData.BGCData;
	}

	public PersistentBPCData GetPersistentBPCData()
	{
		return PersistentECSData.BPCData;
	}

	public bool BUCDataNeedResetOnNewGamePlus(PersistentBUCData BUCData)
	{
		if (BUCData.BUCActorInitData != null)
		{
			return !BUCData.BUCActorInitData.PersistentDataDontResetOnNewGamePlus;
		}
		return true;
	}

	public void RecoverECSData(PersistentECSData PersistentECSData)
	{
		if (PersistentECSData == null)
		{
			BGW_LogUtil.LogError("BIC_PersistentECSData RecoverECSData PersistentECSData == null");
			Reset();
			return;
		}
		PersistentBUCData = null;
		this.PersistentECSData = PersistentECSData;
		foreach (PersistentBUCDataWithLevel bUCDatum in PersistentECSData.BUCData)
		{
			PersistentBUCData = new PersistentBUCDataCollection();
			PersistentBUCData.PersistentBUCDataWithLevel = bUCDatum;
			foreach (PersistentBUCData bUCDatum2 in bUCDatum.BUCData)
			{
				PersistentBUCData.BUCDatasMap.Add(bUCDatum2.Guid, bUCDatum2);
			}
		}
	}

	public void Reset()
	{
		PersistentECSData = BGU_DataUtil.GenNewPersistentECSData();
		PersistentBUCData = null;
	}

	public void ResetOnNewGamePlus()
	{
		GurGsPersistent.BGC_PlayerGuideData bGCPlayerGuideData = GetPersistentBGCData().BGCPlayerGuideData;
		GurGsPersistent.BGC_PlayerDeathData bGCPlayerDeathData = GetPersistentBGCData().BGCPlayerDeathData;
		GurGsPersistent.BPC_GeoInfoData bPCGeoInfoData = GetPersistentBPCData().BPCGeoInfoData;
		bGCPlayerDeathData.ChapterDeathDict.Clear();
		PersistentECSData.BGCData = BGU_DataUtil.GenNewPersistentBGCData();
		PersistentECSData.BPCData = BGU_DataUtil.GenNewPersistentBPCData();
		PersistentBUCData = null;
		PersistentECSData.BGCData.BGCPlayerGuideData = bGCPlayerGuideData;
		PersistentECSData.BGCData.BGCPlayerDeathData = bGCPlayerDeathData;
		PersistentECSData.BPCData.BPCGeoInfoData = bPCGeoInfoData;
		RepeatedField<PersistentBUCDataWithLevel> repeatedField = PersistentECSData.BUCData.Clone();
		PersistentECSData.BUCData.Clear();
		foreach (PersistentBUCDataWithLevel item in repeatedField)
		{
			foreach (PersistentBUCData bUCDatum in item.BUCData)
			{
				if (!BUCDataNeedResetOnNewGamePlus(bUCDatum))
				{
					FindOrAllocBUCDataByGuid(bUCDatum.Guid, out var Ret);
					Ret.MergeFrom(bUCDatum);
				}
			}
		}
	}
}
