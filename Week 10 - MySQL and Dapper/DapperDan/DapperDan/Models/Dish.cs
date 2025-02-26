﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DapperDan.Models
{
    /*
     id int not null auto_increment primary key, 
    `name` nvarchar(20) not null, 
    price float not null,
    isVegetarian bit, 
    isHealthy bit, 
    -- we want it to be a number from 1 to 10, we need to rember that mysql wont enforce a max 
    spiceLevel int 
     */
    public class Dish
    {
        //This tells C# that Id is our primary key in our SQL table 
        [Key]
        public int Id { get; set; }

        [MaxLength(20)]
        public string Name { get; set; }

        public float Price { get; set; }
        public bool IsHealthy { get; set; }
        public bool IsVegetarian { get; set; }

        //Range works only on number data types and allows only numbers inclusive between min/max
        [Range(1,10)]
        public int SpiceLevel { get; set; }

    }
}
