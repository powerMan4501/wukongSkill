using System;
using System.Collections.Generic;
using System.Reflection;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.Mono.Cecil;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;

namespace ILRuntime.Reflection;

internal static class Extensions
{
	public static object CreateInstance(this CustomAttribute attribute, IType at, ILRuntime.Runtime.Enviorment.AppDomain appdomain)
	{
		List<IType> list = null;
		object obj;
		if (at is ILType)
		{
			ILType iLType = (ILType)at;
			if (!attribute.HasConstructorArguments)
			{
				obj = iLType.Instantiate();
			}
			else
			{
				obj = iLType.Instantiate(callDefaultConstructor: false);
				if (list == null)
				{
					list = new List<IType>();
				}
				list.Clear();
				object[] array = new object[attribute.ConstructorArguments.Count];
				for (int i = 0; i < attribute.ConstructorArguments.Count; i++)
				{
					CustomAttributeArgument customAttributeArgument = attribute.ConstructorArguments[i];
					list.Add(appdomain.GetType(customAttributeArgument.Type, null, null));
					array[i] = customAttributeArgument.Value;
				}
				IMethod constructor = iLType.GetConstructor(list);
				appdomain.Invoke(constructor, obj, array);
			}
			if (attribute.HasProperties)
			{
				object[] array2 = new object[1];
				foreach (ILRuntime.Mono.Cecil.CustomAttributeNamedArgument property2 in attribute.Properties)
				{
					array2[0] = property2.Argument.Value;
					IMethod method = iLType.GetMethod("set_" + property2.Name, 1);
					appdomain.Invoke(method, obj, array2);
				}
			}
			if (attribute.HasFields)
			{
				foreach (ILRuntime.Mono.Cecil.CustomAttributeNamedArgument field in attribute.Fields)
				{
					if (iLType.GetField(field.Name, out var fieldIdx) != null)
					{
						((ILTypeInstance)obj)[fieldIdx] = field.Argument.Value;
					}
				}
			}
			obj = ((ILTypeInstance)obj).CLRInstance;
		}
		else
		{
			list = new List<IType>();
			object[] array3 = null;
			if (attribute.HasConstructorArguments)
			{
				array3 = new object[attribute.ConstructorArguments.Count];
				for (int j = 0; j < attribute.ConstructorArguments.Count; j++)
				{
					CustomAttributeArgument customAttributeArgument2 = attribute.ConstructorArguments[j];
					list.Add(appdomain.GetType(customAttributeArgument2.Type, null, null));
					array3[j] = customAttributeArgument2.Value;
				}
			}
			obj = ((CLRMethod)at.GetConstructor(list)).ConstructorInfo.Invoke(array3);
			if (attribute.HasProperties)
			{
				foreach (ILRuntime.Mono.Cecil.CustomAttributeNamedArgument property3 in attribute.Properties)
				{
					PropertyInfo property = at.TypeForCLR.GetProperty(property3.Name);
					if (property.PropertyType == typeof(Type) && property3.Argument.Value != null)
					{
						IType type = appdomain.GetType(property3.Argument.Value, null, null);
						property.SetValue(obj, type.TypeForCLR, null);
					}
					else
					{
						property.SetValue(obj, property3.Argument.Value, null);
					}
				}
			}
			if (attribute.HasFields)
			{
				foreach (ILRuntime.Mono.Cecil.CustomAttributeNamedArgument field2 in attribute.Fields)
				{
					at.TypeForCLR.GetField(field2.Name).SetValue(obj, field2.Argument.Value);
				}
			}
		}
		return obj;
	}
}
