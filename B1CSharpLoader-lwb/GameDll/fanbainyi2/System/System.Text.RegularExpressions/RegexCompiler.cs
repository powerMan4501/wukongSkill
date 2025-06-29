using System.Globalization;
using System.Reflection;
using System.Reflection.Emit;
using System.Security;
using System.Security.Permissions;

namespace System.Text.RegularExpressions;

internal abstract class RegexCompiler
{
	internal sealed class BacktrackNote
	{
		internal int _codepos;

		internal int _flags;

		internal Label _label;

		internal BacktrackNote(int flags, Label label, int codepos)
		{
			_codepos = codepos;
			_flags = flags;
			_label = label;
		}
	}

	internal static FieldInfo _textbegF;

	internal static FieldInfo _textendF;

	internal static FieldInfo _textstartF;

	internal static FieldInfo _textposF;

	internal static FieldInfo _textF;

	internal static FieldInfo _trackposF;

	internal static FieldInfo _trackF;

	internal static FieldInfo _stackposF;

	internal static FieldInfo _stackF;

	internal static FieldInfo _trackcountF;

	internal static MethodInfo _ensurestorageM;

	internal static MethodInfo _captureM;

	internal static MethodInfo _transferM;

	internal static MethodInfo _uncaptureM;

	internal static MethodInfo _ismatchedM;

	internal static MethodInfo _matchlengthM;

	internal static MethodInfo _matchindexM;

	internal static MethodInfo _isboundaryM;

	internal static MethodInfo _isECMABoundaryM;

	internal static MethodInfo _chartolowerM;

	internal static MethodInfo _getcharM;

	internal static MethodInfo _crawlposM;

	internal static MethodInfo _charInSetM;

	internal static MethodInfo _getCurrentCulture;

	internal static MethodInfo _getInvariantCulture;

	internal static MethodInfo _checkTimeoutM;

	internal ILGenerator _ilg;

	internal LocalBuilder _textstartV;

	internal LocalBuilder _textbegV;

	internal LocalBuilder _textendV;

	internal LocalBuilder _textposV;

	internal LocalBuilder _textV;

	internal LocalBuilder _trackposV;

	internal LocalBuilder _trackV;

	internal LocalBuilder _stackposV;

	internal LocalBuilder _stackV;

	internal LocalBuilder _tempV;

	internal LocalBuilder _temp2V;

	internal LocalBuilder _temp3V;

	internal LocalBuilder _loopV;

	internal RegexCode _code;

	internal int[] _codes;

	internal string[] _strings;

	internal RegexPrefix _fcPrefix;

	internal RegexBoyerMoore _bmPrefix;

	internal int _anchors;

	internal Label[] _labels;

	internal BacktrackNote[] _notes;

	internal int _notecount;

	internal int _trackcount;

	internal Label _backtrack;

	internal int _regexopcode;

	internal int _codepos;

	internal int _backpos;

	internal RegexOptions _options;

	internal int[] _uniquenote;

	internal int[] _goto;

	internal const int stackpop = 0;

	internal const int stackpop2 = 1;

	internal const int stackpop3 = 2;

	internal const int capback = 3;

	internal const int capback2 = 4;

	internal const int branchmarkback2 = 5;

	internal const int lazybranchmarkback2 = 6;

	internal const int branchcountback2 = 7;

	internal const int lazybranchcountback2 = 8;

	internal const int forejumpback = 9;

	internal const int uniquecount = 10;

	private const int LoopTimeoutCheckCount = 2000;

	private static readonly bool UseLegacyTimeoutCheck;

	static RegexCompiler()
	{
		UseLegacyTimeoutCheck = System.LocalAppContextSwitches.UseLegacyTimeoutCheck;
		new ReflectionPermission(PermissionState.Unrestricted).Assert();
		try
		{
			_textbegF = RegexRunnerField("runtextbeg");
			_textendF = RegexRunnerField("runtextend");
			_textstartF = RegexRunnerField("runtextstart");
			_textposF = RegexRunnerField("runtextpos");
			_textF = RegexRunnerField("runtext");
			_trackposF = RegexRunnerField("runtrackpos");
			_trackF = RegexRunnerField("runtrack");
			_stackposF = RegexRunnerField("runstackpos");
			_stackF = RegexRunnerField("runstack");
			_trackcountF = RegexRunnerField("runtrackcount");
			_ensurestorageM = RegexRunnerMethod("EnsureStorage");
			_captureM = RegexRunnerMethod("Capture");
			_transferM = RegexRunnerMethod("TransferCapture");
			_uncaptureM = RegexRunnerMethod("Uncapture");
			_ismatchedM = RegexRunnerMethod("IsMatched");
			_matchlengthM = RegexRunnerMethod("MatchLength");
			_matchindexM = RegexRunnerMethod("MatchIndex");
			_isboundaryM = RegexRunnerMethod("IsBoundary");
			_charInSetM = RegexRunnerMethod("CharInClass");
			_isECMABoundaryM = RegexRunnerMethod("IsECMABoundary");
			_crawlposM = RegexRunnerMethod("Crawlpos");
			_checkTimeoutM = RegexRunnerMethod("CheckTimeout");
			_chartolowerM = typeof(char).GetMethod("ToLower", new Type[2]
			{
				typeof(char),
				typeof(CultureInfo)
			});
			_getcharM = typeof(string).GetMethod("get_Chars", new Type[1] { typeof(int) });
			_getCurrentCulture = typeof(CultureInfo).GetMethod("get_CurrentCulture");
			_getInvariantCulture = typeof(CultureInfo).GetMethod("get_InvariantCulture");
		}
		finally
		{
			CodeAccessPermission.RevertAssert();
		}
	}

	private static FieldInfo RegexRunnerField(string fieldname)
	{
		return typeof(RegexRunner).GetField(fieldname, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
	}

	private static MethodInfo RegexRunnerMethod(string methname)
	{
		return typeof(RegexRunner).GetMethod(methname, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
	}

	internal static RegexRunnerFactory Compile(RegexCode code, RegexOptions options)
	{
		RegexLWCGCompiler regexLWCGCompiler = new RegexLWCGCompiler();
		new ReflectionPermission(PermissionState.Unrestricted).Assert();
		try
		{
			return regexLWCGCompiler.FactoryInstanceFromCode(code, options);
		}
		finally
		{
			CodeAccessPermission.RevertAssert();
		}
	}

	internal static void CompileToAssembly(RegexCompilationInfo[] regexes, AssemblyName an, CustomAttributeBuilder[] attribs, string resourceFile)
	{
		RegexTypeCompiler regexTypeCompiler = new RegexTypeCompiler(an, attribs, resourceFile);
		for (int i = 0; i < regexes.Length; i++)
		{
			if (regexes[i] == null)
			{
				throw new ArgumentNullException("regexes", SR.GetString("ArgumentNull_ArrayWithNullElements"));
			}
			string pattern = regexes[i].Pattern;
			RegexOptions options = regexes[i].Options;
			string text = ((regexes[i].Namespace.Length != 0) ? (regexes[i].Namespace + "." + regexes[i].Name) : regexes[i].Name);
			TimeSpan matchTimeout = regexes[i].MatchTimeout;
			RegexTree regexTree = RegexParser.Parse(pattern, options);
			RegexCode code = RegexWriter.Write(regexTree);
			new ReflectionPermission(PermissionState.Unrestricted).Assert();
			try
			{
				Type factory = regexTypeCompiler.FactoryTypeFromCode(code, options, text);
				regexTypeCompiler.GenerateRegexType(pattern, options, text, regexes[i].IsPublic, code, regexTree, factory, matchTimeout);
			}
			finally
			{
				CodeAccessPermission.RevertAssert();
			}
		}
		regexTypeCompiler.Save();
	}

	internal int AddBacktrackNote(int flags, Label l, int codepos)
	{
		if (_notes == null || _notecount >= _notes.Length)
		{
			BacktrackNote[] array = new BacktrackNote[(_notes == null) ? 16 : (_notes.Length * 2)];
			if (_notes != null)
			{
				Array.Copy(_notes, 0, array, 0, _notecount);
			}
			_notes = array;
		}
		_notes[_notecount] = new BacktrackNote(flags, l, codepos);
		return _notecount++;
	}

	internal int AddTrack()
	{
		return AddTrack(128);
	}

	internal int AddTrack(int flags)
	{
		return AddBacktrackNote(flags, DefineLabel(), _codepos);
	}

	internal int AddGoto(int destpos)
	{
		if (_goto[destpos] == -1)
		{
			_goto[destpos] = AddBacktrackNote(0, _labels[destpos], destpos);
		}
		return _goto[destpos];
	}

	internal int AddUniqueTrack(int i)
	{
		return AddUniqueTrack(i, 128);
	}

	internal int AddUniqueTrack(int i, int flags)
	{
		if (_uniquenote[i] == -1)
		{
			_uniquenote[i] = AddTrack(flags);
		}
		return _uniquenote[i];
	}

	internal Label DefineLabel()
	{
		return _ilg.DefineLabel();
	}

	internal void MarkLabel(Label l)
	{
		_ilg.MarkLabel(l);
	}

	internal int Operand(int i)
	{
		return _codes[_codepos + i + 1];
	}

	internal bool IsRtl()
	{
		return (_regexopcode & 0x40) != 0;
	}

	internal bool IsCi()
	{
		return (_regexopcode & 0x200) != 0;
	}

	internal int Code()
	{
		return _regexopcode & 0x3F;
	}

	internal void Ldstr(string str)
	{
		_ilg.Emit(OpCodes.Ldstr, str);
	}

	internal void Ldc(int i)
	{
		if (i <= 127 && i >= -128)
		{
			_ilg.Emit(OpCodes.Ldc_I4_S, (byte)i);
		}
		else
		{
			_ilg.Emit(OpCodes.Ldc_I4, i);
		}
	}

	internal void LdcI8(long i)
	{
		if (i <= int.MaxValue && i >= int.MinValue)
		{
			Ldc((int)i);
			_ilg.Emit(OpCodes.Conv_I8);
		}
		else
		{
			_ilg.Emit(OpCodes.Ldc_I8, i);
		}
	}

	internal void Dup()
	{
		_ilg.Emit(OpCodes.Dup);
	}

	internal void Ret()
	{
		_ilg.Emit(OpCodes.Ret);
	}

	private void Rem()
	{
		_ilg.Emit(OpCodes.Rem);
	}

	private void Ceq()
	{
		_ilg.Emit(OpCodes.Ceq);
	}

	internal void Pop()
	{
		_ilg.Emit(OpCodes.Pop);
	}

	internal void Add()
	{
		_ilg.Emit(OpCodes.Add);
	}

	internal void Add(bool negate)
	{
		if (negate)
		{
			_ilg.Emit(OpCodes.Sub);
		}
		else
		{
			_ilg.Emit(OpCodes.Add);
		}
	}

	internal void Sub()
	{
		_ilg.Emit(OpCodes.Sub);
	}

	internal void Sub(bool negate)
	{
		if (negate)
		{
			_ilg.Emit(OpCodes.Add);
		}
		else
		{
			_ilg.Emit(OpCodes.Sub);
		}
	}

	internal void Ldloc(LocalBuilder lt)
	{
		_ilg.Emit(OpCodes.Ldloc_S, lt);
	}

	internal void Stloc(LocalBuilder lt)
	{
		_ilg.Emit(OpCodes.Stloc_S, lt);
	}

	internal void Ldthis()
	{
		_ilg.Emit(OpCodes.Ldarg_0);
	}

	internal void Ldthisfld(FieldInfo ft)
	{
		Ldthis();
		_ilg.Emit(OpCodes.Ldfld, ft);
	}

	internal void Mvfldloc(FieldInfo ft, LocalBuilder lt)
	{
		Ldthisfld(ft);
		Stloc(lt);
	}

	internal void Mvlocfld(LocalBuilder lt, FieldInfo ft)
	{
		Ldthis();
		Ldloc(lt);
		Stfld(ft);
	}

	internal void Stfld(FieldInfo ft)
	{
		_ilg.Emit(OpCodes.Stfld, ft);
	}

	internal void Callvirt(MethodInfo mt)
	{
		_ilg.Emit(OpCodes.Callvirt, mt);
	}

	internal void Call(MethodInfo mt)
	{
		_ilg.Emit(OpCodes.Call, mt);
	}

	internal void Newobj(ConstructorInfo ct)
	{
		_ilg.Emit(OpCodes.Newobj, ct);
	}

	internal void BrfalseFar(Label l)
	{
		_ilg.Emit(OpCodes.Brfalse, l);
	}

	internal void BrtrueFar(Label l)
	{
		_ilg.Emit(OpCodes.Brtrue, l);
	}

	internal void BrFar(Label l)
	{
		_ilg.Emit(OpCodes.Br, l);
	}

	internal void BleFar(Label l)
	{
		_ilg.Emit(OpCodes.Ble, l);
	}

	internal void BltFar(Label l)
	{
		_ilg.Emit(OpCodes.Blt, l);
	}

	internal void BgeFar(Label l)
	{
		_ilg.Emit(OpCodes.Bge, l);
	}

	internal void BgtFar(Label l)
	{
		_ilg.Emit(OpCodes.Bgt, l);
	}

	internal void BneFar(Label l)
	{
		_ilg.Emit(OpCodes.Bne_Un, l);
	}

	internal void BeqFar(Label l)
	{
		_ilg.Emit(OpCodes.Beq, l);
	}

	internal void Brfalse(Label l)
	{
		_ilg.Emit(OpCodes.Brfalse_S, l);
	}

	internal void Br(Label l)
	{
		_ilg.Emit(OpCodes.Br_S, l);
	}

	internal void Ble(Label l)
	{
		_ilg.Emit(OpCodes.Ble_S, l);
	}

	internal void Blt(Label l)
	{
		_ilg.Emit(OpCodes.Blt_S, l);
	}

	internal void Bge(Label l)
	{
		_ilg.Emit(OpCodes.Bge_S, l);
	}

	internal void Bgt(Label l)
	{
		_ilg.Emit(OpCodes.Bgt_S, l);
	}

	internal void Bgtun(Label l)
	{
		_ilg.Emit(OpCodes.Bgt_Un_S, l);
	}

	internal void Bne(Label l)
	{
		_ilg.Emit(OpCodes.Bne_Un_S, l);
	}

	internal void Beq(Label l)
	{
		_ilg.Emit(OpCodes.Beq_S, l);
	}

	internal void Ldlen()
	{
		_ilg.Emit(OpCodes.Ldlen);
	}

	internal void Rightchar()
	{
		Ldloc(_textV);
		Ldloc(_textposV);
		Callvirt(_getcharM);
	}

	internal void Rightcharnext()
	{
		Ldloc(_textV);
		Ldloc(_textposV);
		Dup();
		Ldc(1);
		Add();
		Stloc(_textposV);
		Callvirt(_getcharM);
	}

	internal void Leftchar()
	{
		Ldloc(_textV);
		Ldloc(_textposV);
		Ldc(1);
		Sub();
		Callvirt(_getcharM);
	}

	internal void Leftcharnext()
	{
		Ldloc(_textV);
		Ldloc(_textposV);
		Ldc(1);
		Sub();
		Dup();
		Stloc(_textposV);
		Callvirt(_getcharM);
	}

	internal void Track()
	{
		ReadyPushTrack();
		Ldc(AddTrack());
		DoPush();
	}

	internal void Trackagain()
	{
		ReadyPushTrack();
		Ldc(_backpos);
		DoPush();
	}

	internal void PushTrack(LocalBuilder lt)
	{
		ReadyPushTrack();
		Ldloc(lt);
		DoPush();
	}

	internal void TrackUnique(int i)
	{
		ReadyPushTrack();
		Ldc(AddUniqueTrack(i));
		DoPush();
	}

	internal void TrackUnique2(int i)
	{
		ReadyPushTrack();
		Ldc(AddUniqueTrack(i, 256));
		DoPush();
	}

	internal void ReadyPushTrack()
	{
		_ilg.Emit(OpCodes.Ldloc_S, _trackV);
		_ilg.Emit(OpCodes.Ldloc_S, _trackposV);
		_ilg.Emit(OpCodes.Ldc_I4_1);
		_ilg.Emit(OpCodes.Sub);
		_ilg.Emit(OpCodes.Dup);
		_ilg.Emit(OpCodes.Stloc_S, _trackposV);
	}

	internal void PopTrack()
	{
		_ilg.Emit(OpCodes.Ldloc_S, _trackV);
		_ilg.Emit(OpCodes.Ldloc_S, _trackposV);
		_ilg.Emit(OpCodes.Dup);
		_ilg.Emit(OpCodes.Ldc_I4_1);
		_ilg.Emit(OpCodes.Add);
		_ilg.Emit(OpCodes.Stloc_S, _trackposV);
		_ilg.Emit(OpCodes.Ldelem_I4);
	}

	internal void TopTrack()
	{
		_ilg.Emit(OpCodes.Ldloc_S, _trackV);
		_ilg.Emit(OpCodes.Ldloc_S, _trackposV);
		_ilg.Emit(OpCodes.Ldelem_I4);
	}

	internal void PushStack(LocalBuilder lt)
	{
		ReadyPushStack();
		_ilg.Emit(OpCodes.Ldloc_S, lt);
		DoPush();
	}

	internal void ReadyReplaceStack(int i)
	{
		_ilg.Emit(OpCodes.Ldloc_S, _stackV);
		_ilg.Emit(OpCodes.Ldloc_S, _stackposV);
		if (i != 0)
		{
			Ldc(i);
			_ilg.Emit(OpCodes.Add);
		}
	}

	internal void ReadyPushStack()
	{
		_ilg.Emit(OpCodes.Ldloc_S, _stackV);
		_ilg.Emit(OpCodes.Ldloc_S, _stackposV);
		_ilg.Emit(OpCodes.Ldc_I4_1);
		_ilg.Emit(OpCodes.Sub);
		_ilg.Emit(OpCodes.Dup);
		_ilg.Emit(OpCodes.Stloc_S, _stackposV);
	}

	internal void TopStack()
	{
		_ilg.Emit(OpCodes.Ldloc_S, _stackV);
		_ilg.Emit(OpCodes.Ldloc_S, _stackposV);
		_ilg.Emit(OpCodes.Ldelem_I4);
	}

	internal void PopStack()
	{
		_ilg.Emit(OpCodes.Ldloc_S, _stackV);
		_ilg.Emit(OpCodes.Ldloc_S, _stackposV);
		_ilg.Emit(OpCodes.Dup);
		_ilg.Emit(OpCodes.Ldc_I4_1);
		_ilg.Emit(OpCodes.Add);
		_ilg.Emit(OpCodes.Stloc_S, _stackposV);
		_ilg.Emit(OpCodes.Ldelem_I4);
	}

	internal void PopDiscardStack()
	{
		PopDiscardStack(1);
	}

	internal void PopDiscardStack(int i)
	{
		_ilg.Emit(OpCodes.Ldloc_S, _stackposV);
		Ldc(i);
		_ilg.Emit(OpCodes.Add);
		_ilg.Emit(OpCodes.Stloc_S, _stackposV);
	}

	internal void DoReplace()
	{
		_ilg.Emit(OpCodes.Stelem_I4);
	}

	internal void DoPush()
	{
		_ilg.Emit(OpCodes.Stelem_I4);
	}

	internal void Back()
	{
		_ilg.Emit(OpCodes.Br, _backtrack);
	}

	internal void Goto(int i)
	{
		if (i < _codepos)
		{
			Label l = DefineLabel();
			Ldloc(_trackposV);
			Ldc(_trackcount * 4);
			Ble(l);
			Ldloc(_stackposV);
			Ldc(_trackcount * 3);
			BgtFar(_labels[i]);
			MarkLabel(l);
			ReadyPushTrack();
			Ldc(AddGoto(i));
			DoPush();
			BrFar(_backtrack);
		}
		else
		{
			BrFar(_labels[i]);
		}
	}

	internal int NextCodepos()
	{
		return _codepos + RegexCode.OpcodeSize(_codes[_codepos]);
	}

	internal Label AdvanceLabel()
	{
		return _labels[NextCodepos()];
	}

	internal void Advance()
	{
		_ilg.Emit(OpCodes.Br, AdvanceLabel());
	}

	internal void CallToLower()
	{
		if ((_options & RegexOptions.CultureInvariant) != RegexOptions.None)
		{
			Call(_getInvariantCulture);
		}
		else
		{
			Call(_getCurrentCulture);
		}
		Call(_chartolowerM);
	}

	internal void GenerateForwardSection()
	{
		_labels = new Label[_codes.Length];
		_goto = new int[_codes.Length];
		for (int i = 0; i < _codes.Length; i += RegexCode.OpcodeSize(_codes[i]))
		{
			_goto[i] = -1;
			_labels[i] = _ilg.DefineLabel();
		}
		_uniquenote = new int[10];
		for (int j = 0; j < 10; j++)
		{
			_uniquenote[j] = -1;
		}
		Mvfldloc(_textF, _textV);
		Mvfldloc(_textstartF, _textstartV);
		Mvfldloc(_textbegF, _textbegV);
		Mvfldloc(_textendF, _textendV);
		Mvfldloc(_textposF, _textposV);
		Mvfldloc(_trackF, _trackV);
		Mvfldloc(_trackposF, _trackposV);
		Mvfldloc(_stackF, _stackV);
		Mvfldloc(_stackposF, _stackposV);
		_backpos = -1;
		for (int i = 0; i < _codes.Length; i += RegexCode.OpcodeSize(_codes[i]))
		{
			MarkLabel(_labels[i]);
			_codepos = i;
			_regexopcode = _codes[i];
			GenerateOneCode();
		}
	}

	internal void GenerateMiddleSection()
	{
		Label label = DefineLabel();
		MarkLabel(_backtrack);
		Mvlocfld(_trackposV, _trackposF);
		Mvlocfld(_stackposV, _stackposF);
		Ldthis();
		Callvirt(_ensurestorageM);
		Mvfldloc(_trackposF, _trackposV);
		Mvfldloc(_stackposF, _stackposV);
		Mvfldloc(_trackF, _trackV);
		Mvfldloc(_stackF, _stackV);
		PopTrack();
		Label[] array = new Label[_notecount];
		for (int i = 0; i < _notecount; i++)
		{
			array[i] = _notes[i]._label;
		}
		_ilg.Emit(OpCodes.Switch, array);
	}

	internal void GenerateBacktrackSection()
	{
		for (int i = 0; i < _notecount; i++)
		{
			BacktrackNote backtrackNote = _notes[i];
			if (backtrackNote._flags != 0)
			{
				_ilg.MarkLabel(backtrackNote._label);
				_codepos = backtrackNote._codepos;
				_backpos = i;
				_regexopcode = _codes[backtrackNote._codepos] | backtrackNote._flags;
				GenerateOneCode();
			}
		}
	}

	internal void GenerateFindFirstChar()
	{
		_textposV = DeclareInt();
		_textV = DeclareString();
		_tempV = DeclareInt();
		_temp2V = DeclareInt();
		if ((_anchors & 0x35) != 0)
		{
			if (!_code._rightToLeft)
			{
				if ((_anchors & 1) != 0)
				{
					Label l = DefineLabel();
					Ldthisfld(_textposF);
					Ldthisfld(_textbegF);
					Ble(l);
					Ldthis();
					Ldthisfld(_textendF);
					Stfld(_textposF);
					Ldc(0);
					Ret();
					MarkLabel(l);
				}
				if ((_anchors & 4) != 0)
				{
					Label l2 = DefineLabel();
					Ldthisfld(_textposF);
					Ldthisfld(_textstartF);
					Ble(l2);
					Ldthis();
					Ldthisfld(_textendF);
					Stfld(_textposF);
					Ldc(0);
					Ret();
					MarkLabel(l2);
				}
				if ((_anchors & 0x10) != 0)
				{
					Label l3 = DefineLabel();
					Ldthisfld(_textposF);
					Ldthisfld(_textendF);
					Ldc(1);
					Sub();
					Bge(l3);
					Ldthis();
					Ldthisfld(_textendF);
					Ldc(1);
					Sub();
					Stfld(_textposF);
					MarkLabel(l3);
				}
				if ((_anchors & 0x20) != 0)
				{
					Label l4 = DefineLabel();
					Ldthisfld(_textposF);
					Ldthisfld(_textendF);
					Bge(l4);
					Ldthis();
					Ldthisfld(_textendF);
					Stfld(_textposF);
					MarkLabel(l4);
				}
			}
			else
			{
				if ((_anchors & 0x20) != 0)
				{
					Label l5 = DefineLabel();
					Ldthisfld(_textposF);
					Ldthisfld(_textendF);
					Bge(l5);
					Ldthis();
					Ldthisfld(_textbegF);
					Stfld(_textposF);
					Ldc(0);
					Ret();
					MarkLabel(l5);
				}
				if ((_anchors & 0x10) != 0)
				{
					Label l6 = DefineLabel();
					Label l7 = DefineLabel();
					Ldthisfld(_textposF);
					Ldthisfld(_textendF);
					Ldc(1);
					Sub();
					Blt(l6);
					Ldthisfld(_textposF);
					Ldthisfld(_textendF);
					Beq(l7);
					Ldthisfld(_textF);
					Ldthisfld(_textposF);
					Callvirt(_getcharM);
					Ldc(10);
					Beq(l7);
					MarkLabel(l6);
					Ldthis();
					Ldthisfld(_textbegF);
					Stfld(_textposF);
					Ldc(0);
					Ret();
					MarkLabel(l7);
				}
				if ((_anchors & 4) != 0)
				{
					Label l8 = DefineLabel();
					Ldthisfld(_textposF);
					Ldthisfld(_textstartF);
					Bge(l8);
					Ldthis();
					Ldthisfld(_textbegF);
					Stfld(_textposF);
					Ldc(0);
					Ret();
					MarkLabel(l8);
				}
				if ((_anchors & 1) != 0)
				{
					Label l9 = DefineLabel();
					Ldthisfld(_textposF);
					Ldthisfld(_textbegF);
					Ble(l9);
					Ldthis();
					Ldthisfld(_textbegF);
					Stfld(_textposF);
					MarkLabel(l9);
				}
			}
			Ldc(1);
			Ret();
		}
		else if (_bmPrefix != null && _bmPrefix._negativeUnicode == null)
		{
			LocalBuilder tempV = _tempV;
			LocalBuilder tempV2 = _tempV;
			LocalBuilder temp2V = _temp2V;
			Label label = DefineLabel();
			Label l10 = DefineLabel();
			Label l11 = DefineLabel();
			Label l12 = DefineLabel();
			Label label2 = DefineLabel();
			Label l13 = DefineLabel();
			int num;
			int index;
			if (!_code._rightToLeft)
			{
				num = -1;
				index = _bmPrefix._pattern.Length - 1;
			}
			else
			{
				num = _bmPrefix._pattern.Length;
				index = 0;
			}
			int i = _bmPrefix._pattern[index];
			Mvfldloc(_textF, _textV);
			if (!_code._rightToLeft)
			{
				Ldthisfld(_textendF);
			}
			else
			{
				Ldthisfld(_textbegF);
			}
			Stloc(temp2V);
			Ldthisfld(_textposF);
			if (!_code._rightToLeft)
			{
				Ldc(_bmPrefix._pattern.Length - 1);
				Add();
			}
			else
			{
				Ldc(_bmPrefix._pattern.Length);
				Sub();
			}
			Stloc(_textposV);
			Br(l12);
			MarkLabel(label);
			if (!_code._rightToLeft)
			{
				Ldc(_bmPrefix._pattern.Length);
			}
			else
			{
				Ldc(-_bmPrefix._pattern.Length);
			}
			MarkLabel(l10);
			Ldloc(_textposV);
			Add();
			Stloc(_textposV);
			MarkLabel(l12);
			Ldloc(_textposV);
			Ldloc(temp2V);
			if (!_code._rightToLeft)
			{
				BgeFar(l11);
			}
			else
			{
				BltFar(l11);
			}
			Rightchar();
			if (_bmPrefix._caseInsensitive)
			{
				CallToLower();
			}
			Dup();
			Stloc(tempV);
			Ldc(i);
			BeqFar(l13);
			Ldloc(tempV);
			Ldc(_bmPrefix._lowASCII);
			Sub();
			Dup();
			Stloc(tempV);
			Ldc(_bmPrefix._highASCII - _bmPrefix._lowASCII);
			Bgtun(label);
			Label[] array = new Label[_bmPrefix._highASCII - _bmPrefix._lowASCII + 1];
			for (int j = _bmPrefix._lowASCII; j <= _bmPrefix._highASCII; j++)
			{
				if (_bmPrefix._negativeASCII[j] == num)
				{
					array[j - _bmPrefix._lowASCII] = label;
				}
				else
				{
					array[j - _bmPrefix._lowASCII] = DefineLabel();
				}
			}
			Ldloc(tempV);
			_ilg.Emit(OpCodes.Switch, array);
			for (int j = _bmPrefix._lowASCII; j <= _bmPrefix._highASCII; j++)
			{
				if (_bmPrefix._negativeASCII[j] != num)
				{
					MarkLabel(array[j - _bmPrefix._lowASCII]);
					Ldc(_bmPrefix._negativeASCII[j]);
					BrFar(l10);
				}
			}
			MarkLabel(l13);
			Ldloc(_textposV);
			Stloc(tempV2);
			for (int j = _bmPrefix._pattern.Length - 2; j >= 0; j--)
			{
				Label l14 = DefineLabel();
				int num2 = (_code._rightToLeft ? (_bmPrefix._pattern.Length - 1 - j) : j);
				Ldloc(_textV);
				Ldloc(tempV2);
				Ldc(1);
				Sub(_code._rightToLeft);
				Dup();
				Stloc(tempV2);
				Callvirt(_getcharM);
				if (_bmPrefix._caseInsensitive)
				{
					CallToLower();
				}
				Ldc(_bmPrefix._pattern[num2]);
				Beq(l14);
				Ldc(_bmPrefix._positive[num2]);
				BrFar(l10);
				MarkLabel(l14);
			}
			Ldthis();
			Ldloc(tempV2);
			if (_code._rightToLeft)
			{
				Ldc(1);
				Add();
			}
			Stfld(_textposF);
			Ldc(1);
			Ret();
			MarkLabel(l11);
			Ldthis();
			if (!_code._rightToLeft)
			{
				Ldthisfld(_textendF);
			}
			else
			{
				Ldthisfld(_textbegF);
			}
			Stfld(_textposF);
			Ldc(0);
			Ret();
		}
		else if (_fcPrefix == null)
		{
			Ldc(1);
			Ret();
		}
		else
		{
			LocalBuilder temp2V2 = _temp2V;
			LocalBuilder tempV3 = _tempV;
			Label l15 = DefineLabel();
			Label l16 = DefineLabel();
			Label l17 = DefineLabel();
			Label l18 = DefineLabel();
			Label l19 = DefineLabel();
			Mvfldloc(_textposF, _textposV);
			Mvfldloc(_textF, _textV);
			if (!_code._rightToLeft)
			{
				Ldthisfld(_textendF);
				Ldloc(_textposV);
			}
			else
			{
				Ldloc(_textposV);
				Ldthisfld(_textbegF);
			}
			Sub();
			Stloc(temp2V2);
			Ldloc(temp2V2);
			Ldc(0);
			BleFar(l18);
			MarkLabel(l15);
			Ldloc(temp2V2);
			Ldc(1);
			Sub();
			Stloc(temp2V2);
			if (_code._rightToLeft)
			{
				Leftcharnext();
			}
			else
			{
				Rightcharnext();
			}
			if (_fcPrefix.CaseInsensitive)
			{
				CallToLower();
			}
			if (!RegexCharClass.IsSingleton(_fcPrefix.Prefix))
			{
				Ldstr(_fcPrefix.Prefix);
				Call(_charInSetM);
				BrtrueFar(l16);
			}
			else
			{
				Ldc(RegexCharClass.SingletonChar(_fcPrefix.Prefix));
				Beq(l16);
			}
			MarkLabel(l19);
			Ldloc(temp2V2);
			Ldc(0);
			if (!RegexCharClass.IsSingleton(_fcPrefix.Prefix))
			{
				BgtFar(l15);
			}
			else
			{
				Bgt(l15);
			}
			Ldc(0);
			BrFar(l17);
			MarkLabel(l16);
			Ldloc(_textposV);
			Ldc(1);
			Sub(_code._rightToLeft);
			Stloc(_textposV);
			Ldc(1);
			MarkLabel(l17);
			Mvlocfld(_textposV, _textposF);
			Ret();
			MarkLabel(l18);
			Ldc(0);
			Ret();
		}
	}

	internal void GenerateInitTrackCount()
	{
		Ldthis();
		Ldc(_trackcount);
		Stfld(_trackcountF);
		Ret();
	}

	internal LocalBuilder DeclareInt()
	{
		return _ilg.DeclareLocal(typeof(int));
	}

	internal LocalBuilder DeclareIntArray()
	{
		return _ilg.DeclareLocal(typeof(int[]));
	}

	internal LocalBuilder DeclareString()
	{
		return _ilg.DeclareLocal(typeof(string));
	}

	internal void GenerateGo()
	{
		_textposV = DeclareInt();
		_textV = DeclareString();
		_trackposV = DeclareInt();
		_trackV = DeclareIntArray();
		_stackposV = DeclareInt();
		_stackV = DeclareIntArray();
		_tempV = DeclareInt();
		_temp2V = DeclareInt();
		_temp3V = DeclareInt();
		_textbegV = DeclareInt();
		_textendV = DeclareInt();
		_textstartV = DeclareInt();
		if (!UseLegacyTimeoutCheck)
		{
			_loopV = DeclareInt();
		}
		_labels = null;
		_notes = null;
		_notecount = 0;
		_backtrack = DefineLabel();
		GenerateForwardSection();
		GenerateMiddleSection();
		GenerateBacktrackSection();
	}

	internal void GenerateOneCode()
	{
		Ldthis();
		Callvirt(_checkTimeoutM);
		switch (_regexopcode)
		{
		case 40:
			Mvlocfld(_textposV, _textposF);
			Ret();
			break;
		case 22:
			Back();
			break;
		case 38:
			Goto(Operand(0));
			break;
		case 37:
			Ldthis();
			Ldc(Operand(0));
			Callvirt(_ismatchedM);
			BrfalseFar(_backtrack);
			break;
		case 23:
			PushTrack(_textposV);
			Track();
			break;
		case 151:
			PopTrack();
			Stloc(_textposV);
			Goto(Operand(0));
			break;
		case 30:
			ReadyPushStack();
			Ldc(-1);
			DoPush();
			TrackUnique(0);
			break;
		case 31:
			PushStack(_textposV);
			TrackUnique(0);
			break;
		case 158:
		case 159:
			PopDiscardStack();
			Back();
			break;
		case 33:
			ReadyPushTrack();
			PopStack();
			Dup();
			Stloc(_textposV);
			DoPush();
			Track();
			break;
		case 161:
			ReadyPushStack();
			PopTrack();
			DoPush();
			Back();
			break;
		case 32:
			if (Operand(1) != -1)
			{
				Ldthis();
				Ldc(Operand(1));
				Callvirt(_ismatchedM);
				BrfalseFar(_backtrack);
			}
			PopStack();
			Stloc(_tempV);
			if (Operand(1) != -1)
			{
				Ldthis();
				Ldc(Operand(0));
				Ldc(Operand(1));
				Ldloc(_tempV);
				Ldloc(_textposV);
				Callvirt(_transferM);
			}
			else
			{
				Ldthis();
				Ldc(Operand(0));
				Ldloc(_tempV);
				Ldloc(_textposV);
				Callvirt(_captureM);
			}
			PushTrack(_tempV);
			if (Operand(0) != -1 && Operand(1) != -1)
			{
				TrackUnique(4);
			}
			else
			{
				TrackUnique(3);
			}
			break;
		case 160:
			ReadyPushStack();
			PopTrack();
			DoPush();
			Ldthis();
			Callvirt(_uncaptureM);
			if (Operand(0) != -1 && Operand(1) != -1)
			{
				Ldthis();
				Callvirt(_uncaptureM);
			}
			Back();
			break;
		case 24:
		{
			LocalBuilder tempV9 = _tempV;
			Label l20 = DefineLabel();
			PopStack();
			Dup();
			Stloc(tempV9);
			PushTrack(tempV9);
			Ldloc(_textposV);
			Beq(l20);
			PushTrack(_textposV);
			PushStack(_textposV);
			Track();
			Goto(Operand(0));
			MarkLabel(l20);
			TrackUnique2(5);
			break;
		}
		case 152:
			PopTrack();
			Stloc(_textposV);
			PopStack();
			Pop();
			TrackUnique2(5);
			Advance();
			break;
		case 280:
			ReadyPushStack();
			PopTrack();
			DoPush();
			Back();
			break;
		case 25:
		{
			LocalBuilder tempV8 = _tempV;
			Label l17 = DefineLabel();
			Label l18 = DefineLabel();
			Label l19 = DefineLabel();
			PopStack();
			Dup();
			Stloc(tempV8);
			Ldloc(tempV8);
			Ldc(-1);
			Beq(l18);
			PushTrack(tempV8);
			Br(l19);
			MarkLabel(l18);
			PushTrack(_textposV);
			MarkLabel(l19);
			Ldloc(_textposV);
			Beq(l17);
			PushTrack(_textposV);
			Track();
			Br(AdvanceLabel());
			MarkLabel(l17);
			ReadyPushStack();
			Ldloc(tempV8);
			DoPush();
			TrackUnique2(6);
			break;
		}
		case 153:
			PopTrack();
			Stloc(_textposV);
			PushStack(_textposV);
			TrackUnique2(6);
			Goto(Operand(0));
			break;
		case 281:
			ReadyReplaceStack(0);
			PopTrack();
			DoReplace();
			Back();
			break;
		case 26:
			ReadyPushStack();
			Ldc(-1);
			DoPush();
			ReadyPushStack();
			Ldc(Operand(0));
			DoPush();
			TrackUnique(1);
			break;
		case 27:
			PushStack(_textposV);
			ReadyPushStack();
			Ldc(Operand(0));
			DoPush();
			TrackUnique(1);
			break;
		case 154:
		case 155:
			PopDiscardStack(2);
			Back();
			break;
		case 28:
		{
			LocalBuilder tempV7 = _tempV;
			LocalBuilder temp2V4 = _temp2V;
			Label l15 = DefineLabel();
			Label l16 = DefineLabel();
			PopStack();
			Stloc(tempV7);
			PopStack();
			Dup();
			Stloc(temp2V4);
			PushTrack(temp2V4);
			Ldloc(_textposV);
			Bne(l15);
			Ldloc(tempV7);
			Ldc(0);
			Bge(l16);
			MarkLabel(l15);
			Ldloc(tempV7);
			Ldc(Operand(1));
			Bge(l16);
			PushStack(_textposV);
			ReadyPushStack();
			Ldloc(tempV7);
			Ldc(1);
			Add();
			DoPush();
			Track();
			Goto(Operand(0));
			MarkLabel(l16);
			PushTrack(tempV7);
			TrackUnique2(7);
			break;
		}
		case 156:
		{
			LocalBuilder tempV5 = _tempV;
			Label l13 = DefineLabel();
			PopStack();
			Ldc(1);
			Sub();
			Dup();
			Stloc(tempV5);
			Ldc(0);
			Blt(l13);
			PopStack();
			Stloc(_textposV);
			PushTrack(tempV5);
			TrackUnique2(7);
			Advance();
			MarkLabel(l13);
			ReadyReplaceStack(0);
			PopTrack();
			DoReplace();
			PushStack(tempV5);
			Back();
			break;
		}
		case 284:
			PopTrack();
			Stloc(_tempV);
			ReadyPushStack();
			PopTrack();
			DoPush();
			PushStack(_tempV);
			Back();
			break;
		case 29:
		{
			LocalBuilder tempV6 = _tempV;
			LocalBuilder temp2V3 = _temp2V;
			Label l14 = DefineLabel();
			Label label = DefineLabel();
			Label label2 = _labels[NextCodepos()];
			PopStack();
			Stloc(tempV6);
			PopStack();
			Stloc(temp2V3);
			Ldloc(tempV6);
			Ldc(0);
			Bge(l14);
			PushTrack(temp2V3);
			PushStack(_textposV);
			ReadyPushStack();
			Ldloc(tempV6);
			Ldc(1);
			Add();
			DoPush();
			TrackUnique2(8);
			Goto(Operand(0));
			MarkLabel(l14);
			PushTrack(temp2V3);
			PushTrack(tempV6);
			PushTrack(_textposV);
			Track();
			break;
		}
		case 157:
		{
			Label l12 = DefineLabel();
			LocalBuilder tempV4 = _tempV;
			PopTrack();
			Stloc(_textposV);
			PopTrack();
			Dup();
			Stloc(tempV4);
			Ldc(Operand(1));
			Bge(l12);
			Ldloc(_textposV);
			TopTrack();
			Beq(l12);
			PushStack(_textposV);
			ReadyPushStack();
			Ldloc(tempV4);
			Ldc(1);
			Add();
			DoPush();
			TrackUnique2(8);
			Goto(Operand(0));
			MarkLabel(l12);
			ReadyPushStack();
			PopTrack();
			DoPush();
			PushStack(tempV4);
			Back();
			break;
		}
		case 285:
			ReadyReplaceStack(1);
			PopTrack();
			DoReplace();
			ReadyReplaceStack(0);
			TopStack();
			Ldc(1);
			Sub();
			DoReplace();
			Back();
			break;
		case 34:
			ReadyPushStack();
			Ldthisfld(_trackF);
			Ldlen();
			Ldloc(_trackposV);
			Sub();
			DoPush();
			ReadyPushStack();
			Ldthis();
			Callvirt(_crawlposM);
			DoPush();
			TrackUnique(1);
			break;
		case 162:
			PopDiscardStack(2);
			Back();
			break;
		case 35:
		{
			Label l5 = DefineLabel();
			Label l6 = DefineLabel();
			PopStack();
			Ldthisfld(_trackF);
			Ldlen();
			PopStack();
			Sub();
			Stloc(_trackposV);
			Dup();
			Ldthis();
			Callvirt(_crawlposM);
			Beq(l6);
			MarkLabel(l5);
			Ldthis();
			Callvirt(_uncaptureM);
			Dup();
			Ldthis();
			Callvirt(_crawlposM);
			Bne(l5);
			MarkLabel(l6);
			Pop();
			Back();
			break;
		}
		case 36:
			PopStack();
			Stloc(_tempV);
			Ldthisfld(_trackF);
			Ldlen();
			PopStack();
			Sub();
			Stloc(_trackposV);
			PushTrack(_tempV);
			TrackUnique(9);
			break;
		case 164:
		{
			Label l7 = DefineLabel();
			Label l8 = DefineLabel();
			PopTrack();
			Dup();
			Ldthis();
			Callvirt(_crawlposM);
			Beq(l8);
			MarkLabel(l7);
			Ldthis();
			Callvirt(_uncaptureM);
			Dup();
			Ldthis();
			Callvirt(_crawlposM);
			Bne(l7);
			MarkLabel(l8);
			Pop();
			Back();
			break;
		}
		case 14:
		{
			Label l2 = _labels[NextCodepos()];
			Ldloc(_textposV);
			Ldloc(_textbegV);
			Ble(l2);
			Leftchar();
			Ldc(10);
			BneFar(_backtrack);
			break;
		}
		case 15:
		{
			Label l = _labels[NextCodepos()];
			Ldloc(_textposV);
			Ldloc(_textendV);
			Bge(l);
			Rightchar();
			Ldc(10);
			BneFar(_backtrack);
			break;
		}
		case 16:
		case 17:
			Ldthis();
			Ldloc(_textposV);
			Ldloc(_textbegV);
			Ldloc(_textendV);
			Callvirt(_isboundaryM);
			if (Code() == 16)
			{
				BrfalseFar(_backtrack);
			}
			else
			{
				BrtrueFar(_backtrack);
			}
			break;
		case 41:
		case 42:
			Ldthis();
			Ldloc(_textposV);
			Ldloc(_textbegV);
			Ldloc(_textendV);
			Callvirt(_isECMABoundaryM);
			if (Code() == 41)
			{
				BrfalseFar(_backtrack);
			}
			else
			{
				BrtrueFar(_backtrack);
			}
			break;
		case 18:
			Ldloc(_textposV);
			Ldloc(_textbegV);
			BgtFar(_backtrack);
			break;
		case 19:
			Ldloc(_textposV);
			Ldthisfld(_textstartF);
			BneFar(_backtrack);
			break;
		case 20:
			Ldloc(_textposV);
			Ldloc(_textendV);
			Ldc(1);
			Sub();
			BltFar(_backtrack);
			Ldloc(_textposV);
			Ldloc(_textendV);
			Bge(_labels[NextCodepos()]);
			Rightchar();
			Ldc(10);
			BneFar(_backtrack);
			break;
		case 21:
			Ldloc(_textposV);
			Ldloc(_textendV);
			BltFar(_backtrack);
			break;
		case 9:
		case 10:
		case 11:
		case 73:
		case 74:
		case 75:
		case 521:
		case 522:
		case 523:
		case 585:
		case 586:
		case 587:
			Ldloc(_textposV);
			if (!IsRtl())
			{
				Ldloc(_textendV);
				BgeFar(_backtrack);
				Rightcharnext();
			}
			else
			{
				Ldloc(_textbegV);
				BleFar(_backtrack);
				Leftcharnext();
			}
			if (IsCi())
			{
				CallToLower();
			}
			if (Code() == 11)
			{
				Ldstr(_strings[Operand(0)]);
				Call(_charInSetM);
				BrfalseFar(_backtrack);
				break;
			}
			Ldc(Operand(0));
			if (Code() == 9)
			{
				BneFar(_backtrack);
			}
			else
			{
				BeqFar(_backtrack);
			}
			break;
		case 12:
		case 524:
		{
			string text2 = _strings[Operand(0)];
			Ldc(text2.Length);
			Ldloc(_textendV);
			Ldloc(_textposV);
			Sub();
			BgtFar(_backtrack);
			for (int i = 0; i < text2.Length; i++)
			{
				Ldloc(_textV);
				Ldloc(_textposV);
				if (i != 0)
				{
					Ldc(i);
					Add();
				}
				Callvirt(_getcharM);
				if (IsCi())
				{
					CallToLower();
				}
				Ldc(text2[i]);
				BneFar(_backtrack);
			}
			Ldloc(_textposV);
			Ldc(text2.Length);
			Add();
			Stloc(_textposV);
			break;
		}
		case 76:
		case 588:
		{
			string text = _strings[Operand(0)];
			Ldc(text.Length);
			Ldloc(_textposV);
			Ldloc(_textbegV);
			Sub();
			BgtFar(_backtrack);
			int num3 = text.Length;
			while (num3 > 0)
			{
				num3--;
				Ldloc(_textV);
				Ldloc(_textposV);
				Ldc(text.Length - num3);
				Sub();
				Callvirt(_getcharM);
				if (IsCi())
				{
					CallToLower();
				}
				Ldc(text[num3]);
				BneFar(_backtrack);
			}
			Ldloc(_textposV);
			Ldc(text.Length);
			Sub();
			Stloc(_textposV);
			break;
		}
		case 13:
		case 77:
		case 525:
		case 589:
		{
			LocalBuilder tempV2 = _tempV;
			LocalBuilder temp2V = _temp2V;
			Label l4 = DefineLabel();
			Ldthis();
			Ldc(Operand(0));
			Callvirt(_ismatchedM);
			if ((_options & RegexOptions.ECMAScript) != RegexOptions.None)
			{
				Brfalse(AdvanceLabel());
			}
			else
			{
				BrfalseFar(_backtrack);
			}
			Ldthis();
			Ldc(Operand(0));
			Callvirt(_matchlengthM);
			Dup();
			Stloc(tempV2);
			if (!IsRtl())
			{
				Ldloc(_textendV);
				Ldloc(_textposV);
			}
			else
			{
				Ldloc(_textposV);
				Ldloc(_textbegV);
			}
			Sub();
			BgtFar(_backtrack);
			Ldthis();
			Ldc(Operand(0));
			Callvirt(_matchindexM);
			if (!IsRtl())
			{
				Ldloc(tempV2);
				Add(IsRtl());
			}
			Stloc(temp2V);
			Ldloc(_textposV);
			Ldloc(tempV2);
			Add(IsRtl());
			Stloc(_textposV);
			MarkLabel(l4);
			Ldloc(tempV2);
			Ldc(0);
			Ble(AdvanceLabel());
			Ldloc(_textV);
			Ldloc(temp2V);
			Ldloc(tempV2);
			if (IsRtl())
			{
				Ldc(1);
				Sub();
				Dup();
				Stloc(tempV2);
			}
			Sub(IsRtl());
			Callvirt(_getcharM);
			if (IsCi())
			{
				CallToLower();
			}
			Ldloc(_textV);
			Ldloc(_textposV);
			Ldloc(tempV2);
			if (!IsRtl())
			{
				Dup();
				Ldc(1);
				Sub();
				Stloc(tempV2);
			}
			Sub(IsRtl());
			Callvirt(_getcharM);
			if (IsCi())
			{
				CallToLower();
			}
			Beq(l4);
			Back();
			break;
		}
		case 0:
		case 1:
		case 2:
		case 64:
		case 65:
		case 66:
		case 512:
		case 513:
		case 514:
		case 576:
		case 577:
		case 578:
		{
			LocalBuilder tempV10 = _tempV;
			Label l21 = DefineLabel();
			int num4 = Operand(1);
			if (num4 == 0)
			{
				break;
			}
			Ldc(num4);
			if (!IsRtl())
			{
				Ldloc(_textendV);
				Ldloc(_textposV);
			}
			else
			{
				Ldloc(_textposV);
				Ldloc(_textbegV);
			}
			Sub();
			BgtFar(_backtrack);
			Ldloc(_textposV);
			Ldc(num4);
			Add(IsRtl());
			Stloc(_textposV);
			Ldc(num4);
			Stloc(tempV10);
			MarkLabel(l21);
			Ldloc(_textV);
			Ldloc(_textposV);
			Ldloc(tempV10);
			if (IsRtl())
			{
				Ldc(1);
				Sub();
				Dup();
				Stloc(tempV10);
				Add();
			}
			else
			{
				Dup();
				Ldc(1);
				Sub();
				Stloc(tempV10);
				Sub();
			}
			Callvirt(_getcharM);
			if (IsCi())
			{
				CallToLower();
			}
			if (Code() == 2)
			{
				if (!UseLegacyTimeoutCheck)
				{
					EmitTimeoutCheck();
				}
				Ldstr(_strings[Operand(0)]);
				Call(_charInSetM);
				BrfalseFar(_backtrack);
			}
			else
			{
				Ldc(Operand(0));
				if (Code() == 0)
				{
					BneFar(_backtrack);
				}
				else
				{
					BeqFar(_backtrack);
				}
			}
			Ldloc(tempV10);
			Ldc(0);
			if (Code() == 2)
			{
				BgtFar(l21);
			}
			else
			{
				Bgt(l21);
			}
			break;
		}
		case 3:
		case 4:
		case 5:
		case 67:
		case 68:
		case 69:
		case 515:
		case 516:
		case 517:
		case 579:
		case 580:
		case 581:
		{
			LocalBuilder tempV3 = _tempV;
			LocalBuilder temp2V2 = _temp2V;
			Label l9 = DefineLabel();
			Label l10 = DefineLabel();
			int num2 = Operand(1);
			if (num2 == 0)
			{
				break;
			}
			if (!IsRtl())
			{
				Ldloc(_textendV);
				Ldloc(_textposV);
			}
			else
			{
				Ldloc(_textposV);
				Ldloc(_textbegV);
			}
			Sub();
			if (num2 != int.MaxValue)
			{
				Label l11 = DefineLabel();
				Dup();
				Ldc(num2);
				Blt(l11);
				Pop();
				Ldc(num2);
				MarkLabel(l11);
			}
			Dup();
			Stloc(temp2V2);
			Ldc(1);
			Add();
			Stloc(tempV3);
			MarkLabel(l9);
			Ldloc(tempV3);
			Ldc(1);
			Sub();
			Dup();
			Stloc(tempV3);
			Ldc(0);
			if (Code() == 5)
			{
				BleFar(l10);
			}
			else
			{
				Ble(l10);
			}
			if (IsRtl())
			{
				Leftcharnext();
			}
			else
			{
				Rightcharnext();
			}
			if (IsCi())
			{
				CallToLower();
			}
			if (Code() == 5)
			{
				if (!UseLegacyTimeoutCheck)
				{
					EmitTimeoutCheck();
				}
				Ldstr(_strings[Operand(0)]);
				Call(_charInSetM);
				BrtrueFar(l9);
			}
			else
			{
				Ldc(Operand(0));
				if (Code() == 3)
				{
					Beq(l9);
				}
				else
				{
					Bne(l9);
				}
			}
			Ldloc(_textposV);
			Ldc(1);
			Sub(IsRtl());
			Stloc(_textposV);
			MarkLabel(l10);
			Ldloc(temp2V2);
			Ldloc(tempV3);
			Ble(AdvanceLabel());
			ReadyPushTrack();
			Ldloc(temp2V2);
			Ldloc(tempV3);
			Sub();
			Ldc(1);
			Sub();
			DoPush();
			ReadyPushTrack();
			Ldloc(_textposV);
			Ldc(1);
			Sub(IsRtl());
			DoPush();
			Track();
			break;
		}
		case 131:
		case 132:
		case 133:
		case 195:
		case 196:
		case 197:
		case 643:
		case 644:
		case 645:
		case 707:
		case 708:
		case 709:
			PopTrack();
			Stloc(_textposV);
			PopTrack();
			Stloc(_tempV);
			Ldloc(_tempV);
			Ldc(0);
			BleFar(AdvanceLabel());
			ReadyPushTrack();
			Ldloc(_tempV);
			Ldc(1);
			Sub();
			DoPush();
			ReadyPushTrack();
			Ldloc(_textposV);
			Ldc(1);
			Sub(IsRtl());
			DoPush();
			Trackagain();
			Advance();
			break;
		case 6:
		case 7:
		case 8:
		case 70:
		case 71:
		case 72:
		case 518:
		case 519:
		case 520:
		case 582:
		case 583:
		case 584:
		{
			LocalBuilder tempV = _tempV;
			int num = Operand(1);
			if (num != 0)
			{
				if (!IsRtl())
				{
					Ldloc(_textendV);
					Ldloc(_textposV);
				}
				else
				{
					Ldloc(_textposV);
					Ldloc(_textbegV);
				}
				Sub();
				if (num != int.MaxValue)
				{
					Label l3 = DefineLabel();
					Dup();
					Ldc(num);
					Blt(l3);
					Pop();
					Ldc(num);
					MarkLabel(l3);
				}
				Dup();
				Stloc(tempV);
				Ldc(0);
				Ble(AdvanceLabel());
				ReadyPushTrack();
				Ldloc(tempV);
				Ldc(1);
				Sub();
				DoPush();
				PushTrack(_textposV);
				Track();
			}
			break;
		}
		case 134:
		case 135:
		case 136:
		case 198:
		case 199:
		case 200:
		case 646:
		case 647:
		case 648:
		case 710:
		case 711:
		case 712:
			PopTrack();
			Stloc(_textposV);
			PopTrack();
			Stloc(_temp2V);
			if (!IsRtl())
			{
				Rightcharnext();
			}
			else
			{
				Leftcharnext();
			}
			if (IsCi())
			{
				CallToLower();
			}
			if (Code() == 8)
			{
				Ldstr(_strings[Operand(0)]);
				Call(_charInSetM);
				BrfalseFar(_backtrack);
			}
			else
			{
				Ldc(Operand(0));
				if (Code() == 6)
				{
					BneFar(_backtrack);
				}
				else
				{
					BeqFar(_backtrack);
				}
			}
			Ldloc(_temp2V);
			Ldc(0);
			BleFar(AdvanceLabel());
			ReadyPushTrack();
			Ldloc(_temp2V);
			Ldc(1);
			Sub();
			DoPush();
			PushTrack(_textposV);
			Trackagain();
			Advance();
			break;
		default:
			throw new NotImplementedException(SR.GetString("UnimplementedState"));
		}
	}

	private void EmitTimeoutCheck()
	{
		Label l = DefineLabel();
		Ldloc(_loopV);
		Ldc(1);
		Add();
		Stloc(_loopV);
		Ldloc(_loopV);
		Ldc(2000);
		Rem();
		Ldc(0);
		Ceq();
		Brfalse(l);
		Ldthis();
		Callvirt(_checkTimeoutM);
		MarkLabel(l);
	}
}
