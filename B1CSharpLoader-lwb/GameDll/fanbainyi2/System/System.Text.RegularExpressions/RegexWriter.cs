using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace System.Text.RegularExpressions;

internal sealed class RegexWriter
{
	internal int[] _intStack;

	internal int _depth;

	internal int[] _emitted;

	internal int _curpos;

	internal Dictionary<string, int> _stringhash;

	internal List<string> _stringtable;

	internal bool _counting;

	internal int _count;

	internal int _trackcount;

	internal Hashtable _caps;

	internal const int BeforeChild = 64;

	internal const int AfterChild = 128;

	internal static RegexCode Write(RegexTree t)
	{
		RegexWriter regexWriter = new RegexWriter();
		return regexWriter.RegexCodeFromRegexTree(t);
	}

	private RegexWriter()
	{
		_intStack = new int[32];
		_emitted = new int[32];
		_stringhash = new Dictionary<string, int>();
		_stringtable = new List<string>();
	}

	internal void PushInt(int I)
	{
		if (_depth >= _intStack.Length)
		{
			int[] array = new int[_depth * 2];
			Array.Copy(_intStack, 0, array, 0, _depth);
			_intStack = array;
		}
		_intStack[_depth++] = I;
	}

	internal bool EmptyStack()
	{
		return _depth == 0;
	}

	internal int PopInt()
	{
		return _intStack[--_depth];
	}

	internal int CurPos()
	{
		return _curpos;
	}

	internal void PatchJump(int Offset, int jumpDest)
	{
		_emitted[Offset + 1] = jumpDest;
	}

	internal void Emit(int op)
	{
		if (_counting)
		{
			_count++;
			if (RegexCode.OpcodeBacktracks(op))
			{
				_trackcount++;
			}
		}
		else
		{
			_emitted[_curpos++] = op;
		}
	}

	internal void Emit(int op, int opd1)
	{
		if (_counting)
		{
			_count += 2;
			if (RegexCode.OpcodeBacktracks(op))
			{
				_trackcount++;
			}
		}
		else
		{
			_emitted[_curpos++] = op;
			_emitted[_curpos++] = opd1;
		}
	}

	internal void Emit(int op, int opd1, int opd2)
	{
		if (_counting)
		{
			_count += 3;
			if (RegexCode.OpcodeBacktracks(op))
			{
				_trackcount++;
			}
		}
		else
		{
			_emitted[_curpos++] = op;
			_emitted[_curpos++] = opd1;
			_emitted[_curpos++] = opd2;
		}
	}

	internal int StringCode(string str)
	{
		if (_counting)
		{
			return 0;
		}
		if (str == null)
		{
			str = string.Empty;
		}
		int num;
		if (_stringhash.ContainsKey(str))
		{
			num = _stringhash[str];
		}
		else
		{
			num = _stringtable.Count;
			_stringhash[str] = num;
			_stringtable.Add(str);
		}
		return num;
	}

	internal ArgumentException MakeException(string message)
	{
		return new ArgumentException(message);
	}

	internal int MapCapnum(int capnum)
	{
		if (capnum == -1)
		{
			return -1;
		}
		if (_caps != null)
		{
			return (int)_caps[capnum];
		}
		return capnum;
	}

	internal RegexCode RegexCodeFromRegexTree(RegexTree tree)
	{
		int capsize;
		if (tree._capnumlist == null || tree._captop == tree._capnumlist.Length)
		{
			capsize = tree._captop;
			_caps = null;
		}
		else
		{
			capsize = tree._capnumlist.Length;
			_caps = tree._caps;
			for (int i = 0; i < tree._capnumlist.Length; i++)
			{
				_caps[tree._capnumlist[i]] = i;
			}
		}
		_counting = true;
		while (true)
		{
			if (!_counting)
			{
				_emitted = new int[_count];
			}
			RegexNode regexNode = tree._root;
			int num = 0;
			Emit(23, 0);
			while (true)
			{
				if (regexNode._children == null)
				{
					EmitFragment(regexNode._type, regexNode, 0);
				}
				else if (num < regexNode._children.Count)
				{
					EmitFragment(regexNode._type | 0x40, regexNode, num);
					regexNode = regexNode._children[num];
					PushInt(num);
					num = 0;
					continue;
				}
				if (EmptyStack())
				{
					break;
				}
				num = PopInt();
				regexNode = regexNode._next;
				EmitFragment(regexNode._type | 0x80, regexNode, num);
				num++;
			}
			PatchJump(0, CurPos());
			Emit(40);
			if (!_counting)
			{
				break;
			}
			_counting = false;
		}
		RegexPrefix fcPrefix = RegexFCD.FirstChars(tree);
		RegexPrefix regexPrefix = RegexFCD.Prefix(tree);
		bool rightToLeft = (tree._options & RegexOptions.RightToLeft) != 0;
		CultureInfo culture = (((tree._options & RegexOptions.CultureInvariant) != RegexOptions.None) ? CultureInfo.InvariantCulture : CultureInfo.CurrentCulture);
		RegexBoyerMoore bmPrefix = ((regexPrefix == null || regexPrefix.Prefix.Length <= 0) ? null : new RegexBoyerMoore(regexPrefix.Prefix, regexPrefix.CaseInsensitive, rightToLeft, culture));
		int anchors = RegexFCD.Anchors(tree);
		return new RegexCode(_emitted, _stringtable, _trackcount, _caps, capsize, bmPrefix, fcPrefix, anchors, rightToLeft);
	}

	internal void EmitFragment(int nodetype, RegexNode node, int CurIndex)
	{
		int num = 0;
		if (nodetype <= 13)
		{
			if (node.UseOptionR())
			{
				num |= 0x40;
			}
			if ((node._options & RegexOptions.IgnoreCase) != RegexOptions.None)
			{
				num |= 0x200;
			}
		}
		switch (nodetype)
		{
		case 88:
			if (CurIndex < node._children.Count - 1)
			{
				PushInt(CurPos());
				Emit(23, 0);
			}
			break;
		case 152:
			if (CurIndex < node._children.Count - 1)
			{
				int offset = PopInt();
				PushInt(CurPos());
				Emit(38, 0);
				PatchJump(offset, CurPos());
			}
			else
			{
				for (int i = 0; i < CurIndex; i++)
				{
					PatchJump(PopInt(), CurPos());
				}
			}
			break;
		case 97:
			if (CurIndex == 0)
			{
				Emit(34);
				PushInt(CurPos());
				Emit(23, 0);
				Emit(37, MapCapnum(node._m));
				Emit(36);
			}
			break;
		case 161:
			switch (CurIndex)
			{
			case 0:
			{
				int offset3 = PopInt();
				PushInt(CurPos());
				Emit(38, 0);
				PatchJump(offset3, CurPos());
				Emit(36);
				if (node._children.Count > 1)
				{
					break;
				}
				goto case 1;
			}
			case 1:
				PatchJump(PopInt(), CurPos());
				break;
			}
			break;
		case 98:
			if (CurIndex == 0)
			{
				Emit(34);
				Emit(31);
				PushInt(CurPos());
				Emit(23, 0);
			}
			break;
		case 162:
			switch (CurIndex)
			{
			case 0:
				Emit(33);
				Emit(36);
				break;
			case 1:
			{
				int offset2 = PopInt();
				PushInt(CurPos());
				Emit(38, 0);
				PatchJump(offset2, CurPos());
				Emit(33);
				Emit(36);
				if (node._children.Count > 2)
				{
					break;
				}
				goto case 2;
			}
			case 2:
				PatchJump(PopInt(), CurPos());
				break;
			}
			break;
		case 90:
		case 91:
			if (node._n < int.MaxValue || node._m > 1)
			{
				Emit((node._m == 0) ? 26 : 27, (node._m != 0) ? (1 - node._m) : 0);
			}
			else
			{
				Emit((node._m == 0) ? 30 : 31);
			}
			if (node._m == 0)
			{
				PushInt(CurPos());
				Emit(38, 0);
			}
			PushInt(CurPos());
			break;
		case 154:
		case 155:
		{
			int jumpDest = CurPos();
			int num2 = nodetype - 154;
			if (node._n < int.MaxValue || node._m > 1)
			{
				Emit(28 + num2, PopInt(), (node._n == int.MaxValue) ? int.MaxValue : (node._n - node._m));
			}
			else
			{
				Emit(24 + num2, PopInt());
			}
			if (node._m == 0)
			{
				PatchJump(PopInt(), jumpDest);
			}
			break;
		}
		case 92:
			Emit(31);
			break;
		case 156:
			Emit(32, MapCapnum(node._m), MapCapnum(node._n));
			break;
		case 94:
			Emit(34);
			Emit(31);
			break;
		case 158:
			Emit(33);
			Emit(36);
			break;
		case 95:
			Emit(34);
			PushInt(CurPos());
			Emit(23, 0);
			break;
		case 159:
			Emit(35);
			PatchJump(PopInt(), CurPos());
			Emit(36);
			break;
		case 96:
			Emit(34);
			break;
		case 160:
			Emit(36);
			break;
		case 9:
		case 10:
			Emit(node._type | num, node._ch);
			break;
		case 3:
		case 4:
		case 6:
		case 7:
			if (node._m > 0)
			{
				Emit(((node._type != 3 && node._type != 6) ? 1 : 0) | num, node._ch, node._m);
			}
			if (node._n > node._m)
			{
				Emit(node._type | num, node._ch, (node._n == int.MaxValue) ? int.MaxValue : (node._n - node._m));
			}
			break;
		case 5:
		case 8:
			if (node._m > 0)
			{
				Emit(2 | num, StringCode(node._str), node._m);
			}
			if (node._n > node._m)
			{
				Emit(node._type | num, StringCode(node._str), (node._n == int.MaxValue) ? int.MaxValue : (node._n - node._m));
			}
			break;
		case 12:
			Emit(node._type | num, StringCode(node._str));
			break;
		case 11:
			Emit(node._type | num, StringCode(node._str));
			break;
		case 13:
			Emit(node._type | num, MapCapnum(node._m));
			break;
		case 14:
		case 15:
		case 16:
		case 17:
		case 18:
		case 19:
		case 20:
		case 21:
		case 22:
		case 41:
		case 42:
			Emit(node._type);
			break;
		default:
			throw MakeException(SR.GetString("UnexpectedOpcode", nodetype.ToString(CultureInfo.CurrentCulture)));
		case 23:
		case 89:
		case 93:
		case 153:
		case 157:
			break;
		}
	}
}
