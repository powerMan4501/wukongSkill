namespace b1;

public static class AbnormalStateGlobleParam
{
	public static float AccMaxCalcKValue => BGW_GameDB.GetAbnormalCommConfig().AccMaxCalcKValue;

	public static int AccProcessBuffID_Frozen => BGW_GameDB.GetAbnormalCommConfig().AccProcessBuffIDFrozen;

	public static int AccProcessBuffID_Yin => BGW_GameDB.GetAbnormalCommConfig().AccProcessBuffIDYin;

	public static int AccProcessBuffID_Yang => BGW_GameDB.GetAbnormalCommConfig().AccProcessBuffIDYang;

	public static float AccTriggerProcessAbnormalPercent_Frozen => BGW_GameDB.GetAbnormalCommConfig().AccTriggerProcessAbnormalPercentFrozen;

	public static float AccTriggerProcessAbnormalPercent_Yin => BGW_GameDB.GetAbnormalCommConfig().AccTriggerProcessAbnormalPercentYin;

	public static float AccTriggerProcessAbnormalPercent_Yang => BGW_GameDB.GetAbnormalCommConfig().AccTriggerProcessAbnormalPercentYang;
}
