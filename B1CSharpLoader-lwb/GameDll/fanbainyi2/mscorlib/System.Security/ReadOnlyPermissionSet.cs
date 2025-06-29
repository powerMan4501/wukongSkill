using System.Collections;
using System.Runtime.Serialization;

namespace System.Security;

[Serializable]
public sealed class ReadOnlyPermissionSet : PermissionSet
{
	private SecurityElement m_originXml;

	[NonSerialized]
	private bool m_deserializing;

	public override bool IsReadOnly => true;

	public ReadOnlyPermissionSet(SecurityElement permissionSetXml)
	{
		if (permissionSetXml == null)
		{
			throw new ArgumentNullException("permissionSetXml");
		}
		m_originXml = permissionSetXml.Copy();
		base.FromXml(m_originXml);
	}

	[OnDeserializing]
	private void OnDeserializing(StreamingContext ctx)
	{
		m_deserializing = true;
	}

	[OnDeserialized]
	private void OnDeserialized(StreamingContext ctx)
	{
		m_deserializing = false;
	}

	public override PermissionSet Copy()
	{
		return new ReadOnlyPermissionSet(m_originXml);
	}

	public override SecurityElement ToXml()
	{
		return m_originXml.Copy();
	}

	protected override IEnumerator GetEnumeratorImpl()
	{
		return new ReadOnlyPermissionSetEnumerator(base.GetEnumeratorImpl());
	}

	protected override IPermission GetPermissionImpl(Type permClass)
	{
		return base.GetPermissionImpl(permClass)?.Copy();
	}

	protected override IPermission AddPermissionImpl(IPermission perm)
	{
		throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_ModifyROPermSet"));
	}

	public override void FromXml(SecurityElement et)
	{
		if (m_deserializing)
		{
			base.FromXml(et);
			return;
		}
		throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_ModifyROPermSet"));
	}

	protected override IPermission RemovePermissionImpl(Type permClass)
	{
		throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_ModifyROPermSet"));
	}

	protected override IPermission SetPermissionImpl(IPermission perm)
	{
		throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_ModifyROPermSet"));
	}
}
