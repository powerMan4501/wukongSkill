using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Security.Policy;
using System.Security.Util;
using System.Text;
using System.Threading;

namespace System.Security;

[Serializable]
[ComVisible(true)]
[StrongNameIdentityPermission(SecurityAction.InheritanceDemand, Name = "mscorlib", PublicKey = "0x00000000000000000400000000000000")]
public class PermissionSet : ISecurityEncodable, ICollection, IEnumerable, IStackWalk, IDeserializationCallback
{
	internal enum IsSubsetOfType
	{
		Normal,
		CheckDemand,
		CheckPermitOnly,
		CheckAssertion
	}

	private bool m_Unrestricted;

	[OptionalField(VersionAdded = 2)]
	private bool m_allPermissionsDecoded;

	[OptionalField(VersionAdded = 2)]
	internal TokenBasedSet m_permSet;

	[OptionalField(VersionAdded = 2)]
	private bool m_ignoreTypeLoadFailures;

	[OptionalField(VersionAdded = 2)]
	private string m_serializedPermissionSet;

	[NonSerialized]
	private bool m_CheckedForNonCas;

	[NonSerialized]
	private bool m_ContainsCas;

	[NonSerialized]
	private bool m_ContainsNonCas;

	[NonSerialized]
	private TokenBasedSet m_permSetSaved;

	private bool readableonly;

	private TokenBasedSet m_unrestrictedPermSet;

	private TokenBasedSet m_normalPermSet;

	[OptionalField(VersionAdded = 2)]
	private bool m_canUnrestrictedOverride;

	internal static readonly PermissionSet s_fullTrust = new PermissionSet(fUnrestricted: true);

	private const string s_str_PermissionSet = "PermissionSet";

	private const string s_str_Permission = "Permission";

	private const string s_str_IPermission = "IPermission";

	private const string s_str_Unrestricted = "Unrestricted";

	private const string s_str_PermissionUnion = "PermissionUnion";

	private const string s_str_PermissionIntersection = "PermissionIntersection";

	private const string s_str_PermissionUnrestrictedUnion = "PermissionUnrestrictedUnion";

	private const string s_str_PermissionUnrestrictedIntersection = "PermissionUnrestrictedIntersection";

	public virtual object SyncRoot => this;

	public virtual bool IsSynchronized => false;

	public virtual bool IsReadOnly => false;

	public virtual int Count
	{
		get
		{
			int num = 0;
			if (m_permSet != null)
			{
				num += m_permSet.GetCount();
			}
			return num;
		}
	}

	internal bool IgnoreTypeLoadFailures
	{
		set
		{
			m_ignoreTypeLoadFailures = value;
		}
	}

	[Conditional("_DEBUG")]
	private static void DEBUG_WRITE(string str)
	{
	}

	[Conditional("_DEBUG")]
	private static void DEBUG_COND_WRITE(bool exp, string str)
	{
	}

	[Conditional("_DEBUG")]
	private static void DEBUG_PRINTSTACK(Exception e)
	{
	}

	[OnDeserializing]
	private void OnDeserializing(StreamingContext ctx)
	{
		Reset();
	}

	[OnDeserialized]
	private void OnDeserialized(StreamingContext ctx)
	{
		if (m_serializedPermissionSet != null)
		{
			FromXml(SecurityElement.FromString(m_serializedPermissionSet));
		}
		else if (m_normalPermSet != null)
		{
			m_permSet = m_normalPermSet.SpecialUnion(m_unrestrictedPermSet);
		}
		else if (m_unrestrictedPermSet != null)
		{
			m_permSet = m_unrestrictedPermSet.SpecialUnion(m_normalPermSet);
		}
		m_serializedPermissionSet = null;
		m_normalPermSet = null;
		m_unrestrictedPermSet = null;
	}

	[OnSerializing]
	private void OnSerializing(StreamingContext ctx)
	{
		if ((ctx.State & ~(StreamingContextStates.Clone | StreamingContextStates.CrossAppDomain)) != 0)
		{
			m_serializedPermissionSet = ToString();
			if (m_permSet != null)
			{
				m_permSet.SpecialSplit(ref m_unrestrictedPermSet, ref m_normalPermSet, m_ignoreTypeLoadFailures);
			}
			m_permSetSaved = m_permSet;
			m_permSet = null;
		}
	}

	[OnSerialized]
	private void OnSerialized(StreamingContext context)
	{
		if ((context.State & ~(StreamingContextStates.Clone | StreamingContextStates.CrossAppDomain)) != 0)
		{
			m_serializedPermissionSet = null;
			m_permSet = m_permSetSaved;
			m_permSetSaved = null;
			m_unrestrictedPermSet = null;
			m_normalPermSet = null;
		}
	}

	internal PermissionSet()
	{
		Reset();
		m_Unrestricted = true;
	}

	internal PermissionSet(bool fUnrestricted)
		: this()
	{
		SetUnrestricted(fUnrestricted);
	}

	public PermissionSet(PermissionState state)
		: this()
	{
		switch (state)
		{
		case PermissionState.Unrestricted:
			SetUnrestricted(unrestricted: true);
			break;
		case PermissionState.None:
			SetUnrestricted(unrestricted: false);
			break;
		default:
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidPermissionState"));
		}
	}

	public PermissionSet(PermissionSet permSet)
		: this()
	{
		if (permSet == null)
		{
			Reset();
			return;
		}
		m_Unrestricted = permSet.m_Unrestricted;
		m_CheckedForNonCas = permSet.m_CheckedForNonCas;
		m_ContainsCas = permSet.m_ContainsCas;
		m_ContainsNonCas = permSet.m_ContainsNonCas;
		m_ignoreTypeLoadFailures = permSet.m_ignoreTypeLoadFailures;
		if (permSet.m_permSet == null)
		{
			return;
		}
		m_permSet = new TokenBasedSet(permSet.m_permSet);
		for (int i = m_permSet.GetStartingIndex(); i <= m_permSet.GetMaxUsedIndex(); i++)
		{
			object item = m_permSet.GetItem(i);
			IPermission permission = item as IPermission;
			ISecurityElementFactory securityElementFactory = item as ISecurityElementFactory;
			if (permission != null)
			{
				m_permSet.SetItem(i, permission.Copy());
			}
			else if (securityElementFactory != null)
			{
				m_permSet.SetItem(i, securityElementFactory.Copy());
			}
		}
	}

	public virtual void CopyTo(Array array, int index)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		PermissionSetEnumeratorInternal permissionSetEnumeratorInternal = new PermissionSetEnumeratorInternal(this);
		while (permissionSetEnumeratorInternal.MoveNext())
		{
			array.SetValue(permissionSetEnumeratorInternal.Current, index++);
		}
	}

	private PermissionSet(object trash, object junk)
	{
		m_Unrestricted = false;
	}

	internal void Reset()
	{
		m_Unrestricted = false;
		m_allPermissionsDecoded = true;
		m_permSet = null;
		m_ignoreTypeLoadFailures = false;
		m_CheckedForNonCas = false;
		m_ContainsCas = false;
		m_ContainsNonCas = false;
		m_permSetSaved = null;
	}

	internal void CheckSet()
	{
		if (m_permSet == null)
		{
			m_permSet = new TokenBasedSet();
		}
	}

	public bool IsEmpty()
	{
		if (m_Unrestricted)
		{
			return false;
		}
		if (m_permSet == null || m_permSet.FastIsEmpty())
		{
			return true;
		}
		PermissionSetEnumeratorInternal permissionSetEnumeratorInternal = new PermissionSetEnumeratorInternal(this);
		while (permissionSetEnumeratorInternal.MoveNext())
		{
			IPermission permission = (IPermission)permissionSetEnumeratorInternal.Current;
			if (!permission.IsSubsetOf(null))
			{
				return false;
			}
		}
		return true;
	}

	internal bool FastIsEmpty()
	{
		if (m_Unrestricted)
		{
			return false;
		}
		if (m_permSet == null || m_permSet.FastIsEmpty())
		{
			return true;
		}
		return false;
	}

	internal IPermission GetPermission(int index)
	{
		if (m_permSet == null)
		{
			return null;
		}
		object item = m_permSet.GetItem(index);
		if (item == null)
		{
			return null;
		}
		if (item is IPermission result)
		{
			return result;
		}
		IPermission permission = CreatePermission(item, index);
		if (permission == null)
		{
			return null;
		}
		return permission;
	}

	internal IPermission GetPermission(PermissionToken permToken)
	{
		if (permToken == null)
		{
			return null;
		}
		return GetPermission(permToken.m_index);
	}

	internal IPermission GetPermission(IPermission perm)
	{
		if (perm == null)
		{
			return null;
		}
		return GetPermission(PermissionToken.GetToken(perm));
	}

	public IPermission GetPermission(Type permClass)
	{
		return GetPermissionImpl(permClass);
	}

	protected virtual IPermission GetPermissionImpl(Type permClass)
	{
		if (permClass == null)
		{
			return null;
		}
		return GetPermission(PermissionToken.FindToken(permClass));
	}

	public IPermission SetPermission(IPermission perm)
	{
		return SetPermissionImpl(perm);
	}

	protected virtual IPermission SetPermissionImpl(IPermission perm)
	{
		if (perm == null)
		{
			return null;
		}
		PermissionToken token = PermissionToken.GetToken(perm);
		if ((token.m_type & PermissionTokenType.IUnrestricted) != 0)
		{
			m_Unrestricted = false;
		}
		CheckSet();
		IPermission permission = GetPermission(token.m_index);
		m_CheckedForNonCas = false;
		m_permSet.SetItem(token.m_index, perm);
		return perm;
	}

	public IPermission AddPermission(IPermission perm)
	{
		return AddPermissionImpl(perm);
	}

	protected virtual IPermission AddPermissionImpl(IPermission perm)
	{
		if (perm == null)
		{
			return null;
		}
		m_CheckedForNonCas = false;
		PermissionToken token = PermissionToken.GetToken(perm);
		if (IsUnrestricted() && (token.m_type & PermissionTokenType.IUnrestricted) != 0)
		{
			Type type = perm.GetType();
			return (IPermission)Activator.CreateInstance(type, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public, null, new object[1] { PermissionState.Unrestricted }, null);
		}
		CheckSet();
		IPermission permission = GetPermission(token.m_index);
		if (permission != null)
		{
			IPermission permission2 = permission.Union(perm);
			m_permSet.SetItem(token.m_index, permission2);
			return permission2;
		}
		m_permSet.SetItem(token.m_index, perm);
		return perm;
	}

	private IPermission RemovePermission(int index)
	{
		IPermission permission = GetPermission(index);
		if (permission == null)
		{
			return null;
		}
		return (IPermission)m_permSet.RemoveItem(index);
	}

	public IPermission RemovePermission(Type permClass)
	{
		return RemovePermissionImpl(permClass);
	}

	protected virtual IPermission RemovePermissionImpl(Type permClass)
	{
		if (permClass == null)
		{
			return null;
		}
		PermissionToken permissionToken = PermissionToken.FindToken(permClass);
		if (permissionToken == null)
		{
			return null;
		}
		return RemovePermission(permissionToken.m_index);
	}

	internal void SetUnrestricted(bool unrestricted)
	{
		m_Unrestricted = unrestricted;
		if (unrestricted)
		{
			m_permSet = null;
		}
	}

	public bool IsUnrestricted()
	{
		return m_Unrestricted;
	}

	internal bool IsSubsetOfHelper(PermissionSet target, IsSubsetOfType type, out IPermission firstPermThatFailed, bool ignoreNonCas)
	{
		firstPermThatFailed = null;
		if (target == null || target.FastIsEmpty())
		{
			if (IsEmpty())
			{
				return true;
			}
			firstPermThatFailed = GetFirstPerm();
			return false;
		}
		if (IsUnrestricted() && !target.IsUnrestricted())
		{
			return false;
		}
		if (m_permSet == null)
		{
			return true;
		}
		target.CheckSet();
		for (int i = m_permSet.GetStartingIndex(); i <= m_permSet.GetMaxUsedIndex(); i++)
		{
			IPermission permission = GetPermission(i);
			if (permission == null || permission.IsSubsetOf(null))
			{
				continue;
			}
			IPermission permission2 = target.GetPermission(i);
			if (target.m_Unrestricted)
			{
				continue;
			}
			if (!(permission is CodeAccessPermission codeAccessPermission))
			{
				if (!ignoreNonCas && !permission.IsSubsetOf(permission2))
				{
					firstPermThatFailed = permission;
					return false;
				}
				continue;
			}
			firstPermThatFailed = permission;
			switch (type)
			{
			case IsSubsetOfType.Normal:
				if (!permission.IsSubsetOf(permission2))
				{
					return false;
				}
				break;
			case IsSubsetOfType.CheckDemand:
				if (!codeAccessPermission.CheckDemand((CodeAccessPermission)permission2))
				{
					return false;
				}
				break;
			case IsSubsetOfType.CheckPermitOnly:
				if (!codeAccessPermission.CheckPermitOnly((CodeAccessPermission)permission2))
				{
					return false;
				}
				break;
			case IsSubsetOfType.CheckAssertion:
				if (!codeAccessPermission.CheckAssert((CodeAccessPermission)permission2))
				{
					return false;
				}
				break;
			}
			firstPermThatFailed = null;
		}
		return true;
	}

	public bool IsSubsetOf(PermissionSet target)
	{
		IPermission firstPermThatFailed;
		return IsSubsetOfHelper(target, IsSubsetOfType.Normal, out firstPermThatFailed, ignoreNonCas: false);
	}

	internal bool CheckDemand(PermissionSet target, out IPermission firstPermThatFailed)
	{
		return IsSubsetOfHelper(target, IsSubsetOfType.CheckDemand, out firstPermThatFailed, ignoreNonCas: true);
	}

	internal bool CheckPermitOnly(PermissionSet target, out IPermission firstPermThatFailed)
	{
		return IsSubsetOfHelper(target, IsSubsetOfType.CheckPermitOnly, out firstPermThatFailed, ignoreNonCas: true);
	}

	internal bool CheckAssertion(PermissionSet target)
	{
		IPermission firstPermThatFailed;
		return IsSubsetOfHelper(target, IsSubsetOfType.CheckAssertion, out firstPermThatFailed, ignoreNonCas: true);
	}

	internal bool CheckDeny(PermissionSet deniedSet, out IPermission firstPermThatFailed)
	{
		firstPermThatFailed = null;
		if (deniedSet == null || deniedSet.FastIsEmpty() || FastIsEmpty())
		{
			return true;
		}
		if (m_Unrestricted && deniedSet.m_Unrestricted)
		{
			return false;
		}
		PermissionSetEnumeratorInternal permissionSetEnumeratorInternal = new PermissionSetEnumeratorInternal(this);
		while (permissionSetEnumeratorInternal.MoveNext())
		{
			if (permissionSetEnumeratorInternal.Current is CodeAccessPermission codeAccessPermission && !codeAccessPermission.IsSubsetOf(null))
			{
				if (deniedSet.m_Unrestricted)
				{
					firstPermThatFailed = codeAccessPermission;
					return false;
				}
				CodeAccessPermission denied = (CodeAccessPermission)deniedSet.GetPermission(permissionSetEnumeratorInternal.GetCurrentIndex());
				if (!codeAccessPermission.CheckDeny(denied))
				{
					firstPermThatFailed = codeAccessPermission;
					return false;
				}
			}
		}
		if (m_Unrestricted)
		{
			PermissionSetEnumeratorInternal permissionSetEnumeratorInternal2 = new PermissionSetEnumeratorInternal(deniedSet);
			while (permissionSetEnumeratorInternal2.MoveNext())
			{
				if (permissionSetEnumeratorInternal2.Current is IPermission)
				{
					return false;
				}
			}
		}
		return true;
	}

	internal void CheckDecoded(CodeAccessPermission demandedPerm, PermissionToken tokenDemandedPerm)
	{
		if (!m_allPermissionsDecoded && m_permSet != null)
		{
			if (tokenDemandedPerm == null)
			{
				tokenDemandedPerm = PermissionToken.GetToken(demandedPerm);
			}
			CheckDecoded(tokenDemandedPerm.m_index);
		}
	}

	internal void CheckDecoded(int index)
	{
		if (!m_allPermissionsDecoded && m_permSet != null)
		{
			GetPermission(index);
		}
	}

	internal void CheckDecoded(PermissionSet demandedSet)
	{
		if (!m_allPermissionsDecoded && m_permSet != null)
		{
			PermissionSetEnumeratorInternal enumeratorInternal = demandedSet.GetEnumeratorInternal();
			while (enumeratorInternal.MoveNext())
			{
				CheckDecoded(enumeratorInternal.GetCurrentIndex());
			}
		}
	}

	internal static void SafeChildAdd(SecurityElement parent, ISecurityElementFactory child, bool copy)
	{
		if (child == parent)
		{
			return;
		}
		if (child.GetTag().Equals("IPermission") || child.GetTag().Equals("Permission"))
		{
			parent.AddChild(child);
		}
		else if (parent.Tag.Equals(child.GetTag()))
		{
			SecurityElement securityElement = (SecurityElement)child;
			for (int i = 0; i < securityElement.InternalChildren.Count; i++)
			{
				ISecurityElementFactory child2 = (ISecurityElementFactory)securityElement.InternalChildren[i];
				parent.AddChildNoDuplicates(child2);
			}
		}
		else
		{
			parent.AddChild((ISecurityElementFactory)(copy ? child.Copy() : child));
		}
	}

	internal void InplaceIntersect(PermissionSet other)
	{
		Exception ex = null;
		m_CheckedForNonCas = false;
		if (this == other)
		{
			return;
		}
		if (other == null || other.FastIsEmpty())
		{
			Reset();
		}
		else
		{
			if (FastIsEmpty())
			{
				return;
			}
			int num = ((m_permSet == null) ? (-1) : m_permSet.GetMaxUsedIndex());
			int num2 = ((other.m_permSet == null) ? (-1) : other.m_permSet.GetMaxUsedIndex());
			if (IsUnrestricted() && num < num2)
			{
				num = num2;
				CheckSet();
			}
			if (other.IsUnrestricted())
			{
				other.CheckSet();
			}
			for (int i = 0; i <= num; i++)
			{
				object item = m_permSet.GetItem(i);
				IPermission permission = item as IPermission;
				ISecurityElementFactory securityElementFactory = item as ISecurityElementFactory;
				object item2 = other.m_permSet.GetItem(i);
				IPermission permission2 = item2 as IPermission;
				ISecurityElementFactory securityElementFactory2 = item2 as ISecurityElementFactory;
				if (item == null && item2 == null)
				{
					continue;
				}
				if (securityElementFactory != null && securityElementFactory2 != null)
				{
					if (securityElementFactory.GetTag().Equals("PermissionIntersection") || securityElementFactory.GetTag().Equals("PermissionUnrestrictedIntersection"))
					{
						SafeChildAdd((SecurityElement)securityElementFactory, securityElementFactory2, copy: true);
						continue;
					}
					bool copy = true;
					if (IsUnrestricted())
					{
						SecurityElement securityElement = new SecurityElement("PermissionUnrestrictedUnion");
						securityElement.AddAttribute("class", securityElementFactory.Attribute("class"));
						SafeChildAdd(securityElement, securityElementFactory, copy: false);
						securityElementFactory = securityElement;
					}
					if (other.IsUnrestricted())
					{
						SecurityElement securityElement2 = new SecurityElement("PermissionUnrestrictedUnion");
						securityElement2.AddAttribute("class", securityElementFactory2.Attribute("class"));
						SafeChildAdd(securityElement2, securityElementFactory2, copy: true);
						securityElementFactory2 = securityElement2;
						copy = false;
					}
					SecurityElement securityElement3 = new SecurityElement("PermissionIntersection");
					securityElement3.AddAttribute("class", securityElementFactory.Attribute("class"));
					SafeChildAdd(securityElement3, securityElementFactory, copy: false);
					SafeChildAdd(securityElement3, securityElementFactory2, copy);
					m_permSet.SetItem(i, securityElement3);
					continue;
				}
				if (item == null)
				{
					if (!IsUnrestricted())
					{
						continue;
					}
					if (securityElementFactory2 != null)
					{
						SecurityElement securityElement4 = new SecurityElement("PermissionUnrestrictedIntersection");
						securityElement4.AddAttribute("class", securityElementFactory2.Attribute("class"));
						SafeChildAdd(securityElement4, securityElementFactory2, copy: true);
						m_permSet.SetItem(i, securityElement4);
					}
					else
					{
						PermissionToken permissionToken = (PermissionToken)PermissionToken.s_tokenSet.GetItem(i);
						if ((permissionToken.m_type & PermissionTokenType.IUnrestricted) != 0)
						{
							m_permSet.SetItem(i, permission2.Copy());
						}
					}
					continue;
				}
				if (item2 == null)
				{
					if (other.IsUnrestricted())
					{
						if (securityElementFactory != null)
						{
							SecurityElement securityElement5 = new SecurityElement("PermissionUnrestrictedIntersection");
							securityElement5.AddAttribute("class", securityElementFactory.Attribute("class"));
							SafeChildAdd(securityElement5, securityElementFactory, copy: false);
							m_permSet.SetItem(i, securityElement5);
						}
						else
						{
							PermissionToken permissionToken2 = (PermissionToken)PermissionToken.s_tokenSet.GetItem(i);
							if ((permissionToken2.m_type & PermissionTokenType.IUnrestricted) == 0)
							{
								m_permSet.SetItem(i, null);
							}
						}
					}
					else
					{
						m_permSet.SetItem(i, null);
					}
					continue;
				}
				if (securityElementFactory != null)
				{
					permission = CreatePermission(securityElementFactory, i);
				}
				if (securityElementFactory2 != null)
				{
					permission2 = other.CreatePermission(securityElementFactory2, i);
				}
				try
				{
					IPermission item3 = ((permission == null) ? permission2 : ((permission2 != null) ? permission.Intersect(permission2) : permission));
					m_permSet.SetItem(i, item3);
				}
				catch (Exception ex2)
				{
					if (ex == null)
					{
						ex = ex2;
					}
				}
			}
			m_Unrestricted = m_Unrestricted && other.m_Unrestricted;
			if (ex != null)
			{
				throw ex;
			}
		}
	}

	public PermissionSet Intersect(PermissionSet other)
	{
		if (other == null || other.FastIsEmpty() || FastIsEmpty())
		{
			return null;
		}
		int num = ((m_permSet == null) ? (-1) : m_permSet.GetMaxUsedIndex());
		int num2 = ((other.m_permSet == null) ? (-1) : other.m_permSet.GetMaxUsedIndex());
		int num3 = ((num < num2) ? num : num2);
		if (IsUnrestricted() && num3 < num2)
		{
			num3 = num2;
			CheckSet();
		}
		if (other.IsUnrestricted() && num3 < num)
		{
			num3 = num;
			other.CheckSet();
		}
		PermissionSet permissionSet = new PermissionSet(fUnrestricted: false);
		if (num3 > -1)
		{
			permissionSet.m_permSet = new TokenBasedSet();
		}
		for (int i = 0; i <= num3; i++)
		{
			object item = m_permSet.GetItem(i);
			IPermission permission = item as IPermission;
			ISecurityElementFactory securityElementFactory = item as ISecurityElementFactory;
			object item2 = other.m_permSet.GetItem(i);
			IPermission permission2 = item2 as IPermission;
			ISecurityElementFactory securityElementFactory2 = item2 as ISecurityElementFactory;
			if (item == null && item2 == null)
			{
				continue;
			}
			if (securityElementFactory != null && securityElementFactory2 != null)
			{
				bool copy = true;
				bool copy2 = true;
				SecurityElement securityElement = new SecurityElement("PermissionIntersection");
				securityElement.AddAttribute("class", securityElementFactory2.Attribute("class"));
				if (IsUnrestricted())
				{
					SecurityElement securityElement2 = new SecurityElement("PermissionUnrestrictedUnion");
					securityElement2.AddAttribute("class", securityElementFactory.Attribute("class"));
					SafeChildAdd(securityElement2, securityElementFactory, copy: true);
					copy2 = false;
					securityElementFactory = securityElement2;
				}
				if (other.IsUnrestricted())
				{
					SecurityElement securityElement3 = new SecurityElement("PermissionUnrestrictedUnion");
					securityElement3.AddAttribute("class", securityElementFactory2.Attribute("class"));
					SafeChildAdd(securityElement3, securityElementFactory2, copy: true);
					copy = false;
					securityElementFactory2 = securityElement3;
				}
				SafeChildAdd(securityElement, securityElementFactory2, copy);
				SafeChildAdd(securityElement, securityElementFactory, copy2);
				permissionSet.m_permSet.SetItem(i, securityElement);
			}
			else if (item == null)
			{
				if (!m_Unrestricted)
				{
					continue;
				}
				if (securityElementFactory2 != null)
				{
					SecurityElement securityElement4 = new SecurityElement("PermissionUnrestrictedIntersection");
					securityElement4.AddAttribute("class", securityElementFactory2.Attribute("class"));
					SafeChildAdd(securityElement4, securityElementFactory2, copy: true);
					permissionSet.m_permSet.SetItem(i, securityElement4);
				}
				else if (permission2 != null)
				{
					PermissionToken permissionToken = (PermissionToken)PermissionToken.s_tokenSet.GetItem(i);
					if ((permissionToken.m_type & PermissionTokenType.IUnrestricted) != 0)
					{
						permissionSet.m_permSet.SetItem(i, permission2.Copy());
					}
				}
			}
			else if (item2 == null)
			{
				if (!other.m_Unrestricted)
				{
					continue;
				}
				if (securityElementFactory != null)
				{
					SecurityElement securityElement5 = new SecurityElement("PermissionUnrestrictedIntersection");
					securityElement5.AddAttribute("class", securityElementFactory.Attribute("class"));
					SafeChildAdd(securityElement5, securityElementFactory, copy: true);
					permissionSet.m_permSet.SetItem(i, securityElement5);
				}
				else if (permission != null)
				{
					PermissionToken permissionToken2 = (PermissionToken)PermissionToken.s_tokenSet.GetItem(i);
					if ((permissionToken2.m_type & PermissionTokenType.IUnrestricted) != 0)
					{
						permissionSet.m_permSet.SetItem(i, permission.Copy());
					}
				}
			}
			else
			{
				if (securityElementFactory != null)
				{
					permission = CreatePermission(securityElementFactory, i);
				}
				if (securityElementFactory2 != null)
				{
					permission2 = other.CreatePermission(securityElementFactory2, i);
				}
				IPermission item3 = ((permission == null) ? permission2 : ((permission2 != null) ? permission.Intersect(permission2) : permission));
				permissionSet.m_permSet.SetItem(i, item3);
			}
		}
		permissionSet.m_Unrestricted = m_Unrestricted && other.m_Unrestricted;
		if (permissionSet.FastIsEmpty())
		{
			return null;
		}
		return permissionSet;
	}

	internal void InplaceUnion(PermissionSet other)
	{
		if (this == other || other == null || other.FastIsEmpty())
		{
			return;
		}
		m_CheckedForNonCas = false;
		m_Unrestricted = m_Unrestricted || other.m_Unrestricted;
		if (m_Unrestricted)
		{
			m_permSet = null;
			return;
		}
		int num = -1;
		if (other.m_permSet != null)
		{
			num = other.m_permSet.GetMaxUsedIndex();
			CheckSet();
		}
		Exception ex = null;
		for (int i = 0; i <= num; i++)
		{
			object item = m_permSet.GetItem(i);
			IPermission permission = item as IPermission;
			ISecurityElementFactory securityElementFactory = item as ISecurityElementFactory;
			object item2 = other.m_permSet.GetItem(i);
			IPermission permission2 = item2 as IPermission;
			ISecurityElementFactory securityElementFactory2 = item2 as ISecurityElementFactory;
			if (item == null && item2 == null)
			{
				continue;
			}
			if (securityElementFactory != null && securityElementFactory2 != null)
			{
				if (securityElementFactory.GetTag().Equals("PermissionUnion") || securityElementFactory.GetTag().Equals("PermissionUnrestrictedUnion"))
				{
					SafeChildAdd((SecurityElement)securityElementFactory, securityElementFactory2, copy: true);
					continue;
				}
				SecurityElement securityElement = ((!IsUnrestricted() && !other.IsUnrestricted()) ? new SecurityElement("PermissionUnion") : new SecurityElement("PermissionUnrestrictedUnion"));
				securityElement.AddAttribute("class", securityElementFactory.Attribute("class"));
				SafeChildAdd(securityElement, securityElementFactory, copy: false);
				SafeChildAdd(securityElement, securityElementFactory2, copy: true);
				m_permSet.SetItem(i, securityElement);
			}
			else if (item == null)
			{
				if (securityElementFactory2 != null)
				{
					m_permSet.SetItem(i, securityElementFactory2.Copy());
				}
				else if (permission2 != null)
				{
					PermissionToken permissionToken = (PermissionToken)PermissionToken.s_tokenSet.GetItem(i);
					if ((permissionToken.m_type & PermissionTokenType.IUnrestricted) == 0 || !m_Unrestricted)
					{
						m_permSet.SetItem(i, permission2.Copy());
					}
				}
			}
			else
			{
				if (item2 == null)
				{
					continue;
				}
				if (securityElementFactory != null)
				{
					permission = CreatePermission(securityElementFactory, i);
				}
				if (securityElementFactory2 != null)
				{
					permission2 = other.CreatePermission(securityElementFactory2, i);
				}
				try
				{
					IPermission item3 = ((permission == null) ? permission2 : ((permission2 != null) ? permission.Union(permission2) : permission));
					m_permSet.SetItem(i, item3);
				}
				catch (Exception ex2)
				{
					if (ex == null)
					{
						ex = ex2;
					}
				}
			}
		}
		if (ex == null)
		{
			return;
		}
		throw ex;
	}

	public PermissionSet Union(PermissionSet other)
	{
		if (other == null || other.FastIsEmpty())
		{
			return Copy();
		}
		if (FastIsEmpty())
		{
			return other.Copy();
		}
		int num = -1;
		PermissionSet permissionSet = new PermissionSet();
		permissionSet.m_Unrestricted = m_Unrestricted || other.m_Unrestricted;
		if (permissionSet.m_Unrestricted)
		{
			return permissionSet;
		}
		CheckSet();
		other.CheckSet();
		num = ((m_permSet.GetMaxUsedIndex() > other.m_permSet.GetMaxUsedIndex()) ? m_permSet.GetMaxUsedIndex() : other.m_permSet.GetMaxUsedIndex());
		permissionSet.m_permSet = new TokenBasedSet();
		for (int i = 0; i <= num; i++)
		{
			object item = m_permSet.GetItem(i);
			IPermission permission = item as IPermission;
			ISecurityElementFactory securityElementFactory = item as ISecurityElementFactory;
			object item2 = other.m_permSet.GetItem(i);
			IPermission permission2 = item2 as IPermission;
			ISecurityElementFactory securityElementFactory2 = item2 as ISecurityElementFactory;
			if (item == null && item2 == null)
			{
				continue;
			}
			if (securityElementFactory != null && securityElementFactory2 != null)
			{
				SecurityElement securityElement = ((!IsUnrestricted() && !other.IsUnrestricted()) ? new SecurityElement("PermissionUnion") : new SecurityElement("PermissionUnrestrictedUnion"));
				securityElement.AddAttribute("class", securityElementFactory.Attribute("class"));
				SafeChildAdd(securityElement, securityElementFactory, copy: true);
				SafeChildAdd(securityElement, securityElementFactory2, copy: true);
				permissionSet.m_permSet.SetItem(i, securityElement);
			}
			else if (item == null)
			{
				if (securityElementFactory2 != null)
				{
					permissionSet.m_permSet.SetItem(i, securityElementFactory2.Copy());
				}
				else if (permission2 != null)
				{
					PermissionToken permissionToken = (PermissionToken)PermissionToken.s_tokenSet.GetItem(i);
					if ((permissionToken.m_type & PermissionTokenType.IUnrestricted) == 0 || !permissionSet.m_Unrestricted)
					{
						permissionSet.m_permSet.SetItem(i, permission2.Copy());
					}
				}
			}
			else if (item2 == null)
			{
				if (securityElementFactory != null)
				{
					permissionSet.m_permSet.SetItem(i, securityElementFactory.Copy());
				}
				else if (permission != null)
				{
					PermissionToken permissionToken2 = (PermissionToken)PermissionToken.s_tokenSet.GetItem(i);
					if ((permissionToken2.m_type & PermissionTokenType.IUnrestricted) == 0 || !permissionSet.m_Unrestricted)
					{
						permissionSet.m_permSet.SetItem(i, permission.Copy());
					}
				}
			}
			else
			{
				if (securityElementFactory != null)
				{
					permission = CreatePermission(securityElementFactory, i);
				}
				if (securityElementFactory2 != null)
				{
					permission2 = other.CreatePermission(securityElementFactory2, i);
				}
				IPermission item3 = ((permission == null) ? permission2 : ((permission2 != null) ? permission.Union(permission2) : permission));
				permissionSet.m_permSet.SetItem(i, item3);
			}
		}
		return permissionSet;
	}

	internal void MergeDeniedSet(PermissionSet denied)
	{
		if (denied == null || denied.FastIsEmpty() || FastIsEmpty())
		{
			return;
		}
		m_CheckedForNonCas = false;
		if (m_permSet == null || denied.m_permSet == null)
		{
			return;
		}
		int num = ((denied.m_permSet.GetMaxUsedIndex() > m_permSet.GetMaxUsedIndex()) ? m_permSet.GetMaxUsedIndex() : denied.m_permSet.GetMaxUsedIndex());
		for (int i = 0; i <= num; i++)
		{
			if (denied.m_permSet.GetItem(i) is IPermission permission)
			{
				IPermission permission2 = m_permSet.GetItem(i) as IPermission;
				if (permission2 == null && !m_Unrestricted)
				{
					denied.m_permSet.SetItem(i, null);
				}
				else if (permission2 != null && permission != null && permission2.IsSubsetOf(permission))
				{
					m_permSet.SetItem(i, null);
					denied.m_permSet.SetItem(i, null);
				}
			}
		}
	}

	internal bool Contains(IPermission perm)
	{
		if (perm == null)
		{
			return true;
		}
		if (m_Unrestricted)
		{
			return true;
		}
		if (FastIsEmpty())
		{
			return false;
		}
		PermissionToken token = PermissionToken.GetToken(perm);
		object item = m_permSet.GetItem(token.m_index);
		if (item == null)
		{
			return perm.IsSubsetOf(null);
		}
		IPermission permission = GetPermission(token.m_index);
		if (permission != null)
		{
			return perm.IsSubsetOf(permission);
		}
		return perm.IsSubsetOf(null);
	}

	[ComVisible(false)]
	public override bool Equals(object obj)
	{
		if (!(obj is PermissionSet permissionSet))
		{
			return false;
		}
		if (m_Unrestricted != permissionSet.m_Unrestricted)
		{
			return false;
		}
		CheckSet();
		permissionSet.CheckSet();
		DecodeAllPermissions();
		permissionSet.DecodeAllPermissions();
		int num = Math.Max(m_permSet.GetMaxUsedIndex(), permissionSet.m_permSet.GetMaxUsedIndex());
		for (int i = 0; i <= num; i++)
		{
			IPermission permission = (IPermission)m_permSet.GetItem(i);
			IPermission permission2 = (IPermission)permissionSet.m_permSet.GetItem(i);
			if (permission == null && permission2 == null)
			{
				continue;
			}
			if (permission == null)
			{
				if (!permission2.IsSubsetOf(null))
				{
					return false;
				}
			}
			else if (permission2 == null)
			{
				if (!permission.IsSubsetOf(null))
				{
					return false;
				}
			}
			else if (!permission.Equals(permission2))
			{
				return false;
			}
		}
		return true;
	}

	[ComVisible(false)]
	public override int GetHashCode()
	{
		int num = (m_Unrestricted ? (-1) : 0);
		if (m_permSet != null)
		{
			DecodeAllPermissions();
			int maxUsedIndex = m_permSet.GetMaxUsedIndex();
			for (int i = m_permSet.GetStartingIndex(); i <= maxUsedIndex; i++)
			{
				IPermission permission = (IPermission)m_permSet.GetItem(i);
				if (permission != null)
				{
					num ^= permission.GetHashCode();
				}
			}
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public void Demand()
	{
		if (!FastIsEmpty())
		{
			ContainsNonCodeAccessPermissions();
			if (m_ContainsCas)
			{
				StackCrawlMark stackMark = StackCrawlMark.LookForMyCallersCaller;
				CodeAccessSecurityEngine.Check(GetCasOnlySet(), ref stackMark);
			}
			if (m_ContainsNonCas)
			{
				DemandNonCAS();
			}
		}
	}

	[SecurityCritical]
	internal void DemandNonCAS()
	{
		ContainsNonCodeAccessPermissions();
		if (!m_ContainsNonCas || m_permSet == null)
		{
			return;
		}
		CheckSet();
		for (int i = m_permSet.GetStartingIndex(); i <= m_permSet.GetMaxUsedIndex(); i++)
		{
			IPermission permission = GetPermission(i);
			if (permission != null && !(permission is CodeAccessPermission))
			{
				permission.Demand();
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public void Assert()
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		SecurityRuntime.Assert(this, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	[Obsolete("Deny is obsolete and will be removed in a future release of the .NET Framework. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	public void Deny()
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		SecurityRuntime.Deny(this, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public void PermitOnly()
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		SecurityRuntime.PermitOnly(this, ref stackMark);
	}

	internal IPermission GetFirstPerm()
	{
		IEnumerator enumerator = GetEnumerator();
		if (!enumerator.MoveNext())
		{
			return null;
		}
		return enumerator.Current as IPermission;
	}

	public virtual PermissionSet Copy()
	{
		return new PermissionSet(this);
	}

	internal PermissionSet CopyWithNoIdentityPermissions()
	{
		PermissionSet permissionSet = new PermissionSet(this);
		permissionSet.RemovePermission(typeof(GacIdentityPermission));
		permissionSet.RemovePermission(typeof(PublisherIdentityPermission));
		permissionSet.RemovePermission(typeof(StrongNameIdentityPermission));
		permissionSet.RemovePermission(typeof(UrlIdentityPermission));
		permissionSet.RemovePermission(typeof(ZoneIdentityPermission));
		return permissionSet;
	}

	public IEnumerator GetEnumerator()
	{
		return GetEnumeratorImpl();
	}

	protected virtual IEnumerator GetEnumeratorImpl()
	{
		return new PermissionSetEnumerator(this);
	}

	internal PermissionSetEnumeratorInternal GetEnumeratorInternal()
	{
		return new PermissionSetEnumeratorInternal(this);
	}

	public override string ToString()
	{
		return ToXml().ToString();
	}

	private void NormalizePermissionSet()
	{
		PermissionSet permissionSet = new PermissionSet(fUnrestricted: false);
		permissionSet.m_Unrestricted = m_Unrestricted;
		if (m_permSet != null)
		{
			for (int i = m_permSet.GetStartingIndex(); i <= m_permSet.GetMaxUsedIndex(); i++)
			{
				object item = m_permSet.GetItem(i);
				IPermission permission = item as IPermission;
				if (item is ISecurityElementFactory obj)
				{
					permission = CreatePerm(obj);
				}
				if (permission != null)
				{
					permissionSet.SetPermission(permission);
				}
			}
		}
		m_permSet = permissionSet.m_permSet;
	}

	private bool DecodeXml(byte[] data, HostProtectionResource fullTrustOnlyResources, HostProtectionResource inaccessibleResources)
	{
		if (data != null && data.Length != 0)
		{
			FromXml(new Parser(data, Tokenizer.ByteTokenEncoding.UnicodeTokens).GetTopElement());
		}
		FilterHostProtectionPermissions(fullTrustOnlyResources, inaccessibleResources);
		DecodeAllPermissions();
		return true;
	}

	private void DecodeAllPermissions()
	{
		if (m_permSet == null)
		{
			m_allPermissionsDecoded = true;
			return;
		}
		int maxUsedIndex = m_permSet.GetMaxUsedIndex();
		for (int i = 0; i <= maxUsedIndex; i++)
		{
			GetPermission(i);
		}
		m_allPermissionsDecoded = true;
	}

	internal void FilterHostProtectionPermissions(HostProtectionResource fullTrustOnly, HostProtectionResource inaccessible)
	{
		HostProtectionPermission.protectedResources = fullTrustOnly;
		HostProtectionPermission hostProtectionPermission = (HostProtectionPermission)GetPermission(HostProtectionPermission.GetTokenIndex());
		if (hostProtectionPermission != null)
		{
			HostProtectionPermission hostProtectionPermission2 = (HostProtectionPermission)hostProtectionPermission.Intersect(new HostProtectionPermission(fullTrustOnly));
			if (hostProtectionPermission2 == null)
			{
				RemovePermission(typeof(HostProtectionPermission));
			}
			else if (hostProtectionPermission2.Resources != hostProtectionPermission.Resources)
			{
				SetPermission(hostProtectionPermission2);
			}
		}
	}

	public virtual void FromXml(SecurityElement et)
	{
		FromXml(et, allowInternalOnly: false, ignoreTypeLoadFailures: false);
	}

	internal static bool IsPermissionTag(string tag, bool allowInternalOnly)
	{
		if (tag.Equals("Permission") || tag.Equals("IPermission"))
		{
			return true;
		}
		if (allowInternalOnly && (tag.Equals("PermissionUnion") || tag.Equals("PermissionIntersection") || tag.Equals("PermissionUnrestrictedIntersection") || tag.Equals("PermissionUnrestrictedUnion")))
		{
			return true;
		}
		return false;
	}

	internal virtual void FromXml(SecurityElement et, bool allowInternalOnly, bool ignoreTypeLoadFailures)
	{
		if (et == null)
		{
			throw new ArgumentNullException("et");
		}
		if (!et.Tag.Equals("PermissionSet"))
		{
			throw new ArgumentException(string.Format(null, Environment.GetResourceString("Argument_InvalidXMLElement"), "PermissionSet", GetType().FullName));
		}
		Reset();
		m_ignoreTypeLoadFailures = ignoreTypeLoadFailures;
		m_allPermissionsDecoded = false;
		m_Unrestricted = XMLUtil.IsUnrestricted(et);
		if (et.InternalChildren == null)
		{
			return;
		}
		int count = et.InternalChildren.Count;
		for (int i = 0; i < count; i++)
		{
			SecurityElement securityElement = (SecurityElement)et.Children[i];
			if (!IsPermissionTag(securityElement.Tag, allowInternalOnly))
			{
				continue;
			}
			string text = securityElement.Attribute("class");
			PermissionToken permissionToken;
			object obj;
			if (text != null)
			{
				permissionToken = PermissionToken.GetToken(text);
				if (permissionToken == null)
				{
					obj = CreatePerm(securityElement);
					if (obj != null)
					{
						permissionToken = PermissionToken.GetToken((IPermission)obj);
					}
				}
				else
				{
					obj = securityElement;
				}
			}
			else
			{
				IPermission permission = CreatePerm(securityElement);
				if (permission == null)
				{
					permissionToken = null;
					obj = null;
				}
				else
				{
					permissionToken = PermissionToken.GetToken(permission);
					obj = permission;
				}
			}
			if (permissionToken != null && obj != null)
			{
				if (m_permSet == null)
				{
					m_permSet = new TokenBasedSet();
				}
				if (m_permSet.GetItem(permissionToken.m_index) != null)
				{
					IPermission target = ((!(m_permSet.GetItem(permissionToken.m_index) is IPermission)) ? CreatePerm((SecurityElement)m_permSet.GetItem(permissionToken.m_index)) : ((IPermission)m_permSet.GetItem(permissionToken.m_index)));
					obj = ((!(obj is IPermission)) ? CreatePerm((SecurityElement)obj).Union(target) : ((IPermission)obj).Union(target));
				}
				if (m_Unrestricted && obj is IPermission)
				{
					obj = null;
				}
				m_permSet.SetItem(permissionToken.m_index, obj);
			}
		}
	}

	internal virtual void FromXml(SecurityDocument doc, int position, bool allowInternalOnly)
	{
		if (doc == null)
		{
			throw new ArgumentNullException("doc");
		}
		if (!doc.GetTagForElement(position).Equals("PermissionSet"))
		{
			throw new ArgumentException(string.Format(null, Environment.GetResourceString("Argument_InvalidXMLElement"), "PermissionSet", GetType().FullName));
		}
		Reset();
		m_allPermissionsDecoded = false;
		Exception ex = null;
		string attributeForElement = doc.GetAttributeForElement(position, "Unrestricted");
		if (attributeForElement != null)
		{
			m_Unrestricted = attributeForElement.Equals("True") || attributeForElement.Equals("true") || attributeForElement.Equals("TRUE");
		}
		else
		{
			m_Unrestricted = false;
		}
		ArrayList childrenPositionForElement = doc.GetChildrenPositionForElement(position);
		int count = childrenPositionForElement.Count;
		for (int i = 0; i < count; i++)
		{
			int position2 = (int)childrenPositionForElement[i];
			if (!IsPermissionTag(doc.GetTagForElement(position2), allowInternalOnly))
			{
				continue;
			}
			try
			{
				string attributeForElement2 = doc.GetAttributeForElement(position2, "class");
				PermissionToken permissionToken;
				object obj;
				if (attributeForElement2 != null)
				{
					permissionToken = PermissionToken.GetToken(attributeForElement2);
					if (permissionToken == null)
					{
						obj = CreatePerm(doc.GetElement(position2, bCreate: true));
						if (obj != null)
						{
							permissionToken = PermissionToken.GetToken((IPermission)obj);
						}
					}
					else
					{
						obj = ((ISecurityElementFactory)new SecurityDocumentElement(doc, position2)).CreateSecurityElement();
					}
				}
				else
				{
					IPermission permission = CreatePerm(doc.GetElement(position2, bCreate: true));
					if (permission == null)
					{
						permissionToken = null;
						obj = null;
					}
					else
					{
						permissionToken = PermissionToken.GetToken(permission);
						obj = permission;
					}
				}
				if (permissionToken != null && obj != null)
				{
					if (m_permSet == null)
					{
						m_permSet = new TokenBasedSet();
					}
					IPermission permission2 = null;
					if (m_permSet.GetItem(permissionToken.m_index) != null)
					{
						permission2 = ((!(m_permSet.GetItem(permissionToken.m_index) is IPermission)) ? CreatePerm(m_permSet.GetItem(permissionToken.m_index)) : ((IPermission)m_permSet.GetItem(permissionToken.m_index)));
					}
					if (permission2 != null)
					{
						obj = ((!(obj is IPermission)) ? permission2.Union(CreatePerm(obj)) : permission2.Union((IPermission)obj));
					}
					if (m_Unrestricted && obj is IPermission)
					{
						obj = null;
					}
					m_permSet.SetItem(permissionToken.m_index, obj);
				}
			}
			catch (Exception ex2)
			{
				if (ex == null)
				{
					ex = ex2;
				}
			}
		}
		if (ex != null)
		{
			throw ex;
		}
	}

	private IPermission CreatePerm(object obj)
	{
		return CreatePerm(obj, m_ignoreTypeLoadFailures);
	}

	internal static IPermission CreatePerm(object obj, bool ignoreTypeLoadFailures)
	{
		SecurityElement securityElement = obj as SecurityElement;
		ISecurityElementFactory securityElementFactory = obj as ISecurityElementFactory;
		if (securityElement == null && securityElementFactory != null)
		{
			securityElement = securityElementFactory.CreateSecurityElement();
		}
		IPermission permission = null;
		switch (securityElement.Tag)
		{
		case "PermissionUnion":
		{
			IEnumerator enumerator = securityElement.Children.GetEnumerator();
			while (enumerator.MoveNext())
			{
				IPermission permission5 = CreatePerm((SecurityElement)enumerator.Current, ignoreTypeLoadFailures);
				permission = ((permission == null) ? permission5 : permission.Union(permission5));
			}
			break;
		}
		case "PermissionIntersection":
		{
			IEnumerator enumerator = securityElement.Children.GetEnumerator();
			while (enumerator.MoveNext())
			{
				IPermission permission3 = CreatePerm((SecurityElement)enumerator.Current, ignoreTypeLoadFailures);
				permission = ((permission == null) ? permission3 : permission.Intersect(permission3));
				if (permission == null)
				{
					return null;
				}
			}
			break;
		}
		case "PermissionUnrestrictedUnion":
		{
			IEnumerator enumerator = securityElement.Children.GetEnumerator();
			bool flag = true;
			while (enumerator.MoveNext())
			{
				IPermission permission4 = CreatePerm((SecurityElement)enumerator.Current, ignoreTypeLoadFailures);
				if (permission4 != null)
				{
					PermissionToken token2 = PermissionToken.GetToken(permission4);
					if ((token2.m_type & PermissionTokenType.IUnrestricted) != 0)
					{
						permission = XMLUtil.CreatePermission(GetPermissionElement((SecurityElement)enumerator.Current), PermissionState.Unrestricted, ignoreTypeLoadFailures);
						flag = false;
						break;
					}
					permission = ((!flag) ? permission4.Union(permission) : permission4);
					flag = false;
				}
			}
			break;
		}
		case "PermissionUnrestrictedIntersection":
		{
			IEnumerator enumerator = securityElement.Children.GetEnumerator();
			while (enumerator.MoveNext())
			{
				IPermission permission2 = CreatePerm((SecurityElement)enumerator.Current, ignoreTypeLoadFailures);
				if (permission2 == null)
				{
					return null;
				}
				PermissionToken token = PermissionToken.GetToken(permission2);
				permission = (((token.m_type & PermissionTokenType.IUnrestricted) == 0) ? null : ((permission == null) ? permission2 : permission2.Intersect(permission)));
				if (permission == null)
				{
					return null;
				}
			}
			break;
		}
		case "IPermission":
		case "Permission":
			permission = securityElement.ToPermission(ignoreTypeLoadFailures);
			break;
		}
		return permission;
	}

	internal IPermission CreatePermission(object obj, int index)
	{
		IPermission permission = CreatePerm(obj);
		if (permission == null)
		{
			return null;
		}
		if (m_Unrestricted)
		{
			permission = null;
		}
		CheckSet();
		m_permSet.SetItem(index, permission);
		if (permission != null)
		{
			PermissionToken token = PermissionToken.GetToken(permission);
			if (token != null && token.m_index != index)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_UnableToGeneratePermissionSet"));
			}
		}
		return permission;
	}

	private static SecurityElement GetPermissionElement(SecurityElement el)
	{
		string tag = el.Tag;
		if (tag == "IPermission" || tag == "Permission")
		{
			return el;
		}
		IEnumerator enumerator = el.Children.GetEnumerator();
		if (enumerator.MoveNext())
		{
			return GetPermissionElement((SecurityElement)enumerator.Current);
		}
		return null;
	}

	internal static SecurityElement CreateEmptyPermissionSetXml()
	{
		SecurityElement securityElement = new SecurityElement("PermissionSet");
		securityElement.AddAttribute("class", "System.Security.PermissionSet");
		securityElement.AddAttribute("version", "1");
		return securityElement;
	}

	internal SecurityElement ToXml(string permName)
	{
		SecurityElement securityElement = new SecurityElement("PermissionSet");
		securityElement.AddAttribute("class", permName);
		securityElement.AddAttribute("version", "1");
		PermissionSetEnumeratorInternal permissionSetEnumeratorInternal = new PermissionSetEnumeratorInternal(this);
		if (m_Unrestricted)
		{
			securityElement.AddAttribute("Unrestricted", "true");
		}
		while (permissionSetEnumeratorInternal.MoveNext())
		{
			IPermission permission = (IPermission)permissionSetEnumeratorInternal.Current;
			if (!m_Unrestricted)
			{
				securityElement.AddChild(permission.ToXml());
			}
		}
		return securityElement;
	}

	internal SecurityElement InternalToXml()
	{
		SecurityElement securityElement = new SecurityElement("PermissionSet");
		securityElement.AddAttribute("class", GetType().FullName);
		securityElement.AddAttribute("version", "1");
		if (m_Unrestricted)
		{
			securityElement.AddAttribute("Unrestricted", "true");
		}
		if (m_permSet != null)
		{
			int maxUsedIndex = m_permSet.GetMaxUsedIndex();
			for (int i = m_permSet.GetStartingIndex(); i <= maxUsedIndex; i++)
			{
				object item = m_permSet.GetItem(i);
				if (item == null)
				{
					continue;
				}
				if (item is IPermission)
				{
					if (!m_Unrestricted)
					{
						securityElement.AddChild(((IPermission)item).ToXml());
					}
				}
				else
				{
					securityElement.AddChild((SecurityElement)item);
				}
			}
		}
		return securityElement;
	}

	public virtual SecurityElement ToXml()
	{
		return ToXml("System.Security.PermissionSet");
	}

	internal byte[] EncodeXml()
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream, Encoding.Unicode);
		binaryWriter.Write(ToXml().ToString());
		binaryWriter.Flush();
		memoryStream.Position = 2L;
		int num = (int)memoryStream.Length - 2;
		byte[] array = new byte[num];
		memoryStream.Read(array, 0, array.Length);
		return array;
	}

	[Obsolete("This method is obsolete and shoud no longer be used.")]
	public static byte[] ConvertPermissionSet(string inFormat, byte[] inData, string outFormat)
	{
		throw new NotImplementedException();
	}

	public bool ContainsNonCodeAccessPermissions()
	{
		if (m_CheckedForNonCas)
		{
			return m_ContainsNonCas;
		}
		lock (this)
		{
			if (m_CheckedForNonCas)
			{
				return m_ContainsNonCas;
			}
			m_ContainsCas = false;
			m_ContainsNonCas = false;
			if (IsUnrestricted())
			{
				m_ContainsCas = true;
			}
			if (m_permSet != null)
			{
				PermissionSetEnumeratorInternal permissionSetEnumeratorInternal = new PermissionSetEnumeratorInternal(this);
				while (permissionSetEnumeratorInternal.MoveNext() && (!m_ContainsCas || !m_ContainsNonCas))
				{
					if (permissionSetEnumeratorInternal.Current is IPermission permission)
					{
						if (permission is CodeAccessPermission)
						{
							m_ContainsCas = true;
						}
						else
						{
							m_ContainsNonCas = true;
						}
					}
				}
			}
			m_CheckedForNonCas = true;
		}
		return m_ContainsNonCas;
	}

	private PermissionSet GetCasOnlySet()
	{
		if (!m_ContainsNonCas)
		{
			return this;
		}
		if (IsUnrestricted())
		{
			return this;
		}
		PermissionSet permissionSet = new PermissionSet(fUnrestricted: false);
		PermissionSetEnumeratorInternal permissionSetEnumeratorInternal = new PermissionSetEnumeratorInternal(this);
		while (permissionSetEnumeratorInternal.MoveNext())
		{
			IPermission permission = (IPermission)permissionSetEnumeratorInternal.Current;
			if (permission is CodeAccessPermission)
			{
				permissionSet.AddPermission(permission);
			}
		}
		permissionSet.m_CheckedForNonCas = true;
		permissionSet.m_ContainsCas = !permissionSet.IsEmpty();
		permissionSet.m_ContainsNonCas = false;
		return permissionSet;
	}

	[SecurityCritical]
	private static void SetupSecurity()
	{
		PolicyLevel policyLevel = PolicyLevel.CreateAppDomainLevel();
		CodeGroup codeGroup = new UnionCodeGroup(new AllMembershipCondition(), policyLevel.GetNamedPermissionSet("Execution"));
		StrongNamePublicKeyBlob blob = new StrongNamePublicKeyBlob("002400000480000094000000060200000024000052534131000400000100010007D1FA57C4AED9F0A32E84AA0FAEFD0DE9E8FD6AEC8F87FB03766C834C99921EB23BE79AD9D5DCC1DD9AD236132102900B723CF980957FC4E177108FC607774F29E8320E92EA05ECE4E821C0A5EFE8F1645C4C0C93C1AB99285D622CAA652C1DFAD63D745D6F2DE5F17E5EAF0FC4963D261C8A12436518206DC093344D5AD293");
		CodeGroup codeGroup2 = new UnionCodeGroup(new StrongNameMembershipCondition(blob, null, null), policyLevel.GetNamedPermissionSet("FullTrust"));
		StrongNamePublicKeyBlob blob2 = new StrongNamePublicKeyBlob("00000000000000000400000000000000");
		CodeGroup codeGroup3 = new UnionCodeGroup(new StrongNameMembershipCondition(blob2, null, null), policyLevel.GetNamedPermissionSet("FullTrust"));
		CodeGroup codeGroup4 = new UnionCodeGroup(new GacMembershipCondition(), policyLevel.GetNamedPermissionSet("FullTrust"));
		codeGroup.AddChild(codeGroup2);
		codeGroup.AddChild(codeGroup3);
		codeGroup.AddChild(codeGroup4);
		policyLevel.RootCodeGroup = codeGroup;
		try
		{
			AppDomain.CurrentDomain.SetAppDomainPolicy(policyLevel);
		}
		catch (PolicyException)
		{
		}
	}

	private static void MergePermission(IPermission perm, bool separateCasFromNonCas, ref PermissionSet casPset, ref PermissionSet nonCasPset)
	{
		if (perm == null)
		{
			return;
		}
		if (!separateCasFromNonCas || perm is CodeAccessPermission)
		{
			if (casPset == null)
			{
				casPset = new PermissionSet(fUnrestricted: false);
			}
			IPermission permission = casPset.GetPermission(perm);
			IPermission target = casPset.AddPermission(perm);
			if (permission != null && !permission.IsSubsetOf(target))
			{
				throw new NotSupportedException(Environment.GetResourceString("NotSupported_DeclarativeUnion"));
			}
		}
		else
		{
			if (nonCasPset == null)
			{
				nonCasPset = new PermissionSet(fUnrestricted: false);
			}
			IPermission permission2 = nonCasPset.GetPermission(perm);
			IPermission target2 = nonCasPset.AddPermission(perm);
			if (permission2 != null && !permission2.IsSubsetOf(target2))
			{
				throw new NotSupportedException(Environment.GetResourceString("NotSupported_DeclarativeUnion"));
			}
		}
	}

	private static byte[] CreateSerialized(object[] attrs, bool serialize, ref byte[] nonCasBlob, out PermissionSet casPset, HostProtectionResource fullTrustOnlyResources, bool allowEmptyPermissionSets)
	{
		casPset = null;
		PermissionSet nonCasPset = null;
		for (int i = 0; i < attrs.Length; i++)
		{
			if (attrs[i] is PermissionSetAttribute)
			{
				PermissionSet permissionSet = ((PermissionSetAttribute)attrs[i]).CreatePermissionSet();
				if (permissionSet == null)
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_UnableToGeneratePermissionSet"));
				}
				PermissionSetEnumeratorInternal permissionSetEnumeratorInternal = new PermissionSetEnumeratorInternal(permissionSet);
				while (permissionSetEnumeratorInternal.MoveNext())
				{
					IPermission perm = (IPermission)permissionSetEnumeratorInternal.Current;
					MergePermission(perm, serialize, ref casPset, ref nonCasPset);
				}
				if (casPset == null)
				{
					casPset = new PermissionSet(fUnrestricted: false);
				}
				if (permissionSet.IsUnrestricted())
				{
					casPset.SetUnrestricted(unrestricted: true);
				}
			}
			else
			{
				IPermission perm2 = ((SecurityAttribute)attrs[i]).CreatePermission();
				MergePermission(perm2, serialize, ref casPset, ref nonCasPset);
			}
		}
		if (casPset != null)
		{
			casPset.FilterHostProtectionPermissions(fullTrustOnlyResources, HostProtectionResource.None);
			casPset.ContainsNonCodeAccessPermissions();
			if (allowEmptyPermissionSets && casPset.IsEmpty())
			{
				casPset = null;
			}
		}
		if (nonCasPset != null)
		{
			nonCasPset.FilterHostProtectionPermissions(fullTrustOnlyResources, HostProtectionResource.None);
			nonCasPset.ContainsNonCodeAccessPermissions();
			if (allowEmptyPermissionSets && nonCasPset.IsEmpty())
			{
				nonCasPset = null;
			}
		}
		byte[] result = null;
		nonCasBlob = null;
		if (serialize)
		{
			if (casPset != null)
			{
				result = casPset.EncodeXml();
			}
			if (nonCasPset != null)
			{
				nonCasBlob = nonCasPset.EncodeXml();
			}
		}
		return result;
	}

	void IDeserializationCallback.OnDeserialization(object sender)
	{
		NormalizePermissionSet();
		m_CheckedForNonCas = false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public static void RevertAssert()
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		SecurityRuntime.RevertAssert(ref stackMark);
	}

	internal static PermissionSet RemoveRefusedPermissionSet(PermissionSet assertSet, PermissionSet refusedSet, out bool bFailedToCompress)
	{
		PermissionSet permissionSet = null;
		bFailedToCompress = false;
		if (assertSet == null)
		{
			return null;
		}
		if (refusedSet != null)
		{
			if (refusedSet.IsUnrestricted())
			{
				return null;
			}
			PermissionSetEnumeratorInternal permissionSetEnumeratorInternal = new PermissionSetEnumeratorInternal(refusedSet);
			while (permissionSetEnumeratorInternal.MoveNext())
			{
				CodeAccessPermission codeAccessPermission = (CodeAccessPermission)permissionSetEnumeratorInternal.Current;
				int currentIndex = permissionSetEnumeratorInternal.GetCurrentIndex();
				if (codeAccessPermission == null)
				{
					continue;
				}
				CodeAccessPermission codeAccessPermission2 = (CodeAccessPermission)assertSet.GetPermission(currentIndex);
				try
				{
					if (codeAccessPermission.Intersect(codeAccessPermission2) != null)
					{
						if (!codeAccessPermission.Equals(codeAccessPermission2))
						{
							bFailedToCompress = true;
							return assertSet;
						}
						if (permissionSet == null)
						{
							permissionSet = assertSet.Copy();
						}
						permissionSet.RemovePermission(currentIndex);
					}
				}
				catch (ArgumentException)
				{
					if (permissionSet == null)
					{
						permissionSet = assertSet.Copy();
					}
					permissionSet.RemovePermission(currentIndex);
				}
			}
		}
		if (permissionSet != null)
		{
			return permissionSet;
		}
		return assertSet;
	}

	internal static void RemoveAssertedPermissionSet(PermissionSet demandSet, PermissionSet assertSet, out PermissionSet alteredDemandSet)
	{
		alteredDemandSet = null;
		PermissionSetEnumeratorInternal permissionSetEnumeratorInternal = new PermissionSetEnumeratorInternal(demandSet);
		while (permissionSetEnumeratorInternal.MoveNext())
		{
			CodeAccessPermission codeAccessPermission = (CodeAccessPermission)permissionSetEnumeratorInternal.Current;
			int currentIndex = permissionSetEnumeratorInternal.GetCurrentIndex();
			if (codeAccessPermission == null)
			{
				continue;
			}
			CodeAccessPermission asserted = (CodeAccessPermission)assertSet.GetPermission(currentIndex);
			try
			{
				if (codeAccessPermission.CheckAssert(asserted))
				{
					if (alteredDemandSet == null)
					{
						alteredDemandSet = demandSet.Copy();
					}
					alteredDemandSet.RemovePermission(currentIndex);
				}
			}
			catch (ArgumentException)
			{
			}
		}
	}

	internal static bool IsIntersectingAssertedPermissions(PermissionSet assertSet1, PermissionSet assertSet2)
	{
		bool result = false;
		if (assertSet1 != null && assertSet2 != null)
		{
			PermissionSetEnumeratorInternal permissionSetEnumeratorInternal = new PermissionSetEnumeratorInternal(assertSet2);
			while (permissionSetEnumeratorInternal.MoveNext())
			{
				CodeAccessPermission codeAccessPermission = (CodeAccessPermission)permissionSetEnumeratorInternal.Current;
				int currentIndex = permissionSetEnumeratorInternal.GetCurrentIndex();
				if (codeAccessPermission == null)
				{
					continue;
				}
				CodeAccessPermission codeAccessPermission2 = (CodeAccessPermission)assertSet1.GetPermission(currentIndex);
				try
				{
					if (codeAccessPermission2 != null && !codeAccessPermission2.Equals(codeAccessPermission))
					{
						result = true;
					}
				}
				catch (ArgumentException)
				{
					result = true;
				}
			}
		}
		return result;
	}
}
