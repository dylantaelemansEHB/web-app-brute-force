﻿using EHikeB.Attributes;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHikeB.Models
{
    public enum Energy
    {
        DIESEL,
        BENZINE,
        ELECTRICITY
    }
    public class Car
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [PersonalData]
        [Display(Name = "Brand and model of the car")]
        public string Model { get; set; }
        [Required]
        [PersonalData]
        [Display(Name = "Number of seats available (including driver)")]
        public int Seats { get; set; }
        [Required]
        [PersonalData]
        [Display(Name = "Type of Energy (diesel, benzine, electricity)")]
        public Energy Energy { get; set; }
        [Required]
        [PersonalData]
        [PlateValidationAttribute(ErrorMessage = "Naam moet in de vorm 1-aaa-111")]
        [Display(Name = "Plate number of the vehicle")]
        public string Plate { get; set; }
        public string CustomerID { get; set; }

    }
}
