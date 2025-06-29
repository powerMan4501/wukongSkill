using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.ToolMenus;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ToolMenus.ScriptSlateIcon", "ToolMenus", UnrealModuleType.Engine)]
public struct FScriptSlateIcon
{
	private static bool StyleSetName_IsValid;

	private static int StyleSetName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ToolMenus.ScriptSlateIcon:StyleSetName")]
	public FName StyleSetName;

	private static bool StyleName_IsValid;

	private static int StyleName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ToolMenus.ScriptSlateIcon:StyleName")]
	public FName StyleName;

	private static bool SmallStyleName_IsValid;

	private static int SmallStyleName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ToolMenus.ScriptSlateIcon:SmallStyleName")]
	public FName SmallStyleName;

	private static bool FScriptSlateIcon_IsValid;

	private static int FScriptSlateIcon_StructSize;

	public FScriptSlateIcon Copy()
	{
		return this;
	}

	public static FScriptSlateIcon FromNative(IntPtr nativeBuffer)
	{
		return new FScriptSlateIcon(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FScriptSlateIcon value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FScriptSlateIcon FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FScriptSlateIcon(nativeBuffer + arrayIndex * FScriptSlateIcon_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FScriptSlateIcon value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FScriptSlateIcon_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FScriptSlateIcon_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ToolMenus.ScriptSlateIcon");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, StyleSetName_Offset), StyleSetName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, StyleName_Offset), StyleName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, SmallStyleName_Offset), SmallStyleName);
	}

	public FScriptSlateIcon(IntPtr nativeStruct)
	{
		if (!FScriptSlateIcon_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ToolMenus.ScriptSlateIcon");
			StyleSetName = default(FName);
			StyleName = default(FName);
			SmallStyleName = default(FName);
		}
		else
		{
			StyleSetName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, StyleSetName_Offset));
			StyleName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, StyleName_Offset));
			SmallStyleName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, SmallStyleName_Offset));
		}
	}

	static FScriptSlateIcon()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FScriptSlateIcon)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FScriptSlateIcon));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ToolMenus.ScriptSlateIcon");
		FScriptSlateIcon_StructSize = NativeReflection.GetStructSize(intPtr);
		StyleSetName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StyleSetName");
		StyleSetName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StyleSetName", Classes.FNameProperty);
		StyleName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StyleName");
		StyleName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StyleName", Classes.FNameProperty);
		SmallStyleName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SmallStyleName");
		SmallStyleName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SmallStyleName", Classes.FNameProperty);
		FScriptSlateIcon_IsValid = intPtr != IntPtr.Zero && StyleSetName_IsValid && StyleName_IsValid && SmallStyleName_IsValid;
		NativeReflection.LogStructIsValid("/Script/ToolMenus.ScriptSlateIcon", FScriptSlateIcon_IsValid);
	}
}
