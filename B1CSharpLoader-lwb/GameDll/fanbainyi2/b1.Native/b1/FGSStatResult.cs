using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.GSStatResult", "UnrealExtent", UnrealModuleType.Game)]
public struct FGSStatResult
{
	private static bool StatType_IsValid;

	private static FFieldAddress StatType_PropertyAddress;

	private static int StatType_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/UnrealExtent.GSStatResult:StatType")]
	public EGSCapturedStatType StatType;

	private static bool StatName_IsValid;

	private static int StatName_Offset;

	[UProperty(Flags = (PropFlags)6755399441187333uL)]
	[UMetaPath("/Script/UnrealExtent.GSStatResult:StatName")]
	public string StatName;

	private static bool PtrValue_IsValid;

	private static int PtrValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/UnrealExtent.GSStatResult:PtrValue")]
	public long PtrValue;

	private static bool Int64Value_IsValid;

	private static int Int64Value_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/UnrealExtent.GSStatResult:Int64Value")]
	public long Int64Value;

	private static bool Duration_IsValid;

	private static int Duration_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/UnrealExtent.GSStatResult:Duration")]
	public long Duration;

	private static bool CallCount_IsValid;

	private static int CallCount_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/UnrealExtent.GSStatResult:CallCount")]
	public int CallCount;

	private static bool DoubleValue_IsValid;

	private static int DoubleValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/UnrealExtent.GSStatResult:DoubleValue")]
	public double DoubleValue;

	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/UnrealExtent.GSStatResult:Name")]
	public FName Name;

	private static bool FGSStatResult_IsValid;

	private static int FGSStatResult_StructSize;

	public FGSStatResult Copy()
	{
		return this;
	}

	public static FGSStatResult FromNative(IntPtr nativeBuffer)
	{
		return new FGSStatResult(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSStatResult value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSStatResult FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSStatResult(nativeBuffer + arrayIndex * FGSStatResult_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSStatResult value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSStatResult_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSStatResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.GSStatResult");
			return;
		}
		EnumMarshaler<EGSCapturedStatType>.ToNative(IntPtr.Add(nativeStruct, StatType_Offset), 0, StatType_PropertyAddress.Address, StatType);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, StatName_Offset), StatName);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(nativeStruct, PtrValue_Offset), PtrValue);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(nativeStruct, Int64Value_Offset), Int64Value);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(nativeStruct, Duration_Offset), Duration);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, CallCount_Offset), CallCount);
		BlittableTypeMarshaler<double>.ToNative(IntPtr.Add(nativeStruct, DoubleValue_Offset), DoubleValue);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
	}

	public FGSStatResult(IntPtr nativeStruct)
	{
		if (!FGSStatResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.GSStatResult");
			StatType = EGSCapturedStatType.NONE;
			StatName = FStringMarshaler.DefaultString;
			PtrValue = 0L;
			Int64Value = 0L;
			Duration = 0L;
			CallCount = 0;
			DoubleValue = 0.0;
			Name = default(FName);
		}
		else
		{
			StatType = EnumMarshaler<EGSCapturedStatType>.FromNative(IntPtr.Add(nativeStruct, StatType_Offset), 0, StatType_PropertyAddress.Address);
			StatName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, StatName_Offset));
			PtrValue = BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(nativeStruct, PtrValue_Offset));
			Int64Value = BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(nativeStruct, Int64Value_Offset));
			Duration = BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(nativeStruct, Duration_Offset));
			CallCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, CallCount_Offset));
			DoubleValue = BlittableTypeMarshaler<double>.FromNative(IntPtr.Add(nativeStruct, DoubleValue_Offset));
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
		}
	}

	static FGSStatResult()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSStatResult)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSStatResult));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UnrealExtent.GSStatResult");
		FGSStatResult_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref StatType_PropertyAddress, intPtr, "StatType");
		StatType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StatType");
		StatType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StatType", Classes.FEnumProperty);
		StatName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StatName");
		StatName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StatName", Classes.FStrProperty);
		PtrValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PtrValue");
		PtrValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PtrValue", Classes.FInt64Property);
		Int64Value_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Int64Value");
		Int64Value_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Int64Value", Classes.FInt64Property);
		Duration_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Duration");
		Duration_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Duration", Classes.FInt64Property);
		CallCount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CallCount");
		CallCount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CallCount", Classes.FIntProperty);
		DoubleValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DoubleValue");
		DoubleValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DoubleValue", Classes.FDoubleProperty);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		FGSStatResult_IsValid = intPtr != IntPtr.Zero && StatType_IsValid && StatName_IsValid && PtrValue_IsValid && Int64Value_IsValid && Duration_IsValid && CallCount_IsValid && DoubleValue_IsValid && Name_IsValid;
		NativeReflection.LogStructIsValid("/Script/UnrealExtent.GSStatResult", FGSStatResult_IsValid);
	}
}
