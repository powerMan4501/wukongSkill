using System;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;

namespace ILRuntime.Runtime.Debugger;

public class VariableInfo
{
	public static VariableInfo NullReferenceExeption = new VariableInfo
	{
		Type = VariableTypes.Error,
		Name = "",
		TypeName = "",
		Value = "NullReferenceException"
	};

	public static VariableInfo RequestTimeout = new VariableInfo
	{
		Type = VariableTypes.Timeout,
		Name = "",
		TypeName = "",
		Value = "RequestTimeoutException"
	};

	public static VariableInfo Null = new VariableInfo
	{
		Type = VariableTypes.Null,
		Name = "",
		TypeName = "",
		Value = "null",
		ValueType = ValueTypes.Null
	};

	public static VariableInfo True = new VariableInfo
	{
		Type = VariableTypes.Boolean,
		Name = "",
		TypeName = "System.Boolean",
		Value = "true",
		ValueType = ValueTypes.Boolean,
		ValueObjType = typeof(bool)
	};

	public static VariableInfo False = new VariableInfo
	{
		Type = VariableTypes.Boolean,
		Name = "",
		TypeName = "System.Boolean",
		Value = "false",
		ValueType = ValueTypes.Boolean,
		ValueObjType = typeof(bool)
	};

	public long Address { get; set; }

	public VariableTypes Type { get; set; }

	public string Name { get; set; }

	public string TypeName { get; set; }

	public string Value { get; set; }

	public ValueTypes ValueType { get; set; }

	public bool Expandable { get; set; }

	public bool IsPrivate { get; set; }

	public bool IsProtected { get; set; }

	public int Offset { get; set; }

	public Type ValueObjType { get; set; }

	public static VariableInfo FromObject(object obj, bool retriveType = false)
	{
		VariableInfo variableInfo = new VariableInfo();
		variableInfo.Name = "";
		if (obj != null)
		{
			variableInfo.Value = obj.ToString();
			if (obj is int)
			{
				variableInfo.ValueType = ValueTypes.Integer;
			}
			else if (obj is bool)
			{
				variableInfo.ValueType = ValueTypes.Boolean;
				variableInfo.Value = variableInfo.Value.ToLower();
			}
			else if (obj is string)
			{
				variableInfo.ValueType = ValueTypes.String;
			}
			if (retriveType)
			{
				if (obj is ILTypeInstance)
				{
					variableInfo.TypeName = ((ILTypeInstance)obj).Type.FullName;
				}
				else if (obj is CrossBindingAdaptorType)
				{
					variableInfo.TypeName = ((CrossBindingAdaptorType)obj).ILInstance.Type.FullName;
				}
				else
				{
					variableInfo.TypeName = obj.GetType().FullName;
				}
			}
			variableInfo.Expandable = !obj.GetType().IsPrimitive && !(obj is string);
		}
		else
		{
			variableInfo.Value = "null";
			variableInfo.ValueType = ValueTypes.Null;
		}
		return variableInfo;
	}

	public static VariableInfo NullReferenceExeptionWithName(string name)
	{
		return new VariableInfo
		{
			Type = VariableTypes.Error,
			Name = "",
			TypeName = "",
			Value = name + " is Null"
		};
	}

	public static VariableInfo GetCannotFind(string name)
	{
		return new VariableInfo
		{
			Type = VariableTypes.NotFound,
			TypeName = "",
			Name = name,
			Value = $"Cannot find \"{name}\" in current scope."
		};
	}

	public static VariableInfo GetInteger(int val)
	{
		return new VariableInfo
		{
			Type = VariableTypes.Integer,
			Value = val.ToString(),
			TypeName = "System.Int32",
			Name = "",
			ValueType = ValueTypes.Integer,
			ValueObjType = typeof(int)
		};
	}

	public static VariableInfo GetString(string val)
	{
		return new VariableInfo
		{
			Type = VariableTypes.String,
			Value = val,
			TypeName = "System.String",
			Name = "",
			ValueType = ValueTypes.String,
			ValueObjType = typeof(string)
		};
	}

	public static VariableInfo GetException(Exception ex)
	{
		return new VariableInfo
		{
			Type = VariableTypes.Error,
			Value = ex.ToString(),
			TypeName = ex.GetType().FullName,
			Name = "",
			ValueType = ValueTypes.String
		};
	}

	public static VariableInfo GetError(string errorText)
	{
		return new VariableInfo
		{
			Type = VariableTypes.Error,
			Value = errorText,
			TypeName = "",
			Name = "",
			ValueType = ValueTypes.String
		};
	}
}
