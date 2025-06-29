namespace b1.Util;

public struct GSEP4VersionInfo
{
	public int version;

	public string user;

	public string workspace;

	public string date;

	public string time;

	public string comment;

	public override string ToString()
	{
		return string.Format("version:{0},user:{1},workspace:{5},date:{2},time:{3},comment:{4}", version, user, date, time, comment, workspace);
	}

	public string ToSimString()
	{
		return $"P4_{version}_{date}_{time}_{workspace}_{user}";
	}
}
