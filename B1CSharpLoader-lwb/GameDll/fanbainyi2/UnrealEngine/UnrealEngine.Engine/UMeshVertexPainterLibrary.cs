using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810025120uL, Config = "Engine")]
[UMetaPath("/Script/Engine.MeshVertexPainterKismetLibrary", "Engine", UnrealModuleType.Engine)]
public class UMeshVertexPainterLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool RemovePaintedVertices_IsValid;

	private static IntPtr RemovePaintedVertices_FunctionAddress;

	private static int RemovePaintedVertices_ParamsSize;

	private static bool RemovePaintedVertices_StaticMeshComponent_IsValid;

	private static FFieldAddress RemovePaintedVertices_StaticMeshComponent_PropertyAddress;

	private static int RemovePaintedVertices_StaticMeshComponent_Offset;

	private static bool PaintVerticesSingleColor_IsValid;

	private static IntPtr PaintVerticesSingleColor_FunctionAddress;

	private static int PaintVerticesSingleColor_ParamsSize;

	private static bool PaintVerticesSingleColor_StaticMeshComponent_IsValid;

	private static FFieldAddress PaintVerticesSingleColor_StaticMeshComponent_PropertyAddress;

	private static int PaintVerticesSingleColor_StaticMeshComponent_Offset;

	private static bool PaintVerticesSingleColor_FillColor_IsValid;

	private static FFieldAddress PaintVerticesSingleColor_FillColor_PropertyAddress;

	private static int PaintVerticesSingleColor_FillColor_Offset;

	private static bool PaintVerticesSingleColor_bConvertToSRGB_IsValid;

	private static FFieldAddress PaintVerticesSingleColor_bConvertToSRGB_PropertyAddress;

	private static int PaintVerticesSingleColor_bConvertToSRGB_Offset;

	private static bool PaintVerticesLerpAlongAxis_IsValid;

	private static IntPtr PaintVerticesLerpAlongAxis_FunctionAddress;

	private static int PaintVerticesLerpAlongAxis_ParamsSize;

	private static bool PaintVerticesLerpAlongAxis_StaticMeshComponent_IsValid;

	private static FFieldAddress PaintVerticesLerpAlongAxis_StaticMeshComponent_PropertyAddress;

	private static int PaintVerticesLerpAlongAxis_StaticMeshComponent_Offset;

	private static bool PaintVerticesLerpAlongAxis_StartColor_IsValid;

	private static FFieldAddress PaintVerticesLerpAlongAxis_StartColor_PropertyAddress;

	private static int PaintVerticesLerpAlongAxis_StartColor_Offset;

	private static bool PaintVerticesLerpAlongAxis_EndColor_IsValid;

	private static FFieldAddress PaintVerticesLerpAlongAxis_EndColor_PropertyAddress;

	private static int PaintVerticesLerpAlongAxis_EndColor_Offset;

	private static bool PaintVerticesLerpAlongAxis_Axis_IsValid;

	private static FFieldAddress PaintVerticesLerpAlongAxis_Axis_PropertyAddress;

	private static int PaintVerticesLerpAlongAxis_Axis_Offset;

	private static bool PaintVerticesLerpAlongAxis_bConvertToSRGB_IsValid;

	private static FFieldAddress PaintVerticesLerpAlongAxis_bConvertToSRGB_PropertyAddress;

	private static int PaintVerticesLerpAlongAxis_bConvertToSRGB_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Engine.MeshVertexPainterKismetLibrary:RemovePaintedVertices")]
	public unsafe static void RemovePaintedVertices(UStaticMeshComponent StaticMeshComponent)
	{
		if (!RemovePaintedVertices_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MeshVertexPainterKismetLibrary:RemovePaintedVertices");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemovePaintedVertices_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemovePaintedVertices_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(intPtr, RemovePaintedVertices_StaticMeshComponent_Offset), 0, RemovePaintedVertices_StaticMeshComponent_PropertyAddress.Address, StaticMeshComponent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemovePaintedVertices_FunctionAddress, intPtr, RemovePaintedVertices_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/Engine.MeshVertexPainterKismetLibrary:PaintVerticesSingleColor")]
	public unsafe static void PaintVerticesSingleColor(UStaticMeshComponent StaticMeshComponent, FLinearColor FillColor, bool bConvertToSRGB = true)
	{
		if (!PaintVerticesSingleColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MeshVertexPainterKismetLibrary:PaintVerticesSingleColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PaintVerticesSingleColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PaintVerticesSingleColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(intPtr, PaintVerticesSingleColor_StaticMeshComponent_Offset), 0, PaintVerticesSingleColor_StaticMeshComponent_PropertyAddress.Address, StaticMeshComponent);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, PaintVerticesSingleColor_FillColor_Offset), 0, PaintVerticesSingleColor_FillColor_PropertyAddress.Address, FillColor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PaintVerticesSingleColor_bConvertToSRGB_Offset), 0, PaintVerticesSingleColor_bConvertToSRGB_PropertyAddress.Address, bConvertToSRGB);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PaintVerticesSingleColor_FunctionAddress, intPtr, PaintVerticesSingleColor_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/Engine.MeshVertexPainterKismetLibrary:PaintVerticesLerpAlongAxis")]
	public unsafe static void PaintVerticesLerpAlongAxis(UStaticMeshComponent StaticMeshComponent, FLinearColor StartColor, FLinearColor EndColor, EVertexPaintAxis Axis, bool bConvertToSRGB = true)
	{
		if (!PaintVerticesLerpAlongAxis_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MeshVertexPainterKismetLibrary:PaintVerticesLerpAlongAxis");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PaintVerticesLerpAlongAxis_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PaintVerticesLerpAlongAxis_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(intPtr, PaintVerticesLerpAlongAxis_StaticMeshComponent_Offset), 0, PaintVerticesLerpAlongAxis_StaticMeshComponent_PropertyAddress.Address, StaticMeshComponent);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, PaintVerticesLerpAlongAxis_StartColor_Offset), 0, PaintVerticesLerpAlongAxis_StartColor_PropertyAddress.Address, StartColor);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, PaintVerticesLerpAlongAxis_EndColor_Offset), 0, PaintVerticesLerpAlongAxis_EndColor_PropertyAddress.Address, EndColor);
		EnumMarshaler<EVertexPaintAxis>.ToNative(IntPtr.Add(intPtr, PaintVerticesLerpAlongAxis_Axis_Offset), 0, PaintVerticesLerpAlongAxis_Axis_PropertyAddress.Address, Axis);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PaintVerticesLerpAlongAxis_bConvertToSRGB_Offset), 0, PaintVerticesLerpAlongAxis_bConvertToSRGB_PropertyAddress.Address, bConvertToSRGB);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PaintVerticesLerpAlongAxis_FunctionAddress, intPtr, PaintVerticesLerpAlongAxis_ParamsSize);
	}

	static UMeshVertexPainterLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMeshVertexPainterLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMeshVertexPainterLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.MeshVertexPainterKismetLibrary");
		RemovePaintedVertices_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemovePaintedVertices");
		RemovePaintedVertices_ParamsSize = NativeReflection.GetFunctionParamsSize(RemovePaintedVertices_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemovePaintedVertices_StaticMeshComponent_PropertyAddress, RemovePaintedVertices_FunctionAddress, "StaticMeshComponent");
		RemovePaintedVertices_StaticMeshComponent_Offset = NativeReflectionCached.GetPropertyOffset(RemovePaintedVertices_FunctionAddress, "StaticMeshComponent");
		RemovePaintedVertices_StaticMeshComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(RemovePaintedVertices_FunctionAddress, "StaticMeshComponent", Classes.FObjectProperty);
		RemovePaintedVertices_IsValid = RemovePaintedVertices_FunctionAddress != IntPtr.Zero && RemovePaintedVertices_StaticMeshComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MeshVertexPainterKismetLibrary:RemovePaintedVertices", RemovePaintedVertices_IsValid);
		PaintVerticesSingleColor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PaintVerticesSingleColor");
		PaintVerticesSingleColor_ParamsSize = NativeReflection.GetFunctionParamsSize(PaintVerticesSingleColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PaintVerticesSingleColor_StaticMeshComponent_PropertyAddress, PaintVerticesSingleColor_FunctionAddress, "StaticMeshComponent");
		PaintVerticesSingleColor_StaticMeshComponent_Offset = NativeReflectionCached.GetPropertyOffset(PaintVerticesSingleColor_FunctionAddress, "StaticMeshComponent");
		PaintVerticesSingleColor_StaticMeshComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(PaintVerticesSingleColor_FunctionAddress, "StaticMeshComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PaintVerticesSingleColor_FillColor_PropertyAddress, PaintVerticesSingleColor_FunctionAddress, "FillColor");
		PaintVerticesSingleColor_FillColor_Offset = NativeReflectionCached.GetPropertyOffset(PaintVerticesSingleColor_FunctionAddress, "FillColor");
		PaintVerticesSingleColor_FillColor_IsValid = NativeReflectionCached.ValidatePropertyClass(PaintVerticesSingleColor_FunctionAddress, "FillColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PaintVerticesSingleColor_bConvertToSRGB_PropertyAddress, PaintVerticesSingleColor_FunctionAddress, "bConvertToSRGB");
		PaintVerticesSingleColor_bConvertToSRGB_Offset = NativeReflectionCached.GetPropertyOffset(PaintVerticesSingleColor_FunctionAddress, "bConvertToSRGB");
		PaintVerticesSingleColor_bConvertToSRGB_IsValid = NativeReflectionCached.ValidatePropertyClass(PaintVerticesSingleColor_FunctionAddress, "bConvertToSRGB", Classes.FBoolProperty);
		PaintVerticesSingleColor_IsValid = PaintVerticesSingleColor_FunctionAddress != IntPtr.Zero && PaintVerticesSingleColor_StaticMeshComponent_IsValid && PaintVerticesSingleColor_FillColor_IsValid && PaintVerticesSingleColor_bConvertToSRGB_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MeshVertexPainterKismetLibrary:PaintVerticesSingleColor", PaintVerticesSingleColor_IsValid);
		PaintVerticesLerpAlongAxis_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PaintVerticesLerpAlongAxis");
		PaintVerticesLerpAlongAxis_ParamsSize = NativeReflection.GetFunctionParamsSize(PaintVerticesLerpAlongAxis_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PaintVerticesLerpAlongAxis_StaticMeshComponent_PropertyAddress, PaintVerticesLerpAlongAxis_FunctionAddress, "StaticMeshComponent");
		PaintVerticesLerpAlongAxis_StaticMeshComponent_Offset = NativeReflectionCached.GetPropertyOffset(PaintVerticesLerpAlongAxis_FunctionAddress, "StaticMeshComponent");
		PaintVerticesLerpAlongAxis_StaticMeshComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(PaintVerticesLerpAlongAxis_FunctionAddress, "StaticMeshComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PaintVerticesLerpAlongAxis_StartColor_PropertyAddress, PaintVerticesLerpAlongAxis_FunctionAddress, "StartColor");
		PaintVerticesLerpAlongAxis_StartColor_Offset = NativeReflectionCached.GetPropertyOffset(PaintVerticesLerpAlongAxis_FunctionAddress, "StartColor");
		PaintVerticesLerpAlongAxis_StartColor_IsValid = NativeReflectionCached.ValidatePropertyClass(PaintVerticesLerpAlongAxis_FunctionAddress, "StartColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PaintVerticesLerpAlongAxis_EndColor_PropertyAddress, PaintVerticesLerpAlongAxis_FunctionAddress, "EndColor");
		PaintVerticesLerpAlongAxis_EndColor_Offset = NativeReflectionCached.GetPropertyOffset(PaintVerticesLerpAlongAxis_FunctionAddress, "EndColor");
		PaintVerticesLerpAlongAxis_EndColor_IsValid = NativeReflectionCached.ValidatePropertyClass(PaintVerticesLerpAlongAxis_FunctionAddress, "EndColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PaintVerticesLerpAlongAxis_Axis_PropertyAddress, PaintVerticesLerpAlongAxis_FunctionAddress, "Axis");
		PaintVerticesLerpAlongAxis_Axis_Offset = NativeReflectionCached.GetPropertyOffset(PaintVerticesLerpAlongAxis_FunctionAddress, "Axis");
		PaintVerticesLerpAlongAxis_Axis_IsValid = NativeReflectionCached.ValidatePropertyClass(PaintVerticesLerpAlongAxis_FunctionAddress, "Axis", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref PaintVerticesLerpAlongAxis_bConvertToSRGB_PropertyAddress, PaintVerticesLerpAlongAxis_FunctionAddress, "bConvertToSRGB");
		PaintVerticesLerpAlongAxis_bConvertToSRGB_Offset = NativeReflectionCached.GetPropertyOffset(PaintVerticesLerpAlongAxis_FunctionAddress, "bConvertToSRGB");
		PaintVerticesLerpAlongAxis_bConvertToSRGB_IsValid = NativeReflectionCached.ValidatePropertyClass(PaintVerticesLerpAlongAxis_FunctionAddress, "bConvertToSRGB", Classes.FBoolProperty);
		PaintVerticesLerpAlongAxis_IsValid = PaintVerticesLerpAlongAxis_FunctionAddress != IntPtr.Zero && PaintVerticesLerpAlongAxis_StaticMeshComponent_IsValid && PaintVerticesLerpAlongAxis_StartColor_IsValid && PaintVerticesLerpAlongAxis_EndColor_IsValid && PaintVerticesLerpAlongAxis_Axis_IsValid && PaintVerticesLerpAlongAxis_bConvertToSRGB_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MeshVertexPainterKismetLibrary:PaintVerticesLerpAlongAxis", PaintVerticesLerpAlongAxis_IsValid);
	}
}
