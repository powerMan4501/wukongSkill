using System;

namespace b1.Protobuf.DataAPI;

internal class InvalidProtoMessageException : Exception
{
	public string ClassName;

	public InvalidProtoMessageException(in string className)
	{
		ClassName = className;
	}
}
