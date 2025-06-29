using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigElementKey", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigElementKey
{
	private static bool Type_IsValid;

	private static FFieldAddress Type_PropertyAddress;

	private static int Type_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.RigElementKey:Type")]
	public ERigElementType Type;

	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.RigElementKey:Name")]
	public FName Name;

	private static bool FRigElementKey_IsValid;

	private static int FRigElementKey_StructSize;

	public FRigElementKey Copy()
	{
		return this;
	}

	public static FRigElementKey FromNative(IntPtr nativeBuffer)
	{
		return new FRigElementKey(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigElementKey value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigElementKey FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigElementKey(nativeBuffer + arrayIndex * FRigElementKey_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigElementKey value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigElementKey_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigElementKey_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigElementKey");
			return;
		}
		EnumMarshaler<ERigElementType>.ToNative(IntPtr.Add(nativeStruct, Type_Offset), 0, Type_PropertyAddress.Address, Type);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
	}

	public FRigElementKey(IntPtr nativeStruct)
	{
		if (!FRigElementKey_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigElementKey");
			Type = ERigElementType.None;
			Name = default(FName);
		}
		else
		{
			Type = EnumMarshaler<ERigElementType>.FromNative(IntPtr.Add(nativeStruct, Type_Offset), 0, Type_PropertyAddress.Address);
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
		}
	}

	static FRigElementKey()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigElementKey)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigElementKey));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigElementKey");
		FRigElementKey_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Type_PropertyAddress, intPtr, "Type");
		Type_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Type");
		Type_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Type", Classes.FEnumProperty);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		FRigElementKey_IsValid = intPtr != IntPtr.Zero && Type_IsValid && Name_IsValid;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigElementKey", FRigElementKey_IsValid);
	}
}
