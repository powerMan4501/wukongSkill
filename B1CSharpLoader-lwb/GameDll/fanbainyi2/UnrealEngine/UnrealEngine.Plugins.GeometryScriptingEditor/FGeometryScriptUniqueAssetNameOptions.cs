using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingEditor;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingEditor.GeometryScriptUniqueAssetNameOptions", "GeometryScriptingEditor", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptUniqueAssetNameOptions
{
	private static bool UniqueIDDigits_IsValid;

	private static int UniqueIDDigits_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingEditor.GeometryScriptUniqueAssetNameOptions:UniqueIDDigits")]
	public int UniqueIDDigits;

	private static bool FGeometryScriptUniqueAssetNameOptions_IsValid;

	private static int FGeometryScriptUniqueAssetNameOptions_StructSize;

	public FGeometryScriptUniqueAssetNameOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptUniqueAssetNameOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptUniqueAssetNameOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptUniqueAssetNameOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptUniqueAssetNameOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptUniqueAssetNameOptions(nativeBuffer + arrayIndex * FGeometryScriptUniqueAssetNameOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptUniqueAssetNameOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptUniqueAssetNameOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptUniqueAssetNameOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingEditor.GeometryScriptUniqueAssetNameOptions");
		}
		else
		{
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, UniqueIDDigits_Offset), UniqueIDDigits);
		}
	}

	public FGeometryScriptUniqueAssetNameOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptUniqueAssetNameOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingEditor.GeometryScriptUniqueAssetNameOptions");
			UniqueIDDigits = 0;
		}
		else
		{
			UniqueIDDigits = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, UniqueIDDigits_Offset));
		}
	}

	static FGeometryScriptUniqueAssetNameOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptUniqueAssetNameOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptUniqueAssetNameOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingEditor.GeometryScriptUniqueAssetNameOptions");
		FGeometryScriptUniqueAssetNameOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		UniqueIDDigits_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UniqueIDDigits");
		UniqueIDDigits_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UniqueIDDigits", Classes.FIntProperty);
		FGeometryScriptUniqueAssetNameOptions_IsValid = intPtr != IntPtr.Zero && UniqueIDDigits_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingEditor.GeometryScriptUniqueAssetNameOptions", FGeometryScriptUniqueAssetNameOptions_IsValid);
	}
}
