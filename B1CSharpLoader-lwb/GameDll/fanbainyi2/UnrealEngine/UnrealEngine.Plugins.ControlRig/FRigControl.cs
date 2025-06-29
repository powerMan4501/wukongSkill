using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigControl", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigControl
{
	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/ControlRig.RigElement:Name")]
	public FName Name;

	private static bool Index_IsValid;

	private static int Index_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/ControlRig.RigElement:Index")]
	public int Index;

	private static bool ControlType_IsValid;

	private static FFieldAddress ControlType_PropertyAddress;

	private static int ControlType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.RigControl:ControlType")]
	public ERigControlType ControlType;

	private static bool DisplayName_IsValid;

	private static int DisplayName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.RigControl:DisplayName")]
	public FName DisplayName;

	private static bool ParentName_IsValid;

	private static int ParentName_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/ControlRig.RigControl:ParentName")]
	public FName ParentName;

	private static bool ParentIndex_IsValid;

	private static int ParentIndex_Offset;

	[UProperty(Flags = (PropFlags)6755469234283028uL)]
	[UMetaPath("/Script/ControlRig.RigControl:ParentIndex")]
	public int ParentIndex;

	private static bool SpaceName_IsValid;

	private static int SpaceName_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/ControlRig.RigControl:SpaceName")]
	public FName SpaceName;

	private static bool SpaceIndex_IsValid;

	private static int SpaceIndex_Offset;

	[UProperty(Flags = (PropFlags)6755469234283028uL)]
	[UMetaPath("/Script/ControlRig.RigControl:SpaceIndex")]
	public int SpaceIndex;

	private static bool OffsetTransform_IsValid;

	private static int OffsetTransform_Offset;

	[UProperty(Flags = (PropFlags)4503669420589061uL)]
	[UMetaPath("/Script/ControlRig.RigControl:OffsetTransform")]
	public FTransform OffsetTransform;

	private static bool InitialValue_IsValid;

	private static int InitialValue_Offset;

	[UProperty(Flags = (PropFlags)4503668346978325uL)]
	[UMetaPath("/Script/ControlRig.RigControl:InitialValue")]
	public FRigControlValue InitialValue;

	private static bool Value_IsValid;

	private static int Value_Offset;

	[UProperty(Flags = (PropFlags)4503668346986517uL)]
	[UMetaPath("/Script/ControlRig.RigControl:Value")]
	public FRigControlValue Value;

	private static bool PrimaryAxis_IsValid;

	private static FFieldAddress PrimaryAxis_PropertyAddress;

	private static int PrimaryAxis_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.RigControl:PrimaryAxis")]
	public ERigControlAxis PrimaryAxis;

	private static bool Animatable_IsValid;

	private static FFieldAddress Animatable_PropertyAddress;

	private static int Animatable_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.RigControl:bAnimatable")]
	public bool Animatable;

	private static bool LimitTranslation_IsValid;

	private static FFieldAddress LimitTranslation_PropertyAddress;

	private static int LimitTranslation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.RigControl:bLimitTranslation")]
	public bool LimitTranslation;

	private static bool LimitRotation_IsValid;

	private static FFieldAddress LimitRotation_PropertyAddress;

	private static int LimitRotation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.RigControl:bLimitRotation")]
	public bool LimitRotation;

	private static bool LimitScale_IsValid;

	private static FFieldAddress LimitScale_PropertyAddress;

	private static int LimitScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.RigControl:bLimitScale")]
	public bool LimitScale;

	private static bool DrawLimits_IsValid;

	private static FFieldAddress DrawLimits_PropertyAddress;

	private static int DrawLimits_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.RigControl:bDrawLimits")]
	public bool DrawLimits;

	private static bool MinimumValue_IsValid;

	private static int MinimumValue_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/ControlRig.RigControl:MinimumValue")]
	public FRigControlValue MinimumValue;

	private static bool MaximumValue_IsValid;

	private static int MaximumValue_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/ControlRig.RigControl:MaximumValue")]
	public FRigControlValue MaximumValue;

	private static bool GizmoEnabled_IsValid;

	private static FFieldAddress GizmoEnabled_PropertyAddress;

	private static int GizmoEnabled_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.RigControl:bGizmoEnabled")]
	public bool GizmoEnabled;

	private static bool GizmoVisible_IsValid;

	private static FFieldAddress GizmoVisible_PropertyAddress;

	private static int GizmoVisible_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.RigControl:bGizmoVisible")]
	public bool GizmoVisible;

	private static bool GizmoName_IsValid;

	private static int GizmoName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.RigControl:GizmoName")]
	public FName GizmoName;

	private static bool GizmoTransform_IsValid;

	private static int GizmoTransform_Offset;

	[UProperty(Flags = (PropFlags)4503669420589061uL)]
	[UMetaPath("/Script/ControlRig.RigControl:GizmoTransform")]
	public FTransform GizmoTransform;

	private static bool GizmoColor_IsValid;

	private static int GizmoColor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.RigControl:GizmoColor")]
	public FLinearColor GizmoColor;

	private static bool IsTransientControl_IsValid;

	private static FFieldAddress IsTransientControl_PropertyAddress;

	private static int IsTransientControl_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.RigControl:bIsTransientControl")]
	public bool IsTransientControl;

	private static bool ControlEnum_IsValid;

	private static int ControlEnum_Offset;

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/ControlRig.RigControl:ControlEnum")]
	public UEnum ControlEnum;

	private static bool FRigControl_IsValid;

	private static int FRigControl_StructSize;

	public FRigControl Copy()
	{
		return this;
	}

	public static FRigControl FromNative(IntPtr nativeBuffer)
	{
		return new FRigControl(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigControl value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigControl FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigControl(nativeBuffer + arrayIndex * FRigControl_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigControl value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigControl_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigControl_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigControl");
			return;
		}
		EnumMarshaler<ERigControlType>.ToNative(IntPtr.Add(nativeStruct, ControlType_Offset), 0, ControlType_PropertyAddress.Address, ControlType);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, DisplayName_Offset), DisplayName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ParentName_Offset), ParentName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ParentIndex_Offset), ParentIndex);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, SpaceName_Offset), SpaceName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SpaceIndex_Offset), SpaceIndex);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(nativeStruct, OffsetTransform_Offset), OffsetTransform);
		FRigControlValue.ToNative(IntPtr.Add(nativeStruct, InitialValue_Offset), InitialValue);
		FRigControlValue.ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
		EnumMarshaler<ERigControlAxis>.ToNative(IntPtr.Add(nativeStruct, PrimaryAxis_Offset), 0, PrimaryAxis_PropertyAddress.Address, PrimaryAxis);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Animatable_Offset), 0, Animatable_PropertyAddress.Address, Animatable);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, LimitTranslation_Offset), 0, LimitTranslation_PropertyAddress.Address, LimitTranslation);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, LimitRotation_Offset), 0, LimitRotation_PropertyAddress.Address, LimitRotation);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, LimitScale_Offset), 0, LimitScale_PropertyAddress.Address, LimitScale);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DrawLimits_Offset), 0, DrawLimits_PropertyAddress.Address, DrawLimits);
		FRigControlValue.ToNative(IntPtr.Add(nativeStruct, MinimumValue_Offset), MinimumValue);
		FRigControlValue.ToNative(IntPtr.Add(nativeStruct, MaximumValue_Offset), MaximumValue);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, GizmoEnabled_Offset), 0, GizmoEnabled_PropertyAddress.Address, GizmoEnabled);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, GizmoVisible_Offset), 0, GizmoVisible_PropertyAddress.Address, GizmoVisible);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, GizmoName_Offset), GizmoName);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(nativeStruct, GizmoTransform_Offset), GizmoTransform);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, GizmoColor_Offset), GizmoColor);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsTransientControl_Offset), 0, IsTransientControl_PropertyAddress.Address, IsTransientControl);
		UObjectMarshaler<UEnum>.ToNative(IntPtr.Add(nativeStruct, ControlEnum_Offset), ControlEnum);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Index_Offset), Index);
	}

	public FRigControl(IntPtr nativeStruct)
	{
		if (!FRigControl_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigControl");
			ControlType = ERigControlType.Bool;
			DisplayName = default(FName);
			ParentName = default(FName);
			ParentIndex = 0;
			SpaceName = default(FName);
			SpaceIndex = 0;
			OffsetTransform = default(FTransform);
			InitialValue = default(FRigControlValue);
			Value = default(FRigControlValue);
			PrimaryAxis = ERigControlAxis.X;
			Animatable = false;
			LimitTranslation = false;
			LimitRotation = false;
			LimitScale = false;
			DrawLimits = false;
			MinimumValue = default(FRigControlValue);
			MaximumValue = default(FRigControlValue);
			GizmoEnabled = false;
			GizmoVisible = false;
			GizmoName = default(FName);
			GizmoTransform = default(FTransform);
			GizmoColor = default(FLinearColor);
			IsTransientControl = false;
			ControlEnum = null;
			Name = default(FName);
			Index = 0;
		}
		else
		{
			ControlType = EnumMarshaler<ERigControlType>.FromNative(IntPtr.Add(nativeStruct, ControlType_Offset), 0, ControlType_PropertyAddress.Address);
			DisplayName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, DisplayName_Offset));
			ParentName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ParentName_Offset));
			ParentIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ParentIndex_Offset));
			SpaceName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, SpaceName_Offset));
			SpaceIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SpaceIndex_Offset));
			OffsetTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(nativeStruct, OffsetTransform_Offset));
			InitialValue = FRigControlValue.FromNative(IntPtr.Add(nativeStruct, InitialValue_Offset));
			Value = FRigControlValue.FromNative(IntPtr.Add(nativeStruct, Value_Offset));
			PrimaryAxis = EnumMarshaler<ERigControlAxis>.FromNative(IntPtr.Add(nativeStruct, PrimaryAxis_Offset), 0, PrimaryAxis_PropertyAddress.Address);
			Animatable = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Animatable_Offset), 0, Animatable_PropertyAddress.Address);
			LimitTranslation = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, LimitTranslation_Offset), 0, LimitTranslation_PropertyAddress.Address);
			LimitRotation = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, LimitRotation_Offset), 0, LimitRotation_PropertyAddress.Address);
			LimitScale = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, LimitScale_Offset), 0, LimitScale_PropertyAddress.Address);
			DrawLimits = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DrawLimits_Offset), 0, DrawLimits_PropertyAddress.Address);
			MinimumValue = FRigControlValue.FromNative(IntPtr.Add(nativeStruct, MinimumValue_Offset));
			MaximumValue = FRigControlValue.FromNative(IntPtr.Add(nativeStruct, MaximumValue_Offset));
			GizmoEnabled = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, GizmoEnabled_Offset), 0, GizmoEnabled_PropertyAddress.Address);
			GizmoVisible = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, GizmoVisible_Offset), 0, GizmoVisible_PropertyAddress.Address);
			GizmoName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, GizmoName_Offset));
			GizmoTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(nativeStruct, GizmoTransform_Offset));
			GizmoColor = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, GizmoColor_Offset));
			IsTransientControl = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsTransientControl_Offset), 0, IsTransientControl_PropertyAddress.Address);
			ControlEnum = UObjectMarshaler<UEnum>.FromNative(IntPtr.Add(nativeStruct, ControlEnum_Offset));
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
			Index = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Index_Offset));
		}
	}

	static FRigControl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigControl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigControl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigControl");
		FRigControl_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		Index_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Index");
		Index_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ControlType_PropertyAddress, intPtr, "ControlType");
		ControlType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ControlType");
		ControlType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ControlType", Classes.FEnumProperty);
		DisplayName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DisplayName");
		DisplayName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DisplayName", Classes.FNameProperty);
		ParentName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParentName");
		ParentName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParentName", Classes.FNameProperty);
		ParentIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParentIndex");
		ParentIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParentIndex", Classes.FIntProperty);
		SpaceName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpaceName");
		SpaceName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpaceName", Classes.FNameProperty);
		SpaceIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpaceIndex");
		SpaceIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpaceIndex", Classes.FIntProperty);
		OffsetTransform_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OffsetTransform");
		OffsetTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OffsetTransform", Classes.FStructProperty);
		InitialValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InitialValue");
		InitialValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InitialValue", Classes.FStructProperty);
		Value_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Value", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PrimaryAxis_PropertyAddress, intPtr, "PrimaryAxis");
		PrimaryAxis_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PrimaryAxis");
		PrimaryAxis_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PrimaryAxis", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref Animatable_PropertyAddress, intPtr, "bAnimatable");
		Animatable_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAnimatable");
		Animatable_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAnimatable", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LimitTranslation_PropertyAddress, intPtr, "bLimitTranslation");
		LimitTranslation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bLimitTranslation");
		LimitTranslation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bLimitTranslation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LimitRotation_PropertyAddress, intPtr, "bLimitRotation");
		LimitRotation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bLimitRotation");
		LimitRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bLimitRotation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LimitScale_PropertyAddress, intPtr, "bLimitScale");
		LimitScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bLimitScale");
		LimitScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bLimitScale", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawLimits_PropertyAddress, intPtr, "bDrawLimits");
		DrawLimits_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDrawLimits");
		DrawLimits_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDrawLimits", Classes.FBoolProperty);
		MinimumValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinimumValue");
		MinimumValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinimumValue", Classes.FStructProperty);
		MaximumValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaximumValue");
		MaximumValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaximumValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GizmoEnabled_PropertyAddress, intPtr, "bGizmoEnabled");
		GizmoEnabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bGizmoEnabled");
		GizmoEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bGizmoEnabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GizmoVisible_PropertyAddress, intPtr, "bGizmoVisible");
		GizmoVisible_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bGizmoVisible");
		GizmoVisible_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bGizmoVisible", Classes.FBoolProperty);
		GizmoName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GizmoName");
		GizmoName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GizmoName", Classes.FNameProperty);
		GizmoTransform_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GizmoTransform");
		GizmoTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GizmoTransform", Classes.FStructProperty);
		GizmoColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GizmoColor");
		GizmoColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GizmoColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsTransientControl_PropertyAddress, intPtr, "bIsTransientControl");
		IsTransientControl_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsTransientControl");
		IsTransientControl_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsTransientControl", Classes.FBoolProperty);
		ControlEnum_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ControlEnum");
		ControlEnum_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ControlEnum", Classes.FObjectProperty);
		FRigControl_IsValid = intPtr != IntPtr.Zero && ControlType_IsValid && DisplayName_IsValid && ParentName_IsValid && ParentIndex_IsValid && SpaceName_IsValid && SpaceIndex_IsValid && OffsetTransform_IsValid && InitialValue_IsValid && Value_IsValid && PrimaryAxis_IsValid && Animatable_IsValid && LimitTranslation_IsValid && LimitRotation_IsValid && LimitScale_IsValid && DrawLimits_IsValid && MinimumValue_IsValid && MaximumValue_IsValid && GizmoEnabled_IsValid && GizmoVisible_IsValid && GizmoName_IsValid && GizmoTransform_IsValid && GizmoColor_IsValid && IsTransientControl_IsValid && ControlEnum_IsValid && Name_IsValid && Index_IsValid;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigControl", FRigControl_IsValid);
	}
}
