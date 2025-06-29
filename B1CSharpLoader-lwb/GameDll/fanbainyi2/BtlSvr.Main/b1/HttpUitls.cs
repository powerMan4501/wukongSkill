using System.IO;
using System.Net;
using System.Text;

namespace b1;

public class HttpUitls
{
	public static string Get(string Url)
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(Url);
		httpWebRequest.KeepAlive = false;
		httpWebRequest.Method = "GET";
		httpWebRequest.ContentType = "application/json; charset=UTF-8";
		httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip;
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		Stream responseStream = httpWebResponse.GetResponseStream();
		StreamReader streamReader = new StreamReader(responseStream, Encoding.UTF8);
		string result = streamReader.ReadToEnd();
		streamReader.Close();
		responseStream.Close();
		httpWebResponse?.Close();
		httpWebRequest?.Abort();
		return result;
	}
}
