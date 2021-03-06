﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadSystem.Domain
{
    abstract class Competition
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public bool IsActive { get; set; }

        public Competition()
        {
            Id = Guid.NewGuid();
        }
    }
}
