using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EditorScriptingUtilities;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/EditorScriptingUtilities.EditorScriptingMeshReductionSettings_Deprecated", "EditorScriptingUtilities", UnrealModuleType.EnginePlugin)]
public struct FEditorScriptingMeshReductionSettings_Deprecated
{
	private static bool PercentTriangles_IsValid;

	private static int PercentTriangles_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorScriptingMeshReductionSettings_Deprecated:PercentTriangles")]
	public float PercentTriangles;

	private static bool ScreenSize_IsValid;

	private static int ScreenSize_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorScriptingMeshReductionSettings_Deprecated:ScreenSize")]
	public float ScreenSize;

	private static bool FEditorScriptingMeshReductionSettings_Deprecated_IsValid;

	private static int FEditorScriptingMeshReductionSettings_Deprecated_StructSize;

	public FEditorScriptingMeshReductionSettings_Deprecated Copy()
	{
		return this;
	}

	public static FEditorScriptingMeshReductionSettings_Deprecated FromNative(IntPtr nativeBuffer)
	{
		return new FEditorScriptingMeshReductionSettings_Deprecated(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FEditorScriptingMeshReductionSettings_Deprecated value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FEditorScriptingMeshReductionSettings_Deprecated FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FEditorScriptingMeshReductionSettings_Deprecated(nativeBuffer + arrayIndex * FEditorScriptingMeshReductionSettings_Deprecated_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FEditorScriptingMeshReductionSettings_Deprecated value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FEditorScriptingMeshReductionSettings_Deprecated_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FEditorScriptingMeshReductionSettings_Deprecated_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/EditorScriptingUtilities.EditorScriptingMeshReductionSettings_Deprecated");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PercentTriangles_Offset), PercentTriangles);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ScreenSize_Offset), ScreenSize);
	}

	public FEditorScriptingMeshReductionSettings_Deprecated(IntPtr nativeStruct)
	{
		if (!FEditorScriptingMeshReductionSettings_Deprecated_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/EditorScriptingUtilities.EditorScriptingMeshReductionSettings_Deprecated");
			PercentTriangles = 0f;
			ScreenSize = 0f;
		}
		else
		{
			PercentTriangles = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PercentTriangles_Offset));
			ScreenSize = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ScreenSize_Offset));
		}
	}

	static FEditorScriptingMeshReductionSettings_Deprecated()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FEditorScriptingMeshReductionSettings_Deprecated)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FEditorScriptingMeshReductionSettings_Deprecated));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/EditorScriptingUtilities.EditorScriptingMeshReductionSettings_Deprecated");
		FEditorScriptingMeshReductionSettings_Deprecated_StructSize = NativeReflection.GetStructSize(intPtr);
		PercentTriangles_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PercentTriangles");
		PercentTriangles_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PercentTriangles", Classes.FFloatProperty);
		ScreenSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ScreenSize");
		ScreenSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ScreenSize", Classes.FFloatProperty);
		FEditorScriptingMeshReductionSettings_Deprecated_IsValid = intPtr != IntPtr.Zero && PercentTriangles_IsValid && ScreenSize_IsValid;
		NativeReflection.LogStructIsValid("/Script/EditorScriptingUtilities.EditorScriptingMeshReductionSettings_Deprecated", FEditorScriptingMeshReductionSettings_Deprecated_IsValid);
	}
}
