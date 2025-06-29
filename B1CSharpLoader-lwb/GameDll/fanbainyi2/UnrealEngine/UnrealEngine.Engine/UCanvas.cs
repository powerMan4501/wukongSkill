using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810549416uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.Canvas", "Engine", UnrealModuleType.Engine)]
public class UCanvas : UObject
{
	private static bool ClippedTextSize_IsValid;

	private static IntPtr ClippedTextSize_FunctionAddress;

	private static int ClippedTextSize_ParamsSize;

	private static bool ClippedTextSize_RenderFont_IsValid;

	private static FFieldAddress ClippedTextSize_RenderFont_PropertyAddress;

	private static int ClippedTextSize_RenderFont_Offset;

	private static bool ClippedTextSize_RenderText_IsValid;

	private static FFieldAddress ClippedTextSize_RenderText_PropertyAddress;

	private static int ClippedTextSize_RenderText_Offset;

	private static bool ClippedTextSize_Scale_IsValid;

	private static FFieldAddress ClippedTextSize_Scale_PropertyAddress;

	private static int ClippedTextSize_Scale_Offset;

	private static bool ClippedTextSize_ReturnValue_IsValid;

	private static FFieldAddress ClippedTextSize_ReturnValue_PropertyAddress;

	private static int ClippedTextSize_ReturnValue_Offset;

	private static bool WrappedTextSize_IsValid;

	private static IntPtr WrappedTextSize_FunctionAddress;

	private static int WrappedTextSize_ParamsSize;

	private static bool WrappedTextSize_RenderFont_IsValid;

	private static FFieldAddress WrappedTextSize_RenderFont_PropertyAddress;

	private static int WrappedTextSize_RenderFont_Offset;

	private static bool WrappedTextSize_RenderText_IsValid;

	private static FFieldAddress WrappedTextSize_RenderText_PropertyAddress;

	private static int WrappedTextSize_RenderText_Offset;

	private static bool WrappedTextSize_ReturnValue_IsValid;

	private static FFieldAddress WrappedTextSize_ReturnValue_PropertyAddress;

	private static int WrappedTextSize_ReturnValue_Offset;

	private static bool Project_IsValid;

	private static IntPtr Project_FunctionAddress;

	private static int Project_ParamsSize;

	private static bool Project_WorldLocation_IsValid;

	private static FFieldAddress Project_WorldLocation_PropertyAddress;

	private static int Project_WorldLocation_Offset;

	private static bool Project_ReturnValue_IsValid;

	private static FFieldAddress Project_ReturnValue_PropertyAddress;

	private static int Project_ReturnValue_Offset;

	private static bool DrawTriangles_IsValid;

	private static IntPtr DrawTriangles_FunctionAddress;

	private static int DrawTriangles_ParamsSize;

	private static bool DrawTriangles_RenderTexture_IsValid;

	private static FFieldAddress DrawTriangles_RenderTexture_PropertyAddress;

	private static int DrawTriangles_RenderTexture_Offset;

	private static bool DrawTriangles_Triangles_IsValid;

	private static FFieldAddress DrawTriangles_Triangles_PropertyAddress;

	private static int DrawTriangles_Triangles_Offset;

	private static bool DrawTexture_IsValid;

	private static IntPtr DrawTexture_FunctionAddress;

	private static int DrawTexture_ParamsSize;

	private static bool DrawTexture_RenderTexture_IsValid;

	private static FFieldAddress DrawTexture_RenderTexture_PropertyAddress;

	private static int DrawTexture_RenderTexture_Offset;

	private static bool DrawTexture_ScreenPosition_IsValid;

	private static FFieldAddress DrawTexture_ScreenPosition_PropertyAddress;

	private static int DrawTexture_ScreenPosition_Offset;

	private static bool DrawTexture_ScreenSize_IsValid;

	private static FFieldAddress DrawTexture_ScreenSize_PropertyAddress;

	private static int DrawTexture_ScreenSize_Offset;

	private static bool DrawTexture_CoordinatePosition_IsValid;

	private static FFieldAddress DrawTexture_CoordinatePosition_PropertyAddress;

	private static int DrawTexture_CoordinatePosition_Offset;

	private static bool DrawTexture_CoordinateSize_IsValid;

	private static FFieldAddress DrawTexture_CoordinateSize_PropertyAddress;

	private static int DrawTexture_CoordinateSize_Offset;

	private static bool DrawTexture_RenderColor_IsValid;

	private static FFieldAddress DrawTexture_RenderColor_PropertyAddress;

	private static int DrawTexture_RenderColor_Offset;

	private static bool DrawTexture_BlendMode_IsValid;

	private static FFieldAddress DrawTexture_BlendMode_PropertyAddress;

	private static int DrawTexture_BlendMode_Offset;

	private static bool DrawTexture_Rotation_IsValid;

	private static FFieldAddress DrawTexture_Rotation_PropertyAddress;

	private static int DrawTexture_Rotation_Offset;

	private static bool DrawTexture_PivotPoint_IsValid;

	private static FFieldAddress DrawTexture_PivotPoint_PropertyAddress;

	private static int DrawTexture_PivotPoint_Offset;

	private static bool DrawText_IsValid;

	private static IntPtr DrawText_FunctionAddress;

	private static int DrawText_ParamsSize;

	private static bool DrawText_RenderFont_IsValid;

	private static FFieldAddress DrawText_RenderFont_PropertyAddress;

	private static int DrawText_RenderFont_Offset;

	private static bool DrawText_RenderText_IsValid;

	private static FFieldAddress DrawText_RenderText_PropertyAddress;

	private static int DrawText_RenderText_Offset;

	private static bool DrawText_ScreenPosition_IsValid;

	private static FFieldAddress DrawText_ScreenPosition_PropertyAddress;

	private static int DrawText_ScreenPosition_Offset;

	private static bool DrawText_Scale_IsValid;

	private static FFieldAddress DrawText_Scale_PropertyAddress;

	private static int DrawText_Scale_Offset;

	private static bool DrawText_RenderColor_IsValid;

	private static FFieldAddress DrawText_RenderColor_PropertyAddress;

	private static int DrawText_RenderColor_Offset;

	private static bool DrawText_Kerning_IsValid;

	private static FFieldAddress DrawText_Kerning_PropertyAddress;

	private static int DrawText_Kerning_Offset;

	private static bool DrawText_ShadowColor_IsValid;

	private static FFieldAddress DrawText_ShadowColor_PropertyAddress;

	private static int DrawText_ShadowColor_Offset;

	private static bool DrawText_ShadowOffset_IsValid;

	private static FFieldAddress DrawText_ShadowOffset_PropertyAddress;

	private static int DrawText_ShadowOffset_Offset;

	private static bool DrawText_bCentreX_IsValid;

	private static FFieldAddress DrawText_bCentreX_PropertyAddress;

	private static int DrawText_bCentreX_Offset;

	private static bool DrawText_bCentreY_IsValid;

	private static FFieldAddress DrawText_bCentreY_PropertyAddress;

	private static int DrawText_bCentreY_Offset;

	private static bool DrawText_bOutlined_IsValid;

	private static FFieldAddress DrawText_bOutlined_PropertyAddress;

	private static int DrawText_bOutlined_Offset;

	private static bool DrawText_OutlineColor_IsValid;

	private static FFieldAddress DrawText_OutlineColor_PropertyAddress;

	private static int DrawText_OutlineColor_Offset;

	private static bool DrawPolygon_IsValid;

	private static IntPtr DrawPolygon_FunctionAddress;

	private static int DrawPolygon_ParamsSize;

	private static bool DrawPolygon_RenderTexture_IsValid;

	private static FFieldAddress DrawPolygon_RenderTexture_PropertyAddress;

	private static int DrawPolygon_RenderTexture_Offset;

	private static bool DrawPolygon_ScreenPosition_IsValid;

	private static FFieldAddress DrawPolygon_ScreenPosition_PropertyAddress;

	private static int DrawPolygon_ScreenPosition_Offset;

	private static bool DrawPolygon_Radius_IsValid;

	private static FFieldAddress DrawPolygon_Radius_PropertyAddress;

	private static int DrawPolygon_Radius_Offset;

	private static bool DrawPolygon_NumberOfSides_IsValid;

	private static FFieldAddress DrawPolygon_NumberOfSides_PropertyAddress;

	private static int DrawPolygon_NumberOfSides_Offset;

	private static bool DrawPolygon_RenderColor_IsValid;

	private static FFieldAddress DrawPolygon_RenderColor_PropertyAddress;

	private static int DrawPolygon_RenderColor_Offset;

	private static bool DrawMaterialTriangles_IsValid;

	private static IntPtr DrawMaterialTriangles_FunctionAddress;

	private static int DrawMaterialTriangles_ParamsSize;

	private static bool DrawMaterialTriangles_RenderMaterial_IsValid;

	private static FFieldAddress DrawMaterialTriangles_RenderMaterial_PropertyAddress;

	private static int DrawMaterialTriangles_RenderMaterial_Offset;

	private static bool DrawMaterialTriangles_Triangles_IsValid;

	private static FFieldAddress DrawMaterialTriangles_Triangles_PropertyAddress;

	private static int DrawMaterialTriangles_Triangles_Offset;

	private static bool DrawMaterial_IsValid;

	private static IntPtr DrawMaterial_FunctionAddress;

	private static int DrawMaterial_ParamsSize;

	private static bool DrawMaterial_RenderMaterial_IsValid;

	private static FFieldAddress DrawMaterial_RenderMaterial_PropertyAddress;

	private static int DrawMaterial_RenderMaterial_Offset;

	private static bool DrawMaterial_ScreenPosition_IsValid;

	private static FFieldAddress DrawMaterial_ScreenPosition_PropertyAddress;

	private static int DrawMaterial_ScreenPosition_Offset;

	private static bool DrawMaterial_ScreenSize_IsValid;

	private static FFieldAddress DrawMaterial_ScreenSize_PropertyAddress;

	private static int DrawMaterial_ScreenSize_Offset;

	private static bool DrawMaterial_CoordinatePosition_IsValid;

	private static FFieldAddress DrawMaterial_CoordinatePosition_PropertyAddress;

	private static int DrawMaterial_CoordinatePosition_Offset;

	private static bool DrawMaterial_CoordinateSize_IsValid;

	private static FFieldAddress DrawMaterial_CoordinateSize_PropertyAddress;

	private static int DrawMaterial_CoordinateSize_Offset;

	private static bool DrawMaterial_Rotation_IsValid;

	private static FFieldAddress DrawMaterial_Rotation_PropertyAddress;

	private static int DrawMaterial_Rotation_Offset;

	private static bool DrawMaterial_PivotPoint_IsValid;

	private static FFieldAddress DrawMaterial_PivotPoint_PropertyAddress;

	private static int DrawMaterial_PivotPoint_Offset;

	private static bool DrawLine_IsValid;

	private static IntPtr DrawLine_FunctionAddress;

	private static int DrawLine_ParamsSize;

	private static bool DrawLine_ScreenPositionA_IsValid;

	private static FFieldAddress DrawLine_ScreenPositionA_PropertyAddress;

	private static int DrawLine_ScreenPositionA_Offset;

	private static bool DrawLine_ScreenPositionB_IsValid;

	private static FFieldAddress DrawLine_ScreenPositionB_PropertyAddress;

	private static int DrawLine_ScreenPositionB_Offset;

	private static bool DrawLine_Thickness_IsValid;

	private static FFieldAddress DrawLine_Thickness_PropertyAddress;

	private static int DrawLine_Thickness_Offset;

	private static bool DrawLine_RenderColor_IsValid;

	private static FFieldAddress DrawLine_RenderColor_PropertyAddress;

	private static int DrawLine_RenderColor_Offset;

	private static bool DrawBox_IsValid;

	private static IntPtr DrawBox_FunctionAddress;

	private static int DrawBox_ParamsSize;

	private static bool DrawBox_ScreenPosition_IsValid;

	private static FFieldAddress DrawBox_ScreenPosition_PropertyAddress;

	private static int DrawBox_ScreenPosition_Offset;

	private static bool DrawBox_ScreenSize_IsValid;

	private static FFieldAddress DrawBox_ScreenSize_PropertyAddress;

	private static int DrawBox_ScreenSize_Offset;

	private static bool DrawBox_Thickness_IsValid;

	private static FFieldAddress DrawBox_Thickness_PropertyAddress;

	private static int DrawBox_Thickness_Offset;

	private static bool DrawBox_RenderColor_IsValid;

	private static FFieldAddress DrawBox_RenderColor_PropertyAddress;

	private static int DrawBox_RenderColor_Offset;

	private static bool DrawBorder_IsValid;

	private static IntPtr DrawBorder_FunctionAddress;

	private static int DrawBorder_ParamsSize;

	private static bool DrawBorder_BorderTexture_IsValid;

	private static FFieldAddress DrawBorder_BorderTexture_PropertyAddress;

	private static int DrawBorder_BorderTexture_Offset;

	private static bool DrawBorder_BackgroundTexture_IsValid;

	private static FFieldAddress DrawBorder_BackgroundTexture_PropertyAddress;

	private static int DrawBorder_BackgroundTexture_Offset;

	private static bool DrawBorder_LeftBorderTexture_IsValid;

	private static FFieldAddress DrawBorder_LeftBorderTexture_PropertyAddress;

	private static int DrawBorder_LeftBorderTexture_Offset;

	private static bool DrawBorder_RightBorderTexture_IsValid;

	private static FFieldAddress DrawBorder_RightBorderTexture_PropertyAddress;

	private static int DrawBorder_RightBorderTexture_Offset;

	private static bool DrawBorder_TopBorderTexture_IsValid;

	private static FFieldAddress DrawBorder_TopBorderTexture_PropertyAddress;

	private static int DrawBorder_TopBorderTexture_Offset;

	private static bool DrawBorder_BottomBorderTexture_IsValid;

	private static FFieldAddress DrawBorder_BottomBorderTexture_PropertyAddress;

	private static int DrawBorder_BottomBorderTexture_Offset;

	private static bool DrawBorder_ScreenPosition_IsValid;

	private static FFieldAddress DrawBorder_ScreenPosition_PropertyAddress;

	private static int DrawBorder_ScreenPosition_Offset;

	private static bool DrawBorder_ScreenSize_IsValid;

	private static FFieldAddress DrawBorder_ScreenSize_PropertyAddress;

	private static int DrawBorder_ScreenSize_Offset;

	private static bool DrawBorder_CoordinatePosition_IsValid;

	private static FFieldAddress DrawBorder_CoordinatePosition_PropertyAddress;

	private static int DrawBorder_CoordinatePosition_Offset;

	private static bool DrawBorder_CoordinateSize_IsValid;

	private static FFieldAddress DrawBorder_CoordinateSize_PropertyAddress;

	private static int DrawBorder_CoordinateSize_Offset;

	private static bool DrawBorder_RenderColor_IsValid;

	private static FFieldAddress DrawBorder_RenderColor_PropertyAddress;

	private static int DrawBorder_RenderColor_Offset;

	private static bool DrawBorder_BorderScale_IsValid;

	private static FFieldAddress DrawBorder_BorderScale_PropertyAddress;

	private static int DrawBorder_BorderScale_Offset;

	private static bool DrawBorder_BackgroundScale_IsValid;

	private static FFieldAddress DrawBorder_BackgroundScale_PropertyAddress;

	private static int DrawBorder_BackgroundScale_Offset;

	private static bool DrawBorder_Rotation_IsValid;

	private static FFieldAddress DrawBorder_Rotation_PropertyAddress;

	private static int DrawBorder_Rotation_Offset;

	private static bool DrawBorder_PivotPoint_IsValid;

	private static FFieldAddress DrawBorder_PivotPoint_PropertyAddress;

	private static int DrawBorder_PivotPoint_Offset;

	private static bool DrawBorder_CornerSize_IsValid;

	private static FFieldAddress DrawBorder_CornerSize_PropertyAddress;

	private static int DrawBorder_CornerSize_Offset;

	private static bool Deproject_IsValid;

	private static IntPtr Deproject_FunctionAddress;

	private static int Deproject_ParamsSize;

	private static bool Deproject_ScreenPosition_IsValid;

	private static FFieldAddress Deproject_ScreenPosition_PropertyAddress;

	private static int Deproject_ScreenPosition_Offset;

	private static bool Deproject_WorldOrigin_IsValid;

	private static FFieldAddress Deproject_WorldOrigin_PropertyAddress;

	private static int Deproject_WorldOrigin_Offset;

	private static bool Deproject_WorldDirection_IsValid;

	private static FFieldAddress Deproject_WorldDirection_PropertyAddress;

	private static int Deproject_WorldDirection_Offset;

	[UFunction(Flags = 75629569u, OriginalName = "K2_TextSize")]
	[UMetaPath("/Script/Engine.Canvas:K2_TextSize")]
	public unsafe FVector2D ClippedTextSize(UFont RenderFont, string RenderText, FVector2D Scale)
	{
		CheckDestroyed();
		if (!ClippedTextSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Canvas:K2_TextSize");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClippedTextSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClippedTextSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UFont>.ToNative(IntPtr.Add(intPtr, ClippedTextSize_RenderFont_Offset), 0, ClippedTextSize_RenderFont_PropertyAddress.Address, RenderFont);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ClippedTextSize_RenderText_Offset), 0, ClippedTextSize_RenderText_PropertyAddress.Address, RenderText);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, ClippedTextSize_Scale_Offset), 0, ClippedTextSize_Scale_PropertyAddress.Address, Scale);
		NativeReflection.InvokeFunctionOptimized(base.Address, ClippedTextSize_FunctionAddress, intPtr, ClippedTextSize_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ClippedTextSize_RenderText_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, ClippedTextSize_ReturnValue_Offset), 0, ClippedTextSize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u, OriginalName = "K2_StrLen")]
	[UMetaPath("/Script/Engine.Canvas:K2_StrLen")]
	public unsafe FVector2D WrappedTextSize(UFont RenderFont, string RenderText)
	{
		CheckDestroyed();
		if (!WrappedTextSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Canvas:K2_StrLen");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(WrappedTextSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WrappedTextSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UFont>.ToNative(IntPtr.Add(intPtr, WrappedTextSize_RenderFont_Offset), 0, WrappedTextSize_RenderFont_PropertyAddress.Address, RenderFont);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, WrappedTextSize_RenderText_Offset), 0, WrappedTextSize_RenderText_PropertyAddress.Address, RenderText);
		NativeReflection.InvokeFunctionOptimized(base.Address, WrappedTextSize_FunctionAddress, intPtr, WrappedTextSize_ParamsSize);
		NativeReflection.DestroyValue_InContainer(WrappedTextSize_RenderText_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, WrappedTextSize_ReturnValue_Offset), 0, WrappedTextSize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u, OriginalName = "K2_Project")]
	[UMetaPath("/Script/Engine.Canvas:K2_Project")]
	public unsafe FVector Project(FVector WorldLocation)
	{
		CheckDestroyed();
		if (!Project_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Canvas:K2_Project");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(Project_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Project_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, Project_WorldLocation_Offset), 0, Project_WorldLocation_PropertyAddress.Address, WorldLocation);
		NativeReflection.InvokeFunctionOptimized(base.Address, Project_FunctionAddress, intPtr, Project_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, Project_ReturnValue_Offset), 0, Project_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u, OriginalName = "K2_DrawTriangle")]
	[UMetaPath("/Script/Engine.Canvas:K2_DrawTriangle")]
	public unsafe void DrawTriangles(UTexture RenderTexture, List<FCanvasUVTri> Triangles)
	{
		CheckDestroyed();
		if (!DrawTriangles_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Canvas:K2_DrawTriangle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawTriangles_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawTriangles_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(intPtr, DrawTriangles_RenderTexture_Offset), 0, DrawTriangles_RenderTexture_PropertyAddress.Address, RenderTexture);
		new TArrayCopyMarshaler<FCanvasUVTri>(1, DrawTriangles_Triangles_PropertyAddress, CachedMarshalingDelegates<FCanvasUVTri, FCanvasUVTri>.FromNative, CachedMarshalingDelegates<FCanvasUVTri, FCanvasUVTri>.ToNative).ToNative(IntPtr.Add(intPtr, DrawTriangles_Triangles_Offset), Triangles);
		NativeReflection.InvokeFunctionOptimized(base.Address, DrawTriangles_FunctionAddress, intPtr, DrawTriangles_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DrawTriangles_Triangles_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75629569u, OriginalName = "K2_DrawTexture")]
	[UMetaPath("/Script/Engine.Canvas:K2_DrawTexture")]
	public unsafe void DrawTexture(UTexture RenderTexture, FVector2D ScreenPosition, FVector2D ScreenSize, FVector2D CoordinatePosition, FVector2D CoordinateSize, FLinearColor RenderColor, EBlendMode BlendMode, float Rotation, FVector2D PivotPoint)
	{
		CheckDestroyed();
		if (!DrawTexture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Canvas:K2_DrawTexture");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawTexture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawTexture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(intPtr, DrawTexture_RenderTexture_Offset), 0, DrawTexture_RenderTexture_PropertyAddress.Address, RenderTexture);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawTexture_ScreenPosition_Offset), 0, DrawTexture_ScreenPosition_PropertyAddress.Address, ScreenPosition);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawTexture_ScreenSize_Offset), 0, DrawTexture_ScreenSize_PropertyAddress.Address, ScreenSize);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawTexture_CoordinatePosition_Offset), 0, DrawTexture_CoordinatePosition_PropertyAddress.Address, CoordinatePosition);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawTexture_CoordinateSize_Offset), 0, DrawTexture_CoordinateSize_PropertyAddress.Address, CoordinateSize);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawTexture_RenderColor_Offset), 0, DrawTexture_RenderColor_PropertyAddress.Address, RenderColor);
		EnumMarshaler<EBlendMode>.ToNative(IntPtr.Add(intPtr, DrawTexture_BlendMode_Offset), 0, DrawTexture_BlendMode_PropertyAddress.Address, BlendMode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawTexture_Rotation_Offset), 0, DrawTexture_Rotation_PropertyAddress.Address, Rotation);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawTexture_PivotPoint_Offset), 0, DrawTexture_PivotPoint_PropertyAddress.Address, PivotPoint);
		NativeReflection.InvokeFunctionOptimized(base.Address, DrawTexture_FunctionAddress, intPtr, DrawTexture_ParamsSize);
	}

	[UFunction(Flags = 75629569u, OriginalName = "K2_DrawText")]
	[UMetaPath("/Script/Engine.Canvas:K2_DrawText")]
	public unsafe void DrawText(UFont RenderFont, string RenderText, FVector2D ScreenPosition, FVector2D Scale, FLinearColor RenderColor, float Kerning, FLinearColor ShadowColor, FVector2D ShadowOffset, bool bCentreX, bool bCentreY, bool bOutlined, FLinearColor OutlineColor)
	{
		CheckDestroyed();
		if (!DrawText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Canvas:K2_DrawText");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UFont>.ToNative(IntPtr.Add(intPtr, DrawText_RenderFont_Offset), 0, DrawText_RenderFont_PropertyAddress.Address, RenderFont);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DrawText_RenderText_Offset), 0, DrawText_RenderText_PropertyAddress.Address, RenderText);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawText_ScreenPosition_Offset), 0, DrawText_ScreenPosition_PropertyAddress.Address, ScreenPosition);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawText_Scale_Offset), 0, DrawText_Scale_PropertyAddress.Address, Scale);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawText_RenderColor_Offset), 0, DrawText_RenderColor_PropertyAddress.Address, RenderColor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawText_Kerning_Offset), 0, DrawText_Kerning_PropertyAddress.Address, Kerning);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawText_ShadowColor_Offset), 0, DrawText_ShadowColor_PropertyAddress.Address, ShadowColor);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawText_ShadowOffset_Offset), 0, DrawText_ShadowOffset_PropertyAddress.Address, ShadowOffset);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DrawText_bCentreX_Offset), 0, DrawText_bCentreX_PropertyAddress.Address, bCentreX);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DrawText_bCentreY_Offset), 0, DrawText_bCentreY_PropertyAddress.Address, bCentreY);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DrawText_bOutlined_Offset), 0, DrawText_bOutlined_PropertyAddress.Address, bOutlined);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawText_OutlineColor_Offset), 0, DrawText_OutlineColor_PropertyAddress.Address, OutlineColor);
		NativeReflection.InvokeFunctionOptimized(base.Address, DrawText_FunctionAddress, intPtr, DrawText_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DrawText_RenderText_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75629569u, OriginalName = "K2_DrawPolygon")]
	[UMetaPath("/Script/Engine.Canvas:K2_DrawPolygon")]
	public unsafe void DrawPolygon(UTexture RenderTexture, FVector2D ScreenPosition, FVector2D Radius, int NumberOfSides, FLinearColor RenderColor)
	{
		CheckDestroyed();
		if (!DrawPolygon_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Canvas:K2_DrawPolygon");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawPolygon_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawPolygon_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(intPtr, DrawPolygon_RenderTexture_Offset), 0, DrawPolygon_RenderTexture_PropertyAddress.Address, RenderTexture);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawPolygon_ScreenPosition_Offset), 0, DrawPolygon_ScreenPosition_PropertyAddress.Address, ScreenPosition);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawPolygon_Radius_Offset), 0, DrawPolygon_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, DrawPolygon_NumberOfSides_Offset), 0, DrawPolygon_NumberOfSides_PropertyAddress.Address, NumberOfSides);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawPolygon_RenderColor_Offset), 0, DrawPolygon_RenderColor_PropertyAddress.Address, RenderColor);
		NativeReflection.InvokeFunctionOptimized(base.Address, DrawPolygon_FunctionAddress, intPtr, DrawPolygon_ParamsSize);
	}

	[UFunction(Flags = 67240961u, OriginalName = "K2_DrawMaterialTriangle")]
	[UMetaPath("/Script/Engine.Canvas:K2_DrawMaterialTriangle")]
	public unsafe void DrawMaterialTriangles(UMaterialInterface RenderMaterial, List<FCanvasUVTri> Triangles)
	{
		CheckDestroyed();
		if (!DrawMaterialTriangles_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Canvas:K2_DrawMaterialTriangle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawMaterialTriangles_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawMaterialTriangles_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, DrawMaterialTriangles_RenderMaterial_Offset), 0, DrawMaterialTriangles_RenderMaterial_PropertyAddress.Address, RenderMaterial);
		new TArrayCopyMarshaler<FCanvasUVTri>(1, DrawMaterialTriangles_Triangles_PropertyAddress, CachedMarshalingDelegates<FCanvasUVTri, FCanvasUVTri>.FromNative, CachedMarshalingDelegates<FCanvasUVTri, FCanvasUVTri>.ToNative).ToNative(IntPtr.Add(intPtr, DrawMaterialTriangles_Triangles_Offset), Triangles);
		NativeReflection.InvokeFunctionOptimized(base.Address, DrawMaterialTriangles_FunctionAddress, intPtr, DrawMaterialTriangles_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DrawMaterialTriangles_Triangles_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75629569u, OriginalName = "K2_DrawMaterial")]
	[UMetaPath("/Script/Engine.Canvas:K2_DrawMaterial")]
	public unsafe void DrawMaterial(UMaterialInterface RenderMaterial, FVector2D ScreenPosition, FVector2D ScreenSize, FVector2D CoordinatePosition, FVector2D CoordinateSize, float Rotation, FVector2D PivotPoint)
	{
		CheckDestroyed();
		if (!DrawMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Canvas:K2_DrawMaterial");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, DrawMaterial_RenderMaterial_Offset), 0, DrawMaterial_RenderMaterial_PropertyAddress.Address, RenderMaterial);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawMaterial_ScreenPosition_Offset), 0, DrawMaterial_ScreenPosition_PropertyAddress.Address, ScreenPosition);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawMaterial_ScreenSize_Offset), 0, DrawMaterial_ScreenSize_PropertyAddress.Address, ScreenSize);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawMaterial_CoordinatePosition_Offset), 0, DrawMaterial_CoordinatePosition_PropertyAddress.Address, CoordinatePosition);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawMaterial_CoordinateSize_Offset), 0, DrawMaterial_CoordinateSize_PropertyAddress.Address, CoordinateSize);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawMaterial_Rotation_Offset), 0, DrawMaterial_Rotation_PropertyAddress.Address, Rotation);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawMaterial_PivotPoint_Offset), 0, DrawMaterial_PivotPoint_PropertyAddress.Address, PivotPoint);
		NativeReflection.InvokeFunctionOptimized(base.Address, DrawMaterial_FunctionAddress, intPtr, DrawMaterial_ParamsSize);
	}

	[UFunction(Flags = 75629569u, OriginalName = "K2_DrawLine")]
	[UMetaPath("/Script/Engine.Canvas:K2_DrawLine")]
	public unsafe void DrawLine(FVector2D ScreenPositionA, FVector2D ScreenPositionB, float Thickness, FLinearColor RenderColor)
	{
		CheckDestroyed();
		if (!DrawLine_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Canvas:K2_DrawLine");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawLine_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawLine_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawLine_ScreenPositionA_Offset), 0, DrawLine_ScreenPositionA_PropertyAddress.Address, ScreenPositionA);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawLine_ScreenPositionB_Offset), 0, DrawLine_ScreenPositionB_PropertyAddress.Address, ScreenPositionB);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawLine_Thickness_Offset), 0, DrawLine_Thickness_PropertyAddress.Address, Thickness);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawLine_RenderColor_Offset), 0, DrawLine_RenderColor_PropertyAddress.Address, RenderColor);
		NativeReflection.InvokeFunctionOptimized(base.Address, DrawLine_FunctionAddress, intPtr, DrawLine_ParamsSize);
	}

	[UFunction(Flags = 75629569u, OriginalName = "K2_DrawBox")]
	[UMetaPath("/Script/Engine.Canvas:K2_DrawBox")]
	public unsafe void DrawBox(FVector2D ScreenPosition, FVector2D ScreenSize, float Thickness, FLinearColor RenderColor)
	{
		CheckDestroyed();
		if (!DrawBox_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Canvas:K2_DrawBox");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawBox_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawBox_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawBox_ScreenPosition_Offset), 0, DrawBox_ScreenPosition_PropertyAddress.Address, ScreenPosition);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawBox_ScreenSize_Offset), 0, DrawBox_ScreenSize_PropertyAddress.Address, ScreenSize);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawBox_Thickness_Offset), 0, DrawBox_Thickness_PropertyAddress.Address, Thickness);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawBox_RenderColor_Offset), 0, DrawBox_RenderColor_PropertyAddress.Address, RenderColor);
		NativeReflection.InvokeFunctionOptimized(base.Address, DrawBox_FunctionAddress, intPtr, DrawBox_ParamsSize);
	}

	[UFunction(Flags = 75629569u, OriginalName = "K2_DrawBorder")]
	[UMetaPath("/Script/Engine.Canvas:K2_DrawBorder")]
	public unsafe void DrawBorder(UTexture BorderTexture, UTexture BackgroundTexture, UTexture LeftBorderTexture, UTexture RightBorderTexture, UTexture TopBorderTexture, UTexture BottomBorderTexture, FVector2D ScreenPosition, FVector2D ScreenSize, FVector2D CoordinatePosition, FVector2D CoordinateSize, FLinearColor RenderColor, FVector2D BorderScale, FVector2D BackgroundScale, float Rotation, FVector2D PivotPoint, FVector2D CornerSize)
	{
		CheckDestroyed();
		if (!DrawBorder_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Canvas:K2_DrawBorder");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawBorder_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawBorder_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(intPtr, DrawBorder_BorderTexture_Offset), 0, DrawBorder_BorderTexture_PropertyAddress.Address, BorderTexture);
		UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(intPtr, DrawBorder_BackgroundTexture_Offset), 0, DrawBorder_BackgroundTexture_PropertyAddress.Address, BackgroundTexture);
		UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(intPtr, DrawBorder_LeftBorderTexture_Offset), 0, DrawBorder_LeftBorderTexture_PropertyAddress.Address, LeftBorderTexture);
		UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(intPtr, DrawBorder_RightBorderTexture_Offset), 0, DrawBorder_RightBorderTexture_PropertyAddress.Address, RightBorderTexture);
		UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(intPtr, DrawBorder_TopBorderTexture_Offset), 0, DrawBorder_TopBorderTexture_PropertyAddress.Address, TopBorderTexture);
		UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(intPtr, DrawBorder_BottomBorderTexture_Offset), 0, DrawBorder_BottomBorderTexture_PropertyAddress.Address, BottomBorderTexture);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawBorder_ScreenPosition_Offset), 0, DrawBorder_ScreenPosition_PropertyAddress.Address, ScreenPosition);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawBorder_ScreenSize_Offset), 0, DrawBorder_ScreenSize_PropertyAddress.Address, ScreenSize);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawBorder_CoordinatePosition_Offset), 0, DrawBorder_CoordinatePosition_PropertyAddress.Address, CoordinatePosition);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawBorder_CoordinateSize_Offset), 0, DrawBorder_CoordinateSize_PropertyAddress.Address, CoordinateSize);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawBorder_RenderColor_Offset), 0, DrawBorder_RenderColor_PropertyAddress.Address, RenderColor);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawBorder_BorderScale_Offset), 0, DrawBorder_BorderScale_PropertyAddress.Address, BorderScale);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawBorder_BackgroundScale_Offset), 0, DrawBorder_BackgroundScale_PropertyAddress.Address, BackgroundScale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawBorder_Rotation_Offset), 0, DrawBorder_Rotation_PropertyAddress.Address, Rotation);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawBorder_PivotPoint_Offset), 0, DrawBorder_PivotPoint_PropertyAddress.Address, PivotPoint);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawBorder_CornerSize_Offset), 0, DrawBorder_CornerSize_PropertyAddress.Address, CornerSize);
		NativeReflection.InvokeFunctionOptimized(base.Address, DrawBorder_FunctionAddress, intPtr, DrawBorder_ParamsSize);
	}

	[UFunction(Flags = 79823873u, OriginalName = "K2_Deproject")]
	[UMetaPath("/Script/Engine.Canvas:K2_Deproject")]
	public unsafe void Deproject(FVector2D ScreenPosition, out FVector WorldOrigin, out FVector WorldDirection)
	{
		CheckDestroyed();
		if (!Deproject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Canvas:K2_Deproject");
			WorldOrigin = default(FVector);
			WorldDirection = default(FVector);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Deproject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Deproject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, Deproject_ScreenPosition_Offset), 0, Deproject_ScreenPosition_PropertyAddress.Address, ScreenPosition);
		NativeReflection.InvokeFunctionOptimized(base.Address, Deproject_FunctionAddress, intPtr, Deproject_ParamsSize);
		WorldOrigin = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, Deproject_WorldOrigin_Offset), 0, Deproject_WorldOrigin_PropertyAddress.Address);
		WorldDirection = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, Deproject_WorldDirection_Offset), 0, Deproject_WorldDirection_PropertyAddress.Address);
	}

	static UCanvas()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCanvas)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCanvas));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Engine.Canvas");
		ClippedTextSize_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "K2_TextSize");
		ClippedTextSize_ParamsSize = NativeReflection.GetFunctionParamsSize(ClippedTextSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClippedTextSize_RenderFont_PropertyAddress, ClippedTextSize_FunctionAddress, "RenderFont");
		ClippedTextSize_RenderFont_Offset = NativeReflectionCached.GetPropertyOffset(ClippedTextSize_FunctionAddress, "RenderFont");
		ClippedTextSize_RenderFont_IsValid = NativeReflectionCached.ValidatePropertyClass(ClippedTextSize_FunctionAddress, "RenderFont", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ClippedTextSize_RenderText_PropertyAddress, ClippedTextSize_FunctionAddress, "RenderText");
		ClippedTextSize_RenderText_Offset = NativeReflectionCached.GetPropertyOffset(ClippedTextSize_FunctionAddress, "RenderText");
		ClippedTextSize_RenderText_IsValid = NativeReflectionCached.ValidatePropertyClass(ClippedTextSize_FunctionAddress, "RenderText", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ClippedTextSize_Scale_PropertyAddress, ClippedTextSize_FunctionAddress, "Scale");
		ClippedTextSize_Scale_Offset = NativeReflectionCached.GetPropertyOffset(ClippedTextSize_FunctionAddress, "Scale");
		ClippedTextSize_Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(ClippedTextSize_FunctionAddress, "Scale", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ClippedTextSize_ReturnValue_PropertyAddress, ClippedTextSize_FunctionAddress, "ReturnValue");
		ClippedTextSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ClippedTextSize_FunctionAddress, "ReturnValue");
		ClippedTextSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ClippedTextSize_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		ClippedTextSize_IsValid = ClippedTextSize_FunctionAddress != IntPtr.Zero && ClippedTextSize_RenderFont_IsValid && ClippedTextSize_RenderText_IsValid && ClippedTextSize_Scale_IsValid && ClippedTextSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Canvas:K2_TextSize", ClippedTextSize_IsValid);
		WrappedTextSize_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "K2_StrLen");
		WrappedTextSize_ParamsSize = NativeReflection.GetFunctionParamsSize(WrappedTextSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref WrappedTextSize_RenderFont_PropertyAddress, WrappedTextSize_FunctionAddress, "RenderFont");
		WrappedTextSize_RenderFont_Offset = NativeReflectionCached.GetPropertyOffset(WrappedTextSize_FunctionAddress, "RenderFont");
		WrappedTextSize_RenderFont_IsValid = NativeReflectionCached.ValidatePropertyClass(WrappedTextSize_FunctionAddress, "RenderFont", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref WrappedTextSize_RenderText_PropertyAddress, WrappedTextSize_FunctionAddress, "RenderText");
		WrappedTextSize_RenderText_Offset = NativeReflectionCached.GetPropertyOffset(WrappedTextSize_FunctionAddress, "RenderText");
		WrappedTextSize_RenderText_IsValid = NativeReflectionCached.ValidatePropertyClass(WrappedTextSize_FunctionAddress, "RenderText", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref WrappedTextSize_ReturnValue_PropertyAddress, WrappedTextSize_FunctionAddress, "ReturnValue");
		WrappedTextSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(WrappedTextSize_FunctionAddress, "ReturnValue");
		WrappedTextSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(WrappedTextSize_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		WrappedTextSize_IsValid = WrappedTextSize_FunctionAddress != IntPtr.Zero && WrappedTextSize_RenderFont_IsValid && WrappedTextSize_RenderText_IsValid && WrappedTextSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Canvas:K2_StrLen", WrappedTextSize_IsValid);
		Project_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "K2_Project");
		Project_ParamsSize = NativeReflection.GetFunctionParamsSize(Project_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Project_WorldLocation_PropertyAddress, Project_FunctionAddress, "WorldLocation");
		Project_WorldLocation_Offset = NativeReflectionCached.GetPropertyOffset(Project_FunctionAddress, "WorldLocation");
		Project_WorldLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(Project_FunctionAddress, "WorldLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Project_ReturnValue_PropertyAddress, Project_FunctionAddress, "ReturnValue");
		Project_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Project_FunctionAddress, "ReturnValue");
		Project_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Project_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		Project_IsValid = Project_FunctionAddress != IntPtr.Zero && Project_WorldLocation_IsValid && Project_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Canvas:K2_Project", Project_IsValid);
		DrawTriangles_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "K2_DrawTriangle");
		DrawTriangles_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawTriangles_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawTriangles_RenderTexture_PropertyAddress, DrawTriangles_FunctionAddress, "RenderTexture");
		DrawTriangles_RenderTexture_Offset = NativeReflectionCached.GetPropertyOffset(DrawTriangles_FunctionAddress, "RenderTexture");
		DrawTriangles_RenderTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawTriangles_FunctionAddress, "RenderTexture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawTriangles_Triangles_PropertyAddress, DrawTriangles_FunctionAddress, "Triangles");
		DrawTriangles_Triangles_Offset = NativeReflectionCached.GetPropertyOffset(DrawTriangles_FunctionAddress, "Triangles");
		DrawTriangles_Triangles_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawTriangles_FunctionAddress, "Triangles", Classes.FArrayProperty);
		DrawTriangles_IsValid = DrawTriangles_FunctionAddress != IntPtr.Zero && DrawTriangles_RenderTexture_IsValid && DrawTriangles_Triangles_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Canvas:K2_DrawTriangle", DrawTriangles_IsValid);
		DrawTexture_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "K2_DrawTexture");
		DrawTexture_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawTexture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawTexture_RenderTexture_PropertyAddress, DrawTexture_FunctionAddress, "RenderTexture");
		DrawTexture_RenderTexture_Offset = NativeReflectionCached.GetPropertyOffset(DrawTexture_FunctionAddress, "RenderTexture");
		DrawTexture_RenderTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawTexture_FunctionAddress, "RenderTexture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawTexture_ScreenPosition_PropertyAddress, DrawTexture_FunctionAddress, "ScreenPosition");
		DrawTexture_ScreenPosition_Offset = NativeReflectionCached.GetPropertyOffset(DrawTexture_FunctionAddress, "ScreenPosition");
		DrawTexture_ScreenPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawTexture_FunctionAddress, "ScreenPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawTexture_ScreenSize_PropertyAddress, DrawTexture_FunctionAddress, "ScreenSize");
		DrawTexture_ScreenSize_Offset = NativeReflectionCached.GetPropertyOffset(DrawTexture_FunctionAddress, "ScreenSize");
		DrawTexture_ScreenSize_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawTexture_FunctionAddress, "ScreenSize", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawTexture_CoordinatePosition_PropertyAddress, DrawTexture_FunctionAddress, "CoordinatePosition");
		DrawTexture_CoordinatePosition_Offset = NativeReflectionCached.GetPropertyOffset(DrawTexture_FunctionAddress, "CoordinatePosition");
		DrawTexture_CoordinatePosition_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawTexture_FunctionAddress, "CoordinatePosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawTexture_CoordinateSize_PropertyAddress, DrawTexture_FunctionAddress, "CoordinateSize");
		DrawTexture_CoordinateSize_Offset = NativeReflectionCached.GetPropertyOffset(DrawTexture_FunctionAddress, "CoordinateSize");
		DrawTexture_CoordinateSize_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawTexture_FunctionAddress, "CoordinateSize", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawTexture_RenderColor_PropertyAddress, DrawTexture_FunctionAddress, "RenderColor");
		DrawTexture_RenderColor_Offset = NativeReflectionCached.GetPropertyOffset(DrawTexture_FunctionAddress, "RenderColor");
		DrawTexture_RenderColor_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawTexture_FunctionAddress, "RenderColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawTexture_BlendMode_PropertyAddress, DrawTexture_FunctionAddress, "BlendMode");
		DrawTexture_BlendMode_Offset = NativeReflectionCached.GetPropertyOffset(DrawTexture_FunctionAddress, "BlendMode");
		DrawTexture_BlendMode_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawTexture_FunctionAddress, "BlendMode", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawTexture_Rotation_PropertyAddress, DrawTexture_FunctionAddress, "Rotation");
		DrawTexture_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(DrawTexture_FunctionAddress, "Rotation");
		DrawTexture_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawTexture_FunctionAddress, "Rotation", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawTexture_PivotPoint_PropertyAddress, DrawTexture_FunctionAddress, "PivotPoint");
		DrawTexture_PivotPoint_Offset = NativeReflectionCached.GetPropertyOffset(DrawTexture_FunctionAddress, "PivotPoint");
		DrawTexture_PivotPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawTexture_FunctionAddress, "PivotPoint", Classes.FStructProperty);
		DrawTexture_IsValid = DrawTexture_FunctionAddress != IntPtr.Zero && DrawTexture_RenderTexture_IsValid && DrawTexture_ScreenPosition_IsValid && DrawTexture_ScreenSize_IsValid && DrawTexture_CoordinatePosition_IsValid && DrawTexture_CoordinateSize_IsValid && DrawTexture_RenderColor_IsValid && DrawTexture_BlendMode_IsValid && DrawTexture_Rotation_IsValid && DrawTexture_PivotPoint_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Canvas:K2_DrawTexture", DrawTexture_IsValid);
		DrawText_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "K2_DrawText");
		DrawText_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawText_RenderFont_PropertyAddress, DrawText_FunctionAddress, "RenderFont");
		DrawText_RenderFont_Offset = NativeReflectionCached.GetPropertyOffset(DrawText_FunctionAddress, "RenderFont");
		DrawText_RenderFont_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawText_FunctionAddress, "RenderFont", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawText_RenderText_PropertyAddress, DrawText_FunctionAddress, "RenderText");
		DrawText_RenderText_Offset = NativeReflectionCached.GetPropertyOffset(DrawText_FunctionAddress, "RenderText");
		DrawText_RenderText_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawText_FunctionAddress, "RenderText", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawText_ScreenPosition_PropertyAddress, DrawText_FunctionAddress, "ScreenPosition");
		DrawText_ScreenPosition_Offset = NativeReflectionCached.GetPropertyOffset(DrawText_FunctionAddress, "ScreenPosition");
		DrawText_ScreenPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawText_FunctionAddress, "ScreenPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawText_Scale_PropertyAddress, DrawText_FunctionAddress, "Scale");
		DrawText_Scale_Offset = NativeReflectionCached.GetPropertyOffset(DrawText_FunctionAddress, "Scale");
		DrawText_Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawText_FunctionAddress, "Scale", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawText_RenderColor_PropertyAddress, DrawText_FunctionAddress, "RenderColor");
		DrawText_RenderColor_Offset = NativeReflectionCached.GetPropertyOffset(DrawText_FunctionAddress, "RenderColor");
		DrawText_RenderColor_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawText_FunctionAddress, "RenderColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawText_Kerning_PropertyAddress, DrawText_FunctionAddress, "Kerning");
		DrawText_Kerning_Offset = NativeReflectionCached.GetPropertyOffset(DrawText_FunctionAddress, "Kerning");
		DrawText_Kerning_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawText_FunctionAddress, "Kerning", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawText_ShadowColor_PropertyAddress, DrawText_FunctionAddress, "ShadowColor");
		DrawText_ShadowColor_Offset = NativeReflectionCached.GetPropertyOffset(DrawText_FunctionAddress, "ShadowColor");
		DrawText_ShadowColor_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawText_FunctionAddress, "ShadowColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawText_ShadowOffset_PropertyAddress, DrawText_FunctionAddress, "ShadowOffset");
		DrawText_ShadowOffset_Offset = NativeReflectionCached.GetPropertyOffset(DrawText_FunctionAddress, "ShadowOffset");
		DrawText_ShadowOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawText_FunctionAddress, "ShadowOffset", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawText_bCentreX_PropertyAddress, DrawText_FunctionAddress, "bCentreX");
		DrawText_bCentreX_Offset = NativeReflectionCached.GetPropertyOffset(DrawText_FunctionAddress, "bCentreX");
		DrawText_bCentreX_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawText_FunctionAddress, "bCentreX", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawText_bCentreY_PropertyAddress, DrawText_FunctionAddress, "bCentreY");
		DrawText_bCentreY_Offset = NativeReflectionCached.GetPropertyOffset(DrawText_FunctionAddress, "bCentreY");
		DrawText_bCentreY_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawText_FunctionAddress, "bCentreY", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawText_bOutlined_PropertyAddress, DrawText_FunctionAddress, "bOutlined");
		DrawText_bOutlined_Offset = NativeReflectionCached.GetPropertyOffset(DrawText_FunctionAddress, "bOutlined");
		DrawText_bOutlined_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawText_FunctionAddress, "bOutlined", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawText_OutlineColor_PropertyAddress, DrawText_FunctionAddress, "OutlineColor");
		DrawText_OutlineColor_Offset = NativeReflectionCached.GetPropertyOffset(DrawText_FunctionAddress, "OutlineColor");
		DrawText_OutlineColor_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawText_FunctionAddress, "OutlineColor", Classes.FStructProperty);
		DrawText_IsValid = DrawText_FunctionAddress != IntPtr.Zero && DrawText_RenderFont_IsValid && DrawText_RenderText_IsValid && DrawText_ScreenPosition_IsValid && DrawText_Scale_IsValid && DrawText_RenderColor_IsValid && DrawText_Kerning_IsValid && DrawText_ShadowColor_IsValid && DrawText_ShadowOffset_IsValid && DrawText_bCentreX_IsValid && DrawText_bCentreY_IsValid && DrawText_bOutlined_IsValid && DrawText_OutlineColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Canvas:K2_DrawText", DrawText_IsValid);
		DrawPolygon_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "K2_DrawPolygon");
		DrawPolygon_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawPolygon_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawPolygon_RenderTexture_PropertyAddress, DrawPolygon_FunctionAddress, "RenderTexture");
		DrawPolygon_RenderTexture_Offset = NativeReflectionCached.GetPropertyOffset(DrawPolygon_FunctionAddress, "RenderTexture");
		DrawPolygon_RenderTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawPolygon_FunctionAddress, "RenderTexture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawPolygon_ScreenPosition_PropertyAddress, DrawPolygon_FunctionAddress, "ScreenPosition");
		DrawPolygon_ScreenPosition_Offset = NativeReflectionCached.GetPropertyOffset(DrawPolygon_FunctionAddress, "ScreenPosition");
		DrawPolygon_ScreenPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawPolygon_FunctionAddress, "ScreenPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawPolygon_Radius_PropertyAddress, DrawPolygon_FunctionAddress, "Radius");
		DrawPolygon_Radius_Offset = NativeReflectionCached.GetPropertyOffset(DrawPolygon_FunctionAddress, "Radius");
		DrawPolygon_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawPolygon_FunctionAddress, "Radius", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawPolygon_NumberOfSides_PropertyAddress, DrawPolygon_FunctionAddress, "NumberOfSides");
		DrawPolygon_NumberOfSides_Offset = NativeReflectionCached.GetPropertyOffset(DrawPolygon_FunctionAddress, "NumberOfSides");
		DrawPolygon_NumberOfSides_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawPolygon_FunctionAddress, "NumberOfSides", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawPolygon_RenderColor_PropertyAddress, DrawPolygon_FunctionAddress, "RenderColor");
		DrawPolygon_RenderColor_Offset = NativeReflectionCached.GetPropertyOffset(DrawPolygon_FunctionAddress, "RenderColor");
		DrawPolygon_RenderColor_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawPolygon_FunctionAddress, "RenderColor", Classes.FStructProperty);
		DrawPolygon_IsValid = DrawPolygon_FunctionAddress != IntPtr.Zero && DrawPolygon_RenderTexture_IsValid && DrawPolygon_ScreenPosition_IsValid && DrawPolygon_Radius_IsValid && DrawPolygon_NumberOfSides_IsValid && DrawPolygon_RenderColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Canvas:K2_DrawPolygon", DrawPolygon_IsValid);
		DrawMaterialTriangles_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "K2_DrawMaterialTriangle");
		DrawMaterialTriangles_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawMaterialTriangles_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterialTriangles_RenderMaterial_PropertyAddress, DrawMaterialTriangles_FunctionAddress, "RenderMaterial");
		DrawMaterialTriangles_RenderMaterial_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterialTriangles_FunctionAddress, "RenderMaterial");
		DrawMaterialTriangles_RenderMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterialTriangles_FunctionAddress, "RenderMaterial", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterialTriangles_Triangles_PropertyAddress, DrawMaterialTriangles_FunctionAddress, "Triangles");
		DrawMaterialTriangles_Triangles_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterialTriangles_FunctionAddress, "Triangles");
		DrawMaterialTriangles_Triangles_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterialTriangles_FunctionAddress, "Triangles", Classes.FArrayProperty);
		DrawMaterialTriangles_IsValid = DrawMaterialTriangles_FunctionAddress != IntPtr.Zero && DrawMaterialTriangles_RenderMaterial_IsValid && DrawMaterialTriangles_Triangles_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Canvas:K2_DrawMaterialTriangle", DrawMaterialTriangles_IsValid);
		DrawMaterial_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "K2_DrawMaterial");
		DrawMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterial_RenderMaterial_PropertyAddress, DrawMaterial_FunctionAddress, "RenderMaterial");
		DrawMaterial_RenderMaterial_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterial_FunctionAddress, "RenderMaterial");
		DrawMaterial_RenderMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterial_FunctionAddress, "RenderMaterial", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterial_ScreenPosition_PropertyAddress, DrawMaterial_FunctionAddress, "ScreenPosition");
		DrawMaterial_ScreenPosition_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterial_FunctionAddress, "ScreenPosition");
		DrawMaterial_ScreenPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterial_FunctionAddress, "ScreenPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterial_ScreenSize_PropertyAddress, DrawMaterial_FunctionAddress, "ScreenSize");
		DrawMaterial_ScreenSize_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterial_FunctionAddress, "ScreenSize");
		DrawMaterial_ScreenSize_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterial_FunctionAddress, "ScreenSize", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterial_CoordinatePosition_PropertyAddress, DrawMaterial_FunctionAddress, "CoordinatePosition");
		DrawMaterial_CoordinatePosition_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterial_FunctionAddress, "CoordinatePosition");
		DrawMaterial_CoordinatePosition_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterial_FunctionAddress, "CoordinatePosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterial_CoordinateSize_PropertyAddress, DrawMaterial_FunctionAddress, "CoordinateSize");
		DrawMaterial_CoordinateSize_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterial_FunctionAddress, "CoordinateSize");
		DrawMaterial_CoordinateSize_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterial_FunctionAddress, "CoordinateSize", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterial_Rotation_PropertyAddress, DrawMaterial_FunctionAddress, "Rotation");
		DrawMaterial_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterial_FunctionAddress, "Rotation");
		DrawMaterial_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterial_FunctionAddress, "Rotation", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterial_PivotPoint_PropertyAddress, DrawMaterial_FunctionAddress, "PivotPoint");
		DrawMaterial_PivotPoint_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterial_FunctionAddress, "PivotPoint");
		DrawMaterial_PivotPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterial_FunctionAddress, "PivotPoint", Classes.FStructProperty);
		DrawMaterial_IsValid = DrawMaterial_FunctionAddress != IntPtr.Zero && DrawMaterial_RenderMaterial_IsValid && DrawMaterial_ScreenPosition_IsValid && DrawMaterial_ScreenSize_IsValid && DrawMaterial_CoordinatePosition_IsValid && DrawMaterial_CoordinateSize_IsValid && DrawMaterial_Rotation_IsValid && DrawMaterial_PivotPoint_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Canvas:K2_DrawMaterial", DrawMaterial_IsValid);
		DrawLine_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "K2_DrawLine");
		DrawLine_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawLine_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawLine_ScreenPositionA_PropertyAddress, DrawLine_FunctionAddress, "ScreenPositionA");
		DrawLine_ScreenPositionA_Offset = NativeReflectionCached.GetPropertyOffset(DrawLine_FunctionAddress, "ScreenPositionA");
		DrawLine_ScreenPositionA_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawLine_FunctionAddress, "ScreenPositionA", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawLine_ScreenPositionB_PropertyAddress, DrawLine_FunctionAddress, "ScreenPositionB");
		DrawLine_ScreenPositionB_Offset = NativeReflectionCached.GetPropertyOffset(DrawLine_FunctionAddress, "ScreenPositionB");
		DrawLine_ScreenPositionB_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawLine_FunctionAddress, "ScreenPositionB", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawLine_Thickness_PropertyAddress, DrawLine_FunctionAddress, "Thickness");
		DrawLine_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(DrawLine_FunctionAddress, "Thickness");
		DrawLine_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawLine_FunctionAddress, "Thickness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawLine_RenderColor_PropertyAddress, DrawLine_FunctionAddress, "RenderColor");
		DrawLine_RenderColor_Offset = NativeReflectionCached.GetPropertyOffset(DrawLine_FunctionAddress, "RenderColor");
		DrawLine_RenderColor_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawLine_FunctionAddress, "RenderColor", Classes.FStructProperty);
		DrawLine_IsValid = DrawLine_FunctionAddress != IntPtr.Zero && DrawLine_ScreenPositionA_IsValid && DrawLine_ScreenPositionB_IsValid && DrawLine_Thickness_IsValid && DrawLine_RenderColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Canvas:K2_DrawLine", DrawLine_IsValid);
		DrawBox_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "K2_DrawBox");
		DrawBox_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawBox_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawBox_ScreenPosition_PropertyAddress, DrawBox_FunctionAddress, "ScreenPosition");
		DrawBox_ScreenPosition_Offset = NativeReflectionCached.GetPropertyOffset(DrawBox_FunctionAddress, "ScreenPosition");
		DrawBox_ScreenPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawBox_FunctionAddress, "ScreenPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawBox_ScreenSize_PropertyAddress, DrawBox_FunctionAddress, "ScreenSize");
		DrawBox_ScreenSize_Offset = NativeReflectionCached.GetPropertyOffset(DrawBox_FunctionAddress, "ScreenSize");
		DrawBox_ScreenSize_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawBox_FunctionAddress, "ScreenSize", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawBox_Thickness_PropertyAddress, DrawBox_FunctionAddress, "Thickness");
		DrawBox_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(DrawBox_FunctionAddress, "Thickness");
		DrawBox_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawBox_FunctionAddress, "Thickness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawBox_RenderColor_PropertyAddress, DrawBox_FunctionAddress, "RenderColor");
		DrawBox_RenderColor_Offset = NativeReflectionCached.GetPropertyOffset(DrawBox_FunctionAddress, "RenderColor");
		DrawBox_RenderColor_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawBox_FunctionAddress, "RenderColor", Classes.FStructProperty);
		DrawBox_IsValid = DrawBox_FunctionAddress != IntPtr.Zero && DrawBox_ScreenPosition_IsValid && DrawBox_ScreenSize_IsValid && DrawBox_Thickness_IsValid && DrawBox_RenderColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Canvas:K2_DrawBox", DrawBox_IsValid);
		DrawBorder_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "K2_DrawBorder");
		DrawBorder_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawBorder_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawBorder_BorderTexture_PropertyAddress, DrawBorder_FunctionAddress, "BorderTexture");
		DrawBorder_BorderTexture_Offset = NativeReflectionCached.GetPropertyOffset(DrawBorder_FunctionAddress, "BorderTexture");
		DrawBorder_BorderTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawBorder_FunctionAddress, "BorderTexture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawBorder_BackgroundTexture_PropertyAddress, DrawBorder_FunctionAddress, "BackgroundTexture");
		DrawBorder_BackgroundTexture_Offset = NativeReflectionCached.GetPropertyOffset(DrawBorder_FunctionAddress, "BackgroundTexture");
		DrawBorder_BackgroundTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawBorder_FunctionAddress, "BackgroundTexture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawBorder_LeftBorderTexture_PropertyAddress, DrawBorder_FunctionAddress, "LeftBorderTexture");
		DrawBorder_LeftBorderTexture_Offset = NativeReflectionCached.GetPropertyOffset(DrawBorder_FunctionAddress, "LeftBorderTexture");
		DrawBorder_LeftBorderTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawBorder_FunctionAddress, "LeftBorderTexture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawBorder_RightBorderTexture_PropertyAddress, DrawBorder_FunctionAddress, "RightBorderTexture");
		DrawBorder_RightBorderTexture_Offset = NativeReflectionCached.GetPropertyOffset(DrawBorder_FunctionAddress, "RightBorderTexture");
		DrawBorder_RightBorderTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawBorder_FunctionAddress, "RightBorderTexture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawBorder_TopBorderTexture_PropertyAddress, DrawBorder_FunctionAddress, "TopBorderTexture");
		DrawBorder_TopBorderTexture_Offset = NativeReflectionCached.GetPropertyOffset(DrawBorder_FunctionAddress, "TopBorderTexture");
		DrawBorder_TopBorderTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawBorder_FunctionAddress, "TopBorderTexture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawBorder_BottomBorderTexture_PropertyAddress, DrawBorder_FunctionAddress, "BottomBorderTexture");
		DrawBorder_BottomBorderTexture_Offset = NativeReflectionCached.GetPropertyOffset(DrawBorder_FunctionAddress, "BottomBorderTexture");
		DrawBorder_BottomBorderTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawBorder_FunctionAddress, "BottomBorderTexture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawBorder_ScreenPosition_PropertyAddress, DrawBorder_FunctionAddress, "ScreenPosition");
		DrawBorder_ScreenPosition_Offset = NativeReflectionCached.GetPropertyOffset(DrawBorder_FunctionAddress, "ScreenPosition");
		DrawBorder_ScreenPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawBorder_FunctionAddress, "ScreenPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawBorder_ScreenSize_PropertyAddress, DrawBorder_FunctionAddress, "ScreenSize");
		DrawBorder_ScreenSize_Offset = NativeReflectionCached.GetPropertyOffset(DrawBorder_FunctionAddress, "ScreenSize");
		DrawBorder_ScreenSize_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawBorder_FunctionAddress, "ScreenSize", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawBorder_CoordinatePosition_PropertyAddress, DrawBorder_FunctionAddress, "CoordinatePosition");
		DrawBorder_CoordinatePosition_Offset = NativeReflectionCached.GetPropertyOffset(DrawBorder_FunctionAddress, "CoordinatePosition");
		DrawBorder_CoordinatePosition_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawBorder_FunctionAddress, "CoordinatePosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawBorder_CoordinateSize_PropertyAddress, DrawBorder_FunctionAddress, "CoordinateSize");
		DrawBorder_CoordinateSize_Offset = NativeReflectionCached.GetPropertyOffset(DrawBorder_FunctionAddress, "CoordinateSize");
		DrawBorder_CoordinateSize_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawBorder_FunctionAddress, "CoordinateSize", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawBorder_RenderColor_PropertyAddress, DrawBorder_FunctionAddress, "RenderColor");
		DrawBorder_RenderColor_Offset = NativeReflectionCached.GetPropertyOffset(DrawBorder_FunctionAddress, "RenderColor");
		DrawBorder_RenderColor_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawBorder_FunctionAddress, "RenderColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawBorder_BorderScale_PropertyAddress, DrawBorder_FunctionAddress, "BorderScale");
		DrawBorder_BorderScale_Offset = NativeReflectionCached.GetPropertyOffset(DrawBorder_FunctionAddress, "BorderScale");
		DrawBorder_BorderScale_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawBorder_FunctionAddress, "BorderScale", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawBorder_BackgroundScale_PropertyAddress, DrawBorder_FunctionAddress, "BackgroundScale");
		DrawBorder_BackgroundScale_Offset = NativeReflectionCached.GetPropertyOffset(DrawBorder_FunctionAddress, "BackgroundScale");
		DrawBorder_BackgroundScale_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawBorder_FunctionAddress, "BackgroundScale", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawBorder_Rotation_PropertyAddress, DrawBorder_FunctionAddress, "Rotation");
		DrawBorder_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(DrawBorder_FunctionAddress, "Rotation");
		DrawBorder_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawBorder_FunctionAddress, "Rotation", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawBorder_PivotPoint_PropertyAddress, DrawBorder_FunctionAddress, "PivotPoint");
		DrawBorder_PivotPoint_Offset = NativeReflectionCached.GetPropertyOffset(DrawBorder_FunctionAddress, "PivotPoint");
		DrawBorder_PivotPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawBorder_FunctionAddress, "PivotPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawBorder_CornerSize_PropertyAddress, DrawBorder_FunctionAddress, "CornerSize");
		DrawBorder_CornerSize_Offset = NativeReflectionCached.GetPropertyOffset(DrawBorder_FunctionAddress, "CornerSize");
		DrawBorder_CornerSize_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawBorder_FunctionAddress, "CornerSize", Classes.FStructProperty);
		DrawBorder_IsValid = DrawBorder_FunctionAddress != IntPtr.Zero && DrawBorder_BorderTexture_IsValid && DrawBorder_BackgroundTexture_IsValid && DrawBorder_LeftBorderTexture_IsValid && DrawBorder_RightBorderTexture_IsValid && DrawBorder_TopBorderTexture_IsValid && DrawBorder_BottomBorderTexture_IsValid && DrawBorder_ScreenPosition_IsValid && DrawBorder_ScreenSize_IsValid && DrawBorder_CoordinatePosition_IsValid && DrawBorder_CoordinateSize_IsValid && DrawBorder_RenderColor_IsValid && DrawBorder_BorderScale_IsValid && DrawBorder_BackgroundScale_IsValid && DrawBorder_Rotation_IsValid && DrawBorder_PivotPoint_IsValid && DrawBorder_CornerSize_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Canvas:K2_DrawBorder", DrawBorder_IsValid);
		Deproject_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "K2_Deproject");
		Deproject_ParamsSize = NativeReflection.GetFunctionParamsSize(Deproject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Deproject_ScreenPosition_PropertyAddress, Deproject_FunctionAddress, "ScreenPosition");
		Deproject_ScreenPosition_Offset = NativeReflectionCached.GetPropertyOffset(Deproject_FunctionAddress, "ScreenPosition");
		Deproject_ScreenPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(Deproject_FunctionAddress, "ScreenPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Deproject_WorldOrigin_PropertyAddress, Deproject_FunctionAddress, "WorldOrigin");
		Deproject_WorldOrigin_Offset = NativeReflectionCached.GetPropertyOffset(Deproject_FunctionAddress, "WorldOrigin");
		Deproject_WorldOrigin_IsValid = NativeReflectionCached.ValidatePropertyClass(Deproject_FunctionAddress, "WorldOrigin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Deproject_WorldDirection_PropertyAddress, Deproject_FunctionAddress, "WorldDirection");
		Deproject_WorldDirection_Offset = NativeReflectionCached.GetPropertyOffset(Deproject_FunctionAddress, "WorldDirection");
		Deproject_WorldDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(Deproject_FunctionAddress, "WorldDirection", Classes.FStructProperty);
		Deproject_IsValid = Deproject_FunctionAddress != IntPtr.Zero && Deproject_ScreenPosition_IsValid && Deproject_WorldOrigin_IsValid && Deproject_WorldDirection_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Canvas:K2_Deproject", Deproject_IsValid);
	}
}
