using UnrealEngine.Engine;

namespace b1;

public interface IBUC_MFDispData
{
	bool IsSphereMF { get; }

	USphereComponent SphereComp { get; }
}
