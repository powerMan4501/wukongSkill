using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGTaggedData", "PCG", UnrealModuleType.EnginePlugin)]
public struct FPCGTaggedData
{
	private static bool Data_IsValid;

	private static int Data_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/PCG.PCGTaggedData:Data")]
	public UPCGData Data;

	private static bool Tags_IsValid;

	private static FFieldAddress Tags_PropertyAddress;

	private static int Tags_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGTaggedData:Tags")]
	public HashSet<string> Tags;

	private static bool Pin_IsValid;

	private static int Pin_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGTaggedData:Pin")]
	public FName Pin;

	private static bool FPCGTaggedData_IsValid;

	private static int FPCGTaggedData_StructSize;

	public FPCGTaggedData Copy()
	{
		FPCGTaggedData result = this;
		if (Tags != null)
		{
			result.Tags = new HashSet<string>(Tags);
		}
		return result;
	}

	public static FPCGTaggedData FromNative(IntPtr nativeBuffer)
	{
		return new FPCGTaggedData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPCGTaggedData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPCGTaggedData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPCGTaggedData(nativeBuffer + arrayIndex * FPCGTaggedData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPCGTaggedData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPCGTaggedData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPCGTaggedData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGTaggedData");
			return;
		}
		UObjectMarshaler<UPCGData>.ToNative(IntPtr.Add(nativeStruct, Data_Offset), Data);
		new TSetCopyMarshaler<string>(1, Tags_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(nativeStruct, Tags_Offset), Tags);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Pin_Offset), Pin);
	}

	public FPCGTaggedData(IntPtr nativeStruct)
	{
		if (!FPCGTaggedData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGTaggedData");
			Data = null;
			Tags = null;
			Pin = default(FName);
		}
		else
		{
			Data = UObjectMarshaler<UPCGData>.FromNative(IntPtr.Add(nativeStruct, Data_Offset));
			Tags = new TSetCopyMarshaler<string>(1, Tags_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(nativeStruct, Tags_Offset));
			Pin = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Pin_Offset));
		}
	}

	static FPCGTaggedData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPCGTaggedData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPCGTaggedData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/PCG.PCGTaggedData");
		FPCGTaggedData_StructSize = NativeReflection.GetStructSize(intPtr);
		Data_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Data");
		Data_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Data", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Tags_PropertyAddress, intPtr, "Tags");
		Tags_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Tags");
		Tags_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Tags", Classes.FSetProperty);
		Pin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Pin");
		Pin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Pin", Classes.FNameProperty);
		FPCGTaggedData_IsValid = intPtr != IntPtr.Zero && Data_IsValid && Tags_IsValid && Pin_IsValid;
		NativeReflection.LogStructIsValid("/Script/PCG.PCGTaggedData", FPCGTaggedData_IsValid);
	}
}
