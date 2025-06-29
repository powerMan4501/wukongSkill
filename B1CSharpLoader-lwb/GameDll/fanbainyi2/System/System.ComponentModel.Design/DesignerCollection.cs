using System.Collections;
using System.Security.Permissions;

namespace System.ComponentModel.Design;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
public class DesignerCollection : ICollection, IEnumerable
{
	private IList designers;

	public int Count => designers.Count;

	public virtual IDesignerHost this[int index] => (IDesignerHost)designers[index];

	int ICollection.Count => Count;

	bool ICollection.IsSynchronized => false;

	object ICollection.SyncRoot => null;

	public DesignerCollection(IDesignerHost[] designers)
	{
		if (designers != null)
		{
			this.designers = new ArrayList(designers);
		}
		else
		{
			this.designers = new ArrayList();
		}
	}

	public DesignerCollection(IList designers)
	{
		this.designers = designers;
	}

	public IEnumerator GetEnumerator()
	{
		return designers.GetEnumerator();
	}

	void ICollection.CopyTo(Array array, int index)
	{
		designers.CopyTo(array, index);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
