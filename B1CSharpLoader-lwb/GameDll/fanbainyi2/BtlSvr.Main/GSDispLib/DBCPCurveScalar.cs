using System;
using System.Collections.Generic;
using b1;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class DBCPCurveScalar
{
	protected struct RuntimePCurvePoint
	{
		public readonly DispLibDBCPCurvePointScalarMode Mode;

		public readonly float Time;

		public readonly float Value;

		public float CurFrameBakedValue;

		public readonly float DurationToPrePoint;

		public RuntimePCurvePoint(DispLibDBCPCurvePointScalarMode _Mode, float _Time, float _Value, float _DurationToPrePoint)
		{
			Mode = _Mode;
			Time = _Time;
			Value = _Value;
			CurFrameBakedValue = _Value;
			DurationToPrePoint = _DurationToPrePoint;
		}
	}

	protected BUC_DispLibUtil_DBCPCurveScalar SourceStruct;

	protected RuntimePCurvePoint[] RuntimePointArray;

	protected RuntimePCurvePoint RuntimeEndToPoint;

	public bool InitOver { get; protected set; }

	public bool HasExternalDependencyData { get; protected set; }

	public bool ExternalDependencyDataIsReady { get; protected set; }

	public float Period { get; protected set; }

	public float LoopAge { get; protected set; }

	public float Age { get; protected set; }

	public float CurFrameValue { get; protected set; }

	public int StdStage_FirstPointIndex { get; protected set; }

	public int StdStage_SecondPointIndex { get; protected set; }

	public float StdStage_NormalizedTimeProgress { get; protected set; }

	public bool isEndStage { get; protected set; }

	public bool EventRealEnd { get; protected set; }

	public bool ParentEventRealEnd { get; protected set; }

	public float ValueOnEndStageBegin { get; protected set; }

	public DBCPCurveScalar(BUC_DispLibUtil_DBCPCurveScalar _SourcePCurveStruct, DBCAsyncExternalDependencyMode _ExternalDependencyMode, float _ParamCurValue, float _ParamInitialValue, float StartAge = 0f)
	{
		Init(_SourcePCurveStruct, _ExternalDependencyMode, _ParamCurValue, _ParamInitialValue, StartAge);
	}

	public DBCPCurveScalar(BUC_DispLibUtil_DBCPCurveScalar _SourcePCurveStruct, float StartAge = 0f)
	{
		Init(_SourcePCurveStruct, DBCAsyncExternalDependencyMode.NotCare, 0f, 0f, StartAge);
	}

	protected virtual bool SetExternalDependencyData(float ParamCurValue, float ParamInitialValue, DBCAsyncExternalDependencyMode ExternalDependencyMode = DBCAsyncExternalDependencyMode.Ready)
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
			case DispLibDBCPCurvePointScalarMode.CacheCurValue:
				RuntimePointArray[i] = new RuntimePCurvePoint(RuntimePointArray[i].Mode, RuntimePointArray[i].Time, ParamCurValue, RuntimePointArray[i].DurationToPrePoint);
				break;
			case DispLibDBCPCurvePointScalarMode.ParamInitialValue:
				RuntimePointArray[i] = new RuntimePCurvePoint(RuntimePointArray[i].Mode, RuntimePointArray[i].Time, ParamInitialValue, RuntimePointArray[i].DurationToPrePoint);
				break;
			}
		}
		switch (RuntimeEndToPoint.Mode)
		{
		case DispLibDBCPCurvePointScalarMode.CacheCurValue:
			RuntimeEndToPoint = new RuntimePCurvePoint(RuntimeEndToPoint.Mode, RuntimeEndToPoint.Time, ParamCurValue, RuntimeEndToPoint.DurationToPrePoint);
			break;
		case DispLibDBCPCurvePointScalarMode.ParamInitialValue:
			RuntimeEndToPoint = new RuntimePCurvePoint(RuntimeEndToPoint.Mode, RuntimeEndToPoint.Time, ParamInitialValue, RuntimeEndToPoint.DurationToPrePoint);
			break;
		}
		return true;
	}

	protected virtual void Init(BUC_DispLibUtil_DBCPCurveScalar _SourcePCurveStruct, DBCAsyncExternalDependencyMode _ExternalDependencyMode, float _ParamCurValue, float _ParamInitialValue, float StartAge)
	{
		InitOver = false;
		SourceStruct = _SourcePCurveStruct;
		ParentEventRealEnd = false;
		Age = Math.Max(0f, StartAge);
		LoopAge = Age;
		if (SourceStruct.Loop)
		{
			LoopAge %= Period;
		}
		List<OnePCurveScalarPoint> pointsList = SourceStruct.PointsList;
		if (pointsList.Count != 0)
		{
			RuntimePointArray = new RuntimePCurvePoint[pointsList.Count];
			for (int i = 0; i < pointsList.Count; i++)
			{
				OnePCurveScalarPoint onePCurveScalarPoint = pointsList[i];
				HasExternalDependencyData = HasExternalDependencyData || onePCurveScalarPoint.Mode == DispLibDBCPCurvePointScalarMode.ParamInitialValue || onePCurveScalarPoint.Mode == DispLibDBCPCurvePointScalarMode.CacheCurValue;
				float num = ((i != 0) ? onePCurveScalarPoint.DurationToPrePoint : 0f);
				Period += num;
				float value = onePCurveScalarPoint.Mode switch
				{
					DispLibDBCPCurvePointScalarMode.OnSpawn_ValueMultiplyRandom_0_1 => onePCurveScalarPoint.Value * FMath.FRand(), 
					DispLibDBCPCurvePointScalarMode.OnSpawn_ValueMultiplyRandom_N1_1 => onePCurveScalarPoint.Value * (float)FMath.RandRange(-1, 1), 
					DispLibDBCPCurvePointScalarMode.CacheCurValue => _ParamCurValue, 
					DispLibDBCPCurvePointScalarMode.ParamInitialValue => _ParamInitialValue, 
					DispLibDBCPCurvePointScalarMode.ValueMultiplyRandom_0_1 => onePCurveScalarPoint.Value, 
					DispLibDBCPCurvePointScalarMode.ValueMultiplyRandom_N1_1 => onePCurveScalarPoint.Value, 
					_ => onePCurveScalarPoint.Value, 
				};
				RuntimePointArray[i] = new RuntimePCurvePoint(onePCurveScalarPoint.Mode, Period, value, num);
			}
			HasExternalDependencyData = HasExternalDependencyData || SourceStruct.EndToPoint.Mode == DispLibDBCPCurvePointScalarMode.ParamInitialValue || SourceStruct.EndToPoint.Mode == DispLibDBCPCurvePointScalarMode.CacheCurValue;
			RuntimeEndToPoint = new RuntimePCurvePoint(_Value: SourceStruct.EndToPoint.Mode switch
			{
				DispLibDBCPCurvePointScalarMode.OnSpawn_ValueMultiplyRandom_0_1 => SourceStruct.EndToPoint.Value * FMath.FRand(), 
				DispLibDBCPCurvePointScalarMode.OnSpawn_ValueMultiplyRandom_N1_1 => SourceStruct.EndToPoint.Value * (float)FMath.RandRange(-1, 1), 
				DispLibDBCPCurvePointScalarMode.CacheCurValue => _ParamCurValue, 
				DispLibDBCPCurvePointScalarMode.ParamInitialValue => _ParamInitialValue, 
				DispLibDBCPCurvePointScalarMode.ValueMultiplyRandom_0_1 => SourceStruct.EndToPoint.Value, 
				DispLibDBCPCurvePointScalarMode.ValueMultiplyRandom_N1_1 => SourceStruct.EndToPoint.Value, 
				_ => SourceStruct.EndToPoint.Value, 
			}, _Mode: SourceStruct.EndToPoint.Mode, _Time: 0f, _DurationToPrePoint: SourceStruct.EndToPoint.DurationToPrePoint);
			switch (RuntimePointArray[0].Mode)
			{
			case DispLibDBCPCurvePointScalarMode.OnSpawn_ValueMultiplyRandom_0_1:
				CurFrameValue = RuntimePointArray[0].Value;
				break;
			case DispLibDBCPCurvePointScalarMode.OnSpawn_ValueMultiplyRandom_N1_1:
				CurFrameValue = RuntimePointArray[0].Value;
				break;
			case DispLibDBCPCurvePointScalarMode.ValueMultiplyRandom_0_1:
				CurFrameValue = RuntimePointArray[0].Value * FMath.FRand();
				break;
			case DispLibDBCPCurvePointScalarMode.ValueMultiplyRandom_N1_1:
				CurFrameValue = RuntimePointArray[0].Value * (float)FMath.RandRange(-1, 1);
				break;
			default:
				CurFrameValue = RuntimePointArray[0].Value;
				break;
			}
			InitOver = true;
			UpdateValue(0f, 0f);
			ExternalDependencyDataIsReady = !HasExternalDependencyData || _ExternalDependencyMode != DBCAsyncExternalDependencyMode.WaitUtilReady;
		}
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
		ValueOnEndStageBegin = MathLib.Lerp(RuntimePointArray[StdStage_FirstPointIndex].CurFrameBakedValue, RuntimePointArray[StdStage_SecondPointIndex].CurFrameBakedValue, StdStage_NormalizedTimeProgress);
		float num = 0f;
		switch (RuntimeEndToPoint.Mode)
		{
		case DispLibDBCPCurvePointScalarMode.ValueMultiplyRandom_0_1:
			num = RuntimeEndToPoint.Value * FMath.FRand();
			RuntimeEndToPoint.CurFrameBakedValue = num;
			break;
		case DispLibDBCPCurvePointScalarMode.ValueMultiplyRandom_N1_1:
			num = RuntimeEndToPoint.Value * FMath.RandRange(-1f, 1f);
			RuntimeEndToPoint.CurFrameBakedValue = num;
			break;
		default:
			num = RuntimeEndToPoint.Value;
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
			CurFrameValue = num;
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
		CurFrameValue = MathLib.Lerp(ValueOnEndStageBegin, num, MathLib.Clamp(LoopAge / durationToPrePoint, 0f, 1f));
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
		RuntimePCurvePoint runtimePCurvePoint = RuntimePointArray[StdStage_FirstPointIndex];
		RuntimePCurvePoint runtimePCurvePoint2 = RuntimePointArray[StdStage_SecondPointIndex];
		float num3 = 0f;
		switch (runtimePCurvePoint.Mode)
		{
		case DispLibDBCPCurvePointScalarMode.ValueMultiplyRandom_0_1:
			num3 = runtimePCurvePoint.Value * FMath.FRand();
			RuntimePointArray[StdStage_FirstPointIndex].CurFrameBakedValue = num3;
			break;
		case DispLibDBCPCurvePointScalarMode.ValueMultiplyRandom_N1_1:
			num3 = runtimePCurvePoint.Value * FMath.RandRange(-1f, 1f);
			RuntimePointArray[StdStage_FirstPointIndex].CurFrameBakedValue = num3;
			break;
		default:
			num3 = runtimePCurvePoint.Value;
			break;
		}
		float num4 = 0f;
		switch (runtimePCurvePoint2.Mode)
		{
		case DispLibDBCPCurvePointScalarMode.ValueMultiplyRandom_0_1:
			num4 = runtimePCurvePoint2.Value * FMath.FRand();
			RuntimePointArray[StdStage_SecondPointIndex].CurFrameBakedValue = num4;
			break;
		case DispLibDBCPCurvePointScalarMode.ValueMultiplyRandom_N1_1:
			num4 = runtimePCurvePoint2.Value * FMath.RandRange(-1f, 1f);
			RuntimePointArray[StdStage_SecondPointIndex].CurFrameBakedValue = num4;
			break;
		default:
			num4 = runtimePCurvePoint2.Value;
			break;
		}
		if (runtimePCurvePoint2.DurationToPrePoint == 0f)
		{
			StdStage_NormalizedTimeProgress = 1f;
			CurFrameValue = num4;
		}
		else
		{
			StdStage_NormalizedTimeProgress = MathLib.Clamp((num - runtimePCurvePoint.Time) / runtimePCurvePoint2.DurationToPrePoint, 0f, 1f);
			CurFrameValue = MathLib.Lerp(num3, num4, StdStage_NormalizedTimeProgress);
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
