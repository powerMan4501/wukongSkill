using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Calliope.CalliopePin", "Calliope", UnrealModuleType.GamePlugin)]
public struct FCalliopePin
{
	private static bool PinName_IsValid;

	private static int PinName_Offset;

	[UProperty(Flags = (PropFlags)6755469234340357uL)]
	[UMetaPath("/Script/Calliope.CalliopePin:PinName")]
	public FName PinName;

	private static bool PinToolTip_IsValid;

	private static int PinToolTip_Offset;

	[UProperty(Flags = (PropFlags)6755399441121797uL)]
	[UMetaPath("/Script/Calliope.CalliopePin:PinToolTip")]
	public string PinToolTip;

	private static bool FCalliopePin_IsValid;

	private static int FCalliopePin_StructSize;

	public FCalliopePin Copy()
	{
		return this;
	}

	public static FCalliopePin FromNative(IntPtr nativeBuffer)
	{
		return new FCalliopePin(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCalliopePin value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCalliopePin FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCalliopePin(nativeBuffer + arrayIndex * FCalliopePin_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCalliopePin value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCalliopePin_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCalliopePin_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.CalliopePin");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, PinName_Offset), PinName);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, PinToolTip_Offset), PinToolTip);
	}

	public FCalliopePin(IntPtr nativeStruct)
	{
		if (!FCalliopePin_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.CalliopePin");
			PinName = default(FName);
			PinToolTip = FStringMarshaler.DefaultString;
		}
		else
		{
			PinName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, PinName_Offset));
			PinToolTip = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, PinToolTip_Offset));
		}
	}

	static FCalliopePin()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCalliopePin)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCalliopePin));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.CalliopePin");
		FCalliopePin_StructSize = NativeReflection.GetStructSize(intPtr);
		PinName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PinName");
		PinName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PinName", Classes.FNameProperty);
		PinToolTip_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PinToolTip");
		PinToolTip_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PinToolTip", Classes.FStrProperty);
		FCalliopePin_IsValid = intPtr != IntPtr.Zero && PinName_IsValid && PinToolTip_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.CalliopePin", FCalliopePin_IsValid);
	}
}
