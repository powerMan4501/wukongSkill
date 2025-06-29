using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

public abstract class DBCIdentityInfoBase
{
	public USceneComponent SourceDispOwnerComp { get; set; }

	public uint IdentityID { get; protected set; }

	public uint AnimNotifyUniqueID { get; protected set; }

	public uint MontageUniqueID { get; protected set; }

	public uint OwnerActorUniqueID { get; protected set; }

	public abstract bool CheckHasTag(FName Tag);
}
