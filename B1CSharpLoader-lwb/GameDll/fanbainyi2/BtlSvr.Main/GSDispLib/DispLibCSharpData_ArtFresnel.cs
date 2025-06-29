using UnrealEngine.Engine;

namespace GSDispLib;

public class DispLibCSharpData_ArtFresnel
{
	public BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode { get; private set; }

	public int Priority { get; private set; }

	public float Time { get; private set; }

	public float OnePeriodTime { get; private set; }

	public bool Loop { get; private set; }

	public bool SimpleProgrammedCurve { get; private set; }

	public float FadeInTime { get; private set; }

	public float CommonTime { get; private set; }

	public float FadeOutTime { get; private set; }

	public float ProgrammedPowerMax { get; private set; }

	public bool InvertGSArtFresnel { get; private set; }

	public bool UseVertexNormalNotTex { get; private set; }

	public bool UseContrastInsteadPower { get; private set; }

	public float BrightValue { get; private set; }

	public float DarkValue { get; private set; }

	public UCurveFloat GSArtFresnelPower { get; private set; }

	public bool ClampGSArtFresnelDotProduct { get; private set; }

	public bool UseHeightGradientRamp { get; private set; }

	public float BottomAlpha { get; private set; }

	public float TopAlpha { get; private set; }

	public UCurveLinearColor FColor_Out { get; private set; }

	public UCurveLinearColor FColor_In { get; private set; }

	public DispLibCSharpData_ArtFresnel(int _Priority, float _Time, float _OnePeriodTime, bool _Loop, bool _SimpleProgrammedCurve, float _FadeInTime, float _CommonTime, float _FadeOutTime, bool _InvertGSArtFresnel, bool _UseVertexNormalNotTex, bool _UseContrastInsteadPower, float _BrightValue, float _DarkValue, UCurveFloat _GSArtFresnelPower, bool _ClampGSArtFresnelDotProduct, bool _UseHeightGradientRamp, float _BottomAlpha, float _TopAlpha, UCurveLinearColor _FColor_Out, UCurveLinearColor _FColor_In)
	{
		Priority = _Priority;
		Time = _Time;
		OnePeriodTime = _OnePeriodTime;
		Loop = _Loop;
		SimpleProgrammedCurve = _SimpleProgrammedCurve;
		FadeInTime = _FadeInTime;
		CommonTime = _CommonTime;
		FadeOutTime = _FadeOutTime;
		InvertGSArtFresnel = _InvertGSArtFresnel;
		UseVertexNormalNotTex = _UseVertexNormalNotTex;
		UseContrastInsteadPower = _UseContrastInsteadPower;
		BrightValue = _BrightValue;
		DarkValue = _DarkValue;
		GSArtFresnelPower = _GSArtFresnelPower;
		ClampGSArtFresnelDotProduct = _ClampGSArtFresnelDotProduct;
		UseHeightGradientRamp = _UseHeightGradientRamp;
		BottomAlpha = _BottomAlpha;
		TopAlpha = _TopAlpha;
		FColor_Out = _FColor_Out;
		FColor_In = _FColor_In;
	}
}
