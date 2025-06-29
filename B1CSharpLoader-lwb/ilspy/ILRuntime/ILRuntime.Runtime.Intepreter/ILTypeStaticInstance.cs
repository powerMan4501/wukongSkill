using ILRuntime.CLR.TypeSystem;
using ILRuntime.Mono.Cecil;
using ILRuntime.Other;
using ILRuntime.Runtime.Stack;

namespace ILRuntime.Runtime.Intepreter;

public class ILTypeStaticInstance : ILTypeInstance
{
	public ILTypeStaticInstance(ILType type)
	{
		base.type = type;
		fields = new StackObject[type.StaticFieldTypes.Length];
		managedObjs = new UncheckedList<object>(fields.Length);
		for (int i = 0; i < fields.Length; i++)
		{
			IType fieldType = type.StaticFieldTypes[i];
			managedObjs.Add(null);
			StackObject.Initialized(ref fields[i], i, fieldType, managedObjs);
		}
		int num = 0;
		foreach (FieldDefinition field in type.TypeDefinition.Fields)
		{
			if (field.IsStatic)
			{
				if (field.InitialValue != null && field.InitialValue.Length != 0)
				{
					fields[num].ObjectType = ObjectTypes.Object;
					fields[num].Value = num;
					managedObjs[num] = field.InitialValue;
				}
				num++;
			}
		}
	}
}
