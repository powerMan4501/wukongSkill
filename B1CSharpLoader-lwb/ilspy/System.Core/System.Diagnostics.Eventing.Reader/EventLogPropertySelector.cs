using System.Collections.Generic;
using System.Security;
using System.Security.Permissions;
using Microsoft.Win32;

namespace System.Diagnostics.Eventing.Reader;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public class EventLogPropertySelector : IDisposable
{
	private EventLogHandle renderContextHandleValues;

	internal EventLogHandle Handle => renderContextHandleValues;

	[SecurityCritical]
	public EventLogPropertySelector(IEnumerable<string> propertyQueries)
	{
		EventLogPermissionHolder.GetEventLogPermission().Demand();
		if (propertyQueries == null)
		{
			throw new ArgumentNullException("propertyQueries");
		}
		string[] array;
		if (propertyQueries is ICollection<string> collection)
		{
			array = new string[collection.Count];
			collection.CopyTo(array, 0);
		}
		else
		{
			List<string> list = new List<string>(propertyQueries);
			array = list.ToArray();
		}
		renderContextHandleValues = NativeWrapper.EvtCreateRenderContext(array.Length, array, Microsoft.Win32.UnsafeNativeMethods.EvtRenderContextFlags.EvtRenderContextValues);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[SecuritySafeCritical]
	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			EventLogPermissionHolder.GetEventLogPermission().Demand();
		}
		if (renderContextHandleValues != null && !renderContextHandleValues.IsInvalid)
		{
			renderContextHandleValues.Dispose();
		}
	}
}
