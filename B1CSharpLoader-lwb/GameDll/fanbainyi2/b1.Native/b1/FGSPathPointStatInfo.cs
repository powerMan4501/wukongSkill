using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.GSPathPointStatInfo", "UnrealExtent", UnrealModuleType.Game)]
public struct FGSPathPointStatInfo
{
	private static bool StatNameAndValue_IsValid;

	private static FFieldAddress StatNameAndValue_PropertyAddress;

	private static int StatNameAndValue_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/UnrealExtent.GSPathPointStatInfo:StatNameAndValue")]
	public Dictionary<string, float> StatNameAndValue;

	private static bool Position_IsValid;

	private static int Position_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.GSPathPointStatInfo:Position")]
	public FVector Position;

	private static bool Duration_IsValid;

	private static int Duration_Offset;

	[UProperty(Flags = (PropFlags)6755399441187333uL)]
	[UMetaPath("/Script/UnrealExtent.GSPathPointStatInfo:Duration")]
	public string Duration;

	private static bool FGSPathPointStatInfo_IsValid;

	private static int FGSPathPointStatInfo_StructSize;

	public FGSPathPointStatInfo Copy()
	{
		FGSPathPointStatInfo result = this;
		if (StatNameAndValue != null)
		{
			result.StatNameAndValue = new Dictionary<string, float>(StatNameAndValue);
		}
		return result;
	}

	public static FGSPathPointStatInfo FromNative(IntPtr nativeBuffer)
	{
		return new FGSPathPointStatInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSPathPointStatInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSPathPointStatInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSPathPointStatInfo(nativeBuffer + arrayIndex * FGSPathPointStatInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSPathPointStatInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSPathPointStatInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSPathPointStatInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.GSPathPointStatInfo");
			return;
		}
		new TMapCopyMarshaler<string, float>(1, StatNameAndValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(nativeStruct, StatNameAndValue_Offset), StatNameAndValue);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Position_Offset), Position);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Duration_Offset), Duration);
	}

	public FGSPathPointStatInfo(IntPtr nativeStruct)
	{
		if (!FGSPathPointStatInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.GSPathPointStatInfo");
			StatNameAndValue = null;
			Position = default(FVector);
			Duration = FStringMarshaler.DefaultString;
		}
		else
		{
			StatNameAndValue = new TMapCopyMarshaler<string, float>(1, StatNameAndValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(nativeStruct, StatNameAndValue_Offset));
			Position = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Position_Offset));
			Duration = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Duration_Offset));
		}
	}

	static FGSPathPointStatInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSPathPointStatInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSPathPointStatInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UnrealExtent.GSPathPointStatInfo");
		FGSPathPointStatInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref StatNameAndValue_PropertyAddress, intPtr, "StatNameAndValue");
		StatNameAndValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StatNameAndValue");
		StatNameAndValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StatNameAndValue", Classes.FMapProperty);
		Position_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Position");
		Position_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Position", Classes.FStructProperty);
		Duration_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Duration");
		Duration_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Duration", Classes.FStrProperty);
		FGSPathPointStatInfo_IsValid = intPtr != IntPtr.Zero && StatNameAndValue_IsValid && Position_IsValid && Duration_IsValid;
		NativeReflection.LogStructIsValid("/Script/UnrealExtent.GSPathPointStatInfo", FGSPathPointStatInfo_IsValid);
	}
}
