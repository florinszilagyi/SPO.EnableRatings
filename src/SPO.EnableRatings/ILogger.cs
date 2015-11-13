namespace SPO.EnableRatings
{
    public interface ILogger
    {
        void WriteInfo(string msg);
        void WriteSuccess(string msg);
        void WriteException(string msg);
        void WriteWarning(string msg);
    }
}