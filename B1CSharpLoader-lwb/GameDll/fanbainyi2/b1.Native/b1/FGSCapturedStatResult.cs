using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.GSCapturedStatResult", "UnrealExtent", UnrealModuleType.Game)]
public struct FGSCapturedStatResult
{
	private static bool StatName_IsValid;

	private static int StatName_Offset;

	[UProperty(Flags = (PropFlags)6755399441187333uL)]
	[UMetaPath("/Script/UnrealExtent.GSCapturedStatResult:StatName")]
	public string StatName;

	private static bool Value_IsValid;

	private static int Value_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/UnrealExtent.GSCapturedStatResult:Value")]
	public float Value;

	private static bool StatType_IsValid;

	private static FFieldAddress StatType_PropertyAddress;

	private static int StatType_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/UnrealExtent.GSCapturedStatResult:StatType")]
	public EGSCapturedStatType StatType;

	private static bool FGSCapturedStatResult_IsValid;

	private static int FGSCapturedStatResult_StructSize;

	public FGSCapturedStatResult Copy()
	{
		return this;
	}

	public static FGSCapturedStatResult FromNative(IntPtr nativeBuffer)
	{
		return new FGSCapturedStatResult(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSCapturedStatResult value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSCapturedStatResult FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSCapturedStatResult(nativeBuffer + arrayIndex * FGSCapturedStatResult_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSCapturedStatResult value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSCapturedStatResult_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSCapturedStatResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.GSCapturedStatResult");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, StatName_Offset), StatName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
		EnumMarshaler<EGSCapturedStatType>.ToNative(IntPtr.Add(nativeStruct, StatType_Offset), 0, StatType_PropertyAddress.Address, StatType);
	}

	public FGSCapturedStatResult(IntPtr nativeStruct)
	{
		if (!FGSCapturedStatResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.GSCapturedStatResult");
			StatName = FStringMarshaler.DefaultString;
			Value = 0f;
			StatType = EGSCapturedStatType.NONE;
		}
		else
		{
			StatName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, StatName_Offset));
			Value = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Value_Offset));
			StatType = EnumMarshaler<EGSCapturedStatType>.FromNative(IntPtr.Add(nativeStruct, StatType_Offset), 0, StatType_PropertyAddress.Address);
		}
	}

	static FGSCapturedStatResult()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSCapturedStatResult)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSCapturedStatResult));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UnrealExtent.GSCapturedStatResult");
		FGSCapturedStatResult_StructSize = NativeReflection.GetStructSize(intPtr);
		StatName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StatName");
		StatName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StatName", Classes.FStrProperty);
		Value_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Value", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref StatType_PropertyAddress, intPtr, "StatType");
		StatType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StatType");
		StatType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StatType", Classes.FEnumProperty);
		FGSCapturedStatResult_IsValid = intPtr != IntPtr.Zero && StatName_IsValid && Value_IsValid && StatType_IsValid;
		NativeReflection.LogStructIsValid("/Script/UnrealExtent.GSCapturedStatResult", FGSCapturedStatResult_IsValid);
	}
}
