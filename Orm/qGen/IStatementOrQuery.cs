﻿using System;
using System.Collections.Generic;

namespace qGen
{
        public interface IStatementOrQuery
        {
                SqlIdentifierCollection Tables { get; set; }
                Where WhereClause { get; set; }
        }
}
