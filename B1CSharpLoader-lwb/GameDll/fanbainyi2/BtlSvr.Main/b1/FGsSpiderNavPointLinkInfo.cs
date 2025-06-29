using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.GsSpiderNavPointLinkInfo")]
public struct FGsSpiderNavPointLinkInfo
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GsSpiderNavPointLinkInfo:LinkPointIndex")]
	public int LinkPointIndex;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GsSpiderNavPointLinkInfo:Cost")]
	public float Cost;

	private static int GsSpiderNavPointLinkInfo_StructSize;

	public FGsSpiderNavPointLinkInfo Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.GsSpiderNavPointLinkInfo");
		GsSpiderNavPointLinkInfo_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FGsSpiderNavPointLinkInfo));
	}

	static FGsSpiderNavPointLinkInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGsSpiderNavPointLinkInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGsSpiderNavPointLinkInfo));
	}
}
