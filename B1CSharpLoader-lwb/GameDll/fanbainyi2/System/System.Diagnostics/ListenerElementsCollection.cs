using System.Collections;
using System.Configuration;
using System.Security.Permissions;

namespace System.Diagnostics;

[ConfigurationCollection(typeof(ListenerElement))]
internal class ListenerElementsCollection : ConfigurationElementCollection
{
	public new ListenerElement this[string name] => (ListenerElement)BaseGet(name);

	public override ConfigurationElementCollectionType CollectionType => ConfigurationElementCollectionType.AddRemoveClearMap;

	protected override ConfigurationElement CreateNewElement()
	{
		return new ListenerElement(allowReferences: true);
	}

	protected override object GetElementKey(ConfigurationElement element)
	{
		return ((ListenerElement)element).Name;
	}

	public TraceListenerCollection GetRuntimeObject()
	{
		TraceListenerCollection traceListenerCollection = new TraceListenerCollection();
		bool flag = false;
		IEnumerator enumerator = GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ListenerElement listenerElement = (ListenerElement)enumerator.Current;
				if (!flag && !listenerElement._isAddedByDefault)
				{
					new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
					flag = true;
				}
				traceListenerCollection.Add(listenerElement.GetRuntimeObject());
			}
			return traceListenerCollection;
		}
		finally
		{
			IDisposable disposable = enumerator as IDisposable;
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}
	}

	protected override void InitializeDefault()
	{
		InitializeDefaultInternal();
	}

	internal void InitializeDefaultInternal()
	{
		ListenerElement listenerElement = new ListenerElement(allowReferences: false);
		listenerElement.Name = "Default";
		listenerElement.TypeName = typeof(DefaultTraceListener).FullName;
		listenerElement._isAddedByDefault = true;
		BaseAdd(listenerElement);
	}

	protected override void BaseAdd(ConfigurationElement element)
	{
		ListenerElement listenerElement = element as ListenerElement;
		if (listenerElement.Name.Equals("Default") && listenerElement.TypeName.Equals(typeof(DefaultTraceListener).FullName))
		{
			BaseAdd(listenerElement, throwIfExists: false);
		}
		else
		{
			BaseAdd(listenerElement, ThrowOnDuplicate);
		}
	}
}
