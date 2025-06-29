namespace b1;

public static class FPsmNodeInstanceFactory
{
	public static PsmNodeInstance CreateInstance(string InInstanceKey)
	{
		return InInstanceKey switch
		{
			"Guide.Initial" => new GuideNodeInstance_Initial(), 
			"Guide.Reroute" => new GuideNodeInstance_Reroute(), 
			"Guide.Wait" => new GuideNodeInstance_Wait(), 
			"BossRush.End" => new BossRushNodeInstance_End(), 
			"Process.Machine.Initial" => new PsmNodeInstance_Initial(), 
			"BossRush.Initial" => new BossRushNodeInstance_Initial(), 
			"Process.Machine.GroupStart" => new PsmNodeInstance_GroupStart(), 
			"BossRush.GroupStart" => new PsmNodeInstance_GroupStart(), 
			"Process.Machine.NPCState" => new PsmNodeInstance_NPCState(), 
			"Process.Machine.Final" => new PsmNodeInstance_Final(), 
			"Process.Machine.Fork" => new PsmNodeInstance_Fork(), 
			"Process.Machine.Join" => new PsmNodeInstance_Join(), 
			"Process.Machine.Junction" => new PsmNodeInstance_Junction(), 
			"Process.Machine.Reroute" => new PsmNodeInstance_Reroute(), 
			"BossRush.Reroute" => new PsmNodeInstance_Reroute(), 
			"Process.Machine.State" => new PsmNodeInstance_State(), 
			"Process.Machine.BattlePaceController" => new PsmNodeInstance_SubMachine(), 
			"Process.Machine.Idle" => new PsmNodeInstance_SubMachine(), 
			"Process.Machine.Story" => new PsmNodeInstance_SubMachine(), 
			"Process.Machine.Battle" => new PsmNodeInstance_SubMachine(), 
			"Process.Machine.SaveArchive" => new PsmNodeInstance_SubMachine(), 
			"Process.Machine.Group" => new PsmNodeInstance_SubMachine(), 
			"Process.Machine.ReportOSS" => new PsmNodeInstance_SubMachine(), 
			"Guide.Mark" => new PsmNodeInstance_SubMachine(), 
			"Guide.Listener" => new PsmNodeInstance_SubMachine(), 
			"BossRush.Idle" => new PsmNodeInstance_SubMachine(), 
			"BossRush.Story" => new PsmNodeInstance_SubMachine(), 
			"BossRush.Battle" => new PsmNodeInstance_SubMachine(), 
			"BossRush.Group" => new PsmNodeInstance_SubMachine(), 
			"BossRush.Wait" => new PsmNodeInstance_SubMachine(), 
			"Process.Machine.Terminate" => new PsmNodeInstance_Terminate(), 
			_ => null, 
		};
	}
}
