using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUPredefinedBezierCurveHepler")]
public class BGUPredefinedBezierCurveHepler : UActorComponent
{
	private List<FVector> BezierCtrlPointList;

	public void InitializeWithParam(FVector StartPoint, FVector EndPoint, float Height, FVector Up)
	{
		new List<FVector>();
		BezierCtrlPointList = new List<FVector>();
		FVector item = (StartPoint + EndPoint) * 0.5 + 2f * Height * Up;
		BezierCtrlPointList.Add(StartPoint);
		BezierCtrlPointList.Add(item);
		BezierCtrlPointList.Add(EndPoint);
	}

	public FVector CalculateDesiredLocationAtTime(float TimeSpan, float AccumulatedTime, float SpdScale)
	{
		float x = AccumulatedTime / TimeSpan * SpdScale;
		x = MathLib.Clamp(x, 0f, 1f);
		if (AccumulatedTime == 0f)
		{
			return BezierCtrlPointList[0];
		}
		if (AccumulatedTime == 1f)
		{
			return BezierCtrlPointList[BezierCtrlPointList.Count - 1];
		}
		return CalculateBezierPoint(x, BezierCtrlPointList[0], BezierCtrlPointList[1], BezierCtrlPointList[2]);
	}

	public FVector CalculateDesiredForwardDirectionAtTime(float TimeSpan, float AccumulatedTime, float SpdScale)
	{
		float x = AccumulatedTime / TimeSpan * SpdScale;
		x = MathLib.Clamp(x, 0f, 1f);
		return CalculateBezierTagent(x, BezierCtrlPointList[0], BezierCtrlPointList[1], BezierCtrlPointList[2]);
	}

	private FVector CalculateBezierTagent(float t, FVector p0, FVector p1, FVector p2)
	{
		FVector result = -2.0 * p0 + 2f * t * p0;
		result += 2.0 * p1 - 4.0 * p1 * t;
		result += 2f * t * p2;
		result.Normalize();
		return result;
	}

	private FVector CalculateBezierPoint(float t, FVector p0, FVector p1, FVector p2)
	{
		float num = 1f - t;
		float num2 = t * t;
		return num * num * p0 + 2f * num * t * p1 + num2 * p2;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUPredefinedBezierCurveHepler");
	}

	static BGUPredefinedBezierCurveHepler()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUPredefinedBezierCurveHepler)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUPredefinedBezierCurveHepler));
	}
}
