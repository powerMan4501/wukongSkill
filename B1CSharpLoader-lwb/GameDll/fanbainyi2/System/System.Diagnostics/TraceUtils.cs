using System.Collections;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Reflection;

namespace System.Diagnostics;

internal static class TraceUtils
{
	internal static object GetRuntimeObject(string className, Type baseType, string initializeData)
	{
		object obj = null;
		Type type = null;
		if (className.Length == 0)
		{
			throw new ConfigurationErrorsException(SR.GetString("EmptyTypeName_NotAllowed"));
		}
		type = Type.GetType(className);
		if (type == null)
		{
			throw new ConfigurationErrorsException(SR.GetString("Could_not_find_type", className));
		}
		if (!baseType.IsAssignableFrom(type))
		{
			throw new ConfigurationErrorsException(SR.GetString("Incorrect_base_type", className, baseType.FullName));
		}
		Exception ex = null;
		try
		{
			if (string.IsNullOrEmpty(initializeData))
			{
				if (IsOwnedTL(type))
				{
					throw new ConfigurationErrorsException(SR.GetString("TL_InitializeData_NotSpecified"));
				}
				ConstructorInfo constructor = type.GetConstructor(new Type[0]);
				if (constructor == null)
				{
					throw new ConfigurationErrorsException(SR.GetString("Could_not_get_constructor", className));
				}
				obj = SecurityUtils.ConstructorInfoInvoke(constructor, new object[0]);
			}
			else
			{
				ConstructorInfo constructor2 = type.GetConstructor(new Type[1] { typeof(string) });
				if (constructor2 != null)
				{
					if (IsOwnedTextWriterTL(type) && initializeData[0] != Path.DirectorySeparatorChar && initializeData[0] != Path.AltDirectorySeparatorChar && !Path.IsPathRooted(initializeData))
					{
						string configFilePath = DiagnosticsConfiguration.ConfigFilePath;
						if (!string.IsNullOrEmpty(configFilePath))
						{
							string directoryName = Path.GetDirectoryName(configFilePath);
							if (directoryName != null)
							{
								initializeData = Path.Combine(directoryName, initializeData);
							}
						}
					}
					obj = SecurityUtils.ConstructorInfoInvoke(constructor2, new object[1] { initializeData });
				}
				else
				{
					ConstructorInfo[] constructors = type.GetConstructors();
					if (constructors == null)
					{
						throw new ConfigurationErrorsException(SR.GetString("Could_not_get_constructor", className));
					}
					for (int i = 0; i < constructors.Length; i++)
					{
						ParameterInfo[] parameters = constructors[i].GetParameters();
						if (parameters.Length == 1)
						{
							Type parameterType = parameters[0].ParameterType;
							try
							{
								object obj2 = ConvertToBaseTypeOrEnum(initializeData, parameterType);
								obj = SecurityUtils.ConstructorInfoInvoke(constructors[i], new object[1] { obj2 });
							}
							catch (TargetInvocationException ex2)
							{
								ex = ex2.InnerException;
								continue;
							}
							catch (Exception ex3)
							{
								ex = ex3;
								continue;
							}
							break;
						}
					}
				}
			}
		}
		catch (TargetInvocationException ex4)
		{
			ex = ex4.InnerException;
		}
		if (obj == null)
		{
			if (ex != null)
			{
				throw new ConfigurationErrorsException(SR.GetString("Could_not_create_type_instance", className), ex);
			}
			throw new ConfigurationErrorsException(SR.GetString("Could_not_create_type_instance", className));
		}
		return obj;
	}

	internal static bool IsOwnedTL(Type type)
	{
		if (!(typeof(EventLogTraceListener) == type))
		{
			return IsOwnedTextWriterTL(type);
		}
		return true;
	}

	internal static bool IsOwnedTextWriterTL(Type type)
	{
		if (!(typeof(XmlWriterTraceListener) == type) && !(typeof(DelimitedListTraceListener) == type))
		{
			return typeof(TextWriterTraceListener) == type;
		}
		return true;
	}

	private static object ConvertToBaseTypeOrEnum(string value, Type type)
	{
		if (type.IsEnum)
		{
			return Enum.Parse(type, value, ignoreCase: false);
		}
		return Convert.ChangeType(value, type, CultureInfo.InvariantCulture);
	}

	internal static void VerifyAttributes(IDictionary attributes, string[] supportedAttributes, object parent)
	{
		foreach (string key in attributes.Keys)
		{
			bool flag = false;
			if (supportedAttributes != null)
			{
				for (int i = 0; i < supportedAttributes.Length; i++)
				{
					if (supportedAttributes[i] == key)
					{
						flag = true;
					}
				}
			}
			if (!flag)
			{
				throw new ConfigurationErrorsException(SR.GetString("AttributeNotSupported", key, parent.GetType().FullName));
			}
		}
	}
}
