using System.Collections.Generic;
using System.IO;

namespace UnrealEngine.Runtime;

public class ManagedUnrealEnumInfo : ManagedUnrealTypeInfo
{
	public List<ManagedUnrealEnumValueInfo> EnumValues { get; set; }

	public ManagedUnrealEnumInfo()
	{
		EnumValues = new List<ManagedUnrealEnumValueInfo>();
	}

	public override void Serialize(BinaryWriter writer)
	{
		base.Serialize(writer);
		WriteObjects(writer, EnumValues);
	}

	public override void Deserialize(BinaryReader reader)
	{
		base.Deserialize(reader);
		EnumValues = ReadObjects<ManagedUnrealEnumValueInfo>(reader);
	}
}
