#define TRACE
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Permissions;

namespace System.Diagnostics;

public class TraceSource
{
	private static List<WeakReference> tracesources = new List<WeakReference>();

	private static int s_LastCollectionCount;

	private volatile SourceSwitch internalSwitch;

	private volatile TraceListenerCollection listeners;

	private StringDictionary attributes;

	private SourceLevels switchLevel;

	private volatile string sourceName;

	internal volatile bool _initCalled;

	public StringDictionary Attributes
	{
		get
		{
			Initialize();
			if (attributes == null)
			{
				attributes = new StringDictionary();
			}
			return attributes;
		}
	}

	public string Name => sourceName;

	public TraceListenerCollection Listeners
	{
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		get
		{
			Initialize();
			return listeners;
		}
	}

	public SourceSwitch Switch
	{
		get
		{
			Initialize();
			return internalSwitch;
		}
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("Switch");
			}
			Initialize();
			internalSwitch = value;
		}
	}

	public TraceSource(string name)
		: this(name, SourceLevels.Off)
	{
	}

	public TraceSource(string name, SourceLevels defaultLevel)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (name.Length == 0)
		{
			throw new ArgumentException("name");
		}
		sourceName = name;
		switchLevel = defaultLevel;
		lock (tracesources)
		{
			_pruneCachedTraceSources();
			tracesources.Add(new WeakReference(this));
		}
	}

	private static void _pruneCachedTraceSources()
	{
		lock (tracesources)
		{
			if (s_LastCollectionCount == GC.CollectionCount(2))
			{
				return;
			}
			List<WeakReference> list = new List<WeakReference>(tracesources.Count);
			for (int i = 0; i < tracesources.Count; i++)
			{
				TraceSource traceSource = (TraceSource)tracesources[i].Target;
				if (traceSource != null)
				{
					list.Add(tracesources[i]);
				}
			}
			if (list.Count < tracesources.Count)
			{
				tracesources.Clear();
				tracesources.AddRange(list);
				tracesources.TrimExcess();
			}
			s_LastCollectionCount = GC.CollectionCount(2);
		}
	}

	private void Initialize()
	{
		if (_initCalled)
		{
			return;
		}
		lock (this)
		{
			if (_initCalled)
			{
				return;
			}
			SourceElementsCollection sources = DiagnosticsConfiguration.Sources;
			if (sources != null)
			{
				SourceElement sourceElement = sources[sourceName];
				if (sourceElement != null)
				{
					if (!string.IsNullOrEmpty(sourceElement.SwitchName))
					{
						CreateSwitch(sourceElement.SwitchType, sourceElement.SwitchName);
					}
					else
					{
						CreateSwitch(sourceElement.SwitchType, sourceName);
						if (!string.IsNullOrEmpty(sourceElement.SwitchValue))
						{
							internalSwitch.Level = (SourceLevels)Enum.Parse(typeof(SourceLevels), sourceElement.SwitchValue);
						}
					}
					listeners = sourceElement.Listeners.GetRuntimeObject();
					attributes = new StringDictionary();
					TraceUtils.VerifyAttributes(sourceElement.Attributes, GetSupportedAttributes(), this);
					attributes.ReplaceHashtable(sourceElement.Attributes);
				}
				else
				{
					NoConfigInit();
				}
			}
			else
			{
				NoConfigInit();
			}
			_initCalled = true;
		}
	}

	private void NoConfigInit()
	{
		internalSwitch = new SourceSwitch(sourceName, switchLevel.ToString());
		listeners = new TraceListenerCollection();
		listeners.Add(new DefaultTraceListener());
		attributes = null;
	}

	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public void Close()
	{
		if (listeners == null)
		{
			return;
		}
		lock (TraceInternal.critSec)
		{
			foreach (TraceListener listener in listeners)
			{
				listener.Close();
			}
		}
	}

	public void Flush()
	{
		if (listeners == null)
		{
			return;
		}
		if (TraceInternal.UseGlobalLock)
		{
			lock (TraceInternal.critSec)
			{
				foreach (TraceListener listener in listeners)
				{
					listener.Flush();
				}
				return;
			}
		}
		foreach (TraceListener listener2 in listeners)
		{
			if (!listener2.IsThreadSafe)
			{
				lock (listener2)
				{
					listener2.Flush();
				}
			}
			else
			{
				listener2.Flush();
			}
		}
	}

	protected internal virtual string[] GetSupportedAttributes()
	{
		return null;
	}

	internal static void RefreshAll()
	{
		lock (tracesources)
		{
			_pruneCachedTraceSources();
			for (int i = 0; i < tracesources.Count; i++)
			{
				((TraceSource)tracesources[i].Target)?.Refresh();
			}
		}
	}

	internal void Refresh()
	{
		if (!_initCalled)
		{
			Initialize();
			return;
		}
		SourceElementsCollection sources = DiagnosticsConfiguration.Sources;
		if (sources == null)
		{
			return;
		}
		SourceElement sourceElement = sources[Name];
		if (sourceElement != null)
		{
			if ((string.IsNullOrEmpty(sourceElement.SwitchType) && internalSwitch.GetType() != typeof(SourceSwitch)) || sourceElement.SwitchType != internalSwitch.GetType().AssemblyQualifiedName)
			{
				if (!string.IsNullOrEmpty(sourceElement.SwitchName))
				{
					CreateSwitch(sourceElement.SwitchType, sourceElement.SwitchName);
				}
				else
				{
					CreateSwitch(sourceElement.SwitchType, Name);
					if (!string.IsNullOrEmpty(sourceElement.SwitchValue))
					{
						internalSwitch.Level = (SourceLevels)Enum.Parse(typeof(SourceLevels), sourceElement.SwitchValue);
					}
				}
			}
			else if (!string.IsNullOrEmpty(sourceElement.SwitchName))
			{
				if (sourceElement.SwitchName != internalSwitch.DisplayName)
				{
					CreateSwitch(sourceElement.SwitchType, sourceElement.SwitchName);
				}
				else
				{
					internalSwitch.Refresh();
				}
			}
			else if (!string.IsNullOrEmpty(sourceElement.SwitchValue))
			{
				internalSwitch.Level = (SourceLevels)Enum.Parse(typeof(SourceLevels), sourceElement.SwitchValue);
			}
			else
			{
				internalSwitch.Level = SourceLevels.Off;
			}
			TraceListenerCollection traceListenerCollection = new TraceListenerCollection();
			foreach (ListenerElement listener in sourceElement.Listeners)
			{
				TraceListener traceListener = listeners[listener.Name];
				if (traceListener != null)
				{
					traceListenerCollection.Add(listener.RefreshRuntimeObject(traceListener));
				}
				else
				{
					traceListenerCollection.Add(listener.GetRuntimeObject());
				}
			}
			TraceUtils.VerifyAttributes(sourceElement.Attributes, GetSupportedAttributes(), this);
			attributes = new StringDictionary();
			attributes.ReplaceHashtable(sourceElement.Attributes);
			listeners = traceListenerCollection;
		}
		else
		{
			internalSwitch.Level = switchLevel;
			listeners.Clear();
			attributes = null;
		}
	}

	[Conditional("TRACE")]
	public void TraceEvent(TraceEventType eventType, int id)
	{
		Initialize();
		TraceEventCache eventCache = new TraceEventCache();
		if (!internalSwitch.ShouldTrace(eventType) || listeners == null)
		{
			return;
		}
		if (TraceInternal.UseGlobalLock)
		{
			lock (TraceInternal.critSec)
			{
				for (int i = 0; i < listeners.Count; i++)
				{
					TraceListener traceListener = listeners[i];
					traceListener.TraceEvent(eventCache, Name, eventType, id);
					if (Trace.AutoFlush)
					{
						traceListener.Flush();
					}
				}
				return;
			}
		}
		for (int j = 0; j < listeners.Count; j++)
		{
			TraceListener traceListener2 = listeners[j];
			if (!traceListener2.IsThreadSafe)
			{
				lock (traceListener2)
				{
					traceListener2.TraceEvent(eventCache, Name, eventType, id);
					if (Trace.AutoFlush)
					{
						traceListener2.Flush();
					}
				}
			}
			else
			{
				traceListener2.TraceEvent(eventCache, Name, eventType, id);
				if (Trace.AutoFlush)
				{
					traceListener2.Flush();
				}
			}
		}
	}

	[Conditional("TRACE")]
	public void TraceEvent(TraceEventType eventType, int id, string message)
	{
		Initialize();
		TraceEventCache eventCache = new TraceEventCache();
		if (!internalSwitch.ShouldTrace(eventType) || listeners == null)
		{
			return;
		}
		if (TraceInternal.UseGlobalLock)
		{
			lock (TraceInternal.critSec)
			{
				for (int i = 0; i < listeners.Count; i++)
				{
					TraceListener traceListener = listeners[i];
					traceListener.TraceEvent(eventCache, Name, eventType, id, message);
					if (Trace.AutoFlush)
					{
						traceListener.Flush();
					}
				}
				return;
			}
		}
		for (int j = 0; j < listeners.Count; j++)
		{
			TraceListener traceListener2 = listeners[j];
			if (!traceListener2.IsThreadSafe)
			{
				lock (traceListener2)
				{
					traceListener2.TraceEvent(eventCache, Name, eventType, id, message);
					if (Trace.AutoFlush)
					{
						traceListener2.Flush();
					}
				}
			}
			else
			{
				traceListener2.TraceEvent(eventCache, Name, eventType, id, message);
				if (Trace.AutoFlush)
				{
					traceListener2.Flush();
				}
			}
		}
	}

	[Conditional("TRACE")]
	public void TraceEvent(TraceEventType eventType, int id, string format, params object[] args)
	{
		Initialize();
		TraceEventCache eventCache = new TraceEventCache();
		if (!internalSwitch.ShouldTrace(eventType) || listeners == null)
		{
			return;
		}
		if (TraceInternal.UseGlobalLock)
		{
			lock (TraceInternal.critSec)
			{
				for (int i = 0; i < listeners.Count; i++)
				{
					TraceListener traceListener = listeners[i];
					traceListener.TraceEvent(eventCache, Name, eventType, id, format, args);
					if (Trace.AutoFlush)
					{
						traceListener.Flush();
					}
				}
				return;
			}
		}
		for (int j = 0; j < listeners.Count; j++)
		{
			TraceListener traceListener2 = listeners[j];
			if (!traceListener2.IsThreadSafe)
			{
				lock (traceListener2)
				{
					traceListener2.TraceEvent(eventCache, Name, eventType, id, format, args);
					if (Trace.AutoFlush)
					{
						traceListener2.Flush();
					}
				}
			}
			else
			{
				traceListener2.TraceEvent(eventCache, Name, eventType, id, format, args);
				if (Trace.AutoFlush)
				{
					traceListener2.Flush();
				}
			}
		}
	}

	[Conditional("TRACE")]
	public void TraceData(TraceEventType eventType, int id, object data)
	{
		Initialize();
		TraceEventCache eventCache = new TraceEventCache();
		if (!internalSwitch.ShouldTrace(eventType) || listeners == null)
		{
			return;
		}
		if (TraceInternal.UseGlobalLock)
		{
			lock (TraceInternal.critSec)
			{
				for (int i = 0; i < listeners.Count; i++)
				{
					TraceListener traceListener = listeners[i];
					traceListener.TraceData(eventCache, Name, eventType, id, data);
					if (Trace.AutoFlush)
					{
						traceListener.Flush();
					}
				}
				return;
			}
		}
		for (int j = 0; j < listeners.Count; j++)
		{
			TraceListener traceListener2 = listeners[j];
			if (!traceListener2.IsThreadSafe)
			{
				lock (traceListener2)
				{
					traceListener2.TraceData(eventCache, Name, eventType, id, data);
					if (Trace.AutoFlush)
					{
						traceListener2.Flush();
					}
				}
			}
			else
			{
				traceListener2.TraceData(eventCache, Name, eventType, id, data);
				if (Trace.AutoFlush)
				{
					traceListener2.Flush();
				}
			}
		}
	}

	[Conditional("TRACE")]
	public void TraceData(TraceEventType eventType, int id, params object[] data)
	{
		Initialize();
		TraceEventCache eventCache = new TraceEventCache();
		if (!internalSwitch.ShouldTrace(eventType) || listeners == null)
		{
			return;
		}
		if (TraceInternal.UseGlobalLock)
		{
			lock (TraceInternal.critSec)
			{
				for (int i = 0; i < listeners.Count; i++)
				{
					TraceListener traceListener = listeners[i];
					traceListener.TraceData(eventCache, Name, eventType, id, data);
					if (Trace.AutoFlush)
					{
						traceListener.Flush();
					}
				}
				return;
			}
		}
		for (int j = 0; j < listeners.Count; j++)
		{
			TraceListener traceListener2 = listeners[j];
			if (!traceListener2.IsThreadSafe)
			{
				lock (traceListener2)
				{
					traceListener2.TraceData(eventCache, Name, eventType, id, data);
					if (Trace.AutoFlush)
					{
						traceListener2.Flush();
					}
				}
			}
			else
			{
				traceListener2.TraceData(eventCache, Name, eventType, id, data);
				if (Trace.AutoFlush)
				{
					traceListener2.Flush();
				}
			}
		}
	}

	[Conditional("TRACE")]
	public void TraceInformation(string message)
	{
		TraceEvent(TraceEventType.Information, 0, message, null);
	}

	[Conditional("TRACE")]
	public void TraceInformation(string format, params object[] args)
	{
		TraceEvent(TraceEventType.Information, 0, format, args);
	}

	[Conditional("TRACE")]
	public void TraceTransfer(int id, string message, Guid relatedActivityId)
	{
		Initialize();
		TraceEventCache eventCache = new TraceEventCache();
		if (!internalSwitch.ShouldTrace(TraceEventType.Transfer) || listeners == null)
		{
			return;
		}
		if (TraceInternal.UseGlobalLock)
		{
			lock (TraceInternal.critSec)
			{
				for (int i = 0; i < listeners.Count; i++)
				{
					TraceListener traceListener = listeners[i];
					traceListener.TraceTransfer(eventCache, Name, id, message, relatedActivityId);
					if (Trace.AutoFlush)
					{
						traceListener.Flush();
					}
				}
				return;
			}
		}
		for (int j = 0; j < listeners.Count; j++)
		{
			TraceListener traceListener2 = listeners[j];
			if (!traceListener2.IsThreadSafe)
			{
				lock (traceListener2)
				{
					traceListener2.TraceTransfer(eventCache, Name, id, message, relatedActivityId);
					if (Trace.AutoFlush)
					{
						traceListener2.Flush();
					}
				}
			}
			else
			{
				traceListener2.TraceTransfer(eventCache, Name, id, message, relatedActivityId);
				if (Trace.AutoFlush)
				{
					traceListener2.Flush();
				}
			}
		}
	}

	private void CreateSwitch(string typename, string name)
	{
		if (!string.IsNullOrEmpty(typename))
		{
			internalSwitch = (SourceSwitch)TraceUtils.GetRuntimeObject(typename, typeof(SourceSwitch), name);
		}
		else
		{
			internalSwitch = new SourceSwitch(name, switchLevel.ToString());
		}
	}
}
