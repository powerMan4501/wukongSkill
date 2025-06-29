using System;
using b1;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class DBCAdvProcessFLinearColor
{
	protected BUC_DispLibUtil_DBCAdvProcessFLinearColor SourceStruct;

	public bool InitOver { get; protected set; }

	public bool isEndStage { get; protected set; }

	public bool EventRealEnd { get; protected set; }

	public FLinearColor CurFrameValue { get; protected set; }

	public FLinearColor ValueOnEndStageBegin { get; protected set; }

	public float LoopAge { get; protected set; }

	public float Age { get; protected set; }

	public bool ParentEventRealEnd { get; protected set; }

	public DBCAdvProcessFLinearColor()
	{
	}

	public DBCAdvProcessFLinearColor(BUC_DispLibUtil_DBCAdvProcessFLinearColor _SourceStruct, float StartAge = 0f)
	{
		Init(_SourceStruct, StartAge);
	}

	protected virtual void Init(BUC_DispLibUtil_DBCAdvProcessFLinearColor _SourceStruct, float StartAge)
	{
		InitOver = false;
		SourceStruct = _SourceStruct;
		Age = Math.Max(0f, StartAge);
		LoopAge = Age;
		if (SourceStruct.Loop && SourceStruct.Period > 0f && SourceStruct.Period != -1000f)
		{
			LoopAge %= SourceStruct.Period;
		}
		switch (SourceStruct.Mode)
		{
		case DispLibDBCAdvProcessFLinearColorMode.Standard:
			CurFrameValue = _SourceStruct.Value;
			break;
		case DispLibDBCAdvProcessFLinearColorMode.RandomAlphaOnSpawn:
		{
			float a2 = FMath.Lerp(SourceStruct.Range.X, SourceStruct.Range.Y, FMath.FRand());
			CurFrameValue = new FLinearColor(SourceStruct.Value.R, SourceStruct.Value.G, SourceStruct.Value.B, a2);
			break;
		}
		case DispLibDBCAdvProcessFLinearColorMode.RandomAlpha:
		{
			float a = FMath.Lerp(SourceStruct.Range.X, SourceStruct.Range.Y, FMath.FRand());
			CurFrameValue = new FLinearColor(SourceStruct.Value.R, SourceStruct.Value.G, SourceStruct.Value.B, a);
			break;
		}
		case DispLibDBCAdvProcessFLinearColorMode.UCurve:
			if (SourceStruct.Curve.IsNullOrDestroyed())
			{
				return;
			}
			CurFrameValue = SourceStruct.Curve.GetUnadjustedLinearColorValue(0f);
			break;
		default:
			CurFrameValue = default(FLinearColor);
			break;
		}
		ParentEventRealEnd = false;
		EventRealEnd = false;
		InitOver = true;
		UpdateValue(0f, 0f);
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
		CurFrameValue = FLinearColor.Lerp(ValueOnEndStageBegin, SourceStruct.EndValue, MathLib.Clamp(LoopAge / SourceStruct.EndStageDuration, 0f, 1f));
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

	public virtual void UpdateValue(float DeltaTime, float VelocityLength, bool isRealTick = true)
	{
		if (!InitOver)
		{
			return;
		}
		Age += DeltaTime;
		LoopAge += DeltaTime;
		switch (SourceStruct.Mode)
		{
		case DispLibDBCAdvProcessFLinearColorMode.Standard:
			if (!isEndStage && SourceStruct.Duration > 0f && Age > SourceStruct.Duration)
			{
				SetEnd();
			}
			if (isEndStage)
			{
				UpdateEndStage();
			}
			break;
		case DispLibDBCAdvProcessFLinearColorMode.RandomAlphaOnSpawn:
			if (!isEndStage && SourceStruct.Duration > 0f && Age > SourceStruct.Duration)
			{
				SetEnd();
			}
			if (isEndStage)
			{
				UpdateEndStage();
			}
			break;
		case DispLibDBCAdvProcessFLinearColorMode.RandomAlpha:
		{
			if (!isEndStage && SourceStruct.Duration > 0f && Age > SourceStruct.Duration)
			{
				SetEnd();
			}
			if (isEndStage)
			{
				UpdateEndStage();
				break;
			}
			float a = FMath.Lerp(SourceStruct.Range.X, SourceStruct.Range.Y, FMath.FRand());
			CurFrameValue = new FLinearColor(SourceStruct.Value.R, SourceStruct.Value.G, SourceStruct.Value.B, a);
			break;
		}
		case DispLibDBCAdvProcessFLinearColorMode.UCurve:
		{
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
					CurFrameValue = SourceStruct.Curve.GetUnadjustedLinearColorValue(num) * SourceStruct.Scale;
				}
			}
			break;
		}
		}
	}
}
