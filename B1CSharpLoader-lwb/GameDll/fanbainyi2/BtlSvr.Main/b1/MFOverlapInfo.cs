using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public struct MFOverlapInfo
{
	public UPrimitiveComponent OverlappedComp { get; set; }

	public TStrongObjectPtr<AActor> OtherActor { get; set; }

	public MFOverlapInfo(UPrimitiveComponent InOverlappedComp, AActor InOtherActor)
	{
		OverlappedComp = InOverlappedComp;
		OtherActor = new TStrongObjectPtr<AActor>(InOtherActor);
	}
}
