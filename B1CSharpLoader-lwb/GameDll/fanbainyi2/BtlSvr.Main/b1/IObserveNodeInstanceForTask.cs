using ResB1;

namespace b1;

public interface IObserveNodeInstanceForTask
{
	void OnNotifyGraph_ItemChange(int ItemID, int OldNum, int NewNum);

	void OnNotifyGraph_Interaction(int InteractionGroupID, int Step);

	void OnNotifyGraph_TaskStage(int TaskStageID, QuestStage StageState);

	void OnNotifyGraph_GainHulu(int HuluID);

	void OnNotifyGraph_MonsterColletion();
}
