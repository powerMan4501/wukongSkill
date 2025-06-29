using System;
using Google.Protobuf;

namespace OssB1;

public sealed class DeviceInfo : IMessage<DeviceInfo>, IMessage, IEquatable<DeviceInfo>, IDeepCloneable<DeviceInfo>
{
	private static readonly MessageParser<DeviceInfo> _parser = new MessageParser<DeviceInfo>(() => new DeviceInfo());

	private UnknownFieldSet _unknownFields;

	private uint mem_;

	private string cpu_ = "";

	private string gpu_ = "";

	public static MessageParser<DeviceInfo> Parser => _parser;

	public uint Mem
	{
		get
		{
			return mem_;
		}
		set
		{
			mem_ = value;
		}
	}

	public string Cpu
	{
		get
		{
			return cpu_;
		}
		set
		{
			cpu_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Gpu
	{
		get
		{
			return gpu_;
		}
		set
		{
			gpu_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public DeviceInfo()
	{
	}

	public DeviceInfo(DeviceInfo other)
		: this()
	{
		mem_ = other.mem_;
		cpu_ = other.cpu_;
		gpu_ = other.gpu_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DeviceInfo Clone()
	{
		return new DeviceInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as DeviceInfo);
	}

	public bool Equals(DeviceInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Mem != other.Mem)
		{
			return false;
		}
		if (Cpu != other.Cpu)
		{
			return false;
		}
		if (Gpu != other.Gpu)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Mem != 0)
		{
			num ^= Mem.GetHashCode();
		}
		if (Cpu.Length != 0)
		{
			num ^= Cpu.GetHashCode();
		}
		if (Gpu.Length != 0)
		{
			num ^= Gpu.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Mem != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Mem);
		}
		if (Cpu.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Cpu);
		}
		if (Gpu.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Gpu);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Mem != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Mem);
		}
		if (Cpu.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Cpu);
		}
		if (Gpu.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Gpu);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(DeviceInfo other)
	{
		if (other != null)
		{
			if (other.Mem != 0)
			{
				Mem = other.Mem;
			}
			if (other.Cpu.Length != 0)
			{
				Cpu = other.Cpu;
			}
			if (other.Gpu.Length != 0)
			{
				Gpu = other.Gpu;
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
				Mem = input.ReadUInt32();
				break;
			case 18u:
				Cpu = input.ReadString();
				break;
			case 26u:
				Gpu = input.ReadString();
				break;
			}
		}
	}
}
