using System.Collections.Generic;
using GUR.Runtime;
using UnrealEngine.Runtime;

namespace b1;

[NeedToUI]
public interface IBUC_AbnormalStateHandlers
{
	bool IsInState(EAbnormalStateType AbnormalStateType);

	bool IsInFinalState(EAbnormalStateType AbnormalStateType);

	List<EAbnormalStateType> GetInFinalStateList();

	Dictionary<EAbnormalStateType, int> GetInFinalStateAndAttackerAbnormalStateDispID();

	bool bNeedShowAbnormalAccUI(EAbnormalStateType Type);

	float GetFinalEffectRemainTime(EAbnormalStateType Type);

	int GetCurFinalEffectBuffID(EAbnormalStateType Type);

	List<EAbnormalStateType> GetAllActiveAbnormalState();

	void PlayHitExtFX(FTransform FXTrans);

	void PlayDeadLoopFX(EAbnormalStateType AbnormalType, int CachedAttackerDispID, bool bEnd);

	void PlayDeadDisapearFX(EAbnormalStateType AbnormalType, int CachedAttackerDispID);

	void UpdateCurLoopAbnormalDisp();
}
