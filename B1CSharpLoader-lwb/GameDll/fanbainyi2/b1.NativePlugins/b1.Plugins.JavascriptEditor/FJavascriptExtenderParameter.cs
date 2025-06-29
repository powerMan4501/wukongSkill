using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/JavascriptEditor.JavascriptExtenderParameter", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public struct FJavascriptExtenderParameter
{
	private static bool CommandList_IsValid;

	private static int CommandList_Offset;

	[UProperty(Flags = (PropFlags)4503599627370516uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptExtenderParameter:CommandList")]
	public FJavascriptUICommandList CommandList;

	private static bool EditingObjects_IsValid;

	private static FFieldAddress EditingObjects_PropertyAddress;

	private static int EditingObjects_Offset;

	[UProperty(Flags = (PropFlags)4503599627371028uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptExtenderParameter:EditingObjects")]
	public List<UObject> EditingObjects;

	private static bool Extender_IsValid;

	private static int Extender_Offset;

	[UProperty(Flags = (PropFlags)4503599627370500uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptExtenderParameter:Extender")]
	public FJavascriptExtender Extender;

	private static bool FJavascriptExtenderParameter_IsValid;

	private static int FJavascriptExtenderParameter_StructSize;

	public FJavascriptExtenderParameter Copy()
	{
		FJavascriptExtenderParameter result = this;
		if (EditingObjects != null)
		{
			result.EditingObjects = new List<UObject>(EditingObjects);
		}
		return result;
	}

	public static FJavascriptExtenderParameter FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptExtenderParameter(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptExtenderParameter value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptExtenderParameter FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptExtenderParameter(nativeBuffer + arrayIndex * FJavascriptExtenderParameter_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptExtenderParameter value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptExtenderParameter_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptExtenderParameter_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptExtenderParameter");
			return;
		}
		FJavascriptUICommandList.ToNative(IntPtr.Add(nativeStruct, CommandList_Offset), CommandList);
		new TArrayCopyMarshaler<UObject>(1, EditingObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(nativeStruct, EditingObjects_Offset), EditingObjects);
		FJavascriptExtender.ToNative(IntPtr.Add(nativeStruct, Extender_Offset), Extender);
	}

	public FJavascriptExtenderParameter(IntPtr nativeStruct)
	{
		if (!FJavascriptExtenderParameter_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptExtenderParameter");
			CommandList = default(FJavascriptUICommandList);
			EditingObjects = null;
			Extender = default(FJavascriptExtender);
		}
		else
		{
			CommandList = FJavascriptUICommandList.FromNative(IntPtr.Add(nativeStruct, CommandList_Offset));
			EditingObjects = new TArrayCopyMarshaler<UObject>(1, EditingObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(nativeStruct, EditingObjects_Offset));
			Extender = FJavascriptExtender.FromNative(IntPtr.Add(nativeStruct, Extender_Offset));
		}
	}

	static FJavascriptExtenderParameter()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptExtenderParameter)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptExtenderParameter));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptEditor.JavascriptExtenderParameter");
		FJavascriptExtenderParameter_StructSize = NativeReflection.GetStructSize(intPtr);
		CommandList_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CommandList");
		CommandList_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CommandList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref EditingObjects_PropertyAddress, intPtr, "EditingObjects");
		EditingObjects_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EditingObjects");
		EditingObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EditingObjects", Classes.FArrayProperty);
		Extender_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Extender");
		Extender_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Extender", Classes.FStructProperty);
		FJavascriptExtenderParameter_IsValid = intPtr != IntPtr.Zero && CommandList_IsValid && EditingObjects_IsValid && Extender_IsValid;
		NativeReflection.LogStructIsValid("/Script/JavascriptEditor.JavascriptExtenderParameter", FJavascriptExtenderParameter_IsValid);
	}
}
