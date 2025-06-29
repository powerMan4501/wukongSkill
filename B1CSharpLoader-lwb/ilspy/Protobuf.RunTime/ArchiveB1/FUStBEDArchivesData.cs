using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using GurGsPersistent;

namespace ArchiveB1;

public sealed class FUStBEDArchivesData : IMessage<FUStBEDArchivesData>, IMessage, IEquatable<FUStBEDArchivesData>, IDeepCloneable<FUStBEDArchivesData>
{
	private static readonly MessageParser<FUStBEDArchivesData> _parser = new MessageParser<FUStBEDArchivesData>(() => new FUStBEDArchivesData());

	private UnknownFieldSet _unknownFields;

	private RoleData roleData_;

	private LevelArchiveData levelArchiveData_;

	private WorldTaskArchiveData taskArchiveData_;

	private StateMachineArchiveData stateMachineArchiveData_;

	private static readonly FieldCodec<int> _repeated_neverPlaySequences_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> neverPlaySequences_ = new RepeatedField<int>();

	private PersistentECSData persistentECSData_;

	public static MessageParser<FUStBEDArchivesData> Parser => _parser;

	public RoleData RoleData
	{
		get
		{
			return roleData_;
		}
		set
		{
			roleData_ = value;
		}
	}

	public LevelArchiveData LevelArchiveData
	{
		get
		{
			return levelArchiveData_;
		}
		set
		{
			levelArchiveData_ = value;
		}
	}

	public WorldTaskArchiveData TaskArchiveData
	{
		get
		{
			return taskArchiveData_;
		}
		set
		{
			taskArchiveData_ = value;
		}
	}

	public StateMachineArchiveData StateMachineArchiveData
	{
		get
		{
			return stateMachineArchiveData_;
		}
		set
		{
			stateMachineArchiveData_ = value;
		}
	}

	public RepeatedField<int> NeverPlaySequences => neverPlaySequences_;

	public PersistentECSData PersistentECSData
	{
		get
		{
			return persistentECSData_;
		}
		set
		{
			persistentECSData_ = value;
		}
	}

	public FUStBEDArchivesData()
	{
	}

	public FUStBEDArchivesData(FUStBEDArchivesData other)
		: this()
	{
		roleData_ = ((other.roleData_ != null) ? other.roleData_.Clone() : null);
		levelArchiveData_ = ((other.levelArchiveData_ != null) ? other.levelArchiveData_.Clone() : null);
		taskArchiveData_ = ((other.taskArchiveData_ != null) ? other.taskArchiveData_.Clone() : null);
		stateMachineArchiveData_ = ((other.stateMachineArchiveData_ != null) ? other.stateMachineArchiveData_.Clone() : null);
		neverPlaySequences_ = other.neverPlaySequences_.Clone();
		persistentECSData_ = ((other.persistentECSData_ != null) ? other.persistentECSData_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStBEDArchivesData Clone()
	{
		return new FUStBEDArchivesData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStBEDArchivesData);
	}

	public bool Equals(FUStBEDArchivesData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(RoleData, other.RoleData))
		{
			return false;
		}
		if (!object.Equals(LevelArchiveData, other.LevelArchiveData))
		{
			return false;
		}
		if (!object.Equals(TaskArchiveData, other.TaskArchiveData))
		{
			return false;
		}
		if (!object.Equals(StateMachineArchiveData, other.StateMachineArchiveData))
		{
			return false;
		}
		if (!neverPlaySequences_.Equals(other.neverPlaySequences_))
		{
			return false;
		}
		if (!object.Equals(PersistentECSData, other.PersistentECSData))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (roleData_ != null)
		{
			num ^= RoleData.GetHashCode();
		}
		if (levelArchiveData_ != null)
		{
			num ^= LevelArchiveData.GetHashCode();
		}
		if (taskArchiveData_ != null)
		{
			num ^= TaskArchiveData.GetHashCode();
		}
		if (stateMachineArchiveData_ != null)
		{
			num ^= StateMachineArchiveData.GetHashCode();
		}
		num ^= neverPlaySequences_.GetHashCode();
		if (persistentECSData_ != null)
		{
			num ^= PersistentECSData.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (roleData_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(RoleData);
		}
		if (levelArchiveData_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(LevelArchiveData);
		}
		if (taskArchiveData_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(TaskArchiveData);
		}
		if (stateMachineArchiveData_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(StateMachineArchiveData);
		}
		neverPlaySequences_.WriteTo(output, _repeated_neverPlaySequences_codec);
		if (persistentECSData_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(PersistentECSData);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (roleData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RoleData);
		}
		if (levelArchiveData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LevelArchiveData);
		}
		if (taskArchiveData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TaskArchiveData);
		}
		if (stateMachineArchiveData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(StateMachineArchiveData);
		}
		num += neverPlaySequences_.CalculateSize(_repeated_neverPlaySequences_codec);
		if (persistentECSData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PersistentECSData);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStBEDArchivesData other)
	{
		if (other == null)
		{
			return;
		}
		if (other.roleData_ != null)
		{
			if (roleData_ == null)
			{
				RoleData = new RoleData();
			}
			RoleData.MergeFrom(other.RoleData);
		}
		if (other.levelArchiveData_ != null)
		{
			if (levelArchiveData_ == null)
			{
				LevelArchiveData = new LevelArchiveData();
			}
			LevelArchiveData.MergeFrom(other.LevelArchiveData);
		}
		if (other.taskArchiveData_ != null)
		{
			if (taskArchiveData_ == null)
			{
				TaskArchiveData = new WorldTaskArchiveData();
			}
			TaskArchiveData.MergeFrom(other.TaskArchiveData);
		}
		if (other.stateMachineArchiveData_ != null)
		{
			if (stateMachineArchiveData_ == null)
			{
				StateMachineArchiveData = new StateMachineArchiveData();
			}
			StateMachineArchiveData.MergeFrom(other.StateMachineArchiveData);
		}
		neverPlaySequences_.Add(other.neverPlaySequences_);
		if (other.persistentECSData_ != null)
		{
			if (persistentECSData_ == null)
			{
				PersistentECSData = new PersistentECSData();
			}
			PersistentECSData.MergeFrom(other.PersistentECSData);
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
				if (roleData_ == null)
				{
					RoleData = new RoleData();
				}
				input.ReadMessage(RoleData);
				break;
			case 18u:
				if (levelArchiveData_ == null)
				{
					LevelArchiveData = new LevelArchiveData();
				}
				input.ReadMessage(LevelArchiveData);
				break;
			case 26u:
				if (taskArchiveData_ == null)
				{
					TaskArchiveData = new WorldTaskArchiveData();
				}
				input.ReadMessage(TaskArchiveData);
				break;
			case 34u:
				if (stateMachineArchiveData_ == null)
				{
					StateMachineArchiveData = new StateMachineArchiveData();
				}
				input.ReadMessage(StateMachineArchiveData);
				break;
			case 40u:
			case 42u:
				neverPlaySequences_.AddEntriesFrom(input, _repeated_neverPlaySequences_codec);
				break;
			case 50u:
				if (persistentECSData_ == null)
				{
					PersistentECSData = new PersistentECSData();
				}
				input.ReadMessage(PersistentECSData);
				break;
			}
		}
	}
}
