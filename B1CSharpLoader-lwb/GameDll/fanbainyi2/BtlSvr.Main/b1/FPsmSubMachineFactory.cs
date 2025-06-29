namespace b1;

public static class FPsmSubMachineFactory
{
	public static PsmSubMachine CreateInstance(string InInstanceKey)
	{
		return InInstanceKey switch
		{
			"Guide.Listener" => new GuideNodeInstance_Listener(), 
			"Guide.Mark" => new GuideNodeInstance_Mark(), 
			"BossRush.Battle" => new BossRushNodeInstance_CommonBattle(), 
			"BossRush.Idle" => new BossRushNodeInstance_CommonIdle(), 
			"BossRush.Story" => new BossRushNodeInstance_CommonStory(), 
			"BossRush.Group" => new BossRushNodeInstance_Group(), 
			"BossRush.Wait" => new BossRushNodeInstance_Wait(), 
			"Process.Machine.ReportOSS" => new PsmSubMachine_ReportOSS(), 
			"Process.Machine.Battle" => new PsmSubMachine_CommonBattle(), 
			"Process.Machine.Idle" => new PsmSubMachine_CommonIdle(), 
			"Process.Machine.Story" => new PsmSubMachine_CommonStory(), 
			"Process.Machine.Group" => new PsmSubMachine_Group(), 
			"Process.Machine.SaveArchive" => new PsmSubMachine_SaveArchive(), 
			"Process.Machine.TestSubMachine" => new PsmSubMachine_TestSubMachine(), 
			_ => null, 
		};
	}
}
