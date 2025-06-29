using System;

namespace GSDispLib;

public class ModifyNiagaraParamsBoolInfo
{
	private BUC_DispLibUtil_ModNiagara_NameAndBoolValue SourceStruct;

	public bool InitOver { get; protected set; }

	public float Age { get; protected set; }

	public bool CurFrameValue { get; protected set; }

	public bool SetEveryFrame { get; protected set; }

	public bool isEndStage { get; protected set; }

	public bool EventRealEnd { get; protected set; }

	public ModifyNiagaraParamsBoolInfo(BUC_DispLibUtil_ModNiagara_NameAndBoolValue _SourceStruct, float StartAge)
	{
		Init(_SourceStruct, StartAge);
	}

	protected virtual void Init(BUC_DispLibUtil_ModNiagara_NameAndBoolValue _SourceStruct, float StartAge)
	{
		SourceStruct = _SourceStruct;
		Age = Math.Max(0f, StartAge);
		CurFrameValue = SourceStruct.Value;
		SetEveryFrame = SourceStruct.SetEveryFrame;
		InitOver = true;
	}

	public virtual void SetEnd()
	{
		if (!isEndStage)
		{
			isEndStage = true;
			SetEveryFrame = true;
			Age = 0f;
		}
	}

	public virtual void UpdateValue(float DeltaTime)
	{
		if (!InitOver)
		{
			return;
		}
		Age += DeltaTime;
		if (isEndStage)
		{
			if (SourceStruct.EndStageDuration <= 0f)
			{
				CurFrameValue = SourceStruct.AfterParamEventRealEndValue;
			}
			else if (Age < SourceStruct.EndStageDuration)
			{
				CurFrameValue = SourceStruct.EndDispStageValue;
			}
			else
			{
				CurFrameValue = SourceStruct.AfterParamEventRealEndValue;
			}
		}
		else if (SourceStruct.Duration > 0f && Age > SourceStruct.Duration)
		{
			SetEnd();
		}
	}
}
