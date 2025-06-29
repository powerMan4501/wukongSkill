using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.ObstacleCheckPointWeight")]
public struct FObstacleCheckPointWeight
{
	[DisplayName("与X轴的夹角")]
	[UProperty]
	[Tooltip("顺时针方向为正，逆时针为负")]
	[BlueprintReadOnly]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.ObstacleCheckPointWeight:Angle")]
	public float Angle;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("权重")]
	[Tooltip("单个点的权重")]
	[USharpPath("/Script/b1-Managed.ObstacleCheckPointWeight:Weight")]
	public float Weight;

	private static int ObstacleCheckPointWeight_StructSize;

	public FObstacleCheckPointWeight Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.ObstacleCheckPointWeight");
		ObstacleCheckPointWeight_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FObstacleCheckPointWeight));
	}

	static FObstacleCheckPointWeight()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FObstacleCheckPointWeight)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FObstacleCheckPointWeight));
	}
}
