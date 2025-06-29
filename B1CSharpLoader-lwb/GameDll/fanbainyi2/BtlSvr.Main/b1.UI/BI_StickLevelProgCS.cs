using System;
using b1.BGW;
using b1.GSMUI.GSWidget;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_StickLevelProgCS")]
public class BI_StickLevelProgCS : BUI_Widget
{
	private IProcBar ProgBar;

	private UWidgetAnimation AnimStA;

	private UWidgetAnimation AnimStB;

	private UWidgetAnimation AnimStC;

	private UWidgetAnimation AnimStD;

	private UWidgetAnimation AnimCosted;

	private UWidgetAnimation AnimReset;

	private UWidgetAnimation AnimIncrease;

	private int CurPelevel;

	private float MaxValue = 100f;

	private float PrecentSplite = 1f;

	private float LastPercent;

	private float ProgBaseTexSize;

	private float ProgBaseTexSizeV1 = 124f;

	private float ProgBaseTexSizeV2 = 340f;

	private float ProgBaseTexSizeV3 = 400f;

	private float ProgPercentSplite = 0.6f;

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		ProgBaseTexSizeV1 = BGW_PreloadAssetMgr.Get(this).UIConfigDataAsset.ProgBaseTexSizeV1;
		ProgBaseTexSizeV2 = BGW_PreloadAssetMgr.Get(this).UIConfigDataAsset.ProgBaseTexSizeV2;
		ProgBaseTexSizeV3 = BGW_PreloadAssetMgr.Get(this).UIConfigDataAsset.ProgBaseTexSizeV3;
		ProgPercentSplite = BGW_PreloadAssetMgr.Get(this).UIConfigDataAsset.ProgPercentSplite;
		UCanvasPanel uCanvasPanel = FindChildWidget("ProgBarCon") as UCanvasPanel;
		if (uCanvasPanel != null)
		{
			ProgBar = FindAndConstructIProcBar(uCanvasPanel, "ProgBar");
			ProgBar.SetValue(0f, IsImmediately: true);
		}
		UpdateMaxValue(MaxValue, IsForce: true);
		AnimStA = FindWidgetAnimation("StAnimA");
		AnimStB = FindWidgetAnimation("StAnimB");
		AnimStC = FindWidgetAnimation("StAnimC");
		AnimStD = FindWidgetAnimation("StAnimD");
		AnimCosted = FindWidgetAnimation("AnimCosted");
		AnimReset = FindWidgetAnimation("AnimReset");
		AnimIncrease = FindWidgetAnimation("AnimIncrease");
	}

	public void UpdateMaxValue(float MaxValue, bool IsForce = false)
	{
		if (this.MaxValue != MaxValue || IsForce)
		{
			this.MaxValue = MaxValue;
			UMaterialLibrary.SetScalarParameterValue(this, BGW_PreloadAssetMgr.Get(this).MPCStickProg, B1GlobalFNames.GSMIParameter_ProgValueMax, MaxValue);
		}
	}

	public void UpdatePrecentSplite(bool IsSplite)
	{
		if (IsSplite)
		{
			UpdatePrecentSplite(LastPercent);
		}
		else
		{
			UpdatePrecentSplite(1f);
		}
	}

	public void UpdatePrecentSplite(float PrecentSplite, bool IsForce = false)
	{
		if (this.PrecentSplite != PrecentSplite || IsForce)
		{
			this.PrecentSplite = PrecentSplite;
			UMaterialLibrary.SetScalarParameterValue(this, BGW_PreloadAssetMgr.Get(this).MPCStickProg, B1GlobalFNames.GSMIParameter_PercentSplite, PrecentSplite);
		}
	}

	public void UpdateProgBaseTexSize(int Level, bool IsInit = false, bool NeedLevel5 = false)
	{
		if (Level == 4 || Level == 5)
		{
			if (NeedLevel5)
			{
				SetProgBaseTexSize(ProgBaseTexSizeV3, IsInit);
				UpdatePrecentSplite(ProgPercentSplite, IsInit);
			}
			else
			{
				SetProgBaseTexSize(ProgBaseTexSizeV2, IsInit);
				UpdatePrecentSplite(1f, IsInit);
			}
		}
		else
		{
			SetProgBaseTexSize(ProgBaseTexSizeV1, IsInit);
			UpdatePrecentSplite(1f, IsInit);
		}
	}

	private void SetProgBaseTexSize(float ProgBaseTexSize, bool IsForce = false)
	{
		if (this.ProgBaseTexSize != ProgBaseTexSize || IsForce)
		{
			this.ProgBaseTexSize = ProgBaseTexSize;
			UMaterialLibrary.SetScalarParameterValue(this, BGW_PreloadAssetMgr.Get(this).MPCStickProg, B1GlobalFNames.GSMIParameter_ProgBaseTexSize, ProgBaseTexSize);
		}
	}

	public void SetPercent(float Percent, int Pelevel, bool IsIncreace, bool IsImmediately = false)
	{
		if (ProgBar != null)
		{
			if (Percent < LastPercent && IsIncreace)
			{
				ProgBar.SetValue(Percent, IsImmediately: true);
			}
			else
			{
				ProgBar.SetValue(Percent, IsImmediately);
			}
		}
		LastPercent = Percent;
		UpdateState(Pelevel);
	}

	private void UpdateState(int Pelevel)
	{
		if (CurPelevel != Pelevel)
		{
			CurPelevel = Pelevel;
			switch (Pelevel)
			{
			case 0:
				GSAnimKeyToState("AKBState", "StDefault");
				break;
			case 1:
				PlayWidgetAnimation(AnimStA);
				GSAnimKeyToState("AKBState", "StA");
				break;
			case 2:
				PlayWidgetAnimation(AnimStB);
				GSAnimKeyToState("AKBState", "StB");
				break;
			case 3:
				PlayWidgetAnimation(AnimStC);
				GSAnimKeyToState("AKBState", "StC");
				break;
			case 4:
				PlayWidgetAnimation(AnimStD);
				GSAnimKeyToState("AKBState", "StD");
				break;
			}
		}
	}

	public void PlayAKBState(string State)
	{
		GSAnimKeyToState("AKBState", State);
	}

	public void PlayAnimStA()
	{
		PlayWidgetAnimation(AnimStA);
	}

	public void PlayAnimStB()
	{
		PlayWidgetAnimation(AnimStB);
	}

	public void PlayAnimStC()
	{
		PlayWidgetAnimation(AnimStC);
	}

	public void PlayAnimStD()
	{
		PlayWidgetAnimation(AnimStD);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BI_StickLevelProgCS");
	}

	static BI_StickLevelProgCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_StickLevelProgCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_StickLevelProgCS));
	}
}
