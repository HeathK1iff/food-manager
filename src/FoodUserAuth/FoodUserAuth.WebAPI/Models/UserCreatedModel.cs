﻿using System;

namespace FoodUserAuth.WebApi.Models
{
    public class UserCreatedModel
    {
        public Guid UserId { get; set; }
        public string Password { get; set; }
    }
}
