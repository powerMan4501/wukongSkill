using System.Globalization;

namespace System.Text.RegularExpressions;

internal sealed class RegexInterpreter : RegexRunner
{
	internal int runoperator;

	internal int[] runcodes;

	internal int runcodepos;

	internal string[] runstrings;

	internal RegexCode runcode;

	internal RegexPrefix runfcPrefix;

	internal RegexBoyerMoore runbmPrefix;

	internal int runanchors;

	internal bool runrtl;

	internal bool runci;

	internal CultureInfo runculture;

	private const int LoopTimeoutCheckCount = 2000;

	private static readonly bool UseLegacyTimeoutCheck = System.LocalAppContextSwitches.UseLegacyTimeoutCheck;

	internal RegexInterpreter(RegexCode code, CultureInfo culture)
	{
		runcode = code;
		runcodes = code._codes;
		runstrings = code._strings;
		runfcPrefix = code._fcPrefix;
		runbmPrefix = code._bmPrefix;
		runanchors = code._anchors;
		runculture = culture;
	}

	protected override void InitTrackCount()
	{
		runtrackcount = runcode._trackcount;
	}

	private void Advance()
	{
		Advance(0);
	}

	private void Advance(int i)
	{
		runcodepos += i + 1;
		SetOperator(runcodes[runcodepos]);
	}

	private void Goto(int newpos)
	{
		if (newpos < runcodepos)
		{
			EnsureStorage();
		}
		SetOperator(runcodes[newpos]);
		runcodepos = newpos;
	}

	private void Textto(int newpos)
	{
		runtextpos = newpos;
	}

	private void Trackto(int newpos)
	{
		runtrackpos = runtrack.Length - newpos;
	}

	private int Textstart()
	{
		return runtextstart;
	}

	private int Textpos()
	{
		return runtextpos;
	}

	private int Trackpos()
	{
		return runtrack.Length - runtrackpos;
	}

	private void TrackPush()
	{
		runtrack[--runtrackpos] = runcodepos;
	}

	private void TrackPush(int I1)
	{
		runtrack[--runtrackpos] = I1;
		runtrack[--runtrackpos] = runcodepos;
	}

	private void TrackPush(int I1, int I2)
	{
		runtrack[--runtrackpos] = I1;
		runtrack[--runtrackpos] = I2;
		runtrack[--runtrackpos] = runcodepos;
	}

	private void TrackPush(int I1, int I2, int I3)
	{
		runtrack[--runtrackpos] = I1;
		runtrack[--runtrackpos] = I2;
		runtrack[--runtrackpos] = I3;
		runtrack[--runtrackpos] = runcodepos;
	}

	private void TrackPush2(int I1)
	{
		runtrack[--runtrackpos] = I1;
		runtrack[--runtrackpos] = -runcodepos;
	}

	private void TrackPush2(int I1, int I2)
	{
		runtrack[--runtrackpos] = I1;
		runtrack[--runtrackpos] = I2;
		runtrack[--runtrackpos] = -runcodepos;
	}

	private void Backtrack()
	{
		int num = runtrack[runtrackpos++];
		if (num < 0)
		{
			num = -num;
			SetOperator(runcodes[num] | 0x100);
		}
		else
		{
			SetOperator(runcodes[num] | 0x80);
		}
		if (num < runcodepos)
		{
			EnsureStorage();
		}
		runcodepos = num;
	}

	private void SetOperator(int op)
	{
		runci = (op & 0x200) != 0;
		runrtl = (op & 0x40) != 0;
		runoperator = op & -577;
	}

	private void TrackPop()
	{
		runtrackpos++;
	}

	private void TrackPop(int framesize)
	{
		runtrackpos += framesize;
	}

	private int TrackPeek()
	{
		return runtrack[runtrackpos - 1];
	}

	private int TrackPeek(int i)
	{
		return runtrack[runtrackpos - i - 1];
	}

	private void StackPush(int I1)
	{
		runstack[--runstackpos] = I1;
	}

	private void StackPush(int I1, int I2)
	{
		runstack[--runstackpos] = I1;
		runstack[--runstackpos] = I2;
	}

	private void StackPop()
	{
		runstackpos++;
	}

	private void StackPop(int framesize)
	{
		runstackpos += framesize;
	}

	private int StackPeek()
	{
		return runstack[runstackpos - 1];
	}

	private int StackPeek(int i)
	{
		return runstack[runstackpos - i - 1];
	}

	private int Operator()
	{
		return runoperator;
	}

	private int Operand(int i)
	{
		return runcodes[runcodepos + i + 1];
	}

	private int Leftchars()
	{
		return runtextpos - runtextbeg;
	}

	private int Rightchars()
	{
		return runtextend - runtextpos;
	}

	private int Bump()
	{
		if (!runrtl)
		{
			return 1;
		}
		return -1;
	}

	private int Forwardchars()
	{
		if (!runrtl)
		{
			return runtextend - runtextpos;
		}
		return runtextpos - runtextbeg;
	}

	private char Forwardcharnext()
	{
		char c = (runrtl ? runtext[--runtextpos] : runtext[runtextpos++]);
		if (!runci)
		{
			return c;
		}
		return char.ToLower(c, runculture);
	}

	private bool Stringmatch(string str)
	{
		int num;
		int num2;
		if (!runrtl)
		{
			if (runtextend - runtextpos < (num = str.Length))
			{
				return false;
			}
			num2 = runtextpos + num;
		}
		else
		{
			if (runtextpos - runtextbeg < (num = str.Length))
			{
				return false;
			}
			num2 = runtextpos;
		}
		if (!runci)
		{
			while (num != 0)
			{
				if (str[--num] != runtext[--num2])
				{
					return false;
				}
			}
		}
		else
		{
			while (num != 0)
			{
				if (str[--num] != char.ToLower(runtext[--num2], runculture))
				{
					return false;
				}
			}
		}
		if (!runrtl)
		{
			num2 += str.Length;
		}
		runtextpos = num2;
		return true;
	}

	private bool Refmatch(int index, int len)
	{
		int num;
		if (!runrtl)
		{
			if (runtextend - runtextpos < len)
			{
				return false;
			}
			num = runtextpos + len;
		}
		else
		{
			if (runtextpos - runtextbeg < len)
			{
				return false;
			}
			num = runtextpos;
		}
		int num2 = index + len;
		int num3 = len;
		if (!runci)
		{
			while (num3-- != 0)
			{
				if (runtext[--num2] != runtext[--num])
				{
					return false;
				}
			}
		}
		else
		{
			while (num3-- != 0)
			{
				if (char.ToLower(runtext[--num2], runculture) != char.ToLower(runtext[--num], runculture))
				{
					return false;
				}
			}
		}
		if (!runrtl)
		{
			num += len;
		}
		runtextpos = num;
		return true;
	}

	private void Backwardnext()
	{
		runtextpos += (runrtl ? 1 : (-1));
	}

	private char CharAt(int j)
	{
		return runtext[j];
	}

	protected override bool FindFirstChar()
	{
		if ((runanchors & 0x35) != 0)
		{
			if (!runcode._rightToLeft)
			{
				if (((runanchors & 1) != 0 && runtextpos > runtextbeg) || ((runanchors & 4) != 0 && runtextpos > runtextstart))
				{
					runtextpos = runtextend;
					return false;
				}
				if ((runanchors & 0x10) != 0 && runtextpos < runtextend - 1)
				{
					runtextpos = runtextend - 1;
				}
				else if ((runanchors & 0x20) != 0 && runtextpos < runtextend)
				{
					runtextpos = runtextend;
				}
			}
			else
			{
				if (((runanchors & 0x20) != 0 && runtextpos < runtextend) || ((runanchors & 0x10) != 0 && (runtextpos < runtextend - 1 || (runtextpos == runtextend - 1 && CharAt(runtextpos) != '\n'))) || ((runanchors & 4) != 0 && runtextpos < runtextstart))
				{
					runtextpos = runtextbeg;
					return false;
				}
				if ((runanchors & 1) != 0 && runtextpos > runtextbeg)
				{
					runtextpos = runtextbeg;
				}
			}
			if (runbmPrefix != null)
			{
				return runbmPrefix.IsMatch(runtext, runtextpos, runtextbeg, runtextend);
			}
			return true;
		}
		if (runbmPrefix != null)
		{
			runtextpos = runbmPrefix.Scan(runtext, runtextpos, runtextbeg, runtextend);
			if (runtextpos == -1)
			{
				runtextpos = (runcode._rightToLeft ? runtextbeg : runtextend);
				return false;
			}
			return true;
		}
		if (runfcPrefix == null)
		{
			return true;
		}
		runrtl = runcode._rightToLeft;
		runci = runfcPrefix.CaseInsensitive;
		string prefix = runfcPrefix.Prefix;
		if (RegexCharClass.IsSingleton(prefix))
		{
			char c = RegexCharClass.SingletonChar(prefix);
			for (int num = Forwardchars(); num > 0; num--)
			{
				if (c == Forwardcharnext())
				{
					Backwardnext();
					return true;
				}
			}
		}
		else
		{
			for (int num = Forwardchars(); num > 0; num--)
			{
				if (RegexCharClass.CharInClass(Forwardcharnext(), prefix))
				{
					Backwardnext();
					return true;
				}
			}
		}
		return false;
	}

	protected override void Go()
	{
		Goto(0);
		while (true)
		{
			CheckTimeout();
			switch (Operator())
			{
			case 40:
				return;
			case 38:
				Goto(Operand(0));
				continue;
			case 37:
				if (IsMatched(Operand(0)))
				{
					Advance(1);
					continue;
				}
				break;
			case 23:
				TrackPush(Textpos());
				Advance(1);
				continue;
			case 151:
				TrackPop();
				Textto(TrackPeek());
				Goto(Operand(0));
				continue;
			case 31:
				StackPush(Textpos());
				TrackPush();
				Advance();
				continue;
			case 30:
				StackPush(-1);
				TrackPush();
				Advance();
				continue;
			case 158:
			case 159:
				StackPop();
				break;
			case 33:
				StackPop();
				TrackPush(StackPeek());
				Textto(StackPeek());
				Advance();
				continue;
			case 161:
				TrackPop();
				StackPush(TrackPeek());
				break;
			case 32:
				if (Operand(1) == -1 || IsMatched(Operand(1)))
				{
					StackPop();
					if (Operand(1) != -1)
					{
						TransferCapture(Operand(0), Operand(1), StackPeek(), Textpos());
					}
					else
					{
						Capture(Operand(0), StackPeek(), Textpos());
					}
					TrackPush(StackPeek());
					Advance(2);
					continue;
				}
				break;
			case 160:
				TrackPop();
				StackPush(TrackPeek());
				Uncapture();
				if (Operand(0) != -1 && Operand(1) != -1)
				{
					Uncapture();
				}
				break;
			case 24:
				StackPop();
				if (Textpos() - StackPeek() != 0)
				{
					TrackPush(StackPeek(), Textpos());
					StackPush(Textpos());
					Goto(Operand(0));
				}
				else
				{
					TrackPush2(StackPeek());
					Advance(1);
				}
				continue;
			case 152:
				TrackPop(2);
				StackPop();
				Textto(TrackPeek(1));
				TrackPush2(TrackPeek());
				Advance(1);
				continue;
			case 280:
				TrackPop();
				StackPush(TrackPeek());
				break;
			case 25:
			{
				StackPop();
				int num27 = StackPeek();
				if (Textpos() != num27)
				{
					if (num27 != -1)
					{
						TrackPush(num27, Textpos());
					}
					else
					{
						TrackPush(Textpos(), Textpos());
					}
				}
				else
				{
					StackPush(num27);
					TrackPush2(StackPeek());
				}
				Advance(1);
				continue;
			}
			case 153:
			{
				TrackPop(2);
				int num25 = TrackPeek(1);
				TrackPush2(TrackPeek());
				StackPush(num25);
				Textto(num25);
				Goto(Operand(0));
				continue;
			}
			case 281:
				StackPop();
				TrackPop();
				StackPush(TrackPeek());
				break;
			case 27:
				StackPush(Textpos(), Operand(0));
				TrackPush();
				Advance(1);
				continue;
			case 26:
				StackPush(-1, Operand(0));
				TrackPush();
				Advance(1);
				continue;
			case 155:
				StackPop(2);
				break;
			case 154:
				StackPop(2);
				break;
			case 28:
			{
				StackPop(2);
				int num16 = StackPeek();
				int num17 = StackPeek(1);
				int num18 = Textpos() - num16;
				if (num17 >= Operand(1) || (num18 == 0 && num17 >= 0))
				{
					TrackPush2(num16, num17);
					Advance(2);
				}
				else
				{
					TrackPush(num16);
					StackPush(Textpos(), num17 + 1);
					Goto(Operand(0));
				}
				continue;
			}
			case 156:
				TrackPop();
				StackPop(2);
				if (StackPeek(1) > 0)
				{
					Textto(StackPeek());
					TrackPush2(TrackPeek(), StackPeek(1) - 1);
					Advance(2);
					continue;
				}
				StackPush(TrackPeek(), StackPeek(1) - 1);
				break;
			case 284:
				TrackPop(2);
				StackPush(TrackPeek(), TrackPeek(1));
				break;
			case 29:
			{
				StackPop(2);
				int i = StackPeek();
				int num9 = StackPeek(1);
				if (num9 < 0)
				{
					TrackPush2(i);
					StackPush(Textpos(), num9 + 1);
					Goto(Operand(0));
				}
				else
				{
					TrackPush(i, num9, Textpos());
					Advance(2);
				}
				continue;
			}
			case 157:
			{
				TrackPop(3);
				int num5 = TrackPeek();
				int num6 = TrackPeek(2);
				if (TrackPeek(1) < Operand(1) && num6 != num5)
				{
					Textto(num6);
					StackPush(num6, TrackPeek(1) + 1);
					TrackPush2(num5);
					Goto(Operand(0));
					continue;
				}
				StackPush(TrackPeek(), TrackPeek(1));
				break;
			}
			case 285:
				TrackPop();
				StackPop(2);
				StackPush(TrackPeek(), StackPeek(1) - 1);
				break;
			case 34:
				StackPush(Trackpos(), Crawlpos());
				TrackPush();
				Advance();
				continue;
			case 162:
				StackPop(2);
				break;
			case 35:
				StackPop(2);
				Trackto(StackPeek());
				while (Crawlpos() != StackPeek(1))
				{
					Uncapture();
				}
				break;
			case 36:
				StackPop(2);
				Trackto(StackPeek());
				TrackPush(StackPeek(1));
				Advance();
				continue;
			case 164:
				TrackPop();
				while (Crawlpos() != TrackPeek())
				{
					Uncapture();
				}
				break;
			case 14:
				if (Leftchars() <= 0 || CharAt(Textpos() - 1) == '\n')
				{
					Advance();
					continue;
				}
				break;
			case 15:
				if (Rightchars() <= 0 || CharAt(Textpos()) == '\n')
				{
					Advance();
					continue;
				}
				break;
			case 16:
				if (IsBoundary(Textpos(), runtextbeg, runtextend))
				{
					Advance();
					continue;
				}
				break;
			case 17:
				if (!IsBoundary(Textpos(), runtextbeg, runtextend))
				{
					Advance();
					continue;
				}
				break;
			case 41:
				if (IsECMABoundary(Textpos(), runtextbeg, runtextend))
				{
					Advance();
					continue;
				}
				break;
			case 42:
				if (!IsECMABoundary(Textpos(), runtextbeg, runtextend))
				{
					Advance();
					continue;
				}
				break;
			case 18:
				if (Leftchars() <= 0)
				{
					Advance();
					continue;
				}
				break;
			case 19:
				if (Textpos() == Textstart())
				{
					Advance();
					continue;
				}
				break;
			case 20:
				if (Rightchars() <= 1 && (Rightchars() != 1 || CharAt(Textpos()) == '\n'))
				{
					Advance();
					continue;
				}
				break;
			case 21:
				if (Rightchars() <= 0)
				{
					Advance();
					continue;
				}
				break;
			case 9:
				if (Forwardchars() >= 1 && Forwardcharnext() == (ushort)Operand(0))
				{
					Advance(1);
					continue;
				}
				break;
			case 10:
				if (Forwardchars() >= 1 && Forwardcharnext() != (ushort)Operand(0))
				{
					Advance(1);
					continue;
				}
				break;
			case 11:
				if (Forwardchars() >= 1 && RegexCharClass.CharInClass(Forwardcharnext(), runstrings[Operand(0)]))
				{
					Advance(1);
					continue;
				}
				break;
			case 12:
				if (Stringmatch(runstrings[Operand(0)]))
				{
					Advance(1);
					continue;
				}
				break;
			case 13:
			{
				int cap = Operand(0);
				if (IsMatched(cap))
				{
					if (!Refmatch(MatchIndex(cap), MatchLength(cap)))
					{
						break;
					}
				}
				else if ((runregex.roptions & RegexOptions.ECMAScript) == 0)
				{
					break;
				}
				Advance(1);
				continue;
			}
			case 0:
			{
				int num29 = Operand(1);
				if (Forwardchars() < num29)
				{
					break;
				}
				char c4 = (char)Operand(0);
				while (num29-- > 0)
				{
					if (Forwardcharnext() != c4)
					{
						goto end_IL_0015;
					}
				}
				Advance(2);
				continue;
			}
			case 1:
			{
				int num28 = Operand(1);
				if (Forwardchars() < num28)
				{
					break;
				}
				char c3 = (char)Operand(0);
				while (num28-- > 0)
				{
					if (Forwardcharnext() == c3)
					{
						goto end_IL_0015;
					}
				}
				Advance(2);
				continue;
			}
			case 2:
			{
				int num26 = Operand(1);
				if (Forwardchars() < num26)
				{
					break;
				}
				string set2 = runstrings[Operand(0)];
				while (num26-- > 0)
				{
					if (!UseLegacyTimeoutCheck && num26 % 2000 == 0)
					{
						CheckTimeout();
					}
					if (!RegexCharClass.CharInClass(Forwardcharnext(), set2))
					{
						goto end_IL_0015;
					}
				}
				Advance(2);
				continue;
			}
			case 3:
			{
				int num23 = Operand(1);
				if (num23 > Forwardchars())
				{
					num23 = Forwardchars();
				}
				char c2 = (char)Operand(0);
				int num24;
				for (num24 = num23; num24 > 0; num24--)
				{
					if (Forwardcharnext() != c2)
					{
						Backwardnext();
						break;
					}
				}
				if (num23 > num24)
				{
					TrackPush(num23 - num24 - 1, Textpos() - Bump());
				}
				Advance(2);
				continue;
			}
			case 4:
			{
				int num21 = Operand(1);
				if (num21 > Forwardchars())
				{
					num21 = Forwardchars();
				}
				char c = (char)Operand(0);
				int num22;
				for (num22 = num21; num22 > 0; num22--)
				{
					if (Forwardcharnext() == c)
					{
						Backwardnext();
						break;
					}
				}
				if (num21 > num22)
				{
					TrackPush(num21 - num22 - 1, Textpos() - Bump());
				}
				Advance(2);
				continue;
			}
			case 5:
			{
				int num19 = Operand(1);
				if (num19 > Forwardchars())
				{
					num19 = Forwardchars();
				}
				string set = runstrings[Operand(0)];
				int num20;
				for (num20 = num19; num20 > 0; num20--)
				{
					if (!UseLegacyTimeoutCheck && num20 % 2000 == 0)
					{
						CheckTimeout();
					}
					if (!RegexCharClass.CharInClass(Forwardcharnext(), set))
					{
						Backwardnext();
						break;
					}
				}
				if (num19 > num20)
				{
					TrackPush(num19 - num20 - 1, Textpos() - Bump());
				}
				Advance(2);
				continue;
			}
			case 131:
			case 132:
			{
				TrackPop(2);
				int num14 = TrackPeek();
				int num15 = TrackPeek(1);
				Textto(num15);
				if (num14 > 0)
				{
					TrackPush(num14 - 1, num15 - Bump());
				}
				Advance(2);
				continue;
			}
			case 133:
			{
				TrackPop(2);
				int num12 = TrackPeek();
				int num13 = TrackPeek(1);
				Textto(num13);
				if (num12 > 0)
				{
					TrackPush(num12 - 1, num13 - Bump());
				}
				Advance(2);
				continue;
			}
			case 6:
			case 7:
			{
				int num11 = Operand(1);
				if (num11 > Forwardchars())
				{
					num11 = Forwardchars();
				}
				if (num11 > 0)
				{
					TrackPush(num11 - 1, Textpos());
				}
				Advance(2);
				continue;
			}
			case 8:
			{
				int num10 = Operand(1);
				if (num10 > Forwardchars())
				{
					num10 = Forwardchars();
				}
				if (num10 > 0)
				{
					TrackPush(num10 - 1, Textpos());
				}
				Advance(2);
				continue;
			}
			case 134:
			{
				TrackPop(2);
				int num7 = TrackPeek(1);
				Textto(num7);
				if (Forwardcharnext() == (ushort)Operand(0))
				{
					int num8 = TrackPeek();
					if (num8 > 0)
					{
						TrackPush(num8 - 1, num7 + Bump());
					}
					Advance(2);
					continue;
				}
				break;
			}
			case 135:
			{
				TrackPop(2);
				int num3 = TrackPeek(1);
				Textto(num3);
				if (Forwardcharnext() != (ushort)Operand(0))
				{
					int num4 = TrackPeek();
					if (num4 > 0)
					{
						TrackPush(num4 - 1, num3 + Bump());
					}
					Advance(2);
					continue;
				}
				break;
			}
			case 136:
			{
				TrackPop(2);
				int num = TrackPeek(1);
				Textto(num);
				if (RegexCharClass.CharInClass(Forwardcharnext(), runstrings[Operand(0)]))
				{
					int num2 = TrackPeek();
					if (num2 > 0)
					{
						TrackPush(num2 - 1, num + Bump());
					}
					Advance(2);
					continue;
				}
				break;
			}
			default:
				throw new NotImplementedException(SR.GetString("UnimplementedState"));
			case 22:
				break;
				end_IL_0015:
				break;
			}
			Backtrack();
		}
	}
}
