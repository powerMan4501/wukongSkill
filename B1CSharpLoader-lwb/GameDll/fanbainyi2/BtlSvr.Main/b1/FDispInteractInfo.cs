using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.DispInteractInfo")]
public struct FDispInteractInfo
{
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispInteractInfo:FirstPos")]
	public FVector FirstPos;

	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispInteractInfo:NextPos")]
	public FVector NextPos;

	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispInteractInfo:FirstRadius")]
	public float FirstRadius;

	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispInteractInfo:NextRadius")]
	public float NextRadius;

	private static int DispInteractInfo_StructSize;

	public void ValidData()
	{
		if (FirstPos.X - NextPos.X <= 0.0001f && FirstPos.Y - NextPos.Y <= 0.0001f)
		{
			NextPos += 0.10000000149011612;
		}
	}

	public FDispInteractInfo Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.DispInteractInfo");
		DispInteractInfo_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FDispInteractInfo));
	}

	static FDispInteractInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FDispInteractInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDispInteractInfo));
	}
}
