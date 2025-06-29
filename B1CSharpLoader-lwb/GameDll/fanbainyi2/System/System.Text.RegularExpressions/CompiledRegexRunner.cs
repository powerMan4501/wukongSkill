namespace System.Text.RegularExpressions;

internal sealed class CompiledRegexRunner : RegexRunner
{
	private NoParamDelegate goMethod;

	private FindFirstCharDelegate findFirstCharMethod;

	private NoParamDelegate initTrackCountMethod;

	internal CompiledRegexRunner()
	{
	}

	internal void SetDelegates(NoParamDelegate go, FindFirstCharDelegate firstChar, NoParamDelegate trackCount)
	{
		goMethod = go;
		findFirstCharMethod = firstChar;
		initTrackCountMethod = trackCount;
	}

	protected override void Go()
	{
		goMethod(this);
	}

	protected override bool FindFirstChar()
	{
		return findFirstCharMethod(this);
	}

	protected override void InitTrackCount()
	{
		initTrackCountMethod(this);
	}
}
