using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UMG.SlateBlueprintLibrary", "UMG", UnrealModuleType.Engine)]
public class USlateLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool TransformVectorLocalToAbsolute_IsValid;

	private static IntPtr TransformVectorLocalToAbsolute_FunctionAddress;

	private static int TransformVectorLocalToAbsolute_ParamsSize;

	private static bool TransformVectorLocalToAbsolute_Geometry_IsValid;

	private static FFieldAddress TransformVectorLocalToAbsolute_Geometry_PropertyAddress;

	private static int TransformVectorLocalToAbsolute_Geometry_Offset;

	private static bool TransformVectorLocalToAbsolute_LocalVector_IsValid;

	private static FFieldAddress TransformVectorLocalToAbsolute_LocalVector_PropertyAddress;

	private static int TransformVectorLocalToAbsolute_LocalVector_Offset;

	private static bool TransformVectorLocalToAbsolute_ReturnValue_IsValid;

	private static FFieldAddress TransformVectorLocalToAbsolute_ReturnValue_PropertyAddress;

	private static int TransformVectorLocalToAbsolute_ReturnValue_Offset;

	private static bool TransformVectorAbsoluteToLocal_IsValid;

	private static IntPtr TransformVectorAbsoluteToLocal_FunctionAddress;

	private static int TransformVectorAbsoluteToLocal_ParamsSize;

	private static bool TransformVectorAbsoluteToLocal_Geometry_IsValid;

	private static FFieldAddress TransformVectorAbsoluteToLocal_Geometry_PropertyAddress;

	private static int TransformVectorAbsoluteToLocal_Geometry_Offset;

	private static bool TransformVectorAbsoluteToLocal_AbsoluteVector_IsValid;

	private static FFieldAddress TransformVectorAbsoluteToLocal_AbsoluteVector_PropertyAddress;

	private static int TransformVectorAbsoluteToLocal_AbsoluteVector_Offset;

	private static bool TransformVectorAbsoluteToLocal_ReturnValue_IsValid;

	private static FFieldAddress TransformVectorAbsoluteToLocal_ReturnValue_PropertyAddress;

	private static int TransformVectorAbsoluteToLocal_ReturnValue_Offset;

	private static bool TransformScalarLocalToAbsolute_IsValid;

	private static IntPtr TransformScalarLocalToAbsolute_FunctionAddress;

	private static int TransformScalarLocalToAbsolute_ParamsSize;

	private static bool TransformScalarLocalToAbsolute_Geometry_IsValid;

	private static FFieldAddress TransformScalarLocalToAbsolute_Geometry_PropertyAddress;

	private static int TransformScalarLocalToAbsolute_Geometry_Offset;

	private static bool TransformScalarLocalToAbsolute_LocalScalar_IsValid;

	private static FFieldAddress TransformScalarLocalToAbsolute_LocalScalar_PropertyAddress;

	private static int TransformScalarLocalToAbsolute_LocalScalar_Offset;

	private static bool TransformScalarLocalToAbsolute_ReturnValue_IsValid;

	private static FFieldAddress TransformScalarLocalToAbsolute_ReturnValue_PropertyAddress;

	private static int TransformScalarLocalToAbsolute_ReturnValue_Offset;

	private static bool TransformScalarAbsoluteToLocal_IsValid;

	private static IntPtr TransformScalarAbsoluteToLocal_FunctionAddress;

	private static int TransformScalarAbsoluteToLocal_ParamsSize;

	private static bool TransformScalarAbsoluteToLocal_Geometry_IsValid;

	private static FFieldAddress TransformScalarAbsoluteToLocal_Geometry_PropertyAddress;

	private static int TransformScalarAbsoluteToLocal_Geometry_Offset;

	private static bool TransformScalarAbsoluteToLocal_AbsoluteScalar_IsValid;

	private static FFieldAddress TransformScalarAbsoluteToLocal_AbsoluteScalar_PropertyAddress;

	private static int TransformScalarAbsoluteToLocal_AbsoluteScalar_Offset;

	private static bool TransformScalarAbsoluteToLocal_ReturnValue_IsValid;

	private static FFieldAddress TransformScalarAbsoluteToLocal_ReturnValue_PropertyAddress;

	private static int TransformScalarAbsoluteToLocal_ReturnValue_Offset;

	private static bool ScreenToWidgetLocal_IsValid;

	private static IntPtr ScreenToWidgetLocal_FunctionAddress;

	private static int ScreenToWidgetLocal_ParamsSize;

	private static bool ScreenToWidgetLocal_WorldContextObject_IsValid;

	private static FFieldAddress ScreenToWidgetLocal_WorldContextObject_PropertyAddress;

	private static int ScreenToWidgetLocal_WorldContextObject_Offset;

	private static bool ScreenToWidgetLocal_Geometry_IsValid;

	private static FFieldAddress ScreenToWidgetLocal_Geometry_PropertyAddress;

	private static int ScreenToWidgetLocal_Geometry_Offset;

	private static bool ScreenToWidgetLocal_ScreenPosition_IsValid;

	private static FFieldAddress ScreenToWidgetLocal_ScreenPosition_PropertyAddress;

	private static int ScreenToWidgetLocal_ScreenPosition_Offset;

	private static bool ScreenToWidgetLocal_LocalCoordinate_IsValid;

	private static FFieldAddress ScreenToWidgetLocal_LocalCoordinate_PropertyAddress;

	private static int ScreenToWidgetLocal_LocalCoordinate_Offset;

	private static bool ScreenToWidgetLocal_bIncludeWindowPosition_IsValid;

	private static FFieldAddress ScreenToWidgetLocal_bIncludeWindowPosition_PropertyAddress;

	private static int ScreenToWidgetLocal_bIncludeWindowPosition_Offset;

	private static bool ScreenToWidgetAbsolute_IsValid;

	private static IntPtr ScreenToWidgetAbsolute_FunctionAddress;

	private static int ScreenToWidgetAbsolute_ParamsSize;

	private static bool ScreenToWidgetAbsolute_WorldContextObject_IsValid;

	private static FFieldAddress ScreenToWidgetAbsolute_WorldContextObject_PropertyAddress;

	private static int ScreenToWidgetAbsolute_WorldContextObject_Offset;

	private static bool ScreenToWidgetAbsolute_ScreenPosition_IsValid;

	private static FFieldAddress ScreenToWidgetAbsolute_ScreenPosition_PropertyAddress;

	private static int ScreenToWidgetAbsolute_ScreenPosition_Offset;

	private static bool ScreenToWidgetAbsolute_AbsoluteCoordinate_IsValid;

	private static FFieldAddress ScreenToWidgetAbsolute_AbsoluteCoordinate_PropertyAddress;

	private static int ScreenToWidgetAbsolute_AbsoluteCoordinate_Offset;

	private static bool ScreenToWidgetAbsolute_bIncludeWindowPosition_IsValid;

	private static FFieldAddress ScreenToWidgetAbsolute_bIncludeWindowPosition_PropertyAddress;

	private static int ScreenToWidgetAbsolute_bIncludeWindowPosition_Offset;

	private static bool ScreenToViewport_IsValid;

	private static IntPtr ScreenToViewport_FunctionAddress;

	private static int ScreenToViewport_ParamsSize;

	private static bool ScreenToViewport_WorldContextObject_IsValid;

	private static FFieldAddress ScreenToViewport_WorldContextObject_PropertyAddress;

	private static int ScreenToViewport_WorldContextObject_Offset;

	private static bool ScreenToViewport_ScreenPosition_IsValid;

	private static FFieldAddress ScreenToViewport_ScreenPosition_PropertyAddress;

	private static int ScreenToViewport_ScreenPosition_Offset;

	private static bool ScreenToViewport_ViewportPosition_IsValid;

	private static FFieldAddress ScreenToViewport_ViewportPosition_PropertyAddress;

	private static int ScreenToViewport_ViewportPosition_Offset;

	private static bool LocalToViewport_IsValid;

	private static IntPtr LocalToViewport_FunctionAddress;

	private static int LocalToViewport_ParamsSize;

	private static bool LocalToViewport_WorldContextObject_IsValid;

	private static FFieldAddress LocalToViewport_WorldContextObject_PropertyAddress;

	private static int LocalToViewport_WorldContextObject_Offset;

	private static bool LocalToViewport_Geometry_IsValid;

	private static FFieldAddress LocalToViewport_Geometry_PropertyAddress;

	private static int LocalToViewport_Geometry_Offset;

	private static bool LocalToViewport_LocalCoordinate_IsValid;

	private static FFieldAddress LocalToViewport_LocalCoordinate_PropertyAddress;

	private static int LocalToViewport_LocalCoordinate_Offset;

	private static bool LocalToViewport_PixelPosition_IsValid;

	private static FFieldAddress LocalToViewport_PixelPosition_PropertyAddress;

	private static int LocalToViewport_PixelPosition_Offset;

	private static bool LocalToViewport_ViewportPosition_IsValid;

	private static FFieldAddress LocalToViewport_ViewportPosition_PropertyAddress;

	private static int LocalToViewport_ViewportPosition_Offset;

	private static bool LocalToAbsolute_IsValid;

	private static IntPtr LocalToAbsolute_FunctionAddress;

	private static int LocalToAbsolute_ParamsSize;

	private static bool LocalToAbsolute_Geometry_IsValid;

	private static FFieldAddress LocalToAbsolute_Geometry_PropertyAddress;

	private static int LocalToAbsolute_Geometry_Offset;

	private static bool LocalToAbsolute_LocalCoordinate_IsValid;

	private static FFieldAddress LocalToAbsolute_LocalCoordinate_PropertyAddress;

	private static int LocalToAbsolute_LocalCoordinate_Offset;

	private static bool LocalToAbsolute_ReturnValue_IsValid;

	private static FFieldAddress LocalToAbsolute_ReturnValue_PropertyAddress;

	private static int LocalToAbsolute_ReturnValue_Offset;

	private static bool IsUnderLocation_IsValid;

	private static IntPtr IsUnderLocation_FunctionAddress;

	private static int IsUnderLocation_ParamsSize;

	private static bool IsUnderLocation_Geometry_IsValid;

	private static FFieldAddress IsUnderLocation_Geometry_PropertyAddress;

	private static int IsUnderLocation_Geometry_Offset;

	private static bool IsUnderLocation_AbsoluteCoordinate_IsValid;

	private static FFieldAddress IsUnderLocation_AbsoluteCoordinate_PropertyAddress;

	private static int IsUnderLocation_AbsoluteCoordinate_Offset;

	private static bool IsUnderLocation_ReturnValue_IsValid;

	private static FFieldAddress IsUnderLocation_ReturnValue_PropertyAddress;

	private static int IsUnderLocation_ReturnValue_Offset;

	private static bool GetLocalTopLeft_IsValid;

	private static IntPtr GetLocalTopLeft_FunctionAddress;

	private static int GetLocalTopLeft_ParamsSize;

	private static bool GetLocalTopLeft_Geometry_IsValid;

	private static FFieldAddress GetLocalTopLeft_Geometry_PropertyAddress;

	private static int GetLocalTopLeft_Geometry_Offset;

	private static bool GetLocalTopLeft_ReturnValue_IsValid;

	private static FFieldAddress GetLocalTopLeft_ReturnValue_PropertyAddress;

	private static int GetLocalTopLeft_ReturnValue_Offset;

	private static bool GetLocalSize_IsValid;

	private static IntPtr GetLocalSize_FunctionAddress;

	private static int GetLocalSize_ParamsSize;

	private static bool GetLocalSize_Geometry_IsValid;

	private static FFieldAddress GetLocalSize_Geometry_PropertyAddress;

	private static int GetLocalSize_Geometry_Offset;

	private static bool GetLocalSize_ReturnValue_IsValid;

	private static FFieldAddress GetLocalSize_ReturnValue_PropertyAddress;

	private static int GetLocalSize_ReturnValue_Offset;

	private static bool GetAbsoluteSize_IsValid;

	private static IntPtr GetAbsoluteSize_FunctionAddress;

	private static int GetAbsoluteSize_ParamsSize;

	private static bool GetAbsoluteSize_Geometry_IsValid;

	private static FFieldAddress GetAbsoluteSize_Geometry_PropertyAddress;

	private static int GetAbsoluteSize_Geometry_Offset;

	private static bool GetAbsoluteSize_ReturnValue_IsValid;

	private static FFieldAddress GetAbsoluteSize_ReturnValue_PropertyAddress;

	private static int GetAbsoluteSize_ReturnValue_Offset;

	private static bool EqualEqual_SlateBrush_IsValid;

	private static IntPtr EqualEqual_SlateBrush_FunctionAddress;

	private static int EqualEqual_SlateBrush_ParamsSize;

	private static bool EqualEqual_SlateBrush_A_IsValid;

	private static FFieldAddress EqualEqual_SlateBrush_A_PropertyAddress;

	private static int EqualEqual_SlateBrush_A_Offset;

	private static bool EqualEqual_SlateBrush_B_IsValid;

	private static FFieldAddress EqualEqual_SlateBrush_B_PropertyAddress;

	private static int EqualEqual_SlateBrush_B_Offset;

	private static bool EqualEqual_SlateBrush_ReturnValue_IsValid;

	private static FFieldAddress EqualEqual_SlateBrush_ReturnValue_PropertyAddress;

	private static int EqualEqual_SlateBrush_ReturnValue_Offset;

	private static bool AbsoluteToViewport_IsValid;

	private static IntPtr AbsoluteToViewport_FunctionAddress;

	private static int AbsoluteToViewport_ParamsSize;

	private static bool AbsoluteToViewport_WorldContextObject_IsValid;

	private static FFieldAddress AbsoluteToViewport_WorldContextObject_PropertyAddress;

	private static int AbsoluteToViewport_WorldContextObject_Offset;

	private static bool AbsoluteToViewport_AbsoluteDesktopCoordinate_IsValid;

	private static FFieldAddress AbsoluteToViewport_AbsoluteDesktopCoordinate_PropertyAddress;

	private static int AbsoluteToViewport_AbsoluteDesktopCoordinate_Offset;

	private static bool AbsoluteToViewport_PixelPosition_IsValid;

	private static FFieldAddress AbsoluteToViewport_PixelPosition_PropertyAddress;

	private static int AbsoluteToViewport_PixelPosition_Offset;

	private static bool AbsoluteToViewport_ViewportPosition_IsValid;

	private static FFieldAddress AbsoluteToViewport_ViewportPosition_PropertyAddress;

	private static int AbsoluteToViewport_ViewportPosition_Offset;

	private static bool AbsoluteToLocal_IsValid;

	private static IntPtr AbsoluteToLocal_FunctionAddress;

	private static int AbsoluteToLocal_ParamsSize;

	private static bool AbsoluteToLocal_Geometry_IsValid;

	private static FFieldAddress AbsoluteToLocal_Geometry_PropertyAddress;

	private static int AbsoluteToLocal_Geometry_Offset;

	private static bool AbsoluteToLocal_AbsoluteCoordinate_IsValid;

	private static FFieldAddress AbsoluteToLocal_AbsoluteCoordinate_PropertyAddress;

	private static int AbsoluteToLocal_AbsoluteCoordinate_Offset;

	private static bool AbsoluteToLocal_ReturnValue_IsValid;

	private static FFieldAddress AbsoluteToLocal_ReturnValue_PropertyAddress;

	private static int AbsoluteToLocal_ReturnValue_Offset;

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/UMG.SlateBlueprintLibrary:TransformVectorLocalToAbsolute")]
	public unsafe static FVector2D TransformVectorLocalToAbsolute(FGeometry Geometry, FVector2D LocalVector)
	{
		if (!TransformVectorLocalToAbsolute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.SlateBlueprintLibrary:TransformVectorLocalToAbsolute");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(TransformVectorLocalToAbsolute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TransformVectorLocalToAbsolute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(TransformVectorLocalToAbsolute_Geometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, TransformVectorLocalToAbsolute_Geometry_Offset), 0, TransformVectorLocalToAbsolute_Geometry_PropertyAddress.Address, Geometry);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, TransformVectorLocalToAbsolute_LocalVector_Offset), 0, TransformVectorLocalToAbsolute_LocalVector_PropertyAddress.Address, LocalVector);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TransformVectorLocalToAbsolute_FunctionAddress, intPtr, TransformVectorLocalToAbsolute_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, TransformVectorLocalToAbsolute_ReturnValue_Offset), 0, TransformVectorLocalToAbsolute_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/UMG.SlateBlueprintLibrary:TransformVectorAbsoluteToLocal")]
	public unsafe static FVector2D TransformVectorAbsoluteToLocal(FGeometry Geometry, FVector2D AbsoluteVector)
	{
		if (!TransformVectorAbsoluteToLocal_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.SlateBlueprintLibrary:TransformVectorAbsoluteToLocal");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(TransformVectorAbsoluteToLocal_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TransformVectorAbsoluteToLocal_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(TransformVectorAbsoluteToLocal_Geometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, TransformVectorAbsoluteToLocal_Geometry_Offset), 0, TransformVectorAbsoluteToLocal_Geometry_PropertyAddress.Address, Geometry);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, TransformVectorAbsoluteToLocal_AbsoluteVector_Offset), 0, TransformVectorAbsoluteToLocal_AbsoluteVector_PropertyAddress.Address, AbsoluteVector);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TransformVectorAbsoluteToLocal_FunctionAddress, intPtr, TransformVectorAbsoluteToLocal_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, TransformVectorAbsoluteToLocal_ReturnValue_Offset), 0, TransformVectorAbsoluteToLocal_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/UMG.SlateBlueprintLibrary:TransformScalarLocalToAbsolute")]
	public unsafe static float TransformScalarLocalToAbsolute(FGeometry Geometry, float LocalScalar)
	{
		if (!TransformScalarLocalToAbsolute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.SlateBlueprintLibrary:TransformScalarLocalToAbsolute");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TransformScalarLocalToAbsolute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TransformScalarLocalToAbsolute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(TransformScalarLocalToAbsolute_Geometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, TransformScalarLocalToAbsolute_Geometry_Offset), 0, TransformScalarLocalToAbsolute_Geometry_PropertyAddress.Address, Geometry);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, TransformScalarLocalToAbsolute_LocalScalar_Offset), 0, TransformScalarLocalToAbsolute_LocalScalar_PropertyAddress.Address, LocalScalar);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TransformScalarLocalToAbsolute_FunctionAddress, intPtr, TransformScalarLocalToAbsolute_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, TransformScalarLocalToAbsolute_ReturnValue_Offset), 0, TransformScalarLocalToAbsolute_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/UMG.SlateBlueprintLibrary:TransformScalarAbsoluteToLocal")]
	public unsafe static float TransformScalarAbsoluteToLocal(FGeometry Geometry, float AbsoluteScalar)
	{
		if (!TransformScalarAbsoluteToLocal_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.SlateBlueprintLibrary:TransformScalarAbsoluteToLocal");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TransformScalarAbsoluteToLocal_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TransformScalarAbsoluteToLocal_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(TransformScalarAbsoluteToLocal_Geometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, TransformScalarAbsoluteToLocal_Geometry_Offset), 0, TransformScalarAbsoluteToLocal_Geometry_PropertyAddress.Address, Geometry);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, TransformScalarAbsoluteToLocal_AbsoluteScalar_Offset), 0, TransformScalarAbsoluteToLocal_AbsoluteScalar_PropertyAddress.Address, AbsoluteScalar);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TransformScalarAbsoluteToLocal_FunctionAddress, intPtr, TransformScalarAbsoluteToLocal_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, TransformScalarAbsoluteToLocal_ReturnValue_Offset), 0, TransformScalarAbsoluteToLocal_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/UMG.SlateBlueprintLibrary:ScreenToWidgetLocal")]
	public unsafe static void ScreenToWidgetLocal(UObject WorldContextObject, FGeometry Geometry, FVector2D ScreenPosition, out FVector2D LocalCoordinate, bool bIncludeWindowPosition = false)
	{
		if (!ScreenToWidgetLocal_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.SlateBlueprintLibrary:ScreenToWidgetLocal");
			LocalCoordinate = default(FVector2D);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScreenToWidgetLocal_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScreenToWidgetLocal_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ScreenToWidgetLocal_WorldContextObject_Offset), 0, ScreenToWidgetLocal_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InitializeValue_InContainer(ScreenToWidgetLocal_Geometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, ScreenToWidgetLocal_Geometry_Offset), 0, ScreenToWidgetLocal_Geometry_PropertyAddress.Address, Geometry);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, ScreenToWidgetLocal_ScreenPosition_Offset), 0, ScreenToWidgetLocal_ScreenPosition_PropertyAddress.Address, ScreenPosition);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ScreenToWidgetLocal_bIncludeWindowPosition_Offset), 0, ScreenToWidgetLocal_bIncludeWindowPosition_PropertyAddress.Address, bIncludeWindowPosition);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ScreenToWidgetLocal_FunctionAddress, intPtr, ScreenToWidgetLocal_ParamsSize);
		LocalCoordinate = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, ScreenToWidgetLocal_LocalCoordinate_Offset), 0, ScreenToWidgetLocal_LocalCoordinate_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/UMG.SlateBlueprintLibrary:ScreenToWidgetAbsolute")]
	public unsafe static void ScreenToWidgetAbsolute(UObject WorldContextObject, FVector2D ScreenPosition, out FVector2D AbsoluteCoordinate, bool bIncludeWindowPosition = false)
	{
		if (!ScreenToWidgetAbsolute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.SlateBlueprintLibrary:ScreenToWidgetAbsolute");
			AbsoluteCoordinate = default(FVector2D);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScreenToWidgetAbsolute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScreenToWidgetAbsolute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ScreenToWidgetAbsolute_WorldContextObject_Offset), 0, ScreenToWidgetAbsolute_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, ScreenToWidgetAbsolute_ScreenPosition_Offset), 0, ScreenToWidgetAbsolute_ScreenPosition_PropertyAddress.Address, ScreenPosition);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ScreenToWidgetAbsolute_bIncludeWindowPosition_Offset), 0, ScreenToWidgetAbsolute_bIncludeWindowPosition_PropertyAddress.Address, bIncludeWindowPosition);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ScreenToWidgetAbsolute_FunctionAddress, intPtr, ScreenToWidgetAbsolute_ParamsSize);
		AbsoluteCoordinate = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, ScreenToWidgetAbsolute_AbsoluteCoordinate_Offset), 0, ScreenToWidgetAbsolute_AbsoluteCoordinate_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/UMG.SlateBlueprintLibrary:ScreenToViewport")]
	public unsafe static void ScreenToViewport(UObject WorldContextObject, FVector2D ScreenPosition, out FVector2D ViewportPosition)
	{
		if (!ScreenToViewport_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.SlateBlueprintLibrary:ScreenToViewport");
			ViewportPosition = default(FVector2D);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScreenToViewport_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScreenToViewport_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ScreenToViewport_WorldContextObject_Offset), 0, ScreenToViewport_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, ScreenToViewport_ScreenPosition_Offset), 0, ScreenToViewport_ScreenPosition_PropertyAddress.Address, ScreenPosition);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ScreenToViewport_FunctionAddress, intPtr, ScreenToViewport_ParamsSize);
		ViewportPosition = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, ScreenToViewport_ViewportPosition_Offset), 0, ScreenToViewport_ViewportPosition_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/UMG.SlateBlueprintLibrary:LocalToViewport")]
	public unsafe static void LocalToViewport(UObject WorldContextObject, FGeometry Geometry, FVector2D LocalCoordinate, out FVector2D PixelPosition, out FVector2D ViewportPosition)
	{
		if (!LocalToViewport_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.SlateBlueprintLibrary:LocalToViewport");
			PixelPosition = default(FVector2D);
			ViewportPosition = default(FVector2D);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LocalToViewport_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LocalToViewport_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, LocalToViewport_WorldContextObject_Offset), 0, LocalToViewport_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InitializeValue_InContainer(LocalToViewport_Geometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, LocalToViewport_Geometry_Offset), 0, LocalToViewport_Geometry_PropertyAddress.Address, Geometry);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, LocalToViewport_LocalCoordinate_Offset), 0, LocalToViewport_LocalCoordinate_PropertyAddress.Address, LocalCoordinate);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LocalToViewport_FunctionAddress, intPtr, LocalToViewport_ParamsSize);
		PixelPosition = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, LocalToViewport_PixelPosition_Offset), 0, LocalToViewport_PixelPosition_PropertyAddress.Address);
		ViewportPosition = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, LocalToViewport_ViewportPosition_Offset), 0, LocalToViewport_ViewportPosition_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/UMG.SlateBlueprintLibrary:LocalToAbsolute")]
	public unsafe static FVector2D LocalToAbsolute(FGeometry Geometry, FVector2D LocalCoordinate)
	{
		if (!LocalToAbsolute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.SlateBlueprintLibrary:LocalToAbsolute");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(LocalToAbsolute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LocalToAbsolute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(LocalToAbsolute_Geometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, LocalToAbsolute_Geometry_Offset), 0, LocalToAbsolute_Geometry_PropertyAddress.Address, Geometry);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, LocalToAbsolute_LocalCoordinate_Offset), 0, LocalToAbsolute_LocalCoordinate_PropertyAddress.Address, LocalCoordinate);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LocalToAbsolute_FunctionAddress, intPtr, LocalToAbsolute_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, LocalToAbsolute_ReturnValue_Offset), 0, LocalToAbsolute_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/UMG.SlateBlueprintLibrary:IsUnderLocation")]
	public unsafe static bool IsUnderLocation(FGeometry Geometry, FVector2D AbsoluteCoordinate)
	{
		if (!IsUnderLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.SlateBlueprintLibrary:IsUnderLocation");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsUnderLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsUnderLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsUnderLocation_Geometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, IsUnderLocation_Geometry_Offset), 0, IsUnderLocation_Geometry_PropertyAddress.Address, Geometry);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, IsUnderLocation_AbsoluteCoordinate_Offset), 0, IsUnderLocation_AbsoluteCoordinate_PropertyAddress.Address, AbsoluteCoordinate);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsUnderLocation_FunctionAddress, intPtr, IsUnderLocation_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsUnderLocation_ReturnValue_Offset), 0, IsUnderLocation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/UMG.SlateBlueprintLibrary:GetLocalTopLeft")]
	public unsafe static FVector2D GetLocalTopLeft(FGeometry Geometry)
	{
		if (!GetLocalTopLeft_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.SlateBlueprintLibrary:GetLocalTopLeft");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLocalTopLeft_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLocalTopLeft_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetLocalTopLeft_Geometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, GetLocalTopLeft_Geometry_Offset), 0, GetLocalTopLeft_Geometry_PropertyAddress.Address, Geometry);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLocalTopLeft_FunctionAddress, intPtr, GetLocalTopLeft_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetLocalTopLeft_ReturnValue_Offset), 0, GetLocalTopLeft_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/UMG.SlateBlueprintLibrary:GetLocalSize")]
	public unsafe static FVector2D GetLocalSize(FGeometry Geometry)
	{
		if (!GetLocalSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.SlateBlueprintLibrary:GetLocalSize");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLocalSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLocalSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetLocalSize_Geometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, GetLocalSize_Geometry_Offset), 0, GetLocalSize_Geometry_PropertyAddress.Address, Geometry);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLocalSize_FunctionAddress, intPtr, GetLocalSize_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetLocalSize_ReturnValue_Offset), 0, GetLocalSize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/UMG.SlateBlueprintLibrary:GetAbsoluteSize")]
	public unsafe static FVector2D GetAbsoluteSize(FGeometry Geometry)
	{
		if (!GetAbsoluteSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.SlateBlueprintLibrary:GetAbsoluteSize");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAbsoluteSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAbsoluteSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAbsoluteSize_Geometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, GetAbsoluteSize_Geometry_Offset), 0, GetAbsoluteSize_Geometry_PropertyAddress.Address, Geometry);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAbsoluteSize_FunctionAddress, intPtr, GetAbsoluteSize_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetAbsoluteSize_ReturnValue_Offset), 0, GetAbsoluteSize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/UMG.SlateBlueprintLibrary:EqualEqual_SlateBrush")]
	public unsafe static bool EqualEqual_SlateBrush(FSlateBrush A, FSlateBrush B)
	{
		if (!EqualEqual_SlateBrush_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.SlateBlueprintLibrary:EqualEqual_SlateBrush");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EqualEqual_SlateBrush_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EqualEqual_SlateBrush_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(EqualEqual_SlateBrush_A_PropertyAddress.Address, intPtr);
		FSlateBrush.ToNative(IntPtr.Add(intPtr, EqualEqual_SlateBrush_A_Offset), 0, EqualEqual_SlateBrush_A_PropertyAddress.Address, A);
		NativeReflection.InitializeValue_InContainer(EqualEqual_SlateBrush_B_PropertyAddress.Address, intPtr);
		FSlateBrush.ToNative(IntPtr.Add(intPtr, EqualEqual_SlateBrush_B_Offset), 0, EqualEqual_SlateBrush_B_PropertyAddress.Address, B);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EqualEqual_SlateBrush_FunctionAddress, intPtr, EqualEqual_SlateBrush_ParamsSize);
		NativeReflection.DestroyValue_InContainer(EqualEqual_SlateBrush_A_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(EqualEqual_SlateBrush_B_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, EqualEqual_SlateBrush_ReturnValue_Offset), 0, EqualEqual_SlateBrush_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/UMG.SlateBlueprintLibrary:AbsoluteToViewport")]
	public unsafe static void AbsoluteToViewport(UObject WorldContextObject, FVector2D AbsoluteDesktopCoordinate, out FVector2D PixelPosition, out FVector2D ViewportPosition)
	{
		if (!AbsoluteToViewport_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.SlateBlueprintLibrary:AbsoluteToViewport");
			PixelPosition = default(FVector2D);
			ViewportPosition = default(FVector2D);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AbsoluteToViewport_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AbsoluteToViewport_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AbsoluteToViewport_WorldContextObject_Offset), 0, AbsoluteToViewport_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, AbsoluteToViewport_AbsoluteDesktopCoordinate_Offset), 0, AbsoluteToViewport_AbsoluteDesktopCoordinate_PropertyAddress.Address, AbsoluteDesktopCoordinate);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AbsoluteToViewport_FunctionAddress, intPtr, AbsoluteToViewport_ParamsSize);
		PixelPosition = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, AbsoluteToViewport_PixelPosition_Offset), 0, AbsoluteToViewport_PixelPosition_PropertyAddress.Address);
		ViewportPosition = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, AbsoluteToViewport_ViewportPosition_Offset), 0, AbsoluteToViewport_ViewportPosition_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/UMG.SlateBlueprintLibrary:AbsoluteToLocal")]
	public unsafe static FVector2D AbsoluteToLocal(FGeometry Geometry, FVector2D AbsoluteCoordinate)
	{
		if (!AbsoluteToLocal_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.SlateBlueprintLibrary:AbsoluteToLocal");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(AbsoluteToLocal_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AbsoluteToLocal_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AbsoluteToLocal_Geometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, AbsoluteToLocal_Geometry_Offset), 0, AbsoluteToLocal_Geometry_PropertyAddress.Address, Geometry);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, AbsoluteToLocal_AbsoluteCoordinate_Offset), 0, AbsoluteToLocal_AbsoluteCoordinate_PropertyAddress.Address, AbsoluteCoordinate);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AbsoluteToLocal_FunctionAddress, intPtr, AbsoluteToLocal_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, AbsoluteToLocal_ReturnValue_Offset), 0, AbsoluteToLocal_ReturnValue_PropertyAddress.Address);
	}

	static USlateLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USlateLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USlateLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UMG.SlateBlueprintLibrary");
		TransformVectorLocalToAbsolute_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TransformVectorLocalToAbsolute");
		TransformVectorLocalToAbsolute_ParamsSize = NativeReflection.GetFunctionParamsSize(TransformVectorLocalToAbsolute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TransformVectorLocalToAbsolute_Geometry_PropertyAddress, TransformVectorLocalToAbsolute_FunctionAddress, "Geometry");
		TransformVectorLocalToAbsolute_Geometry_Offset = NativeReflectionCached.GetPropertyOffset(TransformVectorLocalToAbsolute_FunctionAddress, "Geometry");
		TransformVectorLocalToAbsolute_Geometry_IsValid = NativeReflectionCached.ValidatePropertyClass(TransformVectorLocalToAbsolute_FunctionAddress, "Geometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TransformVectorLocalToAbsolute_LocalVector_PropertyAddress, TransformVectorLocalToAbsolute_FunctionAddress, "LocalVector");
		TransformVectorLocalToAbsolute_LocalVector_Offset = NativeReflectionCached.GetPropertyOffset(TransformVectorLocalToAbsolute_FunctionAddress, "LocalVector");
		TransformVectorLocalToAbsolute_LocalVector_IsValid = NativeReflectionCached.ValidatePropertyClass(TransformVectorLocalToAbsolute_FunctionAddress, "LocalVector", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TransformVectorLocalToAbsolute_ReturnValue_PropertyAddress, TransformVectorLocalToAbsolute_FunctionAddress, "ReturnValue");
		TransformVectorLocalToAbsolute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TransformVectorLocalToAbsolute_FunctionAddress, "ReturnValue");
		TransformVectorLocalToAbsolute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TransformVectorLocalToAbsolute_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		TransformVectorLocalToAbsolute_IsValid = TransformVectorLocalToAbsolute_FunctionAddress != IntPtr.Zero && TransformVectorLocalToAbsolute_Geometry_IsValid && TransformVectorLocalToAbsolute_LocalVector_IsValid && TransformVectorLocalToAbsolute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.SlateBlueprintLibrary:TransformVectorLocalToAbsolute", TransformVectorLocalToAbsolute_IsValid);
		TransformVectorAbsoluteToLocal_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TransformVectorAbsoluteToLocal");
		TransformVectorAbsoluteToLocal_ParamsSize = NativeReflection.GetFunctionParamsSize(TransformVectorAbsoluteToLocal_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TransformVectorAbsoluteToLocal_Geometry_PropertyAddress, TransformVectorAbsoluteToLocal_FunctionAddress, "Geometry");
		TransformVectorAbsoluteToLocal_Geometry_Offset = NativeReflectionCached.GetPropertyOffset(TransformVectorAbsoluteToLocal_FunctionAddress, "Geometry");
		TransformVectorAbsoluteToLocal_Geometry_IsValid = NativeReflectionCached.ValidatePropertyClass(TransformVectorAbsoluteToLocal_FunctionAddress, "Geometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TransformVectorAbsoluteToLocal_AbsoluteVector_PropertyAddress, TransformVectorAbsoluteToLocal_FunctionAddress, "AbsoluteVector");
		TransformVectorAbsoluteToLocal_AbsoluteVector_Offset = NativeReflectionCached.GetPropertyOffset(TransformVectorAbsoluteToLocal_FunctionAddress, "AbsoluteVector");
		TransformVectorAbsoluteToLocal_AbsoluteVector_IsValid = NativeReflectionCached.ValidatePropertyClass(TransformVectorAbsoluteToLocal_FunctionAddress, "AbsoluteVector", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TransformVectorAbsoluteToLocal_ReturnValue_PropertyAddress, TransformVectorAbsoluteToLocal_FunctionAddress, "ReturnValue");
		TransformVectorAbsoluteToLocal_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TransformVectorAbsoluteToLocal_FunctionAddress, "ReturnValue");
		TransformVectorAbsoluteToLocal_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TransformVectorAbsoluteToLocal_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		TransformVectorAbsoluteToLocal_IsValid = TransformVectorAbsoluteToLocal_FunctionAddress != IntPtr.Zero && TransformVectorAbsoluteToLocal_Geometry_IsValid && TransformVectorAbsoluteToLocal_AbsoluteVector_IsValid && TransformVectorAbsoluteToLocal_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.SlateBlueprintLibrary:TransformVectorAbsoluteToLocal", TransformVectorAbsoluteToLocal_IsValid);
		TransformScalarLocalToAbsolute_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TransformScalarLocalToAbsolute");
		TransformScalarLocalToAbsolute_ParamsSize = NativeReflection.GetFunctionParamsSize(TransformScalarLocalToAbsolute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TransformScalarLocalToAbsolute_Geometry_PropertyAddress, TransformScalarLocalToAbsolute_FunctionAddress, "Geometry");
		TransformScalarLocalToAbsolute_Geometry_Offset = NativeReflectionCached.GetPropertyOffset(TransformScalarLocalToAbsolute_FunctionAddress, "Geometry");
		TransformScalarLocalToAbsolute_Geometry_IsValid = NativeReflectionCached.ValidatePropertyClass(TransformScalarLocalToAbsolute_FunctionAddress, "Geometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TransformScalarLocalToAbsolute_LocalScalar_PropertyAddress, TransformScalarLocalToAbsolute_FunctionAddress, "LocalScalar");
		TransformScalarLocalToAbsolute_LocalScalar_Offset = NativeReflectionCached.GetPropertyOffset(TransformScalarLocalToAbsolute_FunctionAddress, "LocalScalar");
		TransformScalarLocalToAbsolute_LocalScalar_IsValid = NativeReflectionCached.ValidatePropertyClass(TransformScalarLocalToAbsolute_FunctionAddress, "LocalScalar", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref TransformScalarLocalToAbsolute_ReturnValue_PropertyAddress, TransformScalarLocalToAbsolute_FunctionAddress, "ReturnValue");
		TransformScalarLocalToAbsolute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TransformScalarLocalToAbsolute_FunctionAddress, "ReturnValue");
		TransformScalarLocalToAbsolute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TransformScalarLocalToAbsolute_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		TransformScalarLocalToAbsolute_IsValid = TransformScalarLocalToAbsolute_FunctionAddress != IntPtr.Zero && TransformScalarLocalToAbsolute_Geometry_IsValid && TransformScalarLocalToAbsolute_LocalScalar_IsValid && TransformScalarLocalToAbsolute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.SlateBlueprintLibrary:TransformScalarLocalToAbsolute", TransformScalarLocalToAbsolute_IsValid);
		TransformScalarAbsoluteToLocal_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TransformScalarAbsoluteToLocal");
		TransformScalarAbsoluteToLocal_ParamsSize = NativeReflection.GetFunctionParamsSize(TransformScalarAbsoluteToLocal_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TransformScalarAbsoluteToLocal_Geometry_PropertyAddress, TransformScalarAbsoluteToLocal_FunctionAddress, "Geometry");
		TransformScalarAbsoluteToLocal_Geometry_Offset = NativeReflectionCached.GetPropertyOffset(TransformScalarAbsoluteToLocal_FunctionAddress, "Geometry");
		TransformScalarAbsoluteToLocal_Geometry_IsValid = NativeReflectionCached.ValidatePropertyClass(TransformScalarAbsoluteToLocal_FunctionAddress, "Geometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TransformScalarAbsoluteToLocal_AbsoluteScalar_PropertyAddress, TransformScalarAbsoluteToLocal_FunctionAddress, "AbsoluteScalar");
		TransformScalarAbsoluteToLocal_AbsoluteScalar_Offset = NativeReflectionCached.GetPropertyOffset(TransformScalarAbsoluteToLocal_FunctionAddress, "AbsoluteScalar");
		TransformScalarAbsoluteToLocal_AbsoluteScalar_IsValid = NativeReflectionCached.ValidatePropertyClass(TransformScalarAbsoluteToLocal_FunctionAddress, "AbsoluteScalar", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref TransformScalarAbsoluteToLocal_ReturnValue_PropertyAddress, TransformScalarAbsoluteToLocal_FunctionAddress, "ReturnValue");
		TransformScalarAbsoluteToLocal_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TransformScalarAbsoluteToLocal_FunctionAddress, "ReturnValue");
		TransformScalarAbsoluteToLocal_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TransformScalarAbsoluteToLocal_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		TransformScalarAbsoluteToLocal_IsValid = TransformScalarAbsoluteToLocal_FunctionAddress != IntPtr.Zero && TransformScalarAbsoluteToLocal_Geometry_IsValid && TransformScalarAbsoluteToLocal_AbsoluteScalar_IsValid && TransformScalarAbsoluteToLocal_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.SlateBlueprintLibrary:TransformScalarAbsoluteToLocal", TransformScalarAbsoluteToLocal_IsValid);
		ScreenToWidgetLocal_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ScreenToWidgetLocal");
		ScreenToWidgetLocal_ParamsSize = NativeReflection.GetFunctionParamsSize(ScreenToWidgetLocal_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScreenToWidgetLocal_WorldContextObject_PropertyAddress, ScreenToWidgetLocal_FunctionAddress, "WorldContextObject");
		ScreenToWidgetLocal_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(ScreenToWidgetLocal_FunctionAddress, "WorldContextObject");
		ScreenToWidgetLocal_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ScreenToWidgetLocal_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ScreenToWidgetLocal_Geometry_PropertyAddress, ScreenToWidgetLocal_FunctionAddress, "Geometry");
		ScreenToWidgetLocal_Geometry_Offset = NativeReflectionCached.GetPropertyOffset(ScreenToWidgetLocal_FunctionAddress, "Geometry");
		ScreenToWidgetLocal_Geometry_IsValid = NativeReflectionCached.ValidatePropertyClass(ScreenToWidgetLocal_FunctionAddress, "Geometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ScreenToWidgetLocal_ScreenPosition_PropertyAddress, ScreenToWidgetLocal_FunctionAddress, "ScreenPosition");
		ScreenToWidgetLocal_ScreenPosition_Offset = NativeReflectionCached.GetPropertyOffset(ScreenToWidgetLocal_FunctionAddress, "ScreenPosition");
		ScreenToWidgetLocal_ScreenPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(ScreenToWidgetLocal_FunctionAddress, "ScreenPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ScreenToWidgetLocal_LocalCoordinate_PropertyAddress, ScreenToWidgetLocal_FunctionAddress, "LocalCoordinate");
		ScreenToWidgetLocal_LocalCoordinate_Offset = NativeReflectionCached.GetPropertyOffset(ScreenToWidgetLocal_FunctionAddress, "LocalCoordinate");
		ScreenToWidgetLocal_LocalCoordinate_IsValid = NativeReflectionCached.ValidatePropertyClass(ScreenToWidgetLocal_FunctionAddress, "LocalCoordinate", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ScreenToWidgetLocal_bIncludeWindowPosition_PropertyAddress, ScreenToWidgetLocal_FunctionAddress, "bIncludeWindowPosition");
		ScreenToWidgetLocal_bIncludeWindowPosition_Offset = NativeReflectionCached.GetPropertyOffset(ScreenToWidgetLocal_FunctionAddress, "bIncludeWindowPosition");
		ScreenToWidgetLocal_bIncludeWindowPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(ScreenToWidgetLocal_FunctionAddress, "bIncludeWindowPosition", Classes.FBoolProperty);
		ScreenToWidgetLocal_IsValid = ScreenToWidgetLocal_FunctionAddress != IntPtr.Zero && ScreenToWidgetLocal_WorldContextObject_IsValid && ScreenToWidgetLocal_Geometry_IsValid && ScreenToWidgetLocal_ScreenPosition_IsValid && ScreenToWidgetLocal_LocalCoordinate_IsValid && ScreenToWidgetLocal_bIncludeWindowPosition_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.SlateBlueprintLibrary:ScreenToWidgetLocal", ScreenToWidgetLocal_IsValid);
		ScreenToWidgetAbsolute_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ScreenToWidgetAbsolute");
		ScreenToWidgetAbsolute_ParamsSize = NativeReflection.GetFunctionParamsSize(ScreenToWidgetAbsolute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScreenToWidgetAbsolute_WorldContextObject_PropertyAddress, ScreenToWidgetAbsolute_FunctionAddress, "WorldContextObject");
		ScreenToWidgetAbsolute_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(ScreenToWidgetAbsolute_FunctionAddress, "WorldContextObject");
		ScreenToWidgetAbsolute_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ScreenToWidgetAbsolute_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ScreenToWidgetAbsolute_ScreenPosition_PropertyAddress, ScreenToWidgetAbsolute_FunctionAddress, "ScreenPosition");
		ScreenToWidgetAbsolute_ScreenPosition_Offset = NativeReflectionCached.GetPropertyOffset(ScreenToWidgetAbsolute_FunctionAddress, "ScreenPosition");
		ScreenToWidgetAbsolute_ScreenPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(ScreenToWidgetAbsolute_FunctionAddress, "ScreenPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ScreenToWidgetAbsolute_AbsoluteCoordinate_PropertyAddress, ScreenToWidgetAbsolute_FunctionAddress, "AbsoluteCoordinate");
		ScreenToWidgetAbsolute_AbsoluteCoordinate_Offset = NativeReflectionCached.GetPropertyOffset(ScreenToWidgetAbsolute_FunctionAddress, "AbsoluteCoordinate");
		ScreenToWidgetAbsolute_AbsoluteCoordinate_IsValid = NativeReflectionCached.ValidatePropertyClass(ScreenToWidgetAbsolute_FunctionAddress, "AbsoluteCoordinate", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ScreenToWidgetAbsolute_bIncludeWindowPosition_PropertyAddress, ScreenToWidgetAbsolute_FunctionAddress, "bIncludeWindowPosition");
		ScreenToWidgetAbsolute_bIncludeWindowPosition_Offset = NativeReflectionCached.GetPropertyOffset(ScreenToWidgetAbsolute_FunctionAddress, "bIncludeWindowPosition");
		ScreenToWidgetAbsolute_bIncludeWindowPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(ScreenToWidgetAbsolute_FunctionAddress, "bIncludeWindowPosition", Classes.FBoolProperty);
		ScreenToWidgetAbsolute_IsValid = ScreenToWidgetAbsolute_FunctionAddress != IntPtr.Zero && ScreenToWidgetAbsolute_WorldContextObject_IsValid && ScreenToWidgetAbsolute_ScreenPosition_IsValid && ScreenToWidgetAbsolute_AbsoluteCoordinate_IsValid && ScreenToWidgetAbsolute_bIncludeWindowPosition_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.SlateBlueprintLibrary:ScreenToWidgetAbsolute", ScreenToWidgetAbsolute_IsValid);
		ScreenToViewport_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ScreenToViewport");
		ScreenToViewport_ParamsSize = NativeReflection.GetFunctionParamsSize(ScreenToViewport_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScreenToViewport_WorldContextObject_PropertyAddress, ScreenToViewport_FunctionAddress, "WorldContextObject");
		ScreenToViewport_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(ScreenToViewport_FunctionAddress, "WorldContextObject");
		ScreenToViewport_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ScreenToViewport_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ScreenToViewport_ScreenPosition_PropertyAddress, ScreenToViewport_FunctionAddress, "ScreenPosition");
		ScreenToViewport_ScreenPosition_Offset = NativeReflectionCached.GetPropertyOffset(ScreenToViewport_FunctionAddress, "ScreenPosition");
		ScreenToViewport_ScreenPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(ScreenToViewport_FunctionAddress, "ScreenPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ScreenToViewport_ViewportPosition_PropertyAddress, ScreenToViewport_FunctionAddress, "ViewportPosition");
		ScreenToViewport_ViewportPosition_Offset = NativeReflectionCached.GetPropertyOffset(ScreenToViewport_FunctionAddress, "ViewportPosition");
		ScreenToViewport_ViewportPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(ScreenToViewport_FunctionAddress, "ViewportPosition", Classes.FStructProperty);
		ScreenToViewport_IsValid = ScreenToViewport_FunctionAddress != IntPtr.Zero && ScreenToViewport_WorldContextObject_IsValid && ScreenToViewport_ScreenPosition_IsValid && ScreenToViewport_ViewportPosition_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.SlateBlueprintLibrary:ScreenToViewport", ScreenToViewport_IsValid);
		LocalToViewport_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LocalToViewport");
		LocalToViewport_ParamsSize = NativeReflection.GetFunctionParamsSize(LocalToViewport_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LocalToViewport_WorldContextObject_PropertyAddress, LocalToViewport_FunctionAddress, "WorldContextObject");
		LocalToViewport_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(LocalToViewport_FunctionAddress, "WorldContextObject");
		LocalToViewport_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(LocalToViewport_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref LocalToViewport_Geometry_PropertyAddress, LocalToViewport_FunctionAddress, "Geometry");
		LocalToViewport_Geometry_Offset = NativeReflectionCached.GetPropertyOffset(LocalToViewport_FunctionAddress, "Geometry");
		LocalToViewport_Geometry_IsValid = NativeReflectionCached.ValidatePropertyClass(LocalToViewport_FunctionAddress, "Geometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LocalToViewport_LocalCoordinate_PropertyAddress, LocalToViewport_FunctionAddress, "LocalCoordinate");
		LocalToViewport_LocalCoordinate_Offset = NativeReflectionCached.GetPropertyOffset(LocalToViewport_FunctionAddress, "LocalCoordinate");
		LocalToViewport_LocalCoordinate_IsValid = NativeReflectionCached.ValidatePropertyClass(LocalToViewport_FunctionAddress, "LocalCoordinate", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LocalToViewport_PixelPosition_PropertyAddress, LocalToViewport_FunctionAddress, "PixelPosition");
		LocalToViewport_PixelPosition_Offset = NativeReflectionCached.GetPropertyOffset(LocalToViewport_FunctionAddress, "PixelPosition");
		LocalToViewport_PixelPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(LocalToViewport_FunctionAddress, "PixelPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LocalToViewport_ViewportPosition_PropertyAddress, LocalToViewport_FunctionAddress, "ViewportPosition");
		LocalToViewport_ViewportPosition_Offset = NativeReflectionCached.GetPropertyOffset(LocalToViewport_FunctionAddress, "ViewportPosition");
		LocalToViewport_ViewportPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(LocalToViewport_FunctionAddress, "ViewportPosition", Classes.FStructProperty);
		LocalToViewport_IsValid = LocalToViewport_FunctionAddress != IntPtr.Zero && LocalToViewport_WorldContextObject_IsValid && LocalToViewport_Geometry_IsValid && LocalToViewport_LocalCoordinate_IsValid && LocalToViewport_PixelPosition_IsValid && LocalToViewport_ViewportPosition_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.SlateBlueprintLibrary:LocalToViewport", LocalToViewport_IsValid);
		LocalToAbsolute_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LocalToAbsolute");
		LocalToAbsolute_ParamsSize = NativeReflection.GetFunctionParamsSize(LocalToAbsolute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LocalToAbsolute_Geometry_PropertyAddress, LocalToAbsolute_FunctionAddress, "Geometry");
		LocalToAbsolute_Geometry_Offset = NativeReflectionCached.GetPropertyOffset(LocalToAbsolute_FunctionAddress, "Geometry");
		LocalToAbsolute_Geometry_IsValid = NativeReflectionCached.ValidatePropertyClass(LocalToAbsolute_FunctionAddress, "Geometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LocalToAbsolute_LocalCoordinate_PropertyAddress, LocalToAbsolute_FunctionAddress, "LocalCoordinate");
		LocalToAbsolute_LocalCoordinate_Offset = NativeReflectionCached.GetPropertyOffset(LocalToAbsolute_FunctionAddress, "LocalCoordinate");
		LocalToAbsolute_LocalCoordinate_IsValid = NativeReflectionCached.ValidatePropertyClass(LocalToAbsolute_FunctionAddress, "LocalCoordinate", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LocalToAbsolute_ReturnValue_PropertyAddress, LocalToAbsolute_FunctionAddress, "ReturnValue");
		LocalToAbsolute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LocalToAbsolute_FunctionAddress, "ReturnValue");
		LocalToAbsolute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LocalToAbsolute_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		LocalToAbsolute_IsValid = LocalToAbsolute_FunctionAddress != IntPtr.Zero && LocalToAbsolute_Geometry_IsValid && LocalToAbsolute_LocalCoordinate_IsValid && LocalToAbsolute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.SlateBlueprintLibrary:LocalToAbsolute", LocalToAbsolute_IsValid);
		IsUnderLocation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsUnderLocation");
		IsUnderLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(IsUnderLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsUnderLocation_Geometry_PropertyAddress, IsUnderLocation_FunctionAddress, "Geometry");
		IsUnderLocation_Geometry_Offset = NativeReflectionCached.GetPropertyOffset(IsUnderLocation_FunctionAddress, "Geometry");
		IsUnderLocation_Geometry_IsValid = NativeReflectionCached.ValidatePropertyClass(IsUnderLocation_FunctionAddress, "Geometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsUnderLocation_AbsoluteCoordinate_PropertyAddress, IsUnderLocation_FunctionAddress, "AbsoluteCoordinate");
		IsUnderLocation_AbsoluteCoordinate_Offset = NativeReflectionCached.GetPropertyOffset(IsUnderLocation_FunctionAddress, "AbsoluteCoordinate");
		IsUnderLocation_AbsoluteCoordinate_IsValid = NativeReflectionCached.ValidatePropertyClass(IsUnderLocation_FunctionAddress, "AbsoluteCoordinate", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsUnderLocation_ReturnValue_PropertyAddress, IsUnderLocation_FunctionAddress, "ReturnValue");
		IsUnderLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsUnderLocation_FunctionAddress, "ReturnValue");
		IsUnderLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsUnderLocation_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsUnderLocation_IsValid = IsUnderLocation_FunctionAddress != IntPtr.Zero && IsUnderLocation_Geometry_IsValid && IsUnderLocation_AbsoluteCoordinate_IsValid && IsUnderLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.SlateBlueprintLibrary:IsUnderLocation", IsUnderLocation_IsValid);
		GetLocalTopLeft_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLocalTopLeft");
		GetLocalTopLeft_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLocalTopLeft_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLocalTopLeft_Geometry_PropertyAddress, GetLocalTopLeft_FunctionAddress, "Geometry");
		GetLocalTopLeft_Geometry_Offset = NativeReflectionCached.GetPropertyOffset(GetLocalTopLeft_FunctionAddress, "Geometry");
		GetLocalTopLeft_Geometry_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocalTopLeft_FunctionAddress, "Geometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocalTopLeft_ReturnValue_PropertyAddress, GetLocalTopLeft_FunctionAddress, "ReturnValue");
		GetLocalTopLeft_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLocalTopLeft_FunctionAddress, "ReturnValue");
		GetLocalTopLeft_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocalTopLeft_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetLocalTopLeft_IsValid = GetLocalTopLeft_FunctionAddress != IntPtr.Zero && GetLocalTopLeft_Geometry_IsValid && GetLocalTopLeft_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.SlateBlueprintLibrary:GetLocalTopLeft", GetLocalTopLeft_IsValid);
		GetLocalSize_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLocalSize");
		GetLocalSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLocalSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLocalSize_Geometry_PropertyAddress, GetLocalSize_FunctionAddress, "Geometry");
		GetLocalSize_Geometry_Offset = NativeReflectionCached.GetPropertyOffset(GetLocalSize_FunctionAddress, "Geometry");
		GetLocalSize_Geometry_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocalSize_FunctionAddress, "Geometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocalSize_ReturnValue_PropertyAddress, GetLocalSize_FunctionAddress, "ReturnValue");
		GetLocalSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLocalSize_FunctionAddress, "ReturnValue");
		GetLocalSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocalSize_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetLocalSize_IsValid = GetLocalSize_FunctionAddress != IntPtr.Zero && GetLocalSize_Geometry_IsValid && GetLocalSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.SlateBlueprintLibrary:GetLocalSize", GetLocalSize_IsValid);
		GetAbsoluteSize_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAbsoluteSize");
		GetAbsoluteSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAbsoluteSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAbsoluteSize_Geometry_PropertyAddress, GetAbsoluteSize_FunctionAddress, "Geometry");
		GetAbsoluteSize_Geometry_Offset = NativeReflectionCached.GetPropertyOffset(GetAbsoluteSize_FunctionAddress, "Geometry");
		GetAbsoluteSize_Geometry_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAbsoluteSize_FunctionAddress, "Geometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAbsoluteSize_ReturnValue_PropertyAddress, GetAbsoluteSize_FunctionAddress, "ReturnValue");
		GetAbsoluteSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAbsoluteSize_FunctionAddress, "ReturnValue");
		GetAbsoluteSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAbsoluteSize_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetAbsoluteSize_IsValid = GetAbsoluteSize_FunctionAddress != IntPtr.Zero && GetAbsoluteSize_Geometry_IsValid && GetAbsoluteSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.SlateBlueprintLibrary:GetAbsoluteSize", GetAbsoluteSize_IsValid);
		EqualEqual_SlateBrush_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EqualEqual_SlateBrush");
		EqualEqual_SlateBrush_ParamsSize = NativeReflection.GetFunctionParamsSize(EqualEqual_SlateBrush_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EqualEqual_SlateBrush_A_PropertyAddress, EqualEqual_SlateBrush_FunctionAddress, "A");
		EqualEqual_SlateBrush_A_Offset = NativeReflectionCached.GetPropertyOffset(EqualEqual_SlateBrush_FunctionAddress, "A");
		EqualEqual_SlateBrush_A_IsValid = NativeReflectionCached.ValidatePropertyClass(EqualEqual_SlateBrush_FunctionAddress, "A", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref EqualEqual_SlateBrush_B_PropertyAddress, EqualEqual_SlateBrush_FunctionAddress, "B");
		EqualEqual_SlateBrush_B_Offset = NativeReflectionCached.GetPropertyOffset(EqualEqual_SlateBrush_FunctionAddress, "B");
		EqualEqual_SlateBrush_B_IsValid = NativeReflectionCached.ValidatePropertyClass(EqualEqual_SlateBrush_FunctionAddress, "B", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref EqualEqual_SlateBrush_ReturnValue_PropertyAddress, EqualEqual_SlateBrush_FunctionAddress, "ReturnValue");
		EqualEqual_SlateBrush_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EqualEqual_SlateBrush_FunctionAddress, "ReturnValue");
		EqualEqual_SlateBrush_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EqualEqual_SlateBrush_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		EqualEqual_SlateBrush_IsValid = EqualEqual_SlateBrush_FunctionAddress != IntPtr.Zero && EqualEqual_SlateBrush_A_IsValid && EqualEqual_SlateBrush_B_IsValid && EqualEqual_SlateBrush_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.SlateBlueprintLibrary:EqualEqual_SlateBrush", EqualEqual_SlateBrush_IsValid);
		AbsoluteToViewport_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AbsoluteToViewport");
		AbsoluteToViewport_ParamsSize = NativeReflection.GetFunctionParamsSize(AbsoluteToViewport_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AbsoluteToViewport_WorldContextObject_PropertyAddress, AbsoluteToViewport_FunctionAddress, "WorldContextObject");
		AbsoluteToViewport_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(AbsoluteToViewport_FunctionAddress, "WorldContextObject");
		AbsoluteToViewport_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AbsoluteToViewport_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AbsoluteToViewport_AbsoluteDesktopCoordinate_PropertyAddress, AbsoluteToViewport_FunctionAddress, "AbsoluteDesktopCoordinate");
		AbsoluteToViewport_AbsoluteDesktopCoordinate_Offset = NativeReflectionCached.GetPropertyOffset(AbsoluteToViewport_FunctionAddress, "AbsoluteDesktopCoordinate");
		AbsoluteToViewport_AbsoluteDesktopCoordinate_IsValid = NativeReflectionCached.ValidatePropertyClass(AbsoluteToViewport_FunctionAddress, "AbsoluteDesktopCoordinate", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AbsoluteToViewport_PixelPosition_PropertyAddress, AbsoluteToViewport_FunctionAddress, "PixelPosition");
		AbsoluteToViewport_PixelPosition_Offset = NativeReflectionCached.GetPropertyOffset(AbsoluteToViewport_FunctionAddress, "PixelPosition");
		AbsoluteToViewport_PixelPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(AbsoluteToViewport_FunctionAddress, "PixelPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AbsoluteToViewport_ViewportPosition_PropertyAddress, AbsoluteToViewport_FunctionAddress, "ViewportPosition");
		AbsoluteToViewport_ViewportPosition_Offset = NativeReflectionCached.GetPropertyOffset(AbsoluteToViewport_FunctionAddress, "ViewportPosition");
		AbsoluteToViewport_ViewportPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(AbsoluteToViewport_FunctionAddress, "ViewportPosition", Classes.FStructProperty);
		AbsoluteToViewport_IsValid = AbsoluteToViewport_FunctionAddress != IntPtr.Zero && AbsoluteToViewport_WorldContextObject_IsValid && AbsoluteToViewport_AbsoluteDesktopCoordinate_IsValid && AbsoluteToViewport_PixelPosition_IsValid && AbsoluteToViewport_ViewportPosition_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.SlateBlueprintLibrary:AbsoluteToViewport", AbsoluteToViewport_IsValid);
		AbsoluteToLocal_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AbsoluteToLocal");
		AbsoluteToLocal_ParamsSize = NativeReflection.GetFunctionParamsSize(AbsoluteToLocal_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AbsoluteToLocal_Geometry_PropertyAddress, AbsoluteToLocal_FunctionAddress, "Geometry");
		AbsoluteToLocal_Geometry_Offset = NativeReflectionCached.GetPropertyOffset(AbsoluteToLocal_FunctionAddress, "Geometry");
		AbsoluteToLocal_Geometry_IsValid = NativeReflectionCached.ValidatePropertyClass(AbsoluteToLocal_FunctionAddress, "Geometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AbsoluteToLocal_AbsoluteCoordinate_PropertyAddress, AbsoluteToLocal_FunctionAddress, "AbsoluteCoordinate");
		AbsoluteToLocal_AbsoluteCoordinate_Offset = NativeReflectionCached.GetPropertyOffset(AbsoluteToLocal_FunctionAddress, "AbsoluteCoordinate");
		AbsoluteToLocal_AbsoluteCoordinate_IsValid = NativeReflectionCached.ValidatePropertyClass(AbsoluteToLocal_FunctionAddress, "AbsoluteCoordinate", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AbsoluteToLocal_ReturnValue_PropertyAddress, AbsoluteToLocal_FunctionAddress, "ReturnValue");
		AbsoluteToLocal_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AbsoluteToLocal_FunctionAddress, "ReturnValue");
		AbsoluteToLocal_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AbsoluteToLocal_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		AbsoluteToLocal_IsValid = AbsoluteToLocal_FunctionAddress != IntPtr.Zero && AbsoluteToLocal_Geometry_IsValid && AbsoluteToLocal_AbsoluteCoordinate_IsValid && AbsoluteToLocal_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.SlateBlueprintLibrary:AbsoluteToLocal", AbsoluteToLocal_IsValid);
	}
}
