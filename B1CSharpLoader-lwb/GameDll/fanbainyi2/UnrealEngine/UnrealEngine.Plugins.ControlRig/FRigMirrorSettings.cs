using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigMirrorSettings", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigMirrorSettings
{
	private static bool MirrorAxis_IsValid;

	private static FFieldAddress MirrorAxis_PropertyAddress;

	private static int MirrorAxis_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.RigMirrorSettings:MirrorAxis")]
	public EAxisType MirrorAxis;

	private static bool AxisToFlip_IsValid;

	private static FFieldAddress AxisToFlip_PropertyAddress;

	private static int AxisToFlip_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.RigMirrorSettings:AxisToFlip")]
	public EAxisType AxisToFlip;

	private static bool SearchString_IsValid;

	private static int SearchString_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/ControlRig.RigMirrorSettings:SearchString")]
	public string SearchString;

	private static bool ReplaceString_IsValid;

	private static int ReplaceString_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/ControlRig.RigMirrorSettings:ReplaceString")]
	public string ReplaceString;

	private static bool FRigMirrorSettings_IsValid;

	private static int FRigMirrorSettings_StructSize;

	public FRigMirrorSettings Copy()
	{
		return this;
	}

	public static FRigMirrorSettings FromNative(IntPtr nativeBuffer)
	{
		return new FRigMirrorSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigMirrorSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigMirrorSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigMirrorSettings(nativeBuffer + arrayIndex * FRigMirrorSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigMirrorSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigMirrorSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigMirrorSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigMirrorSettings");
			return;
		}
		EnumMarshaler<EAxisType>.ToNative(IntPtr.Add(nativeStruct, MirrorAxis_Offset), 0, MirrorAxis_PropertyAddress.Address, MirrorAxis);
		EnumMarshaler<EAxisType>.ToNative(IntPtr.Add(nativeStruct, AxisToFlip_Offset), 0, AxisToFlip_PropertyAddress.Address, AxisToFlip);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, SearchString_Offset), SearchString);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ReplaceString_Offset), ReplaceString);
	}

	public FRigMirrorSettings(IntPtr nativeStruct)
	{
		if (!FRigMirrorSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigMirrorSettings");
			MirrorAxis = EAxisType.None;
			AxisToFlip = EAxisType.None;
			SearchString = FStringMarshaler.DefaultString;
			ReplaceString = FStringMarshaler.DefaultString;
		}
		else
		{
			MirrorAxis = EnumMarshaler<EAxisType>.FromNative(IntPtr.Add(nativeStruct, MirrorAxis_Offset), 0, MirrorAxis_PropertyAddress.Address);
			AxisToFlip = EnumMarshaler<EAxisType>.FromNative(IntPtr.Add(nativeStruct, AxisToFlip_Offset), 0, AxisToFlip_PropertyAddress.Address);
			SearchString = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, SearchString_Offset));
			ReplaceString = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ReplaceString_Offset));
		}
	}

	static FRigMirrorSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigMirrorSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigMirrorSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigMirrorSettings");
		FRigMirrorSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref MirrorAxis_PropertyAddress, intPtr, "MirrorAxis");
		MirrorAxis_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MirrorAxis");
		MirrorAxis_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MirrorAxis", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref AxisToFlip_PropertyAddress, intPtr, "AxisToFlip");
		AxisToFlip_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AxisToFlip");
		AxisToFlip_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AxisToFlip", Classes.FByteProperty);
		SearchString_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SearchString");
		SearchString_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SearchString", Classes.FStrProperty);
		ReplaceString_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ReplaceString");
		ReplaceString_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ReplaceString", Classes.FStrProperty);
		FRigMirrorSettings_IsValid = intPtr != IntPtr.Zero && MirrorAxis_IsValid && AxisToFlip_IsValid && SearchString_IsValid && ReplaceString_IsValid;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigMirrorSettings", FRigMirrorSettings_IsValid);
	}
}
