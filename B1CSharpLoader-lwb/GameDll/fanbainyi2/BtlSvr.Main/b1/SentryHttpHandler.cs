using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace b1;

public class SentryHttpHandler : HttpClientHandler
{
	internal static volatile bool IsHttpRequesting;

	internal string BackupReplaceDsnMatch = "";

	internal string BackupReplaceDsnNew = "";

	public SentryHttpHandler(string backupRelaceDsnMatch, string backupReplaceDsnNew)
	{
		BackupReplaceDsnMatch = backupRelaceDsnMatch;
		BackupReplaceDsnNew = backupReplaceDsnNew;
	}

	protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
	{
		return Task.Run(delegate
		{
			//IL_0189: Unknown result type (might be due to invalid IL or missing references)
			//IL_0190: Expected O, but got Unknown
			IsHttpRequesting = true;
			byte[] result = request.Content.ReadAsByteArrayAsync().Result;
			List<string> list = new List<string>();
			foreach (KeyValuePair<string, IEnumerable<string>> item in (HttpHeaders)request.Headers)
			{
				list.Add(item.Key + ":" + string.Join(",", item.Value.ToList()));
			}
			foreach (KeyValuePair<string, IEnumerable<string>> item2 in (HttpHeaders)request.Content.Headers)
			{
				list.Add(item2.Key + ":" + string.Join(",", item2.Value.ToList()));
			}
			bool OutIsTimeout = false;
			string text = request.RequestUri.ToString();
			HttpResponseMessage val = BGW_AsyncTaskMgr.NonGameThreadHttpRequestSync(out OutIsTimeout, text, "POST", list.ToArray(), result, 20);
			if (val == null || OutIsTimeout)
			{
				if (!string.IsNullOrEmpty(BackupReplaceDsnMatch) && text.Contains(BackupReplaceDsnMatch))
				{
					string requestUrl = text.Replace(BackupReplaceDsnMatch, BackupReplaceDsnNew);
					val = BGW_AsyncTaskMgr.NonGameThreadHttpRequestSync(out OutIsTimeout, requestUrl, "POST", list.ToArray(), result, 20);
				}
				if (val == null || OutIsTimeout)
				{
					val = new HttpResponseMessage(HttpStatusCode.RequestTimeout);
				}
			}
			IsHttpRequesting = false;
			return val;
		}, cancellationToken);
	}
}
