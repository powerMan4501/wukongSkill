namespace System.ComponentModel.Design.Serialization;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
public sealed class DesignerSerializerAttribute : Attribute
{
	private string serializerTypeName;

	private string serializerBaseTypeName;

	private string typeId;

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

	public DesignerSerializerAttribute(Type serializerType, Type baseSerializerType)
	{
		serializerTypeName = serializerType.AssemblyQualifiedName;
		serializerBaseTypeName = baseSerializerType.AssemblyQualifiedName;
	}

	public DesignerSerializerAttribute(string serializerTypeName, Type baseSerializerType)
	{
		this.serializerTypeName = serializerTypeName;
		serializerBaseTypeName = baseSerializerType.AssemblyQualifiedName;
	}

	public DesignerSerializerAttribute(string serializerTypeName, string baseSerializerTypeName)
	{
		this.serializerTypeName = serializerTypeName;
		serializerBaseTypeName = baseSerializerTypeName;
	}
}
