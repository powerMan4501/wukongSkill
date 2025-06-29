namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.Class)]
public class RunInstallerAttribute : Attribute
{
	private bool runInstaller;

	public static readonly RunInstallerAttribute Yes = new RunInstallerAttribute(runInstaller: true);

	public static readonly RunInstallerAttribute No = new RunInstallerAttribute(runInstaller: false);

	public static readonly RunInstallerAttribute Default = No;

	public bool RunInstaller => runInstaller;

	public RunInstallerAttribute(bool runInstaller)
	{
		this.runInstaller = runInstaller;
	}

	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (obj is RunInstallerAttribute runInstallerAttribute)
		{
			return runInstallerAttribute.RunInstaller == runInstaller;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	public override bool IsDefaultAttribute()
	{
		return Equals(Default);
	}
}
