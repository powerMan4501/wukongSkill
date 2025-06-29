using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlU3;

public sealed class FUStB2DSkillSDesc : IMessage<FUStB2DSkillSDesc>, IMessage, IEquatable<FUStB2DSkillSDesc>, IDeepCloneable<FUStB2DSkillSDesc>
{
	private static readonly MessageParser<FUStB2DSkillSDesc> _parser = new MessageParser<FUStB2DSkillSDesc>(() => new FUStB2DSkillSDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int level_;

	private EB2DEffectRangeTargetBase targetBase_;

	private int targetFilter_;

	private int targetBaseParam1_;

	private int targetBaseParam2_;

	private int targetBaseParam3_;

	private int targetBaseParam4_;

	private EB2DSkillTriggerEvent triggerEvent_;

	private int triggerEventParam_;

	private string templatePath_ = "";

	private float mpCost_;

	private float preCooldownTime_;

	private float cooldownTime_;

	private int priority_;

	private int range_;

	private int manualShowtime_;

	private int dragMutex_;

	private int dragMutexTime_;

	private int breakOnTargetDead_;

	private EB2DDispRangeType skillRange_;

	private int skillRangeParam1_;

	private int skillRangeParam2_;

	private EB2DSkillType skillType_;

	private EB2DEffectRangeTargetBase minorTargetBase_;

	private int skillHatredCoefficient_;

	private int skillConstHatred_;

	private int levelHatredCoefficient_;

	public static MessageParser<FUStB2DSkillSDesc> Parser => _parser;

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public int Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	public EB2DEffectRangeTargetBase TargetBase
	{
		get
		{
			return targetBase_;
		}
		set
		{
			targetBase_ = value;
		}
	}

	public int TargetFilter
	{
		get
		{
			return targetFilter_;
		}
		set
		{
			targetFilter_ = value;
		}
	}

	public int TargetBaseParam1
	{
		get
		{
			return targetBaseParam1_;
		}
		set
		{
			targetBaseParam1_ = value;
		}
	}

	public int TargetBaseParam2
	{
		get
		{
			return targetBaseParam2_;
		}
		set
		{
			targetBaseParam2_ = value;
		}
	}

	public int TargetBaseParam3
	{
		get
		{
			return targetBaseParam3_;
		}
		set
		{
			targetBaseParam3_ = value;
		}
	}

	public int TargetBaseParam4
	{
		get
		{
			return targetBaseParam4_;
		}
		set
		{
			targetBaseParam4_ = value;
		}
	}

	public EB2DSkillTriggerEvent TriggerEvent
	{
		get
		{
			return triggerEvent_;
		}
		set
		{
			triggerEvent_ = value;
		}
	}

	public int TriggerEventParam
	{
		get
		{
			return triggerEventParam_;
		}
		set
		{
			triggerEventParam_ = value;
		}
	}

	public string TemplatePath
	{
		get
		{
			return templatePath_;
		}
		set
		{
			templatePath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public float MpCost
	{
		get
		{
			return mpCost_;
		}
		set
		{
			mpCost_ = value;
		}
	}

	public float PreCooldownTime
	{
		get
		{
			return preCooldownTime_;
		}
		set
		{
			preCooldownTime_ = value;
		}
	}

	public float CooldownTime
	{
		get
		{
			return cooldownTime_;
		}
		set
		{
			cooldownTime_ = value;
		}
	}

	public int Priority
	{
		get
		{
			return priority_;
		}
		set
		{
			priority_ = value;
		}
	}

	public int Range
	{
		get
		{
			return range_;
		}
		set
		{
			range_ = value;
		}
	}

	public int ManualShowtime
	{
		get
		{
			return manualShowtime_;
		}
		set
		{
			manualShowtime_ = value;
		}
	}

	public int DragMutex
	{
		get
		{
			return dragMutex_;
		}
		set
		{
			dragMutex_ = value;
		}
	}

	public int DragMutexTime
	{
		get
		{
			return dragMutexTime_;
		}
		set
		{
			dragMutexTime_ = value;
		}
	}

	public int BreakOnTargetDead
	{
		get
		{
			return breakOnTargetDead_;
		}
		set
		{
			breakOnTargetDead_ = value;
		}
	}

	public EB2DDispRangeType SkillRange
	{
		get
		{
			return skillRange_;
		}
		set
		{
			skillRange_ = value;
		}
	}

	public int SkillRangeParam1
	{
		get
		{
			return skillRangeParam1_;
		}
		set
		{
			skillRangeParam1_ = value;
		}
	}

	public int SkillRangeParam2
	{
		get
		{
			return skillRangeParam2_;
		}
		set
		{
			skillRangeParam2_ = value;
		}
	}

	public EB2DSkillType SkillType
	{
		get
		{
			return skillType_;
		}
		set
		{
			skillType_ = value;
		}
	}

	public EB2DEffectRangeTargetBase MinorTargetBase
	{
		get
		{
			return minorTargetBase_;
		}
		set
		{
			minorTargetBase_ = value;
		}
	}

	public int SkillHatredCoefficient
	{
		get
		{
			return skillHatredCoefficient_;
		}
		set
		{
			skillHatredCoefficient_ = value;
		}
	}

	public int SkillConstHatred
	{
		get
		{
			return skillConstHatred_;
		}
		set
		{
			skillConstHatred_ = value;
		}
	}

	public int LevelHatredCoefficient
	{
		get
		{
			return levelHatredCoefficient_;
		}
		set
		{
			levelHatredCoefficient_ = value;
		}
	}

	public FUStB2DSkillSDesc()
	{
	}

	public FUStB2DSkillSDesc(FUStB2DSkillSDesc other)
		: this()
	{
		id_ = other.id_;
		level_ = other.level_;
		targetBase_ = other.targetBase_;
		targetFilter_ = other.targetFilter_;
		targetBaseParam1_ = other.targetBaseParam1_;
		targetBaseParam2_ = other.targetBaseParam2_;
		targetBaseParam3_ = other.targetBaseParam3_;
		targetBaseParam4_ = other.targetBaseParam4_;
		triggerEvent_ = other.triggerEvent_;
		triggerEventParam_ = other.triggerEventParam_;
		templatePath_ = other.templatePath_;
		mpCost_ = other.mpCost_;
		preCooldownTime_ = other.preCooldownTime_;
		cooldownTime_ = other.cooldownTime_;
		priority_ = other.priority_;
		range_ = other.range_;
		manualShowtime_ = other.manualShowtime_;
		dragMutex_ = other.dragMutex_;
		dragMutexTime_ = other.dragMutexTime_;
		breakOnTargetDead_ = other.breakOnTargetDead_;
		skillRange_ = other.skillRange_;
		skillRangeParam1_ = other.skillRangeParam1_;
		skillRangeParam2_ = other.skillRangeParam2_;
		skillType_ = other.skillType_;
		minorTargetBase_ = other.minorTargetBase_;
		skillHatredCoefficient_ = other.skillHatredCoefficient_;
		skillConstHatred_ = other.skillConstHatred_;
		levelHatredCoefficient_ = other.levelHatredCoefficient_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStB2DSkillSDesc Clone()
	{
		return new FUStB2DSkillSDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStB2DSkillSDesc);
	}

	public bool Equals(FUStB2DSkillSDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (TargetBase != other.TargetBase)
		{
			return false;
		}
		if (TargetFilter != other.TargetFilter)
		{
			return false;
		}
		if (TargetBaseParam1 != other.TargetBaseParam1)
		{
			return false;
		}
		if (TargetBaseParam2 != other.TargetBaseParam2)
		{
			return false;
		}
		if (TargetBaseParam3 != other.TargetBaseParam3)
		{
			return false;
		}
		if (TargetBaseParam4 != other.TargetBaseParam4)
		{
			return false;
		}
		if (TriggerEvent != other.TriggerEvent)
		{
			return false;
		}
		if (TriggerEventParam != other.TriggerEventParam)
		{
			return false;
		}
		if (TemplatePath != other.TemplatePath)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MpCost, other.MpCost))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PreCooldownTime, other.PreCooldownTime))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CooldownTime, other.CooldownTime))
		{
			return false;
		}
		if (Priority != other.Priority)
		{
			return false;
		}
		if (Range != other.Range)
		{
			return false;
		}
		if (ManualShowtime != other.ManualShowtime)
		{
			return false;
		}
		if (DragMutex != other.DragMutex)
		{
			return false;
		}
		if (DragMutexTime != other.DragMutexTime)
		{
			return false;
		}
		if (BreakOnTargetDead != other.BreakOnTargetDead)
		{
			return false;
		}
		if (SkillRange != other.SkillRange)
		{
			return false;
		}
		if (SkillRangeParam1 != other.SkillRangeParam1)
		{
			return false;
		}
		if (SkillRangeParam2 != other.SkillRangeParam2)
		{
			return false;
		}
		if (SkillType != other.SkillType)
		{
			return false;
		}
		if (MinorTargetBase != other.MinorTargetBase)
		{
			return false;
		}
		if (SkillHatredCoefficient != other.SkillHatredCoefficient)
		{
			return false;
		}
		if (SkillConstHatred != other.SkillConstHatred)
		{
			return false;
		}
		if (LevelHatredCoefficient != other.LevelHatredCoefficient)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (TargetBase != EB2DEffectRangeTargetBase.Auto)
		{
			num ^= TargetBase.GetHashCode();
		}
		if (TargetFilter != 0)
		{
			num ^= TargetFilter.GetHashCode();
		}
		if (TargetBaseParam1 != 0)
		{
			num ^= TargetBaseParam1.GetHashCode();
		}
		if (TargetBaseParam2 != 0)
		{
			num ^= TargetBaseParam2.GetHashCode();
		}
		if (TargetBaseParam3 != 0)
		{
			num ^= TargetBaseParam3.GetHashCode();
		}
		if (TargetBaseParam4 != 0)
		{
			num ^= TargetBaseParam4.GetHashCode();
		}
		if (TriggerEvent != EB2DSkillTriggerEvent.Auto)
		{
			num ^= TriggerEvent.GetHashCode();
		}
		if (TriggerEventParam != 0)
		{
			num ^= TriggerEventParam.GetHashCode();
		}
		if (TemplatePath.Length != 0)
		{
			num ^= TemplatePath.GetHashCode();
		}
		if (MpCost != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MpCost);
		}
		if (PreCooldownTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PreCooldownTime);
		}
		if (CooldownTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CooldownTime);
		}
		if (Priority != 0)
		{
			num ^= Priority.GetHashCode();
		}
		if (Range != 0)
		{
			num ^= Range.GetHashCode();
		}
		if (ManualShowtime != 0)
		{
			num ^= ManualShowtime.GetHashCode();
		}
		if (DragMutex != 0)
		{
			num ^= DragMutex.GetHashCode();
		}
		if (DragMutexTime != 0)
		{
			num ^= DragMutexTime.GetHashCode();
		}
		if (BreakOnTargetDead != 0)
		{
			num ^= BreakOnTargetDead.GetHashCode();
		}
		if (SkillRange != EB2DDispRangeType.TargetBaseObj)
		{
			num ^= SkillRange.GetHashCode();
		}
		if (SkillRangeParam1 != 0)
		{
			num ^= SkillRangeParam1.GetHashCode();
		}
		if (SkillRangeParam2 != 0)
		{
			num ^= SkillRangeParam2.GetHashCode();
		}
		if (SkillType != EB2DSkillType.Normal)
		{
			num ^= SkillType.GetHashCode();
		}
		if (MinorTargetBase != EB2DEffectRangeTargetBase.Auto)
		{
			num ^= MinorTargetBase.GetHashCode();
		}
		if (SkillHatredCoefficient != 0)
		{
			num ^= SkillHatredCoefficient.GetHashCode();
		}
		if (SkillConstHatred != 0)
		{
			num ^= SkillConstHatred.GetHashCode();
		}
		if (LevelHatredCoefficient != 0)
		{
			num ^= LevelHatredCoefficient.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (Level != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Level);
		}
		if (TargetBase != EB2DEffectRangeTargetBase.Auto)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)TargetBase);
		}
		if (TargetFilter != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(TargetFilter);
		}
		if (TargetBaseParam1 != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(TargetBaseParam1);
		}
		if (TargetBaseParam2 != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(TargetBaseParam2);
		}
		if (TargetBaseParam3 != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(TargetBaseParam3);
		}
		if (TargetBaseParam4 != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(TargetBaseParam4);
		}
		if (TriggerEvent != EB2DSkillTriggerEvent.Auto)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)TriggerEvent);
		}
		if (TriggerEventParam != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(TriggerEventParam);
		}
		if (TemplatePath.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(TemplatePath);
		}
		if (MpCost != 0f)
		{
			output.WriteRawTag(101);
			output.WriteFloat(MpCost);
		}
		if (PreCooldownTime != 0f)
		{
			output.WriteRawTag(109);
			output.WriteFloat(PreCooldownTime);
		}
		if (CooldownTime != 0f)
		{
			output.WriteRawTag(117);
			output.WriteFloat(CooldownTime);
		}
		if (Priority != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(Priority);
		}
		if (Range != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(Range);
		}
		if (ManualShowtime != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(ManualShowtime);
		}
		if (DragMutex != 0)
		{
			output.WriteRawTag(144, 1);
			output.WriteInt32(DragMutex);
		}
		if (DragMutexTime != 0)
		{
			output.WriteRawTag(152, 1);
			output.WriteInt32(DragMutexTime);
		}
		if (BreakOnTargetDead != 0)
		{
			output.WriteRawTag(160, 1);
			output.WriteInt32(BreakOnTargetDead);
		}
		if (SkillRange != EB2DDispRangeType.TargetBaseObj)
		{
			output.WriteRawTag(168, 1);
			output.WriteEnum((int)SkillRange);
		}
		if (SkillRangeParam1 != 0)
		{
			output.WriteRawTag(176, 1);
			output.WriteInt32(SkillRangeParam1);
		}
		if (SkillRangeParam2 != 0)
		{
			output.WriteRawTag(184, 1);
			output.WriteInt32(SkillRangeParam2);
		}
		if (SkillType != EB2DSkillType.Normal)
		{
			output.WriteRawTag(192, 1);
			output.WriteEnum((int)SkillType);
		}
		if (MinorTargetBase != EB2DEffectRangeTargetBase.Auto)
		{
			output.WriteRawTag(200, 1);
			output.WriteEnum((int)MinorTargetBase);
		}
		if (SkillHatredCoefficient != 0)
		{
			output.WriteRawTag(208, 1);
			output.WriteInt32(SkillHatredCoefficient);
		}
		if (SkillConstHatred != 0)
		{
			output.WriteRawTag(216, 1);
			output.WriteInt32(SkillConstHatred);
		}
		if (LevelHatredCoefficient != 0)
		{
			output.WriteRawTag(224, 1);
			output.WriteInt32(LevelHatredCoefficient);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Level);
		}
		if (TargetBase != EB2DEffectRangeTargetBase.Auto)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)TargetBase);
		}
		if (TargetFilter != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetFilter);
		}
		if (TargetBaseParam1 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetBaseParam1);
		}
		if (TargetBaseParam2 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetBaseParam2);
		}
		if (TargetBaseParam3 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetBaseParam3);
		}
		if (TargetBaseParam4 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetBaseParam4);
		}
		if (TriggerEvent != EB2DSkillTriggerEvent.Auto)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)TriggerEvent);
		}
		if (TriggerEventParam != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TriggerEventParam);
		}
		if (TemplatePath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TemplatePath);
		}
		if (MpCost != 0f)
		{
			num += 5;
		}
		if (PreCooldownTime != 0f)
		{
			num += 5;
		}
		if (CooldownTime != 0f)
		{
			num += 5;
		}
		if (Priority != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Priority);
		}
		if (Range != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(Range);
		}
		if (ManualShowtime != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ManualShowtime);
		}
		if (DragMutex != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(DragMutex);
		}
		if (DragMutexTime != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(DragMutexTime);
		}
		if (BreakOnTargetDead != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(BreakOnTargetDead);
		}
		if (SkillRange != EB2DDispRangeType.TargetBaseObj)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)SkillRange);
		}
		if (SkillRangeParam1 != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SkillRangeParam1);
		}
		if (SkillRangeParam2 != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SkillRangeParam2);
		}
		if (SkillType != EB2DSkillType.Normal)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)SkillType);
		}
		if (MinorTargetBase != EB2DEffectRangeTargetBase.Auto)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)MinorTargetBase);
		}
		if (SkillHatredCoefficient != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SkillHatredCoefficient);
		}
		if (SkillConstHatred != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SkillConstHatred);
		}
		if (LevelHatredCoefficient != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(LevelHatredCoefficient);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStB2DSkillSDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.TargetBase != EB2DEffectRangeTargetBase.Auto)
			{
				TargetBase = other.TargetBase;
			}
			if (other.TargetFilter != 0)
			{
				TargetFilter = other.TargetFilter;
			}
			if (other.TargetBaseParam1 != 0)
			{
				TargetBaseParam1 = other.TargetBaseParam1;
			}
			if (other.TargetBaseParam2 != 0)
			{
				TargetBaseParam2 = other.TargetBaseParam2;
			}
			if (other.TargetBaseParam3 != 0)
			{
				TargetBaseParam3 = other.TargetBaseParam3;
			}
			if (other.TargetBaseParam4 != 0)
			{
				TargetBaseParam4 = other.TargetBaseParam4;
			}
			if (other.TriggerEvent != EB2DSkillTriggerEvent.Auto)
			{
				TriggerEvent = other.TriggerEvent;
			}
			if (other.TriggerEventParam != 0)
			{
				TriggerEventParam = other.TriggerEventParam;
			}
			if (other.TemplatePath.Length != 0)
			{
				TemplatePath = other.TemplatePath;
			}
			if (other.MpCost != 0f)
			{
				MpCost = other.MpCost;
			}
			if (other.PreCooldownTime != 0f)
			{
				PreCooldownTime = other.PreCooldownTime;
			}
			if (other.CooldownTime != 0f)
			{
				CooldownTime = other.CooldownTime;
			}
			if (other.Priority != 0)
			{
				Priority = other.Priority;
			}
			if (other.Range != 0)
			{
				Range = other.Range;
			}
			if (other.ManualShowtime != 0)
			{
				ManualShowtime = other.ManualShowtime;
			}
			if (other.DragMutex != 0)
			{
				DragMutex = other.DragMutex;
			}
			if (other.DragMutexTime != 0)
			{
				DragMutexTime = other.DragMutexTime;
			}
			if (other.BreakOnTargetDead != 0)
			{
				BreakOnTargetDead = other.BreakOnTargetDead;
			}
			if (other.SkillRange != EB2DDispRangeType.TargetBaseObj)
			{
				SkillRange = other.SkillRange;
			}
			if (other.SkillRangeParam1 != 0)
			{
				SkillRangeParam1 = other.SkillRangeParam1;
			}
			if (other.SkillRangeParam2 != 0)
			{
				SkillRangeParam2 = other.SkillRangeParam2;
			}
			if (other.SkillType != EB2DSkillType.Normal)
			{
				SkillType = other.SkillType;
			}
			if (other.MinorTargetBase != EB2DEffectRangeTargetBase.Auto)
			{
				MinorTargetBase = other.MinorTargetBase;
			}
			if (other.SkillHatredCoefficient != 0)
			{
				SkillHatredCoefficient = other.SkillHatredCoefficient;
			}
			if (other.SkillConstHatred != 0)
			{
				SkillConstHatred = other.SkillConstHatred;
			}
			if (other.LevelHatredCoefficient != 0)
			{
				LevelHatredCoefficient = other.LevelHatredCoefficient;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
				Id = input.ReadInt32();
				break;
			case 16u:
				Level = input.ReadInt32();
				break;
			case 24u:
				TargetBase = (EB2DEffectRangeTargetBase)input.ReadEnum();
				break;
			case 32u:
				TargetFilter = input.ReadInt32();
				break;
			case 40u:
				TargetBaseParam1 = input.ReadInt32();
				break;
			case 48u:
				TargetBaseParam2 = input.ReadInt32();
				break;
			case 56u:
				TargetBaseParam3 = input.ReadInt32();
				break;
			case 64u:
				TargetBaseParam4 = input.ReadInt32();
				break;
			case 72u:
				TriggerEvent = (EB2DSkillTriggerEvent)input.ReadEnum();
				break;
			case 80u:
				TriggerEventParam = input.ReadInt32();
				break;
			case 90u:
				TemplatePath = input.ReadString();
				break;
			case 101u:
				MpCost = input.ReadFloat();
				break;
			case 109u:
				PreCooldownTime = input.ReadFloat();
				break;
			case 117u:
				CooldownTime = input.ReadFloat();
				break;
			case 120u:
				Priority = input.ReadInt32();
				break;
			case 128u:
				Range = input.ReadInt32();
				break;
			case 136u:
				ManualShowtime = input.ReadInt32();
				break;
			case 144u:
				DragMutex = input.ReadInt32();
				break;
			case 152u:
				DragMutexTime = input.ReadInt32();
				break;
			case 160u:
				BreakOnTargetDead = input.ReadInt32();
				break;
			case 168u:
				SkillRange = (EB2DDispRangeType)input.ReadEnum();
				break;
			case 176u:
				SkillRangeParam1 = input.ReadInt32();
				break;
			case 184u:
				SkillRangeParam2 = input.ReadInt32();
				break;
			case 192u:
				SkillType = (EB2DSkillType)input.ReadEnum();
				break;
			case 200u:
				MinorTargetBase = (EB2DEffectRangeTargetBase)input.ReadEnum();
				break;
			case 208u:
				SkillHatredCoefficient = input.ReadInt32();
				break;
			case 216u:
				SkillConstHatred = input.ReadInt32();
				break;
			case 224u:
				LevelHatredCoefficient = input.ReadInt32();
				break;
			}
		}
	}
}
