using System.ComponentModel;

namespace System.Net.Security;

internal class ProtocolToken
{
	internal SecurityStatus Status;

	internal byte[] Payload;

	internal int Size;

	internal bool Failed
	{
		get
		{
			if (Status != SecurityStatus.OK)
			{
				return Status != SecurityStatus.ContinueNeeded;
			}
			return false;
		}
	}

	internal bool Done => Status == SecurityStatus.OK;

	internal bool Renegotiate => Status == SecurityStatus.Renegotiate;

	internal bool CloseConnection => Status == SecurityStatus.ContextExpired;

	internal ProtocolToken(byte[] data, SecurityStatus errorCode)
	{
		Status = errorCode;
		Payload = data;
		Size = ((data != null) ? data.Length : 0);
	}

	internal Win32Exception GetException()
	{
		if (!Done)
		{
			return new Win32Exception((int)Status);
		}
		return null;
	}
}
