using System.CodeDom;

namespace Microsoft.CSharp;

internal class CSharpMemberAttributeConverter : CSharpModifierAttributeConverter
{
	private static volatile string[] names;

	private static volatile object[] values;

	private static volatile CSharpMemberAttributeConverter defaultConverter;

	public static CSharpMemberAttributeConverter Default
	{
		get
		{
			if (defaultConverter == null)
			{
				defaultConverter = new CSharpMemberAttributeConverter();
			}
			return defaultConverter;
		}
	}

	protected override string[] Names
	{
		get
		{
			if (names == null)
			{
				names = new string[5] { "Public", "Protected", "Protected Internal", "Internal", "Private" };
			}
			return names;
		}
	}

	protected override object[] Values
	{
		get
		{
			if (values == null)
			{
				values = new object[5]
				{
					MemberAttributes.Public,
					MemberAttributes.Family,
					MemberAttributes.FamilyOrAssembly,
					MemberAttributes.Assembly,
					MemberAttributes.Private
				};
			}
			return values;
		}
	}

	protected override object DefaultValue => MemberAttributes.Private;

	private CSharpMemberAttributeConverter()
	{
	}
}
