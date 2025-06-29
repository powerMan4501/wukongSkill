using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/b1.TraceStatResult", "b1", UnrealModuleType.Game)]
public struct FTraceStatResult
{
	private static bool StatName_IsValid;

	private static int StatName_Offset;

	[UProperty(Flags = (PropFlags)6755399441187333uL)]
	[UMetaPath("/Script/b1.TraceStatResult:StatName")]
	public string StatName;

	private static bool Value_IsValid;

	private static int Value_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/b1.TraceStatResult:Value")]
	public float Value;

	private static bool StatType_IsValid;

	private static FFieldAddress StatType_PropertyAddress;

	private static int StatType_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/b1.TraceStatResult:StatType")]
	public EGSStatType StatType;

	private static bool FTraceStatResult_IsValid;

	private static int FTraceStatResult_StructSize;

	public FTraceStatResult Copy()
	{
		return this;
	}

	public static FTraceStatResult FromNative(IntPtr nativeBuffer)
	{
		return new FTraceStatResult(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTraceStatResult value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTraceStatResult FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTraceStatResult(nativeBuffer + arrayIndex * FTraceStatResult_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTraceStatResult value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FTraceStatResult_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FTraceStatResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.TraceStatResult");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, StatName_Offset), StatName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
		EnumMarshaler<EGSStatType>.ToNative(IntPtr.Add(nativeStruct, StatType_Offset), 0, StatType_PropertyAddress.Address, StatType);
	}

	public FTraceStatResult(IntPtr nativeStruct)
	{
		if (!FTraceStatResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.TraceStatResult");
			StatName = FStringMarshaler.DefaultString;
			Value = 0f;
			StatType = EGSStatType.NONE;
		}
		else
		{
			StatName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, StatName_Offset));
			Value = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Value_Offset));
			StatType = EnumMarshaler<EGSStatType>.FromNative(IntPtr.Add(nativeStruct, StatType_Offset), 0, StatType_PropertyAddress.Address);
		}
	}

	static FTraceStatResult()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTraceStatResult)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTraceStatResult));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.TraceStatResult");
		FTraceStatResult_StructSize = NativeReflection.GetStructSize(intPtr);
		StatName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StatName");
		StatName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StatName", Classes.FStrProperty);
		Value_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Value", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref StatType_PropertyAddress, intPtr, "StatType");
		StatType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StatType");
		StatType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StatType", Classes.FEnumProperty);
		FTraceStatResult_IsValid = intPtr != IntPtr.Zero && StatName_IsValid && Value_IsValid && StatType_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.TraceStatResult", FTraceStatResult_IsValid);
	}
}
