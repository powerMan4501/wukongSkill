using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.TreeInfo")]
public struct FTreeInfo
{
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TreeInfo:Bounds_WithScaled")]
	public FVector Bounds_WithScaled;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TreeInfo:Pos")]
	public FVector Pos;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TreeInfo:Rot")]
	public FRotator Rot;

	private static int TreeInfo_StructSize;

	public FTreeInfo Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.TreeInfo");
		TreeInfo_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FTreeInfo));
	}

	static FTreeInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FTreeInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTreeInfo));
	}
}
