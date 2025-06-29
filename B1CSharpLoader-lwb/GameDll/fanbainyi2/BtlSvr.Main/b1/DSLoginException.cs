using System;

namespace b1;

public class DSLoginException : Exception
{
	private string ExtraMsg = "";

	public DSLoginException(string ExtraMsg = "")
	{
		this.ExtraMsg = ExtraMsg;
	}

	public override string ToString()
	{
		return "LoadingException " + ExtraMsg;
	}
}
