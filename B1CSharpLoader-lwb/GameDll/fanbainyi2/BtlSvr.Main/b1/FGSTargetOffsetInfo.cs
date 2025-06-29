using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FGSTargetOffsetInfo
{
	public ProjectilePosOffsetType PosOffsetType;

	public ProjectilePosOffsetSpace OffsetSpace;

	public ProjectileBaseType BaseType;

	public bool UseSocket;

	public FName SocketName;

	public FVector PosOffset;

	public FRangePointSetRule RangeOffsetInfo;

	public float VerticalOffset_World;

	public bool HasCachedRangeOffset;

	public FVector CachedRangeOffset;

	public TStrongObjectPtr<AActor> BaseActor;

	public FGSTargetOffsetInfo()
	{
		BaseActor = new TStrongObjectPtr<AActor>();
	}

	public FGSTargetOffsetInfo(ProjectilePosOffsetStruct PosOffsetStruct)
	{
		PosOffsetType = PosOffsetStruct.PosOffsetType;
		OffsetSpace = PosOffsetStruct.OffsetSpace;
		BaseType = PosOffsetStruct.BaseType;
		UseSocket = PosOffsetStruct.UseSocket;
		SocketName = PosOffsetStruct.SocketName;
		PosOffset = PosOffsetStruct.PosOffset;
		RangeOffsetInfo = PosOffsetStruct.RangeOffsetInfo;
		VerticalOffset_World = PosOffsetStruct.VerticalOffset_World;
		HasCachedRangeOffset = false;
		CachedRangeOffset = FVector.ZeroVector;
		BaseActor = new TStrongObjectPtr<AActor>();
		BaseActor.Set(PosOffsetStruct.BaseActor?.Get());
	}

	public FGSTargetOffsetInfo(FGSTargetOffsetInfo PosOffsetStruct)
	{
		PosOffsetType = PosOffsetStruct.PosOffsetType;
		OffsetSpace = PosOffsetStruct.OffsetSpace;
		BaseType = PosOffsetStruct.BaseType;
		UseSocket = PosOffsetStruct.UseSocket;
		SocketName = PosOffsetStruct.SocketName;
		PosOffset = PosOffsetStruct.PosOffset;
		RangeOffsetInfo = PosOffsetStruct.RangeOffsetInfo;
		VerticalOffset_World = PosOffsetStruct.VerticalOffset_World;
		HasCachedRangeOffset = PosOffsetStruct.HasCachedRangeOffset;
		CachedRangeOffset = PosOffsetStruct.CachedRangeOffset;
		BaseActor = new TStrongObjectPtr<AActor>();
		BaseActor.Set(PosOffsetStruct.BaseActor?.Get());
	}
}
