using UnrealEngine.Engine;

namespace b1;

public abstract class BGU_PropMgrType_Mesh : BGU_PropMgrTypeBase
{
	protected USkeletalMeshComponent MeshComp { get; set; }

	protected BGU_PropMgrType_Mesh(USkeletalMeshComponent InMeshComp)
	{
		MeshComp = InMeshComp;
	}
}
