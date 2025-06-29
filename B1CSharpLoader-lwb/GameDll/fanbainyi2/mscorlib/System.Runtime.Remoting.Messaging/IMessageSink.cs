using System.Runtime.InteropServices;
using System.Security;

namespace System.Runtime.Remoting.Messaging;

[ComVisible(true)]
public interface IMessageSink
{
	IMessageSink NextSink
	{
		[SecurityCritical]
		get;
	}

	[SecurityCritical]
	IMessage SyncProcessMessage(IMessage msg);

	[SecurityCritical]
	IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink);
}
