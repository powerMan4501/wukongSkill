using System;

namespace b1.Protobuf.DataAPI;

internal class IncorrectPropertyNumberException : Exception
{
	public readonly string PropertyOwner;

	public readonly int OwnerPropertyNum;

	public readonly int ActualPropertyNum;

	public IncorrectPropertyNumberException(in string propertyOwner, in int ownerPropertyNum, in int actualPropertyNum)
	{
		PropertyOwner = propertyOwner;
		OwnerPropertyNum = ownerPropertyNum;
		ActualPropertyNum = actualPropertyNum;
	}
}
