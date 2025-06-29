namespace GSE.GSSdk;

public delegate bool HttpRequestDelegate(string url, string method, string[] headers, byte[] body, HttpResponseFinishNotify onRspNotify, int reqTimeoutSecond = 10);
