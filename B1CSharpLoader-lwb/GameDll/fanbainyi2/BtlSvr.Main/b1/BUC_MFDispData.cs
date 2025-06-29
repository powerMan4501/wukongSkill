using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_MFDispData : IBUC_MFDispData
{
	public bool bEnableShelterRT { get; set; }

	public bool bUseGlobalFX { get; set; }

	public FName FXTag { get; set; }

	public bool IsSphereMF { get; set; }

	public USphereComponent SphereComp { get; set; }
}
