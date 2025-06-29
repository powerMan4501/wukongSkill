using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

public class BGS_StartUpGMSystem : GameModeSystemBase
{
	private bool bFirstTick { get; set; }

	private List<UNiagaraComponent> PreloadNiagaraComponents { get; } = new List<UNiagaraComponent>();

	private float DestroyPreloadNiagaraTimeSeconds { get; set; }

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		if (UB1Util.IsStartupConfigEnable())
		{
			GetOwner().World.GetPlayerController(0);
		}
		bFirstTick = true;
		DestroyPreloadNiagaraTimeSeconds = 5f;
	}

	public override void OnAttach()
	{
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (PreloadNiagaraComponents.Count > 0)
		{
			if (DestroyPreloadNiagaraTimeSeconds > 0f)
			{
				DestroyPreloadNiagaraTimeSeconds -= DeltaTime;
			}
			else
			{
				foreach (UNiagaraComponent preloadNiagaraComponent in PreloadNiagaraComponents)
				{
					preloadNiagaraComponent.DestroyComponent(Owner);
				}
				PreloadNiagaraComponents.Clear();
			}
		}
		if (bFirstTick)
		{
			bFirstTick = false;
			BGW_WorldSettings bGW_WorldSettings = Owner.World.GetWorldSettings().Cast<BGW_WorldSettings>();
			if (bGW_WorldSettings != null)
			{
				foreach (FDirectoryPath playOnStartNiagaraPath in bGW_WorldSettings.PlayOnStartNiagaraPaths)
				{
					_ = playOnStartNiagaraPath;
				}
			}
		}
		if (!UB1Util.IsStartupConfigEnable())
		{
			return;
		}
		if (UB1Util.GetStartCommandList(out var OutStartCommandList) > 0)
		{
			foreach (string item in OutStartCommandList)
			{
				USystemLibrary.ExecuteConsoleCommand(GetOwner(), item, null);
			}
		}
		if (UB1Util.GetGMCommandList(out var OutGMCommandList) > 0)
		{
			foreach (string value in OutGMCommandList.Values)
			{
				USystemLibrary.ExecuteConsoleCommand(GetOwner(), value, null);
			}
		}
		UB1Util.SetStartupConfigEnable(bEnable: false);
	}
}
