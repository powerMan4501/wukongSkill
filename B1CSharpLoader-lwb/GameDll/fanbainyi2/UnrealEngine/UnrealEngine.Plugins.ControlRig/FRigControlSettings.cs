using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigControlSettings", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigControlSettings
{
	private static bool ControlType_IsValid;

	private static FFieldAddress ControlType_PropertyAddress;

	private static int ControlType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.RigControlSettings:ControlType")]
	public ERigControlType ControlType;

	private static bool DisplayName_IsValid;

	private static int DisplayName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.RigControlSettings:DisplayName")]
	public FName DisplayName;

	private static bool PrimaryAxis_IsValid;

	private static FFieldAddress PrimaryAxis_PropertyAddress;

	private static int PrimaryAxis_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.RigControlSettings:PrimaryAxis")]
	public ERigControlAxis PrimaryAxis;

	private static bool Animatable_IsValid;

	private static FFieldAddress Animatable_PropertyAddress;

	private static int Animatable_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.RigControlSettings:bAnimatable")]
	public bool Animatable;

	private static bool LimitEnabled_IsValid;

	private static FFieldAddress LimitEnabled_PropertyAddress;

	private static int LimitEnabled_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/ControlRig.RigControlSettings:LimitEnabled")]
	public List<FRigControlLimitEnabled> LimitEnabled;

	private static bool DrawLimits_IsValid;

	private static FFieldAddress DrawLimits_PropertyAddress;

	private static int DrawLimits_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.RigControlSettings:bDrawLimits")]
	public bool DrawLimits;

	private static bool MinimumValue_IsValid;

	private static int MinimumValue_Offset;

	[UProperty(Flags = (PropFlags)4503668346847236uL)]
	[UMetaPath("/Script/ControlRig.RigControlSettings:MinimumValue")]
	public FRigControlValue MinimumValue;

	private static bool MaximumValue_IsValid;

	private static int MaximumValue_Offset;

	[UProperty(Flags = (PropFlags)4503668346847236uL)]
	[UMetaPath("/Script/ControlRig.RigControlSettings:MaximumValue")]
	public FRigControlValue MaximumValue;

	private static bool ShapeEnabled_IsValid;

	private static FFieldAddress ShapeEnabled_PropertyAddress;

	private static int ShapeEnabled_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.RigControlSettings:bShapeEnabled")]
	public bool ShapeEnabled;

	private static bool ShapeVisible_IsValid;

	private static FFieldAddress ShapeVisible_PropertyAddress;

	private static int ShapeVisible_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.RigControlSettings:bShapeVisible")]
	public bool ShapeVisible;

	private static bool ShapeName_IsValid;

	private static int ShapeName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.RigControlSettings:ShapeName")]
	public FName ShapeName;

	private static bool ShapeColor_IsValid;

	private static int ShapeColor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.RigControlSettings:ShapeColor")]
	public FLinearColor ShapeColor;

	private static bool IsTransientControl_IsValid;

	private static FFieldAddress IsTransientControl_PropertyAddress;

	private static int IsTransientControl_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/ControlRig.RigControlSettings:bIsTransientControl")]
	public bool IsTransientControl;

	private static bool ControlEnum_IsValid;

	private static int ControlEnum_Offset;

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/ControlRig.RigControlSettings:ControlEnum")]
	public UEnum ControlEnum;

	private static bool Customization_IsValid;

	private static int Customization_Offset;

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/ControlRig.RigControlSettings:Customization")]
	public FRigControlElementCustomization Customization;

	private static bool FRigControlSettings_IsValid;

	private static int FRigControlSettings_StructSize;

	public FRigControlSettings Copy()
	{
		FRigControlSettings result = this;
		if (LimitEnabled != null)
		{
			result.LimitEnabled = new List<FRigControlLimitEnabled>(LimitEnabled);
		}
		return result;
	}

	public static FRigControlSettings FromNative(IntPtr nativeBuffer)
	{
		return new FRigControlSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigControlSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigControlSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigControlSettings(nativeBuffer + arrayIndex * FRigControlSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigControlSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigControlSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigControlSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigControlSettings");
			return;
		}
		EnumMarshaler<ERigControlType>.ToNative(IntPtr.Add(nativeStruct, ControlType_Offset), 0, ControlType_PropertyAddress.Address, ControlType);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, DisplayName_Offset), DisplayName);
		EnumMarshaler<ERigControlAxis>.ToNative(IntPtr.Add(nativeStruct, PrimaryAxis_Offset), 0, PrimaryAxis_PropertyAddress.Address, PrimaryAxis);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Animatable_Offset), 0, Animatable_PropertyAddress.Address, Animatable);
		new TArrayCopyMarshaler<FRigControlLimitEnabled>(1, LimitEnabled_PropertyAddress, CachedMarshalingDelegates<FRigControlLimitEnabled, FRigControlLimitEnabled>.FromNative, CachedMarshalingDelegates<FRigControlLimitEnabled, FRigControlLimitEnabled>.ToNative).ToNative(IntPtr.Add(nativeStruct, LimitEnabled_Offset), LimitEnabled);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DrawLimits_Offset), 0, DrawLimits_PropertyAddress.Address, DrawLimits);
		FRigControlValue.ToNative(IntPtr.Add(nativeStruct, MinimumValue_Offset), MinimumValue);
		FRigControlValue.ToNative(IntPtr.Add(nativeStruct, MaximumValue_Offset), MaximumValue);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ShapeEnabled_Offset), 0, ShapeEnabled_PropertyAddress.Address, ShapeEnabled);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ShapeVisible_Offset), 0, ShapeVisible_PropertyAddress.Address, ShapeVisible);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ShapeName_Offset), ShapeName);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, ShapeColor_Offset), ShapeColor);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsTransientControl_Offset), 0, IsTransientControl_PropertyAddress.Address, IsTransientControl);
		UObjectMarshaler<UEnum>.ToNative(IntPtr.Add(nativeStruct, ControlEnum_Offset), ControlEnum);
		FRigControlElementCustomization.ToNative(IntPtr.Add(nativeStruct, Customization_Offset), Customization);
	}

	public FRigControlSettings(IntPtr nativeStruct)
	{
		if (!FRigControlSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigControlSettings");
			ControlType = ERigControlType.Bool;
			DisplayName = default(FName);
			PrimaryAxis = ERigControlAxis.X;
			Animatable = false;
			LimitEnabled = null;
			DrawLimits = false;
			MinimumValue = default(FRigControlValue);
			MaximumValue = default(FRigControlValue);
			ShapeEnabled = false;
			ShapeVisible = false;
			ShapeName = default(FName);
			ShapeColor = default(FLinearColor);
			IsTransientControl = false;
			ControlEnum = null;
			Customization = default(FRigControlElementCustomization);
		}
		else
		{
			ControlType = EnumMarshaler<ERigControlType>.FromNative(IntPtr.Add(nativeStruct, ControlType_Offset), 0, ControlType_PropertyAddress.Address);
			DisplayName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, DisplayName_Offset));
			PrimaryAxis = EnumMarshaler<ERigControlAxis>.FromNative(IntPtr.Add(nativeStruct, PrimaryAxis_Offset), 0, PrimaryAxis_PropertyAddress.Address);
			Animatable = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Animatable_Offset), 0, Animatable_PropertyAddress.Address);
			LimitEnabled = new TArrayCopyMarshaler<FRigControlLimitEnabled>(1, LimitEnabled_PropertyAddress, CachedMarshalingDelegates<FRigControlLimitEnabled, FRigControlLimitEnabled>.FromNative, CachedMarshalingDelegates<FRigControlLimitEnabled, FRigControlLimitEnabled>.ToNative).FromNative(IntPtr.Add(nativeStruct, LimitEnabled_Offset));
			DrawLimits = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DrawLimits_Offset), 0, DrawLimits_PropertyAddress.Address);
			MinimumValue = FRigControlValue.FromNative(IntPtr.Add(nativeStruct, MinimumValue_Offset));
			MaximumValue = FRigControlValue.FromNative(IntPtr.Add(nativeStruct, MaximumValue_Offset));
			ShapeEnabled = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ShapeEnabled_Offset), 0, ShapeEnabled_PropertyAddress.Address);
			ShapeVisible = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ShapeVisible_Offset), 0, ShapeVisible_PropertyAddress.Address);
			ShapeName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ShapeName_Offset));
			ShapeColor = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, ShapeColor_Offset));
			IsTransientControl = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsTransientControl_Offset), 0, IsTransientControl_PropertyAddress.Address);
			ControlEnum = UObjectMarshaler<UEnum>.FromNative(IntPtr.Add(nativeStruct, ControlEnum_Offset));
			Customization = FRigControlElementCustomization.FromNative(IntPtr.Add(nativeStruct, Customization_Offset));
		}
	}

	static FRigControlSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigControlSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigControlSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigControlSettings");
		FRigControlSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref ControlType_PropertyAddress, intPtr, "ControlType");
		ControlType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ControlType");
		ControlType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ControlType", Classes.FEnumProperty);
		DisplayName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DisplayName");
		DisplayName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DisplayName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref PrimaryAxis_PropertyAddress, intPtr, "PrimaryAxis");
		PrimaryAxis_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PrimaryAxis");
		PrimaryAxis_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PrimaryAxis", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref Animatable_PropertyAddress, intPtr, "bAnimatable");
		Animatable_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAnimatable");
		Animatable_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAnimatable", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LimitEnabled_PropertyAddress, intPtr, "LimitEnabled");
		LimitEnabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LimitEnabled");
		LimitEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LimitEnabled", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawLimits_PropertyAddress, intPtr, "bDrawLimits");
		DrawLimits_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDrawLimits");
		DrawLimits_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDrawLimits", Classes.FBoolProperty);
		MinimumValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinimumValue");
		MinimumValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinimumValue", Classes.FStructProperty);
		MaximumValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaximumValue");
		MaximumValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaximumValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ShapeEnabled_PropertyAddress, intPtr, "bShapeEnabled");
		ShapeEnabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bShapeEnabled");
		ShapeEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bShapeEnabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ShapeVisible_PropertyAddress, intPtr, "bShapeVisible");
		ShapeVisible_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bShapeVisible");
		ShapeVisible_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bShapeVisible", Classes.FBoolProperty);
		ShapeName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShapeName");
		ShapeName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShapeName", Classes.FNameProperty);
		ShapeColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShapeColor");
		ShapeColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShapeColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsTransientControl_PropertyAddress, intPtr, "bIsTransientControl");
		IsTransientControl_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsTransientControl");
		IsTransientControl_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsTransientControl", Classes.FBoolProperty);
		ControlEnum_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ControlEnum");
		ControlEnum_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ControlEnum", Classes.FObjectProperty);
		Customization_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Customization");
		Customization_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Customization", Classes.FStructProperty);
		FRigControlSettings_IsValid = intPtr != IntPtr.Zero && ControlType_IsValid && DisplayName_IsValid && PrimaryAxis_IsValid && Animatable_IsValid && LimitEnabled_IsValid && DrawLimits_IsValid && MinimumValue_IsValid && MaximumValue_IsValid && ShapeEnabled_IsValid && ShapeVisible_IsValid && ShapeName_IsValid && ShapeColor_IsValid && IsTransientControl_IsValid && ControlEnum_IsValid && Customization_IsValid;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigControlSettings", FRigControlSettings_IsValid);
	}
}
