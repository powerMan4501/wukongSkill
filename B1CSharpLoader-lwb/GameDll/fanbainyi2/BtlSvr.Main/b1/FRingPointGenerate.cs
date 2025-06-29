using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.RingPointGenerate")]
public struct FRingPointGenerate
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("内圈半径")]
	[Category("RingPointGenerate")]
	[USharpPath("/Script/b1-Managed.RingPointGenerate:MinR")]
	public float MinR;

	[DisplayName("外圈半径")]
	[Category("RingPointGenerate")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.RingPointGenerate:MaxR")]
	public float MaxR;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("分割环数")]
	[Category("RingPointGenerate")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.RingPointGenerate:RingNum")]
	public int RingNum;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("单环点数")]
	[Category("RingPointGenerate")]
	[USharpPath("/Script/b1-Managed.RingPointGenerate:PointNumPerRing")]
	public int PointNumPerRing;

	private static int RingPointGenerate_StructSize;

	public FRingPointGenerate Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.RingPointGenerate");
		RingPointGenerate_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FRingPointGenerate));
	}

	static FRingPointGenerate()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FRingPointGenerate)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRingPointGenerate));
	}
}
