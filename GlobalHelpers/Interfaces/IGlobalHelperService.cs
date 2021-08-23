using SharedConfig.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHelpers.Interfaces
{
    public interface IGlobalHelperService
    {
        LocalUser GetUserData();
        Guid GetUserId();
    }
}
