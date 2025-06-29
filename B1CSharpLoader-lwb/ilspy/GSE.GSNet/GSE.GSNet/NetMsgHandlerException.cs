using System;

namespace GSE.GSNet;

public class NetMsgHandlerException : Exception
{
	public NetMsgHandlerException(Exception e)
		: base("NetHandlerException", e)
	{
	}
}
