using System;
using b1;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class DBCAdvProcessScalar
{
	protected BUC_DispLibUtil_DBCAdvProcessScalar SourceStruct;

	public bool InitOver { get; protected set; }

	public bool isEndStage { get; protected set; }

	public bool EventRealEnd { get; protected set; }

	public float CurFrameValue { get; protected set; }

	public float ValueOnEndStageBegin { get; protected set; }

	public float LoopAge { get; protected set; }

	public float Age { get; protected set; }

	public bool ParentEventRealEnd { get; protected set; }

	public DBCAdvProcessScalar()
	{
	}

	public DBCAdvProcessScalar(BUC_DispLibUtil_DBCAdvProcessScalar _SourceStruct, float StartAge = 0f)
	{
		Init(_SourceStruct, StartAge);
	}

	public void UpdateStandardModeEventCurFrameValue(float NewValue)
	{
		if (!isEndStage && !EventRealEnd)
		{
			CurFrameValue = NewValue;
		}
	}

	protected virtual void Init(BUC_DispLibUtil_DBCAdvProcessScalar _SourceStruct, float StartAge)
	{
		InitOver = false;
		SourceStruct = _SourceStruct;
		Age = Math.Max(0f, StartAge);
		LoopAge = Age;
		if (SourceStruct.Loop && SourceStruct.Period > 0f && SourceStruct.Period != -1000f)
		{
			LoopAge %= SourceStruct.Period;
		}
		EventRealEnd = false;
		ParentEventRealEnd = false;
		switch (SourceStruct.Mode)
		{
		case DispLibDBCAdvProcessScalarMode.Standard:
			CurFrameValue = SourceStruct.Value;
			break;
		case DispLibDBCAdvProcessScalarMode.RandomOnSpawn:
			CurFrameValue = FMath.Lerp(SourceStruct.Range.X, SourceStruct.Range.Y, FMath.FRand());
			break;
		case DispLibDBCAdvProcessScalarMode.Random:
			CurFrameValue = FMath.Lerp(SourceStruct.Range.X, SourceStruct.Range.Y, FMath.FRand());
			break;
		case DispLibDBCAdvProcessScalarMode.UCurve:
			if (SourceStruct.Curve.IsNullOrDestroyed())
			{
				return;
			}
			CurFrameValue = SourceStruct.Curve.GetFloatValue(0f);
			break;
		default:
			CurFrameValue = 0f;
			break;
		}
		InitOver = true;
		UpdateValue(0f, 0f);
	}

	public virtual void UpdateValue(float DeltaTime, float VelocityLength, bool isRealTick = true)
	{
		if (!InitOver)
		{
			return;
		}
		switch (SourceStruct.Mode)
		{
		case DispLibDBCAdvProcessScalarMode.Standard:
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
			else if (SourceStruct.Value == -1000f)
			{
				CurFrameValue = FMath.FInterpTo(CurFrameValue, VelocityLength, DeltaTime, SourceStruct.Range.X);
			}
			break;
		case DispLibDBCAdvProcessScalarMode.RandomOnSpawn:
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
			break;
		case DispLibDBCAdvProcessScalarMode.Random:
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
				CurFrameValue = MathLib.Lerp(SourceStruct.Range.X, SourceStruct.Range.Y, FMath.FRand());
			}
			break;
		case DispLibDBCAdvProcessScalarMode.UCurve:
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
				break;
			}
			float num = Age;
			if (SourceStruct.Period > 0f)
			{
				num = MathLib.Clamp(LoopAge / SourceStruct.Period, 0f, 1f);
			}
			else if (SourceStruct.Period == -1000f)
			{
				num = FMath.FInterpTo(num, VelocityLength, DeltaTime, SourceStruct.Range.X);
			}
			if (SourceStruct.Loop && SourceStruct.Period != -1000f)
			{
				LoopAge = ((LoopAge > SourceStruct.Period) ? 0f : LoopAge);
			}
			if (isRealTick)
			{
				if (SourceStruct.Curve.IsNullOrDestroyed())
				{
					EventRealEnd = true;
				}
				else
				{
					CurFrameValue = SourceStruct.Curve.GetFloatValue(num) * SourceStruct.Scale;
				}
			}
			break;
		}
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
		if (SourceStruct.EndStageDuration < 0f)
		{
			CurFrameValue = ValueOnEndStageBegin;
			return;
		}
		if (SourceStruct.EndStageDuration == 0f)
		{
			CurFrameValue = SourceStruct.EndValue;
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
		CurFrameValue = MathLib.Lerp(ValueOnEndStageBegin, SourceStruct.EndValue, MathLib.Clamp(LoopAge / SourceStruct.EndStageDuration, 0f, 1f));
		switch (SourceStruct.ReleaseParameterControlMode)
		{
		case DispLibDBCAdvProcessReleaseParameterControlMode.OnEventRealEnd:
			if (ParentEventRealEnd)
			{
				EventRealEnd = true;
			}
			break;
		case DispLibDBCAdvProcessReleaseParameterControlMode.OnParamSelfEndStageOver:
			if (LoopAge >= SourceStruct.EndStageDuration)
			{
				EventRealEnd = true;
			}
			break;
		}
	}
}
