using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public static class FParse
{
	public static bool Command(ref string str, string match, bool parseMightTriggerExecution = true)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(str);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(match);
		using FStringUnsafe fStringUnsafe3 = new FStringUnsafe();
		bool result = Native_FParse.Command(ref fStringUnsafe.Array, ref fStringUnsafe2.Array, parseMightTriggerExecution, ref fStringUnsafe3.Array);
		str = fStringUnsafe3.Value;
		return result;
	}

	public static bool Value(string str, string match, ref FName value)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(str);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(match);
		return Native_FParse.Value_Name(ref fStringUnsafe.Array, ref fStringUnsafe2.Array, ref value);
	}

	public static bool Value(string str, string match, ref uint value)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(str);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(match);
		return Native_FParse.Value_UInt32(ref fStringUnsafe.Array, ref fStringUnsafe2.Array, ref value);
	}

	public static bool Value(string str, string match, ref Guid value)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(str);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(match);
		return Native_FParse.Value_Guid(ref fStringUnsafe.Array, ref fStringUnsafe2.Array, ref value);
	}

	public static bool Value(string str, string match, ref byte value)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(str);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(match);
		return Native_FParse.Value_Byte(ref fStringUnsafe.Array, ref fStringUnsafe2.Array, ref value);
	}

	public static bool Value(string str, string match, ref sbyte value)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(str);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(match);
		return Native_FParse.Value_SByte(ref fStringUnsafe.Array, ref fStringUnsafe2.Array, ref value);
	}

	public static bool Value(string str, string match, ref ushort value)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(str);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(match);
		return Native_FParse.Value_UInt16(ref fStringUnsafe.Array, ref fStringUnsafe2.Array, ref value);
	}

	public static bool Value(string str, string match, ref short value)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(str);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(match);
		return Native_FParse.Value_Int16(ref fStringUnsafe.Array, ref fStringUnsafe2.Array, ref value);
	}

	public static bool Value(string str, string match, ref float value)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(str);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(match);
		return Native_FParse.Value_Float(ref fStringUnsafe.Array, ref fStringUnsafe2.Array, ref value);
	}

	public static bool Value(string str, string match, ref double value)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(str);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(match);
		return Native_FParse.Value_Double(ref fStringUnsafe.Array, ref fStringUnsafe2.Array, ref value);
	}

	public static bool Value(string str, string match, ref int value)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(str);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(match);
		return Native_FParse.Value_Int32(ref fStringUnsafe.Array, ref fStringUnsafe2.Array, ref value);
	}

	public static bool Value(string str, string match, out string value, bool shouldStopOnSeparator = true)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(str);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(match);
		using FStringUnsafe fStringUnsafe3 = new FStringUnsafe();
		bool result = Native_FParse.Value_Str(ref fStringUnsafe.Array, ref fStringUnsafe2.Array, ref fStringUnsafe3.Array, shouldStopOnSeparator);
		value = fStringUnsafe3.Value;
		return result;
	}

	public static bool Value(string str, string match, ref ulong value)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(str);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(match);
		return Native_FParse.Value_UInt64(ref fStringUnsafe.Array, ref fStringUnsafe2.Array, ref value);
	}

	public static bool Value(string str, string match, ref long value)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(str);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(match);
		return Native_FParse.Value_Int64(ref fStringUnsafe.Array, ref fStringUnsafe2.Array, ref value);
	}

	public static bool Value(string str, string match, ref bool value)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(str);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(match);
		csbool value2 = false;
		bool result = Native_FParse.Bool(ref fStringUnsafe.Array, ref fStringUnsafe2.Array, ref value2);
		value = value2;
		return result;
	}

	public static bool Line(ref string str, out string result, bool exact = false)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(str);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
		using FStringUnsafe fStringUnsafe3 = new FStringUnsafe();
		bool result2 = Native_FParse.Line(ref fStringUnsafe.Array, ref fStringUnsafe3.Array, exact, ref fStringUnsafe2.Array);
		str = fStringUnsafe2.Value;
		result = fStringUnsafe3.Value;
		return result2;
	}

	public static bool LineExtended(ref string str, out string result, out int linesConsumed, bool exact = false)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(str);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
		using FStringUnsafe fStringUnsafe3 = new FStringUnsafe();
		bool result2 = Native_FParse.LineExtended(ref fStringUnsafe.Array, ref fStringUnsafe3.Array, out linesConsumed, exact, ref fStringUnsafe2.Array);
		str = fStringUnsafe2.Value;
		result = fStringUnsafe3.Value;
		return result2;
	}

	public static bool Token(ref string str, out string arg, bool useEscape)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(str);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
		using FStringUnsafe fStringUnsafe3 = new FStringUnsafe();
		bool result = Native_FParse.Token(ref fStringUnsafe.Array, ref fStringUnsafe3.Array, useEscape, ref fStringUnsafe2.Array);
		str = fStringUnsafe2.Value;
		arg = fStringUnsafe3.Value;
		return result;
	}

	public static bool AlnumToken(ref string str, out string arg)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(str);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
		using FStringUnsafe fStringUnsafe3 = new FStringUnsafe();
		bool result = Native_FParse.AlnumToken(ref fStringUnsafe.Array, ref fStringUnsafe3.Array, ref fStringUnsafe2.Array);
		str = fStringUnsafe2.Value;
		arg = fStringUnsafe3.Value;
		return result;
	}

	public static string Token(ref string str, bool useEscape)
	{
		Token(ref str, out var arg, useEscape);
		return arg;
	}

	public static void Next(ref string str)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(str);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
		Native_FParse.Next(ref fStringUnsafe.Array, ref fStringUnsafe2.Array);
		str = fStringUnsafe2.Value;
	}

	public static bool Param(string str, string param)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(str);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(param);
		return Native_FParse.Param(ref fStringUnsafe.Array, ref fStringUnsafe2.Array);
	}

	public static bool QuotedString(string str, out string value, out int numCharsRead)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(str);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe();
		csbool obj = Native_FParse.QuotedString(ref fStringUnsafe.Array, ref fStringUnsafe2.Array, out numCharsRead);
		value = fStringUnsafe2.Value;
		return obj;
	}

	public static byte HexDigit(char c)
	{
		int num = 0;
		num = ((c >= '0' && c <= '9') ? (c - 48) : ((c >= 'a' && c <= 'f') ? (c + 10 - 97) : ((c >= 'A' && c <= 'F') ? (c + 10 - 65) : 0)));
		return (byte)num;
	}

	public static uint HexNumber(string hexString)
	{
		uint num = 0u;
		for (int i = 0; i < hexString.Length; i++)
		{
			num *= 16;
			num += HexDigit(hexString[i]);
		}
		return num;
	}

	public static ulong HexNumber64(string hexString)
	{
		ulong num = 0uL;
		for (int i = 0; i < hexString.Length; i++)
		{
			num *= 16;
			num += HexDigit(hexString[i]);
		}
		return num;
	}
}
