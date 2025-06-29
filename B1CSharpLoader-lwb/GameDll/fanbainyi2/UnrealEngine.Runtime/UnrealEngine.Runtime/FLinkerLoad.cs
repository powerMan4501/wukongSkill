using System.Linq;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public class FLinkerLoad
{
	public static FName[] FindPreviousNamesForClass(string currentClassPath, bool isInstance)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(currentClassPath);
		using TArrayUnsafe<FName> tArrayUnsafe = new TArrayUnsafe<FName>();
		Native_FLinkerLoad.FindPreviousNamesForClass(ref fStringUnsafe.Array, isInstance, tArrayUnsafe.Address);
		return tArrayUnsafe.ToArray();
	}

	public static FName FindNewNameForClass(FName oldClassName, bool isInstance)
	{
		Native_FLinkerLoad.FindNewNameForClass(ref oldClassName, isInstance, out var result);
		return result;
	}

	public static FName FindNewNameForEnum(FName oldEnumName)
	{
		Native_FLinkerLoad.FindNewNameForEnum(ref oldEnumName, out var result);
		return result;
	}

	public static FName FindNewNameForStruct(FName oldStructName)
	{
		Native_FLinkerLoad.FindNewNameForStruct(ref oldStructName, out var result);
		return result;
	}
}
