using System.Collections;
using System.IO;
using System.Security.Permissions;

namespace System.ComponentModel.Design.Serialization;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public abstract class SerializationStore : IDisposable
{
	public abstract ICollection Errors { get; }

	public abstract void Close();

	public abstract void Save(Stream stream);

	void IDisposable.Dispose()
	{
		Dispose(disposing: true);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			Close();
		}
	}
}
