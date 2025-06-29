namespace b1;

public static class BGUAbnormalStateFuncLib
{
	public static EAbnormalStateType GetAbnormalStateTypeByFinalBuffID(int FinalBuffID)
	{
		return (EAbnormalStateType)((FinalBuffID - 910000) / 1000);
	}
}
