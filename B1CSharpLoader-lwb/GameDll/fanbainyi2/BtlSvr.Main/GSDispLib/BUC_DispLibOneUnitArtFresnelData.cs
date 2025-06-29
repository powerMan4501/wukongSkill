using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class BUC_DispLibOneUnitArtFresnelData
{
	public BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode;

	public TStrongObjectPtr<UCurveFloat> GSArtFresnelPower = new TStrongObjectPtr<UCurveFloat>();

	public TStrongObjectPtr<UCurveLinearColor> FColor_Out = new TStrongObjectPtr<UCurveLinearColor>();

	public TStrongObjectPtr<UCurveLinearColor> FColor_In = new TStrongObjectPtr<UCurveLinearColor>();

	public uint UAFID { get; internal set; }

	public bool Active { get; internal set; }

	public bool isPause { get; internal set; }

	public int Priority { get; internal set; }

	public float Time { get; internal set; }

	public float OnePeriodTime { get; internal set; }

	public bool SimpleProgrammedCurve { get; internal set; }

	public float FadeInTime { get; internal set; }

	public float CommonTime { get; internal set; }

	public float FadeOutTime { get; internal set; }

	public float ProgrammedPowerMax { get; internal set; }

	public bool Loop { get; internal set; }

	public bool UseVertexNormalNotTex { get; internal set; }

	public bool InvertGSArtFresnel { get; internal set; }

	public bool UseContrastInsteadPower { get; internal set; }

	public float BrightValue { get; internal set; }

	public float DarkValue { get; internal set; }

	public bool ClampGSArtFresnelDotProduct { get; internal set; }

	public bool UseHeightGradientRamp { get; internal set; }

	public float TopAlpha { get; internal set; }

	public float BottomAlpha { get; internal set; }

	public float UnitHeight { get; internal set; }

	public float Age { get; internal set; }

	public float CurPeriodAge { get; internal set; }

	public bool GetLoop()
	{
		return Loop;
	}

	public float GetAge()
	{
		return Age;
	}

	public float GetCurPeriodAge()
	{
		return Age;
	}

	internal void Reset()
	{
		Active = false;
		isPause = false;
		FilterMode = default(BUC_DispLibDBC_MaterialEffectTargetInfo);
		Priority = 0;
		Time = 0f;
		OnePeriodTime = 0f;
		SimpleProgrammedCurve = false;
		FadeInTime = 0f;
		CommonTime = 0f;
		FadeOutTime = 0f;
		Loop = false;
		UseVertexNormalNotTex = false;
		InvertGSArtFresnel = false;
		UseContrastInsteadPower = false;
		BrightValue = 0f;
		DarkValue = 0f;
		GSArtFresnelPower.SetNull();
		ClampGSArtFresnelDotProduct = false;
		UseHeightGradientRamp = false;
		TopAlpha = 0f;
		BottomAlpha = 0f;
		UnitHeight = 0f;
		FColor_Out.SetNull();
		FColor_In.SetNull();
		Age = 0f;
		CurPeriodAge = 0f;
	}
}
