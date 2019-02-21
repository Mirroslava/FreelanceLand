﻿using System.Collections.Generic;

namespace FreelanceLand.Models
{
    public class TaskStatus
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public List<Task> Tasks { get; set; }
    }
}
