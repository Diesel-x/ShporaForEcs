﻿using System.ComponentModel.DataAnnotations;

namespace Demo4.Data
{
    public class TypeProblem
    {

        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
