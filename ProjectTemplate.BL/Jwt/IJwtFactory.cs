using ProjectTemplate.Domain.DTO.Authentication;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ProjectTemplate.BL.Jwt
{
    public interface IJwtFactory
    {
        Task<string> GenerateSAMLEncodedToken(ClaimsPrincipal claims);
        Task<string> GenerateEncodedToken(string userName, ClaimsIdentity identity);
        ClaimsIdentity GenerateClaimsIdentity(string userName, string id);
        string GenerateEncodedToken(UserDTO userClaimsDTO);
    }
}
