using b1.EventDelDefine;

namespace b1;

internal class BUS_OnlineTamerDebugComp : UActorCompBaseCS
{
	private BGC_ServerTamerAuthData ServerTamerAuthData { get; set; }

	public override void OnAttach()
	{
		ServerTamerAuthData = BGU_DataUtil.GetGameModeReadonlyData<BGC_ServerTamerAuthData>(GetOwner());
	}

	public override void OnNetActive()
	{
		base.OnNetActive();
		if (DebugConfig.DebugGSRepRole)
		{
			FreshDebugUI();
			base.BGSEventCollection.Evt_TamerPhaseChanged += new Del_TamerPhaseChanged(OnTamerPhaseChanged);
		}
	}

	public override void OnNetDeActive()
	{
		base.OnNetDeActive();
		if (DebugConfig.DebugGSRepRole)
		{
			base.BGSEventCollection.Evt_TamerPhaseChanged -= new Del_TamerPhaseChanged(OnTamerPhaseChanged);
		}
	}

	private void OnTamerPhaseChanged(FTamerRef InTamer, ETamerPhase OldPhase, ETamerPhase NewPhase)
	{
		if (InTamer.MonsterInstancePtr.Get() == GetOwner())
		{
			FreshDebugUI(NewPhase);
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		FreshDebugUI();
	}

	private void FreshDebugUI(ETamerPhase PhaseOverride = ETamerPhase.None)
	{
		if (!DebugConfig.DebugGSRepRole)
		{
			return;
		}
		BUTamerActor bUTamerActor = OwnerAsCharacterCS.GetTamerOwner() as BUTamerActor;
		if (bUTamerActor != null && bUTamerActor.CurrentRef != null)
		{
			if (PhaseOverride == ETamerPhase.None)
			{
				PhaseOverride = bUTamerActor.CurrentRef.Phase;
			}
			int num = 1;
			base.BUSEventCollection?.Evt_UpdateDebugUIInfo.Invoke("DebugGSRepRole", "ActorName:" + GetOwner().GetName(), num++);
			base.BUSEventCollection?.Evt_UpdateDebugUIInfo.Invoke("DebugGSRepRole", $"Phase:{PhaseOverride}", num++);
			if (ServerTamerAuthData != null)
			{
				base.BUSEventCollection?.Evt_UpdateDebugUIInfo.Invoke("DebugGSRepRole", $"ServerTamerAuthState:{ServerTamerAuthData.GetServerTamerAuthState(bUTamerActor.CurrentRef.TamerGuid)}", num++);
			}
			base.BUSEventCollection?.Evt_UpdateDebugUIInfo.Invoke("DebugGSRepRole", $"LocalRole:{GetOwner().GetLocalRole()}", num++);
			base.BUSEventCollection?.Evt_UpdateDebugUIInfo.Invoke("DebugGSRepRole", $"RemoteRole:{GetOwner().GetRemoteRole()}", num++);
		}
	}
}
