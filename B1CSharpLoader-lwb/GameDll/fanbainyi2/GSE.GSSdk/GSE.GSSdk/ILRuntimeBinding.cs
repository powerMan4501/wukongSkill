using System;
using ILRuntime.Runtime.Enviorment;

namespace GSE.GSSdk;

public static class ILRuntimeBinding
{
	public static void Register(ILRuntime.Runtime.Enviorment.AppDomain appdomain)
	{
		GSSDKRpc.AuthRegisterILRuntime(appdomain);
		GSSDKRpc.DirRegisterILRuntime(appdomain);
		GSSDKRpc.VersionRegisterILRuntime(appdomain);
		GSSDKRpc.ReportRegisterILRuntime(appdomain);
		appdomain.DelegateManager.RegisterMethodDelegate<int, byte[]>();
		appdomain.DelegateManager.RegisterDelegateConvertor<HttpResponseFinishNotify>((Delegate act) => (HttpResponseFinishNotify)delegate(int httpStatus, byte[] resultBody)
		{
			((Action<int, byte[]>)act)(httpStatus, resultBody);
		});
	}
}
