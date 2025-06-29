using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.FGSBuffInfo")]
public struct FGSBuffInfo
{
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FGSBuffInfo:BuffID")]
	public int BuffID;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Buff持续时间(毫秒)")]
	[Tooltip("-1:不移除 ； 0：读Buff表中配置")]
	[USharpPath("/Script/b1-Managed.FGSBuffInfo:BuffDuration")]
	public int BuffDuration;

	private static int FGSBuffInfo_StructSize;

	public FGSBuffInfo Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.FGSBuffInfo");
		FGSBuffInfo_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FGSBuffInfo));
	}

	static FGSBuffInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSBuffInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSBuffInfo));
	}
}
