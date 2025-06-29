using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.GSMUICore.Event;

public class GSMUIWidgetCurveTranslation : GSMUIEventBase
{
	private UWidget TargetWidget;

	private readonly float DelayTime;

	private readonly FVector2D Start;

	private readonly FVector2D End;

	private readonly float Duration;

	private readonly WCTCurveParam Param;

	private FVector2D CurTranslation = FVector2D.ZeroVector;

	private readonly float Amplitude;

	private readonly float AmplitudePadding;

	private readonly FVector2D SideDir;

	public GSMUIWidgetCurveTranslation(UWidget RefWidget, WCTCurveParam InParam, float Duration = 0.5f, FVector2D Start = default(FVector2D), FVector2D End = default(FVector2D), float DelayTime = 0f)
		: base("GSMUIWidgetCurveTranslation")
	{
		this.DelayTime = DelayTime;
		TargetWidget = RefWidget;
		this.Duration = Duration;
		this.Start = Start;
		this.End = End;
		Param = InParam;
		CurTranslation = Start;
		TargetWidget.SetRenderTranslation(CurTranslation);
		Random random = new Random();
		FVector2D sideDir = GetSideDir(Start, End, random);
		float num = Param.AmplitudeRateMin + (float)random.NextDouble() * Param.AmplitudeRateMax;
		AmplitudePadding = Param.AmplitudeMin + (float)random.NextDouble() * (Param.AmplitudeMax - Param.AmplitudeMin);
		SideDir = sideDir * num + sideDir.Normal2D() * AmplitudePadding;
	}

	protected override GSMUITickableStat DoTickImpl(float DeltaTime)
	{
		if (RunTime < DelayTime)
		{
			return GSMUITickableStat.TICKING;
		}
		float num = RunTime - DelayTime;
		float x = num / Duration;
		x = MathLib.Clamp(x, 0f, 1f);
		float num2 = GSEaseFunc.Ease(Param.ForwardEasingFunc, 0f, 1f, x, Param.ForwardEaseParam);
		float num3 = GSEaseFunc.Ease(Param.SideEasingFunc, 0f, 1f, x, Param.SideEaseParam);
		FVector2D fVector2D = End - Start;
		CurTranslation = fVector2D * num2 + SideDir * num3 + Start;
		TargetWidget.SetRenderTranslation(CurTranslation);
		if (num >= Duration)
		{
			return GSMUITickableStat.IDLE;
		}
		return GSMUITickableStat.TICKING;
	}

	public static FVector2D RandomDir(Random Rand)
	{
		int num = Rand.Next(2);
		if (num == 0)
		{
			num = -1;
		}
		float num2 = (float)Rand.NextDouble() * 2f - 1f;
		float num3 = (float)Math.Sqrt(1.0 - Math.Pow(num2, 2.0)) * (float)num;
		return new FVector2D(num2, num3);
	}

	private FVector2D GetSideDir(FVector2D Start, FVector2D End, Random Rand)
	{
		FVector2D fVector2D = End - Start;
		FVector2D fVector2D2 = new FVector2D(fVector2D.Y, 0f - fVector2D.X);
		if (Param.OriginVector != FVector2D.ZeroVector)
		{
			if (FVector2D.DotProduct(Param.OriginVector, fVector2D2) < 0f)
			{
				return -fVector2D2;
			}
		}
		else if (Rand.Next(2) == 0)
		{
			return -fVector2D2;
		}
		return fVector2D2;
	}
}
