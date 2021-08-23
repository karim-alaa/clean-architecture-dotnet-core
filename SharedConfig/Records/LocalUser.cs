using SharedConfig.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedConfig.Records
{
    public record LocalUser
    (
        Guid Id,
        Guid MerchantId,
        AppLanguages Language,
        string Role = ""
    );
}
