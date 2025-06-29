using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public static class GSEaseFuncInUE
{
	private static double HALF_PI = Math.PI / 2.0;

	private static float Lerp(float A, float B, float Alpha)
	{
		return A + Alpha * (B - A);
	}

	private static FVector Lerp(FVector A, FVector B, float Alpha)
	{
		return A + Alpha * (B - A);
	}

	private static float InterpStep(float A, float B, float Alpha, int Steps)
	{
		if (Steps <= 1 || Alpha <= 0f)
		{
			return A;
		}
		if (Alpha >= 1f)
		{
			return B;
		}
		float num = Steps;
		float num2 = num - 1f;
		float alpha = (float)Math.Floor(Alpha * num / num2);
		return Lerp(A, B, alpha);
	}

	private static float InterpSinIn(float A, float B, float Alpha)
	{
		float alpha = -1f * (float)Math.Cos((double)Alpha * HALF_PI) + 1f;
		return Lerp(A, B, alpha);
	}

	private static float InterpSinOut(float A, float B, float Alpha)
	{
		float alpha = (float)Math.Sin((double)Alpha * HALF_PI);
		return Lerp(A, B, alpha);
	}

	private static float InterpSinInOut(float A, float B, float Alpha)
	{
		return Lerp(A, B, (Alpha < 0.5f) ? (InterpSinIn(0f, 1f, Alpha * 2f) * 0.5f) : (InterpSinOut(0f, 1f, Alpha * 2f - 1f) * 0.5f + 0.5f));
	}

	private static float InterpEaseIn(float A, float B, float Alpha, float Exp)
	{
		float alpha = (float)Math.Pow(Alpha, Exp);
		return Lerp(A, B, alpha);
	}

	private static float InterpEaseOut(float A, float B, float Alpha, float Exp)
	{
		float alpha = 1f - (float)Math.Pow(1f - Alpha, Exp);
		return Lerp(A, B, alpha);
	}

	private static float InterpEaseInOut(float A, float B, float Alpha, float Exp)
	{
		return Lerp(A, B, (Alpha < 0.5f) ? (InterpEaseIn(0f, 1f, Alpha * 2f, Exp) * 0.5f) : (InterpEaseOut(0f, 1f, Alpha * 2f - 1f, Exp) * 0.5f + 0.5f));
	}

	private static float InterpExpoIn(float A, float B, float Alpha)
	{
		float alpha = ((Alpha == 0f) ? 0f : ((float)Math.Pow(2.0, 10f * (Alpha - 1f))));
		return Lerp(A, B, alpha);
	}

	private static float InterpExpoOut(float A, float B, float Alpha)
	{
		float alpha = ((Alpha == 1f) ? 1f : (0f - (float)Math.Pow(2.0, -10f * Alpha) + 1f));
		return Lerp(A, B, alpha);
	}

	private static float InterpExpoInOut(float A, float B, float Alpha)
	{
		return Lerp(A, B, (Alpha < 0.5f) ? (InterpExpoIn(0f, 1f, Alpha * 2f) * 0.5f) : (InterpExpoOut(0f, 1f, Alpha * 2f - 1f) * 0.5f + 0.5f));
	}

	private static float InterpCircularIn(float A, float B, float Alpha)
	{
		float alpha = -1f * ((float)Math.Sqrt(1f - Alpha * Alpha) - 1f);
		return Lerp(A, B, alpha);
	}

	private static float InterpCircularOut(float A, float B, float Alpha)
	{
		Alpha -= 1f;
		float alpha = (float)Math.Sqrt(1f - Alpha * Alpha);
		return Lerp(A, B, alpha);
	}

	private static float InterpCircularInOut(float A, float B, float Alpha)
	{
		return Lerp(A, B, (Alpha < 0.5f) ? (InterpCircularIn(0f, 1f, Alpha * 2f) * 0.5f) : (InterpCircularOut(0f, 1f, Alpha * 2f - 1f) * 0.5f + 0.5f));
	}

	private static float EaseAlpha(float InAlpha, EEasingFunc EasingFunc, float BlendExp, int Steps)
	{
		return EasingFunc switch
		{
			EEasingFunc.Step => InterpStep(0f, 1f, InAlpha, Steps), 
			EEasingFunc.SinusoidalIn => InterpSinIn(0f, 1f, InAlpha), 
			EEasingFunc.SinusoidalOut => InterpSinOut(0f, 1f, InAlpha), 
			EEasingFunc.SinusoidalInOut => InterpSinInOut(0f, 1f, InAlpha), 
			EEasingFunc.EaseIn => InterpEaseIn(0f, 1f, InAlpha, BlendExp), 
			EEasingFunc.EaseOut => InterpEaseOut(0f, 1f, InAlpha, BlendExp), 
			EEasingFunc.EaseInOut => InterpEaseInOut(0f, 1f, InAlpha, BlendExp), 
			EEasingFunc.ExpoIn => InterpExpoIn(0f, 1f, InAlpha), 
			EEasingFunc.ExpoOut => InterpExpoOut(0f, 1f, InAlpha), 
			EEasingFunc.ExpoInOut => InterpExpoInOut(0f, 1f, InAlpha), 
			EEasingFunc.CircularIn => InterpCircularIn(0f, 1f, InAlpha), 
			EEasingFunc.CircularOut => InterpCircularOut(0f, 1f, InAlpha), 
			EEasingFunc.CircularInOut => InterpCircularInOut(0f, 1f, InAlpha), 
			_ => InAlpha, 
		};
	}

	private static float Ease(float A, float B, float Alpha, EEasingFunc EasingFunc, float BlendExp, int Steps)
	{
		return Lerp(A, B, EaseAlpha(Alpha, EasingFunc, BlendExp, Steps));
	}

	public static float GSMathEase(float Start, float End, float Alpha, EEasingFunc EasingFuncType, float BlendExp = 2f, int Steps = 2)
	{
		return Ease(Start, End, Alpha, EasingFuncType, BlendExp, Steps);
	}

	private static FVector Ease(FVector A, FVector B, float Alpha, EEasingFunc EasingFunc, float BlendExp, int Steps)
	{
		return Lerp(A, B, EaseAlpha(Alpha, EasingFunc, BlendExp, Steps));
	}

	public static FVector GSMathEase(FVector Start, FVector End, float Alpha, EEasingFunc EasingFuncType, float BlendExp = 2f, int Steps = 2)
	{
		return Ease(Start, End, Alpha, EasingFuncType, BlendExp, Steps);
	}
}
