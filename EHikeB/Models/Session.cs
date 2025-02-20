﻿using EHikeB.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EHikeB.Models
{
    public enum Status
    {
        OPEN,
        CLOSED,
        TERMINATED,
        ARCHIVED
    }
    public enum Paiement
    {
        PAYPAL,
        CASH,
        PAYCONIQ
    }
    public class Session
    {
        [Key]
        public int SessionID { get; set; }
        public Customer Driver { get; set; }
        public string DriverId { get; set; }
        public Car Car { get; set; }
        public int CarID { get; set; }
        [Required]
        [Display(Name = "Departure time")]
        [DateValidationAttribute(ErrorMessage = "Select a futur date")]
        public DateTime StartTime { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        [NotMapped]
        public bool Available { get; set; }
        [Required]
        public Status Status { get; set; }
        [NotMapped]
        public List<Customer> Hikers { get; set; }
        [NotMapped]
        public string HikersNames { get {
                if(Hikers == null)
                {
                    return "";
                }
                string names = "";
                foreach (Customer customer in Hikers)
                {
                    names += customer.FirstName + " " + customer.LastName + ",";
                }
                return names;
            } }
        [Display(Name = "Paiement method")]
        public Paiement PaiementMethod { get; set; }
    }
}
