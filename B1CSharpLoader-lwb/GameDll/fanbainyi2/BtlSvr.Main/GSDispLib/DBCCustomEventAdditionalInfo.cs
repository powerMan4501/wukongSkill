using UnrealEngine.Engine;

namespace GSDispLib;

public struct DBCCustomEventAdditionalInfo
{
	public USceneComponent SourceDispOwnerComp;

	public USceneComponent MinorDispOwnerComp;

	public uint ANID;

	public uint MontageUniqueID;

	public DBCTransformParam DBCTransform;

	public DBCCustomEventAdditionalInfo(USceneComponent _SourceDispOwnerComp, USceneComponent _MinorDispOwnerComp, uint _ANID = 0u, uint _MontageUniqueID = 0u, DBCTransformParam _DBCTransform = default(DBCTransformParam))
	{
		SourceDispOwnerComp = _SourceDispOwnerComp;
		MinorDispOwnerComp = _MinorDispOwnerComp;
		ANID = _ANID;
		MontageUniqueID = _MontageUniqueID;
		DBCTransform = _DBCTransform;
	}
}
