using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.ScrollInputData")]
public struct ScrollInputData
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("鼠标滚轮输入时间")]
	[USharpPath("/Script/b1-Managed.ScrollInputData:KeyboardInputTime")]
	public float KeyboardInputTime;

	[UProperty]
	[BlueprintReadWrite]
	[Tooltip("鼠标滚轮滑动速率")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.ScrollInputData:KeyboardScrollMultiplier")]
	public float KeyboardScrollMultiplier;

	[Tooltip("手柄摇杆输入时间")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.ScrollInputData:GamepadInputTime")]
	public float GamepadInputTime;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("手柄摇杆初始速率")]
	[USharpPath("/Script/b1-Managed.ScrollInputData:GamepadScrollOriSpeed")]
	public float GamepadScrollOriSpeed;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("手柄摇杆滑动速率")]
	[USharpPath("/Script/b1-Managed.ScrollInputData:GamepadScrollMultiplier")]
	public float GamepadScrollMultiplier;

	private static int ScrollInputData_StructSize;

	public ScrollInputData Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.ScrollInputData");
		ScrollInputData_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(ScrollInputData));
	}

	static ScrollInputData()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(ScrollInputData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ScrollInputData));
	}
}
