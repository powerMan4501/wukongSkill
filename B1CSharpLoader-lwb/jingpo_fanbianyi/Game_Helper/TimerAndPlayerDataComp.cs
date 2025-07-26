using b1;

namespace Game_Helper;

public class TimerAndPlayerDataComp : UActorCompBaseCS
{
	public IBPC_PlayerRoleData PlayerRoleData;

	public override void OnAttach()
	{
		PlayerRoleData = ((UActorCompBaseCS)this).RequireReadOnlyControlledPlayerControlData<IBPC_PlayerRoleData, BPC_PlayerRoleData>();
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
	}

	public override int GetTickGroupMask()
	{
		return 1;
	}

	public void CanTick(bool Iscan)
	{
		((UActorCompBaseCS)this).SetCanTick(Iscan);
	}

	public T BUC_AnyDataGet<T>() where T : class, new()
	{
		return ((UActorCompBaseCS)this).RequireWritableData<T>();
	}

	public IT GetReadOnlyData<IT, T>() where IT : class where T : class, IT, new()
	{
		return ((UActorCompBaseCS)this).RequireReadOnlyData<IT, T>();
	}
}
