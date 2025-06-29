using System;
using System.Collections.Generic;
using b1.GSMUI;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.GSMUICore.Event;

public class GSMSeqUtil
{
	public static GSMEventWidgetQuickBezierTo GenDirRandBezierTo(UWidget RefWidget, FVector2D RefDir, FVector2D StartPos, FVector2D EndPos, float DurationRef, float DelayTime = 0f)
	{
		float num = 300f + GSMMathUtil.RandFloat() * 100f;
		FVector2D control = StartPos + RefDir * num;
		float num2 = GSMMathUtil.RandFloat() * 0.1f;
		float duration = DurationRef + num2;
		return new GSMEventWidgetQuickBezierTo(RefWidget, StartPos, control, EndPos, duration, DelayTime);
	}

	public static GSMEventWidgetQuickBezierTo GenBackDirRandBezierTo(UWidget RefWidget, FVector2D StartPos, FVector2D EndPos, float DistParam, float DegParam, float DurationRef, float DelayTime = 0f)
	{
		int num = 1;
		if (GSMMathUtil.RandFloat() >= 0.5f)
		{
			num = -1;
		}
		FVector2D fVector2D = StartPos - EndPos;
		fVector2D.Normalize();
		float num2 = DistParam + GSMMathUtil.RandFloat() * DistParam;
		float num3 = DegParam + GSMMathUtil.RandFloat() * DegParam;
		FVector2D control = StartPos + fVector2D.GetRotated((float)num * num3) * num2;
		float num4 = GSMMathUtil.RandFloat() * 0.1f;
		float duration = DurationRef + num4;
		return new GSMEventWidgetQuickBezierTo(RefWidget, StartPos, control, EndPos, duration, DelayTime);
	}

	public static GSMUIEventBase GenListShowInSeq(float FirstDelay, float PerDelay, List<IGSMShowIn> ItemList)
	{
		GSMUIEventSequence gSMUIEventSequence = new GSMUIEventSequence();
		gSMUIEventSequence.AddEvent(new GSMUIDelay(FirstDelay));
		for (int i = 0; i < ItemList.Count; i++)
		{
			IGSMShowIn OneItem = ItemList[i];
			OneItem.ResetForPlayShowInAnim();
			gSMUIEventSequence.AddEvent(new GSMUIDelay(PerDelay));
			gSMUIEventSequence.AddEvent(new GSMUIEventExecFunc(delegate
			{
				OneItem.PlayShowInAnim();
			}));
		}
		return gSMUIEventSequence;
	}

	public static GSMUIEventSequence GenGapExecFuncSeq(float FirstDelay, float PerDelay, List<Action> ActionFuncList)
	{
		GSMUIEventSequence SeqIn = new GSMUIEventSequence();
		SeqIn.AddEvent(new GSMUIDelay(FirstDelay));
		ActionFuncList.ForEach(delegate(Action OneAction)
		{
			SeqIn.AddEvent(new GSMUIDelay(PerDelay));
			SeqIn.AddEvent(new GSMUIEventExecFunc(OneAction));
		});
		return SeqIn;
	}

	public static GSMUIEventSequence GenPanelChildUserWidgetShowInSeq(float FirstDelay, float PerDelay, UPanelWidget RootPanel, string ShowInAnimName)
	{
		List<UWidget> allChildren = RootPanel.GetAllChildren();
		GSMUIEventSequence gSMUIEventSequence = new GSMUIEventSequence();
		gSMUIEventSequence.AddEvent(new GSMUIDelay(FirstDelay));
		for (int i = 0; i < allChildren.Count; i++)
		{
			UUserWidget OneItem = allChildren[i] as UUserWidget;
			if (OneItem.GetVisibility() != ESlateVisibility.Collapsed)
			{
				OneItem.SetRenderOpacity(0f);
				gSMUIEventSequence.AddEvent(new GSMUIDelay(PerDelay));
				gSMUIEventSequence.AddEvent(new GSMUIEventExecFunc(delegate
				{
					OneItem.SetRenderOpacity(1f);
				}));
			}
		}
		return gSMUIEventSequence;
	}
}
