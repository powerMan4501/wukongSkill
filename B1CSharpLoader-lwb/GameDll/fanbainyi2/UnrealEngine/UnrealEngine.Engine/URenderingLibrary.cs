using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810025120uL, Config = "Engine")]
[UMetaPath("/Script/Engine.KismetRenderingLibrary", "Engine", UnrealModuleType.Engine)]
public class URenderingLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetCastInsetShadowForAllAttachments_IsValid;

	private static IntPtr SetCastInsetShadowForAllAttachments_FunctionAddress;

	private static int SetCastInsetShadowForAllAttachments_ParamsSize;

	private static bool SetCastInsetShadowForAllAttachments_PrimitiveComponent_IsValid;

	private static FFieldAddress SetCastInsetShadowForAllAttachments_PrimitiveComponent_PropertyAddress;

	private static int SetCastInsetShadowForAllAttachments_PrimitiveComponent_Offset;

	private static bool SetCastInsetShadowForAllAttachments_bCastInsetShadow_IsValid;

	private static FFieldAddress SetCastInsetShadowForAllAttachments_bCastInsetShadow_PropertyAddress;

	private static int SetCastInsetShadowForAllAttachments_bCastInsetShadow_Offset;

	private static bool SetCastInsetShadowForAllAttachments_bLightAttachmentsAsGroup_IsValid;

	private static FFieldAddress SetCastInsetShadowForAllAttachments_bLightAttachmentsAsGroup_PropertyAddress;

	private static int SetCastInsetShadowForAllAttachments_bLightAttachmentsAsGroup_Offset;

	private static bool RenderTargetCreateStaticTexture2DEditorOnly_IsValid;

	private static IntPtr RenderTargetCreateStaticTexture2DEditorOnly_FunctionAddress;

	private static int RenderTargetCreateStaticTexture2DEditorOnly_ParamsSize;

	private static bool RenderTargetCreateStaticTexture2DEditorOnly_RenderTarget_IsValid;

	private static FFieldAddress RenderTargetCreateStaticTexture2DEditorOnly_RenderTarget_PropertyAddress;

	private static int RenderTargetCreateStaticTexture2DEditorOnly_RenderTarget_Offset;

	private static bool RenderTargetCreateStaticTexture2DEditorOnly_Name_IsValid;

	private static FFieldAddress RenderTargetCreateStaticTexture2DEditorOnly_Name_PropertyAddress;

	private static int RenderTargetCreateStaticTexture2DEditorOnly_Name_Offset;

	private static bool RenderTargetCreateStaticTexture2DEditorOnly_CompressionSettings_IsValid;

	private static FFieldAddress RenderTargetCreateStaticTexture2DEditorOnly_CompressionSettings_PropertyAddress;

	private static int RenderTargetCreateStaticTexture2DEditorOnly_CompressionSettings_Offset;

	private static bool RenderTargetCreateStaticTexture2DEditorOnly_MipSettings_IsValid;

	private static FFieldAddress RenderTargetCreateStaticTexture2DEditorOnly_MipSettings_PropertyAddress;

	private static int RenderTargetCreateStaticTexture2DEditorOnly_MipSettings_Offset;

	private static bool RenderTargetCreateStaticTexture2DEditorOnly_ReturnValue_IsValid;

	private static FFieldAddress RenderTargetCreateStaticTexture2DEditorOnly_ReturnValue_PropertyAddress;

	private static int RenderTargetCreateStaticTexture2DEditorOnly_ReturnValue_Offset;

	private static bool ReleaseRenderTarget2D_IsValid;

	private static IntPtr ReleaseRenderTarget2D_FunctionAddress;

	private static int ReleaseRenderTarget2D_ParamsSize;

	private static bool ReleaseRenderTarget2D_TextureRenderTarget_IsValid;

	private static FFieldAddress ReleaseRenderTarget2D_TextureRenderTarget_PropertyAddress;

	private static int ReleaseRenderTarget2D_TextureRenderTarget_Offset;

	private static bool ReadRenderTargetUV_IsValid;

	private static IntPtr ReadRenderTargetUV_FunctionAddress;

	private static int ReadRenderTargetUV_ParamsSize;

	private static bool ReadRenderTargetUV_WorldContextObject_IsValid;

	private static FFieldAddress ReadRenderTargetUV_WorldContextObject_PropertyAddress;

	private static int ReadRenderTargetUV_WorldContextObject_Offset;

	private static bool ReadRenderTargetUV_TextureRenderTarget_IsValid;

	private static FFieldAddress ReadRenderTargetUV_TextureRenderTarget_PropertyAddress;

	private static int ReadRenderTargetUV_TextureRenderTarget_Offset;

	private static bool ReadRenderTargetUV_U_IsValid;

	private static FFieldAddress ReadRenderTargetUV_U_PropertyAddress;

	private static int ReadRenderTargetUV_U_Offset;

	private static bool ReadRenderTargetUV_V_IsValid;

	private static FFieldAddress ReadRenderTargetUV_V_PropertyAddress;

	private static int ReadRenderTargetUV_V_Offset;

	private static bool ReadRenderTargetUV_ReturnValue_IsValid;

	private static FFieldAddress ReadRenderTargetUV_ReturnValue_PropertyAddress;

	private static int ReadRenderTargetUV_ReturnValue_Offset;

	private static bool ReadRenderTargetRawUVArea_IsValid;

	private static IntPtr ReadRenderTargetRawUVArea_FunctionAddress;

	private static int ReadRenderTargetRawUVArea_ParamsSize;

	private static bool ReadRenderTargetRawUVArea_WorldContextObject_IsValid;

	private static FFieldAddress ReadRenderTargetRawUVArea_WorldContextObject_PropertyAddress;

	private static int ReadRenderTargetRawUVArea_WorldContextObject_Offset;

	private static bool ReadRenderTargetRawUVArea_TextureRenderTarget_IsValid;

	private static FFieldAddress ReadRenderTargetRawUVArea_TextureRenderTarget_PropertyAddress;

	private static int ReadRenderTargetRawUVArea_TextureRenderTarget_Offset;

	private static bool ReadRenderTargetRawUVArea_Area_IsValid;

	private static FFieldAddress ReadRenderTargetRawUVArea_Area_PropertyAddress;

	private static int ReadRenderTargetRawUVArea_Area_Offset;

	private static bool ReadRenderTargetRawUVArea_bNormalize_IsValid;

	private static FFieldAddress ReadRenderTargetRawUVArea_bNormalize_PropertyAddress;

	private static int ReadRenderTargetRawUVArea_bNormalize_Offset;

	private static bool ReadRenderTargetRawUVArea_ReturnValue_IsValid;

	private static FFieldAddress ReadRenderTargetRawUVArea_ReturnValue_PropertyAddress;

	private static int ReadRenderTargetRawUVArea_ReturnValue_Offset;

	private static bool ReadRenderTargetRawUV_IsValid;

	private static IntPtr ReadRenderTargetRawUV_FunctionAddress;

	private static int ReadRenderTargetRawUV_ParamsSize;

	private static bool ReadRenderTargetRawUV_WorldContextObject_IsValid;

	private static FFieldAddress ReadRenderTargetRawUV_WorldContextObject_PropertyAddress;

	private static int ReadRenderTargetRawUV_WorldContextObject_Offset;

	private static bool ReadRenderTargetRawUV_TextureRenderTarget_IsValid;

	private static FFieldAddress ReadRenderTargetRawUV_TextureRenderTarget_PropertyAddress;

	private static int ReadRenderTargetRawUV_TextureRenderTarget_Offset;

	private static bool ReadRenderTargetRawUV_U_IsValid;

	private static FFieldAddress ReadRenderTargetRawUV_U_PropertyAddress;

	private static int ReadRenderTargetRawUV_U_Offset;

	private static bool ReadRenderTargetRawUV_V_IsValid;

	private static FFieldAddress ReadRenderTargetRawUV_V_PropertyAddress;

	private static int ReadRenderTargetRawUV_V_Offset;

	private static bool ReadRenderTargetRawUV_bNormalize_IsValid;

	private static FFieldAddress ReadRenderTargetRawUV_bNormalize_PropertyAddress;

	private static int ReadRenderTargetRawUV_bNormalize_Offset;

	private static bool ReadRenderTargetRawUV_ReturnValue_IsValid;

	private static FFieldAddress ReadRenderTargetRawUV_ReturnValue_PropertyAddress;

	private static int ReadRenderTargetRawUV_ReturnValue_Offset;

	private static bool ReadRenderTargetRawPixelArea_IsValid;

	private static IntPtr ReadRenderTargetRawPixelArea_FunctionAddress;

	private static int ReadRenderTargetRawPixelArea_ParamsSize;

	private static bool ReadRenderTargetRawPixelArea_WorldContextObject_IsValid;

	private static FFieldAddress ReadRenderTargetRawPixelArea_WorldContextObject_PropertyAddress;

	private static int ReadRenderTargetRawPixelArea_WorldContextObject_Offset;

	private static bool ReadRenderTargetRawPixelArea_TextureRenderTarget_IsValid;

	private static FFieldAddress ReadRenderTargetRawPixelArea_TextureRenderTarget_PropertyAddress;

	private static int ReadRenderTargetRawPixelArea_TextureRenderTarget_Offset;

	private static bool ReadRenderTargetRawPixelArea_MinX_IsValid;

	private static FFieldAddress ReadRenderTargetRawPixelArea_MinX_PropertyAddress;

	private static int ReadRenderTargetRawPixelArea_MinX_Offset;

	private static bool ReadRenderTargetRawPixelArea_MinY_IsValid;

	private static FFieldAddress ReadRenderTargetRawPixelArea_MinY_PropertyAddress;

	private static int ReadRenderTargetRawPixelArea_MinY_Offset;

	private static bool ReadRenderTargetRawPixelArea_MaxX_IsValid;

	private static FFieldAddress ReadRenderTargetRawPixelArea_MaxX_PropertyAddress;

	private static int ReadRenderTargetRawPixelArea_MaxX_Offset;

	private static bool ReadRenderTargetRawPixelArea_MaxY_IsValid;

	private static FFieldAddress ReadRenderTargetRawPixelArea_MaxY_PropertyAddress;

	private static int ReadRenderTargetRawPixelArea_MaxY_Offset;

	private static bool ReadRenderTargetRawPixelArea_bNormalize_IsValid;

	private static FFieldAddress ReadRenderTargetRawPixelArea_bNormalize_PropertyAddress;

	private static int ReadRenderTargetRawPixelArea_bNormalize_Offset;

	private static bool ReadRenderTargetRawPixelArea_ReturnValue_IsValid;

	private static FFieldAddress ReadRenderTargetRawPixelArea_ReturnValue_PropertyAddress;

	private static int ReadRenderTargetRawPixelArea_ReturnValue_Offset;

	private static bool ReadRenderTargetRawPixel_IsValid;

	private static IntPtr ReadRenderTargetRawPixel_FunctionAddress;

	private static int ReadRenderTargetRawPixel_ParamsSize;

	private static bool ReadRenderTargetRawPixel_WorldContextObject_IsValid;

	private static FFieldAddress ReadRenderTargetRawPixel_WorldContextObject_PropertyAddress;

	private static int ReadRenderTargetRawPixel_WorldContextObject_Offset;

	private static bool ReadRenderTargetRawPixel_TextureRenderTarget_IsValid;

	private static FFieldAddress ReadRenderTargetRawPixel_TextureRenderTarget_PropertyAddress;

	private static int ReadRenderTargetRawPixel_TextureRenderTarget_Offset;

	private static bool ReadRenderTargetRawPixel_X_IsValid;

	private static FFieldAddress ReadRenderTargetRawPixel_X_PropertyAddress;

	private static int ReadRenderTargetRawPixel_X_Offset;

	private static bool ReadRenderTargetRawPixel_Y_IsValid;

	private static FFieldAddress ReadRenderTargetRawPixel_Y_PropertyAddress;

	private static int ReadRenderTargetRawPixel_Y_Offset;

	private static bool ReadRenderTargetRawPixel_bNormalize_IsValid;

	private static FFieldAddress ReadRenderTargetRawPixel_bNormalize_PropertyAddress;

	private static int ReadRenderTargetRawPixel_bNormalize_Offset;

	private static bool ReadRenderTargetRawPixel_ReturnValue_IsValid;

	private static FFieldAddress ReadRenderTargetRawPixel_ReturnValue_PropertyAddress;

	private static int ReadRenderTargetRawPixel_ReturnValue_Offset;

	private static bool ReadRenderTargetRaw_IsValid;

	private static IntPtr ReadRenderTargetRaw_FunctionAddress;

	private static int ReadRenderTargetRaw_ParamsSize;

	private static bool ReadRenderTargetRaw_WorldContextObject_IsValid;

	private static FFieldAddress ReadRenderTargetRaw_WorldContextObject_PropertyAddress;

	private static int ReadRenderTargetRaw_WorldContextObject_Offset;

	private static bool ReadRenderTargetRaw_TextureRenderTarget_IsValid;

	private static FFieldAddress ReadRenderTargetRaw_TextureRenderTarget_PropertyAddress;

	private static int ReadRenderTargetRaw_TextureRenderTarget_Offset;

	private static bool ReadRenderTargetRaw_OutLinearSamples_IsValid;

	private static FFieldAddress ReadRenderTargetRaw_OutLinearSamples_PropertyAddress;

	private static int ReadRenderTargetRaw_OutLinearSamples_Offset;

	private static bool ReadRenderTargetRaw_bNormalize_IsValid;

	private static FFieldAddress ReadRenderTargetRaw_bNormalize_PropertyAddress;

	private static int ReadRenderTargetRaw_bNormalize_Offset;

	private static bool ReadRenderTargetRaw_ReturnValue_IsValid;

	private static FFieldAddress ReadRenderTargetRaw_ReturnValue_PropertyAddress;

	private static int ReadRenderTargetRaw_ReturnValue_Offset;

	private static bool ReadRenderTargetPixel_IsValid;

	private static IntPtr ReadRenderTargetPixel_FunctionAddress;

	private static int ReadRenderTargetPixel_ParamsSize;

	private static bool ReadRenderTargetPixel_WorldContextObject_IsValid;

	private static FFieldAddress ReadRenderTargetPixel_WorldContextObject_PropertyAddress;

	private static int ReadRenderTargetPixel_WorldContextObject_Offset;

	private static bool ReadRenderTargetPixel_TextureRenderTarget_IsValid;

	private static FFieldAddress ReadRenderTargetPixel_TextureRenderTarget_PropertyAddress;

	private static int ReadRenderTargetPixel_TextureRenderTarget_Offset;

	private static bool ReadRenderTargetPixel_X_IsValid;

	private static FFieldAddress ReadRenderTargetPixel_X_PropertyAddress;

	private static int ReadRenderTargetPixel_X_Offset;

	private static bool ReadRenderTargetPixel_Y_IsValid;

	private static FFieldAddress ReadRenderTargetPixel_Y_PropertyAddress;

	private static int ReadRenderTargetPixel_Y_Offset;

	private static bool ReadRenderTargetPixel_ReturnValue_IsValid;

	private static FFieldAddress ReadRenderTargetPixel_ReturnValue_PropertyAddress;

	private static int ReadRenderTargetPixel_ReturnValue_Offset;

	private static bool ReadRenderTarget_IsValid;

	private static IntPtr ReadRenderTarget_FunctionAddress;

	private static int ReadRenderTarget_ParamsSize;

	private static bool ReadRenderTarget_WorldContextObject_IsValid;

	private static FFieldAddress ReadRenderTarget_WorldContextObject_PropertyAddress;

	private static int ReadRenderTarget_WorldContextObject_Offset;

	private static bool ReadRenderTarget_TextureRenderTarget_IsValid;

	private static FFieldAddress ReadRenderTarget_TextureRenderTarget_PropertyAddress;

	private static int ReadRenderTarget_TextureRenderTarget_Offset;

	private static bool ReadRenderTarget_OutSamples_IsValid;

	private static FFieldAddress ReadRenderTarget_OutSamples_PropertyAddress;

	private static int ReadRenderTarget_OutSamples_Offset;

	private static bool ReadRenderTarget_bNormalize_IsValid;

	private static FFieldAddress ReadRenderTarget_bNormalize_PropertyAddress;

	private static int ReadRenderTarget_bNormalize_Offset;

	private static bool ReadRenderTarget_ReturnValue_IsValid;

	private static FFieldAddress ReadRenderTarget_ReturnValue_PropertyAddress;

	private static int ReadRenderTarget_ReturnValue_Offset;

	private static bool MakeSkinWeightInfo_IsValid;

	private static IntPtr MakeSkinWeightInfo_FunctionAddress;

	private static int MakeSkinWeightInfo_ParamsSize;

	private static bool MakeSkinWeightInfo_Bone0_IsValid;

	private static FFieldAddress MakeSkinWeightInfo_Bone0_PropertyAddress;

	private static int MakeSkinWeightInfo_Bone0_Offset;

	private static bool MakeSkinWeightInfo_Weight0_IsValid;

	private static FFieldAddress MakeSkinWeightInfo_Weight0_PropertyAddress;

	private static int MakeSkinWeightInfo_Weight0_Offset;

	private static bool MakeSkinWeightInfo_Bone1_IsValid;

	private static FFieldAddress MakeSkinWeightInfo_Bone1_PropertyAddress;

	private static int MakeSkinWeightInfo_Bone1_Offset;

	private static bool MakeSkinWeightInfo_Weight1_IsValid;

	private static FFieldAddress MakeSkinWeightInfo_Weight1_PropertyAddress;

	private static int MakeSkinWeightInfo_Weight1_Offset;

	private static bool MakeSkinWeightInfo_Bone2_IsValid;

	private static FFieldAddress MakeSkinWeightInfo_Bone2_PropertyAddress;

	private static int MakeSkinWeightInfo_Bone2_Offset;

	private static bool MakeSkinWeightInfo_Weight2_IsValid;

	private static FFieldAddress MakeSkinWeightInfo_Weight2_PropertyAddress;

	private static int MakeSkinWeightInfo_Weight2_Offset;

	private static bool MakeSkinWeightInfo_Bone3_IsValid;

	private static FFieldAddress MakeSkinWeightInfo_Bone3_PropertyAddress;

	private static int MakeSkinWeightInfo_Bone3_Offset;

	private static bool MakeSkinWeightInfo_Weight3_IsValid;

	private static FFieldAddress MakeSkinWeightInfo_Weight3_PropertyAddress;

	private static int MakeSkinWeightInfo_Weight3_Offset;

	private static bool MakeSkinWeightInfo_ReturnValue_IsValid;

	private static FFieldAddress MakeSkinWeightInfo_ReturnValue_PropertyAddress;

	private static int MakeSkinWeightInfo_ReturnValue_Offset;

	private static bool ImportFileAsTexture2D_IsValid;

	private static IntPtr ImportFileAsTexture2D_FunctionAddress;

	private static int ImportFileAsTexture2D_ParamsSize;

	private static bool ImportFileAsTexture2D_WorldContextObject_IsValid;

	private static FFieldAddress ImportFileAsTexture2D_WorldContextObject_PropertyAddress;

	private static int ImportFileAsTexture2D_WorldContextObject_Offset;

	private static bool ImportFileAsTexture2D_Filename_IsValid;

	private static FFieldAddress ImportFileAsTexture2D_Filename_PropertyAddress;

	private static int ImportFileAsTexture2D_Filename_Offset;

	private static bool ImportFileAsTexture2D_ReturnValue_IsValid;

	private static FFieldAddress ImportFileAsTexture2D_ReturnValue_PropertyAddress;

	private static int ImportFileAsTexture2D_ReturnValue_Offset;

	private static bool ImportBufferAsTexture2D_IsValid;

	private static IntPtr ImportBufferAsTexture2D_FunctionAddress;

	private static int ImportBufferAsTexture2D_ParamsSize;

	private static bool ImportBufferAsTexture2D_WorldContextObject_IsValid;

	private static FFieldAddress ImportBufferAsTexture2D_WorldContextObject_PropertyAddress;

	private static int ImportBufferAsTexture2D_WorldContextObject_Offset;

	private static bool ImportBufferAsTexture2D_Buffer_IsValid;

	private static FFieldAddress ImportBufferAsTexture2D_Buffer_PropertyAddress;

	private static int ImportBufferAsTexture2D_Buffer_Offset;

	private static bool ImportBufferAsTexture2D_ReturnValue_IsValid;

	private static FFieldAddress ImportBufferAsTexture2D_ReturnValue_PropertyAddress;

	private static int ImportBufferAsTexture2D_ReturnValue_Offset;

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

	private static bool ExportRenderTarget_IsValid;

	private static IntPtr ExportRenderTarget_FunctionAddress;

	private static int ExportRenderTarget_ParamsSize;

	private static bool ExportRenderTarget_WorldContextObject_IsValid;

	private static FFieldAddress ExportRenderTarget_WorldContextObject_PropertyAddress;

	private static int ExportRenderTarget_WorldContextObject_Offset;

	private static bool ExportRenderTarget_TextureRenderTarget_IsValid;

	private static FFieldAddress ExportRenderTarget_TextureRenderTarget_PropertyAddress;

	private static int ExportRenderTarget_TextureRenderTarget_Offset;

	private static bool ExportRenderTarget_FilePath_IsValid;

	private static FFieldAddress ExportRenderTarget_FilePath_PropertyAddress;

	private static int ExportRenderTarget_FilePath_Offset;

	private static bool ExportRenderTarget_FileName_IsValid;

	private static FFieldAddress ExportRenderTarget_FileName_PropertyAddress;

	private static int ExportRenderTarget_FileName_Offset;

	private static bool EndDrawCanvasToRenderTarget_IsValid;

	private static IntPtr EndDrawCanvasToRenderTarget_FunctionAddress;

	private static int EndDrawCanvasToRenderTarget_ParamsSize;

	private static bool EndDrawCanvasToRenderTarget_WorldContextObject_IsValid;

	private static FFieldAddress EndDrawCanvasToRenderTarget_WorldContextObject_PropertyAddress;

	private static int EndDrawCanvasToRenderTarget_WorldContextObject_Offset;

	private static bool EndDrawCanvasToRenderTarget_Context_IsValid;

	private static FFieldAddress EndDrawCanvasToRenderTarget_Context_PropertyAddress;

	private static int EndDrawCanvasToRenderTarget_Context_Offset;

	private static bool DrawMaterialToRenderTarget_IsValid;

	private static IntPtr DrawMaterialToRenderTarget_FunctionAddress;

	private static int DrawMaterialToRenderTarget_ParamsSize;

	private static bool DrawMaterialToRenderTarget_WorldContextObject_IsValid;

	private static FFieldAddress DrawMaterialToRenderTarget_WorldContextObject_PropertyAddress;

	private static int DrawMaterialToRenderTarget_WorldContextObject_Offset;

	private static bool DrawMaterialToRenderTarget_TextureRenderTarget_IsValid;

	private static FFieldAddress DrawMaterialToRenderTarget_TextureRenderTarget_PropertyAddress;

	private static int DrawMaterialToRenderTarget_TextureRenderTarget_Offset;

	private static bool DrawMaterialToRenderTarget_Material_IsValid;

	private static FFieldAddress DrawMaterialToRenderTarget_Material_PropertyAddress;

	private static int DrawMaterialToRenderTarget_Material_Offset;

	private static bool CreateRenderTargetVolume_IsValid;

	private static IntPtr CreateRenderTargetVolume_FunctionAddress;

	private static int CreateRenderTargetVolume_ParamsSize;

	private static bool CreateRenderTargetVolume_WorldContextObject_IsValid;

	private static FFieldAddress CreateRenderTargetVolume_WorldContextObject_PropertyAddress;

	private static int CreateRenderTargetVolume_WorldContextObject_Offset;

	private static bool CreateRenderTargetVolume_Width_IsValid;

	private static FFieldAddress CreateRenderTargetVolume_Width_PropertyAddress;

	private static int CreateRenderTargetVolume_Width_Offset;

	private static bool CreateRenderTargetVolume_Height_IsValid;

	private static FFieldAddress CreateRenderTargetVolume_Height_PropertyAddress;

	private static int CreateRenderTargetVolume_Height_Offset;

	private static bool CreateRenderTargetVolume_Depth_IsValid;

	private static FFieldAddress CreateRenderTargetVolume_Depth_PropertyAddress;

	private static int CreateRenderTargetVolume_Depth_Offset;

	private static bool CreateRenderTargetVolume_Format_IsValid;

	private static FFieldAddress CreateRenderTargetVolume_Format_PropertyAddress;

	private static int CreateRenderTargetVolume_Format_Offset;

	private static bool CreateRenderTargetVolume_ClearColor_IsValid;

	private static FFieldAddress CreateRenderTargetVolume_ClearColor_PropertyAddress;

	private static int CreateRenderTargetVolume_ClearColor_Offset;

	private static bool CreateRenderTargetVolume_bAutoGenerateMipMaps_IsValid;

	private static FFieldAddress CreateRenderTargetVolume_bAutoGenerateMipMaps_PropertyAddress;

	private static int CreateRenderTargetVolume_bAutoGenerateMipMaps_Offset;

	private static bool CreateRenderTargetVolume_ReturnValue_IsValid;

	private static FFieldAddress CreateRenderTargetVolume_ReturnValue_PropertyAddress;

	private static int CreateRenderTargetVolume_ReturnValue_Offset;

	private static bool CreateRenderTarget2DArray_IsValid;

	private static IntPtr CreateRenderTarget2DArray_FunctionAddress;

	private static int CreateRenderTarget2DArray_ParamsSize;

	private static bool CreateRenderTarget2DArray_WorldContextObject_IsValid;

	private static FFieldAddress CreateRenderTarget2DArray_WorldContextObject_PropertyAddress;

	private static int CreateRenderTarget2DArray_WorldContextObject_Offset;

	private static bool CreateRenderTarget2DArray_Width_IsValid;

	private static FFieldAddress CreateRenderTarget2DArray_Width_PropertyAddress;

	private static int CreateRenderTarget2DArray_Width_Offset;

	private static bool CreateRenderTarget2DArray_Height_IsValid;

	private static FFieldAddress CreateRenderTarget2DArray_Height_PropertyAddress;

	private static int CreateRenderTarget2DArray_Height_Offset;

	private static bool CreateRenderTarget2DArray_Slices_IsValid;

	private static FFieldAddress CreateRenderTarget2DArray_Slices_PropertyAddress;

	private static int CreateRenderTarget2DArray_Slices_Offset;

	private static bool CreateRenderTarget2DArray_Format_IsValid;

	private static FFieldAddress CreateRenderTarget2DArray_Format_PropertyAddress;

	private static int CreateRenderTarget2DArray_Format_Offset;

	private static bool CreateRenderTarget2DArray_ClearColor_IsValid;

	private static FFieldAddress CreateRenderTarget2DArray_ClearColor_PropertyAddress;

	private static int CreateRenderTarget2DArray_ClearColor_Offset;

	private static bool CreateRenderTarget2DArray_bAutoGenerateMipMaps_IsValid;

	private static FFieldAddress CreateRenderTarget2DArray_bAutoGenerateMipMaps_PropertyAddress;

	private static int CreateRenderTarget2DArray_bAutoGenerateMipMaps_Offset;

	private static bool CreateRenderTarget2DArray_ReturnValue_IsValid;

	private static FFieldAddress CreateRenderTarget2DArray_ReturnValue_PropertyAddress;

	private static int CreateRenderTarget2DArray_ReturnValue_Offset;

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

	private static bool CreateRenderTarget2D_Format_IsValid;

	private static FFieldAddress CreateRenderTarget2D_Format_PropertyAddress;

	private static int CreateRenderTarget2D_Format_Offset;

	private static bool CreateRenderTarget2D_ClearColor_IsValid;

	private static FFieldAddress CreateRenderTarget2D_ClearColor_PropertyAddress;

	private static int CreateRenderTarget2D_ClearColor_Offset;

	private static bool CreateRenderTarget2D_bAutoGenerateMipMaps_IsValid;

	private static FFieldAddress CreateRenderTarget2D_bAutoGenerateMipMaps_PropertyAddress;

	private static int CreateRenderTarget2D_bAutoGenerateMipMaps_Offset;

	private static bool CreateRenderTarget2D_ReturnValue_IsValid;

	private static FFieldAddress CreateRenderTarget2D_ReturnValue_PropertyAddress;

	private static int CreateRenderTarget2D_ReturnValue_Offset;

	private static bool ConvertRenderTargetToTexture2DEditorOnly_IsValid;

	private static IntPtr ConvertRenderTargetToTexture2DEditorOnly_FunctionAddress;

	private static int ConvertRenderTargetToTexture2DEditorOnly_ParamsSize;

	private static bool ConvertRenderTargetToTexture2DEditorOnly_WorldContextObject_IsValid;

	private static FFieldAddress ConvertRenderTargetToTexture2DEditorOnly_WorldContextObject_PropertyAddress;

	private static int ConvertRenderTargetToTexture2DEditorOnly_WorldContextObject_Offset;

	private static bool ConvertRenderTargetToTexture2DEditorOnly_RenderTarget_IsValid;

	private static FFieldAddress ConvertRenderTargetToTexture2DEditorOnly_RenderTarget_PropertyAddress;

	private static int ConvertRenderTargetToTexture2DEditorOnly_RenderTarget_Offset;

	private static bool ConvertRenderTargetToTexture2DEditorOnly_Texture_IsValid;

	private static FFieldAddress ConvertRenderTargetToTexture2DEditorOnly_Texture_PropertyAddress;

	private static int ConvertRenderTargetToTexture2DEditorOnly_Texture_Offset;

	private static bool ClearRenderTarget2D_IsValid;

	private static IntPtr ClearRenderTarget2D_FunctionAddress;

	private static int ClearRenderTarget2D_ParamsSize;

	private static bool ClearRenderTarget2D_WorldContextObject_IsValid;

	private static FFieldAddress ClearRenderTarget2D_WorldContextObject_PropertyAddress;

	private static int ClearRenderTarget2D_WorldContextObject_Offset;

	private static bool ClearRenderTarget2D_TextureRenderTarget_IsValid;

	private static FFieldAddress ClearRenderTarget2D_TextureRenderTarget_PropertyAddress;

	private static int ClearRenderTarget2D_TextureRenderTarget_Offset;

	private static bool ClearRenderTarget2D_ClearColor_IsValid;

	private static FFieldAddress ClearRenderTarget2D_ClearColor_PropertyAddress;

	private static int ClearRenderTarget2D_ClearColor_Offset;

	private static bool CalculateProjectionMatrix_IsValid;

	private static IntPtr CalculateProjectionMatrix_FunctionAddress;

	private static int CalculateProjectionMatrix_ParamsSize;

	private static bool CalculateProjectionMatrix_MinimalViewInfo_IsValid;

	private static FFieldAddress CalculateProjectionMatrix_MinimalViewInfo_PropertyAddress;

	private static int CalculateProjectionMatrix_MinimalViewInfo_Offset;

	private static bool CalculateProjectionMatrix_ReturnValue_IsValid;

	private static FFieldAddress CalculateProjectionMatrix_ReturnValue_PropertyAddress;

	private static int CalculateProjectionMatrix_ReturnValue_Offset;

	private static bool BreakSkinWeightInfo_IsValid;

	private static IntPtr BreakSkinWeightInfo_FunctionAddress;

	private static int BreakSkinWeightInfo_ParamsSize;

	private static bool BreakSkinWeightInfo_InWeight_IsValid;

	private static FFieldAddress BreakSkinWeightInfo_InWeight_PropertyAddress;

	private static int BreakSkinWeightInfo_InWeight_Offset;

	private static bool BreakSkinWeightInfo_Bone0_IsValid;

	private static FFieldAddress BreakSkinWeightInfo_Bone0_PropertyAddress;

	private static int BreakSkinWeightInfo_Bone0_Offset;

	private static bool BreakSkinWeightInfo_Weight0_IsValid;

	private static FFieldAddress BreakSkinWeightInfo_Weight0_PropertyAddress;

	private static int BreakSkinWeightInfo_Weight0_Offset;

	private static bool BreakSkinWeightInfo_Bone1_IsValid;

	private static FFieldAddress BreakSkinWeightInfo_Bone1_PropertyAddress;

	private static int BreakSkinWeightInfo_Bone1_Offset;

	private static bool BreakSkinWeightInfo_Weight1_IsValid;

	private static FFieldAddress BreakSkinWeightInfo_Weight1_PropertyAddress;

	private static int BreakSkinWeightInfo_Weight1_Offset;

	private static bool BreakSkinWeightInfo_Bone2_IsValid;

	private static FFieldAddress BreakSkinWeightInfo_Bone2_PropertyAddress;

	private static int BreakSkinWeightInfo_Bone2_Offset;

	private static bool BreakSkinWeightInfo_Weight2_IsValid;

	private static FFieldAddress BreakSkinWeightInfo_Weight2_PropertyAddress;

	private static int BreakSkinWeightInfo_Weight2_Offset;

	private static bool BreakSkinWeightInfo_Bone3_IsValid;

	private static FFieldAddress BreakSkinWeightInfo_Bone3_PropertyAddress;

	private static int BreakSkinWeightInfo_Bone3_Offset;

	private static bool BreakSkinWeightInfo_Weight3_IsValid;

	private static FFieldAddress BreakSkinWeightInfo_Weight3_PropertyAddress;

	private static int BreakSkinWeightInfo_Weight3_Offset;

	private static bool BeginDrawCanvasToRenderTarget_IsValid;

	private static IntPtr BeginDrawCanvasToRenderTarget_FunctionAddress;

	private static int BeginDrawCanvasToRenderTarget_ParamsSize;

	private static bool BeginDrawCanvasToRenderTarget_WorldContextObject_IsValid;

	private static FFieldAddress BeginDrawCanvasToRenderTarget_WorldContextObject_PropertyAddress;

	private static int BeginDrawCanvasToRenderTarget_WorldContextObject_Offset;

	private static bool BeginDrawCanvasToRenderTarget_TextureRenderTarget_IsValid;

	private static FFieldAddress BeginDrawCanvasToRenderTarget_TextureRenderTarget_PropertyAddress;

	private static int BeginDrawCanvasToRenderTarget_TextureRenderTarget_Offset;

	private static bool BeginDrawCanvasToRenderTarget_Canvas_IsValid;

	private static FFieldAddress BeginDrawCanvasToRenderTarget_Canvas_PropertyAddress;

	private static int BeginDrawCanvasToRenderTarget_Canvas_Offset;

	private static bool BeginDrawCanvasToRenderTarget_Size_IsValid;

	private static FFieldAddress BeginDrawCanvasToRenderTarget_Size_PropertyAddress;

	private static int BeginDrawCanvasToRenderTarget_Size_Offset;

	private static bool BeginDrawCanvasToRenderTarget_Context_IsValid;

	private static FFieldAddress BeginDrawCanvasToRenderTarget_Context_PropertyAddress;

	private static int BeginDrawCanvasToRenderTarget_Context_Offset;

	[UFunction(Flags = 67249155u)]
	[UMetaPath("/Script/Engine.KismetRenderingLibrary:SetCastInsetShadowForAllAttachments")]
	public unsafe static void SetCastInsetShadowForAllAttachments(UPrimitiveComponent PrimitiveComponent, bool bCastInsetShadow, bool bLightAttachmentsAsGroup)
	{
		if (!SetCastInsetShadowForAllAttachments_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetRenderingLibrary:SetCastInsetShadowForAllAttachments");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCastInsetShadowForAllAttachments_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCastInsetShadowForAllAttachments_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, SetCastInsetShadowForAllAttachments_PrimitiveComponent_Offset), 0, SetCastInsetShadowForAllAttachments_PrimitiveComponent_PropertyAddress.Address, PrimitiveComponent);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCastInsetShadowForAllAttachments_bCastInsetShadow_Offset), 0, SetCastInsetShadowForAllAttachments_bCastInsetShadow_PropertyAddress.Address, bCastInsetShadow);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCastInsetShadowForAllAttachments_bLightAttachmentsAsGroup_Offset), 0, SetCastInsetShadowForAllAttachments_bLightAttachmentsAsGroup_PropertyAddress.Address, bLightAttachmentsAsGroup);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetCastInsetShadowForAllAttachments_FunctionAddress, intPtr, SetCastInsetShadowForAllAttachments_ParamsSize);
	}

	[UFunction(Flags = 67249155u)]
	[UMetaPath("/Script/Engine.KismetRenderingLibrary:RenderTargetCreateStaticTexture2DEditorOnly")]
	public unsafe static UTexture2D RenderTargetCreateStaticTexture2DEditorOnly(UTextureRenderTarget2D RenderTarget, string Name = "Texture", ETextureCompressionSettings CompressionSettings = ETextureCompressionSettings.TC_Default, ETextureMipGenSettings MipSettings = ETextureMipGenSettings.TMGS_FromTextureGroup)
	{
		if (!RenderTargetCreateStaticTexture2DEditorOnly_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetRenderingLibrary:RenderTargetCreateStaticTexture2DEditorOnly");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RenderTargetCreateStaticTexture2DEditorOnly_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RenderTargetCreateStaticTexture2DEditorOnly_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(intPtr, RenderTargetCreateStaticTexture2DEditorOnly_RenderTarget_Offset), 0, RenderTargetCreateStaticTexture2DEditorOnly_RenderTarget_PropertyAddress.Address, RenderTarget);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RenderTargetCreateStaticTexture2DEditorOnly_Name_Offset), 0, RenderTargetCreateStaticTexture2DEditorOnly_Name_PropertyAddress.Address, Name);
		EnumMarshaler<ETextureCompressionSettings>.ToNative(IntPtr.Add(intPtr, RenderTargetCreateStaticTexture2DEditorOnly_CompressionSettings_Offset), 0, RenderTargetCreateStaticTexture2DEditorOnly_CompressionSettings_PropertyAddress.Address, CompressionSettings);
		EnumMarshaler<ETextureMipGenSettings>.ToNative(IntPtr.Add(intPtr, RenderTargetCreateStaticTexture2DEditorOnly_MipSettings_Offset), 0, RenderTargetCreateStaticTexture2DEditorOnly_MipSettings_PropertyAddress.Address, MipSettings);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RenderTargetCreateStaticTexture2DEditorOnly_FunctionAddress, intPtr, RenderTargetCreateStaticTexture2DEditorOnly_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RenderTargetCreateStaticTexture2DEditorOnly_Name_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(intPtr, RenderTargetCreateStaticTexture2DEditorOnly_ReturnValue_Offset), 0, RenderTargetCreateStaticTexture2DEditorOnly_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249155u)]
	[UMetaPath("/Script/Engine.KismetRenderingLibrary:ReleaseRenderTarget2D")]
	public unsafe static void ReleaseRenderTarget2D(UTextureRenderTarget2D TextureRenderTarget)
	{
		if (!ReleaseRenderTarget2D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetRenderingLibrary:ReleaseRenderTarget2D");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReleaseRenderTarget2D_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReleaseRenderTarget2D_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(intPtr, ReleaseRenderTarget2D_TextureRenderTarget_Offset), 0, ReleaseRenderTarget2D_TextureRenderTarget_PropertyAddress.Address, TextureRenderTarget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ReleaseRenderTarget2D_FunctionAddress, intPtr, ReleaseRenderTarget2D_ParamsSize);
	}

	[UFunction(Flags = 75637763u)]
	[UMetaPath("/Script/Engine.KismetRenderingLibrary:ReadRenderTargetUV")]
	public unsafe static FColor ReadRenderTargetUV(UObject WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, float U, float V)
	{
		if (!ReadRenderTargetUV_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetRenderingLibrary:ReadRenderTargetUV");
			return default(FColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReadRenderTargetUV_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReadRenderTargetUV_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ReadRenderTargetUV_WorldContextObject_Offset), 0, ReadRenderTargetUV_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(intPtr, ReadRenderTargetUV_TextureRenderTarget_Offset), 0, ReadRenderTargetUV_TextureRenderTarget_PropertyAddress.Address, TextureRenderTarget);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ReadRenderTargetUV_U_Offset), 0, ReadRenderTargetUV_U_PropertyAddress.Address, U);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ReadRenderTargetUV_V_Offset), 0, ReadRenderTargetUV_V_PropertyAddress.Address, V);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ReadRenderTargetUV_FunctionAddress, intPtr, ReadRenderTargetUV_ParamsSize);
		return BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(intPtr, ReadRenderTargetUV_ReturnValue_Offset), 0, ReadRenderTargetUV_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637763u)]
	[UMetaPath("/Script/Engine.KismetRenderingLibrary:ReadRenderTargetRawUVArea")]
	public unsafe static List<FLinearColor> ReadRenderTargetRawUVArea(UObject WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, FBox2D Area, bool bNormalize = true)
	{
		if (!ReadRenderTargetRawUVArea_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetRenderingLibrary:ReadRenderTargetRawUVArea");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReadRenderTargetRawUVArea_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReadRenderTargetRawUVArea_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ReadRenderTargetRawUVArea_WorldContextObject_Offset), 0, ReadRenderTargetRawUVArea_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(intPtr, ReadRenderTargetRawUVArea_TextureRenderTarget_Offset), 0, ReadRenderTargetRawUVArea_TextureRenderTarget_PropertyAddress.Address, TextureRenderTarget);
		BlittableTypeMarshaler<FBox2D>.ToNative(IntPtr.Add(intPtr, ReadRenderTargetRawUVArea_Area_Offset), 0, ReadRenderTargetRawUVArea_Area_PropertyAddress.Address, Area);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ReadRenderTargetRawUVArea_bNormalize_Offset), 0, ReadRenderTargetRawUVArea_bNormalize_PropertyAddress.Address, bNormalize);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ReadRenderTargetRawUVArea_FunctionAddress, intPtr, ReadRenderTargetRawUVArea_ParamsSize);
		List<FLinearColor> result = new TArrayCopyMarshaler<FLinearColor>(1, ReadRenderTargetRawUVArea_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.FromNative, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.ToNative).FromNative(IntPtr.Add(intPtr, ReadRenderTargetRawUVArea_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(ReadRenderTargetRawUVArea_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 75637763u)]
	[UMetaPath("/Script/Engine.KismetRenderingLibrary:ReadRenderTargetRawUV")]
	public unsafe static FLinearColor ReadRenderTargetRawUV(UObject WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, float U, float V, bool bNormalize = true)
	{
		if (!ReadRenderTargetRawUV_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetRenderingLibrary:ReadRenderTargetRawUV");
			return default(FLinearColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReadRenderTargetRawUV_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReadRenderTargetRawUV_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ReadRenderTargetRawUV_WorldContextObject_Offset), 0, ReadRenderTargetRawUV_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(intPtr, ReadRenderTargetRawUV_TextureRenderTarget_Offset), 0, ReadRenderTargetRawUV_TextureRenderTarget_PropertyAddress.Address, TextureRenderTarget);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ReadRenderTargetRawUV_U_Offset), 0, ReadRenderTargetRawUV_U_PropertyAddress.Address, U);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ReadRenderTargetRawUV_V_Offset), 0, ReadRenderTargetRawUV_V_PropertyAddress.Address, V);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ReadRenderTargetRawUV_bNormalize_Offset), 0, ReadRenderTargetRawUV_bNormalize_PropertyAddress.Address, bNormalize);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ReadRenderTargetRawUV_FunctionAddress, intPtr, ReadRenderTargetRawUV_ParamsSize);
		return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, ReadRenderTargetRawUV_ReturnValue_Offset), 0, ReadRenderTargetRawUV_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249155u)]
	[UMetaPath("/Script/Engine.KismetRenderingLibrary:ReadRenderTargetRawPixelArea")]
	public unsafe static List<FLinearColor> ReadRenderTargetRawPixelArea(UObject WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, int MinX, int MinY, int MaxX, int MaxY, bool bNormalize = true)
	{
		if (!ReadRenderTargetRawPixelArea_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetRenderingLibrary:ReadRenderTargetRawPixelArea");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReadRenderTargetRawPixelArea_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReadRenderTargetRawPixelArea_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ReadRenderTargetRawPixelArea_WorldContextObject_Offset), 0, ReadRenderTargetRawPixelArea_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(intPtr, ReadRenderTargetRawPixelArea_TextureRenderTarget_Offset), 0, ReadRenderTargetRawPixelArea_TextureRenderTarget_PropertyAddress.Address, TextureRenderTarget);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ReadRenderTargetRawPixelArea_MinX_Offset), 0, ReadRenderTargetRawPixelArea_MinX_PropertyAddress.Address, MinX);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ReadRenderTargetRawPixelArea_MinY_Offset), 0, ReadRenderTargetRawPixelArea_MinY_PropertyAddress.Address, MinY);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ReadRenderTargetRawPixelArea_MaxX_Offset), 0, ReadRenderTargetRawPixelArea_MaxX_PropertyAddress.Address, MaxX);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ReadRenderTargetRawPixelArea_MaxY_Offset), 0, ReadRenderTargetRawPixelArea_MaxY_PropertyAddress.Address, MaxY);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ReadRenderTargetRawPixelArea_bNormalize_Offset), 0, ReadRenderTargetRawPixelArea_bNormalize_PropertyAddress.Address, bNormalize);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ReadRenderTargetRawPixelArea_FunctionAddress, intPtr, ReadRenderTargetRawPixelArea_ParamsSize);
		List<FLinearColor> result = new TArrayCopyMarshaler<FLinearColor>(1, ReadRenderTargetRawPixelArea_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.FromNative, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.ToNative).FromNative(IntPtr.Add(intPtr, ReadRenderTargetRawPixelArea_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(ReadRenderTargetRawPixelArea_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 75637763u)]
	[UMetaPath("/Script/Engine.KismetRenderingLibrary:ReadRenderTargetRawPixel")]
	public unsafe static FLinearColor ReadRenderTargetRawPixel(UObject WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, int X, int Y, bool bNormalize = true)
	{
		if (!ReadRenderTargetRawPixel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetRenderingLibrary:ReadRenderTargetRawPixel");
			return default(FLinearColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReadRenderTargetRawPixel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReadRenderTargetRawPixel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ReadRenderTargetRawPixel_WorldContextObject_Offset), 0, ReadRenderTargetRawPixel_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(intPtr, ReadRenderTargetRawPixel_TextureRenderTarget_Offset), 0, ReadRenderTargetRawPixel_TextureRenderTarget_PropertyAddress.Address, TextureRenderTarget);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ReadRenderTargetRawPixel_X_Offset), 0, ReadRenderTargetRawPixel_X_PropertyAddress.Address, X);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ReadRenderTargetRawPixel_Y_Offset), 0, ReadRenderTargetRawPixel_Y_PropertyAddress.Address, Y);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ReadRenderTargetRawPixel_bNormalize_Offset), 0, ReadRenderTargetRawPixel_bNormalize_PropertyAddress.Address, bNormalize);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ReadRenderTargetRawPixel_FunctionAddress, intPtr, ReadRenderTargetRawPixel_ParamsSize);
		return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, ReadRenderTargetRawPixel_ReturnValue_Offset), 0, ReadRenderTargetRawPixel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443459u)]
	[UMetaPath("/Script/Engine.KismetRenderingLibrary:ReadRenderTargetRaw")]
	public unsafe static bool ReadRenderTargetRaw(UObject WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, out List<FLinearColor> OutLinearSamples, bool bNormalize = true)
	{
		if (!ReadRenderTargetRaw_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetRenderingLibrary:ReadRenderTargetRaw");
			OutLinearSamples = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReadRenderTargetRaw_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReadRenderTargetRaw_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ReadRenderTargetRaw_WorldContextObject_Offset), 0, ReadRenderTargetRaw_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(intPtr, ReadRenderTargetRaw_TextureRenderTarget_Offset), 0, ReadRenderTargetRaw_TextureRenderTarget_PropertyAddress.Address, TextureRenderTarget);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ReadRenderTargetRaw_bNormalize_Offset), 0, ReadRenderTargetRaw_bNormalize_PropertyAddress.Address, bNormalize);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ReadRenderTargetRaw_FunctionAddress, intPtr, ReadRenderTargetRaw_ParamsSize);
		OutLinearSamples = new TArrayCopyMarshaler<FLinearColor>(1, ReadRenderTargetRaw_OutLinearSamples_PropertyAddress, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.FromNative, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.ToNative).FromNative(IntPtr.Add(intPtr, ReadRenderTargetRaw_OutLinearSamples_Offset));
		NativeReflection.DestroyValue_InContainer(ReadRenderTargetRaw_OutLinearSamples_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ReadRenderTargetRaw_ReturnValue_Offset), 0, ReadRenderTargetRaw_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637763u)]
	[UMetaPath("/Script/Engine.KismetRenderingLibrary:ReadRenderTargetPixel")]
	public unsafe static FColor ReadRenderTargetPixel(UObject WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, int X, int Y)
	{
		if (!ReadRenderTargetPixel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetRenderingLibrary:ReadRenderTargetPixel");
			return default(FColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReadRenderTargetPixel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReadRenderTargetPixel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ReadRenderTargetPixel_WorldContextObject_Offset), 0, ReadRenderTargetPixel_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(intPtr, ReadRenderTargetPixel_TextureRenderTarget_Offset), 0, ReadRenderTargetPixel_TextureRenderTarget_PropertyAddress.Address, TextureRenderTarget);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ReadRenderTargetPixel_X_Offset), 0, ReadRenderTargetPixel_X_PropertyAddress.Address, X);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ReadRenderTargetPixel_Y_Offset), 0, ReadRenderTargetPixel_Y_PropertyAddress.Address, Y);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ReadRenderTargetPixel_FunctionAddress, intPtr, ReadRenderTargetPixel_ParamsSize);
		return BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(intPtr, ReadRenderTargetPixel_ReturnValue_Offset), 0, ReadRenderTargetPixel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443459u)]
	[UMetaPath("/Script/Engine.KismetRenderingLibrary:ReadRenderTarget")]
	public unsafe static bool ReadRenderTarget(UObject WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, out List<FColor> OutSamples, bool bNormalize = true)
	{
		if (!ReadRenderTarget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetRenderingLibrary:ReadRenderTarget");
			OutSamples = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReadRenderTarget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReadRenderTarget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ReadRenderTarget_WorldContextObject_Offset), 0, ReadRenderTarget_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(intPtr, ReadRenderTarget_TextureRenderTarget_Offset), 0, ReadRenderTarget_TextureRenderTarget_PropertyAddress.Address, TextureRenderTarget);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ReadRenderTarget_bNormalize_Offset), 0, ReadRenderTarget_bNormalize_PropertyAddress.Address, bNormalize);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ReadRenderTarget_FunctionAddress, intPtr, ReadRenderTarget_ParamsSize);
		OutSamples = new TArrayCopyMarshaler<FColor>(1, ReadRenderTarget_OutSamples_PropertyAddress, CachedMarshalingDelegates<FColor, BlittableTypeMarshaler<FColor>>.FromNative, CachedMarshalingDelegates<FColor, BlittableTypeMarshaler<FColor>>.ToNative).FromNative(IntPtr.Add(intPtr, ReadRenderTarget_OutSamples_Offset));
		NativeReflection.DestroyValue_InContainer(ReadRenderTarget_OutSamples_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ReadRenderTarget_ReturnValue_Offset), 0, ReadRenderTarget_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684611u)]
	[UMetaPath("/Script/Engine.KismetRenderingLibrary:MakeSkinWeightInfo")]
	public unsafe static FSkelMeshSkinWeightInfo MakeSkinWeightInfo(int Bone0, byte Weight0, int Bone1, byte Weight1, int Bone2, byte Weight2, int Bone3, byte Weight3)
	{
		if (!MakeSkinWeightInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetRenderingLibrary:MakeSkinWeightInfo");
			return default(FSkelMeshSkinWeightInfo);
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeSkinWeightInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeSkinWeightInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, MakeSkinWeightInfo_Bone0_Offset), 0, MakeSkinWeightInfo_Bone0_PropertyAddress.Address, Bone0);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, MakeSkinWeightInfo_Weight0_Offset), 0, MakeSkinWeightInfo_Weight0_PropertyAddress.Address, Weight0);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, MakeSkinWeightInfo_Bone1_Offset), 0, MakeSkinWeightInfo_Bone1_PropertyAddress.Address, Bone1);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, MakeSkinWeightInfo_Weight1_Offset), 0, MakeSkinWeightInfo_Weight1_PropertyAddress.Address, Weight1);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, MakeSkinWeightInfo_Bone2_Offset), 0, MakeSkinWeightInfo_Bone2_PropertyAddress.Address, Bone2);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, MakeSkinWeightInfo_Weight2_Offset), 0, MakeSkinWeightInfo_Weight2_PropertyAddress.Address, Weight2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, MakeSkinWeightInfo_Bone3_Offset), 0, MakeSkinWeightInfo_Bone3_PropertyAddress.Address, Bone3);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, MakeSkinWeightInfo_Weight3_Offset), 0, MakeSkinWeightInfo_Weight3_PropertyAddress.Address, Weight3);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakeSkinWeightInfo_FunctionAddress, intPtr, MakeSkinWeightInfo_ParamsSize);
		return FSkelMeshSkinWeightInfo.FromNative(IntPtr.Add(intPtr, MakeSkinWeightInfo_ReturnValue_Offset), 0, MakeSkinWeightInfo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249155u)]
	[UMetaPath("/Script/Engine.KismetRenderingLibrary:ImportFileAsTexture2D")]
	public unsafe static UTexture2D ImportFileAsTexture2D(UObject WorldContextObject, string Filename)
	{
		if (!ImportFileAsTexture2D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetRenderingLibrary:ImportFileAsTexture2D");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ImportFileAsTexture2D_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ImportFileAsTexture2D_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ImportFileAsTexture2D_WorldContextObject_Offset), 0, ImportFileAsTexture2D_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ImportFileAsTexture2D_Filename_Offset), 0, ImportFileAsTexture2D_Filename_PropertyAddress.Address, Filename);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ImportFileAsTexture2D_FunctionAddress, intPtr, ImportFileAsTexture2D_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ImportFileAsTexture2D_Filename_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(intPtr, ImportFileAsTexture2D_ReturnValue_Offset), 0, ImportFileAsTexture2D_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443459u)]
	[UMetaPath("/Script/Engine.KismetRenderingLibrary:ImportBufferAsTexture2D")]
	public unsafe static UTexture2D ImportBufferAsTexture2D(UObject WorldContextObject, List<byte> Buffer)
	{
		if (!ImportBufferAsTexture2D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetRenderingLibrary:ImportBufferAsTexture2D");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ImportBufferAsTexture2D_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ImportBufferAsTexture2D_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ImportBufferAsTexture2D_WorldContextObject_Offset), 0, ImportBufferAsTexture2D_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		new TArrayCopyMarshaler<byte>(1, ImportBufferAsTexture2D_Buffer_PropertyAddress, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative).ToNative(IntPtr.Add(intPtr, ImportBufferAsTexture2D_Buffer_Offset), Buffer);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ImportBufferAsTexture2D_FunctionAddress, intPtr, ImportBufferAsTexture2D_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ImportBufferAsTexture2D_Buffer_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(intPtr, ImportBufferAsTexture2D_ReturnValue_Offset), 0, ImportBufferAsTexture2D_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249155u)]
	[UMetaPath("/Script/Engine.KismetRenderingLibrary:ExportTexture2D")]
	public unsafe static void ExportTexture2D(UObject WorldContextObject, UTexture2D Texture, string FilePath, string FileName)
	{
		if (!ExportTexture2D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetRenderingLibrary:ExportTexture2D");
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

	[UFunction(Flags = 67249155u)]
	[UMetaPath("/Script/Engine.KismetRenderingLibrary:ExportRenderTarget")]
	public unsafe static void ExportRenderTarget(UObject WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, string FilePath, string FileName)
	{
		if (!ExportRenderTarget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetRenderingLibrary:ExportRenderTarget");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExportRenderTarget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExportRenderTarget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ExportRenderTarget_WorldContextObject_Offset), 0, ExportRenderTarget_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(intPtr, ExportRenderTarget_TextureRenderTarget_Offset), 0, ExportRenderTarget_TextureRenderTarget_PropertyAddress.Address, TextureRenderTarget);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ExportRenderTarget_FilePath_Offset), 0, ExportRenderTarget_FilePath_PropertyAddress.Address, FilePath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ExportRenderTarget_FileName_Offset), 0, ExportRenderTarget_FileName_PropertyAddress.Address, FileName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ExportRenderTarget_FunctionAddress, intPtr, ExportRenderTarget_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ExportRenderTarget_FilePath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ExportRenderTarget_FileName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443459u)]
	[UMetaPath("/Script/Engine.KismetRenderingLibrary:EndDrawCanvasToRenderTarget")]
	public unsafe static void EndDrawCanvasToRenderTarget(UObject WorldContextObject, FDrawToRenderTargetContext Context)
	{
		if (!EndDrawCanvasToRenderTarget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetRenderingLibrary:EndDrawCanvasToRenderTarget");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EndDrawCanvasToRenderTarget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EndDrawCanvasToRenderTarget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, EndDrawCanvasToRenderTarget_WorldContextObject_Offset), 0, EndDrawCanvasToRenderTarget_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InitializeValue_InContainer(EndDrawCanvasToRenderTarget_Context_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FDrawToRenderTargetContext>.ToNative(IntPtr.Add(intPtr, EndDrawCanvasToRenderTarget_Context_Offset), 0, EndDrawCanvasToRenderTarget_Context_PropertyAddress.Address, Context);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EndDrawCanvasToRenderTarget_FunctionAddress, intPtr, EndDrawCanvasToRenderTarget_ParamsSize);
	}

	[UFunction(Flags = 67249155u)]
	[UMetaPath("/Script/Engine.KismetRenderingLibrary:DrawMaterialToRenderTarget")]
	public unsafe static void DrawMaterialToRenderTarget(UObject WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, UMaterialInterface Material)
	{
		if (!DrawMaterialToRenderTarget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetRenderingLibrary:DrawMaterialToRenderTarget");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawMaterialToRenderTarget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawMaterialToRenderTarget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, DrawMaterialToRenderTarget_WorldContextObject_Offset), 0, DrawMaterialToRenderTarget_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(intPtr, DrawMaterialToRenderTarget_TextureRenderTarget_Offset), 0, DrawMaterialToRenderTarget_TextureRenderTarget_PropertyAddress.Address, TextureRenderTarget);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, DrawMaterialToRenderTarget_Material_Offset), 0, DrawMaterialToRenderTarget_Material_PropertyAddress.Address, Material);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DrawMaterialToRenderTarget_FunctionAddress, intPtr, DrawMaterialToRenderTarget_ParamsSize);
	}

	[UFunction(Flags = 75637763u)]
	[UMetaPath("/Script/Engine.KismetRenderingLibrary:CreateRenderTargetVolume")]
	public unsafe static UTextureRenderTargetVolume CreateRenderTargetVolume(UObject WorldContextObject, int Width, int Height, int Depth, ETextureRenderTargetFormat Format, FLinearColor ClearColor, bool bAutoGenerateMipMaps)
	{
		if (!CreateRenderTargetVolume_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetRenderingLibrary:CreateRenderTargetVolume");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateRenderTargetVolume_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateRenderTargetVolume_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CreateRenderTargetVolume_WorldContextObject_Offset), 0, CreateRenderTargetVolume_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CreateRenderTargetVolume_Width_Offset), 0, CreateRenderTargetVolume_Width_PropertyAddress.Address, Width);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CreateRenderTargetVolume_Height_Offset), 0, CreateRenderTargetVolume_Height_PropertyAddress.Address, Height);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CreateRenderTargetVolume_Depth_Offset), 0, CreateRenderTargetVolume_Depth_PropertyAddress.Address, Depth);
		EnumMarshaler<ETextureRenderTargetFormat>.ToNative(IntPtr.Add(intPtr, CreateRenderTargetVolume_Format_Offset), 0, CreateRenderTargetVolume_Format_PropertyAddress.Address, Format);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, CreateRenderTargetVolume_ClearColor_Offset), 0, CreateRenderTargetVolume_ClearColor_PropertyAddress.Address, ClearColor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateRenderTargetVolume_bAutoGenerateMipMaps_Offset), 0, CreateRenderTargetVolume_bAutoGenerateMipMaps_PropertyAddress.Address, bAutoGenerateMipMaps);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateRenderTargetVolume_FunctionAddress, intPtr, CreateRenderTargetVolume_ParamsSize);
		return UObjectMarshaler<UTextureRenderTargetVolume>.FromNative(IntPtr.Add(intPtr, CreateRenderTargetVolume_ReturnValue_Offset), 0, CreateRenderTargetVolume_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637763u)]
	[UMetaPath("/Script/Engine.KismetRenderingLibrary:CreateRenderTarget2DArray")]
	public unsafe static UTextureRenderTarget2DArray CreateRenderTarget2DArray(UObject WorldContextObject, int Width, int Height, int Slices, ETextureRenderTargetFormat Format, FLinearColor ClearColor, bool bAutoGenerateMipMaps)
	{
		if (!CreateRenderTarget2DArray_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetRenderingLibrary:CreateRenderTarget2DArray");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateRenderTarget2DArray_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateRenderTarget2DArray_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CreateRenderTarget2DArray_WorldContextObject_Offset), 0, CreateRenderTarget2DArray_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CreateRenderTarget2DArray_Width_Offset), 0, CreateRenderTarget2DArray_Width_PropertyAddress.Address, Width);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CreateRenderTarget2DArray_Height_Offset), 0, CreateRenderTarget2DArray_Height_PropertyAddress.Address, Height);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CreateRenderTarget2DArray_Slices_Offset), 0, CreateRenderTarget2DArray_Slices_PropertyAddress.Address, Slices);
		EnumMarshaler<ETextureRenderTargetFormat>.ToNative(IntPtr.Add(intPtr, CreateRenderTarget2DArray_Format_Offset), 0, CreateRenderTarget2DArray_Format_PropertyAddress.Address, Format);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, CreateRenderTarget2DArray_ClearColor_Offset), 0, CreateRenderTarget2DArray_ClearColor_PropertyAddress.Address, ClearColor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateRenderTarget2DArray_bAutoGenerateMipMaps_Offset), 0, CreateRenderTarget2DArray_bAutoGenerateMipMaps_PropertyAddress.Address, bAutoGenerateMipMaps);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateRenderTarget2DArray_FunctionAddress, intPtr, CreateRenderTarget2DArray_ParamsSize);
		return UObjectMarshaler<UTextureRenderTarget2DArray>.FromNative(IntPtr.Add(intPtr, CreateRenderTarget2DArray_ReturnValue_Offset), 0, CreateRenderTarget2DArray_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637763u)]
	[UMetaPath("/Script/Engine.KismetRenderingLibrary:CreateRenderTarget2D")]
	public unsafe static UTextureRenderTarget2D CreateRenderTarget2D(UObject WorldContextObject, int Width, int Height, ETextureRenderTargetFormat Format, FLinearColor ClearColor, bool bAutoGenerateMipMaps)
	{
		if (!CreateRenderTarget2D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetRenderingLibrary:CreateRenderTarget2D");
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
		EnumMarshaler<ETextureRenderTargetFormat>.ToNative(IntPtr.Add(intPtr, CreateRenderTarget2D_Format_Offset), 0, CreateRenderTarget2D_Format_PropertyAddress.Address, Format);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, CreateRenderTarget2D_ClearColor_Offset), 0, CreateRenderTarget2D_ClearColor_PropertyAddress.Address, ClearColor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateRenderTarget2D_bAutoGenerateMipMaps_Offset), 0, CreateRenderTarget2D_bAutoGenerateMipMaps_PropertyAddress.Address, bAutoGenerateMipMaps);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateRenderTarget2D_FunctionAddress, intPtr, CreateRenderTarget2D_ParamsSize);
		return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(intPtr, CreateRenderTarget2D_ReturnValue_Offset), 0, CreateRenderTarget2D_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249155u)]
	[UMetaPath("/Script/Engine.KismetRenderingLibrary:ConvertRenderTargetToTexture2DEditorOnly")]
	public unsafe static void ConvertRenderTargetToTexture2DEditorOnly(UObject WorldContextObject, UTextureRenderTarget2D RenderTarget, UTexture2D Texture)
	{
		if (!ConvertRenderTargetToTexture2DEditorOnly_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetRenderingLibrary:ConvertRenderTargetToTexture2DEditorOnly");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertRenderTargetToTexture2DEditorOnly_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertRenderTargetToTexture2DEditorOnly_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ConvertRenderTargetToTexture2DEditorOnly_WorldContextObject_Offset), 0, ConvertRenderTargetToTexture2DEditorOnly_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(intPtr, ConvertRenderTargetToTexture2DEditorOnly_RenderTarget_Offset), 0, ConvertRenderTargetToTexture2DEditorOnly_RenderTarget_PropertyAddress.Address, RenderTarget);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(intPtr, ConvertRenderTargetToTexture2DEditorOnly_Texture_Offset), 0, ConvertRenderTargetToTexture2DEditorOnly_Texture_PropertyAddress.Address, Texture);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertRenderTargetToTexture2DEditorOnly_FunctionAddress, intPtr, ConvertRenderTargetToTexture2DEditorOnly_ParamsSize);
	}

	[UFunction(Flags = 75637763u)]
	[UMetaPath("/Script/Engine.KismetRenderingLibrary:ClearRenderTarget2D")]
	public unsafe static void ClearRenderTarget2D(UObject WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, FLinearColor ClearColor)
	{
		if (!ClearRenderTarget2D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetRenderingLibrary:ClearRenderTarget2D");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearRenderTarget2D_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearRenderTarget2D_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ClearRenderTarget2D_WorldContextObject_Offset), 0, ClearRenderTarget2D_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(intPtr, ClearRenderTarget2D_TextureRenderTarget_Offset), 0, ClearRenderTarget2D_TextureRenderTarget_PropertyAddress.Address, TextureRenderTarget);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, ClearRenderTarget2D_ClearColor_Offset), 0, ClearRenderTarget2D_ClearColor_PropertyAddress.Address, ClearColor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ClearRenderTarget2D_FunctionAddress, intPtr, ClearRenderTarget2D_ParamsSize);
	}

	[UFunction(Flags = 348267523u)]
	[UMetaPath("/Script/Engine.KismetRenderingLibrary:CalculateProjectionMatrix")]
	public unsafe static FMatrix CalculateProjectionMatrix(FMinimalViewInfo MinimalViewInfo)
	{
		if (!CalculateProjectionMatrix_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetRenderingLibrary:CalculateProjectionMatrix");
			return default(FMatrix);
		}
		byte* ptr = stackalloc byte[(int)(uint)(CalculateProjectionMatrix_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CalculateProjectionMatrix_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CalculateProjectionMatrix_MinimalViewInfo_PropertyAddress.Address, intPtr);
		FMinimalViewInfo.ToNative(IntPtr.Add(intPtr, CalculateProjectionMatrix_MinimalViewInfo_Offset), 0, CalculateProjectionMatrix_MinimalViewInfo_PropertyAddress.Address, MinimalViewInfo);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CalculateProjectionMatrix_FunctionAddress, intPtr, CalculateProjectionMatrix_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CalculateProjectionMatrix_MinimalViewInfo_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FMatrix>.FromNative(IntPtr.Add(intPtr, CalculateProjectionMatrix_ReturnValue_Offset), 0, CalculateProjectionMatrix_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878915u)]
	[UMetaPath("/Script/Engine.KismetRenderingLibrary:BreakSkinWeightInfo")]
	public unsafe static void BreakSkinWeightInfo(FSkelMeshSkinWeightInfo InWeight, out int Bone0, out byte Weight0, out int Bone1, out byte Weight1, out int Bone2, out byte Weight2, out int Bone3, out byte Weight3)
	{
		if (!BreakSkinWeightInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetRenderingLibrary:BreakSkinWeightInfo");
			Bone0 = 0;
			Weight0 = 0;
			Bone1 = 0;
			Weight1 = 0;
			Bone2 = 0;
			Weight2 = 0;
			Bone3 = 0;
			Weight3 = 0;
		}
		else
		{
			byte* ptr = stackalloc byte[(int)(uint)(BreakSkinWeightInfo_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BreakSkinWeightInfo_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(BreakSkinWeightInfo_InWeight_PropertyAddress.Address, intPtr);
			FSkelMeshSkinWeightInfo.ToNative(IntPtr.Add(intPtr, BreakSkinWeightInfo_InWeight_Offset), 0, BreakSkinWeightInfo_InWeight_PropertyAddress.Address, InWeight);
			NativeReflection.InvokeStaticFunctionOptimized(classAddress, BreakSkinWeightInfo_FunctionAddress, intPtr, BreakSkinWeightInfo_ParamsSize);
			Bone0 = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, BreakSkinWeightInfo_Bone0_Offset), 0, BreakSkinWeightInfo_Bone0_PropertyAddress.Address);
			Weight0 = BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(intPtr, BreakSkinWeightInfo_Weight0_Offset), 0, BreakSkinWeightInfo_Weight0_PropertyAddress.Address);
			Bone1 = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, BreakSkinWeightInfo_Bone1_Offset), 0, BreakSkinWeightInfo_Bone1_PropertyAddress.Address);
			Weight1 = BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(intPtr, BreakSkinWeightInfo_Weight1_Offset), 0, BreakSkinWeightInfo_Weight1_PropertyAddress.Address);
			Bone2 = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, BreakSkinWeightInfo_Bone2_Offset), 0, BreakSkinWeightInfo_Bone2_PropertyAddress.Address);
			Weight2 = BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(intPtr, BreakSkinWeightInfo_Weight2_Offset), 0, BreakSkinWeightInfo_Weight2_PropertyAddress.Address);
			Bone3 = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, BreakSkinWeightInfo_Bone3_Offset), 0, BreakSkinWeightInfo_Bone3_PropertyAddress.Address);
			Weight3 = BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(intPtr, BreakSkinWeightInfo_Weight3_Offset), 0, BreakSkinWeightInfo_Weight3_PropertyAddress.Address);
		}
	}

	[UFunction(Flags = 79832067u)]
	[UMetaPath("/Script/Engine.KismetRenderingLibrary:BeginDrawCanvasToRenderTarget")]
	public unsafe static void BeginDrawCanvasToRenderTarget(UObject WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, out UCanvas Canvas, out FVector2D Size, out FDrawToRenderTargetContext Context)
	{
		if (!BeginDrawCanvasToRenderTarget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetRenderingLibrary:BeginDrawCanvasToRenderTarget");
			Canvas = null;
			Size = default(FVector2D);
			Context = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BeginDrawCanvasToRenderTarget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BeginDrawCanvasToRenderTarget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BeginDrawCanvasToRenderTarget_WorldContextObject_Offset), 0, BeginDrawCanvasToRenderTarget_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(intPtr, BeginDrawCanvasToRenderTarget_TextureRenderTarget_Offset), 0, BeginDrawCanvasToRenderTarget_TextureRenderTarget_PropertyAddress.Address, TextureRenderTarget);
		NativeReflection.InitializeValue_InContainer(BeginDrawCanvasToRenderTarget_Context_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BeginDrawCanvasToRenderTarget_FunctionAddress, intPtr, BeginDrawCanvasToRenderTarget_ParamsSize);
		Canvas = UObjectMarshaler<UCanvas>.FromNative(IntPtr.Add(intPtr, BeginDrawCanvasToRenderTarget_Canvas_Offset), 0, BeginDrawCanvasToRenderTarget_Canvas_PropertyAddress.Address);
		Size = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, BeginDrawCanvasToRenderTarget_Size_Offset), 0, BeginDrawCanvasToRenderTarget_Size_PropertyAddress.Address);
		Context = StructAsClassMarshaler<FDrawToRenderTargetContext>.FromNative(IntPtr.Add(intPtr, BeginDrawCanvasToRenderTarget_Context_Offset), 0, BeginDrawCanvasToRenderTarget_Context_PropertyAddress.Address);
	}

	static URenderingLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(URenderingLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(URenderingLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.KismetRenderingLibrary");
		SetCastInsetShadowForAllAttachments_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetCastInsetShadowForAllAttachments");
		SetCastInsetShadowForAllAttachments_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCastInsetShadowForAllAttachments_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCastInsetShadowForAllAttachments_PrimitiveComponent_PropertyAddress, SetCastInsetShadowForAllAttachments_FunctionAddress, "PrimitiveComponent");
		SetCastInsetShadowForAllAttachments_PrimitiveComponent_Offset = NativeReflectionCached.GetPropertyOffset(SetCastInsetShadowForAllAttachments_FunctionAddress, "PrimitiveComponent");
		SetCastInsetShadowForAllAttachments_PrimitiveComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCastInsetShadowForAllAttachments_FunctionAddress, "PrimitiveComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCastInsetShadowForAllAttachments_bCastInsetShadow_PropertyAddress, SetCastInsetShadowForAllAttachments_FunctionAddress, "bCastInsetShadow");
		SetCastInsetShadowForAllAttachments_bCastInsetShadow_Offset = NativeReflectionCached.GetPropertyOffset(SetCastInsetShadowForAllAttachments_FunctionAddress, "bCastInsetShadow");
		SetCastInsetShadowForAllAttachments_bCastInsetShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCastInsetShadowForAllAttachments_FunctionAddress, "bCastInsetShadow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCastInsetShadowForAllAttachments_bLightAttachmentsAsGroup_PropertyAddress, SetCastInsetShadowForAllAttachments_FunctionAddress, "bLightAttachmentsAsGroup");
		SetCastInsetShadowForAllAttachments_bLightAttachmentsAsGroup_Offset = NativeReflectionCached.GetPropertyOffset(SetCastInsetShadowForAllAttachments_FunctionAddress, "bLightAttachmentsAsGroup");
		SetCastInsetShadowForAllAttachments_bLightAttachmentsAsGroup_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCastInsetShadowForAllAttachments_FunctionAddress, "bLightAttachmentsAsGroup", Classes.FBoolProperty);
		SetCastInsetShadowForAllAttachments_IsValid = SetCastInsetShadowForAllAttachments_FunctionAddress != IntPtr.Zero && SetCastInsetShadowForAllAttachments_PrimitiveComponent_IsValid && SetCastInsetShadowForAllAttachments_bCastInsetShadow_IsValid && SetCastInsetShadowForAllAttachments_bLightAttachmentsAsGroup_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetRenderingLibrary:SetCastInsetShadowForAllAttachments", SetCastInsetShadowForAllAttachments_IsValid);
		RenderTargetCreateStaticTexture2DEditorOnly_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RenderTargetCreateStaticTexture2DEditorOnly");
		RenderTargetCreateStaticTexture2DEditorOnly_ParamsSize = NativeReflection.GetFunctionParamsSize(RenderTargetCreateStaticTexture2DEditorOnly_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RenderTargetCreateStaticTexture2DEditorOnly_RenderTarget_PropertyAddress, RenderTargetCreateStaticTexture2DEditorOnly_FunctionAddress, "RenderTarget");
		RenderTargetCreateStaticTexture2DEditorOnly_RenderTarget_Offset = NativeReflectionCached.GetPropertyOffset(RenderTargetCreateStaticTexture2DEditorOnly_FunctionAddress, "RenderTarget");
		RenderTargetCreateStaticTexture2DEditorOnly_RenderTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(RenderTargetCreateStaticTexture2DEditorOnly_FunctionAddress, "RenderTarget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RenderTargetCreateStaticTexture2DEditorOnly_Name_PropertyAddress, RenderTargetCreateStaticTexture2DEditorOnly_FunctionAddress, "Name");
		RenderTargetCreateStaticTexture2DEditorOnly_Name_Offset = NativeReflectionCached.GetPropertyOffset(RenderTargetCreateStaticTexture2DEditorOnly_FunctionAddress, "Name");
		RenderTargetCreateStaticTexture2DEditorOnly_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(RenderTargetCreateStaticTexture2DEditorOnly_FunctionAddress, "Name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RenderTargetCreateStaticTexture2DEditorOnly_CompressionSettings_PropertyAddress, RenderTargetCreateStaticTexture2DEditorOnly_FunctionAddress, "CompressionSettings");
		RenderTargetCreateStaticTexture2DEditorOnly_CompressionSettings_Offset = NativeReflectionCached.GetPropertyOffset(RenderTargetCreateStaticTexture2DEditorOnly_FunctionAddress, "CompressionSettings");
		RenderTargetCreateStaticTexture2DEditorOnly_CompressionSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(RenderTargetCreateStaticTexture2DEditorOnly_FunctionAddress, "CompressionSettings", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref RenderTargetCreateStaticTexture2DEditorOnly_MipSettings_PropertyAddress, RenderTargetCreateStaticTexture2DEditorOnly_FunctionAddress, "MipSettings");
		RenderTargetCreateStaticTexture2DEditorOnly_MipSettings_Offset = NativeReflectionCached.GetPropertyOffset(RenderTargetCreateStaticTexture2DEditorOnly_FunctionAddress, "MipSettings");
		RenderTargetCreateStaticTexture2DEditorOnly_MipSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(RenderTargetCreateStaticTexture2DEditorOnly_FunctionAddress, "MipSettings", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref RenderTargetCreateStaticTexture2DEditorOnly_ReturnValue_PropertyAddress, RenderTargetCreateStaticTexture2DEditorOnly_FunctionAddress, "ReturnValue");
		RenderTargetCreateStaticTexture2DEditorOnly_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RenderTargetCreateStaticTexture2DEditorOnly_FunctionAddress, "ReturnValue");
		RenderTargetCreateStaticTexture2DEditorOnly_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RenderTargetCreateStaticTexture2DEditorOnly_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		RenderTargetCreateStaticTexture2DEditorOnly_IsValid = RenderTargetCreateStaticTexture2DEditorOnly_FunctionAddress != IntPtr.Zero && RenderTargetCreateStaticTexture2DEditorOnly_RenderTarget_IsValid && RenderTargetCreateStaticTexture2DEditorOnly_Name_IsValid && RenderTargetCreateStaticTexture2DEditorOnly_CompressionSettings_IsValid && RenderTargetCreateStaticTexture2DEditorOnly_MipSettings_IsValid && RenderTargetCreateStaticTexture2DEditorOnly_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetRenderingLibrary:RenderTargetCreateStaticTexture2DEditorOnly", RenderTargetCreateStaticTexture2DEditorOnly_IsValid);
		ReleaseRenderTarget2D_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReleaseRenderTarget2D");
		ReleaseRenderTarget2D_ParamsSize = NativeReflection.GetFunctionParamsSize(ReleaseRenderTarget2D_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReleaseRenderTarget2D_TextureRenderTarget_PropertyAddress, ReleaseRenderTarget2D_FunctionAddress, "TextureRenderTarget");
		ReleaseRenderTarget2D_TextureRenderTarget_Offset = NativeReflectionCached.GetPropertyOffset(ReleaseRenderTarget2D_FunctionAddress, "TextureRenderTarget");
		ReleaseRenderTarget2D_TextureRenderTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(ReleaseRenderTarget2D_FunctionAddress, "TextureRenderTarget", Classes.FObjectProperty);
		ReleaseRenderTarget2D_IsValid = ReleaseRenderTarget2D_FunctionAddress != IntPtr.Zero && ReleaseRenderTarget2D_TextureRenderTarget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetRenderingLibrary:ReleaseRenderTarget2D", ReleaseRenderTarget2D_IsValid);
		ReadRenderTargetUV_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReadRenderTargetUV");
		ReadRenderTargetUV_ParamsSize = NativeReflection.GetFunctionParamsSize(ReadRenderTargetUV_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTargetUV_WorldContextObject_PropertyAddress, ReadRenderTargetUV_FunctionAddress, "WorldContextObject");
		ReadRenderTargetUV_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTargetUV_FunctionAddress, "WorldContextObject");
		ReadRenderTargetUV_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTargetUV_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTargetUV_TextureRenderTarget_PropertyAddress, ReadRenderTargetUV_FunctionAddress, "TextureRenderTarget");
		ReadRenderTargetUV_TextureRenderTarget_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTargetUV_FunctionAddress, "TextureRenderTarget");
		ReadRenderTargetUV_TextureRenderTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTargetUV_FunctionAddress, "TextureRenderTarget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTargetUV_U_PropertyAddress, ReadRenderTargetUV_FunctionAddress, "U");
		ReadRenderTargetUV_U_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTargetUV_FunctionAddress, "U");
		ReadRenderTargetUV_U_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTargetUV_FunctionAddress, "U", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTargetUV_V_PropertyAddress, ReadRenderTargetUV_FunctionAddress, "V");
		ReadRenderTargetUV_V_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTargetUV_FunctionAddress, "V");
		ReadRenderTargetUV_V_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTargetUV_FunctionAddress, "V", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTargetUV_ReturnValue_PropertyAddress, ReadRenderTargetUV_FunctionAddress, "ReturnValue");
		ReadRenderTargetUV_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTargetUV_FunctionAddress, "ReturnValue");
		ReadRenderTargetUV_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTargetUV_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		ReadRenderTargetUV_IsValid = ReadRenderTargetUV_FunctionAddress != IntPtr.Zero && ReadRenderTargetUV_WorldContextObject_IsValid && ReadRenderTargetUV_TextureRenderTarget_IsValid && ReadRenderTargetUV_U_IsValid && ReadRenderTargetUV_V_IsValid && ReadRenderTargetUV_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetRenderingLibrary:ReadRenderTargetUV", ReadRenderTargetUV_IsValid);
		ReadRenderTargetRawUVArea_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReadRenderTargetRawUVArea");
		ReadRenderTargetRawUVArea_ParamsSize = NativeReflection.GetFunctionParamsSize(ReadRenderTargetRawUVArea_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTargetRawUVArea_WorldContextObject_PropertyAddress, ReadRenderTargetRawUVArea_FunctionAddress, "WorldContextObject");
		ReadRenderTargetRawUVArea_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTargetRawUVArea_FunctionAddress, "WorldContextObject");
		ReadRenderTargetRawUVArea_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTargetRawUVArea_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTargetRawUVArea_TextureRenderTarget_PropertyAddress, ReadRenderTargetRawUVArea_FunctionAddress, "TextureRenderTarget");
		ReadRenderTargetRawUVArea_TextureRenderTarget_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTargetRawUVArea_FunctionAddress, "TextureRenderTarget");
		ReadRenderTargetRawUVArea_TextureRenderTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTargetRawUVArea_FunctionAddress, "TextureRenderTarget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTargetRawUVArea_Area_PropertyAddress, ReadRenderTargetRawUVArea_FunctionAddress, "Area");
		ReadRenderTargetRawUVArea_Area_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTargetRawUVArea_FunctionAddress, "Area");
		ReadRenderTargetRawUVArea_Area_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTargetRawUVArea_FunctionAddress, "Area", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTargetRawUVArea_bNormalize_PropertyAddress, ReadRenderTargetRawUVArea_FunctionAddress, "bNormalize");
		ReadRenderTargetRawUVArea_bNormalize_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTargetRawUVArea_FunctionAddress, "bNormalize");
		ReadRenderTargetRawUVArea_bNormalize_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTargetRawUVArea_FunctionAddress, "bNormalize", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTargetRawUVArea_ReturnValue_PropertyAddress, ReadRenderTargetRawUVArea_FunctionAddress, "ReturnValue");
		ReadRenderTargetRawUVArea_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTargetRawUVArea_FunctionAddress, "ReturnValue");
		ReadRenderTargetRawUVArea_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTargetRawUVArea_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		ReadRenderTargetRawUVArea_IsValid = ReadRenderTargetRawUVArea_FunctionAddress != IntPtr.Zero && ReadRenderTargetRawUVArea_WorldContextObject_IsValid && ReadRenderTargetRawUVArea_TextureRenderTarget_IsValid && ReadRenderTargetRawUVArea_Area_IsValid && ReadRenderTargetRawUVArea_bNormalize_IsValid && ReadRenderTargetRawUVArea_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetRenderingLibrary:ReadRenderTargetRawUVArea", ReadRenderTargetRawUVArea_IsValid);
		ReadRenderTargetRawUV_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReadRenderTargetRawUV");
		ReadRenderTargetRawUV_ParamsSize = NativeReflection.GetFunctionParamsSize(ReadRenderTargetRawUV_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTargetRawUV_WorldContextObject_PropertyAddress, ReadRenderTargetRawUV_FunctionAddress, "WorldContextObject");
		ReadRenderTargetRawUV_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTargetRawUV_FunctionAddress, "WorldContextObject");
		ReadRenderTargetRawUV_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTargetRawUV_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTargetRawUV_TextureRenderTarget_PropertyAddress, ReadRenderTargetRawUV_FunctionAddress, "TextureRenderTarget");
		ReadRenderTargetRawUV_TextureRenderTarget_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTargetRawUV_FunctionAddress, "TextureRenderTarget");
		ReadRenderTargetRawUV_TextureRenderTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTargetRawUV_FunctionAddress, "TextureRenderTarget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTargetRawUV_U_PropertyAddress, ReadRenderTargetRawUV_FunctionAddress, "U");
		ReadRenderTargetRawUV_U_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTargetRawUV_FunctionAddress, "U");
		ReadRenderTargetRawUV_U_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTargetRawUV_FunctionAddress, "U", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTargetRawUV_V_PropertyAddress, ReadRenderTargetRawUV_FunctionAddress, "V");
		ReadRenderTargetRawUV_V_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTargetRawUV_FunctionAddress, "V");
		ReadRenderTargetRawUV_V_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTargetRawUV_FunctionAddress, "V", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTargetRawUV_bNormalize_PropertyAddress, ReadRenderTargetRawUV_FunctionAddress, "bNormalize");
		ReadRenderTargetRawUV_bNormalize_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTargetRawUV_FunctionAddress, "bNormalize");
		ReadRenderTargetRawUV_bNormalize_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTargetRawUV_FunctionAddress, "bNormalize", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTargetRawUV_ReturnValue_PropertyAddress, ReadRenderTargetRawUV_FunctionAddress, "ReturnValue");
		ReadRenderTargetRawUV_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTargetRawUV_FunctionAddress, "ReturnValue");
		ReadRenderTargetRawUV_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTargetRawUV_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		ReadRenderTargetRawUV_IsValid = ReadRenderTargetRawUV_FunctionAddress != IntPtr.Zero && ReadRenderTargetRawUV_WorldContextObject_IsValid && ReadRenderTargetRawUV_TextureRenderTarget_IsValid && ReadRenderTargetRawUV_U_IsValid && ReadRenderTargetRawUV_V_IsValid && ReadRenderTargetRawUV_bNormalize_IsValid && ReadRenderTargetRawUV_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetRenderingLibrary:ReadRenderTargetRawUV", ReadRenderTargetRawUV_IsValid);
		ReadRenderTargetRawPixelArea_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReadRenderTargetRawPixelArea");
		ReadRenderTargetRawPixelArea_ParamsSize = NativeReflection.GetFunctionParamsSize(ReadRenderTargetRawPixelArea_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTargetRawPixelArea_WorldContextObject_PropertyAddress, ReadRenderTargetRawPixelArea_FunctionAddress, "WorldContextObject");
		ReadRenderTargetRawPixelArea_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTargetRawPixelArea_FunctionAddress, "WorldContextObject");
		ReadRenderTargetRawPixelArea_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTargetRawPixelArea_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTargetRawPixelArea_TextureRenderTarget_PropertyAddress, ReadRenderTargetRawPixelArea_FunctionAddress, "TextureRenderTarget");
		ReadRenderTargetRawPixelArea_TextureRenderTarget_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTargetRawPixelArea_FunctionAddress, "TextureRenderTarget");
		ReadRenderTargetRawPixelArea_TextureRenderTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTargetRawPixelArea_FunctionAddress, "TextureRenderTarget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTargetRawPixelArea_MinX_PropertyAddress, ReadRenderTargetRawPixelArea_FunctionAddress, "MinX");
		ReadRenderTargetRawPixelArea_MinX_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTargetRawPixelArea_FunctionAddress, "MinX");
		ReadRenderTargetRawPixelArea_MinX_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTargetRawPixelArea_FunctionAddress, "MinX", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTargetRawPixelArea_MinY_PropertyAddress, ReadRenderTargetRawPixelArea_FunctionAddress, "MinY");
		ReadRenderTargetRawPixelArea_MinY_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTargetRawPixelArea_FunctionAddress, "MinY");
		ReadRenderTargetRawPixelArea_MinY_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTargetRawPixelArea_FunctionAddress, "MinY", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTargetRawPixelArea_MaxX_PropertyAddress, ReadRenderTargetRawPixelArea_FunctionAddress, "MaxX");
		ReadRenderTargetRawPixelArea_MaxX_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTargetRawPixelArea_FunctionAddress, "MaxX");
		ReadRenderTargetRawPixelArea_MaxX_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTargetRawPixelArea_FunctionAddress, "MaxX", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTargetRawPixelArea_MaxY_PropertyAddress, ReadRenderTargetRawPixelArea_FunctionAddress, "MaxY");
		ReadRenderTargetRawPixelArea_MaxY_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTargetRawPixelArea_FunctionAddress, "MaxY");
		ReadRenderTargetRawPixelArea_MaxY_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTargetRawPixelArea_FunctionAddress, "MaxY", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTargetRawPixelArea_bNormalize_PropertyAddress, ReadRenderTargetRawPixelArea_FunctionAddress, "bNormalize");
		ReadRenderTargetRawPixelArea_bNormalize_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTargetRawPixelArea_FunctionAddress, "bNormalize");
		ReadRenderTargetRawPixelArea_bNormalize_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTargetRawPixelArea_FunctionAddress, "bNormalize", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTargetRawPixelArea_ReturnValue_PropertyAddress, ReadRenderTargetRawPixelArea_FunctionAddress, "ReturnValue");
		ReadRenderTargetRawPixelArea_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTargetRawPixelArea_FunctionAddress, "ReturnValue");
		ReadRenderTargetRawPixelArea_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTargetRawPixelArea_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		ReadRenderTargetRawPixelArea_IsValid = ReadRenderTargetRawPixelArea_FunctionAddress != IntPtr.Zero && ReadRenderTargetRawPixelArea_WorldContextObject_IsValid && ReadRenderTargetRawPixelArea_TextureRenderTarget_IsValid && ReadRenderTargetRawPixelArea_MinX_IsValid && ReadRenderTargetRawPixelArea_MinY_IsValid && ReadRenderTargetRawPixelArea_MaxX_IsValid && ReadRenderTargetRawPixelArea_MaxY_IsValid && ReadRenderTargetRawPixelArea_bNormalize_IsValid && ReadRenderTargetRawPixelArea_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetRenderingLibrary:ReadRenderTargetRawPixelArea", ReadRenderTargetRawPixelArea_IsValid);
		ReadRenderTargetRawPixel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReadRenderTargetRawPixel");
		ReadRenderTargetRawPixel_ParamsSize = NativeReflection.GetFunctionParamsSize(ReadRenderTargetRawPixel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTargetRawPixel_WorldContextObject_PropertyAddress, ReadRenderTargetRawPixel_FunctionAddress, "WorldContextObject");
		ReadRenderTargetRawPixel_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTargetRawPixel_FunctionAddress, "WorldContextObject");
		ReadRenderTargetRawPixel_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTargetRawPixel_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTargetRawPixel_TextureRenderTarget_PropertyAddress, ReadRenderTargetRawPixel_FunctionAddress, "TextureRenderTarget");
		ReadRenderTargetRawPixel_TextureRenderTarget_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTargetRawPixel_FunctionAddress, "TextureRenderTarget");
		ReadRenderTargetRawPixel_TextureRenderTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTargetRawPixel_FunctionAddress, "TextureRenderTarget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTargetRawPixel_X_PropertyAddress, ReadRenderTargetRawPixel_FunctionAddress, "X");
		ReadRenderTargetRawPixel_X_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTargetRawPixel_FunctionAddress, "X");
		ReadRenderTargetRawPixel_X_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTargetRawPixel_FunctionAddress, "X", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTargetRawPixel_Y_PropertyAddress, ReadRenderTargetRawPixel_FunctionAddress, "Y");
		ReadRenderTargetRawPixel_Y_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTargetRawPixel_FunctionAddress, "Y");
		ReadRenderTargetRawPixel_Y_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTargetRawPixel_FunctionAddress, "Y", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTargetRawPixel_bNormalize_PropertyAddress, ReadRenderTargetRawPixel_FunctionAddress, "bNormalize");
		ReadRenderTargetRawPixel_bNormalize_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTargetRawPixel_FunctionAddress, "bNormalize");
		ReadRenderTargetRawPixel_bNormalize_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTargetRawPixel_FunctionAddress, "bNormalize", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTargetRawPixel_ReturnValue_PropertyAddress, ReadRenderTargetRawPixel_FunctionAddress, "ReturnValue");
		ReadRenderTargetRawPixel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTargetRawPixel_FunctionAddress, "ReturnValue");
		ReadRenderTargetRawPixel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTargetRawPixel_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		ReadRenderTargetRawPixel_IsValid = ReadRenderTargetRawPixel_FunctionAddress != IntPtr.Zero && ReadRenderTargetRawPixel_WorldContextObject_IsValid && ReadRenderTargetRawPixel_TextureRenderTarget_IsValid && ReadRenderTargetRawPixel_X_IsValid && ReadRenderTargetRawPixel_Y_IsValid && ReadRenderTargetRawPixel_bNormalize_IsValid && ReadRenderTargetRawPixel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetRenderingLibrary:ReadRenderTargetRawPixel", ReadRenderTargetRawPixel_IsValid);
		ReadRenderTargetRaw_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReadRenderTargetRaw");
		ReadRenderTargetRaw_ParamsSize = NativeReflection.GetFunctionParamsSize(ReadRenderTargetRaw_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTargetRaw_WorldContextObject_PropertyAddress, ReadRenderTargetRaw_FunctionAddress, "WorldContextObject");
		ReadRenderTargetRaw_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTargetRaw_FunctionAddress, "WorldContextObject");
		ReadRenderTargetRaw_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTargetRaw_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTargetRaw_TextureRenderTarget_PropertyAddress, ReadRenderTargetRaw_FunctionAddress, "TextureRenderTarget");
		ReadRenderTargetRaw_TextureRenderTarget_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTargetRaw_FunctionAddress, "TextureRenderTarget");
		ReadRenderTargetRaw_TextureRenderTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTargetRaw_FunctionAddress, "TextureRenderTarget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTargetRaw_OutLinearSamples_PropertyAddress, ReadRenderTargetRaw_FunctionAddress, "OutLinearSamples");
		ReadRenderTargetRaw_OutLinearSamples_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTargetRaw_FunctionAddress, "OutLinearSamples");
		ReadRenderTargetRaw_OutLinearSamples_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTargetRaw_FunctionAddress, "OutLinearSamples", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTargetRaw_bNormalize_PropertyAddress, ReadRenderTargetRaw_FunctionAddress, "bNormalize");
		ReadRenderTargetRaw_bNormalize_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTargetRaw_FunctionAddress, "bNormalize");
		ReadRenderTargetRaw_bNormalize_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTargetRaw_FunctionAddress, "bNormalize", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTargetRaw_ReturnValue_PropertyAddress, ReadRenderTargetRaw_FunctionAddress, "ReturnValue");
		ReadRenderTargetRaw_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTargetRaw_FunctionAddress, "ReturnValue");
		ReadRenderTargetRaw_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTargetRaw_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ReadRenderTargetRaw_IsValid = ReadRenderTargetRaw_FunctionAddress != IntPtr.Zero && ReadRenderTargetRaw_WorldContextObject_IsValid && ReadRenderTargetRaw_TextureRenderTarget_IsValid && ReadRenderTargetRaw_OutLinearSamples_IsValid && ReadRenderTargetRaw_bNormalize_IsValid && ReadRenderTargetRaw_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetRenderingLibrary:ReadRenderTargetRaw", ReadRenderTargetRaw_IsValid);
		ReadRenderTargetPixel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReadRenderTargetPixel");
		ReadRenderTargetPixel_ParamsSize = NativeReflection.GetFunctionParamsSize(ReadRenderTargetPixel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTargetPixel_WorldContextObject_PropertyAddress, ReadRenderTargetPixel_FunctionAddress, "WorldContextObject");
		ReadRenderTargetPixel_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTargetPixel_FunctionAddress, "WorldContextObject");
		ReadRenderTargetPixel_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTargetPixel_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTargetPixel_TextureRenderTarget_PropertyAddress, ReadRenderTargetPixel_FunctionAddress, "TextureRenderTarget");
		ReadRenderTargetPixel_TextureRenderTarget_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTargetPixel_FunctionAddress, "TextureRenderTarget");
		ReadRenderTargetPixel_TextureRenderTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTargetPixel_FunctionAddress, "TextureRenderTarget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTargetPixel_X_PropertyAddress, ReadRenderTargetPixel_FunctionAddress, "X");
		ReadRenderTargetPixel_X_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTargetPixel_FunctionAddress, "X");
		ReadRenderTargetPixel_X_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTargetPixel_FunctionAddress, "X", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTargetPixel_Y_PropertyAddress, ReadRenderTargetPixel_FunctionAddress, "Y");
		ReadRenderTargetPixel_Y_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTargetPixel_FunctionAddress, "Y");
		ReadRenderTargetPixel_Y_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTargetPixel_FunctionAddress, "Y", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTargetPixel_ReturnValue_PropertyAddress, ReadRenderTargetPixel_FunctionAddress, "ReturnValue");
		ReadRenderTargetPixel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTargetPixel_FunctionAddress, "ReturnValue");
		ReadRenderTargetPixel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTargetPixel_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		ReadRenderTargetPixel_IsValid = ReadRenderTargetPixel_FunctionAddress != IntPtr.Zero && ReadRenderTargetPixel_WorldContextObject_IsValid && ReadRenderTargetPixel_TextureRenderTarget_IsValid && ReadRenderTargetPixel_X_IsValid && ReadRenderTargetPixel_Y_IsValid && ReadRenderTargetPixel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetRenderingLibrary:ReadRenderTargetPixel", ReadRenderTargetPixel_IsValid);
		ReadRenderTarget_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReadRenderTarget");
		ReadRenderTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(ReadRenderTarget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTarget_WorldContextObject_PropertyAddress, ReadRenderTarget_FunctionAddress, "WorldContextObject");
		ReadRenderTarget_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTarget_FunctionAddress, "WorldContextObject");
		ReadRenderTarget_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTarget_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTarget_TextureRenderTarget_PropertyAddress, ReadRenderTarget_FunctionAddress, "TextureRenderTarget");
		ReadRenderTarget_TextureRenderTarget_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTarget_FunctionAddress, "TextureRenderTarget");
		ReadRenderTarget_TextureRenderTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTarget_FunctionAddress, "TextureRenderTarget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTarget_OutSamples_PropertyAddress, ReadRenderTarget_FunctionAddress, "OutSamples");
		ReadRenderTarget_OutSamples_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTarget_FunctionAddress, "OutSamples");
		ReadRenderTarget_OutSamples_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTarget_FunctionAddress, "OutSamples", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTarget_bNormalize_PropertyAddress, ReadRenderTarget_FunctionAddress, "bNormalize");
		ReadRenderTarget_bNormalize_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTarget_FunctionAddress, "bNormalize");
		ReadRenderTarget_bNormalize_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTarget_FunctionAddress, "bNormalize", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadRenderTarget_ReturnValue_PropertyAddress, ReadRenderTarget_FunctionAddress, "ReturnValue");
		ReadRenderTarget_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ReadRenderTarget_FunctionAddress, "ReturnValue");
		ReadRenderTarget_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadRenderTarget_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ReadRenderTarget_IsValid = ReadRenderTarget_FunctionAddress != IntPtr.Zero && ReadRenderTarget_WorldContextObject_IsValid && ReadRenderTarget_TextureRenderTarget_IsValid && ReadRenderTarget_OutSamples_IsValid && ReadRenderTarget_bNormalize_IsValid && ReadRenderTarget_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetRenderingLibrary:ReadRenderTarget", ReadRenderTarget_IsValid);
		MakeSkinWeightInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakeSkinWeightInfo");
		MakeSkinWeightInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeSkinWeightInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeSkinWeightInfo_Bone0_PropertyAddress, MakeSkinWeightInfo_FunctionAddress, "Bone0");
		MakeSkinWeightInfo_Bone0_Offset = NativeReflectionCached.GetPropertyOffset(MakeSkinWeightInfo_FunctionAddress, "Bone0");
		MakeSkinWeightInfo_Bone0_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeSkinWeightInfo_FunctionAddress, "Bone0", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeSkinWeightInfo_Weight0_PropertyAddress, MakeSkinWeightInfo_FunctionAddress, "Weight0");
		MakeSkinWeightInfo_Weight0_Offset = NativeReflectionCached.GetPropertyOffset(MakeSkinWeightInfo_FunctionAddress, "Weight0");
		MakeSkinWeightInfo_Weight0_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeSkinWeightInfo_FunctionAddress, "Weight0", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeSkinWeightInfo_Bone1_PropertyAddress, MakeSkinWeightInfo_FunctionAddress, "Bone1");
		MakeSkinWeightInfo_Bone1_Offset = NativeReflectionCached.GetPropertyOffset(MakeSkinWeightInfo_FunctionAddress, "Bone1");
		MakeSkinWeightInfo_Bone1_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeSkinWeightInfo_FunctionAddress, "Bone1", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeSkinWeightInfo_Weight1_PropertyAddress, MakeSkinWeightInfo_FunctionAddress, "Weight1");
		MakeSkinWeightInfo_Weight1_Offset = NativeReflectionCached.GetPropertyOffset(MakeSkinWeightInfo_FunctionAddress, "Weight1");
		MakeSkinWeightInfo_Weight1_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeSkinWeightInfo_FunctionAddress, "Weight1", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeSkinWeightInfo_Bone2_PropertyAddress, MakeSkinWeightInfo_FunctionAddress, "Bone2");
		MakeSkinWeightInfo_Bone2_Offset = NativeReflectionCached.GetPropertyOffset(MakeSkinWeightInfo_FunctionAddress, "Bone2");
		MakeSkinWeightInfo_Bone2_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeSkinWeightInfo_FunctionAddress, "Bone2", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeSkinWeightInfo_Weight2_PropertyAddress, MakeSkinWeightInfo_FunctionAddress, "Weight2");
		MakeSkinWeightInfo_Weight2_Offset = NativeReflectionCached.GetPropertyOffset(MakeSkinWeightInfo_FunctionAddress, "Weight2");
		MakeSkinWeightInfo_Weight2_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeSkinWeightInfo_FunctionAddress, "Weight2", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeSkinWeightInfo_Bone3_PropertyAddress, MakeSkinWeightInfo_FunctionAddress, "Bone3");
		MakeSkinWeightInfo_Bone3_Offset = NativeReflectionCached.GetPropertyOffset(MakeSkinWeightInfo_FunctionAddress, "Bone3");
		MakeSkinWeightInfo_Bone3_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeSkinWeightInfo_FunctionAddress, "Bone3", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeSkinWeightInfo_Weight3_PropertyAddress, MakeSkinWeightInfo_FunctionAddress, "Weight3");
		MakeSkinWeightInfo_Weight3_Offset = NativeReflectionCached.GetPropertyOffset(MakeSkinWeightInfo_FunctionAddress, "Weight3");
		MakeSkinWeightInfo_Weight3_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeSkinWeightInfo_FunctionAddress, "Weight3", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeSkinWeightInfo_ReturnValue_PropertyAddress, MakeSkinWeightInfo_FunctionAddress, "ReturnValue");
		MakeSkinWeightInfo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeSkinWeightInfo_FunctionAddress, "ReturnValue");
		MakeSkinWeightInfo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeSkinWeightInfo_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		MakeSkinWeightInfo_IsValid = MakeSkinWeightInfo_FunctionAddress != IntPtr.Zero && MakeSkinWeightInfo_Bone0_IsValid && MakeSkinWeightInfo_Weight0_IsValid && MakeSkinWeightInfo_Bone1_IsValid && MakeSkinWeightInfo_Weight1_IsValid && MakeSkinWeightInfo_Bone2_IsValid && MakeSkinWeightInfo_Weight2_IsValid && MakeSkinWeightInfo_Bone3_IsValid && MakeSkinWeightInfo_Weight3_IsValid && MakeSkinWeightInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetRenderingLibrary:MakeSkinWeightInfo", MakeSkinWeightInfo_IsValid);
		ImportFileAsTexture2D_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ImportFileAsTexture2D");
		ImportFileAsTexture2D_ParamsSize = NativeReflection.GetFunctionParamsSize(ImportFileAsTexture2D_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ImportFileAsTexture2D_WorldContextObject_PropertyAddress, ImportFileAsTexture2D_FunctionAddress, "WorldContextObject");
		ImportFileAsTexture2D_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(ImportFileAsTexture2D_FunctionAddress, "WorldContextObject");
		ImportFileAsTexture2D_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportFileAsTexture2D_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportFileAsTexture2D_Filename_PropertyAddress, ImportFileAsTexture2D_FunctionAddress, "Filename");
		ImportFileAsTexture2D_Filename_Offset = NativeReflectionCached.GetPropertyOffset(ImportFileAsTexture2D_FunctionAddress, "Filename");
		ImportFileAsTexture2D_Filename_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportFileAsTexture2D_FunctionAddress, "Filename", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportFileAsTexture2D_ReturnValue_PropertyAddress, ImportFileAsTexture2D_FunctionAddress, "ReturnValue");
		ImportFileAsTexture2D_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ImportFileAsTexture2D_FunctionAddress, "ReturnValue");
		ImportFileAsTexture2D_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportFileAsTexture2D_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ImportFileAsTexture2D_IsValid = ImportFileAsTexture2D_FunctionAddress != IntPtr.Zero && ImportFileAsTexture2D_WorldContextObject_IsValid && ImportFileAsTexture2D_Filename_IsValid && ImportFileAsTexture2D_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetRenderingLibrary:ImportFileAsTexture2D", ImportFileAsTexture2D_IsValid);
		ImportBufferAsTexture2D_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ImportBufferAsTexture2D");
		ImportBufferAsTexture2D_ParamsSize = NativeReflection.GetFunctionParamsSize(ImportBufferAsTexture2D_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ImportBufferAsTexture2D_WorldContextObject_PropertyAddress, ImportBufferAsTexture2D_FunctionAddress, "WorldContextObject");
		ImportBufferAsTexture2D_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(ImportBufferAsTexture2D_FunctionAddress, "WorldContextObject");
		ImportBufferAsTexture2D_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportBufferAsTexture2D_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportBufferAsTexture2D_Buffer_PropertyAddress, ImportBufferAsTexture2D_FunctionAddress, "Buffer");
		ImportBufferAsTexture2D_Buffer_Offset = NativeReflectionCached.GetPropertyOffset(ImportBufferAsTexture2D_FunctionAddress, "Buffer");
		ImportBufferAsTexture2D_Buffer_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportBufferAsTexture2D_FunctionAddress, "Buffer", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportBufferAsTexture2D_ReturnValue_PropertyAddress, ImportBufferAsTexture2D_FunctionAddress, "ReturnValue");
		ImportBufferAsTexture2D_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ImportBufferAsTexture2D_FunctionAddress, "ReturnValue");
		ImportBufferAsTexture2D_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportBufferAsTexture2D_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ImportBufferAsTexture2D_IsValid = ImportBufferAsTexture2D_FunctionAddress != IntPtr.Zero && ImportBufferAsTexture2D_WorldContextObject_IsValid && ImportBufferAsTexture2D_Buffer_IsValid && ImportBufferAsTexture2D_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetRenderingLibrary:ImportBufferAsTexture2D", ImportBufferAsTexture2D_IsValid);
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
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetRenderingLibrary:ExportTexture2D", ExportTexture2D_IsValid);
		ExportRenderTarget_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ExportRenderTarget");
		ExportRenderTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(ExportRenderTarget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExportRenderTarget_WorldContextObject_PropertyAddress, ExportRenderTarget_FunctionAddress, "WorldContextObject");
		ExportRenderTarget_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(ExportRenderTarget_FunctionAddress, "WorldContextObject");
		ExportRenderTarget_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportRenderTarget_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportRenderTarget_TextureRenderTarget_PropertyAddress, ExportRenderTarget_FunctionAddress, "TextureRenderTarget");
		ExportRenderTarget_TextureRenderTarget_Offset = NativeReflectionCached.GetPropertyOffset(ExportRenderTarget_FunctionAddress, "TextureRenderTarget");
		ExportRenderTarget_TextureRenderTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportRenderTarget_FunctionAddress, "TextureRenderTarget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportRenderTarget_FilePath_PropertyAddress, ExportRenderTarget_FunctionAddress, "FilePath");
		ExportRenderTarget_FilePath_Offset = NativeReflectionCached.GetPropertyOffset(ExportRenderTarget_FunctionAddress, "FilePath");
		ExportRenderTarget_FilePath_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportRenderTarget_FunctionAddress, "FilePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportRenderTarget_FileName_PropertyAddress, ExportRenderTarget_FunctionAddress, "FileName");
		ExportRenderTarget_FileName_Offset = NativeReflectionCached.GetPropertyOffset(ExportRenderTarget_FunctionAddress, "FileName");
		ExportRenderTarget_FileName_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportRenderTarget_FunctionAddress, "FileName", Classes.FStrProperty);
		ExportRenderTarget_IsValid = ExportRenderTarget_FunctionAddress != IntPtr.Zero && ExportRenderTarget_WorldContextObject_IsValid && ExportRenderTarget_TextureRenderTarget_IsValid && ExportRenderTarget_FilePath_IsValid && ExportRenderTarget_FileName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetRenderingLibrary:ExportRenderTarget", ExportRenderTarget_IsValid);
		EndDrawCanvasToRenderTarget_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EndDrawCanvasToRenderTarget");
		EndDrawCanvasToRenderTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(EndDrawCanvasToRenderTarget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EndDrawCanvasToRenderTarget_WorldContextObject_PropertyAddress, EndDrawCanvasToRenderTarget_FunctionAddress, "WorldContextObject");
		EndDrawCanvasToRenderTarget_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(EndDrawCanvasToRenderTarget_FunctionAddress, "WorldContextObject");
		EndDrawCanvasToRenderTarget_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(EndDrawCanvasToRenderTarget_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref EndDrawCanvasToRenderTarget_Context_PropertyAddress, EndDrawCanvasToRenderTarget_FunctionAddress, "Context");
		EndDrawCanvasToRenderTarget_Context_Offset = NativeReflectionCached.GetPropertyOffset(EndDrawCanvasToRenderTarget_FunctionAddress, "Context");
		EndDrawCanvasToRenderTarget_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(EndDrawCanvasToRenderTarget_FunctionAddress, "Context", Classes.FStructProperty);
		EndDrawCanvasToRenderTarget_IsValid = EndDrawCanvasToRenderTarget_FunctionAddress != IntPtr.Zero && EndDrawCanvasToRenderTarget_WorldContextObject_IsValid && EndDrawCanvasToRenderTarget_Context_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetRenderingLibrary:EndDrawCanvasToRenderTarget", EndDrawCanvasToRenderTarget_IsValid);
		DrawMaterialToRenderTarget_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DrawMaterialToRenderTarget");
		DrawMaterialToRenderTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawMaterialToRenderTarget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterialToRenderTarget_WorldContextObject_PropertyAddress, DrawMaterialToRenderTarget_FunctionAddress, "WorldContextObject");
		DrawMaterialToRenderTarget_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterialToRenderTarget_FunctionAddress, "WorldContextObject");
		DrawMaterialToRenderTarget_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterialToRenderTarget_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterialToRenderTarget_TextureRenderTarget_PropertyAddress, DrawMaterialToRenderTarget_FunctionAddress, "TextureRenderTarget");
		DrawMaterialToRenderTarget_TextureRenderTarget_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterialToRenderTarget_FunctionAddress, "TextureRenderTarget");
		DrawMaterialToRenderTarget_TextureRenderTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterialToRenderTarget_FunctionAddress, "TextureRenderTarget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterialToRenderTarget_Material_PropertyAddress, DrawMaterialToRenderTarget_FunctionAddress, "Material");
		DrawMaterialToRenderTarget_Material_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterialToRenderTarget_FunctionAddress, "Material");
		DrawMaterialToRenderTarget_Material_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterialToRenderTarget_FunctionAddress, "Material", Classes.FObjectProperty);
		DrawMaterialToRenderTarget_IsValid = DrawMaterialToRenderTarget_FunctionAddress != IntPtr.Zero && DrawMaterialToRenderTarget_WorldContextObject_IsValid && DrawMaterialToRenderTarget_TextureRenderTarget_IsValid && DrawMaterialToRenderTarget_Material_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetRenderingLibrary:DrawMaterialToRenderTarget", DrawMaterialToRenderTarget_IsValid);
		CreateRenderTargetVolume_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateRenderTargetVolume");
		CreateRenderTargetVolume_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateRenderTargetVolume_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateRenderTargetVolume_WorldContextObject_PropertyAddress, CreateRenderTargetVolume_FunctionAddress, "WorldContextObject");
		CreateRenderTargetVolume_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(CreateRenderTargetVolume_FunctionAddress, "WorldContextObject");
		CreateRenderTargetVolume_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateRenderTargetVolume_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateRenderTargetVolume_Width_PropertyAddress, CreateRenderTargetVolume_FunctionAddress, "Width");
		CreateRenderTargetVolume_Width_Offset = NativeReflectionCached.GetPropertyOffset(CreateRenderTargetVolume_FunctionAddress, "Width");
		CreateRenderTargetVolume_Width_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateRenderTargetVolume_FunctionAddress, "Width", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateRenderTargetVolume_Height_PropertyAddress, CreateRenderTargetVolume_FunctionAddress, "Height");
		CreateRenderTargetVolume_Height_Offset = NativeReflectionCached.GetPropertyOffset(CreateRenderTargetVolume_FunctionAddress, "Height");
		CreateRenderTargetVolume_Height_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateRenderTargetVolume_FunctionAddress, "Height", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateRenderTargetVolume_Depth_PropertyAddress, CreateRenderTargetVolume_FunctionAddress, "Depth");
		CreateRenderTargetVolume_Depth_Offset = NativeReflectionCached.GetPropertyOffset(CreateRenderTargetVolume_FunctionAddress, "Depth");
		CreateRenderTargetVolume_Depth_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateRenderTargetVolume_FunctionAddress, "Depth", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateRenderTargetVolume_Format_PropertyAddress, CreateRenderTargetVolume_FunctionAddress, "Format");
		CreateRenderTargetVolume_Format_Offset = NativeReflectionCached.GetPropertyOffset(CreateRenderTargetVolume_FunctionAddress, "Format");
		CreateRenderTargetVolume_Format_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateRenderTargetVolume_FunctionAddress, "Format", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateRenderTargetVolume_ClearColor_PropertyAddress, CreateRenderTargetVolume_FunctionAddress, "ClearColor");
		CreateRenderTargetVolume_ClearColor_Offset = NativeReflectionCached.GetPropertyOffset(CreateRenderTargetVolume_FunctionAddress, "ClearColor");
		CreateRenderTargetVolume_ClearColor_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateRenderTargetVolume_FunctionAddress, "ClearColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateRenderTargetVolume_bAutoGenerateMipMaps_PropertyAddress, CreateRenderTargetVolume_FunctionAddress, "bAutoGenerateMipMaps");
		CreateRenderTargetVolume_bAutoGenerateMipMaps_Offset = NativeReflectionCached.GetPropertyOffset(CreateRenderTargetVolume_FunctionAddress, "bAutoGenerateMipMaps");
		CreateRenderTargetVolume_bAutoGenerateMipMaps_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateRenderTargetVolume_FunctionAddress, "bAutoGenerateMipMaps", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateRenderTargetVolume_ReturnValue_PropertyAddress, CreateRenderTargetVolume_FunctionAddress, "ReturnValue");
		CreateRenderTargetVolume_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateRenderTargetVolume_FunctionAddress, "ReturnValue");
		CreateRenderTargetVolume_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateRenderTargetVolume_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateRenderTargetVolume_IsValid = CreateRenderTargetVolume_FunctionAddress != IntPtr.Zero && CreateRenderTargetVolume_WorldContextObject_IsValid && CreateRenderTargetVolume_Width_IsValid && CreateRenderTargetVolume_Height_IsValid && CreateRenderTargetVolume_Depth_IsValid && CreateRenderTargetVolume_Format_IsValid && CreateRenderTargetVolume_ClearColor_IsValid && CreateRenderTargetVolume_bAutoGenerateMipMaps_IsValid && CreateRenderTargetVolume_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetRenderingLibrary:CreateRenderTargetVolume", CreateRenderTargetVolume_IsValid);
		CreateRenderTarget2DArray_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateRenderTarget2DArray");
		CreateRenderTarget2DArray_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateRenderTarget2DArray_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateRenderTarget2DArray_WorldContextObject_PropertyAddress, CreateRenderTarget2DArray_FunctionAddress, "WorldContextObject");
		CreateRenderTarget2DArray_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(CreateRenderTarget2DArray_FunctionAddress, "WorldContextObject");
		CreateRenderTarget2DArray_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateRenderTarget2DArray_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateRenderTarget2DArray_Width_PropertyAddress, CreateRenderTarget2DArray_FunctionAddress, "Width");
		CreateRenderTarget2DArray_Width_Offset = NativeReflectionCached.GetPropertyOffset(CreateRenderTarget2DArray_FunctionAddress, "Width");
		CreateRenderTarget2DArray_Width_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateRenderTarget2DArray_FunctionAddress, "Width", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateRenderTarget2DArray_Height_PropertyAddress, CreateRenderTarget2DArray_FunctionAddress, "Height");
		CreateRenderTarget2DArray_Height_Offset = NativeReflectionCached.GetPropertyOffset(CreateRenderTarget2DArray_FunctionAddress, "Height");
		CreateRenderTarget2DArray_Height_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateRenderTarget2DArray_FunctionAddress, "Height", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateRenderTarget2DArray_Slices_PropertyAddress, CreateRenderTarget2DArray_FunctionAddress, "Slices");
		CreateRenderTarget2DArray_Slices_Offset = NativeReflectionCached.GetPropertyOffset(CreateRenderTarget2DArray_FunctionAddress, "Slices");
		CreateRenderTarget2DArray_Slices_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateRenderTarget2DArray_FunctionAddress, "Slices", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateRenderTarget2DArray_Format_PropertyAddress, CreateRenderTarget2DArray_FunctionAddress, "Format");
		CreateRenderTarget2DArray_Format_Offset = NativeReflectionCached.GetPropertyOffset(CreateRenderTarget2DArray_FunctionAddress, "Format");
		CreateRenderTarget2DArray_Format_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateRenderTarget2DArray_FunctionAddress, "Format", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateRenderTarget2DArray_ClearColor_PropertyAddress, CreateRenderTarget2DArray_FunctionAddress, "ClearColor");
		CreateRenderTarget2DArray_ClearColor_Offset = NativeReflectionCached.GetPropertyOffset(CreateRenderTarget2DArray_FunctionAddress, "ClearColor");
		CreateRenderTarget2DArray_ClearColor_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateRenderTarget2DArray_FunctionAddress, "ClearColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateRenderTarget2DArray_bAutoGenerateMipMaps_PropertyAddress, CreateRenderTarget2DArray_FunctionAddress, "bAutoGenerateMipMaps");
		CreateRenderTarget2DArray_bAutoGenerateMipMaps_Offset = NativeReflectionCached.GetPropertyOffset(CreateRenderTarget2DArray_FunctionAddress, "bAutoGenerateMipMaps");
		CreateRenderTarget2DArray_bAutoGenerateMipMaps_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateRenderTarget2DArray_FunctionAddress, "bAutoGenerateMipMaps", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateRenderTarget2DArray_ReturnValue_PropertyAddress, CreateRenderTarget2DArray_FunctionAddress, "ReturnValue");
		CreateRenderTarget2DArray_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateRenderTarget2DArray_FunctionAddress, "ReturnValue");
		CreateRenderTarget2DArray_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateRenderTarget2DArray_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateRenderTarget2DArray_IsValid = CreateRenderTarget2DArray_FunctionAddress != IntPtr.Zero && CreateRenderTarget2DArray_WorldContextObject_IsValid && CreateRenderTarget2DArray_Width_IsValid && CreateRenderTarget2DArray_Height_IsValid && CreateRenderTarget2DArray_Slices_IsValid && CreateRenderTarget2DArray_Format_IsValid && CreateRenderTarget2DArray_ClearColor_IsValid && CreateRenderTarget2DArray_bAutoGenerateMipMaps_IsValid && CreateRenderTarget2DArray_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetRenderingLibrary:CreateRenderTarget2DArray", CreateRenderTarget2DArray_IsValid);
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
		NativeReflectionCached.GetPropertyRef(ref CreateRenderTarget2D_Format_PropertyAddress, CreateRenderTarget2D_FunctionAddress, "Format");
		CreateRenderTarget2D_Format_Offset = NativeReflectionCached.GetPropertyOffset(CreateRenderTarget2D_FunctionAddress, "Format");
		CreateRenderTarget2D_Format_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateRenderTarget2D_FunctionAddress, "Format", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateRenderTarget2D_ClearColor_PropertyAddress, CreateRenderTarget2D_FunctionAddress, "ClearColor");
		CreateRenderTarget2D_ClearColor_Offset = NativeReflectionCached.GetPropertyOffset(CreateRenderTarget2D_FunctionAddress, "ClearColor");
		CreateRenderTarget2D_ClearColor_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateRenderTarget2D_FunctionAddress, "ClearColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateRenderTarget2D_bAutoGenerateMipMaps_PropertyAddress, CreateRenderTarget2D_FunctionAddress, "bAutoGenerateMipMaps");
		CreateRenderTarget2D_bAutoGenerateMipMaps_Offset = NativeReflectionCached.GetPropertyOffset(CreateRenderTarget2D_FunctionAddress, "bAutoGenerateMipMaps");
		CreateRenderTarget2D_bAutoGenerateMipMaps_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateRenderTarget2D_FunctionAddress, "bAutoGenerateMipMaps", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateRenderTarget2D_ReturnValue_PropertyAddress, CreateRenderTarget2D_FunctionAddress, "ReturnValue");
		CreateRenderTarget2D_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateRenderTarget2D_FunctionAddress, "ReturnValue");
		CreateRenderTarget2D_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateRenderTarget2D_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateRenderTarget2D_IsValid = CreateRenderTarget2D_FunctionAddress != IntPtr.Zero && CreateRenderTarget2D_WorldContextObject_IsValid && CreateRenderTarget2D_Width_IsValid && CreateRenderTarget2D_Height_IsValid && CreateRenderTarget2D_Format_IsValid && CreateRenderTarget2D_ClearColor_IsValid && CreateRenderTarget2D_bAutoGenerateMipMaps_IsValid && CreateRenderTarget2D_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetRenderingLibrary:CreateRenderTarget2D", CreateRenderTarget2D_IsValid);
		ConvertRenderTargetToTexture2DEditorOnly_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertRenderTargetToTexture2DEditorOnly");
		ConvertRenderTargetToTexture2DEditorOnly_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertRenderTargetToTexture2DEditorOnly_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertRenderTargetToTexture2DEditorOnly_WorldContextObject_PropertyAddress, ConvertRenderTargetToTexture2DEditorOnly_FunctionAddress, "WorldContextObject");
		ConvertRenderTargetToTexture2DEditorOnly_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(ConvertRenderTargetToTexture2DEditorOnly_FunctionAddress, "WorldContextObject");
		ConvertRenderTargetToTexture2DEditorOnly_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertRenderTargetToTexture2DEditorOnly_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertRenderTargetToTexture2DEditorOnly_RenderTarget_PropertyAddress, ConvertRenderTargetToTexture2DEditorOnly_FunctionAddress, "RenderTarget");
		ConvertRenderTargetToTexture2DEditorOnly_RenderTarget_Offset = NativeReflectionCached.GetPropertyOffset(ConvertRenderTargetToTexture2DEditorOnly_FunctionAddress, "RenderTarget");
		ConvertRenderTargetToTexture2DEditorOnly_RenderTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertRenderTargetToTexture2DEditorOnly_FunctionAddress, "RenderTarget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertRenderTargetToTexture2DEditorOnly_Texture_PropertyAddress, ConvertRenderTargetToTexture2DEditorOnly_FunctionAddress, "Texture");
		ConvertRenderTargetToTexture2DEditorOnly_Texture_Offset = NativeReflectionCached.GetPropertyOffset(ConvertRenderTargetToTexture2DEditorOnly_FunctionAddress, "Texture");
		ConvertRenderTargetToTexture2DEditorOnly_Texture_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertRenderTargetToTexture2DEditorOnly_FunctionAddress, "Texture", Classes.FObjectProperty);
		ConvertRenderTargetToTexture2DEditorOnly_IsValid = ConvertRenderTargetToTexture2DEditorOnly_FunctionAddress != IntPtr.Zero && ConvertRenderTargetToTexture2DEditorOnly_WorldContextObject_IsValid && ConvertRenderTargetToTexture2DEditorOnly_RenderTarget_IsValid && ConvertRenderTargetToTexture2DEditorOnly_Texture_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetRenderingLibrary:ConvertRenderTargetToTexture2DEditorOnly", ConvertRenderTargetToTexture2DEditorOnly_IsValid);
		ClearRenderTarget2D_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClearRenderTarget2D");
		ClearRenderTarget2D_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearRenderTarget2D_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearRenderTarget2D_WorldContextObject_PropertyAddress, ClearRenderTarget2D_FunctionAddress, "WorldContextObject");
		ClearRenderTarget2D_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(ClearRenderTarget2D_FunctionAddress, "WorldContextObject");
		ClearRenderTarget2D_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearRenderTarget2D_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ClearRenderTarget2D_TextureRenderTarget_PropertyAddress, ClearRenderTarget2D_FunctionAddress, "TextureRenderTarget");
		ClearRenderTarget2D_TextureRenderTarget_Offset = NativeReflectionCached.GetPropertyOffset(ClearRenderTarget2D_FunctionAddress, "TextureRenderTarget");
		ClearRenderTarget2D_TextureRenderTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearRenderTarget2D_FunctionAddress, "TextureRenderTarget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ClearRenderTarget2D_ClearColor_PropertyAddress, ClearRenderTarget2D_FunctionAddress, "ClearColor");
		ClearRenderTarget2D_ClearColor_Offset = NativeReflectionCached.GetPropertyOffset(ClearRenderTarget2D_FunctionAddress, "ClearColor");
		ClearRenderTarget2D_ClearColor_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearRenderTarget2D_FunctionAddress, "ClearColor", Classes.FStructProperty);
		ClearRenderTarget2D_IsValid = ClearRenderTarget2D_FunctionAddress != IntPtr.Zero && ClearRenderTarget2D_WorldContextObject_IsValid && ClearRenderTarget2D_TextureRenderTarget_IsValid && ClearRenderTarget2D_ClearColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetRenderingLibrary:ClearRenderTarget2D", ClearRenderTarget2D_IsValid);
		CalculateProjectionMatrix_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CalculateProjectionMatrix");
		CalculateProjectionMatrix_ParamsSize = NativeReflection.GetFunctionParamsSize(CalculateProjectionMatrix_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CalculateProjectionMatrix_MinimalViewInfo_PropertyAddress, CalculateProjectionMatrix_FunctionAddress, "MinimalViewInfo");
		CalculateProjectionMatrix_MinimalViewInfo_Offset = NativeReflectionCached.GetPropertyOffset(CalculateProjectionMatrix_FunctionAddress, "MinimalViewInfo");
		CalculateProjectionMatrix_MinimalViewInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateProjectionMatrix_FunctionAddress, "MinimalViewInfo", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CalculateProjectionMatrix_ReturnValue_PropertyAddress, CalculateProjectionMatrix_FunctionAddress, "ReturnValue");
		CalculateProjectionMatrix_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CalculateProjectionMatrix_FunctionAddress, "ReturnValue");
		CalculateProjectionMatrix_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateProjectionMatrix_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		CalculateProjectionMatrix_IsValid = CalculateProjectionMatrix_FunctionAddress != IntPtr.Zero && CalculateProjectionMatrix_MinimalViewInfo_IsValid && CalculateProjectionMatrix_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetRenderingLibrary:CalculateProjectionMatrix", CalculateProjectionMatrix_IsValid);
		BreakSkinWeightInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BreakSkinWeightInfo");
		BreakSkinWeightInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(BreakSkinWeightInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BreakSkinWeightInfo_InWeight_PropertyAddress, BreakSkinWeightInfo_FunctionAddress, "InWeight");
		BreakSkinWeightInfo_InWeight_Offset = NativeReflectionCached.GetPropertyOffset(BreakSkinWeightInfo_FunctionAddress, "InWeight");
		BreakSkinWeightInfo_InWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakSkinWeightInfo_FunctionAddress, "InWeight", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BreakSkinWeightInfo_Bone0_PropertyAddress, BreakSkinWeightInfo_FunctionAddress, "Bone0");
		BreakSkinWeightInfo_Bone0_Offset = NativeReflectionCached.GetPropertyOffset(BreakSkinWeightInfo_FunctionAddress, "Bone0");
		BreakSkinWeightInfo_Bone0_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakSkinWeightInfo_FunctionAddress, "Bone0", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BreakSkinWeightInfo_Weight0_PropertyAddress, BreakSkinWeightInfo_FunctionAddress, "Weight0");
		BreakSkinWeightInfo_Weight0_Offset = NativeReflectionCached.GetPropertyOffset(BreakSkinWeightInfo_FunctionAddress, "Weight0");
		BreakSkinWeightInfo_Weight0_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakSkinWeightInfo_FunctionAddress, "Weight0", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref BreakSkinWeightInfo_Bone1_PropertyAddress, BreakSkinWeightInfo_FunctionAddress, "Bone1");
		BreakSkinWeightInfo_Bone1_Offset = NativeReflectionCached.GetPropertyOffset(BreakSkinWeightInfo_FunctionAddress, "Bone1");
		BreakSkinWeightInfo_Bone1_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakSkinWeightInfo_FunctionAddress, "Bone1", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BreakSkinWeightInfo_Weight1_PropertyAddress, BreakSkinWeightInfo_FunctionAddress, "Weight1");
		BreakSkinWeightInfo_Weight1_Offset = NativeReflectionCached.GetPropertyOffset(BreakSkinWeightInfo_FunctionAddress, "Weight1");
		BreakSkinWeightInfo_Weight1_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakSkinWeightInfo_FunctionAddress, "Weight1", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref BreakSkinWeightInfo_Bone2_PropertyAddress, BreakSkinWeightInfo_FunctionAddress, "Bone2");
		BreakSkinWeightInfo_Bone2_Offset = NativeReflectionCached.GetPropertyOffset(BreakSkinWeightInfo_FunctionAddress, "Bone2");
		BreakSkinWeightInfo_Bone2_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakSkinWeightInfo_FunctionAddress, "Bone2", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BreakSkinWeightInfo_Weight2_PropertyAddress, BreakSkinWeightInfo_FunctionAddress, "Weight2");
		BreakSkinWeightInfo_Weight2_Offset = NativeReflectionCached.GetPropertyOffset(BreakSkinWeightInfo_FunctionAddress, "Weight2");
		BreakSkinWeightInfo_Weight2_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakSkinWeightInfo_FunctionAddress, "Weight2", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref BreakSkinWeightInfo_Bone3_PropertyAddress, BreakSkinWeightInfo_FunctionAddress, "Bone3");
		BreakSkinWeightInfo_Bone3_Offset = NativeReflectionCached.GetPropertyOffset(BreakSkinWeightInfo_FunctionAddress, "Bone3");
		BreakSkinWeightInfo_Bone3_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakSkinWeightInfo_FunctionAddress, "Bone3", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BreakSkinWeightInfo_Weight3_PropertyAddress, BreakSkinWeightInfo_FunctionAddress, "Weight3");
		BreakSkinWeightInfo_Weight3_Offset = NativeReflectionCached.GetPropertyOffset(BreakSkinWeightInfo_FunctionAddress, "Weight3");
		BreakSkinWeightInfo_Weight3_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakSkinWeightInfo_FunctionAddress, "Weight3", Classes.FByteProperty);
		BreakSkinWeightInfo_IsValid = BreakSkinWeightInfo_FunctionAddress != IntPtr.Zero && BreakSkinWeightInfo_InWeight_IsValid && BreakSkinWeightInfo_Bone0_IsValid && BreakSkinWeightInfo_Weight0_IsValid && BreakSkinWeightInfo_Bone1_IsValid && BreakSkinWeightInfo_Weight1_IsValid && BreakSkinWeightInfo_Bone2_IsValid && BreakSkinWeightInfo_Weight2_IsValid && BreakSkinWeightInfo_Bone3_IsValid && BreakSkinWeightInfo_Weight3_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetRenderingLibrary:BreakSkinWeightInfo", BreakSkinWeightInfo_IsValid);
		BeginDrawCanvasToRenderTarget_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BeginDrawCanvasToRenderTarget");
		BeginDrawCanvasToRenderTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginDrawCanvasToRenderTarget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BeginDrawCanvasToRenderTarget_WorldContextObject_PropertyAddress, BeginDrawCanvasToRenderTarget_FunctionAddress, "WorldContextObject");
		BeginDrawCanvasToRenderTarget_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(BeginDrawCanvasToRenderTarget_FunctionAddress, "WorldContextObject");
		BeginDrawCanvasToRenderTarget_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BeginDrawCanvasToRenderTarget_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BeginDrawCanvasToRenderTarget_TextureRenderTarget_PropertyAddress, BeginDrawCanvasToRenderTarget_FunctionAddress, "TextureRenderTarget");
		BeginDrawCanvasToRenderTarget_TextureRenderTarget_Offset = NativeReflectionCached.GetPropertyOffset(BeginDrawCanvasToRenderTarget_FunctionAddress, "TextureRenderTarget");
		BeginDrawCanvasToRenderTarget_TextureRenderTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(BeginDrawCanvasToRenderTarget_FunctionAddress, "TextureRenderTarget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BeginDrawCanvasToRenderTarget_Canvas_PropertyAddress, BeginDrawCanvasToRenderTarget_FunctionAddress, "Canvas");
		BeginDrawCanvasToRenderTarget_Canvas_Offset = NativeReflectionCached.GetPropertyOffset(BeginDrawCanvasToRenderTarget_FunctionAddress, "Canvas");
		BeginDrawCanvasToRenderTarget_Canvas_IsValid = NativeReflectionCached.ValidatePropertyClass(BeginDrawCanvasToRenderTarget_FunctionAddress, "Canvas", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BeginDrawCanvasToRenderTarget_Size_PropertyAddress, BeginDrawCanvasToRenderTarget_FunctionAddress, "Size");
		BeginDrawCanvasToRenderTarget_Size_Offset = NativeReflectionCached.GetPropertyOffset(BeginDrawCanvasToRenderTarget_FunctionAddress, "Size");
		BeginDrawCanvasToRenderTarget_Size_IsValid = NativeReflectionCached.ValidatePropertyClass(BeginDrawCanvasToRenderTarget_FunctionAddress, "Size", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BeginDrawCanvasToRenderTarget_Context_PropertyAddress, BeginDrawCanvasToRenderTarget_FunctionAddress, "Context");
		BeginDrawCanvasToRenderTarget_Context_Offset = NativeReflectionCached.GetPropertyOffset(BeginDrawCanvasToRenderTarget_FunctionAddress, "Context");
		BeginDrawCanvasToRenderTarget_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(BeginDrawCanvasToRenderTarget_FunctionAddress, "Context", Classes.FStructProperty);
		BeginDrawCanvasToRenderTarget_IsValid = BeginDrawCanvasToRenderTarget_FunctionAddress != IntPtr.Zero && BeginDrawCanvasToRenderTarget_WorldContextObject_IsValid && BeginDrawCanvasToRenderTarget_TextureRenderTarget_IsValid && BeginDrawCanvasToRenderTarget_Canvas_IsValid && BeginDrawCanvasToRenderTarget_Size_IsValid && BeginDrawCanvasToRenderTarget_Context_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetRenderingLibrary:BeginDrawCanvasToRenderTarget", BeginDrawCanvasToRenderTarget_IsValid);
	}
}
