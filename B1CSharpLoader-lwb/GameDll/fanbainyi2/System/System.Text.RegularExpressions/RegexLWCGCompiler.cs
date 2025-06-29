using System.Globalization;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;

namespace System.Text.RegularExpressions;

internal class RegexLWCGCompiler : RegexCompiler
{
	private static int _regexCount = 0;

	private static Type[] _paramTypes = new Type[1] { typeof(RegexRunner) };

	internal RegexLWCGCompiler()
	{
	}

	internal RegexRunnerFactory FactoryInstanceFromCode(RegexCode code, RegexOptions options)
	{
		_code = code;
		_codes = code._codes;
		_strings = code._strings;
		_fcPrefix = code._fcPrefix;
		_bmPrefix = code._bmPrefix;
		_anchors = code._anchors;
		_trackcount = code._trackcount;
		_options = options;
		string text = Interlocked.Increment(ref _regexCount).ToString(CultureInfo.InvariantCulture);
		DynamicMethod go = DefineDynamicMethod("Go" + text, null, typeof(CompiledRegexRunner));
		GenerateGo();
		DynamicMethod firstChar = DefineDynamicMethod("FindFirstChar" + text, typeof(bool), typeof(CompiledRegexRunner));
		GenerateFindFirstChar();
		DynamicMethod trackCount = DefineDynamicMethod("InitTrackCount" + text, null, typeof(CompiledRegexRunner));
		GenerateInitTrackCount();
		return new CompiledRegexRunnerFactory(go, firstChar, trackCount);
	}

	internal DynamicMethod DefineDynamicMethod(string methname, Type returntype, Type hostType)
	{
		MethodAttributes attributes = MethodAttributes.Public | MethodAttributes.Static;
		CallingConventions callingConvention = CallingConventions.Standard;
		DynamicMethod dynamicMethod = new DynamicMethod(methname, attributes, callingConvention, returntype, _paramTypes, hostType, skipVisibility: false);
		_ilg = dynamicMethod.GetILGenerator();
		return dynamicMethod;
	}
}
