using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.ProcBarConfig")]
public struct FProcBarConfig
{
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("默认值")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ProcBarConfig:DefValue")]
	public float DefValue;

	[EditAnywhere]
	[DisplayName("最大值")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ProcBarConfig:MaxValue")]
	public float MaxValue;

	private static int ProcBarConfig_StructSize;

	public FProcBarConfig Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.ProcBarConfig");
		ProcBarConfig_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FProcBarConfig));
	}

	static FProcBarConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FProcBarConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FProcBarConfig));
	}
}
