using System;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.InputActionKeyMapping", "Engine", UnrealModuleType.Engine)]
public struct FInputActionKeyMapping
{
	private static bool ActionName_IsValid;

	private static int ActionName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InputActionKeyMapping:ActionName")]
	public FName ActionName;

	private static bool Shift_IsValid;

	private static FFieldAddress Shift_PropertyAddress;

	private static int Shift_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.InputActionKeyMapping:bShift")]
	public bool Shift;

	private static bool Ctrl_IsValid;

	private static FFieldAddress Ctrl_PropertyAddress;

	private static int Ctrl_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.InputActionKeyMapping:bCtrl")]
	public bool Ctrl;

	private static bool Alt_IsValid;

	private static FFieldAddress Alt_PropertyAddress;

	private static int Alt_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.InputActionKeyMapping:bAlt")]
	public bool Alt;

	private static bool Cmd_IsValid;

	private static FFieldAddress Cmd_PropertyAddress;

	private static int Cmd_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.InputActionKeyMapping:bCmd")]
	public bool Cmd;

	private static bool Key_IsValid;

	private static int Key_Offset;

	[UProperty(Flags = (PropFlags)6755399441055749uL)]
	[UMetaPath("/Script/Engine.InputActionKeyMapping:Key")]
	public FKey Key;

	private static bool FInputActionKeyMapping_IsValid;

	private static int FInputActionKeyMapping_StructSize;

	public FInputActionKeyMapping Copy()
	{
		return this;
	}

	public static FInputActionKeyMapping FromNative(IntPtr nativeBuffer)
	{
		return new FInputActionKeyMapping(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInputActionKeyMapping value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInputActionKeyMapping FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInputActionKeyMapping(nativeBuffer + arrayIndex * FInputActionKeyMapping_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInputActionKeyMapping value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FInputActionKeyMapping_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FInputActionKeyMapping_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.InputActionKeyMapping");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ActionName_Offset), ActionName);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Shift_Offset), 0, Shift_PropertyAddress.Address, Shift);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Ctrl_Offset), 0, Ctrl_PropertyAddress.Address, Ctrl);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Alt_Offset), 0, Alt_PropertyAddress.Address, Alt);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Cmd_Offset), 0, Cmd_PropertyAddress.Address, Cmd);
		FKey.ToNative(IntPtr.Add(nativeStruct, Key_Offset), Key);
	}

	public FInputActionKeyMapping(IntPtr nativeStruct)
	{
		if (!FInputActionKeyMapping_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.InputActionKeyMapping");
			ActionName = default(FName);
			Shift = false;
			Ctrl = false;
			Alt = false;
			Cmd = false;
			Key = default(FKey);
		}
		else
		{
			ActionName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ActionName_Offset));
			Shift = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Shift_Offset), 0, Shift_PropertyAddress.Address);
			Ctrl = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Ctrl_Offset), 0, Ctrl_PropertyAddress.Address);
			Alt = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Alt_Offset), 0, Alt_PropertyAddress.Address);
			Cmd = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Cmd_Offset), 0, Cmd_PropertyAddress.Address);
			Key = FKey.FromNative(IntPtr.Add(nativeStruct, Key_Offset));
		}
	}

	static FInputActionKeyMapping()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInputActionKeyMapping)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInputActionKeyMapping));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.InputActionKeyMapping");
		FInputActionKeyMapping_StructSize = NativeReflection.GetStructSize(intPtr);
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
		Key_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Key", Classes.FStructProperty);
		FInputActionKeyMapping_IsValid = intPtr != IntPtr.Zero && ActionName_IsValid && Shift_IsValid && Ctrl_IsValid && Alt_IsValid && Cmd_IsValid && Key_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.InputActionKeyMapping", FInputActionKeyMapping_IsValid);
	}
}
