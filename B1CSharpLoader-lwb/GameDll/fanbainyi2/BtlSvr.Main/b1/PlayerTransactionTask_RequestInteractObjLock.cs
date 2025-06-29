using Google.Protobuf.Collections;
using GUR.Runtime;
using GurGsStruct;

namespace b1;

[ReplicateData]
public class PlayerTransactionTask_RequestInteractObjLock : PlayerTransactionTaskBase
{
	public override void RefreshGetDeltaDataFunc(bool IsActive)
	{
		base.RefreshGetDeltaDataFunc(IsActive);
	}

	public override int GetGSRepSubClassIdx()
	{
		return 0;
	}

	public override void DumpFull(RepeatedField<ClassDeltaMsgPlayerTransactionTaskBase> Data)
	{
		base.DumpFull(Data);
	}
}
