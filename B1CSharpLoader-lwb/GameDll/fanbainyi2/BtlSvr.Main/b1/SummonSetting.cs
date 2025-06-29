using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.SummonSetting")]
public struct SummonSetting
{
	[EditAnywhere]
	[UProperty]
	[Tooltip("召唤ID")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.SummonSetting:SummonID")]
	public int SummonID;

	[UProperty]
	[BlueprintReadWrite]
	[Tooltip("百分比权重")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.SummonSetting:SummonWeight")]
	public float SummonWeight;

	[UProperty]
	[BlueprintReadWrite]
	[Tooltip("同SummonUnit效果里的第二个整形参数")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.SummonSetting:SummonPointIndex")]
	public int SummonPointIndex;

	private static int SummonSetting_StructSize;

	public SummonSetting Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.SummonSetting");
		SummonSetting_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(SummonSetting));
	}

	static SummonSetting()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(SummonSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(SummonSetting));
	}
}
