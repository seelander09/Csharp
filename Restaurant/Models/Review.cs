using System;
using System.ComponentModel.DataAnnotations;

namespace Restaurant.Models
{
    public class Review
    {
        [Key]
        public int ReviewsId { get; set; }
        public string ReviewerName { get; set; }
        public string RestaurantName { get; set; }
        public DateTime Date { get; set; }
        public int ReviewNum { get; set; }

    }

}

