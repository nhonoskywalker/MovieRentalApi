namespace MRAPP.Insfrastructure.Providers
{
    using MRAPP.Insfrastructure.Models.AuthTokens;

    public interface IJwtOptionsProvider
    {
        JwtOptions GetJwtOptions();
    }
}
