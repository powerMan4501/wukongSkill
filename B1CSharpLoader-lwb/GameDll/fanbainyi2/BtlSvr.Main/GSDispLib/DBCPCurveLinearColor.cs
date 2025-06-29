using System;
using System.Collections.Generic;
using b1;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class DBCPCurveLinearColor
{
	protected struct RuntimeColorPCurvePoint
	{
		public readonly DispLibDBCPCurvePointColorMode Mode;

		public readonly float Time;

		public readonly FLinearColor Value;

		public FLinearColor CurFrameBakedValue;

		public readonly float DurationToPrePoint;

		public RuntimeColorPCurvePoint(DispLibDBCPCurvePointColorMode _Mode, float _Time, FLinearColor _Value, float _DurationToPrePoint)
		{
			Mode = _Mode;
			Time = _Time;
			Value = _Value;
			CurFrameBakedValue = _Value;
			DurationToPrePoint = _DurationToPrePoint;
		}
	}

	protected BUC_DispLibUtil_DBCPCurveColor SourceStruct;

	protected RuntimeColorPCurvePoint[] RuntimePointArray;

	protected RuntimeColorPCurvePoint RuntimeEndToPoint;

	public bool InitOver { get; protected set; }

	public bool HasExternalDependencyData { get; protected set; }

	public bool ExternalDependencyDataIsReady { get; protected set; }

	public float Period { get; protected set; }

	public float LoopAge { get; protected set; }

	public float Age { get; protected set; }

	public FLinearColor CurFrameValue { get; protected set; }

	public int StdStage_FirstPointIndex { get; protected set; }

	public int StdStage_SecondPointIndex { get; protected set; }

	public bool isEndStage { get; protected set; }

	public bool EventRealEnd { get; protected set; }

	public bool ParentEventRealEnd { get; protected set; }

	public float StdStage_NormalizedTimeProgress { get; protected set; }

	public FLinearColor ValueOnEndStageBegin { get; protected set; }

	public DBCPCurveLinearColor(BUC_DispLibUtil_DBCPCurveColor _SourcePCurveStruct, DBCAsyncExternalDependencyMode _ExternalDependencyMode, FLinearColor _ParamCurValue, FLinearColor _ParamInitialValue, float StartAge = 0f)
	{
		Init(_SourcePCurveStruct, _ExternalDependencyMode, _ParamCurValue, _ParamInitialValue, StartAge);
	}

	public DBCPCurveLinearColor(BUC_DispLibUtil_DBCPCurveColor _SourcePCurveStruct, float StartAge = 0f)
	{
		Init(_SourcePCurveStruct, DBCAsyncExternalDependencyMode.NotCare, FLinearColor.White, FLinearColor.White, StartAge);
	}

	protected virtual bool SetExternalDependencyData(FLinearColor ParamCurValue, FLinearColor ParamInitialValue, DBCAsyncExternalDependencyMode ExternalDependencyMode = DBCAsyncExternalDependencyMode.Ready)
	{
		if (!InitOver)
		{
			return false;
		}
		if (!HasExternalDependencyData)
		{
			return true;
		}
		ExternalDependencyDataIsReady = !HasExternalDependencyData || ExternalDependencyMode != DBCAsyncExternalDependencyMode.WaitUtilReady;
		for (int i = 0; i < RuntimePointArray.Length; i++)
		{
			switch (RuntimePointArray[i].Mode)
			{
			case DispLibDBCPCurvePointColorMode.CacheCurValue:
				RuntimePointArray[i] = new RuntimeColorPCurvePoint(RuntimePointArray[i].Mode, RuntimePointArray[i].Time, ParamCurValue, RuntimePointArray[i].DurationToPrePoint);
				break;
			case DispLibDBCPCurvePointColorMode.ParamInitialValue:
				RuntimePointArray[i] = new RuntimeColorPCurvePoint(RuntimePointArray[i].Mode, RuntimePointArray[i].Time, ParamInitialValue, RuntimePointArray[i].DurationToPrePoint);
				break;
			}
		}
		switch (RuntimeEndToPoint.Mode)
		{
		case DispLibDBCPCurvePointColorMode.CacheCurValue:
			RuntimeEndToPoint = new RuntimeColorPCurvePoint(RuntimeEndToPoint.Mode, RuntimeEndToPoint.Time, ParamCurValue, RuntimeEndToPoint.DurationToPrePoint);
			break;
		case DispLibDBCPCurvePointColorMode.ParamInitialValue:
			RuntimeEndToPoint = new RuntimeColorPCurvePoint(RuntimeEndToPoint.Mode, RuntimeEndToPoint.Time, ParamInitialValue, RuntimeEndToPoint.DurationToPrePoint);
			break;
		}
		return true;
	}

	protected virtual void Init(BUC_DispLibUtil_DBCPCurveColor _SourcePCurveStruct, DBCAsyncExternalDependencyMode _ExternalDependencyMode, FLinearColor _ParamCurValue, FLinearColor _ParamInitialValue, float StartAge)
	{
		InitOver = false;
		SourceStruct = _SourcePCurveStruct;
		Age = Math.Max(0f, StartAge);
		LoopAge = Age;
		if (SourceStruct.Loop)
		{
			LoopAge %= Period;
		}
		List<OnePCurveColorPoint> pointsList = SourceStruct.PointsList;
		if (pointsList.Count == 0)
		{
			return;
		}
		RuntimePointArray = new RuntimeColorPCurvePoint[pointsList.Count];
		for (int i = 0; i < pointsList.Count; i++)
		{
			OnePCurveColorPoint onePCurveColorPoint = pointsList[i];
			HasExternalDependencyData = HasExternalDependencyData || onePCurveColorPoint.Mode == DispLibDBCPCurvePointColorMode.ParamInitialValue || onePCurveColorPoint.Mode == DispLibDBCPCurvePointColorMode.CacheCurValue;
			float num = ((i != 0) ? onePCurveColorPoint.DurationToPrePoint : 0f);
			Period += num;
			FLinearColor value;
			switch (onePCurveColorPoint.Mode)
			{
			case DispLibDBCPCurvePointColorMode.OnSpawn_ValueMultiplyRandom_0_1:
				value = onePCurveColorPoint.Value;
				value.A *= FMath.FRand();
				break;
			case DispLibDBCPCurvePointColorMode.OnSpawn_ValueMultiplyRandom_N1_1:
				value = onePCurveColorPoint.Value;
				value.A *= FMath.RandRange(-1, 1);
				break;
			case DispLibDBCPCurvePointColorMode.CacheCurValue:
				value = _ParamCurValue;
				break;
			case DispLibDBCPCurvePointColorMode.ParamInitialValue:
				value = _ParamInitialValue;
				break;
			case DispLibDBCPCurvePointColorMode.ValueMultiplyRandom_0_1:
				value = onePCurveColorPoint.Value;
				break;
			case DispLibDBCPCurvePointColorMode.ValueMultiplyRandom_N1_1:
				value = onePCurveColorPoint.Value;
				break;
			default:
				value = onePCurveColorPoint.Value;
				break;
			}
			RuntimePointArray[i] = new RuntimeColorPCurvePoint(onePCurveColorPoint.Mode, Period, value, num);
		}
		HasExternalDependencyData = HasExternalDependencyData || SourceStruct.EndToPoint.Mode == DispLibDBCPCurvePointColorMode.ParamInitialValue || SourceStruct.EndToPoint.Mode == DispLibDBCPCurvePointColorMode.CacheCurValue;
		FLinearColor value2;
		switch (SourceStruct.EndToPoint.Mode)
		{
		case DispLibDBCPCurvePointColorMode.OnSpawn_ValueMultiplyRandom_0_1:
			value2 = SourceStruct.EndToPoint.Value;
			value2.A *= FMath.FRand();
			break;
		case DispLibDBCPCurvePointColorMode.OnSpawn_ValueMultiplyRandom_N1_1:
			value2 = SourceStruct.EndToPoint.Value;
			value2.A *= FMath.RandRange(-1, 1);
			break;
		case DispLibDBCPCurvePointColorMode.CacheCurValue:
			value2 = _ParamCurValue;
			break;
		case DispLibDBCPCurvePointColorMode.ParamInitialValue:
			value2 = _ParamInitialValue;
			break;
		case DispLibDBCPCurvePointColorMode.ValueMultiplyRandom_0_1:
			value2 = SourceStruct.EndToPoint.Value;
			break;
		case DispLibDBCPCurvePointColorMode.ValueMultiplyRandom_N1_1:
			value2 = SourceStruct.EndToPoint.Value;
			break;
		default:
			value2 = SourceStruct.EndToPoint.Value;
			break;
		}
		RuntimeEndToPoint = new RuntimeColorPCurvePoint(SourceStruct.EndToPoint.Mode, 0f, value2, SourceStruct.EndToPoint.DurationToPrePoint);
		switch (RuntimePointArray[0].Mode)
		{
		case DispLibDBCPCurvePointColorMode.OnSpawn_ValueMultiplyRandom_0_1:
			CurFrameValue = RuntimePointArray[0].Value;
			break;
		case DispLibDBCPCurvePointColorMode.OnSpawn_ValueMultiplyRandom_N1_1:
			CurFrameValue = RuntimePointArray[0].Value;
			break;
		case DispLibDBCPCurvePointColorMode.ValueMultiplyRandom_0_1:
		{
			FLinearColor value4 = RuntimePointArray[0].Value;
			value4.A *= FMath.FRand();
			CurFrameValue = value4;
			break;
		}
		case DispLibDBCPCurvePointColorMode.ValueMultiplyRandom_N1_1:
		{
			FLinearColor value3 = RuntimePointArray[0].Value;
			value3.A *= FMath.RandRange(-1, 1);
			CurFrameValue = value3;
			break;
		}
		default:
			CurFrameValue = RuntimePointArray[0].Value;
			break;
		}
		InitOver = true;
		UpdateValue(0f, 0f);
		ExternalDependencyDataIsReady = !HasExternalDependencyData || _ExternalDependencyMode != DBCAsyncExternalDependencyMode.WaitUtilReady;
	}

	public virtual void SetEnd()
	{
		if (!isEndStage)
		{
			isEndStage = true;
			ValueOnEndStageBegin = CurFrameValue;
			LoopAge = 0f;
		}
	}

	public virtual void OnParentEventRealEnd()
	{
		ParentEventRealEnd = true;
	}

	protected virtual void UpdateEndStage()
	{
		ValueOnEndStageBegin = FLinearColor.Lerp(RuntimePointArray[StdStage_FirstPointIndex].CurFrameBakedValue, RuntimePointArray[StdStage_SecondPointIndex].CurFrameBakedValue, StdStage_NormalizedTimeProgress);
		FLinearColor value;
		switch (RuntimeEndToPoint.Mode)
		{
		case DispLibDBCPCurvePointColorMode.ValueMultiplyRandom_0_1:
			value = RuntimeEndToPoint.Value;
			value.A *= FMath.FRand();
			RuntimeEndToPoint.CurFrameBakedValue = value;
			break;
		case DispLibDBCPCurvePointColorMode.ValueMultiplyRandom_N1_1:
			value = RuntimeEndToPoint.Value;
			value.A *= FMath.RandRange(-1f, 1f);
			RuntimeEndToPoint.CurFrameBakedValue = value;
			break;
		default:
			value = RuntimeEndToPoint.Value;
			break;
		}
		float durationToPrePoint = RuntimeEndToPoint.DurationToPrePoint;
		if (durationToPrePoint < 0f)
		{
			CurFrameValue = ValueOnEndStageBegin;
			return;
		}
		if (durationToPrePoint == 0f)
		{
			CurFrameValue = value;
			switch (SourceStruct.ReleaseParameterControlMode)
			{
			case DispLibDBCAdvProcessReleaseParameterControlMode.OnEventRealEnd:
				if (ParentEventRealEnd)
				{
					EventRealEnd = true;
				}
				break;
			case DispLibDBCAdvProcessReleaseParameterControlMode.OnParamSelfEndStageOver:
				EventRealEnd = true;
				break;
			}
			return;
		}
		CurFrameValue = FLinearColor.Lerp(ValueOnEndStageBegin, value, MathLib.Clamp(LoopAge / durationToPrePoint, 0f, 1f));
		switch (SourceStruct.ReleaseParameterControlMode)
		{
		case DispLibDBCAdvProcessReleaseParameterControlMode.OnEventRealEnd:
			if (ParentEventRealEnd)
			{
				EventRealEnd = true;
			}
			break;
		case DispLibDBCAdvProcessReleaseParameterControlMode.OnParamSelfEndStageOver:
			if (LoopAge >= durationToPrePoint)
			{
				EventRealEnd = true;
			}
			break;
		}
	}

	protected virtual void UpdateMainStage()
	{
		float num = Age;
		if (SourceStruct.Loop)
		{
			LoopAge = ((LoopAge > Period) ? 0f : LoopAge);
			num = LoopAge;
		}
		if (num >= Period)
		{
			int num2 = Math.Max(0, RuntimePointArray.Length - 1);
			StdStage_FirstPointIndex = Math.Max(0, num2 - 1);
			StdStage_SecondPointIndex = num2;
		}
		else
		{
			for (int i = 1; i < RuntimePointArray.Length; i++)
			{
				if (num < RuntimePointArray[i].Time)
				{
					StdStage_FirstPointIndex = Math.Max(0, i - 1);
					StdStage_SecondPointIndex = i;
					break;
				}
			}
		}
		RuntimeColorPCurvePoint runtimeColorPCurvePoint = RuntimePointArray[StdStage_FirstPointIndex];
		RuntimeColorPCurvePoint runtimeColorPCurvePoint2 = RuntimePointArray[StdStage_SecondPointIndex];
		FLinearColor value;
		switch (runtimeColorPCurvePoint.Mode)
		{
		case DispLibDBCPCurvePointColorMode.ValueMultiplyRandom_0_1:
			value = runtimeColorPCurvePoint.Value;
			value.A *= FMath.FRand();
			RuntimePointArray[StdStage_FirstPointIndex].CurFrameBakedValue = value;
			break;
		case DispLibDBCPCurvePointColorMode.ValueMultiplyRandom_N1_1:
			value = runtimeColorPCurvePoint.Value;
			value.A *= FMath.RandRange(-1f, 1f);
			RuntimePointArray[StdStage_FirstPointIndex].CurFrameBakedValue = value;
			break;
		default:
			value = runtimeColorPCurvePoint.Value;
			break;
		}
		FLinearColor value2;
		switch (runtimeColorPCurvePoint2.Mode)
		{
		case DispLibDBCPCurvePointColorMode.ValueMultiplyRandom_0_1:
			value2 = runtimeColorPCurvePoint2.Value;
			value2.A *= FMath.FRand();
			RuntimePointArray[StdStage_SecondPointIndex].CurFrameBakedValue = value2;
			break;
		case DispLibDBCPCurvePointColorMode.ValueMultiplyRandom_N1_1:
			value2 = runtimeColorPCurvePoint2.Value;
			value2.A *= FMath.RandRange(-1f, 1f);
			RuntimePointArray[StdStage_SecondPointIndex].CurFrameBakedValue = value2;
			break;
		default:
			value2 = runtimeColorPCurvePoint2.Value;
			break;
		}
		if (runtimeColorPCurvePoint2.DurationToPrePoint == 0f)
		{
			StdStage_NormalizedTimeProgress = 1f;
			CurFrameValue = value2;
		}
		else
		{
			StdStage_NormalizedTimeProgress = MathLib.Clamp((num - runtimeColorPCurvePoint.Time) / runtimeColorPCurvePoint2.DurationToPrePoint, 0f, 1f);
			CurFrameValue = FLinearColor.Lerp(value, value2, StdStage_NormalizedTimeProgress);
		}
	}

	public virtual void UpdateValue(float DeltaTime, float VelocityLength)
	{
		if (InitOver)
		{
			Age += DeltaTime;
			LoopAge += DeltaTime;
			if (!isEndStage && SourceStruct.Duration > 0f && Age > SourceStruct.Duration)
			{
				SetEnd();
			}
			if (isEndStage)
			{
				UpdateEndStage();
			}
			else
			{
				UpdateMainStage();
			}
		}
	}
}
