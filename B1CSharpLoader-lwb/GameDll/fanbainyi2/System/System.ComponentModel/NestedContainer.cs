using System.Globalization;
using System.Security.Permissions;

namespace System.ComponentModel;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public class NestedContainer : Container, INestedContainer, IContainer, IDisposable
{
	private class Site : INestedSite, ISite, IServiceProvider
	{
		private IComponent component;

		private NestedContainer container;

		private string name;

		public IComponent Component => component;

		public IContainer Container => container;

		public bool DesignMode
		{
			get
			{
				IComponent owner = container.Owner;
				if (owner != null && owner.Site != null)
				{
					return owner.Site.DesignMode;
				}
				return false;
			}
		}

		public string FullName
		{
			get
			{
				if (name != null)
				{
					string ownerName = container.OwnerName;
					string text = name;
					if (ownerName != null)
					{
						text = string.Format(CultureInfo.InvariantCulture, "{0}.{1}", new object[2] { ownerName, text });
					}
					return text;
				}
				return name;
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				if (value == null || name == null || !value.Equals(name))
				{
					container.ValidateName(component, value);
					name = value;
				}
			}
		}

		internal Site(IComponent component, NestedContainer container, string name)
		{
			this.component = component;
			this.container = container;
			this.name = name;
		}

		public object GetService(Type service)
		{
			if (!(service == typeof(ISite)))
			{
				return container.GetService(service);
			}
			return this;
		}
	}

	private IComponent _owner;

	public IComponent Owner => _owner;

	protected virtual string OwnerName
	{
		get
		{
			string result = null;
			if (_owner != null && _owner.Site != null)
			{
				result = ((!(_owner.Site is INestedSite nestedSite)) ? _owner.Site.Name : nestedSite.FullName);
			}
			return result;
		}
	}

	public NestedContainer(IComponent owner)
	{
		if (owner == null)
		{
			throw new ArgumentNullException("owner");
		}
		_owner = owner;
		_owner.Disposed += OnOwnerDisposed;
	}

	protected override ISite CreateSite(IComponent component, string name)
	{
		if (component == null)
		{
			throw new ArgumentNullException("component");
		}
		return new Site(component, this, name);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			_owner.Disposed -= OnOwnerDisposed;
		}
		base.Dispose(disposing);
	}

	protected override object GetService(Type service)
	{
		if (service == typeof(INestedContainer))
		{
			return this;
		}
		return base.GetService(service);
	}

	private void OnOwnerDisposed(object sender, EventArgs e)
	{
		Dispose();
	}
}
