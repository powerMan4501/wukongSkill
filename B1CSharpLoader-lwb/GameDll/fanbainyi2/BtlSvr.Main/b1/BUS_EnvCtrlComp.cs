using System.Linq;
using b1.BGW;
using b1.EventDelDefine;
using b1.Plugins.CustomLightSystem;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_EnvCtrlComp : UActorCompBaseCS
{
	private b1.BUC_EnvCtrlData EnvCtrlData;

	public override void OnAttach()
	{
		EnvCtrlData = RequireWritableData<b1.BUC_EnvCtrlData>();
		base.BUSEventCollection.Evt_OnSwitchEnvironment += new Del_OnSwitchEnvironment(ChangeToTargetEnv);
		base.BUSEventCollection.Evt_ReleaseEnvironment += new Del_ReleaseEnvironment(ReleaseLevelSequenceFromEnvCtrl);
		base.BUSEventCollection.Evt_ResetAllEnvCtrl += new Del_Void(OnResetAllEnvCtrl);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		CheckScheduleUpdate(DeltaTime);
	}

	private void OpenCLSMng()
	{
		if (EnvCtrlData.CLSCmdMng == null)
		{
			if (Owner == null)
			{
				return;
			}
			UWorld world = Owner.World;
			if (!world.IsNullOrDestroyed())
			{
				world.GetAllActorsOfClass(UClass.GetClass<ACLSCommandManager>(), out var OutActors);
				if (OutActors.Count > 0)
				{
					EnvCtrlData.CLSCmdMng = OutActors[0] as ACLSCommandManager;
				}
			}
		}
		if (!(EnvCtrlData.CLSCmdMng == null))
		{
			EnvCtrlData.CLSCmdMng.InterruptAnotherManager();
			EnvCtrlData.bCLSCmdOpen = true;
		}
	}

	private void CloseCLSMng()
	{
		if (!(EnvCtrlData.CLSCmdMng == null))
		{
			EnvCtrlData.CLSCmdMng.ReactiveAnotherManager();
			EnvCtrlData.bCLSCmdOpen = false;
		}
	}

	private void ChangeToTargetEnv(AActor Actor, string LevelSequencePath, float AddtiveTargetPercentage)
	{
		int entityHash = AActorStatics.GetEntityHash(Actor);
		if (!EnvCtrlData.LeveleSequenceMap.ContainsKey(entityHash))
		{
			ULevelSequence levelSequence = GetLevelSequence(LevelSequencePath);
			if (levelSequence == null || Owner == null)
			{
				return;
			}
			UWorld actorStreamingLevelWorld = BGU_UnrealWorldUtil.GetActorStreamingLevelWorld(Owner);
			if (actorStreamingLevelWorld == null)
			{
				return;
			}
			ALevelSequenceActor OutActor;
			ULevelSequencePlayer envLevelSequencePlayer = ULevelSequencePlayer.CreateLevelSequencePlayer(actorStreamingLevelWorld, levelSequence, new FMovieSceneSequencePlaybackSettings
			{
				PlayRate = 1f
			}, out OutActor);
			CtrlRightRegister(entityHash, envLevelSequencePlayer);
		}
		if (!EnvCtrlData.bCLSCmdOpen)
		{
			OpenCLSMng();
		}
		FEnvChangeConfig value = EnvCtrlData.LeveleSequenceMap[entityHash];
		float num = AddtiveTargetPercentage / 100f * value.FinalTargetALTime;
		value.CurTargerALTime = ((num + value.CurTargerALTime > value.FinalTargetALTime) ? value.FinalTargetALTime : (num + value.CurTargerALTime));
		EnvCtrlData.LeveleSequenceMap[entityHash] = value;
	}

	private ULevelSequence GetLevelSequence(string LevelSequencePath)
	{
		ULevelSequence uLevelSequence = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<ULevelSequence>(LevelSequencePath, ELoadResourceType.AsyncLoadAndCache);
		if (uLevelSequence == null)
		{
			return null;
		}
		return uLevelSequence;
	}

	private void CtrlRightRegister(int ActorHash, ULevelSequencePlayer EnvLevelSequencePlayer)
	{
		if (EnvCtrlData.LeveleSequenceMap.ContainsKey(ActorHash))
		{
			return;
		}
		FEnvChangeConfig value = new FEnvChangeConfig
		{
			EnvLevelSequencePlayer = EnvLevelSequencePlayer
		};
		if (!(Owner == null))
		{
			UWorld actorStreamingLevelWorld = BGU_UnrealWorldUtil.GetActorStreamingLevelWorld(Owner);
			ADirectionalLight[] allActorsOfClass = actorStreamingLevelWorld.GetAllActorsOfClass<ADirectionalLight>();
			if (allActorsOfClass.Length != 0)
			{
				value.CLS_DLight = allActorsOfClass[0];
			}
			ASkyLight[] allActorsOfClass2 = actorStreamingLevelWorld.GetAllActorsOfClass<ASkyLight>();
			if (allActorsOfClass2.Length != 0)
			{
				value.CLS_SLight = allActorsOfClass2[0];
			}
			ASkyAtmosphere[] allActorsOfClass3 = actorStreamingLevelWorld.GetAllActorsOfClass<ASkyAtmosphere>();
			if (allActorsOfClass3.Length != 0)
			{
				value.CLS_AFog = allActorsOfClass3[0];
			}
			AExponentialHeightFog[] allActorsOfClass4 = actorStreamingLevelWorld.GetAllActorsOfClass<AExponentialHeightFog>();
			if (allActorsOfClass4.Length != 0)
			{
				value.CLS_EHFog = allActorsOfClass4[0];
			}
			value.FinalTargetALTime = UBGUFunctionLibraryForCS.BGUGetLevelSequenceLength(EnvLevelSequencePlayer);
			value.CurALTime = 0f;
			value.CurTargerALTime = 0f;
			EnvCtrlData.LeveleSequenceMap.Add(ActorHash, value);
		}
	}

	private void CheckScheduleUpdate(float DeltaTime)
	{
		if (EnvCtrlData.LeveleSequenceMap == null || EnvCtrlData.LeveleSequenceMap.Count < 1)
		{
			return;
		}
		foreach (int key in EnvCtrlData.LeveleSequenceMap.Keys)
		{
			if (!EnvCtrlData.LeveleSequenceMap.ContainsKey(key))
			{
				continue;
			}
			FEnvChangeConfig fEnvChangeConfig = EnvCtrlData.LeveleSequenceMap[key];
			if (fEnvChangeConfig.EnvLevelSequencePlayer == null)
			{
				continue;
			}
			if (fEnvChangeConfig.EnvLevelSequencePlayer.IsPlaying())
			{
				if (UBGUFunctionLibraryForCS.BGUGetLevelSequenceCurTime(fEnvChangeConfig.EnvLevelSequencePlayer) >= fEnvChangeConfig.CurTargerALTime)
				{
					SwitchEnvByCLS(key);
					fEnvChangeConfig.EnvLevelSequencePlayer.Pause();
				}
				else
				{
					SwitchEnvByCLS(key);
				}
			}
			else if (UBGUFunctionLibraryForCS.BGUGetLevelSequenceCurTime(fEnvChangeConfig.EnvLevelSequencePlayer) < fEnvChangeConfig.CurTargerALTime)
			{
				fEnvChangeConfig.EnvLevelSequencePlayer.Play();
			}
		}
	}

	private void SwitchEnvByCLS(int ActorHash)
	{
		if (EnvCtrlData.LeveleSequenceMap.ContainsKey(ActorHash))
		{
			FEnvChangeConfig fEnvChangeConfig = EnvCtrlData.LeveleSequenceMap[ActorHash];
			EnvCtrlData.CLSCmdMng.SafelySwitchLightsAndFogs(fEnvChangeConfig.CLS_DLight, fEnvChangeConfig.CLS_SLight, fEnvChangeConfig.CLS_AFog, fEnvChangeConfig.CLS_EHFog, fEnvChangeConfig.CLS_TargetMPCProperty, fEnvChangeConfig.CLS_OriMPCProperty, 1f, ForceUpdate: true);
		}
	}

	private void ReleaseLevelSequenceFromEnvCtrl(AActor Actor, bool bNeedRollBack)
	{
		ReleaseLevelSequenceFromEnvCtrl(AActorStatics.GetEntityHash(Actor), bNeedRollBack);
	}

	private void ReleaseLevelSequenceFromEnvCtrl(int EntityHash, bool bNeedRollBack)
	{
		if (bNeedRollBack)
		{
			FMovieSceneSequencePlaybackParams playbackPosition = new FMovieSceneSequencePlaybackParams
			{
				Time = 0f
			};
			EnvCtrlData.LeveleSequenceMap[EntityHash].EnvLevelSequencePlayer.SetPlaybackPosition(playbackPosition);
			SwitchEnvByCLS(EntityHash);
		}
		EnvCtrlData.LeveleSequenceMap.Remove(EntityHash);
		if (EnvCtrlData.LeveleSequenceMap == null)
		{
			CloseCLSMng();
		}
		else if (EnvCtrlData.LeveleSequenceMap.Count < 1)
		{
			CloseCLSMng();
		}
	}

	public void OnResetAllEnvCtrl()
	{
		if (EnvCtrlData.LeveleSequenceMap != null)
		{
			int[] array = EnvCtrlData.LeveleSequenceMap.Keys.ToArray();
			for (int i = 0; i < array.Length; i++)
			{
				ReleaseLevelSequenceFromEnvCtrl(array[i], bNeedRollBack: true);
			}
		}
	}
}
