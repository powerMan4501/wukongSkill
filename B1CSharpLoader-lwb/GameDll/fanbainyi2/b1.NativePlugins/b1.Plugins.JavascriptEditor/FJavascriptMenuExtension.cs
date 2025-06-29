using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/JavascriptEditor.JavascriptMenuExtension", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public struct FJavascriptMenuExtension
{
	private static bool ExtensionHook_IsValid;

	private static int ExtensionHook_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptMenuExtension:ExtensionHook")]
	public FName ExtensionHook;

	private static bool HookPosition_IsValid;

	private static FFieldAddress HookPosition_PropertyAddress;

	private static int HookPosition_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptMenuExtension:HookPosition")]
	public EJavascriptExtensionHook HookPosition;

	private static bool FJavascriptMenuExtension_IsValid;

	private static int FJavascriptMenuExtension_StructSize;

	public FJavascriptMenuExtension Copy()
	{
		return this;
	}

	public static FJavascriptMenuExtension FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptMenuExtension(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptMenuExtension value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptMenuExtension FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptMenuExtension(nativeBuffer + arrayIndex * FJavascriptMenuExtension_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptMenuExtension value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptMenuExtension_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptMenuExtension_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptMenuExtension");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ExtensionHook_Offset), ExtensionHook);
		EnumMarshaler<EJavascriptExtensionHook>.ToNative(IntPtr.Add(nativeStruct, HookPosition_Offset), 0, HookPosition_PropertyAddress.Address, HookPosition);
	}

	public FJavascriptMenuExtension(IntPtr nativeStruct)
	{
		if (!FJavascriptMenuExtension_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptMenuExtension");
			ExtensionHook = default(FName);
			HookPosition = EJavascriptExtensionHook.Before;
		}
		else
		{
			ExtensionHook = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ExtensionHook_Offset));
			HookPosition = EnumMarshaler<EJavascriptExtensionHook>.FromNative(IntPtr.Add(nativeStruct, HookPosition_Offset), 0, HookPosition_PropertyAddress.Address);
		}
	}

	static FJavascriptMenuExtension()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptMenuExtension)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptMenuExtension));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptEditor.JavascriptMenuExtension");
		FJavascriptMenuExtension_StructSize = NativeReflection.GetStructSize(intPtr);
		ExtensionHook_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ExtensionHook");
		ExtensionHook_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ExtensionHook", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref HookPosition_PropertyAddress, intPtr, "HookPosition");
		HookPosition_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HookPosition");
		HookPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HookPosition", Classes.FByteProperty);
		FJavascriptMenuExtension_IsValid = intPtr != IntPtr.Zero && ExtensionHook_IsValid && HookPosition_IsValid;
		NativeReflection.LogStructIsValid("/Script/JavascriptEditor.JavascriptMenuExtension", FJavascriptMenuExtension_IsValid);
	}
}
