using System.Security;

namespace System.Diagnostics;

[Serializable]
internal class LogSwitch
{
	internal string strName;

	internal string strDescription;

	private LogSwitch ParentSwitch;

	internal volatile LoggingLevels iLevel;

	internal volatile LoggingLevels iOldLevel;

	public virtual string Name => strName;

	public virtual string Description => strDescription;

	public virtual LogSwitch Parent => ParentSwitch;

	public virtual LoggingLevels MinimumLevel
	{
		get
		{
			return iLevel;
		}
		[SecuritySafeCritical]
		set
		{
			iLevel = value;
			iOldLevel = value;
			string strParentName = ((ParentSwitch != null) ? ParentSwitch.Name : "");
			if (Debugger.IsAttached)
			{
				Log.ModifyLogSwitch((int)iLevel, strName, strParentName);
			}
			Log.InvokeLogSwitchLevelHandlers(this, iLevel);
		}
	}

	private LogSwitch()
	{
	}

	[SecuritySafeCritical]
	public LogSwitch(string name, string description, LogSwitch parent)
	{
		if (name != null && name.Length == 0)
		{
			throw new ArgumentOutOfRangeException("Name", Environment.GetResourceString("Argument_StringZeroLength"));
		}
		if (name != null && parent != null)
		{
			strName = name;
			strDescription = description;
			iLevel = LoggingLevels.ErrorLevel;
			iOldLevel = iLevel;
			ParentSwitch = parent;
			Log.m_Hashtable.Add(strName, this);
			Log.AddLogSwitch(this);
			return;
		}
		throw new ArgumentNullException((name == null) ? "name" : "parent");
	}

	[SecuritySafeCritical]
	internal LogSwitch(string name, string description)
	{
		strName = name;
		strDescription = description;
		iLevel = LoggingLevels.ErrorLevel;
		iOldLevel = iLevel;
		ParentSwitch = null;
		Log.m_Hashtable.Add(strName, this);
		Log.AddLogSwitch(this);
	}

	public virtual bool CheckLevel(LoggingLevels level)
	{
		if (iLevel > level)
		{
			if (ParentSwitch == null)
			{
				return false;
			}
			return ParentSwitch.CheckLevel(level);
		}
		return true;
	}

	public static LogSwitch GetSwitch(string name)
	{
		return (LogSwitch)Log.m_Hashtable[name];
	}
}
