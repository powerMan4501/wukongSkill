using System;
using b1;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class ModifyNiagaraParamsFLinearColorInfo
{
	private BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor SourceStruct;

	public bool InitOver { get; protected set; }

	public bool isEndStage { get; protected set; }

	public FLinearColor CurFrameValue { get; protected set; }

	public bool SetEveryFrame { get; protected set; }

	public FLinearColor ValueOnEndStageBegin { get; protected set; }

	public float LoopAge { get; protected set; }

	public float Age { get; protected set; }

	public ModifyNiagaraParamsFLinearColorInfo(BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor _SourceStruct, FVector Velocity, float StartAge)
	{
		Init(_SourceStruct, Velocity, StartAge);
	}

	public virtual void SetEnd()
	{
		if (!isEndStage)
		{
			isEndStage = true;
			SetEveryFrame = true;
			ValueOnEndStageBegin = CurFrameValue;
			LoopAge = 0f;
		}
	}

	protected virtual void UpdateEndStage()
	{
		if (SourceStruct.EndStageDuration < 0f)
		{
			CurFrameValue = ValueOnEndStageBegin;
		}
		else if (SourceStruct.EndStageDuration == 0f)
		{
			CurFrameValue = SourceStruct.EndValue;
		}
		else
		{
			CurFrameValue = FMath.Lerp(ValueOnEndStageBegin, SourceStruct.EndValue, MathLib.Clamp(LoopAge / SourceStruct.EndStageDuration, 0f, 1f));
		}
	}

	protected virtual void Init(BUC_DispLibUtil_ModifyNiagaraParams_FLinearColor _SourceStruct, FVector Velocity, float StartAge)
	{
		InitOver = false;
		SourceStruct = _SourceStruct;
		Age = Math.Max(0f, StartAge);
		LoopAge = Age;
		if (SourceStruct.Loop && SourceStruct.Period > 0f && SourceStruct.Period != -1000f)
		{
			LoopAge %= SourceStruct.Period;
		}
		SetEveryFrame = SourceStruct.SetEveryFrame;
		switch (SourceStruct.Mode)
		{
		case DispLibDBCAdvProcessModifyNiagaraParamUtilMode.Random:
			SetEveryFrame = true;
			break;
		case DispLibDBCAdvProcessModifyNiagaraParamUtilMode.TimedUCurve:
			SetEveryFrame = true;
			break;
		case DispLibDBCAdvProcessModifyNiagaraParamUtilMode.SpecAttUCurve:
			SetEveryFrame = true;
			break;
		}
		switch (SourceStruct.Mode)
		{
		case DispLibDBCAdvProcessModifyNiagaraParamUtilMode.Standard:
			CurFrameValue = SourceStruct.Value;
			break;
		case DispLibDBCAdvProcessModifyNiagaraParamUtilMode.SpecAtt:
			if (SourceStruct.SpecAttType == DispLibDBCSpecialAttritubeTpye.Velocity)
			{
				CurFrameValue = new FLinearColor(Velocity.X, Velocity.Y, Velocity.Z);
			}
			break;
		case DispLibDBCAdvProcessModifyNiagaraParamUtilMode.RandomOnSpawn:
		case DispLibDBCAdvProcessModifyNiagaraParamUtilMode.Random:
			CurFrameValue = FMath.Lerp(SourceStruct.RangeMin, SourceStruct.RangeMax, FMath.FRand());
			break;
		case DispLibDBCAdvProcessModifyNiagaraParamUtilMode.TimedUCurve:
			if (SourceStruct.Curve.IsNullOrDestroyed())
			{
				return;
			}
			CurFrameValue = SourceStruct.Curve.GetUnadjustedLinearColorValue(0f);
			break;
		case DispLibDBCAdvProcessModifyNiagaraParamUtilMode.SpecAttUCurve:
		{
			if (SourceStruct.Curve.IsNullOrDestroyed())
			{
				return;
			}
			Velocity.ToDirectionAndLength(out var _, out var length);
			CurFrameValue = SourceStruct.Curve.GetUnadjustedLinearColorValue(length);
			break;
		}
		default:
			CurFrameValue = FLinearColor.White;
			break;
		}
		InitOver = true;
		UpdateValue(0f, Velocity);
	}

	public virtual void UpdateValue(float DeltaTime, FVector Velocity)
	{
		if (!InitOver)
		{
			return;
		}
		switch (SourceStruct.Mode)
		{
		case DispLibDBCAdvProcessModifyNiagaraParamUtilMode.Standard:
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
		case DispLibDBCAdvProcessModifyNiagaraParamUtilMode.SpecAtt:
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
			else if (SourceStruct.SpecAttType == DispLibDBCSpecialAttritubeTpye.Velocity)
			{
				CurFrameValue = new FLinearColor(Velocity.X, Velocity.Y, Velocity.Z);
			}
			break;
		case DispLibDBCAdvProcessModifyNiagaraParamUtilMode.RandomOnSpawn:
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
		case DispLibDBCAdvProcessModifyNiagaraParamUtilMode.Random:
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
				CurFrameValue = FMath.Lerp(SourceStruct.RangeMin, SourceStruct.RangeMax, FMath.FRand());
			}
			break;
		case DispLibDBCAdvProcessModifyNiagaraParamUtilMode.TimedUCurve:
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
			float inTime = Age;
			if (SourceStruct.Period > 0f)
			{
				inTime = MathLib.Clamp(LoopAge / SourceStruct.Period, 0f, 1f);
			}
			if (SourceStruct.Loop)
			{
				LoopAge = ((LoopAge > SourceStruct.Period) ? 0f : LoopAge);
			}
			CurFrameValue = SourceStruct.Curve.GetUnadjustedLinearColorValue(inTime) * SourceStruct.Scale;
			break;
		}
		case DispLibDBCAdvProcessModifyNiagaraParamUtilMode.SpecAttUCurve:
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
			float num = 0f;
			if (SourceStruct.SpecAttType == DispLibDBCSpecialAttritubeTpye.Velocity)
			{
				Velocity.ToDirectionAndLength(out var _, out var length);
				num = FMath.FInterpTo(num, length, DeltaTime, SourceStruct.Value.R);
			}
			CurFrameValue = SourceStruct.Curve.GetUnadjustedLinearColorValue(num) * SourceStruct.Scale;
			break;
		}
		}
	}
}
