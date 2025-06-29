using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.WarpingVectorValue", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FWarpingVectorValue
{
	private static bool Mode_IsValid;

	private static FFieldAddress Mode_PropertyAddress;

	private static int Mode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.WarpingVectorValue:Mode")]
	public EWarpingVectorMode Mode;

	private static bool Value_IsValid;

	private static int Value_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.WarpingVectorValue:Value")]
	public FVector Value;

	private static bool FWarpingVectorValue_IsValid;

	private static int FWarpingVectorValue_StructSize;

	public FWarpingVectorValue Copy()
	{
		return this;
	}

	public static FWarpingVectorValue FromNative(IntPtr nativeBuffer)
	{
		return new FWarpingVectorValue(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FWarpingVectorValue value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FWarpingVectorValue FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FWarpingVectorValue(nativeBuffer + arrayIndex * FWarpingVectorValue_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FWarpingVectorValue value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FWarpingVectorValue_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FWarpingVectorValue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.WarpingVectorValue");
			return;
		}
		EnumMarshaler<EWarpingVectorMode>.ToNative(IntPtr.Add(nativeStruct, Mode_Offset), 0, Mode_PropertyAddress.Address, Mode);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
	}

	public FWarpingVectorValue(IntPtr nativeStruct)
	{
		if (!FWarpingVectorValue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.WarpingVectorValue");
			Mode = EWarpingVectorMode.ComponentSpaceVector;
			Value = default(FVector);
		}
		else
		{
			Mode = EnumMarshaler<EWarpingVectorMode>.FromNative(IntPtr.Add(nativeStruct, Mode_Offset), 0, Mode_PropertyAddress.Address);
			Value = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Value_Offset));
		}
	}

	static FWarpingVectorValue()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FWarpingVectorValue)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FWarpingVectorValue));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.WarpingVectorValue");
		FWarpingVectorValue_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Mode_PropertyAddress, intPtr, "Mode");
		Mode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Mode");
		Mode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Mode", Classes.FEnumProperty);
		Value_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Value", Classes.FStructProperty);
		FWarpingVectorValue_IsValid = intPtr != IntPtr.Zero && Mode_IsValid && Value_IsValid;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.WarpingVectorValue", FWarpingVectorValue_IsValid);
	}
}
