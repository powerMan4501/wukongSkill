using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public static class BGUFuncLibComponentCS
{
	public static FVector BGUGetSocketLocation(this USceneComponent Comp, ref FName SocketName)
	{
		return SceneComponentFuncLib.GetSocketLocation(Comp.Address, ref SocketName);
	}

	public static FRotator BGUGetSocketRotation(this USceneComponent Comp, ref FName SocketName)
	{
		return SceneComponentFuncLib.GetSocketRotation(Comp.Address, ref SocketName);
	}

	public static FTransform BGUGetSocketTransform(this USceneComponent Comp, ref FName SocketName, ERelativeTransformSpace TransformSpace = ERelativeTransformSpace.RTS_World)
	{
		return SceneComponentFuncLib.GetSocketTransform(Comp.Address, ref SocketName, TransformSpace);
	}

	public static void BGUSetWorldLocationAndRotation(this USceneComponent Comp, FVector Location, FRotator Rotation)
	{
		SceneComponentFuncLib.SetWorldLocationAndRotationSimple(Comp.Address, Location, Rotation);
	}

	public static FVector BGUFindLocationClosestToWorldLocation(this USplineComponent SplineComp, FVector WorldLocation, bool bLocalSpace)
	{
		return SplineComponentFuncLib.FindLocationClosestToWorldLocation(SplineComp.Address, WorldLocation, bLocalSpace);
	}

	public static FVector BGUFindRightVectorClosestToWorldLocation(this USplineComponent SplineComp, FVector WorldLocation, bool bLocalSpace)
	{
		return SplineComponentFuncLib.FindRightVectorClosestToWorldLocation(SplineComp.Address, WorldLocation, bLocalSpace);
	}
}
