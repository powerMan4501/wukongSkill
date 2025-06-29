using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptCollisionFromMeshOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptCollisionFromMeshOptions
{
	private static bool EmitTransaction_IsValid;

	private static FFieldAddress EmitTransaction_PropertyAddress;

	private static int EmitTransaction_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptCollisionFromMeshOptions:bEmitTransaction")]
	public bool EmitTransaction;

	private static bool Method_IsValid;

	private static FFieldAddress Method_PropertyAddress;

	private static int Method_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptCollisionFromMeshOptions:Method")]
	public EGeometryScriptCollisionGenerationMethod Method;

	private static bool AutoDetectSpheres_IsValid;

	private static FFieldAddress AutoDetectSpheres_PropertyAddress;

	private static int AutoDetectSpheres_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptCollisionFromMeshOptions:bAutoDetectSpheres")]
	public bool AutoDetectSpheres;

	private static bool AutoDetectBoxes_IsValid;

	private static FFieldAddress AutoDetectBoxes_PropertyAddress;

	private static int AutoDetectBoxes_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptCollisionFromMeshOptions:bAutoDetectBoxes")]
	public bool AutoDetectBoxes;

	private static bool AutoDetectCapsules_IsValid;

	private static FFieldAddress AutoDetectCapsules_PropertyAddress;

	private static int AutoDetectCapsules_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptCollisionFromMeshOptions:bAutoDetectCapsules")]
	public bool AutoDetectCapsules;

	private static bool MinThickness_IsValid;

	private static int MinThickness_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptCollisionFromMeshOptions:MinThickness")]
	public float MinThickness;

	private static bool SimplifyHulls_IsValid;

	private static FFieldAddress SimplifyHulls_PropertyAddress;

	private static int SimplifyHulls_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptCollisionFromMeshOptions:bSimplifyHulls")]
	public bool SimplifyHulls;

	private static bool ConvexHullTargetFaceCount_IsValid;

	private static int ConvexHullTargetFaceCount_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptCollisionFromMeshOptions:ConvexHullTargetFaceCount")]
	public int ConvexHullTargetFaceCount;

	private static bool SweptHullSimplifyTolerance_IsValid;

	private static int SweptHullSimplifyTolerance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptCollisionFromMeshOptions:SweptHullSimplifyTolerance")]
	public float SweptHullSimplifyTolerance;

	private static bool SweptHullAxis_IsValid;

	private static FFieldAddress SweptHullAxis_PropertyAddress;

	private static int SweptHullAxis_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptCollisionFromMeshOptions:SweptHullAxis")]
	public EGeometryScriptSweptHullAxis SweptHullAxis;

	private static bool RemoveFullyContainedShapes_IsValid;

	private static FFieldAddress RemoveFullyContainedShapes_PropertyAddress;

	private static int RemoveFullyContainedShapes_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptCollisionFromMeshOptions:bRemoveFullyContainedShapes")]
	public bool RemoveFullyContainedShapes;

	private static bool MaxShapeCount_IsValid;

	private static int MaxShapeCount_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptCollisionFromMeshOptions:MaxShapeCount")]
	public int MaxShapeCount;

	private static bool FGeometryScriptCollisionFromMeshOptions_IsValid;

	private static int FGeometryScriptCollisionFromMeshOptions_StructSize;

	public FGeometryScriptCollisionFromMeshOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptCollisionFromMeshOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptCollisionFromMeshOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptCollisionFromMeshOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptCollisionFromMeshOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptCollisionFromMeshOptions(nativeBuffer + arrayIndex * FGeometryScriptCollisionFromMeshOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptCollisionFromMeshOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptCollisionFromMeshOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptCollisionFromMeshOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptCollisionFromMeshOptions");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EmitTransaction_Offset), 0, EmitTransaction_PropertyAddress.Address, EmitTransaction);
		EnumMarshaler<EGeometryScriptCollisionGenerationMethod>.ToNative(IntPtr.Add(nativeStruct, Method_Offset), 0, Method_PropertyAddress.Address, Method);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AutoDetectSpheres_Offset), 0, AutoDetectSpheres_PropertyAddress.Address, AutoDetectSpheres);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AutoDetectBoxes_Offset), 0, AutoDetectBoxes_PropertyAddress.Address, AutoDetectBoxes);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AutoDetectCapsules_Offset), 0, AutoDetectCapsules_PropertyAddress.Address, AutoDetectCapsules);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinThickness_Offset), MinThickness);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SimplifyHulls_Offset), 0, SimplifyHulls_PropertyAddress.Address, SimplifyHulls);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ConvexHullTargetFaceCount_Offset), ConvexHullTargetFaceCount);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SweptHullSimplifyTolerance_Offset), SweptHullSimplifyTolerance);
		EnumMarshaler<EGeometryScriptSweptHullAxis>.ToNative(IntPtr.Add(nativeStruct, SweptHullAxis_Offset), 0, SweptHullAxis_PropertyAddress.Address, SweptHullAxis);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, RemoveFullyContainedShapes_Offset), 0, RemoveFullyContainedShapes_PropertyAddress.Address, RemoveFullyContainedShapes);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MaxShapeCount_Offset), MaxShapeCount);
	}

	public FGeometryScriptCollisionFromMeshOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptCollisionFromMeshOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptCollisionFromMeshOptions");
			EmitTransaction = false;
			Method = EGeometryScriptCollisionGenerationMethod.AlignedBoxes;
			AutoDetectSpheres = false;
			AutoDetectBoxes = false;
			AutoDetectCapsules = false;
			MinThickness = 0f;
			SimplifyHulls = false;
			ConvexHullTargetFaceCount = 0;
			SweptHullSimplifyTolerance = 0f;
			SweptHullAxis = EGeometryScriptSweptHullAxis.X;
			RemoveFullyContainedShapes = false;
			MaxShapeCount = 0;
		}
		else
		{
			EmitTransaction = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EmitTransaction_Offset), 0, EmitTransaction_PropertyAddress.Address);
			Method = EnumMarshaler<EGeometryScriptCollisionGenerationMethod>.FromNative(IntPtr.Add(nativeStruct, Method_Offset), 0, Method_PropertyAddress.Address);
			AutoDetectSpheres = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AutoDetectSpheres_Offset), 0, AutoDetectSpheres_PropertyAddress.Address);
			AutoDetectBoxes = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AutoDetectBoxes_Offset), 0, AutoDetectBoxes_PropertyAddress.Address);
			AutoDetectCapsules = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AutoDetectCapsules_Offset), 0, AutoDetectCapsules_PropertyAddress.Address);
			MinThickness = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinThickness_Offset));
			SimplifyHulls = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SimplifyHulls_Offset), 0, SimplifyHulls_PropertyAddress.Address);
			ConvexHullTargetFaceCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ConvexHullTargetFaceCount_Offset));
			SweptHullSimplifyTolerance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SweptHullSimplifyTolerance_Offset));
			SweptHullAxis = EnumMarshaler<EGeometryScriptSweptHullAxis>.FromNative(IntPtr.Add(nativeStruct, SweptHullAxis_Offset), 0, SweptHullAxis_PropertyAddress.Address);
			RemoveFullyContainedShapes = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, RemoveFullyContainedShapes_Offset), 0, RemoveFullyContainedShapes_PropertyAddress.Address);
			MaxShapeCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MaxShapeCount_Offset));
		}
	}

	static FGeometryScriptCollisionFromMeshOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptCollisionFromMeshOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptCollisionFromMeshOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptCollisionFromMeshOptions");
		FGeometryScriptCollisionFromMeshOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref EmitTransaction_PropertyAddress, intPtr, "bEmitTransaction");
		EmitTransaction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEmitTransaction");
		EmitTransaction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEmitTransaction", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Method_PropertyAddress, intPtr, "Method");
		Method_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Method");
		Method_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Method", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoDetectSpheres_PropertyAddress, intPtr, "bAutoDetectSpheres");
		AutoDetectSpheres_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAutoDetectSpheres");
		AutoDetectSpheres_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAutoDetectSpheres", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoDetectBoxes_PropertyAddress, intPtr, "bAutoDetectBoxes");
		AutoDetectBoxes_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAutoDetectBoxes");
		AutoDetectBoxes_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAutoDetectBoxes", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoDetectCapsules_PropertyAddress, intPtr, "bAutoDetectCapsules");
		AutoDetectCapsules_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAutoDetectCapsules");
		AutoDetectCapsules_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAutoDetectCapsules", Classes.FBoolProperty);
		MinThickness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinThickness");
		MinThickness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinThickness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SimplifyHulls_PropertyAddress, intPtr, "bSimplifyHulls");
		SimplifyHulls_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSimplifyHulls");
		SimplifyHulls_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSimplifyHulls", Classes.FBoolProperty);
		ConvexHullTargetFaceCount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConvexHullTargetFaceCount");
		ConvexHullTargetFaceCount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConvexHullTargetFaceCount", Classes.FIntProperty);
		SweptHullSimplifyTolerance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SweptHullSimplifyTolerance");
		SweptHullSimplifyTolerance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SweptHullSimplifyTolerance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SweptHullAxis_PropertyAddress, intPtr, "SweptHullAxis");
		SweptHullAxis_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SweptHullAxis");
		SweptHullAxis_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SweptHullAxis", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveFullyContainedShapes_PropertyAddress, intPtr, "bRemoveFullyContainedShapes");
		RemoveFullyContainedShapes_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRemoveFullyContainedShapes");
		RemoveFullyContainedShapes_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRemoveFullyContainedShapes", Classes.FBoolProperty);
		MaxShapeCount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxShapeCount");
		MaxShapeCount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxShapeCount", Classes.FIntProperty);
		FGeometryScriptCollisionFromMeshOptions_IsValid = intPtr != IntPtr.Zero && EmitTransaction_IsValid && Method_IsValid && AutoDetectSpheres_IsValid && AutoDetectBoxes_IsValid && AutoDetectCapsules_IsValid && MinThickness_IsValid && SimplifyHulls_IsValid && ConvexHullTargetFaceCount_IsValid && SweptHullSimplifyTolerance_IsValid && SweptHullAxis_IsValid && RemoveFullyContainedShapes_IsValid && MaxShapeCount_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptCollisionFromMeshOptions", FGeometryScriptCollisionFromMeshOptions_IsValid);
	}
}
