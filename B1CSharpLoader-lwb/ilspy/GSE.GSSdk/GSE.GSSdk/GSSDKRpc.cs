using System;
using Gssdk;
using ILRuntime.Runtime.Enviorment;

namespace GSE.GSSdk;

public class GSSDKRpc
{
	public static bool DevReportLogEvent(ReportLogEventReq Req, OnProtobufResponse<ReportLogEventRes> OnRspCallback = null, int TimeoutSecond = 30)
	{
		return GSSDKEnv.Client.CallProtobufService("DevReport", "LogEvent", Req, OnRspCallback, TimeoutSecond) == 0;
	}

	public static bool DevReportLogEventUpload(ReportLogEventUploadReq Req, OnProtobufResponse<ReportLogEventUploadRes> OnRspCallback = null, int TimeoutSecond = 30)
	{
		return GSSDKEnv.Client.CallProtobufService("DevReport", "LogEventUpload", Req, OnRspCallback, TimeoutSecond) == 0;
	}

	public static void DevReportRegisterILRuntime(ILRuntime.Runtime.Enviorment.AppDomain appdomain)
	{
		appdomain.DelegateManager.RegisterMethodDelegate<int, string, ReportLogEventRes>();
		appdomain.DelegateManager.RegisterDelegateConvertor<OnProtobufResponse<ReportLogEventRes>>((Delegate act) => (OnProtobufResponse<ReportLogEventRes>)delegate(int Code, string ErrorMsg, ReportLogEventRes RetObj)
		{
			((Action<int, string, ReportLogEventRes>)act)(Code, ErrorMsg, RetObj);
		});
		appdomain.DelegateManager.RegisterMethodDelegate<int, string, ReportLogEventUploadRes>();
		appdomain.DelegateManager.RegisterDelegateConvertor<OnProtobufResponse<ReportLogEventUploadRes>>((Delegate act) => (OnProtobufResponse<ReportLogEventUploadRes>)delegate(int Code, string ErrorMsg, ReportLogEventUploadRes RetObj)
		{
			((Action<int, string, ReportLogEventUploadRes>)act)(Code, ErrorMsg, RetObj);
		});
	}

	public static bool ReportViewLogQuery(ReportLogQueryReq Req, OnProtobufResponse<ReportLogQueryRes> OnRspCallback = null, int TimeoutSecond = 30)
	{
		return GSSDKEnv.Client.CallProtobufService("ReportView", "LogQuery", Req, OnRspCallback, TimeoutSecond) == 0;
	}

	public static bool ReportViewLogDownload(ReportLogDownloadReq Req, OnProtobufResponse<ReportLogDownloadRes> OnRspCallback = null, int TimeoutSecond = 30)
	{
		return GSSDKEnv.Client.CallProtobufService("ReportView", "LogDownload", Req, OnRspCallback, TimeoutSecond) == 0;
	}

	public static bool ReportViewLogNotify(ReportLogNotifyReq Req, OnProtobufResponse<ReportLogNotifyRes> OnRspCallback = null, int TimeoutSecond = 30)
	{
		return GSSDKEnv.Client.CallProtobufService("ReportView", "LogNotify", Req, OnRspCallback, TimeoutSecond) == 0;
	}

	public static void ReportViewRegisterILRuntime(ILRuntime.Runtime.Enviorment.AppDomain appdomain)
	{
		appdomain.DelegateManager.RegisterMethodDelegate<int, string, ReportLogQueryRes>();
		appdomain.DelegateManager.RegisterDelegateConvertor<OnProtobufResponse<ReportLogQueryRes>>((Delegate act) => (OnProtobufResponse<ReportLogQueryRes>)delegate(int Code, string ErrorMsg, ReportLogQueryRes RetObj)
		{
			((Action<int, string, ReportLogQueryRes>)act)(Code, ErrorMsg, RetObj);
		});
		appdomain.DelegateManager.RegisterMethodDelegate<int, string, ReportLogDownloadRes>();
		appdomain.DelegateManager.RegisterDelegateConvertor<OnProtobufResponse<ReportLogDownloadRes>>((Delegate act) => (OnProtobufResponse<ReportLogDownloadRes>)delegate(int Code, string ErrorMsg, ReportLogDownloadRes RetObj)
		{
			((Action<int, string, ReportLogDownloadRes>)act)(Code, ErrorMsg, RetObj);
		});
		appdomain.DelegateManager.RegisterMethodDelegate<int, string, ReportLogNotifyRes>();
		appdomain.DelegateManager.RegisterDelegateConvertor<OnProtobufResponse<ReportLogNotifyRes>>((Delegate act) => (OnProtobufResponse<ReportLogNotifyRes>)delegate(int Code, string ErrorMsg, ReportLogNotifyRes RetObj)
		{
			((Action<int, string, ReportLogNotifyRes>)act)(Code, ErrorMsg, RetObj);
		});
	}

	public static bool DirList(DirListReq Req, OnProtobufResponse<DirListRes> OnRspCallback = null, int TimeoutSecond = 30)
	{
		return GSSDKEnv.Client.CallProtobufService("Dir", "List", Req, OnRspCallback, TimeoutSecond) == 0;
	}

	public static void DirRegisterILRuntime(ILRuntime.Runtime.Enviorment.AppDomain appdomain)
	{
		appdomain.DelegateManager.RegisterMethodDelegate<int, string, DirListRes>();
		appdomain.DelegateManager.RegisterDelegateConvertor<OnProtobufResponse<DirListRes>>((Delegate act) => (OnProtobufResponse<DirListRes>)delegate(int Code, string ErrorMsg, DirListRes RetObj)
		{
			((Action<int, string, DirListRes>)act)(Code, ErrorMsg, RetObj);
		});
	}

	public static bool DirAdminGetAll(DirGetAllReq Req, OnProtobufResponse<DirGetAllRes> OnRspCallback = null, int TimeoutSecond = 30)
	{
		return GSSDKEnv.Client.CallProtobufService("DirAdmin", "GetAll", Req, OnRspCallback, TimeoutSecond) == 0;
	}

	public static bool DirAdminGetOne(DirGetOneReq Req, OnProtobufResponse<DirGetOneRes> OnRspCallback = null, int TimeoutSecond = 30)
	{
		return GSSDKEnv.Client.CallProtobufService("DirAdmin", "GetOne", Req, OnRspCallback, TimeoutSecond) == 0;
	}

	public static bool DirAdminUpdateOne(DirUpdateOneReq Req, OnProtobufResponse<DirUpdateOneRes> OnRspCallback = null, int TimeoutSecond = 30)
	{
		return GSSDKEnv.Client.CallProtobufService("DirAdmin", "UpdateOne", Req, OnRspCallback, TimeoutSecond) == 0;
	}

	public static bool DirAdminInsertOne(DirInsertOneReq Req, OnProtobufResponse<DirInsertOneRes> OnRspCallback = null, int TimeoutSecond = 30)
	{
		return GSSDKEnv.Client.CallProtobufService("DirAdmin", "InsertOne", Req, OnRspCallback, TimeoutSecond) == 0;
	}

	public static bool DirAdminReport(DirReportReq Req, OnProtobufResponse<DirReportRes> OnRspCallback = null, int TimeoutSecond = 30)
	{
		return GSSDKEnv.Client.CallProtobufService("DirAdmin", "Report", Req, OnRspCallback, TimeoutSecond) == 0;
	}

	public static bool DirAdminLoadCfg(LoadCfgReq Req, OnProtobufResponse<LoadCfgRes> OnRspCallback = null, int TimeoutSecond = 30)
	{
		return GSSDKEnv.Client.CallProtobufService("DirAdmin", "LoadCfg", Req, OnRspCallback, TimeoutSecond) == 0;
	}

	public static bool DirAdminReloadCfg(ReloadCfgReq Req, OnProtobufResponse<ReloadCfgRes> OnRspCallback = null, int TimeoutSecond = 30)
	{
		return GSSDKEnv.Client.CallProtobufService("DirAdmin", "ReloadCfg", Req, OnRspCallback, TimeoutSecond) == 0;
	}

	public static void DirAdminRegisterILRuntime(ILRuntime.Runtime.Enviorment.AppDomain appdomain)
	{
		appdomain.DelegateManager.RegisterMethodDelegate<int, string, DirGetAllRes>();
		appdomain.DelegateManager.RegisterDelegateConvertor<OnProtobufResponse<DirGetAllRes>>((Delegate act) => (OnProtobufResponse<DirGetAllRes>)delegate(int Code, string ErrorMsg, DirGetAllRes RetObj)
		{
			((Action<int, string, DirGetAllRes>)act)(Code, ErrorMsg, RetObj);
		});
		appdomain.DelegateManager.RegisterMethodDelegate<int, string, DirGetOneRes>();
		appdomain.DelegateManager.RegisterDelegateConvertor<OnProtobufResponse<DirGetOneRes>>((Delegate act) => (OnProtobufResponse<DirGetOneRes>)delegate(int Code, string ErrorMsg, DirGetOneRes RetObj)
		{
			((Action<int, string, DirGetOneRes>)act)(Code, ErrorMsg, RetObj);
		});
		appdomain.DelegateManager.RegisterMethodDelegate<int, string, DirUpdateOneRes>();
		appdomain.DelegateManager.RegisterDelegateConvertor<OnProtobufResponse<DirUpdateOneRes>>((Delegate act) => (OnProtobufResponse<DirUpdateOneRes>)delegate(int Code, string ErrorMsg, DirUpdateOneRes RetObj)
		{
			((Action<int, string, DirUpdateOneRes>)act)(Code, ErrorMsg, RetObj);
		});
		appdomain.DelegateManager.RegisterMethodDelegate<int, string, DirInsertOneRes>();
		appdomain.DelegateManager.RegisterDelegateConvertor<OnProtobufResponse<DirInsertOneRes>>((Delegate act) => (OnProtobufResponse<DirInsertOneRes>)delegate(int Code, string ErrorMsg, DirInsertOneRes RetObj)
		{
			((Action<int, string, DirInsertOneRes>)act)(Code, ErrorMsg, RetObj);
		});
		appdomain.DelegateManager.RegisterMethodDelegate<int, string, DirReportRes>();
		appdomain.DelegateManager.RegisterDelegateConvertor<OnProtobufResponse<DirReportRes>>((Delegate act) => (OnProtobufResponse<DirReportRes>)delegate(int Code, string ErrorMsg, DirReportRes RetObj)
		{
			((Action<int, string, DirReportRes>)act)(Code, ErrorMsg, RetObj);
		});
		appdomain.DelegateManager.RegisterMethodDelegate<int, string, LoadCfgRes>();
		appdomain.DelegateManager.RegisterDelegateConvertor<OnProtobufResponse<LoadCfgRes>>((Delegate act) => (OnProtobufResponse<LoadCfgRes>)delegate(int Code, string ErrorMsg, LoadCfgRes RetObj)
		{
			((Action<int, string, LoadCfgRes>)act)(Code, ErrorMsg, RetObj);
		});
		appdomain.DelegateManager.RegisterMethodDelegate<int, string, ReloadCfgRes>();
		appdomain.DelegateManager.RegisterDelegateConvertor<OnProtobufResponse<ReloadCfgRes>>((Delegate act) => (OnProtobufResponse<ReloadCfgRes>)delegate(int Code, string ErrorMsg, ReloadCfgRes RetObj)
		{
			((Action<int, string, ReloadCfgRes>)act)(Code, ErrorMsg, RetObj);
		});
	}

	public static bool AuthLoginDir(AuthLoginDirReq Req, OnProtobufResponse<AuthLoginDirRes> OnRspCallback = null, int TimeoutSecond = 30)
	{
		return GSSDKEnv.Client.CallProtobufService("Auth", "LoginDir", Req, OnRspCallback, TimeoutSecond) == 0;
	}

	public static void AuthRegisterILRuntime(ILRuntime.Runtime.Enviorment.AppDomain appdomain)
	{
		appdomain.DelegateManager.RegisterMethodDelegate<int, string, AuthLoginDirRes>();
		appdomain.DelegateManager.RegisterDelegateConvertor<OnProtobufResponse<AuthLoginDirRes>>((Delegate act) => (OnProtobufResponse<AuthLoginDirRes>)delegate(int Code, string ErrorMsg, AuthLoginDirRes RetObj)
		{
			((Action<int, string, AuthLoginDirRes>)act)(Code, ErrorMsg, RetObj);
		});
	}

	public static bool AuthAdminGetAll(AuthGetAllReq Req, OnProtobufResponse<AuthGetAllRes> OnRspCallback = null, int TimeoutSecond = 30)
	{
		return GSSDKEnv.Client.CallProtobufService("AuthAdmin", "GetAll", Req, OnRspCallback, TimeoutSecond) == 0;
	}

	public static bool AuthAdminGetOne(AuthGetOneReq Req, OnProtobufResponse<AuthGetOneRes> OnRspCallback = null, int TimeoutSecond = 30)
	{
		return GSSDKEnv.Client.CallProtobufService("AuthAdmin", "GetOne", Req, OnRspCallback, TimeoutSecond) == 0;
	}

	public static bool AuthAdminUpdateOne(AuthUpdateOneReq Req, OnProtobufResponse<AuthUpdateOneRes> OnRspCallback = null, int TimeoutSecond = 30)
	{
		return GSSDKEnv.Client.CallProtobufService("AuthAdmin", "UpdateOne", Req, OnRspCallback, TimeoutSecond) == 0;
	}

	public static bool AuthAdminInsertOne(AuthInsertOneReq Req, OnProtobufResponse<AuthInsertOneRes> OnRspCallback = null, int TimeoutSecond = 30)
	{
		return GSSDKEnv.Client.CallProtobufService("AuthAdmin", "InsertOne", Req, OnRspCallback, TimeoutSecond) == 0;
	}

	public static bool AuthAdminGetUserInfo(AuthGetUserInfoReq Req, OnProtobufResponse<AuthGetUserInfoRes> OnRspCallback = null, int TimeoutSecond = 30)
	{
		return GSSDKEnv.Client.CallProtobufService("AuthAdmin", "GetUserInfo", Req, OnRspCallback, TimeoutSecond) == 0;
	}

	public static bool AuthAdminBind(AuthBindReq Req, OnProtobufResponse<AuthBindRes> OnRspCallback = null, int TimeoutSecond = 30)
	{
		return GSSDKEnv.Client.CallProtobufService("AuthAdmin", "Bind", Req, OnRspCallback, TimeoutSecond) == 0;
	}

	public static bool AuthAdminForceBind(AuthForceBindReq Req, OnProtobufResponse<AuthForceBindRes> OnRspCallback = null, int TimeoutSecond = 30)
	{
		return GSSDKEnv.Client.CallProtobufService("AuthAdmin", "ForceBind", Req, OnRspCallback, TimeoutSecond) == 0;
	}

	public static bool AuthAdminUnbind(AuthUnbindReq Req, OnProtobufResponse<AuthUnbindRes> OnRspCallback = null, int TimeoutSecond = 30)
	{
		return GSSDKEnv.Client.CallProtobufService("AuthAdmin", "Unbind", Req, OnRspCallback, TimeoutSecond) == 0;
	}

	public static bool AuthAdminGetCustomCfg(AuthGetCustomCfgReq Req, OnProtobufResponse<AuthGetCustomCfgRes> OnRspCallback = null, int TimeoutSecond = 30)
	{
		return GSSDKEnv.Client.CallProtobufService("AuthAdmin", "GetCustomCfg", Req, OnRspCallback, TimeoutSecond) == 0;
	}

	public static bool AuthAdminOpUserJsonConfig(AuthOpUserJsonConfigReq Req, OnProtobufResponse<AuthOpUserJsonConfigRes> OnRspCallback = null, int TimeoutSecond = 30)
	{
		return GSSDKEnv.Client.CallProtobufService("AuthAdmin", "OpUserJsonConfig", Req, OnRspCallback, TimeoutSecond) == 0;
	}

	public static bool AuthAdminSetUserJsonConfig(AuthSetUserJsonConfigReq Req, OnProtobufResponse<AuthSetUserJsonConfigRes> OnRspCallback = null, int TimeoutSecond = 30)
	{
		return GSSDKEnv.Client.CallProtobufService("AuthAdmin", "SetUserJsonConfig", Req, OnRspCallback, TimeoutSecond) == 0;
	}

	public static void AuthAdminRegisterILRuntime(ILRuntime.Runtime.Enviorment.AppDomain appdomain)
	{
		appdomain.DelegateManager.RegisterMethodDelegate<int, string, AuthGetAllRes>();
		appdomain.DelegateManager.RegisterDelegateConvertor<OnProtobufResponse<AuthGetAllRes>>((Delegate act) => (OnProtobufResponse<AuthGetAllRes>)delegate(int Code, string ErrorMsg, AuthGetAllRes RetObj)
		{
			((Action<int, string, AuthGetAllRes>)act)(Code, ErrorMsg, RetObj);
		});
		appdomain.DelegateManager.RegisterMethodDelegate<int, string, AuthGetOneRes>();
		appdomain.DelegateManager.RegisterDelegateConvertor<OnProtobufResponse<AuthGetOneRes>>((Delegate act) => (OnProtobufResponse<AuthGetOneRes>)delegate(int Code, string ErrorMsg, AuthGetOneRes RetObj)
		{
			((Action<int, string, AuthGetOneRes>)act)(Code, ErrorMsg, RetObj);
		});
		appdomain.DelegateManager.RegisterMethodDelegate<int, string, AuthUpdateOneRes>();
		appdomain.DelegateManager.RegisterDelegateConvertor<OnProtobufResponse<AuthUpdateOneRes>>((Delegate act) => (OnProtobufResponse<AuthUpdateOneRes>)delegate(int Code, string ErrorMsg, AuthUpdateOneRes RetObj)
		{
			((Action<int, string, AuthUpdateOneRes>)act)(Code, ErrorMsg, RetObj);
		});
		appdomain.DelegateManager.RegisterMethodDelegate<int, string, AuthInsertOneRes>();
		appdomain.DelegateManager.RegisterDelegateConvertor<OnProtobufResponse<AuthInsertOneRes>>((Delegate act) => (OnProtobufResponse<AuthInsertOneRes>)delegate(int Code, string ErrorMsg, AuthInsertOneRes RetObj)
		{
			((Action<int, string, AuthInsertOneRes>)act)(Code, ErrorMsg, RetObj);
		});
		appdomain.DelegateManager.RegisterMethodDelegate<int, string, AuthGetUserInfoRes>();
		appdomain.DelegateManager.RegisterDelegateConvertor<OnProtobufResponse<AuthGetUserInfoRes>>((Delegate act) => (OnProtobufResponse<AuthGetUserInfoRes>)delegate(int Code, string ErrorMsg, AuthGetUserInfoRes RetObj)
		{
			((Action<int, string, AuthGetUserInfoRes>)act)(Code, ErrorMsg, RetObj);
		});
		appdomain.DelegateManager.RegisterMethodDelegate<int, string, AuthBindRes>();
		appdomain.DelegateManager.RegisterDelegateConvertor<OnProtobufResponse<AuthBindRes>>((Delegate act) => (OnProtobufResponse<AuthBindRes>)delegate(int Code, string ErrorMsg, AuthBindRes RetObj)
		{
			((Action<int, string, AuthBindRes>)act)(Code, ErrorMsg, RetObj);
		});
		appdomain.DelegateManager.RegisterMethodDelegate<int, string, AuthForceBindRes>();
		appdomain.DelegateManager.RegisterDelegateConvertor<OnProtobufResponse<AuthForceBindRes>>((Delegate act) => (OnProtobufResponse<AuthForceBindRes>)delegate(int Code, string ErrorMsg, AuthForceBindRes RetObj)
		{
			((Action<int, string, AuthForceBindRes>)act)(Code, ErrorMsg, RetObj);
		});
		appdomain.DelegateManager.RegisterMethodDelegate<int, string, AuthUnbindRes>();
		appdomain.DelegateManager.RegisterDelegateConvertor<OnProtobufResponse<AuthUnbindRes>>((Delegate act) => (OnProtobufResponse<AuthUnbindRes>)delegate(int Code, string ErrorMsg, AuthUnbindRes RetObj)
		{
			((Action<int, string, AuthUnbindRes>)act)(Code, ErrorMsg, RetObj);
		});
		appdomain.DelegateManager.RegisterMethodDelegate<int, string, AuthGetCustomCfgRes>();
		appdomain.DelegateManager.RegisterDelegateConvertor<OnProtobufResponse<AuthGetCustomCfgRes>>((Delegate act) => (OnProtobufResponse<AuthGetCustomCfgRes>)delegate(int Code, string ErrorMsg, AuthGetCustomCfgRes RetObj)
		{
			((Action<int, string, AuthGetCustomCfgRes>)act)(Code, ErrorMsg, RetObj);
		});
		appdomain.DelegateManager.RegisterMethodDelegate<int, string, AuthOpUserJsonConfigRes>();
		appdomain.DelegateManager.RegisterDelegateConvertor<OnProtobufResponse<AuthOpUserJsonConfigRes>>((Delegate act) => (OnProtobufResponse<AuthOpUserJsonConfigRes>)delegate(int Code, string ErrorMsg, AuthOpUserJsonConfigRes RetObj)
		{
			((Action<int, string, AuthOpUserJsonConfigRes>)act)(Code, ErrorMsg, RetObj);
		});
		appdomain.DelegateManager.RegisterMethodDelegate<int, string, AuthSetUserJsonConfigRes>();
		appdomain.DelegateManager.RegisterDelegateConvertor<OnProtobufResponse<AuthSetUserJsonConfigRes>>((Delegate act) => (OnProtobufResponse<AuthSetUserJsonConfigRes>)delegate(int Code, string ErrorMsg, AuthSetUserJsonConfigRes RetObj)
		{
			((Action<int, string, AuthSetUserJsonConfigRes>)act)(Code, ErrorMsg, RetObj);
		});
	}

	public static bool ReportUser(ReportUserReq Req, OnProtobufResponse<ReportUserRes> OnRspCallback = null, int TimeoutSecond = 30)
	{
		return GSSDKEnv.Client.CallProtobufService("Report", "User", Req, OnRspCallback, TimeoutSecond) == 0;
	}

	public static bool ReportEvent(ReportEventReq Req, OnProtobufResponse<ReportEventRes> OnRspCallback = null, int TimeoutSecond = 30)
	{
		return GSSDKEnv.Client.CallProtobufService("Report", "Event", Req, OnRspCallback, TimeoutSecond) == 0;
	}

	public static bool ReportMonitor(ReportMonitorReq Req, OnProtobufResponse<ReportMonitorRes> OnRspCallback = null, int TimeoutSecond = 30)
	{
		return GSSDKEnv.Client.CallProtobufService("Report", "Monitor", Req, OnRspCallback, TimeoutSecond) == 0;
	}

	public static bool ReportTrack(ReportTrackReq Req, OnProtobufResponse<ReportTrackRes> OnRspCallback = null, int TimeoutSecond = 30)
	{
		return GSSDKEnv.Client.CallProtobufService("Report", "Track", Req, OnRspCallback, TimeoutSecond) == 0;
	}

	public static void ReportRegisterILRuntime(ILRuntime.Runtime.Enviorment.AppDomain appdomain)
	{
		appdomain.DelegateManager.RegisterMethodDelegate<int, string, ReportUserRes>();
		appdomain.DelegateManager.RegisterDelegateConvertor<OnProtobufResponse<ReportUserRes>>((Delegate act) => (OnProtobufResponse<ReportUserRes>)delegate(int Code, string ErrorMsg, ReportUserRes RetObj)
		{
			((Action<int, string, ReportUserRes>)act)(Code, ErrorMsg, RetObj);
		});
		appdomain.DelegateManager.RegisterMethodDelegate<int, string, ReportEventRes>();
		appdomain.DelegateManager.RegisterDelegateConvertor<OnProtobufResponse<ReportEventRes>>((Delegate act) => (OnProtobufResponse<ReportEventRes>)delegate(int Code, string ErrorMsg, ReportEventRes RetObj)
		{
			((Action<int, string, ReportEventRes>)act)(Code, ErrorMsg, RetObj);
		});
		appdomain.DelegateManager.RegisterMethodDelegate<int, string, ReportMonitorRes>();
		appdomain.DelegateManager.RegisterDelegateConvertor<OnProtobufResponse<ReportMonitorRes>>((Delegate act) => (OnProtobufResponse<ReportMonitorRes>)delegate(int Code, string ErrorMsg, ReportMonitorRes RetObj)
		{
			((Action<int, string, ReportMonitorRes>)act)(Code, ErrorMsg, RetObj);
		});
		appdomain.DelegateManager.RegisterMethodDelegate<int, string, ReportTrackRes>();
		appdomain.DelegateManager.RegisterDelegateConvertor<OnProtobufResponse<ReportTrackRes>>((Delegate act) => (OnProtobufResponse<ReportTrackRes>)delegate(int Code, string ErrorMsg, ReportTrackRes RetObj)
		{
			((Action<int, string, ReportTrackRes>)act)(Code, ErrorMsg, RetObj);
		});
	}

	public static bool VersionCheckConfig(VersionCheckConfigReq Req, OnProtobufResponse<VersionCheckConfigRes> OnRspCallback = null, int TimeoutSecond = 30)
	{
		return GSSDKEnv.Client.CallProtobufService("Version", "CheckConfig", Req, OnRspCallback, TimeoutSecond) == 0;
	}

	public static void VersionRegisterILRuntime(ILRuntime.Runtime.Enviorment.AppDomain appdomain)
	{
		appdomain.DelegateManager.RegisterMethodDelegate<int, string, VersionCheckConfigRes>();
		appdomain.DelegateManager.RegisterDelegateConvertor<OnProtobufResponse<VersionCheckConfigRes>>((Delegate act) => (OnProtobufResponse<VersionCheckConfigRes>)delegate(int Code, string ErrorMsg, VersionCheckConfigRes RetObj)
		{
			((Action<int, string, VersionCheckConfigRes>)act)(Code, ErrorMsg, RetObj);
		});
	}

	public static bool VersionAdminGetCustomCfg(VersionGetCustomCfgReq Req, OnProtobufResponse<VersionGetCustomCfgRes> OnRspCallback = null, int TimeoutSecond = 30)
	{
		return GSSDKEnv.Client.CallProtobufService("VersionAdmin", "GetCustomCfg", Req, OnRspCallback, TimeoutSecond) == 0;
	}

	public static bool VersionAdminOpServerJsonConfig(VersionOpServerJsonConfigReq Req, OnProtobufResponse<VersionOpServerJsonConfigRes> OnRspCallback = null, int TimeoutSecond = 30)
	{
		return GSSDKEnv.Client.CallProtobufService("VersionAdmin", "OpServerJsonConfig", Req, OnRspCallback, TimeoutSecond) == 0;
	}

	public static bool VersionAdminTestCheckConfig(VersionTestCheckConfigReq Req, OnProtobufResponse<VersionTestCheckConfigRes> OnRspCallback = null, int TimeoutSecond = 30)
	{
		return GSSDKEnv.Client.CallProtobufService("VersionAdmin", "TestCheckConfig", Req, OnRspCallback, TimeoutSecond) == 0;
	}

	public static bool VersionAdminSetServerJsonConfig(VersionSetServerJsonConfigReq Req, OnProtobufResponse<VersionSetServerJsonConfigRes> OnRspCallback = null, int TimeoutSecond = 30)
	{
		return GSSDKEnv.Client.CallProtobufService("VersionAdmin", "SetServerJsonConfig", Req, OnRspCallback, TimeoutSecond) == 0;
	}

	public static void VersionAdminRegisterILRuntime(ILRuntime.Runtime.Enviorment.AppDomain appdomain)
	{
		appdomain.DelegateManager.RegisterMethodDelegate<int, string, VersionGetCustomCfgRes>();
		appdomain.DelegateManager.RegisterDelegateConvertor<OnProtobufResponse<VersionGetCustomCfgRes>>((Delegate act) => (OnProtobufResponse<VersionGetCustomCfgRes>)delegate(int Code, string ErrorMsg, VersionGetCustomCfgRes RetObj)
		{
			((Action<int, string, VersionGetCustomCfgRes>)act)(Code, ErrorMsg, RetObj);
		});
		appdomain.DelegateManager.RegisterMethodDelegate<int, string, VersionOpServerJsonConfigRes>();
		appdomain.DelegateManager.RegisterDelegateConvertor<OnProtobufResponse<VersionOpServerJsonConfigRes>>((Delegate act) => (OnProtobufResponse<VersionOpServerJsonConfigRes>)delegate(int Code, string ErrorMsg, VersionOpServerJsonConfigRes RetObj)
		{
			((Action<int, string, VersionOpServerJsonConfigRes>)act)(Code, ErrorMsg, RetObj);
		});
		appdomain.DelegateManager.RegisterMethodDelegate<int, string, VersionTestCheckConfigRes>();
		appdomain.DelegateManager.RegisterDelegateConvertor<OnProtobufResponse<VersionTestCheckConfigRes>>((Delegate act) => (OnProtobufResponse<VersionTestCheckConfigRes>)delegate(int Code, string ErrorMsg, VersionTestCheckConfigRes RetObj)
		{
			((Action<int, string, VersionTestCheckConfigRes>)act)(Code, ErrorMsg, RetObj);
		});
		appdomain.DelegateManager.RegisterMethodDelegate<int, string, VersionSetServerJsonConfigRes>();
		appdomain.DelegateManager.RegisterDelegateConvertor<OnProtobufResponse<VersionSetServerJsonConfigRes>>((Delegate act) => (OnProtobufResponse<VersionSetServerJsonConfigRes>)delegate(int Code, string ErrorMsg, VersionSetServerJsonConfigRes RetObj)
		{
			((Action<int, string, VersionSetServerJsonConfigRes>)act)(Code, ErrorMsg, RetObj);
		});
	}
}
