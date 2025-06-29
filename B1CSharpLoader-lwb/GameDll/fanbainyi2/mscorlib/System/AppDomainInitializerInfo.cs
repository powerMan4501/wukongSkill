using System.Collections.Generic;
using System.Reflection;
using System.Security;
using System.Security.Permissions;

namespace System;

internal class AppDomainInitializerInfo
{
	internal class ItemInfo
	{
		public string TargetTypeAssembly;

		public string TargetTypeName;

		public string MethodName;
	}

	internal ItemInfo[] Info;

	internal AppDomainInitializerInfo(AppDomainInitializer init)
	{
		Info = null;
		if (init == null)
		{
			return;
		}
		List<ItemInfo> list = new List<ItemInfo>();
		List<AppDomainInitializer> list2 = new List<AppDomainInitializer> { init };
		int num = 0;
		while (list2.Count > num)
		{
			AppDomainInitializer appDomainInitializer = list2[num++];
			Delegate[] invocationList = appDomainInitializer.GetInvocationList();
			for (int i = 0; i < invocationList.Length; i++)
			{
				if (!invocationList[i].Method.IsStatic)
				{
					if (invocationList[i].Target != null)
					{
						if (!(invocationList[i].Target is AppDomainInitializer item))
						{
							throw new ArgumentException(Environment.GetResourceString("Arg_MustBeStatic"), invocationList[i].Method.ReflectedType.FullName + "::" + invocationList[i].Method.Name);
						}
						list2.Add(item);
					}
				}
				else
				{
					list.Add(new ItemInfo
					{
						TargetTypeAssembly = invocationList[i].Method.ReflectedType.Module.Assembly.FullName,
						TargetTypeName = invocationList[i].Method.ReflectedType.FullName,
						MethodName = invocationList[i].Method.Name
					});
				}
			}
		}
		Info = list.ToArray();
	}

	[SecuritySafeCritical]
	internal AppDomainInitializer Unwrap()
	{
		if (Info == null)
		{
			return null;
		}
		AppDomainInitializer appDomainInitializer = null;
		new ReflectionPermission(ReflectionPermissionFlag.MemberAccess).Assert();
		for (int i = 0; i < Info.Length; i++)
		{
			Assembly assembly = Assembly.Load(Info[i].TargetTypeAssembly);
			AppDomainInitializer appDomainInitializer2 = (AppDomainInitializer)Delegate.CreateDelegate(typeof(AppDomainInitializer), assembly.GetType(Info[i].TargetTypeName), Info[i].MethodName);
			appDomainInitializer = ((appDomainInitializer != null) ? ((AppDomainInitializer)Delegate.Combine(appDomainInitializer, appDomainInitializer2)) : appDomainInitializer2);
		}
		return appDomainInitializer;
	}
}
