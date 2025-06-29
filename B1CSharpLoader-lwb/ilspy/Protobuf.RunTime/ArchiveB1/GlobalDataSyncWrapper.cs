using System;
using Google.Protobuf;
using ResB1;

namespace ArchiveB1;

public sealed class GlobalDataSyncWrapper : IMessage<GlobalDataSyncWrapper>, IMessage, IEquatable<GlobalDataSyncWrapper>, IDeepCloneable<GlobalDataSyncWrapper>
{
	private static readonly MessageParser<GlobalDataSyncWrapper> _parser = new MessageParser<GlobalDataSyncWrapper>(() => new GlobalDataSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private BoolSyncWrapper showSoulSkillBtn_;

	private BoolSyncWrapper showFabaoBtn_;

	private BoolSyncWrapper showJinDouYunBtn_;

	private BoolSyncWrapper showPropStanceBtn_;

	private BoolSyncWrapper showPokeStanceBtn_;

	private BoolSyncWrapper reachEndA_;

	private BoolSyncWrapper reachEndB_;

	private BoolSyncWrapper haveShowGameLevelPassTips_;

	private BoolSyncWrapper haveShowBossRushTips_;

	private BoolSyncWrapper haveShowMapTips_;

	public static MessageParser<GlobalDataSyncWrapper> Parser => _parser;

	public int SyncFlag
	{
		get
		{
			return syncFlag_;
		}
		set
		{
			syncFlag_ = value;
		}
	}

	public int SyncIdx
	{
		get
		{
			return syncIdx_;
		}
		set
		{
			syncIdx_ = value;
		}
	}

	public BoolSyncWrapper ShowSoulSkillBtn
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

	public BoolSyncWrapper ShowFabaoBtn
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

	public BoolSyncWrapper ShowJinDouYunBtn
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

	public BoolSyncWrapper ShowPropStanceBtn
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

	public BoolSyncWrapper ShowPokeStanceBtn
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

	public BoolSyncWrapper ReachEndA
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

	public BoolSyncWrapper ReachEndB
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

	public BoolSyncWrapper HaveShowGameLevelPassTips
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

	public BoolSyncWrapper HaveShowBossRushTips
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

	public BoolSyncWrapper HaveShowMapTips
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

	public GlobalDataSyncWrapper()
	{
	}

	public GlobalDataSyncWrapper(GlobalDataSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		showSoulSkillBtn_ = ((other.showSoulSkillBtn_ != null) ? other.showSoulSkillBtn_.Clone() : null);
		showFabaoBtn_ = ((other.showFabaoBtn_ != null) ? other.showFabaoBtn_.Clone() : null);
		showJinDouYunBtn_ = ((other.showJinDouYunBtn_ != null) ? other.showJinDouYunBtn_.Clone() : null);
		showPropStanceBtn_ = ((other.showPropStanceBtn_ != null) ? other.showPropStanceBtn_.Clone() : null);
		showPokeStanceBtn_ = ((other.showPokeStanceBtn_ != null) ? other.showPokeStanceBtn_.Clone() : null);
		reachEndA_ = ((other.reachEndA_ != null) ? other.reachEndA_.Clone() : null);
		reachEndB_ = ((other.reachEndB_ != null) ? other.reachEndB_.Clone() : null);
		haveShowGameLevelPassTips_ = ((other.haveShowGameLevelPassTips_ != null) ? other.haveShowGameLevelPassTips_.Clone() : null);
		haveShowBossRushTips_ = ((other.haveShowBossRushTips_ != null) ? other.haveShowBossRushTips_.Clone() : null);
		haveShowMapTips_ = ((other.haveShowMapTips_ != null) ? other.haveShowMapTips_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GlobalDataSyncWrapper Clone()
	{
		return new GlobalDataSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GlobalDataSyncWrapper);
	}

	public bool Equals(GlobalDataSyncWrapper other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SyncFlag != other.SyncFlag)
		{
			return false;
		}
		if (SyncIdx != other.SyncIdx)
		{
			return false;
		}
		if (!object.Equals(ShowSoulSkillBtn, other.ShowSoulSkillBtn))
		{
			return false;
		}
		if (!object.Equals(ShowFabaoBtn, other.ShowFabaoBtn))
		{
			return false;
		}
		if (!object.Equals(ShowJinDouYunBtn, other.ShowJinDouYunBtn))
		{
			return false;
		}
		if (!object.Equals(ShowPropStanceBtn, other.ShowPropStanceBtn))
		{
			return false;
		}
		if (!object.Equals(ShowPokeStanceBtn, other.ShowPokeStanceBtn))
		{
			return false;
		}
		if (!object.Equals(ReachEndA, other.ReachEndA))
		{
			return false;
		}
		if (!object.Equals(ReachEndB, other.ReachEndB))
		{
			return false;
		}
		if (!object.Equals(HaveShowGameLevelPassTips, other.HaveShowGameLevelPassTips))
		{
			return false;
		}
		if (!object.Equals(HaveShowBossRushTips, other.HaveShowBossRushTips))
		{
			return false;
		}
		if (!object.Equals(HaveShowMapTips, other.HaveShowMapTips))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SyncFlag != 0)
		{
			num ^= SyncFlag.GetHashCode();
		}
		if (SyncIdx != 0)
		{
			num ^= SyncIdx.GetHashCode();
		}
		if (showSoulSkillBtn_ != null)
		{
			num ^= ShowSoulSkillBtn.GetHashCode();
		}
		if (showFabaoBtn_ != null)
		{
			num ^= ShowFabaoBtn.GetHashCode();
		}
		if (showJinDouYunBtn_ != null)
		{
			num ^= ShowJinDouYunBtn.GetHashCode();
		}
		if (showPropStanceBtn_ != null)
		{
			num ^= ShowPropStanceBtn.GetHashCode();
		}
		if (showPokeStanceBtn_ != null)
		{
			num ^= ShowPokeStanceBtn.GetHashCode();
		}
		if (reachEndA_ != null)
		{
			num ^= ReachEndA.GetHashCode();
		}
		if (reachEndB_ != null)
		{
			num ^= ReachEndB.GetHashCode();
		}
		if (haveShowGameLevelPassTips_ != null)
		{
			num ^= HaveShowGameLevelPassTips.GetHashCode();
		}
		if (haveShowBossRushTips_ != null)
		{
			num ^= HaveShowBossRushTips.GetHashCode();
		}
		if (haveShowMapTips_ != null)
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
		if (SyncFlag != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(SyncFlag);
		}
		if (SyncIdx != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SyncIdx);
		}
		if (showSoulSkillBtn_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(ShowSoulSkillBtn);
		}
		if (showFabaoBtn_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(ShowFabaoBtn);
		}
		if (showJinDouYunBtn_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(ShowJinDouYunBtn);
		}
		if (showPropStanceBtn_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(ShowPropStanceBtn);
		}
		if (showPokeStanceBtn_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(ShowPokeStanceBtn);
		}
		if (reachEndA_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(ReachEndA);
		}
		if (reachEndB_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(ReachEndB);
		}
		if (haveShowGameLevelPassTips_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(HaveShowGameLevelPassTips);
		}
		if (haveShowBossRushTips_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(HaveShowBossRushTips);
		}
		if (haveShowMapTips_ != null)
		{
			output.WriteRawTag(130, 1);
			output.WriteMessage(HaveShowMapTips);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SyncFlag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SyncFlag);
		}
		if (SyncIdx != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SyncIdx);
		}
		if (showSoulSkillBtn_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ShowSoulSkillBtn);
		}
		if (showFabaoBtn_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ShowFabaoBtn);
		}
		if (showJinDouYunBtn_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ShowJinDouYunBtn);
		}
		if (showPropStanceBtn_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ShowPropStanceBtn);
		}
		if (showPokeStanceBtn_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ShowPokeStanceBtn);
		}
		if (reachEndA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ReachEndA);
		}
		if (reachEndB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ReachEndB);
		}
		if (haveShowGameLevelPassTips_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HaveShowGameLevelPassTips);
		}
		if (haveShowBossRushTips_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HaveShowBossRushTips);
		}
		if (haveShowMapTips_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(HaveShowMapTips);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GlobalDataSyncWrapper other)
	{
		if (other == null)
		{
			return;
		}
		if (other.SyncFlag != 0)
		{
			SyncFlag = other.SyncFlag;
		}
		if (other.SyncIdx != 0)
		{
			SyncIdx = other.SyncIdx;
		}
		if (other.showSoulSkillBtn_ != null)
		{
			if (showSoulSkillBtn_ == null)
			{
				ShowSoulSkillBtn = new BoolSyncWrapper();
			}
			ShowSoulSkillBtn.MergeFrom(other.ShowSoulSkillBtn);
		}
		if (other.showFabaoBtn_ != null)
		{
			if (showFabaoBtn_ == null)
			{
				ShowFabaoBtn = new BoolSyncWrapper();
			}
			ShowFabaoBtn.MergeFrom(other.ShowFabaoBtn);
		}
		if (other.showJinDouYunBtn_ != null)
		{
			if (showJinDouYunBtn_ == null)
			{
				ShowJinDouYunBtn = new BoolSyncWrapper();
			}
			ShowJinDouYunBtn.MergeFrom(other.ShowJinDouYunBtn);
		}
		if (other.showPropStanceBtn_ != null)
		{
			if (showPropStanceBtn_ == null)
			{
				ShowPropStanceBtn = new BoolSyncWrapper();
			}
			ShowPropStanceBtn.MergeFrom(other.ShowPropStanceBtn);
		}
		if (other.showPokeStanceBtn_ != null)
		{
			if (showPokeStanceBtn_ == null)
			{
				ShowPokeStanceBtn = new BoolSyncWrapper();
			}
			ShowPokeStanceBtn.MergeFrom(other.ShowPokeStanceBtn);
		}
		if (other.reachEndA_ != null)
		{
			if (reachEndA_ == null)
			{
				ReachEndA = new BoolSyncWrapper();
			}
			ReachEndA.MergeFrom(other.ReachEndA);
		}
		if (other.reachEndB_ != null)
		{
			if (reachEndB_ == null)
			{
				ReachEndB = new BoolSyncWrapper();
			}
			ReachEndB.MergeFrom(other.ReachEndB);
		}
		if (other.haveShowGameLevelPassTips_ != null)
		{
			if (haveShowGameLevelPassTips_ == null)
			{
				HaveShowGameLevelPassTips = new BoolSyncWrapper();
			}
			HaveShowGameLevelPassTips.MergeFrom(other.HaveShowGameLevelPassTips);
		}
		if (other.haveShowBossRushTips_ != null)
		{
			if (haveShowBossRushTips_ == null)
			{
				HaveShowBossRushTips = new BoolSyncWrapper();
			}
			HaveShowBossRushTips.MergeFrom(other.HaveShowBossRushTips);
		}
		if (other.haveShowMapTips_ != null)
		{
			if (haveShowMapTips_ == null)
			{
				HaveShowMapTips = new BoolSyncWrapper();
			}
			HaveShowMapTips.MergeFrom(other.HaveShowMapTips);
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
				SyncFlag = input.ReadInt32();
				break;
			case 16u:
				SyncIdx = input.ReadInt32();
				break;
			case 58u:
				if (showSoulSkillBtn_ == null)
				{
					ShowSoulSkillBtn = new BoolSyncWrapper();
				}
				input.ReadMessage(ShowSoulSkillBtn);
				break;
			case 66u:
				if (showFabaoBtn_ == null)
				{
					ShowFabaoBtn = new BoolSyncWrapper();
				}
				input.ReadMessage(ShowFabaoBtn);
				break;
			case 74u:
				if (showJinDouYunBtn_ == null)
				{
					ShowJinDouYunBtn = new BoolSyncWrapper();
				}
				input.ReadMessage(ShowJinDouYunBtn);
				break;
			case 82u:
				if (showPropStanceBtn_ == null)
				{
					ShowPropStanceBtn = new BoolSyncWrapper();
				}
				input.ReadMessage(ShowPropStanceBtn);
				break;
			case 90u:
				if (showPokeStanceBtn_ == null)
				{
					ShowPokeStanceBtn = new BoolSyncWrapper();
				}
				input.ReadMessage(ShowPokeStanceBtn);
				break;
			case 98u:
				if (reachEndA_ == null)
				{
					ReachEndA = new BoolSyncWrapper();
				}
				input.ReadMessage(ReachEndA);
				break;
			case 106u:
				if (reachEndB_ == null)
				{
					ReachEndB = new BoolSyncWrapper();
				}
				input.ReadMessage(ReachEndB);
				break;
			case 114u:
				if (haveShowGameLevelPassTips_ == null)
				{
					HaveShowGameLevelPassTips = new BoolSyncWrapper();
				}
				input.ReadMessage(HaveShowGameLevelPassTips);
				break;
			case 122u:
				if (haveShowBossRushTips_ == null)
				{
					HaveShowBossRushTips = new BoolSyncWrapper();
				}
				input.ReadMessage(HaveShowBossRushTips);
				break;
			case 130u:
				if (haveShowMapTips_ == null)
				{
					HaveShowMapTips = new BoolSyncWrapper();
				}
				input.ReadMessage(HaveShowMapTips);
				break;
			}
		}
	}
}
