using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class ProcessCustom_SaveArchive : IMessage<ProcessCustom_SaveArchive>, IMessage, IEquatable<ProcessCustom_SaveArchive>, IDeepCloneable<ProcessCustom_SaveArchive>
{
	private static readonly MessageParser<ProcessCustom_SaveArchive> _parser = new MessageParser<ProcessCustom_SaveArchive>(() => new ProcessCustom_SaveArchive());

	private UnknownFieldSet _unknownFields;

	private string archiveLabel_ = "";

	private static readonly FieldCodec<CalliopeCustom_ManagedSceneObj> _repeated_managedObjs_codec = FieldCodec.ForMessage(18u, CalliopeCustom_ManagedSceneObj.Parser);

	private readonly RepeatedField<CalliopeCustom_ManagedSceneObj> managedObjs_ = new RepeatedField<CalliopeCustom_ManagedSceneObj>();

	private static readonly FieldCodec<CalliopeCustom_ManagedNPCUnit> _repeated_managedNpcUnits_codec = FieldCodec.ForMessage(26u, CalliopeCustom_ManagedNPCUnit.Parser);

	private readonly RepeatedField<CalliopeCustom_ManagedNPCUnit> managedNpcUnits_ = new RepeatedField<CalliopeCustom_ManagedNPCUnit>();

	private static readonly FieldCodec<CalliopeCustom_ManagedInteractor> _repeated_managedInteractors_codec = FieldCodec.ForMessage(34u, CalliopeCustom_ManagedInteractor.Parser);

	private readonly RepeatedField<CalliopeCustom_ManagedInteractor> managedInteractors_ = new RepeatedField<CalliopeCustom_ManagedInteractor>();

	private static readonly FieldCodec<CalliopeCustom_ManagedStreamingLevelStateConfig> _repeated_managedStreamingLevelStateConfigs_codec = FieldCodec.ForMessage(42u, CalliopeCustom_ManagedStreamingLevelStateConfig.Parser);

	private readonly RepeatedField<CalliopeCustom_ManagedStreamingLevelStateConfig> managedStreamingLevelStateConfigs_ = new RepeatedField<CalliopeCustom_ManagedStreamingLevelStateConfig>();

	private static readonly FieldCodec<CalliopeCustom_ManagedGroupUnit> _repeated_managedGroupUnits_codec = FieldCodec.ForMessage(50u, CalliopeCustom_ManagedGroupUnit.Parser);

	private readonly RepeatedField<CalliopeCustom_ManagedGroupUnit> managedGroupUnits_ = new RepeatedField<CalliopeCustom_ManagedGroupUnit>();

	public static MessageParser<ProcessCustom_SaveArchive> Parser => _parser;

	public string ArchiveLabel
	{
		get
		{
			return archiveLabel_;
		}
		set
		{
			archiveLabel_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<CalliopeCustom_ManagedSceneObj> ManagedObjs => managedObjs_;

	public RepeatedField<CalliopeCustom_ManagedNPCUnit> ManagedNpcUnits => managedNpcUnits_;

	public RepeatedField<CalliopeCustom_ManagedInteractor> ManagedInteractors => managedInteractors_;

	public RepeatedField<CalliopeCustom_ManagedStreamingLevelStateConfig> ManagedStreamingLevelStateConfigs => managedStreamingLevelStateConfigs_;

	public RepeatedField<CalliopeCustom_ManagedGroupUnit> ManagedGroupUnits => managedGroupUnits_;

	public ProcessCustom_SaveArchive()
	{
	}

	public ProcessCustom_SaveArchive(ProcessCustom_SaveArchive other)
		: this()
	{
		archiveLabel_ = other.archiveLabel_;
		managedObjs_ = other.managedObjs_.Clone();
		managedNpcUnits_ = other.managedNpcUnits_.Clone();
		managedInteractors_ = other.managedInteractors_.Clone();
		managedStreamingLevelStateConfigs_ = other.managedStreamingLevelStateConfigs_.Clone();
		managedGroupUnits_ = other.managedGroupUnits_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ProcessCustom_SaveArchive Clone()
	{
		return new ProcessCustom_SaveArchive(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ProcessCustom_SaveArchive);
	}

	public bool Equals(ProcessCustom_SaveArchive other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ArchiveLabel != other.ArchiveLabel)
		{
			return false;
		}
		if (!managedObjs_.Equals(other.managedObjs_))
		{
			return false;
		}
		if (!managedNpcUnits_.Equals(other.managedNpcUnits_))
		{
			return false;
		}
		if (!managedInteractors_.Equals(other.managedInteractors_))
		{
			return false;
		}
		if (!managedStreamingLevelStateConfigs_.Equals(other.managedStreamingLevelStateConfigs_))
		{
			return false;
		}
		if (!managedGroupUnits_.Equals(other.managedGroupUnits_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ArchiveLabel.Length != 0)
		{
			num ^= ArchiveLabel.GetHashCode();
		}
		num ^= managedObjs_.GetHashCode();
		num ^= managedNpcUnits_.GetHashCode();
		num ^= managedInteractors_.GetHashCode();
		num ^= managedStreamingLevelStateConfigs_.GetHashCode();
		num ^= managedGroupUnits_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ArchiveLabel.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(ArchiveLabel);
		}
		managedObjs_.WriteTo(output, _repeated_managedObjs_codec);
		managedNpcUnits_.WriteTo(output, _repeated_managedNpcUnits_codec);
		managedInteractors_.WriteTo(output, _repeated_managedInteractors_codec);
		managedStreamingLevelStateConfigs_.WriteTo(output, _repeated_managedStreamingLevelStateConfigs_codec);
		managedGroupUnits_.WriteTo(output, _repeated_managedGroupUnits_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ArchiveLabel.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ArchiveLabel);
		}
		num += managedObjs_.CalculateSize(_repeated_managedObjs_codec);
		num += managedNpcUnits_.CalculateSize(_repeated_managedNpcUnits_codec);
		num += managedInteractors_.CalculateSize(_repeated_managedInteractors_codec);
		num += managedStreamingLevelStateConfigs_.CalculateSize(_repeated_managedStreamingLevelStateConfigs_codec);
		num += managedGroupUnits_.CalculateSize(_repeated_managedGroupUnits_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ProcessCustom_SaveArchive other)
	{
		if (other != null)
		{
			if (other.ArchiveLabel.Length != 0)
			{
				ArchiveLabel = other.ArchiveLabel;
			}
			managedObjs_.Add(other.managedObjs_);
			managedNpcUnits_.Add(other.managedNpcUnits_);
			managedInteractors_.Add(other.managedInteractors_);
			managedStreamingLevelStateConfigs_.Add(other.managedStreamingLevelStateConfigs_);
			managedGroupUnits_.Add(other.managedGroupUnits_);
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
			case 10u:
				ArchiveLabel = input.ReadString();
				break;
			case 18u:
				managedObjs_.AddEntriesFrom(input, _repeated_managedObjs_codec);
				break;
			case 26u:
				managedNpcUnits_.AddEntriesFrom(input, _repeated_managedNpcUnits_codec);
				break;
			case 34u:
				managedInteractors_.AddEntriesFrom(input, _repeated_managedInteractors_codec);
				break;
			case 42u:
				managedStreamingLevelStateConfigs_.AddEntriesFrom(input, _repeated_managedStreamingLevelStateConfigs_codec);
				break;
			case 50u:
				managedGroupUnits_.AddEntriesFrom(input, _repeated_managedGroupUnits_codec);
				break;
			}
		}
	}
}
