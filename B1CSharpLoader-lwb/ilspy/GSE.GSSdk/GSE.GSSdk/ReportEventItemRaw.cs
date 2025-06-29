using Gssdk;

namespace GSE.GSSdk;

public class ReportEventItemRaw
{
	public string service;

	public string api;

	public string meth;

	public string compress;

	public string encrypt;

	public ReportTrackReq TrackReq;

	public ReportMonitorReq MonitorReq;

	public ReportEventReq EventReq;

	public ReportUserReq UserReq;

	public ReportUploadFilesReq UpdateFilesReq;

	public ReportEventItemRaw()
	{
		service = "Report";
		api = "Monitor";
		meth = "POST";
		compress = "gzip";
		encrypt = "";
		TrackReq = null;
		MonitorReq = null;
		EventReq = null;
		UserReq = null;
	}

	public override string ToString()
	{
		return "service:" + service + ",api:" + api + ",meth:" + meth + ",compress:" + compress + ",encrypt:" + encrypt + ",req:" + TrackReq?.ToString() + ",reqMonitor:" + MonitorReq?.ToString() + ",reqEvent:" + EventReq?.ToString() + ",reqUser:" + UserReq?.ToString() + ",reqUploadFiles:" + UpdateFilesReq;
	}
}
