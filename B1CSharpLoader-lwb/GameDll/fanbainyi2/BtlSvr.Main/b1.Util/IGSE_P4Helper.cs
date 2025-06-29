namespace b1.Util;

public interface IGSE_P4Helper
{
	string GetLocalVersion(string FilePath);

	bool CheckOutFile(string FilePath);

	string GetLastOutput();

	bool IsFileCheckoutByOther(string FilePath);

	bool IsP4Connecting();

	string GetWorkspaceName();

	string GetUserName();

	string GetServerName();
}
