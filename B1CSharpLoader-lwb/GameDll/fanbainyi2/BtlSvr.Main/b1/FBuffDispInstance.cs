using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class FBuffDispInstance
{
	public long InstanceID { get; set; }

	public int BuffID { get; set; }

	public int BuffDispGroupID { get; set; }

	public EBuffDispType DispType { get; set; }

	public FUStBuffDispDesc BuffDispDesc { get; set; }

	public List<int> BuffsInGroup { get; } = new List<int>();

	public List<UFXSystemComponent> PlayingBuffFXs { get; } = new List<UFXSystemComponent>();

	public List<int> PlayingBuffDispConfigRequestIDs { get; } = new List<int>();

	public List<BuffDispTickData> PlayingBuffTickDataList { get; } = new List<BuffDispTickData>();

	public static long GenerateInstanceID(int InBuffID, EBuffDispType InDispType = EBuffDispType.Buff, int InBuffDispGroupID = 0)
	{
		return ((long)InBuffDispGroupID << 34) + ((long)InDispType << 32) + InBuffID;
	}

	public int GetMaterialUniqueIndexBase()
	{
		switch (DispType)
		{
		case EBuffDispType.None:
		case EBuffDispType.Buff:
		case EBuffDispType.SingleInGroup:
			return BuffID * 100 + (int)(DispType - 1) * 30;
		case EBuffDispType.Group:
			return BuffDispGroupID * 100 + (int)(DispType - 1) * 30;
		default:
			return (int)(DispType - 1) * 30;
		}
	}
}
