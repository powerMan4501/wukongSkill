using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.AutoSizeScrollData")]
public struct AutoSizeScrollData
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSProperty|Scroll")]
	[Tooltip("开始回弹速度")]
	[USharpPath("/Script/b1-Managed.AutoSizeScrollData:StopSpeed")]
	public float StopSpeed;

	[UProperty]
	[EditAnywhere]
	[Category("GSProperty|Scroll")]
	[Tooltip("吸附加速度")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AutoSizeScrollData:Acceleration")]
	public float Acceleration;

	[BlueprintReadWrite]
	[Category("GSProperty|Scroll")]
	[Tooltip("选中时滚动时间(一格)")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AutoSizeScrollData:ScrollTime")]
	public float ScrollTime;

	[Tooltip("吸附时间")]
	[Category("GSProperty|Scroll")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AutoSizeScrollData:AttractTime")]
	public float AttractTime;

	private static int AutoSizeScrollData_StructSize;

	public AutoSizeScrollData Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.AutoSizeScrollData");
		AutoSizeScrollData_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(AutoSizeScrollData));
	}

	static AutoSizeScrollData()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(AutoSizeScrollData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AutoSizeScrollData));
	}
}
