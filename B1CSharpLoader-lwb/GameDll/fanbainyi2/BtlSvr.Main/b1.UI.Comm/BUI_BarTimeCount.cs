using System;
using b1.GSMUICore.Event;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI.Comm;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_BarTimeCount")]
public class BUI_BarTimeCount : BUI_Widget
{
	private UImage SkillIconBGImg;

	private UImage BarMainImg;

	private UTextBlock TxtTime;

	private UMaterialInstanceDynamic BarMainMat;

	private GSMUIEventBase MainBarTweenEvent;

	private float LeftDuration { get; set; }

	private int LastCount { get; set; }

	private float TotalDuration { get; set; }

	private string GetDebugInfo()
	{
		return $"TotalDuration:{LeftDuration}";
	}

	protected override void OnUIInitialized()
	{
		SkillIconBGImg = FindChildWidget("SkillIconBGImg") as UImage;
		BarMainImg = FindChildWidget("BarMainImg") as UImage;
		TxtTime = FindChildWidget("TxtTime") as UTextBlock;
		BarMainMat = BarMainImg.GetDynamicMaterial();
	}

	public void SetIsNeedLeftOffset(bool IsNeed)
	{
	}

	protected override void OnUIPreConstruct()
	{
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
	}

	public void StartTimeCount(float TotalTime)
	{
		if (MainBarTweenEvent != null)
		{
			MainBarTweenEvent.Stop();
		}
		TotalDuration = TotalTime;
		LeftDuration = TotalTime;
		MainBarTweenEvent = AppendGSMUIEvent(new GSMUITweenBarMatPercent(BarMainMat, 1f, 0f, TotalTime, 0.1f, EEasingFunc.Linear));
	}

	[UFunction]
	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		if (!(LeftDuration <= 0f))
		{
			LeftDuration -= InDeltaTime;
			int num = (int)LeftDuration;
			if (num != LastCount)
			{
				TxtTime.SetText(FText.FromString($"{num}"));
				LastCount = num;
			}
		}
	}

	public void PreStart(float StartTime)
	{
		if (!(LeftDuration + 1.5f >= TotalDuration))
		{
			if (MainBarTweenEvent != null)
			{
				MainBarTweenEvent.Stop();
			}
			int num = (int)StartTime;
			LeftDuration = 0f;
			TxtTime.SetText(FText.FromString($"{num}"));
			BarMainMat.SetScalarParameterValue(B1Names.GSMaskMatPercent, 1f);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUI_BarTimeCount");
	}

	static BUI_BarTimeCount()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_BarTimeCount)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_BarTimeCount));
	}
}
