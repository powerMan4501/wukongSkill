using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UStruct(Flags = 4101)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.ControlRigComponentMappedComponent", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FControlRigComponentMappedComponent
{
	private static bool Component_IsValid;

	private static int Component_Offset;

	[UProperty(Flags = (PropFlags)7881369141641741uL)]
	[UMetaPath("/Script/ControlRig.ControlRigComponentMappedComponent:Component")]
	public USceneComponent Component;

	private static bool ElementName_IsValid;

	private static int ElementName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.ControlRigComponentMappedComponent:ElementName")]
	public FName ElementName;

	private static bool ElementType_IsValid;

	private static FFieldAddress ElementType_PropertyAddress;

	private static int ElementType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.ControlRigComponentMappedComponent:ElementType")]
	public ERigElementType ElementType;

	private static bool Direction_IsValid;

	private static FFieldAddress Direction_PropertyAddress;

	private static int Direction_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.ControlRigComponentMappedComponent:Direction")]
	public EControlRigComponentMapDirection Direction;

	private static bool FControlRigComponentMappedComponent_IsValid;

	private static int FControlRigComponentMappedComponent_StructSize;

	public FControlRigComponentMappedComponent Copy()
	{
		return this;
	}

	public static FControlRigComponentMappedComponent FromNative(IntPtr nativeBuffer)
	{
		return new FControlRigComponentMappedComponent(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FControlRigComponentMappedComponent value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FControlRigComponentMappedComponent FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FControlRigComponentMappedComponent(nativeBuffer + arrayIndex * FControlRigComponentMappedComponent_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FControlRigComponentMappedComponent value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FControlRigComponentMappedComponent_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FControlRigComponentMappedComponent_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.ControlRigComponentMappedComponent");
			return;
		}
		UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(nativeStruct, Component_Offset), Component);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ElementName_Offset), ElementName);
		EnumMarshaler<ERigElementType>.ToNative(IntPtr.Add(nativeStruct, ElementType_Offset), 0, ElementType_PropertyAddress.Address, ElementType);
		EnumMarshaler<EControlRigComponentMapDirection>.ToNative(IntPtr.Add(nativeStruct, Direction_Offset), 0, Direction_PropertyAddress.Address, Direction);
	}

	public FControlRigComponentMappedComponent(IntPtr nativeStruct)
	{
		if (!FControlRigComponentMappedComponent_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.ControlRigComponentMappedComponent");
			Component = null;
			ElementName = default(FName);
			ElementType = ERigElementType.None;
			Direction = EControlRigComponentMapDirection.Input;
		}
		else
		{
			Component = UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(nativeStruct, Component_Offset));
			ElementName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ElementName_Offset));
			ElementType = EnumMarshaler<ERigElementType>.FromNative(IntPtr.Add(nativeStruct, ElementType_Offset), 0, ElementType_PropertyAddress.Address);
			Direction = EnumMarshaler<EControlRigComponentMapDirection>.FromNative(IntPtr.Add(nativeStruct, Direction_Offset), 0, Direction_PropertyAddress.Address);
		}
	}

	static FControlRigComponentMappedComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FControlRigComponentMappedComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FControlRigComponentMappedComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.ControlRigComponentMappedComponent");
		FControlRigComponentMappedComponent_StructSize = NativeReflection.GetStructSize(intPtr);
		Component_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Component");
		Component_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Component", Classes.FObjectProperty);
		ElementName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ElementName");
		ElementName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ElementName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ElementType_PropertyAddress, intPtr, "ElementType");
		ElementType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ElementType");
		ElementType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ElementType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref Direction_PropertyAddress, intPtr, "Direction");
		Direction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Direction");
		Direction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Direction", Classes.FEnumProperty);
		FControlRigComponentMappedComponent_IsValid = intPtr != IntPtr.Zero && Component_IsValid && ElementName_IsValid && ElementType_IsValid && Direction_IsValid;
		NativeReflection.LogStructIsValid("/Script/ControlRig.ControlRigComponentMappedComponent", FControlRigComponentMappedComponent_IsValid);
	}
}
