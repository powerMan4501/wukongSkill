using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_TextureFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_TextureFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool WriteToTexture_RenderingThread_IsValid;

	private static IntPtr WriteToTexture_RenderingThread_FunctionAddress;

	private static int WriteToTexture_RenderingThread_ParamsSize;

	private static bool WriteToTexture_RenderingThread_TargetTexture_IsValid;

	private static FFieldAddress WriteToTexture_RenderingThread_TargetTexture_PropertyAddress;

	private static int WriteToTexture_RenderingThread_TargetTexture_Offset;

	private static bool WriteToTexture_RenderingThread_ColorBuffer_IsValid;

	private static FFieldAddress WriteToTexture_RenderingThread_ColorBuffer_PropertyAddress;

	private static int WriteToTexture_RenderingThread_ColorBuffer_Offset;

	private static bool WriteToTexture_RenderingThread_Count_IsValid;

	private static FFieldAddress WriteToTexture_RenderingThread_Count_PropertyAddress;

	private static int WriteToTexture_RenderingThread_Count_Offset;

	private static bool WriteToTexture_RenderingThread_MipMapIndex_IsValid;

	private static FFieldAddress WriteToTexture_RenderingThread_MipMapIndex_PropertyAddress;

	private static int WriteToTexture_RenderingThread_MipMapIndex_Offset;

	private static bool WriteToTexture_GameThread_IsValid;

	private static IntPtr WriteToTexture_GameThread_FunctionAddress;

	private static int WriteToTexture_GameThread_ParamsSize;

	private static bool WriteToTexture_GameThread_TargetTexture_IsValid;

	private static FFieldAddress WriteToTexture_GameThread_TargetTexture_PropertyAddress;

	private static int WriteToTexture_GameThread_TargetTexture_Offset;

	private static bool WriteToTexture_GameThread_ColorBuffer_IsValid;

	private static FFieldAddress WriteToTexture_GameThread_ColorBuffer_PropertyAddress;

	private static int WriteToTexture_GameThread_ColorBuffer_Offset;

	private static bool WriteToTexture_GameThread_Count_IsValid;

	private static FFieldAddress WriteToTexture_GameThread_Count_PropertyAddress;

	private static int WriteToTexture_GameThread_Count_Offset;

	private static bool WriteToTexture_GameThread_MipMapIndex_IsValid;

	private static FFieldAddress WriteToTexture_GameThread_MipMapIndex_PropertyAddress;

	private static int WriteToTexture_GameThread_MipMapIndex_Offset;

	private static bool WriteToTexture_GameThread_ReturnValue_IsValid;

	private static FFieldAddress WriteToTexture_GameThread_ReturnValue_PropertyAddress;

	private static int WriteToTexture_GameThread_ReturnValue_Offset;

	private static bool StartCapturingStreamingTextureStats_IsValid;

	private static IntPtr StartCapturingStreamingTextureStats_FunctionAddress;

	private static int StartCapturingStreamingTextureStats_ParamsSize;

	private static bool SaveTexture2DAs16F_IsValid;

	private static IntPtr SaveTexture2DAs16F_FunctionAddress;

	private static int SaveTexture2DAs16F_ParamsSize;

	private static bool SaveTexture2DAs16F_PackageName_IsValid;

	private static FFieldAddress SaveTexture2DAs16F_PackageName_PropertyAddress;

	private static int SaveTexture2DAs16F_PackageName_Offset;

	private static bool SaveTexture2DAs16F_TextureName_IsValid;

	private static FFieldAddress SaveTexture2DAs16F_TextureName_PropertyAddress;

	private static int SaveTexture2DAs16F_TextureName_Offset;

	private static bool SaveTexture2DAs16F_TextureWidth_IsValid;

	private static FFieldAddress SaveTexture2DAs16F_TextureWidth_PropertyAddress;

	private static int SaveTexture2DAs16F_TextureWidth_Offset;

	private static bool SaveTexture2DAs16F_TextureHeight_IsValid;

	private static FFieldAddress SaveTexture2DAs16F_TextureHeight_PropertyAddress;

	private static int SaveTexture2DAs16F_TextureHeight_Offset;

	private static bool SaveTexture2DAs16F_Data_IsValid;

	private static FFieldAddress SaveTexture2DAs16F_Data_PropertyAddress;

	private static int SaveTexture2DAs16F_Data_Offset;

	private static bool SaveTexture2D_IsValid;

	private static IntPtr SaveTexture2D_FunctionAddress;

	private static int SaveTexture2D_ParamsSize;

	private static bool SaveTexture2D_PackageName_IsValid;

	private static FFieldAddress SaveTexture2D_PackageName_PropertyAddress;

	private static int SaveTexture2D_PackageName_Offset;

	private static bool SaveTexture2D_TextureName_IsValid;

	private static FFieldAddress SaveTexture2D_TextureName_PropertyAddress;

	private static int SaveTexture2D_TextureName_Offset;

	private static bool SaveTexture2D_TextureWidth_IsValid;

	private static FFieldAddress SaveTexture2D_TextureWidth_PropertyAddress;

	private static int SaveTexture2D_TextureWidth_Offset;

	private static bool SaveTexture2D_TextureHeight_IsValid;

	private static FFieldAddress SaveTexture2D_TextureHeight_PropertyAddress;

	private static int SaveTexture2D_TextureHeight_Offset;

	private static bool SaveTexture2D_Data_IsValid;

	private static FFieldAddress SaveTexture2D_Data_PropertyAddress;

	private static int SaveTexture2D_Data_Offset;

	private static bool ReleaseRenderTarget_IsValid;

	private static IntPtr ReleaseRenderTarget_FunctionAddress;

	private static int ReleaseRenderTarget_ParamsSize;

	private static bool ReleaseRenderTarget_TextureRenderTarget_IsValid;

	private static FFieldAddress ReleaseRenderTarget_TextureRenderTarget_PropertyAddress;

	private static int ReleaseRenderTarget_TextureRenderTarget_Offset;

	private static bool OutputNonPowerOfTwoUdimVTInfo_IsValid;

	private static IntPtr OutputNonPowerOfTwoUdimVTInfo_FunctionAddress;

	private static int OutputNonPowerOfTwoUdimVTInfo_ParamsSize;

	private static bool IsPowerOfTwo_IsValid;

	private static IntPtr IsPowerOfTwo_FunctionAddress;

	private static int IsPowerOfTwo_ParamsSize;

	private static bool IsPowerOfTwo_TargetTexture_IsValid;

	private static FFieldAddress IsPowerOfTwo_TargetTexture_PropertyAddress;

	private static int IsPowerOfTwo_TargetTexture_Offset;

	private static bool IsPowerOfTwo_ReturnValue_IsValid;

	private static FFieldAddress IsPowerOfTwo_ReturnValue_PropertyAddress;

	private static int IsPowerOfTwo_ReturnValue_Offset;

	private static bool GetObjThumbnail_IsValid;

	private static IntPtr GetObjThumbnail_FunctionAddress;

	private static int GetObjThumbnail_ParamsSize;

	private static bool GetObjThumbnail_InObject_IsValid;

	private static FFieldAddress GetObjThumbnail_InObject_PropertyAddress;

	private static int GetObjThumbnail_InObject_Offset;

	private static bool GetObjThumbnail_ReturnValue_IsValid;

	private static FFieldAddress GetObjThumbnail_ReturnValue_PropertyAddress;

	private static int GetObjThumbnail_ReturnValue_Offset;

	private static bool ExportTexture2D_IsValid;

	private static IntPtr ExportTexture2D_FunctionAddress;

	private static int ExportTexture2D_ParamsSize;

	private static bool ExportTexture2D_WorldContextObject_IsValid;

	private static FFieldAddress ExportTexture2D_WorldContextObject_PropertyAddress;

	private static int ExportTexture2D_WorldContextObject_Offset;

	private static bool ExportTexture2D_Texture_IsValid;

	private static FFieldAddress ExportTexture2D_Texture_PropertyAddress;

	private static int ExportTexture2D_Texture_Offset;

	private static bool ExportTexture2D_FilePath_IsValid;

	private static FFieldAddress ExportTexture2D_FilePath_PropertyAddress;

	private static int ExportTexture2D_FilePath_Offset;

	private static bool ExportTexture2D_FileName_IsValid;

	private static FFieldAddress ExportTexture2D_FileName_PropertyAddress;

	private static int ExportTexture2D_FileName_Offset;

	private static bool ExportColorDataAsPNG_IsValid;

	private static IntPtr ExportColorDataAsPNG_FunctionAddress;

	private static int ExportColorDataAsPNG_ParamsSize;

	private static bool ExportColorDataAsPNG_SrcWidth_IsValid;

	private static FFieldAddress ExportColorDataAsPNG_SrcWidth_PropertyAddress;

	private static int ExportColorDataAsPNG_SrcWidth_Offset;

	private static bool ExportColorDataAsPNG_SrcHeight_IsValid;

	private static FFieldAddress ExportColorDataAsPNG_SrcHeight_PropertyAddress;

	private static int ExportColorDataAsPNG_SrcHeight_Offset;

	private static bool ExportColorDataAsPNG_Filepath_IsValid;

	private static FFieldAddress ExportColorDataAsPNG_Filepath_PropertyAddress;

	private static int ExportColorDataAsPNG_Filepath_Offset;

	private static bool ExportColorDataAsPNG_ColorBuffer_IsValid;

	private static FFieldAddress ExportColorDataAsPNG_ColorBuffer_PropertyAddress;

	private static int ExportColorDataAsPNG_ColorBuffer_Offset;

	private static bool ExportColorDataAsPNG_Count_IsValid;

	private static FFieldAddress ExportColorDataAsPNG_Count_PropertyAddress;

	private static int ExportColorDataAsPNG_Count_Offset;

	private static bool EndCapturingStreamingTextureStats_IsValid;

	private static IntPtr EndCapturingStreamingTextureStats_FunctionAddress;

	private static int EndCapturingStreamingTextureStats_ParamsSize;

	private static bool DumpStreamingTextureStats_IsValid;

	private static IntPtr DumpStreamingTextureStats_FunctionAddress;

	private static int DumpStreamingTextureStats_ParamsSize;

	private static bool CreateTexture2DFromColorData_IsValid;

	private static IntPtr CreateTexture2DFromColorData_FunctionAddress;

	private static int CreateTexture2DFromColorData_ParamsSize;

	private static bool CreateTexture2DFromColorData_SrcWidth_IsValid;

	private static FFieldAddress CreateTexture2DFromColorData_SrcWidth_PropertyAddress;

	private static int CreateTexture2DFromColorData_SrcWidth_Offset;

	private static bool CreateTexture2DFromColorData_SrcHeight_IsValid;

	private static FFieldAddress CreateTexture2DFromColorData_SrcHeight_PropertyAddress;

	private static int CreateTexture2DFromColorData_SrcHeight_Offset;

	private static bool CreateTexture2DFromColorData_ColorData_IsValid;

	private static FFieldAddress CreateTexture2DFromColorData_ColorData_PropertyAddress;

	private static int CreateTexture2DFromColorData_ColorData_Offset;

	private static bool CreateTexture2DFromColorData_Name_IsValid;

	private static FFieldAddress CreateTexture2DFromColorData_Name_PropertyAddress;

	private static int CreateTexture2DFromColorData_Name_Offset;

	private static bool CreateTexture2DFromColorData_ReturnValue_IsValid;

	private static FFieldAddress CreateTexture2DFromColorData_ReturnValue_PropertyAddress;

	private static int CreateTexture2DFromColorData_ReturnValue_Offset;

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

	private static bool CreateTexture2D_InFormat_IsValid;

	private static FFieldAddress CreateTexture2D_InFormat_PropertyAddress;

	private static int CreateTexture2D_InFormat_Offset;

	private static bool CreateTexture2D_ReturnValue_IsValid;

	private static FFieldAddress CreateTexture2D_ReturnValue_PropertyAddress;

	private static int CreateTexture2D_ReturnValue_Offset;

	private static bool CreateStaticTexture2D_IsValid;

	private static IntPtr CreateStaticTexture2D_FunctionAddress;

	private static int CreateStaticTexture2D_ParamsSize;

	private static bool CreateStaticTexture2D_SourceRT_IsValid;

	private static FFieldAddress CreateStaticTexture2D_SourceRT_PropertyAddress;

	private static int CreateStaticTexture2D_SourceRT_Offset;

	private static bool CreateStaticTexture2D_OutputPath_IsValid;

	private static FFieldAddress CreateStaticTexture2D_OutputPath_PropertyAddress;

	private static int CreateStaticTexture2D_OutputPath_Offset;

	private static bool CreateStaticTexture2D_OutputFileName_IsValid;

	private static FFieldAddress CreateStaticTexture2D_OutputFileName_PropertyAddress;

	private static int CreateStaticTexture2D_OutputFileName_Offset;

	private static bool CreateRenderTarget2D_IsValid;

	private static IntPtr CreateRenderTarget2D_FunctionAddress;

	private static int CreateRenderTarget2D_ParamsSize;

	private static bool CreateRenderTarget2D_WorldContextObject_IsValid;

	private static FFieldAddress CreateRenderTarget2D_WorldContextObject_PropertyAddress;

	private static int CreateRenderTarget2D_WorldContextObject_Offset;

	private static bool CreateRenderTarget2D_Width_IsValid;

	private static FFieldAddress CreateRenderTarget2D_Width_PropertyAddress;

	private static int CreateRenderTarget2D_Width_Offset;

	private static bool CreateRenderTarget2D_Height_IsValid;

	private static FFieldAddress CreateRenderTarget2D_Height_PropertyAddress;

	private static int CreateRenderTarget2D_Height_Offset;

	private static bool CreateRenderTarget2D_ClearColor_IsValid;

	private static FFieldAddress CreateRenderTarget2D_ClearColor_PropertyAddress;

	private static int CreateRenderTarget2D_ClearColor_Offset;

	private static bool CreateRenderTarget2D_ReturnValue_IsValid;

	private static FFieldAddress CreateRenderTarget2D_ReturnValue_PropertyAddress;

	private static int CreateRenderTarget2D_ReturnValue_Offset;

	private static bool CollectNonPowerOfTwoUdimVT_IsValid;

	private static IntPtr CollectNonPowerOfTwoUdimVT_FunctionAddress;

	private static int CollectNonPowerOfTwoUdimVT_ParamsSize;

	private static bool ChangeImageMaterial_IsValid;

	private static IntPtr ChangeImageMaterial_FunctionAddress;

	private static int ChangeImageMaterial_ParamsSize;

	private static bool ChangeImageMaterial_WorldContextObject_IsValid;

	private static FFieldAddress ChangeImageMaterial_WorldContextObject_PropertyAddress;

	private static int ChangeImageMaterial_WorldContextObject_Offset;

	private static bool ChangeImageMaterial_Image_IsValid;

	private static FFieldAddress ChangeImageMaterial_Image_PropertyAddress;

	private static int ChangeImageMaterial_Image_Offset;

	private static bool ChangeImageMaterial_MatPath_IsValid;

	private static FFieldAddress ChangeImageMaterial_MatPath_PropertyAddress;

	private static int ChangeImageMaterial_MatPath_Offset;

	private static bool ChangeImageMaterial_ReturnValue_IsValid;

	private static FFieldAddress ChangeImageMaterial_ReturnValue_PropertyAddress;

	private static int ChangeImageMaterial_ReturnValue_Offset;

	private static bool CaptureStreamingTextureStats_IsValid;

	private static IntPtr CaptureStreamingTextureStats_FunctionAddress;

	private static int CaptureStreamingTextureStats_ParamsSize;

	private static bool CalculateAverageColorInTiles_IsValid;

	private static IntPtr CalculateAverageColorInTiles_FunctionAddress;

	private static int CalculateAverageColorInTiles_ParamsSize;

	private static bool CalculateAverageColorInTiles_InTexture_IsValid;

	private static FFieldAddress CalculateAverageColorInTiles_InTexture_PropertyAddress;

	private static int CalculateAverageColorInTiles_InTexture_Offset;

	private static bool CalculateAverageColorInTiles_TileCount_IsValid;

	private static FFieldAddress CalculateAverageColorInTiles_TileCount_PropertyAddress;

	private static int CalculateAverageColorInTiles_TileCount_Offset;

	private static bool CalculateAverageColorInTiles_bDebugLog_IsValid;

	private static FFieldAddress CalculateAverageColorInTiles_bDebugLog_PropertyAddress;

	private static int CalculateAverageColorInTiles_bDebugLog_Offset;

	private static bool CalculateAverageColorInTiles_ReturnValue_IsValid;

	private static FFieldAddress CalculateAverageColorInTiles_ReturnValue_PropertyAddress;

	private static int CalculateAverageColorInTiles_ReturnValue_Offset;

	private static bool BuildStreamedLowMips_IsValid;

	private static IntPtr BuildStreamedLowMips_FunctionAddress;

	private static int BuildStreamedLowMips_ParamsSize;

	private static bool BuildStreamedLowMips_RVTComponent_IsValid;

	private static FFieldAddress BuildStreamedLowMips_RVTComponent_PropertyAddress;

	private static int BuildStreamedLowMips_RVTComponent_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_TextureFuncLib:WriteToTexture_RenderingThread")]
	public unsafe static void WriteToTexture_RenderingThread(UTexture2D TargetTexture, FColorBufferPtr ColorBuffer, int Count, int MipMapIndex = 0)
	{
		if (!WriteToTexture_RenderingThread_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_TextureFuncLib:WriteToTexture_RenderingThread");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(WriteToTexture_RenderingThread_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WriteToTexture_RenderingThread_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(intPtr, WriteToTexture_RenderingThread_TargetTexture_Offset), 0, WriteToTexture_RenderingThread_TargetTexture_PropertyAddress.Address, TargetTexture);
		BlittableTypeMarshaler<FColorBufferPtr>.ToNative(IntPtr.Add(intPtr, WriteToTexture_RenderingThread_ColorBuffer_Offset), 0, WriteToTexture_RenderingThread_ColorBuffer_PropertyAddress.Address, ColorBuffer);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, WriteToTexture_RenderingThread_Count_Offset), 0, WriteToTexture_RenderingThread_Count_PropertyAddress.Address, Count);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, WriteToTexture_RenderingThread_MipMapIndex_Offset), 0, WriteToTexture_RenderingThread_MipMapIndex_PropertyAddress.Address, MipMapIndex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, WriteToTexture_RenderingThread_FunctionAddress, intPtr, WriteToTexture_RenderingThread_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_TextureFuncLib:WriteToTexture_GameThread")]
	public unsafe static bool WriteToTexture_GameThread(UTexture2D TargetTexture, FColorBufferPtr ColorBuffer, int Count, int MipMapIndex = 0)
	{
		if (!WriteToTexture_GameThread_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_TextureFuncLib:WriteToTexture_GameThread");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(WriteToTexture_GameThread_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WriteToTexture_GameThread_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(intPtr, WriteToTexture_GameThread_TargetTexture_Offset), 0, WriteToTexture_GameThread_TargetTexture_PropertyAddress.Address, TargetTexture);
		BlittableTypeMarshaler<FColorBufferPtr>.ToNative(IntPtr.Add(intPtr, WriteToTexture_GameThread_ColorBuffer_Offset), 0, WriteToTexture_GameThread_ColorBuffer_PropertyAddress.Address, ColorBuffer);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, WriteToTexture_GameThread_Count_Offset), 0, WriteToTexture_GameThread_Count_PropertyAddress.Address, Count);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, WriteToTexture_GameThread_MipMapIndex_Offset), 0, WriteToTexture_GameThread_MipMapIndex_PropertyAddress.Address, MipMapIndex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, WriteToTexture_GameThread_FunctionAddress, intPtr, WriteToTexture_GameThread_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, WriteToTexture_GameThread_ReturnValue_Offset), 0, WriteToTexture_GameThread_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_TextureFuncLib:StartCapturingStreamingTextureStats")]
	public unsafe static void StartCapturingStreamingTextureStats()
	{
		if (!StartCapturingStreamingTextureStats_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_TextureFuncLib:StartCapturingStreamingTextureStats");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartCapturingStreamingTextureStats_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartCapturingStreamingTextureStats_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: StartCapturingStreamingTextureStats_FunctionAddress, argsSize: StartCapturingStreamingTextureStats_ParamsSize);
	}

	[UFunction(Flags = 608314369u)]
	[UMetaPath("/Script/UnrealExtent.GSE_TextureFuncLib:SaveTexture2DAs16F")]
	public unsafe static void SaveTexture2DAs16F(string PackageName, string TextureName, int TextureWidth, int TextureHeight, List<float> Data)
	{
		if (!SaveTexture2DAs16F_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_TextureFuncLib:SaveTexture2DAs16F");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SaveTexture2DAs16F_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SaveTexture2DAs16F_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SaveTexture2DAs16F_PackageName_Offset), 0, SaveTexture2DAs16F_PackageName_PropertyAddress.Address, PackageName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SaveTexture2DAs16F_TextureName_Offset), 0, SaveTexture2DAs16F_TextureName_PropertyAddress.Address, TextureName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SaveTexture2DAs16F_TextureWidth_Offset), 0, SaveTexture2DAs16F_TextureWidth_PropertyAddress.Address, TextureWidth);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SaveTexture2DAs16F_TextureHeight_Offset), 0, SaveTexture2DAs16F_TextureHeight_PropertyAddress.Address, TextureHeight);
		new TArrayCopyMarshaler<float>(1, SaveTexture2DAs16F_Data_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(intPtr, SaveTexture2DAs16F_Data_Offset), Data);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SaveTexture2DAs16F_FunctionAddress, intPtr, SaveTexture2DAs16F_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SaveTexture2DAs16F_PackageName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SaveTexture2DAs16F_TextureName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SaveTexture2DAs16F_Data_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 608314369u)]
	[UMetaPath("/Script/UnrealExtent.GSE_TextureFuncLib:SaveTexture2D")]
	public unsafe static void SaveTexture2D(string PackageName, string TextureName, int TextureWidth, int TextureHeight, List<float> Data)
	{
		if (!SaveTexture2D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_TextureFuncLib:SaveTexture2D");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SaveTexture2D_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SaveTexture2D_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SaveTexture2D_PackageName_Offset), 0, SaveTexture2D_PackageName_PropertyAddress.Address, PackageName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SaveTexture2D_TextureName_Offset), 0, SaveTexture2D_TextureName_PropertyAddress.Address, TextureName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SaveTexture2D_TextureWidth_Offset), 0, SaveTexture2D_TextureWidth_PropertyAddress.Address, TextureWidth);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SaveTexture2D_TextureHeight_Offset), 0, SaveTexture2D_TextureHeight_PropertyAddress.Address, TextureHeight);
		new TArrayCopyMarshaler<float>(1, SaveTexture2D_Data_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(intPtr, SaveTexture2D_Data_Offset), Data);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SaveTexture2D_FunctionAddress, intPtr, SaveTexture2D_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SaveTexture2D_PackageName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SaveTexture2D_TextureName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SaveTexture2D_Data_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_TextureFuncLib:ReleaseRenderTarget")]
	public unsafe static void ReleaseRenderTarget(UTextureRenderTarget2D TextureRenderTarget)
	{
		if (!ReleaseRenderTarget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_TextureFuncLib:ReleaseRenderTarget");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReleaseRenderTarget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReleaseRenderTarget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(intPtr, ReleaseRenderTarget_TextureRenderTarget_Offset), 0, ReleaseRenderTarget_TextureRenderTarget_PropertyAddress.Address, TextureRenderTarget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ReleaseRenderTarget_FunctionAddress, intPtr, ReleaseRenderTarget_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_TextureFuncLib:OutputNonPowerOfTwoUdimVTInfo")]
	public unsafe static void OutputNonPowerOfTwoUdimVTInfo()
	{
		if (!OutputNonPowerOfTwoUdimVTInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_TextureFuncLib:OutputNonPowerOfTwoUdimVTInfo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OutputNonPowerOfTwoUdimVTInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OutputNonPowerOfTwoUdimVTInfo_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: OutputNonPowerOfTwoUdimVTInfo_FunctionAddress, argsSize: OutputNonPowerOfTwoUdimVTInfo_ParamsSize);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_TextureFuncLib:IsPowerOfTwo")]
	public unsafe static bool IsPowerOfTwo(UTexture TargetTexture)
	{
		if (!IsPowerOfTwo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_TextureFuncLib:IsPowerOfTwo");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPowerOfTwo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPowerOfTwo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(intPtr, IsPowerOfTwo_TargetTexture_Offset), 0, IsPowerOfTwo_TargetTexture_PropertyAddress.Address, TargetTexture);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsPowerOfTwo_FunctionAddress, intPtr, IsPowerOfTwo_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPowerOfTwo_ReturnValue_Offset), 0, IsPowerOfTwo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_TextureFuncLib:GetObjThumbnail")]
	public unsafe static UTexture2D GetObjThumbnail(UObject InObject)
	{
		if (!GetObjThumbnail_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_TextureFuncLib:GetObjThumbnail");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetObjThumbnail_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetObjThumbnail_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetObjThumbnail_InObject_Offset), 0, GetObjThumbnail_InObject_PropertyAddress.Address, InObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetObjThumbnail_FunctionAddress, intPtr, GetObjThumbnail_ParamsSize);
		return UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(intPtr, GetObjThumbnail_ReturnValue_Offset), 0, GetObjThumbnail_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_TextureFuncLib:ExportTexture2D")]
	public unsafe static void ExportTexture2D(UObject WorldContextObject, UTexture2D Texture, string FilePath, string FileName)
	{
		if (!ExportTexture2D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_TextureFuncLib:ExportTexture2D");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExportTexture2D_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExportTexture2D_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ExportTexture2D_WorldContextObject_Offset), 0, ExportTexture2D_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(intPtr, ExportTexture2D_Texture_Offset), 0, ExportTexture2D_Texture_PropertyAddress.Address, Texture);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ExportTexture2D_FilePath_Offset), 0, ExportTexture2D_FilePath_PropertyAddress.Address, FilePath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ExportTexture2D_FileName_Offset), 0, ExportTexture2D_FileName_PropertyAddress.Address, FileName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ExportTexture2D_FunctionAddress, intPtr, ExportTexture2D_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ExportTexture2D_FilePath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ExportTexture2D_FileName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_TextureFuncLib:ExportColorDataAsPNG")]
	public unsafe static void ExportColorDataAsPNG(int SrcWidth, int SrcHeight, string Filepath, FColorBufferPtr ColorBuffer, int Count)
	{
		if (!ExportColorDataAsPNG_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_TextureFuncLib:ExportColorDataAsPNG");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExportColorDataAsPNG_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExportColorDataAsPNG_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ExportColorDataAsPNG_SrcWidth_Offset), 0, ExportColorDataAsPNG_SrcWidth_PropertyAddress.Address, SrcWidth);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ExportColorDataAsPNG_SrcHeight_Offset), 0, ExportColorDataAsPNG_SrcHeight_PropertyAddress.Address, SrcHeight);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ExportColorDataAsPNG_Filepath_Offset), 0, ExportColorDataAsPNG_Filepath_PropertyAddress.Address, Filepath);
		BlittableTypeMarshaler<FColorBufferPtr>.ToNative(IntPtr.Add(intPtr, ExportColorDataAsPNG_ColorBuffer_Offset), 0, ExportColorDataAsPNG_ColorBuffer_PropertyAddress.Address, ColorBuffer);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ExportColorDataAsPNG_Count_Offset), 0, ExportColorDataAsPNG_Count_PropertyAddress.Address, Count);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ExportColorDataAsPNG_FunctionAddress, intPtr, ExportColorDataAsPNG_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ExportColorDataAsPNG_Filepath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_TextureFuncLib:EndCapturingStreamingTextureStats")]
	public unsafe static void EndCapturingStreamingTextureStats()
	{
		if (!EndCapturingStreamingTextureStats_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_TextureFuncLib:EndCapturingStreamingTextureStats");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EndCapturingStreamingTextureStats_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EndCapturingStreamingTextureStats_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: EndCapturingStreamingTextureStats_FunctionAddress, argsSize: EndCapturingStreamingTextureStats_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_TextureFuncLib:DumpStreamingTextureStats")]
	public unsafe static void DumpStreamingTextureStats()
	{
		if (!DumpStreamingTextureStats_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_TextureFuncLib:DumpStreamingTextureStats");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DumpStreamingTextureStats_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DumpStreamingTextureStats_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: DumpStreamingTextureStats_FunctionAddress, argsSize: DumpStreamingTextureStats_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_TextureFuncLib:CreateTexture2DFromColorData")]
	public unsafe static UTexture2D CreateTexture2DFromColorData(int SrcWidth, int SrcHeight, List<FColor> ColorData, string Name)
	{
		if (!CreateTexture2DFromColorData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_TextureFuncLib:CreateTexture2DFromColorData");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateTexture2DFromColorData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateTexture2DFromColorData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CreateTexture2DFromColorData_SrcWidth_Offset), 0, CreateTexture2DFromColorData_SrcWidth_PropertyAddress.Address, SrcWidth);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CreateTexture2DFromColorData_SrcHeight_Offset), 0, CreateTexture2DFromColorData_SrcHeight_PropertyAddress.Address, SrcHeight);
		new TArrayCopyMarshaler<FColor>(1, CreateTexture2DFromColorData_ColorData_PropertyAddress, CachedMarshalingDelegates<FColor, BlittableTypeMarshaler<FColor>>.FromNative, CachedMarshalingDelegates<FColor, BlittableTypeMarshaler<FColor>>.ToNative).ToNative(IntPtr.Add(intPtr, CreateTexture2DFromColorData_ColorData_Offset), ColorData);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateTexture2DFromColorData_Name_Offset), 0, CreateTexture2DFromColorData_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateTexture2DFromColorData_FunctionAddress, intPtr, CreateTexture2DFromColorData_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateTexture2DFromColorData_ColorData_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CreateTexture2DFromColorData_Name_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(intPtr, CreateTexture2DFromColorData_ReturnValue_Offset), 0, CreateTexture2DFromColorData_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_TextureFuncLib:CreateTexture2D")]
	public unsafe static UTexture2D CreateTexture2D(int SrcWidth, int SrcHeight, string Name, EPixelFormat InFormat = EPixelFormat.PF_B8G8R8A8)
	{
		if (!CreateTexture2D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_TextureFuncLib:CreateTexture2D");
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
		EnumMarshaler<EPixelFormat>.ToNative(IntPtr.Add(intPtr, CreateTexture2D_InFormat_Offset), 0, CreateTexture2D_InFormat_PropertyAddress.Address, InFormat);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateTexture2D_FunctionAddress, intPtr, CreateTexture2D_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateTexture2D_Name_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(intPtr, CreateTexture2D_ReturnValue_Offset), 0, CreateTexture2D_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_TextureFuncLib:CreateStaticTexture2D")]
	public unsafe static void CreateStaticTexture2D(UTextureRenderTarget2D SourceRT, string OutputPath, string OutputFileName)
	{
		if (!CreateStaticTexture2D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_TextureFuncLib:CreateStaticTexture2D");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateStaticTexture2D_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateStaticTexture2D_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(intPtr, CreateStaticTexture2D_SourceRT_Offset), 0, CreateStaticTexture2D_SourceRT_PropertyAddress.Address, SourceRT);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateStaticTexture2D_OutputPath_Offset), 0, CreateStaticTexture2D_OutputPath_PropertyAddress.Address, OutputPath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateStaticTexture2D_OutputFileName_Offset), 0, CreateStaticTexture2D_OutputFileName_PropertyAddress.Address, OutputFileName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateStaticTexture2D_FunctionAddress, intPtr, CreateStaticTexture2D_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateStaticTexture2D_OutputPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CreateStaticTexture2D_OutputFileName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_TextureFuncLib:CreateRenderTarget2D")]
	public unsafe static UTextureRenderTarget2D CreateRenderTarget2D(UObject WorldContextObject, int Width, int Height, FLinearColor ClearColor)
	{
		if (!CreateRenderTarget2D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_TextureFuncLib:CreateRenderTarget2D");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateRenderTarget2D_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateRenderTarget2D_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CreateRenderTarget2D_WorldContextObject_Offset), 0, CreateRenderTarget2D_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CreateRenderTarget2D_Width_Offset), 0, CreateRenderTarget2D_Width_PropertyAddress.Address, Width);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CreateRenderTarget2D_Height_Offset), 0, CreateRenderTarget2D_Height_PropertyAddress.Address, Height);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, CreateRenderTarget2D_ClearColor_Offset), 0, CreateRenderTarget2D_ClearColor_PropertyAddress.Address, ClearColor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateRenderTarget2D_FunctionAddress, intPtr, CreateRenderTarget2D_ParamsSize);
		return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(intPtr, CreateRenderTarget2D_ReturnValue_Offset), 0, CreateRenderTarget2D_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_TextureFuncLib:CollectNonPowerOfTwoUdimVT")]
	public unsafe static void CollectNonPowerOfTwoUdimVT()
	{
		if (!CollectNonPowerOfTwoUdimVT_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_TextureFuncLib:CollectNonPowerOfTwoUdimVT");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CollectNonPowerOfTwoUdimVT_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CollectNonPowerOfTwoUdimVT_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: CollectNonPowerOfTwoUdimVT_FunctionAddress, argsSize: CollectNonPowerOfTwoUdimVT_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_TextureFuncLib:ChangeImageMaterial")]
	public unsafe static UMaterialInstanceDynamic ChangeImageMaterial(UObject WorldContextObject, UImage Image, string MatPath)
	{
		if (!ChangeImageMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_TextureFuncLib:ChangeImageMaterial");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ChangeImageMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ChangeImageMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ChangeImageMaterial_WorldContextObject_Offset), 0, ChangeImageMaterial_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<UImage>.ToNative(IntPtr.Add(intPtr, ChangeImageMaterial_Image_Offset), 0, ChangeImageMaterial_Image_PropertyAddress.Address, Image);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ChangeImageMaterial_MatPath_Offset), 0, ChangeImageMaterial_MatPath_PropertyAddress.Address, MatPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ChangeImageMaterial_FunctionAddress, intPtr, ChangeImageMaterial_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ChangeImageMaterial_MatPath_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(intPtr, ChangeImageMaterial_ReturnValue_Offset), 0, ChangeImageMaterial_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_TextureFuncLib:CaptureStreamingTextureStats")]
	public unsafe static void CaptureStreamingTextureStats()
	{
		if (!CaptureStreamingTextureStats_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_TextureFuncLib:CaptureStreamingTextureStats");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CaptureStreamingTextureStats_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CaptureStreamingTextureStats_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: CaptureStreamingTextureStats_FunctionAddress, argsSize: CaptureStreamingTextureStats_ParamsSize);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_TextureFuncLib:CalculateAverageColorInTiles")]
	public unsafe static List<float> CalculateAverageColorInTiles(UTexture2D InTexture, FIntPoint TileCount, bool bDebugLog = false)
	{
		if (!CalculateAverageColorInTiles_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_TextureFuncLib:CalculateAverageColorInTiles");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CalculateAverageColorInTiles_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CalculateAverageColorInTiles_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(intPtr, CalculateAverageColorInTiles_InTexture_Offset), 0, CalculateAverageColorInTiles_InTexture_PropertyAddress.Address, InTexture);
		BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(intPtr, CalculateAverageColorInTiles_TileCount_Offset), 0, CalculateAverageColorInTiles_TileCount_PropertyAddress.Address, TileCount);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CalculateAverageColorInTiles_bDebugLog_Offset), 0, CalculateAverageColorInTiles_bDebugLog_PropertyAddress.Address, bDebugLog);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CalculateAverageColorInTiles_FunctionAddress, intPtr, CalculateAverageColorInTiles_ParamsSize);
		List<float> result = new TArrayCopyMarshaler<float>(1, CalculateAverageColorInTiles_ReturnValue_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(intPtr, CalculateAverageColorInTiles_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(CalculateAverageColorInTiles_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_TextureFuncLib:BuildStreamedLowMips")]
	public unsafe static void BuildStreamedLowMips(URuntimeVirtualTextureComponent RVTComponent)
	{
		if (!BuildStreamedLowMips_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_TextureFuncLib:BuildStreamedLowMips");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BuildStreamedLowMips_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BuildStreamedLowMips_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<URuntimeVirtualTextureComponent>.ToNative(IntPtr.Add(intPtr, BuildStreamedLowMips_RVTComponent_Offset), 0, BuildStreamedLowMips_RVTComponent_PropertyAddress.Address, RVTComponent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BuildStreamedLowMips_FunctionAddress, intPtr, BuildStreamedLowMips_ParamsSize);
	}

	static UGSE_TextureFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_TextureFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_TextureFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_TextureFuncLib");
		WriteToTexture_RenderingThread_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "WriteToTexture_RenderingThread");
		WriteToTexture_RenderingThread_ParamsSize = NativeReflection.GetFunctionParamsSize(WriteToTexture_RenderingThread_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref WriteToTexture_RenderingThread_TargetTexture_PropertyAddress, WriteToTexture_RenderingThread_FunctionAddress, "TargetTexture");
		WriteToTexture_RenderingThread_TargetTexture_Offset = NativeReflectionCached.GetPropertyOffset(WriteToTexture_RenderingThread_FunctionAddress, "TargetTexture");
		WriteToTexture_RenderingThread_TargetTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteToTexture_RenderingThread_FunctionAddress, "TargetTexture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref WriteToTexture_RenderingThread_ColorBuffer_PropertyAddress, WriteToTexture_RenderingThread_FunctionAddress, "ColorBuffer");
		WriteToTexture_RenderingThread_ColorBuffer_Offset = NativeReflectionCached.GetPropertyOffset(WriteToTexture_RenderingThread_FunctionAddress, "ColorBuffer");
		WriteToTexture_RenderingThread_ColorBuffer_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteToTexture_RenderingThread_FunctionAddress, "ColorBuffer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref WriteToTexture_RenderingThread_Count_PropertyAddress, WriteToTexture_RenderingThread_FunctionAddress, "Count");
		WriteToTexture_RenderingThread_Count_Offset = NativeReflectionCached.GetPropertyOffset(WriteToTexture_RenderingThread_FunctionAddress, "Count");
		WriteToTexture_RenderingThread_Count_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteToTexture_RenderingThread_FunctionAddress, "Count", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref WriteToTexture_RenderingThread_MipMapIndex_PropertyAddress, WriteToTexture_RenderingThread_FunctionAddress, "MipMapIndex");
		WriteToTexture_RenderingThread_MipMapIndex_Offset = NativeReflectionCached.GetPropertyOffset(WriteToTexture_RenderingThread_FunctionAddress, "MipMapIndex");
		WriteToTexture_RenderingThread_MipMapIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteToTexture_RenderingThread_FunctionAddress, "MipMapIndex", Classes.FIntProperty);
		WriteToTexture_RenderingThread_IsValid = WriteToTexture_RenderingThread_FunctionAddress != IntPtr.Zero && WriteToTexture_RenderingThread_TargetTexture_IsValid && WriteToTexture_RenderingThread_ColorBuffer_IsValid && WriteToTexture_RenderingThread_Count_IsValid && WriteToTexture_RenderingThread_MipMapIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_TextureFuncLib:WriteToTexture_RenderingThread", WriteToTexture_RenderingThread_IsValid);
		WriteToTexture_GameThread_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "WriteToTexture_GameThread");
		WriteToTexture_GameThread_ParamsSize = NativeReflection.GetFunctionParamsSize(WriteToTexture_GameThread_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref WriteToTexture_GameThread_TargetTexture_PropertyAddress, WriteToTexture_GameThread_FunctionAddress, "TargetTexture");
		WriteToTexture_GameThread_TargetTexture_Offset = NativeReflectionCached.GetPropertyOffset(WriteToTexture_GameThread_FunctionAddress, "TargetTexture");
		WriteToTexture_GameThread_TargetTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteToTexture_GameThread_FunctionAddress, "TargetTexture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref WriteToTexture_GameThread_ColorBuffer_PropertyAddress, WriteToTexture_GameThread_FunctionAddress, "ColorBuffer");
		WriteToTexture_GameThread_ColorBuffer_Offset = NativeReflectionCached.GetPropertyOffset(WriteToTexture_GameThread_FunctionAddress, "ColorBuffer");
		WriteToTexture_GameThread_ColorBuffer_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteToTexture_GameThread_FunctionAddress, "ColorBuffer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref WriteToTexture_GameThread_Count_PropertyAddress, WriteToTexture_GameThread_FunctionAddress, "Count");
		WriteToTexture_GameThread_Count_Offset = NativeReflectionCached.GetPropertyOffset(WriteToTexture_GameThread_FunctionAddress, "Count");
		WriteToTexture_GameThread_Count_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteToTexture_GameThread_FunctionAddress, "Count", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref WriteToTexture_GameThread_MipMapIndex_PropertyAddress, WriteToTexture_GameThread_FunctionAddress, "MipMapIndex");
		WriteToTexture_GameThread_MipMapIndex_Offset = NativeReflectionCached.GetPropertyOffset(WriteToTexture_GameThread_FunctionAddress, "MipMapIndex");
		WriteToTexture_GameThread_MipMapIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteToTexture_GameThread_FunctionAddress, "MipMapIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref WriteToTexture_GameThread_ReturnValue_PropertyAddress, WriteToTexture_GameThread_FunctionAddress, "ReturnValue");
		WriteToTexture_GameThread_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(WriteToTexture_GameThread_FunctionAddress, "ReturnValue");
		WriteToTexture_GameThread_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteToTexture_GameThread_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		WriteToTexture_GameThread_IsValid = WriteToTexture_GameThread_FunctionAddress != IntPtr.Zero && WriteToTexture_GameThread_TargetTexture_IsValid && WriteToTexture_GameThread_ColorBuffer_IsValid && WriteToTexture_GameThread_Count_IsValid && WriteToTexture_GameThread_MipMapIndex_IsValid && WriteToTexture_GameThread_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_TextureFuncLib:WriteToTexture_GameThread", WriteToTexture_GameThread_IsValid);
		StartCapturingStreamingTextureStats_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StartCapturingStreamingTextureStats");
		StartCapturingStreamingTextureStats_ParamsSize = NativeReflection.GetFunctionParamsSize(StartCapturingStreamingTextureStats_FunctionAddress);
		StartCapturingStreamingTextureStats_IsValid = StartCapturingStreamingTextureStats_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_TextureFuncLib:StartCapturingStreamingTextureStats", StartCapturingStreamingTextureStats_IsValid);
		SaveTexture2DAs16F_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SaveTexture2DAs16F");
		SaveTexture2DAs16F_ParamsSize = NativeReflection.GetFunctionParamsSize(SaveTexture2DAs16F_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SaveTexture2DAs16F_PackageName_PropertyAddress, SaveTexture2DAs16F_FunctionAddress, "PackageName");
		SaveTexture2DAs16F_PackageName_Offset = NativeReflectionCached.GetPropertyOffset(SaveTexture2DAs16F_FunctionAddress, "PackageName");
		SaveTexture2DAs16F_PackageName_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveTexture2DAs16F_FunctionAddress, "PackageName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveTexture2DAs16F_TextureName_PropertyAddress, SaveTexture2DAs16F_FunctionAddress, "TextureName");
		SaveTexture2DAs16F_TextureName_Offset = NativeReflectionCached.GetPropertyOffset(SaveTexture2DAs16F_FunctionAddress, "TextureName");
		SaveTexture2DAs16F_TextureName_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveTexture2DAs16F_FunctionAddress, "TextureName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveTexture2DAs16F_TextureWidth_PropertyAddress, SaveTexture2DAs16F_FunctionAddress, "TextureWidth");
		SaveTexture2DAs16F_TextureWidth_Offset = NativeReflectionCached.GetPropertyOffset(SaveTexture2DAs16F_FunctionAddress, "TextureWidth");
		SaveTexture2DAs16F_TextureWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveTexture2DAs16F_FunctionAddress, "TextureWidth", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveTexture2DAs16F_TextureHeight_PropertyAddress, SaveTexture2DAs16F_FunctionAddress, "TextureHeight");
		SaveTexture2DAs16F_TextureHeight_Offset = NativeReflectionCached.GetPropertyOffset(SaveTexture2DAs16F_FunctionAddress, "TextureHeight");
		SaveTexture2DAs16F_TextureHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveTexture2DAs16F_FunctionAddress, "TextureHeight", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveTexture2DAs16F_Data_PropertyAddress, SaveTexture2DAs16F_FunctionAddress, "Data");
		SaveTexture2DAs16F_Data_Offset = NativeReflectionCached.GetPropertyOffset(SaveTexture2DAs16F_FunctionAddress, "Data");
		SaveTexture2DAs16F_Data_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveTexture2DAs16F_FunctionAddress, "Data", Classes.FArrayProperty);
		SaveTexture2DAs16F_IsValid = SaveTexture2DAs16F_FunctionAddress != IntPtr.Zero && SaveTexture2DAs16F_PackageName_IsValid && SaveTexture2DAs16F_TextureName_IsValid && SaveTexture2DAs16F_TextureWidth_IsValid && SaveTexture2DAs16F_TextureHeight_IsValid && SaveTexture2DAs16F_Data_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_TextureFuncLib:SaveTexture2DAs16F", SaveTexture2DAs16F_IsValid);
		SaveTexture2D_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SaveTexture2D");
		SaveTexture2D_ParamsSize = NativeReflection.GetFunctionParamsSize(SaveTexture2D_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SaveTexture2D_PackageName_PropertyAddress, SaveTexture2D_FunctionAddress, "PackageName");
		SaveTexture2D_PackageName_Offset = NativeReflectionCached.GetPropertyOffset(SaveTexture2D_FunctionAddress, "PackageName");
		SaveTexture2D_PackageName_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveTexture2D_FunctionAddress, "PackageName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveTexture2D_TextureName_PropertyAddress, SaveTexture2D_FunctionAddress, "TextureName");
		SaveTexture2D_TextureName_Offset = NativeReflectionCached.GetPropertyOffset(SaveTexture2D_FunctionAddress, "TextureName");
		SaveTexture2D_TextureName_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveTexture2D_FunctionAddress, "TextureName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveTexture2D_TextureWidth_PropertyAddress, SaveTexture2D_FunctionAddress, "TextureWidth");
		SaveTexture2D_TextureWidth_Offset = NativeReflectionCached.GetPropertyOffset(SaveTexture2D_FunctionAddress, "TextureWidth");
		SaveTexture2D_TextureWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveTexture2D_FunctionAddress, "TextureWidth", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveTexture2D_TextureHeight_PropertyAddress, SaveTexture2D_FunctionAddress, "TextureHeight");
		SaveTexture2D_TextureHeight_Offset = NativeReflectionCached.GetPropertyOffset(SaveTexture2D_FunctionAddress, "TextureHeight");
		SaveTexture2D_TextureHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveTexture2D_FunctionAddress, "TextureHeight", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveTexture2D_Data_PropertyAddress, SaveTexture2D_FunctionAddress, "Data");
		SaveTexture2D_Data_Offset = NativeReflectionCached.GetPropertyOffset(SaveTexture2D_FunctionAddress, "Data");
		SaveTexture2D_Data_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveTexture2D_FunctionAddress, "Data", Classes.FArrayProperty);
		SaveTexture2D_IsValid = SaveTexture2D_FunctionAddress != IntPtr.Zero && SaveTexture2D_PackageName_IsValid && SaveTexture2D_TextureName_IsValid && SaveTexture2D_TextureWidth_IsValid && SaveTexture2D_TextureHeight_IsValid && SaveTexture2D_Data_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_TextureFuncLib:SaveTexture2D", SaveTexture2D_IsValid);
		ReleaseRenderTarget_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReleaseRenderTarget");
		ReleaseRenderTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(ReleaseRenderTarget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReleaseRenderTarget_TextureRenderTarget_PropertyAddress, ReleaseRenderTarget_FunctionAddress, "TextureRenderTarget");
		ReleaseRenderTarget_TextureRenderTarget_Offset = NativeReflectionCached.GetPropertyOffset(ReleaseRenderTarget_FunctionAddress, "TextureRenderTarget");
		ReleaseRenderTarget_TextureRenderTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(ReleaseRenderTarget_FunctionAddress, "TextureRenderTarget", Classes.FObjectProperty);
		ReleaseRenderTarget_IsValid = ReleaseRenderTarget_FunctionAddress != IntPtr.Zero && ReleaseRenderTarget_TextureRenderTarget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_TextureFuncLib:ReleaseRenderTarget", ReleaseRenderTarget_IsValid);
		OutputNonPowerOfTwoUdimVTInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OutputNonPowerOfTwoUdimVTInfo");
		OutputNonPowerOfTwoUdimVTInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(OutputNonPowerOfTwoUdimVTInfo_FunctionAddress);
		OutputNonPowerOfTwoUdimVTInfo_IsValid = OutputNonPowerOfTwoUdimVTInfo_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_TextureFuncLib:OutputNonPowerOfTwoUdimVTInfo", OutputNonPowerOfTwoUdimVTInfo_IsValid);
		IsPowerOfTwo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsPowerOfTwo");
		IsPowerOfTwo_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPowerOfTwo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPowerOfTwo_TargetTexture_PropertyAddress, IsPowerOfTwo_FunctionAddress, "TargetTexture");
		IsPowerOfTwo_TargetTexture_Offset = NativeReflectionCached.GetPropertyOffset(IsPowerOfTwo_FunctionAddress, "TargetTexture");
		IsPowerOfTwo_TargetTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPowerOfTwo_FunctionAddress, "TargetTexture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsPowerOfTwo_ReturnValue_PropertyAddress, IsPowerOfTwo_FunctionAddress, "ReturnValue");
		IsPowerOfTwo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPowerOfTwo_FunctionAddress, "ReturnValue");
		IsPowerOfTwo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPowerOfTwo_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPowerOfTwo_IsValid = IsPowerOfTwo_FunctionAddress != IntPtr.Zero && IsPowerOfTwo_TargetTexture_IsValid && IsPowerOfTwo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_TextureFuncLib:IsPowerOfTwo", IsPowerOfTwo_IsValid);
		GetObjThumbnail_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetObjThumbnail");
		GetObjThumbnail_ParamsSize = NativeReflection.GetFunctionParamsSize(GetObjThumbnail_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetObjThumbnail_InObject_PropertyAddress, GetObjThumbnail_FunctionAddress, "InObject");
		GetObjThumbnail_InObject_Offset = NativeReflectionCached.GetPropertyOffset(GetObjThumbnail_FunctionAddress, "InObject");
		GetObjThumbnail_InObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetObjThumbnail_FunctionAddress, "InObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetObjThumbnail_ReturnValue_PropertyAddress, GetObjThumbnail_FunctionAddress, "ReturnValue");
		GetObjThumbnail_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetObjThumbnail_FunctionAddress, "ReturnValue");
		GetObjThumbnail_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetObjThumbnail_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetObjThumbnail_IsValid = GetObjThumbnail_FunctionAddress != IntPtr.Zero && GetObjThumbnail_InObject_IsValid && GetObjThumbnail_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_TextureFuncLib:GetObjThumbnail", GetObjThumbnail_IsValid);
		ExportTexture2D_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ExportTexture2D");
		ExportTexture2D_ParamsSize = NativeReflection.GetFunctionParamsSize(ExportTexture2D_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExportTexture2D_WorldContextObject_PropertyAddress, ExportTexture2D_FunctionAddress, "WorldContextObject");
		ExportTexture2D_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(ExportTexture2D_FunctionAddress, "WorldContextObject");
		ExportTexture2D_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportTexture2D_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportTexture2D_Texture_PropertyAddress, ExportTexture2D_FunctionAddress, "Texture");
		ExportTexture2D_Texture_Offset = NativeReflectionCached.GetPropertyOffset(ExportTexture2D_FunctionAddress, "Texture");
		ExportTexture2D_Texture_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportTexture2D_FunctionAddress, "Texture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportTexture2D_FilePath_PropertyAddress, ExportTexture2D_FunctionAddress, "FilePath");
		ExportTexture2D_FilePath_Offset = NativeReflectionCached.GetPropertyOffset(ExportTexture2D_FunctionAddress, "FilePath");
		ExportTexture2D_FilePath_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportTexture2D_FunctionAddress, "FilePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportTexture2D_FileName_PropertyAddress, ExportTexture2D_FunctionAddress, "FileName");
		ExportTexture2D_FileName_Offset = NativeReflectionCached.GetPropertyOffset(ExportTexture2D_FunctionAddress, "FileName");
		ExportTexture2D_FileName_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportTexture2D_FunctionAddress, "FileName", Classes.FStrProperty);
		ExportTexture2D_IsValid = ExportTexture2D_FunctionAddress != IntPtr.Zero && ExportTexture2D_WorldContextObject_IsValid && ExportTexture2D_Texture_IsValid && ExportTexture2D_FilePath_IsValid && ExportTexture2D_FileName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_TextureFuncLib:ExportTexture2D", ExportTexture2D_IsValid);
		ExportColorDataAsPNG_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ExportColorDataAsPNG");
		ExportColorDataAsPNG_ParamsSize = NativeReflection.GetFunctionParamsSize(ExportColorDataAsPNG_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExportColorDataAsPNG_SrcWidth_PropertyAddress, ExportColorDataAsPNG_FunctionAddress, "SrcWidth");
		ExportColorDataAsPNG_SrcWidth_Offset = NativeReflectionCached.GetPropertyOffset(ExportColorDataAsPNG_FunctionAddress, "SrcWidth");
		ExportColorDataAsPNG_SrcWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportColorDataAsPNG_FunctionAddress, "SrcWidth", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportColorDataAsPNG_SrcHeight_PropertyAddress, ExportColorDataAsPNG_FunctionAddress, "SrcHeight");
		ExportColorDataAsPNG_SrcHeight_Offset = NativeReflectionCached.GetPropertyOffset(ExportColorDataAsPNG_FunctionAddress, "SrcHeight");
		ExportColorDataAsPNG_SrcHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportColorDataAsPNG_FunctionAddress, "SrcHeight", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportColorDataAsPNG_Filepath_PropertyAddress, ExportColorDataAsPNG_FunctionAddress, "Filepath");
		ExportColorDataAsPNG_Filepath_Offset = NativeReflectionCached.GetPropertyOffset(ExportColorDataAsPNG_FunctionAddress, "Filepath");
		ExportColorDataAsPNG_Filepath_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportColorDataAsPNG_FunctionAddress, "Filepath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportColorDataAsPNG_ColorBuffer_PropertyAddress, ExportColorDataAsPNG_FunctionAddress, "ColorBuffer");
		ExportColorDataAsPNG_ColorBuffer_Offset = NativeReflectionCached.GetPropertyOffset(ExportColorDataAsPNG_FunctionAddress, "ColorBuffer");
		ExportColorDataAsPNG_ColorBuffer_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportColorDataAsPNG_FunctionAddress, "ColorBuffer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportColorDataAsPNG_Count_PropertyAddress, ExportColorDataAsPNG_FunctionAddress, "Count");
		ExportColorDataAsPNG_Count_Offset = NativeReflectionCached.GetPropertyOffset(ExportColorDataAsPNG_FunctionAddress, "Count");
		ExportColorDataAsPNG_Count_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportColorDataAsPNG_FunctionAddress, "Count", Classes.FIntProperty);
		ExportColorDataAsPNG_IsValid = ExportColorDataAsPNG_FunctionAddress != IntPtr.Zero && ExportColorDataAsPNG_SrcWidth_IsValid && ExportColorDataAsPNG_SrcHeight_IsValid && ExportColorDataAsPNG_Filepath_IsValid && ExportColorDataAsPNG_ColorBuffer_IsValid && ExportColorDataAsPNG_Count_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_TextureFuncLib:ExportColorDataAsPNG", ExportColorDataAsPNG_IsValid);
		EndCapturingStreamingTextureStats_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EndCapturingStreamingTextureStats");
		EndCapturingStreamingTextureStats_ParamsSize = NativeReflection.GetFunctionParamsSize(EndCapturingStreamingTextureStats_FunctionAddress);
		EndCapturingStreamingTextureStats_IsValid = EndCapturingStreamingTextureStats_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_TextureFuncLib:EndCapturingStreamingTextureStats", EndCapturingStreamingTextureStats_IsValid);
		DumpStreamingTextureStats_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DumpStreamingTextureStats");
		DumpStreamingTextureStats_ParamsSize = NativeReflection.GetFunctionParamsSize(DumpStreamingTextureStats_FunctionAddress);
		DumpStreamingTextureStats_IsValid = DumpStreamingTextureStats_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_TextureFuncLib:DumpStreamingTextureStats", DumpStreamingTextureStats_IsValid);
		CreateTexture2DFromColorData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateTexture2DFromColorData");
		CreateTexture2DFromColorData_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateTexture2DFromColorData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateTexture2DFromColorData_SrcWidth_PropertyAddress, CreateTexture2DFromColorData_FunctionAddress, "SrcWidth");
		CreateTexture2DFromColorData_SrcWidth_Offset = NativeReflectionCached.GetPropertyOffset(CreateTexture2DFromColorData_FunctionAddress, "SrcWidth");
		CreateTexture2DFromColorData_SrcWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTexture2DFromColorData_FunctionAddress, "SrcWidth", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateTexture2DFromColorData_SrcHeight_PropertyAddress, CreateTexture2DFromColorData_FunctionAddress, "SrcHeight");
		CreateTexture2DFromColorData_SrcHeight_Offset = NativeReflectionCached.GetPropertyOffset(CreateTexture2DFromColorData_FunctionAddress, "SrcHeight");
		CreateTexture2DFromColorData_SrcHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTexture2DFromColorData_FunctionAddress, "SrcHeight", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateTexture2DFromColorData_ColorData_PropertyAddress, CreateTexture2DFromColorData_FunctionAddress, "ColorData");
		CreateTexture2DFromColorData_ColorData_Offset = NativeReflectionCached.GetPropertyOffset(CreateTexture2DFromColorData_FunctionAddress, "ColorData");
		CreateTexture2DFromColorData_ColorData_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTexture2DFromColorData_FunctionAddress, "ColorData", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateTexture2DFromColorData_Name_PropertyAddress, CreateTexture2DFromColorData_FunctionAddress, "Name");
		CreateTexture2DFromColorData_Name_Offset = NativeReflectionCached.GetPropertyOffset(CreateTexture2DFromColorData_FunctionAddress, "Name");
		CreateTexture2DFromColorData_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTexture2DFromColorData_FunctionAddress, "Name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateTexture2DFromColorData_ReturnValue_PropertyAddress, CreateTexture2DFromColorData_FunctionAddress, "ReturnValue");
		CreateTexture2DFromColorData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateTexture2DFromColorData_FunctionAddress, "ReturnValue");
		CreateTexture2DFromColorData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTexture2DFromColorData_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateTexture2DFromColorData_IsValid = CreateTexture2DFromColorData_FunctionAddress != IntPtr.Zero && CreateTexture2DFromColorData_SrcWidth_IsValid && CreateTexture2DFromColorData_SrcHeight_IsValid && CreateTexture2DFromColorData_ColorData_IsValid && CreateTexture2DFromColorData_Name_IsValid && CreateTexture2DFromColorData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_TextureFuncLib:CreateTexture2DFromColorData", CreateTexture2DFromColorData_IsValid);
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
		NativeReflectionCached.GetPropertyRef(ref CreateTexture2D_InFormat_PropertyAddress, CreateTexture2D_FunctionAddress, "InFormat");
		CreateTexture2D_InFormat_Offset = NativeReflectionCached.GetPropertyOffset(CreateTexture2D_FunctionAddress, "InFormat");
		CreateTexture2D_InFormat_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTexture2D_FunctionAddress, "InFormat", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateTexture2D_ReturnValue_PropertyAddress, CreateTexture2D_FunctionAddress, "ReturnValue");
		CreateTexture2D_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateTexture2D_FunctionAddress, "ReturnValue");
		CreateTexture2D_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTexture2D_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateTexture2D_IsValid = CreateTexture2D_FunctionAddress != IntPtr.Zero && CreateTexture2D_SrcWidth_IsValid && CreateTexture2D_SrcHeight_IsValid && CreateTexture2D_Name_IsValid && CreateTexture2D_InFormat_IsValid && CreateTexture2D_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_TextureFuncLib:CreateTexture2D", CreateTexture2D_IsValid);
		CreateStaticTexture2D_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateStaticTexture2D");
		CreateStaticTexture2D_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateStaticTexture2D_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateStaticTexture2D_SourceRT_PropertyAddress, CreateStaticTexture2D_FunctionAddress, "SourceRT");
		CreateStaticTexture2D_SourceRT_Offset = NativeReflectionCached.GetPropertyOffset(CreateStaticTexture2D_FunctionAddress, "SourceRT");
		CreateStaticTexture2D_SourceRT_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateStaticTexture2D_FunctionAddress, "SourceRT", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateStaticTexture2D_OutputPath_PropertyAddress, CreateStaticTexture2D_FunctionAddress, "OutputPath");
		CreateStaticTexture2D_OutputPath_Offset = NativeReflectionCached.GetPropertyOffset(CreateStaticTexture2D_FunctionAddress, "OutputPath");
		CreateStaticTexture2D_OutputPath_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateStaticTexture2D_FunctionAddress, "OutputPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateStaticTexture2D_OutputFileName_PropertyAddress, CreateStaticTexture2D_FunctionAddress, "OutputFileName");
		CreateStaticTexture2D_OutputFileName_Offset = NativeReflectionCached.GetPropertyOffset(CreateStaticTexture2D_FunctionAddress, "OutputFileName");
		CreateStaticTexture2D_OutputFileName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateStaticTexture2D_FunctionAddress, "OutputFileName", Classes.FStrProperty);
		CreateStaticTexture2D_IsValid = CreateStaticTexture2D_FunctionAddress != IntPtr.Zero && CreateStaticTexture2D_SourceRT_IsValid && CreateStaticTexture2D_OutputPath_IsValid && CreateStaticTexture2D_OutputFileName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_TextureFuncLib:CreateStaticTexture2D", CreateStaticTexture2D_IsValid);
		CreateRenderTarget2D_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateRenderTarget2D");
		CreateRenderTarget2D_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateRenderTarget2D_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateRenderTarget2D_WorldContextObject_PropertyAddress, CreateRenderTarget2D_FunctionAddress, "WorldContextObject");
		CreateRenderTarget2D_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(CreateRenderTarget2D_FunctionAddress, "WorldContextObject");
		CreateRenderTarget2D_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateRenderTarget2D_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateRenderTarget2D_Width_PropertyAddress, CreateRenderTarget2D_FunctionAddress, "Width");
		CreateRenderTarget2D_Width_Offset = NativeReflectionCached.GetPropertyOffset(CreateRenderTarget2D_FunctionAddress, "Width");
		CreateRenderTarget2D_Width_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateRenderTarget2D_FunctionAddress, "Width", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateRenderTarget2D_Height_PropertyAddress, CreateRenderTarget2D_FunctionAddress, "Height");
		CreateRenderTarget2D_Height_Offset = NativeReflectionCached.GetPropertyOffset(CreateRenderTarget2D_FunctionAddress, "Height");
		CreateRenderTarget2D_Height_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateRenderTarget2D_FunctionAddress, "Height", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateRenderTarget2D_ClearColor_PropertyAddress, CreateRenderTarget2D_FunctionAddress, "ClearColor");
		CreateRenderTarget2D_ClearColor_Offset = NativeReflectionCached.GetPropertyOffset(CreateRenderTarget2D_FunctionAddress, "ClearColor");
		CreateRenderTarget2D_ClearColor_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateRenderTarget2D_FunctionAddress, "ClearColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateRenderTarget2D_ReturnValue_PropertyAddress, CreateRenderTarget2D_FunctionAddress, "ReturnValue");
		CreateRenderTarget2D_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateRenderTarget2D_FunctionAddress, "ReturnValue");
		CreateRenderTarget2D_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateRenderTarget2D_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateRenderTarget2D_IsValid = CreateRenderTarget2D_FunctionAddress != IntPtr.Zero && CreateRenderTarget2D_WorldContextObject_IsValid && CreateRenderTarget2D_Width_IsValid && CreateRenderTarget2D_Height_IsValid && CreateRenderTarget2D_ClearColor_IsValid && CreateRenderTarget2D_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_TextureFuncLib:CreateRenderTarget2D", CreateRenderTarget2D_IsValid);
		CollectNonPowerOfTwoUdimVT_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CollectNonPowerOfTwoUdimVT");
		CollectNonPowerOfTwoUdimVT_ParamsSize = NativeReflection.GetFunctionParamsSize(CollectNonPowerOfTwoUdimVT_FunctionAddress);
		CollectNonPowerOfTwoUdimVT_IsValid = CollectNonPowerOfTwoUdimVT_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_TextureFuncLib:CollectNonPowerOfTwoUdimVT", CollectNonPowerOfTwoUdimVT_IsValid);
		ChangeImageMaterial_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ChangeImageMaterial");
		ChangeImageMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(ChangeImageMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ChangeImageMaterial_WorldContextObject_PropertyAddress, ChangeImageMaterial_FunctionAddress, "WorldContextObject");
		ChangeImageMaterial_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(ChangeImageMaterial_FunctionAddress, "WorldContextObject");
		ChangeImageMaterial_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ChangeImageMaterial_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ChangeImageMaterial_Image_PropertyAddress, ChangeImageMaterial_FunctionAddress, "Image");
		ChangeImageMaterial_Image_Offset = NativeReflectionCached.GetPropertyOffset(ChangeImageMaterial_FunctionAddress, "Image");
		ChangeImageMaterial_Image_IsValid = NativeReflectionCached.ValidatePropertyClass(ChangeImageMaterial_FunctionAddress, "Image", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ChangeImageMaterial_MatPath_PropertyAddress, ChangeImageMaterial_FunctionAddress, "MatPath");
		ChangeImageMaterial_MatPath_Offset = NativeReflectionCached.GetPropertyOffset(ChangeImageMaterial_FunctionAddress, "MatPath");
		ChangeImageMaterial_MatPath_IsValid = NativeReflectionCached.ValidatePropertyClass(ChangeImageMaterial_FunctionAddress, "MatPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ChangeImageMaterial_ReturnValue_PropertyAddress, ChangeImageMaterial_FunctionAddress, "ReturnValue");
		ChangeImageMaterial_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ChangeImageMaterial_FunctionAddress, "ReturnValue");
		ChangeImageMaterial_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ChangeImageMaterial_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ChangeImageMaterial_IsValid = ChangeImageMaterial_FunctionAddress != IntPtr.Zero && ChangeImageMaterial_WorldContextObject_IsValid && ChangeImageMaterial_Image_IsValid && ChangeImageMaterial_MatPath_IsValid && ChangeImageMaterial_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_TextureFuncLib:ChangeImageMaterial", ChangeImageMaterial_IsValid);
		CaptureStreamingTextureStats_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CaptureStreamingTextureStats");
		CaptureStreamingTextureStats_ParamsSize = NativeReflection.GetFunctionParamsSize(CaptureStreamingTextureStats_FunctionAddress);
		CaptureStreamingTextureStats_IsValid = CaptureStreamingTextureStats_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_TextureFuncLib:CaptureStreamingTextureStats", CaptureStreamingTextureStats_IsValid);
		CalculateAverageColorInTiles_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CalculateAverageColorInTiles");
		CalculateAverageColorInTiles_ParamsSize = NativeReflection.GetFunctionParamsSize(CalculateAverageColorInTiles_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CalculateAverageColorInTiles_InTexture_PropertyAddress, CalculateAverageColorInTiles_FunctionAddress, "InTexture");
		CalculateAverageColorInTiles_InTexture_Offset = NativeReflectionCached.GetPropertyOffset(CalculateAverageColorInTiles_FunctionAddress, "InTexture");
		CalculateAverageColorInTiles_InTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateAverageColorInTiles_FunctionAddress, "InTexture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CalculateAverageColorInTiles_TileCount_PropertyAddress, CalculateAverageColorInTiles_FunctionAddress, "TileCount");
		CalculateAverageColorInTiles_TileCount_Offset = NativeReflectionCached.GetPropertyOffset(CalculateAverageColorInTiles_FunctionAddress, "TileCount");
		CalculateAverageColorInTiles_TileCount_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateAverageColorInTiles_FunctionAddress, "TileCount", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CalculateAverageColorInTiles_bDebugLog_PropertyAddress, CalculateAverageColorInTiles_FunctionAddress, "bDebugLog");
		CalculateAverageColorInTiles_bDebugLog_Offset = NativeReflectionCached.GetPropertyOffset(CalculateAverageColorInTiles_FunctionAddress, "bDebugLog");
		CalculateAverageColorInTiles_bDebugLog_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateAverageColorInTiles_FunctionAddress, "bDebugLog", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CalculateAverageColorInTiles_ReturnValue_PropertyAddress, CalculateAverageColorInTiles_FunctionAddress, "ReturnValue");
		CalculateAverageColorInTiles_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CalculateAverageColorInTiles_FunctionAddress, "ReturnValue");
		CalculateAverageColorInTiles_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateAverageColorInTiles_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		CalculateAverageColorInTiles_IsValid = CalculateAverageColorInTiles_FunctionAddress != IntPtr.Zero && CalculateAverageColorInTiles_InTexture_IsValid && CalculateAverageColorInTiles_TileCount_IsValid && CalculateAverageColorInTiles_bDebugLog_IsValid && CalculateAverageColorInTiles_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_TextureFuncLib:CalculateAverageColorInTiles", CalculateAverageColorInTiles_IsValid);
		BuildStreamedLowMips_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BuildStreamedLowMips");
		BuildStreamedLowMips_ParamsSize = NativeReflection.GetFunctionParamsSize(BuildStreamedLowMips_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BuildStreamedLowMips_RVTComponent_PropertyAddress, BuildStreamedLowMips_FunctionAddress, "RVTComponent");
		BuildStreamedLowMips_RVTComponent_Offset = NativeReflectionCached.GetPropertyOffset(BuildStreamedLowMips_FunctionAddress, "RVTComponent");
		BuildStreamedLowMips_RVTComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildStreamedLowMips_FunctionAddress, "RVTComponent", Classes.FObjectProperty);
		BuildStreamedLowMips_IsValid = BuildStreamedLowMips_FunctionAddress != IntPtr.Zero && BuildStreamedLowMips_RVTComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_TextureFuncLib:BuildStreamedLowMips", BuildStreamedLowMips_IsValid);
	}
}
