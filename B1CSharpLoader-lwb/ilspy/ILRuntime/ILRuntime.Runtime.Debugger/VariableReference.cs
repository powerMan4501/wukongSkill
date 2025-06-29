using System;

namespace ILRuntime.Runtime.Debugger;

public class VariableReference
{
	public static VariableReference Null = new VariableReference
	{
		Type = VariableTypes.Null,
		Name = "null"
	};

	public static VariableReference True = new VariableReference
	{
		Type = VariableTypes.Boolean,
		Name = "true",
		Offset = 1
	};

	public static VariableReference False = new VariableReference
	{
		Type = VariableTypes.Boolean,
		Name = "false",
		Offset = 0
	};

	public long Address { get; set; }

	public VariableTypes Type { get; set; }

	public int Offset { get; set; }

	public string Name { get; set; }

	public VariableReference Parent { get; set; }

	public VariableReference[] Parameters { get; set; }

	public Type ValueType { get; set; }

	public object Value { get; set; }

	public bool Conditional { get; set; }

	public string FullName
	{
		get
		{
			if (Parent != null)
			{
				switch (Type)
				{
				case VariableTypes.FieldReference:
				case VariableTypes.PropertyReference:
					return $"{Parent.FullName}.{Name}";
				case VariableTypes.IndexAccess:
					return $"{Parent.FullName}[{Parameters[0].FullName}]";
				case VariableTypes.Error:
					return Name;
				default:
					throw new NotImplementedException();
				}
			}
			return Type switch
			{
				VariableTypes.String => $"\"{Name}\"", 
				VariableTypes.Integer => Offset.ToString(), 
				VariableTypes.Boolean => (Offset == 1).ToString(), 
				_ => Name, 
			};
		}
	}

	public static VariableReference GetInteger(int val)
	{
		return new VariableReference
		{
			Type = VariableTypes.Integer,
			Name = "",
			Offset = val
		};
	}

	public static VariableReference GetString(string val)
	{
		return new VariableReference
		{
			Type = VariableTypes.String,
			Name = val
		};
	}

	public static VariableReference GetMember(string name, VariableReference parent)
	{
		return new VariableReference
		{
			Type = VariableTypes.FieldReference,
			Name = name,
			Parent = parent
		};
	}
}
