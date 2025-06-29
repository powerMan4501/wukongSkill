using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptIterativeMeshSmoothingOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptIterativeMeshSmoothingOptions
{
	private static bool NumIterations_IsValid;

	private static int NumIterations_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptIterativeMeshSmoothingOptions:NumIterations")]
	public int NumIterations;

	private static bool Alpha_IsValid;

	private static int Alpha_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptIterativeMeshSmoothingOptions:Alpha")]
	public float Alpha;

	private static bool FGeometryScriptIterativeMeshSmoothingOptions_IsValid;

	private static int FGeometryScriptIterativeMeshSmoothingOptions_StructSize;

	public FGeometryScriptIterativeMeshSmoothingOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptIterativeMeshSmoothingOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptIterativeMeshSmoothingOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptIterativeMeshSmoothingOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptIterativeMeshSmoothingOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptIterativeMeshSmoothingOptions(nativeBuffer + arrayIndex * FGeometryScriptIterativeMeshSmoothingOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptIterativeMeshSmoothingOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptIterativeMeshSmoothingOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptIterativeMeshSmoothingOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptIterativeMeshSmoothingOptions");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, NumIterations_Offset), NumIterations);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Alpha_Offset), Alpha);
	}

	public FGeometryScriptIterativeMeshSmoothingOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptIterativeMeshSmoothingOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptIterativeMeshSmoothingOptions");
			NumIterations = 0;
			Alpha = 0f;
		}
		else
		{
			NumIterations = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, NumIterations_Offset));
			Alpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Alpha_Offset));
		}
	}

	static FGeometryScriptIterativeMeshSmoothingOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptIterativeMeshSmoothingOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptIterativeMeshSmoothingOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptIterativeMeshSmoothingOptions");
		FGeometryScriptIterativeMeshSmoothingOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NumIterations_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumIterations");
		NumIterations_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumIterations", Classes.FIntProperty);
		Alpha_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Alpha");
		Alpha_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Alpha", Classes.FFloatProperty);
		FGeometryScriptIterativeMeshSmoothingOptions_IsValid = intPtr != IntPtr.Zero && NumIterations_IsValid && Alpha_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptIterativeMeshSmoothingOptions", FGeometryScriptIterativeMeshSmoothingOptions_IsValid);
	}
}
