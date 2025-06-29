using System;

namespace b1.Protobuf.DataAPI;

public class DuplicatedIDException : Exception
{
	public int DuplicatedID;

	public DuplicatedIDException(in int duplicatedID)
	{
		DuplicatedID = duplicatedID;
	}

	public override string ToString()
	{
		return $"duplicated id {DuplicatedID}";
	}
}
