using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigSpace", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigSpace
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

	private static bool SpaceType_IsValid;

	private static FFieldAddress SpaceType_PropertyAddress;

	private static int SpaceType_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/ControlRig.RigSpace:SpaceType")]
	public ERigSpaceType SpaceType;

	private static bool ParentName_IsValid;

	private static int ParentName_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/ControlRig.RigSpace:ParentName")]
	public FName ParentName;

	private static bool ParentIndex_IsValid;

	private static int ParentIndex_Offset;

	[UProperty(Flags = (PropFlags)6755469234283028uL)]
	[UMetaPath("/Script/ControlRig.RigSpace:ParentIndex")]
	public int ParentIndex;

	private static bool InitialTransform_IsValid;

	private static int InitialTransform_Offset;

	[UProperty(Flags = (PropFlags)4503669420589077uL)]
	[UMetaPath("/Script/ControlRig.RigSpace:InitialTransform")]
	public FTransform InitialTransform;

	private static bool LocalTransform_IsValid;

	private static int LocalTransform_Offset;

	[UProperty(Flags = (PropFlags)4503669420597269uL)]
	[UMetaPath("/Script/ControlRig.RigSpace:LocalTransform")]
	public FTransform LocalTransform;

	private static bool FRigSpace_IsValid;

	private static int FRigSpace_StructSize;

	public FRigSpace Copy()
	{
		return this;
	}

	public static FRigSpace FromNative(IntPtr nativeBuffer)
	{
		return new FRigSpace(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigSpace value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigSpace FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigSpace(nativeBuffer + arrayIndex * FRigSpace_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigSpace value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigSpace_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigSpace_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigSpace");
			return;
		}
		EnumMarshaler<ERigSpaceType>.ToNative(IntPtr.Add(nativeStruct, SpaceType_Offset), 0, SpaceType_PropertyAddress.Address, SpaceType);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ParentName_Offset), ParentName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ParentIndex_Offset), ParentIndex);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(nativeStruct, InitialTransform_Offset), InitialTransform);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(nativeStruct, LocalTransform_Offset), LocalTransform);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Index_Offset), Index);
	}

	public FRigSpace(IntPtr nativeStruct)
	{
		if (!FRigSpace_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigSpace");
			SpaceType = ERigSpaceType.Global;
			ParentName = default(FName);
			ParentIndex = 0;
			InitialTransform = default(FTransform);
			LocalTransform = default(FTransform);
			Name = default(FName);
			Index = 0;
		}
		else
		{
			SpaceType = EnumMarshaler<ERigSpaceType>.FromNative(IntPtr.Add(nativeStruct, SpaceType_Offset), 0, SpaceType_PropertyAddress.Address);
			ParentName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ParentName_Offset));
			ParentIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ParentIndex_Offset));
			InitialTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(nativeStruct, InitialTransform_Offset));
			LocalTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(nativeStruct, LocalTransform_Offset));
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
			Index = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Index_Offset));
		}
	}

	static FRigSpace()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigSpace)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigSpace));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigSpace");
		FRigSpace_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		Index_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Index");
		Index_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SpaceType_PropertyAddress, intPtr, "SpaceType");
		SpaceType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpaceType");
		SpaceType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpaceType", Classes.FEnumProperty);
		ParentName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParentName");
		ParentName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParentName", Classes.FNameProperty);
		ParentIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParentIndex");
		ParentIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParentIndex", Classes.FIntProperty);
		InitialTransform_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InitialTransform");
		InitialTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InitialTransform", Classes.FStructProperty);
		LocalTransform_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LocalTransform");
		LocalTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LocalTransform", Classes.FStructProperty);
		FRigSpace_IsValid = intPtr != IntPtr.Zero && SpaceType_IsValid && ParentName_IsValid && ParentIndex_IsValid && InitialTransform_IsValid && LocalTransform_IsValid && Name_IsValid && Index_IsValid;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigSpace", FRigSpace_IsValid);
	}
}
