using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Calliope.CalliopeConnectedPin", "Calliope", UnrealModuleType.GamePlugin)]
public struct FCalliopeConnectedPin
{
	private static bool NodeGuid_IsValid;

	private static int NodeGuid_Offset;

	[UProperty(Flags = (PropFlags)6755468160532484uL)]
	[UMetaPath("/Script/Calliope.CalliopeConnectedPin:NodeGuid")]
	public FCalliopeGuid NodeGuid;

	private static bool PinName_IsValid;

	private static int PinName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.CalliopeConnectedPin:PinName")]
	public FName PinName;

	private static bool FCalliopeConnectedPin_IsValid;

	private static int FCalliopeConnectedPin_StructSize;

	public FCalliopeConnectedPin Copy()
	{
		return this;
	}

	public static FCalliopeConnectedPin FromNative(IntPtr nativeBuffer)
	{
		return new FCalliopeConnectedPin(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCalliopeConnectedPin value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCalliopeConnectedPin FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCalliopeConnectedPin(nativeBuffer + arrayIndex * FCalliopeConnectedPin_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCalliopeConnectedPin value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCalliopeConnectedPin_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCalliopeConnectedPin_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.CalliopeConnectedPin");
			return;
		}
		FCalliopeGuid.ToNative(IntPtr.Add(nativeStruct, NodeGuid_Offset), NodeGuid);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, PinName_Offset), PinName);
	}

	public FCalliopeConnectedPin(IntPtr nativeStruct)
	{
		if (!FCalliopeConnectedPin_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.CalliopeConnectedPin");
			NodeGuid = default(FCalliopeGuid);
			PinName = default(FName);
		}
		else
		{
			NodeGuid = FCalliopeGuid.FromNative(IntPtr.Add(nativeStruct, NodeGuid_Offset));
			PinName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, PinName_Offset));
		}
	}

	static FCalliopeConnectedPin()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCalliopeConnectedPin)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCalliopeConnectedPin));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.CalliopeConnectedPin");
		FCalliopeConnectedPin_StructSize = NativeReflection.GetStructSize(intPtr);
		NodeGuid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NodeGuid");
		NodeGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NodeGuid", Classes.FStructProperty);
		PinName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PinName");
		PinName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PinName", Classes.FNameProperty);
		FCalliopeConnectedPin_IsValid = intPtr != IntPtr.Zero && NodeGuid_IsValid && PinName_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.CalliopeConnectedPin", FCalliopeConnectedPin_IsValid);
	}
}
