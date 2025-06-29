using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 57857)]
[BlueprintType]
[UMetaPath("/Script/b1.ItemGenerationInfo", "b1", UnrealModuleType.Game)]
public struct FItemGenerationInfo
{
	private static int FItemGenerationInfo_StructSize;

	public FItemGenerationInfo Copy()
	{
		return this;
	}

	static FItemGenerationInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FItemGenerationInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FItemGenerationInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1.ItemGenerationInfo");
		FItemGenerationInfo_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FItemGenerationInfo));
	}
}
