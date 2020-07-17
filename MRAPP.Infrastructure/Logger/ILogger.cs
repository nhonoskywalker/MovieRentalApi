
namespace MRAPP.Insfrastructure.Logger
{
    using System;

    public interface ILogger
    {
        void WriteException(Exception e);
    }
}
