using System;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.Mono.Cecil;
using ILRuntime.Mono.Collections.Generic;
using ILRuntime.Runtime.Stack;

namespace ILRuntime.Runtime.Intepreter;

internal class ILEnumTypeInstance : ILTypeInstance
{
	public ILEnumTypeInstance(ILType type)
	{
		if (!type.IsEnum)
		{
			throw new NotSupportedException();
		}
		base.type = type;
		fields = new StackObject[1];
	}

	public override ILTypeInstance Clone()
	{
		ILEnumTypeInstance iLEnumTypeInstance = new ILEnumTypeInstance(type);
		iLEnumTypeInstance.fields[0] = fields[0];
		return iLEnumTypeInstance;
	}

	public unsafe override string ToString()
	{
		Collection<FieldDefinition> collection = type.TypeDefinition.Fields;
		long num = 0L;
		int num2 = 0;
		bool flag = fields[0].ObjectType == ObjectTypes.Long;
		if (flag)
		{
			fixed (StackObject* ptr = fields)
			{
				num = *(long*)(&ptr->Value);
			}
		}
		else
		{
			num2 = fields[0].Value;
		}
		for (int i = 0; i < collection.Count; i++)
		{
			FieldDefinition fieldDefinition = collection[i];
			if (!fieldDefinition.IsStatic)
			{
				continue;
			}
			if (flag)
			{
				if (((fieldDefinition.Constant is long) ? ((long)fieldDefinition.Constant) : ((long)(ulong)fieldDefinition.Constant)) == num)
				{
					return fieldDefinition.Name;
				}
				continue;
			}
			if (fieldDefinition.Constant is int)
			{
				if ((int)fieldDefinition.Constant == num2)
				{
					return fieldDefinition.Name;
				}
				continue;
			}
			if (fieldDefinition.Constant is short)
			{
				if ((short)fieldDefinition.Constant == num2)
				{
					return fieldDefinition.Name;
				}
				continue;
			}
			if (fieldDefinition.Constant is long)
			{
				if ((long)fieldDefinition.Constant == num)
				{
					return fieldDefinition.Name;
				}
				continue;
			}
			if (fieldDefinition.Constant is byte)
			{
				if ((byte)fieldDefinition.Constant == num2)
				{
					return fieldDefinition.Name;
				}
				continue;
			}
			if (fieldDefinition.Constant is uint)
			{
				if ((uint)fieldDefinition.Constant == (uint)num2)
				{
					return fieldDefinition.Name;
				}
				continue;
			}
			if (fieldDefinition.Constant is ushort)
			{
				if ((ushort)fieldDefinition.Constant == num2)
				{
					return fieldDefinition.Name;
				}
				continue;
			}
			if (fieldDefinition.Constant is sbyte)
			{
				if ((sbyte)fieldDefinition.Constant == num2)
				{
					return fieldDefinition.Name;
				}
				continue;
			}
			throw new NotImplementedException();
		}
		if (!flag)
		{
			return num2.ToString();
		}
		return num.ToString();
	}
}
