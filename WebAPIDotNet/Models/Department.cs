﻿using System.Text.Json.Serialization;

namespace WebAPIDotNet.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? ManagerName { get; set; }
        
        [JsonIgnore]
        public List<Employee>? Emps { get; set; }
    }
}
