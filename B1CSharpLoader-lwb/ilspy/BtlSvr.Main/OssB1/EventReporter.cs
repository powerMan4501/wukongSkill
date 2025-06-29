using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using b1;
using GSE.GSSdk;
using GSE.OnlineBase;
using ILRuntime.Runtime.Enviorment;
using LitJson;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace OssB1;

public class EventReporter
{
	public delegate void Del_ReportEventHeadGetter(ReportEventHead OssEventHeader, bool FillRoleBaseInfo);

	private static Dictionary<UObject, EventReporter> _multi_instance = new Dictionary<UObject, EventReporter>();

	private UObject _game_instance;

	private ReportMsgComm ReportComm = new ReportMsgComm();

	private Del_ReportEventHeadGetter LocalReportEventHeadGetter;

	private Del_ReportEventHeadGetter ServerReportEventHeadGetter;

	private bool NeedLogEvent;

	private static FileStream oss_log_file_stream = null;

	private static int oss_log_file_max_append_byte_size = 33554432;

	private static long oss_log_file_append_byte_size = 0L;

	public UBGWGameInstance GameInstance => _game_instance as UBGWGameInstance;

	private Del_ReportEventHeadGetter RoleBaseGatter
	{
		get
		{
			if (ServerReportEventHeadGetter != null)
			{
				return ServerReportEventHeadGetter;
			}
			return LocalReportEventHeadGetter;
		}
	}

	protected EventReporter(UObject WorldCtx)
	{
		_game_instance = WorldCtx;
		ReportComm.Reporter = new ReporterEnv
		{
			ReporterType = ReporterType.Default,
			ReporterId = "b1"
		};
		if (!(GameInstance != null))
		{
			return;
		}
		UWorld worldForCS = GameInstance.GetWorldForCS();
		if (worldForCS != null)
		{
			if (UGSE_EngineFuncLib.IsDedicateServer(worldForCS))
			{
				ReportComm.Reporter.ReporterType = ReporterType.ReporterDedicatedServer;
			}
			else if (worldForCS.IsServer())
			{
				ReportComm.Reporter.ReporterType = ReporterType.ReporterListenServer;
			}
			else
			{
				ReportComm.Reporter.ReporterType = ReporterType.ReporterClient;
			}
		}
	}

	public static void DestroyInstance(UObject WorldCtx)
	{
		if (WorldCtx == null || WorldCtx.IsNullOrDestroyed())
		{
			BGW_LogUtil.LogError("oss get instance for destroy but world ctx is null !");
			return;
		}
		UGameInstance gameInstance = UGameplayStatics.GetGameInstance(WorldCtx);
		if (gameInstance == null)
		{
			BGW_LogUtil.LogError("oss get instance for destroy but world ctx get game instance is null !");
		}
		else if (!_multi_instance.Remove(gameInstance))
		{
			BGW_LogUtil.LogError("oss get instance for destroy but key instance:{0},{1} remove empty ", WorldCtx.GetAddress(), gameInstance.GetAddress());
		}
	}

	public static EventReporter GetInstance(UObject WorldCtx)
	{
		if (WorldCtx == null || WorldCtx.IsNullOrDestroyed())
		{
			BGW_LogUtil.LogError("oss get instance for init but world ctx is null !");
			return null;
		}
		UGameInstance gameInstance = UGameplayStatics.GetGameInstance(WorldCtx);
		if (gameInstance == null)
		{
			BGW_LogUtil.LogError("oss get instance but world ctx get game instance is null !");
			return null;
		}
		if (_multi_instance.TryGetValue(gameInstance, out var value))
		{
			return value;
		}
		value = new EventReporter(gameInstance);
		_multi_instance.Add(gameInstance, value);
		return value;
	}

	public static void DelegateRegister(ILRuntime.Runtime.Enviorment.AppDomain appdomain)
	{
		appdomain.DelegateManager.RegisterMethodDelegate<ReportEventHead>();
		appdomain.DelegateManager.RegisterMethodDelegate<ReportEventHead, bool>();
		appdomain.DelegateManager.RegisterDelegateConvertor<Del_ReportEventHeadGetter>((Delegate act) => (Del_ReportEventHeadGetter)delegate(ReportEventHead RoleBase, bool FillRoleBaseInfo)
		{
			((Action<ReportEventHead, bool>)act)(RoleBase, FillRoleBaseInfo);
		});
	}

	public static void InitLocalReporter(UObject Context, Del_ReportEventHeadGetter LocalRoleBaseGetter)
	{
		EventReporter instance = GetInstance(Context);
		if (instance == null)
		{
			BGW_LogUtil.LogError("oss get reporter by context:{0} instance fail !", Context?.GetAddress());
		}
		else
		{
			instance.SetLocalRoleBaseGetter(LocalRoleBaseGetter);
		}
	}

	public void SetLocalRoleBaseGetter(Del_ReportEventHeadGetter getter)
	{
		LocalReportEventHeadGetter = getter;
	}

	public void SetServerRoleBaseGetter(Del_ReportEventHeadGetter getter)
	{
		ServerReportEventHeadGetter = getter;
	}

	public void ToggleLog(bool IsOpenLog)
	{
		NeedLogEvent = IsOpenLog;
	}

	private static bool CheckIsEventCantReportInBossRush(string EventType)
	{
		if (!GSEUtil.IsBossRushMode())
		{
			return true;
		}
		switch (EventType)
		{
		case "BossRushResult":
		case "ExitGame":
		case "SettingChange":
		case "Battle":
		case "GameCrash":
		case "Logout":
			return true;
		case "ItemChange":
			if (GSEUtil.IsInBossRushFinishStage())
			{
				return true;
			}
			break;
		}
		return false;
	}

	public void AddReportEvent(ReportEvent Evt, bool FillRoleBaseInfo)
	{
		if (CheckIsEventCantReportInBossRush(Evt.EventType))
		{
			Evt.EventHead = new ReportEventHead
			{
				Comm = ReportComm
			};
			RoleBaseGatter?.Invoke(Evt.EventHead, FillRoleBaseInfo);
			string format = JsonMapper.ToJson(Evt);
			string text = "CEVENT_" + Evt.EventType;
			GSSDKReport.TrackDataEvent(text, format);
			if (NeedLogEvent)
			{
				OSSLogFileAppend("evt name:" + text + " evt body:" + PbEncoding.ToString(Evt));
			}
		}
	}

	private static void OSSLogFileAppend(string msg)
	{
		if (oss_log_file_stream == null)
		{
			try
			{
				string text = FPaths.Combine(FPaths.ProjectSavedDir, "Logs", "b1_oss.log");
				FileInfo fileInfo = new FileInfo(text);
				if (fileInfo.Exists)
				{
					oss_log_file_append_byte_size += fileInfo.Length;
					if (fileInfo.Length >= oss_log_file_max_append_byte_size)
					{
						string text2 = text + ".bak";
						if (File.Exists(text2))
						{
							File.Delete(text2);
						}
						File.Move(text, text2);
					}
				}
				oss_log_file_stream = new FileStream(text, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			}
			catch (Exception ex)
			{
				BGW_LogUtil.LogError("move oss log file fail:%s !", ex.Message);
			}
		}
		if (oss_log_file_stream != null)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + "|" + msg + "\n");
			oss_log_file_stream.Write(bytes, 0, bytes.Length);
			oss_log_file_stream.Flush();
			oss_log_file_append_byte_size += bytes.Length;
			if (oss_log_file_append_byte_size >= oss_log_file_max_append_byte_size)
			{
				oss_log_file_stream = null;
				oss_log_file_append_byte_size = 0L;
			}
		}
	}

	public ReportClientBase GenLocalSdkClientInfo()
	{
		ReportClientBase obj = new ReportClientBase
		{
			RoleId = UBGWFunctionLibraryCS.SinglePlayerDefaultRoleId(),
			PlayMode = GSSDKEnv.UserInfo.ClientSetting.PlayMode,
			Version = GSVersionUtil.GetAppVersionWithRevision(),
			SdkUid = BGW_GSSdkMgr.GetLoginUserId(_game_instance, "InvalidSdkUid")
		};
		string text = GSSDKEnv.UserInfo?.AuthInfo?.LoginChannelUserName;
		obj.SdkUname = ((text != null) ? text : "");
		obj.ShareArchiveUid = BGW_GameArchiveMgr.Get(_game_instance).SharedArchiveUid;
		obj.GameSessionUuid = BGW_GSSdkMgr.Get(_game_instance).GameStartSessionUUID;
		obj.LoginChannel = DebugConfig.GSSdkLoginChannel;
		obj.Region = GSSDKEnv.UserInfo?.ClientSetting?.Region ?? "";
		obj.DeviceId = GSSDKEnv.UserInfo?.DeviceInfo?.DeviceId ?? "";
		return obj;
	}

	public void Guide(ReportEventGuide EventMsg)
	{
		ReportEvent evt = new ReportEvent
		{
			EventType = "Guide",
			Guide = EventMsg
		};
		AddReportEvent(evt, FillRoleBaseInfo: true);
	}

	public void CreateRole(ReportEventCreateRole EventMsg)
	{
		ReportEvent evt = new ReportEvent
		{
			EventType = "CreateRole",
			CreateRole = EventMsg
		};
		AddReportEvent(evt, FillRoleBaseInfo: true);
	}

	public void Login(ReportEventLogin EventMsg)
	{
		ReportEvent evt = new ReportEvent
		{
			EventType = "Login",
			Login = EventMsg
		};
		AddReportEvent(evt, FillRoleBaseInfo: true);
	}

	public void Logout(ReportEventLogout EventMsg)
	{
		ReportEvent evt = new ReportEvent
		{
			EventType = "Logout",
			Logout = EventMsg
		};
		AddReportEvent(evt, FillRoleBaseInfo: true);
	}

	public void PlayerDie(ReportEventPlayerDie EventMsg)
	{
		ReportEvent evt = new ReportEvent
		{
			EventType = "PlayerDie",
			PlayerDie = EventMsg
		};
		AddReportEvent(evt, FillRoleBaseInfo: true);
	}

	public void SlevelLeave(ReportEventSlevelLeave EventMsg)
	{
		ReportEvent evt = new ReportEvent
		{
			EventType = "SlevelLeave",
			SlevelLeave = EventMsg
		};
		AddReportEvent(evt, FillRoleBaseInfo: true);
	}

	public void ItemChange(ReportEventItemChange EventMsg)
	{
		ReportEvent evt = new ReportEvent
		{
			EventType = "ItemChange",
			ItemChange = EventMsg
		};
		AddReportEvent(evt, FillRoleBaseInfo: true);
	}

	public void CreateArchive(ReportEventCreateArchive EventMsg)
	{
		ReportEvent evt = new ReportEvent
		{
			EventType = "CreateArchive",
			CreateArchive = EventMsg
		};
		AddReportEvent(evt, FillRoleBaseInfo: true);
	}

	public void DeleteArchive(ReportEventDeleteArchive EventMsg)
	{
		ReportEvent evt = new ReportEvent
		{
			EventType = "DeleteArchive",
			DeleteArchive = EventMsg
		};
		AddReportEvent(evt, FillRoleBaseInfo: true);
	}

	public void ItemDrop(ReportEventItemDrop EventMsg)
	{
		ReportEvent evt = new ReportEvent
		{
			EventType = "ItemDrop",
			ItemDrop = EventMsg
		};
		AddReportEvent(evt, FillRoleBaseInfo: true);
	}

	public void Load(ReportEventLoad EventMsg)
	{
		ReportEvent evt = new ReportEvent
		{
			EventType = "Load",
			Load = EventMsg
		};
		AddReportEvent(evt, FillRoleBaseInfo: true);
	}

	public void Harvest(ReportEventHarvest EventMsg)
	{
		ReportEvent evt = new ReportEvent
		{
			EventType = "Harvest",
			Harvest = EventMsg
		};
		AddReportEvent(evt, FillRoleBaseInfo: true);
	}

	public void ExitGame(ReportEventExitGame EventMsg)
	{
		ReportEvent evt = new ReportEvent
		{
			EventType = "ExitGame",
			ExitGame = EventMsg
		};
		AddReportEvent(evt, FillRoleBaseInfo: true);
	}

	public void InitSettingFinish(ReportEventInitSettingFinish EventMsg)
	{
		ReportEvent evt = new ReportEvent
		{
			EventType = "InitSettingFinish",
			InitSettingFinish = EventMsg
		};
		AddReportEvent(evt, FillRoleBaseInfo: true);
	}

	public void SettingChange(ReportEventSettingChange EventMsg)
	{
		ReportEvent evt = new ReportEvent
		{
			EventType = "SettingChange",
			SettingChange = EventMsg
		};
		AddReportEvent(evt, FillRoleBaseInfo: true);
	}

	public void Interact(ReportEventInteract EventMsg)
	{
		ReportEvent evt = new ReportEvent
		{
			EventType = "Interact",
			Interact = EventMsg
		};
		AddReportEvent(evt, FillRoleBaseInfo: true);
	}

	public void MonsterFirstMeet(ReportEventMonsterFirstMeet EventMsg)
	{
		ReportEvent evt = new ReportEvent
		{
			EventType = "MonsterFirstMeet",
			MonsterFirstMeet = EventMsg
		};
		AddReportEvent(evt, FillRoleBaseInfo: true);
	}

	public void GameComplete(ReportEventGameComplete EventMsg)
	{
		ReportEvent evt = new ReportEvent
		{
			EventType = "GameComplete",
			GameComplete = EventMsg
		};
		AddReportEvent(evt, FillRoleBaseInfo: true);
	}

	public void PlayerTransEvent(ReportEventPlayerTransEvent EventMsg)
	{
		ReportEvent evt = new ReportEvent
		{
			EventType = "PlayerTransEvent",
			PlayerTransEvent = EventMsg
		};
		AddReportEvent(evt, FillRoleBaseInfo: true);
	}

	public void GPEvent(ReportEventGPEvent EventMsg)
	{
		ReportEvent evt = new ReportEvent
		{
			EventType = "Gpevent",
			Gpevent = EventMsg
		};
		AddReportEvent(evt, FillRoleBaseInfo: true);
	}

	public void Battle(ReportEventBattle EventMsg)
	{
		ReportEvent evt = new ReportEvent
		{
			EventType = "Battle",
			Battle = EventMsg
		};
		AddReportEvent(evt, FillRoleBaseInfo: true);
	}

	public void BossRushResult(ReportEventBossRushResult EventMsg)
	{
		ReportEvent evt = new ReportEvent
		{
			EventType = "BossRushResult",
			BossRushResult = EventMsg
		};
		AddReportEvent(evt, FillRoleBaseInfo: true);
	}

	public void CommValueChange(ReportEventCommValueChange EventMsg)
	{
		ReportEvent evt = new ReportEvent
		{
			EventType = "CommValueChange",
			CommValueChange = EventMsg
		};
		AddReportEvent(evt, FillRoleBaseInfo: true);
	}

	public void WinePartnerChange(ReportEventWinePartnerChange EventMsg)
	{
		ReportEvent evt = new ReportEvent
		{
			EventType = "WinePartnerChange",
			WinePartnerChange = EventMsg
		};
		AddReportEvent(evt, FillRoleBaseInfo: true);
	}

	public void Refine(ReportEventRefine EventMsg)
	{
		ReportEvent evt = new ReportEvent
		{
			EventType = "Refine",
			Refine = EventMsg
		};
		AddReportEvent(evt, FillRoleBaseInfo: true);
	}

	public void Task(ReportEventTask EventMsg)
	{
		ReportEvent evt = new ReportEvent
		{
			EventType = "Task",
			Task = EventMsg
		};
		AddReportEvent(evt, FillRoleBaseInfo: true);
	}

	public void AppLaunch(ReportEventAppLaunch EventMsg)
	{
		ReportEvent evt = new ReportEvent
		{
			EventType = "AppLaunch",
			AppLaunch = EventMsg
		};
		AddReportEvent(evt, FillRoleBaseInfo: true);
	}

	public void ExecGM(ReportEventExecGM EventMsg)
	{
		ReportEvent evt = new ReportEvent
		{
			EventType = "ExecGm",
			ExecGm = EventMsg
		};
		AddReportEvent(evt, FillRoleBaseInfo: true);
	}

	public void Collection(ReportEventCollection EventMsg)
	{
		ReportEvent evt = new ReportEvent
		{
			EventType = "Collection",
			Collection = EventMsg
		};
		AddReportEvent(evt, FillRoleBaseInfo: true);
	}

	public void Chapter(ReportEventChapter EventMsg)
	{
		ReportEvent evt = new ReportEvent
		{
			EventType = "Chapter",
			Chapter = EventMsg
		};
		AddReportEvent(evt, FillRoleBaseInfo: true);
	}

	public void RoleSnapshoot(ReportEventRoleSnapshoot EventMsg)
	{
		ReportEvent evt = new ReportEvent
		{
			EventType = "RoleSnapshoot",
			RoleSnapshoot = EventMsg
		};
		AddReportEvent(evt, FillRoleBaseInfo: true);
	}

	public void InputSettingChange(ReportEventInputSettingChange EventMsg)
	{
		ReportEvent evt = new ReportEvent
		{
			EventType = "InputSettingChange",
			InputSettingChange = EventMsg
		};
		AddReportEvent(evt, FillRoleBaseInfo: true);
	}

	public void BenchMarkResult(ReportEventBenchMarkResult EventMsg)
	{
		ReportEvent evt = new ReportEvent
		{
			EventType = "BenchMarkResult",
			BenchMarkResult = EventMsg
		};
		AddReportEvent(evt, FillRoleBaseInfo: true);
	}

	public void GameCrash(ReportEventGameCrash EventMsg)
	{
		ReportEvent evt = new ReportEvent
		{
			EventType = "GameCrash",
			GameCrash = EventMsg
		};
		AddReportEvent(evt, FillRoleBaseInfo: true);
	}
}
