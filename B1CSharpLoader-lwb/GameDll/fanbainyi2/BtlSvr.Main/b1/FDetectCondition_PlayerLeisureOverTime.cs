using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.DetectCondition_PlayerLeisureOverTime")]
public struct FDetectCondition_PlayerLeisureOverTime
{
	[EditAnywhere]
	[DisplayName("怠惰时长")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DetectCondition_PlayerLeisureOverTime:PlayerLeisureOverTime")]
	public float PlayerLeisureOverTime;

	private static int DetectCondition_PlayerLeisureOverTime_StructSize;

	public FDetectCondition_PlayerLeisureOverTime Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.DetectCondition_PlayerLeisureOverTime");
		DetectCondition_PlayerLeisureOverTime_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FDetectCondition_PlayerLeisureOverTime));
	}

	static FDetectCondition_PlayerLeisureOverTime()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FDetectCondition_PlayerLeisureOverTime)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDetectCondition_PlayerLeisureOverTime));
	}
}
