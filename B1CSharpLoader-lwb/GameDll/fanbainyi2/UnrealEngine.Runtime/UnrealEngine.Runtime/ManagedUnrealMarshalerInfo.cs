using System;

namespace UnrealEngine.Runtime;

public struct ManagedUnrealMarshalerInfo
{
	public ManagedUnrealMarshalerType MarshalerType;

	public EPropertyType Type;

	public string Path;

	public EPropertyType Arg1Type;

	public string Arg1Path;

	public EPropertyType Arg2Type;

	public string Arg2Path;

	public ManagedUnrealMarshalerInfo(ManagedUnrealPropertyInfo propertyInfo, ManagedUnrealMarshalerType marshalerType)
	{
		MarshalerType = marshalerType;
		Type = propertyInfo.Type.TypeCode;
		Path = propertyInfo.Type.Path;
		Arg1Type = EPropertyType.Unknown;
		Arg1Path = null;
		Arg2Type = EPropertyType.Unknown;
		Arg2Path = null;
		if (propertyInfo.GenericArgs != null)
		{
			if (propertyInfo.GenericArgs.Count >= 1)
			{
				Arg1Type = propertyInfo.GenericArgs[0].TypeCode;
				Arg1Path = propertyInfo.GenericArgs[0].Path;
			}
			if (propertyInfo.GenericArgs.Count >= 2)
			{
				Arg2Type = propertyInfo.GenericArgs[1].TypeCode;
				Arg2Path = propertyInfo.GenericArgs[1].Path;
			}
			if (propertyInfo.GenericArgs.Count >= 3)
			{
				throw new NotImplementedException("Handle more than 2 generic args if Unreal has a type requiring it");
			}
		}
	}

	public ManagedUnrealMarshalerInfo(EPropertyType typeCode, string typePath, ManagedUnrealMarshalerType marshalerType)
	{
		MarshalerType = marshalerType;
		Type = typeCode;
		Path = typePath;
		Arg1Type = EPropertyType.Unknown;
		Arg1Path = null;
		Arg2Type = EPropertyType.Unknown;
		Arg2Path = null;
	}

	public ManagedUnrealMarshalerInfo(EPropertyType typeCode, string typePath, EPropertyType arg1TypeCode, string arg1TypePath, EPropertyType arg2TypeCode, string arg2TypePath, ManagedUnrealMarshalerType marshalerType)
	{
		MarshalerType = marshalerType;
		Type = typeCode;
		Path = typePath;
		Arg1Type = arg1TypeCode;
		Arg1Path = arg1TypePath;
		Arg2Type = arg2TypeCode;
		Arg2Path = arg2TypePath;
	}
}
