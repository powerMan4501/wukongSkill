using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.BGU.BUAnim;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.LimbIKEffectorsInfo")]
public struct FLimbIKEffectorsInfo
{
	private static int LimbIKEffectorsInfo_StructSize;

	public FLimbIKEffectorsInfo Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.LimbIKEffectorsInfo");
		LimbIKEffectorsInfo_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FLimbIKEffectorsInfo));
	}

	static FLimbIKEffectorsInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FLimbIKEffectorsInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLimbIKEffectorsInfo));
	}
}
