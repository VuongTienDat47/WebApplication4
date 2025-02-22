﻿using Newtonsoft.Json;

namespace WebApplication4.Model
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Class { get; set; }
    }
}
