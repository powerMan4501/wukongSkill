using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.FSCDCollisionInfo")]
public struct FSCDCollisionInfo
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("放大系数")]
	[USharpPath("/Script/b1-Managed.FSCDCollisionInfo:ScaleRate")]
	public float ScaleRate;

	[Tooltip("单位：秒")]
	[DisplayName("停留时间")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FSCDCollisionInfo:KeepTime")]
	public float KeepTime;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("展示颜色")]
	[USharpPath("/Script/b1-Managed.FSCDCollisionInfo:CollisionColor")]
	public FColor CollisionColor;

	private static int FSCDCollisionInfo_StructSize;

	public FSCDCollisionInfo Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.FSCDCollisionInfo");
		FSCDCollisionInfo_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FSCDCollisionInfo));
	}

	static FSCDCollisionInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FSCDCollisionInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSCDCollisionInfo));
	}
}
