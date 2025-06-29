using System.Globalization;

namespace System.Text.RegularExpressions;

internal sealed class RegexFCD
{
	private int[] _intStack;

	private int _intDepth;

	private RegexFC[] _fcStack;

	private int _fcDepth;

	private bool _skipAllChildren;

	private bool _skipchild;

	private bool _failed;

	private const int BeforeChild = 64;

	private const int AfterChild = 128;

	internal const int Beginning = 1;

	internal const int Bol = 2;

	internal const int Start = 4;

	internal const int Eol = 8;

	internal const int EndZ = 16;

	internal const int End = 32;

	internal const int Boundary = 64;

	internal const int ECMABoundary = 128;

	internal static RegexPrefix FirstChars(RegexTree t)
	{
		RegexFCD regexFCD = new RegexFCD();
		RegexFC regexFC = regexFCD.RegexFCFromRegexTree(t);
		if (regexFC == null || regexFC._nullable)
		{
			return null;
		}
		CultureInfo culture = (((t._options & RegexOptions.CultureInvariant) != RegexOptions.None) ? CultureInfo.InvariantCulture : CultureInfo.CurrentCulture);
		return new RegexPrefix(regexFC.GetFirstChars(culture), regexFC.IsCaseInsensitive());
	}

	internal static RegexPrefix Prefix(RegexTree tree)
	{
		RegexNode regexNode = null;
		int num = 0;
		RegexNode regexNode2 = tree._root;
		while (true)
		{
			switch (regexNode2._type)
			{
			case 25:
				if (regexNode2.ChildCount() > 0)
				{
					regexNode = regexNode2;
					num = 0;
				}
				break;
			case 28:
			case 32:
				regexNode2 = regexNode2.Child(0);
				regexNode = null;
				continue;
			case 3:
			case 6:
				if (regexNode2._m > 0)
				{
					string prefix = string.Empty.PadRight(regexNode2._m, regexNode2._ch);
					return new RegexPrefix(prefix, (regexNode2._options & RegexOptions.IgnoreCase) != 0);
				}
				return RegexPrefix.Empty;
			case 9:
				return new RegexPrefix(regexNode2._ch.ToString(CultureInfo.InvariantCulture), (regexNode2._options & RegexOptions.IgnoreCase) != 0);
			case 12:
				return new RegexPrefix(regexNode2._str, (regexNode2._options & RegexOptions.IgnoreCase) != 0);
			default:
				return RegexPrefix.Empty;
			case 14:
			case 15:
			case 16:
			case 18:
			case 19:
			case 20:
			case 21:
			case 23:
			case 30:
			case 31:
			case 41:
				break;
			}
			if (regexNode == null || num >= regexNode.ChildCount())
			{
				break;
			}
			regexNode2 = regexNode.Child(num++);
		}
		return RegexPrefix.Empty;
	}

	internal static int Anchors(RegexTree tree)
	{
		RegexNode regexNode = null;
		int num = 0;
		int num2 = 0;
		RegexNode regexNode2 = tree._root;
		while (true)
		{
			switch (regexNode2._type)
			{
			case 25:
				if (regexNode2.ChildCount() > 0)
				{
					regexNode = regexNode2;
					num = 0;
				}
				break;
			case 28:
			case 32:
				regexNode2 = regexNode2.Child(0);
				regexNode = null;
				continue;
			case 14:
			case 15:
			case 16:
			case 18:
			case 19:
			case 20:
			case 21:
			case 41:
				return num2 | AnchorFromType(regexNode2._type);
			default:
				return num2;
			case 23:
			case 30:
			case 31:
				break;
			}
			if (regexNode == null || num >= regexNode.ChildCount())
			{
				break;
			}
			regexNode2 = regexNode.Child(num++);
		}
		return num2;
	}

	private static int AnchorFromType(int type)
	{
		return type switch
		{
			14 => 2, 
			15 => 8, 
			16 => 64, 
			41 => 128, 
			18 => 1, 
			19 => 4, 
			20 => 16, 
			21 => 32, 
			_ => 0, 
		};
	}

	private RegexFCD()
	{
		_fcStack = new RegexFC[32];
		_intStack = new int[32];
	}

	private void PushInt(int I)
	{
		if (_intDepth >= _intStack.Length)
		{
			int[] array = new int[_intDepth * 2];
			Array.Copy(_intStack, 0, array, 0, _intDepth);
			_intStack = array;
		}
		_intStack[_intDepth++] = I;
	}

	private bool IntIsEmpty()
	{
		return _intDepth == 0;
	}

	private int PopInt()
	{
		return _intStack[--_intDepth];
	}

	private void PushFC(RegexFC fc)
	{
		if (_fcDepth >= _fcStack.Length)
		{
			RegexFC[] array = new RegexFC[_fcDepth * 2];
			Array.Copy(_fcStack, 0, array, 0, _fcDepth);
			_fcStack = array;
		}
		_fcStack[_fcDepth++] = fc;
	}

	private bool FCIsEmpty()
	{
		return _fcDepth == 0;
	}

	private RegexFC PopFC()
	{
		return _fcStack[--_fcDepth];
	}

	private RegexFC TopFC()
	{
		return _fcStack[_fcDepth - 1];
	}

	private RegexFC RegexFCFromRegexTree(RegexTree tree)
	{
		RegexNode regexNode = tree._root;
		int num = 0;
		while (true)
		{
			if (regexNode._children == null)
			{
				CalculateFC(regexNode._type, regexNode, 0);
			}
			else if (num < regexNode._children.Count && !_skipAllChildren)
			{
				CalculateFC(regexNode._type | 0x40, regexNode, num);
				if (!_skipchild)
				{
					regexNode = regexNode._children[num];
					PushInt(num);
					num = 0;
				}
				else
				{
					num++;
					_skipchild = false;
				}
				continue;
			}
			_skipAllChildren = false;
			if (IntIsEmpty())
			{
				break;
			}
			num = PopInt();
			regexNode = regexNode._next;
			CalculateFC(regexNode._type | 0x80, regexNode, num);
			if (_failed)
			{
				return null;
			}
			num++;
		}
		if (FCIsEmpty())
		{
			return null;
		}
		return PopFC();
	}

	private void SkipChild()
	{
		_skipchild = true;
	}

	private void CalculateFC(int NodeType, RegexNode node, int CurIndex)
	{
		bool caseInsensitive = false;
		bool flag = false;
		if (NodeType <= 13)
		{
			if ((node._options & RegexOptions.IgnoreCase) != RegexOptions.None)
			{
				caseInsensitive = true;
			}
			if ((node._options & RegexOptions.RightToLeft) != RegexOptions.None)
			{
				flag = true;
			}
		}
		switch (NodeType)
		{
		case 98:
			if (CurIndex == 0)
			{
				SkipChild();
			}
			break;
		case 23:
			PushFC(new RegexFC(nullable: true));
			break;
		case 153:
			if (CurIndex != 0)
			{
				RegexFC fc3 = PopFC();
				RegexFC regexFC3 = TopFC();
				_failed = !regexFC3.AddFC(fc3, concatenate: true);
			}
			if (!TopFC()._nullable)
			{
				_skipAllChildren = true;
			}
			break;
		case 162:
			if (CurIndex > 1)
			{
				RegexFC fc2 = PopFC();
				RegexFC regexFC2 = TopFC();
				_failed = !regexFC2.AddFC(fc2, concatenate: false);
			}
			break;
		case 152:
		case 161:
			if (CurIndex != 0)
			{
				RegexFC fc = PopFC();
				RegexFC regexFC = TopFC();
				_failed = !regexFC.AddFC(fc, concatenate: false);
			}
			break;
		case 154:
		case 155:
			if (node._m == 0)
			{
				TopFC()._nullable = true;
			}
			break;
		case 94:
		case 95:
			SkipChild();
			PushFC(new RegexFC(nullable: true));
			break;
		case 9:
		case 10:
			PushFC(new RegexFC(node._ch, NodeType == 10, nullable: false, caseInsensitive));
			break;
		case 3:
		case 6:
			PushFC(new RegexFC(node._ch, not: false, node._m == 0, caseInsensitive));
			break;
		case 4:
		case 7:
			PushFC(new RegexFC(node._ch, not: true, node._m == 0, caseInsensitive));
			break;
		case 12:
			if (node._str.Length == 0)
			{
				PushFC(new RegexFC(nullable: true));
			}
			else if (!flag)
			{
				PushFC(new RegexFC(node._str[0], not: false, nullable: false, caseInsensitive));
			}
			else
			{
				PushFC(new RegexFC(node._str[node._str.Length - 1], not: false, nullable: false, caseInsensitive));
			}
			break;
		case 11:
			PushFC(new RegexFC(node._str, nullable: false, caseInsensitive));
			break;
		case 5:
		case 8:
			PushFC(new RegexFC(node._str, node._m == 0, caseInsensitive));
			break;
		case 13:
			PushFC(new RegexFC("\0\u0001\0\0", nullable: true, caseInsensitive: false));
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
			PushFC(new RegexFC(nullable: true));
			break;
		default:
			throw new ArgumentException(SR.GetString("UnexpectedOpcode", NodeType.ToString(CultureInfo.CurrentCulture)));
		case 88:
		case 89:
		case 90:
		case 91:
		case 92:
		case 93:
		case 96:
		case 97:
		case 156:
		case 157:
		case 158:
		case 159:
		case 160:
			break;
		}
	}
}
