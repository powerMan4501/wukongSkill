using System;
using System.Globalization;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public static class FMath
{
	private struct SegmentDistToSegment_Solver
	{
		public bool LinesAreNearlyParallel;

		public FVector A1;

		public FVector A2;

		public FVector S1;

		public FVector S2;

		public FVector S3;

		public SegmentDistToSegment_Solver(ref FVector a1, ref FVector b1, ref FVector a2, ref FVector b2)
		{
			LinesAreNearlyParallel = false;
			A1 = a1;
			A2 = a2;
			S1 = b1 - a1;
			S2 = b2 - a2;
			S3 = a1 - a2;
		}

		public void Solve(out FVector outP1, out FVector outP2)
		{
			double num = S1 | S1;
			double num2 = S1 | S2;
			double num3 = S1 | S3;
			double num4 = S2 | S2;
			double num5 = S2 | S3;
			double num6 = num * num4 - num2 * num2;
			double num7 = num6;
			double num8 = num6;
			double num9;
			double num10;
			if (LinesAreNearlyParallel || num6 < 9.999999747378752E-05)
			{
				num9 = 0.0;
				num7 = 1.0;
				num10 = num5;
				num8 = num4;
			}
			else
			{
				num9 = num2 * num5 - num4 * num3;
				num10 = num * num5 - num2 * num3;
				if (num9 < 0.0)
				{
					num9 = 0.0;
					num10 = num5;
					num8 = num4;
				}
				else if (num9 > num7)
				{
					num9 = num7;
					num10 = num5 + num2;
					num8 = num4;
				}
			}
			if (num10 < 0.0)
			{
				num10 = 0.0;
				if (0.0 - num3 < 0.0)
				{
					num9 = 0.0;
				}
				else if (0.0 - num3 > num)
				{
					num9 = num7;
				}
				else
				{
					num9 = 0.0 - num3;
					num7 = num;
				}
			}
			else if (num10 > num8)
			{
				num10 = num8;
				if (0.0 - num3 + num2 < 0.0)
				{
					num9 = 0.0;
				}
				else if (0.0 - num3 + num2 > num)
				{
					num9 = num7;
				}
				else
				{
					num9 = 0.0 - num3 + num2;
					num7 = num;
				}
			}
			double num11 = ((Abs(num9) < 9.999999747378752E-05) ? 0.0 : (num9 / num7));
			double num12 = ((Abs(num10) < 9.999999747378752E-05) ? 0.0 : (num10 / num8));
			outP1 = A1 + num11 * S1;
			outP2 = A2 + num12 * S2;
		}
	}

	public const string LogUnrealMath = "LogUnrealMath";

	public static readonly float LogToLog2 = 1f / Loge(2f);

	public const float PI = (float)Math.PI;

	public const float SmallNumber = 1E-08f;

	public const float KindaSmallNumber = 0.0001f;

	public const float BigNumber = 3.4E+38f;

	public const float EulersNumber = (float)Math.E;

	public const float MaxFloat = float.MaxValue;

	public const float InvPI = 1f / (float)Math.PI;

	public const float HalfPI = (float)Math.PI / 2f;

	public const float Delta = 1E-05f;

	public const float FLOAT_NORMAL_THRESH = 0.0001f;

	public const float THRESH_POINT_ON_PLANE = 0.1f;

	public const float THRESH_POINT_ON_SIDE = 0.2f;

	public const float THRESH_POINTS_ARE_SAME = 2E-05f;

	public const float THRESH_POINTS_ARE_NEAR = 0.015f;

	public const float THRESH_NORMALS_ARE_SAME = 2E-05f;

	public const float THRESH_UVS_ARE_SAME = 0.0009765625f;

	public const float THRESH_VECTORS_ARE_NEAR = 0.0004f;

	public const float THRESH_SPLIT_POLY_WITH_PLANE = 0.25f;

	public const float THRESH_SPLIT_POLY_PRECISELY = 0.01f;

	public const float THRESH_ZERO_NORM_SQUARED = 0.0001f;

	public const float THRESH_NORMALS_ARE_PARALLEL = 0.999845f;

	public const float THRESH_NORMALS_ARE_ORTHOGONAL = 0.017455f;

	public const float THRESH_VECTOR_NORMALIZED = 0.01f;

	public const float THRESH_QUAT_NORMALIZED = 0.01f;

	public static readonly uint[] BitFlag = new uint[32]
	{
		1u, 2u, 4u, 8u, 16u, 32u, 64u, 128u, 256u, 512u,
		1024u, 2048u, 4096u, 8192u, 16384u, 32768u, 65536u, 131072u, 262144u, 524288u,
		1048576u, 2097152u, 4194304u, 8388608u, 16777216u, 33554432u, 67108864u, 134217728u, 268435456u, 536870912u,
		1073741824u, 2147483648u
	};

	public static float ClampFloatTangent(float prevPointVal, float prevTime, float curPointVal, float curTime, float nextPointVal, float nextTime)
	{
		float num = Max(0.0001f, nextTime - prevTime);
		float num2 = Max(0.0001f, curTime - prevTime);
		float num3 = Max(0.0001f, nextTime - curTime);
		float num4 = 0f;
		float num5 = nextPointVal - prevPointVal;
		float num6 = curPointVal - prevPointVal;
		float num7 = nextPointVal - curPointVal;
		if ((num6 >= 0f && num7 <= 0f) || (num6 <= 0f && num7 >= 0f))
		{
			return 0f;
		}
		float b = num7 / num3;
		float b2 = num6 / num2;
		float num8 = num5 / num;
		float num9 = num8;
		float num10 = num6 / num5;
		if (num5 > 0f)
		{
			if (num10 < 0.333f)
			{
				float alpha = 1f - num10 / 0.333f;
				float val = Lerp(num8, b2, alpha);
				num9 = Min(num9, val);
			}
			if (num10 > 0.667f)
			{
				float alpha2 = (num10 - 0.667f) / 0.333f;
				float val2 = Lerp(num8, b, alpha2);
				num9 = Min(num9, val2);
			}
		}
		else
		{
			if (num10 < 0.333f)
			{
				float alpha3 = 1f - num10 / 0.333f;
				float val3 = Lerp(num8, b2, alpha3);
				num9 = Max(num9, val3);
			}
			if (num10 > 0.667f)
			{
				float alpha4 = (num10 - 0.667f) / 0.333f;
				float val4 = Lerp(num8, b, alpha4);
				num9 = Max(num9, val4);
			}
		}
		return num9;
	}

	public static void AutoCalcTangent(float prevP, float p, float nextP, float tension, out float outTan)
	{
		outTan = (1f - tension) * (p - prevP + (nextP - p));
	}

	public static void AutoCalcTangent(FVector prevP, FVector p, FVector nextP, float tension, out FVector outTan)
	{
		outTan = (1f - tension) * (p - prevP + (nextP - p));
	}

	public static void AutoCalcTangent(FVector2D prevP, FVector2D p, FVector2D nextP, float tension, out FVector2D outTan)
	{
		outTan = (1f - tension) * (p - prevP + (nextP - p));
	}

	public static void AutoCalcTangent(FTwoVectors prevP, FTwoVectors p, FTwoVectors nextP, float tension, out FTwoVectors outTan)
	{
		outTan = (1f - tension) * (p - prevP + (nextP - p));
	}

	public static void AutoCalcTangent(FQuat prevP, FQuat p, FQuat nextP, float tension, out FQuat outTan)
	{
		FQuat.CalcTangents(prevP, p, nextP, tension, out outTan);
	}

	private unsafe static void ComputeClampableFloatVectorCurveTangentClamped(float prevTime, float* prevPoint, float curTime, float* curPoint, float nextTime, float* nextPoint, float tension, int typeSize, float* outTangent)
	{
		float* ptr = prevPoint;
		float* ptr2 = curPoint;
		float* ptr3 = nextPoint;
		float* ptr4 = outTangent;
		for (int i = 0; i < typeSize; i += 4)
		{
			float num = ClampFloatTangent(*ptr, prevTime, *ptr2, curTime, *ptr3, nextTime);
			*ptr4 = (1f - tension) * num;
			ptr4++;
			ptr++;
			ptr2++;
			ptr3++;
		}
	}

	public unsafe static void ComputeCurveTangent(float prevTime, float prevPoint, float curTime, float curPoint, float nextTime, float nextPoint, float tension, bool wantClamping, out float outTangent)
	{
		if (wantClamping)
		{
			float num = default(float);
			ComputeClampableFloatVectorCurveTangentClamped(prevTime, &prevPoint, curTime, &curPoint, nextTime, &nextPoint, tension, 4, &num);
			outTangent = num;
		}
		else
		{
			AutoCalcTangent(prevPoint, curPoint, nextPoint, tension, out outTangent);
			float num2 = Max(0.0001f, nextTime - prevTime);
			outTangent /= num2;
		}
	}

	public unsafe static void ComputeCurveTangent(float prevTime, FVector prevPoint, float curTime, FVector curPoint, float nextTime, FVector nextPoint, float tension, bool wantClamping, out FVector outTangent)
	{
		if (wantClamping)
		{
			FVector fVector = default(FVector);
			ComputeClampableFloatVectorCurveTangentClamped(prevTime, (float*)(&prevPoint), curTime, (float*)(&curPoint), nextTime, (float*)(&nextPoint), tension, sizeof(FVector), (float*)(&fVector));
			outTangent = fVector;
		}
		else
		{
			AutoCalcTangent(prevPoint, curPoint, nextPoint, tension, out outTangent);
			float num = Max(0.0001f, nextTime - prevTime);
			outTangent /= (double)num;
		}
	}

	public unsafe static void ComputeCurveTangent(float prevTime, FVector2D prevPoint, float curTime, FVector2D curPoint, float nextTime, FVector2D nextPoint, float tension, bool wantClamping, out FVector2D outTangent)
	{
		if (wantClamping)
		{
			FVector2D fVector2D = default(FVector2D);
			ComputeClampableFloatVectorCurveTangentClamped(prevTime, (float*)(&prevPoint), curTime, (float*)(&curPoint), nextTime, (float*)(&nextPoint), tension, sizeof(FVector2D), (float*)(&fVector2D));
			outTangent = fVector2D;
		}
		else
		{
			AutoCalcTangent(prevPoint, curPoint, nextPoint, tension, out outTangent);
			float num = Max(0.0001f, nextTime - prevTime);
			outTangent /= (double)num;
		}
	}

	public unsafe static void ComputeCurveTangent(float prevTime, FTwoVectors prevPoint, float curTime, FTwoVectors curPoint, float nextTime, FTwoVectors nextPoint, float tension, bool wantClamping, out FTwoVectors outTangent)
	{
		if (wantClamping)
		{
			FTwoVectors fTwoVectors = default(FTwoVectors);
			ComputeClampableFloatVectorCurveTangentClamped(prevTime, (float*)(&prevPoint), curTime, (float*)(&curPoint), nextTime, (float*)(&nextPoint), tension, sizeof(FTwoVectors), (float*)(&fTwoVectors));
			outTangent = fTwoVectors;
		}
		else
		{
			AutoCalcTangent(prevPoint, curPoint, nextPoint, tension, out outTangent);
			float num = Max(0.0001f, nextTime - prevTime);
			outTangent /= (double)num;
		}
	}

	private static void FindBounds(out float outMin, out float outMax, float start, float startLeaveTan, float startT, float end, float endArriveTan, float endT, bool curve)
	{
		outMin = Min(start, end);
		outMax = Max(start, end);
		if (!curve)
		{
			return;
		}
		float num = endT - startT;
		startLeaveTan *= num;
		endArriveTan *= num;
		float num2 = 6f * start + 3f * startLeaveTan + 3f * endArriveTan - 6f * end;
		float num3 = -6f * start - 4f * startLeaveTan - 2f * endArriveTan + 6f * end;
		float num4 = startLeaveTan;
		float num5 = num3 * num3 - 4f * num2 * num4;
		if (num5 > 0f && !IsNearlyZero(num2))
		{
			float num6 = Sqrt(num5);
			float num7 = (0f - num3 + num6) / (2f * num2);
			float num8 = startT + num7 * (endT - startT);
			if (num8 > startT && num8 < endT)
			{
				float val = CubicInterp(start, startLeaveTan, end, endArriveTan, num7);
				outMin = Min(outMin, val);
				outMax = Max(outMax, val);
			}
			float num9 = (0f - num3 - num6) / (2f * num2);
			float num10 = startT + num9 * (endT - startT);
			if (num10 > startT && num10 < endT)
			{
				float val2 = CubicInterp(start, startLeaveTan, end, endArriveTan, num9);
				outMin = Min(outMin, val2);
				outMax = Max(outMax, val2);
			}
		}
	}

	private static void FindBounds(out double outMin, out double outMax, double start, double startLeaveTan, double startT, double end, double endArriveTan, double endT, bool curve)
	{
		outMin = Min(start, end);
		outMax = Max(start, end);
		if (!curve)
		{
			return;
		}
		double num = endT - startT;
		startLeaveTan *= num;
		endArriveTan *= num;
		double num2 = 6.0 * start + 3.0 * startLeaveTan + 3.0 * endArriveTan - 6.0 * end;
		double num3 = -6.0 * start - 4.0 * startLeaveTan - 2.0 * endArriveTan + 6.0 * end;
		double num4 = startLeaveTan;
		double num5 = num3 * num3 - 4.0 * num2 * num4;
		if (num5 > 0.0 && !IsNearlyZero(num2))
		{
			double num6 = Sqrt(num5);
			double num7 = (0.0 - num3 + num6) / (2.0 * num2);
			double num8 = startT + num7 * (endT - startT);
			if (num8 > startT && num8 < endT)
			{
				double val = CubicInterp(start, startLeaveTan, end, endArriveTan, num7);
				outMin = Min(outMin, val);
				outMax = Max(outMax, val);
			}
			double num9 = (0.0 - num3 - num6) / (2.0 * num2);
			double num10 = startT + num9 * (endT - startT);
			if (num10 > startT && num10 < endT)
			{
				double val2 = CubicInterp(start, startLeaveTan, end, endArriveTan, num9);
				outMin = Min(outMin, val2);
				outMax = Max(outMax, val2);
			}
		}
	}

	public static void CurveFindIntervalBounds(FInterpCurvePointFloat start, FInterpCurvePointFloat end, ref float currentMin, ref float currentMax)
	{
		bool curve = start.IsCurveKey();
		FindBounds(out var outMin, out var outMax, start.OutVal, start.LeaveTangent, start.InVal, end.OutVal, end.ArriveTangent, end.InVal, curve);
		currentMin = Min(currentMin, outMin);
		currentMax = Max(currentMax, outMax);
	}

	public static void CurveFindIntervalBounds(FInterpCurvePointVector2D start, FInterpCurvePointVector2D end, ref FVector2D currentMin, ref FVector2D currentMax)
	{
		bool curve = start.IsCurveKey();
		FindBounds(out var outMin, out var outMax, start.OutVal.X, start.LeaveTangent.X, start.InVal, end.OutVal.X, end.ArriveTangent.X, end.InVal, curve);
		currentMin.X = Min(currentMin.X, outMin);
		currentMax.X = Max(currentMax.X, outMax);
		FindBounds(out outMin, out outMax, start.OutVal.Y, start.LeaveTangent.Y, start.InVal, end.OutVal.Y, end.ArriveTangent.Y, end.InVal, curve);
		currentMin.Y = Min(currentMin.Y, outMin);
		currentMax.Y = Max(currentMax.Y, outMax);
	}

	public static void CurveFindIntervalBounds(FInterpCurvePointVector start, FInterpCurvePointVector end, ref FVector currentMin, ref FVector currentMax)
	{
		bool curve = start.IsCurveKey();
		FindBounds(out var outMin, out var outMax, start.OutVal.X, start.LeaveTangent.X, start.InVal, end.OutVal.X, end.ArriveTangent.X, end.InVal, curve);
		currentMin.X = Min(currentMin.X, outMin);
		currentMax.X = Max(currentMax.X, outMax);
		FindBounds(out outMin, out outMax, start.OutVal.Y, start.LeaveTangent.Y, start.InVal, end.OutVal.Y, end.ArriveTangent.Y, end.InVal, curve);
		currentMin.Y = Min(currentMin.Y, outMin);
		currentMax.Y = Max(currentMax.Y, outMax);
		FindBounds(out outMin, out outMax, start.OutVal.Z, start.LeaveTangent.Z, start.InVal, end.OutVal.Z, end.ArriveTangent.Z, end.InVal, curve);
		currentMin.Z = Min(currentMin.Z, outMin);
		currentMax.Z = Max(currentMax.Z, outMax);
	}

	public static void CurveFindIntervalBounds(FInterpCurvePointTwoVectors start, FInterpCurvePointTwoVectors end, ref FTwoVectors currentMin, ref FTwoVectors currentMax)
	{
		bool curve = start.IsCurveKey();
		FindBounds(out var outMin, out var outMax, start.OutVal.V1.X, start.LeaveTangent.V1.X, start.InVal, end.OutVal.V1.X, end.ArriveTangent.V1.X, end.InVal, curve);
		currentMin.V1.X = Min(currentMin.V1.X, outMin);
		currentMax.V1.X = Max(currentMax.V1.X, outMax);
		FindBounds(out outMin, out outMax, start.OutVal.V1.Y, start.LeaveTangent.V1.Y, start.InVal, end.OutVal.V1.Y, end.ArriveTangent.V1.Y, end.InVal, curve);
		currentMin.V1.Y = Min(currentMin.V1.Y, outMin);
		currentMax.V1.Y = Max(currentMax.V1.Y, outMax);
		FindBounds(out outMin, out outMax, start.OutVal.V1.Z, start.LeaveTangent.V1.Z, start.InVal, end.OutVal.V1.Z, end.ArriveTangent.V1.Z, end.InVal, curve);
		currentMin.V1.Z = Min(currentMin.V1.Z, outMin);
		currentMax.V1.Z = Max(currentMax.V1.Z, outMax);
		FindBounds(out outMin, out outMax, start.OutVal.V2.X, start.LeaveTangent.V2.X, start.InVal, end.OutVal.V2.X, end.ArriveTangent.V2.X, end.InVal, curve);
		currentMin.V2.X = Min(currentMin.V2.X, outMin);
		currentMax.V2.X = Max(currentMax.V2.X, outMax);
		FindBounds(out outMin, out outMax, start.OutVal.V2.Y, start.LeaveTangent.V2.Y, start.InVal, end.OutVal.V2.Y, end.ArriveTangent.V2.Y, end.InVal, curve);
		currentMin.V2.Y = Min(currentMin.V2.Y, outMin);
		currentMax.V2.Y = Max(currentMax.V2.Y, outMax);
		FindBounds(out outMin, out outMax, start.OutVal.V2.Z, start.LeaveTangent.V2.Z, start.InVal, end.OutVal.V2.Z, end.ArriveTangent.V2.Z, end.InVal, curve);
		currentMin.V2.Z = Min(currentMin.V2.Z, outMin);
		currentMax.V2.Z = Max(currentMax.V2.Z, outMax);
	}

	public static void CurveFindIntervalBounds(FInterpCurvePointLinearColor start, FInterpCurvePointLinearColor end, ref FLinearColor currentMin, ref FLinearColor currentMax)
	{
		bool curve = start.IsCurveKey();
		FindBounds(out var outMin, out var outMax, start.OutVal.R, start.LeaveTangent.R, start.InVal, end.OutVal.R, end.ArriveTangent.R, end.InVal, curve);
		currentMin.R = Min(currentMin.R, outMin);
		currentMax.R = Max(currentMax.R, outMax);
		FindBounds(out outMin, out outMax, start.OutVal.G, start.LeaveTangent.G, start.InVal, end.OutVal.G, end.ArriveTangent.G, end.InVal, curve);
		currentMin.G = Min(currentMin.G, outMin);
		currentMax.G = Max(currentMax.G, outMax);
		FindBounds(out outMin, out outMax, start.OutVal.B, start.LeaveTangent.B, start.InVal, end.OutVal.B, end.ArriveTangent.B, end.InVal, curve);
		currentMin.B = Min(currentMin.B, outMin);
		currentMax.B = Max(currentMax.B, outMax);
		FindBounds(out outMin, out outMax, start.OutVal.A, start.LeaveTangent.A, start.InVal, end.OutVal.A, end.ArriveTangent.A, end.InVal, curve);
		currentMin.A = Min(currentMin.A, outMin);
		currentMax.A = Max(currentMax.A, outMax);
	}

	public static double lpexp(double x, int exp)
	{
		return x * Math.Pow(2.0, exp);
	}

	public static double frexp(double x, out int exp)
	{
		exp = (int)Math.Floor(Math.Log(x) / Math.Log(2.0)) + 1;
		return 1.0 - (Math.Pow(2.0, exp) - x) / Math.Pow(2.0, exp);
	}

	public static int TruncToInt(float f)
	{
		return (int)f;
	}

	public static int TruncToInt(double d)
	{
		return (int)d;
	}

	public static float TruncToFloat(float f)
	{
		return TruncToInt(f);
	}

	public static int FloorToInt(float f)
	{
		return (int)Math.Floor(f);
	}

	public static int FloorToInt(double d)
	{
		return (int)Math.Floor(d);
	}

	public static float FloorToFloat(float f)
	{
		return (float)Math.Floor(f);
	}

	public static double FloorToDouble(double f)
	{
		return Math.Floor(f);
	}

	public static int RoundToInt(float f)
	{
		return (int)Math.Round(f);
	}

	public static int RoundToInt(double d)
	{
		return (int)Math.Round(d);
	}

	public static float RoundToFloat(float f)
	{
		return (float)Math.Round(f);
	}

	public static double RoundToDouble(double f)
	{
		return Math.Round(f);
	}

	public static int CeilToInt(float f)
	{
		return (int)Math.Ceiling(f);
	}

	public static int CeilToInt(double d)
	{
		return (int)Math.Ceiling(d);
	}

	public static float CeilToFloat(float f)
	{
		return (float)Math.Ceiling(f);
	}

	public static double CeilToDouble(double f)
	{
		return Math.Ceiling(f);
	}

	public static float Fractional(float value)
	{
		return value - TruncToFloat(value);
	}

	public static float Frac(float value)
	{
		return value - FloorToFloat(value);
	}

	public static float Modf(float value, out float intPart)
	{
		intPart = (float)Math.Truncate(value);
		return value - intPart;
	}

	public static double Modf(double value, out double intPart)
	{
		intPart = Math.Truncate(value);
		return value - intPart;
	}

	public static float Exp(float value)
	{
		return (float)Math.Exp(value);
	}

	public static float Exp2(float value)
	{
		return (float)Math.Pow(2.0, value);
	}

	public static float Loge(float value)
	{
		return (float)Math.Log(value);
	}

	public static float LogX(float baseValue, float value)
	{
		return (float)(Math.Log(value) / Math.Log(baseValue));
	}

	public static float Log2(float value)
	{
		return (float)Math.Log(value) * 1.442695f;
	}

	public static float Fmod(float x, float y)
	{
		return x % y;
	}

	public static double Dmod(double x, double y)
	{
		return x % y;
	}

	public static float Sin(float value)
	{
		return (float)Math.Sin(value);
	}

	public static double Sin(double value)
	{
		return Math.Sin(value);
	}

	public static float Asin(float value)
	{
		return (float)Math.Asin((value < -1f) ? (-1f) : ((value < 1f) ? value : 1f));
	}

	public static float Sinh(float value)
	{
		return (float)Math.Sinh(value);
	}

	public static float Cos(float value)
	{
		return (float)Math.Cos(value);
	}

	public static double Cos(double value)
	{
		return Math.Cos(value);
	}

	public static float Acos(float value)
	{
		return (float)Math.Acos((value < -1f) ? (-1f) : ((value < 1f) ? value : 1f));
	}

	public static double Acos(double value)
	{
		return Math.Acos((value < -1.0) ? (-1.0) : ((value < 1.0) ? value : 1.0));
	}

	public static float Tan(float value)
	{
		return (float)Math.Tan(value);
	}

	public static double Tan(double value)
	{
		return Math.Tan(value);
	}

	public static float Atan(float value)
	{
		return (float)Math.Atan(value);
	}

	public static float Atan2(float y, float x)
	{
		return (float)Math.Atan2(y, x);
	}

	public static double Atan2(double y, double x)
	{
		return Math.Atan2(y, x);
	}

	public static float Sqrt(float value)
	{
		return (float)Math.Sqrt(value);
	}

	public static double Sqrt(double value)
	{
		return Math.Sqrt(value);
	}

	public static float Pow(float a, float b)
	{
		return (float)Math.Pow(a, b);
	}

	public static double Pow(double a, double b)
	{
		return Math.Pow(a, b);
	}

	public static float InvSqrt(float value)
	{
		return 1f / (float)Math.Sqrt(value);
	}

	public static double InvSqrt(double value)
	{
		return 1.0 / Math.Sqrt(value);
	}

	public unsafe static float InvSqrtEst(float value)
	{
		float num = 0.5f * value;
		int num2 = *(int*)(&value);
		num2 = 1597463174 - (num2 >> 1);
		value = *(float*)(&num2);
		value *= 1.5f - num * value * value;
		return value;
	}

	public unsafe static bool IsNaN(float value)
	{
		return (*(uint*)(&value) & 0x7FFFFFFF) > 2139095040;
	}

	public unsafe static bool IsNaN(double value)
	{
		return (*(uint*)(&value) & 0x7FFFFFFF) > 2139095040;
	}

	public unsafe static bool IsFinite(float value)
	{
		return (*(uint*)(&value) & 0x7F800000) != 2139095040;
	}

	public unsafe static bool IsFinite(double value)
	{
		return (*(uint*)(&value) & 0x7F800000) != 2139095040;
	}

	public unsafe static bool IsNegativeFloat(float value)
	{
		return *(uint*)(&value) >= 2147483648u;
	}

	public unsafe static bool IsNegativeDouble(double value)
	{
		return (ulong)(*(long*)(&value)) >= 9223372036854775808uL;
	}

	public static int Rand()
	{
		return Native_FMath.Rand();
	}

	public static void RandInit(int seed)
	{
		Native_FMath.RandInit(seed);
	}

	public static float FRand()
	{
		return Native_FMath.FRand();
	}

	public static double DRand()
	{
		return Native_FMath.FRand();
	}

	public static void SRandInit(int seed)
	{
		Native_FMath.SRandInit(seed);
	}

	public static int GetRandSeed()
	{
		return Native_FMath.GetRandSeed();
	}

	public static float SRand()
	{
		return Native_FMath.SRand();
	}

	public static uint FloorLog2(uint value)
	{
		uint num = 0u;
		if (value >= 65536)
		{
			value >>= 16;
			num += 16;
		}
		if (value >= 256)
		{
			value >>= 8;
			num += 8;
		}
		if (value >= 16)
		{
			value >>= 4;
			num += 4;
		}
		if (value >= 4)
		{
			value >>= 2;
			num += 2;
		}
		if (value >= 2)
		{
			num++;
		}
		if (value != 0)
		{
			return num;
		}
		return 0u;
	}

	public static ulong FloorLog2_64(ulong value)
	{
		ulong num = 0uL;
		if (value >= 4294967296L)
		{
			value >>= 32;
			num += 32;
		}
		if (value >= 65536)
		{
			value >>= 16;
			num += 16;
		}
		if (value >= 256)
		{
			value >>= 8;
			num += 8;
		}
		if (value >= 16)
		{
			value >>= 4;
			num += 4;
		}
		if (value >= 4)
		{
			value >>= 2;
			num += 2;
		}
		if (value >= 2)
		{
			num++;
		}
		if (value != 0L)
		{
			return num;
		}
		return 0uL;
	}

	public static uint CountLeadingZeros(uint value)
	{
		if (value == 0)
		{
			return 32u;
		}
		return 31 - FloorLog2(value);
	}

	public static ulong CountLeadingZeros64(ulong value)
	{
		if (value == 0L)
		{
			return 64uL;
		}
		return 63 - FloorLog2_64(value);
	}

	public static uint CountTrailingZeros(uint value)
	{
		if (value == 0)
		{
			return 32u;
		}
		uint num = 0u;
		while ((value & 1) == 0)
		{
			value >>= 1;
			num++;
		}
		return num;
	}

	public static uint CeilLogTwo(uint arg)
	{
		uint num = (uint)((int)(CountLeadingZeros(arg) << 26) >> 31);
		return (32 - CountLeadingZeros(arg - 1)) & ~num;
	}

	public static ulong CeilLogTwo64(ulong arg)
	{
		ulong num = (ulong)((long)(CountLeadingZeros64(arg) << 57) >> 63);
		return (64 - CountLeadingZeros64(arg - 1)) & ~num;
	}

	public static uint RoundUpToPowerOfTwo(uint arg)
	{
		return (uint)(1 << (int)CeilLogTwo(arg));
	}

	public static ulong RoundUpToPowerOfTwo64(ulong arg)
	{
		return (ulong)(1L << (int)CeilLogTwo64(arg));
	}

	public static uint MortonCode2(uint x)
	{
		x &= 0xFFFF;
		x = (x ^ (x << 8)) & 0xFF00FF;
		x = (x ^ (x << 4)) & 0xF0F0F0F;
		x = (x ^ (x << 2)) & 0x33333333;
		x = (x ^ (x << 1)) & 0x55555555;
		return x;
	}

	public static uint ReverseMortonCode2(uint x)
	{
		x &= 0x55555555;
		x = (x ^ (x >> 1)) & 0x33333333;
		x = (x ^ (x >> 2)) & 0xF0F0F0F;
		x = (x ^ (x >> 4)) & 0xFF00FF;
		x = (x ^ (x >> 8)) & 0xFFFF;
		return x;
	}

	public static uint MortonCode3(uint x)
	{
		x &= 0x3FF;
		x = (x ^ (x << 16)) & 0xFF0000FFu;
		x = (x ^ (x << 8)) & 0x300F00F;
		x = (x ^ (x << 4)) & 0x30C30C3;
		x = (x ^ (x << 2)) & 0x9249249;
		return x;
	}

	public static uint ReverseMortonCode3(uint x)
	{
		x &= 0x9249249;
		x = (x ^ (x >> 2)) & 0x30C30C3;
		x = (x ^ (x >> 4)) & 0x300F00F;
		x = (x ^ (x >> 8)) & 0xFF0000FFu;
		x = (x ^ (x >> 16)) & 0x3FF;
		return x;
	}

	public static float FloatSelect(float comparand, float valueGEZero, float valueLTZero)
	{
		if (!(comparand >= 0f))
		{
			return valueLTZero;
		}
		return valueGEZero;
	}

	public static double DoubleSelect(double comparand, double valueGEZero, double valueLTZero)
	{
		if (!(comparand >= 0.0))
		{
			return valueLTZero;
		}
		return valueGEZero;
	}

	public static int CountBits(ulong bits)
	{
		bits -= (bits >> 1) & 0x5555555555555555L;
		bits = (bits & 0x3333333333333333L) + ((bits >> 2) & 0x3333333333333333L);
		bits = (bits + (bits >> 4)) & 0xF0F0F0F0F0F0F0FL;
		return (int)(bits * 72340172838076673L >> 56);
	}

	public static sbyte Abs(sbyte value)
	{
		return Math.Abs(value);
	}

	public static short Abs(short value)
	{
		return Math.Abs(value);
	}

	public static int Abs(int value)
	{
		return Math.Abs(value);
	}

	public static long Abs(long value)
	{
		return Math.Abs(value);
	}

	public static float Abs(float value)
	{
		return Math.Abs(value);
	}

	public static double Abs(double value)
	{
		return Math.Abs(value);
	}

	public static decimal Abs(decimal value)
	{
		return Math.Abs(value);
	}

	public static int Sign(sbyte value)
	{
		return Math.Sign(value);
	}

	public static int Sign(short value)
	{
		return Math.Sign(value);
	}

	public static int Sign(int value)
	{
		return Math.Sign(value);
	}

	public static int Sign(long value)
	{
		return Math.Sign(value);
	}

	public static int Sign(float value)
	{
		return Math.Sign(value);
	}

	public static int Sign(double value)
	{
		return Math.Sign(value);
	}

	public static int Sign(decimal value)
	{
		return Math.Sign(value);
	}

	public static sbyte Max(sbyte val1, sbyte val2)
	{
		return Math.Max(val1, val2);
	}

	public static byte Max(byte val1, byte val2)
	{
		return Math.Max(val1, val2);
	}

	public static short Max(short val1, short val2)
	{
		return Math.Max(val1, val2);
	}

	public static ushort Max(ushort val1, ushort val2)
	{
		return Math.Max(val1, val2);
	}

	public static int Max(int val1, int val2)
	{
		return Math.Max(val1, val2);
	}

	public static uint Max(uint val1, uint val2)
	{
		return Math.Max(val1, val2);
	}

	public static long Max(long val1, long val2)
	{
		return Math.Max(val1, val2);
	}

	public static ulong Max(ulong val1, ulong val2)
	{
		return Math.Max(val1, val2);
	}

	public static float Max(float val1, float val2)
	{
		return Math.Max(val1, val2);
	}

	public static double Max(double val1, double val2)
	{
		return Math.Max(val1, val2);
	}

	public static decimal Max(decimal val1, decimal val2)
	{
		return Math.Max(val1, val2);
	}

	public static sbyte Min(sbyte val1, sbyte val2)
	{
		return Math.Min(val1, val2);
	}

	public static byte Min(byte val1, byte val2)
	{
		return Math.Min(val1, val2);
	}

	public static short Min(short val1, short val2)
	{
		return Math.Min(val1, val2);
	}

	public static ushort Min(ushort val1, ushort val2)
	{
		return Math.Min(val1, val2);
	}

	public static int Min(int val1, int val2)
	{
		return Math.Min(val1, val2);
	}

	public static long Min(long val1, long val2)
	{
		return Math.Min(val1, val2);
	}

	public static ulong Min(ulong val1, ulong val2)
	{
		return Math.Min(val1, val2);
	}

	public static float Min(float val1, float val2)
	{
		return Math.Min(val1, val2);
	}

	public static double Min(double val1, double val2)
	{
		return Math.Min(val1, val2);
	}

	public static decimal Min(decimal val1, decimal val2)
	{
		return Math.Min(val1, val2);
	}

	public static sbyte Min(params sbyte[] values)
	{
		int minIndex;
		return Min(values, out minIndex);
	}

	public static sbyte Min(sbyte[] values, out int minIndex)
	{
		minIndex = 0;
		int num = values.Length;
		if (num == 0)
		{
			return 0;
		}
		sbyte b = values[0];
		for (int i = 1; i < num; i++)
		{
			sbyte b2 = values[i];
			if (b2 < b)
			{
				b = b2;
				minIndex = i;
			}
		}
		return b;
	}

	public static byte Min(params byte[] values)
	{
		int minIndex;
		return Min(values, out minIndex);
	}

	public static byte Min(byte[] values, out int minIndex)
	{
		minIndex = 0;
		int num = values.Length;
		if (num == 0)
		{
			return 0;
		}
		byte b = values[0];
		for (int i = 1; i < num; i++)
		{
			byte b2 = values[i];
			if (b2 < b)
			{
				b = b2;
				minIndex = i;
			}
		}
		return b;
	}

	public static short Min(params short[] values)
	{
		int minIndex;
		return Min(values, out minIndex);
	}

	public static short Min(short[] values, out int minIndex)
	{
		minIndex = 0;
		int num = values.Length;
		if (num == 0)
		{
			return 0;
		}
		short num2 = values[0];
		for (int i = 1; i < num; i++)
		{
			short num3 = values[i];
			if (num3 < num2)
			{
				num2 = num3;
				minIndex = i;
			}
		}
		return num2;
	}

	public static ushort Min(params ushort[] values)
	{
		int minIndex;
		return Min(values, out minIndex);
	}

	public static ushort Min(ushort[] values, out int minIndex)
	{
		minIndex = 0;
		int num = values.Length;
		if (num == 0)
		{
			return 0;
		}
		ushort num2 = values[0];
		for (int i = 1; i < num; i++)
		{
			ushort num3 = values[i];
			if (num3 < num2)
			{
				num2 = num3;
				minIndex = i;
			}
		}
		return num2;
	}

	public static int Min(params int[] values)
	{
		int minIndex;
		return Min(values, out minIndex);
	}

	public static int Min(int[] values, out int minIndex)
	{
		minIndex = 0;
		int num = values.Length;
		if (num == 0)
		{
			return 0;
		}
		int num2 = values[0];
		for (int i = 1; i < num; i++)
		{
			int num3 = values[i];
			if (num3 < num2)
			{
				num2 = num3;
				minIndex = i;
			}
		}
		return num2;
	}

	public static uint Min(params uint[] values)
	{
		int minIndex;
		return Min(values, out minIndex);
	}

	public static uint Min(uint[] values, out int minIndex)
	{
		minIndex = 0;
		int num = values.Length;
		if (num == 0)
		{
			return 0u;
		}
		uint num2 = values[0];
		for (int i = 1; i < num; i++)
		{
			uint num3 = values[i];
			if (num3 < num2)
			{
				num2 = num3;
				minIndex = i;
			}
		}
		return num2;
	}

	public static long Min(params long[] values)
	{
		int minIndex;
		return Min(values, out minIndex);
	}

	public static long Min(long[] values, out int minIndex)
	{
		minIndex = 0;
		int num = values.Length;
		if (num == 0)
		{
			return 0L;
		}
		long num2 = values[0];
		for (int i = 1; i < num; i++)
		{
			long num3 = values[i];
			if (num3 < num2)
			{
				num2 = num3;
				minIndex = i;
			}
		}
		return num2;
	}

	public static ulong Min(params ulong[] values)
	{
		int minIndex;
		return Min(values, out minIndex);
	}

	public static ulong Min(ulong[] values, out int minIndex)
	{
		minIndex = 0;
		int num = values.Length;
		if (num == 0)
		{
			return 0uL;
		}
		ulong num2 = values[0];
		for (int i = 1; i < num; i++)
		{
			ulong num3 = values[i];
			if (num3 < num2)
			{
				num2 = num3;
				minIndex = i;
			}
		}
		return num2;
	}

	public static float Min(params float[] values)
	{
		int minIndex;
		return Min(values, out minIndex);
	}

	public static float Min(float[] values, out int minIndex)
	{
		minIndex = 0;
		int num = values.Length;
		if (num == 0)
		{
			return 0f;
		}
		float num2 = values[0];
		for (int i = 1; i < num; i++)
		{
			float num3 = values[i];
			if (num3 < num2)
			{
				num2 = num3;
				minIndex = i;
			}
		}
		return num2;
	}

	public static double Min(params double[] values)
	{
		int minIndex;
		return Min(values, out minIndex);
	}

	public static double Min(double[] values, out int minIndex)
	{
		minIndex = 0;
		int num = values.Length;
		if (num == 0)
		{
			return 0.0;
		}
		double num2 = values[0];
		for (int i = 1; i < num; i++)
		{
			double num3 = values[i];
			if (num3 < num2)
			{
				num2 = num3;
				minIndex = i;
			}
		}
		return num2;
	}

	public static decimal Min(params decimal[] values)
	{
		int minIndex;
		return Min(values, out minIndex);
	}

	public static decimal Min(decimal[] values, out int minIndex)
	{
		minIndex = 0;
		int num = values.Length;
		if (num == 0)
		{
			return 0m;
		}
		decimal num2 = values[0];
		for (int i = 1; i < num; i++)
		{
			decimal num3 = values[i];
			if (num3 < num2)
			{
				num2 = num3;
				minIndex = i;
			}
		}
		return num2;
	}

	public static sbyte Max(params sbyte[] values)
	{
		int minIndex;
		return Max(values, out minIndex);
	}

	public static sbyte Max(sbyte[] values, out int minIndex)
	{
		minIndex = 0;
		int num = values.Length;
		if (num == 0)
		{
			return 0;
		}
		sbyte b = values[0];
		for (int i = 1; i < num; i++)
		{
			sbyte b2 = values[i];
			if (b2 > b)
			{
				b = b2;
				minIndex = i;
			}
		}
		return b;
	}

	public static byte Max(params byte[] values)
	{
		int minIndex;
		return Max(values, out minIndex);
	}

	public static byte Max(byte[] values, out int minIndex)
	{
		minIndex = 0;
		int num = values.Length;
		if (num == 0)
		{
			return 0;
		}
		byte b = values[0];
		for (int i = 1; i < num; i++)
		{
			byte b2 = values[i];
			if (b2 > b)
			{
				b = b2;
				minIndex = i;
			}
		}
		return b;
	}

	public static short Max(params short[] values)
	{
		int minIndex;
		return Max(values, out minIndex);
	}

	public static short Max(short[] values, out int minIndex)
	{
		minIndex = 0;
		int num = values.Length;
		if (num == 0)
		{
			return 0;
		}
		short num2 = values[0];
		for (int i = 1; i < num; i++)
		{
			short num3 = values[i];
			if (num3 > num2)
			{
				num2 = num3;
				minIndex = i;
			}
		}
		return num2;
	}

	public static ushort Max(params ushort[] values)
	{
		int minIndex;
		return Max(values, out minIndex);
	}

	public static ushort Max(ushort[] values, out int minIndex)
	{
		minIndex = 0;
		int num = values.Length;
		if (num == 0)
		{
			return 0;
		}
		ushort num2 = values[0];
		for (int i = 1; i < num; i++)
		{
			ushort num3 = values[i];
			if (num3 > num2)
			{
				num2 = num3;
				minIndex = i;
			}
		}
		return num2;
	}

	public static int Max(params int[] values)
	{
		int minIndex;
		return Max(values, out minIndex);
	}

	public static int Max(int[] values, out int minIndex)
	{
		minIndex = 0;
		int num = values.Length;
		if (num == 0)
		{
			return 0;
		}
		int num2 = values[0];
		for (int i = 1; i < num; i++)
		{
			int num3 = values[i];
			if (num3 > num2)
			{
				num2 = num3;
				minIndex = i;
			}
		}
		return num2;
	}

	public static uint Max(params uint[] values)
	{
		int minIndex;
		return Max(values, out minIndex);
	}

	public static uint Max(uint[] values, out int minIndex)
	{
		minIndex = 0;
		int num = values.Length;
		if (num == 0)
		{
			return 0u;
		}
		uint num2 = values[0];
		for (int i = 1; i < num; i++)
		{
			uint num3 = values[i];
			if (num3 > num2)
			{
				num2 = num3;
				minIndex = i;
			}
		}
		return num2;
	}

	public static long Max(params long[] values)
	{
		int minIndex;
		return Max(values, out minIndex);
	}

	public static long Max(long[] values, out int minIndex)
	{
		minIndex = 0;
		int num = values.Length;
		if (num == 0)
		{
			return 0L;
		}
		long num2 = values[0];
		for (int i = 1; i < num; i++)
		{
			long num3 = values[i];
			if (num3 > num2)
			{
				num2 = num3;
				minIndex = i;
			}
		}
		return num2;
	}

	public static ulong Max(params ulong[] values)
	{
		int minIndex;
		return Max(values, out minIndex);
	}

	public static ulong Max(ulong[] values, out int minIndex)
	{
		minIndex = 0;
		int num = values.Length;
		if (num == 0)
		{
			return 0uL;
		}
		ulong num2 = values[0];
		for (int i = 1; i < num; i++)
		{
			ulong num3 = values[i];
			if (num3 > num2)
			{
				num2 = num3;
				minIndex = i;
			}
		}
		return num2;
	}

	public static float Max(params float[] values)
	{
		int minIndex;
		return Max(values, out minIndex);
	}

	public static float Max(float[] values, out int minIndex)
	{
		minIndex = 0;
		int num = values.Length;
		if (num == 0)
		{
			return 0f;
		}
		float num2 = values[0];
		for (int i = 1; i < num; i++)
		{
			float num3 = values[i];
			if (num3 > num2)
			{
				num2 = num3;
				minIndex = i;
			}
		}
		return num2;
	}

	public static double Max(params double[] values)
	{
		int minIndex;
		return Max(values, out minIndex);
	}

	public static double Max(double[] values, out int minIndex)
	{
		minIndex = 0;
		int num = values.Length;
		if (num == 0)
		{
			return 0.0;
		}
		double num2 = values[0];
		for (int i = 1; i < num; i++)
		{
			double num3 = values[i];
			if (num3 > num2)
			{
				num2 = num3;
				minIndex = i;
			}
		}
		return num2;
	}

	public static decimal Max(params decimal[] values)
	{
		int minIndex;
		return Max(values, out minIndex);
	}

	public static decimal Max(decimal[] values, out int minIndex)
	{
		minIndex = 0;
		int num = values.Length;
		if (num == 0)
		{
			return 0m;
		}
		decimal num2 = values[0];
		for (int i = 1; i < num; i++)
		{
			decimal num3 = values[i];
			if (num3 > num2)
			{
				num2 = num3;
				minIndex = i;
			}
		}
		return num2;
	}

	public static void LogOrEnsureNanError(string format, params object[] args)
	{
		FMessage.Log("LogUnrealMath", ELogVerbosity.Error, string.Format(format, args));
	}

	public static int RandHelper(int a)
	{
		if (a <= 0)
		{
			return 0;
		}
		return Min(TruncToInt(FRand() * (float)a), a - 1);
	}

	public static int RandRange(int min, int max)
	{
		int a = max - min + 1;
		return min + RandHelper(a);
	}

	public static float RandRange(float min, float max)
	{
		return FRandRange(min, max);
	}

	public static float FRandRange(float min, float max)
	{
		return min + (max - min) * FRand();
	}

	public static double FRandRange(double min, double max)
	{
		return min + (max - min) * DRand();
	}

	public static bool RandBool()
	{
		return RandRange(0, 1) == 1;
	}

	public static FVector VRand()
	{
		FVector fVector = default(FVector);
		double num;
		do
		{
			fVector.X = FRand() * 2f - 1f;
			fVector.Y = FRand() * 2f - 1f;
			fVector.Z = FRand() * 2f - 1f;
			num = fVector.SizeSquared();
		}
		while (num < 1.0 || num < 9.999999747378752E-05);
		return fVector * (1.0 / Sqrt(num));
	}

	public static FVector VRandCone(FVector dir, float coneHalfAngleRad)
	{
		if (coneHalfAngleRad > 0f)
		{
			float num = FRand();
			float num2 = FRand();
			float num3 = (float)Math.PI * 2f * num;
			float x = Acos(2f * num2 - 1f);
			x = Fmod(x, coneHalfAngleRad);
			FMatrix fMatrix = FMatrix.CreateRotation(dir.Rotation());
			FVector scaledAxis = fMatrix.GetScaledAxis(EAxis.X);
			FVector scaledAxis2 = fMatrix.GetScaledAxis(EAxis.Y);
			return dir.RotateAngleAxis(x * 180f / (float)Math.PI, scaledAxis2).RotateAngleAxis(num3 * 180f / (float)Math.PI, scaledAxis).GetSafeNormal();
		}
		return dir.GetSafeNormal();
	}

	public static FVector VRandCone(FVector dir, float horizontalConeHalfAngleRad, float verticalConeHalfAngleRad)
	{
		if (verticalConeHalfAngleRad > 0f && horizontalConeHalfAngleRad > 0f)
		{
			float num = FRand();
			float num2 = FRand();
			float num3 = (float)Math.PI * 2f * num;
			float x = Acos(2f * num2 - 1f);
			float num4 = Square(Cos(num3) / verticalConeHalfAngleRad) + Square(Sin(num3) / horizontalConeHalfAngleRad);
			num4 = Sqrt(1f / num4);
			x = Fmod(x, num4);
			FMatrix fMatrix = FMatrix.CreateRotation(dir.Rotation());
			FVector scaledAxis = fMatrix.GetScaledAxis(EAxis.X);
			FVector scaledAxis2 = fMatrix.GetScaledAxis(EAxis.Y);
			return dir.RotateAngleAxis(x * 180f / (float)Math.PI, scaledAxis2).RotateAngleAxis(num3 * 180f / (float)Math.PI, scaledAxis).GetSafeNormal();
		}
		return dir.GetSafeNormal();
	}

	public static FVector2D RandPointInCircle(float circleRadius)
	{
		FVector2D fVector2D = default(FVector2D);
		double num;
		do
		{
			fVector2D.X = FRand() * 2f - 1f;
			fVector2D.Y = FRand() * 2f - 1f;
			num = fVector2D.SizeSquared();
		}
		while (num > 1.0);
		return fVector2D * circleRadius;
	}

	public static FVector RandPointInBox(FBox box)
	{
		return new FVector(FRandRange(box.Min.X, box.Max.X), FRandRange(box.Min.Y, box.Max.Y), FRandRange(box.Min.Z, box.Max.Z));
	}

	public static FVector GetReflectionVector(FVector direction, FVector surfaceNormal)
	{
		return direction - 2f * (direction | surfaceNormal.GetSafeNormal()) * surfaceNormal.GetSafeNormal();
	}

	public static bool IsNearlyEqual(float a, float b, float errorTolerance = 1E-08f)
	{
		return Abs(a - b) <= errorTolerance;
	}

	public static bool IsNearlyEqual(double a, double b, double errorTolerance = 9.99999993922529E-09)
	{
		return Abs(a - b) <= errorTolerance;
	}

	public static bool IsNearlyZero(float value, float errorTolerance = 1E-08f)
	{
		return Abs(value) <= errorTolerance;
	}

	public static bool IsNearlyZero(double value, double errorTolerance = 9.99999993922529E-09)
	{
		return Abs(value) <= errorTolerance;
	}

	public static bool IsPowerOfTwo(sbyte value)
	{
		return (value & (value - 1)) == 0;
	}

	public static float GridSnap(float location, float grid)
	{
		if (grid == 0f)
		{
			return location;
		}
		return FloorToFloat((location + 0.5f * grid) / grid) * grid;
	}

	public static double GridSnap(double location, double grid)
	{
		if (grid == 0.0)
		{
			return location;
		}
		return FloorToDouble((location + 0.5 * grid) / grid) * grid;
	}

	public static void SinCos(out float scalarSin, out float scalarCos, float value)
	{
		float num = 1f / (2f * (float)Math.PI) * value;
		num = ((!(value >= 0f)) ? ((float)(int)(num - 0.5f)) : ((float)(int)(num + 0.5f)));
		float num2 = value - (float)Math.PI * 2f * num;
		float num3;
		if (num2 > (float)Math.PI / 2f)
		{
			num2 = (float)Math.PI - num2;
			num3 = -1f;
		}
		else if (num2 < -(float)Math.PI / 2f)
		{
			num2 = -(float)Math.PI - num2;
			num3 = -1f;
		}
		else
		{
			num3 = 1f;
		}
		float num4 = num2 * num2;
		scalarSin = (((((-2.3889859E-08f * num4 + 2.7525562E-06f) * num4 - 0.00019840874f) * num4 + 0.008333331f) * num4 - 1f / 6f) * num4 + 1f) * num2;
		float num5 = ((((-2.6051615E-07f * num4 + 2.4760495E-05f) * num4 - 0.0013888378f) * num4 + 0.041666638f) * num4 - 0.5f) * num4 + 1f;
		scalarCos = num3 * num5;
	}

	public static void SinCos(out double scalarSin, out double scalarCos, double value)
	{
		double num = 0.15915493667125702 * value;
		num = ((!(value >= 0.0)) ? ((double)(int)(num - 0.5)) : ((double)(int)(num + 0.5)));
		double num2 = value - 6.2831854820251465 * num;
		double num3;
		if (num2 > 1.5707963705062866)
		{
			num2 = 3.1415927410125732 - num2;
			num3 = -1.0;
		}
		else if (num2 < -1.5707963705062866)
		{
			num2 = -3.1415927410125732 - num2;
			num3 = -1.0;
		}
		else
		{
			num3 = 1.0;
		}
		double num4 = num2 * num2;
		scalarSin = (((((-2.3889859E-08 * num4 + 2.7525562E-06) * num4 - 0.00019840874) * num4 + 0.008333331) * num4 - 0.16666667) * num4 + 1.0) * num2;
		double num5 = ((((-2.6051615E-07 * num4 + 2.4760495E-05) * num4 - 0.0013888378) * num4 + 0.041666638) * num4 - 0.5) * num4 + 1.0;
		scalarCos = num3 * num5;
	}

	public static float FastAsin(float value)
	{
		bool num = value >= 0f;
		float num2 = Abs(value);
		float num3 = 1f - num2;
		if (num3 < 0f)
		{
			num3 = 0f;
		}
		float num4 = Sqrt(num3);
		float num5 = ((((((-0.0012624911f * num2 + 0.00667009f) * num2 - 0.017088126f) * num2 + 0.03089188f) * num2 - 0.050174303f) * num2 + 0.08897899f) * num2 - 0.2145988f) * num2 + 1.5707963f;
		num5 *= num4;
		if (!num)
		{
			return num5 - 1.5707963f;
		}
		return 1.5707963f - num5;
	}

	public static double FastAsin(double value)
	{
		bool num = value >= 0.0;
		double num2 = Abs(value);
		double num3 = 1.0 - num2;
		if (num3 < 0.0)
		{
			num3 = 0.0;
		}
		double num4 = Sqrt(num3);
		double num5 = ((((((-0.0012624911 * num2 + 0.0066700901) * num2 - 0.0170881256) * num2 + 0.030891881) * num2 - 0.0501743046) * num2 + 0.0889789874) * num2 - 0.2145988016) * num2 + 1.570796305;
		num5 *= num4;
		if (!num)
		{
			return num5 - 1.570796305;
		}
		return 1.570796305 - num5;
	}

	public static float ClampAngle(float angleDegrees, float minAngleDegrees, float maxAngleDegrees)
	{
		float num = FRotator.ClampAxis(maxAngleDegrees - minAngleDegrees) * 0.5f;
		float num2 = FRotator.ClampAxis(minAngleDegrees + num);
		float num3 = FRotator.NormalizeAxis(angleDegrees - num2);
		if (num3 > num)
		{
			return FRotator.NormalizeAxis(num2 + num);
		}
		if (num3 < 0f - num)
		{
			return FRotator.NormalizeAxis(num2 - num);
		}
		return FRotator.NormalizeAxis(angleDegrees);
	}

	public static float FindDeltaAngleDegrees(float a1, float a2)
	{
		float num = a2 - a1;
		if (num > 180f)
		{
			num -= 360f;
		}
		else if (num < -180f)
		{
			num += 360f;
		}
		return num;
	}

	public static float FindDeltaAngleRadians(float a1, float a2)
	{
		float num = a2 - a1;
		if (num > (float)Math.PI)
		{
			num -= (float)Math.PI * 2f;
		}
		else if (num < -(float)Math.PI)
		{
			num += (float)Math.PI * 2f;
		}
		return num;
	}

	public static float UnwindRadians(float a)
	{
		while (a > (float)Math.PI)
		{
			a -= (float)Math.PI * 2f;
		}
		while (a < -(float)Math.PI)
		{
			a += (float)Math.PI * 2f;
		}
		return a;
	}

	public static float UnwindDegrees(float a)
	{
		while (a > 180f)
		{
			a -= 360f;
		}
		while (a < -180f)
		{
			a += 360f;
		}
		return a;
	}

	public static double UnwindDegrees(double a)
	{
		while (a > 180.0)
		{
			a -= 360.0;
		}
		while (a < -180.0)
		{
			a += 360.0;
		}
		return a;
	}

	public static void WindRelativeAnglesDegrees(float angle0, ref float angle1)
	{
		float value = angle0 - angle1;
		float num = Abs(value);
		if (num > 180f)
		{
			angle1 += 360f * (float)Sign(value) * FloorToFloat(num / 360f + 0.5f);
		}
	}

	public static double FixedTurn(double current, double desired, double deltaRate)
	{
		if (deltaRate == 0.0)
		{
			return FRotator.ClampAxis(current);
		}
		if (deltaRate >= 360.0)
		{
			return FRotator.ClampAxis(desired);
		}
		double num = FRotator.ClampAxis(current);
		current = num;
		desired = FRotator.ClampAxis(desired);
		num = ((current > desired) ? ((!(current - desired < 180.0)) ? (num + Min(desired + 360.0 - current, Abs(deltaRate))) : (num - Min(current - desired, Abs(deltaRate)))) : ((!(desired - current < 180.0)) ? (num - Min(current + 360.0 - desired, Abs(deltaRate))) : (num + Min(desired - current, Abs(deltaRate)))));
		return FRotator.ClampAxis(num);
	}

	public static void CartesianToPolar(float x, float y, out float rad, out float ang)
	{
		rad = Sqrt(Square(x) + Square(y));
		ang = Atan2(y, x);
	}

	public static void CartesianToPolar(FVector2D cart, out FVector2D polar)
	{
		polar = new FVector2D(Sqrt(Square(cart.X) + Square(cart.Y)), Atan2(cart.Y, cart.X));
	}

	public static void PolarToCartesian(float rad, float ang, out float x, out float y)
	{
		x = rad * Cos(ang);
		y = rad * Sin(ang);
	}

	public static void PolarToCartesian(FVector2D polar, out FVector2D cart)
	{
		cart = new FVector2D(polar.X * Cos(polar.Y), polar.X * Sin(polar.Y));
	}

	public static bool GetDotDistance(out FVector2D dotDist, FVector direction, FVector axisX, FVector axisY, FVector axisZ)
	{
		return GetDotDistance(out dotDist, ref direction, ref axisX, ref axisY, ref axisZ);
	}

	public static bool GetDotDistance(out FVector2D dotDist, ref FVector direction, ref FVector axisX, ref FVector axisY, ref FVector axisZ)
	{
		FVector safeNormal = direction.GetSafeNormal();
		FVector safeNormal2 = (safeNormal - (safeNormal | axisZ) * axisZ).GetSafeNormal();
		float num = (((safeNormal2 | axisY) < 0f) ? (-1f) : 1f);
		float num2 = safeNormal2 | axisX;
		dotDist = new FVector2D(num * Abs(num2), safeNormal | axisZ);
		return num2 >= 0f;
	}

	public static FVector2D GetAzimuthAndElevation(FVector direction, FVector axisX, FVector axisY, FVector axisZ)
	{
		return GetAzimuthAndElevation(ref direction, ref axisX, ref axisY, ref axisZ);
	}

	public static FVector2D GetAzimuthAndElevation(ref FVector direction, ref FVector axisX, ref FVector axisY, ref FVector axisZ)
	{
		FVector safeNormal = direction.GetSafeNormal();
		FVector safeNormal2 = (safeNormal - (safeNormal | axisZ) * axisZ).GetSafeNormal();
		float num = (((safeNormal2 | axisY) < 0f) ? (-1f) : 1f);
		return new FVector2D(y: Asin(safeNormal | axisZ), x: Acos(safeNormal2 | axisX) * num);
	}

	private static float TruncateToHalfIfClose(float f)
	{
		float intPart = 0f;
		float num = Modf(f, out intPart);
		if (f < 0f)
		{
			return intPart + (IsNearlyEqual(num, -0.5f) ? (-0.5f) : num);
		}
		return intPart + (IsNearlyEqual(num, 0.5f) ? 0.5f : num);
	}

	private static double TruncateToHalfIfClose(double f)
	{
		double intPart = 0.0;
		double num = Modf(f, out intPart);
		if (f < 0.0)
		{
			return intPart + (IsNearlyEqual(num, -0.5) ? (-0.5) : num);
		}
		return intPart + (IsNearlyEqual(num, 0.5) ? 0.5 : num);
	}

	public static float RoundHalfToEven(float f)
	{
		f = TruncateToHalfIfClose(f);
		bool flag = f < 0f;
		if ((uint)FloorToFloat(flag ? (0f - f) : f) % 2 == 0)
		{
			if (!flag)
			{
				return CeilToFloat(f - 0.5f);
			}
			return FloorToFloat(f + 0.5f);
		}
		if (!flag)
		{
			return FloorToFloat(f + 0.5f);
		}
		return CeilToFloat(f - 0.5f);
	}

	public static double RoundHalfToEven(double f)
	{
		f = TruncateToHalfIfClose(f);
		bool flag = f < 0.0;
		if ((ulong)FloorToDouble(flag ? (0.0 - f) : f) % 2 == 0)
		{
			if (!flag)
			{
				return CeilToDouble(f - 0.5);
			}
			return FloorToDouble(f + 0.5);
		}
		if (!flag)
		{
			return FloorToDouble(f + 0.5);
		}
		return CeilToDouble(f - 0.5);
	}

	public static float RoundHalfFromZero(float f)
	{
		f = TruncateToHalfIfClose(f);
		if (!(f < 0f))
		{
			return FloorToFloat(f + 0.5f);
		}
		return CeilToFloat(f - 0.5f);
	}

	public static double RoundHalfFromZero(double f)
	{
		f = TruncateToHalfIfClose(f);
		if (!(f < 0.0))
		{
			return FloorToDouble(f + 0.5);
		}
		return CeilToDouble(f - 0.5);
	}

	public static float RoundHalfToZero(float f)
	{
		f = TruncateToHalfIfClose(f);
		if (!(f < 0f))
		{
			return CeilToFloat(f - 0.5f);
		}
		return FloorToFloat(f + 0.5f);
	}

	public static double RoundHalfToZero(double f)
	{
		f = TruncateToHalfIfClose(f);
		if (!(f < 0.0))
		{
			return CeilToDouble(f - 0.5);
		}
		return FloorToDouble(f + 0.5);
	}

	public static float RoundFromZero(float f)
	{
		if (!(f < 0f))
		{
			return CeilToFloat(f);
		}
		return FloorToFloat(f);
	}

	public static double RoundFromZero(double f)
	{
		if (!(f < 0.0))
		{
			return CeilToDouble(f);
		}
		return FloorToDouble(f);
	}

	public static float RoundToZero(float f)
	{
		if (!(f < 0f))
		{
			return FloorToFloat(f);
		}
		return CeilToFloat(f);
	}

	public static double RoundToZero(double f)
	{
		if (!(f < 0.0))
		{
			return FloorToDouble(f);
		}
		return CeilToDouble(f);
	}

	public static float RoundToNegativeInfinity(float f)
	{
		return FloorToFloat(f);
	}

	public static double RoundToNegativeInfinity(double f)
	{
		return FloorToDouble(f);
	}

	public static float RoundToPositiveInfinity(float f)
	{
		return CeilToFloat(f);
	}

	public static double RoundToPositiveInfinity(double f)
	{
		return CeilToDouble(f);
	}

	public static string FormatIntToHumanReadable(int val)
	{
		return val.ToString("N0", CultureInfo.InvariantCulture);
	}

	public static bool MemoryTest(IntPtr baseAddress, uint numBytes)
	{
		return Native_FMath.MemoryTest(baseAddress, numBytes);
	}

	public static bool Eval(string str, out float value)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(str);
		return Native_FMath.Eval(ref fStringUnsafe.Array, out value);
	}

	public static FVector GetBaryCentric2D(FVector point, FVector a, FVector b, FVector c)
	{
		double num = ((b.Y - c.Y) * (point.X - c.X) + (c.X - b.X) * (point.Y - c.Y)) / ((b.Y - c.Y) * (a.X - c.X) + (c.X - b.X) * (a.Y - c.Y));
		double num2 = ((c.Y - a.Y) * (point.X - c.X) + (a.X - c.X) * (point.Y - c.Y)) / ((b.Y - c.Y) * (a.X - c.X) + (c.X - b.X) * (a.Y - c.Y));
		return new FVector(num, num2, 1.0 - num - num2);
	}

	public static FVector ComputeBaryCentric2D(FVector point, FVector a, FVector b, FVector c)
	{
		FVector fVector = (b - a) ^ (c - a);
		if (fVector.SizeSquared() <= 9.99999993922529E-09)
		{
			FMessage.Log("LogUnrealMath", ELogVerbosity.Warning, "Small triangle detected in FMath::ComputeBaryCentric2D(), can't compute valid barycentric coordinate.");
			return new FVector(0.0, 0.0, 0.0);
		}
		FVector safeNormal = fVector.GetSafeNormal();
		double num = 1.0 / (double)(safeNormal | fVector);
		double num2 = (double)(safeNormal | ((b - point) ^ (c - point))) * num;
		double num3 = (double)(safeNormal | ((c - point) ^ (a - point))) * num;
		return new FVector(num2, num3, 1.0 - num2 - num3);
	}

	public static FVector4 ComputeBaryCentric3D(FVector point, FVector a, FVector b, FVector c, FVector d)
	{
		FVector x = b - a;
		FVector y = c - a;
		FVector z = d - a;
		FVector v = point - a;
		FPlane fPlane = (FPlane)new FMatrix(x, y, z, FVector.ZeroVector).Inverse().TransformVector(v);
		return new FVector4(1.0 - fPlane.X - fPlane.Y - fPlane.Z, fPlane.X, fPlane.Y, fPlane.Z);
	}

	public static float SmoothStep(float a, float b, float x)
	{
		if (x < a)
		{
			return 0f;
		}
		if (x >= b)
		{
			return 1f;
		}
		float num = (x - a) / (b - a);
		return num * num * (3f - 2f * num);
	}

	public static bool ExtractBoolFromBitfield(byte[] bitField, int index)
	{
		int num = index / 8;
		byte b = (byte)(1 << (index & 7));
		return (bitField[num] & b) != 0;
	}

	public static void SetBoolInBitField(byte[] bitField, int index, bool set)
	{
		int num = index / 8;
		byte b = (byte)(1 << (index & 7));
		if (set)
		{
			bitField[num] |= b;
		}
		else
		{
			bitField[num] &= (byte)(~b);
		}
	}

	public static void ApplyScaleToFloat(ref double dst, FVector deltaScale, double magnitude = 1.0)
	{
		double num = (((double)deltaScale.X > 0.0 || (double)deltaScale.Y > 0.0 || (double)deltaScale.Z > 0.0) ? magnitude : (0.0 - magnitude));
		dst += num * (double)deltaScale.Size();
		dst = Max(0.0, dst);
	}

	public static byte Quantize8UnsignedByte(float x)
	{
		return (byte)(int)(x * 255.999f);
	}

	public static byte Quantize8SignedByte(float x)
	{
		return Quantize8UnsignedByte(x * 0.5f + 0.5f);
	}

	public static int GreatestCommonDivisor(int a, int b)
	{
		while (b != 0)
		{
			int num = b;
			b = a % b;
			a = num;
		}
		return a;
	}

	public static int LeastCommonMultiplier(int a, int b)
	{
		int num = GreatestCommonDivisor(a, b);
		if (num != 0)
		{
			return a / num * b;
		}
		return 0;
	}

	public static double GetRangePct(double minValue, double maxValue, double value)
	{
		double num = maxValue - minValue;
		if (IsNearlyZero(num))
		{
			if (!(value >= maxValue))
			{
				return 0.0;
			}
			return 1.0;
		}
		return (value - minValue) / num;
	}

	public static double GetRangePct(FVector2D range, double value)
	{
		return GetRangePct(range.X, range.Y, value);
	}

	public static double GetRangeValue(FVector2D range, double pct)
	{
		return Lerp(range.X, range.Y, pct);
	}

	public static float GetMappedRangeValueClamped(FVector2D inputRange, FVector2D outputRange, double value)
	{
		double pct = Clamp(GetRangePct(inputRange, value), 0.0, 1.0);
		return (float)GetRangeValue(outputRange, pct);
	}

	public static double GetMappedRangeValueUnclamped(FVector2D inputRange, FVector2D outputRange, double value)
	{
		return GetRangeValue(outputRange, GetRangePct(inputRange, value));
	}

	public static float Lerp(float a, float b, float alpha)
	{
		return a + alpha * (b - a);
	}

	public static double Lerp(double a, double b, double alpha)
	{
		return a + alpha * (b - a);
	}

	public static FLinearColor Lerp(FLinearColor a, FLinearColor b, float alpha)
	{
		return new FLinearColor(Lerp(a.R, b.R, alpha), Lerp(a.G, b.G, alpha), Lerp(a.B, b.B, alpha), Lerp(a.A, b.A, alpha));
	}

	public static FColor Lerp(FColor a, FColor b, float alpha)
	{
		return new FColor((byte)Lerp((int)a.R, (int)b.R, alpha), (byte)Lerp((int)a.G, (int)b.G, alpha), (byte)Lerp((int)a.B, (int)b.B, alpha), (byte)Lerp((int)a.A, (int)b.A, alpha));
	}

	public static FVector2D Lerp(FVector2D a, FVector2D b, float alpha)
	{
		return new FVector2D(Lerp(a.X, b.X, alpha), Lerp(a.Y, b.Y, alpha));
	}

	public static FVector Lerp(FVector a, FVector b, float alpha)
	{
		return new FVector(Lerp(a.X, b.X, alpha), Lerp(a.Y, b.Y, alpha), Lerp(a.Z, b.Z, alpha));
	}

	public static FVector Lerp(FVector a, FVector b, double alpha)
	{
		return new FVector(Lerp(a.X, b.X, alpha), Lerp(a.Y, b.Y, alpha), Lerp(a.Z, b.Z, alpha));
	}

	public static FVector4 Lerp(FVector4 a, FVector4 b, float alpha)
	{
		return new FVector4(Lerp(a.X, b.X, alpha), Lerp(a.Y, b.Y, alpha), Lerp(a.Z, b.Z, alpha), Lerp(a.W, b.W, alpha));
	}

	public static FIntPoint Lerp(FIntPoint a, FIntPoint b, float alpha)
	{
		return new FIntPoint((int)Lerp(a.X, b.X, alpha), (int)Lerp(a.Y, b.Y, alpha));
	}

	public static float LerpStable(float a, float b, float alpha)
	{
		return a * (1f - alpha) + b * alpha;
	}

	public static double LerpStable(double a, double b, double alpha)
	{
		return a * (1.0 - alpha) + b * alpha;
	}

	public static FLinearColor LerpStable(FLinearColor a, FLinearColor b, float alpha)
	{
		return new FLinearColor(LerpStable(a.R, b.R, alpha), LerpStable(a.G, b.G, alpha), LerpStable(a.B, b.B, alpha), LerpStable(a.A, b.A, alpha));
	}

	public static FColor LerpStable(FColor a, FColor b, float alpha)
	{
		return new FColor((byte)LerpStable((int)a.R, (int)b.R, alpha), (byte)LerpStable((int)a.G, (int)b.G, alpha), (byte)LerpStable((int)a.B, (int)b.B, alpha), (byte)LerpStable((int)a.A, (int)b.A, alpha));
	}

	public static FVector2D LerpStable(FVector2D a, FVector2D b, float alpha)
	{
		return new FVector2D(LerpStable(a.X, b.X, alpha), LerpStable(a.Y, b.Y, alpha));
	}

	public static FVector LerpStable(FVector a, FVector b, float alpha)
	{
		return new FVector(LerpStable(a.X, b.X, alpha), LerpStable(a.Y, b.Y, alpha), LerpStable(a.Z, b.Z, alpha));
	}

	public static FVector4 LerpStable(FVector4 a, FVector4 b, float alpha)
	{
		return new FVector4(LerpStable(a.X, b.X, alpha), LerpStable(a.Y, b.Y, alpha), LerpStable(a.Z, b.Z, alpha), LerpStable(a.W, b.W, alpha));
	}

	public static FIntPoint LerpStable(FIntPoint a, FIntPoint b, float alpha)
	{
		return new FIntPoint((int)LerpStable(a.X, b.X, alpha), (int)LerpStable(a.Y, b.Y, alpha));
	}

	public static float BiLerp(float p00, float p10, float p01, float p11, float fracX, float fracY)
	{
		return Lerp(Lerp(p00, p10, fracX), Lerp(p01, p11, fracX), fracY);
	}

	public static double BiLerp(double p00, double p10, double p01, double p11, double fracX, double fracY)
	{
		return Lerp(Lerp(p00, p10, fracX), Lerp(p01, p11, fracX), fracY);
	}

	public static float CubicInterp(float p0, float t0, float p1, float t1, float alpha)
	{
		float num = alpha * alpha;
		float num2 = num * alpha;
		return (2f * num2 - 3f * num + 1f) * p0 + (num2 - 2f * num + alpha) * t0 + (num2 - num) * t1 + (-2f * num2 + 3f * num) * p1;
	}

	public static double CubicInterp(double p0, double t0, double p1, double t1, double alpha)
	{
		double num = alpha * alpha;
		double num2 = num * alpha;
		return (2.0 * num2 - 3.0 * num + 1.0) * p0 + (num2 - 2.0 * num + alpha) * t0 + (num2 - num) * t1 + (-2.0 * num2 + 3.0 * num) * p1;
	}

	public static float CubicInterpDerivative(float p0, float t0, float p1, float t1, float alpha)
	{
		float num = 6f * p0 + 3f * t0 + 3f * t1 - 6f * p1;
		float num2 = -6f * p0 - 4f * t0 - 2f * t1 + 6f * p1;
		float num3 = num * num;
		return num * num3 + num2 * alpha + t0;
	}

	public static float CubicInterpSecondDerivative(float p0, float t0, float p1, float t1, float alpha)
	{
		float num = 12f * p0 + 6f * t0 + 6f * t1 - 12f * p1;
		float num2 = -6f * p0 - 4f * t0 - 2f * t1 + 6f * p1;
		return num * alpha + num2;
	}

	public static float InterpEaseIn(float a, float b, float alpha, float exp)
	{
		float alpha2 = Pow(alpha, exp);
		return Lerp(a, b, alpha2);
	}

	public static float InterpEaseOut(float a, float b, float alpha, float exp)
	{
		float alpha2 = 1f - Pow(1f - alpha, exp);
		return Lerp(a, b, alpha2);
	}

	public static float InterpEaseInOut(float a, float b, float alpha, float exp)
	{
		return Lerp(a, b, (alpha < 0.5f) ? (InterpEaseIn(0f, 1f, alpha * 2f, exp) * 0.5f) : (InterpEaseOut(0f, 1f, alpha * 2f - 1f, exp) * 0.5f + 0.5f));
	}

	public static float InterpStep(float a, float b, float alpha, int steps)
	{
		if (steps <= 1 || alpha <= 0f)
		{
			return a;
		}
		if (alpha >= 1f)
		{
			return b;
		}
		float num = steps;
		float num2 = num - 1f;
		float alpha2 = FloorToFloat(alpha * num) / num2;
		return Lerp(a, b, alpha2);
	}

	public static float InterpSinIn(float a, float b, float alpha)
	{
		float alpha2 = -1f * Cos(alpha * ((float)Math.PI / 2f)) + 1f;
		return Lerp(a, b, alpha2);
	}

	public static float InterpSinOut(float a, float b, float alpha)
	{
		float alpha2 = Sin(alpha * ((float)Math.PI / 2f));
		return Lerp(a, b, alpha2);
	}

	public static float InterpSinInOut(float a, float b, float alpha)
	{
		return Lerp(a, b, (alpha < 0.5f) ? (InterpSinIn(0f, 1f, alpha * 2f) * 0.5f) : (InterpSinOut(0f, 1f, alpha * 2f - 1f) * 0.5f + 0.5f));
	}

	public static float InterpExpoIn(float a, float b, float alpha)
	{
		float alpha2 = ((alpha == 0f) ? 0f : Pow(2f, 10f * (alpha - 1f)));
		return Lerp(a, b, alpha2);
	}

	public static float InterpExpoOut(float a, float b, float alpha)
	{
		float alpha2 = ((alpha == 1f) ? 1f : (0f - Pow(2f, -10f * alpha) + 1f));
		return Lerp(a, b, alpha2);
	}

	public static float InterpExpoInOut(float a, float b, float alpha)
	{
		return Lerp(a, b, (alpha < 0.5f) ? (InterpExpoIn(0f, 1f, alpha * 2f) * 0.5f) : (InterpExpoOut(0f, 1f, alpha * 2f - 1f) * 0.5f + 0.5f));
	}

	public static float InterpCircularIn(float a, float b, float alpha)
	{
		float alpha2 = -1f * (Sqrt(1f - alpha * alpha) - 1f);
		return Lerp(a, b, alpha2);
	}

	public static float InterpCircularOut(float a, float b, float alpha)
	{
		alpha -= 1f;
		float alpha2 = Sqrt(1f - alpha * alpha);
		return Lerp(a, b, alpha2);
	}

	public static float InterpCircularInOut(float a, float b, float alpha)
	{
		return Lerp(a, b, (alpha < 0.5f) ? (InterpCircularIn(0f, 1f, alpha * 2f) * 0.5f) : (InterpCircularOut(0f, 1f, alpha * 2f - 1f) * 0.5f + 0.5f));
	}

	public static FRotator Lerp(FRotator a, FRotator b, float alpha)
	{
		return a + (b - a).GetNormalized() * alpha;
	}

	public static FRotator Lerp(FRotator a, FRotator b, double alpha)
	{
		return a + (b - a).GetNormalized() * alpha;
	}

	public static FRotator LerpRange(FRotator a, FRotator b, float alpha)
	{
		return (a * (1f - alpha) + b * alpha).GetNormalized();
	}

	public static FRotator LerpRange(FRotator a, FRotator b, double alpha)
	{
		return (a * (1.0 - alpha) + b * alpha).GetNormalized();
	}

	public static FQuat Lerp(FQuat a, FQuat b, float alpha)
	{
		return FQuat.Slerp(a, b, alpha);
	}

	public static FQuat BiLerp(FQuat p00, FQuat p10, FQuat p01, FQuat p11, float fracX, float fracY)
	{
		return Lerp(FQuat.Slerp_NotNormalized(p00, p10, fracX), FQuat.Slerp_NotNormalized(p01, p11, fracX), fracY);
	}

	public static FQuat CubicInterp(FQuat p0, FQuat t0, FQuat p1, FQuat t1, float alpha)
	{
		return FQuat.Squad(p0, t0, p1, t1, alpha);
	}

	public static float CubicCRSplineInterp(float p0, float p1, float p2, float p3, float t0, float t1, float t2, float t3, float t)
	{
		float num = 1f / (t1 - t0);
		float num2 = p0 * ((t1 - t) * num) + p1 * ((t - t0) * num);
		float num3 = 1f / (t2 - t1);
		float num4 = p1 * ((t2 - t) * num3) + p2 * ((t - t1) * num3);
		float num5 = 1f / (t3 - t2);
		float num6 = p2 * ((t3 - t) * num5) + p3 * ((t - t2) * num5);
		float num7 = 1f / (t2 - t0);
		float num8 = num2 * ((t2 - t) * num7) + num4 * ((t - t0) * num7);
		float num9 = 1f / (t3 - t1);
		float num10 = num4 * ((t3 - t) * num9) + num6 * ((t - t1) * num9);
		return num8 * ((t2 - t) * num3) + num10 * ((t - t1) * num3);
	}

	public static float CubicCRSplineInterpSafe(float p0, float p1, float p2, float p3, float t0, float t1, float t2, float t3, float t)
	{
		float value = t1 - t0;
		float value2 = t2 - t1;
		float value3 = t3 - t2;
		float value4 = t2 - t0;
		float value5 = t3 - t1;
		if (IsNearlyZero(value) || IsNearlyZero(value2) || IsNearlyZero(value3) || IsNearlyZero(value4) || IsNearlyZero(value5))
		{
			return p1;
		}
		float num = 1f / (t1 - t0);
		float num2 = p0 * ((t1 - t) * num) + p1 * ((t - t0) * num);
		float num3 = 1f / (t2 - t1);
		float num4 = p1 * ((t2 - t) * num3) + p2 * ((t - t1) * num3);
		float num5 = 1f / (t3 - t2);
		float num6 = p2 * ((t3 - t) * num5) + p3 * ((t - t2) * num5);
		float num7 = 1f / (t2 - t0);
		float num8 = num2 * ((t2 - t) * num7) + num4 * ((t - t0) * num7);
		float num9 = 1f / (t3 - t1);
		float num10 = num4 * ((t3 - t) * num9) + num6 * ((t - t1) * num9);
		return num8 * ((t2 - t) * num3) + num10 * ((t - t1) * num3);
	}

	public static FVector VInterpNormalRotationTo(FVector current, FVector target, float deltaTime, float rotationSpeedDegrees)
	{
		FQuat.FindBetween(current, target).ToAxisAndAngle(out var axis, out var angle);
		float num = rotationSpeedDegrees * ((float)Math.PI / 180f) * deltaTime;
		if (Abs(angle) > (double)num)
		{
			angle = Clamp(angle, 0f - num, num);
			return new FQuat(axis, angle).RotateVector(current);
		}
		return target;
	}

	public static FVector VInterpConstantTo(FVector current, FVector target, float deltaTime, float interpSpeed)
	{
		FVector fVector = target - current;
		double num = fVector.Size();
		float num2 = interpSpeed * deltaTime;
		if (num > (double)num2)
		{
			if (num2 > 0f)
			{
				FVector fVector2 = fVector / num;
				return current + fVector2 * num2;
			}
			return current;
		}
		return target;
	}

	public static FVector VInterpTo(FVector current, FVector target, float deltaTime, float interpSpeed)
	{
		if (interpSpeed <= 0f)
		{
			return target;
		}
		FVector fVector = target - current;
		if (fVector.SizeSquared() < 9.999999747378752E-05)
		{
			return target;
		}
		FVector fVector2 = fVector * Clamp(deltaTime * interpSpeed, 0f, 1f);
		return current + fVector2;
	}

	public static FVector2D Vector2DInterpConstantTo(FVector2D current, FVector2D target, float deltaTime, float interpSpeed)
	{
		FVector2D fVector2D = target - current;
		double num = fVector2D.Size();
		float num2 = interpSpeed * deltaTime;
		if (num > (double)num2)
		{
			if (num2 > 0f)
			{
				FVector2D fVector2D2 = fVector2D / num;
				return current + fVector2D2 * num2;
			}
			return current;
		}
		return target;
	}

	public static FVector2D Vector2DInterpTo(FVector2D current, FVector2D target, float deltaTime, float interpSpeed)
	{
		if (interpSpeed <= 0f)
		{
			return target;
		}
		FVector2D fVector2D = target - current;
		if (fVector2D.SizeSquared() < 0.0001f)
		{
			return target;
		}
		FVector2D fVector2D2 = fVector2D * Clamp(deltaTime * interpSpeed, 0f, 1f);
		return current + fVector2D2;
	}

	public static FRotator RInterpConstantTo(FRotator current, FRotator target, float deltaTime, float interpSpeed)
	{
		if (deltaTime == 0f || current == target)
		{
			return current;
		}
		if (interpSpeed <= 0f)
		{
			return target;
		}
		float num = interpSpeed * deltaTime;
		FRotator normalized = (target - current).GetNormalized();
		FRotator fRotator = current;
		fRotator.Pitch += Clamp(normalized.Pitch, 0f - num, num);
		fRotator.Yaw += Clamp(normalized.Yaw, 0f - num, num);
		fRotator.Roll += Clamp(normalized.Roll, 0f - num, num);
		return fRotator.GetNormalized();
	}

	public static FRotator RInterpTo(FRotator current, FRotator target, float deltaTime, float interpSpeed)
	{
		if (deltaTime == 0f || current == target)
		{
			return current;
		}
		if (interpSpeed <= 0f)
		{
			return target;
		}
		float x = interpSpeed * deltaTime;
		FRotator normalized = (target - current).GetNormalized();
		if (normalized.IsNearlyZero())
		{
			return target;
		}
		FRotator fRotator = normalized * Clamp(x, 0f, 1f);
		return (current + fRotator).GetNormalized();
	}

	public static float FInterpConstantTo(float current, float target, float deltaTime, float interpSpeed)
	{
		float num = target - current;
		if (Square(num) < 1E-08f)
		{
			return target;
		}
		float num2 = interpSpeed * deltaTime;
		return current + Clamp(num, 0f - num2, num2);
	}

	public static float FInterpTo(float current, float target, float deltaTime, float interpSpeed)
	{
		if (interpSpeed <= 0f)
		{
			return target;
		}
		float num = target - current;
		if (Square(num) < 1E-08f)
		{
			return target;
		}
		float num2 = num * Clamp(deltaTime * interpSpeed, 0f, 1f);
		return current + num2;
	}

	public static double DInterpTo(double current, double target, double deltaTime, double interpSpeed)
	{
		if (interpSpeed <= 0.0)
		{
			return target;
		}
		double num = target - current;
		if (Square(num) < 9.99999993922529E-09)
		{
			return target;
		}
		double num2 = num * Clamp(deltaTime * interpSpeed, 0.0, 1.0);
		return current + num2;
	}

	public static FLinearColor CInterpTo(FLinearColor current, FLinearColor target, float deltaTime, float interpSpeed)
	{
		if (interpSpeed <= 0f)
		{
			return target;
		}
		if ((double)FLinearColor.Dist(target, current) < 9.999999747378752E-05)
		{
			return target;
		}
		FLinearColor fLinearColor = (target - current) * Clamp(deltaTime * interpSpeed, 0f, 1f);
		return current + fLinearColor;
	}

	public static FQuat QInterpConstantTo(FQuat current, FQuat target, float deltaTime, float interpSpeed)
	{
		if (interpSpeed <= 0f)
		{
			return target;
		}
		if (current.Equals(target))
		{
			return target;
		}
		float num = Clamp(deltaTime * interpSpeed, 0f, 1f);
		float num2 = (float)Max(9.99999993922529E-09, target.AngularDistance(current));
		float slerp = Clamp(num / num2, 0f, 1f);
		return FQuat.Slerp(current, target, slerp);
	}

	public static FQuat QInterpTo(FQuat current, FQuat target, float deltaTime, float interpSpeed)
	{
		if (interpSpeed <= 0f)
		{
			return target;
		}
		if (current.Equals(target))
		{
			return target;
		}
		return FQuat.Slerp(current, target, Clamp(interpSpeed * deltaTime, 0f, 1f));
	}

	public static float MakePulsatingValue(double currentTime, float pulsesPerSecond, float phase = 0f)
	{
		return 0.5f + 0.5f * Sin((float)((double)((0.25f + phase) * (float)Math.PI) * 2.0 + currentTime * 3.1415927410125732 * 2.0 * (double)pulsesPerSecond));
	}

	public static FVector RayPlaneIntersection(FVector rayOrigin, FVector rayDirection, FPlane plane)
	{
		FVector fVector = new FVector(plane.X, plane.Y, plane.Z);
		double num = FVector.DotProduct(fVector * plane.W - rayOrigin, fVector) / FVector.DotProduct(rayDirection, fVector);
		return rayOrigin + rayDirection * num;
	}

	public static FVector LinePlaneIntersection(FVector point1, FVector point2, FVector planeOrigin, FVector planeNormal)
	{
		return point1 + (point2 - point1) * (((planeOrigin - point1) | planeNormal) / ((point2 - point1) | planeNormal));
	}

	public static FVector LinePlaneIntersection(FVector point1, FVector point2, FPlane plane)
	{
		return point1 + (point2 - point1) * ((plane.W - (double)(point1 | plane)) / (double)((point2 - point1) | plane));
	}

	public static bool ComputeProjectedSphereShaft(float lightX, float lightZ, float radius, FMatrix projMatrix, FVector axis, float axisSign, ref int minX, ref int maxX)
	{
		float num = minX;
		double num2 = maxX - minX;
		float num3 = (Square(lightX) - Square(radius) + Square(lightZ)) * Square(lightZ);
		if (num3 >= 0f)
		{
			float num4 = Sqrt(num3);
			float num5 = 1f / (Square(lightX) + Square(lightZ));
			float num6 = (radius * lightX - num4) * num5;
			float num7 = (radius * lightX + num4) * num5;
			float num8 = (radius - num6 * lightX) / lightZ;
			float num9 = (radius - num7 * lightX) / lightZ;
			float num10 = lightZ - radius * num8;
			float num11 = lightZ - radius * num9;
			if (num10 > 0f)
			{
				float num12 = (0f - num10) * num8 / num6;
				FVector4 a = projMatrix.TransformFVector4(new FVector4(axis.X * num12, axis.Y * num12, num10, 1.0));
				double num13 = (FVector4.Dot3(a, axis) / (double)a.W + (double)(1f * axisSign)) / 2.0 * (double)axisSign;
				if (IsNegativeFloat(num6) ^ IsNegativeFloat(axisSign))
				{
					maxX = Min(CeilToInt(num2 * num13 + (double)num), maxX);
				}
				else
				{
					minX = Max(FloorToInt(num2 * num13 + (double)num), minX);
				}
			}
			if (num11 > 0f)
			{
				float num14 = (0f - num11) * num9 / num7;
				FVector4 a2 = projMatrix.TransformFVector4(new FVector4(axis.X * num14, axis.Y * num14, num11, 1.0));
				double num15 = (FVector4.Dot3(a2, axis) / (double)a2.W + 1.0 * (double)axisSign) / 2.0 * (double)axisSign;
				if (IsNegativeFloat(num7) ^ IsNegativeFloat(axisSign))
				{
					maxX = Min(CeilToInt(num2 * num15 + (double)num), maxX);
				}
				else
				{
					minX = Max(FloorToInt(num2 * num15 + (double)num), minX);
				}
			}
		}
		return minX <= maxX;
	}

	public static uint ComputeProjectedSphereScissorRect(ref FIntRect scissorRect, FVector sphereOrigin, float radius, FVector viewOrigin, FMatrix viewMatrix, FMatrix projMatrix)
	{
		if ((sphereOrigin - viewOrigin).SizeSquared() > (double)Square(radius))
		{
			FVector fVector = viewMatrix.TransformPosition(sphereOrigin);
			if (!ComputeProjectedSphereShaft(fVector.X, fVector.Z, radius, projMatrix, new FVector(1.0, 0.0, 0.0), 1f, ref scissorRect.Min.X, ref scissorRect.Max.X))
			{
				return 0u;
			}
			if (!ComputeProjectedSphereShaft(fVector.Y, fVector.Z, radius, projMatrix, new FVector(0.0, 1.0, 0.0), -1f, ref scissorRect.Min.Y, ref scissorRect.Max.Y))
			{
				return 0u;
			}
			return 1u;
		}
		return 2u;
	}

	public static FSphere ComputeBoundingSphereForCone(FVector coneOrigin, FVector coneDirection, float coneRadius, float cosConeAngle, float sinConeAngle)
	{
		if (cosConeAngle < 0.707107f)
		{
			return new FSphere(coneOrigin + coneDirection * coneRadius * cosConeAngle, coneRadius * sinConeAngle);
		}
		float num = coneRadius / (2f * cosConeAngle);
		return new FSphere(coneOrigin + coneDirection * num, num);
	}

	public unsafe static bool PlaneAABBIntersection(FPlane p, FBox aabb)
	{
		FVector p2 = default(FVector);
		FVector p3 = default(FVector);
		float* ptr = (float*)(&p2);
		float* ptr2 = (float*)(&p3);
		float* ptr3 = (float*)(&aabb.Min);
		float* ptr4 = (float*)(&aabb.Max);
		float* ptr5 = (float*)(&p);
		for (int i = 0; i < 3; i++)
		{
			if (ptr5[i] >= 0f)
			{
				ptr[i] = ptr3[i];
				ptr2[i] = ptr4[i];
			}
			else
			{
				ptr[i] = ptr4[i];
				ptr2[i] = ptr3[i];
			}
		}
		double num = p.PlaneDot(p3);
		double num2 = p.PlaneDot(p2);
		if (num >= 0.0)
		{
			return num2 <= 0.0;
		}
		return false;
	}

	public static bool SphereAABBIntersection(FVector sphereCenter, float radiusSquared, FBox aabb)
	{
		double num = 0.0;
		if (sphereCenter.X < aabb.Min.X)
		{
			num += (double)Square(sphereCenter.X - aabb.Min.X);
		}
		else if (sphereCenter.X > aabb.Max.X)
		{
			num += (double)Square(sphereCenter.X - aabb.Max.X);
		}
		if (sphereCenter.Y < aabb.Min.Y)
		{
			num += (double)Square(sphereCenter.Y - aabb.Min.Y);
		}
		else if (sphereCenter.Y > aabb.Max.Y)
		{
			num += (double)Square(sphereCenter.Y - aabb.Max.Y);
		}
		if (sphereCenter.Z < aabb.Min.Z)
		{
			num += (double)Square(sphereCenter.Z - aabb.Min.Z);
		}
		else if (sphereCenter.Z > aabb.Max.Z)
		{
			num += (double)Square(sphereCenter.Z - aabb.Max.Z);
		}
		return num <= (double)radiusSquared;
	}

	public static bool SphereAABBIntersection(FSphere sphere, FBox aabb)
	{
		float radiusSquared = (float)Square(sphere.W);
		return SphereAABBIntersection(sphere.Center, radiusSquared, aabb);
	}

	public static bool PointBoxIntersection(FVector point, FBox box)
	{
		if (point.X >= box.Min.X && point.X <= box.Max.X && point.Y >= box.Min.Y && point.Y <= box.Max.Y && point.Z >= box.Min.Z)
		{
			return point.Z <= box.Max.Z;
		}
		return false;
	}

	public static bool LineBoxIntersection(FBox box, FVector start, FVector end, FVector direction)
	{
		return LineBoxIntersection(box, start, end, direction, direction.Reciprocal());
	}

	public static bool LineBoxIntersection(FBox box, FVector start, FVector end, FVector direction, FVector oneOverDirection)
	{
		FVector fVector = default(FVector);
		bool flag = false;
		if (start.X < box.Min.X)
		{
			flag = true;
			if (!(end.X >= box.Min.X))
			{
				return false;
			}
			fVector.X = (box.Min.X - start.X) * oneOverDirection.X;
		}
		else if (start.X > box.Max.X)
		{
			flag = true;
			if (!(end.X <= box.Max.X))
			{
				return false;
			}
			fVector.X = (box.Max.X - start.X) * oneOverDirection.X;
		}
		else
		{
			fVector.X = 0f;
		}
		if (start.Y < box.Min.Y)
		{
			flag = true;
			if (!(end.Y >= box.Min.Y))
			{
				return false;
			}
			fVector.Y = (box.Min.Y - start.Y) * oneOverDirection.Y;
		}
		else if (start.Y > box.Max.Y)
		{
			flag = true;
			if (!(end.Y <= box.Max.Y))
			{
				return false;
			}
			fVector.Y = (box.Max.Y - start.Y) * oneOverDirection.Y;
		}
		else
		{
			fVector.Y = 0f;
		}
		if (start.Z < box.Min.Z)
		{
			flag = true;
			if (!(end.Z >= box.Min.Z))
			{
				return false;
			}
			fVector.Z = (box.Min.Z - start.Z) * oneOverDirection.Z;
		}
		else if (start.Z > box.Max.Z)
		{
			flag = true;
			if (!(end.Z <= box.Max.Z))
			{
				return false;
			}
			fVector.Z = (box.Max.Z - start.Z) * oneOverDirection.Z;
		}
		else
		{
			fVector.Z = 0f;
		}
		if (flag)
		{
			double num = Max3(fVector.X, fVector.Y, fVector.Z);
			if (num >= 0.0 && num <= 1.0)
			{
				FVector fVector2 = start + direction * num;
				if (fVector2.X > box.Min.X - 0.1f && fVector2.X < box.Max.X + 0.1f && fVector2.Y > box.Min.Y - 0.1f && fVector2.Y < box.Max.Y + 0.1f && fVector2.Z > box.Min.Z - 0.1f && fVector2.Z < box.Max.Z + 0.1f)
				{
					return true;
				}
			}
			return false;
		}
		return true;
	}

	public static bool LineExtentBoxIntersection(FBox inBox, FVector start, FVector end, FVector extent, out FVector hitLocation, out FVector hitNormal, out float hitTime)
	{
		FBox fBox = inBox;
		fBox.Max.X += extent.X;
		fBox.Max.Y += extent.Y;
		fBox.Max.Z += extent.Z;
		fBox.Min.X -= extent.X;
		fBox.Min.Y -= extent.Y;
		fBox.Min.Z -= extent.Z;
		FVector fVector = end - start;
		FVector fVector2 = default(FVector);
		bool flag = true;
		float[] array = new float[3] { 1f, 1f, 1f };
		if (start.X < fBox.Min.X)
		{
			if (fVector.X <= 0f)
			{
				hitLocation = default(FVector);
				hitNormal = default(FVector);
				hitTime = 0f;
				return false;
			}
			flag = false;
			array[0] = -1f;
			fVector2.X = (fBox.Min.X - start.X) / fVector.X;
		}
		else if (start.X > fBox.Max.X)
		{
			if (fVector.X >= 0f)
			{
				hitLocation = default(FVector);
				hitNormal = default(FVector);
				hitTime = 0f;
				return false;
			}
			flag = false;
			fVector2.X = (fBox.Max.X - start.X) / fVector.X;
		}
		else
		{
			fVector2.X = 0f;
		}
		if (start.Y < fBox.Min.Y)
		{
			if (fVector.Y <= 0f)
			{
				hitLocation = default(FVector);
				hitNormal = default(FVector);
				hitTime = 0f;
				return false;
			}
			flag = false;
			array[1] = -1f;
			fVector2.Y = (fBox.Min.Y - start.Y) / fVector.Y;
		}
		else if (start.Y > fBox.Max.Y)
		{
			if (fVector.Y >= 0f)
			{
				hitLocation = default(FVector);
				hitNormal = default(FVector);
				hitTime = 0f;
				return false;
			}
			flag = false;
			fVector2.Y = (fBox.Max.Y - start.Y) / fVector.Y;
		}
		else
		{
			fVector2.Y = 0f;
		}
		if (start.Z < fBox.Min.Z)
		{
			if (fVector.Z <= 0f)
			{
				hitLocation = default(FVector);
				hitNormal = default(FVector);
				hitTime = 0f;
				return false;
			}
			flag = false;
			array[2] = -1f;
			fVector2.Z = (fBox.Min.Z - start.Z) / fVector.Z;
		}
		else if (start.Z > fBox.Max.Z)
		{
			if (fVector.Z >= 0f)
			{
				hitLocation = default(FVector);
				hitNormal = default(FVector);
				hitTime = 0f;
				return false;
			}
			flag = false;
			fVector2.Z = (fBox.Max.Z - start.Z) / fVector.Z;
		}
		else
		{
			fVector2.Z = 0f;
		}
		if (flag)
		{
			hitLocation = start;
			hitNormal = new FVector(0.0, 0.0, 1.0);
			hitTime = 0f;
			return true;
		}
		if (fVector2.Y > fVector2.Z)
		{
			hitTime = fVector2.Y;
			hitNormal = new FVector(0.0, array[1], 0.0);
		}
		else
		{
			hitTime = fVector2.Z;
			hitNormal = new FVector(0.0, 0.0, array[2]);
		}
		if (fVector2.X > hitTime)
		{
			hitTime = fVector2.X;
			hitNormal = new FVector(array[0], 0.0, 0.0);
		}
		if (hitTime >= 0f && hitTime <= 1f)
		{
			hitLocation = start + fVector * hitTime;
			if (hitLocation.X > fBox.Min.X - 0.1f && hitLocation.X < fBox.Max.X + 0.1f && hitLocation.Y > fBox.Min.Y - 0.1f && hitLocation.Y < fBox.Max.Y + 0.1f && hitLocation.Z > fBox.Min.Z - 0.1f && hitLocation.Z < fBox.Max.Z + 0.1f)
			{
				return true;
			}
		}
		hitLocation = default(FVector);
		return false;
	}

	public static bool LineSphereIntersection(FVector start, FVector dir, float length, FVector origin, float radius)
	{
		FVector fVector = start - origin;
		double num = dir | (origin - start);
		double num2 = (double)(radius * radius) - ((double)(fVector | fVector) - num * num);
		if (num2 >= 0.0)
		{
			double num3 = (num - Sqrt(num2)) / (double)length;
			if (num3 >= 0.0 && num3 <= 1.0)
			{
				return true;
			}
			return false;
		}
		return false;
	}

	public static bool SphereConeIntersection(FVector sphereCenter, float sphereRadius, FVector coneAxis, float coneAngleSin, float coneAngleCos)
	{
		FVector fVector = coneAxis * ((0f - sphereRadius) / coneAngleSin);
		FVector fVector2 = sphereCenter - fVector;
		double num = fVector2 | fVector2;
		double num2 = coneAxis | fVector2;
		if (num2 > 0.0 && num2 * num2 >= num * (double)Square(coneAngleCos))
		{
			num = sphereCenter | sphereCenter;
			num2 = -coneAxis | sphereCenter;
			if (num2 > 0.0 && num2 * num2 >= num * (double)Square(coneAngleSin))
			{
				return num <= (double)Square(sphereRadius);
			}
			return true;
		}
		return false;
	}

	public static FVector ClosestPointOnLine(FVector lineStart, FVector lineEnd, FVector point)
	{
		double num = (lineStart - point) | (lineEnd - lineStart);
		double num2 = (lineEnd - lineStart).SizeSquared();
		double num3 = Clamp((0.0 - num) / num2, 0.0, 1.0);
		return lineStart + num3 * (lineEnd - lineStart);
	}

	public static FVector ClosestPointOnInfiniteLine(FVector lineStart, FVector lineEnd, FVector point)
	{
		double num = (lineStart - point) | (lineEnd - lineStart);
		double num2 = (lineEnd - lineStart).SizeSquared();
		if (num2 < 9.99999993922529E-09)
		{
			return lineStart;
		}
		double num3 = (0.0 - num) / num2;
		return lineStart + num3 * (lineEnd - lineStart);
	}

	public static bool IntersectPlanes3(out FVector i, FPlane p1, FPlane p2, FPlane p3)
	{
		double num = (p1 ^ p2) | p3;
		if (Square(num) < (double)Square(0.001f))
		{
			i = FVector.ZeroVector;
			return false;
		}
		i = (p1.W * (p2 ^ p3) + p2.W * (p3 ^ p1) + p3.W * (p1 ^ p2)) / num;
		return true;
	}

	public static bool IntersectPlanes2(out FVector i, out FVector d, FPlane p1, FPlane p2)
	{
		d = p1 ^ p2;
		double num = d.SizeSquared();
		if (num < (double)Square(0.001f))
		{
			d = (i = FVector.ZeroVector);
			return false;
		}
		i = (p1.W * (p2 ^ d) + p2.W * (d ^ p1)) / num;
		d.Normalize();
		return true;
	}

	public static double PointDistToLine(FVector point, FVector direction, FVector origin, out FVector closestPoint)
	{
		FVector safeNormal = direction.GetSafeNormal();
		closestPoint = origin + safeNormal * ((point - origin) | safeNormal);
		return (closestPoint - point).Size();
	}

	public static double PointDistToLine(FVector point, FVector direction, FVector origin)
	{
		FVector safeNormal = direction.GetSafeNormal();
		return (origin + safeNormal * ((point - origin) | safeNormal) - point).Size();
	}

	public static FVector ClosestPointOnSegment(FVector point, FVector startPoint, FVector endPoint)
	{
		FVector fVector = endPoint - startPoint;
		double num = (point - startPoint) | fVector;
		if (num <= 0.0)
		{
			return startPoint;
		}
		double num2 = fVector | fVector;
		if (num2 <= num)
		{
			return endPoint;
		}
		return startPoint + fVector * (num / num2);
	}

	public static FVector2D ClosestPointOnSegment2D(FVector2D point, FVector2D startPoint, FVector2D endPoint)
	{
		FVector2D fVector2D = endPoint - startPoint;
		double num = FVector2D.DotProduct(point - startPoint, fVector2D);
		if (num <= 0.0)
		{
			return startPoint;
		}
		double num2 = FVector2D.DotProduct(fVector2D, fVector2D);
		if (num2 <= num)
		{
			return endPoint;
		}
		return startPoint + fVector2D * (num / num2);
	}

	public static double PointDistToSegment(FVector point, FVector startPoint, FVector endPoint)
	{
		FVector fVector = ClosestPointOnSegment(point, startPoint, endPoint);
		return (point - fVector).Size();
	}

	public static double PointDistToSegmentSquared(FVector point, FVector startPoint, FVector endPoint)
	{
		FVector fVector = ClosestPointOnSegment(point, startPoint, endPoint);
		return (point - fVector).SizeSquared();
	}

	public static void SegmentDistToSegment(FVector a1, FVector b1, FVector a2, FVector b2, out FVector p1, out FVector p2)
	{
		new SegmentDistToSegment_Solver(ref a1, ref b1, ref a2, ref b2).Solve(out p1, out p2);
	}

	public static void SegmentDistToSegmentSafe(FVector a1, FVector b1, FVector a2, FVector b2, out FVector p1, out FVector p2)
	{
		SegmentDistToSegment_Solver segmentDistToSegment_Solver = new SegmentDistToSegment_Solver(ref a1, ref b1, ref a2, ref b2);
		FVector safeNormal = segmentDistToSegment_Solver.S1.GetSafeNormal();
		FVector safeNormal2 = segmentDistToSegment_Solver.S2.GetSafeNormal();
		bool flag = safeNormal.IsZero();
		bool flag2 = safeNormal2.IsZero();
		if (flag && flag2)
		{
			p1 = a1;
			p2 = a2;
			return;
		}
		if (flag2)
		{
			p1 = ClosestPointOnSegment(a2, a1, b1);
			p2 = a2;
			return;
		}
		if (flag)
		{
			p1 = a1;
			p2 = ClosestPointOnSegment(a1, a2, b2);
			return;
		}
		double num = safeNormal | safeNormal;
		double num2 = safeNormal2 | safeNormal2;
		double num3 = safeNormal | safeNormal2;
		double num4 = num * num2 - num3 * num3;
		segmentDistToSegment_Solver.LinesAreNearlyParallel = num4 < 9.999999747378752E-05;
		segmentDistToSegment_Solver.Solve(out p1, out p2);
	}

	public static double GetTForSegmentPlaneIntersect(FVector startPoint, FVector endPoint, FPlane plane)
	{
		return (plane.W - (double)(startPoint | plane)) / (double)((endPoint - startPoint) | plane);
	}

	public static bool SegmentPlaneIntersection(FVector startPoint, FVector endPoint, FPlane plane, out FVector intersectionPoint)
	{
		double tForSegmentPlaneIntersect = GetTForSegmentPlaneIntersect(startPoint, endPoint, plane);
		if (tForSegmentPlaneIntersect > -9.999999747378752E-05 && tForSegmentPlaneIntersect < 1.000100016593933)
		{
			intersectionPoint = startPoint + tForSegmentPlaneIntersect * (endPoint - startPoint);
			return true;
		}
		intersectionPoint = default(FVector);
		return false;
	}

	public static bool SegmentTriangleIntersection(FVector startPoint, FVector endPoint, FVector a, FVector b, FVector c, out FVector intersectPoint, out FVector triangleNormal)
	{
		FVector fVector = a - b;
		FVector fVector2 = b - c;
		FVector fVector3 = fVector ^ fVector2;
		if (!SegmentPlaneIntersection(startPoint, endPoint, new FPlane(a, fVector3), out intersectPoint))
		{
			triangleNormal = default(FVector);
			return false;
		}
		FVector fVector4 = ComputeBaryCentric2D(intersectPoint, a, b, c);
		if (fVector4.X > 0f && fVector4.Y > 0f && fVector4.Z > 0f)
		{
			triangleNormal = fVector3;
			return true;
		}
		triangleNormal = default(FVector);
		return false;
	}

	public static bool SegmentIntersection2D(FVector segmentStartA, FVector segmentEndA, FVector segmentStartB, FVector segmentEndB, out FVector intersectionPoint)
	{
		FVector fVector = segmentEndA - segmentStartA;
		FVector fVector2 = segmentEndB - segmentStartB;
		float num = ((0f - fVector.Y) * (segmentStartA.X - segmentStartB.X) + fVector.X * (segmentStartA.Y - segmentStartB.Y)) / ((0f - fVector2.X) * fVector.Y + fVector.X * fVector2.Y);
		float num2 = (fVector2.X * (segmentStartA.Y - segmentStartB.Y) - fVector2.Y * (segmentStartA.X - segmentStartB.X)) / ((0f - fVector2.X) * fVector.Y + fVector.X * fVector2.Y);
		bool num3 = num >= 0f && num <= 1f && num2 >= 0f && num2 <= 1f;
		intersectionPoint = default(FVector);
		if (num3)
		{
			intersectionPoint.X = segmentStartA.X + num2 * fVector.X;
			intersectionPoint.Y = segmentStartA.Y + num2 * fVector.Y;
			intersectionPoint.Z = segmentStartA.Z + num2 * fVector.Z;
		}
		return num3;
	}

	public static FVector ClosestPointOnTriangleToPoint(FVector point, FVector a, FVector b, FVector c)
	{
		FVector fVector = a - b;
		FVector fVector2 = c - a;
		FVector fVector3 = b - c;
		FVector fVector4 = fVector ^ fVector3;
		FPlane[] array = new FPlane[3]
		{
			new FPlane(b, fVector4 ^ fVector),
			new FPlane(a, fVector4 ^ fVector2),
			new FPlane(c, fVector4 ^ fVector3)
		};
		int num = 0;
		for (int i = 0; i < 3; i++)
		{
			if (array[i].PlaneDot(point) > 0.0)
			{
				num |= 1 << i;
			}
		}
		FVector result = new FVector(point.X, point.Y, point.Z);
		switch (num)
		{
		case 0:
			return FVector.PointPlaneProject(point, a, b, c);
		case 1:
			return ClosestPointOnSegment(point, b, a);
		case 2:
			return ClosestPointOnSegment(point, a, c);
		case 3:
			return a;
		case 4:
			return ClosestPointOnSegment(point, b, c);
		case 5:
			return b;
		case 6:
			return c;
		default:
			FMessage.Log("LogUnrealMath", ELogVerbosity.Log, "Impossible result in FMath::ClosestPointOnTriangleToPoint");
			return result;
		}
	}

	public static FVector ClosestPointOnTetrahedronToPoint(FVector point, FVector a, FVector b, FVector c, FVector d)
	{
		FVector fVector = c;
		FVector fVector2 = d;
		if (new FPlane(a, b, c).PlaneDot(d) < 0.0)
		{
			fVector = d;
			fVector2 = c;
		}
		FPlane[] array = new FPlane[4]
		{
			new FPlane(fVector2, fVector, a),
			new FPlane(fVector2, b, fVector),
			new FPlane(fVector2, a, b),
			new FPlane(a, fVector, b)
		};
		int num = 0;
		for (int i = 0; i < 4; i++)
		{
			if (array[i].PlaneDot(point) > 0.0)
			{
				num |= 1 << i;
			}
		}
		FVector result = new FVector(point.X, point.Y, point.Z);
		switch (num)
		{
		case 1:
			return ClosestPointOnTriangleToPoint(point, fVector2, fVector, a);
		case 2:
			return ClosestPointOnTriangleToPoint(point, fVector2, b, fVector);
		case 3:
			return ClosestPointOnSegment(point, fVector2, fVector);
		case 4:
			return ClosestPointOnTriangleToPoint(point, fVector2, a, b);
		case 5:
			return ClosestPointOnSegment(point, fVector2, a);
		case 6:
			return ClosestPointOnSegment(point, fVector2, b);
		case 7:
			return fVector2;
		case 8:
			return ClosestPointOnTriangleToPoint(point, a, fVector, b);
		case 9:
			return ClosestPointOnSegment(point, a, fVector);
		case 10:
			return ClosestPointOnSegment(point, b, fVector);
		case 11:
			return fVector;
		case 12:
			return ClosestPointOnSegment(point, b, a);
		case 13:
			return a;
		case 14:
			return b;
		default:
			FMessage.Log("LogUnrealMath", ELogVerbosity.Log, "FMath::ClosestPointOnTetrahedronToPoint() : impossible result");
			break;
		case 0:
			break;
		}
		return result;
	}

	public static void SphereDistToLine(FVector sphereOrigin, float sphereRadius, FVector lineOrigin, FVector normalizedLineDir, out FVector closestPoint)
	{
		FVector fVector = sphereOrigin - lineOrigin;
		double num = -2.0 * (double)(normalizedLineDir | fVector);
		double num2 = fVector.SizeSquared() - (double)Square(sphereRadius);
		double num3 = Square(num) - 4.0 * num2;
		if (num3 <= 9.999999747378752E-05)
		{
			FVector fVector2 = lineOrigin + (0.0 - num) * 0.5 * normalizedLineDir;
			closestPoint = sphereOrigin + (fVector2 - sphereOrigin).GetSafeNormal() * sphereRadius;
			return;
		}
		double num4 = Sqrt(num3);
		double num5 = (0.0 - num + num4) * 0.5;
		double num6 = (0.0 - num - num4) * 0.5;
		double num7 = ((Abs(num5) == Abs(num6)) ? Abs(num5) : ((Abs(num5) < Abs(num6)) ? num5 : num6));
		closestPoint = lineOrigin + num7 * normalizedLineDir;
	}

	public static bool GetDistanceWithinConeSegment(FVector point, FVector coneStartPoint, FVector coneLine, float radiusAtStart, float radiusAtEnd, out float percentage)
	{
		FVector closestPoint;
		double num = PointDistToLine(point, coneLine, coneStartPoint, out closestPoint);
		percentage = 0f;
		FVector fVector = coneStartPoint - closestPoint;
		FVector fVector2 = coneStartPoint + coneLine - closestPoint;
		double num2 = coneLine.SizeSquared();
		double num3 = fVector.SizeSquared();
		double num4 = fVector2.SizeSquared();
		if (num3 > num2 || num4 > num2)
		{
			return false;
		}
		double num5 = Sqrt(num3) / Sqrt(num2);
		double num6 = (double)radiusAtStart + (double)(radiusAtEnd - radiusAtStart) * num5;
		if (num > num6)
		{
			return false;
		}
		percentage = (float)((num6 > 0.0) ? ((num6 - num) / num6) : 1.0);
		return true;
	}

	public static bool PointsAreCoplanar(FVector[] points, float tolerance = 0.1f)
	{
		if (points.Length < 4)
		{
			return true;
		}
		FVector safeNormal = FVector.CrossProduct(points[2] - points[0], points[1] - points[0]).GetSafeNormal();
		int num = points.Length;
		for (int i = 3; i < num; i++)
		{
			if (Abs(FVector.PointPlaneDist(points[i], points[0], safeNormal)) > (double)tolerance)
			{
				return false;
			}
		}
		return true;
	}

	public static bool IsWithin(sbyte testValue, sbyte minValue, sbyte maxValue)
	{
		if (testValue >= minValue)
		{
			return testValue < maxValue;
		}
		return false;
	}

	public static bool IsWithin(byte testValue, byte minValue, byte maxValue)
	{
		if (testValue >= minValue)
		{
			return testValue < maxValue;
		}
		return false;
	}

	public static bool IsWithin(short testValue, short minValue, short maxValue)
	{
		if (testValue >= minValue)
		{
			return testValue < maxValue;
		}
		return false;
	}

	public static bool IsWithin(ushort testValue, ushort minValue, ushort maxValue)
	{
		if (testValue >= minValue)
		{
			return testValue < maxValue;
		}
		return false;
	}

	public static bool IsWithin(int testValue, int minValue, int maxValue)
	{
		if (testValue >= minValue)
		{
			return testValue < maxValue;
		}
		return false;
	}

	public static bool IsWithin(uint testValue, uint minValue, uint maxValue)
	{
		if (testValue >= minValue)
		{
			return testValue < maxValue;
		}
		return false;
	}

	public static bool IsWithin(long testValue, long minValue, long maxValue)
	{
		if (testValue >= minValue)
		{
			return testValue < maxValue;
		}
		return false;
	}

	public static bool IsWithin(ulong testValue, ulong minValue, ulong maxValue)
	{
		if (testValue >= minValue)
		{
			return testValue < maxValue;
		}
		return false;
	}

	public static bool IsWithin(float testValue, float minValue, float maxValue)
	{
		if (testValue >= minValue)
		{
			return testValue < maxValue;
		}
		return false;
	}

	public static bool IsWithin(double testValue, double minValue, double maxValue)
	{
		if (testValue >= minValue)
		{
			return testValue < maxValue;
		}
		return false;
	}

	public static bool IsWithin(decimal testValue, decimal minValue, decimal maxValue)
	{
		if (testValue >= minValue)
		{
			return testValue < maxValue;
		}
		return false;
	}

	public static bool IsWithinInclusive(sbyte testValue, sbyte minValue, sbyte maxValue)
	{
		if (testValue >= minValue)
		{
			return testValue <= maxValue;
		}
		return false;
	}

	public static bool IsWithinInclusive(byte testValue, byte minValue, byte maxValue)
	{
		if (testValue >= minValue)
		{
			return testValue <= maxValue;
		}
		return false;
	}

	public static bool IsWithinInclusive(short testValue, short minValue, short maxValue)
	{
		if (testValue >= minValue)
		{
			return testValue <= maxValue;
		}
		return false;
	}

	public static bool IsWithinInclusive(ushort testValue, ushort minValue, ushort maxValue)
	{
		if (testValue >= minValue)
		{
			return testValue <= maxValue;
		}
		return false;
	}

	public static bool IsWithinInclusive(int testValue, int minValue, int maxValue)
	{
		if (testValue >= minValue)
		{
			return testValue <= maxValue;
		}
		return false;
	}

	public static bool IsWithinInclusive(uint testValue, uint minValue, uint maxValue)
	{
		if (testValue >= minValue)
		{
			return testValue <= maxValue;
		}
		return false;
	}

	public static bool IsWithinInclusive(long testValue, long minValue, long maxValue)
	{
		if (testValue >= minValue)
		{
			return testValue <= maxValue;
		}
		return false;
	}

	public static bool IsWithinInclusive(ulong testValue, ulong minValue, ulong maxValue)
	{
		if (testValue >= minValue)
		{
			return testValue <= maxValue;
		}
		return false;
	}

	public static bool IsWithinInclusive(float testValue, float minValue, float maxValue)
	{
		if (testValue >= minValue)
		{
			return testValue <= maxValue;
		}
		return false;
	}

	public static bool IsWithinInclusive(double testValue, double minValue, double maxValue)
	{
		if (testValue >= minValue)
		{
			return testValue <= maxValue;
		}
		return false;
	}

	public static bool IsWithinInclusive(decimal testValue, decimal minValue, decimal maxValue)
	{
		if (testValue >= minValue)
		{
			return testValue <= maxValue;
		}
		return false;
	}

	public static bool IsPowerOfTwo(byte value)
	{
		return (value & (value - 1)) == 0;
	}

	public static bool IsPowerOfTwo(short value)
	{
		return (value & (value - 1)) == 0;
	}

	public static bool IsPowerOfTwo(ushort value)
	{
		return (value & (value - 1)) == 0;
	}

	public static bool IsPowerOfTwo(int value)
	{
		return (value & (value - 1)) == 0;
	}

	public static bool IsPowerOfTwo(uint value)
	{
		return (value & (value - 1)) == 0;
	}

	public static bool IsPowerOfTwo(long value)
	{
		return (value & (value - 1)) == 0;
	}

	public static bool IsPowerOfTwo(ulong value)
	{
		return (value & (value - 1)) == 0;
	}

	public static bool IsPowerOfTwo(float value)
	{
		return IsPowerOfTwo((int)value);
	}

	public static bool IsPowerOfTwo(double value)
	{
		return IsPowerOfTwo((long)value);
	}

	public static bool IsPowerOfTwo(decimal value)
	{
		return IsPowerOfTwo((long)value);
	}

	public static sbyte Max3(sbyte val1, sbyte val2, sbyte val3)
	{
		return Math.Max(Math.Max(val1, val2), val3);
	}

	public static byte Max3(byte val1, byte val2, byte val3)
	{
		return Math.Max(Math.Max(val1, val2), val3);
	}

	public static short Max3(short val1, short val2, short val3)
	{
		return Math.Max(Math.Max(val1, val2), val3);
	}

	public static ushort Max3(ushort val1, ushort val2, ushort val3)
	{
		return Math.Max(Math.Max(val1, val2), val3);
	}

	public static int Max3(int val1, int val2, int val3)
	{
		return Math.Max(Math.Max(val1, val2), val3);
	}

	public static uint Max3(uint val1, uint val2, uint val3)
	{
		return Math.Max(Math.Max(val1, val2), val3);
	}

	public static long Max3(long val1, long val2, long val3)
	{
		return Math.Max(Math.Max(val1, val2), val3);
	}

	public static ulong Max3(ulong val1, ulong val2, ulong val3)
	{
		return Math.Max(Math.Max(val1, val2), val3);
	}

	public static float Max3(float val1, float val2, float val3)
	{
		return Math.Max(Math.Max(val1, val2), val3);
	}

	public static double Max3(double val1, double val2, double val3)
	{
		return Math.Max(Math.Max(val1, val2), val3);
	}

	public static decimal Max3(decimal val1, decimal val2, decimal val3)
	{
		return Math.Max(Math.Max(val1, val2), val3);
	}

	public static sbyte Min3(sbyte val1, sbyte val2, sbyte val3)
	{
		return Math.Min(Math.Min(val1, val2), val3);
	}

	public static byte Min3(byte val1, byte val2, byte val3)
	{
		return Math.Min(Math.Min(val1, val2), val3);
	}

	public static short Min3(short val1, short val2, short val3)
	{
		return Math.Min(Math.Min(val1, val2), val3);
	}

	public static ushort Min3(ushort val1, ushort val2, ushort val3)
	{
		return Math.Min(Math.Min(val1, val2), val3);
	}

	public static int Min3(int val1, int val2, int val3)
	{
		return Math.Min(Math.Min(val1, val2), val3);
	}

	public static uint Min3(uint val1, uint val2, uint val3)
	{
		return Math.Min(Math.Min(val1, val2), val3);
	}

	public static long Min3(long val1, long val2, long val3)
	{
		return Math.Min(Math.Min(val1, val2), val3);
	}

	public static ulong Min3(ulong val1, ulong val2, ulong val3)
	{
		return Math.Min(Math.Min(val1, val2), val3);
	}

	public static float Min3(float val1, float val2, float val3)
	{
		return Math.Min(Math.Min(val1, val2), val3);
	}

	public static double Min3(double val1, double val2, double val3)
	{
		return Math.Min(Math.Min(val1, val2), val3);
	}

	public static decimal Min3(decimal val1, decimal val2, decimal val3)
	{
		return Math.Min(Math.Min(val1, val2), val3);
	}

	public static int Square(sbyte value)
	{
		return value * value;
	}

	public static int Square(byte value)
	{
		return value * value;
	}

	public static int Square(short value)
	{
		return value * value;
	}

	public static int Square(ushort value)
	{
		return value * value;
	}

	public static int Square(int value)
	{
		return value * value;
	}

	public static uint Square(uint value)
	{
		return value * value;
	}

	public static long Square(long value)
	{
		return value * value;
	}

	public static ulong Square(ulong value)
	{
		return value * value;
	}

	public static float Square(float value)
	{
		return value * value;
	}

	public static double Square(double value)
	{
		return value * value;
	}

	public static decimal Square(decimal value)
	{
		return value * value;
	}

	public static sbyte Clamp(sbyte x, sbyte min, sbyte max)
	{
		if (x >= min)
		{
			if (x >= max)
			{
				return max;
			}
			return x;
		}
		return min;
	}

	public static byte Clamp(byte x, byte min, byte max)
	{
		if (x >= min)
		{
			if (x >= max)
			{
				return max;
			}
			return x;
		}
		return min;
	}

	public static short Clamp(short x, short min, short max)
	{
		if (x >= min)
		{
			if (x >= max)
			{
				return max;
			}
			return x;
		}
		return min;
	}

	public static ushort Clamp(ushort x, ushort min, ushort max)
	{
		if (x >= min)
		{
			if (x >= max)
			{
				return max;
			}
			return x;
		}
		return min;
	}

	public static int Clamp(int x, int min, int max)
	{
		if (x >= min)
		{
			if (x >= max)
			{
				return max;
			}
			return x;
		}
		return min;
	}

	public static uint Clamp(uint x, uint min, uint max)
	{
		if (x >= min)
		{
			if (x >= max)
			{
				return max;
			}
			return x;
		}
		return min;
	}

	public static long Clamp(long x, long min, long max)
	{
		if (x >= min)
		{
			if (x >= max)
			{
				return max;
			}
			return x;
		}
		return min;
	}

	public static ulong Clamp(ulong x, ulong min, ulong max)
	{
		if (x >= min)
		{
			if (x >= max)
			{
				return max;
			}
			return x;
		}
		return min;
	}

	public static float Clamp(float x, float min, float max)
	{
		if (!(x < min))
		{
			if (!(x < max))
			{
				return max;
			}
			return x;
		}
		return min;
	}

	public static double Clamp(double x, double min, double max)
	{
		if (!(x < min))
		{
			if (!(x < max))
			{
				return max;
			}
			return x;
		}
		return min;
	}

	public static decimal Clamp(decimal x, decimal min, decimal max)
	{
		if (!(x < min))
		{
			if (!(x < max))
			{
				return max;
			}
			return x;
		}
		return min;
	}

	public static int DivideAndRoundUp(int dividend, int divisor)
	{
		return (dividend + divisor - 1) / divisor;
	}

	public static uint DivideAndRoundUp(uint dividend, uint divisor)
	{
		return (dividend + divisor - 1) / divisor;
	}

	public static long DivideAndRoundUp(long dividend, long divisor)
	{
		return (dividend + divisor - 1) / divisor;
	}

	public static ulong DivideAndRoundUp(ulong dividend, ulong divisor)
	{
		return (dividend + divisor - 1) / divisor;
	}

	public static int DivideAndRoundDown(int dividend, int divisor)
	{
		return dividend / divisor;
	}

	public static uint DivideAndRoundDown(uint dividend, uint divisor)
	{
		return dividend / divisor;
	}

	public static long DivideAndRoundDown(long dividend, long divisor)
	{
		return dividend / divisor;
	}

	public static ulong DivideAndRoundDown(ulong dividend, ulong divisor)
	{
		return dividend / divisor;
	}

	public static int DivideAndRoundNearest(int dividend, int divisor)
	{
		if (dividend < 0)
		{
			return (dividend - divisor / 2 + 1) / divisor;
		}
		return (dividend + divisor / 2) / divisor;
	}

	public static uint DivideAndRoundNearest(uint dividend, uint divisor)
	{
		if (dividend < 0)
		{
			return (dividend - divisor / 2 + 1) / divisor;
		}
		return (dividend + divisor / 2) / divisor;
	}

	public static long DivideAndRoundNearest(long dividend, long divisor)
	{
		if (dividend < 0)
		{
			return (dividend - divisor / 2 + 1) / divisor;
		}
		return (dividend + divisor / 2) / divisor;
	}

	public static ulong DivideAndRoundNearest(ulong dividend, ulong divisor)
	{
		if (dividend < 0)
		{
			return (dividend - divisor / 2 + 1) / divisor;
		}
		return (dividend + divisor / 2) / divisor;
	}

	public static float RadiansToDegrees(float radVal)
	{
		return radVal * (180f / (float)Math.PI);
	}

	public static double RadiansToDegrees(double radVal)
	{
		return radVal * 57.2957763671875;
	}

	public static float DegreesToRadians(float degVal)
	{
		return degVal * ((float)Math.PI / 180f);
	}

	public static double DegreesToRadians(double degVal)
	{
		return degVal * 0.01745329238474369;
	}
}
