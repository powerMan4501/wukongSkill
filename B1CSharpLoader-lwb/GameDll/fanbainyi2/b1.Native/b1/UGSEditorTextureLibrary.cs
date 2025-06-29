using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/FuncLibEditor.GSEditorTextureLibrary", "FuncLibEditor", UnrealModuleType.Game)]
public class UGSEditorTextureLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool StopCollectingTexDimensions_IsValid;

	private static IntPtr StopCollectingTexDimensions_FunctionAddress;

	private static int StopCollectingTexDimensions_ParamsSize;

	private static bool StopCollectingTexDimensions_ReturnValue_IsValid;

	private static FFieldAddress StopCollectingTexDimensions_ReturnValue_PropertyAddress;

	private static int StopCollectingTexDimensions_ReturnValue_Offset;

	private static bool StartCollectingTexDimensions_IsValid;

	private static IntPtr StartCollectingTexDimensions_FunctionAddress;

	private static int StartCollectingTexDimensions_ParamsSize;

	private static bool StartCollectingTexDimensions_ReturnValue_IsValid;

	private static FFieldAddress StartCollectingTexDimensions_ReturnValue_PropertyAddress;

	private static int StartCollectingTexDimensions_ReturnValue_Offset;

	private static bool SetLevelViewportCameraInfo_IsValid;

	private static IntPtr SetLevelViewportCameraInfo_FunctionAddress;

	private static int SetLevelViewportCameraInfo_ParamsSize;

	private static bool SetLevelViewportCameraInfo_CameraLocation_IsValid;

	private static FFieldAddress SetLevelViewportCameraInfo_CameraLocation_PropertyAddress;

	private static int SetLevelViewportCameraInfo_CameraLocation_Offset;

	private static bool SetLevelViewportCameraInfo_CameraRotation_IsValid;

	private static FFieldAddress SetLevelViewportCameraInfo_CameraRotation_PropertyAddress;

	private static int SetLevelViewportCameraInfo_CameraRotation_Offset;

	private static bool SampleTexture2DLinearColor_IsValid;

	private static IntPtr SampleTexture2DLinearColor_FunctionAddress;

	private static int SampleTexture2DLinearColor_ParamsSize;

	private static bool SampleTexture2DLinearColor_InTexture_IsValid;

	private static FFieldAddress SampleTexture2DLinearColor_InTexture_PropertyAddress;

	private static int SampleTexture2DLinearColor_InTexture_Offset;

	private static bool SampleTexture2DLinearColor_X_IsValid;

	private static FFieldAddress SampleTexture2DLinearColor_X_PropertyAddress;

	private static int SampleTexture2DLinearColor_X_Offset;

	private static bool SampleTexture2DLinearColor_Y_IsValid;

	private static FFieldAddress SampleTexture2DLinearColor_Y_PropertyAddress;

	private static int SampleTexture2DLinearColor_Y_Offset;

	private static bool SampleTexture2DLinearColor_ReturnValue_IsValid;

	private static FFieldAddress SampleTexture2DLinearColor_ReturnValue_PropertyAddress;

	private static int SampleTexture2DLinearColor_ReturnValue_Offset;

	private static bool SampleTexture2DColor_IsValid;

	private static IntPtr SampleTexture2DColor_FunctionAddress;

	private static int SampleTexture2DColor_ParamsSize;

	private static bool SampleTexture2DColor_InTexture_IsValid;

	private static FFieldAddress SampleTexture2DColor_InTexture_PropertyAddress;

	private static int SampleTexture2DColor_InTexture_Offset;

	private static bool SampleTexture2DColor_X_IsValid;

	private static FFieldAddress SampleTexture2DColor_X_PropertyAddress;

	private static int SampleTexture2DColor_X_Offset;

	private static bool SampleTexture2DColor_Y_IsValid;

	private static FFieldAddress SampleTexture2DColor_Y_PropertyAddress;

	private static int SampleTexture2DColor_Y_Offset;

	private static bool SampleTexture2DColor_ReturnValue_IsValid;

	private static FFieldAddress SampleTexture2DColor_ReturnValue_PropertyAddress;

	private static int SampleTexture2DColor_ReturnValue_Offset;

	private static bool ReplaceSourceFileName_IsValid;

	private static IntPtr ReplaceSourceFileName_FunctionAddress;

	private static int ReplaceSourceFileName_ParamsSize;

	private static bool ReplaceSourceFileName_Texture_IsValid;

	private static FFieldAddress ReplaceSourceFileName_Texture_PropertyAddress;

	private static int ReplaceSourceFileName_Texture_Offset;

	private static bool ReplaceSourceFileName_Src_IsValid;

	private static FFieldAddress ReplaceSourceFileName_Src_PropertyAddress;

	private static int ReplaceSourceFileName_Src_Offset;

	private static bool ReplaceSourceFileName_Target_IsValid;

	private static FFieldAddress ReplaceSourceFileName_Target_PropertyAddress;

	private static int ReplaceSourceFileName_Target_Offset;

	private static bool ExportTexture2DAsHDR_IsValid;

	private static IntPtr ExportTexture2DAsHDR_FunctionAddress;

	private static int ExportTexture2DAsHDR_ParamsSize;

	private static bool ExportTexture2DAsHDR_WorldContextObject_IsValid;

	private static FFieldAddress ExportTexture2DAsHDR_WorldContextObject_PropertyAddress;

	private static int ExportTexture2DAsHDR_WorldContextObject_Offset;

	private static bool ExportTexture2DAsHDR_Texture_IsValid;

	private static FFieldAddress ExportTexture2DAsHDR_Texture_PropertyAddress;

	private static int ExportTexture2DAsHDR_Texture_Offset;

	private static bool ExportTexture2DAsHDR_FilePath_IsValid;

	private static FFieldAddress ExportTexture2DAsHDR_FilePath_PropertyAddress;

	private static int ExportTexture2DAsHDR_FilePath_Offset;

	private static bool ExportTexture2DAsHDR_FileName_IsValid;

	private static FFieldAddress ExportTexture2DAsHDR_FileName_PropertyAddress;

	private static int ExportTexture2DAsHDR_FileName_Offset;

	private static bool ExportTexture2DAsHDR_ReturnValue_IsValid;

	private static FFieldAddress ExportTexture2DAsHDR_ReturnValue_PropertyAddress;

	private static int ExportTexture2DAsHDR_ReturnValue_Offset;

	private static bool ExportTexture2D_IsValid;

	private static IntPtr ExportTexture2D_FunctionAddress;

	private static int ExportTexture2D_ParamsSize;

	private static bool ExportTexture2D_Texture_IsValid;

	private static FFieldAddress ExportTexture2D_Texture_PropertyAddress;

	private static int ExportTexture2D_Texture_Offset;

	private static bool ExportTexture2D_FilePath_IsValid;

	private static FFieldAddress ExportTexture2D_FilePath_PropertyAddress;

	private static int ExportTexture2D_FilePath_Offset;

	private static bool ExportTexture2D_FileName_IsValid;

	private static FFieldAddress ExportTexture2D_FileName_PropertyAddress;

	private static int ExportTexture2D_FileName_Offset;

	private static bool ExportTexture2D_ReturnValue_IsValid;

	private static FFieldAddress ExportTexture2D_ReturnValue_PropertyAddress;

	private static int ExportTexture2D_ReturnValue_Offset;

	private static bool CreateTexture2DFromFColor_IsValid;

	private static IntPtr CreateTexture2DFromFColor_FunctionAddress;

	private static int CreateTexture2DFromFColor_ParamsSize;

	private static bool CreateTexture2DFromFColor_SrcWidth_IsValid;

	private static FFieldAddress CreateTexture2DFromFColor_SrcWidth_PropertyAddress;

	private static int CreateTexture2DFromFColor_SrcWidth_Offset;

	private static bool CreateTexture2DFromFColor_SrcHeight_IsValid;

	private static FFieldAddress CreateTexture2DFromFColor_SrcHeight_PropertyAddress;

	private static int CreateTexture2DFromFColor_SrcHeight_Offset;

	private static bool CreateTexture2DFromFColor_WithAlpha_IsValid;

	private static FFieldAddress CreateTexture2DFromFColor_WithAlpha_PropertyAddress;

	private static int CreateTexture2DFromFColor_WithAlpha_Offset;

	private static bool CreateTexture2DFromFColor_ColorData_IsValid;

	private static FFieldAddress CreateTexture2DFromFColor_ColorData_PropertyAddress;

	private static int CreateTexture2DFromFColor_ColorData_Offset;

	private static bool CreateTexture2DFromFColor_AssetName_IsValid;

	private static FFieldAddress CreateTexture2DFromFColor_AssetName_PropertyAddress;

	private static int CreateTexture2DFromFColor_AssetName_Offset;

	private static bool CreateTexture2DFromFColor_PackageName_IsValid;

	private static FFieldAddress CreateTexture2DFromFColor_PackageName_PropertyAddress;

	private static int CreateTexture2DFromFColor_PackageName_Offset;

	private static bool CreateTexture2DFromFColor_InFormat_IsValid;

	private static FFieldAddress CreateTexture2DFromFColor_InFormat_PropertyAddress;

	private static int CreateTexture2DFromFColor_InFormat_Offset;

	private static bool CreateTexture2DFromFColor_ReturnValue_IsValid;

	private static FFieldAddress CreateTexture2DFromFColor_ReturnValue_PropertyAddress;

	private static int CreateTexture2DFromFColor_ReturnValue_Offset;

	private static bool CreateTexture2D_IsValid;

	private static IntPtr CreateTexture2D_FunctionAddress;

	private static int CreateTexture2D_ParamsSize;

	private static bool CreateTexture2D_SrcWidth_IsValid;

	private static FFieldAddress CreateTexture2D_SrcWidth_PropertyAddress;

	private static int CreateTexture2D_SrcWidth_Offset;

	private static bool CreateTexture2D_SrcHeight_IsValid;

	private static FFieldAddress CreateTexture2D_SrcHeight_PropertyAddress;

	private static int CreateTexture2D_SrcHeight_Offset;

	private static bool CreateTexture2D_Name_IsValid;

	private static FFieldAddress CreateTexture2D_Name_PropertyAddress;

	private static int CreateTexture2D_Name_Offset;

	private static bool CreateTexture2D_PackageName_IsValid;

	private static FFieldAddress CreateTexture2D_PackageName_PropertyAddress;

	private static int CreateTexture2D_PackageName_Offset;

	private static bool CreateTexture2D_InFormat_IsValid;

	private static FFieldAddress CreateTexture2D_InFormat_PropertyAddress;

	private static int CreateTexture2D_InFormat_Offset;

	private static bool CreateTexture2D_ReturnValue_IsValid;

	private static FFieldAddress CreateTexture2D_ReturnValue_PropertyAddress;

	private static int CreateTexture2D_ReturnValue_Offset;

	private static bool CopyTextureSettings_IsValid;

	private static IntPtr CopyTextureSettings_FunctionAddress;

	private static int CopyTextureSettings_ParamsSize;

	private static bool CopyTextureSettings_SrcTexture_IsValid;

	private static FFieldAddress CopyTextureSettings_SrcTexture_PropertyAddress;

	private static int CopyTextureSettings_SrcTexture_Offset;

	private static bool CopyTextureSettings_DestTexture_IsValid;

	private static FFieldAddress CopyTextureSettings_DestTexture_PropertyAddress;

	private static int CopyTextureSettings_DestTexture_Offset;

	private static bool CollectTexDimensions_IsValid;

	private static IntPtr CollectTexDimensions_FunctionAddress;

	private static int CollectTexDimensions_ParamsSize;

	private static bool CollectTexDimensions_ReturnValue_IsValid;

	private static FFieldAddress CollectTexDimensions_ReturnValue_PropertyAddress;

	private static int CollectTexDimensions_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorTextureLibrary:StopCollectingTexDimensions")]
	public unsafe static bool StopCollectingTexDimensions()
	{
		if (!StopCollectingTexDimensions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorTextureLibrary:StopCollectingTexDimensions");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopCollectingTexDimensions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopCollectingTexDimensions_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, StopCollectingTexDimensions_FunctionAddress, intPtr, StopCollectingTexDimensions_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, StopCollectingTexDimensions_ReturnValue_Offset), 0, StopCollectingTexDimensions_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorTextureLibrary:StartCollectingTexDimensions")]
	public unsafe static bool StartCollectingTexDimensions()
	{
		if (!StartCollectingTexDimensions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorTextureLibrary:StartCollectingTexDimensions");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartCollectingTexDimensions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartCollectingTexDimensions_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, StartCollectingTexDimensions_FunctionAddress, intPtr, StartCollectingTexDimensions_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, StartCollectingTexDimensions_ReturnValue_Offset), 0, StartCollectingTexDimensions_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorTextureLibrary:SetLevelViewportCameraInfo")]
	public unsafe static void SetLevelViewportCameraInfo(FVector CameraLocation, FRotator CameraRotation)
	{
		if (!SetLevelViewportCameraInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorTextureLibrary:SetLevelViewportCameraInfo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLevelViewportCameraInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLevelViewportCameraInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetLevelViewportCameraInfo_CameraLocation_Offset), 0, SetLevelViewportCameraInfo_CameraLocation_PropertyAddress.Address, CameraLocation);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SetLevelViewportCameraInfo_CameraRotation_Offset), 0, SetLevelViewportCameraInfo_CameraRotation_PropertyAddress.Address, CameraRotation);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetLevelViewportCameraInfo_FunctionAddress, intPtr, SetLevelViewportCameraInfo_ParamsSize);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorTextureLibrary:SampleTexture2DLinearColor")]
	public unsafe static FLinearColor SampleTexture2DLinearColor(UTexture2D InTexture, int X, int Y)
	{
		if (!SampleTexture2DLinearColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorTextureLibrary:SampleTexture2DLinearColor");
			return default(FLinearColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(SampleTexture2DLinearColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SampleTexture2DLinearColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(intPtr, SampleTexture2DLinearColor_InTexture_Offset), 0, SampleTexture2DLinearColor_InTexture_PropertyAddress.Address, InTexture);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SampleTexture2DLinearColor_X_Offset), 0, SampleTexture2DLinearColor_X_PropertyAddress.Address, X);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SampleTexture2DLinearColor_Y_Offset), 0, SampleTexture2DLinearColor_Y_PropertyAddress.Address, Y);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SampleTexture2DLinearColor_FunctionAddress, intPtr, SampleTexture2DLinearColor_ParamsSize);
		return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, SampleTexture2DLinearColor_ReturnValue_Offset), 0, SampleTexture2DLinearColor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorTextureLibrary:SampleTexture2DColor")]
	public unsafe static FColor SampleTexture2DColor(UTexture2D InTexture, int X, int Y)
	{
		if (!SampleTexture2DColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorTextureLibrary:SampleTexture2DColor");
			return default(FColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(SampleTexture2DColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SampleTexture2DColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(intPtr, SampleTexture2DColor_InTexture_Offset), 0, SampleTexture2DColor_InTexture_PropertyAddress.Address, InTexture);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SampleTexture2DColor_X_Offset), 0, SampleTexture2DColor_X_PropertyAddress.Address, X);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SampleTexture2DColor_Y_Offset), 0, SampleTexture2DColor_Y_PropertyAddress.Address, Y);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SampleTexture2DColor_FunctionAddress, intPtr, SampleTexture2DColor_ParamsSize);
		return BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(intPtr, SampleTexture2DColor_ReturnValue_Offset), 0, SampleTexture2DColor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorTextureLibrary:ReplaceSourceFileName")]
	public unsafe static void ReplaceSourceFileName(UTexture Texture, string Src, string Target)
	{
		if (!ReplaceSourceFileName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorTextureLibrary:ReplaceSourceFileName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReplaceSourceFileName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReplaceSourceFileName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(intPtr, ReplaceSourceFileName_Texture_Offset), 0, ReplaceSourceFileName_Texture_PropertyAddress.Address, Texture);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ReplaceSourceFileName_Src_Offset), 0, ReplaceSourceFileName_Src_PropertyAddress.Address, Src);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ReplaceSourceFileName_Target_Offset), 0, ReplaceSourceFileName_Target_PropertyAddress.Address, Target);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ReplaceSourceFileName_FunctionAddress, intPtr, ReplaceSourceFileName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ReplaceSourceFileName_Src_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ReplaceSourceFileName_Target_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorTextureLibrary:ExportTexture2DAsHDR")]
	public unsafe static bool ExportTexture2DAsHDR(UObject WorldContextObject, UTexture2D Texture, string FilePath, string FileName)
	{
		if (!ExportTexture2DAsHDR_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorTextureLibrary:ExportTexture2DAsHDR");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExportTexture2DAsHDR_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExportTexture2DAsHDR_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ExportTexture2DAsHDR_WorldContextObject_Offset), 0, ExportTexture2DAsHDR_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(intPtr, ExportTexture2DAsHDR_Texture_Offset), 0, ExportTexture2DAsHDR_Texture_PropertyAddress.Address, Texture);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ExportTexture2DAsHDR_FilePath_Offset), 0, ExportTexture2DAsHDR_FilePath_PropertyAddress.Address, FilePath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ExportTexture2DAsHDR_FileName_Offset), 0, ExportTexture2DAsHDR_FileName_PropertyAddress.Address, FileName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ExportTexture2DAsHDR_FunctionAddress, intPtr, ExportTexture2DAsHDR_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ExportTexture2DAsHDR_FilePath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ExportTexture2DAsHDR_FileName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ExportTexture2DAsHDR_ReturnValue_Offset), 0, ExportTexture2DAsHDR_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorTextureLibrary:ExportTexture2D")]
	public unsafe static bool ExportTexture2D(UTexture2D Texture, string FilePath, string FileName)
	{
		if (!ExportTexture2D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorTextureLibrary:ExportTexture2D");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExportTexture2D_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExportTexture2D_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(intPtr, ExportTexture2D_Texture_Offset), 0, ExportTexture2D_Texture_PropertyAddress.Address, Texture);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ExportTexture2D_FilePath_Offset), 0, ExportTexture2D_FilePath_PropertyAddress.Address, FilePath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ExportTexture2D_FileName_Offset), 0, ExportTexture2D_FileName_PropertyAddress.Address, FileName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ExportTexture2D_FunctionAddress, intPtr, ExportTexture2D_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ExportTexture2D_FilePath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ExportTexture2D_FileName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ExportTexture2D_ReturnValue_Offset), 0, ExportTexture2D_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorTextureLibrary:CreateTexture2DFromFColor")]
	public unsafe static UTexture2D CreateTexture2DFromFColor(int SrcWidth, int SrcHeight, bool WithAlpha, List<FColor> ColorData, string AssetName, string PackageName, EPixelFormat InFormat = EPixelFormat.PF_B8G8R8A8)
	{
		if (!CreateTexture2DFromFColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorTextureLibrary:CreateTexture2DFromFColor");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateTexture2DFromFColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateTexture2DFromFColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CreateTexture2DFromFColor_SrcWidth_Offset), 0, CreateTexture2DFromFColor_SrcWidth_PropertyAddress.Address, SrcWidth);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CreateTexture2DFromFColor_SrcHeight_Offset), 0, CreateTexture2DFromFColor_SrcHeight_PropertyAddress.Address, SrcHeight);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateTexture2DFromFColor_WithAlpha_Offset), 0, CreateTexture2DFromFColor_WithAlpha_PropertyAddress.Address, WithAlpha);
		new TArrayCopyMarshaler<FColor>(1, CreateTexture2DFromFColor_ColorData_PropertyAddress, CachedMarshalingDelegates<FColor, BlittableTypeMarshaler<FColor>>.FromNative, CachedMarshalingDelegates<FColor, BlittableTypeMarshaler<FColor>>.ToNative).ToNative(IntPtr.Add(intPtr, CreateTexture2DFromFColor_ColorData_Offset), ColorData);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateTexture2DFromFColor_AssetName_Offset), 0, CreateTexture2DFromFColor_AssetName_PropertyAddress.Address, AssetName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateTexture2DFromFColor_PackageName_Offset), 0, CreateTexture2DFromFColor_PackageName_PropertyAddress.Address, PackageName);
		EnumMarshaler<EPixelFormat>.ToNative(IntPtr.Add(intPtr, CreateTexture2DFromFColor_InFormat_Offset), 0, CreateTexture2DFromFColor_InFormat_PropertyAddress.Address, InFormat);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateTexture2DFromFColor_FunctionAddress, intPtr, CreateTexture2DFromFColor_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateTexture2DFromFColor_ColorData_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CreateTexture2DFromFColor_AssetName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CreateTexture2DFromFColor_PackageName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(intPtr, CreateTexture2DFromFColor_ReturnValue_Offset), 0, CreateTexture2DFromFColor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorTextureLibrary:CreateTexture2D")]
	public unsafe static UTexture2D CreateTexture2D(int SrcWidth, int SrcHeight, string Name, string PackageName, EPixelFormat InFormat = EPixelFormat.PF_B8G8R8A8)
	{
		if (!CreateTexture2D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorTextureLibrary:CreateTexture2D");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateTexture2D_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateTexture2D_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CreateTexture2D_SrcWidth_Offset), 0, CreateTexture2D_SrcWidth_PropertyAddress.Address, SrcWidth);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CreateTexture2D_SrcHeight_Offset), 0, CreateTexture2D_SrcHeight_PropertyAddress.Address, SrcHeight);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateTexture2D_Name_Offset), 0, CreateTexture2D_Name_PropertyAddress.Address, Name);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateTexture2D_PackageName_Offset), 0, CreateTexture2D_PackageName_PropertyAddress.Address, PackageName);
		EnumMarshaler<EPixelFormat>.ToNative(IntPtr.Add(intPtr, CreateTexture2D_InFormat_Offset), 0, CreateTexture2D_InFormat_PropertyAddress.Address, InFormat);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateTexture2D_FunctionAddress, intPtr, CreateTexture2D_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateTexture2D_Name_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CreateTexture2D_PackageName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(intPtr, CreateTexture2D_ReturnValue_Offset), 0, CreateTexture2D_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorTextureLibrary:CopyTextureSettings")]
	public unsafe static void CopyTextureSettings(UTexture SrcTexture, UTexture DestTexture)
	{
		if (!CopyTextureSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorTextureLibrary:CopyTextureSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyTextureSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyTextureSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(intPtr, CopyTextureSettings_SrcTexture_Offset), 0, CopyTextureSettings_SrcTexture_PropertyAddress.Address, SrcTexture);
		UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(intPtr, CopyTextureSettings_DestTexture_Offset), 0, CopyTextureSettings_DestTexture_PropertyAddress.Address, DestTexture);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CopyTextureSettings_FunctionAddress, intPtr, CopyTextureSettings_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorTextureLibrary:CollectTexDimensions")]
	public unsafe static bool CollectTexDimensions()
	{
		if (!CollectTexDimensions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorTextureLibrary:CollectTexDimensions");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CollectTexDimensions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CollectTexDimensions_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CollectTexDimensions_FunctionAddress, intPtr, CollectTexDimensions_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CollectTexDimensions_ReturnValue_Offset), 0, CollectTexDimensions_ReturnValue_PropertyAddress.Address);
	}

	static UGSEditorTextureLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSEditorTextureLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSEditorTextureLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/FuncLibEditor.GSEditorTextureLibrary");
		StopCollectingTexDimensions_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StopCollectingTexDimensions");
		StopCollectingTexDimensions_ParamsSize = NativeReflection.GetFunctionParamsSize(StopCollectingTexDimensions_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StopCollectingTexDimensions_ReturnValue_PropertyAddress, StopCollectingTexDimensions_FunctionAddress, "ReturnValue");
		StopCollectingTexDimensions_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(StopCollectingTexDimensions_FunctionAddress, "ReturnValue");
		StopCollectingTexDimensions_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(StopCollectingTexDimensions_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		StopCollectingTexDimensions_IsValid = StopCollectingTexDimensions_FunctionAddress != IntPtr.Zero && StopCollectingTexDimensions_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorTextureLibrary:StopCollectingTexDimensions", StopCollectingTexDimensions_IsValid);
		StartCollectingTexDimensions_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StartCollectingTexDimensions");
		StartCollectingTexDimensions_ParamsSize = NativeReflection.GetFunctionParamsSize(StartCollectingTexDimensions_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StartCollectingTexDimensions_ReturnValue_PropertyAddress, StartCollectingTexDimensions_FunctionAddress, "ReturnValue");
		StartCollectingTexDimensions_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(StartCollectingTexDimensions_FunctionAddress, "ReturnValue");
		StartCollectingTexDimensions_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(StartCollectingTexDimensions_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		StartCollectingTexDimensions_IsValid = StartCollectingTexDimensions_FunctionAddress != IntPtr.Zero && StartCollectingTexDimensions_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorTextureLibrary:StartCollectingTexDimensions", StartCollectingTexDimensions_IsValid);
		SetLevelViewportCameraInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetLevelViewportCameraInfo");
		SetLevelViewportCameraInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLevelViewportCameraInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLevelViewportCameraInfo_CameraLocation_PropertyAddress, SetLevelViewportCameraInfo_FunctionAddress, "CameraLocation");
		SetLevelViewportCameraInfo_CameraLocation_Offset = NativeReflectionCached.GetPropertyOffset(SetLevelViewportCameraInfo_FunctionAddress, "CameraLocation");
		SetLevelViewportCameraInfo_CameraLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLevelViewportCameraInfo_FunctionAddress, "CameraLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLevelViewportCameraInfo_CameraRotation_PropertyAddress, SetLevelViewportCameraInfo_FunctionAddress, "CameraRotation");
		SetLevelViewportCameraInfo_CameraRotation_Offset = NativeReflectionCached.GetPropertyOffset(SetLevelViewportCameraInfo_FunctionAddress, "CameraRotation");
		SetLevelViewportCameraInfo_CameraRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLevelViewportCameraInfo_FunctionAddress, "CameraRotation", Classes.FStructProperty);
		SetLevelViewportCameraInfo_IsValid = SetLevelViewportCameraInfo_FunctionAddress != IntPtr.Zero && SetLevelViewportCameraInfo_CameraLocation_IsValid && SetLevelViewportCameraInfo_CameraRotation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorTextureLibrary:SetLevelViewportCameraInfo", SetLevelViewportCameraInfo_IsValid);
		SampleTexture2DLinearColor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SampleTexture2DLinearColor");
		SampleTexture2DLinearColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SampleTexture2DLinearColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SampleTexture2DLinearColor_InTexture_PropertyAddress, SampleTexture2DLinearColor_FunctionAddress, "InTexture");
		SampleTexture2DLinearColor_InTexture_Offset = NativeReflectionCached.GetPropertyOffset(SampleTexture2DLinearColor_FunctionAddress, "InTexture");
		SampleTexture2DLinearColor_InTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(SampleTexture2DLinearColor_FunctionAddress, "InTexture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SampleTexture2DLinearColor_X_PropertyAddress, SampleTexture2DLinearColor_FunctionAddress, "X");
		SampleTexture2DLinearColor_X_Offset = NativeReflectionCached.GetPropertyOffset(SampleTexture2DLinearColor_FunctionAddress, "X");
		SampleTexture2DLinearColor_X_IsValid = NativeReflectionCached.ValidatePropertyClass(SampleTexture2DLinearColor_FunctionAddress, "X", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SampleTexture2DLinearColor_Y_PropertyAddress, SampleTexture2DLinearColor_FunctionAddress, "Y");
		SampleTexture2DLinearColor_Y_Offset = NativeReflectionCached.GetPropertyOffset(SampleTexture2DLinearColor_FunctionAddress, "Y");
		SampleTexture2DLinearColor_Y_IsValid = NativeReflectionCached.ValidatePropertyClass(SampleTexture2DLinearColor_FunctionAddress, "Y", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SampleTexture2DLinearColor_ReturnValue_PropertyAddress, SampleTexture2DLinearColor_FunctionAddress, "ReturnValue");
		SampleTexture2DLinearColor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SampleTexture2DLinearColor_FunctionAddress, "ReturnValue");
		SampleTexture2DLinearColor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SampleTexture2DLinearColor_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		SampleTexture2DLinearColor_IsValid = SampleTexture2DLinearColor_FunctionAddress != IntPtr.Zero && SampleTexture2DLinearColor_InTexture_IsValid && SampleTexture2DLinearColor_X_IsValid && SampleTexture2DLinearColor_Y_IsValid && SampleTexture2DLinearColor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorTextureLibrary:SampleTexture2DLinearColor", SampleTexture2DLinearColor_IsValid);
		SampleTexture2DColor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SampleTexture2DColor");
		SampleTexture2DColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SampleTexture2DColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SampleTexture2DColor_InTexture_PropertyAddress, SampleTexture2DColor_FunctionAddress, "InTexture");
		SampleTexture2DColor_InTexture_Offset = NativeReflectionCached.GetPropertyOffset(SampleTexture2DColor_FunctionAddress, "InTexture");
		SampleTexture2DColor_InTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(SampleTexture2DColor_FunctionAddress, "InTexture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SampleTexture2DColor_X_PropertyAddress, SampleTexture2DColor_FunctionAddress, "X");
		SampleTexture2DColor_X_Offset = NativeReflectionCached.GetPropertyOffset(SampleTexture2DColor_FunctionAddress, "X");
		SampleTexture2DColor_X_IsValid = NativeReflectionCached.ValidatePropertyClass(SampleTexture2DColor_FunctionAddress, "X", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SampleTexture2DColor_Y_PropertyAddress, SampleTexture2DColor_FunctionAddress, "Y");
		SampleTexture2DColor_Y_Offset = NativeReflectionCached.GetPropertyOffset(SampleTexture2DColor_FunctionAddress, "Y");
		SampleTexture2DColor_Y_IsValid = NativeReflectionCached.ValidatePropertyClass(SampleTexture2DColor_FunctionAddress, "Y", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SampleTexture2DColor_ReturnValue_PropertyAddress, SampleTexture2DColor_FunctionAddress, "ReturnValue");
		SampleTexture2DColor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SampleTexture2DColor_FunctionAddress, "ReturnValue");
		SampleTexture2DColor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SampleTexture2DColor_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		SampleTexture2DColor_IsValid = SampleTexture2DColor_FunctionAddress != IntPtr.Zero && SampleTexture2DColor_InTexture_IsValid && SampleTexture2DColor_X_IsValid && SampleTexture2DColor_Y_IsValid && SampleTexture2DColor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorTextureLibrary:SampleTexture2DColor", SampleTexture2DColor_IsValid);
		ReplaceSourceFileName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReplaceSourceFileName");
		ReplaceSourceFileName_ParamsSize = NativeReflection.GetFunctionParamsSize(ReplaceSourceFileName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReplaceSourceFileName_Texture_PropertyAddress, ReplaceSourceFileName_FunctionAddress, "Texture");
		ReplaceSourceFileName_Texture_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceSourceFileName_FunctionAddress, "Texture");
		ReplaceSourceFileName_Texture_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceSourceFileName_FunctionAddress, "Texture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceSourceFileName_Src_PropertyAddress, ReplaceSourceFileName_FunctionAddress, "Src");
		ReplaceSourceFileName_Src_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceSourceFileName_FunctionAddress, "Src");
		ReplaceSourceFileName_Src_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceSourceFileName_FunctionAddress, "Src", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceSourceFileName_Target_PropertyAddress, ReplaceSourceFileName_FunctionAddress, "Target");
		ReplaceSourceFileName_Target_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceSourceFileName_FunctionAddress, "Target");
		ReplaceSourceFileName_Target_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceSourceFileName_FunctionAddress, "Target", Classes.FStrProperty);
		ReplaceSourceFileName_IsValid = ReplaceSourceFileName_FunctionAddress != IntPtr.Zero && ReplaceSourceFileName_Texture_IsValid && ReplaceSourceFileName_Src_IsValid && ReplaceSourceFileName_Target_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorTextureLibrary:ReplaceSourceFileName", ReplaceSourceFileName_IsValid);
		ExportTexture2DAsHDR_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ExportTexture2DAsHDR");
		ExportTexture2DAsHDR_ParamsSize = NativeReflection.GetFunctionParamsSize(ExportTexture2DAsHDR_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExportTexture2DAsHDR_WorldContextObject_PropertyAddress, ExportTexture2DAsHDR_FunctionAddress, "WorldContextObject");
		ExportTexture2DAsHDR_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(ExportTexture2DAsHDR_FunctionAddress, "WorldContextObject");
		ExportTexture2DAsHDR_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportTexture2DAsHDR_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportTexture2DAsHDR_Texture_PropertyAddress, ExportTexture2DAsHDR_FunctionAddress, "Texture");
		ExportTexture2DAsHDR_Texture_Offset = NativeReflectionCached.GetPropertyOffset(ExportTexture2DAsHDR_FunctionAddress, "Texture");
		ExportTexture2DAsHDR_Texture_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportTexture2DAsHDR_FunctionAddress, "Texture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportTexture2DAsHDR_FilePath_PropertyAddress, ExportTexture2DAsHDR_FunctionAddress, "FilePath");
		ExportTexture2DAsHDR_FilePath_Offset = NativeReflectionCached.GetPropertyOffset(ExportTexture2DAsHDR_FunctionAddress, "FilePath");
		ExportTexture2DAsHDR_FilePath_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportTexture2DAsHDR_FunctionAddress, "FilePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportTexture2DAsHDR_FileName_PropertyAddress, ExportTexture2DAsHDR_FunctionAddress, "FileName");
		ExportTexture2DAsHDR_FileName_Offset = NativeReflectionCached.GetPropertyOffset(ExportTexture2DAsHDR_FunctionAddress, "FileName");
		ExportTexture2DAsHDR_FileName_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportTexture2DAsHDR_FunctionAddress, "FileName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportTexture2DAsHDR_ReturnValue_PropertyAddress, ExportTexture2DAsHDR_FunctionAddress, "ReturnValue");
		ExportTexture2DAsHDR_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ExportTexture2DAsHDR_FunctionAddress, "ReturnValue");
		ExportTexture2DAsHDR_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportTexture2DAsHDR_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ExportTexture2DAsHDR_IsValid = ExportTexture2DAsHDR_FunctionAddress != IntPtr.Zero && ExportTexture2DAsHDR_WorldContextObject_IsValid && ExportTexture2DAsHDR_Texture_IsValid && ExportTexture2DAsHDR_FilePath_IsValid && ExportTexture2DAsHDR_FileName_IsValid && ExportTexture2DAsHDR_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorTextureLibrary:ExportTexture2DAsHDR", ExportTexture2DAsHDR_IsValid);
		ExportTexture2D_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ExportTexture2D");
		ExportTexture2D_ParamsSize = NativeReflection.GetFunctionParamsSize(ExportTexture2D_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExportTexture2D_Texture_PropertyAddress, ExportTexture2D_FunctionAddress, "Texture");
		ExportTexture2D_Texture_Offset = NativeReflectionCached.GetPropertyOffset(ExportTexture2D_FunctionAddress, "Texture");
		ExportTexture2D_Texture_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportTexture2D_FunctionAddress, "Texture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportTexture2D_FilePath_PropertyAddress, ExportTexture2D_FunctionAddress, "FilePath");
		ExportTexture2D_FilePath_Offset = NativeReflectionCached.GetPropertyOffset(ExportTexture2D_FunctionAddress, "FilePath");
		ExportTexture2D_FilePath_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportTexture2D_FunctionAddress, "FilePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportTexture2D_FileName_PropertyAddress, ExportTexture2D_FunctionAddress, "FileName");
		ExportTexture2D_FileName_Offset = NativeReflectionCached.GetPropertyOffset(ExportTexture2D_FunctionAddress, "FileName");
		ExportTexture2D_FileName_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportTexture2D_FunctionAddress, "FileName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportTexture2D_ReturnValue_PropertyAddress, ExportTexture2D_FunctionAddress, "ReturnValue");
		ExportTexture2D_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ExportTexture2D_FunctionAddress, "ReturnValue");
		ExportTexture2D_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportTexture2D_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ExportTexture2D_IsValid = ExportTexture2D_FunctionAddress != IntPtr.Zero && ExportTexture2D_Texture_IsValid && ExportTexture2D_FilePath_IsValid && ExportTexture2D_FileName_IsValid && ExportTexture2D_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorTextureLibrary:ExportTexture2D", ExportTexture2D_IsValid);
		CreateTexture2DFromFColor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateTexture2DFromFColor");
		CreateTexture2DFromFColor_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateTexture2DFromFColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateTexture2DFromFColor_SrcWidth_PropertyAddress, CreateTexture2DFromFColor_FunctionAddress, "SrcWidth");
		CreateTexture2DFromFColor_SrcWidth_Offset = NativeReflectionCached.GetPropertyOffset(CreateTexture2DFromFColor_FunctionAddress, "SrcWidth");
		CreateTexture2DFromFColor_SrcWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTexture2DFromFColor_FunctionAddress, "SrcWidth", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateTexture2DFromFColor_SrcHeight_PropertyAddress, CreateTexture2DFromFColor_FunctionAddress, "SrcHeight");
		CreateTexture2DFromFColor_SrcHeight_Offset = NativeReflectionCached.GetPropertyOffset(CreateTexture2DFromFColor_FunctionAddress, "SrcHeight");
		CreateTexture2DFromFColor_SrcHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTexture2DFromFColor_FunctionAddress, "SrcHeight", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateTexture2DFromFColor_WithAlpha_PropertyAddress, CreateTexture2DFromFColor_FunctionAddress, "WithAlpha");
		CreateTexture2DFromFColor_WithAlpha_Offset = NativeReflectionCached.GetPropertyOffset(CreateTexture2DFromFColor_FunctionAddress, "WithAlpha");
		CreateTexture2DFromFColor_WithAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTexture2DFromFColor_FunctionAddress, "WithAlpha", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateTexture2DFromFColor_ColorData_PropertyAddress, CreateTexture2DFromFColor_FunctionAddress, "ColorData");
		CreateTexture2DFromFColor_ColorData_Offset = NativeReflectionCached.GetPropertyOffset(CreateTexture2DFromFColor_FunctionAddress, "ColorData");
		CreateTexture2DFromFColor_ColorData_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTexture2DFromFColor_FunctionAddress, "ColorData", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateTexture2DFromFColor_AssetName_PropertyAddress, CreateTexture2DFromFColor_FunctionAddress, "AssetName");
		CreateTexture2DFromFColor_AssetName_Offset = NativeReflectionCached.GetPropertyOffset(CreateTexture2DFromFColor_FunctionAddress, "AssetName");
		CreateTexture2DFromFColor_AssetName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTexture2DFromFColor_FunctionAddress, "AssetName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateTexture2DFromFColor_PackageName_PropertyAddress, CreateTexture2DFromFColor_FunctionAddress, "PackageName");
		CreateTexture2DFromFColor_PackageName_Offset = NativeReflectionCached.GetPropertyOffset(CreateTexture2DFromFColor_FunctionAddress, "PackageName");
		CreateTexture2DFromFColor_PackageName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTexture2DFromFColor_FunctionAddress, "PackageName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateTexture2DFromFColor_InFormat_PropertyAddress, CreateTexture2DFromFColor_FunctionAddress, "InFormat");
		CreateTexture2DFromFColor_InFormat_Offset = NativeReflectionCached.GetPropertyOffset(CreateTexture2DFromFColor_FunctionAddress, "InFormat");
		CreateTexture2DFromFColor_InFormat_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTexture2DFromFColor_FunctionAddress, "InFormat", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateTexture2DFromFColor_ReturnValue_PropertyAddress, CreateTexture2DFromFColor_FunctionAddress, "ReturnValue");
		CreateTexture2DFromFColor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateTexture2DFromFColor_FunctionAddress, "ReturnValue");
		CreateTexture2DFromFColor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTexture2DFromFColor_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateTexture2DFromFColor_IsValid = CreateTexture2DFromFColor_FunctionAddress != IntPtr.Zero && CreateTexture2DFromFColor_SrcWidth_IsValid && CreateTexture2DFromFColor_SrcHeight_IsValid && CreateTexture2DFromFColor_WithAlpha_IsValid && CreateTexture2DFromFColor_ColorData_IsValid && CreateTexture2DFromFColor_AssetName_IsValid && CreateTexture2DFromFColor_PackageName_IsValid && CreateTexture2DFromFColor_InFormat_IsValid && CreateTexture2DFromFColor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorTextureLibrary:CreateTexture2DFromFColor", CreateTexture2DFromFColor_IsValid);
		CreateTexture2D_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateTexture2D");
		CreateTexture2D_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateTexture2D_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateTexture2D_SrcWidth_PropertyAddress, CreateTexture2D_FunctionAddress, "SrcWidth");
		CreateTexture2D_SrcWidth_Offset = NativeReflectionCached.GetPropertyOffset(CreateTexture2D_FunctionAddress, "SrcWidth");
		CreateTexture2D_SrcWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTexture2D_FunctionAddress, "SrcWidth", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateTexture2D_SrcHeight_PropertyAddress, CreateTexture2D_FunctionAddress, "SrcHeight");
		CreateTexture2D_SrcHeight_Offset = NativeReflectionCached.GetPropertyOffset(CreateTexture2D_FunctionAddress, "SrcHeight");
		CreateTexture2D_SrcHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTexture2D_FunctionAddress, "SrcHeight", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateTexture2D_Name_PropertyAddress, CreateTexture2D_FunctionAddress, "Name");
		CreateTexture2D_Name_Offset = NativeReflectionCached.GetPropertyOffset(CreateTexture2D_FunctionAddress, "Name");
		CreateTexture2D_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTexture2D_FunctionAddress, "Name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateTexture2D_PackageName_PropertyAddress, CreateTexture2D_FunctionAddress, "PackageName");
		CreateTexture2D_PackageName_Offset = NativeReflectionCached.GetPropertyOffset(CreateTexture2D_FunctionAddress, "PackageName");
		CreateTexture2D_PackageName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTexture2D_FunctionAddress, "PackageName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateTexture2D_InFormat_PropertyAddress, CreateTexture2D_FunctionAddress, "InFormat");
		CreateTexture2D_InFormat_Offset = NativeReflectionCached.GetPropertyOffset(CreateTexture2D_FunctionAddress, "InFormat");
		CreateTexture2D_InFormat_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTexture2D_FunctionAddress, "InFormat", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateTexture2D_ReturnValue_PropertyAddress, CreateTexture2D_FunctionAddress, "ReturnValue");
		CreateTexture2D_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateTexture2D_FunctionAddress, "ReturnValue");
		CreateTexture2D_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTexture2D_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateTexture2D_IsValid = CreateTexture2D_FunctionAddress != IntPtr.Zero && CreateTexture2D_SrcWidth_IsValid && CreateTexture2D_SrcHeight_IsValid && CreateTexture2D_Name_IsValid && CreateTexture2D_PackageName_IsValid && CreateTexture2D_InFormat_IsValid && CreateTexture2D_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorTextureLibrary:CreateTexture2D", CreateTexture2D_IsValid);
		CopyTextureSettings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CopyTextureSettings");
		CopyTextureSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyTextureSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyTextureSettings_SrcTexture_PropertyAddress, CopyTextureSettings_FunctionAddress, "SrcTexture");
		CopyTextureSettings_SrcTexture_Offset = NativeReflectionCached.GetPropertyOffset(CopyTextureSettings_FunctionAddress, "SrcTexture");
		CopyTextureSettings_SrcTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyTextureSettings_FunctionAddress, "SrcTexture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyTextureSettings_DestTexture_PropertyAddress, CopyTextureSettings_FunctionAddress, "DestTexture");
		CopyTextureSettings_DestTexture_Offset = NativeReflectionCached.GetPropertyOffset(CopyTextureSettings_FunctionAddress, "DestTexture");
		CopyTextureSettings_DestTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyTextureSettings_FunctionAddress, "DestTexture", Classes.FObjectProperty);
		CopyTextureSettings_IsValid = CopyTextureSettings_FunctionAddress != IntPtr.Zero && CopyTextureSettings_SrcTexture_IsValid && CopyTextureSettings_DestTexture_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorTextureLibrary:CopyTextureSettings", CopyTextureSettings_IsValid);
		CollectTexDimensions_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CollectTexDimensions");
		CollectTexDimensions_ParamsSize = NativeReflection.GetFunctionParamsSize(CollectTexDimensions_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CollectTexDimensions_ReturnValue_PropertyAddress, CollectTexDimensions_FunctionAddress, "ReturnValue");
		CollectTexDimensions_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CollectTexDimensions_FunctionAddress, "ReturnValue");
		CollectTexDimensions_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CollectTexDimensions_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CollectTexDimensions_IsValid = CollectTexDimensions_FunctionAddress != IntPtr.Zero && CollectTexDimensions_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorTextureLibrary:CollectTexDimensions", CollectTexDimensions_IsValid);
	}
}
