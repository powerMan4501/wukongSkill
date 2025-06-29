namespace UnrealEngine.Plugins.SequencerScripting;

public static class USequencerScriptingRangeExtensions_CsExtensions
{
	public static void SetStartSeconds(this ref FSequencerScriptingRange Range, float Start)
	{
		USequencerScriptingRangeExtensions.SetStartSeconds(ref Range, Start);
	}

	public static void SetStartFrame(this ref FSequencerScriptingRange Range, int Start)
	{
		USequencerScriptingRangeExtensions.SetStartFrame(ref Range, Start);
	}

	public static void SetEndSeconds(this ref FSequencerScriptingRange Range, float End)
	{
		USequencerScriptingRangeExtensions.SetEndSeconds(ref Range, End);
	}

	public static void SetEndFrame(this ref FSequencerScriptingRange Range, int End)
	{
		USequencerScriptingRangeExtensions.SetEndFrame(ref Range, End);
	}

	public static void RemoveStart(this ref FSequencerScriptingRange Range)
	{
		USequencerScriptingRangeExtensions.RemoveStart(ref Range);
	}

	public static void RemoveEnd(this ref FSequencerScriptingRange Range)
	{
		USequencerScriptingRangeExtensions.RemoveEnd(ref Range);
	}

	public static bool HasStart(this FSequencerScriptingRange Range)
	{
		return USequencerScriptingRangeExtensions.HasStart(Range);
	}

	public static bool HasEnd(this FSequencerScriptingRange Range)
	{
		return USequencerScriptingRangeExtensions.HasEnd(Range);
	}

	public static float GetStartSeconds(this FSequencerScriptingRange Range)
	{
		return USequencerScriptingRangeExtensions.GetStartSeconds(Range);
	}

	public static int GetStartFrame(this FSequencerScriptingRange Range)
	{
		return USequencerScriptingRangeExtensions.GetStartFrame(Range);
	}

	public static float GetEndSeconds(this FSequencerScriptingRange Range)
	{
		return USequencerScriptingRangeExtensions.GetEndSeconds(Range);
	}

	public static int GetEndFrame(this FSequencerScriptingRange Range)
	{
		return USequencerScriptingRangeExtensions.GetEndFrame(Range);
	}
}
