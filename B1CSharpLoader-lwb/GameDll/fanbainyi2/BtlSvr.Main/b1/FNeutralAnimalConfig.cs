using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.NeutralAnimalConfig")]
public struct FNeutralAnimalConfig
{
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.NeutralAnimalConfig:NeutralAnimalType")]
	public ENeutralAnimalType NeutralAnimalType;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.NeutralAnimalConfig:BackToPatrolRange")]
	public float BackToPatrolRange;

	private static int NeutralAnimalConfig_StructSize;

	private static int NeutralAnimalConfig_IsValid;

	private static bool NeutralAnimalType_IsValid;

	private static int NeutralAnimalType_Offset;

	private static FFieldAddress NeutralAnimalType_PropertyAddress;

	private static bool BackToPatrolRange_IsValid;

	private static int BackToPatrolRange_Offset;

	public FNeutralAnimalConfig Copy()
	{
		return this;
	}

	public static FNeutralAnimalConfig FromNative(IntPtr nativeBuffer)
	{
		return new FNeutralAnimalConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FNeutralAnimalConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FNeutralAnimalConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FNeutralAnimalConfig(IntPtr.Add(nativeBuffer, arrayIndex * NeutralAnimalConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FNeutralAnimalConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * NeutralAnimalConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (NeutralAnimalConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.NeutralAnimalConfig");
			return;
		}
		EnumMarshaler<ENeutralAnimalType>.ToNative(IntPtr.Add(nativeStruct, NeutralAnimalType_Offset), 0, NeutralAnimalType_PropertyAddress.Address, NeutralAnimalType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BackToPatrolRange_Offset), BackToPatrolRange);
	}

	public FNeutralAnimalConfig(IntPtr nativeStruct)
	{
		if (NeutralAnimalConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.NeutralAnimalConfig");
			NeutralAnimalType = ENeutralAnimalType.None;
			BackToPatrolRange = 0f;
		}
		else
		{
			NeutralAnimalType = EnumMarshaler<ENeutralAnimalType>.FromNative(IntPtr.Add(nativeStruct, NeutralAnimalType_Offset), 0, NeutralAnimalType_PropertyAddress.Address);
			BackToPatrolRange = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BackToPatrolRange_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.NeutralAnimalConfig");
		NeutralAnimalConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref NeutralAnimalType_PropertyAddress, intPtr, "NeutralAnimalType");
		NeutralAnimalType_Offset = NativeReflection.GetPropertyOffset(intPtr, "NeutralAnimalType");
		NeutralAnimalType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NeutralAnimalType", Classes.FEnumProperty);
		BackToPatrolRange_Offset = NativeReflection.GetPropertyOffset(intPtr, "BackToPatrolRange");
		BackToPatrolRange_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BackToPatrolRange", Classes.FFloatProperty);
		NeutralAnimalConfig_IsValid = ((intPtr != IntPtr.Zero && NeutralAnimalType_IsValid && BackToPatrolRange_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.NeutralAnimalConfig", (byte)NeutralAnimalConfig_IsValid != 0);
	}

	static FNeutralAnimalConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FNeutralAnimalConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FNeutralAnimalConfig));
	}
}
