using System;

namespace b1;

public class FSMException : Exception
{
	private FSMStateBase ThrowState;

	public string ExtraMsg { get; private set; }

	public ELoadingExceptionLevel Level { get; private set; }

	public int ChildErrorCode { get; private set; }

	public int ErrorCode { get; private set; }

	public FSMException(FSMStateBase ThrowState, string ExtraMsg = "", ELoadingExceptionLevel ExceptionLevel = ELoadingExceptionLevel.Fatal, int ChildErrorCode = -1)
	{
		this.ThrowState = ThrowState;
		this.ExtraMsg = ExtraMsg;
		Level = ExceptionLevel;
		this.ChildErrorCode = ChildErrorCode;
		if (ThrowState is FSMState_GI_GlobalBase fSMState_GI_GlobalBase)
		{
			ErrorCode = GenErrorCode(1, (int)fSMState_GI_GlobalBase.OwningInstance.ActiveEState);
		}
		else if (ThrowState is FSMState_GI_LoadingBase fSMState_GI_LoadingBase)
		{
			ErrorCode = GenErrorCode(2, (int)fSMState_GI_LoadingBase.OwningInstance.ActiveEState);
		}
	}

	public override string ToString()
	{
		return $"FSMException ThrowState:{ThrowState.GetType()} ExtraMsg:{ExtraMsg} ChildErrorCode:{ChildErrorCode}\nStackInfo:\n{StackTrace}";
	}

	private int GenErrorCode(int Prefix, int LoadingEnum)
	{
		return Prefix * 10000 + LoadingEnum;
	}
}
