using System.Collections.Generic;
using System.Globalization;

namespace System.Text.RegularExpressions;

internal sealed class RegexCharClass
{
	private struct LowerCaseMapping
	{
		internal char _chMin;

		internal char _chMax;

		internal int _lcOp;

		internal int _data;

		internal LowerCaseMapping(char chMin, char chMax, int lcOp, int data)
		{
			_chMin = chMin;
			_chMax = chMax;
			_lcOp = lcOp;
			_data = data;
		}
	}

	private sealed class SingleRangeComparer : IComparer<SingleRange>
	{
		public int Compare(SingleRange x, SingleRange y)
		{
			if (x._first >= y._first)
			{
				if (x._first <= y._first)
				{
					return 0;
				}
				return 1;
			}
			return -1;
		}
	}

	private sealed class SingleRange
	{
		internal char _first;

		internal char _last;

		internal SingleRange(char first, char last)
		{
			_first = first;
			_last = last;
		}
	}

	private List<SingleRange> _rangelist;

	private StringBuilder _categories;

	private bool _canonical;

	private bool _negate;

	private RegexCharClass _subtractor;

	private const int FLAGS = 0;

	private const int SETLENGTH = 1;

	private const int CATEGORYLENGTH = 2;

	private const int SETSTART = 3;

	private const char Nullchar = '\0';

	private const char Lastchar = '\uffff';

	private const char GroupChar = '\0';

	private const short SpaceConst = 100;

	private const short NotSpaceConst = -100;

	private const char ZeroWidthJoiner = '\u200d';

	private const char ZeroWidthNonJoiner = '\u200c';

	private static readonly string InternalRegexIgnoreCase;

	private static readonly string Space;

	private static readonly string NotSpace;

	private static readonly string Word;

	private static readonly string NotWord;

	internal static readonly string SpaceClass;

	internal static readonly string NotSpaceClass;

	internal static readonly string WordClass;

	internal static readonly string NotWordClass;

	internal static readonly string DigitClass;

	internal static readonly string NotDigitClass;

	private const string ECMASpaceSet = "\t\u000e !";

	private const string NotECMASpaceSet = "\0\t\u000e !";

	private const string ECMAWordSet = "0:A[_`a{İı";

	private const string NotECMAWordSet = "\00:A[_`a{İı";

	private const string ECMADigitSet = "0:";

	private const string NotECMADigitSet = "\00:";

	internal const string ECMASpaceClass = "\0\u0004\0\t\u000e !";

	internal const string NotECMASpaceClass = "\u0001\u0004\0\t\u000e !";

	internal const string ECMAWordClass = "\0\n\00:A[_`a{İı";

	internal const string NotECMAWordClass = "\u0001\n\00:A[_`a{İı";

	internal const string ECMADigitClass = "\0\u0002\00:";

	internal const string NotECMADigitClass = "\u0001\u0002\00:";

	internal const string AnyClass = "\0\u0001\0\0";

	internal const string EmptyClass = "\0\0\0";

	private static Dictionary<string, string> _definedCategories;

	private static readonly string[,] _propTable;

	private const int LowercaseSet = 0;

	private const int LowercaseAdd = 1;

	private const int LowercaseBor = 2;

	private const int LowercaseBad = 3;

	private static readonly LowerCaseMapping[] _lcTable;

	internal bool CanMerge
	{
		get
		{
			if (!_negate)
			{
				return _subtractor == null;
			}
			return false;
		}
	}

	internal bool Negate
	{
		set
		{
			_negate = value;
		}
	}

	static RegexCharClass()
	{
		InternalRegexIgnoreCase = "__InternalRegexIgnoreCase__";
		Space = "d";
		NotSpace = NegateCategory(Space);
		_propTable = new string[112, 2]
		{
			{ "IsAlphabeticPresentationForms", "ﬀﭐ" },
			{ "IsArabic", "\u0600܀" },
			{ "IsArabicPresentationForms-A", "ﭐ\ufe00" },
			{ "IsArabicPresentationForms-B", "ﹰ\uff00" },
			{ "IsArmenian", "\u0530\u0590" },
			{ "IsArrows", "←∀" },
			{ "IsBasicLatin", "\0\u0080" },
			{ "IsBengali", "ঀ\u0a00" },
			{ "IsBlockElements", "▀■" },
			{ "IsBopomofo", "\u3100\u3130" },
			{ "IsBopomofoExtended", "ㆠ㇀" },
			{ "IsBoxDrawing", "─▀" },
			{ "IsBraillePatterns", "⠀⤀" },
			{ "IsBuhid", "ᝀᝠ" },
			{ "IsCJKCompatibility", "㌀㐀" },
			{ "IsCJKCompatibilityForms", "︰﹐" },
			{ "IsCJKCompatibilityIdeographs", "豈ﬀ" },
			{ "IsCJKRadicalsSupplement", "⺀⼀" },
			{ "IsCJKSymbolsandPunctuation", "\u3000\u3040" },
			{ "IsCJKUnifiedIdeographs", "一ꀀ" },
			{ "IsCJKUnifiedIdeographsExtensionA", "㐀䷀" },
			{ "IsCherokee", "Ꭰ᐀" },
			{ "IsCombiningDiacriticalMarks", "\u0300Ͱ" },
			{ "IsCombiningDiacriticalMarksforSymbols", "\u20d0℀" },
			{ "IsCombiningHalfMarks", "\ufe20︰" },
			{ "IsCombiningMarksforSymbols", "\u20d0℀" },
			{ "IsControlPictures", "␀⑀" },
			{ "IsCurrencySymbols", "₠\u20d0" },
			{ "IsCyrillic", "ЀԀ" },
			{ "IsCyrillicSupplement", "Ԁ\u0530" },
			{ "IsDevanagari", "\u0900ঀ" },
			{ "IsDingbats", "✀⟀" },
			{ "IsEnclosedAlphanumerics", "①─" },
			{ "IsEnclosedCJKLettersandMonths", "㈀㌀" },
			{ "IsEthiopic", "ሀᎀ" },
			{ "IsGeneralPunctuation", "\u2000⁰" },
			{ "IsGeometricShapes", "■☀" },
			{ "IsGeorgian", "Ⴀᄀ" },
			{ "IsGreek", "ͰЀ" },
			{ "IsGreekExtended", "ἀ\u2000" },
			{ "IsGreekandCoptic", "ͰЀ" },
			{ "IsGujarati", "\u0a80\u0b00" },
			{ "IsGurmukhi", "\u0a00\u0a80" },
			{ "IsHalfwidthandFullwidthForms", "\uff00\ufff0" },
			{ "IsHangulCompatibilityJamo", "\u3130㆐" },
			{ "IsHangulJamo", "ᄀሀ" },
			{ "IsHangulSyllables", "가ힰ" },
			{ "IsHanunoo", "ᜠᝀ" },
			{ "IsHebrew", "\u0590\u0600" },
			{ "IsHighPrivateUseSurrogates", "\udb80\udc00" },
			{ "IsHighSurrogates", "\ud800\udb80" },
			{ "IsHiragana", "\u3040゠" },
			{ "IsIPAExtensions", "ɐʰ" },
			{ "IsIdeographicDescriptionCharacters", "⿰\u3000" },
			{ "IsKanbun", "㆐ㆠ" },
			{ "IsKangxiRadicals", "⼀\u2fe0" },
			{ "IsKannada", "ಀ\u0d00" },
			{ "IsKatakana", "゠\u3100" },
			{ "IsKatakanaPhoneticExtensions", "ㇰ㈀" },
			{ "IsKhmer", "ក᠀" },
			{ "IsKhmerSymbols", "᧠ᨀ" },
			{ "IsLao", "\u0e80ༀ" },
			{ "IsLatin-1Supplement", "\u0080Ā" },
			{ "IsLatinExtended-A", "Āƀ" },
			{ "IsLatinExtended-B", "ƀɐ" },
			{ "IsLatinExtendedAdditional", "Ḁἀ" },
			{ "IsLetterlikeSymbols", "℀⅐" },
			{ "IsLimbu", "ᤀᥐ" },
			{ "IsLowSurrogates", "\udc00\ue000" },
			{ "IsMalayalam", "\u0d00\u0d80" },
			{ "IsMathematicalOperators", "∀⌀" },
			{ "IsMiscellaneousMathematicalSymbols-A", "⟀⟰" },
			{ "IsMiscellaneousMathematicalSymbols-B", "⦀⨀" },
			{ "IsMiscellaneousSymbols", "☀✀" },
			{ "IsMiscellaneousSymbolsandArrows", "⬀Ⰰ" },
			{ "IsMiscellaneousTechnical", "⌀␀" },
			{ "IsMongolian", "᠀ᢰ" },
			{ "IsMyanmar", "ကႠ" },
			{ "IsNumberForms", "⅐←" },
			{ "IsOgham", "\u1680ᚠ" },
			{ "IsOpticalCharacterRecognition", "⑀①" },
			{ "IsOriya", "\u0b00\u0b80" },
			{ "IsPhoneticExtensions", "ᴀᶀ" },
			{ "IsPrivateUse", "\ue000豈" },
			{ "IsPrivateUseArea", "\ue000豈" },
			{ "IsRunic", "ᚠᜀ" },
			{ "IsSinhala", "\u0d80\u0e00" },
			{ "IsSmallFormVariants", "﹐ﹰ" },
			{ "IsSpacingModifierLetters", "ʰ\u0300" },
			{ "IsSpecials", "\ufff0" },
			{ "IsSuperscriptsandSubscripts", "⁰₠" },
			{ "IsSupplementalArrows-A", "⟰⠀" },
			{ "IsSupplementalArrows-B", "⤀⦀" },
			{ "IsSupplementalMathematicalOperators", "⨀⬀" },
			{ "IsSyriac", "܀ݐ" },
			{ "IsTagalog", "ᜀᜠ" },
			{ "IsTagbanwa", "ᝠក" },
			{ "IsTaiLe", "ᥐᦀ" },
			{ "IsTamil", "\u0b80\u0c00" },
			{ "IsTelugu", "\u0c00ಀ" },
			{ "IsThaana", "ހ߀" },
			{ "IsThai", "\u0e00\u0e80" },
			{ "IsTibetan", "ༀက" },
			{ "IsUnifiedCanadianAboriginalSyllabics", "᐀\u1680" },
			{ "IsVariationSelectors", "\ufe00︐" },
			{ "IsYiRadicals", "꒐ꓐ" },
			{ "IsYiSyllables", "ꀀ꒐" },
			{ "IsYijingHexagramSymbols", "䷀一" },
			{ "_xmlC", "-/0;A[_`a{·\u00b8À×Ø÷øĲĴĿŁŉŊſƀǄǍǱǴǶǺȘɐʩʻ\u02c2ː\u02d2\u0300\u0346\u0360\u0362Ά\u038bΌ\u038dΎ\u03a2ΣϏϐϗϚϛϜϝϞϟϠϡϢϴЁЍЎѐёѝў҂\u0483\u0487ҐӅӇӉӋӍӐӬӮӶӸӺԱ\u0557ՙ՚աև\u0591\u05a2\u05a3\u05ba\u05bb־\u05bf׀\u05c1׃\u05c4\u05c5א\u05ebװ׳ءػـ\u0653٠٪\u0670ڸںڿۀۏې۔ە۩\u06eaۮ۰ۺ\u0901ऄअ\u093a\u093c\u094e\u0951\u0955क़।०॰\u0981\u0984অ\u098dএ\u0991ও\u09a9প\u09b1ল\u09b3শ\u09ba\u09bcঽ\u09be\u09c5\u09c7\u09c9\u09cbৎ\u09d7\u09d8ড়\u09deয়\u09e4০৲\u0a02\u0a03ਅ\u0a0bਏ\u0a11ਓ\u0a29ਪ\u0a31ਲ\u0a34ਵ\u0a37ਸ\u0a3a\u0a3c\u0a3d\u0a3e\u0a43\u0a47\u0a49\u0a4b\u0a4eਖ਼\u0a5dਫ਼\u0a5f੦\u0a75\u0a81\u0a84અઌઍ\u0a8eએ\u0a92ઓ\u0aa9પ\u0ab1લ\u0ab4વ\u0aba\u0abc\u0ac6\u0ac7\u0aca\u0acb\u0aceૠૡ૦૰\u0b01\u0b04ଅ\u0b0dଏ\u0b11ଓ\u0b29ପ\u0b31ଲ\u0b34ଶ\u0b3a\u0b3c\u0b44\u0b47\u0b49\u0b4b\u0b4e\u0b56\u0b58ଡ଼\u0b5eୟ\u0b62୦୰\u0b82\u0b84அ\u0b8bஎ\u0b91ஒ\u0b96ங\u0b9bஜ\u0b9dஞ\u0ba0ண\u0ba5ந\u0babமஶஷ\u0bba\u0bbe\u0bc3\u0bc6\u0bc9\u0bca\u0bce\u0bd7\u0bd8௧௰\u0c01\u0c04అ\u0c0dఎ\u0c11ఒ\u0c29పఴవ\u0c3a\u0c3e\u0c45\u0c46\u0c49\u0c4a\u0c4e\u0c55\u0c57ౠ\u0c62౦\u0c70\u0c82಄ಅ\u0c8dಎ\u0c91ಒ\u0ca9ಪ\u0cb4ವ\u0cba\u0cbe\u0cc5\u0cc6\u0cc9\u0cca\u0cce\u0cd5\u0cd7ೞ\u0cdfೠ\u0ce2೦\u0cf0\u0d02ഄഅ\u0d0dഎ\u0d11ഒഩപഺ\u0d3e\u0d44\u0d46\u0d49\u0d4aൎ\u0d57൘ൠ\u0d62൦൰กฯะ\u0e3bเ๏๐๚ກ\u0e83ຄ\u0e85ງຉຊ\u0e8bຍຎດຘນຠມ\u0ea4ລ\u0ea6ວຨສຬອຯະ\u0eba\u0ebb\u0ebeເ\u0ec5ໆ\u0ec7\u0ec8\u0ece໐\u0eda\u0f18༚༠༪\u0f35༶\u0f37༸\u0f39༺\u0f3e\u0f48ཉཪ\u0f71྅\u0f86ྌ\u0f90\u0f96\u0f97\u0f98\u0f99\u0fae\u0fb1\u0fb8\u0fb9\u0fbaႠ\u10c6აჷᄀᄁᄂᄄᄅᄈᄉᄊᄋᄍᄎᄓᄼᄽᄾᄿᅀᅁᅌᅍᅎᅏᅐᅑᅔᅖᅙᅚᅟᅢᅣᅤᅥᅦᅧᅨᅩᅪᅭᅯᅲᅴᅵᅶᆞᆟᆨᆩᆫᆬᆮᆰᆷᆹᆺᆻᆼᇃᇫᇬᇰᇱᇹᇺḀẜẠỺἀ\u1f16Ἐ\u1f1eἠ\u1f46Ὀ\u1f4eὐ\u1f58Ὑ\u1f5aὛ\u1f5cὝ\u1f5eὟ\u1f7eᾀ\u1fb5ᾶ\u1fbdι\u1fbfῂ\u1fc5ῆ\u1fcdῐ\u1fd4ῖ\u1fdcῠ\u1fedῲ\u1ff5ῶ\u1ffd\u20d0\u20dd\u20e1\u20e2Ω℧Kℬ℮ℯↀↃ々〆〇〈〡〰〱〶ぁゕ\u3099\u309bゝゟァ・ーヿㄅㄭ一龦가\ud7a4" },
			{ "_xmlD", "0:٠٪۰ۺ०॰০ৰ੦\u0a70૦૰୦୰௧௰౦\u0c70೦\u0cf0൦൰๐๚໐\u0eda༠༪၀၊፩፲០\u17ea᠐\u181a０：" },
			{ "_xmlI", ":;A[_`a{À×Ø÷øĲĴĿŁŉŊſƀǄǍǱǴǶǺȘɐʩʻ\u02c2Ά·Έ\u038bΌ\u038dΎ\u03a2ΣϏϐϗϚϛϜϝϞϟϠϡϢϴЁЍЎѐёѝў҂ҐӅӇӉӋӍӐӬӮӶӸӺԱ\u0557ՙ՚աևא\u05ebװ׳ءػف\u064bٱڸںڿۀۏې۔ە\u06d6ۥ\u06e7अ\u093aऽ\u093eक़\u0962অ\u098dএ\u0991ও\u09a9প\u09b1ল\u09b3শ\u09baড়\u09deয়\u09e2ৰ৲ਅ\u0a0bਏ\u0a11ਓ\u0a29ਪ\u0a31ਲ\u0a34ਵ\u0a37ਸ\u0a3aਖ਼\u0a5dਫ਼\u0a5fੲ\u0a75અઌઍ\u0a8eએ\u0a92ઓ\u0aa9પ\u0ab1લ\u0ab4વ\u0abaઽ\u0abeૠૡଅ\u0b0dଏ\u0b11ଓ\u0b29ପ\u0b31ଲ\u0b34ଶ\u0b3aଽ\u0b3eଡ଼\u0b5eୟ\u0b62அ\u0b8bஎ\u0b91ஒ\u0b96ங\u0b9bஜ\u0b9dஞ\u0ba0ண\u0ba5ந\u0babமஶஷ\u0bbaఅ\u0c0dఎ\u0c11ఒ\u0c29పఴవ\u0c3aౠ\u0c62ಅ\u0c8dಎ\u0c91ಒ\u0ca9ಪ\u0cb4ವ\u0cbaೞ\u0cdfೠ\u0ce2അ\u0d0dഎ\u0d11ഒഩപഺൠ\u0d62กฯะ\u0e31า\u0e34เๆກ\u0e83ຄ\u0e85ງຉຊ\u0e8bຍຎດຘນຠມ\u0ea4ລ\u0ea6ວຨສຬອຯະ\u0eb1າ\u0eb4ຽ\u0ebeເ\u0ec5ཀ\u0f48ཉཪႠ\u10c6აჷᄀᄁᄂᄄᄅᄈᄉᄊᄋᄍᄎᄓᄼᄽᄾᄿᅀᅁᅌᅍᅎᅏᅐᅑᅔᅖᅙᅚᅟᅢᅣᅤᅥᅦᅧᅨᅩᅪᅭᅯᅲᅴᅵᅶᆞᆟᆨᆩᆫᆬᆮᆰᆷᆹᆺᆻᆼᇃᇫᇬᇰᇱᇹᇺḀẜẠỺἀ\u1f16Ἐ\u1f1eἠ\u1f46Ὀ\u1f4eὐ\u1f58Ὑ\u1f5aὛ\u1f5cὝ\u1f5eὟ\u1f7eᾀ\u1fb5ᾶ\u1fbdι\u1fbfῂ\u1fc5ῆ\u1fcdῐ\u1fd4ῖ\u1fdcῠ\u1fedῲ\u1ff5ῶ\u1ffdΩ℧Kℬ℮ℯↀↃ〇〈〡\u302aぁゕァ・ㄅㄭ一龦가\ud7a4" },
			{ "_xmlW", "$%+,0:<?A[^_`{|}~\u007f¢«¬\u00ad®·\u00b8»¼¿ÀȡȢȴɐʮʰ\u02ef\u0300\u0350\u0360ͰʹͶͺͻ\u0384·Έ\u038bΌ\u038dΎ\u03a2ΣϏϐϷЀ\u0487\u0488ӏӐӶӸӺԀԐԱ\u0557ՙ՚աֈ\u0591\u05a2\u05a3\u05ba\u05bb־\u05bf׀\u05c1׃\u05c4\u05c5א\u05ebװ׳ءػـ\u0656٠٪ٮ۔ە\u06dd۞ۮ۰ۿܐܭ\u0730\u074bހ\u07b2\u0901ऄअ\u093a\u093c\u094eॐ\u0955क़।०॰\u0981\u0984অ\u098dএ\u0991ও\u09a9প\u09b1ল\u09b3শ\u09ba\u09bcঽ\u09be\u09c5\u09c7\u09c9\u09cbৎ\u09d7\u09d8ড়\u09deয়\u09e4০৻\u0a02\u0a03ਅ\u0a0bਏ\u0a11ਓ\u0a29ਪ\u0a31ਲ\u0a34ਵ\u0a37ਸ\u0a3a\u0a3c\u0a3d\u0a3e\u0a43\u0a47\u0a49\u0a4b\u0a4eਖ਼\u0a5dਫ਼\u0a5f੦\u0a75\u0a81\u0a84અઌઍ\u0a8eએ\u0a92ઓ\u0aa9પ\u0ab1લ\u0ab4વ\u0aba\u0abc\u0ac6\u0ac7\u0aca\u0acb\u0aceૐ\u0ad1ૠૡ૦૰\u0b01\u0b04ଅ\u0b0dଏ\u0b11ଓ\u0b29ପ\u0b31ଲ\u0b34ଶ\u0b3a\u0b3c\u0b44\u0b47\u0b49\u0b4b\u0b4e\u0b56\u0b58ଡ଼\u0b5eୟ\u0b62୦ୱ\u0b82\u0b84அ\u0b8bஎ\u0b91ஒ\u0b96ங\u0b9bஜ\u0b9dஞ\u0ba0ண\u0ba5ந\u0babமஶஷ\u0bba\u0bbe\u0bc3\u0bc6\u0bc9\u0bca\u0bce\u0bd7\u0bd8௧௳\u0c01\u0c04అ\u0c0dఎ\u0c11ఒ\u0c29పఴవ\u0c3a\u0c3e\u0c45\u0c46\u0c49\u0c4a\u0c4e\u0c55\u0c57ౠ\u0c62౦\u0c70\u0c82಄ಅ\u0c8dಎ\u0c91ಒ\u0ca9ಪ\u0cb4ವ\u0cba\u0cbe\u0cc5\u0cc6\u0cc9\u0cca\u0cce\u0cd5\u0cd7ೞ\u0cdfೠ\u0ce2೦\u0cf0\u0d02ഄഅ\u0d0dഎ\u0d11ഒഩപഺ\u0d3e\u0d44\u0d46\u0d49\u0d4aൎ\u0d57൘ൠ\u0d62൦൰\u0d82\u0d84අ\u0d97ක\u0db2ඳ\u0dbcල\u0dbeව\u0dc7\u0dca\u0dcb\u0dcf\u0dd5\u0dd6\u0dd7\u0dd8\u0de0\u0df2෴ก\u0e3b฿๏๐๚ກ\u0e83ຄ\u0e85ງຉຊ\u0e8bຍຎດຘນຠມ\u0ea4ລ\u0ea6ວຨສຬອ\u0eba\u0ebb\u0ebeເ\u0ec5ໆ\u0ec7\u0ec8\u0ece໐\u0edaໜໞༀ༄༓༺\u0f3e\u0f48ཉཫ\u0f71྅\u0f86ྌ\u0f90\u0f98\u0f99\u0fbd྾\u0fcd࿏࿐ကဢဣဨဩ\u102b\u102c\u1033\u1036\u103a၀၊ၐၚႠ\u10c6აჹᄀᅚᅟᆣᆨᇺሀሇለቇቈ\u1249ቊ\u124eቐ\u1257ቘ\u1259ቚ\u125eበኇኈ\u1289ኊ\u128eነኯኰ\u12b1ኲ\u12b6ኸ\u12bfዀ\u12c1ዂ\u12c6ወዏዐ\u12d7ዘዯደጏጐ\u1311ጒ\u1316ጘጟጠፇፈ\u135b፩\u137dᎠᏵᐁ᙭ᙯᙷᚁ᚛ᚠ᛫ᛮᛱᜀᜍᜎ\u1715ᜠ᜵ᝀ\u1754ᝠ\u176dᝮ\u1771\u1772\u1774ក។ៗ៘៛\u17dd០\u17ea\u180b\u180e᠐\u181aᠠᡸᢀᢪḀẜẠỺἀ\u1f16Ἐ\u1f1eἠ\u1f46Ὀ\u1f4eὐ\u1f58Ὑ\u1f5aὛ\u1f5cὝ\u1f5eὟ\u1f7eᾀ\u1fb5ᾶ\u1fc5ῆ\u1fd4ῖ\u1fdc\u1fdd\u1ff0ῲ\u1ff5ῶ\u1fff⁄⁅⁒⁓⁰\u2072⁴⁽ⁿ₍₠₲\u20d0\u20eb℀℻ℽ⅌⅓ↄ←〈⌫⎴⎷⏏␀\u2427⑀\u244b①⓿─☔☖☘☙♾⚀⚊✁✅✆✊✌✨✩❌❍❎❏❓❖❗❘❟❡❨❶➕➘➰➱➿⟐⟦⟰⦃⦙⧘⧜⧼⧾⬀⺀\u2e9a⺛\u2ef4⼀\u2fd6⿰\u2ffc〄〈〒〔〠〰〱〽〾\u3040ぁ\u3097\u3099゠ァ・ー\u3100ㄅㄭㄱ\u318f㆐ㆸㇰ㈝㈠㉄㉑㉼㉿㋌㋐㋿㌀㍷㍻㏞㏠㏿㐀䶶一龦ꀀ\ua48d꒐\ua4c7가\ud7a4豈郞侮恵ﬀ\ufb07ﬓ\ufb18יִ\ufb37טּ\ufb3dמּ\ufb3fנּ\ufb42ףּ\ufb45צּ\ufbb2ﯓ﴾ﵐ\ufd90ﶒ\ufdc8ﷰ﷽\ufe00︐\ufe20\ufe24﹢﹣﹤\ufe67﹩﹪ﹰ\ufe75ﹶ\ufefd＄％＋，０：＜？Ａ［\uff3e\uff3f\uff40｛｜｝～｟ｦ\uffbfￂ\uffc8ￊ\uffd0ￒ\uffd8ￚ\uffdd￠\uffe7￨\uffef￼\ufffe" }
		};
		_lcTable = new LowerCaseMapping[94]
		{
			new LowerCaseMapping('A', 'Z', 1, 32),
			new LowerCaseMapping('À', 'Þ', 1, 32),
			new LowerCaseMapping('Ā', 'Į', 2, 0),
			new LowerCaseMapping('İ', 'İ', 0, 105),
			new LowerCaseMapping('Ĳ', 'Ķ', 2, 0),
			new LowerCaseMapping('Ĺ', 'Ň', 3, 0),
			new LowerCaseMapping('Ŋ', 'Ŷ', 2, 0),
			new LowerCaseMapping('Ÿ', 'Ÿ', 0, 255),
			new LowerCaseMapping('Ź', 'Ž', 3, 0),
			new LowerCaseMapping('Ɓ', 'Ɓ', 0, 595),
			new LowerCaseMapping('Ƃ', 'Ƅ', 2, 0),
			new LowerCaseMapping('Ɔ', 'Ɔ', 0, 596),
			new LowerCaseMapping('Ƈ', 'Ƈ', 0, 392),
			new LowerCaseMapping('Ɖ', 'Ɗ', 1, 205),
			new LowerCaseMapping('Ƌ', 'Ƌ', 0, 396),
			new LowerCaseMapping('Ǝ', 'Ǝ', 0, 477),
			new LowerCaseMapping('Ə', 'Ə', 0, 601),
			new LowerCaseMapping('Ɛ', 'Ɛ', 0, 603),
			new LowerCaseMapping('Ƒ', 'Ƒ', 0, 402),
			new LowerCaseMapping('Ɠ', 'Ɠ', 0, 608),
			new LowerCaseMapping('Ɣ', 'Ɣ', 0, 611),
			new LowerCaseMapping('Ɩ', 'Ɩ', 0, 617),
			new LowerCaseMapping('Ɨ', 'Ɨ', 0, 616),
			new LowerCaseMapping('Ƙ', 'Ƙ', 0, 409),
			new LowerCaseMapping('Ɯ', 'Ɯ', 0, 623),
			new LowerCaseMapping('Ɲ', 'Ɲ', 0, 626),
			new LowerCaseMapping('Ɵ', 'Ɵ', 0, 629),
			new LowerCaseMapping('Ơ', 'Ƥ', 2, 0),
			new LowerCaseMapping('Ƨ', 'Ƨ', 0, 424),
			new LowerCaseMapping('Ʃ', 'Ʃ', 0, 643),
			new LowerCaseMapping('Ƭ', 'Ƭ', 0, 429),
			new LowerCaseMapping('Ʈ', 'Ʈ', 0, 648),
			new LowerCaseMapping('Ư', 'Ư', 0, 432),
			new LowerCaseMapping('Ʊ', 'Ʋ', 1, 217),
			new LowerCaseMapping('Ƴ', 'Ƶ', 3, 0),
			new LowerCaseMapping('Ʒ', 'Ʒ', 0, 658),
			new LowerCaseMapping('Ƹ', 'Ƹ', 0, 441),
			new LowerCaseMapping('Ƽ', 'Ƽ', 0, 445),
			new LowerCaseMapping('Ǆ', 'ǅ', 0, 454),
			new LowerCaseMapping('Ǉ', 'ǈ', 0, 457),
			new LowerCaseMapping('Ǌ', 'ǋ', 0, 460),
			new LowerCaseMapping('Ǎ', 'Ǜ', 3, 0),
			new LowerCaseMapping('Ǟ', 'Ǯ', 2, 0),
			new LowerCaseMapping('Ǳ', 'ǲ', 0, 499),
			new LowerCaseMapping('Ǵ', 'Ǵ', 0, 501),
			new LowerCaseMapping('Ǻ', 'Ȗ', 2, 0),
			new LowerCaseMapping('Ά', 'Ά', 0, 940),
			new LowerCaseMapping('Έ', 'Ί', 1, 37),
			new LowerCaseMapping('Ό', 'Ό', 0, 972),
			new LowerCaseMapping('Ύ', 'Ώ', 1, 63),
			new LowerCaseMapping('Α', 'Ϋ', 1, 32),
			new LowerCaseMapping('Ϣ', 'Ϯ', 2, 0),
			new LowerCaseMapping('Ё', 'Џ', 1, 80),
			new LowerCaseMapping('А', 'Я', 1, 32),
			new LowerCaseMapping('Ѡ', 'Ҁ', 2, 0),
			new LowerCaseMapping('Ґ', 'Ҿ', 2, 0),
			new LowerCaseMapping('Ӂ', 'Ӄ', 3, 0),
			new LowerCaseMapping('Ӈ', 'Ӈ', 0, 1224),
			new LowerCaseMapping('Ӌ', 'Ӌ', 0, 1228),
			new LowerCaseMapping('Ӑ', 'Ӫ', 2, 0),
			new LowerCaseMapping('Ӯ', 'Ӵ', 2, 0),
			new LowerCaseMapping('Ӹ', 'Ӹ', 0, 1273),
			new LowerCaseMapping('Ա', 'Ֆ', 1, 48),
			new LowerCaseMapping('Ⴀ', 'Ⴥ', 1, 48),
			new LowerCaseMapping('Ḁ', 'Ỹ', 2, 0),
			new LowerCaseMapping('Ἀ', 'Ἇ', 1, -8),
			new LowerCaseMapping('Ἐ', '\u1f1f', 1, -8),
			new LowerCaseMapping('Ἠ', 'Ἧ', 1, -8),
			new LowerCaseMapping('Ἰ', 'Ἷ', 1, -8),
			new LowerCaseMapping('Ὀ', 'Ὅ', 1, -8),
			new LowerCaseMapping('Ὑ', 'Ὑ', 0, 8017),
			new LowerCaseMapping('Ὓ', 'Ὓ', 0, 8019),
			new LowerCaseMapping('Ὕ', 'Ὕ', 0, 8021),
			new LowerCaseMapping('Ὗ', 'Ὗ', 0, 8023),
			new LowerCaseMapping('Ὠ', 'Ὧ', 1, -8),
			new LowerCaseMapping('ᾈ', 'ᾏ', 1, -8),
			new LowerCaseMapping('ᾘ', 'ᾟ', 1, -8),
			new LowerCaseMapping('ᾨ', 'ᾯ', 1, -8),
			new LowerCaseMapping('Ᾰ', 'Ᾱ', 1, -8),
			new LowerCaseMapping('Ὰ', 'Ά', 1, -74),
			new LowerCaseMapping('ᾼ', 'ᾼ', 0, 8115),
			new LowerCaseMapping('Ὲ', 'Ή', 1, -86),
			new LowerCaseMapping('ῌ', 'ῌ', 0, 8131),
			new LowerCaseMapping('Ῐ', 'Ῑ', 1, -8),
			new LowerCaseMapping('Ὶ', 'Ί', 1, -100),
			new LowerCaseMapping('Ῠ', 'Ῡ', 1, -8),
			new LowerCaseMapping('Ὺ', 'Ύ', 1, -112),
			new LowerCaseMapping('Ῥ', 'Ῥ', 0, 8165),
			new LowerCaseMapping('Ὸ', 'Ό', 1, -128),
			new LowerCaseMapping('Ὼ', 'Ώ', 1, -126),
			new LowerCaseMapping('ῼ', 'ῼ', 0, 8179),
			new LowerCaseMapping('Ⅰ', 'Ⅿ', 1, 16),
			new LowerCaseMapping('Ⓐ', 'ⓐ', 1, 26),
			new LowerCaseMapping('Ａ', 'Ｚ', 1, 32)
		};
		Dictionary<string, string> dictionary = new Dictionary<string, string>(32);
		char[] array = new char[9];
		StringBuilder stringBuilder = new StringBuilder(11);
		stringBuilder.Append('\0');
		array[0] = '\0';
		array[1] = '\u000f';
		dictionary["Cc"] = array[1].ToString();
		array[2] = '\u0010';
		dictionary["Cf"] = array[2].ToString();
		array[3] = '\u001e';
		dictionary["Cn"] = array[3].ToString();
		array[4] = '\u0012';
		dictionary["Co"] = array[4].ToString();
		array[5] = '\u0011';
		dictionary["Cs"] = array[5].ToString();
		array[6] = '\0';
		dictionary["C"] = new string(array, 0, 7);
		array[1] = '\u0002';
		dictionary["Ll"] = array[1].ToString();
		array[2] = '\u0004';
		dictionary["Lm"] = array[2].ToString();
		array[3] = '\u0005';
		dictionary["Lo"] = array[3].ToString();
		array[4] = '\u0003';
		dictionary["Lt"] = array[4].ToString();
		array[5] = '\u0001';
		dictionary["Lu"] = array[5].ToString();
		dictionary["L"] = new string(array, 0, 7);
		stringBuilder.Append(new string(array, 1, 5));
		dictionary[InternalRegexIgnoreCase] = string.Format(CultureInfo.InvariantCulture, "{0}{1}{2}{3}{4}", '\0', array[1], array[4], array[5], array[6]);
		array[1] = '\a';
		dictionary["Mc"] = array[1].ToString();
		array[2] = '\b';
		dictionary["Me"] = array[2].ToString();
		array[3] = '\u0006';
		dictionary["Mn"] = array[3].ToString();
		array[4] = '\0';
		dictionary["M"] = new string(array, 0, 5);
		stringBuilder.Append(array[3]);
		array[1] = '\t';
		dictionary["Nd"] = array[1].ToString();
		array[2] = '\n';
		dictionary["Nl"] = array[2].ToString();
		array[3] = '\v';
		dictionary["No"] = array[3].ToString();
		dictionary["N"] = new string(array, 0, 5);
		stringBuilder.Append(array[1]);
		array[1] = '\u0013';
		dictionary["Pc"] = array[1].ToString();
		array[2] = '\u0014';
		dictionary["Pd"] = array[2].ToString();
		array[3] = '\u0016';
		dictionary["Pe"] = array[3].ToString();
		array[4] = '\u0019';
		dictionary["Po"] = array[4].ToString();
		array[5] = '\u0015';
		dictionary["Ps"] = array[5].ToString();
		array[6] = '\u0018';
		dictionary["Pf"] = array[6].ToString();
		array[7] = '\u0017';
		dictionary["Pi"] = array[7].ToString();
		array[8] = '\0';
		dictionary["P"] = new string(array, 0, 9);
		stringBuilder.Append(array[1]);
		array[1] = '\u001b';
		dictionary["Sc"] = array[1].ToString();
		array[2] = '\u001c';
		dictionary["Sk"] = array[2].ToString();
		array[3] = '\u001a';
		dictionary["Sm"] = array[3].ToString();
		array[4] = '\u001d';
		dictionary["So"] = array[4].ToString();
		array[5] = '\0';
		dictionary["S"] = new string(array, 0, 6);
		array[1] = '\r';
		dictionary["Zl"] = array[1].ToString();
		array[2] = '\u000e';
		dictionary["Zp"] = array[2].ToString();
		array[3] = '\f';
		dictionary["Zs"] = array[3].ToString();
		array[4] = '\0';
		dictionary["Z"] = new string(array, 0, 5);
		stringBuilder.Append('\0');
		Word = stringBuilder.ToString();
		NotWord = NegateCategory(Word);
		SpaceClass = "\0\0\u0001" + Space;
		NotSpaceClass = "\u0001\0\u0001" + Space;
		WordClass = "\0\0" + (char)Word.Length + Word;
		NotWordClass = "\u0001\0" + (char)Word.Length + Word;
		DigitClass = "\0\0\u0001\t";
		NotDigitClass = "\0\0\u0001\ufff7";
		_definedCategories = dictionary;
	}

	internal RegexCharClass()
	{
		_rangelist = new List<SingleRange>(6);
		_canonical = true;
		_categories = new StringBuilder();
	}

	private RegexCharClass(bool negate, List<SingleRange> ranges, StringBuilder categories, RegexCharClass subtraction)
	{
		_rangelist = ranges;
		_categories = categories;
		_canonical = true;
		_negate = negate;
		_subtractor = subtraction;
	}

	internal void AddChar(char c)
	{
		AddRange(c, c);
	}

	internal void AddCharClass(RegexCharClass cc)
	{
		if (!cc._canonical)
		{
			_canonical = false;
		}
		else if (_canonical && RangeCount() > 0 && cc.RangeCount() > 0 && cc.GetRangeAt(0)._first <= GetRangeAt(RangeCount() - 1)._last)
		{
			_canonical = false;
		}
		for (int i = 0; i < cc.RangeCount(); i++)
		{
			_rangelist.Add(cc.GetRangeAt(i));
		}
		_categories.Append(cc._categories.ToString());
	}

	private void AddSet(string set)
	{
		if (_canonical && RangeCount() > 0 && set.Length > 0 && set[0] <= GetRangeAt(RangeCount() - 1)._last)
		{
			_canonical = false;
		}
		int i;
		for (i = 0; i < set.Length - 1; i += 2)
		{
			_rangelist.Add(new SingleRange(set[i], (char)(set[i + 1] - 1)));
		}
		if (i < set.Length)
		{
			_rangelist.Add(new SingleRange(set[i], '\uffff'));
		}
	}

	internal void AddSubtraction(RegexCharClass sub)
	{
		_subtractor = sub;
	}

	internal void AddRange(char first, char last)
	{
		_rangelist.Add(new SingleRange(first, last));
		if (_canonical && _rangelist.Count > 0 && first <= _rangelist[_rangelist.Count - 1]._last)
		{
			_canonical = false;
		}
	}

	internal void AddCategoryFromName(string categoryName, bool invert, bool caseInsensitive, string pattern)
	{
		_definedCategories.TryGetValue(categoryName, out var value);
		if (value != null && !categoryName.Equals(InternalRegexIgnoreCase))
		{
			string text = value;
			if (caseInsensitive && (categoryName.Equals("Ll") || categoryName.Equals("Lu") || categoryName.Equals("Lt")))
			{
				text = _definedCategories[InternalRegexIgnoreCase];
			}
			if (invert)
			{
				text = NegateCategory(text);
			}
			_categories.Append(text);
		}
		else
		{
			AddSet(SetFromProperty(categoryName, invert, pattern));
		}
	}

	private void AddCategory(string category)
	{
		_categories.Append(category);
	}

	internal void AddLowercase(CultureInfo culture)
	{
		_canonical = false;
		int i = 0;
		for (int count = _rangelist.Count; i < count; i++)
		{
			SingleRange singleRange = _rangelist[i];
			if (singleRange._first == singleRange._last)
			{
				singleRange._first = (singleRange._last = char.ToLower(singleRange._first, culture));
			}
			else
			{
				AddLowercaseRange(singleRange._first, singleRange._last, culture);
			}
		}
	}

	private void AddLowercaseRange(char chMin, char chMax, CultureInfo culture)
	{
		int i = 0;
		int num = _lcTable.Length;
		while (i < num)
		{
			int num2 = (i + num) / 2;
			if (_lcTable[num2]._chMax < chMin)
			{
				i = num2 + 1;
			}
			else
			{
				num = num2;
			}
		}
		if (i >= _lcTable.Length)
		{
			return;
		}
		for (; i < _lcTable.Length; i++)
		{
			LowerCaseMapping lowerCaseMapping2;
			LowerCaseMapping lowerCaseMapping = (lowerCaseMapping2 = _lcTable[i]);
			if (lowerCaseMapping._chMin <= chMax)
			{
				char c;
				if ((c = lowerCaseMapping2._chMin) < chMin)
				{
					c = chMin;
				}
				char c2;
				if ((c2 = lowerCaseMapping2._chMax) > chMax)
				{
					c2 = chMax;
				}
				switch (lowerCaseMapping2._lcOp)
				{
				case 0:
					c = (char)lowerCaseMapping2._data;
					c2 = (char)lowerCaseMapping2._data;
					break;
				case 1:
					c = (char)(c + (ushort)lowerCaseMapping2._data);
					c2 = (char)(c2 + (ushort)lowerCaseMapping2._data);
					break;
				case 2:
					c = (char)(c | 1);
					c2 = (char)(c2 | 1);
					break;
				case 3:
					c = (char)(c + (ushort)(c & 1));
					c2 = (char)(c2 + (ushort)(c2 & 1));
					break;
				}
				if (c < chMin || c2 > chMax)
				{
					AddRange(c, c2);
				}
				continue;
			}
			break;
		}
	}

	internal void AddWord(bool ecma, bool negate)
	{
		if (negate)
		{
			if (ecma)
			{
				AddSet("\00:A[_`a{İı");
			}
			else
			{
				AddCategory(NotWord);
			}
		}
		else if (ecma)
		{
			AddSet("0:A[_`a{İı");
		}
		else
		{
			AddCategory(Word);
		}
	}

	internal void AddSpace(bool ecma, bool negate)
	{
		if (negate)
		{
			if (ecma)
			{
				AddSet("\0\t\u000e !");
			}
			else
			{
				AddCategory(NotSpace);
			}
		}
		else if (ecma)
		{
			AddSet("\t\u000e !");
		}
		else
		{
			AddCategory(Space);
		}
	}

	internal void AddDigit(bool ecma, bool negate, string pattern)
	{
		if (ecma)
		{
			if (negate)
			{
				AddSet("\00:");
			}
			else
			{
				AddSet("0:");
			}
		}
		else
		{
			AddCategoryFromName("Nd", negate, caseInsensitive: false, pattern);
		}
	}

	internal static string ConvertOldStringsToClass(string set, string category)
	{
		StringBuilder stringBuilder = new StringBuilder(set.Length + category.Length + 3);
		if (set.Length >= 2 && set[0] == '\0' && set[1] == '\0')
		{
			stringBuilder.Append('\u0001');
			stringBuilder.Append((char)(set.Length - 2));
			stringBuilder.Append((char)category.Length);
			stringBuilder.Append(set.Substring(2));
		}
		else
		{
			stringBuilder.Append('\0');
			stringBuilder.Append((char)set.Length);
			stringBuilder.Append((char)category.Length);
			stringBuilder.Append(set);
		}
		stringBuilder.Append(category);
		return stringBuilder.ToString();
	}

	internal static char SingletonChar(string set)
	{
		return set[3];
	}

	internal static bool IsMergeable(string charClass)
	{
		if (!IsNegated(charClass))
		{
			return !IsSubtraction(charClass);
		}
		return false;
	}

	internal static bool IsEmpty(string charClass)
	{
		if (charClass[2] == '\0' && charClass[0] == '\0' && charClass[1] == '\0' && !IsSubtraction(charClass))
		{
			return true;
		}
		return false;
	}

	internal static bool IsSingleton(string set)
	{
		if (set[0] == '\0' && set[2] == '\0' && set[1] == '\u0002' && !IsSubtraction(set) && (set[3] == '\uffff' || set[3] + 1 == set[4]))
		{
			return true;
		}
		return false;
	}

	internal static bool IsSingletonInverse(string set)
	{
		if (set[0] == '\u0001' && set[2] == '\0' && set[1] == '\u0002' && !IsSubtraction(set) && (set[3] == '\uffff' || set[3] + 1 == set[4]))
		{
			return true;
		}
		return false;
	}

	private static bool IsSubtraction(string charClass)
	{
		return charClass.Length > 3 + charClass[1] + charClass[2];
	}

	internal static bool IsNegated(string set)
	{
		if (set != null)
		{
			return set[0] == '\u0001';
		}
		return false;
	}

	internal static bool IsECMAWordChar(char ch)
	{
		return CharInClass(ch, "\0\n\00:A[_`a{İı");
	}

	internal static bool IsWordChar(char ch)
	{
		if (!CharInClass(ch, WordClass) && ch != '\u200d')
		{
			return ch == '\u200c';
		}
		return true;
	}

	internal static bool CharInClass(char ch, string set)
	{
		return CharInClassRecursive(ch, set, 0);
	}

	internal static bool CharInClassRecursive(char ch, string set, int start)
	{
		int num = set[start + 1];
		int num2 = set[start + 2];
		int num3 = start + 3 + num + num2;
		bool flag = false;
		if (set.Length > num3)
		{
			flag = CharInClassRecursive(ch, set, num3);
		}
		bool flag2 = CharInClassInternal(ch, set, start, num, num2);
		if (set[start] == '\u0001')
		{
			flag2 = !flag2;
		}
		if (flag2)
		{
			return !flag;
		}
		return false;
	}

	private static bool CharInClassInternal(char ch, string set, int start, int mySetLength, int myCategoryLength)
	{
		int num = start + 3;
		int num2 = num + mySetLength;
		while (num != num2)
		{
			int num3 = (num + num2) / 2;
			if (ch < set[num3])
			{
				num2 = num3;
			}
			else
			{
				num = num3 + 1;
			}
		}
		if ((num & 1) == (start & 1))
		{
			return true;
		}
		if (myCategoryLength == 0)
		{
			return false;
		}
		return CharInCategory(ch, set, start, mySetLength, myCategoryLength);
	}

	private static bool CharInCategory(char ch, string set, int start, int mySetLength, int myCategoryLength)
	{
		UnicodeCategory unicodeCategory = char.GetUnicodeCategory(ch);
		int i = start + 3 + mySetLength;
		int num = i + myCategoryLength;
		while (i < num)
		{
			int num2 = (short)set[i];
			if (num2 == 0)
			{
				if (CharInCategoryGroup(ch, unicodeCategory, set, ref i))
				{
					return true;
				}
			}
			else if (num2 > 0)
			{
				if (num2 == 100)
				{
					if (char.IsWhiteSpace(ch))
					{
						return true;
					}
					i++;
					continue;
				}
				num2--;
				if (unicodeCategory == (UnicodeCategory)num2)
				{
					return true;
				}
			}
			else
			{
				if (num2 == -100)
				{
					if (!char.IsWhiteSpace(ch))
					{
						return true;
					}
					i++;
					continue;
				}
				num2 = -1 - num2;
				if (unicodeCategory != (UnicodeCategory)num2)
				{
					return true;
				}
			}
			i++;
		}
		return false;
	}

	private static bool CharInCategoryGroup(char ch, UnicodeCategory chcategory, string category, ref int i)
	{
		i++;
		int num = (short)category[i];
		if (num > 0)
		{
			bool flag = false;
			while (num != 0)
			{
				if (!flag)
				{
					num--;
					if (chcategory == (UnicodeCategory)num)
					{
						flag = true;
					}
				}
				i++;
				num = (short)category[i];
			}
			return flag;
		}
		bool flag2 = true;
		while (num != 0)
		{
			if (flag2)
			{
				num = -1 - num;
				if (chcategory == (UnicodeCategory)num)
				{
					flag2 = false;
				}
			}
			i++;
			num = (short)category[i];
		}
		return flag2;
	}

	private static string NegateCategory(string category)
	{
		if (category == null)
		{
			return null;
		}
		StringBuilder stringBuilder = new StringBuilder(category.Length);
		for (int i = 0; i < category.Length; i++)
		{
			short num = (short)category[i];
			stringBuilder.Append((char)(-num));
		}
		return stringBuilder.ToString();
	}

	internal static RegexCharClass Parse(string charClass)
	{
		return ParseRecursive(charClass, 0);
	}

	private static RegexCharClass ParseRecursive(string charClass, int start)
	{
		int num = charClass[start + 1];
		int num2 = charClass[start + 2];
		int num3 = start + 3 + num + num2;
		List<SingleRange> list = new List<SingleRange>(num);
		int num4 = start + 3;
		int num5 = num4 + num;
		while (num4 < num5)
		{
			char first = charClass[num4];
			num4++;
			char last = ((num4 >= num5) ? '\uffff' : ((char)(charClass[num4] - 1)));
			num4++;
			list.Add(new SingleRange(first, last));
		}
		RegexCharClass subtraction = null;
		if (charClass.Length > num3)
		{
			subtraction = ParseRecursive(charClass, num3);
		}
		return new RegexCharClass(charClass[start] == '\u0001', list, new StringBuilder(charClass.Substring(num5, num2)), subtraction);
	}

	private int RangeCount()
	{
		return _rangelist.Count;
	}

	internal string ToStringClass()
	{
		if (!_canonical)
		{
			Canonicalize();
		}
		int num = _rangelist.Count * 2;
		StringBuilder stringBuilder = new StringBuilder(num + _categories.Length + 3);
		int num2 = (_negate ? 1 : 0);
		stringBuilder.Append((char)num2);
		stringBuilder.Append((char)num);
		stringBuilder.Append((char)_categories.Length);
		for (int i = 0; i < _rangelist.Count; i++)
		{
			SingleRange singleRange = _rangelist[i];
			stringBuilder.Append(singleRange._first);
			if (singleRange._last != '\uffff')
			{
				stringBuilder.Append((char)(singleRange._last + 1));
			}
		}
		stringBuilder[1] = (char)(stringBuilder.Length - 3);
		stringBuilder.Append(_categories);
		if (_subtractor != null)
		{
			stringBuilder.Append(_subtractor.ToStringClass());
		}
		return stringBuilder.ToString();
	}

	private SingleRange GetRangeAt(int i)
	{
		return _rangelist[i];
	}

	private void Canonicalize()
	{
		_canonical = true;
		_rangelist.Sort(0, _rangelist.Count, new SingleRangeComparer());
		if (_rangelist.Count <= 1)
		{
			return;
		}
		bool flag = false;
		int num = 1;
		int num2 = 0;
		while (true)
		{
			char last = _rangelist[num2]._last;
			while (true)
			{
				if (num == _rangelist.Count || last == '\uffff')
				{
					flag = true;
					break;
				}
				SingleRange singleRange;
				if ((singleRange = _rangelist[num])._first > last + 1)
				{
					break;
				}
				if (last < singleRange._last)
				{
					last = singleRange._last;
				}
				num++;
			}
			_rangelist[num2]._last = last;
			num2++;
			if (flag)
			{
				break;
			}
			if (num2 < num)
			{
				_rangelist[num2] = _rangelist[num];
			}
			num++;
		}
		_rangelist.RemoveRange(num2, _rangelist.Count - num2);
	}

	private static string SetFromProperty(string capname, bool invert, string pattern)
	{
		int num = 0;
		int num2 = _propTable.GetLength(0);
		while (num != num2)
		{
			int num3 = (num + num2) / 2;
			int num4 = string.Compare(capname, _propTable[num3, 0], StringComparison.Ordinal);
			if (num4 < 0)
			{
				num2 = num3;
				continue;
			}
			if (num4 > 0)
			{
				num = num3 + 1;
				continue;
			}
			string text = _propTable[num3, 1];
			if (invert)
			{
				if (text[0] == '\0')
				{
					return text.Substring(1);
				}
				return "\0" + text;
			}
			return text;
		}
		throw new ArgumentException(SR.GetString("MakeException", pattern, SR.GetString("UnknownProperty", capname)));
	}
}
