﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Common
{
    public interface IBaseEntity
    {
        public string Id { get; set; }
    }
}
