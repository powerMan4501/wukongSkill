using GUR.Runtime;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ActorTransformInfoData : IBUC_ActorTransformInfoData
{
	public AActor Owner;

	[GSGameDataSnapShot]
	public bool NeedUpdate { get; set; }

	[GSGameDataSnapShot]
	public FTransform OriginTransform { get; set; }

	[GSGameDataSnapShot]
	public FTransform NextUpdateTransform { get; set; }

	[GSGameDataSnapShot]
	public bool bSweep { get; set; }

	[GSGameDataSnapShot]
	public bool bTeleport { get; set; }

	public BUC_ActorTransformInfoData()
	{
		NeedUpdate = false;
		OriginTransform = FTransform.Default;
		NextUpdateTransform = FTransform.Default;
		bSweep = false;
		bTeleport = false;
	}

	public void InitOwnerActor(AActor _Owner)
	{
		Owner = _Owner;
	}

	public bool GetNextUpdateTransform(out FTransform OutTransform)
	{
		bool result = false;
		OutTransform = FTransform.Default;
		if (NeedUpdate)
		{
			result = true;
			OutTransform = NextUpdateTransform;
		}
		else if (!Owner.IsNullFastCheck())
		{
			result = true;
			ActorFuncLib.GetActorTransformSimple(Owner.Address, out OutTransform);
		}
		return result;
	}

	public bool GetNextUpdateLocation(out FVector OutLocation)
	{
		bool result = false;
		OutLocation = FVector.ZeroVector;
		if (NeedUpdate)
		{
			result = true;
			OutLocation = NextUpdateTransform.GetLocation();
		}
		else if (!Owner.IsNullFastCheck())
		{
			result = true;
			ActorFuncLib.GetActorLocationSimple(Owner.Address, out OutLocation);
		}
		return result;
	}

	public bool GetNextUpdateRotation(out FRotator OutRotator)
	{
		bool result = false;
		OutRotator = FRotator.ZeroRotator;
		if (NeedUpdate)
		{
			result = true;
			OutRotator = NextUpdateTransform.GetRotation().Rotator();
		}
		else if (Owner != null)
		{
			result = true;
			ActorFuncLib.GetActorRotationSimple(Owner.Address, out OutRotator);
		}
		return result;
	}
}
