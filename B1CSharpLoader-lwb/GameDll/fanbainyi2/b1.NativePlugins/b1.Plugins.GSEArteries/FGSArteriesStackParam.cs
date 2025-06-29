using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSEArteries;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GSEArteries.GSArteriesStackParam", "GSEArteries", UnrealModuleType.GamePlugin)]
public struct FGSArteriesStackParam
{
	private static bool CanBeStackedOnto_IsValid;

	private static FFieldAddress CanBeStackedOnto_PropertyAddress;

	private static int CanBeStackedOnto_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSEArteries.GSArteriesStackParam:bCanBeStackedOnto")]
	public bool CanBeStackedOnto;

	private static bool eFixToLevel_IsValid;

	private static FFieldAddress eFixToLevel_PropertyAddress;

	private static int eFixToLevel_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSEArteries.GSArteriesStackParam:eFixToLevel")]
	public EGSARTERIES_PLACEMENT_LEVEL eFixToLevel;

	private static bool eCanPitchAt_IsValid;

	private static FFieldAddress eCanPitchAt_PropertyAddress;

	private static int eCanPitchAt_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSEArteries.GSArteriesStackParam:eCanPitchAt")]
	public EGSARTERIES_PLACEMENT_LEVEL eCanPitchAt;

	private static bool eCanRollAt_IsValid;

	private static FFieldAddress eCanRollAt_PropertyAddress;

	private static int eCanRollAt_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSEArteries.GSArteriesStackParam:eCanRollAt")]
	public EGSARTERIES_PLACEMENT_LEVEL eCanRollAt;

	private static bool eCanYawAt_IsValid;

	private static FFieldAddress eCanYawAt_PropertyAddress;

	private static int eCanYawAt_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSEArteries.GSArteriesStackParam:eCanYawAt")]
	public EGSARTERIES_PLACEMENT_LEVEL eCanYawAt;

	private static bool FGSArteriesStackParam_IsValid;

	private static int FGSArteriesStackParam_StructSize;

	public FGSArteriesStackParam Copy()
	{
		return this;
	}

	public static FGSArteriesStackParam FromNative(IntPtr nativeBuffer)
	{
		return new FGSArteriesStackParam(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSArteriesStackParam value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSArteriesStackParam FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSArteriesStackParam(nativeBuffer + arrayIndex * FGSArteriesStackParam_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSArteriesStackParam value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSArteriesStackParam_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSArteriesStackParam_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSEArteries.GSArteriesStackParam");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CanBeStackedOnto_Offset), 0, CanBeStackedOnto_PropertyAddress.Address, CanBeStackedOnto);
		EnumMarshaler<EGSARTERIES_PLACEMENT_LEVEL>.ToNative(IntPtr.Add(nativeStruct, eFixToLevel_Offset), 0, eFixToLevel_PropertyAddress.Address, eFixToLevel);
		EnumMarshaler<EGSARTERIES_PLACEMENT_LEVEL>.ToNative(IntPtr.Add(nativeStruct, eCanPitchAt_Offset), 0, eCanPitchAt_PropertyAddress.Address, eCanPitchAt);
		EnumMarshaler<EGSARTERIES_PLACEMENT_LEVEL>.ToNative(IntPtr.Add(nativeStruct, eCanRollAt_Offset), 0, eCanRollAt_PropertyAddress.Address, eCanRollAt);
		EnumMarshaler<EGSARTERIES_PLACEMENT_LEVEL>.ToNative(IntPtr.Add(nativeStruct, eCanYawAt_Offset), 0, eCanYawAt_PropertyAddress.Address, eCanYawAt);
	}

	public FGSArteriesStackParam(IntPtr nativeStruct)
	{
		if (!FGSArteriesStackParam_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSEArteries.GSArteriesStackParam");
			CanBeStackedOnto = false;
			eFixToLevel = EGSARTERIES_PLACEMENT_LEVEL.NONE;
			eCanPitchAt = EGSARTERIES_PLACEMENT_LEVEL.NONE;
			eCanRollAt = EGSARTERIES_PLACEMENT_LEVEL.NONE;
			eCanYawAt = EGSARTERIES_PLACEMENT_LEVEL.NONE;
		}
		else
		{
			CanBeStackedOnto = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CanBeStackedOnto_Offset), 0, CanBeStackedOnto_PropertyAddress.Address);
			eFixToLevel = EnumMarshaler<EGSARTERIES_PLACEMENT_LEVEL>.FromNative(IntPtr.Add(nativeStruct, eFixToLevel_Offset), 0, eFixToLevel_PropertyAddress.Address);
			eCanPitchAt = EnumMarshaler<EGSARTERIES_PLACEMENT_LEVEL>.FromNative(IntPtr.Add(nativeStruct, eCanPitchAt_Offset), 0, eCanPitchAt_PropertyAddress.Address);
			eCanRollAt = EnumMarshaler<EGSARTERIES_PLACEMENT_LEVEL>.FromNative(IntPtr.Add(nativeStruct, eCanRollAt_Offset), 0, eCanRollAt_PropertyAddress.Address);
			eCanYawAt = EnumMarshaler<EGSARTERIES_PLACEMENT_LEVEL>.FromNative(IntPtr.Add(nativeStruct, eCanYawAt_Offset), 0, eCanYawAt_PropertyAddress.Address);
		}
	}

	static FGSArteriesStackParam()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSArteriesStackParam)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSArteriesStackParam));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GSEArteries.GSArteriesStackParam");
		FGSArteriesStackParam_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref CanBeStackedOnto_PropertyAddress, intPtr, "bCanBeStackedOnto");
		CanBeStackedOnto_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCanBeStackedOnto");
		CanBeStackedOnto_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCanBeStackedOnto", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref eFixToLevel_PropertyAddress, intPtr, "eFixToLevel");
		eFixToLevel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "eFixToLevel");
		eFixToLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "eFixToLevel", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref eCanPitchAt_PropertyAddress, intPtr, "eCanPitchAt");
		eCanPitchAt_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "eCanPitchAt");
		eCanPitchAt_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "eCanPitchAt", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref eCanRollAt_PropertyAddress, intPtr, "eCanRollAt");
		eCanRollAt_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "eCanRollAt");
		eCanRollAt_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "eCanRollAt", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref eCanYawAt_PropertyAddress, intPtr, "eCanYawAt");
		eCanYawAt_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "eCanYawAt");
		eCanYawAt_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "eCanYawAt", Classes.FEnumProperty);
		FGSArteriesStackParam_IsValid = intPtr != IntPtr.Zero && CanBeStackedOnto_IsValid && eFixToLevel_IsValid && eCanPitchAt_IsValid && eCanRollAt_IsValid && eCanYawAt_IsValid;
		NativeReflection.LogStructIsValid("/Script/GSEArteries.GSArteriesStackParam", FGSArteriesStackParam_IsValid);
	}
}
