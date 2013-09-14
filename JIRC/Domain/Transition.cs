﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.SqlServer.Server;

namespace JIRC.Domain
{
    public class Transition
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public TransitionTo To { get; set; }
        public IEnumerable<TransitionField> Fields { get; set; }

        public class TransitionTo
        {
            public Uri Self { get; set; }
            public string Description { get; set; }
            public Uri IconUrl { get; set; }
            public string Name { get; set; }
            public int Id { get; set; }
        }

        public class TransitionField
        {
            public string Id { get; set; }
            public bool Required { get; set; }
            public string Type { get; set; }
        }
    }
}
