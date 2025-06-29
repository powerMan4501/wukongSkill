namespace b1;

public struct SubtitleInfo
{
	public string name;

	public string content;

	public float duration;

	public bool IsSupportSoundDirection;

	public SubtitleInfo(string _name, string _content, float _duration, bool _IsSupportSoundDirection)
	{
		name = _name;
		content = _content;
		duration = _duration;
		IsSupportSoundDirection = _IsSupportSoundDirection;
	}
}
