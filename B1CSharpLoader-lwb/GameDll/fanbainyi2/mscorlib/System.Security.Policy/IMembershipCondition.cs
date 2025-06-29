using System.Runtime.InteropServices;

namespace System.Security.Policy;

[ComVisible(true)]
public interface IMembershipCondition : ISecurityEncodable, ISecurityPolicyEncodable
{
	bool Check(Evidence evidence);

	IMembershipCondition Copy();

	new string ToString();

	new bool Equals(object obj);
}
