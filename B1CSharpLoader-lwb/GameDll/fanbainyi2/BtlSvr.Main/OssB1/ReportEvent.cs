using System;
using Google.Protobuf;

namespace OssB1;

public sealed class ReportEvent : IMessage<ReportEvent>, IMessage, IEquatable<ReportEvent>, IDeepCloneable<ReportEvent>
{
	private static readonly MessageParser<ReportEvent> _parser = new MessageParser<ReportEvent>(() => new ReportEvent());

	private UnknownFieldSet _unknownFields;

	private string eventType_ = "";

	private ReportEventHead eventHead_;

	private ReportEventGuide guide_;

	private ReportEventCreateRole createRole_;

	private ReportEventLogin login_;

	private ReportEventLogout logout_;

	private ReportEventPlayerDie playerDie_;

	private ReportEventSlevelLeave slevelLeave_;

	private ReportEventItemChange itemChange_;

	private ReportEventCreateArchive createArchive_;

	private ReportEventDeleteArchive deleteArchive_;

	private ReportEventItemDrop itemDrop_;

	private ReportEventLoad load_;

	private ReportEventHarvest harvest_;

	private ReportEventExitGame exitGame_;

	private ReportEventInitSettingFinish initSettingFinish_;

	private ReportEventSettingChange settingChange_;

	private ReportEventInteract interact_;

	private ReportEventMonsterFirstMeet monsterFirstMeet_;

	private ReportEventGameComplete gameComplete_;

	private ReportEventPlayerTransEvent playerTransEvent_;

	private ReportEventGPEvent gpevent_;

	private ReportEventBattle battle_;

	private ReportEventBossRushResult bossRushResult_;

	private ReportEventCommValueChange commValueChange_;

	private ReportEventWinePartnerChange winePartnerChange_;

	private ReportEventRefine refine_;

	private ReportEventTask task_;

	private ReportEventAppLaunch appLaunch_;

	private ReportEventExecGM execGm_;

	private ReportEventCollection collection_;

	private ReportEventChapter chapter_;

	private ReportEventRoleSnapshoot roleSnapshoot_;

	private ReportEventInputSettingChange inputSettingChange_;

	private ReportEventBenchMarkResult benchMarkResult_;

	private ReportEventGameCrash gameCrash_;

	public static MessageParser<ReportEvent> Parser => _parser;

	public string EventType
	{
		get
		{
			return eventType_;
		}
		set
		{
			eventType_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ReportEventHead EventHead
	{
		get
		{
			return eventHead_;
		}
		set
		{
			eventHead_ = value;
		}
	}

	public ReportEventGuide Guide
	{
		get
		{
			return guide_;
		}
		set
		{
			guide_ = value;
		}
	}

	public ReportEventCreateRole CreateRole
	{
		get
		{
			return createRole_;
		}
		set
		{
			createRole_ = value;
		}
	}

	public ReportEventLogin Login
	{
		get
		{
			return login_;
		}
		set
		{
			login_ = value;
		}
	}

	public ReportEventLogout Logout
	{
		get
		{
			return logout_;
		}
		set
		{
			logout_ = value;
		}
	}

	public ReportEventPlayerDie PlayerDie
	{
		get
		{
			return playerDie_;
		}
		set
		{
			playerDie_ = value;
		}
	}

	public ReportEventSlevelLeave SlevelLeave
	{
		get
		{
			return slevelLeave_;
		}
		set
		{
			slevelLeave_ = value;
		}
	}

	public ReportEventItemChange ItemChange
	{
		get
		{
			return itemChange_;
		}
		set
		{
			itemChange_ = value;
		}
	}

	public ReportEventCreateArchive CreateArchive
	{
		get
		{
			return createArchive_;
		}
		set
		{
			createArchive_ = value;
		}
	}

	public ReportEventDeleteArchive DeleteArchive
	{
		get
		{
			return deleteArchive_;
		}
		set
		{
			deleteArchive_ = value;
		}
	}

	public ReportEventItemDrop ItemDrop
	{
		get
		{
			return itemDrop_;
		}
		set
		{
			itemDrop_ = value;
		}
	}

	public ReportEventLoad Load
	{
		get
		{
			return load_;
		}
		set
		{
			load_ = value;
		}
	}

	public ReportEventHarvest Harvest
	{
		get
		{
			return harvest_;
		}
		set
		{
			harvest_ = value;
		}
	}

	public ReportEventExitGame ExitGame
	{
		get
		{
			return exitGame_;
		}
		set
		{
			exitGame_ = value;
		}
	}

	public ReportEventInitSettingFinish InitSettingFinish
	{
		get
		{
			return initSettingFinish_;
		}
		set
		{
			initSettingFinish_ = value;
		}
	}

	public ReportEventSettingChange SettingChange
	{
		get
		{
			return settingChange_;
		}
		set
		{
			settingChange_ = value;
		}
	}

	public ReportEventInteract Interact
	{
		get
		{
			return interact_;
		}
		set
		{
			interact_ = value;
		}
	}

	public ReportEventMonsterFirstMeet MonsterFirstMeet
	{
		get
		{
			return monsterFirstMeet_;
		}
		set
		{
			monsterFirstMeet_ = value;
		}
	}

	public ReportEventGameComplete GameComplete
	{
		get
		{
			return gameComplete_;
		}
		set
		{
			gameComplete_ = value;
		}
	}

	public ReportEventPlayerTransEvent PlayerTransEvent
	{
		get
		{
			return playerTransEvent_;
		}
		set
		{
			playerTransEvent_ = value;
		}
	}

	public ReportEventGPEvent Gpevent
	{
		get
		{
			return gpevent_;
		}
		set
		{
			gpevent_ = value;
		}
	}

	public ReportEventBattle Battle
	{
		get
		{
			return battle_;
		}
		set
		{
			battle_ = value;
		}
	}

	public ReportEventBossRushResult BossRushResult
	{
		get
		{
			return bossRushResult_;
		}
		set
		{
			bossRushResult_ = value;
		}
	}

	public ReportEventCommValueChange CommValueChange
	{
		get
		{
			return commValueChange_;
		}
		set
		{
			commValueChange_ = value;
		}
	}

	public ReportEventWinePartnerChange WinePartnerChange
	{
		get
		{
			return winePartnerChange_;
		}
		set
		{
			winePartnerChange_ = value;
		}
	}

	public ReportEventRefine Refine
	{
		get
		{
			return refine_;
		}
		set
		{
			refine_ = value;
		}
	}

	public ReportEventTask Task
	{
		get
		{
			return task_;
		}
		set
		{
			task_ = value;
		}
	}

	public ReportEventAppLaunch AppLaunch
	{
		get
		{
			return appLaunch_;
		}
		set
		{
			appLaunch_ = value;
		}
	}

	public ReportEventExecGM ExecGm
	{
		get
		{
			return execGm_;
		}
		set
		{
			execGm_ = value;
		}
	}

	public ReportEventCollection Collection
	{
		get
		{
			return collection_;
		}
		set
		{
			collection_ = value;
		}
	}

	public ReportEventChapter Chapter
	{
		get
		{
			return chapter_;
		}
		set
		{
			chapter_ = value;
		}
	}

	public ReportEventRoleSnapshoot RoleSnapshoot
	{
		get
		{
			return roleSnapshoot_;
		}
		set
		{
			roleSnapshoot_ = value;
		}
	}

	public ReportEventInputSettingChange InputSettingChange
	{
		get
		{
			return inputSettingChange_;
		}
		set
		{
			inputSettingChange_ = value;
		}
	}

	public ReportEventBenchMarkResult BenchMarkResult
	{
		get
		{
			return benchMarkResult_;
		}
		set
		{
			benchMarkResult_ = value;
		}
	}

	public ReportEventGameCrash GameCrash
	{
		get
		{
			return gameCrash_;
		}
		set
		{
			gameCrash_ = value;
		}
	}

	public ReportEvent()
	{
	}

	public ReportEvent(ReportEvent other)
		: this()
	{
		eventType_ = other.eventType_;
		eventHead_ = ((other.eventHead_ != null) ? other.eventHead_.Clone() : null);
		guide_ = ((other.guide_ != null) ? other.guide_.Clone() : null);
		createRole_ = ((other.createRole_ != null) ? other.createRole_.Clone() : null);
		login_ = ((other.login_ != null) ? other.login_.Clone() : null);
		logout_ = ((other.logout_ != null) ? other.logout_.Clone() : null);
		playerDie_ = ((other.playerDie_ != null) ? other.playerDie_.Clone() : null);
		slevelLeave_ = ((other.slevelLeave_ != null) ? other.slevelLeave_.Clone() : null);
		itemChange_ = ((other.itemChange_ != null) ? other.itemChange_.Clone() : null);
		createArchive_ = ((other.createArchive_ != null) ? other.createArchive_.Clone() : null);
		deleteArchive_ = ((other.deleteArchive_ != null) ? other.deleteArchive_.Clone() : null);
		itemDrop_ = ((other.itemDrop_ != null) ? other.itemDrop_.Clone() : null);
		load_ = ((other.load_ != null) ? other.load_.Clone() : null);
		harvest_ = ((other.harvest_ != null) ? other.harvest_.Clone() : null);
		exitGame_ = ((other.exitGame_ != null) ? other.exitGame_.Clone() : null);
		initSettingFinish_ = ((other.initSettingFinish_ != null) ? other.initSettingFinish_.Clone() : null);
		settingChange_ = ((other.settingChange_ != null) ? other.settingChange_.Clone() : null);
		interact_ = ((other.interact_ != null) ? other.interact_.Clone() : null);
		monsterFirstMeet_ = ((other.monsterFirstMeet_ != null) ? other.monsterFirstMeet_.Clone() : null);
		gameComplete_ = ((other.gameComplete_ != null) ? other.gameComplete_.Clone() : null);
		playerTransEvent_ = ((other.playerTransEvent_ != null) ? other.playerTransEvent_.Clone() : null);
		gpevent_ = ((other.gpevent_ != null) ? other.gpevent_.Clone() : null);
		battle_ = ((other.battle_ != null) ? other.battle_.Clone() : null);
		bossRushResult_ = ((other.bossRushResult_ != null) ? other.bossRushResult_.Clone() : null);
		commValueChange_ = ((other.commValueChange_ != null) ? other.commValueChange_.Clone() : null);
		winePartnerChange_ = ((other.winePartnerChange_ != null) ? other.winePartnerChange_.Clone() : null);
		refine_ = ((other.refine_ != null) ? other.refine_.Clone() : null);
		task_ = ((other.task_ != null) ? other.task_.Clone() : null);
		appLaunch_ = ((other.appLaunch_ != null) ? other.appLaunch_.Clone() : null);
		execGm_ = ((other.execGm_ != null) ? other.execGm_.Clone() : null);
		collection_ = ((other.collection_ != null) ? other.collection_.Clone() : null);
		chapter_ = ((other.chapter_ != null) ? other.chapter_.Clone() : null);
		roleSnapshoot_ = ((other.roleSnapshoot_ != null) ? other.roleSnapshoot_.Clone() : null);
		inputSettingChange_ = ((other.inputSettingChange_ != null) ? other.inputSettingChange_.Clone() : null);
		benchMarkResult_ = ((other.benchMarkResult_ != null) ? other.benchMarkResult_.Clone() : null);
		gameCrash_ = ((other.gameCrash_ != null) ? other.gameCrash_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportEvent Clone()
	{
		return new ReportEvent(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportEvent);
	}

	public bool Equals(ReportEvent other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EventType != other.EventType)
		{
			return false;
		}
		if (!object.Equals(EventHead, other.EventHead))
		{
			return false;
		}
		if (!object.Equals(Guide, other.Guide))
		{
			return false;
		}
		if (!object.Equals(CreateRole, other.CreateRole))
		{
			return false;
		}
		if (!object.Equals(Login, other.Login))
		{
			return false;
		}
		if (!object.Equals(Logout, other.Logout))
		{
			return false;
		}
		if (!object.Equals(PlayerDie, other.PlayerDie))
		{
			return false;
		}
		if (!object.Equals(SlevelLeave, other.SlevelLeave))
		{
			return false;
		}
		if (!object.Equals(ItemChange, other.ItemChange))
		{
			return false;
		}
		if (!object.Equals(CreateArchive, other.CreateArchive))
		{
			return false;
		}
		if (!object.Equals(DeleteArchive, other.DeleteArchive))
		{
			return false;
		}
		if (!object.Equals(ItemDrop, other.ItemDrop))
		{
			return false;
		}
		if (!object.Equals(Load, other.Load))
		{
			return false;
		}
		if (!object.Equals(Harvest, other.Harvest))
		{
			return false;
		}
		if (!object.Equals(ExitGame, other.ExitGame))
		{
			return false;
		}
		if (!object.Equals(InitSettingFinish, other.InitSettingFinish))
		{
			return false;
		}
		if (!object.Equals(SettingChange, other.SettingChange))
		{
			return false;
		}
		if (!object.Equals(Interact, other.Interact))
		{
			return false;
		}
		if (!object.Equals(MonsterFirstMeet, other.MonsterFirstMeet))
		{
			return false;
		}
		if (!object.Equals(GameComplete, other.GameComplete))
		{
			return false;
		}
		if (!object.Equals(PlayerTransEvent, other.PlayerTransEvent))
		{
			return false;
		}
		if (!object.Equals(Gpevent, other.Gpevent))
		{
			return false;
		}
		if (!object.Equals(Battle, other.Battle))
		{
			return false;
		}
		if (!object.Equals(BossRushResult, other.BossRushResult))
		{
			return false;
		}
		if (!object.Equals(CommValueChange, other.CommValueChange))
		{
			return false;
		}
		if (!object.Equals(WinePartnerChange, other.WinePartnerChange))
		{
			return false;
		}
		if (!object.Equals(Refine, other.Refine))
		{
			return false;
		}
		if (!object.Equals(Task, other.Task))
		{
			return false;
		}
		if (!object.Equals(AppLaunch, other.AppLaunch))
		{
			return false;
		}
		if (!object.Equals(ExecGm, other.ExecGm))
		{
			return false;
		}
		if (!object.Equals(Collection, other.Collection))
		{
			return false;
		}
		if (!object.Equals(Chapter, other.Chapter))
		{
			return false;
		}
		if (!object.Equals(RoleSnapshoot, other.RoleSnapshoot))
		{
			return false;
		}
		if (!object.Equals(InputSettingChange, other.InputSettingChange))
		{
			return false;
		}
		if (!object.Equals(BenchMarkResult, other.BenchMarkResult))
		{
			return false;
		}
		if (!object.Equals(GameCrash, other.GameCrash))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (EventType.Length != 0)
		{
			num ^= EventType.GetHashCode();
		}
		if (eventHead_ != null)
		{
			num ^= EventHead.GetHashCode();
		}
		if (guide_ != null)
		{
			num ^= Guide.GetHashCode();
		}
		if (createRole_ != null)
		{
			num ^= CreateRole.GetHashCode();
		}
		if (login_ != null)
		{
			num ^= Login.GetHashCode();
		}
		if (logout_ != null)
		{
			num ^= Logout.GetHashCode();
		}
		if (playerDie_ != null)
		{
			num ^= PlayerDie.GetHashCode();
		}
		if (slevelLeave_ != null)
		{
			num ^= SlevelLeave.GetHashCode();
		}
		if (itemChange_ != null)
		{
			num ^= ItemChange.GetHashCode();
		}
		if (createArchive_ != null)
		{
			num ^= CreateArchive.GetHashCode();
		}
		if (deleteArchive_ != null)
		{
			num ^= DeleteArchive.GetHashCode();
		}
		if (itemDrop_ != null)
		{
			num ^= ItemDrop.GetHashCode();
		}
		if (load_ != null)
		{
			num ^= Load.GetHashCode();
		}
		if (harvest_ != null)
		{
			num ^= Harvest.GetHashCode();
		}
		if (exitGame_ != null)
		{
			num ^= ExitGame.GetHashCode();
		}
		if (initSettingFinish_ != null)
		{
			num ^= InitSettingFinish.GetHashCode();
		}
		if (settingChange_ != null)
		{
			num ^= SettingChange.GetHashCode();
		}
		if (interact_ != null)
		{
			num ^= Interact.GetHashCode();
		}
		if (monsterFirstMeet_ != null)
		{
			num ^= MonsterFirstMeet.GetHashCode();
		}
		if (gameComplete_ != null)
		{
			num ^= GameComplete.GetHashCode();
		}
		if (playerTransEvent_ != null)
		{
			num ^= PlayerTransEvent.GetHashCode();
		}
		if (gpevent_ != null)
		{
			num ^= Gpevent.GetHashCode();
		}
		if (battle_ != null)
		{
			num ^= Battle.GetHashCode();
		}
		if (bossRushResult_ != null)
		{
			num ^= BossRushResult.GetHashCode();
		}
		if (commValueChange_ != null)
		{
			num ^= CommValueChange.GetHashCode();
		}
		if (winePartnerChange_ != null)
		{
			num ^= WinePartnerChange.GetHashCode();
		}
		if (refine_ != null)
		{
			num ^= Refine.GetHashCode();
		}
		if (task_ != null)
		{
			num ^= Task.GetHashCode();
		}
		if (appLaunch_ != null)
		{
			num ^= AppLaunch.GetHashCode();
		}
		if (execGm_ != null)
		{
			num ^= ExecGm.GetHashCode();
		}
		if (collection_ != null)
		{
			num ^= Collection.GetHashCode();
		}
		if (chapter_ != null)
		{
			num ^= Chapter.GetHashCode();
		}
		if (roleSnapshoot_ != null)
		{
			num ^= RoleSnapshoot.GetHashCode();
		}
		if (inputSettingChange_ != null)
		{
			num ^= InputSettingChange.GetHashCode();
		}
		if (benchMarkResult_ != null)
		{
			num ^= BenchMarkResult.GetHashCode();
		}
		if (gameCrash_ != null)
		{
			num ^= GameCrash.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (EventType.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(EventType);
		}
		if (eventHead_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(EventHead);
		}
		if (guide_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Guide);
		}
		if (createRole_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(CreateRole);
		}
		if (login_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(Login);
		}
		if (logout_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(Logout);
		}
		if (playerDie_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(PlayerDie);
		}
		if (slevelLeave_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(SlevelLeave);
		}
		if (itemChange_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(ItemChange);
		}
		if (createArchive_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(CreateArchive);
		}
		if (deleteArchive_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(DeleteArchive);
		}
		if (itemDrop_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(ItemDrop);
		}
		if (load_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(Load);
		}
		if (harvest_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(Harvest);
		}
		if (exitGame_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(ExitGame);
		}
		if (initSettingFinish_ != null)
		{
			output.WriteRawTag(130, 1);
			output.WriteMessage(InitSettingFinish);
		}
		if (settingChange_ != null)
		{
			output.WriteRawTag(138, 1);
			output.WriteMessage(SettingChange);
		}
		if (interact_ != null)
		{
			output.WriteRawTag(146, 1);
			output.WriteMessage(Interact);
		}
		if (monsterFirstMeet_ != null)
		{
			output.WriteRawTag(154, 1);
			output.WriteMessage(MonsterFirstMeet);
		}
		if (gameComplete_ != null)
		{
			output.WriteRawTag(162, 1);
			output.WriteMessage(GameComplete);
		}
		if (playerTransEvent_ != null)
		{
			output.WriteRawTag(170, 1);
			output.WriteMessage(PlayerTransEvent);
		}
		if (gpevent_ != null)
		{
			output.WriteRawTag(178, 1);
			output.WriteMessage(Gpevent);
		}
		if (battle_ != null)
		{
			output.WriteRawTag(186, 1);
			output.WriteMessage(Battle);
		}
		if (bossRushResult_ != null)
		{
			output.WriteRawTag(194, 1);
			output.WriteMessage(BossRushResult);
		}
		if (commValueChange_ != null)
		{
			output.WriteRawTag(202, 1);
			output.WriteMessage(CommValueChange);
		}
		if (winePartnerChange_ != null)
		{
			output.WriteRawTag(210, 1);
			output.WriteMessage(WinePartnerChange);
		}
		if (refine_ != null)
		{
			output.WriteRawTag(218, 1);
			output.WriteMessage(Refine);
		}
		if (task_ != null)
		{
			output.WriteRawTag(226, 1);
			output.WriteMessage(Task);
		}
		if (appLaunch_ != null)
		{
			output.WriteRawTag(234, 1);
			output.WriteMessage(AppLaunch);
		}
		if (execGm_ != null)
		{
			output.WriteRawTag(242, 1);
			output.WriteMessage(ExecGm);
		}
		if (collection_ != null)
		{
			output.WriteRawTag(250, 1);
			output.WriteMessage(Collection);
		}
		if (chapter_ != null)
		{
			output.WriteRawTag(130, 2);
			output.WriteMessage(Chapter);
		}
		if (roleSnapshoot_ != null)
		{
			output.WriteRawTag(138, 2);
			output.WriteMessage(RoleSnapshoot);
		}
		if (inputSettingChange_ != null)
		{
			output.WriteRawTag(146, 2);
			output.WriteMessage(InputSettingChange);
		}
		if (benchMarkResult_ != null)
		{
			output.WriteRawTag(154, 2);
			output.WriteMessage(BenchMarkResult);
		}
		if (gameCrash_ != null)
		{
			output.WriteRawTag(162, 2);
			output.WriteMessage(GameCrash);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (EventType.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(EventType);
		}
		if (eventHead_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EventHead);
		}
		if (guide_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Guide);
		}
		if (createRole_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CreateRole);
		}
		if (login_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Login);
		}
		if (logout_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Logout);
		}
		if (playerDie_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PlayerDie);
		}
		if (slevelLeave_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SlevelLeave);
		}
		if (itemChange_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ItemChange);
		}
		if (createArchive_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CreateArchive);
		}
		if (deleteArchive_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DeleteArchive);
		}
		if (itemDrop_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ItemDrop);
		}
		if (load_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Load);
		}
		if (harvest_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Harvest);
		}
		if (exitGame_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ExitGame);
		}
		if (initSettingFinish_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(InitSettingFinish);
		}
		if (settingChange_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(SettingChange);
		}
		if (interact_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(Interact);
		}
		if (monsterFirstMeet_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(MonsterFirstMeet);
		}
		if (gameComplete_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(GameComplete);
		}
		if (playerTransEvent_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PlayerTransEvent);
		}
		if (gpevent_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(Gpevent);
		}
		if (battle_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(Battle);
		}
		if (bossRushResult_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BossRushResult);
		}
		if (commValueChange_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(CommValueChange);
		}
		if (winePartnerChange_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(WinePartnerChange);
		}
		if (refine_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(Refine);
		}
		if (task_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(Task);
		}
		if (appLaunch_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(AppLaunch);
		}
		if (execGm_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ExecGm);
		}
		if (collection_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(Collection);
		}
		if (chapter_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(Chapter);
		}
		if (roleSnapshoot_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(RoleSnapshoot);
		}
		if (inputSettingChange_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(InputSettingChange);
		}
		if (benchMarkResult_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BenchMarkResult);
		}
		if (gameCrash_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(GameCrash);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportEvent other)
	{
		if (other == null)
		{
			return;
		}
		if (other.EventType.Length != 0)
		{
			EventType = other.EventType;
		}
		if (other.eventHead_ != null)
		{
			if (eventHead_ == null)
			{
				EventHead = new ReportEventHead();
			}
			EventHead.MergeFrom(other.EventHead);
		}
		if (other.guide_ != null)
		{
			if (guide_ == null)
			{
				Guide = new ReportEventGuide();
			}
			Guide.MergeFrom(other.Guide);
		}
		if (other.createRole_ != null)
		{
			if (createRole_ == null)
			{
				CreateRole = new ReportEventCreateRole();
			}
			CreateRole.MergeFrom(other.CreateRole);
		}
		if (other.login_ != null)
		{
			if (login_ == null)
			{
				Login = new ReportEventLogin();
			}
			Login.MergeFrom(other.Login);
		}
		if (other.logout_ != null)
		{
			if (logout_ == null)
			{
				Logout = new ReportEventLogout();
			}
			Logout.MergeFrom(other.Logout);
		}
		if (other.playerDie_ != null)
		{
			if (playerDie_ == null)
			{
				PlayerDie = new ReportEventPlayerDie();
			}
			PlayerDie.MergeFrom(other.PlayerDie);
		}
		if (other.slevelLeave_ != null)
		{
			if (slevelLeave_ == null)
			{
				SlevelLeave = new ReportEventSlevelLeave();
			}
			SlevelLeave.MergeFrom(other.SlevelLeave);
		}
		if (other.itemChange_ != null)
		{
			if (itemChange_ == null)
			{
				ItemChange = new ReportEventItemChange();
			}
			ItemChange.MergeFrom(other.ItemChange);
		}
		if (other.createArchive_ != null)
		{
			if (createArchive_ == null)
			{
				CreateArchive = new ReportEventCreateArchive();
			}
			CreateArchive.MergeFrom(other.CreateArchive);
		}
		if (other.deleteArchive_ != null)
		{
			if (deleteArchive_ == null)
			{
				DeleteArchive = new ReportEventDeleteArchive();
			}
			DeleteArchive.MergeFrom(other.DeleteArchive);
		}
		if (other.itemDrop_ != null)
		{
			if (itemDrop_ == null)
			{
				ItemDrop = new ReportEventItemDrop();
			}
			ItemDrop.MergeFrom(other.ItemDrop);
		}
		if (other.load_ != null)
		{
			if (load_ == null)
			{
				Load = new ReportEventLoad();
			}
			Load.MergeFrom(other.Load);
		}
		if (other.harvest_ != null)
		{
			if (harvest_ == null)
			{
				Harvest = new ReportEventHarvest();
			}
			Harvest.MergeFrom(other.Harvest);
		}
		if (other.exitGame_ != null)
		{
			if (exitGame_ == null)
			{
				ExitGame = new ReportEventExitGame();
			}
			ExitGame.MergeFrom(other.ExitGame);
		}
		if (other.initSettingFinish_ != null)
		{
			if (initSettingFinish_ == null)
			{
				InitSettingFinish = new ReportEventInitSettingFinish();
			}
			InitSettingFinish.MergeFrom(other.InitSettingFinish);
		}
		if (other.settingChange_ != null)
		{
			if (settingChange_ == null)
			{
				SettingChange = new ReportEventSettingChange();
			}
			SettingChange.MergeFrom(other.SettingChange);
		}
		if (other.interact_ != null)
		{
			if (interact_ == null)
			{
				Interact = new ReportEventInteract();
			}
			Interact.MergeFrom(other.Interact);
		}
		if (other.monsterFirstMeet_ != null)
		{
			if (monsterFirstMeet_ == null)
			{
				MonsterFirstMeet = new ReportEventMonsterFirstMeet();
			}
			MonsterFirstMeet.MergeFrom(other.MonsterFirstMeet);
		}
		if (other.gameComplete_ != null)
		{
			if (gameComplete_ == null)
			{
				GameComplete = new ReportEventGameComplete();
			}
			GameComplete.MergeFrom(other.GameComplete);
		}
		if (other.playerTransEvent_ != null)
		{
			if (playerTransEvent_ == null)
			{
				PlayerTransEvent = new ReportEventPlayerTransEvent();
			}
			PlayerTransEvent.MergeFrom(other.PlayerTransEvent);
		}
		if (other.gpevent_ != null)
		{
			if (gpevent_ == null)
			{
				Gpevent = new ReportEventGPEvent();
			}
			Gpevent.MergeFrom(other.Gpevent);
		}
		if (other.battle_ != null)
		{
			if (battle_ == null)
			{
				Battle = new ReportEventBattle();
			}
			Battle.MergeFrom(other.Battle);
		}
		if (other.bossRushResult_ != null)
		{
			if (bossRushResult_ == null)
			{
				BossRushResult = new ReportEventBossRushResult();
			}
			BossRushResult.MergeFrom(other.BossRushResult);
		}
		if (other.commValueChange_ != null)
		{
			if (commValueChange_ == null)
			{
				CommValueChange = new ReportEventCommValueChange();
			}
			CommValueChange.MergeFrom(other.CommValueChange);
		}
		if (other.winePartnerChange_ != null)
		{
			if (winePartnerChange_ == null)
			{
				WinePartnerChange = new ReportEventWinePartnerChange();
			}
			WinePartnerChange.MergeFrom(other.WinePartnerChange);
		}
		if (other.refine_ != null)
		{
			if (refine_ == null)
			{
				Refine = new ReportEventRefine();
			}
			Refine.MergeFrom(other.Refine);
		}
		if (other.task_ != null)
		{
			if (task_ == null)
			{
				Task = new ReportEventTask();
			}
			Task.MergeFrom(other.Task);
		}
		if (other.appLaunch_ != null)
		{
			if (appLaunch_ == null)
			{
				AppLaunch = new ReportEventAppLaunch();
			}
			AppLaunch.MergeFrom(other.AppLaunch);
		}
		if (other.execGm_ != null)
		{
			if (execGm_ == null)
			{
				ExecGm = new ReportEventExecGM();
			}
			ExecGm.MergeFrom(other.ExecGm);
		}
		if (other.collection_ != null)
		{
			if (collection_ == null)
			{
				Collection = new ReportEventCollection();
			}
			Collection.MergeFrom(other.Collection);
		}
		if (other.chapter_ != null)
		{
			if (chapter_ == null)
			{
				Chapter = new ReportEventChapter();
			}
			Chapter.MergeFrom(other.Chapter);
		}
		if (other.roleSnapshoot_ != null)
		{
			if (roleSnapshoot_ == null)
			{
				RoleSnapshoot = new ReportEventRoleSnapshoot();
			}
			RoleSnapshoot.MergeFrom(other.RoleSnapshoot);
		}
		if (other.inputSettingChange_ != null)
		{
			if (inputSettingChange_ == null)
			{
				InputSettingChange = new ReportEventInputSettingChange();
			}
			InputSettingChange.MergeFrom(other.InputSettingChange);
		}
		if (other.benchMarkResult_ != null)
		{
			if (benchMarkResult_ == null)
			{
				BenchMarkResult = new ReportEventBenchMarkResult();
			}
			BenchMarkResult.MergeFrom(other.BenchMarkResult);
		}
		if (other.gameCrash_ != null)
		{
			if (gameCrash_ == null)
			{
				GameCrash = new ReportEventGameCrash();
			}
			GameCrash.MergeFrom(other.GameCrash);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 10u:
				EventType = input.ReadString();
				break;
			case 18u:
				if (eventHead_ == null)
				{
					EventHead = new ReportEventHead();
				}
				input.ReadMessage(EventHead);
				break;
			case 26u:
				if (guide_ == null)
				{
					Guide = new ReportEventGuide();
				}
				input.ReadMessage(Guide);
				break;
			case 34u:
				if (createRole_ == null)
				{
					CreateRole = new ReportEventCreateRole();
				}
				input.ReadMessage(CreateRole);
				break;
			case 42u:
				if (login_ == null)
				{
					Login = new ReportEventLogin();
				}
				input.ReadMessage(Login);
				break;
			case 50u:
				if (logout_ == null)
				{
					Logout = new ReportEventLogout();
				}
				input.ReadMessage(Logout);
				break;
			case 58u:
				if (playerDie_ == null)
				{
					PlayerDie = new ReportEventPlayerDie();
				}
				input.ReadMessage(PlayerDie);
				break;
			case 66u:
				if (slevelLeave_ == null)
				{
					SlevelLeave = new ReportEventSlevelLeave();
				}
				input.ReadMessage(SlevelLeave);
				break;
			case 74u:
				if (itemChange_ == null)
				{
					ItemChange = new ReportEventItemChange();
				}
				input.ReadMessage(ItemChange);
				break;
			case 82u:
				if (createArchive_ == null)
				{
					CreateArchive = new ReportEventCreateArchive();
				}
				input.ReadMessage(CreateArchive);
				break;
			case 90u:
				if (deleteArchive_ == null)
				{
					DeleteArchive = new ReportEventDeleteArchive();
				}
				input.ReadMessage(DeleteArchive);
				break;
			case 98u:
				if (itemDrop_ == null)
				{
					ItemDrop = new ReportEventItemDrop();
				}
				input.ReadMessage(ItemDrop);
				break;
			case 106u:
				if (load_ == null)
				{
					Load = new ReportEventLoad();
				}
				input.ReadMessage(Load);
				break;
			case 114u:
				if (harvest_ == null)
				{
					Harvest = new ReportEventHarvest();
				}
				input.ReadMessage(Harvest);
				break;
			case 122u:
				if (exitGame_ == null)
				{
					ExitGame = new ReportEventExitGame();
				}
				input.ReadMessage(ExitGame);
				break;
			case 130u:
				if (initSettingFinish_ == null)
				{
					InitSettingFinish = new ReportEventInitSettingFinish();
				}
				input.ReadMessage(InitSettingFinish);
				break;
			case 138u:
				if (settingChange_ == null)
				{
					SettingChange = new ReportEventSettingChange();
				}
				input.ReadMessage(SettingChange);
				break;
			case 146u:
				if (interact_ == null)
				{
					Interact = new ReportEventInteract();
				}
				input.ReadMessage(Interact);
				break;
			case 154u:
				if (monsterFirstMeet_ == null)
				{
					MonsterFirstMeet = new ReportEventMonsterFirstMeet();
				}
				input.ReadMessage(MonsterFirstMeet);
				break;
			case 162u:
				if (gameComplete_ == null)
				{
					GameComplete = new ReportEventGameComplete();
				}
				input.ReadMessage(GameComplete);
				break;
			case 170u:
				if (playerTransEvent_ == null)
				{
					PlayerTransEvent = new ReportEventPlayerTransEvent();
				}
				input.ReadMessage(PlayerTransEvent);
				break;
			case 178u:
				if (gpevent_ == null)
				{
					Gpevent = new ReportEventGPEvent();
				}
				input.ReadMessage(Gpevent);
				break;
			case 186u:
				if (battle_ == null)
				{
					Battle = new ReportEventBattle();
				}
				input.ReadMessage(Battle);
				break;
			case 194u:
				if (bossRushResult_ == null)
				{
					BossRushResult = new ReportEventBossRushResult();
				}
				input.ReadMessage(BossRushResult);
				break;
			case 202u:
				if (commValueChange_ == null)
				{
					CommValueChange = new ReportEventCommValueChange();
				}
				input.ReadMessage(CommValueChange);
				break;
			case 210u:
				if (winePartnerChange_ == null)
				{
					WinePartnerChange = new ReportEventWinePartnerChange();
				}
				input.ReadMessage(WinePartnerChange);
				break;
			case 218u:
				if (refine_ == null)
				{
					Refine = new ReportEventRefine();
				}
				input.ReadMessage(Refine);
				break;
			case 226u:
				if (task_ == null)
				{
					Task = new ReportEventTask();
				}
				input.ReadMessage(Task);
				break;
			case 234u:
				if (appLaunch_ == null)
				{
					AppLaunch = new ReportEventAppLaunch();
				}
				input.ReadMessage(AppLaunch);
				break;
			case 242u:
				if (execGm_ == null)
				{
					ExecGm = new ReportEventExecGM();
				}
				input.ReadMessage(ExecGm);
				break;
			case 250u:
				if (collection_ == null)
				{
					Collection = new ReportEventCollection();
				}
				input.ReadMessage(Collection);
				break;
			case 258u:
				if (chapter_ == null)
				{
					Chapter = new ReportEventChapter();
				}
				input.ReadMessage(Chapter);
				break;
			case 266u:
				if (roleSnapshoot_ == null)
				{
					RoleSnapshoot = new ReportEventRoleSnapshoot();
				}
				input.ReadMessage(RoleSnapshoot);
				break;
			case 274u:
				if (inputSettingChange_ == null)
				{
					InputSettingChange = new ReportEventInputSettingChange();
				}
				input.ReadMessage(InputSettingChange);
				break;
			case 282u:
				if (benchMarkResult_ == null)
				{
					BenchMarkResult = new ReportEventBenchMarkResult();
				}
				input.ReadMessage(BenchMarkResult);
				break;
			case 290u:
				if (gameCrash_ == null)
				{
					GameCrash = new ReportEventGameCrash();
				}
				input.ReadMessage(GameCrash);
				break;
			}
		}
	}
}
