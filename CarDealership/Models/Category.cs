﻿using System.ComponentModel.DataAnnotations;

namespace CarDealership.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Model { get; set; }
    }
}
