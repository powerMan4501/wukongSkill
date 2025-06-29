using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.RigVMDeveloper;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/RigVMDeveloper.RigVMCompileSettings", "RigVMDeveloper", UnrealModuleType.Engine)]
public struct FRigVMCompileSettings
{
	private static bool SurpressInfoMessages_IsValid;

	private static FFieldAddress SurpressInfoMessages_PropertyAddress;

	private static int SurpressInfoMessages_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMCompileSettings:SurpressInfoMessages")]
	public bool SurpressInfoMessages;

	private static bool SurpressWarnings_IsValid;

	private static FFieldAddress SurpressWarnings_PropertyAddress;

	private static int SurpressWarnings_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMCompileSettings:SurpressWarnings")]
	public bool SurpressWarnings;

	private static bool SurpressErrors_IsValid;

	private static FFieldAddress SurpressErrors_PropertyAddress;

	private static int SurpressErrors_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMCompileSettings:SurpressErrors")]
	public bool SurpressErrors;

	private static bool EnablePinWatches_IsValid;

	private static FFieldAddress EnablePinWatches_PropertyAddress;

	private static int EnablePinWatches_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMCompileSettings:EnablePinWatches")]
	public bool EnablePinWatches;

	private static bool ASTSettings_IsValid;

	private static int ASTSettings_Offset;

	[UProperty(Flags = (PropFlags)4503599627378693uL)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMCompileSettings:ASTSettings")]
	public FRigVMParserASTSettings ASTSettings;

	private static bool FRigVMCompileSettings_IsValid;

	private static int FRigVMCompileSettings_StructSize;

	public FRigVMCompileSettings Copy()
	{
		return this;
	}

	public static FRigVMCompileSettings FromNative(IntPtr nativeBuffer)
	{
		return new FRigVMCompileSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigVMCompileSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigVMCompileSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigVMCompileSettings(nativeBuffer + arrayIndex * FRigVMCompileSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigVMCompileSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigVMCompileSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigVMCompileSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/RigVMDeveloper.RigVMCompileSettings");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SurpressInfoMessages_Offset), 0, SurpressInfoMessages_PropertyAddress.Address, SurpressInfoMessages);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SurpressWarnings_Offset), 0, SurpressWarnings_PropertyAddress.Address, SurpressWarnings);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SurpressErrors_Offset), 0, SurpressErrors_PropertyAddress.Address, SurpressErrors);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnablePinWatches_Offset), 0, EnablePinWatches_PropertyAddress.Address, EnablePinWatches);
		FRigVMParserASTSettings.ToNative(IntPtr.Add(nativeStruct, ASTSettings_Offset), ASTSettings);
	}

	public FRigVMCompileSettings(IntPtr nativeStruct)
	{
		if (!FRigVMCompileSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/RigVMDeveloper.RigVMCompileSettings");
			SurpressInfoMessages = false;
			SurpressWarnings = false;
			SurpressErrors = false;
			EnablePinWatches = false;
			ASTSettings = default(FRigVMParserASTSettings);
		}
		else
		{
			SurpressInfoMessages = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SurpressInfoMessages_Offset), 0, SurpressInfoMessages_PropertyAddress.Address);
			SurpressWarnings = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SurpressWarnings_Offset), 0, SurpressWarnings_PropertyAddress.Address);
			SurpressErrors = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SurpressErrors_Offset), 0, SurpressErrors_PropertyAddress.Address);
			EnablePinWatches = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnablePinWatches_Offset), 0, EnablePinWatches_PropertyAddress.Address);
			ASTSettings = FRigVMParserASTSettings.FromNative(IntPtr.Add(nativeStruct, ASTSettings_Offset));
		}
	}

	static FRigVMCompileSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigVMCompileSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigVMCompileSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/RigVMDeveloper.RigVMCompileSettings");
		FRigVMCompileSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref SurpressInfoMessages_PropertyAddress, intPtr, "SurpressInfoMessages");
		SurpressInfoMessages_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SurpressInfoMessages");
		SurpressInfoMessages_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SurpressInfoMessages", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SurpressWarnings_PropertyAddress, intPtr, "SurpressWarnings");
		SurpressWarnings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SurpressWarnings");
		SurpressWarnings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SurpressWarnings", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SurpressErrors_PropertyAddress, intPtr, "SurpressErrors");
		SurpressErrors_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SurpressErrors");
		SurpressErrors_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SurpressErrors", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnablePinWatches_PropertyAddress, intPtr, "EnablePinWatches");
		EnablePinWatches_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EnablePinWatches");
		EnablePinWatches_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EnablePinWatches", Classes.FBoolProperty);
		ASTSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ASTSettings");
		ASTSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ASTSettings", Classes.FStructProperty);
		FRigVMCompileSettings_IsValid = intPtr != IntPtr.Zero && SurpressInfoMessages_IsValid && SurpressWarnings_IsValid && SurpressErrors_IsValid && EnablePinWatches_IsValid && ASTSettings_IsValid;
		NativeReflection.LogStructIsValid("/Script/RigVMDeveloper.RigVMCompileSettings", FRigVMCompileSettings_IsValid);
	}
}
