namespace ILRuntime.Runtime.Debugger;

public enum VariableTypes
{
	Normal,
	FieldReference,
	PropertyReference,
	TypeReference,
	IndexAccess,
	Invocation,
	Integer,
	Boolean,
	String,
	Value,
	Class,
	Null,
	Error,
	NotFound,
	Timeout,
	Pending
}
