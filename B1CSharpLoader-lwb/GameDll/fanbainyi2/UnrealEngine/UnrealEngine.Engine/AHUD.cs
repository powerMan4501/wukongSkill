using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938540uL, Config = "Game")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.HUD", "Engine", UnrealModuleType.Engine)]
public class AHUD : AActor
{
	private static bool PlayerOwner_IsValid;

	private static int PlayerOwner_Offset;

	private static bool LostFocusPaused_IsValid;

	private static FFieldAddress LostFocusPaused_PropertyAddress;

	private static int LostFocusPaused_Offset;

	private static bool ShowHUD_IsValid;

	private static FFieldAddress ShowHUD_PropertyAddress;

	private static int ShowHUD_Offset;

	private static bool ShowDebugInfo_IsValid;

	private static FFieldAddress ShowDebugInfo_PropertyAddress;

	private static int ShowDebugInfo_Offset;

	private static bool ShowHitBoxDebugInfo_IsValid;

	private static FFieldAddress ShowHitBoxDebugInfo_PropertyAddress;

	private static int ShowHitBoxDebugInfo_Offset;

	private static bool ShowOverlays_IsValid;

	private static FFieldAddress ShowOverlays_PropertyAddress;

	private static int ShowOverlays_Offset;

	private static bool EnableDebugTextShadow_IsValid;

	private static FFieldAddress EnableDebugTextShadow_PropertyAddress;

	private static int EnableDebugTextShadow_Offset;

	private static bool ReceiveHitBoxRelease_IsValid;

	private IntPtr ReceiveHitBoxRelease_InstanceFunctionAddress;

	private static IntPtr ReceiveHitBoxRelease_FunctionAddress;

	private static int ReceiveHitBoxRelease_ParamsSize;

	private static bool ReceiveHitBoxRelease_BoxName_IsValid;

	private static FFieldAddress ReceiveHitBoxRelease_BoxName_PropertyAddress;

	private static int ReceiveHitBoxRelease_BoxName_Offset;

	private static bool ReceiveHitBoxEndCursorOver_IsValid;

	private IntPtr ReceiveHitBoxEndCursorOver_InstanceFunctionAddress;

	private static IntPtr ReceiveHitBoxEndCursorOver_FunctionAddress;

	private static int ReceiveHitBoxEndCursorOver_ParamsSize;

	private static bool ReceiveHitBoxEndCursorOver_BoxName_IsValid;

	private static FFieldAddress ReceiveHitBoxEndCursorOver_BoxName_PropertyAddress;

	private static int ReceiveHitBoxEndCursorOver_BoxName_Offset;

	private static bool ReceiveHitBoxClick_IsValid;

	private IntPtr ReceiveHitBoxClick_InstanceFunctionAddress;

	private static IntPtr ReceiveHitBoxClick_FunctionAddress;

	private static int ReceiveHitBoxClick_ParamsSize;

	private static bool ReceiveHitBoxClick_BoxName_IsValid;

	private static FFieldAddress ReceiveHitBoxClick_BoxName_PropertyAddress;

	private static int ReceiveHitBoxClick_BoxName_Offset;

	private static bool ReceiveHitBoxBeginCursorOver_IsValid;

	private IntPtr ReceiveHitBoxBeginCursorOver_InstanceFunctionAddress;

	private static IntPtr ReceiveHitBoxBeginCursorOver_FunctionAddress;

	private static int ReceiveHitBoxBeginCursorOver_ParamsSize;

	private static bool ReceiveHitBoxBeginCursorOver_BoxName_IsValid;

	private static FFieldAddress ReceiveHitBoxBeginCursorOver_BoxName_PropertyAddress;

	private static int ReceiveHitBoxBeginCursorOver_BoxName_Offset;

	private static bool ReceiveDrawHUD_IsValid;

	private IntPtr ReceiveDrawHUD_InstanceFunctionAddress;

	private static IntPtr ReceiveDrawHUD_FunctionAddress;

	private static int ReceiveDrawHUD_ParamsSize;

	private static bool ReceiveDrawHUD_SizeX_IsValid;

	private static FFieldAddress ReceiveDrawHUD_SizeX_PropertyAddress;

	private static int ReceiveDrawHUD_SizeX_Offset;

	private static bool ReceiveDrawHUD_SizeY_IsValid;

	private static FFieldAddress ReceiveDrawHUD_SizeY_PropertyAddress;

	private static int ReceiveDrawHUD_SizeY_Offset;

	private static bool Project_IsValid;

	private static IntPtr Project_FunctionAddress;

	private static int Project_ParamsSize;

	private static bool Project_Location_IsValid;

	private static FFieldAddress Project_Location_PropertyAddress;

	private static int Project_Location_Offset;

	private static bool Project_bClampToZeroPlane_IsValid;

	private static FFieldAddress Project_bClampToZeroPlane_PropertyAddress;

	private static int Project_bClampToZeroPlane_Offset;

	private static bool Project_ReturnValue_IsValid;

	private static FFieldAddress Project_ReturnValue_PropertyAddress;

	private static int Project_ReturnValue_Offset;

	private static bool GetTextSize_IsValid;

	private static IntPtr GetTextSize_FunctionAddress;

	private static int GetTextSize_ParamsSize;

	private static bool GetTextSize_Text_IsValid;

	private static FFieldAddress GetTextSize_Text_PropertyAddress;

	private static int GetTextSize_Text_Offset;

	private static bool GetTextSize_OutWidth_IsValid;

	private static FFieldAddress GetTextSize_OutWidth_PropertyAddress;

	private static int GetTextSize_OutWidth_Offset;

	private static bool GetTextSize_OutHeight_IsValid;

	private static FFieldAddress GetTextSize_OutHeight_PropertyAddress;

	private static int GetTextSize_OutHeight_Offset;

	private static bool GetTextSize_Font_IsValid;

	private static FFieldAddress GetTextSize_Font_PropertyAddress;

	private static int GetTextSize_Font_Offset;

	private static bool GetTextSize_Scale_IsValid;

	private static FFieldAddress GetTextSize_Scale_PropertyAddress;

	private static int GetTextSize_Scale_Offset;

	private static bool GetOwningPlayerController_IsValid;

	private static IntPtr GetOwningPlayerController_FunctionAddress;

	private static int GetOwningPlayerController_ParamsSize;

	private static bool GetOwningPlayerController_ReturnValue_IsValid;

	private static FFieldAddress GetOwningPlayerController_ReturnValue_PropertyAddress;

	private static int GetOwningPlayerController_ReturnValue_Offset;

	private static bool GetOwningPawn_IsValid;

	private static IntPtr GetOwningPawn_FunctionAddress;

	private static int GetOwningPawn_ParamsSize;

	private static bool GetOwningPawn_ReturnValue_IsValid;

	private static FFieldAddress GetOwningPawn_ReturnValue_PropertyAddress;

	private static int GetOwningPawn_ReturnValue_Offset;

	private static bool GetActorsInSelectionRectangle_IsValid;

	private static IntPtr GetActorsInSelectionRectangle_FunctionAddress;

	private static int GetActorsInSelectionRectangle_ParamsSize;

	private static bool GetActorsInSelectionRectangle_ClassFilter_IsValid;

	private static FFieldAddress GetActorsInSelectionRectangle_ClassFilter_PropertyAddress;

	private static int GetActorsInSelectionRectangle_ClassFilter_Offset;

	private static bool GetActorsInSelectionRectangle_FirstPoint_IsValid;

	private static FFieldAddress GetActorsInSelectionRectangle_FirstPoint_PropertyAddress;

	private static int GetActorsInSelectionRectangle_FirstPoint_Offset;

	private static bool GetActorsInSelectionRectangle_SecondPoint_IsValid;

	private static FFieldAddress GetActorsInSelectionRectangle_SecondPoint_PropertyAddress;

	private static int GetActorsInSelectionRectangle_SecondPoint_Offset;

	private static bool GetActorsInSelectionRectangle_OutActors_IsValid;

	private static FFieldAddress GetActorsInSelectionRectangle_OutActors_PropertyAddress;

	private static int GetActorsInSelectionRectangle_OutActors_Offset;

	private static bool GetActorsInSelectionRectangle_bIncludeNonCollidingComponents_IsValid;

	private static FFieldAddress GetActorsInSelectionRectangle_bIncludeNonCollidingComponents_PropertyAddress;

	private static int GetActorsInSelectionRectangle_bIncludeNonCollidingComponents_Offset;

	private static bool GetActorsInSelectionRectangle_bActorMustBeFullyEnclosed_IsValid;

	private static FFieldAddress GetActorsInSelectionRectangle_bActorMustBeFullyEnclosed_PropertyAddress;

	private static int GetActorsInSelectionRectangle_bActorMustBeFullyEnclosed_Offset;

	private static bool DrawTextureSimple_IsValid;

	private static IntPtr DrawTextureSimple_FunctionAddress;

	private static int DrawTextureSimple_ParamsSize;

	private static bool DrawTextureSimple_Texture_IsValid;

	private static FFieldAddress DrawTextureSimple_Texture_PropertyAddress;

	private static int DrawTextureSimple_Texture_Offset;

	private static bool DrawTextureSimple_ScreenX_IsValid;

	private static FFieldAddress DrawTextureSimple_ScreenX_PropertyAddress;

	private static int DrawTextureSimple_ScreenX_Offset;

	private static bool DrawTextureSimple_ScreenY_IsValid;

	private static FFieldAddress DrawTextureSimple_ScreenY_PropertyAddress;

	private static int DrawTextureSimple_ScreenY_Offset;

	private static bool DrawTextureSimple_Scale_IsValid;

	private static FFieldAddress DrawTextureSimple_Scale_PropertyAddress;

	private static int DrawTextureSimple_Scale_Offset;

	private static bool DrawTextureSimple_bScalePosition_IsValid;

	private static FFieldAddress DrawTextureSimple_bScalePosition_PropertyAddress;

	private static int DrawTextureSimple_bScalePosition_Offset;

	private static bool DrawTexture_IsValid;

	private static IntPtr DrawTexture_FunctionAddress;

	private static int DrawTexture_ParamsSize;

	private static bool DrawTexture_Texture_IsValid;

	private static FFieldAddress DrawTexture_Texture_PropertyAddress;

	private static int DrawTexture_Texture_Offset;

	private static bool DrawTexture_ScreenX_IsValid;

	private static FFieldAddress DrawTexture_ScreenX_PropertyAddress;

	private static int DrawTexture_ScreenX_Offset;

	private static bool DrawTexture_ScreenY_IsValid;

	private static FFieldAddress DrawTexture_ScreenY_PropertyAddress;

	private static int DrawTexture_ScreenY_Offset;

	private static bool DrawTexture_ScreenW_IsValid;

	private static FFieldAddress DrawTexture_ScreenW_PropertyAddress;

	private static int DrawTexture_ScreenW_Offset;

	private static bool DrawTexture_ScreenH_IsValid;

	private static FFieldAddress DrawTexture_ScreenH_PropertyAddress;

	private static int DrawTexture_ScreenH_Offset;

	private static bool DrawTexture_TextureU_IsValid;

	private static FFieldAddress DrawTexture_TextureU_PropertyAddress;

	private static int DrawTexture_TextureU_Offset;

	private static bool DrawTexture_TextureV_IsValid;

	private static FFieldAddress DrawTexture_TextureV_PropertyAddress;

	private static int DrawTexture_TextureV_Offset;

	private static bool DrawTexture_TextureUWidth_IsValid;

	private static FFieldAddress DrawTexture_TextureUWidth_PropertyAddress;

	private static int DrawTexture_TextureUWidth_Offset;

	private static bool DrawTexture_TextureVHeight_IsValid;

	private static FFieldAddress DrawTexture_TextureVHeight_PropertyAddress;

	private static int DrawTexture_TextureVHeight_Offset;

	private static bool DrawTexture_TintColor_IsValid;

	private static FFieldAddress DrawTexture_TintColor_PropertyAddress;

	private static int DrawTexture_TintColor_Offset;

	private static bool DrawTexture_BlendMode_IsValid;

	private static FFieldAddress DrawTexture_BlendMode_PropertyAddress;

	private static int DrawTexture_BlendMode_Offset;

	private static bool DrawTexture_Scale_IsValid;

	private static FFieldAddress DrawTexture_Scale_PropertyAddress;

	private static int DrawTexture_Scale_Offset;

	private static bool DrawTexture_bScalePosition_IsValid;

	private static FFieldAddress DrawTexture_bScalePosition_PropertyAddress;

	private static int DrawTexture_bScalePosition_Offset;

	private static bool DrawTexture_Rotation_IsValid;

	private static FFieldAddress DrawTexture_Rotation_PropertyAddress;

	private static int DrawTexture_Rotation_Offset;

	private static bool DrawTexture_RotPivot_IsValid;

	private static FFieldAddress DrawTexture_RotPivot_PropertyAddress;

	private static int DrawTexture_RotPivot_Offset;

	private static bool DrawText_IsValid;

	private static IntPtr DrawText_FunctionAddress;

	private static int DrawText_ParamsSize;

	private static bool DrawText_Text_IsValid;

	private static FFieldAddress DrawText_Text_PropertyAddress;

	private static int DrawText_Text_Offset;

	private static bool DrawText_TextColor_IsValid;

	private static FFieldAddress DrawText_TextColor_PropertyAddress;

	private static int DrawText_TextColor_Offset;

	private static bool DrawText_ScreenX_IsValid;

	private static FFieldAddress DrawText_ScreenX_PropertyAddress;

	private static int DrawText_ScreenX_Offset;

	private static bool DrawText_ScreenY_IsValid;

	private static FFieldAddress DrawText_ScreenY_PropertyAddress;

	private static int DrawText_ScreenY_Offset;

	private static bool DrawText_Font_IsValid;

	private static FFieldAddress DrawText_Font_PropertyAddress;

	private static int DrawText_Font_Offset;

	private static bool DrawText_Scale_IsValid;

	private static FFieldAddress DrawText_Scale_PropertyAddress;

	private static int DrawText_Scale_Offset;

	private static bool DrawText_bScalePosition_IsValid;

	private static FFieldAddress DrawText_bScalePosition_PropertyAddress;

	private static int DrawText_bScalePosition_Offset;

	private static bool DrawRect_IsValid;

	private static IntPtr DrawRect_FunctionAddress;

	private static int DrawRect_ParamsSize;

	private static bool DrawRect_RectColor_IsValid;

	private static FFieldAddress DrawRect_RectColor_PropertyAddress;

	private static int DrawRect_RectColor_Offset;

	private static bool DrawRect_ScreenX_IsValid;

	private static FFieldAddress DrawRect_ScreenX_PropertyAddress;

	private static int DrawRect_ScreenX_Offset;

	private static bool DrawRect_ScreenY_IsValid;

	private static FFieldAddress DrawRect_ScreenY_PropertyAddress;

	private static int DrawRect_ScreenY_Offset;

	private static bool DrawRect_ScreenW_IsValid;

	private static FFieldAddress DrawRect_ScreenW_PropertyAddress;

	private static int DrawRect_ScreenW_Offset;

	private static bool DrawRect_ScreenH_IsValid;

	private static FFieldAddress DrawRect_ScreenH_PropertyAddress;

	private static int DrawRect_ScreenH_Offset;

	private static bool DrawMaterialTriangle_IsValid;

	private static IntPtr DrawMaterialTriangle_FunctionAddress;

	private static int DrawMaterialTriangle_ParamsSize;

	private static bool DrawMaterialTriangle_Material_IsValid;

	private static FFieldAddress DrawMaterialTriangle_Material_PropertyAddress;

	private static int DrawMaterialTriangle_Material_Offset;

	private static bool DrawMaterialTriangle_V0_Pos_IsValid;

	private static FFieldAddress DrawMaterialTriangle_V0_Pos_PropertyAddress;

	private static int DrawMaterialTriangle_V0_Pos_Offset;

	private static bool DrawMaterialTriangle_V1_Pos_IsValid;

	private static FFieldAddress DrawMaterialTriangle_V1_Pos_PropertyAddress;

	private static int DrawMaterialTriangle_V1_Pos_Offset;

	private static bool DrawMaterialTriangle_V2_Pos_IsValid;

	private static FFieldAddress DrawMaterialTriangle_V2_Pos_PropertyAddress;

	private static int DrawMaterialTriangle_V2_Pos_Offset;

	private static bool DrawMaterialTriangle_V0_UV_IsValid;

	private static FFieldAddress DrawMaterialTriangle_V0_UV_PropertyAddress;

	private static int DrawMaterialTriangle_V0_UV_Offset;

	private static bool DrawMaterialTriangle_V1_UV_IsValid;

	private static FFieldAddress DrawMaterialTriangle_V1_UV_PropertyAddress;

	private static int DrawMaterialTriangle_V1_UV_Offset;

	private static bool DrawMaterialTriangle_V2_UV_IsValid;

	private static FFieldAddress DrawMaterialTriangle_V2_UV_PropertyAddress;

	private static int DrawMaterialTriangle_V2_UV_Offset;

	private static bool DrawMaterialTriangle_V0_Color_IsValid;

	private static FFieldAddress DrawMaterialTriangle_V0_Color_PropertyAddress;

	private static int DrawMaterialTriangle_V0_Color_Offset;

	private static bool DrawMaterialTriangle_V1_Color_IsValid;

	private static FFieldAddress DrawMaterialTriangle_V1_Color_PropertyAddress;

	private static int DrawMaterialTriangle_V1_Color_Offset;

	private static bool DrawMaterialTriangle_V2_Color_IsValid;

	private static FFieldAddress DrawMaterialTriangle_V2_Color_PropertyAddress;

	private static int DrawMaterialTriangle_V2_Color_Offset;

	private static bool DrawMaterialSimple_IsValid;

	private static IntPtr DrawMaterialSimple_FunctionAddress;

	private static int DrawMaterialSimple_ParamsSize;

	private static bool DrawMaterialSimple_Material_IsValid;

	private static FFieldAddress DrawMaterialSimple_Material_PropertyAddress;

	private static int DrawMaterialSimple_Material_Offset;

	private static bool DrawMaterialSimple_ScreenX_IsValid;

	private static FFieldAddress DrawMaterialSimple_ScreenX_PropertyAddress;

	private static int DrawMaterialSimple_ScreenX_Offset;

	private static bool DrawMaterialSimple_ScreenY_IsValid;

	private static FFieldAddress DrawMaterialSimple_ScreenY_PropertyAddress;

	private static int DrawMaterialSimple_ScreenY_Offset;

	private static bool DrawMaterialSimple_ScreenW_IsValid;

	private static FFieldAddress DrawMaterialSimple_ScreenW_PropertyAddress;

	private static int DrawMaterialSimple_ScreenW_Offset;

	private static bool DrawMaterialSimple_ScreenH_IsValid;

	private static FFieldAddress DrawMaterialSimple_ScreenH_PropertyAddress;

	private static int DrawMaterialSimple_ScreenH_Offset;

	private static bool DrawMaterialSimple_Scale_IsValid;

	private static FFieldAddress DrawMaterialSimple_Scale_PropertyAddress;

	private static int DrawMaterialSimple_Scale_Offset;

	private static bool DrawMaterialSimple_bScalePosition_IsValid;

	private static FFieldAddress DrawMaterialSimple_bScalePosition_PropertyAddress;

	private static int DrawMaterialSimple_bScalePosition_Offset;

	private static bool DrawMaterial_IsValid;

	private static IntPtr DrawMaterial_FunctionAddress;

	private static int DrawMaterial_ParamsSize;

	private static bool DrawMaterial_Material_IsValid;

	private static FFieldAddress DrawMaterial_Material_PropertyAddress;

	private static int DrawMaterial_Material_Offset;

	private static bool DrawMaterial_ScreenX_IsValid;

	private static FFieldAddress DrawMaterial_ScreenX_PropertyAddress;

	private static int DrawMaterial_ScreenX_Offset;

	private static bool DrawMaterial_ScreenY_IsValid;

	private static FFieldAddress DrawMaterial_ScreenY_PropertyAddress;

	private static int DrawMaterial_ScreenY_Offset;

	private static bool DrawMaterial_ScreenW_IsValid;

	private static FFieldAddress DrawMaterial_ScreenW_PropertyAddress;

	private static int DrawMaterial_ScreenW_Offset;

	private static bool DrawMaterial_ScreenH_IsValid;

	private static FFieldAddress DrawMaterial_ScreenH_PropertyAddress;

	private static int DrawMaterial_ScreenH_Offset;

	private static bool DrawMaterial_MaterialU_IsValid;

	private static FFieldAddress DrawMaterial_MaterialU_PropertyAddress;

	private static int DrawMaterial_MaterialU_Offset;

	private static bool DrawMaterial_MaterialV_IsValid;

	private static FFieldAddress DrawMaterial_MaterialV_PropertyAddress;

	private static int DrawMaterial_MaterialV_Offset;

	private static bool DrawMaterial_MaterialUWidth_IsValid;

	private static FFieldAddress DrawMaterial_MaterialUWidth_PropertyAddress;

	private static int DrawMaterial_MaterialUWidth_Offset;

	private static bool DrawMaterial_MaterialVHeight_IsValid;

	private static FFieldAddress DrawMaterial_MaterialVHeight_PropertyAddress;

	private static int DrawMaterial_MaterialVHeight_Offset;

	private static bool DrawMaterial_Scale_IsValid;

	private static FFieldAddress DrawMaterial_Scale_PropertyAddress;

	private static int DrawMaterial_Scale_Offset;

	private static bool DrawMaterial_bScalePosition_IsValid;

	private static FFieldAddress DrawMaterial_bScalePosition_PropertyAddress;

	private static int DrawMaterial_bScalePosition_Offset;

	private static bool DrawMaterial_Rotation_IsValid;

	private static FFieldAddress DrawMaterial_Rotation_PropertyAddress;

	private static int DrawMaterial_Rotation_Offset;

	private static bool DrawMaterial_RotPivot_IsValid;

	private static FFieldAddress DrawMaterial_RotPivot_PropertyAddress;

	private static int DrawMaterial_RotPivot_Offset;

	private static bool DrawLine_IsValid;

	private static IntPtr DrawLine_FunctionAddress;

	private static int DrawLine_ParamsSize;

	private static bool DrawLine_StartScreenX_IsValid;

	private static FFieldAddress DrawLine_StartScreenX_PropertyAddress;

	private static int DrawLine_StartScreenX_Offset;

	private static bool DrawLine_StartScreenY_IsValid;

	private static FFieldAddress DrawLine_StartScreenY_PropertyAddress;

	private static int DrawLine_StartScreenY_Offset;

	private static bool DrawLine_EndScreenX_IsValid;

	private static FFieldAddress DrawLine_EndScreenX_PropertyAddress;

	private static int DrawLine_EndScreenX_Offset;

	private static bool DrawLine_EndScreenY_IsValid;

	private static FFieldAddress DrawLine_EndScreenY_PropertyAddress;

	private static int DrawLine_EndScreenY_Offset;

	private static bool DrawLine_LineColor_IsValid;

	private static FFieldAddress DrawLine_LineColor_PropertyAddress;

	private static int DrawLine_LineColor_Offset;

	private static bool DrawLine_LineThickness_IsValid;

	private static FFieldAddress DrawLine_LineThickness_PropertyAddress;

	private static int DrawLine_LineThickness_Offset;

	private static bool Deproject_IsValid;

	private static IntPtr Deproject_FunctionAddress;

	private static int Deproject_ParamsSize;

	private static bool Deproject_ScreenX_IsValid;

	private static FFieldAddress Deproject_ScreenX_PropertyAddress;

	private static int Deproject_ScreenX_Offset;

	private static bool Deproject_ScreenY_IsValid;

	private static FFieldAddress Deproject_ScreenY_PropertyAddress;

	private static int Deproject_ScreenY_Offset;

	private static bool Deproject_WorldPosition_IsValid;

	private static FFieldAddress Deproject_WorldPosition_PropertyAddress;

	private static int Deproject_WorldPosition_Offset;

	private static bool Deproject_WorldDirection_IsValid;

	private static FFieldAddress Deproject_WorldDirection_PropertyAddress;

	private static int Deproject_WorldDirection_Offset;

	private static bool AddHitBox_IsValid;

	private static IntPtr AddHitBox_FunctionAddress;

	private static int AddHitBox_ParamsSize;

	private static bool AddHitBox_Position_IsValid;

	private static FFieldAddress AddHitBox_Position_PropertyAddress;

	private static int AddHitBox_Position_Offset;

	private static bool AddHitBox_Size_IsValid;

	private static FFieldAddress AddHitBox_Size_PropertyAddress;

	private static int AddHitBox_Size_Offset;

	private static bool AddHitBox_InName_IsValid;

	private static FFieldAddress AddHitBox_InName_PropertyAddress;

	private static int AddHitBox_InName_Offset;

	private static bool AddHitBox_bConsumesInput_IsValid;

	private static FFieldAddress AddHitBox_bConsumesInput_PropertyAddress;

	private static int AddHitBox_bConsumesInput_Offset;

	private static bool AddHitBox_Priority_IsValid;

	private static FFieldAddress AddHitBox_Priority_PropertyAddress;

	private static int AddHitBox_Priority_Offset;

	[UProperty(Flags = (PropFlags)7881369141117460uL)]
	[UMetaPath("/Script/Engine.HUD:PlayerOwner")]
	public APlayerController PlayerOwner
	{
		get
		{
			CheckDestroyed();
			if (!PlayerOwner_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.HUD:PlayerOwner");
				return null;
			}
			return UObjectMarshaler<APlayerController>.FromNative(IntPtr.Add(base.Address, PlayerOwner_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlayerOwner_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.HUD:PlayerOwner");
			}
			else
			{
				UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(base.Address, PlayerOwner_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532500uL)]
	[UMetaPath("/Script/Engine.HUD:bLostFocusPaused")]
	public bool LostFocusPaused
	{
		get
		{
			CheckDestroyed();
			if (!LostFocusPaused_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.HUD:bLostFocusPaused");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, LostFocusPaused_Offset), 0, LostFocusPaused_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LostFocusPaused_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.HUD:bLostFocusPaused");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, LostFocusPaused_Offset), 0, LostFocusPaused_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.HUD:bShowHUD")]
	public bool ShowHUD
	{
		get
		{
			CheckDestroyed();
			if (!ShowHUD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.HUD:bShowHUD");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ShowHUD_Offset), 0, ShowHUD_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShowHUD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.HUD:bShowHUD");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ShowHUD_Offset), 0, ShowHUD_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532484uL)]
	[UMetaPath("/Script/Engine.HUD:bShowDebugInfo")]
	public bool ShowDebugInfo
	{
		get
		{
			CheckDestroyed();
			if (!ShowDebugInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.HUD:bShowDebugInfo");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ShowDebugInfo_Offset), 0, ShowDebugInfo_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShowDebugInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.HUD:bShowDebugInfo");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ShowDebugInfo_Offset), 0, ShowDebugInfo_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532484uL)]
	[UMetaPath("/Script/Engine.HUD:bShowHitBoxDebugInfo")]
	public bool ShowHitBoxDebugInfo
	{
		get
		{
			CheckDestroyed();
			if (!ShowHitBoxDebugInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.HUD:bShowHitBoxDebugInfo");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ShowHitBoxDebugInfo_Offset), 0, ShowHitBoxDebugInfo_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShowHitBoxDebugInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.HUD:bShowHitBoxDebugInfo");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ShowHitBoxDebugInfo_Offset), 0, ShowHitBoxDebugInfo_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532484uL)]
	[UMetaPath("/Script/Engine.HUD:bShowOverlays")]
	public bool ShowOverlays
	{
		get
		{
			CheckDestroyed();
			if (!ShowOverlays_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.HUD:bShowOverlays");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ShowOverlays_Offset), 0, ShowOverlays_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShowOverlays_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.HUD:bShowOverlays");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ShowOverlays_Offset), 0, ShowOverlays_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.HUD:bEnableDebugTextShadow")]
	public bool EnableDebugTextShadow
	{
		get
		{
			CheckDestroyed();
			if (!EnableDebugTextShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.HUD:bEnableDebugTextShadow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableDebugTextShadow_Offset), 0, EnableDebugTextShadow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableDebugTextShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.HUD:bEnableDebugTextShadow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableDebugTextShadow_Offset), 0, EnableDebugTextShadow_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 134350856u)]
	[UMetaPath("/Script/Engine.HUD:ReceiveHitBoxRelease")]
	public unsafe void ReceiveHitBoxRelease(FName BoxName)
	{
		CheckDestroyed();
		if (!ReceiveHitBoxRelease_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.HUD:ReceiveHitBoxRelease");
			return;
		}
		if (ReceiveHitBoxRelease_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveHitBoxRelease_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveHitBoxRelease");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveHitBoxRelease_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveHitBoxRelease_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ReceiveHitBoxRelease_BoxName_Offset), 0, ReceiveHitBoxRelease_BoxName_PropertyAddress.Address, BoxName);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveHitBoxRelease_InstanceFunctionAddress, intPtr, ReceiveHitBoxRelease_ParamsSize);
	}

	protected unsafe virtual void ReceiveHitBoxRelease_Implementation(FName BoxName)
	{
		CheckDestroyed();
		if (!ReceiveHitBoxRelease_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.HUD:ReceiveHitBoxRelease");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveHitBoxRelease_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveHitBoxRelease_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ReceiveHitBoxRelease_BoxName_Offset), 0, ReceiveHitBoxRelease_BoxName_PropertyAddress.Address, BoxName);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveHitBoxRelease_FunctionAddress, intPtr, ReceiveHitBoxRelease_ParamsSize);
	}

	[UFunction(Flags = 134350856u)]
	[UMetaPath("/Script/Engine.HUD:ReceiveHitBoxEndCursorOver")]
	public unsafe void ReceiveHitBoxEndCursorOver(FName BoxName)
	{
		CheckDestroyed();
		if (!ReceiveHitBoxEndCursorOver_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.HUD:ReceiveHitBoxEndCursorOver");
			return;
		}
		if (ReceiveHitBoxEndCursorOver_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveHitBoxEndCursorOver_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveHitBoxEndCursorOver");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveHitBoxEndCursorOver_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveHitBoxEndCursorOver_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ReceiveHitBoxEndCursorOver_BoxName_Offset), 0, ReceiveHitBoxEndCursorOver_BoxName_PropertyAddress.Address, BoxName);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveHitBoxEndCursorOver_InstanceFunctionAddress, intPtr, ReceiveHitBoxEndCursorOver_ParamsSize);
	}

	protected unsafe virtual void ReceiveHitBoxEndCursorOver_Implementation(FName BoxName)
	{
		CheckDestroyed();
		if (!ReceiveHitBoxEndCursorOver_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.HUD:ReceiveHitBoxEndCursorOver");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveHitBoxEndCursorOver_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveHitBoxEndCursorOver_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ReceiveHitBoxEndCursorOver_BoxName_Offset), 0, ReceiveHitBoxEndCursorOver_BoxName_PropertyAddress.Address, BoxName);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveHitBoxEndCursorOver_FunctionAddress, intPtr, ReceiveHitBoxEndCursorOver_ParamsSize);
	}

	[UFunction(Flags = 134350856u)]
	[UMetaPath("/Script/Engine.HUD:ReceiveHitBoxClick")]
	public unsafe void ReceiveHitBoxClick(FName BoxName)
	{
		CheckDestroyed();
		if (!ReceiveHitBoxClick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.HUD:ReceiveHitBoxClick");
			return;
		}
		if (ReceiveHitBoxClick_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveHitBoxClick_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveHitBoxClick");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveHitBoxClick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveHitBoxClick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ReceiveHitBoxClick_BoxName_Offset), 0, ReceiveHitBoxClick_BoxName_PropertyAddress.Address, BoxName);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveHitBoxClick_InstanceFunctionAddress, intPtr, ReceiveHitBoxClick_ParamsSize);
	}

	protected unsafe virtual void ReceiveHitBoxClick_Implementation(FName BoxName)
	{
		CheckDestroyed();
		if (!ReceiveHitBoxClick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.HUD:ReceiveHitBoxClick");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveHitBoxClick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveHitBoxClick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ReceiveHitBoxClick_BoxName_Offset), 0, ReceiveHitBoxClick_BoxName_PropertyAddress.Address, BoxName);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveHitBoxClick_FunctionAddress, intPtr, ReceiveHitBoxClick_ParamsSize);
	}

	[UFunction(Flags = 134350856u)]
	[UMetaPath("/Script/Engine.HUD:ReceiveHitBoxBeginCursorOver")]
	public unsafe void ReceiveHitBoxBeginCursorOver(FName BoxName)
	{
		CheckDestroyed();
		if (!ReceiveHitBoxBeginCursorOver_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.HUD:ReceiveHitBoxBeginCursorOver");
			return;
		}
		if (ReceiveHitBoxBeginCursorOver_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveHitBoxBeginCursorOver_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveHitBoxBeginCursorOver");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveHitBoxBeginCursorOver_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveHitBoxBeginCursorOver_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ReceiveHitBoxBeginCursorOver_BoxName_Offset), 0, ReceiveHitBoxBeginCursorOver_BoxName_PropertyAddress.Address, BoxName);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveHitBoxBeginCursorOver_InstanceFunctionAddress, intPtr, ReceiveHitBoxBeginCursorOver_ParamsSize);
	}

	protected unsafe virtual void ReceiveHitBoxBeginCursorOver_Implementation(FName BoxName)
	{
		CheckDestroyed();
		if (!ReceiveHitBoxBeginCursorOver_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.HUD:ReceiveHitBoxBeginCursorOver");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveHitBoxBeginCursorOver_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveHitBoxBeginCursorOver_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ReceiveHitBoxBeginCursorOver_BoxName_Offset), 0, ReceiveHitBoxBeginCursorOver_BoxName_PropertyAddress.Address, BoxName);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveHitBoxBeginCursorOver_FunctionAddress, intPtr, ReceiveHitBoxBeginCursorOver_ParamsSize);
	}

	[UFunction(Flags = 134350856u)]
	[UMetaPath("/Script/Engine.HUD:ReceiveDrawHUD")]
	public unsafe void ReceiveDrawHUD(int SizeX, int SizeY)
	{
		CheckDestroyed();
		if (!ReceiveDrawHUD_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.HUD:ReceiveDrawHUD");
			return;
		}
		if (ReceiveDrawHUD_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveDrawHUD_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveDrawHUD");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveDrawHUD_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveDrawHUD_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ReceiveDrawHUD_SizeX_Offset), 0, ReceiveDrawHUD_SizeX_PropertyAddress.Address, SizeX);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ReceiveDrawHUD_SizeY_Offset), 0, ReceiveDrawHUD_SizeY_PropertyAddress.Address, SizeY);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveDrawHUD_InstanceFunctionAddress, intPtr, ReceiveDrawHUD_ParamsSize);
	}

	protected unsafe virtual void ReceiveDrawHUD_Implementation(int SizeX, int SizeY)
	{
		CheckDestroyed();
		if (!ReceiveDrawHUD_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.HUD:ReceiveDrawHUD");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveDrawHUD_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveDrawHUD_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ReceiveDrawHUD_SizeX_Offset), 0, ReceiveDrawHUD_SizeX_PropertyAddress.Address, SizeX);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ReceiveDrawHUD_SizeY_Offset), 0, ReceiveDrawHUD_SizeY_PropertyAddress.Address, SizeY);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveDrawHUD_FunctionAddress, intPtr, ReceiveDrawHUD_ParamsSize);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.HUD:Project")]
	public unsafe FVector Project(FVector Location, bool bClampToZeroPlane = true)
	{
		CheckDestroyed();
		if (!Project_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.HUD:Project");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(Project_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Project_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, Project_Location_Offset), 0, Project_Location_PropertyAddress.Address, Location);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Project_bClampToZeroPlane_Offset), 0, Project_bClampToZeroPlane_PropertyAddress.Address, bClampToZeroPlane);
		NativeReflection.InvokeFunctionOptimized(base.Address, Project_FunctionAddress, intPtr, Project_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, Project_ReturnValue_Offset), 0, Project_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Engine.HUD:GetTextSize")]
	public unsafe void GetTextSize(string Text, out float OutWidth, out float OutHeight, UFont Font, float Scale)
	{
		CheckDestroyed();
		if (!GetTextSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.HUD:GetTextSize");
			OutWidth = 0f;
			OutHeight = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTextSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTextSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetTextSize_Text_Offset), 0, GetTextSize_Text_PropertyAddress.Address, Text);
		UObjectMarshaler<UFont>.ToNative(IntPtr.Add(intPtr, GetTextSize_Font_Offset), 0, GetTextSize_Font_PropertyAddress.Address, Font);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetTextSize_Scale_Offset), 0, GetTextSize_Scale_PropertyAddress.Address, Scale);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTextSize_FunctionAddress, intPtr, GetTextSize_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetTextSize_Text_PropertyAddress.Address, intPtr);
		OutWidth = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetTextSize_OutWidth_Offset), 0, GetTextSize_OutWidth_PropertyAddress.Address);
		OutHeight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetTextSize_OutHeight_Offset), 0, GetTextSize_OutHeight_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.HUD:GetOwningPlayerController")]
	public unsafe APlayerController GetOwningPlayerController()
	{
		CheckDestroyed();
		if (!GetOwningPlayerController_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.HUD:GetOwningPlayerController");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOwningPlayerController_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOwningPlayerController_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOwningPlayerController_FunctionAddress, intPtr, GetOwningPlayerController_ParamsSize);
		return UObjectMarshaler<APlayerController>.FromNative(IntPtr.Add(intPtr, GetOwningPlayerController_ReturnValue_Offset), 0, GetOwningPlayerController_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.HUD:GetOwningPawn")]
	public unsafe APawn GetOwningPawn()
	{
		CheckDestroyed();
		if (!GetOwningPawn_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.HUD:GetOwningPawn");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOwningPawn_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOwningPawn_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOwningPawn_FunctionAddress, intPtr, GetOwningPawn_ParamsSize);
		return UObjectMarshaler<APawn>.FromNative(IntPtr.Add(intPtr, GetOwningPawn_ReturnValue_Offset), 0, GetOwningPawn_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348259329u)]
	[UMetaPath("/Script/Engine.HUD:GetActorsInSelectionRectangle")]
	public unsafe void GetActorsInSelectionRectangle(TSubclassOf<AActor> ClassFilter, FVector2D FirstPoint, FVector2D SecondPoint, out List<AActor> OutActors, bool bIncludeNonCollidingComponents = true, bool bActorMustBeFullyEnclosed = false)
	{
		CheckDestroyed();
		if (!GetActorsInSelectionRectangle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.HUD:GetActorsInSelectionRectangle");
			OutActors = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorsInSelectionRectangle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorsInSelectionRectangle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetActorsInSelectionRectangle_ClassFilter_Offset), 0, GetActorsInSelectionRectangle_ClassFilter_PropertyAddress.Address, ClassFilter);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, GetActorsInSelectionRectangle_FirstPoint_Offset), 0, GetActorsInSelectionRectangle_FirstPoint_PropertyAddress.Address, FirstPoint);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, GetActorsInSelectionRectangle_SecondPoint_Offset), 0, GetActorsInSelectionRectangle_SecondPoint_PropertyAddress.Address, SecondPoint);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetActorsInSelectionRectangle_bIncludeNonCollidingComponents_Offset), 0, GetActorsInSelectionRectangle_bIncludeNonCollidingComponents_PropertyAddress.Address, bIncludeNonCollidingComponents);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetActorsInSelectionRectangle_bActorMustBeFullyEnclosed_Offset), 0, GetActorsInSelectionRectangle_bActorMustBeFullyEnclosed_PropertyAddress.Address, bActorMustBeFullyEnclosed);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetActorsInSelectionRectangle_FunctionAddress, intPtr, GetActorsInSelectionRectangle_ParamsSize);
		OutActors = new TArrayCopyMarshaler<AActor>(1, GetActorsInSelectionRectangle_OutActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, GetActorsInSelectionRectangle_OutActors_Offset));
		NativeReflection.DestroyValue_InContainer(GetActorsInSelectionRectangle_OutActors_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.HUD:DrawTextureSimple")]
	public unsafe void DrawTextureSimple(UTexture Texture, float ScreenX, float ScreenY, float Scale = 1f, bool bScalePosition = false)
	{
		CheckDestroyed();
		if (!DrawTextureSimple_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.HUD:DrawTextureSimple");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawTextureSimple_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawTextureSimple_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(intPtr, DrawTextureSimple_Texture_Offset), 0, DrawTextureSimple_Texture_PropertyAddress.Address, Texture);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawTextureSimple_ScreenX_Offset), 0, DrawTextureSimple_ScreenX_PropertyAddress.Address, ScreenX);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawTextureSimple_ScreenY_Offset), 0, DrawTextureSimple_ScreenY_PropertyAddress.Address, ScreenY);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawTextureSimple_Scale_Offset), 0, DrawTextureSimple_Scale_PropertyAddress.Address, Scale);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DrawTextureSimple_bScalePosition_Offset), 0, DrawTextureSimple_bScalePosition_PropertyAddress.Address, bScalePosition);
		NativeReflection.InvokeFunctionOptimized(base.Address, DrawTextureSimple_FunctionAddress, intPtr, DrawTextureSimple_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.HUD:DrawTexture")]
	public unsafe void DrawTexture(UTexture Texture, float ScreenX, float ScreenY, float ScreenW, float ScreenH, float TextureU, float TextureV, float TextureUWidth, float TextureVHeight, FLinearColor TintColor, EBlendMode BlendMode, float Scale, bool bScalePosition, float Rotation, FVector2D RotPivot)
	{
		CheckDestroyed();
		if (!DrawTexture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.HUD:DrawTexture");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawTexture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawTexture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(intPtr, DrawTexture_Texture_Offset), 0, DrawTexture_Texture_PropertyAddress.Address, Texture);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawTexture_ScreenX_Offset), 0, DrawTexture_ScreenX_PropertyAddress.Address, ScreenX);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawTexture_ScreenY_Offset), 0, DrawTexture_ScreenY_PropertyAddress.Address, ScreenY);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawTexture_ScreenW_Offset), 0, DrawTexture_ScreenW_PropertyAddress.Address, ScreenW);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawTexture_ScreenH_Offset), 0, DrawTexture_ScreenH_PropertyAddress.Address, ScreenH);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawTexture_TextureU_Offset), 0, DrawTexture_TextureU_PropertyAddress.Address, TextureU);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawTexture_TextureV_Offset), 0, DrawTexture_TextureV_PropertyAddress.Address, TextureV);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawTexture_TextureUWidth_Offset), 0, DrawTexture_TextureUWidth_PropertyAddress.Address, TextureUWidth);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawTexture_TextureVHeight_Offset), 0, DrawTexture_TextureVHeight_PropertyAddress.Address, TextureVHeight);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawTexture_TintColor_Offset), 0, DrawTexture_TintColor_PropertyAddress.Address, TintColor);
		EnumMarshaler<EBlendMode>.ToNative(IntPtr.Add(intPtr, DrawTexture_BlendMode_Offset), 0, DrawTexture_BlendMode_PropertyAddress.Address, BlendMode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawTexture_Scale_Offset), 0, DrawTexture_Scale_PropertyAddress.Address, Scale);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DrawTexture_bScalePosition_Offset), 0, DrawTexture_bScalePosition_PropertyAddress.Address, bScalePosition);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawTexture_Rotation_Offset), 0, DrawTexture_Rotation_PropertyAddress.Address, Rotation);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawTexture_RotPivot_Offset), 0, DrawTexture_RotPivot_PropertyAddress.Address, RotPivot);
		NativeReflection.InvokeFunctionOptimized(base.Address, DrawTexture_FunctionAddress, intPtr, DrawTexture_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.HUD:DrawText")]
	public unsafe void DrawText(string Text, FLinearColor TextColor, float ScreenX, float ScreenY, UFont Font, float Scale, bool bScalePosition)
	{
		CheckDestroyed();
		if (!DrawText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.HUD:DrawText");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DrawText_Text_Offset), 0, DrawText_Text_PropertyAddress.Address, Text);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawText_TextColor_Offset), 0, DrawText_TextColor_PropertyAddress.Address, TextColor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawText_ScreenX_Offset), 0, DrawText_ScreenX_PropertyAddress.Address, ScreenX);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawText_ScreenY_Offset), 0, DrawText_ScreenY_PropertyAddress.Address, ScreenY);
		UObjectMarshaler<UFont>.ToNative(IntPtr.Add(intPtr, DrawText_Font_Offset), 0, DrawText_Font_PropertyAddress.Address, Font);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawText_Scale_Offset), 0, DrawText_Scale_PropertyAddress.Address, Scale);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DrawText_bScalePosition_Offset), 0, DrawText_bScalePosition_PropertyAddress.Address, bScalePosition);
		NativeReflection.InvokeFunctionOptimized(base.Address, DrawText_FunctionAddress, intPtr, DrawText_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DrawText_Text_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.HUD:DrawRect")]
	public unsafe void DrawRect(FLinearColor RectColor, float ScreenX, float ScreenY, float ScreenW, float ScreenH)
	{
		CheckDestroyed();
		if (!DrawRect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.HUD:DrawRect");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawRect_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawRect_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawRect_RectColor_Offset), 0, DrawRect_RectColor_PropertyAddress.Address, RectColor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawRect_ScreenX_Offset), 0, DrawRect_ScreenX_PropertyAddress.Address, ScreenX);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawRect_ScreenY_Offset), 0, DrawRect_ScreenY_PropertyAddress.Address, ScreenY);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawRect_ScreenW_Offset), 0, DrawRect_ScreenW_PropertyAddress.Address, ScreenW);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawRect_ScreenH_Offset), 0, DrawRect_ScreenH_PropertyAddress.Address, ScreenH);
		NativeReflection.InvokeFunctionOptimized(base.Address, DrawRect_FunctionAddress, intPtr, DrawRect_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.HUD:DrawMaterialTriangle")]
	public unsafe void DrawMaterialTriangle(UMaterialInterface Material, FVector2D V0_Pos, FVector2D V1_Pos, FVector2D V2_Pos, FVector2D V0_UV, FVector2D V1_UV, FVector2D V2_UV, FLinearColor V0_Color, FLinearColor V1_Color, FLinearColor V2_Color)
	{
		CheckDestroyed();
		if (!DrawMaterialTriangle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.HUD:DrawMaterialTriangle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawMaterialTriangle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawMaterialTriangle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, DrawMaterialTriangle_Material_Offset), 0, DrawMaterialTriangle_Material_PropertyAddress.Address, Material);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawMaterialTriangle_V0_Pos_Offset), 0, DrawMaterialTriangle_V0_Pos_PropertyAddress.Address, V0_Pos);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawMaterialTriangle_V1_Pos_Offset), 0, DrawMaterialTriangle_V1_Pos_PropertyAddress.Address, V1_Pos);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawMaterialTriangle_V2_Pos_Offset), 0, DrawMaterialTriangle_V2_Pos_PropertyAddress.Address, V2_Pos);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawMaterialTriangle_V0_UV_Offset), 0, DrawMaterialTriangle_V0_UV_PropertyAddress.Address, V0_UV);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawMaterialTriangle_V1_UV_Offset), 0, DrawMaterialTriangle_V1_UV_PropertyAddress.Address, V1_UV);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawMaterialTriangle_V2_UV_Offset), 0, DrawMaterialTriangle_V2_UV_PropertyAddress.Address, V2_UV);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawMaterialTriangle_V0_Color_Offset), 0, DrawMaterialTriangle_V0_Color_PropertyAddress.Address, V0_Color);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawMaterialTriangle_V1_Color_Offset), 0, DrawMaterialTriangle_V1_Color_PropertyAddress.Address, V1_Color);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawMaterialTriangle_V2_Color_Offset), 0, DrawMaterialTriangle_V2_Color_PropertyAddress.Address, V2_Color);
		NativeReflection.InvokeFunctionOptimized(base.Address, DrawMaterialTriangle_FunctionAddress, intPtr, DrawMaterialTriangle_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.HUD:DrawMaterialSimple")]
	public unsafe void DrawMaterialSimple(UMaterialInterface Material, float ScreenX, float ScreenY, float ScreenW, float ScreenH, float Scale = 1f, bool bScalePosition = false)
	{
		CheckDestroyed();
		if (!DrawMaterialSimple_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.HUD:DrawMaterialSimple");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawMaterialSimple_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawMaterialSimple_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, DrawMaterialSimple_Material_Offset), 0, DrawMaterialSimple_Material_PropertyAddress.Address, Material);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawMaterialSimple_ScreenX_Offset), 0, DrawMaterialSimple_ScreenX_PropertyAddress.Address, ScreenX);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawMaterialSimple_ScreenY_Offset), 0, DrawMaterialSimple_ScreenY_PropertyAddress.Address, ScreenY);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawMaterialSimple_ScreenW_Offset), 0, DrawMaterialSimple_ScreenW_PropertyAddress.Address, ScreenW);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawMaterialSimple_ScreenH_Offset), 0, DrawMaterialSimple_ScreenH_PropertyAddress.Address, ScreenH);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawMaterialSimple_Scale_Offset), 0, DrawMaterialSimple_Scale_PropertyAddress.Address, Scale);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DrawMaterialSimple_bScalePosition_Offset), 0, DrawMaterialSimple_bScalePosition_PropertyAddress.Address, bScalePosition);
		NativeReflection.InvokeFunctionOptimized(base.Address, DrawMaterialSimple_FunctionAddress, intPtr, DrawMaterialSimple_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.HUD:DrawMaterial")]
	public unsafe void DrawMaterial(UMaterialInterface Material, float ScreenX, float ScreenY, float ScreenW, float ScreenH, float MaterialU, float MaterialV, float MaterialUWidth, float MaterialVHeight, float Scale = 1f, bool bScalePosition = false, float Rotation = 0f, FVector2D RotPivot = default(FVector2D))
	{
		CheckDestroyed();
		if (!DrawMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.HUD:DrawMaterial");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, DrawMaterial_Material_Offset), 0, DrawMaterial_Material_PropertyAddress.Address, Material);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawMaterial_ScreenX_Offset), 0, DrawMaterial_ScreenX_PropertyAddress.Address, ScreenX);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawMaterial_ScreenY_Offset), 0, DrawMaterial_ScreenY_PropertyAddress.Address, ScreenY);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawMaterial_ScreenW_Offset), 0, DrawMaterial_ScreenW_PropertyAddress.Address, ScreenW);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawMaterial_ScreenH_Offset), 0, DrawMaterial_ScreenH_PropertyAddress.Address, ScreenH);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawMaterial_MaterialU_Offset), 0, DrawMaterial_MaterialU_PropertyAddress.Address, MaterialU);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawMaterial_MaterialV_Offset), 0, DrawMaterial_MaterialV_PropertyAddress.Address, MaterialV);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawMaterial_MaterialUWidth_Offset), 0, DrawMaterial_MaterialUWidth_PropertyAddress.Address, MaterialUWidth);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawMaterial_MaterialVHeight_Offset), 0, DrawMaterial_MaterialVHeight_PropertyAddress.Address, MaterialVHeight);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawMaterial_Scale_Offset), 0, DrawMaterial_Scale_PropertyAddress.Address, Scale);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DrawMaterial_bScalePosition_Offset), 0, DrawMaterial_bScalePosition_PropertyAddress.Address, bScalePosition);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawMaterial_Rotation_Offset), 0, DrawMaterial_Rotation_PropertyAddress.Address, Rotation);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawMaterial_RotPivot_Offset), 0, DrawMaterial_RotPivot_PropertyAddress.Address, RotPivot);
		NativeReflection.InvokeFunctionOptimized(base.Address, DrawMaterial_FunctionAddress, intPtr, DrawMaterial_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.HUD:DrawLine")]
	public unsafe void DrawLine(float StartScreenX, float StartScreenY, float EndScreenX, float EndScreenY, FLinearColor LineColor, float LineThickness = 0f)
	{
		CheckDestroyed();
		if (!DrawLine_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.HUD:DrawLine");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawLine_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawLine_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawLine_StartScreenX_Offset), 0, DrawLine_StartScreenX_PropertyAddress.Address, StartScreenX);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawLine_StartScreenY_Offset), 0, DrawLine_StartScreenY_PropertyAddress.Address, StartScreenY);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawLine_EndScreenX_Offset), 0, DrawLine_EndScreenX_PropertyAddress.Address, EndScreenX);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawLine_EndScreenY_Offset), 0, DrawLine_EndScreenY_PropertyAddress.Address, EndScreenY);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawLine_LineColor_Offset), 0, DrawLine_LineColor_PropertyAddress.Address, LineColor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawLine_LineThickness_Offset), 0, DrawLine_LineThickness_PropertyAddress.Address, LineThickness);
		NativeReflection.InvokeFunctionOptimized(base.Address, DrawLine_FunctionAddress, intPtr, DrawLine_ParamsSize);
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/Engine.HUD:Deproject")]
	public unsafe void Deproject(float ScreenX, float ScreenY, out FVector WorldPosition, out FVector WorldDirection)
	{
		CheckDestroyed();
		if (!Deproject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.HUD:Deproject");
			WorldPosition = default(FVector);
			WorldDirection = default(FVector);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Deproject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Deproject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Deproject_ScreenX_Offset), 0, Deproject_ScreenX_PropertyAddress.Address, ScreenX);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Deproject_ScreenY_Offset), 0, Deproject_ScreenY_PropertyAddress.Address, ScreenY);
		NativeReflection.InvokeFunctionOptimized(base.Address, Deproject_FunctionAddress, intPtr, Deproject_ParamsSize);
		WorldPosition = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, Deproject_WorldPosition_Offset), 0, Deproject_WorldPosition_PropertyAddress.Address);
		WorldDirection = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, Deproject_WorldDirection_Offset), 0, Deproject_WorldDirection_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.HUD:AddHitBox")]
	public unsafe void AddHitBox(FVector2D Position, FVector2D Size, FName InName, bool bConsumesInput, int Priority = 0)
	{
		CheckDestroyed();
		if (!AddHitBox_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.HUD:AddHitBox");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddHitBox_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddHitBox_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, AddHitBox_Position_Offset), 0, AddHitBox_Position_PropertyAddress.Address, Position);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, AddHitBox_Size_Offset), 0, AddHitBox_Size_PropertyAddress.Address, Size);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddHitBox_InName_Offset), 0, AddHitBox_InName_PropertyAddress.Address, InName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddHitBox_bConsumesInput_Offset), 0, AddHitBox_bConsumesInput_PropertyAddress.Address, bConsumesInput);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AddHitBox_Priority_Offset), 0, AddHitBox_Priority_PropertyAddress.Address, Priority);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddHitBox_FunctionAddress, intPtr, AddHitBox_ParamsSize);
	}

	static AHUD()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AHUD)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AHUD));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.HUD");
		PlayerOwner_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlayerOwner");
		PlayerOwner_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlayerOwner", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref LostFocusPaused_PropertyAddress, intPtr, "bLostFocusPaused");
		LostFocusPaused_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bLostFocusPaused");
		LostFocusPaused_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bLostFocusPaused", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowHUD_PropertyAddress, intPtr, "bShowHUD");
		ShowHUD_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bShowHUD");
		ShowHUD_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bShowHUD", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowDebugInfo_PropertyAddress, intPtr, "bShowDebugInfo");
		ShowDebugInfo_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bShowDebugInfo");
		ShowDebugInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bShowDebugInfo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowHitBoxDebugInfo_PropertyAddress, intPtr, "bShowHitBoxDebugInfo");
		ShowHitBoxDebugInfo_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bShowHitBoxDebugInfo");
		ShowHitBoxDebugInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bShowHitBoxDebugInfo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowOverlays_PropertyAddress, intPtr, "bShowOverlays");
		ShowOverlays_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bShowOverlays");
		ShowOverlays_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bShowOverlays", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableDebugTextShadow_PropertyAddress, intPtr, "bEnableDebugTextShadow");
		EnableDebugTextShadow_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableDebugTextShadow");
		EnableDebugTextShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableDebugTextShadow", Classes.FBoolProperty);
		ReceiveHitBoxRelease_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveHitBoxRelease");
		ReceiveHitBoxRelease_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveHitBoxRelease_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveHitBoxRelease_BoxName_PropertyAddress, ReceiveHitBoxRelease_FunctionAddress, "BoxName");
		ReceiveHitBoxRelease_BoxName_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveHitBoxRelease_FunctionAddress, "BoxName");
		ReceiveHitBoxRelease_BoxName_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveHitBoxRelease_FunctionAddress, "BoxName", Classes.FNameProperty);
		ReceiveHitBoxRelease_IsValid = ReceiveHitBoxRelease_FunctionAddress != IntPtr.Zero && ReceiveHitBoxRelease_BoxName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.HUD:ReceiveHitBoxRelease", ReceiveHitBoxRelease_IsValid);
		ReceiveHitBoxEndCursorOver_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveHitBoxEndCursorOver");
		ReceiveHitBoxEndCursorOver_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveHitBoxEndCursorOver_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveHitBoxEndCursorOver_BoxName_PropertyAddress, ReceiveHitBoxEndCursorOver_FunctionAddress, "BoxName");
		ReceiveHitBoxEndCursorOver_BoxName_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveHitBoxEndCursorOver_FunctionAddress, "BoxName");
		ReceiveHitBoxEndCursorOver_BoxName_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveHitBoxEndCursorOver_FunctionAddress, "BoxName", Classes.FNameProperty);
		ReceiveHitBoxEndCursorOver_IsValid = ReceiveHitBoxEndCursorOver_FunctionAddress != IntPtr.Zero && ReceiveHitBoxEndCursorOver_BoxName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.HUD:ReceiveHitBoxEndCursorOver", ReceiveHitBoxEndCursorOver_IsValid);
		ReceiveHitBoxClick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveHitBoxClick");
		ReceiveHitBoxClick_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveHitBoxClick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveHitBoxClick_BoxName_PropertyAddress, ReceiveHitBoxClick_FunctionAddress, "BoxName");
		ReceiveHitBoxClick_BoxName_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveHitBoxClick_FunctionAddress, "BoxName");
		ReceiveHitBoxClick_BoxName_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveHitBoxClick_FunctionAddress, "BoxName", Classes.FNameProperty);
		ReceiveHitBoxClick_IsValid = ReceiveHitBoxClick_FunctionAddress != IntPtr.Zero && ReceiveHitBoxClick_BoxName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.HUD:ReceiveHitBoxClick", ReceiveHitBoxClick_IsValid);
		ReceiveHitBoxBeginCursorOver_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveHitBoxBeginCursorOver");
		ReceiveHitBoxBeginCursorOver_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveHitBoxBeginCursorOver_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveHitBoxBeginCursorOver_BoxName_PropertyAddress, ReceiveHitBoxBeginCursorOver_FunctionAddress, "BoxName");
		ReceiveHitBoxBeginCursorOver_BoxName_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveHitBoxBeginCursorOver_FunctionAddress, "BoxName");
		ReceiveHitBoxBeginCursorOver_BoxName_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveHitBoxBeginCursorOver_FunctionAddress, "BoxName", Classes.FNameProperty);
		ReceiveHitBoxBeginCursorOver_IsValid = ReceiveHitBoxBeginCursorOver_FunctionAddress != IntPtr.Zero && ReceiveHitBoxBeginCursorOver_BoxName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.HUD:ReceiveHitBoxBeginCursorOver", ReceiveHitBoxBeginCursorOver_IsValid);
		ReceiveDrawHUD_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveDrawHUD");
		ReceiveDrawHUD_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveDrawHUD_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveDrawHUD_SizeX_PropertyAddress, ReceiveDrawHUD_FunctionAddress, "SizeX");
		ReceiveDrawHUD_SizeX_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveDrawHUD_FunctionAddress, "SizeX");
		ReceiveDrawHUD_SizeX_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveDrawHUD_FunctionAddress, "SizeX", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveDrawHUD_SizeY_PropertyAddress, ReceiveDrawHUD_FunctionAddress, "SizeY");
		ReceiveDrawHUD_SizeY_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveDrawHUD_FunctionAddress, "SizeY");
		ReceiveDrawHUD_SizeY_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveDrawHUD_FunctionAddress, "SizeY", Classes.FIntProperty);
		ReceiveDrawHUD_IsValid = ReceiveDrawHUD_FunctionAddress != IntPtr.Zero && ReceiveDrawHUD_SizeX_IsValid && ReceiveDrawHUD_SizeY_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.HUD:ReceiveDrawHUD", ReceiveDrawHUD_IsValid);
		Project_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Project");
		Project_ParamsSize = NativeReflection.GetFunctionParamsSize(Project_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Project_Location_PropertyAddress, Project_FunctionAddress, "Location");
		Project_Location_Offset = NativeReflectionCached.GetPropertyOffset(Project_FunctionAddress, "Location");
		Project_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(Project_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Project_bClampToZeroPlane_PropertyAddress, Project_FunctionAddress, "bClampToZeroPlane");
		Project_bClampToZeroPlane_Offset = NativeReflectionCached.GetPropertyOffset(Project_FunctionAddress, "bClampToZeroPlane");
		Project_bClampToZeroPlane_IsValid = NativeReflectionCached.ValidatePropertyClass(Project_FunctionAddress, "bClampToZeroPlane", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Project_ReturnValue_PropertyAddress, Project_FunctionAddress, "ReturnValue");
		Project_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Project_FunctionAddress, "ReturnValue");
		Project_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Project_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		Project_IsValid = Project_FunctionAddress != IntPtr.Zero && Project_Location_IsValid && Project_bClampToZeroPlane_IsValid && Project_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.HUD:Project", Project_IsValid);
		GetTextSize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTextSize");
		GetTextSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTextSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTextSize_Text_PropertyAddress, GetTextSize_FunctionAddress, "Text");
		GetTextSize_Text_Offset = NativeReflectionCached.GetPropertyOffset(GetTextSize_FunctionAddress, "Text");
		GetTextSize_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextSize_FunctionAddress, "Text", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTextSize_OutWidth_PropertyAddress, GetTextSize_FunctionAddress, "OutWidth");
		GetTextSize_OutWidth_Offset = NativeReflectionCached.GetPropertyOffset(GetTextSize_FunctionAddress, "OutWidth");
		GetTextSize_OutWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextSize_FunctionAddress, "OutWidth", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTextSize_OutHeight_PropertyAddress, GetTextSize_FunctionAddress, "OutHeight");
		GetTextSize_OutHeight_Offset = NativeReflectionCached.GetPropertyOffset(GetTextSize_FunctionAddress, "OutHeight");
		GetTextSize_OutHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextSize_FunctionAddress, "OutHeight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTextSize_Font_PropertyAddress, GetTextSize_FunctionAddress, "Font");
		GetTextSize_Font_Offset = NativeReflectionCached.GetPropertyOffset(GetTextSize_FunctionAddress, "Font");
		GetTextSize_Font_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextSize_FunctionAddress, "Font", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTextSize_Scale_PropertyAddress, GetTextSize_FunctionAddress, "Scale");
		GetTextSize_Scale_Offset = NativeReflectionCached.GetPropertyOffset(GetTextSize_FunctionAddress, "Scale");
		GetTextSize_Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextSize_FunctionAddress, "Scale", Classes.FFloatProperty);
		GetTextSize_IsValid = GetTextSize_FunctionAddress != IntPtr.Zero && GetTextSize_Text_IsValid && GetTextSize_OutWidth_IsValid && GetTextSize_OutHeight_IsValid && GetTextSize_Font_IsValid && GetTextSize_Scale_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.HUD:GetTextSize", GetTextSize_IsValid);
		GetOwningPlayerController_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetOwningPlayerController");
		GetOwningPlayerController_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOwningPlayerController_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOwningPlayerController_ReturnValue_PropertyAddress, GetOwningPlayerController_FunctionAddress, "ReturnValue");
		GetOwningPlayerController_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOwningPlayerController_FunctionAddress, "ReturnValue");
		GetOwningPlayerController_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOwningPlayerController_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetOwningPlayerController_IsValid = GetOwningPlayerController_FunctionAddress != IntPtr.Zero && GetOwningPlayerController_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.HUD:GetOwningPlayerController", GetOwningPlayerController_IsValid);
		GetOwningPawn_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetOwningPawn");
		GetOwningPawn_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOwningPawn_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOwningPawn_ReturnValue_PropertyAddress, GetOwningPawn_FunctionAddress, "ReturnValue");
		GetOwningPawn_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOwningPawn_FunctionAddress, "ReturnValue");
		GetOwningPawn_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOwningPawn_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetOwningPawn_IsValid = GetOwningPawn_FunctionAddress != IntPtr.Zero && GetOwningPawn_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.HUD:GetOwningPawn", GetOwningPawn_IsValid);
		GetActorsInSelectionRectangle_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetActorsInSelectionRectangle");
		GetActorsInSelectionRectangle_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorsInSelectionRectangle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorsInSelectionRectangle_ClassFilter_PropertyAddress, GetActorsInSelectionRectangle_FunctionAddress, "ClassFilter");
		GetActorsInSelectionRectangle_ClassFilter_Offset = NativeReflectionCached.GetPropertyOffset(GetActorsInSelectionRectangle_FunctionAddress, "ClassFilter");
		GetActorsInSelectionRectangle_ClassFilter_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorsInSelectionRectangle_FunctionAddress, "ClassFilter", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorsInSelectionRectangle_FirstPoint_PropertyAddress, GetActorsInSelectionRectangle_FunctionAddress, "FirstPoint");
		GetActorsInSelectionRectangle_FirstPoint_Offset = NativeReflectionCached.GetPropertyOffset(GetActorsInSelectionRectangle_FunctionAddress, "FirstPoint");
		GetActorsInSelectionRectangle_FirstPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorsInSelectionRectangle_FunctionAddress, "FirstPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorsInSelectionRectangle_SecondPoint_PropertyAddress, GetActorsInSelectionRectangle_FunctionAddress, "SecondPoint");
		GetActorsInSelectionRectangle_SecondPoint_Offset = NativeReflectionCached.GetPropertyOffset(GetActorsInSelectionRectangle_FunctionAddress, "SecondPoint");
		GetActorsInSelectionRectangle_SecondPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorsInSelectionRectangle_FunctionAddress, "SecondPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorsInSelectionRectangle_OutActors_PropertyAddress, GetActorsInSelectionRectangle_FunctionAddress, "OutActors");
		GetActorsInSelectionRectangle_OutActors_Offset = NativeReflectionCached.GetPropertyOffset(GetActorsInSelectionRectangle_FunctionAddress, "OutActors");
		GetActorsInSelectionRectangle_OutActors_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorsInSelectionRectangle_FunctionAddress, "OutActors", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorsInSelectionRectangle_bIncludeNonCollidingComponents_PropertyAddress, GetActorsInSelectionRectangle_FunctionAddress, "bIncludeNonCollidingComponents");
		GetActorsInSelectionRectangle_bIncludeNonCollidingComponents_Offset = NativeReflectionCached.GetPropertyOffset(GetActorsInSelectionRectangle_FunctionAddress, "bIncludeNonCollidingComponents");
		GetActorsInSelectionRectangle_bIncludeNonCollidingComponents_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorsInSelectionRectangle_FunctionAddress, "bIncludeNonCollidingComponents", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorsInSelectionRectangle_bActorMustBeFullyEnclosed_PropertyAddress, GetActorsInSelectionRectangle_FunctionAddress, "bActorMustBeFullyEnclosed");
		GetActorsInSelectionRectangle_bActorMustBeFullyEnclosed_Offset = NativeReflectionCached.GetPropertyOffset(GetActorsInSelectionRectangle_FunctionAddress, "bActorMustBeFullyEnclosed");
		GetActorsInSelectionRectangle_bActorMustBeFullyEnclosed_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorsInSelectionRectangle_FunctionAddress, "bActorMustBeFullyEnclosed", Classes.FBoolProperty);
		GetActorsInSelectionRectangle_IsValid = GetActorsInSelectionRectangle_FunctionAddress != IntPtr.Zero && GetActorsInSelectionRectangle_ClassFilter_IsValid && GetActorsInSelectionRectangle_FirstPoint_IsValid && GetActorsInSelectionRectangle_SecondPoint_IsValid && GetActorsInSelectionRectangle_OutActors_IsValid && GetActorsInSelectionRectangle_bIncludeNonCollidingComponents_IsValid && GetActorsInSelectionRectangle_bActorMustBeFullyEnclosed_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.HUD:GetActorsInSelectionRectangle", GetActorsInSelectionRectangle_IsValid);
		DrawTextureSimple_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DrawTextureSimple");
		DrawTextureSimple_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawTextureSimple_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawTextureSimple_Texture_PropertyAddress, DrawTextureSimple_FunctionAddress, "Texture");
		DrawTextureSimple_Texture_Offset = NativeReflectionCached.GetPropertyOffset(DrawTextureSimple_FunctionAddress, "Texture");
		DrawTextureSimple_Texture_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawTextureSimple_FunctionAddress, "Texture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawTextureSimple_ScreenX_PropertyAddress, DrawTextureSimple_FunctionAddress, "ScreenX");
		DrawTextureSimple_ScreenX_Offset = NativeReflectionCached.GetPropertyOffset(DrawTextureSimple_FunctionAddress, "ScreenX");
		DrawTextureSimple_ScreenX_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawTextureSimple_FunctionAddress, "ScreenX", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawTextureSimple_ScreenY_PropertyAddress, DrawTextureSimple_FunctionAddress, "ScreenY");
		DrawTextureSimple_ScreenY_Offset = NativeReflectionCached.GetPropertyOffset(DrawTextureSimple_FunctionAddress, "ScreenY");
		DrawTextureSimple_ScreenY_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawTextureSimple_FunctionAddress, "ScreenY", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawTextureSimple_Scale_PropertyAddress, DrawTextureSimple_FunctionAddress, "Scale");
		DrawTextureSimple_Scale_Offset = NativeReflectionCached.GetPropertyOffset(DrawTextureSimple_FunctionAddress, "Scale");
		DrawTextureSimple_Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawTextureSimple_FunctionAddress, "Scale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawTextureSimple_bScalePosition_PropertyAddress, DrawTextureSimple_FunctionAddress, "bScalePosition");
		DrawTextureSimple_bScalePosition_Offset = NativeReflectionCached.GetPropertyOffset(DrawTextureSimple_FunctionAddress, "bScalePosition");
		DrawTextureSimple_bScalePosition_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawTextureSimple_FunctionAddress, "bScalePosition", Classes.FBoolProperty);
		DrawTextureSimple_IsValid = DrawTextureSimple_FunctionAddress != IntPtr.Zero && DrawTextureSimple_Texture_IsValid && DrawTextureSimple_ScreenX_IsValid && DrawTextureSimple_ScreenY_IsValid && DrawTextureSimple_Scale_IsValid && DrawTextureSimple_bScalePosition_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.HUD:DrawTextureSimple", DrawTextureSimple_IsValid);
		DrawTexture_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DrawTexture");
		DrawTexture_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawTexture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawTexture_Texture_PropertyAddress, DrawTexture_FunctionAddress, "Texture");
		DrawTexture_Texture_Offset = NativeReflectionCached.GetPropertyOffset(DrawTexture_FunctionAddress, "Texture");
		DrawTexture_Texture_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawTexture_FunctionAddress, "Texture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawTexture_ScreenX_PropertyAddress, DrawTexture_FunctionAddress, "ScreenX");
		DrawTexture_ScreenX_Offset = NativeReflectionCached.GetPropertyOffset(DrawTexture_FunctionAddress, "ScreenX");
		DrawTexture_ScreenX_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawTexture_FunctionAddress, "ScreenX", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawTexture_ScreenY_PropertyAddress, DrawTexture_FunctionAddress, "ScreenY");
		DrawTexture_ScreenY_Offset = NativeReflectionCached.GetPropertyOffset(DrawTexture_FunctionAddress, "ScreenY");
		DrawTexture_ScreenY_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawTexture_FunctionAddress, "ScreenY", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawTexture_ScreenW_PropertyAddress, DrawTexture_FunctionAddress, "ScreenW");
		DrawTexture_ScreenW_Offset = NativeReflectionCached.GetPropertyOffset(DrawTexture_FunctionAddress, "ScreenW");
		DrawTexture_ScreenW_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawTexture_FunctionAddress, "ScreenW", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawTexture_ScreenH_PropertyAddress, DrawTexture_FunctionAddress, "ScreenH");
		DrawTexture_ScreenH_Offset = NativeReflectionCached.GetPropertyOffset(DrawTexture_FunctionAddress, "ScreenH");
		DrawTexture_ScreenH_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawTexture_FunctionAddress, "ScreenH", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawTexture_TextureU_PropertyAddress, DrawTexture_FunctionAddress, "TextureU");
		DrawTexture_TextureU_Offset = NativeReflectionCached.GetPropertyOffset(DrawTexture_FunctionAddress, "TextureU");
		DrawTexture_TextureU_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawTexture_FunctionAddress, "TextureU", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawTexture_TextureV_PropertyAddress, DrawTexture_FunctionAddress, "TextureV");
		DrawTexture_TextureV_Offset = NativeReflectionCached.GetPropertyOffset(DrawTexture_FunctionAddress, "TextureV");
		DrawTexture_TextureV_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawTexture_FunctionAddress, "TextureV", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawTexture_TextureUWidth_PropertyAddress, DrawTexture_FunctionAddress, "TextureUWidth");
		DrawTexture_TextureUWidth_Offset = NativeReflectionCached.GetPropertyOffset(DrawTexture_FunctionAddress, "TextureUWidth");
		DrawTexture_TextureUWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawTexture_FunctionAddress, "TextureUWidth", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawTexture_TextureVHeight_PropertyAddress, DrawTexture_FunctionAddress, "TextureVHeight");
		DrawTexture_TextureVHeight_Offset = NativeReflectionCached.GetPropertyOffset(DrawTexture_FunctionAddress, "TextureVHeight");
		DrawTexture_TextureVHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawTexture_FunctionAddress, "TextureVHeight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawTexture_TintColor_PropertyAddress, DrawTexture_FunctionAddress, "TintColor");
		DrawTexture_TintColor_Offset = NativeReflectionCached.GetPropertyOffset(DrawTexture_FunctionAddress, "TintColor");
		DrawTexture_TintColor_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawTexture_FunctionAddress, "TintColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawTexture_BlendMode_PropertyAddress, DrawTexture_FunctionAddress, "BlendMode");
		DrawTexture_BlendMode_Offset = NativeReflectionCached.GetPropertyOffset(DrawTexture_FunctionAddress, "BlendMode");
		DrawTexture_BlendMode_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawTexture_FunctionAddress, "BlendMode", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawTexture_Scale_PropertyAddress, DrawTexture_FunctionAddress, "Scale");
		DrawTexture_Scale_Offset = NativeReflectionCached.GetPropertyOffset(DrawTexture_FunctionAddress, "Scale");
		DrawTexture_Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawTexture_FunctionAddress, "Scale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawTexture_bScalePosition_PropertyAddress, DrawTexture_FunctionAddress, "bScalePosition");
		DrawTexture_bScalePosition_Offset = NativeReflectionCached.GetPropertyOffset(DrawTexture_FunctionAddress, "bScalePosition");
		DrawTexture_bScalePosition_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawTexture_FunctionAddress, "bScalePosition", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawTexture_Rotation_PropertyAddress, DrawTexture_FunctionAddress, "Rotation");
		DrawTexture_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(DrawTexture_FunctionAddress, "Rotation");
		DrawTexture_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawTexture_FunctionAddress, "Rotation", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawTexture_RotPivot_PropertyAddress, DrawTexture_FunctionAddress, "RotPivot");
		DrawTexture_RotPivot_Offset = NativeReflectionCached.GetPropertyOffset(DrawTexture_FunctionAddress, "RotPivot");
		DrawTexture_RotPivot_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawTexture_FunctionAddress, "RotPivot", Classes.FStructProperty);
		DrawTexture_IsValid = DrawTexture_FunctionAddress != IntPtr.Zero && DrawTexture_Texture_IsValid && DrawTexture_ScreenX_IsValid && DrawTexture_ScreenY_IsValid && DrawTexture_ScreenW_IsValid && DrawTexture_ScreenH_IsValid && DrawTexture_TextureU_IsValid && DrawTexture_TextureV_IsValid && DrawTexture_TextureUWidth_IsValid && DrawTexture_TextureVHeight_IsValid && DrawTexture_TintColor_IsValid && DrawTexture_BlendMode_IsValid && DrawTexture_Scale_IsValid && DrawTexture_bScalePosition_IsValid && DrawTexture_Rotation_IsValid && DrawTexture_RotPivot_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.HUD:DrawTexture", DrawTexture_IsValid);
		DrawText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DrawText");
		DrawText_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawText_Text_PropertyAddress, DrawText_FunctionAddress, "Text");
		DrawText_Text_Offset = NativeReflectionCached.GetPropertyOffset(DrawText_FunctionAddress, "Text");
		DrawText_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawText_FunctionAddress, "Text", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawText_TextColor_PropertyAddress, DrawText_FunctionAddress, "TextColor");
		DrawText_TextColor_Offset = NativeReflectionCached.GetPropertyOffset(DrawText_FunctionAddress, "TextColor");
		DrawText_TextColor_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawText_FunctionAddress, "TextColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawText_ScreenX_PropertyAddress, DrawText_FunctionAddress, "ScreenX");
		DrawText_ScreenX_Offset = NativeReflectionCached.GetPropertyOffset(DrawText_FunctionAddress, "ScreenX");
		DrawText_ScreenX_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawText_FunctionAddress, "ScreenX", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawText_ScreenY_PropertyAddress, DrawText_FunctionAddress, "ScreenY");
		DrawText_ScreenY_Offset = NativeReflectionCached.GetPropertyOffset(DrawText_FunctionAddress, "ScreenY");
		DrawText_ScreenY_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawText_FunctionAddress, "ScreenY", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawText_Font_PropertyAddress, DrawText_FunctionAddress, "Font");
		DrawText_Font_Offset = NativeReflectionCached.GetPropertyOffset(DrawText_FunctionAddress, "Font");
		DrawText_Font_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawText_FunctionAddress, "Font", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawText_Scale_PropertyAddress, DrawText_FunctionAddress, "Scale");
		DrawText_Scale_Offset = NativeReflectionCached.GetPropertyOffset(DrawText_FunctionAddress, "Scale");
		DrawText_Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawText_FunctionAddress, "Scale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawText_bScalePosition_PropertyAddress, DrawText_FunctionAddress, "bScalePosition");
		DrawText_bScalePosition_Offset = NativeReflectionCached.GetPropertyOffset(DrawText_FunctionAddress, "bScalePosition");
		DrawText_bScalePosition_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawText_FunctionAddress, "bScalePosition", Classes.FBoolProperty);
		DrawText_IsValid = DrawText_FunctionAddress != IntPtr.Zero && DrawText_Text_IsValid && DrawText_TextColor_IsValid && DrawText_ScreenX_IsValid && DrawText_ScreenY_IsValid && DrawText_Font_IsValid && DrawText_Scale_IsValid && DrawText_bScalePosition_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.HUD:DrawText", DrawText_IsValid);
		DrawRect_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DrawRect");
		DrawRect_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawRect_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawRect_RectColor_PropertyAddress, DrawRect_FunctionAddress, "RectColor");
		DrawRect_RectColor_Offset = NativeReflectionCached.GetPropertyOffset(DrawRect_FunctionAddress, "RectColor");
		DrawRect_RectColor_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawRect_FunctionAddress, "RectColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawRect_ScreenX_PropertyAddress, DrawRect_FunctionAddress, "ScreenX");
		DrawRect_ScreenX_Offset = NativeReflectionCached.GetPropertyOffset(DrawRect_FunctionAddress, "ScreenX");
		DrawRect_ScreenX_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawRect_FunctionAddress, "ScreenX", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawRect_ScreenY_PropertyAddress, DrawRect_FunctionAddress, "ScreenY");
		DrawRect_ScreenY_Offset = NativeReflectionCached.GetPropertyOffset(DrawRect_FunctionAddress, "ScreenY");
		DrawRect_ScreenY_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawRect_FunctionAddress, "ScreenY", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawRect_ScreenW_PropertyAddress, DrawRect_FunctionAddress, "ScreenW");
		DrawRect_ScreenW_Offset = NativeReflectionCached.GetPropertyOffset(DrawRect_FunctionAddress, "ScreenW");
		DrawRect_ScreenW_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawRect_FunctionAddress, "ScreenW", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawRect_ScreenH_PropertyAddress, DrawRect_FunctionAddress, "ScreenH");
		DrawRect_ScreenH_Offset = NativeReflectionCached.GetPropertyOffset(DrawRect_FunctionAddress, "ScreenH");
		DrawRect_ScreenH_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawRect_FunctionAddress, "ScreenH", Classes.FFloatProperty);
		DrawRect_IsValid = DrawRect_FunctionAddress != IntPtr.Zero && DrawRect_RectColor_IsValid && DrawRect_ScreenX_IsValid && DrawRect_ScreenY_IsValid && DrawRect_ScreenW_IsValid && DrawRect_ScreenH_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.HUD:DrawRect", DrawRect_IsValid);
		DrawMaterialTriangle_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DrawMaterialTriangle");
		DrawMaterialTriangle_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawMaterialTriangle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterialTriangle_Material_PropertyAddress, DrawMaterialTriangle_FunctionAddress, "Material");
		DrawMaterialTriangle_Material_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterialTriangle_FunctionAddress, "Material");
		DrawMaterialTriangle_Material_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterialTriangle_FunctionAddress, "Material", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterialTriangle_V0_Pos_PropertyAddress, DrawMaterialTriangle_FunctionAddress, "V0_Pos");
		DrawMaterialTriangle_V0_Pos_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterialTriangle_FunctionAddress, "V0_Pos");
		DrawMaterialTriangle_V0_Pos_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterialTriangle_FunctionAddress, "V0_Pos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterialTriangle_V1_Pos_PropertyAddress, DrawMaterialTriangle_FunctionAddress, "V1_Pos");
		DrawMaterialTriangle_V1_Pos_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterialTriangle_FunctionAddress, "V1_Pos");
		DrawMaterialTriangle_V1_Pos_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterialTriangle_FunctionAddress, "V1_Pos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterialTriangle_V2_Pos_PropertyAddress, DrawMaterialTriangle_FunctionAddress, "V2_Pos");
		DrawMaterialTriangle_V2_Pos_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterialTriangle_FunctionAddress, "V2_Pos");
		DrawMaterialTriangle_V2_Pos_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterialTriangle_FunctionAddress, "V2_Pos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterialTriangle_V0_UV_PropertyAddress, DrawMaterialTriangle_FunctionAddress, "V0_UV");
		DrawMaterialTriangle_V0_UV_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterialTriangle_FunctionAddress, "V0_UV");
		DrawMaterialTriangle_V0_UV_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterialTriangle_FunctionAddress, "V0_UV", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterialTriangle_V1_UV_PropertyAddress, DrawMaterialTriangle_FunctionAddress, "V1_UV");
		DrawMaterialTriangle_V1_UV_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterialTriangle_FunctionAddress, "V1_UV");
		DrawMaterialTriangle_V1_UV_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterialTriangle_FunctionAddress, "V1_UV", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterialTriangle_V2_UV_PropertyAddress, DrawMaterialTriangle_FunctionAddress, "V2_UV");
		DrawMaterialTriangle_V2_UV_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterialTriangle_FunctionAddress, "V2_UV");
		DrawMaterialTriangle_V2_UV_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterialTriangle_FunctionAddress, "V2_UV", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterialTriangle_V0_Color_PropertyAddress, DrawMaterialTriangle_FunctionAddress, "V0_Color");
		DrawMaterialTriangle_V0_Color_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterialTriangle_FunctionAddress, "V0_Color");
		DrawMaterialTriangle_V0_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterialTriangle_FunctionAddress, "V0_Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterialTriangle_V1_Color_PropertyAddress, DrawMaterialTriangle_FunctionAddress, "V1_Color");
		DrawMaterialTriangle_V1_Color_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterialTriangle_FunctionAddress, "V1_Color");
		DrawMaterialTriangle_V1_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterialTriangle_FunctionAddress, "V1_Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterialTriangle_V2_Color_PropertyAddress, DrawMaterialTriangle_FunctionAddress, "V2_Color");
		DrawMaterialTriangle_V2_Color_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterialTriangle_FunctionAddress, "V2_Color");
		DrawMaterialTriangle_V2_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterialTriangle_FunctionAddress, "V2_Color", Classes.FStructProperty);
		DrawMaterialTriangle_IsValid = DrawMaterialTriangle_FunctionAddress != IntPtr.Zero && DrawMaterialTriangle_Material_IsValid && DrawMaterialTriangle_V0_Pos_IsValid && DrawMaterialTriangle_V1_Pos_IsValid && DrawMaterialTriangle_V2_Pos_IsValid && DrawMaterialTriangle_V0_UV_IsValid && DrawMaterialTriangle_V1_UV_IsValid && DrawMaterialTriangle_V2_UV_IsValid && DrawMaterialTriangle_V0_Color_IsValid && DrawMaterialTriangle_V1_Color_IsValid && DrawMaterialTriangle_V2_Color_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.HUD:DrawMaterialTriangle", DrawMaterialTriangle_IsValid);
		DrawMaterialSimple_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DrawMaterialSimple");
		DrawMaterialSimple_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawMaterialSimple_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterialSimple_Material_PropertyAddress, DrawMaterialSimple_FunctionAddress, "Material");
		DrawMaterialSimple_Material_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterialSimple_FunctionAddress, "Material");
		DrawMaterialSimple_Material_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterialSimple_FunctionAddress, "Material", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterialSimple_ScreenX_PropertyAddress, DrawMaterialSimple_FunctionAddress, "ScreenX");
		DrawMaterialSimple_ScreenX_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterialSimple_FunctionAddress, "ScreenX");
		DrawMaterialSimple_ScreenX_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterialSimple_FunctionAddress, "ScreenX", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterialSimple_ScreenY_PropertyAddress, DrawMaterialSimple_FunctionAddress, "ScreenY");
		DrawMaterialSimple_ScreenY_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterialSimple_FunctionAddress, "ScreenY");
		DrawMaterialSimple_ScreenY_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterialSimple_FunctionAddress, "ScreenY", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterialSimple_ScreenW_PropertyAddress, DrawMaterialSimple_FunctionAddress, "ScreenW");
		DrawMaterialSimple_ScreenW_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterialSimple_FunctionAddress, "ScreenW");
		DrawMaterialSimple_ScreenW_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterialSimple_FunctionAddress, "ScreenW", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterialSimple_ScreenH_PropertyAddress, DrawMaterialSimple_FunctionAddress, "ScreenH");
		DrawMaterialSimple_ScreenH_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterialSimple_FunctionAddress, "ScreenH");
		DrawMaterialSimple_ScreenH_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterialSimple_FunctionAddress, "ScreenH", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterialSimple_Scale_PropertyAddress, DrawMaterialSimple_FunctionAddress, "Scale");
		DrawMaterialSimple_Scale_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterialSimple_FunctionAddress, "Scale");
		DrawMaterialSimple_Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterialSimple_FunctionAddress, "Scale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterialSimple_bScalePosition_PropertyAddress, DrawMaterialSimple_FunctionAddress, "bScalePosition");
		DrawMaterialSimple_bScalePosition_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterialSimple_FunctionAddress, "bScalePosition");
		DrawMaterialSimple_bScalePosition_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterialSimple_FunctionAddress, "bScalePosition", Classes.FBoolProperty);
		DrawMaterialSimple_IsValid = DrawMaterialSimple_FunctionAddress != IntPtr.Zero && DrawMaterialSimple_Material_IsValid && DrawMaterialSimple_ScreenX_IsValid && DrawMaterialSimple_ScreenY_IsValid && DrawMaterialSimple_ScreenW_IsValid && DrawMaterialSimple_ScreenH_IsValid && DrawMaterialSimple_Scale_IsValid && DrawMaterialSimple_bScalePosition_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.HUD:DrawMaterialSimple", DrawMaterialSimple_IsValid);
		DrawMaterial_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DrawMaterial");
		DrawMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterial_Material_PropertyAddress, DrawMaterial_FunctionAddress, "Material");
		DrawMaterial_Material_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterial_FunctionAddress, "Material");
		DrawMaterial_Material_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterial_FunctionAddress, "Material", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterial_ScreenX_PropertyAddress, DrawMaterial_FunctionAddress, "ScreenX");
		DrawMaterial_ScreenX_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterial_FunctionAddress, "ScreenX");
		DrawMaterial_ScreenX_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterial_FunctionAddress, "ScreenX", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterial_ScreenY_PropertyAddress, DrawMaterial_FunctionAddress, "ScreenY");
		DrawMaterial_ScreenY_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterial_FunctionAddress, "ScreenY");
		DrawMaterial_ScreenY_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterial_FunctionAddress, "ScreenY", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterial_ScreenW_PropertyAddress, DrawMaterial_FunctionAddress, "ScreenW");
		DrawMaterial_ScreenW_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterial_FunctionAddress, "ScreenW");
		DrawMaterial_ScreenW_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterial_FunctionAddress, "ScreenW", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterial_ScreenH_PropertyAddress, DrawMaterial_FunctionAddress, "ScreenH");
		DrawMaterial_ScreenH_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterial_FunctionAddress, "ScreenH");
		DrawMaterial_ScreenH_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterial_FunctionAddress, "ScreenH", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterial_MaterialU_PropertyAddress, DrawMaterial_FunctionAddress, "MaterialU");
		DrawMaterial_MaterialU_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterial_FunctionAddress, "MaterialU");
		DrawMaterial_MaterialU_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterial_FunctionAddress, "MaterialU", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterial_MaterialV_PropertyAddress, DrawMaterial_FunctionAddress, "MaterialV");
		DrawMaterial_MaterialV_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterial_FunctionAddress, "MaterialV");
		DrawMaterial_MaterialV_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterial_FunctionAddress, "MaterialV", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterial_MaterialUWidth_PropertyAddress, DrawMaterial_FunctionAddress, "MaterialUWidth");
		DrawMaterial_MaterialUWidth_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterial_FunctionAddress, "MaterialUWidth");
		DrawMaterial_MaterialUWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterial_FunctionAddress, "MaterialUWidth", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterial_MaterialVHeight_PropertyAddress, DrawMaterial_FunctionAddress, "MaterialVHeight");
		DrawMaterial_MaterialVHeight_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterial_FunctionAddress, "MaterialVHeight");
		DrawMaterial_MaterialVHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterial_FunctionAddress, "MaterialVHeight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterial_Scale_PropertyAddress, DrawMaterial_FunctionAddress, "Scale");
		DrawMaterial_Scale_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterial_FunctionAddress, "Scale");
		DrawMaterial_Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterial_FunctionAddress, "Scale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterial_bScalePosition_PropertyAddress, DrawMaterial_FunctionAddress, "bScalePosition");
		DrawMaterial_bScalePosition_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterial_FunctionAddress, "bScalePosition");
		DrawMaterial_bScalePosition_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterial_FunctionAddress, "bScalePosition", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterial_Rotation_PropertyAddress, DrawMaterial_FunctionAddress, "Rotation");
		DrawMaterial_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterial_FunctionAddress, "Rotation");
		DrawMaterial_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterial_FunctionAddress, "Rotation", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawMaterial_RotPivot_PropertyAddress, DrawMaterial_FunctionAddress, "RotPivot");
		DrawMaterial_RotPivot_Offset = NativeReflectionCached.GetPropertyOffset(DrawMaterial_FunctionAddress, "RotPivot");
		DrawMaterial_RotPivot_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawMaterial_FunctionAddress, "RotPivot", Classes.FStructProperty);
		DrawMaterial_IsValid = DrawMaterial_FunctionAddress != IntPtr.Zero && DrawMaterial_Material_IsValid && DrawMaterial_ScreenX_IsValid && DrawMaterial_ScreenY_IsValid && DrawMaterial_ScreenW_IsValid && DrawMaterial_ScreenH_IsValid && DrawMaterial_MaterialU_IsValid && DrawMaterial_MaterialV_IsValid && DrawMaterial_MaterialUWidth_IsValid && DrawMaterial_MaterialVHeight_IsValid && DrawMaterial_Scale_IsValid && DrawMaterial_bScalePosition_IsValid && DrawMaterial_Rotation_IsValid && DrawMaterial_RotPivot_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.HUD:DrawMaterial", DrawMaterial_IsValid);
		DrawLine_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DrawLine");
		DrawLine_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawLine_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawLine_StartScreenX_PropertyAddress, DrawLine_FunctionAddress, "StartScreenX");
		DrawLine_StartScreenX_Offset = NativeReflectionCached.GetPropertyOffset(DrawLine_FunctionAddress, "StartScreenX");
		DrawLine_StartScreenX_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawLine_FunctionAddress, "StartScreenX", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawLine_StartScreenY_PropertyAddress, DrawLine_FunctionAddress, "StartScreenY");
		DrawLine_StartScreenY_Offset = NativeReflectionCached.GetPropertyOffset(DrawLine_FunctionAddress, "StartScreenY");
		DrawLine_StartScreenY_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawLine_FunctionAddress, "StartScreenY", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawLine_EndScreenX_PropertyAddress, DrawLine_FunctionAddress, "EndScreenX");
		DrawLine_EndScreenX_Offset = NativeReflectionCached.GetPropertyOffset(DrawLine_FunctionAddress, "EndScreenX");
		DrawLine_EndScreenX_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawLine_FunctionAddress, "EndScreenX", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawLine_EndScreenY_PropertyAddress, DrawLine_FunctionAddress, "EndScreenY");
		DrawLine_EndScreenY_Offset = NativeReflectionCached.GetPropertyOffset(DrawLine_FunctionAddress, "EndScreenY");
		DrawLine_EndScreenY_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawLine_FunctionAddress, "EndScreenY", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawLine_LineColor_PropertyAddress, DrawLine_FunctionAddress, "LineColor");
		DrawLine_LineColor_Offset = NativeReflectionCached.GetPropertyOffset(DrawLine_FunctionAddress, "LineColor");
		DrawLine_LineColor_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawLine_FunctionAddress, "LineColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawLine_LineThickness_PropertyAddress, DrawLine_FunctionAddress, "LineThickness");
		DrawLine_LineThickness_Offset = NativeReflectionCached.GetPropertyOffset(DrawLine_FunctionAddress, "LineThickness");
		DrawLine_LineThickness_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawLine_FunctionAddress, "LineThickness", Classes.FFloatProperty);
		DrawLine_IsValid = DrawLine_FunctionAddress != IntPtr.Zero && DrawLine_StartScreenX_IsValid && DrawLine_StartScreenY_IsValid && DrawLine_EndScreenX_IsValid && DrawLine_EndScreenY_IsValid && DrawLine_LineColor_IsValid && DrawLine_LineThickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.HUD:DrawLine", DrawLine_IsValid);
		Deproject_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Deproject");
		Deproject_ParamsSize = NativeReflection.GetFunctionParamsSize(Deproject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Deproject_ScreenX_PropertyAddress, Deproject_FunctionAddress, "ScreenX");
		Deproject_ScreenX_Offset = NativeReflectionCached.GetPropertyOffset(Deproject_FunctionAddress, "ScreenX");
		Deproject_ScreenX_IsValid = NativeReflectionCached.ValidatePropertyClass(Deproject_FunctionAddress, "ScreenX", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Deproject_ScreenY_PropertyAddress, Deproject_FunctionAddress, "ScreenY");
		Deproject_ScreenY_Offset = NativeReflectionCached.GetPropertyOffset(Deproject_FunctionAddress, "ScreenY");
		Deproject_ScreenY_IsValid = NativeReflectionCached.ValidatePropertyClass(Deproject_FunctionAddress, "ScreenY", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Deproject_WorldPosition_PropertyAddress, Deproject_FunctionAddress, "WorldPosition");
		Deproject_WorldPosition_Offset = NativeReflectionCached.GetPropertyOffset(Deproject_FunctionAddress, "WorldPosition");
		Deproject_WorldPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(Deproject_FunctionAddress, "WorldPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Deproject_WorldDirection_PropertyAddress, Deproject_FunctionAddress, "WorldDirection");
		Deproject_WorldDirection_Offset = NativeReflectionCached.GetPropertyOffset(Deproject_FunctionAddress, "WorldDirection");
		Deproject_WorldDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(Deproject_FunctionAddress, "WorldDirection", Classes.FStructProperty);
		Deproject_IsValid = Deproject_FunctionAddress != IntPtr.Zero && Deproject_ScreenX_IsValid && Deproject_ScreenY_IsValid && Deproject_WorldPosition_IsValid && Deproject_WorldDirection_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.HUD:Deproject", Deproject_IsValid);
		AddHitBox_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddHitBox");
		AddHitBox_ParamsSize = NativeReflection.GetFunctionParamsSize(AddHitBox_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddHitBox_Position_PropertyAddress, AddHitBox_FunctionAddress, "Position");
		AddHitBox_Position_Offset = NativeReflectionCached.GetPropertyOffset(AddHitBox_FunctionAddress, "Position");
		AddHitBox_Position_IsValid = NativeReflectionCached.ValidatePropertyClass(AddHitBox_FunctionAddress, "Position", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddHitBox_Size_PropertyAddress, AddHitBox_FunctionAddress, "Size");
		AddHitBox_Size_Offset = NativeReflectionCached.GetPropertyOffset(AddHitBox_FunctionAddress, "Size");
		AddHitBox_Size_IsValid = NativeReflectionCached.ValidatePropertyClass(AddHitBox_FunctionAddress, "Size", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddHitBox_InName_PropertyAddress, AddHitBox_FunctionAddress, "InName");
		AddHitBox_InName_Offset = NativeReflectionCached.GetPropertyOffset(AddHitBox_FunctionAddress, "InName");
		AddHitBox_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddHitBox_FunctionAddress, "InName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddHitBox_bConsumesInput_PropertyAddress, AddHitBox_FunctionAddress, "bConsumesInput");
		AddHitBox_bConsumesInput_Offset = NativeReflectionCached.GetPropertyOffset(AddHitBox_FunctionAddress, "bConsumesInput");
		AddHitBox_bConsumesInput_IsValid = NativeReflectionCached.ValidatePropertyClass(AddHitBox_FunctionAddress, "bConsumesInput", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddHitBox_Priority_PropertyAddress, AddHitBox_FunctionAddress, "Priority");
		AddHitBox_Priority_Offset = NativeReflectionCached.GetPropertyOffset(AddHitBox_FunctionAddress, "Priority");
		AddHitBox_Priority_IsValid = NativeReflectionCached.ValidatePropertyClass(AddHitBox_FunctionAddress, "Priority", Classes.FIntProperty);
		AddHitBox_IsValid = AddHitBox_FunctionAddress != IntPtr.Zero && AddHitBox_Position_IsValid && AddHitBox_Size_IsValid && AddHitBox_InName_IsValid && AddHitBox_bConsumesInput_IsValid && AddHitBox_Priority_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.HUD:AddHitBox", AddHitBox_IsValid);
	}
}
