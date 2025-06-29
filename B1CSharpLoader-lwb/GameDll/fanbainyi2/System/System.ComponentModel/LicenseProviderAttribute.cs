namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
public sealed class LicenseProviderAttribute : Attribute
{
	public static readonly LicenseProviderAttribute Default = new LicenseProviderAttribute();

	private Type licenseProviderType;

	private string licenseProviderName;

	public Type LicenseProvider
	{
		get
		{
			if (licenseProviderType == null && licenseProviderName != null)
			{
				licenseProviderType = Type.GetType(licenseProviderName);
			}
			return licenseProviderType;
		}
	}

	public override object TypeId
	{
		get
		{
			string fullName = licenseProviderName;
			if (fullName == null && licenseProviderType != null)
			{
				fullName = licenseProviderType.FullName;
			}
			return GetType().FullName + fullName;
		}
	}

	public LicenseProviderAttribute()
		: this((string)null)
	{
	}

	public LicenseProviderAttribute(string typeName)
	{
		licenseProviderName = typeName;
	}

	public LicenseProviderAttribute(Type type)
	{
		licenseProviderType = type;
	}

	public override bool Equals(object value)
	{
		if (value is LicenseProviderAttribute && value != null)
		{
			Type licenseProvider = ((LicenseProviderAttribute)value).LicenseProvider;
			if (licenseProvider == LicenseProvider)
			{
				return true;
			}
			if (licenseProvider != null && licenseProvider.Equals(LicenseProvider))
			{
				return true;
			}
		}
		return false;
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}
}
