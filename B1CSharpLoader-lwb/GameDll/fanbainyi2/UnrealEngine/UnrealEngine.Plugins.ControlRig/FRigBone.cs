using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigBone", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigBone
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

	private static bool ParentName_IsValid;

	private static int ParentName_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/ControlRig.RigBone:ParentName")]
	public FName ParentName;

	private static bool InitialTransform_IsValid;

	private static int InitialTransform_Offset;

	[UProperty(Flags = (PropFlags)4503669420589077uL)]
	[UMetaPath("/Script/ControlRig.RigBone:InitialTransform")]
	public FTransform InitialTransform;

	private static bool GlobalTransform_IsValid;

	private static int GlobalTransform_Offset;

	[UProperty(Flags = (PropFlags)4503669420597269uL)]
	[UMetaPath("/Script/ControlRig.RigBone:GlobalTransform")]
	public FTransform GlobalTransform;

	private static bool LocalTransform_IsValid;

	private static int LocalTransform_Offset;

	[UProperty(Flags = (PropFlags)4503669420597269uL)]
	[UMetaPath("/Script/ControlRig.RigBone:LocalTransform")]
	public FTransform LocalTransform;

	private static bool Type_IsValid;

	private static FFieldAddress Type_PropertyAddress;

	private static int Type_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/ControlRig.RigBone:Type")]
	public ERigBoneType Type;

	private static bool FRigBone_IsValid;

	private static int FRigBone_StructSize;

	public FRigBone Copy()
	{
		return this;
	}

	public static FRigBone FromNative(IntPtr nativeBuffer)
	{
		return new FRigBone(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigBone value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigBone FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigBone(nativeBuffer + arrayIndex * FRigBone_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigBone value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigBone_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigBone_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigBone");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ParentName_Offset), ParentName);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(nativeStruct, InitialTransform_Offset), InitialTransform);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(nativeStruct, GlobalTransform_Offset), GlobalTransform);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(nativeStruct, LocalTransform_Offset), LocalTransform);
		EnumMarshaler<ERigBoneType>.ToNative(IntPtr.Add(nativeStruct, Type_Offset), 0, Type_PropertyAddress.Address, Type);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Index_Offset), Index);
	}

	public FRigBone(IntPtr nativeStruct)
	{
		if (!FRigBone_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigBone");
			ParentName = default(FName);
			InitialTransform = default(FTransform);
			GlobalTransform = default(FTransform);
			LocalTransform = default(FTransform);
			Type = ERigBoneType.Imported;
			Name = default(FName);
			Index = 0;
		}
		else
		{
			ParentName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ParentName_Offset));
			InitialTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(nativeStruct, InitialTransform_Offset));
			GlobalTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(nativeStruct, GlobalTransform_Offset));
			LocalTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(nativeStruct, LocalTransform_Offset));
			Type = EnumMarshaler<ERigBoneType>.FromNative(IntPtr.Add(nativeStruct, Type_Offset), 0, Type_PropertyAddress.Address);
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
			Index = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Index_Offset));
		}
	}

	static FRigBone()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigBone)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigBone));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigBone");
		FRigBone_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		Index_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Index");
		Index_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Index", Classes.FIntProperty);
		ParentName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParentName");
		ParentName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParentName", Classes.FNameProperty);
		InitialTransform_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InitialTransform");
		InitialTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InitialTransform", Classes.FStructProperty);
		GlobalTransform_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GlobalTransform");
		GlobalTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GlobalTransform", Classes.FStructProperty);
		LocalTransform_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LocalTransform");
		LocalTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LocalTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Type_PropertyAddress, intPtr, "Type");
		Type_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Type");
		Type_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Type", Classes.FEnumProperty);
		FRigBone_IsValid = intPtr != IntPtr.Zero && ParentName_IsValid && InitialTransform_IsValid && GlobalTransform_IsValid && LocalTransform_IsValid && Type_IsValid && Name_IsValid && Index_IsValid;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigBone", FRigBone_IsValid);
	}
}
