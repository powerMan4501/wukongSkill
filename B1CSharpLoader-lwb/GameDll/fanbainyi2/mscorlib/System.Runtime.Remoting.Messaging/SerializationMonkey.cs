using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Security;

namespace System.Runtime.Remoting.Messaging;

[Serializable]
internal class SerializationMonkey : ISerializable, IFieldInfo
{
	internal ISerializationRootObject _obj;

	internal string[] fieldNames;

	internal Type[] fieldTypes;

	public string[] FieldNames
	{
		[SecurityCritical]
		get
		{
			return fieldNames;
		}
		[SecurityCritical]
		set
		{
			fieldNames = value;
		}
	}

	public Type[] FieldTypes
	{
		[SecurityCritical]
		get
		{
			return fieldTypes;
		}
		[SecurityCritical]
		set
		{
			fieldTypes = value;
		}
	}

	[SecurityCritical]
	internal SerializationMonkey(SerializationInfo info, StreamingContext ctx)
	{
		_obj.RootSetObjectData(info, ctx);
	}

	[SecurityCritical]
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_Method"));
	}
}
