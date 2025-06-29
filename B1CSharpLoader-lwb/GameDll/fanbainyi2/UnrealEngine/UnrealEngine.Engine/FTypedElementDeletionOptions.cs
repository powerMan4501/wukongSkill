using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.TypedElementDeletionOptions", "Engine", UnrealModuleType.Engine)]
public struct FTypedElementDeletionOptions
{
	private static bool VerifyDeletionCanHappen_IsValid;

	private static FFieldAddress VerifyDeletionCanHappen_PropertyAddress;

	private static int VerifyDeletionCanHappen_Offset;

	[UProperty(Flags = (PropFlags)20266268116386308uL)]
	[UMetaPath("/Script/Engine.TypedElementDeletionOptions:bVerifyDeletionCanHappen")]
	public bool VerifyDeletionCanHappen;

	private static bool WarnAboutReferences_IsValid;

	private static FFieldAddress WarnAboutReferences_PropertyAddress;

	private static int WarnAboutReferences_Offset;

	[UProperty(Flags = (PropFlags)20266268116386308uL)]
	[UMetaPath("/Script/Engine.TypedElementDeletionOptions:bWarnAboutReferences")]
	public bool WarnAboutReferences;

	private static bool WarnAboutSoftReferences_IsValid;

	private static FFieldAddress WarnAboutSoftReferences_PropertyAddress;

	private static int WarnAboutSoftReferences_Offset;

	[UProperty(Flags = (PropFlags)20266268116386308uL)]
	[UMetaPath("/Script/Engine.TypedElementDeletionOptions:bWarnAboutSoftReferences")]
	public bool WarnAboutSoftReferences;

	private static bool FTypedElementDeletionOptions_IsValid;

	private static int FTypedElementDeletionOptions_StructSize;

	public FTypedElementDeletionOptions Copy()
	{
		return this;
	}

	public static FTypedElementDeletionOptions FromNative(IntPtr nativeBuffer)
	{
		return new FTypedElementDeletionOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTypedElementDeletionOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTypedElementDeletionOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTypedElementDeletionOptions(nativeBuffer + arrayIndex * FTypedElementDeletionOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTypedElementDeletionOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FTypedElementDeletionOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FTypedElementDeletionOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.TypedElementDeletionOptions");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, VerifyDeletionCanHappen_Offset), 0, VerifyDeletionCanHappen_PropertyAddress.Address, VerifyDeletionCanHappen);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, WarnAboutReferences_Offset), 0, WarnAboutReferences_PropertyAddress.Address, WarnAboutReferences);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, WarnAboutSoftReferences_Offset), 0, WarnAboutSoftReferences_PropertyAddress.Address, WarnAboutSoftReferences);
	}

	public FTypedElementDeletionOptions(IntPtr nativeStruct)
	{
		if (!FTypedElementDeletionOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.TypedElementDeletionOptions");
			VerifyDeletionCanHappen = false;
			WarnAboutReferences = false;
			WarnAboutSoftReferences = false;
		}
		else
		{
			VerifyDeletionCanHappen = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, VerifyDeletionCanHappen_Offset), 0, VerifyDeletionCanHappen_PropertyAddress.Address);
			WarnAboutReferences = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, WarnAboutReferences_Offset), 0, WarnAboutReferences_PropertyAddress.Address);
			WarnAboutSoftReferences = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, WarnAboutSoftReferences_Offset), 0, WarnAboutSoftReferences_PropertyAddress.Address);
		}
	}

	static FTypedElementDeletionOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTypedElementDeletionOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTypedElementDeletionOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.TypedElementDeletionOptions");
		FTypedElementDeletionOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref VerifyDeletionCanHappen_PropertyAddress, intPtr, "bVerifyDeletionCanHappen");
		VerifyDeletionCanHappen_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bVerifyDeletionCanHappen");
		VerifyDeletionCanHappen_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bVerifyDeletionCanHappen", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref WarnAboutReferences_PropertyAddress, intPtr, "bWarnAboutReferences");
		WarnAboutReferences_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bWarnAboutReferences");
		WarnAboutReferences_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bWarnAboutReferences", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref WarnAboutSoftReferences_PropertyAddress, intPtr, "bWarnAboutSoftReferences");
		WarnAboutSoftReferences_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bWarnAboutSoftReferences");
		WarnAboutSoftReferences_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bWarnAboutSoftReferences", Classes.FBoolProperty);
		FTypedElementDeletionOptions_IsValid = intPtr != IntPtr.Zero && VerifyDeletionCanHappen_IsValid && WarnAboutReferences_IsValid && WarnAboutSoftReferences_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.TypedElementDeletionOptions", FTypedElementDeletionOptions_IsValid);
	}
}
