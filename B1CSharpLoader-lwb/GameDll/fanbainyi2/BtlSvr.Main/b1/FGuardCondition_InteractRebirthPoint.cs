using b1.EventDelDefine;
using CommB1;

namespace b1;

public class FGuardCondition_InteractRebirthPoint : FGuardConditionBase
{
	private const int WaitTickTime = 3;

	private int RebirthPointId { get; set; }

	private bool IsFadeInFinish { get; set; }

	private int TickTimer { get; set; }

	public override EGuardConditionType ConditionType => EGuardConditionType.InteractRebirthPoint;

	public override bool Initial(CalliopeCustom_TransitionCondition_Guide GuideCondition, PsmNodeInstance InPsmNodeInstance)
	{
		RebirthPointId = GuideCondition.RebirthPointId;
		return true;
	}

	protected override void Clean()
	{
	}

	protected override void Start()
	{
		IsFadeInFinish = false;
		BGS_EventCollectionCS.Get(GetOwner()).Evt_ShrineMainUIFadeInFinish += new Del_Void_Int(OnShrineMainUIFadeInFinish);
	}

	protected override void OnGameStateAttach()
	{
		BGS_EventCollectionCS.Get(GetOwner()).Evt_ShrineMainUIFadeInFinish += new Del_Void_Int(OnShrineMainUIFadeInFinish);
	}

	protected override void Stop()
	{
		BGS_EventCollectionCS.Get(GetOwner()).Evt_ShrineMainUIFadeInFinish -= new Del_Void_Int(OnShrineMainUIFadeInFinish);
	}

	private void OnShrineMainUIFadeInFinish(int InRebirthPointId)
	{
		if (RebirthPointId < 0 || InRebirthPointId == RebirthPointId)
		{
			IsFadeInFinish = true;
			TickTimer = 3;
		}
	}

	protected override void OnTick(float DeltaTime)
	{
		if (IsFadeInFinish && --TickTimer < 0)
		{
			base.QueryState = EQueryState.QuerySuccess;
			IsFadeInFinish = false;
		}
	}
}
