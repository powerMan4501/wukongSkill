using System;
using b1.BGW;
using b1.Plugins.GSInput;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_StickLevelDotCS")]
public class BI_StickLevelDotCS : BUI_Widget
{
	private UWidgetAnimation AnimShow_Level_1;

	private UWidgetAnimation AnimShow_Level_2;

	private UWidgetAnimation AnimShow_Level_3;

	private UWidgetAnimation AnimShow_Level_4;

	private UWidgetAnimation AnimHide_Level_1;

	private UWidgetAnimation AnimHide_Level_2;

	private UWidgetAnimation AnimHide_Level_3;

	private UWidgetAnimation AnimHide_Level_4;

	private UWidgetAnimation AnimCost;

	private UWidgetAnimation AnimActiveDot;

	private UWidgetAnimation AnimPoseChange;

	private UCanvasPanel InputConCon;

	private UCanvasPanel InputCon;

	private UOverlay XBOXCon;

	private UOverlay PS5Con;

	private b1.UI.EPELevelIconStat CurPELevelIconStat;

	private static bool BindPelevel_IsValid;

	private static int BindPelevel_Offset;

	[UProperty]
	[EditAnywhere]
	[Category("GSProperty")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BI_StickLevelDotCS:BindPelevel")]
	public int BindPelevel
	{
		get
		{
			CheckDestroyed();
			if (!BindPelevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_StickLevelDotCS:BindPelevel");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BindPelevel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BindPelevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_StickLevelDotCS:BindPelevel");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BindPelevel_Offset), value);
			}
		}
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		AnimShow_Level_1 = FindWidgetAnimation("AnimShowDot1");
		AnimShow_Level_2 = FindWidgetAnimation("AnimShowDot2");
		AnimShow_Level_3 = FindWidgetAnimation("AnimShowDot3");
		AnimShow_Level_4 = FindWidgetAnimation("AnimShowDot4");
		AnimHide_Level_1 = FindWidgetAnimation("AnimHideDot1");
		AnimHide_Level_2 = FindWidgetAnimation("AnimHideDot2");
		AnimHide_Level_3 = FindWidgetAnimation("AnimHideDot3");
		AnimHide_Level_4 = FindWidgetAnimation("AnimHideDot4");
		AnimCost = FindWidgetAnimation("AnimCosted");
		AnimActiveDot = FindWidgetAnimation("AnimActiveDot");
		AnimPoseChange = FindWidgetAnimation("AnimTogglePose");
		InputConCon = FindChildWidget("InputRootCon") as UCanvasPanel;
		InputCon = FindChildWidget("InputRoot") as UCanvasPanel;
		XBOXCon = FindChildWidget("xb") as UOverlay;
		PS5Con = FindChildWidget("ps") as UOverlay;
		if (FPlatformProperties.GetPlatform() == EPlatform.PS5)
		{
			PS5Con?.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
			XBOXCon?.SetVisibility(ESlateVisibility.Collapsed);
		}
		else
		{
			PS5Con?.SetVisibility(ESlateVisibility.Collapsed);
			XBOXCon?.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
		}
		CurPELevelIconStat = b1.UI.EPELevelIconStat.Empty;
		OnSwitchInput(BGW_EnhancedInputMgrV2.GetCurrentInputType());
	}

	public void OnUpdateFull(int OldLevel, int NewLevel, bool IsInit, bool IsPoseDot)
	{
		if (NewLevel > OldLevel)
		{
			if (BindPelevel == 4 && BindPelevel > NewLevel && IsPoseDot)
			{
				PlayAnim(b1.UI.EPELevelEvent.Gained, NewLevel);
			}
			if (NewLevel >= BindPelevel && BindPelevel > OldLevel && CurPELevelIconStat != b1.UI.EPELevelIconStat.Gained)
			{
				PlayAnim(b1.UI.EPELevelEvent.Gained, BindPelevel);
				UpdateSetIconStat(b1.UI.EPELevelIconStat.Gained);
				if (!IsInit)
				{
					BGW_UIMgr.Get(this).PlayUISound($"EVT_hud_player_gunshi_level{BindPelevel}");
				}
			}
		}
		else if (NewLevel < OldLevel)
		{
			if (BindPelevel == 4 && BindPelevel > OldLevel && IsPoseDot)
			{
				PlayAnim(b1.UI.EPELevelEvent.Costed, OldLevel);
			}
			if (OldLevel >= BindPelevel && BindPelevel > NewLevel && CurPELevelIconStat == b1.UI.EPELevelIconStat.Gained)
			{
				PlayAnim(b1.UI.EPELevelEvent.Costed, BindPelevel);
				UpdateSetIconStat(b1.UI.EPELevelIconStat.Lose);
			}
		}
	}

	public void OnUpdateActive(bool IsActive)
	{
		if (IsActive)
		{
			PlayWidgetAnimation(AnimActiveDot);
			GSAnimKeyToState("AKBActiveDot", $"Dot{BindPelevel}", IsForce: true);
		}
		else
		{
			GSAnimKeyToState("AKBActiveDot", "Default", IsForce: true);
		}
	}

	private void PlayAnim(b1.UI.EPELevelEvent Stat, int CurPELevel)
	{
		if (Stat == b1.UI.EPELevelEvent.Gained)
		{
			UWidgetAnimation animHide = GetAnimHide(CurPELevel);
			if (animHide != null && IsAnimationPlaying(animHide))
			{
				StopAnimation(animHide);
			}
			if (AnimCost != null && IsAnimationPlaying(AnimCost))
			{
				StopAnimation(AnimCost);
			}
			UWidgetAnimation animShow = GetAnimShow(CurPELevel);
			if (animShow != null)
			{
				PlayWidgetAnimation(animShow);
			}
		}
		if (Stat != b1.UI.EPELevelEvent.Costed)
		{
			return;
		}
		UWidgetAnimation animShow2 = GetAnimShow(CurPELevel);
		if (animShow2 != null && IsAnimationPlaying(animShow2))
		{
			StopAnimation(animShow2);
		}
		UWidgetAnimation animHide2 = GetAnimHide(CurPELevel);
		if (animHide2 != null)
		{
			PlayWidgetAnimation(animHide2);
		}
		if (AnimCost != null)
		{
			if (IsAnimationPlaying(AnimCost))
			{
				StopAnimation(AnimCost);
			}
			PlayWidgetAnimation(AnimCost);
		}
	}

	private UWidgetAnimation GetAnimShow(int CurPELevel)
	{
		return CurPELevel switch
		{
			1 => AnimShow_Level_1, 
			2 => AnimShow_Level_2, 
			3 => AnimShow_Level_3, 
			4 => AnimShow_Level_4, 
			_ => null, 
		};
	}

	private UWidgetAnimation GetAnimHide(int CurPELevel)
	{
		return CurPELevel switch
		{
			1 => AnimHide_Level_1, 
			2 => AnimHide_Level_2, 
			3 => AnimHide_Level_3, 
			4 => AnimHide_Level_4, 
			_ => null, 
		};
	}

	private void UpdateSetIconStat(b1.UI.EPELevelIconStat NewPELevelIconStat)
	{
		if (CurPELevelIconStat != NewPELevelIconStat)
		{
			if (NewPELevelIconStat == b1.UI.EPELevelIconStat.Lose)
			{
				NewPELevelIconStat = b1.UI.EPELevelIconStat.Empty;
			}
			CurPELevelIconStat = NewPELevelIconStat;
		}
	}

	public void UpdateLockState(int Pelevel)
	{
		if (Pelevel < BindPelevel)
		{
			GSAnimKeyToState("AKBDotLockState", "Locked", IsForce: true);
		}
		else
		{
			GSAnimKeyToState("AKBDotLockState", "Unlock", IsForce: true);
		}
	}

	public void UpdatePosType(int Idx)
	{
		UMaterialParameterCollection stylePoseMPC = BGW_PreloadAssetMgr.Get(this).UIConfigDataAsset.StylePoseMPC;
		if (stylePoseMPC != null)
		{
			UMaterialLibrary.SetScalarParameterValue(this, stylePoseMPC, B1GlobalFNames.GSMIParameter_StyleIndex, Idx);
		}
		if (IsAnimationPlaying(AnimPoseChange))
		{
			StopAnimation(AnimPoseChange);
		}
		PlayAnimation(AnimPoseChange);
	}

	public void UpdateInputVisibility(int StanceNum)
	{
		if (StanceNum > 1)
		{
			InputConCon?.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
		}
		else
		{
			InputConCon?.SetVisibility(ESlateVisibility.Collapsed);
		}
	}

	protected override void OnSwitchInput(EGSInputType InputType)
	{
		switch (InputType)
		{
		case EGSInputType.KeyboardMouse:
			InputCon?.SetVisibility(ESlateVisibility.Collapsed);
			break;
		case EGSInputType.Gamepad:
			InputCon?.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
			break;
		case EGSInputType.None:
		case EGSInputType.Touch:
		case EGSInputType.Other:
			break;
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BI_StickLevelDotCS");
		BindPelevel_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BindPelevel");
		BindPelevel_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BindPelevel", Classes.FIntProperty);
	}

	static BI_StickLevelDotCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_StickLevelDotCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_StickLevelDotCS));
	}
}
