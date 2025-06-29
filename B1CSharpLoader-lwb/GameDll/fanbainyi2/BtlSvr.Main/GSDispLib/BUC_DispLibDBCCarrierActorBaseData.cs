using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class BUC_DispLibDBCCarrierActorBaseData : BUC_DispLibDataBase, IBUC_DispLibDBCCarrierActorBaseData
{
	internal bool InitOver;

	internal USceneComponent EmitterComp;

	internal FVector EmitterStartPos;

	private USceneComponent TargetComp;

	internal FVector TargetStartPos;

	public bool GetInitOver()
	{
		return InitOver;
	}

	public USceneComponent GetEmitterComp()
	{
		return EmitterComp;
	}

	public FVector GetEmitterStartPos()
	{
		return EmitterStartPos;
	}

	public USceneComponent GetTargetComp()
	{
		return TargetComp;
	}

	public FVector GetTargetStartPos()
	{
		return TargetStartPos;
	}

	internal bool Init(USceneComponent _EmitterComp, FVector _EmitterStartPos, USceneComponent _TargetComp, FVector _TargetStartPos)
	{
		EmitterComp = _EmitterComp;
		TargetComp = _TargetComp;
		EmitterStartPos = _EmitterStartPos;
		TargetStartPos = _TargetStartPos;
		InitOver = true;
		return true;
	}

	internal void Reset()
	{
		InitOver = false;
		EmitterComp = null;
		TargetComp = null;
		EmitterStartPos = default(FVector);
		TargetStartPos = default(FVector);
	}
}
