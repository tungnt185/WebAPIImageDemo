using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebAPIImageService.Controllers
{
    public class UserProfile
    {
        public string UserId { get; set; }

        public string UserAvatarBase64String { get; set; }
    }
}
