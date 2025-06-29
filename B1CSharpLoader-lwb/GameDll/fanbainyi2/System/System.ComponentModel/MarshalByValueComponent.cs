using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace System.ComponentModel;

[ComVisible(true)]
[Designer("System.Windows.Forms.Design.ComponentDocumentDesigner, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(IRootDesigner))]
[DesignerCategory("Component")]
[TypeConverter(typeof(ComponentConverter))]
public class MarshalByValueComponent : IComponent, IDisposable, IServiceProvider
{
	private static readonly object EventDisposed = new object();

	private ISite site;

	private EventHandlerList events;

	protected EventHandlerList Events
	{
		get
		{
			if (events == null)
			{
				events = new EventHandlerList();
			}
			return events;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual ISite Site
	{
		get
		{
			return site;
		}
		set
		{
			site = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IContainer Container => site?.Container;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual bool DesignMode => site?.DesignMode ?? false;

	public event EventHandler Disposed
	{
		add
		{
			Events.AddHandler(EventDisposed, value);
		}
		remove
		{
			Events.RemoveHandler(EventDisposed, value);
		}
	}

	~MarshalByValueComponent()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!disposing)
		{
			return;
		}
		lock (this)
		{
			if (site != null && site.Container != null)
			{
				site.Container.Remove(this);
			}
			if (events != null)
			{
				((EventHandler)events[EventDisposed])?.Invoke(this, EventArgs.Empty);
			}
		}
	}

	public virtual object GetService(Type service)
	{
		if (site != null)
		{
			return site.GetService(service);
		}
		return null;
	}

	public override string ToString()
	{
		ISite site = this.site;
		if (site != null)
		{
			return site.Name + " [" + GetType().FullName + "]";
		}
		return GetType().FullName;
	}
}
