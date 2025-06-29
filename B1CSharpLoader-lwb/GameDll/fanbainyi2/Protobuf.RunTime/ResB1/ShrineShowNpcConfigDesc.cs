using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class ShrineShowNpcConfigDesc : IMessage<ShrineShowNpcConfigDesc>, IMessage, IEquatable<ShrineShowNpcConfigDesc>, IDeepCloneable<ShrineShowNpcConfigDesc>
{
	private static readonly MessageParser<ShrineShowNpcConfigDesc> _parser = new MessageParser<ShrineShowNpcConfigDesc>(() => new ShrineShowNpcConfigDesc());

	private UnknownFieldSet _unknownFields;

	private int npcId_;

	private int rebirthPointId_;

	private int sortId_;

	private int showTaskStageId_;

	private int showStage_;

	private int hideTaskStageId_;

	private int hideStage_;

	private int levelIdGen_;

	private string wolrdLocationGen_ = "";

	private int mapSpriteId_;

	private float mapPosX_;

	private float mapPosY_;

	public static MessageParser<ShrineShowNpcConfigDesc> Parser => _parser;

	public int NpcId
	{
		get
		{
			return npcId_;
		}
		set
		{
			npcId_ = value;
		}
	}

	public int RebirthPointId
	{
		get
		{
			return rebirthPointId_;
		}
		set
		{
			rebirthPointId_ = value;
		}
	}

	public int SortId
	{
		get
		{
			return sortId_;
		}
		set
		{
			sortId_ = value;
		}
	}

	public int ShowTaskStageId
	{
		get
		{
			return showTaskStageId_;
		}
		set
		{
			showTaskStageId_ = value;
		}
	}

	public int ShowStage
	{
		get
		{
			return showStage_;
		}
		set
		{
			showStage_ = value;
		}
	}

	public int HideTaskStageId
	{
		get
		{
			return hideTaskStageId_;
		}
		set
		{
			hideTaskStageId_ = value;
		}
	}

	public int HideStage
	{
		get
		{
			return hideStage_;
		}
		set
		{
			hideStage_ = value;
		}
	}

	public int LevelIdGen
	{
		get
		{
			return levelIdGen_;
		}
		set
		{
			levelIdGen_ = value;
		}
	}

	public string WolrdLocationGen
	{
		get
		{
			return wolrdLocationGen_;
		}
		set
		{
			wolrdLocationGen_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int MapSpriteId
	{
		get
		{
			return mapSpriteId_;
		}
		set
		{
			mapSpriteId_ = value;
		}
	}

	public float MapPosX
	{
		get
		{
			return mapPosX_;
		}
		set
		{
			mapPosX_ = value;
		}
	}

	public float MapPosY
	{
		get
		{
			return mapPosY_;
		}
		set
		{
			mapPosY_ = value;
		}
	}

	public ShrineShowNpcConfigDesc()
	{
	}

	public ShrineShowNpcConfigDesc(ShrineShowNpcConfigDesc other)
		: this()
	{
		npcId_ = other.npcId_;
		rebirthPointId_ = other.rebirthPointId_;
		sortId_ = other.sortId_;
		showTaskStageId_ = other.showTaskStageId_;
		showStage_ = other.showStage_;
		hideTaskStageId_ = other.hideTaskStageId_;
		hideStage_ = other.hideStage_;
		levelIdGen_ = other.levelIdGen_;
		wolrdLocationGen_ = other.wolrdLocationGen_;
		mapSpriteId_ = other.mapSpriteId_;
		mapPosX_ = other.mapPosX_;
		mapPosY_ = other.mapPosY_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ShrineShowNpcConfigDesc Clone()
	{
		return new ShrineShowNpcConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ShrineShowNpcConfigDesc);
	}

	public bool Equals(ShrineShowNpcConfigDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NpcId != other.NpcId)
		{
			return false;
		}
		if (RebirthPointId != other.RebirthPointId)
		{
			return false;
		}
		if (SortId != other.SortId)
		{
			return false;
		}
		if (ShowTaskStageId != other.ShowTaskStageId)
		{
			return false;
		}
		if (ShowStage != other.ShowStage)
		{
			return false;
		}
		if (HideTaskStageId != other.HideTaskStageId)
		{
			return false;
		}
		if (HideStage != other.HideStage)
		{
			return false;
		}
		if (LevelIdGen != other.LevelIdGen)
		{
			return false;
		}
		if (WolrdLocationGen != other.WolrdLocationGen)
		{
			return false;
		}
		if (MapSpriteId != other.MapSpriteId)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MapPosX, other.MapPosX))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MapPosY, other.MapPosY))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (NpcId != 0)
		{
			num ^= NpcId.GetHashCode();
		}
		if (RebirthPointId != 0)
		{
			num ^= RebirthPointId.GetHashCode();
		}
		if (SortId != 0)
		{
			num ^= SortId.GetHashCode();
		}
		if (ShowTaskStageId != 0)
		{
			num ^= ShowTaskStageId.GetHashCode();
		}
		if (ShowStage != 0)
		{
			num ^= ShowStage.GetHashCode();
		}
		if (HideTaskStageId != 0)
		{
			num ^= HideTaskStageId.GetHashCode();
		}
		if (HideStage != 0)
		{
			num ^= HideStage.GetHashCode();
		}
		if (LevelIdGen != 0)
		{
			num ^= LevelIdGen.GetHashCode();
		}
		if (WolrdLocationGen.Length != 0)
		{
			num ^= WolrdLocationGen.GetHashCode();
		}
		if (MapSpriteId != 0)
		{
			num ^= MapSpriteId.GetHashCode();
		}
		if (MapPosX != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MapPosX);
		}
		if (MapPosY != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MapPosY);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (NpcId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(NpcId);
		}
		if (RebirthPointId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(RebirthPointId);
		}
		if (SortId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(SortId);
		}
		if (ShowTaskStageId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ShowTaskStageId);
		}
		if (ShowStage != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(ShowStage);
		}
		if (HideTaskStageId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(HideTaskStageId);
		}
		if (HideStage != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(HideStage);
		}
		if (LevelIdGen != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(LevelIdGen);
		}
		if (WolrdLocationGen.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(WolrdLocationGen);
		}
		if (MapSpriteId != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(MapSpriteId);
		}
		if (MapPosX != 0f)
		{
			output.WriteRawTag(93);
			output.WriteFloat(MapPosX);
		}
		if (MapPosY != 0f)
		{
			output.WriteRawTag(101);
			output.WriteFloat(MapPosY);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (NpcId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NpcId);
		}
		if (RebirthPointId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RebirthPointId);
		}
		if (SortId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SortId);
		}
		if (ShowTaskStageId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ShowTaskStageId);
		}
		if (ShowStage != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ShowStage);
		}
		if (HideTaskStageId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HideTaskStageId);
		}
		if (HideStage != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HideStage);
		}
		if (LevelIdGen != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LevelIdGen);
		}
		if (WolrdLocationGen.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(WolrdLocationGen);
		}
		if (MapSpriteId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MapSpriteId);
		}
		if (MapPosX != 0f)
		{
			num += 5;
		}
		if (MapPosY != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ShrineShowNpcConfigDesc other)
	{
		if (other != null)
		{
			if (other.NpcId != 0)
			{
				NpcId = other.NpcId;
			}
			if (other.RebirthPointId != 0)
			{
				RebirthPointId = other.RebirthPointId;
			}
			if (other.SortId != 0)
			{
				SortId = other.SortId;
			}
			if (other.ShowTaskStageId != 0)
			{
				ShowTaskStageId = other.ShowTaskStageId;
			}
			if (other.ShowStage != 0)
			{
				ShowStage = other.ShowStage;
			}
			if (other.HideTaskStageId != 0)
			{
				HideTaskStageId = other.HideTaskStageId;
			}
			if (other.HideStage != 0)
			{
				HideStage = other.HideStage;
			}
			if (other.LevelIdGen != 0)
			{
				LevelIdGen = other.LevelIdGen;
			}
			if (other.WolrdLocationGen.Length != 0)
			{
				WolrdLocationGen = other.WolrdLocationGen;
			}
			if (other.MapSpriteId != 0)
			{
				MapSpriteId = other.MapSpriteId;
			}
			if (other.MapPosX != 0f)
			{
				MapPosX = other.MapPosX;
			}
			if (other.MapPosY != 0f)
			{
				MapPosY = other.MapPosY;
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
				NpcId = input.ReadInt32();
				break;
			case 16u:
				RebirthPointId = input.ReadInt32();
				break;
			case 24u:
				SortId = input.ReadInt32();
				break;
			case 32u:
				ShowTaskStageId = input.ReadInt32();
				break;
			case 40u:
				ShowStage = input.ReadInt32();
				break;
			case 48u:
				HideTaskStageId = input.ReadInt32();
				break;
			case 56u:
				HideStage = input.ReadInt32();
				break;
			case 64u:
				LevelIdGen = input.ReadInt32();
				break;
			case 74u:
				WolrdLocationGen = input.ReadString();
				break;
			case 80u:
				MapSpriteId = input.ReadInt32();
				break;
			case 93u:
				MapPosX = input.ReadFloat();
				break;
			case 101u:
				MapPosY = input.ReadFloat();
				break;
			}
		}
	}
}
