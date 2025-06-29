using System;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Slate;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Slate.InputChord", "Slate", UnrealModuleType.Engine)]
public struct FInputChord
{
	private static bool Key_IsValid;

	private static int Key_Offset;

	[UProperty(Flags = (PropFlags)6755399441055749uL)]
	[UMetaPath("/Script/Slate.InputChord:Key")]
	public FKey Key;

	private static bool Shift_IsValid;

	private static FFieldAddress Shift_PropertyAddress;

	private static int Shift_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Slate.InputChord:bShift")]
	public bool Shift;

	private static bool Ctrl_IsValid;

	private static FFieldAddress Ctrl_PropertyAddress;

	private static int Ctrl_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Slate.InputChord:bCtrl")]
	public bool Ctrl;

	private static bool Alt_IsValid;

	private static FFieldAddress Alt_PropertyAddress;

	private static int Alt_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Slate.InputChord:bAlt")]
	public bool Alt;

	private static bool Cmd_IsValid;

	private static FFieldAddress Cmd_PropertyAddress;

	private static int Cmd_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Slate.InputChord:bCmd")]
	public bool Cmd;

	private static bool FInputChord_IsValid;

	private static int FInputChord_StructSize;

	public FInputChord Copy()
	{
		return this;
	}

	public static FInputChord FromNative(IntPtr nativeBuffer)
	{
		return new FInputChord(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInputChord value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInputChord FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInputChord(nativeBuffer + arrayIndex * FInputChord_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInputChord value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FInputChord_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FInputChord_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Slate.InputChord");
			return;
		}
		FKey.ToNative(IntPtr.Add(nativeStruct, Key_Offset), Key);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Shift_Offset), 0, Shift_PropertyAddress.Address, Shift);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Ctrl_Offset), 0, Ctrl_PropertyAddress.Address, Ctrl);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Alt_Offset), 0, Alt_PropertyAddress.Address, Alt);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Cmd_Offset), 0, Cmd_PropertyAddress.Address, Cmd);
	}

	public FInputChord(IntPtr nativeStruct)
	{
		if (!FInputChord_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Slate.InputChord");
			Key = default(FKey);
			Shift = false;
			Ctrl = false;
			Alt = false;
			Cmd = false;
		}
		else
		{
			Key = FKey.FromNative(IntPtr.Add(nativeStruct, Key_Offset));
			Shift = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Shift_Offset), 0, Shift_PropertyAddress.Address);
			Ctrl = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Ctrl_Offset), 0, Ctrl_PropertyAddress.Address);
			Alt = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Alt_Offset), 0, Alt_PropertyAddress.Address);
			Cmd = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Cmd_Offset), 0, Cmd_PropertyAddress.Address);
		}
	}

	static FInputChord()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInputChord)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInputChord));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Slate.InputChord");
		FInputChord_StructSize = NativeReflection.GetStructSize(intPtr);
		Key_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Key");
		Key_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Key", Classes.FStructProperty);
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
		FInputChord_IsValid = intPtr != IntPtr.Zero && Key_IsValid && Shift_IsValid && Ctrl_IsValid && Alt_IsValid && Cmd_IsValid;
		NativeReflection.LogStructIsValid("/Script/Slate.InputChord", FInputChord_IsValid);
	}
}
