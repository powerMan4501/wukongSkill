using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class RoleStaticsData : IMessage<RoleStaticsData>, IMessage, IEquatable<RoleStaticsData>, IDeepCloneable<RoleStaticsData>
{
	private static readonly MessageParser<RoleStaticsData> _parser = new MessageParser<RoleStaticsData>(() => new RoleStaticsData());

	private UnknownFieldSet _unknownFields;

	private ArchiveStaticsOne summaryStatics_;

	private static readonly FieldCodec<ArchiveStaticsOne> _repeated_historyStatics_codec = FieldCodec.ForMessage(18u, ArchiveStaticsOne.Parser);

	private readonly RepeatedField<ArchiveStaticsOne> historyStatics_ = new RepeatedField<ArchiveStaticsOne>();

	private NewGameResetStaticsData newGameResetStatics_;

	public static MessageParser<RoleStaticsData> Parser => _parser;

	public ArchiveStaticsOne SummaryStatics
	{
		get
		{
			return summaryStatics_;
		}
		set
		{
			summaryStatics_ = value;
		}
	}

	public RepeatedField<ArchiveStaticsOne> HistoryStatics => historyStatics_;

	public NewGameResetStaticsData NewGameResetStatics
	{
		get
		{
			return newGameResetStatics_;
		}
		set
		{
			newGameResetStatics_ = value;
		}
	}

	public RoleStaticsData()
	{
	}

	public RoleStaticsData(RoleStaticsData other)
		: this()
	{
		summaryStatics_ = ((other.summaryStatics_ != null) ? other.summaryStatics_.Clone() : null);
		historyStatics_ = other.historyStatics_.Clone();
		newGameResetStatics_ = ((other.newGameResetStatics_ != null) ? other.newGameResetStatics_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleStaticsData Clone()
	{
		return new RoleStaticsData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleStaticsData);
	}

	public bool Equals(RoleStaticsData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(SummaryStatics, other.SummaryStatics))
		{
			return false;
		}
		if (!historyStatics_.Equals(other.historyStatics_))
		{
			return false;
		}
		if (!object.Equals(NewGameResetStatics, other.NewGameResetStatics))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (summaryStatics_ != null)
		{
			num ^= SummaryStatics.GetHashCode();
		}
		num ^= historyStatics_.GetHashCode();
		if (newGameResetStatics_ != null)
		{
			num ^= NewGameResetStatics.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (summaryStatics_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(SummaryStatics);
		}
		historyStatics_.WriteTo(output, _repeated_historyStatics_codec);
		if (newGameResetStatics_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(NewGameResetStatics);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (summaryStatics_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SummaryStatics);
		}
		num += historyStatics_.CalculateSize(_repeated_historyStatics_codec);
		if (newGameResetStatics_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NewGameResetStatics);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleStaticsData other)
	{
		if (other == null)
		{
			return;
		}
		if (other.summaryStatics_ != null)
		{
			if (summaryStatics_ == null)
			{
				SummaryStatics = new ArchiveStaticsOne();
			}
			SummaryStatics.MergeFrom(other.SummaryStatics);
		}
		historyStatics_.Add(other.historyStatics_);
		if (other.newGameResetStatics_ != null)
		{
			if (newGameResetStatics_ == null)
			{
				NewGameResetStatics = new NewGameResetStaticsData();
			}
			NewGameResetStatics.MergeFrom(other.NewGameResetStatics);
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
				if (summaryStatics_ == null)
				{
					SummaryStatics = new ArchiveStaticsOne();
				}
				input.ReadMessage(SummaryStatics);
				break;
			case 18u:
				historyStatics_.AddEntriesFrom(input, _repeated_historyStatics_codec);
				break;
			case 26u:
				if (newGameResetStatics_ == null)
				{
					NewGameResetStatics = new NewGameResetStaticsData();
				}
				input.ReadMessage(NewGameResetStatics);
				break;
			}
		}
	}
}
