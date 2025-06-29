using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace System;

internal abstract class BaseConfigHandler
{
	private delegate void NotifyEventCallback(ConfigEvents nEvent);

	private delegate void BeginChildrenCallback(int size, ConfigNodeSubType subType, ConfigNodeType nType, int terminal, [MarshalAs(UnmanagedType.LPWStr)] string text, int textLength, int prefixLength);

	private delegate void EndChildrenCallback(int fEmpty, int size, ConfigNodeSubType subType, ConfigNodeType nType, int terminal, [MarshalAs(UnmanagedType.LPWStr)] string text, int textLength, int prefixLength);

	private delegate void ErrorCallback(int size, ConfigNodeSubType subType, ConfigNodeType nType, int terminal, [MarshalAs(UnmanagedType.LPWStr)] string text, int textLength, int prefixLength);

	private delegate void CreateNodeCallback(int size, ConfigNodeSubType subType, ConfigNodeType nType, int terminal, [MarshalAs(UnmanagedType.LPWStr)] string text, int textLength, int prefixLength);

	private delegate void CreateAttributeCallback(int size, ConfigNodeSubType subType, ConfigNodeType nType, int terminal, [MarshalAs(UnmanagedType.LPWStr)] string text, int textLength, int prefixLength);

	protected Delegate[] eventCallbacks;

	public BaseConfigHandler()
	{
		InitializeCallbacks();
	}

	private void InitializeCallbacks()
	{
		if (eventCallbacks == null)
		{
			eventCallbacks = new Delegate[6];
			eventCallbacks[0] = new NotifyEventCallback(NotifyEvent);
			eventCallbacks[1] = new BeginChildrenCallback(BeginChildren);
			eventCallbacks[2] = new EndChildrenCallback(EndChildren);
			eventCallbacks[3] = new ErrorCallback(Error);
			eventCallbacks[4] = new CreateNodeCallback(CreateNode);
			eventCallbacks[5] = new CreateAttributeCallback(CreateAttribute);
		}
	}

	public abstract void NotifyEvent(ConfigEvents nEvent);

	public abstract void BeginChildren(int size, ConfigNodeSubType subType, ConfigNodeType nType, int terminal, [MarshalAs(UnmanagedType.LPWStr)] string text, int textLength, int prefixLength);

	public abstract void EndChildren(int fEmpty, int size, ConfigNodeSubType subType, ConfigNodeType nType, int terminal, [MarshalAs(UnmanagedType.LPWStr)] string text, int textLength, int prefixLength);

	public abstract void Error(int size, ConfigNodeSubType subType, ConfigNodeType nType, int terminal, [MarshalAs(UnmanagedType.LPWStr)] string text, int textLength, int prefixLength);

	public abstract void CreateNode(int size, ConfigNodeSubType subType, ConfigNodeType nType, int terminal, [MarshalAs(UnmanagedType.LPWStr)] string text, int textLength, int prefixLength);

	public abstract void CreateAttribute(int size, ConfigNodeSubType subType, ConfigNodeType nType, int terminal, [MarshalAs(UnmanagedType.LPWStr)] string text, int textLength, int prefixLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal extern void RunParser(string fileName);
}
