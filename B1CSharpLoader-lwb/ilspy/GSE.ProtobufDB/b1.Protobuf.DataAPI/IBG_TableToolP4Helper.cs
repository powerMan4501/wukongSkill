namespace b1.Protobuf.DataAPI;

public interface IBG_TableToolP4Helper
{
	bool IsUseExternalP4Config();

	bool CheckOutFile(string FilePath);

	bool MarkForAddFile(string FilePath);

	string GetLastOutput();

	bool IsFileCheckoutByOther(string FilePath);

	bool IsP4Connecting();
}
