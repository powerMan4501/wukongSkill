using System;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 16392)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.FrameNumberRangeBound", "CoreUObject", UnrealModuleType.Engine)]
public struct FFrameNumberRangeBound
{
	private static bool Type_IsValid;

	private static FFieldAddress Type_PropertyAddress;

	private static int Type_Offset;

	[UProperty(Flags = (PropFlags)20266268116386309uL)]
	[UMetaPath("/Script/CoreUObject.FrameNumberRangeBound:Type")]
	public ERangeBoundTypes Type;

	private static bool Value_IsValid;

	private static int Value_Offset;

	[UProperty(Flags = (PropFlags)20266267042643973uL)]
	[UMetaPath("/Script/CoreUObject.FrameNumberRangeBound:Value")]
	public FFrameNumber Value;

	private static bool FFrameNumberRangeBound_IsValid;

	private static int FFrameNumberRangeBound_StructSize;

	public FFrameNumberRangeBound Copy()
	{
		return this;
	}

	public static FFrameNumberRangeBound FromNative(IntPtr nativeBuffer)
	{
		return new FFrameNumberRangeBound(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FFrameNumberRangeBound value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FFrameNumberRangeBound FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FFrameNumberRangeBound(nativeBuffer + arrayIndex * FFrameNumberRangeBound_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FFrameNumberRangeBound value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FFrameNumberRangeBound_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FFrameNumberRangeBound_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.FrameNumberRangeBound");
			return;
		}
		EnumMarshaler<ERangeBoundTypes>.ToNative(IntPtr.Add(nativeStruct, Type_Offset), 0, Type_PropertyAddress.Address, Type);
		FFrameNumber.ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
	}

	public FFrameNumberRangeBound(IntPtr nativeStruct)
	{
		if (!FFrameNumberRangeBound_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.FrameNumberRangeBound");
			Type = ERangeBoundTypes.Exclusive;
			Value = default(FFrameNumber);
		}
		else
		{
			Type = EnumMarshaler<ERangeBoundTypes>.FromNative(IntPtr.Add(nativeStruct, Type_Offset), 0, Type_PropertyAddress.Address);
			Value = FFrameNumber.FromNative(IntPtr.Add(nativeStruct, Value_Offset));
		}
	}

	static FFrameNumberRangeBound()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FFrameNumberRangeBound)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FFrameNumberRangeBound));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CoreUObject.FrameNumberRangeBound");
		FFrameNumberRangeBound_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Type_PropertyAddress, intPtr, "Type");
		Type_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Type");
		Type_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Type", Classes.FByteProperty);
		Value_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Value", Classes.FStructProperty);
		FFrameNumberRangeBound_IsValid = intPtr != IntPtr.Zero && Type_IsValid && Value_IsValid;
		NativeReflection.LogStructIsValid("/Script/CoreUObject.FrameNumberRangeBound", FFrameNumberRangeBound_IsValid);
	}
}
