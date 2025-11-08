using System;
using System.Collections.Generic;
using System.Linq;
using b1;
using UnrealEngine.Engine;

namespace BlackMythWukong_Game_Helper;

public class GameStateSystemMgr : GameStateSystemBase
{
	private Dictionary<Type, SystemBase> Dic_ = new Dictionary<Type, SystemBase>();

	public override void OnAttach()
	{
		Console.WriteLine("OnAttach");
		AddSystemA(new BU_TimerSystem());
		AddSystemA(new BU_PlayerTransSystem());
		AddSystemA(new BU_PlayerTransSysemA());
		AddSystemA(new BU_MonsterHpMaxMul());
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		IBPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<BPC_PlayerRoleData>((AActor)MyUtils.GetControlledPawn().GetController());
		if (readOnlyData != null)
		{
			Console.WriteLine("OnBeginPlay");
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		Console.WriteLine("OnEndPlay");
		StopAllSystem();
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		Dictionary<Type, SystemBase>.KeyCollection keys = Dic_.Keys;
		foreach (Type item in keys)
		{
			if (Dic_.TryGetValue(item, out var value) && value.IsRun)
			{
				value.OnTick(DeltaTime, TickGroup);
			}
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public void SetRunOrStop(bool isRun)
	{
		SetCanTick(isRun);
	}

	public void StopAllSystem()
	{
		foreach (Type key in Dic_.Keys)
		{
			if (Dic_.TryGetValue(key, out var value))
			{
				value.SetRun(isRun: false);
			}
		}
	}

	private T AddSystem<T>(T system) where T : SystemBase
	{
		if (Dic_.Keys.Contains(typeof(T)))
		{
			Dic_[typeof(T)] = system;
		}
		else
		{
			Dic_.Add(typeof(T), system);
		}
		system.Init(this);
		system.OnAttach();
		return system;
	}

	public void AddSystemA<T>(T systemBase) where T : SystemBase
	{
		T gameStateSystem = AddSystem(systemBase);
		GlobalObjectMgr.Add(gameStateSystem);
	}
}
