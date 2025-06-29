using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_StriderMove")]
public struct FAnimHumanoidSetting_StriderMove
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("停步rootmovetion时间")]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_StriderMove:StriderStopTime")]
	public float StriderStopTime;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("停步rootmovetion距离")]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_StriderMove:StriderStopDistance")]
	public float StriderStopDistance;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("鬼畜停步开始时间")]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_StriderMove:StriderLoopAnimTimeStart")]
	public float StriderLoopAnimTimeStart;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[DisplayName("鬼畜停步间隔时间")]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_StriderMove:StriderGuiChuTime")]
	public float StriderGuiChuTime;

	[UProperty]
	[EditAnywhere]
	[DisplayName("单点判断时间")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_StriderMove:StriderSingleStep")]
	public float StriderSingleStep;

	private static int AnimHumanoidSetting_StriderMove_StructSize;

	public FAnimHumanoidSetting_StriderMove Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_StriderMove");
		AnimHumanoidSetting_StriderMove_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FAnimHumanoidSetting_StriderMove));
	}

	static FAnimHumanoidSetting_StriderMove()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_StriderMove)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_StriderMove));
	}
}
