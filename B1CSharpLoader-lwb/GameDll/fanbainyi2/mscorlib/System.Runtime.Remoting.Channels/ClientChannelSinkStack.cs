using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security;

namespace System.Runtime.Remoting.Channels;

[SecurityCritical]
[ComVisible(true)]
public class ClientChannelSinkStack : IClientChannelSinkStack, IClientResponseChannelSinkStack
{
	private class SinkStack
	{
		public SinkStack PrevStack;

		public IClientChannelSink Sink;

		public object State;
	}

	private SinkStack _stack;

	private IMessageSink _replySink;

	public ClientChannelSinkStack()
	{
	}

	public ClientChannelSinkStack(IMessageSink replySink)
	{
		_replySink = replySink;
	}

	[SecurityCritical]
	public void Push(IClientChannelSink sink, object state)
	{
		SinkStack sinkStack = new SinkStack();
		sinkStack.PrevStack = _stack;
		sinkStack.Sink = sink;
		sinkStack.State = state;
		_stack = sinkStack;
	}

	[SecurityCritical]
	public object Pop(IClientChannelSink sink)
	{
		if (_stack == null)
		{
			throw new RemotingException(Environment.GetResourceString("Remoting_Channel_PopOnEmptySinkStack"));
		}
		while (_stack.Sink != sink)
		{
			_stack = _stack.PrevStack;
			if (_stack == null)
			{
				break;
			}
		}
		if (_stack.Sink == null)
		{
			throw new RemotingException(Environment.GetResourceString("Remoting_Channel_PopFromSinkStackWithoutPush"));
		}
		object state = _stack.State;
		_stack = _stack.PrevStack;
		return state;
	}

	[SecurityCritical]
	public void AsyncProcessResponse(ITransportHeaders headers, Stream stream)
	{
		if (_replySink != null)
		{
			if (_stack == null)
			{
				throw new RemotingException(Environment.GetResourceString("Remoting_Channel_CantCallAPRWhenStackEmpty"));
			}
			IClientChannelSink sink = _stack.Sink;
			object state = _stack.State;
			_stack = _stack.PrevStack;
			sink.AsyncProcessResponse(this, state, headers, stream);
		}
	}

	[SecurityCritical]
	public void DispatchReplyMessage(IMessage msg)
	{
		if (_replySink != null)
		{
			_replySink.SyncProcessMessage(msg);
		}
	}

	[SecurityCritical]
	public void DispatchException(Exception e)
	{
		DispatchReplyMessage(new ReturnMessage(e, null));
	}
}
