namespace System.ComponentModel.Design.Serialization;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
[Obsolete("This attribute has been deprecated. Use DesignerSerializerAttribute instead.  For example, to specify a root designer for CodeDom, use DesignerSerializerAttribute(...,typeof(TypeCodeDomSerializer)).  http://go.microsoft.com/fwlink/?linkid=14202")]
public sealed class RootDesignerSerializerAttribute : Attribute
{
	private bool reloadable;

	private string serializerTypeName;

	private string serializerBaseTypeName;

	private string typeId;

	public bool Reloadable => reloadable;

	public string SerializerTypeName => serializerTypeName;

	public string SerializerBaseTypeName => serializerBaseTypeName;

	public override object TypeId
	{
		get
		{
			if (typeId == null)
			{
				string text = serializerBaseTypeName;
				int num = text.IndexOf(',');
				if (num != -1)
				{
					text = text.Substring(0, num);
				}
				typeId = GetType().FullName + text;
			}
			return typeId;
		}
	}

	public RootDesignerSerializerAttribute(Type serializerType, Type baseSerializerType, bool reloadable)
	{
		serializerTypeName = serializerType.AssemblyQualifiedName;
		serializerBaseTypeName = baseSerializerType.AssemblyQualifiedName;
		this.reloadable = reloadable;
	}

	public RootDesignerSerializerAttribute(string serializerTypeName, Type baseSerializerType, bool reloadable)
	{
		this.serializerTypeName = serializerTypeName;
		serializerBaseTypeName = baseSerializerType.AssemblyQualifiedName;
		this.reloadable = reloadable;
	}

	public RootDesignerSerializerAttribute(string serializerTypeName, string baseSerializerTypeName, bool reloadable)
	{
		this.serializerTypeName = serializerTypeName;
		serializerBaseTypeName = baseSerializerTypeName;
		this.reloadable = reloadable;
	}
}
