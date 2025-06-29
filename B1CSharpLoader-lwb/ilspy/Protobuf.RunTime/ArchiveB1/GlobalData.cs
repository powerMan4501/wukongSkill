using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class GlobalData : IMessage<GlobalData>, IMessage, IEquatable<GlobalData>, IDeepCloneable<GlobalData>
{
	private static readonly MessageParser<GlobalData> _parser = new MessageParser<GlobalData>(() => new GlobalData());

	private UnknownFieldSet _unknownFields;

	private bool showSoulSkillBtn_;

	private bool showFabaoBtn_;

	private bool showJinDouYunBtn_;

	private bool showPropStanceBtn_;

	private bool showPokeStanceBtn_;

	private bool reachEndA_;

	private bool reachEndB_;

	private bool haveShowGameLevelPassTips_;

	private bool haveShowBossRushTips_;

	private bool haveShowMapTips_;

	public static MessageParser<GlobalData> Parser => _parser;

	public bool ShowSoulSkillBtn
	{
		get
		{
			return showSoulSkillBtn_;
		}
		set
		{
			showSoulSkillBtn_ = value;
		}
	}

	public bool ShowFabaoBtn
	{
		get
		{
			return showFabaoBtn_;
		}
		set
		{
			showFabaoBtn_ = value;
		}
	}

	public bool ShowJinDouYunBtn
	{
		get
		{
			return showJinDouYunBtn_;
		}
		set
		{
			showJinDouYunBtn_ = value;
		}
	}

	public bool ShowPropStanceBtn
	{
		get
		{
			return showPropStanceBtn_;
		}
		set
		{
			showPropStanceBtn_ = value;
		}
	}

	public bool ShowPokeStanceBtn
	{
		get
		{
			return showPokeStanceBtn_;
		}
		set
		{
			showPokeStanceBtn_ = value;
		}
	}

	public bool ReachEndA
	{
		get
		{
			return reachEndA_;
		}
		set
		{
			reachEndA_ = value;
		}
	}

	public bool ReachEndB
	{
		get
		{
			return reachEndB_;
		}
		set
		{
			reachEndB_ = value;
		}
	}

	public bool HaveShowGameLevelPassTips
	{
		get
		{
			return haveShowGameLevelPassTips_;
		}
		set
		{
			haveShowGameLevelPassTips_ = value;
		}
	}

	public bool HaveShowBossRushTips
	{
		get
		{
			return haveShowBossRushTips_;
		}
		set
		{
			haveShowBossRushTips_ = value;
		}
	}

	public bool HaveShowMapTips
	{
		get
		{
			return haveShowMapTips_;
		}
		set
		{
			haveShowMapTips_ = value;
		}
	}

	public GlobalData()
	{
	}

	public GlobalData(GlobalData other)
		: this()
	{
		showSoulSkillBtn_ = other.showSoulSkillBtn_;
		showFabaoBtn_ = other.showFabaoBtn_;
		showJinDouYunBtn_ = other.showJinDouYunBtn_;
		showPropStanceBtn_ = other.showPropStanceBtn_;
		showPokeStanceBtn_ = other.showPokeStanceBtn_;
		reachEndA_ = other.reachEndA_;
		reachEndB_ = other.reachEndB_;
		haveShowGameLevelPassTips_ = other.haveShowGameLevelPassTips_;
		haveShowBossRushTips_ = other.haveShowBossRushTips_;
		haveShowMapTips_ = other.haveShowMapTips_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GlobalData Clone()
	{
		return new GlobalData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GlobalData);
	}

	public bool Equals(GlobalData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ShowSoulSkillBtn != other.ShowSoulSkillBtn)
		{
			return false;
		}
		if (ShowFabaoBtn != other.ShowFabaoBtn)
		{
			return false;
		}
		if (ShowJinDouYunBtn != other.ShowJinDouYunBtn)
		{
			return false;
		}
		if (ShowPropStanceBtn != other.ShowPropStanceBtn)
		{
			return false;
		}
		if (ShowPokeStanceBtn != other.ShowPokeStanceBtn)
		{
			return false;
		}
		if (ReachEndA != other.ReachEndA)
		{
			return false;
		}
		if (ReachEndB != other.ReachEndB)
		{
			return false;
		}
		if (HaveShowGameLevelPassTips != other.HaveShowGameLevelPassTips)
		{
			return false;
		}
		if (HaveShowBossRushTips != other.HaveShowBossRushTips)
		{
			return false;
		}
		if (HaveShowMapTips != other.HaveShowMapTips)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ShowSoulSkillBtn)
		{
			num ^= ShowSoulSkillBtn.GetHashCode();
		}
		if (ShowFabaoBtn)
		{
			num ^= ShowFabaoBtn.GetHashCode();
		}
		if (ShowJinDouYunBtn)
		{
			num ^= ShowJinDouYunBtn.GetHashCode();
		}
		if (ShowPropStanceBtn)
		{
			num ^= ShowPropStanceBtn.GetHashCode();
		}
		if (ShowPokeStanceBtn)
		{
			num ^= ShowPokeStanceBtn.GetHashCode();
		}
		if (ReachEndA)
		{
			num ^= ReachEndA.GetHashCode();
		}
		if (ReachEndB)
		{
			num ^= ReachEndB.GetHashCode();
		}
		if (HaveShowGameLevelPassTips)
		{
			num ^= HaveShowGameLevelPassTips.GetHashCode();
		}
		if (HaveShowBossRushTips)
		{
			num ^= HaveShowBossRushTips.GetHashCode();
		}
		if (HaveShowMapTips)
		{
			num ^= HaveShowMapTips.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ShowSoulSkillBtn)
		{
			output.WriteRawTag(40);
			output.WriteBool(ShowSoulSkillBtn);
		}
		if (ShowFabaoBtn)
		{
			output.WriteRawTag(48);
			output.WriteBool(ShowFabaoBtn);
		}
		if (ShowJinDouYunBtn)
		{
			output.WriteRawTag(56);
			output.WriteBool(ShowJinDouYunBtn);
		}
		if (ShowPropStanceBtn)
		{
			output.WriteRawTag(64);
			output.WriteBool(ShowPropStanceBtn);
		}
		if (ShowPokeStanceBtn)
		{
			output.WriteRawTag(72);
			output.WriteBool(ShowPokeStanceBtn);
		}
		if (ReachEndA)
		{
			output.WriteRawTag(80);
			output.WriteBool(ReachEndA);
		}
		if (ReachEndB)
		{
			output.WriteRawTag(88);
			output.WriteBool(ReachEndB);
		}
		if (HaveShowGameLevelPassTips)
		{
			output.WriteRawTag(96);
			output.WriteBool(HaveShowGameLevelPassTips);
		}
		if (HaveShowBossRushTips)
		{
			output.WriteRawTag(104);
			output.WriteBool(HaveShowBossRushTips);
		}
		if (HaveShowMapTips)
		{
			output.WriteRawTag(112);
			output.WriteBool(HaveShowMapTips);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ShowSoulSkillBtn)
		{
			num += 2;
		}
		if (ShowFabaoBtn)
		{
			num += 2;
		}
		if (ShowJinDouYunBtn)
		{
			num += 2;
		}
		if (ShowPropStanceBtn)
		{
			num += 2;
		}
		if (ShowPokeStanceBtn)
		{
			num += 2;
		}
		if (ReachEndA)
		{
			num += 2;
		}
		if (ReachEndB)
		{
			num += 2;
		}
		if (HaveShowGameLevelPassTips)
		{
			num += 2;
		}
		if (HaveShowBossRushTips)
		{
			num += 2;
		}
		if (HaveShowMapTips)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GlobalData other)
	{
		if (other != null)
		{
			if (other.ShowSoulSkillBtn)
			{
				ShowSoulSkillBtn = other.ShowSoulSkillBtn;
			}
			if (other.ShowFabaoBtn)
			{
				ShowFabaoBtn = other.ShowFabaoBtn;
			}
			if (other.ShowJinDouYunBtn)
			{
				ShowJinDouYunBtn = other.ShowJinDouYunBtn;
			}
			if (other.ShowPropStanceBtn)
			{
				ShowPropStanceBtn = other.ShowPropStanceBtn;
			}
			if (other.ShowPokeStanceBtn)
			{
				ShowPokeStanceBtn = other.ShowPokeStanceBtn;
			}
			if (other.ReachEndA)
			{
				ReachEndA = other.ReachEndA;
			}
			if (other.ReachEndB)
			{
				ReachEndB = other.ReachEndB;
			}
			if (other.HaveShowGameLevelPassTips)
			{
				HaveShowGameLevelPassTips = other.HaveShowGameLevelPassTips;
			}
			if (other.HaveShowBossRushTips)
			{
				HaveShowBossRushTips = other.HaveShowBossRushTips;
			}
			if (other.HaveShowMapTips)
			{
				HaveShowMapTips = other.HaveShowMapTips;
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
			case 40u:
				ShowSoulSkillBtn = input.ReadBool();
				break;
			case 48u:
				ShowFabaoBtn = input.ReadBool();
				break;
			case 56u:
				ShowJinDouYunBtn = input.ReadBool();
				break;
			case 64u:
				ShowPropStanceBtn = input.ReadBool();
				break;
			case 72u:
				ShowPokeStanceBtn = input.ReadBool();
				break;
			case 80u:
				ReachEndA = input.ReadBool();
				break;
			case 88u:
				ReachEndB = input.ReadBool();
				break;
			case 96u:
				HaveShowGameLevelPassTips = input.ReadBool();
				break;
			case 104u:
				HaveShowBossRushTips = input.ReadBool();
				break;
			case 112u:
				HaveShowMapTips = input.ReadBool();
				break;
			}
		}
	}
}
