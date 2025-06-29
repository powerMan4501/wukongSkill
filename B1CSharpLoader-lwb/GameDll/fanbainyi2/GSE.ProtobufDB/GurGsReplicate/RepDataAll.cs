using System;
using Google.Protobuf;

namespace GurGsReplicate;

public sealed class RepDataAll : IMessage<RepDataAll>, IMessage, IEquatable<RepDataAll>, IDeepCloneable<RepDataAll>
{
	private static readonly MessageParser<RepDataAll> _parser = new MessageParser<RepDataAll>(() => new RepDataAll());

	private UnknownFieldSet _unknownFields;

	private int version_;

	private int oldVersion_;

	private ABPHelperData aBPHelperData_;

	private AttrContainer attrContainer_;

	private BuffData buffData_;

	private ChargeSkillData chargeSkillData_;

	private FallDyingData fallDyingData_;

	private MontageSyncData montageSyncData_;

	private PredictionTestData predictionTestData_;

	private ReplicateTestData replicateTestData_;

	private SimpleStateData simpleStateData_;

	private TargetInfoData targetInfoData_;

	private UnitHatredData unitHatredData_;

	private UnitStateData unitStateData_;

	private ObjActorMovementData objActorMovementData_;

	private InteractData interactData_;

	private ProjectileBasicData projectileBasicData_;

	private CircusControlData circusControlData_;

	private GameStateTestData gameStateTestData_;

	private LevelAuthorityData levelAuthorityData_;

	private LevelBattleData levelBattleData_;

	private OnlineChallengeData onlineChallengeData_;

	private PlayerStateTestData playerStateTestData_;

	private RoleBaseData roleBaseData_;

	private TransactionData transactionData_;

	public static MessageParser<RepDataAll> Parser => _parser;

	public int Version
	{
		get
		{
			return version_;
		}
		set
		{
			version_ = value;
		}
	}

	public int OldVersion
	{
		get
		{
			return oldVersion_;
		}
		set
		{
			oldVersion_ = value;
		}
	}

	public ABPHelperData ABPHelperData
	{
		get
		{
			return aBPHelperData_;
		}
		set
		{
			aBPHelperData_ = value;
		}
	}

	public AttrContainer AttrContainer
	{
		get
		{
			return attrContainer_;
		}
		set
		{
			attrContainer_ = value;
		}
	}

	public BuffData BuffData
	{
		get
		{
			return buffData_;
		}
		set
		{
			buffData_ = value;
		}
	}

	public ChargeSkillData ChargeSkillData
	{
		get
		{
			return chargeSkillData_;
		}
		set
		{
			chargeSkillData_ = value;
		}
	}

	public FallDyingData FallDyingData
	{
		get
		{
			return fallDyingData_;
		}
		set
		{
			fallDyingData_ = value;
		}
	}

	public MontageSyncData MontageSyncData
	{
		get
		{
			return montageSyncData_;
		}
		set
		{
			montageSyncData_ = value;
		}
	}

	public PredictionTestData PredictionTestData
	{
		get
		{
			return predictionTestData_;
		}
		set
		{
			predictionTestData_ = value;
		}
	}

	public ReplicateTestData ReplicateTestData
	{
		get
		{
			return replicateTestData_;
		}
		set
		{
			replicateTestData_ = value;
		}
	}

	public SimpleStateData SimpleStateData
	{
		get
		{
			return simpleStateData_;
		}
		set
		{
			simpleStateData_ = value;
		}
	}

	public TargetInfoData TargetInfoData
	{
		get
		{
			return targetInfoData_;
		}
		set
		{
			targetInfoData_ = value;
		}
	}

	public UnitHatredData UnitHatredData
	{
		get
		{
			return unitHatredData_;
		}
		set
		{
			unitHatredData_ = value;
		}
	}

	public UnitStateData UnitStateData
	{
		get
		{
			return unitStateData_;
		}
		set
		{
			unitStateData_ = value;
		}
	}

	public ObjActorMovementData ObjActorMovementData
	{
		get
		{
			return objActorMovementData_;
		}
		set
		{
			objActorMovementData_ = value;
		}
	}

	public InteractData InteractData
	{
		get
		{
			return interactData_;
		}
		set
		{
			interactData_ = value;
		}
	}

	public ProjectileBasicData ProjectileBasicData
	{
		get
		{
			return projectileBasicData_;
		}
		set
		{
			projectileBasicData_ = value;
		}
	}

	public CircusControlData CircusControlData
	{
		get
		{
			return circusControlData_;
		}
		set
		{
			circusControlData_ = value;
		}
	}

	public GameStateTestData GameStateTestData
	{
		get
		{
			return gameStateTestData_;
		}
		set
		{
			gameStateTestData_ = value;
		}
	}

	public LevelAuthorityData LevelAuthorityData
	{
		get
		{
			return levelAuthorityData_;
		}
		set
		{
			levelAuthorityData_ = value;
		}
	}

	public LevelBattleData LevelBattleData
	{
		get
		{
			return levelBattleData_;
		}
		set
		{
			levelBattleData_ = value;
		}
	}

	public OnlineChallengeData OnlineChallengeData
	{
		get
		{
			return onlineChallengeData_;
		}
		set
		{
			onlineChallengeData_ = value;
		}
	}

	public PlayerStateTestData PlayerStateTestData
	{
		get
		{
			return playerStateTestData_;
		}
		set
		{
			playerStateTestData_ = value;
		}
	}

	public RoleBaseData RoleBaseData
	{
		get
		{
			return roleBaseData_;
		}
		set
		{
			roleBaseData_ = value;
		}
	}

	public TransactionData TransactionData
	{
		get
		{
			return transactionData_;
		}
		set
		{
			transactionData_ = value;
		}
	}

	public RepDataAll()
	{
	}

	public RepDataAll(RepDataAll other)
		: this()
	{
		version_ = other.version_;
		oldVersion_ = other.oldVersion_;
		aBPHelperData_ = ((other.aBPHelperData_ != null) ? other.aBPHelperData_.Clone() : null);
		attrContainer_ = ((other.attrContainer_ != null) ? other.attrContainer_.Clone() : null);
		buffData_ = ((other.buffData_ != null) ? other.buffData_.Clone() : null);
		chargeSkillData_ = ((other.chargeSkillData_ != null) ? other.chargeSkillData_.Clone() : null);
		fallDyingData_ = ((other.fallDyingData_ != null) ? other.fallDyingData_.Clone() : null);
		montageSyncData_ = ((other.montageSyncData_ != null) ? other.montageSyncData_.Clone() : null);
		predictionTestData_ = ((other.predictionTestData_ != null) ? other.predictionTestData_.Clone() : null);
		replicateTestData_ = ((other.replicateTestData_ != null) ? other.replicateTestData_.Clone() : null);
		simpleStateData_ = ((other.simpleStateData_ != null) ? other.simpleStateData_.Clone() : null);
		targetInfoData_ = ((other.targetInfoData_ != null) ? other.targetInfoData_.Clone() : null);
		unitHatredData_ = ((other.unitHatredData_ != null) ? other.unitHatredData_.Clone() : null);
		unitStateData_ = ((other.unitStateData_ != null) ? other.unitStateData_.Clone() : null);
		objActorMovementData_ = ((other.objActorMovementData_ != null) ? other.objActorMovementData_.Clone() : null);
		interactData_ = ((other.interactData_ != null) ? other.interactData_.Clone() : null);
		projectileBasicData_ = ((other.projectileBasicData_ != null) ? other.projectileBasicData_.Clone() : null);
		circusControlData_ = ((other.circusControlData_ != null) ? other.circusControlData_.Clone() : null);
		gameStateTestData_ = ((other.gameStateTestData_ != null) ? other.gameStateTestData_.Clone() : null);
		levelAuthorityData_ = ((other.levelAuthorityData_ != null) ? other.levelAuthorityData_.Clone() : null);
		levelBattleData_ = ((other.levelBattleData_ != null) ? other.levelBattleData_.Clone() : null);
		onlineChallengeData_ = ((other.onlineChallengeData_ != null) ? other.onlineChallengeData_.Clone() : null);
		playerStateTestData_ = ((other.playerStateTestData_ != null) ? other.playerStateTestData_.Clone() : null);
		roleBaseData_ = ((other.roleBaseData_ != null) ? other.roleBaseData_.Clone() : null);
		transactionData_ = ((other.transactionData_ != null) ? other.transactionData_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RepDataAll Clone()
	{
		return new RepDataAll(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RepDataAll);
	}

	public bool Equals(RepDataAll other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Version != other.Version)
		{
			return false;
		}
		if (OldVersion != other.OldVersion)
		{
			return false;
		}
		if (!object.Equals(ABPHelperData, other.ABPHelperData))
		{
			return false;
		}
		if (!object.Equals(AttrContainer, other.AttrContainer))
		{
			return false;
		}
		if (!object.Equals(BuffData, other.BuffData))
		{
			return false;
		}
		if (!object.Equals(ChargeSkillData, other.ChargeSkillData))
		{
			return false;
		}
		if (!object.Equals(FallDyingData, other.FallDyingData))
		{
			return false;
		}
		if (!object.Equals(MontageSyncData, other.MontageSyncData))
		{
			return false;
		}
		if (!object.Equals(PredictionTestData, other.PredictionTestData))
		{
			return false;
		}
		if (!object.Equals(ReplicateTestData, other.ReplicateTestData))
		{
			return false;
		}
		if (!object.Equals(SimpleStateData, other.SimpleStateData))
		{
			return false;
		}
		if (!object.Equals(TargetInfoData, other.TargetInfoData))
		{
			return false;
		}
		if (!object.Equals(UnitHatredData, other.UnitHatredData))
		{
			return false;
		}
		if (!object.Equals(UnitStateData, other.UnitStateData))
		{
			return false;
		}
		if (!object.Equals(ObjActorMovementData, other.ObjActorMovementData))
		{
			return false;
		}
		if (!object.Equals(InteractData, other.InteractData))
		{
			return false;
		}
		if (!object.Equals(ProjectileBasicData, other.ProjectileBasicData))
		{
			return false;
		}
		if (!object.Equals(CircusControlData, other.CircusControlData))
		{
			return false;
		}
		if (!object.Equals(GameStateTestData, other.GameStateTestData))
		{
			return false;
		}
		if (!object.Equals(LevelAuthorityData, other.LevelAuthorityData))
		{
			return false;
		}
		if (!object.Equals(LevelBattleData, other.LevelBattleData))
		{
			return false;
		}
		if (!object.Equals(OnlineChallengeData, other.OnlineChallengeData))
		{
			return false;
		}
		if (!object.Equals(PlayerStateTestData, other.PlayerStateTestData))
		{
			return false;
		}
		if (!object.Equals(RoleBaseData, other.RoleBaseData))
		{
			return false;
		}
		if (!object.Equals(TransactionData, other.TransactionData))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Version != 0)
		{
			num ^= Version.GetHashCode();
		}
		if (OldVersion != 0)
		{
			num ^= OldVersion.GetHashCode();
		}
		if (aBPHelperData_ != null)
		{
			num ^= ABPHelperData.GetHashCode();
		}
		if (attrContainer_ != null)
		{
			num ^= AttrContainer.GetHashCode();
		}
		if (buffData_ != null)
		{
			num ^= BuffData.GetHashCode();
		}
		if (chargeSkillData_ != null)
		{
			num ^= ChargeSkillData.GetHashCode();
		}
		if (fallDyingData_ != null)
		{
			num ^= FallDyingData.GetHashCode();
		}
		if (montageSyncData_ != null)
		{
			num ^= MontageSyncData.GetHashCode();
		}
		if (predictionTestData_ != null)
		{
			num ^= PredictionTestData.GetHashCode();
		}
		if (replicateTestData_ != null)
		{
			num ^= ReplicateTestData.GetHashCode();
		}
		if (simpleStateData_ != null)
		{
			num ^= SimpleStateData.GetHashCode();
		}
		if (targetInfoData_ != null)
		{
			num ^= TargetInfoData.GetHashCode();
		}
		if (unitHatredData_ != null)
		{
			num ^= UnitHatredData.GetHashCode();
		}
		if (unitStateData_ != null)
		{
			num ^= UnitStateData.GetHashCode();
		}
		if (objActorMovementData_ != null)
		{
			num ^= ObjActorMovementData.GetHashCode();
		}
		if (interactData_ != null)
		{
			num ^= InteractData.GetHashCode();
		}
		if (projectileBasicData_ != null)
		{
			num ^= ProjectileBasicData.GetHashCode();
		}
		if (circusControlData_ != null)
		{
			num ^= CircusControlData.GetHashCode();
		}
		if (gameStateTestData_ != null)
		{
			num ^= GameStateTestData.GetHashCode();
		}
		if (levelAuthorityData_ != null)
		{
			num ^= LevelAuthorityData.GetHashCode();
		}
		if (levelBattleData_ != null)
		{
			num ^= LevelBattleData.GetHashCode();
		}
		if (onlineChallengeData_ != null)
		{
			num ^= OnlineChallengeData.GetHashCode();
		}
		if (playerStateTestData_ != null)
		{
			num ^= PlayerStateTestData.GetHashCode();
		}
		if (roleBaseData_ != null)
		{
			num ^= RoleBaseData.GetHashCode();
		}
		if (transactionData_ != null)
		{
			num ^= TransactionData.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Version != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Version);
		}
		if (OldVersion != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(OldVersion);
		}
		if (aBPHelperData_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(ABPHelperData);
		}
		if (attrContainer_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(AttrContainer);
		}
		if (buffData_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(BuffData);
		}
		if (chargeSkillData_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(ChargeSkillData);
		}
		if (fallDyingData_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(FallDyingData);
		}
		if (montageSyncData_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(MontageSyncData);
		}
		if (predictionTestData_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(PredictionTestData);
		}
		if (replicateTestData_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(ReplicateTestData);
		}
		if (simpleStateData_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(SimpleStateData);
		}
		if (targetInfoData_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(TargetInfoData);
		}
		if (unitHatredData_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(UnitHatredData);
		}
		if (unitStateData_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(UnitStateData);
		}
		if (objActorMovementData_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(ObjActorMovementData);
		}
		if (interactData_ != null)
		{
			output.WriteRawTag(130, 1);
			output.WriteMessage(InteractData);
		}
		if (projectileBasicData_ != null)
		{
			output.WriteRawTag(138, 1);
			output.WriteMessage(ProjectileBasicData);
		}
		if (circusControlData_ != null)
		{
			output.WriteRawTag(146, 1);
			output.WriteMessage(CircusControlData);
		}
		if (gameStateTestData_ != null)
		{
			output.WriteRawTag(154, 1);
			output.WriteMessage(GameStateTestData);
		}
		if (levelAuthorityData_ != null)
		{
			output.WriteRawTag(162, 1);
			output.WriteMessage(LevelAuthorityData);
		}
		if (levelBattleData_ != null)
		{
			output.WriteRawTag(170, 1);
			output.WriteMessage(LevelBattleData);
		}
		if (onlineChallengeData_ != null)
		{
			output.WriteRawTag(178, 1);
			output.WriteMessage(OnlineChallengeData);
		}
		if (playerStateTestData_ != null)
		{
			output.WriteRawTag(186, 1);
			output.WriteMessage(PlayerStateTestData);
		}
		if (roleBaseData_ != null)
		{
			output.WriteRawTag(194, 1);
			output.WriteMessage(RoleBaseData);
		}
		if (transactionData_ != null)
		{
			output.WriteRawTag(202, 1);
			output.WriteMessage(TransactionData);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Version != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Version);
		}
		if (OldVersion != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OldVersion);
		}
		if (aBPHelperData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ABPHelperData);
		}
		if (attrContainer_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AttrContainer);
		}
		if (buffData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BuffData);
		}
		if (chargeSkillData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ChargeSkillData);
		}
		if (fallDyingData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FallDyingData);
		}
		if (montageSyncData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MontageSyncData);
		}
		if (predictionTestData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PredictionTestData);
		}
		if (replicateTestData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ReplicateTestData);
		}
		if (simpleStateData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SimpleStateData);
		}
		if (targetInfoData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TargetInfoData);
		}
		if (unitHatredData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(UnitHatredData);
		}
		if (unitStateData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(UnitStateData);
		}
		if (objActorMovementData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ObjActorMovementData);
		}
		if (interactData_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(InteractData);
		}
		if (projectileBasicData_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ProjectileBasicData);
		}
		if (circusControlData_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(CircusControlData);
		}
		if (gameStateTestData_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(GameStateTestData);
		}
		if (levelAuthorityData_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(LevelAuthorityData);
		}
		if (levelBattleData_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(LevelBattleData);
		}
		if (onlineChallengeData_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(OnlineChallengeData);
		}
		if (playerStateTestData_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PlayerStateTestData);
		}
		if (roleBaseData_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(RoleBaseData);
		}
		if (transactionData_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(TransactionData);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RepDataAll other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Version != 0)
		{
			Version = other.Version;
		}
		if (other.OldVersion != 0)
		{
			OldVersion = other.OldVersion;
		}
		if (other.aBPHelperData_ != null)
		{
			if (aBPHelperData_ == null)
			{
				ABPHelperData = new ABPHelperData();
			}
			ABPHelperData.MergeFrom(other.ABPHelperData);
		}
		if (other.attrContainer_ != null)
		{
			if (attrContainer_ == null)
			{
				AttrContainer = new AttrContainer();
			}
			AttrContainer.MergeFrom(other.AttrContainer);
		}
		if (other.buffData_ != null)
		{
			if (buffData_ == null)
			{
				BuffData = new BuffData();
			}
			BuffData.MergeFrom(other.BuffData);
		}
		if (other.chargeSkillData_ != null)
		{
			if (chargeSkillData_ == null)
			{
				ChargeSkillData = new ChargeSkillData();
			}
			ChargeSkillData.MergeFrom(other.ChargeSkillData);
		}
		if (other.fallDyingData_ != null)
		{
			if (fallDyingData_ == null)
			{
				FallDyingData = new FallDyingData();
			}
			FallDyingData.MergeFrom(other.FallDyingData);
		}
		if (other.montageSyncData_ != null)
		{
			if (montageSyncData_ == null)
			{
				MontageSyncData = new MontageSyncData();
			}
			MontageSyncData.MergeFrom(other.MontageSyncData);
		}
		if (other.predictionTestData_ != null)
		{
			if (predictionTestData_ == null)
			{
				PredictionTestData = new PredictionTestData();
			}
			PredictionTestData.MergeFrom(other.PredictionTestData);
		}
		if (other.replicateTestData_ != null)
		{
			if (replicateTestData_ == null)
			{
				ReplicateTestData = new ReplicateTestData();
			}
			ReplicateTestData.MergeFrom(other.ReplicateTestData);
		}
		if (other.simpleStateData_ != null)
		{
			if (simpleStateData_ == null)
			{
				SimpleStateData = new SimpleStateData();
			}
			SimpleStateData.MergeFrom(other.SimpleStateData);
		}
		if (other.targetInfoData_ != null)
		{
			if (targetInfoData_ == null)
			{
				TargetInfoData = new TargetInfoData();
			}
			TargetInfoData.MergeFrom(other.TargetInfoData);
		}
		if (other.unitHatredData_ != null)
		{
			if (unitHatredData_ == null)
			{
				UnitHatredData = new UnitHatredData();
			}
			UnitHatredData.MergeFrom(other.UnitHatredData);
		}
		if (other.unitStateData_ != null)
		{
			if (unitStateData_ == null)
			{
				UnitStateData = new UnitStateData();
			}
			UnitStateData.MergeFrom(other.UnitStateData);
		}
		if (other.objActorMovementData_ != null)
		{
			if (objActorMovementData_ == null)
			{
				ObjActorMovementData = new ObjActorMovementData();
			}
			ObjActorMovementData.MergeFrom(other.ObjActorMovementData);
		}
		if (other.interactData_ != null)
		{
			if (interactData_ == null)
			{
				InteractData = new InteractData();
			}
			InteractData.MergeFrom(other.InteractData);
		}
		if (other.projectileBasicData_ != null)
		{
			if (projectileBasicData_ == null)
			{
				ProjectileBasicData = new ProjectileBasicData();
			}
			ProjectileBasicData.MergeFrom(other.ProjectileBasicData);
		}
		if (other.circusControlData_ != null)
		{
			if (circusControlData_ == null)
			{
				CircusControlData = new CircusControlData();
			}
			CircusControlData.MergeFrom(other.CircusControlData);
		}
		if (other.gameStateTestData_ != null)
		{
			if (gameStateTestData_ == null)
			{
				GameStateTestData = new GameStateTestData();
			}
			GameStateTestData.MergeFrom(other.GameStateTestData);
		}
		if (other.levelAuthorityData_ != null)
		{
			if (levelAuthorityData_ == null)
			{
				LevelAuthorityData = new LevelAuthorityData();
			}
			LevelAuthorityData.MergeFrom(other.LevelAuthorityData);
		}
		if (other.levelBattleData_ != null)
		{
			if (levelBattleData_ == null)
			{
				LevelBattleData = new LevelBattleData();
			}
			LevelBattleData.MergeFrom(other.LevelBattleData);
		}
		if (other.onlineChallengeData_ != null)
		{
			if (onlineChallengeData_ == null)
			{
				OnlineChallengeData = new OnlineChallengeData();
			}
			OnlineChallengeData.MergeFrom(other.OnlineChallengeData);
		}
		if (other.playerStateTestData_ != null)
		{
			if (playerStateTestData_ == null)
			{
				PlayerStateTestData = new PlayerStateTestData();
			}
			PlayerStateTestData.MergeFrom(other.PlayerStateTestData);
		}
		if (other.roleBaseData_ != null)
		{
			if (roleBaseData_ == null)
			{
				RoleBaseData = new RoleBaseData();
			}
			RoleBaseData.MergeFrom(other.RoleBaseData);
		}
		if (other.transactionData_ != null)
		{
			if (transactionData_ == null)
			{
				TransactionData = new TransactionData();
			}
			TransactionData.MergeFrom(other.TransactionData);
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
			case 8u:
				Version = input.ReadInt32();
				break;
			case 16u:
				OldVersion = input.ReadInt32();
				break;
			case 26u:
				if (aBPHelperData_ == null)
				{
					ABPHelperData = new ABPHelperData();
				}
				input.ReadMessage(ABPHelperData);
				break;
			case 34u:
				if (attrContainer_ == null)
				{
					AttrContainer = new AttrContainer();
				}
				input.ReadMessage(AttrContainer);
				break;
			case 42u:
				if (buffData_ == null)
				{
					BuffData = new BuffData();
				}
				input.ReadMessage(BuffData);
				break;
			case 50u:
				if (chargeSkillData_ == null)
				{
					ChargeSkillData = new ChargeSkillData();
				}
				input.ReadMessage(ChargeSkillData);
				break;
			case 58u:
				if (fallDyingData_ == null)
				{
					FallDyingData = new FallDyingData();
				}
				input.ReadMessage(FallDyingData);
				break;
			case 66u:
				if (montageSyncData_ == null)
				{
					MontageSyncData = new MontageSyncData();
				}
				input.ReadMessage(MontageSyncData);
				break;
			case 74u:
				if (predictionTestData_ == null)
				{
					PredictionTestData = new PredictionTestData();
				}
				input.ReadMessage(PredictionTestData);
				break;
			case 82u:
				if (replicateTestData_ == null)
				{
					ReplicateTestData = new ReplicateTestData();
				}
				input.ReadMessage(ReplicateTestData);
				break;
			case 90u:
				if (simpleStateData_ == null)
				{
					SimpleStateData = new SimpleStateData();
				}
				input.ReadMessage(SimpleStateData);
				break;
			case 98u:
				if (targetInfoData_ == null)
				{
					TargetInfoData = new TargetInfoData();
				}
				input.ReadMessage(TargetInfoData);
				break;
			case 106u:
				if (unitHatredData_ == null)
				{
					UnitHatredData = new UnitHatredData();
				}
				input.ReadMessage(UnitHatredData);
				break;
			case 114u:
				if (unitStateData_ == null)
				{
					UnitStateData = new UnitStateData();
				}
				input.ReadMessage(UnitStateData);
				break;
			case 122u:
				if (objActorMovementData_ == null)
				{
					ObjActorMovementData = new ObjActorMovementData();
				}
				input.ReadMessage(ObjActorMovementData);
				break;
			case 130u:
				if (interactData_ == null)
				{
					InteractData = new InteractData();
				}
				input.ReadMessage(InteractData);
				break;
			case 138u:
				if (projectileBasicData_ == null)
				{
					ProjectileBasicData = new ProjectileBasicData();
				}
				input.ReadMessage(ProjectileBasicData);
				break;
			case 146u:
				if (circusControlData_ == null)
				{
					CircusControlData = new CircusControlData();
				}
				input.ReadMessage(CircusControlData);
				break;
			case 154u:
				if (gameStateTestData_ == null)
				{
					GameStateTestData = new GameStateTestData();
				}
				input.ReadMessage(GameStateTestData);
				break;
			case 162u:
				if (levelAuthorityData_ == null)
				{
					LevelAuthorityData = new LevelAuthorityData();
				}
				input.ReadMessage(LevelAuthorityData);
				break;
			case 170u:
				if (levelBattleData_ == null)
				{
					LevelBattleData = new LevelBattleData();
				}
				input.ReadMessage(LevelBattleData);
				break;
			case 178u:
				if (onlineChallengeData_ == null)
				{
					OnlineChallengeData = new OnlineChallengeData();
				}
				input.ReadMessage(OnlineChallengeData);
				break;
			case 186u:
				if (playerStateTestData_ == null)
				{
					PlayerStateTestData = new PlayerStateTestData();
				}
				input.ReadMessage(PlayerStateTestData);
				break;
			case 194u:
				if (roleBaseData_ == null)
				{
					RoleBaseData = new RoleBaseData();
				}
				input.ReadMessage(RoleBaseData);
				break;
			case 202u:
				if (transactionData_ == null)
				{
					TransactionData = new TransactionData();
				}
				input.ReadMessage(TransactionData);
				break;
			}
		}
	}
}
