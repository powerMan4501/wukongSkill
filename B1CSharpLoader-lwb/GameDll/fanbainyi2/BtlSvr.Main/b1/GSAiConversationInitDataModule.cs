namespace b1;

internal class GSAiConversationInitDataModule : GSInitDataModuleBase
{
	public override void Init()
	{
		base.Init();
		base.ModuleType = EInitDataModuleType.AiConversation;
	}
}
