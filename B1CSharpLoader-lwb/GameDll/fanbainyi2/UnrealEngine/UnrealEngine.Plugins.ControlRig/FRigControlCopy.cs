using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigControlCopy", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigControlCopy
{
	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.RigControlCopy:Name")]
	public FName Name;

	private static bool ControlType_IsValid;

	private static FFieldAddress ControlType_PropertyAddress;

	private static int ControlType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.RigControlCopy:ControlType")]
	public ERigControlType ControlType;

	private static bool ParentKey_IsValid;

	private static int ParentKey_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/ControlRig.RigControlCopy:ParentKey")]
	public FRigElementKey ParentKey;

	private static bool OffsetTransform_IsValid;

	private static int OffsetTransform_Offset;

	[UProperty(Flags = (PropFlags)4503669420589061uL)]
	[UMetaPath("/Script/ControlRig.RigControlCopy:OffsetTransform")]
	public FTransform OffsetTransform;

	private static bool ParentTransform_IsValid;

	private static int ParentTransform_Offset;

	[UProperty(Flags = (PropFlags)4503669420589061uL)]
	[UMetaPath("/Script/ControlRig.RigControlCopy:ParentTransform")]
	public FTransform ParentTransform;

	private static bool LocalTransform_IsValid;

	private static int LocalTransform_Offset;

	[UProperty(Flags = (PropFlags)4503669420589061uL)]
	[UMetaPath("/Script/ControlRig.RigControlCopy:LocalTransform")]
	public FTransform LocalTransform;

	private static bool GlobalTransform_IsValid;

	private static int GlobalTransform_Offset;

	[UProperty(Flags = (PropFlags)4503669420589061uL)]
	[UMetaPath("/Script/ControlRig.RigControlCopy:GlobalTransform")]
	public FTransform GlobalTransform;

	private static bool FRigControlCopy_IsValid;

	private static int FRigControlCopy_StructSize;

	public FRigControlCopy Copy()
	{
		return this;
	}

	public static FRigControlCopy FromNative(IntPtr nativeBuffer)
	{
		return new FRigControlCopy(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigControlCopy value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigControlCopy FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigControlCopy(nativeBuffer + arrayIndex * FRigControlCopy_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigControlCopy value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigControlCopy_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigControlCopy_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigControlCopy");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		EnumMarshaler<ERigControlType>.ToNative(IntPtr.Add(nativeStruct, ControlType_Offset), 0, ControlType_PropertyAddress.Address, ControlType);
		FRigElementKey.ToNative(IntPtr.Add(nativeStruct, ParentKey_Offset), ParentKey);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(nativeStruct, OffsetTransform_Offset), OffsetTransform);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(nativeStruct, ParentTransform_Offset), ParentTransform);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(nativeStruct, LocalTransform_Offset), LocalTransform);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(nativeStruct, GlobalTransform_Offset), GlobalTransform);
	}

	public FRigControlCopy(IntPtr nativeStruct)
	{
		if (!FRigControlCopy_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigControlCopy");
			Name = default(FName);
			ControlType = ERigControlType.Bool;
			ParentKey = default(FRigElementKey);
			OffsetTransform = default(FTransform);
			ParentTransform = default(FTransform);
			LocalTransform = default(FTransform);
			GlobalTransform = default(FTransform);
		}
		else
		{
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
			ControlType = EnumMarshaler<ERigControlType>.FromNative(IntPtr.Add(nativeStruct, ControlType_Offset), 0, ControlType_PropertyAddress.Address);
			ParentKey = FRigElementKey.FromNative(IntPtr.Add(nativeStruct, ParentKey_Offset));
			OffsetTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(nativeStruct, OffsetTransform_Offset));
			ParentTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(nativeStruct, ParentTransform_Offset));
			LocalTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(nativeStruct, LocalTransform_Offset));
			GlobalTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(nativeStruct, GlobalTransform_Offset));
		}
	}

	static FRigControlCopy()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigControlCopy)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigControlCopy));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigControlCopy");
		FRigControlCopy_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ControlType_PropertyAddress, intPtr, "ControlType");
		ControlType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ControlType");
		ControlType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ControlType", Classes.FEnumProperty);
		ParentKey_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParentKey");
		ParentKey_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParentKey", Classes.FStructProperty);
		OffsetTransform_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OffsetTransform");
		OffsetTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OffsetTransform", Classes.FStructProperty);
		ParentTransform_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParentTransform");
		ParentTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParentTransform", Classes.FStructProperty);
		LocalTransform_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LocalTransform");
		LocalTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LocalTransform", Classes.FStructProperty);
		GlobalTransform_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GlobalTransform");
		GlobalTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GlobalTransform", Classes.FStructProperty);
		FRigControlCopy_IsValid = intPtr != IntPtr.Zero && Name_IsValid && ControlType_IsValid && ParentKey_IsValid && OffsetTransform_IsValid && ParentTransform_IsValid && LocalTransform_IsValid && GlobalTransform_IsValid;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigControlCopy", FRigControlCopy_IsValid);
	}
}
