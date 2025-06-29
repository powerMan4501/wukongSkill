using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.GSInputActionKeyMapping", "UnrealExtent", UnrealModuleType.Game)]
public struct FGSInputActionKeyMapping
{
	private static bool ActionName_IsValid;

	private static int ActionName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.GSInputActionKeyMapping:ActionName")]
	public FName ActionName;

	private static bool Shift_IsValid;

	private static FFieldAddress Shift_PropertyAddress;

	private static int Shift_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/UnrealExtent.GSInputActionKeyMapping:bShift")]
	public bool Shift;

	private static bool Ctrl_IsValid;

	private static FFieldAddress Ctrl_PropertyAddress;

	private static int Ctrl_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/UnrealExtent.GSInputActionKeyMapping:bCtrl")]
	public bool Ctrl;

	private static bool Alt_IsValid;

	private static FFieldAddress Alt_PropertyAddress;

	private static int Alt_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/UnrealExtent.GSInputActionKeyMapping:bAlt")]
	public bool Alt;

	private static bool Cmd_IsValid;

	private static FFieldAddress Cmd_PropertyAddress;

	private static int Cmd_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/UnrealExtent.GSInputActionKeyMapping:bCmd")]
	public bool Cmd;

	private static bool Key_IsValid;

	private static int Key_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.GSInputActionKeyMapping:Key")]
	public FName Key;

	private static bool FGSInputActionKeyMapping_IsValid;

	private static int FGSInputActionKeyMapping_StructSize;

	public FGSInputActionKeyMapping Copy()
	{
		return this;
	}

	public static FGSInputActionKeyMapping FromNative(IntPtr nativeBuffer)
	{
		return new FGSInputActionKeyMapping(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSInputActionKeyMapping value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSInputActionKeyMapping FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSInputActionKeyMapping(nativeBuffer + arrayIndex * FGSInputActionKeyMapping_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSInputActionKeyMapping value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSInputActionKeyMapping_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSInputActionKeyMapping_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.GSInputActionKeyMapping");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ActionName_Offset), ActionName);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Shift_Offset), 0, Shift_PropertyAddress.Address, Shift);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Ctrl_Offset), 0, Ctrl_PropertyAddress.Address, Ctrl);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Alt_Offset), 0, Alt_PropertyAddress.Address, Alt);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Cmd_Offset), 0, Cmd_PropertyAddress.Address, Cmd);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Key_Offset), Key);
	}

	public FGSInputActionKeyMapping(IntPtr nativeStruct)
	{
		if (!FGSInputActionKeyMapping_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.GSInputActionKeyMapping");
			ActionName = default(FName);
			Shift = false;
			Ctrl = false;
			Alt = false;
			Cmd = false;
			Key = default(FName);
		}
		else
		{
			ActionName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ActionName_Offset));
			Shift = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Shift_Offset), 0, Shift_PropertyAddress.Address);
			Ctrl = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Ctrl_Offset), 0, Ctrl_PropertyAddress.Address);
			Alt = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Alt_Offset), 0, Alt_PropertyAddress.Address);
			Cmd = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Cmd_Offset), 0, Cmd_PropertyAddress.Address);
			Key = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Key_Offset));
		}
	}

	static FGSInputActionKeyMapping()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSInputActionKeyMapping)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSInputActionKeyMapping));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UnrealExtent.GSInputActionKeyMapping");
		FGSInputActionKeyMapping_StructSize = NativeReflection.GetStructSize(intPtr);
		ActionName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActionName");
		ActionName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActionName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref Shift_PropertyAddress, intPtr, "bShift");
		Shift_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bShift");
		Shift_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bShift", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Ctrl_PropertyAddress, intPtr, "bCtrl");
		Ctrl_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCtrl");
		Ctrl_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCtrl", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Alt_PropertyAddress, intPtr, "bAlt");
		Alt_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAlt");
		Alt_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAlt", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Cmd_PropertyAddress, intPtr, "bCmd");
		Cmd_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCmd");
		Cmd_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCmd", Classes.FBoolProperty);
		Key_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Key");
		Key_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Key", Classes.FNameProperty);
		FGSInputActionKeyMapping_IsValid = intPtr != IntPtr.Zero && ActionName_IsValid && Shift_IsValid && Ctrl_IsValid && Alt_IsValid && Cmd_IsValid && Key_IsValid;
		NativeReflection.LogStructIsValid("/Script/UnrealExtent.GSInputActionKeyMapping", FGSInputActionKeyMapping_IsValid);
	}
}
