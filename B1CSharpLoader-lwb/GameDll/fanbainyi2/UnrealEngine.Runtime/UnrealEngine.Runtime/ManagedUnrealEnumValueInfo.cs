using System.IO;

namespace UnrealEngine.Runtime;

public class ManagedUnrealEnumValueInfo : ManagedUnrealReflectionBase
{
	public ulong Value { get; set; }

	public override void Serialize(BinaryWriter writer)
	{
		base.Serialize(writer);
		writer.Write(Value);
	}

	public override void Deserialize(BinaryReader reader)
	{
		base.Deserialize(reader);
		Value = reader.ReadUInt64();
	}
}
