using System;
using System.Reflection;
using System.Text;

namespace ILRuntime.Runtime.CLRBinding;

internal static class CommonBindingGenerator
{
	internal static string GenerateMiscRegisterCode(this Type type, string typeClsName, bool defaultCtor, bool newArr)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (defaultCtor && !type.IsPrimitive && !type.IsAbstract)
		{
			BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public;
			if (type.GetConstructor(bindingAttr, null, new Type[0], null) != null || type.IsValueType)
			{
				stringBuilder.AppendLine($"            app.RegisterCLRCreateDefaultInstance(type, () => new {typeClsName}());");
			}
		}
		if (newArr && (!type.IsAbstract || !type.IsSealed))
		{
			if (type.IsArray)
			{
				Type type2 = type;
				int num = 0;
				while (type2.IsArray)
				{
					type2 = type2.GetElementType();
					num++;
				}
				type2.GetClassName(out var _, out var realClsName, out var _);
				string text = "";
				for (int i = 0; i < num; i++)
				{
					text += "[]";
				}
				stringBuilder.AppendLine($"            app.RegisterCLRCreateArrayInstance(type, s => new {realClsName}[s]{text});");
			}
			else
			{
				stringBuilder.AppendLine($"            app.RegisterCLRCreateArrayInstance(type, s => new {typeClsName}[s]);");
			}
		}
		return stringBuilder.ToString();
	}

	internal static string GenerateCommonCode(this Type type, string typeClsName)
	{
		if (!type.IsValueType)
		{
			return "";
		}
		StringBuilder stringBuilder = new StringBuilder();
		if (type.IsPrimitive)
		{
			stringBuilder.AppendLine($"        static {typeClsName} GetInstance(ILRuntime.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack)");
			stringBuilder.AppendLine("        {");
			if (type.IsPrimitive || type.IsValueType)
			{
				stringBuilder.AppendLine("            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);");
			}
			stringBuilder.AppendLine($"            {typeClsName} instance_of_this_method;");
			stringBuilder.Append("            switch(ptr_of_this_method->ObjectType)\r\n            {\r\n                case ObjectTypes.FieldReference:\r\n                    {\r\n                        var instance_of_fieldReference = __mStack[ptr_of_this_method->Value];\r\n                        if(instance_of_fieldReference is ILTypeInstance)\r\n                        {\r\n                            instance_of_this_method = (");
			stringBuilder.Append(typeClsName);
			stringBuilder.Append(")typeof(");
			stringBuilder.Append(typeClsName);
			stringBuilder.Append(").CheckCLRTypes(((ILTypeInstance)instance_of_fieldReference)[ptr_of_this_method->ValueLow])");
			stringBuilder.Append(";");
			stringBuilder.Append("\r\n                        }\r\n                        else\r\n                        {\r\n                            var t = __domain.GetType(instance_of_fieldReference.GetType()) as CLRType;\r\n                            instance_of_this_method = (");
			stringBuilder.Append(typeClsName);
			stringBuilder.Append(")t.GetFieldValue(ptr_of_this_method->ValueLow, instance_of_fieldReference);");
			stringBuilder.Append("\r\n                        }\r\n                    }\r\n                    break;\r\n                case ObjectTypes.StaticFieldReference:\r\n                    {\r\n                        var t = __domain.GetType(ptr_of_this_method->Value);\r\n                        if(t is ILType)\r\n                        {\r\n                            instance_of_this_method = (");
			stringBuilder.Append(typeClsName);
			stringBuilder.Append(")typeof(");
			stringBuilder.Append(typeClsName);
			stringBuilder.Append(").CheckCLRTypes(((ILType)t).StaticInstance[ptr_of_this_method->ValueLow])");
			stringBuilder.Append(";");
			stringBuilder.Append("\r\n                        }\r\n                        else\r\n                        {\r\n                            instance_of_this_method = (");
			stringBuilder.Append(typeClsName);
			stringBuilder.Append(")((CLRType)t).GetFieldValue(ptr_of_this_method->ValueLow, null);\r\n                        }\r\n                    }\r\n                    break;\r\n                case ObjectTypes.ArrayReference:\r\n                    {\r\n                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as ");
			stringBuilder.Append(typeClsName);
			stringBuilder.AppendLine("[];\r\n                        instance_of_this_method = instance_of_arrayReference[ptr_of_this_method->ValueLow];                        \r\n                    }\r\n                    break;\r\n                default:");
			stringBuilder.AppendLine($"                    instance_of_this_method = {type.GetRetrieveValueCode(typeClsName)};");
			stringBuilder.AppendLine("                    break;\r\n            }\r\n            return instance_of_this_method;");
			stringBuilder.AppendLine("        }");
		}
		if (!type.IsPrimitive && !type.IsAbstract)
		{
			stringBuilder.AppendLine($"        static void WriteBackInstance(ILRuntime.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref {typeClsName} instance_of_this_method)");
			stringBuilder.AppendLine("        {");
			stringBuilder.AppendLine("            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);\r\n            switch(ptr_of_this_method->ObjectType)\r\n            {\r\n                case ObjectTypes.Object:\r\n                    {\r\n                        __mStack[ptr_of_this_method->Value] = instance_of_this_method;");
			stringBuilder.Append("                    }\r\n                    break;\r\n                case ObjectTypes.FieldReference:\r\n                    {\r\n                        var ___obj = __mStack[ptr_of_this_method->Value];\r\n                        if(___obj is ILTypeInstance)\r\n                        {\r\n                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = instance_of_this_method");
			stringBuilder.Append(";\r\n                        }\r\n                        else\r\n                        {\r\n                            var t = __domain.GetType(___obj.GetType()) as CLRType;\r\n                            t.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, instance_of_this_method");
			stringBuilder.Append(");\r\n                        }\r\n                    }\r\n                    break;\r\n                case ObjectTypes.StaticFieldReference:\r\n                    {\r\n                        var t = __domain.GetType(ptr_of_this_method->Value);\r\n                        if(t is ILType)\r\n                        {\r\n                            ((ILType)t).StaticInstance[ptr_of_this_method->ValueLow] = instance_of_this_method");
			stringBuilder.Append(";\r\n                        }\r\n                        else\r\n                        {\r\n                            ((CLRType)t).SetStaticFieldValue(ptr_of_this_method->ValueLow, instance_of_this_method");
			stringBuilder.Append(");\r\n                        }\r\n                    }\r\n                    break;\r\n                 case ObjectTypes.ArrayReference:\r\n                    {\r\n                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as ");
			stringBuilder.Append(typeClsName);
			stringBuilder.AppendLine("[];\r\n                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;\r\n                    }\r\n                    break;\r\n            }");
			stringBuilder.AppendLine("        }");
		}
		return stringBuilder.ToString();
	}
}
