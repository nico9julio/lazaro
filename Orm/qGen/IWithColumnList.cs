﻿using Lazaro.Orm.Data;
using System;
using System.Collections.Generic;

namespace qGen
{
        public interface IWithColumnList
        {
                SqlIdentifierCollection Columns { get; set; }
        }
}
